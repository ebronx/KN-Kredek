using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace web_app.Models
{
    public class Order
    {
        [Required]
        public int PizzaId { get; set; }

        [Required(ErrorMessage ="Miasto jest wymagane")]
        public string City { get; set; }

        [Required(ErrorMessage ="Adres jest wymagany")]
        public string Adress { get; set; }

        [Required(ErrorMessage = "Email jest wymagany")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Nr tel jest wymagany")]
        [Phone(ErrorMessage ="niepoprawny numer tel")]
        public string Phone { get; set; }

        [Required]
        public DateTime OrderDate { get; set; }


    }
}
