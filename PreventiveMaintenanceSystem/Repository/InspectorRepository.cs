using PreventiveMaintenanceSystem.DataAccess;
using PreventiveMaintenanceSystem.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace PreventiveMaintenanceSystem.Repository
{
    public class InspectorRepository : BaseRepository
    {
        public List<Inspector> GetAllInspectors()
        {
            List<Inspector> result = new List<Inspector>();

            var reader = dbConnection.Select("usp_Inspector_GetAll", null, CommandType.StoredProcedure);
            if (reader != null)
            {
                if (reader.Rows.Count > 0)
                {
                    foreach (DataRow row in reader.Rows)
                    {
                        Inspector item = new Inspector();
                        item.ID = transform.ToInt(row["ID"]);
                        item.Name = row["Name"].ToString();
                        result.Add(item);
                    }
                }
            }
            return result;
        }
    }
}