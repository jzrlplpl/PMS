using PreventiveMaintenanceSystem.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PreventiveMaintenanceSystem.Models.ViewModels
{
    public class PanelCheckViewModel : PanelCheck
    {
        public List<Inspector> Inspectors { get; set; }
    }
}