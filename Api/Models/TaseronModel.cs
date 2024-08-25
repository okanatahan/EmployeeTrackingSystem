using System.ComponentModel.DataAnnotations;

namespace Api.Models
{
    public class TaseronModel
    {
        [Key]
        public int ID { get; set; }
        public string TaseronID => $"TAS{ID}";
        public string? Taseron_Bilgisi { get; set; }
    }
}
