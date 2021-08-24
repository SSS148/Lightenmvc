using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lighten.Models
{
    public class YourProducts
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

        [Display(Name = "UserId")]
        public int UserId { get; set; }
    }
}
