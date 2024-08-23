using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTrackingSystem.Models
{
    public class DepartmanModel
    {
        [Key]
        public int ID { get; set; }
        public string DepartmanID => $"DEP{ID}";
        public string DEPARTMAN_ADI { get; set; }
    }
}
