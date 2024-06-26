using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace APBrandv2._0.Models
{
    public class Variant
    {
        [Key]
        public Guid VariantId { get; set; }
        public Guid ModelID { get; set; }
        public string VariantName { get; set; }
        public string MainCamera { get; set; }
        public string SelfieCamera { get; set; }
        public string BodyRatio { get; set; }
        public string Network { get; set; }
        public string Display { get; set; }
        public string Platform { get; set; }
        public string COMMS { get; set; }
        public string Memory { get; set; }
        public string Features { get; set; }
        public string Battery { get; set; }
        public string MISC { get; set; }
        public string Tests { get; set; }
        [ValidateNever]
        public Model Model { get; set; }
        [ValidateNever]
        public ICollection<Review> Reviews { get; set; }
    }
}
