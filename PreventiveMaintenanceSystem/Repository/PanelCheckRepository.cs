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
    public class PanelCheckRepository : BaseRepository
    {
        public List<PanelCheck> GetPanelChecks()
        {
            List<PanelCheck> result = new List<PanelCheck>();

            var reader = dbConnection.Select("usp_PanelCheck_GetAll");
            if (reader != null)
            {
                if (reader.Rows.Count > 0)
                {
                    foreach (DataRow row in reader.Rows)
                    {
                        PanelCheck item = new PanelCheck();
                        item.ID = transform.ToInt(row["ID"]);
                        item.Number = transform.ToInt(row["Number"]);
                        item.Tower = row["Tower"].ToString();
                        item.SounderOutput = transform.ToBool(row["SounderOutput"]);
                        item.BatteryConnector = transform.ToBool(row["BatteryConnector"]);
                        item.BatteryVoltage = transform.ToDecimal(row["BatteryVoltage"]);
                        item.InspectionDate = transform.ToDateTime(row["InspectionDate"]);
                        item.Inspector = row["Inspector"].ToString();
                        result.Add(item);
                    }
                }
            }
            return result;
        }
        public Result Insert(PanelCheck parameter)
        {
            var result = dbConnection.Insert("usp_PanelCheck_Insert", parameter);
            return result;
        }
        public Result Update(PanelCheck parameter)
        {
            var result = dbConnection.Update("usp_PanelCheck_Update", parameter);
            return result;
        }
    }
}