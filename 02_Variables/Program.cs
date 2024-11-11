using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Double Değişkenler

            //double number;
            //number = 4.85;

            //Console.WriteLine(number);

            //Console.WriteLine("********** Fiyat Listesi **********");
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine("-----------------------------------");

            //double applePrice, strawberryPrice, orangePrice, potatoPrice, tomatoPrice;
            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.WriteLine("Elma Birim Fiyatı: " + applePrice + " TL");
            //Console.WriteLine("Portakal Birim Fiyatı: " + orangePrice + " TL");
            //Console.WriteLine("Çilek Birim Fiyatı: " + strawberryPrice + " TL");
            //Console.WriteLine("Patates Birim Fiyatı: " + potatoPrice + " TL");
            //Console.WriteLine("Domates Birim Fiyatı: " + tomatoPrice + " TL");

            //Console.WriteLine("-----------------------------------");
            //Console.WriteLine();
            //Console.WriteLine();


            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;

            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram =0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //double appleTotalPrice = applePrice * appleGram;
            //double orangeTotalPrice = orangeGram * orangePrice;
            //double strawberryTotalPrice = strawberryGram * strawberryPrice;
            //double potatoTotalPrice = potatoGram * potatoPrice;
            //double tomatoTotalPrice = tomatoGram * tomatoPrice;

            //Console.WriteLine("-----------------------------------");

            //Console.WriteLine("Alınan Toplam Elma Tutarı: " + appleTotalPrice + " TL");
            //Console.WriteLine("Alınan Toplam Portakal Tutarı: " + orangeTotalPrice + " TL");
            //Console.WriteLine("Alınan Toplam Çilek Tutarı: " + strawberryTotalPrice + " TL");
            //Console.WriteLine("Alınan Toplam Patates Tutarı: " + potatoTotalPrice +  " TL");
            //Console.WriteLine("Alınan Toplam Domates Tutarı: " + tomatoTotalPrice + " TL");

            //Console.WriteLine("-----------------------------------");
            //Console.WriteLine();

            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice +
            //    tomatoTotalPrice;

            //Console.WriteLine("Toplam Alışveriş Tutarı: " + shoppingTotalPrice + " TL");



            #endregion

            #region Char Değişkenler

            //char symbol;
            //symbol = 'a';

            //Console.WriteLine(symbol);



            #endregion

            #region Klavyeden Veri Girişleri String Değişkenler

            //Console.WriteLine("********** CSharp Hava Yolları **********");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;

            //Console.Write("Yolcu adı: ");
            //passengerName = Console.ReadLine();

            //Console.WriteLine();

            //Console.Write("Yolcu soyadı: ");
            //passengerSurname = Console.ReadLine();

            //Console.WriteLine();

            //Console.Write("İlçe Bilgisi: ");
            //passengerDistrict = Console.ReadLine();

            //Console.WriteLine();

            //Console.Write("Şehir Bilgisi: ");
            //passengerCity = Console.ReadLine();

            //Console.WriteLine();

            //Console.Write("Yaş Bilgisi: ");
            //passengerAge = Console.ReadLine();

            //Console.WriteLine();

            //Console.Write("Kimlik Bilgisi: ");
            //passengerIdentityNumber = Console.ReadLine();

            //Console.WriteLine();

            //Console.WriteLine();

            //Console.WriteLine("-----------------------------------------");

            //Console.WriteLine();

            //Console.WriteLine("Yolcu TC Kimlik No: "+passengerIdentityNumber+" , Yolcu Ad Soyad: " + passengerName
            //    + " " + passengerSurname+ " , "+ passengerDistrict+"/"+ passengerCity+" , "+ passengerAge);



            #endregion

            #region Klavyeden Tam Sayı Girişleri Ve Dönüşümler

            //int shoePrice, computerPrice, chairPrice, tvPrice ;

            //shoePrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoeCount, computerCount, chairCount, tvCount;

            //Console.Write("Lütfen aldığınız ayakkabı adedini giriniz: ");
            //shoeCount = int.Parse( Console.ReadLine());

            //Console.Write("Lütfen aldığınız bilgisayar adedini giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız sandalye adedini giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen aldığınız televizyon adedini giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = shoeCount * shoePrice + computerCount * computerPrice + 
            //    chairCount * chairPrice + tvCount * tvPrice;

            //Console.WriteLine("Toplam Ödemeniz Gereken Tutar: " + totalPrice);














            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri

            //double exam1, exam2, exam3, result;

            //Console.Write("Lütfen birinci sınav notunuzu giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen ikinci sınav notunuzu giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen üçüncü sınav notunuzu giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();
            //Console.WriteLine("Sınav Ortalamanız: " + result);




            #endregion

            #region Klavyeden Karakter Girişleri

            char gender;
            Console.Write("Lütfen cinsiyetinizi giriniz: ");
            gender = char.Parse(Console.ReadLine());

            Console.WriteLine("Girdiğiniz cinsiyet: " + gender);


            #endregion

            Console.Read();
        }
    }
}
