 using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace APBrandv2._0.Models
{
    public class Brand
    {
        [Key ]
        public Guid BrandID { get; set; }
        public string BrandName { get; set; }
        public string BrandDescription { get; set; }
        public string CountryofOrigin { get; set; }
        public string Industry { get; set; }
        public string Headquarterslocation { get; set; }
        public string YearFounded { get; set; }
        public string WebsiteUrl { get; set; }
        public string ContactNumber { get; set; }
        public string Founder { get; set; }
        public string Description { get; set; }
        [ValidateNever]
        public ICollection<Model> Models { get; set; }
    }
}
