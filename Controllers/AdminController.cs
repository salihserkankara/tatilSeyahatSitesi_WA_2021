using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProject.Models.Siniflar;

namespace TravelTripProject.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Context c = new Context();
        [Authorize]
        public ActionResult Index()
        {
            var degerler = c.Blogs.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult YeniBlog()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniBlog(Blog p)
        {
            c.Blogs.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult BlogSil(int id)
        {
            var b = c.Blogs.Find(id);
            c.Blogs.Remove(b);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        [Authorize]
        public ActionResult BlogGetir(int id)
        {
            var bl = c.Blogs.Find(id);
            return View("BlogGetir", bl);
        }
        public ActionResult BlogGuncelle(Blog b)
        {
            var blg = c.Blogs.Find(b.ID);
            blg.Baslik = b.Baslik;
            blg.Tarih = b.Tarih;
            blg.BlogImage = b.BlogImage;
            blg.Aciklama = b.Aciklama;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult BlogDetaylar(int id)
        {
            var bd = c.Blogs.Find(id);
            return View("BlogDetaylar", bd);
        }
        [Authorize]
        public ActionResult YorumListesi()
        {
            var yorumlar = c.Yorumlars.ToList();
            return View(yorumlar);
        }
        public ActionResult YorumSil(int id)
        {
            var v = c.Yorumlars.Find(id);
            c.Yorumlars.Remove(v);
            c.SaveChanges();
            return RedirectToAction("YorumListesi");
        }
        [Authorize]
        public ActionResult YorumGetir(int id)
        {
            var yr = c.Yorumlars.Find(id);
            return View("YorumGetir", yr);
        }
        public ActionResult YorumGuncelle(Yorumlar y)
        {
            var yrm = c.Yorumlars.Find(y.ID);
            yrm.KullaniciAdi = y.KullaniciAdi;
            yrm.Mail = y.Mail;
            yrm.Yorum = y.Yorum;
            c.SaveChanges();
            return RedirectToAction("YorumListesi");
        }
        public ActionResult Iletisim()
        {
            var iletisim = c.Iletisims.ToList();
            return View(iletisim);
        }
        public ActionResult Hakkimizda()
        {
            var hakkimizda = c.Hakkimizdas.ToList();
            return View(hakkimizda);
        }
        [Authorize]
        public ActionResult HakkimizdaGetir(int id)
        {
            var h = c.Hakkimizdas.Find(id);
            return View("HakkimizdaGetir", h);
        }
        public ActionResult HakkimizdaGuncelle(Hakkimizda h)
        {
            var hk = c.Hakkimizdas.Find(h.ID);
            hk.FotoUrl = h.FotoUrl;
            hk.Aciklama = h.Aciklama;
            c.SaveChanges();
            return RedirectToAction("Hakkimizda");
        }
        [Authorize]
        public ActionResult Restoranlar()
        {
            var degerler = c.Restoranlars.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult YeniRestoran()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniRestoran(Restoranlar r)
        {
            c.Restoranlars.Add(r);
            c.SaveChanges();
            return RedirectToAction("Restoranlar");
        }
        [Authorize]
        public ActionResult RestoranGetir(int id)
        {
            var r = c.Restoranlars.Find(id);
            return View("RestoranGetir", r);
        }
        public ActionResult RestoranGuncelle(Restoranlar r)
        {
            var re = c.Restoranlars.Find(r.ID);
            re.Baslik = r.Baslik;
            re.Aciklama = r.Aciklama;
            re.Image = r.Image;
            c.SaveChanges();
            return RedirectToAction("Restoranlar");
        }
        public ActionResult RestoranDetaylar(int id)
        {
            var rd = c.Restoranlars.Find(id);
            return View("RestoranDetaylar", rd);
        }
        public ActionResult RestoranSil(int id)
        {
            var rs = c.Restoranlars.Find(id);
            c.Restoranlars.Remove(rs);
            c.SaveChanges();
            return RedirectToAction("Restoranlar");
        }
    }
}