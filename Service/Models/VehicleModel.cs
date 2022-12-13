using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Service.Models
{
    public class VehicleModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public int ModelID { get; set; }
        public string ModelName { get; set; }

        public virtual ICollection<Registration> Registrations { get; set; }

       
    }
} 