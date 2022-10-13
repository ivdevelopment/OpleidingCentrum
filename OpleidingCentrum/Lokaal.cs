using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpleidingCentrum
{
    internal class Lokaal
    {
        public Lokaal(int nummer, Instructeur instructeur)
        {
            Nummer = nummer;
            Instructeur = instructeur;
        }
        public int Nummer { get; set; }
        public Instructeur Instructeur { get; set; }
        private int aantalCursisten = 0;
        private List<Cursist> Cursisten = new List<Cursist>();
        public void CursistToevoegen(Cursist cursist)
        {
            aantalCursisten++;
            Cursisten.Add(cursist);
        }

        public void CursistVerwijderen(Cursist cursist)
        {
            aantalCursisten--;
            Cursisten.Remove(cursist);
        }

        public override string ToString()
        {
            StringBuilder uitvoer = new StringBuilder($"Lokaal {Nummer} heeft als instructeur {Instructeur.Voornaam} {Instructeur.Familienaam}\nEr zijn {aantalCursisten} cursisten:\n");
            foreach(var cursist in Cursisten)
                uitvoer.Append($"{cursist.Voornaam} {cursist.Familienaam} volgt {cursist.Traject.Naam}\n");
            return uitvoer.ToString();

        }
    }
}
