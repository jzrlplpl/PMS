using PreventiveMaintenanceSystem.Manager;
using PreventiveMaintenanceSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PreventiveMaintenanceSystem.Controllers
{
    public class InspectorController : Controller
    {
        private InspectorManager inspectorManager = new InspectorManager();
        // GET: Inspector
        [HttpGet]
        public ActionResult Index()
        {
            var model = inspectorManager.InspectorGetAll();
            return View(model);
        }
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(Inspector inspector)
        {
            try
            {
                if (ModelState.IsValid) 
                {
                    inspectorManager.Insert(inspector);
                }
            }
            catch (Exception e)
            {
                TempData["Error"] = e.Message;
            }
            return Redirect("/inspector/index");
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var model = inspectorManager.InspectorGetByID(id);
            return View(model);
        }
        [HttpPost]
        public ActionResult Edit(Inspector inspector)
        {
            inspectorManager.Update(inspector);
            return Redirect("/inspector");
        }
    }
}