using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTrackingSystem.Models
{
    public class KullaniciModel
    {
        [Key]
        public int FK_PersonelID { get; set; }
        public string kullanıcı_adı { get; set; }
        public string parola { get; set; }
        public string rol { get; set; }
    }
}
