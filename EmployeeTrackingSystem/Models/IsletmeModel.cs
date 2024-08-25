using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTrackingSystem.Models
{
    public class IsletmeModel
    {
        [Key]
        public int ID { get; set; }
        public string IsletmeID => $"ISL{ID}";
        public string Isletme_Adı { get; set; }
    }
}
