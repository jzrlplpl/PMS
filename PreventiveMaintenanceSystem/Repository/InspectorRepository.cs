﻿using PreventiveMaintenanceSystem.DataAccess;
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
                        item.IsDeleted = transform.ToBool(row["IsDeleted"]);
                        result.Add(item);
                    }
                }
            }
            return result;
        }

        public Result Insert(Inspector parameter)
        {
            var result = dbConnection.Insert("usp_Inspector_Insert", parameter);
            return result;
        }
        public Result Update(Inspector parameter)
        {
            var result = dbConnection.Update("usp_Inspector_Update", parameter);
            return result;
        }
    }
}