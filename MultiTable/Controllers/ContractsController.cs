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
    public class ContractsController : Controller
    {
        private ContractRepository _contractRepository;

        public ContractsController()
        {
            _contractRepository = new ContractRepository();
        }

        // GET: Cars
        public ActionResult Index()
        {
            return View(_contractRepository.GetWhere(x => x.ID > 0)); //Get all recods that have IDs
        }

        // GET: Cars/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
               return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Contract contract = _contractRepository.GetWhere(x => x.ID == id.Value).FirstOrDefault();
            if (contract == null)
            {
                return HttpNotFound();
            }
            return View(contract);
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
        public ActionResult Create([Bind(Include = "ID,Brand,Model,Year")] Contract contract)
        {
            if (ModelState.IsValid)
            {
                _contractRepository.Create(contract);
                return RedirectToAction("Index");
            }

            return View(contract);
        }

        // GET: Cars/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Contract contract = _contractRepository.GetWhere(x => x.ID == id.Value).FirstOrDefault();
            if (contract == null)
            {
                return HttpNotFound();
            }
            return View(contract);
        }

        // POST: Cars/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Brand,Model,Year")] Contract contract)
        {
            if (ModelState.IsValid)
            {
                _contractRepository.Update(contract);
                return RedirectToAction("Index");
            }
            return View(contract);
        }

        // GET: Cars/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Contract contract = _contractRepository.GetWhere(x => x.ID == id.Value).FirstOrDefault();
            if (contract == null)
            {
                return HttpNotFound();
            }
            return View(contract);
        }

        // POST: Cars/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Contract contract = _contractRepository.GetWhere(x => x.ID == id).FirstOrDefault();
            _contractRepository.Delete(contract);
            return RedirectToAction("Index");
        }
    }
}
