using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace APBrandv2._0.Models
{
    public class Model
    {
        [Key]
        public Guid ModelID { get; set; }
        public Guid BrandID { get; set; }
        public string ModelName { get; set; }  
        [ValidateNever]
        public Brand Brand { get; set; }    
        [ValidateNever]
        public ICollection<Variant> Variants { get; set; }
    }
}
