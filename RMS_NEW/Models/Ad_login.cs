using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using RMS_NEW.Models;
using RMS_NEW.Utility;
using System.ComponentModel.DataAnnotations;

namespace RMS_NEW.Models
{
    public class Ad_login
    {
        [Required(ErrorMessage = "Please Enter Name")]
        [StringLength(12)]
        public string Admin_id { get; set; }

        [Required(ErrorMessage = "Please Enter Password")]
        [DataType(DataType.Password)]
        public string Ad_Password { get; set; }
    }

}


