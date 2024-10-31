using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HavaSavunmaOdeviBasit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Değişken Tanımlama

            double yukseklik, mesafe, maxYukseklik, gerekenAci,tahminAci, tolerans, hata, y, radyan, zaman;
            const double yerCekimi = 9.81;
            const double mermiHizi = 100d;

            #endregion

            #region Dışarıdan Değişken Alma

            Console.WriteLine("---HAVA SAVUNMA SISTEMI ARAYUZUNE HOSGELDINIZ---");
            Console.Write("\nLütfen hedefin yerden yüksekliğini metre cinsinden giriniz: ");
            yukseklik = double.Parse(Console.ReadLine());

            Console.Write("\nLütfen hedefin topa göre uzaklığını metre cinsinden giriniz: ");
            mesafe = double.Parse(Console.ReadLine());

            #endregion

            #region Maksimum Yükseklik Hesaplaması ve Karşılaştırma

            maxYukseklik = Math.Pow(mermiHizi, 2) / (2 * yerCekimi); // ( V^2 ) / 2 * g

            if (maxYukseklik < yukseklik)
            {
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine("\nHedefi vuramazsınız. Devam etmek için lütfen herhangi bir tuşa basınız.");
                Console.ReadKey();
                return;
            }

            #endregion

            #region Açı Hesaplama

            tahminAci = 45d; // En fazla yol katedebileceği açı 45 derece
            tolerans = 1e-6; // Hata payı 10^(-6) -> 0.000001 (double'ın sınırlarından dolayı)
            gerekenAci = tahminAci;

            for (int sayac = 0; sayac < 1000; sayac++)
            {
                radyan = gerekenAci * Math.PI / 180d; // a(R) = a(D) * pi / 180 -> Math sınıfının Sin ve Cos metotları radyan ile çalışır.
                zaman = mesafe / (mermiHizi * Math.Cos(radyan)); // t = x / ( V * cos(a) )

                y = mermiHizi * Math.Sin(radyan) * zaman - (0.5 * yerCekimi * Math.Pow(zaman, 2)); // y = V * sin(a) * t - ( 1/2 * g * t^2 )
                hata = y - yukseklik;

                if (Math.Abs(hata) < tolerans)
                {
                    break;
                }

                gerekenAci -= hata * 0.01;
                gerekenAci = Math.Max(0, Math.Min(90, gerekenAci));
            }

            #endregion

            #region Sonuç Yazdırma

            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("\nUçağı vurmak için gereken açı: " + gerekenAci);
            Console.WriteLine("Devam etmek için lütfen herhangi bir tuşa basınız.");
            Console.ReadKey();

            #endregion
        }
    }
}
