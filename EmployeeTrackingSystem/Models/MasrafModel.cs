using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTrackingSystem.Models
{
    public class MasrafModel
    {
        [Key]
        public int ID { get; set; }
        public string MasrafID => $"MAS{ID}";
        public string Masraf_Bilgisi { get; set; }
    }
}
