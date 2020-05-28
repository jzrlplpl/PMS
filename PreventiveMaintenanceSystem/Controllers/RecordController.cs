using PreventiveMaintenanceSystem.Manager;
using PreventiveMaintenanceSystem.Models.Entities;
using PreventiveMaintenanceSystem.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PreventiveMaintenanceSystem.Controllers
{
    public class RecordController : Controller
    {
        private RecordManager recordManager = new RecordManager();
        private DropdownManager dropdownManager = new DropdownManager();

        public void ReadyContextForView()
        {
            RecordViewModel recordViewModel = new RecordViewModel();
            recordViewModel.StatusType = dropdownManager.StatusTypeList();
            recordViewModel.TowerList = dropdownManager.TowerList();
            ViewBag.Context = recordViewModel;
        }

        // GET: Record
        public ActionResult Index()
        {
            var model = recordManager.GetAllRecord();
            return View(model);
        }

        // GET: Record/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Record/Create
        public ActionResult Add()
        {
            ReadyContextForView();
            return View();
        }

        // POST: Record/Create
        [HttpPost]
        public ActionResult Add(Record record)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    recordManager.Insert(record);
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Record/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Record/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Record/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Record/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
