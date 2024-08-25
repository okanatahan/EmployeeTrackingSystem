using System.ComponentModel.DataAnnotations;

namespace Api.Models
{
    public class PozisyonModel
    {
        [Key]
        public int ID { get; set; }
        public string PozisyonID => $"POZ{ID}";
        public string? Pozisyon_Adı { get; set; }
    }
}
