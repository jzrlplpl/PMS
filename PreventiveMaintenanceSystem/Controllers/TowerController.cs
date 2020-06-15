using PreventiveMaintenanceSystem.Manager;
using PreventiveMaintenanceSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PreventiveMaintenanceSystem.Controllers
{
    public class TowerController : Controller
    {
        private TowerManager towerManager = new TowerManager();
        // GET: Inspector
        [HttpGet]
        public ActionResult Index()
        {
            var model = towerManager.TowerGetAll();
            return View(model);
        }
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(Tower tower)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    towerManager.Insert(tower);
                }
            }
            catch (Exception e)
            {
                TempData["Error"] = e.Message;
            }
            return Redirect("/tower");
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var model = towerManager.TowerGetByID(id);
            return View(model);
        }
        [HttpPost]
        public ActionResult Edit(Tower tower)
        {
            towerManager.Update(tower);
            return Redirect("/tower");
        }
    }
}