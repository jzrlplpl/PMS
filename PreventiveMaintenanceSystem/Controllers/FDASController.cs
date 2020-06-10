using Newtonsoft.Json.Linq;
using PreventiveMaintenanceSystem.Manager;
using PreventiveMaintenanceSystem.Models.Entities;
using PreventiveMaintenanceSystem.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PreventiveMaintenanceSystem.Controllers
{
    public class FDASController : Controller
    {
        private PanelCheckManager panelCheckManager = new PanelCheckManager();
        private SounderCheckManager sounderCheckManager = new SounderCheckManager();
        private InspectorManager inspectorManager = new InspectorManager();
        // GET: FDAS
        public ActionResult Index()
        {
            return View();
        }
        public void Floors(int bldg)
        {
            List<string> floors = new List<string>();
            floors.Add("Basement");
            floors.Add("Ground Floor");
            floors.Add("2nd Floor");
            floors.Add("3rd Floor");
            floors.Add("4th Floor");
            floors.Add("5th Floor");
            floors.Add("6th Floor");
            floors.Add("7th Floor");
            floors.Add("8th Floor");
            floors.Add("9th Floor");
            floors.Add("10th Floor");
            floors.Add("11th Floor");
            floors.Add("12th Floor");
            if (bldg == 0) // For One West
            {
                floors.RemoveAt(12);
                ViewBag.FloorList = floors;
            }
            if (bldg == 1) // For Two West Tower
            {
                ViewBag.FloorList = floors;
            }
        }
        public ActionResult SounderIndex()
        {
            return View(sounderCheckManager.SounderChecksGetAll());
        }
        //[HttpGet]
        //public ActionResult SounderCheck()
        //{
        //    return View();
        //}
        // Sounder Insert for One West Tower 
        [HttpGet]
        public ActionResult OneWest()
        {
            Floors(0);
            return View();
        }
        public ActionResult TwoWest()
        {
            Floors(1);
            return View();
        }
        // Sounder Insert
        [HttpPost]
        public ActionResult SounderCheck(List<SounderCheck> sounderChecks)
        {
            foreach (var item in sounderChecks)
            {
                var date = DateTime.Now;
                item.InspectionDate = date;
                sounderCheckManager.Insert(item);
            }
            return Redirect("/fdas/sounderindex");
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

        [HttpPost]
        public DataTable AddToDataTable()
        {
            DataTable dt = new DataTable();
            dt.Clear();
            return dt;
        }
    }
}