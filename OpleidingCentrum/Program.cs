using OpleidingCentrum;

var traject1 = new Traject("c++");
var traject2 = new Traject("java");
var traject3 = new Traject(".net");
var traject4 = new Traject("basis");
var cursist1 = new Cursist("Felix", "De Vliegher", traject4);
var cursist2 = new Cursist("Koen", "Vanhoutte", traject2);
var cursist3 = new Cursist("Serge", "Vereecke", traject2);
var cursist4 = new Cursist("Freddy", "Himpe", traject3);
var instructeur = new Instructeur("Hans", "Desmet");
var lokaal = new Lokaal(11, instructeur);
lokaal.CursistToevoegen(cursist1); // een lokaal heeft een variabel aantal cursisten
lokaal.CursistToevoegen(cursist2);
lokaal.CursistToevoegen(cursist3);
lokaal.CursistToevoegen(cursist4);
Console.WriteLine(lokaal);
cursist1.Traject = traject1;
var cursist5 = new Cursist("Alexandra", "Blondeel", traject2);
lokaal.CursistToevoegen(cursist5);
lokaal.CursistVerwijderen(cursist2);
Console.WriteLine(lokaal);

