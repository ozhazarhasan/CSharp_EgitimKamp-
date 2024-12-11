using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Temel Dizi Örnekleri

            //string[] colors = new string[4];

            //colors[0] = "Sarı";
            //colors[1] = "Kırmızı";
            //colors[2] = "Yeşil";
            //colors[3] = "Mavi";

            ////Console.WriteLine(colors[2]);

            //string[] cities = new string[4];
            //cities[0] = "Malatya";
            //cities[1] = "Paris";
            //cities[2] = "Ankara";
            //cities[3] = "İstanbul";

            //Console.WriteLine(cities[3]);

            //int[] numbers = new int[5];

            //numbers[0] = 22;
            //numbers[1] = 36;
            //numbers[2] = 68;
            //numbers[03] = 44;
            //numbers[4] = 840;

            //Console.WriteLine(numbers[0]);

            //string[] cities = { "Roma", "Kopenhag", "milano", "Prag" };
            //Console.WriteLine(cities[3]);




            #endregion

            #region Dizideki Tüm Elemanları Listeleme

            //string[] colors = { "Sarı", "Kırmızı", "Yeşil", "Mavi" };

            //for(int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}

            //int[] numbers = { 19, 24, 88, 44, 31, 68, 120, 76, 43, 81 };

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}


            //char[] symbols = { 'a', 'b', '*', '/' };

            //for(int i = 0; i < symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}

            //int[] myArray = { 16, 45, 44, 68, 544, 789 };

            //int maxNum = myArray[0];

            //for(int i = 0; i < myArray.Length; i++)
            //{
            //    if (myArray[i] > maxNum)
            //    {
            //        maxNum = myArray[i];

            //    }


            //}

            ////Console.WriteLine("En büyük sayı: " + maxNum);


            //string[] persons = { "Hasan", "deniz", "Mami", "nazo" };

            ////Console.WriteLine(persons.Length);

            //int[] numbers = { 14, 44, 65, 78, 43, 21, 90, 102 };
            //Array.Sort(numbers);

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}


            //int[] numbers = { 14, 44, 65, 78, 43, 21, 90, 102 };
            //Array.Reverse(numbers);

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}


            #endregion

            #region Dizi Metotları

            //string[] customers = { "Hasan", "Mami", "Eray", "Merve", "Selin", "Beyza" };

            //int index = Array.IndexOf(customers,"Eray");
            //Console.WriteLine(index);
            //int[] numbers = { 1, 89, 23, 45, 32, 78, 99, 156, 6547, 584 };

            //Console.WriteLine("Dizinin en büyük elemanı: " + numbers.Max() +" // " +"Dizinin en küçük elemanı: "  +numbers.Min());



            #endregion

            #region Kullanıcıdan Değer Alma


            //string[] cities = new string [5];

            //for(int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i+1}. Şehri giriniz: ");
            //    cities[i] = Console.ReadLine();
            //}

            //Console.WriteLine();
            //Console.WriteLine("-------------------------------");

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}


            //int[] numbers = { 13, 25, 17, 15, 58, 36, 95 };

            //int sum = 0;


            //for(int i=0;i<numbers.Length;i++)
            //{
            //    sum +=numbers[i];

            //}

            //Console.WriteLine("Toplam: " + sum);


            //int[] numbers = { 15, 56, 23, 89, 47, 25, 14, 58, 95, 44, 20 };

            //Console.WriteLine("***** Çift Sayılar *****");

            //for(int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //Console.WriteLine();
            //Console.WriteLine("***********************");
            //Console.WriteLine();
            //Console.WriteLine("***** Tek Sayılar *****");

            //for(int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 1)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}
















            #endregion

            Console.Read();


        }
    }
}
