using PreventiveMaintenanceSystem.Manager;
using PreventiveMaintenanceSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace PreventiveMaintenanceSystem.Controllers
{
    [System.Web.Mvc.SessionState(System.Web.SessionState.SessionStateBehavior.ReadOnly)]
    [AllowAnonymous]
    public class InspectorAPIController : ApiController
    {
        // GET: InspectorAPI
        [Route("~/api/inspectors")]
        [HttpGet]
        public IEnumerable<Inspector> GetInspectorForDropdown()
        {
            InspectorManager inspectorManager = new InspectorManager();
            return inspectorManager.InspectorGetAll();
        }
    }
}
