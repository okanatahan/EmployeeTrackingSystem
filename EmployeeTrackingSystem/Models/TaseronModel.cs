using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTrackingSystem.Models
{
    public class TaseronModel
    {
        [Key]
        public int ID { get; set; }
        public string TaseronID => $"TAS{ID}";
        public string Taseron_Bilgisi { get; set; }
    }
}
