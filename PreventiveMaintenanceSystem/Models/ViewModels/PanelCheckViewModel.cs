using PreventiveMaintenanceSystem.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PreventiveMaintenanceSystem.Models.ViewModels
{
    public class PanelCheckViewModel : PanelCheck
    {
        public List<SelectListItem> ListOfTowers { get; set; }
    }
}