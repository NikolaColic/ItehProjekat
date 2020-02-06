using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen.Models
{
    public class Raspored
    {
        [Key]
        public DateTime DatumRasporeda { get; set; }
        [Required]
        public string Smena { get; set; }
        public bool Kasnjenje { get; set; }
        public DateTime VremePrijavljivanja { get; set; }
        public string Obavestenje { get; set; }
        public Administrator Administrator { get => administrator; set => administrator = value; }
        public Zaposleni Zaposleni { get => zaposleni; set => zaposleni = value; }

        private Administrator administrator;
        private Zaposleni zaposleni;


    }
}
