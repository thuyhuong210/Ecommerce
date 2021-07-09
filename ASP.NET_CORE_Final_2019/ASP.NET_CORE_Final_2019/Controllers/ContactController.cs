﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ASP.NET_CORE_Final_2019.Models;
using ASP.NET_CORE_Final_2019.Services;
using MimeKit;
using MailKit.Net.Smtp;

namespace ASP.NET_CORE_Final_2019.Controllers
{
    public class ContactController : ChaController
    {
        public ContactController(IFSanpham _IFSanpham, IFDonHang _IFDonhang) : base(_IFSanpham, _IFDonhang)
        { }

        [Route("Contact")]
        [HttpGet]
        public IActionResult Index()
        {
            getSession();
            return View();
        }

        [Route("Contact")]
        [HttpPost]
        public IActionResult Index(Contact _Contact)
        {
            try
            {
                var message = new MimeMessage();
                message.From.Add(new MailboxAddress("Thiên Ân", "ndsg1964@gmail.com"));
                message.To.Add(new MailboxAddress("Khoa Bá", "ohwhynotme1999@gmail.com"));
                message.Subject = "Thông báo từ khách hàng có Email: " + _Contact.Email;
                message.Body = new TextPart("plain")
                {
                    Text = _Contact.ChuDe + " | Tên người gửi: " + _Contact.Ten + " | Nội dung: " + _Contact.NoiDung
                };
                using (var client = new SmtpClient())
                {
                    client.Connect("smtp.gmail.com", 587, false);
                    client.Authenticate("ndsg1964@gmail.com", "Thienanbao0399");
                    client.Send(message);
                    client.Disconnect(true);
                }
            } catch (Exception ex)
            {
                ModelState.Clear();
                ViewBag.Message = $" Oops! We have a problem here {ex.Message}";
            }

            return RedirectToAction("Index", "Home", new { area = ""});
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}