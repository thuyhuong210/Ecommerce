﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ASP.NET_CORE_Final_2019.Areas.Services;
using ASP.NET_CORE_Final_2019.Models;
using ClosedXML.Excel;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_CORE_Final_2019.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class KhachHangController : Controller
    {
        public readonly IKhachHang IKhachHang;
        public readonly IDonHang IDonHang;
        public KhachHangController(IKhachHang _IKhachHang,IDonHang _IDonHang)
        {
            IKhachHang = _IKhachHang;
            IDonHang = _IDonHang;
        }
        [Route("admin/[controller]")]
        public IActionResult Index()
        {
            ViewBag.DonHang = IDonHang.GetDonhangs;
            return View(IKhachHang.GetKhachhangs);
        }
        [HttpGet]
        public IActionResult Edit(string Email)
        {
            return View(IKhachHang.GetKhachHang(Email));
        }

        [HttpPost]
        public IActionResult Edit(Khachhang _KhachHang)
        {
            IKhachHang.UpdateKhachHang(_KhachHang);
            return RedirectToAction("Index");
        }
        public IActionResult ExportCSV()
        {
            var builder = new StringBuilder();
            IEnumerable<Khachhang> listemail = IKhachHang.GetKhachhangs;
            foreach(var item in listemail)
            {
                builder.AppendLine($"{item.Email}");
            }
            return File(Encoding.UTF8.GetBytes(builder.ToString()), "text/csv", "DanhSachEmailKhachHang.csv");
        }
        public IActionResult ExportXlsx()
        {
            IEnumerable<Khachhang> listemail = IKhachHang.GetKhachhangs;
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Emails");
                var row = 1;
                foreach (var item in listemail)
                {
                    worksheet.Cell(row,1).Value = item.Email;
                    row++;
                }
                using( var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "DanhSachEmailKhachHang.xlsx");
                }
            }
        }
    }
}