using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Deployment.Internal;
using System.Linq;

namespace Service.Models
{
    public class VehicleMake
    {
        internal object FirstMidName;

        [Key]
        public int ID { get; set; }
        public string VehicleName { get; set; }
        public string VehicleAbrv { get; set; }

        public virtual ICollection<VehicleModel> VehicleModels { get; set; }
    }
}