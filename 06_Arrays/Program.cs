using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        private static int length;
        private static int i;

        static void Main(string[] args)
        {
            #region Temel Dizi Örnekleri

            //string[] colors = new string[4];
            //colors[0] = "Kırmızı";
            //colors[1] = "Yeşil";   
            //colors[2] = "Mavi";
            //colors[3] = "Sarı";

            //Console.WriteLine(colors[2]);

            //string[] cities = new string[5];
            //cities[0] = "İstanbul";
            //cities[1] = "Ankara";   
            //cities[2] = "İzmir";
            //cities[3] = "Bursa";   
            //cities[4] = "Antalya";

            //Console.WriteLine(cities[5]);

            //int [] numbers = new int[10];
            //numbers[0] = 1; 
            //numbers[1] = 2;
            //numbers[2] = 3; 
            //numbers[3] = 4;
            //numbers[4] = 5;

            //numbers[6] = 7;
            //numbers[7] = 8;
            //numbers[8] = 9;
            //numbers[9] = 10;
            //Console.WriteLine(numbers[5]);

            //string[] animals = { "Kedi", "Köpek", "Kuş", "Maymun" };
            //Console.WriteLine(animals[2]);

            #endregion

            #region Dizideki Tüm Elemanları Yazdırma
            //string[] colors = { "Kırmızı", "Yeşil", "Mavi", "Sarı" };

            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //for (int i = 0; i <numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }

            //}

            //char [] symbols = { '!', '?', '*', '+', '-', '/', '%', '&', '#', '@' };
            //for (int i = 0; i < symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}

            //int[] myArray = { 47, 85 , 95, 899, 25, 36, 74, 12, 63, 49};

            //int maxNumber = myArray[0];

            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    if (myArray[i] > maxNumber)
            //    {
            //        maxNumber = myArray[i];
            //    }
            //}
            //Console.WriteLine("Dizideki en büyük sayı: " + maxNumber);

            //string[] cities = { "İstanbul", "Ankara", "İzmir", "Bursa", "Antalya", "Adana", "Trabzon", "Samsun", "Diyarbakır", "Gaziantep" };
            //Console.WriteLine(cities.Length);

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //Array.Sort(numbers);

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //Array.Reverse(numbers);
            //for (int i = 0; i < length; i++)
            //{

            //}

            //Console.WriteLine(numbers[i]);

            #endregion

            #region Dizi Metotları

            //string[] customers = { "Ahmet", "Mehmet", "Ayşe", "Fatma", "Zeynep" };
            //int index = Array.IndexOf(customers, "Ayşe");
            //Console.WriteLine("Aranan elemanın dizindeki yeri: " + index);

            //int [] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //Console.WriteLine("Dizideki en büyüğü: " + numbers.Max() + " En küçüğü: " + numbers.Min());

            #endregion

            #region Kullanıcıdan Diziye Eleman Eklemek

            //string[] cities = new string[5];

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i + 1}. şehir ismini giriniz: ");
            //    cities[i] = Console.ReadLine();
            //}
            
            //int[] numbers = {10, 20, 30, 40, 50, 60, 70, 80, 90, 100};
            //int sum = 0;

            //for (int j = 0; j < numbers.Length; j++)
            //{
            //    sum += numbers[i];
            //}

            //Console.WriteLine(sum);

            //    int[] numbers = { 1,2,3,4,5,6,7,8,9,10 };
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //    {
            //        Console.WriteLine("Çift sayılar: " + numbers[i]);
            //    }
            //}

            //for (i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 != 0)
            //    {
            //        Console.WriteLine("Tek sayılar: " + numbers[i]);
            //    }
            //}

         

            #endregion


            Console.Read();
        }
    }
}
