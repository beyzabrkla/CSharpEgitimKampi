﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If Else
            /*
            Console.Write("Lütfen Şifreyi Giriniz:");
            string password;
            password = Console.ReadLine();
            if (password == "abcd")
            {
                Console.WriteLine("Şifre Doğru");

            }
            else
            {
                Console.WriteLine("Şifre Yanlış");
            }
            */


            /*
            string capital, country;
            Console.WriteLine("Başkenti Giriniz:");
            capital = Console.ReadLine();

            Console.WriteLine("Ülkeyi Giriniz:");
            country = Console.ReadLine();

            if (capital=="Ankara" & country == "Türkiye")
            {
                Console.WriteLine("Veriler Doğrulandı");
            }
            else
            {
                Console.WriteLine("Veriler Hatalı");
            }
            */


            /*
            int number; 
            Console.WriteLine("Bir Sayı Giriniz:");
            number =int.Parse(Console.ReadLine());

            if(number == 5)
            {
                Console.WriteLine("Sayı Doğru");
            }
            else
            {
                Console.WriteLine("Sayı Yanlış");
            }   
            */


            /*
            int exam1, exam2, exam3, average;
            string result= "Hata";

            Console.WriteLine("1. Sınav Notunu Giriniz:");
            exam1 = int.Parse(Console.ReadLine());

            Console.WriteLine("2. Sınav Notunu Giriniz:");
            exam2 = int.Parse(Console.ReadLine());

            Console.WriteLine("3. Sınav Notunu Giriniz:");
            exam3 = int.Parse(Console.ReadLine());

            average = (exam1 + exam2 + exam3) / 3;
            Console.WriteLine("Ortalamanız:" + average);

            if (average > 0 & average < 50)
            {
                result = "Kaldınız";
            }
            if (average > 50 & average <= 70)
            {
                result = "Sonuç Orta";
            }
            if (average > 71 & average <= 84)
            {
                result = "Sonuç İyi";
            }
            if (average > 84)
            {
                result = "Sonuç Mük";
            }

            Console.WriteLine(result);
            */


            /*
            string city;
            Console.WriteLine("Lütfen Şehir Giriniz:");
            city= Console.ReadLine();

            if (city=="adana" | city == "ankara" | city=="bursa" | city=="trabzon")
            {
                Console.WriteLine("Şehir Mevcut");
            }
            else
            {
                Console.WriteLine("Şehir Mevcut Değil");
            }
            */


            /*
            Console.WriteLine("Lütfen Kullanıcı Adınızı Giriniz:");
            string username= Console.ReadLine();

            if (username!="admin")
            {
                Console.WriteLine("Bu Kullanıcı Adı Kabul Edilemez");
            }
            else
            {
                Console.WriteLine("Hoş Geldiniz");
            }
            */

            #endregion Else

            #region Mod İşlemleri

            /*
            int number;
            number = 26;
            Console .WriteLine(result);
            */


            /*
            Console .WriteLine("Lütfen 1.Sayıyı Giriniz:");
            int number1= int.Parse(Console.ReadLine());

            Console .WriteLine("Lütfen 2. Sayıyı Giriniz:");
            int number2=int.Parse(Console.ReadLine());

            int result= number1 % number2;

            Console.WriteLine("1.Sayının 2. Sayıya bölümünden kalan: " + result);
            */

            /*
            Console.WriteLine("Lütfen Sayıyı Giriniz:");
            int number  = int.Parse(Console.ReadLine());

            if(number %2 == 0)
            {
                Console.WriteLine("Sayı Çifttir.");
            }
            else
            {
                Console.WriteLine("Sayı Tektir.");
            }
            */

            #endregion

            #region Char Değişkenler İle Karar Yapıları
            /*
            char team;
            Console.WriteLine("Lütfen Takım Sembolünü Giriniz:");
            team = char.Parse(Console.ReadLine());

            if (team == 'g' | team == 'G')
            {
                Console.WriteLine("Galatasaray");
            }

            if (team == 'f' | team == 'F')
            {
                Console.WriteLine("Fenerbahçe");
            }

            if (team =='b' | team== 'B')
            {
                Console.WriteLine("Beşiktaş");
            }
                Console.ReadLine();
            */

            #endregion

            #region Örnek Proje Uygulaması
            /*
            Console.WriteLine("****** CSharp Eğitim Kampı Restoran *******");
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------");

            Console.WriteLine("1- Ana Yemekler");
            Console.WriteLine("2- Çorbalar");
            Console.WriteLine("3- Pizzalar");
            Console.WriteLine("4- İçecekler");
            Console.WriteLine("5- Tatlılar");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine();



            string menuItem;

            Console.Write("Detayını Görmek İstediğiniz Menüyü Seçin:");
            menuItem = Console.ReadLine();

            if (menuItem == "1")
            {
                Console.WriteLine();
                Console.WriteLine("---------------------Ana Yemekler-------------------------");
                Console.WriteLine();
                Console.WriteLine("1- Köri Soslu Tavuk");
                Console.WriteLine("2- Kızartma Tabağı");
                Console.WriteLine("3- Kuru Fasulye Pilav");
                Console.WriteLine("4- Fırında Somon");
                Console.WriteLine("5- Patlıcan Musakka");
                Console.WriteLine();

                Console.WriteLine("---------------------Ana Yemekler-------------------------");

                Console.WriteLine();

            }

            if (menuItem == "2")
            {
                Console.WriteLine();
                Console.WriteLine("---------------------Çorbalar-------------------------");
                Console.WriteLine();
                Console.WriteLine("1- Mercimek Çorbası");
                Console.WriteLine("2- Ezogelin Çorbası");
                Console.WriteLine("3- Tarhana Çorbası");
                Console.WriteLine();

                Console.WriteLine("---------------------Çorbalar-------------------------");

                Console.WriteLine();
            }

            if (menuItem == "3")
            {
                Console.WriteLine();
                Console.WriteLine("---------------------Pizalar-------------------------");
                Console.WriteLine();
                Console.WriteLine("1- Margarita");
                Console.WriteLine("2- Tavuklu Pizza");
                Console.WriteLine();

                Console.WriteLine("---------------------Pizzalar-------------------------");

                Console.WriteLine();
            }

            if (menuItem == "4")
            {
                Console.WriteLine();
                Console.WriteLine("---------------------İçecekler-------------------------");
                Console.WriteLine();
                Console.WriteLine("1- Kola");
                Console.WriteLine("2- Ayran");
                Console.WriteLine("3- Su");
                Console.WriteLine();

                Console.WriteLine("---------------------İçecekler-------------------------");

                Console.WriteLine();
            }

            if (menuItem == "5")
            {
                Console.WriteLine();
                Console.WriteLine("---------------------Tatlılar-------------------------");
                Console.WriteLine();
                Console.WriteLine("1- Sufle");
                Console.WriteLine("2- Trileçe");
                Console.WriteLine("3- Ekler");
                Console.WriteLine();

                Console.WriteLine("---------------------Tatlılar-------------------------");

                Console.WriteLine();
            }
            */

            #endregion

            #region Switch Case 

            /*
            Console.Write("Lütfen Ay Numarasını Giriniz: ");
            int monthNumber = int.Parse(Console.ReadLine());

            switch (monthNumber)
            {
                case 1:Console.WriteLine("Ocak"); break;
                case 2:Console.WriteLine("Şubat"); break;
                case 3:Console.WriteLine("Mart"); break;
                case 4:Console.WriteLine("Nisan"); break;
                case 5:Console.WriteLine("Mayıs"); break;
                case 6:Console.WriteLine("Haziran"); break;
                case 7:Console.WriteLine("Temmuz"); break;
                case 8:Console.WriteLine("Ağustos"); break;
                case 9:Console.WriteLine("Eylül"); break;
                case 10:Console.WriteLine("Ekim"); break;
                case 11:Console.WriteLine("Kasım"); break;
                case 12:Console.WriteLine("Aralık"); break;

                default : Console.WriteLine("Hatalı Veri Girişi"); break;

            }

            */







            #endregion

            #region Hesap Makinesi
            /*
            int number1, number2, result;
            char symbol;

            Console.WriteLine("1.Sayıyı Giriniz:");
            number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("2.Sayıyı Giriniz:");
            number2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Lütfen Yapmak İstediğiniz İşlemi Giriniz");
            symbol = char.Parse(Console.ReadLine());

            switch (symbol)
            {
                case '+':
                    result=number1 + number2; ;
                    Console.WriteLine("Toplam: " + result);
                    break;


                case '-':
                    result=number1 - number2; 
                    Console.WriteLine("Fark: " + result);
                    break;

                case '/':
                    result=number1 / number2;
                    Console.WriteLine("Çarpım: " + result);
                    break;

                case '*':
                    result=number1*number2; 
                    Console.WriteLine("BÖlüm: " + result);
                    break;

                default:Console.WriteLine("Lütfen doğru bir işlem seçiniz");
                    break;
            }
            */






            #endregion


            Console.Read();

        }
    }
}

