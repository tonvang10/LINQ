using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            AnimalList animalList = new AnimalList();
            animalList.StartList();
            Console.WriteLine();
            animalList.DisplayListOfAnimalsAgain();

            ClassGrade classGrade = new ClassGrade();
            classGrade.ShowAllGrades();
            classGrade.RemoveMinGrades();
            Console.WriteLine("\nGrades after removing minimum score:");
            classGrade.ShowAllGrades();
            Console.WriteLine("\nAverage of grades:");
            classGrade.GetAverageGrades();
            classGrade.ShowAverageGrades();
            Console.WriteLine("\nTotal average of all grades:");
            classGrade.GetAverageOfAverageGrades();

            Function function = new Function();
            function.CountLetters();
            function.SortLetters();
            Console.ReadKey();
        }
    }
}
