using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PreventiveMaintenanceSystem.Models.Entities
{
    public class SounderCheck
    {
        public int ID { get; set; }
        public string Level { get; set; }
        public string Tower { get; set; }
        public bool MCP1 { get; set; }
        public bool MCP2 { get; set; }
        public bool Sounder1 { get; set; }
        public bool Sounder2 { get; set; }
        public string Remarks { get; set; }
        [Display(Name = "Inspection Date")]
        public DateTime InspectionDate { get; set; }
        public string Inspector { get; set; }
    }
}