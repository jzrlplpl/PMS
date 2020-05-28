using PreventiveMaintenanceSystem.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PreventiveMaintenanceSystem.DataAccess
{
    public class BaseRepository
    {
        public DatabaseConnection dbConnection;
        public FieldTransformer transform;

        public BaseRepository()
        {
            this.dbConnection = new DatabaseConnection();
            this.transform = new FieldTransformer();
        }
    }
}