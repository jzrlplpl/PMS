using PreventiveMaintenanceSystem.Managers;
using PreventiveMaintenanceSystem.Models.Entities;
using PreventiveMaintenanceSystem.Models.Parameters;
using PreventiveMaintenanceSystem.Models.ViewModels;
using PreventiveMaintenanceSystem.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PreventiveMaintenanceSystem.Manager
{
    public class RecordManager : BaseManager
    {
        private RecordRepository recordRepository = new RecordRepository();
        private DropdownManager dropdownManager = new DropdownManager();
        public List<Record> GetAllRecord()
        {
            List<Record> record = cacheManager.cache["usp_Record_GetAll"] as List<Record>;
            if (record == null)
            {
                record = recordRepository.GetAllRecords();
                cacheManager.cache.Set("usp_Record_GetAll", record, cacheManager.cacheExpiry);
            }
            return record;
        }
        public Result Insert(Record parameter)
        {
            Result result = recordRepository.Insert(parameter);
            if (result.IsSuccess)
            {
                cacheManager.AddItemToCache("usp_Record_GetAll", parameter);
            }
            return result;
        }
    }
}