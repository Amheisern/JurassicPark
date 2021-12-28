using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using CsvHelper;

namespace JurassicPark
{
    class DinosDatabase
    {
        private List<Dino> Dinos { get; set; } = new List<Dino>();

        private string FileName = "DraftsData.csv";

        public void LoadDinos()
        {
            if (File.Exists(FileName))
            {
                var fileReader = new StreamReader(FileName);

                var csvReader = new CsvReader(fileReader, CultureInfo.InvariantCulture);

                // Replace our BLANK list of employees with the ones that are in the CSV file
                Dinos = csvReader.GetRecords<Dino>().ToList();

                fileReader.Close();
            }
        }

        public void SaveDinos()
        {
            var fileWriter = new StreamWriter(FileName);

            var csvWriter = new CsvWriter(fileWriter, CultureInfo.InvariantCulture);

            csvWriter.WriteRecords(Dinos);

            fileWriter.Close();
        }


        public Dino FindDinos(string dinoName)
        {
            Dino foundDino = Dinos.FirstOrDefault(dino => dino.Name.ToUpper().Contains(dino.Name.ToUpper()));
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
        public void ShowDinos(List<Dino> dinos)
        {
            var numberOfCarnivore = dinos.Where(dino => dino.Diet.Contains("Carnivore"))
            .Count();
            var numberOfHerbivore = dinos.Where(dino => dino.Diet.Contains("Herbivore"))
            .Count();
            Console.WriteLine(numberOfCarnivore);
        }
    }
}

