using DOAN_CLOUND.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DOAN_CLOUND.Controllers
{
    public class KhachHangController : Controller
    {
        private readonly KhachHangRepository _khachHangRepo = new KhachHangRepository();

        // GET: KhachHang
        public ActionResult Index()
        {
            var khachHangList = _khachHangRepo.GetAll();
            return View(khachHangList);
        }

        // GET: KhachHang/Details/5
        public ActionResult Details(string id)
        {
            var khachHang = _khachHangRepo.GetById(id);
            if (khachHang == null)
            {
                return HttpNotFound();
            }
            return View(khachHang);
        }

        // GET: KhachHang/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: KhachHang/Create
        [HttpPost]
        public ActionResult Create(KhachHang khachHang)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _khachHangRepo.Add(khachHang);
                    return RedirectToAction("Index");
                }
                return View(khachHang);
            }
            catch
            {
                return View();
            }
        }

        // GET: KhachHang/Edit/5
        public ActionResult Edit(string id)
        {
            var khachHang = _khachHangRepo.GetById(id);
            if (khachHang == null)
            {
                return HttpNotFound();
            }
            return View(khachHang);
        }

        // POST: KhachHang/Edit/5
        [HttpPost]
        public ActionResult Edit(string id, KhachHang khachHang)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _khachHangRepo.Update(id, khachHang);
                    return RedirectToAction("Index");
                }
                return View(khachHang);
            }
            catch
            {
                return View();
            }
        }

        // GET: KhachHang/Delete/5
        public ActionResult Delete(string id)
        {
            var khachHang = _khachHangRepo.GetById(id);
            if (khachHang == null)
            {
                return HttpNotFound();
            }
            return View(khachHang);
        }

        // POST: KhachHang/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(string id)
        {
            try
            {
                _khachHangRepo.Delete(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}