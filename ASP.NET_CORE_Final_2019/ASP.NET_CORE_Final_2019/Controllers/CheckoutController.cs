using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP.NET_CORE_Final_2019.Services;
using ASP.NET_CORE_Final_2019.Models;
using Microsoft.AspNetCore.Mvc;
using ASP.NET_CORE_Final_2019.Areas.Services;
using Microsoft.AspNetCore.Http;
using MimeKit;
using MailKit.Net.Smtp;
using System.Diagnostics;
using ASP.NET_CORE_Final_2019.PayPalHelper;
using Microsoft.Extensions.Configuration;
using PayPal.v1.Payments;
using System.Net.Http;
using System.IO;
using Newtonsoft.Json.Linq;
using ASP.NET_CORE_Final_2019.API_NganLuong;

namespace ASP.NET_CORE_Final_2019.Controllers
{
    public class CheckoutController : ChaController
    {
        public readonly IKhachHang _KhachHang;
        //public readonly IFDonHang _Donhang;
        public readonly IDonHang _DonhangAdmin;
        public IConfiguration _configuration { get; }
        public readonly string AuthyAPIKey;
        public float USDtoVND;
        public CheckoutController(IFSanpham _IFSanpham, IFDonHang _IFDonhang, IKhachHang _IKhachHang, IConfiguration _Iconfiguration, IDonHang _IDonhang) : base(_IFSanpham, _IFDonhang)
        {
            _KhachHang = _IKhachHang;
            //_Donhang = _IFDonhang;
            _configuration = _Iconfiguration;
            _DonhangAdmin = _IDonhang;
            AuthyAPIKey = _configuration["API:AuthyAPIKey"];
        }

        [Route("Checkout")]
        [HttpGet]
        public IActionResult Checkout()
        {
            getSession();

            var flag = false;
            var array = _Donhang.getChiTietDonHang(HttpContext.Session.GetInt32("Id"));

            // Check neu giỏ hàng Trống
            foreach(Chitietdonhang item in _Donhang.getChiTietDonHang(HttpContext.Session.GetInt32("Id")) )
            {
                if (item.SoLuong != 0)
                {
                    flag = true;
                    break;
                }
                Console.WriteLine(flag);
            }
            Debug.WriteLine(flag);
            if (!flag)
            {
                return RedirectToAction("Index", "Cart", new { area = "" });
            }
            return View();
        }
        [Route("CheckCode")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CheckCode(CheckoutSum sum,String bankcode)
        {
            //test send SMS code
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("X-Authy-API-Key", AuthyAPIKey);

                var requestContent = new FormUrlEncodedContent(new[] {
                new KeyValuePair<string, string>("via", "sms"),
                new KeyValuePair<string, string>("phone_number", sum.khachhang.Sdt.ToString()),
                new KeyValuePair<string, string>("locale", "vi"),
                new KeyValuePair<string, string>("code_length", "6"),
                new KeyValuePair<string, string>("country_code", "84"),
            });

                HttpResponseMessage response = client.PostAsync(
                    "https://api.authy.com/protected/json/phones/verification/start",
                    requestContent).Result;

                HttpContent responseContent = response.Content;
                Console.WriteLine(responseContent.ReadAsStringAsync().Result);
            }
            ViewBag.bankcode = bankcode;
            return View(sum);
        }

