using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Su_Dagitim_1_0.Models;
using System.Data;

using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data.Entity;
using System.Net;
using System.Collections.Specialized;
using System.Text;
namespace Su_Dagitim_1_0.Controllers
{
    public class AdminController : Controller
    {
        
        public string ss;
       private MySqlConnection connection;
      
       Su_ManagerEntities1 db = new Su_ManagerEntities1();

        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (Session["KullaniciAdi"] == null)
            {
                filterContext.Result = Redirect("/Login/Index");
            }
            base.OnActionExecuting(filterContext);
        }
          public ActionResult Index()
        {
            return View();
        }
          public ActionResult Calisan()
          {
              return View();
          }
          public class CustomerModel
          {
              public int ID { get; set; }
              public DateTime alis_tarihi { get; set; }
              public DateTime teslim_tarihi { get; set; }

              public int adet { get; set; }
              public int urunID { get; set; }
              public int kullaniciID { get; set; }
              public string adres { get; set; }
          }
          public ActionResult Siparis()
          {
              //MySqlConnection con = new MySqlConnection("server=localhost; user id=root;password='123'; database=suapii;");
              //MySqlCommand cmd = new MySqlCommand("INSERT INTO `siparis` (`ID`, `alis_tarihi`, `teslim_tarihi`, `adet`, `urunID`, `kullaniciID`, `adres`) VALUES (NULL, '2017/4/4', '2017/2/2', '22', '1', '1', 'ggggg')");
             
              //MySqlCommand cm = new MySqlCommand("select * from siparis",con);
              //try
              //{
              //            con.Open();
              //      MySqlDataAdapter adtr = new MySqlDataAdapter(cm);
              //      DataSet ds = new DataSet();
              //      adtr.Fill(ds);
              //            con.Close();
              //}
              //catch (Exception ex)
              //{
                  
              //    throw;
              //}
      
                return View();
              
          }

        

      
          public ActionResult CalisanKayit(Calisan form)
          {
              db.Calisan.Add(form);
              db.SaveChanges();
              return Json(true, JsonRequestBehavior.AllowGet);
          }
          public ActionResult Calisansil(int calisanid)
          {
              var sil = db.Calisan.Where(w => w.ID == calisanid).FirstOrDefault();
              db.Calisan.Remove(sil);
              db.SaveChanges();
              return Json(true, JsonRequestBehavior.AllowGet);

          }
          public ActionResult GetCalisan()
          {
              var liste = db.Calisan.ToList();

              return Json(liste, JsonRequestBehavior.AllowGet);
          }
          public ActionResult GetCalisma()
          {
              var list = db.Calisma.ToList();
              return Json(list,JsonRequestBehavior.AllowGet);
          }

              public ActionResult GetSaat()
          {
              var liste = db.Calisma.ToList();
              return Json(liste, JsonRequestBehavior.AllowGet);
          }
       
              [HttpPost]
              public ActionResult asdasd(Calisan data)
              {
                  if (ModelState.IsValid)
                  {
                      db.Entry(data).State = EntityState.Modified;
                      db.SaveChanges();
                      return Json("");
                  }
                  return View(data);
              }
    }
    
}
