using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MultiTable.Models;
using MultiTable.Repositories;

namespace MultiTable.Controllers
{
    public class DriversController : Controller
    {
        private DriverRepository _driverRepository;

        public DriversController()
        {
            _driverRepository = new DriverRepository();
        }

        // GET: Cars
        public ActionResult Index()
        {
            return View(_driverRepository.GetWhere(x => x.ID > 0)); //Get all recods that have IDs
        }

        // GET: Cars/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Driver driver = _driverRepository.GetWhere(x => x.ID == id.Value).FirstOrDefault();
            if (driver == null)
            {
                return HttpNotFound();
            }
            return View(driver);
        }

        // GET: Cars/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cars/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Brand,Model,Year")] Driver driver)
        {
            if (ModelState.IsValid)
            {
                _driverRepository.Create(driver);
                return RedirectToAction("Index");
            }

            return View(driver);
        }

        // GET: Cars/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Driver driver = _driverRepository.GetWhere(x => x.ID == id.Value).FirstOrDefault();
            if (driver == null)
            {
                return HttpNotFound();
            }
            return View(driver);
        }

        // POST: Cars/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Brand,Model,Year")] Driver driver)
        {
            if (ModelState.IsValid)
            {
                _driverRepository.Update(driver);
                return RedirectToAction("Index");
            }
            return View(driver);
        }

        // GET: Cars/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Driver driver = _driverRepository.GetWhere(x => x.ID == id.Value).FirstOrDefault();
            if (driver == null)
            {
                return HttpNotFound();
            }
            return View(driver);
        }

        // POST: Cars/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Driver driver = _driverRepository.GetWhere(x => x.ID == id).FirstOrDefault();
            _driverRepository.Delete(driver);
            return RedirectToAction("Index");
        }
    }
}
