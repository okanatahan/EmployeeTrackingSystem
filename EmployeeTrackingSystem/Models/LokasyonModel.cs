using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTrackingSystem.Models
{
    public class LokasyonModel
    {
        [Key]
        public int ID { get; set; }
        public string LokasyonID => $"LOK{ID}";
        public string Lokasyon_Adı { get; set; }
    }
}
