using System;
using System.Collections.Generic;
using System.Linq;

namespace JurassicPark
{
    class DinosDatabase
    {
        private List<Dino> Dinos = new List<Dino>();

        public void FindDinos(string dinoName)
        {
            Dino foundDino = Dinos.FirstOrDefault(dino => dino.Name.ToUpper().Contains(dinoName.ToUpper()));
        }
        public void RemoveDinos(Dino dinoToDelete)
        {
            Dinos.Remove(dinoToDelete);
        }
        //Adding a Dino to DinosDatabase
        public void AddDinos(Dino newDino)
        {
            Dinos.Add(newDino);
        }
        // public void DisplayDinos(Dino ShowDino)
        // {

        // }
    }
    class Dino
    {
        public string Name { get; set; }
        public string Diet { get; set; }
        public int weight { get; set; }
        public int Enclosure { get; set; }
        public DateTime Date { get; set; } // Need help with this
    }

    class Program
    {
        static void DisplayGreeting()
        {
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("    Welcome to JurassicPark D.R.A.F.T.S database   ");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine();
        }

        static string PromptForString(string prompt)
        {
            Console.Write(prompt);
            var userInput = Console.ReadLine();

            return userInput;
        }

        static int PromptForInteger(string prompt)
        {
            Console.Write(prompt);
            int userInput;
            var isThisGoodInput = Int32.TryParse(Console.ReadLine(), out userInput);

            if (isThisGoodInput)
            {
                return userInput;
            }
            else
            {
                Console.WriteLine("Sorry, that isn't a valid input, I'm using 0 as your answer.");
                return 0;
            }
        }

        //^^^^^^^^^^^^^^^^^^^^^^^ methods, classes, oh my ^^^^^^^^^
        static void Main(string[] args)
        {
            // our dino database
            var database = new DinosDatabase();

            // Should we keep showing out menu
            var keepGoing = true;

            DisplayGreeting();

            //While user hasn't input "Q" keep showing menu
            while (keepGoing)
            {
                Console.WriteLine("test");
            }
        }
    }
}

