using System.ComponentModel.DataAnnotations;

namespace Api.Models
{
    public class LokasyonModel
    {
        [Key]
        public int ID { get; set; }
        public string LokasyonID => $"LOK{ID}";
        public string? Lokasyon_Adı { get; set; }
    }
}
