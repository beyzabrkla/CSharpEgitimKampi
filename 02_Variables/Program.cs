﻿using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Değişkenler

            /*
            double number;

            number = 4.85;

            Console.WriteLine(number);
            
            Console.WriteLine("**** Fiyat Listesi");
            Console.WriteLine();

            double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            applePrice = 14.85;
            orangePrice = 20.95;
            strawberryPrice = 45;
            potatoPrice = 9.74;
            tomatoPrice = 6.88;

            Console.WriteLine("----Elma Birim Fiyatı : " + applePrice + " TL");
            Console.WriteLine("----Portakal Birim Fiyatı : " + orangePrice+ " TL");
            Console.WriteLine("----Çilek Birim Fiyatı : " + strawberryPrice + " TL");
            Console.WriteLine("----Patates Birim Fiyatı : " + potatoPrice + " TL");
            Console.WriteLine("----Domates Birim Fiyatı : " + tomatoPrice + " TL");

            Console.WriteLine();
            Console.WriteLine();

            double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;

            appleGram = 1.245;
            orangeGram = 2.650;
            strawberryGram = 0.750;   
            potatoGram = 4.859;
            tomatoGram = 3.745;

            double appleTotalPrice= applePrice * appleGram;
            double orangeTotalPrice= orangePrice * orangeGram;
            double strawberryTotalPrice= strawberryPrice * strawberryGram;
            double potatoTotalPrice= potatoPrice * potatoGram;
            double tomatoTotalPrice= tomatoPrice * tomatoGram;

            Console.WriteLine("Alınan Ürün: Elma - "+ "Birim Fiyat "+ applePrice+ " TL "+" - Gramaj: "+ appleGram+ " - Toplam Tutar: "+ appleTotalPrice+ " TL" );
            Console.WriteLine("Alınan Ürün: Portakal - "+ "Birim Fiyat "+ orangePrice+ " TL "+" - Gramaj: "+ orangeGram+ " - Toplam Tutar: "+ orangeTotalPrice+ " TL" );
            Console.WriteLine("Alınan Ürün: Çilek - "+ "Birim Fiyat "+ strawberryPrice+ " TL "+" - Gramaj: "+ strawberryPrice+ " - Toplam Tutar: "+ strawberryTotalPrice+ " TL" );
            Console.WriteLine("Alınan Ürün: Patates - "+ "Birim Fiyat "+ potatoPrice+ " TL "+" - Gramaj: "+ potatoGram+ " - Toplam Tutar: "+ potatoTotalPrice+ " TL" );
            Console.WriteLine("Alınan Ürün: Domates - "+ "Birim Fiyat "+ tomatoPrice+ " TL "+" - Gramaj: "+ tomatoGram+ " - Toplam Tutar: "+ tomatoTotalPrice+ " TL" );


            double shoppingtotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice;
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Alışveriş Tutarı: " + shoppingtotalPrice + " TL");
            */
            #endregion


            #region Char Değişkenler

            //TOPLANTI SAAT 20:00 'DA
            /*
            char symbol;
            
            symbol = 'A';

            Console.WriteLine(symbol);
            */
            #endregion


            #region Klavyeden Veri Girişleri String Değişkenler
            /*
            Console.WriteLine("**** CSharp HavaYolları Yolcu Bilgisi ****");
            Console.WriteLine();

            string passengerName, passengerSurname,  passengerCity, passengerDistrict, passengerAge, passengerIdentityNumber;

            Console.Write(" Yolcu Adı: ");
            passengerName = Console.ReadLine();

            Console.Write(" Yolcu Soyadı: ");
            passengerSurname = Console.ReadLine();


            Console.Write(" İlçe Bilgisi: ");
            passengerDistrict = Console.ReadLine();

            Console.Write(" Şehir Bilgisi: ");
            passengerCity = Console.ReadLine();


            Console.Write(" Yolcu Yaş: ");
            passengerAge = Console.ReadLine();

            Console.Write(" Yolcu TC Kimlik No: ");
            passengerIdentityNumber = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("--------------------------");
            Console.WriteLine("Yolcu TC Kimlik Numarası :"+ passengerIdentityNumber+" -  "+" Yolcu Ad Soyad:"+ passengerName + passengerSurname + " "+ passengerDistrict + " / "+ passengerCity+ " "+ passengerAge);
            */

            #endregion


            #region Klavyede Tam Sayı Girişleri ve Dönüşümler

            /*
            int shoesPrice, computerPrice, chairPrice, tvPrice;
            shoesPrice = 1000;
            computerPrice = 20000;
            chairPrice = 5000;
            tvPrice = 12000;

            int shoesCount, computerCount, chairCount, tvCount;

            Console.WriteLine("**** Lütfen aldığınız ayakkabı sayısını giriniz: ****");
            shoesCount=int.Parse(Console.ReadLine());//klavyeden girilen değeri int cinsine dönüştürür.

            Console.WriteLine("**** Lütfen aldığınız bilgisayar sayısını giriniz: ****");
            computerCount = Convert.ToInt32(Console.ReadLine());//klavyeden girilen değeri int cinsine dönüştürür.

            Console.WriteLine("**** Lütfen aldığınız sandalye sayısını giriniz: ****");
            chairCount = int.Parse(Console.ReadLine());//klavyeden girilen değeri int cinsine dönüştürür.

            Console.WriteLine("**** Lütfen aldığınız televizyon sayısını giriniz: ****");
            tvCount = Convert.ToInt32(Console.ReadLine());//klavyeden girilen değeri int cinsine dönüştürür.

            int totalPrice = (shoesPrice * shoesCount) + (computerPrice * computerCount) + (chairPrice * chairCount) + (tvPrice * tvCount);

            Console.WriteLine();
            Console.WriteLine("Toplam Ödemeniz Gereken Tutar: " + totalPrice + " TL");
            */


            #endregion


            #region Klavyeden Ondalıklı Sayı İşlemleri
            /*
            double exam1, exam2, exam3, result;

            Console.WriteLine("Lütfen 1. Sınav Notunuzu Giriniz:");
            exam1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Lütfen 2. Sınav Notunuzu Giriniz:");
            exam2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Lütfen 3. Sınav Notunuzu Giriniz:");
            exam3 = double.Parse(Console.ReadLine());

             result = (exam1 + exam2 + exam3) / 3;

            Console.WriteLine();
            Console.WriteLine("Sınav Not Ortalamanız: " + result);
            */


            #endregion


            #region Klavyeden Karakter Girişleri
            /*
            char gender;

            Console.WriteLine("Lütfen Cinsiyet Seçiniz:");
            gender= char.Parse(Console.ReadLine());

            Console.WriteLine("Seçtiğiniz Cinsiyet: " + gender);
            */

            #endregion


            Console.Read();
        }
    }
}
