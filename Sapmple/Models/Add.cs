using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Sapmple.Models
{
    public class Add
    {
        [Required]
        [DisplayName("First Number: ")]
        public decimal ? FirstNumber  { get; set; }

        [Required]
        [DisplayName("Second Number: ")]
        public decimal ? SecondNumber { get; set; }
    }
}