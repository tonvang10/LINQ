using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class ClassGrade
    {
        List<int> idoGrade;
        List<int> harlemGrade;
        List<int> aysonGrade;
        List<int> jackieGrade;
        List<int> tonGrade;
        double idoAverageGrade;
        double harlemAverageGrade;
        double aysonAverageGrade;
        double jackieAverageGrade;
        double tonAverageGrade;
        public ClassGrade()
        {
            idoGrade = new List<int>() { 100, 90, 85, 90, 95, 85 };
            harlemGrade = new List<int>() { 90, 95, 85, 80, 100, 85 };
            aysonGrade = new List<int>() { 100, 95, 95, 90, 95, 100 };
            jackieGrade = new List<int>() { 95, 95, 85, 90, 95, 85 };
            tonGrade = new List<int>() { 50, 10, 40, 100, 70, 35 };
        }
        public void ShowAllGrades()
        {
            ShowIdoGrades();
            ShowHarlemGrades();
            ShowAysonGrades();
            ShowJackieGrades();
            ShowTonGrades();
        }
        public void ShowTonGrades()
        {
            Console.WriteLine("\nTon's Grades:");
            foreach (int grade in tonGrade)
            {
                Console.WriteLine(grade);
            }
        }
        public void ShowJackieGrades()
        {
            Console.WriteLine("\nJackie's Grades:");
            foreach (int grade in jackieGrade)
            {
                Console.WriteLine(grade);
            }
        }
        public void ShowAysonGrades()
        {
            Console.WriteLine("\nAyson's Grades:");
            foreach (int grade in aysonGrade)
            {
                Console.WriteLine(grade);
            }
        }
        public void ShowHarlemGrades()
        {
            Console.WriteLine("\nHarlem's Grades:");
            foreach (int grade in harlemGrade)
            {
                Console.WriteLine(grade);
            }
        }
        public void ShowIdoGrades()
        {
            Console.WriteLine("\nIdo's Grades:");
            foreach (int grade in idoGrade)
            {
                Console.WriteLine(grade);
            }
        }
        public void RemoveMinGrades()
        {
            idoGrade.Remove(idoGrade.Min());
            harlemGrade.Remove(harlemGrade.Min());
            aysonGrade.Remove(aysonGrade.Min());
            jackieGrade.Remove(jackieGrade.Min());
            tonGrade.Remove(tonGrade.Min());
        }
        public void GetAverageOfAverageGrades()
        {
            double average = (idoAverageGrade + harlemAverageGrade + aysonAverageGrade + jackieAverageGrade + tonAverageGrade) / 5;
            Console.WriteLine(average);
        }
        public void ShowAverageGrades()
        {
            Console.WriteLine("\nIdo's average grade:");
            Console.WriteLine(idoAverageGrade);
            Console.WriteLine("\nHarlem's average grade:");
            Console.WriteLine(harlemAverageGrade);
            Console.WriteLine("\nAyson's average grade:");
            Console.WriteLine(aysonAverageGrade);
            Console.WriteLine("\nJackie's average grade:");
            Console.WriteLine(jackieAverageGrade);
            Console.WriteLine("\nTon's average grade:");
            Console.WriteLine(tonAverageGrade);
        }
        public void GetAverageGrades()
        {
            idoAverageGrade = idoGrade.Average();
            harlemAverageGrade = harlemGrade.Average();
            aysonAverageGrade = aysonGrade.Average();
            jackieAverageGrade = jackieGrade.Average();
            tonAverageGrade = tonGrade.Average();
        }
    }
}
