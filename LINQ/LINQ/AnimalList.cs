using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class AnimalList
    {
        List<string> animals;
        public AnimalList()
        {
            animals = new List<string>();
        }
        public void StartList()
        {
            AddToAnimalsList();
            DisplayListOfAnimals();
        }
        public void AddToAnimalsList()
        {
            animals.Add("dog");
            animals.Add("dog");
            animals.Add("cat");
            animals.Add("cat");
            animals.Add("bird");
            animals.Add("dog");
            animals.Add("fish");
            animals.Add("fish");
        }
        public void DisplayListOfAnimals()
        {
            foreach (string animal in animals)
            {
                Console.WriteLine("List of animals: {0}", animal);
            }
        }
        public void DisplayListOfAnimalsAgain()
        {
            List<string> animalsAgain = animals.Distinct().ToList();
            foreach (string animal in animalsAgain)
            {
                Console.WriteLine("List of animals with no duplicates: {0}", animal);
            }
        }
    }
}
