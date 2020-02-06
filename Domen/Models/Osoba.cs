using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen.Models
{
    public abstract class Osoba
    {
        [Key]
        public int OsobaID { get; set; }
        [Required, MinLength(2,ErrorMessage ="Ime morati imati makar 2 karaktera"),RegularExpression("^[a - zA - Z] + (([',. -][a-zA-Z ])?[a-zA-Z]*)*$",ErrorMessage ="Pogresno uneto ime")]
        public string Ime { get; set; }
        [Required, MinLength(2, ErrorMessage = "Ime morati imati makar 2 karaktera"), RegularExpression("^[a - zA - Z] + (([',. -][a-zA-Z ])?[a-zA-Z]*)*$", ErrorMessage = "Pogresno uneto ime")]
        public string Prezime { get; set; }
        [Required]

        public string Adresa { get; set; }
        [Required]
        public string BrojTelefona { get; set; }
        [Required,]
        public string Email { get; set; }
        [Required,RegularExpression("^(?!.*([A-Za-z0-9]){1})(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{6,}$")]
        public string Sifra { get; set; }

    }
}
