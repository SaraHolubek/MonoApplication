using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Service.ViewModels
{
    public class RegistratedCarsGroup
    {
        [DataType(DataType.Date)]
        public string VehicleName { get; set; }

        public int VehicleCount { get; set; }
    }
}