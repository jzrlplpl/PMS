using PreventiveMaintenanceSystem.Managers;
using PreventiveMaintenanceSystem.Models.Entities;
using PreventiveMaintenanceSystem.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PreventiveMaintenanceSystem.Manager
{
    public class FloorManager : BaseManager
    {
        private FloorRepository floorRepository = new FloorRepository();
        public List<Floor> GetAllFloors()
        {
            List<Floor> record = cacheManager.cache["usp_Floor_GetAll"] as List<Floor>;
            if (record == null)
            {
                record = floorRepository.GetAllFloors();
                cacheManager.cache.Set("usp_Floor_GetAll", record, cacheManager.cacheExpiry);
            }
            return record;
        }
        public List<Floor> FloorGetByTowerID(int id)
        {
            return GetAllFloors().Where(f => f.TowerID.Equals(id)).ToList();
        }
    }
}