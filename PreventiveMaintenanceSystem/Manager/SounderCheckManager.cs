using PreventiveMaintenanceSystem.Managers;
using PreventiveMaintenanceSystem.Models.Entities;
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
    }
}