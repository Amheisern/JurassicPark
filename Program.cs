using System;
using System.Collections.Generic;
using System.Linq;

namespace JurassicPark
{
    class DinosDatabase
    {
        private List<Dino> Dinos = new List<Dino>();

        public Dino FindDinos(string dinoName)
        {
            Dino foundDino = Dinos.FirstOrDefault(dino => dino.Name.ToUpper().Contains(dinoName.ToUpper()));
            return foundDino;
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
    }
    class Dino
    {

        public string Name { get; set; }
        public string Diet { get; set; }
        public int Weight { get; set; }
        public int Enclosure { get; set; }
        //  public List<Card> CurrentCards { get; set; } = new List<Card>();
        public DateTime Date { get; set; } = DateTime.Now;// Need help with this

        public void DisplayDinos()
        {
            // name = Name;
            // diet = Diet;
            // weight = Weight;
            // enclosure = Enclosure;
            // need to add all properties and format
            Console.WriteLine($"The dinosaurs name is {Name}");
            Console.WriteLine($"This dinosaur is a {Diet} and weighs {Weight} tons");
            Console.WriteLine($"This dinosaur was acquired {Date} and is currently in enclosure number {Enclosure}");


        }
        // public void DinoDisplay();
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
            var newDino = new Dino();
            newDino.Name = "Frank";
            //("frank", "carnivore", 6, 2);
            newDino.DisplayDinos();


            //While user hasn't input "Q" keep showing menu
            while (keepGoing)
            {
                Console.WriteLine();
                Console.WriteLine("Please choose from the following D.R.A.F.T.S menu");
                Console.WriteLine("(D)isplay a dinosaur from database");
                Console.WriteLine("(R)emove a dinosaur from database");
                Console.WriteLine("(A)dd a dinosaur to database");
                Console.WriteLine("(F)ind a dinosaur in the database");
                Console.WriteLine("(T)ransfer a dinosaur to a different enclosure");
                Console.WriteLine("(S)how number of herbivores and carnivores ");
                Console.WriteLine("(Q)uit to exit menu");
                var choice = Console.ReadLine().ToUpper();

                switch (choice)
                {
                    case "D":

                    case "R":


                    case "A":
                        var dino = new Dino();

                        dino.Name = PromptForString("What is the name of the dinosaur?");
                        dino.Diet = PromptForString("Is the dinosaur a carnivore or herbivore?");
                        dino.Weight = PromptForInteger("In tons, what is the weight of the dinosaur?");
                        dino.Enclosure = PromptForInteger("What is the number of the enclosure?");
                        break;
                    // weight in tons  

                    case "F":
                        // public void FindDinos(string dinoName)
                        //Dino foundDino = Dinos.FirstOrDefault(dino => dino.Name.ToUpper().Contains(dinoName.ToUpper()));
                        var name = PromptForString("Please type the name of the Dinosaur");
                        Dino foundDino = database.FindDinos(name);
                        if (foundDino == null)
                        {
                            Console.WriteLine("No match found in database!");
                        }
                        else
                        {
                            Console.WriteLine($"Found! {foundDino.Name} is in encloser {foundDino.Enclosure} ")
                        }
                        break;

                    case "T":

                    case "S":

                    case "Q":
                        keepGoing = false;
                        break;
                    default:
                        Console.WriteLine("That was not a valid selection!");
                        break;
                }
            }
        }
    }
}

