using System.ComponentModel.DataAnnotations;

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
