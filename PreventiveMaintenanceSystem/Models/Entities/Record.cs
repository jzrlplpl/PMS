using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PreventiveMaintenanceSystem.Models.Entities
{
    public class Record
    {
        public int ID { get; set; }
        public string Building { get; set; }
        public string Floor { get; set; }
        public string MCP_1 { get; set; }
        public string MCP_2 { get; set; }
        public string Sounder_1 { get; set; }
        public string Sounder_2 { get; set; }
        public DateTime DateChecked { get; set; }
        public string Remarks { get; set; }
        public bool IsDeleted { get; set; }
    }
}