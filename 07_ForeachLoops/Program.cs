using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoops
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Foreach Döngüsü

            //string[] cities = { "Milano", "İstanbul", "Malatya", "Varşova", "Madrid" };

            //foreach(string city in cities)
            //{
            //    Console.WriteLine(city);
            //}


            //int[] numbers = { 10, 23, 45, 788, 67, 90, 57, 44, 22 };

            //foreach(int num in numbers)
            //{
            //    if (num % 2 == 0)
            //    {
            //        Console.WriteLine(num);
            //    }
            //}

            //int[] numbers = { 10, 23, 45, 788, 67, 90, 57, 44, 22 };

            //int sum = 0;

            //foreach(int i in numbers)
            //{
            //    sum += i;

            //}

            //Console.WriteLine(sum);


            //List<int> numbers = new List<int>()
            //{
            //    1,4,6,85,55,44,745

            //};

            //foreach(int num in numbers)
            //{
            //    Console.WriteLine(num);
            ////}


            //string merhaba = "Merhaba";

            //foreach(char c in merhaba)
            //{
            //    Console.WriteLine(c);
            //}

            #endregion

            #region Not Hesaplama Uygulaması

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("*************** Not Hesaplama Uygulaması ***************");
            Console.WriteLine();
            Console.WriteLine("********************************************************");
            Console.WriteLine();

            
            // Kullanıcıdan Öğrenci sayısı alma.

            Console.Write("Lütfen öğrenci sayısı giriniz: ");
            int studentCount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine();

            //Öğrenci adları ve sınav ortalamalarını saklayacak diziler.

            string[] studentNames = new string[studentCount];
            double[] studentExamAvg = new double[studentCount];

            for(int i = 0; i < studentCount; i++)
            {
               
                Console.Write($"{i+1}. öğrencinin ismini giriniz: ");
                studentNames[i] = Console.ReadLine();



                double totalExamResult = 0;

                Console.WriteLine();

                for (int j = 0; j < 3; j++)
                {
                    
                    Console.Write($"{studentNames[i]} adlı öğrencinin {j + 1}. sınav notunu giriniz: ");
                    
                    double value = double.Parse(Console.ReadLine());

                    totalExamResult += value;
                    Console.WriteLine();
                }


                studentExamAvg[i] = totalExamResult / 3;

                Console.WriteLine($"{studentNames[i]} adlı öğrencinin ortalaması: { studentExamAvg[i]:0.00}");
                Console.WriteLine();


                if (studentExamAvg[i] < 50)
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci KALDI!");
                    Console.WriteLine();
                    Console.WriteLine("-----------------------------------------------");

                }

                else
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci GEÇTİ!");
                    Console.WriteLine();
                    Console.WriteLine("-----------------------------------------------");

                }


            }




            #endregion


            Console.ReadKey();
        }
    }
}