        [Route("VerifyAndCheckout")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> VerifyAndCheckout(CheckoutSum sum, String code, String bankcode)
        {

            //convert currency
            var currencyConvertAPI = _configuration["currencycovertApi:API"];
            var cli = new HttpClient();
            var fullApi = "https://free.currconv.com/api/v7/convert?q=USD_VND&compact=ultra&apiKey=" + currencyConvertAPI;
            HttpResponseMessage getConttent = await cli.GetAsync(fullApi);
            HttpContent respon = getConttent.Content;
            
            Debug.WriteLine(currencyConvertAPI + "cec");

            using (var read = new StreamReader(await respon.ReadAsStreamAsync()))
            {
                var resss = await read.ReadToEndAsync();
                Debug.WriteLine(resss + "cecc");
                resss = @"[" + resss + "]";
                dynamic ketqua = JArray.Parse(resss);
                dynamic kq = ketqua[0];
                string convert = kq.USD_VND;
                ViewBag.tyso = convert;
                USDtoVND = float.Parse(convert);
                Debug.WriteLine(USDtoVND);
            }

            //end convert

            //---------------------- Mở ra khi  Hoàn Tất Hết

            var clientt = new HttpClient();

            // Add authentication header
            clientt.DefaultRequestHeaders.Add("X-Authy-API-Key", AuthyAPIKey);

            // https://api.authy.com/protected/json/phones/verification/check?phone_number=$USER_PHONE&country_code=$USER_COUNTRY&verification_code=$VERIFY_CODE
            var api = "https://api.authy.com/protected/json/phones/verification/check?phone_number=" + sum.khachhang.Sdt + "&country_code=84&verification_code=" + code;
            HttpResponseMessage response = await clientt.GetAsync(api);

            // Get the response content.
            HttpContent responseContent = response.Content;

            // Get the stream of the content.
            using (var reader = new StreamReader(await responseContent.ReadAsStreamAsync()))
            {
                // Write the output.

                var result = await reader.ReadToEndAsync();
                // parse json string to array
                result = @"[" + result + "]";

                dynamic blogPosts = JArray.Parse(result);

                dynamic blogPost = blogPosts[0];
                string isTrue = blogPost.success;
                //string isTrue = "True"; // dong lai khi hoan tat
                                    // -- End Mở ra
            if (isTrue == "True") // Code = Code : Success : True
                {
                    if (_KhachHang.GetKhachHang(sum.khachhang.Email) != null)
                    {
                        _KhachHang.UpdateKhachHang(sum.khachhang);
                    }
                    _KhachHang.AddKhachHang(sum.khachhang, HttpContext.Session.GetInt32("Id"));
                    _Donhang.UpdatePhuongThuc(HttpContext.Session.GetInt32("Id"), sum.PhuongThucThanhToan);
                    _Donhang.UpdateDescription(HttpContext.Session.GetInt32("Id"), "Chưa Thanh Toán");

                    if (sum.PhuongThucThanhToan == "Thanh Toán Khi Nhận Hàng")
                    {
                            return View("../Checkout/Success");
                    } // end thanh toan khi nhan hang
                    else if (sum.PhuongThucThanhToan == "PayPal")
                    {
                        Double summ = 0;
                        var PayPalAPI = new PayPalAPI(_configuration);
                        var itemList = new ItemList()
                        {
                            Items = new List<Item>()
                        };
                        IEnumerable<Chitietdonhang> a = _DonhangAdmin.GetChitietdonhang((int)HttpContext.Session.GetInt32("Id"));
                        foreach (var item in a)
                        {
                            Decimal soluong = 0;
                            string des = "";
                            Sanpham sp = _Sanpham.GetSanPham(item.IdSanPham);
                            if (sp.IdLoaiSanPham == 4)
                            {
                                soluong = (Decimal)item.SoLuong;
                                des = "unit: 1 cup";
                            }
                            else
                            {
                                soluong = (Decimal)item.SoLuong / 100;
                                des = "Unit: 100 gam";
                            }
                            itemList.Items.Add(new Item()
                            {
                                Name = sp.Ten,
                                Currency = "USD",
                                Price = Math.Round(((Decimal)item.Gia / (Decimal)USDtoVND / soluong), 2).ToString(),
                                Quantity = soluong.ToString(),
                                Description = des
                            });

                        }
                        foreach (var item in itemList.Items)
                        {
                            Debug.WriteLine(item.Name + " " + item.Quantity + " " + item.Price); // debug log
                            summ = summ + Math.Round((double.Parse(item.Price) * double.Parse(item.Quantity)), 2);
                        }
                        string URL = await PayPalAPI.getRedirectURLtoPayPal(summ, "USD", itemList);
                        return Redirect(URL);
                     }
                    else if (sum.PhuongThucThanhToan == "Ví Ngân Lượng" || sum.PhuongThucThanhToan=="Thẻ VISA" || sum.PhuongThucThanhToan=="Thẻ ATM")
                    {
                        Double summ = 0;
                        string payment_method = "";
                        string str_bankcode = bankcode;
                        IEnumerable<Chitietdonhang> a = _DonhangAdmin.GetChitietdonhang((int)HttpContext.Session.GetInt32("Id"));
                        if(sum.PhuongThucThanhToan=="Ví Ngân Lượng")
                        {
                            payment_method = "nl";
                        }
                        else if(sum.PhuongThucThanhToan =="Thẻ VISA")
                        {
                            payment_method = "VISA";
                        }
                        else if(sum.PhuongThucThanhToan=="Thẻ ATM")
                        {
                            payment_method = "ATM_ONLINE";
                        }
                        else
                        {
                            payment_method = "ATM_ONLINE";
                        }

                        
                        RequestInfo info = new RequestInfo();
                        foreach (var item in a)
                        {

                            //Decimal soluong = 0;
                            //string des = "";
                            //Sanpham sp = _Sanpham.GetSanPham(item.IdSanPham);
                            //if (sp.IdLoaiSanPham == 4)
                            //{
                            //    soluong = (Decimal)item.SoLuong;
                            //    des = "unit: 1 cup";
                            //}
                            //else
                            //{
                            //    soluong = (Decimal)item.SoLuong / 100;
                            //    des = "Unit: 100 gam";
                            //}
                            summ = summ + ((double)item.Gia);
                        }
                        info.Merchant_id = _configuration["NganLuong:mechant_id"];
                        info.Merchant_password = _configuration["NganLuong:mechant_pass"];
                        info.Receiver_email = _configuration["NganLuong:seller_email"];



                        info.cur_code = "vnd";
                        info.bank_code = str_bankcode;

                        info.Order_code = HttpContext.Session.GetInt32("Id").ToString();
                        info.Total_amount = summ.ToString();
                        info.order_description = "Đây Là Đơn Hàng Từ "+ sum.khachhang.Ten+" có email là "+sum.khachhang.Email;
                        info.return_url = _configuration["NganLuong:returnURL"];
                        info.cancel_url = _configuration["NganLuong:cancelURL"];

                        info.Buyer_fullname = sum.khachhang.Ten;
                        info.Buyer_email = sum.khachhang.Email;
                        info.Buyer_mobile = sum.khachhang.Sdt;
                        info.Total_item = a.Count().ToString();

                        APICheckoutV3 objNLChecout = new APICheckoutV3(_configuration);
                        ResponseInfo resultt = objNLChecout.GetUrlCheckout(info, payment_method);

                        if (resultt.Error_code == "00")
                        {
                            return Redirect(resultt.Checkout_url);
                        }
                        else
                        {
                            Debug.WriteLine(resultt.Description);
                            return RedirectToAction("Fail","Checkout", new { message = resultt.Description });
                        }
                    }
                    else
                        {
                            return RedirectToAction("Fail");
                        }
                    }
                else // Code != Code : Success : False
                {
                    return RedirectToAction("Fail", "Checkout", new { message = "Sai Mã Xác Nhận!!" });
                }
            }
            //mở ra khi xong het


        }
		[Route("Checkout/Success")]
        public async Task<IActionResult> Success([FromQuery(Name = "paymentId" )] string paymentId, [FromQuery(Name = "PayerID" )] string payerId )
        {
			var PayPalAPI = new PayPalAPI(_configuration);
            try
            {
                var result = await PayPalAPI.executedPayment(paymentId, payerId);
            }
            catch
            {
                return View();
            }
            _Donhang.UpdateDescription(HttpContext.Session.GetInt32("Id"), "Đã Thanh toán");
            return View();
		}

        [Route("Checkout/Fail")]
        public IActionResult Fail(string message)
        {
            ViewBag.message = message;
            return View();
        }

        [Route("Checkout/AllSuccess")]
        public IActionResult allSuccess()
        {
            return View("../Checkout/Success");
        }
    }
}