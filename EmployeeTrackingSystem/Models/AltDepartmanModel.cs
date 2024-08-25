using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTrackingSystem.Models
{
    public class AltDepartmanModel
    {
        [Key]
        public int ID { get; set; }
        public string AltDepartmanID => $"ALT{ID}";
        public string Alt_Departman_Adı { get; set; }
    }
}
