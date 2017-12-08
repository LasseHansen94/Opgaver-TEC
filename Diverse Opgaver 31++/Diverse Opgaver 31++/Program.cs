using System;
using System.Collections.Generic;

namespace Diverse_Opgaver_31__
{
    class Program
    {
        static void Main(string[] args)
        {
            // Opgave 31++

            Person Abraham = new Person(){
                fornavn = "Abraham",
                efternavn = "Lincoln",
                adresse = "Abrahamsvej 20",
                tlfnr = "40302010"
            };
            Person Gilbert = new Person(){ 
                fornavn = "Gilbert",
                efternavn = "Skysovs",
                adresse = "Gilbertsvej 231",
                tlfnr = "20310212"
            };
            Person Flomme = new Person(){ 
                fornavn = "Flomme",
                adresse = "Flommevej 23",
                tlfnr = "20304050"
            };
            Person Blomme = new Person(){
                fornavn = "Blomme",
                adresse = "Blommevej 203",
                tlfnr = "30405060"
            };
            Person Alexandre = new Person(){
                fornavn = "Alexandre",
                adresse = "Alexandrevej 203",
                tlfnr = "30405061"
            };
            object obj = OpretPerson();
            PrintPerson(obj);
            
            Produkt telefon = new Produkt();
            telefon.SetPris(100); 
            Console.WriteLine(telefon.GetPris());
            Console.ReadKey();

        }
        public static object OpretPerson() {
            Person Gilbert = new Person() {
                fornavn = Console.ReadLine(),
                efternavn = Console.ReadLine(),
                adresse = Console.ReadLine(),
                tlfnr = Console.ReadLine()
            };
            return Gilbert;
        }

        public static void PrintPerson(object obj) {
            foreach (var item in obj.GetType().GetProperties()) {
                Console.WriteLine(item.GetValue(obj));
            }
        }

        class Person {
            public string fornavn{get; set;}
            public string efternavn{get; set;}
            public string adresse{get; set;}
            public string tlfnr{get; set;}
        }

        class Produkt {
            const double _moms = 0.25;
            private double pris = 0;
            public int kg{get; set;}
            public double størrelse{get; set; }

            public double GetPris() {
                return pris;
            }
            public void SetPris(double pris) {
                this.pris = pris + (pris * _moms);
            }
        }
    }
}
