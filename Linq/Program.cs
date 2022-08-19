using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<Pracownik> programisci = new Pracownik[]
            {
                new Pracownik { Id = 1, Imie = "Marcin", Nazwisko = "Nowak"},
                 new Pracownik { Id = 1, Imie = "Maciej", Nazwisko = "Nowak"},
                new Pracownik { Id = 2, Imie = "Tomek", Nazwisko = "Kowal"},
                new Pracownik { Id = 3, Imie = "Jacek", Nazwisko = "Sobota"},
                new Pracownik { Id = 4, Imie = "Adam", Nazwisko = "Wrona"}
            };

            IEnumerable<Pracownik> kierowcy = new List<Pracownik>()
            {
                new Pracownik { Id = 5, Imie = "Olek", Nazwisko = "Sroka"},
                new Pracownik { Id = 6, Imie = "Pawel", Nazwisko = "Wrobel"},
                new Pracownik { Id = 7, Imie = "Marek", Nazwisko = "Piatek"}
            };

            foreach (var osoba in programisci.Where(p => p.Imie.StartsWith("M")).OrderBy(p => p.Imie))
                
            {
                Console.WriteLine(osoba.Imie);
            }
            Console.ReadLine();


            var zapytanie = programisci.Where(p => p.Imie.Length == 5).OrderBy(p => p.Imie);
            var zapytani2 = from programista in programisci
                            where programista.Imie.Length == 5
                            orderby programista.Imie
                            select programista;

            foreach (var item in zapytani2)
            {
                Console.WriteLine(item.Imie);
            }



        }

        public static bool RozpoczynaNaM(Pracownik pracownik)
        {
            return pracownik.Imie.StartsWith("M");
        }

        
	{

	}

     

    }
}


