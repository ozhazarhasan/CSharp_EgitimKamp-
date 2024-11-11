using System;

namespace _01_MainSubjectss
{
    class Program
    {
        static void Main(string[] args)
        {
            #region YazdırmaKomutları
            //Console.WriteLine("Hello World!");
            //Console.Write("hasan");

            //Console.WriteLine("***** Yemek Kategorileri *****");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soğuk Başlangıçlar");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("***** Yemek Kategorileri *****");
            //Console.Read();
            #endregion

            #region String Değişkenler

            //string name;
            //name = "Hasan";
            //Console.Write(name);

            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, customerDistrict, customerCity ;

            //customerName = "Hasan";
            //customerSurname = "Özhazar";
            //customerPhone = "+90 500 120 00 12";
            //customerEmail = "ozhazarhasan@gmail.com";
            //customerDistrict = "Sultangazi";
            //customerCity = "İstanbul";

            //Console.WriteLine("********** Randevu Kartı **********");
            //Console.WriteLine();

            //Console.WriteLine("-----------------------------------");

            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("EMail Adresi: " + customerEmail);
            //Console.WriteLine("Adresi: " + customerDistrict + "/" + customerCity);

            //Console.WriteLine("-----------------------------------");

            //customerName = "Victor";
            //customerSurname = "Osimhen";
            //customerPhone = "+90 500 162 78 98";
            //customerEmail = "victorosimhen@gmail.com";
            //customerDistrict = "Sarıyer";
            //customerCity = "İstanbul";
            //Console.WriteLine();

            //Console.WriteLine("-----------------------------------");

            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("EMail Adresi: " + customerEmail);
            //Console.WriteLine("Adresi: " + customerDistrict + "/" + customerCity);

            //Console.WriteLine("-----------------------------------");



            #endregion

            #region İnt Değişkenler

            //int number = 23;
            //Console.WriteLine(number);

            int hamburgerPrice = 300;
            int cokePrice = 50;
            int waterPrice = 15;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 50;

            Console.WriteLine("********** Restoran Menü Fiyatı **********");
            Console.WriteLine();

            Console.WriteLine("------------------------------------------");

            Console.WriteLine("Kola: " + cokePrice+ "TL");
            Console.WriteLine("Su: " + waterPrice+ "TL");
            Console.WriteLine("Kızartma: " + friesPrice+ "TL");
            Console.WriteLine("Pizza: " + pizzaPrice + "TL");
            Console.WriteLine("Limonata: " + lemonadePrice + "TL");
            
            Console.WriteLine("------------------------------------------");
            Console.WriteLine();
            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;

            int totalHamburgerPrice = 0;
            int totalCokePrice = 0;
            int totalFriesPrice = 0;
            int totalWaterPrice = 0;
            int totalPizzaPrice = 0;
            int totalLemonadePrice = 0;

            hamburgerCount = 3;
            cokeCount = 3;
            friesCount = 1;
            waterCount = 3;
            pizzaCount = 0;
            lemonadeCount = 0;

            totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            totalCokePrice = cokeCount * cokePrice;
            totalFriesPrice = friesCount * friesPrice;
            totalWaterPrice = waterCount * waterPrice;
            totalPizzaPrice = pizzaCount * pizzaPrice;
            totalLemonadePrice = lemonadeCount * lemonadePrice;

            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Hamburger Tutarı: " + totalHamburgerPrice + " TL");
            Console.WriteLine("Kola Tutarı: " + totalCokePrice + "TL");
            Console.WriteLine("Kızartma Tutarı: " + totalFriesPrice + "TL");
            Console.WriteLine("Su Tutarı: " + totalWaterPrice + "TL");
            Console.WriteLine("Pizza Tutarı: " + totalPizzaPrice + "TL");
            Console.WriteLine("Limonata Tutarı: " + totalLemonadePrice + "TL");
            Console.WriteLine();

            int totalPrice = 0;
            totalPrice = totalHamburgerPrice + totalCokePrice + totalFriesPrice + totalWaterPrice + totalPizzaPrice + totalLemonadePrice;

            Console.WriteLine("Toplam Tutar: " + totalPrice + "TL");

            #endregion


            Console.ReadLine();

        }

    }
}
