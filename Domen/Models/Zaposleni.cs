using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen.Models
{
    public class Zaposleni : Osoba
    {
        public DateTime DatumZap { get; set; }
        public string Pozicija{ get; set; }

        



    }
}
