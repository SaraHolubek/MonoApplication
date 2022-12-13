using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Service.Models
{
    public class Registration
    {
        [Key]
        public int RegID { get; set; }
        public int VehicleID { get; set; }
        public int ModelID { get; set; }

        public virtual VehicleMake VehicleMake { get; set; }
        public virtual VehicleModel VehicleModel { get; set; }
    }
}