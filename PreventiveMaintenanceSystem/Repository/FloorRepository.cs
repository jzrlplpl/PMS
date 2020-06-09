using PreventiveMaintenanceSystem.DataAccess;
using PreventiveMaintenanceSystem.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace PreventiveMaintenanceSystem.Repository
{
    public class FloorRepository : BaseRepository
    {
        public List<Floor> GetAllFloors()
        {
            List<Floor> result = new List<Floor>();

            var reader = dbConnection.Select("usp_Floor_GetAll");
            if (reader != null)
            {
                if (reader.Rows.Count > 0)
                {
                    foreach (DataRow row in reader.Rows)
                    {
                        Floor item = new Floor();
                        item.ID = transform.ToInt(row["ID"]);
                        item.Name = row["Name"].ToString();
                        item.TowerID = transform.ToInt(row["TowerID"]);
                        item.IsDeleted = transform.ToBool(row["IsDeleted"]);
                        result.Add(item);
                    }
                }
            }
            return result;
        }

    }
}