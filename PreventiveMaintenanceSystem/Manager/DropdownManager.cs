using PreventiveMaintenanceSystem.Managers;
using PreventiveMaintenanceSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PreventiveMaintenanceSystem.Manager
{
    public class DropdownManager : BaseManager
    {
        private TowerManager towerManager = new TowerManager();
        //public List<SelectListItem> TowerList()
        //{
        //    List<SelectListItem> result = new List<SelectListItem>();
        //    Dictionary<string, string> x = new Dictionary<string, string>();
        //    x.Add("One West", "One West");
        //    x.Add("Two West", "Two West");
        //    foreach (var item in x)
        //    {
        //        result.Add(new SelectListItem() { Value = item.Key.ToString(), Text = item.Value });
        //    }
        //    return result;
        //}
        public List<SelectListItem> StatusTypeList()
        {
            List<SelectListItem> result = new List<SelectListItem>();
            Dictionary<string, string> x = new Dictionary<string, string>();
            x.Add("", "-Select Status-");
            x.Add("Good", "Good");
            x.Add("No Good", "No Good");
            foreach (var item in x)
            {
                result.Add(new SelectListItem() { Value = item.Key.ToString(), Text = item.Value });
            }
            return result;
        }
        public List<SelectListItem> TowerList()
        {
            List<SelectListItem> towers = cacheManager.cache["usp_Tower_GetAll"] as List<SelectListItem>;
            if (towers == null)
            {
                towers = new List<SelectListItem>();
                foreach (Tower tower in towerManager.TowerGetAll().OrderBy(c => c.Name))
                {
                    SelectListItem x = new SelectListItem();
                    towers.Add(new SelectListItem() { Value = tower.Name, Text = tower.Name });
                }
                cacheManager.cache.Set("usp_Tower_GetAll", towers, cacheManager.cacheExpiry);
            }
            return towers;
        }
    }
}