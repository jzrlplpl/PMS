using PreventiveMaintenanceSystem.Manager;
using PreventiveMaintenanceSystem.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PreventiveMaintenanceSystem.Controllers.API
{
    public class FDASController : ControllerBase
    {
        [HttpPost]
        public ActionResult SoundCheckInsertByBatch(IEnumerable<SounderCheck> parameters)
        {
            SounderCheckManager manager = new SounderCheckManager();
            if (parameters.Count() > 0)
            {
                foreach (var item in parameters)
                {
                    manager.Insert(item);
                }
            }
            return Redirect("/fdas/sounderindex");
        }
    }
}