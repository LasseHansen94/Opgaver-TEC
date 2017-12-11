using System;
using System.Collections.Generic;

namespace _08_12
{
    class Program
    {
        static void Main(string[] args)
        {
            // Der er to ting i en klasse: Fields (Attributes), Properties og Methods (Function)

            // Vi initialiser et objekt i stack () = Constructor
            User Niels = new User();
            Niels.A();

            // lister + properties

            // List
            List<Product> list = new List<Product>()
            {
                new Product {
                    Navn = "Test",
                    Description = "This is a test description",
                    Weight = 10.30                   
                },
                new Product {
                    // Navn = "Test2",
                    Description = "Test2 description",
                    Weight = 20.31
                }
            };
            bool falsk = false;
            if (list[1].Navn == null) {
                falsk = true;
            }

            Console.WriteLine(falsk);
            Console.ReadKey();
            
        }
    }

    class User : Product {

        // Fields - De kan tildeles forskellige Encapsulations (Public, protected, private og default)
        public int alder;
        protected bool erMand;
        private string CPRnr;
        string navn; // Default - Samme som private i C#

        // Properties
        public int _alder {
            get{return alder;}
            set{alder = value;}
        }       

        // Methods
        public void A() {
            alder = 5;
            navn = "go";
        }

        public void B() {
            alder = 10;
            navn = "hey";
        }

        // Constructor
        public User() { // Initialiserer et objekt
            // Her sætter man attributes
        }

        // Desructor (Finializer) kan ikke kaldes. De bliver aktiveret automatisk
        ~User(){ // Descructoren tager ikke parameterer eller modifiers
            // Cleanup Statements..
        }
    }

    internal class Product{
        // Properties
        public string Navn {get; set; }
        public string Description{get; set;}
        public double Weight{get;set;}
        public Product() {
            
        }
    }

}
