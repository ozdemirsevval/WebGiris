﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NorthwindEntities.SqlServerEntities;

namespace WebMVC.Controllers
{
    public class ShipperController : Controller
    {
        private readonly SqlNorthwinContext db;

        public ShipperController(SqlNorthwinContext db)
        {
            this.db = db;
        }
        // GET: ShipperController
        public ActionResult Index()
        {
            var result = db.Shippers.ToList();
            return View(result);
        }

        // GET: ShipperController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ShipperController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ShipperController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ShipperController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ShipperController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ShipperController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ShipperController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
