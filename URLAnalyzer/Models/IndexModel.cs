using System.ComponentModel.DataAnnotations;
using URLAnalyzer.CustomValidators;

namespace URLAnalyzer.Models
{
    public class IndexModel
    {
        [Required]
        [Url]
        [CustomUrlValidator]
        public string Url { get; set; }
    }
}
