using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTrackingSystem.Models
{
    public class GecisModel
    {
        [Key]
        public int ID { get; set; }
        public string GecisID => $"GEC{ID}";
        public string Gecis_Bilgisi { get; set; }
    }
}
