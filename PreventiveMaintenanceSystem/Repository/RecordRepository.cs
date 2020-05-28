using PreventiveMaintenanceSystem.DataAccess;
using PreventiveMaintenanceSystem.Models.Entities;
using PreventiveMaintenanceSystem.Models.Parameters;
using PreventiveMaintenanceSystem.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace PreventiveMaintenanceSystem.Repository
{
    public class RecordRepository : BaseRepository
    {
        public List<Record> GetAllRecords()
        {
            List<Record> result = new List<Record>();

            var reader = dbConnection.Select("usp_Record_GetAll");
            if (reader != null)
            {
                if (reader.Rows.Count > 0)
                {
                    foreach (DataRow row in reader.Rows)
                    {
                        Record item = new Record();
                        item.ID = transform.ToInt(row["ID"]);
                        item.Building = row["Building"].ToString();
                        item.Floor = row["Floor"].ToString();
                        item.MCP_1 = row["MCP_1"].ToString();
                        item.MCP_2 = row["MCP_2"].ToString();
                        item.Sounder_1 = row["Sounder_1"].ToString();
                        item.Sounder_2 = row["Sounder_2"].ToString();
                        item.DateChecked = transform.ToDateTime(row["DateChecked"]);
                        item.Remarks = row["Remarks"].ToString();
                        item.IsDeleted = transform.ToBool(row["IsDeleted"]);
                        result.Add(item);
                    }
                }
            }
            return result;
        }
        public Result Insert(Record parameter)
        {
            var result = dbConnection.Insert("usp_Record_Insert", parameter);
            return result;
        }
        public Result Update(Record parameter)
        {
            var result = dbConnection.Update("usp_Record_Update", parameter);
            return result;
        }
    }
}