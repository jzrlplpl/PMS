using PreventiveMaintenanceSystem.Managers;
using PreventiveMaintenanceSystem.Models.Entities;
using PreventiveMaintenanceSystem.Models.Parameters;
using PreventiveMaintenanceSystem.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PreventiveMaintenanceSystem.Manager
{
    public class PanelCheckManager : BaseManager
    {
        private PanelCheckRepository panelCheckRepository = new PanelCheckRepository();

        public List<PanelCheck> PanelChecksGetAll()
        {
            List<PanelCheck> record = cacheManager.cache["usp_PanelCheck_GetAll"] as List<PanelCheck>;
            if (record == null)
            {
                record = panelCheckRepository.GetPanelChecks();
                cacheManager.cache.Set("usp_PanelCheck_GetAll", record, cacheManager.cacheExpiry);
            }
            return record;
        }
        public PanelCheck PanelCheckGetByID(int id)
        {
            return PanelChecksGetAll().FirstOrDefault(e => e.ID.Equals(id));
        }
        public Result Insert(PanelCheck parameter)
        {
            Result result = panelCheckRepository.Insert(parameter);
            if (result.IsSuccess)
            {
                cacheManager.ClearCache("usp_PanelCheck_GetAll");
            }
            return result;
        }
        public Result Update(PanelCheck parameter)
        {
            Result result = panelCheckRepository.Update(parameter);
            if (result.IsSuccess)
            {
                cacheManager.ClearCache("usp_PanelCheck_GetAll");
            }
            return result;
        }
    }
}