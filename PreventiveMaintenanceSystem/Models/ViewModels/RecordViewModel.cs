using PreventiveMaintenanceSystem.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PreventiveMaintenanceSystem.Models.ViewModels
{
    public class RecordViewModel : Record
    {
        public List<SelectListItem> StatusType { get; set; }
        public List<SelectListItem> TowerList { get; set; }
    }
}