using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü

            //string[] cities = { "İstanbul", "Ankara", "İzmir", "Bursa", "Antalya" };
            //foreach (string city in cities)
            //{
            //    Console.WriteLine(city);
            //

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //foreach (int number in numbers)
            //{
            //    if (number % 2 == 0)
            //    {
            //        Console.WriteLine("Çift sayılar: " + number);
            //    }
            //}

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //int total = 0;
            //foreach (int number in numbers)
            //{
            //    total += number;
            //}
            //Console.WriteLine("Toplam: " + total);

            //List<int> numberList = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //foreach (int number in numberList)
            //{
            // Console.WriteLine(number);
            //}

            //string word = "Foreach";
            
            //foreach (char letter in word)
            //{
            //    Console.WriteLine(letter);
            //}

            #endregion

            #region Sınav Sistemi

            Console.WriteLine("C# Sınav Sistemine Hoşgeldiniz!");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Sınıfınızda kaç kişi var ?");
            int studentCount = int.Parse(Console.ReadLine());
            Console.WriteLine("--------------------------------");

            string[] studentNames = new string[studentCount];
            double[] studentAvgGrades = new double[studentCount];

            for(int i = 0;  i< studentCount; i++ )
            {
                Console.Write($"{i + 1}. öğrenci ismini giriniz: ");
                studentNames[i] = Console.ReadLine();

                double totalExamResult = 0; 

                for(int j = 1; j <= 3; j++)
                {
                    Console.Write($"{studentNames[i]} adlı öğrencinin {j}. sınav notunu giriniz: ");
                    double value = double.Parse(Console.ReadLine());
                    totalExamResult += value;
                }
                Console.WriteLine();
                studentAvgGrades[i] = totalExamResult / 3;
                Console.WriteLine("--------------------------------");

            }

            for(int k = 0; k < studentCount; k++)
            {
                Console.WriteLine($"{studentNames[k]} adlı öğrencinin sınav ortalaması: {studentAvgGrades[k]}");

                if (studentAvgGrades[k] >= 50)
                {
                    Console.WriteLine($"{studentNames[k]} adlı öğrenci sınavı geçti.");
                }
                else
                {
                    Console.WriteLine($"{studentNames[k]} adlı öğrenci sınavı kaldı.");
                }

                Console.WriteLine("--------------------------------");  

            }

            #endregion
            Console.Read();
        }
    }
}
