using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Su_Dagitim_1_0.Models;
namespace Su_Dagitim_1_0.Controllers
{
    public class GirisController : Controller
    {
       //
        Su_ManagerEntities1 db = new Su_ManagerEntities1();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult LoginnKontrol(string emaill, string sifre)
        {
            var list1 = db.Calisan.Where(w => w.Eposta == emaill && w.Sifre == sifre).ToList();
            if (list1.Count == 1)
            {
                Session["KullaniciAdi"] = list1[0].Ad;
                Session["KullaniciSoyAdi"] = list1[0].Soyad;
                Session["KullaniciTel"] = list1[0].Telefon;
                Session["Kullaniciadres"] = list1[0].Adres;
                Session["Kullaniciid"] = list1[0].ID;
                if (Convert.ToInt16(list1[0].Yetki) == 1)
                {
                    return RedirectToAction("Index", "Admin");
                }
                else
                {
                    return RedirectToAction("Index", "Kullanici");
                }

            }
            else
            {
                var list2 = db.Musteri.Where(w => w.Eposta == emaill && w.Parola == sifre).ToList();
                if (list2.Count == 1)
                {
                    return RedirectToAction("Index", "Musteri");
                }
                return RedirectToAction("Index", "Giris");
            }

        }
        public ActionResult LogOut()
        {
            Session.Abandon();
            return RedirectToAction("Index", "Giris"); // RedirectToAction("ActionResult", "Controller"); // 
        }
        public ActionResult Kayit(string Ad, string Soyad, string Adres, string Telefon, string sifre, string email)
        {
            var a = db.Calisan.Where(q => q.Eposta == email);
            if (a != null)
            {
                Calisan ne = new Calisan();
                ne.Ad = Ad;
                ne.Soyad = Soyad;
                ne.Adres = Adres;
                ne.Eposta = email;
                ne.Sifre = sifre;
                long ss = long.Parse(Telefon);
                ne.Telefon = ss;
                ne.Yetki = false;
                db.Calisan.Add(ne);
                db.SaveChanges();
                return RedirectToAction("Index", "Giris");
            }
            else
                return Json("alert('email kullanıldı')", JsonRequestBehavior.AllowGet);
        } 
    }
    
}
