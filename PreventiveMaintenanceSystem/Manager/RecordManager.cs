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
        private FloorRepository floorRepository = new FloorRepository();
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

        public List<RecordViewModel> RecordExtendedGetAll()
        {
            List<RecordViewModel> officeDetailsViewModels = new List<RecordViewModel>();
            List<Record> records = GetAllRecord();
            foreach (Record record in records)
            {
                RecordViewModel model = new RecordViewModel();
                model.ID = record.ID;
                model.Building = record.Building;
                model.MCP_1 = record.MCP_1;
                model.MCP_2 = record.MCP_2;
                model.Sounder_1 = record.Sounder_1;
                model.Sounder_2 = record.Sounder_2;
                model.DateChecked = record.DateChecked;
                model.DateModified = record.DateModified;
                model.Remarks = record.Remarks;
                model.IsDeleted = record.IsDeleted;
                model.FloorList = floorRepository.GetAllFloors().ToList();
                officeDetailsViewModels.Add(model);
            }
            return officeDetailsViewModels;
        }
        public Record RecordGetByID(int id)
        {
            return GetAllRecord().FirstOrDefault(e => e.ID.Equals(id));
        }
        public Result Insert(Record parameter)
        {
            Result result = recordRepository.Insert(parameter);
            if (result.IsSuccess)
            {
                cacheManager.ClearCache("usp_Record_GetAll");
            }
            return result;
        }
        public Result Update(Record parameter)
        {
            Result result = recordRepository.Update(parameter);
            if (result.IsSuccess)
            {
                cacheManager.ClearCache("usp_Record_GetAll");
            }
            return result;
        }
    }
}