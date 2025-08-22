using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Geriye Değer Döndüren Metotlar

            //string studentCard()
            //{
            //    string studentName = "Buse";
            //    string studentSurname = "Yıldız";

            //    return studentName + " " + studentSurname;
            //}

            //Console.WriteLine("Öğrenci Kartı: " + studentCard());

            #endregion

            #region Geriye Değer Döndüren Parametreli Metotlar

            // string CountryCard(string countryName, string capital, string flagColor)
            // {
            //     string cardInfo = "Ülke: " + countryName + " Başkent: " + capital + "- Bayrak Rengi: " + flagColor;
            //     return cardInfo;
            // }

            // string x, y, z;
            // Console.WriteLine("Ülke Adı: ");
            // x = Console.ReadLine();

            // Console.WriteLine("Başkent Adı: ");
            // y = Console.ReadLine();

            // Console.WriteLine("Bayrak Rengi: ");
            // z = Console.ReadLine();

            //Console.WriteLine( CountryCard(x, y, z));

            //Console.WriteLine(CountryCard("Türkiye", "Ankara", "Kırmızı"));



            #endregion

            #region Geriye Değer Döndüren Int Parametreli Metotlar

            //int Sum(int number1,int number2)
            //{
            //    int result = number1 + number2;
            //    return result;
            //}

            //Console.WriteLine(Sum(2, 5));
            #endregion

            #region Örnek Uygulama

            string ExamResult(string student, int exam1, int exam2, int exam3)
            {
                int result = (exam1 + exam2 + exam3) / 3;
                if (result >= 50)
                {
                    return "Öğrenci sınavı geçti "+ "ortalama: " + result;
                }
                else
                {
                    return "Kaldı " + "ortlama: " + result;
                }
            }

            Console.WriteLine(ExamResult("Ali", 25, 5, 85));
            Console.WriteLine(ExamResult("Ayşe",88, 41, 85));

            #endregion

            Console.Read();
        }
    }
}
