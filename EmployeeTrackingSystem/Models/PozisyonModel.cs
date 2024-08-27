using System.ComponentModel.DataAnnotations;

namespace EmployeeTrackingSystem.Models
{
    public class PozisyonModel
    {
        [Key]
        public int ID { get; set; }
        public string PozisyonID => $"POZ{ID}";
        public string Pozisyon_Adı { get; set; }
    }
}
