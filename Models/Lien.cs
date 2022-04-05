using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LienSample.Models
{
    public class Lien
    {
        public int Id { get; set; }
        public string Company { get; set; } = string.Empty;
        
        [Display(Name = "Created Date")]
        [DataType(DataType.Date)]
        public DateTime CreatedDate { get; set; }
        
         [DataType(DataType.Currency)]
        public decimal Amount { get; set; }
    }
}