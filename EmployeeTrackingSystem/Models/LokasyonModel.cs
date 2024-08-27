using System.ComponentModel.DataAnnotations;

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
