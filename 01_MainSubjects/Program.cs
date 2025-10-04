using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Yazdırma Komutları

            //  Console.WriteLine("Merhaba Dünya");
            //   Console.Write("selam");

            /* Console.WriteLine("**** Yemek kategorileri ****");
               Console.WriteLine();
               Console.WriteLine("1- Çorbalar");
               Console.WriteLine("2- Ana Yemekler");
               Console.WriteLine("3- Soğuk Başlangıçlar");
               Console.WriteLine("4- Salatalar");
               Console.WriteLine("5- Tatlılar");
               Console.WriteLine("6- İçecekler");
               Console.WriteLine();
               Console.WriteLine("**** Yemek Kategorileri****");
            */

            #endregion


            #region String Değişkenler

            //string
            //Değişken_türü değişken_adı;

            /*
            string name;
            name = "beyza";
            console.Write(name);
            

            //kelimenin ilk harfinin küçük diğer kelime harfinin büyük olması cammelCase dir.
            string passengerName;
            string passengerSurname;
            string passengerPhone;
            string passengerEmail, district, city;

            passengerName = "Beyza";
            passengerSurname = "Kılıçaslan";
            passengerPhone = "05302029530";
            passengerEmail = "beyzarabia121@gmail.com";
            district = "Beylikdüzü";
            city = "İstanbul";

            Console.WriteLine("**** Rezervasyon Kartı ****");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Müşteri Adı: " + passengerName+ " " +passengerSurname);
            Console.WriteLine("İletişim:" + passengerPhone);
            Console.WriteLine("Email Adresi: " + passengerEmail);
            Console.WriteLine("Adres: " + district + "/" + city);
            Console.WriteLine("---------------------------------------");

            passengerName = "Ahmet";
            passengerSurname= "Yılmaz";
            passengerPhone = "05432145678";
            passengerEmail = "hsdnfj@gmail.com";
            district = "Kadıköy";
            city = "İstanbul";

            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Müşteri Adı: " + passengerName + " " + passengerSurname);
            Console.WriteLine("İletişim:" + passengerPhone);
            Console.WriteLine("Email Adresi: " + passengerEmail);
            Console.WriteLine("Adres: " + district + "/" + city);
            Console.WriteLine("---------------------------------------");
            */
            #endregion


            #region Int Değişkenler

            //int 
            //int number = 24;
            //Console.WriteLine(number);

            int hamburgerPrice = 300;
            int cokePrice= 50;
            int waterPrice= 10;
            int friesPrice= 100;
            int pizzaPrice= 250;
            int lemonadePrice= 60;

            Console.WriteLine("**** Restoran Menü Fiyatı ****");
            Console.WriteLine();
            Console.WriteLine("----Hamburger: " + hamburgerPrice + " TL");
            Console.WriteLine("----Pizza: " + pizzaPrice+ " TL");
            Console.WriteLine("----Kola: " + cokePrice + " TL");
            Console.WriteLine("----Limonata: " + lemonadePrice + " TL");
            Console.WriteLine("----Kızartma: " + friesPrice + " TL");
            Console.WriteLine("----Su: " + waterPrice + " TL");
            Console.WriteLine();
            Console.WriteLine("**** Restoran Menü Fiyatı ****");

            Console.WriteLine();

            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;

            int totalHamburgerPrice = 0;
            int totalCokePrice = 0;
            int totalWaterPrice = 0;
            int totalFriesPrice = 0;
            int totalPizzaPrice = 0;
            int totalLemonadePrice = 0;



            hamburgerCount = 3;
            cokeCount = 3;
            waterCount = 2;
            friesCount = 1;
            pizzaCount = 0;
            lemonadeCount = 0;


            totalHamburgerPrice = hamburgerPrice * hamburgerCount;
            totalCokePrice = cokePrice * cokeCount;
            totalWaterPrice = waterPrice * waterCount;
            totalFriesPrice = friesPrice * friesCount;
            totalPizzaPrice = pizzaPrice * pizzaCount;
            totalLemonadePrice = lemonadePrice * lemonadeCount;

            Console.WriteLine("--------------------------------");
            Console.WriteLine("Hamburger Tutarı: " + totalHamburgerPrice+" Tl");
            Console.WriteLine("Kola Tutarı: " + totalCokePrice+" Tl");
            Console.WriteLine("Pizza Tutarı: " + totalPizzaPrice+" Tl");
            Console.WriteLine("Kızartma Tutarı: " + totalFriesPrice+" Tl");
            Console.WriteLine("Limonata Tutarı: " + totalLemonadePrice+" Tl");
            Console.WriteLine("Su Tutarı: " + totalWaterPrice+" Tl");


            int totalPrice = totalHamburgerPrice + totalCokePrice + totalWaterPrice + totalFriesPrice + totalPizzaPrice + totalLemonadePrice;

            Console.WriteLine("");
            Console.WriteLine("Toplam Ödenilecek Tutar: " + totalPrice + " TL");

            #endregion


            Console.Read();
        }
    }
}
