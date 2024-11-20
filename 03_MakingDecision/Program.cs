using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    class Program
    {
        static void Main(string[] args)
        {

            #region If Else

            //Console.Write("Lütfen şifrenizi giriniz: ");

            //string password = Console.ReadLine();

            //if (password == "abcd")
            //{
            //    Console.WriteLine("Şifre Doğru!");
            //}

            //else
            ////{
            //    Console.WriteLine("Şifre Yanlış!");
            //}


            //string capital, country;

            //Console.Write("Başkenti giriniz: ");
            //capital = Console.ReadLine();

            //Console.Write("Ülkeyi giriniz: ");
            //country = Console.ReadLine();

            //if (capital == "ankara" & country=="türkiye")
            ////{
            //    Console.Write("Veriler doğrulandı!");
            //}

            //else
            //{
            //    Console.Write("Hatalı Bilgi!");
            //}

            //int number = 5;

            //Console.Write("Lütfen sayıyı giriniz: ");

            //number =int.Parse(Console.ReadLine());

            //if (number == 5)
            //{
            //    Console.WriteLine("Sayı Doğru!");

            //}

            //else
            //{
            //    Console.WriteLine("Sayı Yanlış!");
            //}


            //double exam1, exam2, exam3, average;
            //string result="Hata!";

            //Console.Write("Birinci sınav notunuzu giriniz: ");
            //exam1 =double.Parse( Console.ReadLine());

            //Console.Write("İkinci sınav notunuzu giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Üçüncü sınav notunuzu giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine("Ortalamanız: " + average);

            //if(average>0 & average <= 50)
            //{
            //    result="Sonuç Vasat";

            //}

            //if(average>50 & average <= 70)
            //{
            //    result="Sonuç Orta";
            //}

            //if(average>70 & average<=84)
            //{
            //    result = "Sonuç İyi";
            //}

            //if(average>84)
            //{
            //    result = "Sonuç Çok İyi";
            //}

            //Console.WriteLine(result);


            //string city;
            //Console.Write("Şehir giriniz: ");

            //city = Console.ReadLine();

            //if (city == "Bursa" | city == "Malatya" | city == "İstanbul" | city == "Ankara")
            //{
            //    Console.WriteLine("Şehir mevcut.");

            //}

            //else
            //{
            //    Console.WriteLine("Şehir mevcut değil.");
            ////}


            //Console.Write("Kullanıcı adınızı giriniz: ");
            //string username = Console.ReadLine();

            //if (username != "admin")
            //{
            //    Console.WriteLine("Bu kullanıcı adı kabul edilemez.");
            //}

            //else
            //{
            //    Console.WriteLine("Hoş Geldiniz...");
            //}



            #endregion

            #region Mod İşlemleri

            //int number = 31;
            //int result = number % 5;
            //Console.WriteLine(result);

            //Console.Write("Lütfen birinci sayıyı giriniz: ");
            //int number1 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen ikinci sayıyı giriniz: ");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;

            //Console.WriteLine("Birinci sayının ikinci sayıya bölümünden kalan: " + result);


            //Console.WriteLine("Lütfen bir sayı giriniz: ");

            //int number = int.Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("Sayı Çifttir.");

            //}

            //else
            //{
            //    Console.WriteLine("Sayı Tektir.");
            //}
            #endregion

            #region Char Değişkenler İle Karar Yapıları

            //Console.Write("Takım sembolü giriniz: ");

            //char team = char.Parse(Console.ReadLine());

            //if(team=='g'| team == 'G')
            //{
            //    Console.WriteLine("Galatasaray");
            //}

            //if(team=='f'| team == 'F')
            //{
            //    Console.WriteLine("Fenerbahçe");
            //}

            //if(team=='b'| team == 'B')
            //{
            //    Console.WriteLine("Beşiktaş");
            //}

            //else
            //{
            //    Console.WriteLine("Hatalı sembol girdiniz");
            //}

            #endregion

            #region Örnek Proje Uygulaması

            //Console.WriteLine("***** C# Eğitim Kampı Restoran *****");
            //Console.WriteLine();
            //Console.WriteLine("------------------------------------");
            //Console.WriteLine("1-Ana Yemekler");
            //Console.WriteLine("2-Çorbalar");
            //Console.WriteLine("3-Pizzalar");
            //Console.WriteLine("4-İçecekler");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("------------------------------------");
            //Console.WriteLine();

            //string menuItem;

            //Console.Write("Detayını görmek istediğiniz menüyü seçiniz: ");
            //menuItem = Console.ReadLine();

            //if (menuItem =="1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------- Ana Yemekler ----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Köri Soslu Tavuk");
            //    Console.WriteLine("2-Kızartma Tabağı");
            //    Console.WriteLine("3-Fırında Somon");
            //    Console.WriteLine("4-Fasulye Pilav");
            //    Console.WriteLine("5-Patlıcan Musakka");
            //    Console.WriteLine();
            //    Console.WriteLine("---------- Ana Yemekler ----------");
            //}

            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------- Çorbalar ----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Mercimek Çorbası");
            //    Console.WriteLine("2-Ezogelin Çorbası");
            //    Console.WriteLine();
            //    Console.WriteLine("---------- Çorbalar ----------");

            //}

            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------- Pizzalar ----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Akdeniz Pizza");
            //    Console.WriteLine("2-Margaritha Pizza");
            //    Console.WriteLine("3-Tavuklu Pizza");
            //    Console.WriteLine();
            //    Console.WriteLine("---------- Pizzalar ----------");

            //}

            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------- İçecekler ----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Kola");
            //    Console.WriteLine("2-Ayran");
            //    Console.WriteLine("3-Su");
            //    Console.WriteLine();
            //    Console.WriteLine("---------- İçecekler ----------");
            //}

            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------- Tatlılar ----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Trileçe");
            //    Console.WriteLine("2-Kazandibi");
            //    Console.WriteLine("3-Sütlaç");
            //    Console.WriteLine();
            //    Console.WriteLine("---------- Tatlılar ----------");
            //}



            #endregion

            #region Switch Case

            //Console.WriteLine("Lütfen Ay girişi yapınız: ");

            //int monthNumber = int.Parse(Console.ReadLine());

            //switch (monthNumber)
            //{
            //    case 1:Console.Write("Ocak"); break;

            //    case 2: Console.Write("Şubat"); break;

            //    case 3: Console.Write("Mart"); break;

            //    case 4: Console.Write("Nisan"); break;

            //    case 5: Console.Write("Mayıs"); break;

            //    case 6: Console.Write("Haziran"); break;

            //    case 7: Console.Write("Temmuz"); break;

            //    case 8: Console.Write("Ağustos"); break;

            //    case 9: Console.Write("Eylül"); break;

            //    case 10: Console.Write("Ekim"); break;

            //    case 11: Console.Write("Kasım"); break;

            //    case 12: Console.Write("Aralık"); break;

            //    default: Console.WriteLine("Hatalı veri girişi!");break;
            //}



            #endregion

            #region Switch Case İle Hesap Makinesi

            //Console.Write("Birinci sayıyı giriniz: ");
            //double number1 = double.Parse(Console.ReadLine());

            //Console.Write("İkinci sayıyı giriniz: ");
            //double number2 = double.Parse(Console.ReadLine());

            //double result;
            //char process;

            //Console.Write("Lütfen yapmak istediğiniz işlemi seçiniz: ");
            //process = char.Parse(Console.ReadLine());

            //switch (process)
            //{
            //    case '+':
            //        result = number1 + number2;
            //        Console.WriteLine("Sonuç: " + result);
            //        break;

            //    case '-':
            //        result = number1 - number2;
            //        Console.WriteLine("Sonuç: " + result);
            //        break;

            //    case '*':
            //        result = number1 * number2;
            //        Console.WriteLine("Sonuç: " + result);
            //        break;

            //    case '/':
            //        result = number1 / number2;
            //        Console.WriteLine("Sonuç: " + result);
            //        break;

            //    default:Console.WriteLine("Hatalı giriş yaptınız!!!");
            //        break;


            //}

            
            #endregion


            Console.Read();
        }
    }
}
