using PreventiveMaintenanceSystem.Manager;
using PreventiveMaintenanceSystem.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PreventiveMaintenanceSystem.Controllers
{
    public class FDASController : Controller
    {
        private PanelCheckManager panelCheckManager = new PanelCheckManager();
        private SounderCheckManager sounderCheckManager = new SounderCheckManager();
        // GET: FDAS
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult SounderIndex()
        {
            return View(sounderCheckManager.SounderChecksGetAll());
        }
        [HttpGet]
        public ActionResult SounderCheck()
        {
            return View();
        }

        // Homepage of Panel Check
        public ActionResult PanelIndex()
        {
            return View(panelCheckManager.PanelChecksGetAll());
        }

        [HttpGet]
        public ActionResult PanelCheck()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult PanelCheck(PanelCheck panelCheck)
        {
            var defaultDate = DateTime.Now;
            panelCheck.InspectionDate = defaultDate;
            panelCheckManager.Insert(panelCheck);
            return Redirect("/fdas/panelindex");
        }
        [HttpGet]
        public ActionResult EditPanelCheck(int id)
        {
            var model = panelCheckManager.PanelCheckGetByID(id);
            model.InspectionDate = DateTime.Now;
            return View(model);
        }

        [HttpPost]
        public ActionResult EditPanelCheck(PanelCheck panelCheck)
        {
            panelCheckManager.Update(panelCheck);
            return Redirect("/fdas/panelindex");
        }
    }
}