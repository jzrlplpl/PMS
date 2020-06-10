using PreventiveMaintenanceSystem.Managers;
using PreventiveMaintenanceSystem.Models;
using PreventiveMaintenanceSystem.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PreventiveMaintenanceSystem.Manager
{
    public class InspectorManager : BaseManager
    {
        private InspectorRepository inspectorRepository = new InspectorRepository(); 
        public List<Inspector> InspectorGetAll()
        {
            List<Inspector> result = cacheManager.cache["usp_Inspector_GetAll"] as List<Inspector>;
            if (result == null)
            {
                result = inspectorRepository.GetAllInspectors();
                cacheManager.cache.Set("usp_Inspector_GetAll", result, cacheManager.cacheExpiry);
            }
            return result;
        }
    }
}