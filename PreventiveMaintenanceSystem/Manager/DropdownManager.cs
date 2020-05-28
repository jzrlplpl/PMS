using PreventiveMaintenanceSystem.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PreventiveMaintenanceSystem.Manager
{
    public class DropdownManager : BaseManager
    {
        public List<SelectListItem> TowerList()
        {
            List<SelectListItem> result = new List<SelectListItem>();
            Dictionary<string, string> x = new Dictionary<string, string>();
            x.Add("One West", "One West");
            x.Add("Two West", "Two West");
            foreach (var item in x)
            {
                result.Add(new SelectListItem() { Value = item.Key.ToString(), Text = item.Value });
            }
            return result;
        }
        public List<SelectListItem> StatusTypeList()
        {
            List<SelectListItem> result = new List<SelectListItem>();
            Dictionary<string, string> x = new Dictionary<string, string>();
            x.Add("Good", "Good");
            x.Add("No Good", "No Good");
            foreach (var item in x)
            {
                result.Add(new SelectListItem() { Value = item.Key.ToString(), Text = item.Value });
            }
            return result;
        }

    }
}