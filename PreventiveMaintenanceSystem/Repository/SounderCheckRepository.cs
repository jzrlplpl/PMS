using PreventiveMaintenanceSystem.DataAccess;
using PreventiveMaintenanceSystem.Models.Entities;
using PreventiveMaintenanceSystem.Models.Parameters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace PreventiveMaintenanceSystem.Repository
{
    public class SounderCheckRepository : BaseRepository
    {
        public List<SounderCheck> GetSounderChecks()
        {
            List<SounderCheck> result = new List<SounderCheck>();

            var reader = dbConnection.Select("usp_SounderCheck_GetAll");
            if (reader != null)
            {
                if (reader.Rows.Count > 0)
                {
                    foreach (DataRow row in reader.Rows)
                    {
                        SounderCheck item = new SounderCheck();
                        item.ID = transform.ToInt(row["ID"]);
                        item.Level = row["Level"].ToString();
                        item.Tower = row["Tower"].ToString();
                        item.MCP1 = transform.ToBool(row["MCP1"]);
                        item.MCP2 = transform.ToBool(row["MCP2"]);
                        item.Sounder1 = transform.ToBool(row["Sounder1"]);
                        item.Sounder2 = transform.ToBool(row["Sounder2"]);
                        item.Remarks = row["Remarks"].ToString();
                        item.InspectionDate = transform.ToDateTime(row["InspectionDate"]);
                        item.Inspector = row["Inspector"].ToString();
                        result.Add(item);
                    }
                }
            }
            return result;
        }
        public Result Insert(SounderCheck parameter)
        {
            var result = dbConnection.Insert("usp_SounderCheck_Insert", parameter);
            return result;
        }
        public Result Update(SounderCheck parameter)
        {
            var result = dbConnection.Update("usp_SounderCheck_Update", parameter);
            return result;
        }
    }
}