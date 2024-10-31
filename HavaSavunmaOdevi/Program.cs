using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HavaSavunmaOdevi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double mermiHizi, yukseklik, mesafe, maxYukseklik;

            mermiHizi = VeriAl("mermiHizi");
            yukseklik = VeriAl("yukseklik");
            mesafe = VeriAl("mesafe");

            maxYukseklik = MaxYukseklikHesapla(mermiHizi);

            if (maxYukseklik < yukseklik)
            {
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine("\nHedefi vuramazsınız. Devam etmek için lütfen herhangi bir tuşa basınız.");
                Console.ReadKey();
                return;
            }

            double gerekenAci = AciHesapla(mesafe, yukseklik, mermiHizi);

            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("\nUçağı vurmak için gereken açı: " + gerekenAci);
            Console.WriteLine("Devam etmek için lütfen herhangi bir tuşa basınız.");
            Console.ReadKey();
        }

        #region Metotlar

        static double MaxYukseklikHesapla(double mermiHizi)
        {
            const double yerCekimi = 9.81;
            return Math.Pow(mermiHizi, 2) / (2 * yerCekimi);
        }
        
        static double VeriAl(string veriAdi)
        {
            if (veriAdi == "mermiHizi")
            {
                Console.WriteLine("---HAVA SAVUNMA SISTEMI ARAYUZUNE HOSGELDINIZ---");
                Console.Write("\nLütfen mermi hızını m/s cinsinden giriniz: ");
            }
            else if (veriAdi == "yukseklik")
            {
                Console.Write("\nLütfen hedefin yerden yüksekliğini metre cinsinden giriniz: ");
            }
            else
            {
                Console.Write("\nLütfen hedefin topa göre uzaklığını metre cinsinden giriniz: ");
            }

            return Convert.ToDouble(Console.ReadLine());
        }

        static double AciHesapla(double mesafe, double yukseklik, double mermiHizi)
        {
            double tahmin = 45d;
            double tolerans = 1e-6;
            double aci = tahmin;

            for (int sayac = 0; sayac < 1000; sayac++)
            {
                double y = YEkseniHesapla(aci, mesafe, mermiHizi);
                double hata = y - yukseklik;

                if (Math.Abs(hata) < tolerans)
                {
                    break;
                }

                aci -= hata * 0.01;
                aci = Math.Max(0, Math.Min(90, aci));
            }

            return aci;
        }

        static double YEkseniHesapla(double aci, double mesafe, double mermiHizi)
        {
            const double yerCekimi = 9.81;
            double radyan = DerecedenRadyanaCevir(aci);
            double zaman = mesafe / (mermiHizi * Math.Cos(radyan));
            return mermiHizi * Math.Sin(radyan) * zaman - (0.5 * yerCekimi * Math.Pow(zaman, 2));
        }

        static double DerecedenRadyanaCevir(double aci)
        {
            return aci * Math.PI / 180d;
        }

        #endregion
    }
}
