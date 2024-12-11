using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Void (Değer Döndürmeyen) Metotlar

            //void customerList()
            //{
            //    Console.WriteLine("Hasan Özhazar");
            //    Console.WriteLine("Mahmut Yıldırım");
            //    Console.WriteLine("Mete Erpek");
            //    Console.WriteLine("Fatih Uslu");
            //}

            //customerList();

            //void sum()
            //{
            //    int x = 3;
            //    int y = 2;
            //    int z = y + x;
            //    Console.WriteLine(z);

            //}


            //sum();


            #endregion

            #region Geriye Değer Döndürmeyen String Parametreli Metotlar

            //void customerCard(string name,string surName)
            //{
            //    Console.WriteLine("Ad: " + name + ", Soyad: " + surName);

            //}

            //customerCard("Hasan","Özhazar");
            //customerCard("Cristiano", "Ronaldo");

            #endregion

            #region Geriye Değer Döndürmeyen String Parametreli Metotlar

            //void Sum(int number1,int number2,int number3)
            //{
            //    int result = number1 + number2 + number3;
            //    Console.WriteLine(result);
            //}

            //Sum(1, 89, 4);

            #endregion

            #region Geriye Değer Döndüren Metotlar

            //string StudentCard()
            //{
            //    string name = "Hasan";
            //    string surname = "Özhazar";
            //    return name + " " + surname;
            //}

            //Console.WriteLine(StudentCard());


            #endregion

            #region Geriye Değer Döndüren String Parametreli Metotlar

            //string CountryCard(string country, string capital,string flagColor)
            //{
            //    string cardInfo = "Ülke: " + country + " - Başkent: " + capital + " - Bayrak rengi: " +
            //        flagColor;
            //    return cardInfo;
            //}


            //string x, y, z;
            //Console.Write("Ülke adı giriniz: ");
            //x = Console.ReadLine();
            //Console.Write("Ülkenizin başkentini giriniz: ");
            //y = Console.ReadLine();
            //Console.Write("Ülkenizin bayrak rengini giriniz: ");
            //z = Console.ReadLine();

            //Console.WriteLine(CountryCard(x, y, z));



            #endregion

            #region Geriye Değer Döndüren Int Parametreli Metotlar

            //int Sum(int number1,int number2)
            //{
            //    int result = number1 + number2;
            //    return result;

            //}

            //Console.WriteLine(Sum(55, 45));
            //Console.WriteLine(Sum(44, 84));
            #endregion

            #region Örnek Uygulama

            string ExamResult(string student,double exam1,double exam2,double exam3)
            {
                double result = (exam1 + exam2 + exam3)/ 3;
                if (result >= 50)
                {
                    return student + " adlı öğrenci başarılı oldu!" + "  Ortalaması: " + result.ToString("F2");
                }

                else
                {
                    return  student + " adlı öğrenci başarısız oldu!"+" , Ortalaması: "+result.ToString("F2");
                }

               
            }

            Console.WriteLine(ExamResult("Hasan Özhazar", 85, 90, 77));
            Console.WriteLine(ExamResult("Ayşe Çayır", 85, 20, 37));
            Console.WriteLine(ExamResult("Polat Alemdar", 85, 10, 77));


            #endregion

            Console.Read();

        }
    }
}
