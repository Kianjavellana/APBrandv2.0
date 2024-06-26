using MessagePack;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace APBrandv2._0.Models
{
    public class Review   
    {
        [key]
        public Guid ReviewID { get; set; }
        public Guid VariantId { get; set; }
        public string ReviewDescription { get; set;}
        public string? comment { get; set; }
        public string Rating { get; set; }
        public string RatingDescription { get; }
        [ValidateNever]
        public List<Variant> Variants { get; set; }
        [ValidateNever]
        public Variant Variant { get; set; }
    }
}
