using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpleidingCentrum
{
    internal class Instructeur
    {
        public Instructeur(string voornaam, string familienaam)
        {
            Voornaam = voornaam;
            Familienaam = familienaam;
        }

        public string Voornaam { get; set; }
        public string Familienaam { get; set; }
    }
}
