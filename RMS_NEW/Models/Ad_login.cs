﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using RMS_NEW.Models;
using RMS_NEW.Utility;

namespace RMS_NEW.Models
{
    public class Ad_login
    {
        public string Admin_id { get; set; }
        public string Ad_Password { get; set; }
    }

}


