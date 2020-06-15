using PreventiveMaintenanceSystem.Managers;
using PreventiveMaintenanceSystem.Models;
using PreventiveMaintenanceSystem.Models.Parameters;
using PreventiveMaintenanceSystem.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PreventiveMaintenanceSystem.Manager
{
    public class TowerManager : BaseManager
    {
        private TowerRepository towerRepository = new TowerRepository();
        public List<Tower> TowerGetAll()
        {
            List<Tower> result = cacheManager.cache["usp_Tower_GetAll"] as List<Tower>;
            if (result == null)
            {
                result = towerRepository.GetAllTowers();
                cacheManager.cache.Set("usp_Tower_GetAll", result, cacheManager.cacheExpiry);
            }
            return result;
        }
        public Tower TowerGetByID(int id)
        {
            return TowerGetAll().FirstOrDefault(e => e.ID.Equals(id));
        }
        public Result Insert(Tower parameter)
        {
            Result result = towerRepository.Insert(parameter);
            if (result.IsSuccess)
            {
                cacheManager.ClearCache("usp_Tower_GetAll");
            }
            return result;
        }
        public Result Update(Tower parameter)
        {
            Result result = towerRepository.Update(parameter);
            if (result.IsSuccess)
            {
                cacheManager.ClearCache("usp_Tower_GetAll");
            }
            return result;
        }
    }
}