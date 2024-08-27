using System.ComponentModel.DataAnnotations;

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
