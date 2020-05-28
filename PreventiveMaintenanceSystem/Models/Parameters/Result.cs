﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PreventiveMaintenanceSystem.Models.Parameters
{
    public class Result
    {
        public int ID { get; set; }
        public bool IsSuccess { get; set; }
        public Exception Exception { get; set; }
        public string ExceptionMessage { get; set; }
    }
}