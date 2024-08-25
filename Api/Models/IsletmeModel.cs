using System.ComponentModel.DataAnnotations;

namespace Api.Models
{
    public class IsletmeModel
    {
        [Key]
        public int ID { get; set; }
        public string IsletmeID => $"ISL{ID}";
        public string? Isletme_Adı { get; set; }
    }
}
