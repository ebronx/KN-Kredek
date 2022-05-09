using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KredekStronaZadDom.Models
{
    public class Order
    {
        [Required]
        public int CourseId { get; set; }

        [Required(ErrorMessage = "Imie jest wymagane")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Nazwisko jest wymagane")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Email jest wymagany")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Nr tel jest wymagany")]
        [Phone(ErrorMessage = "niepoprawny numer tel")]
        public string Phone { get; set; }

        [Required]
        public DateTime OrderDate { get; set; }
    }
}
