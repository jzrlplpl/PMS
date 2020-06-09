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
    public class SounderCheckManager : BaseManager
    {
        private SounderCheckRepository sounderCheckRepository = new SounderCheckRepository();
        public List<SounderCheck> SounderChecksGetAll()
        {
            List<SounderCheck> record = cacheManager.cache["usp_SounderCheck_GetAll"] as List<SounderCheck>;
            if (record == null)
            {
                record = sounderCheckRepository.GetSounderChecks();
                cacheManager.cache.Set("usp_SounderCheck_GetAll", record, cacheManager.cacheExpiry);
            }
            return record;
        }
        public Result Insert(SounderCheck parameter)
        {
            Result result = sounderCheckRepository.Insert(parameter);
            if (result.IsSuccess)
            {
                cacheManager.ClearCache("usp_SounderCheck_GetAll");
            }
            return result;
        }
    }
}