using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PreventiveMaintenanceSystem.Models.Entities
{
    public class PanelCheck
    {
        public int ID { get; set; }
        [Display(Name = "Panel #")]
        public int Number { get; set; }
        public string Tower { get; set; }
        [Display(Name = "Panel Sounder Output")]
        public bool SounderOutput { get; set; }
        [Display(Name = "Battery Connector")]
        public bool BatteryConnector { get; set; }
        [Display(Name = "Battery Voltage")]
        public decimal BatteryVoltage { get; set; }
        [Display(Name = "Inspection Date")]
        public DateTime InspectionDate { get; set; }
        public string Inspector { get; set; }
    }
}