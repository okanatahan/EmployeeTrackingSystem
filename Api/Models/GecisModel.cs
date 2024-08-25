using System.ComponentModel.DataAnnotations;

namespace Api.Models
{
    public class GecisModel
    {
        [Key]
        public int ID { get; set; }
        public string GecisID => $"GEC{ID}";
        public string? Gecis_Bilgisi { get; set; }
    }
}
