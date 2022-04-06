using System.ComponentModel.DataAnnotations;

namespace LienSample.Models
{
    public class LienType
    {
        public string Id { get; set; } = string.Empty;
        
        [Display(Name = "Lien Type")]
        public string Name { get; set; } = string.Empty;
    }
}