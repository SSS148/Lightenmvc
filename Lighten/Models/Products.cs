using System.ComponentModel.DataAnnotations;

namespace Lighten.Models
{
    public class Products
    {
        public int Id { get; set; }

        [Display(Name = "LightModel")]
        public string LightModel { get; set; }

        [Display(Name = "LightCompany")]
        public string LightCompany { get; set; }
        
        [Display(Name = "LightType")]
        public string LightType { get; set; }
        
        [Display(Name = "Price")]
        public string Price { get; set; }
    }
}
