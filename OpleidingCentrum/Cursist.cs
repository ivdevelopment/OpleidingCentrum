using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpleidingCentrum
{
    internal class Cursist
    {
        public Cursist(string voornaam, string familienaam, Traject traject)
        {
            Voornaam = voornaam;
            Familienaam = familienaam;
            Traject = traject;
        }
        public string Voornaam { get; set; }
        public string Familienaam { get; set; }
        public Traject Traject { get; set; }
    }
}
