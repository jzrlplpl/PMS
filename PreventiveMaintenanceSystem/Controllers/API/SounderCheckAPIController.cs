using PreventiveMaintenanceSystem.Manager;
using PreventiveMaintenanceSystem.Models;
using PreventiveMaintenanceSystem.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Results;

namespace PreventiveMaintenanceSystem.Controllers.API
{
    public class SounderCheckAPIController : ApiController
    {
        // GET: SounderCheckAPI
        [Route("~/api/soundercheck")]
        [HttpGet]
        public IEnumerable<SounderCheck> GetSounderCheck()
        {
            SounderCheckManager manager = new SounderCheckManager();
            var data = manager.SounderChecksGetAll();
            return data;
        }
    }
}