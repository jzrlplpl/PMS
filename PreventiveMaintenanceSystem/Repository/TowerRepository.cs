using PreventiveMaintenanceSystem.DataAccess;
using PreventiveMaintenanceSystem.Models;
using PreventiveMaintenanceSystem.Models.Entities;
using PreventiveMaintenanceSystem.Models.Parameters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace PreventiveMaintenanceSystem.Repository
{
    public class TowerRepository : BaseRepository
    {
        public List<Tower> GetAllTowers()
        {
            List<Tower> result = new List<Tower>();

            var reader = dbConnection.Select("usp_Tower_GetAll", null, CommandType.StoredProcedure);
            if (reader != null)
            {
                if (reader.Rows.Count > 0)
                {
                    foreach (DataRow row in reader.Rows)
                    {
                        Tower item = new Tower();
                        item.ID = transform.ToInt(row["ID"]);
                        item.Name = row["Name"].ToString();
                        item.IsDeleted = transform.ToBool(row["IsDeleted"]);
                        result.Add(item);
                    }
                }
            }
            return result;
        }

        public Result Insert(Tower parameter)
        {
            var result = dbConnection.Insert("usp_Tower_Insert", parameter);
            return result;
        }
        public Result Update(Tower parameter)
        {
            var result = dbConnection.Update("usp_Tower_Update", parameter);
            return result;
        }
    }
}