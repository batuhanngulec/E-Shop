using DataAccessLayer.Context;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace E_Shop.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        DataContext db = new DataContext();
        public ActionResult Update()
        {
            var username = (string)Session["Mail"];
            var degerler = db.Users.FirstOrDefault(x => x.Email == username);
            return View(degerler);
                   
        }
        [HttpPost]
        public ActionResult Update(User data)
        {
            var username = (string)Session["Mail"];
            var user = db.Users.Where(x => x.Email == username).FirstOrDefault();
            user.Name = data.Name;
            user.SurName = data.SurName;
            user.Email = data.Email;
            user.Password = data.Password;
            user.RePassword = data.RePassword;
            user.UserName = data.UserName;
            db.SaveChanges();
            return RedirectToAction("Index", "Home");

        }

        public ActionResult PasswordReset()
        {
            return View();
        }

        [HttpPost]
        public ActionResult PasswordReset(string eposta)
        {
            var mail = db.Users.Where(x => x.Email == eposta).SingleOrDefault();
            if (mail !=null)
            {
                Random rnd = new Random();
                int yenisifre = rnd.Next();
                User sifre = new User();
                mail.Password = (Convert.ToString(yenisifre));
                db.SaveChanges();
                WebMail.SmtpServer = "smtp.gmail.com";
                WebMail.EnableSsl = true;
                WebMail.UserName = "batuhan.gulec170@gmail.com";
                WebMail.Password = "kurumsall12345";
                WebMail.SmtpPort = 587;
                WebMail.Send(eposta, "Giris Sifreniz", "Sifreniz" + yenisifre);
                ViewBag.uyari = "Sifreniz Basariyla gonderilmistir";
            }
            else
            {
                ViewBag.uyari = "Hata olustu tekrar deneyiniz";
            }
            return View();
        }
    }
}