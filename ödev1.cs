// See https://aka.ms/new-console-template for more information
using static System.Net.Mime.MediaTypeNames;
using System.Diagnostics.Metrics;
using System.Diagnostics;
using System.Runtime.ConstrainedExecution;
using System;

internal class Program
{
    private static void Main(string[] args)
    {


        // 1 - Switch case ile müşteriden alınan sipariş numarasına göre hangi ürünün sipariş edildiğini belirleyen algoritma yazınız.

        //Console.Write("Siparis no giriniz: ");
        //     int siparisNo = Convert.ToInt32(Console.ReadLine());

        //     switch (siparisNo)
        //     {
        //         case 1:
        //             Console.WriteLine("Sipariş edilen ürün Elektronik");
        //             break;

        //         case 2:
        //             Console.WriteLine("Sipariş edilen ürün Ev aleti");
        //             break;
        //         case 3:
        //             {
        //                 Console.WriteLine("Sipariş edilen ürün Kitap");
        //                 break;
        //             }
        //         default:
        //             Console.WriteLine("siparis no gecersiz!!");
        //             break;
        //     }





        // 2 - kullanıcıdan kaç ürün almak istediğini soran,her ürünün fiyatını alarak toplam alışveriş tutarını hesaplayan bir algoritma yazınız.(döngü için for döngüsü kullanınız)

        //Console.WriteLine("Almak istediğiniz ürün adetini giriniz: "); //ekrana yazı yazma
        //int urunAdeti = Convert.ToInt32(Console.ReadLine()); // ekrana girilen degeri okuyup urunAdeti değişkenine atama.
        //double toplamFiyat = 0; //toplamFiyatı tutmak için bir değişken tanımlıyoruz ve hata almamak için başlangıç değerini 0 veriyoruz.
        //for (int i = 1; i <= urunAdeti; i++)
        //{
        //    Console.WriteLine(i + ". ürünün fiyatını giriniz: ");
        //    double urunFiyat = Convert.ToDouble(Console.ReadLine());
        //    toplamFiyat += urunFiyat; // her girdiği ürün fiyatini orn:1.urun fiyatı:5
        //                              // 2. urun fiyatı : 10 gibi her girdiğinde girdiği fiyatı toplamFiyat ile topladık(yada toplamFiyata ekledik).
        //}
        //Console.WriteLine("Toplam tutar: " + toplamFiyat); // toplam fiyatı yazdırdık.


        // 3 - Do - While ve While döngüsü nedir? Bununla ilgili örnek yapınız.

        //int i = 0;

        //do
        //{
        //    Console.WriteLine(i);
        //    i++;

        //} while (i < 3);


        //int i = 1;
        //while (i<5)
        //{
        //    Console.WriteLine(i);
        //    i++;
        //}


        //Console.WriteLine("i 5 ten küçük değildir..");


        // 4 - Bir sayının mükemmel sayı olup olmadığı kontrol eden algoritma yazınız.

        //Bir sayının mükemmel bir sayı olduğunu belirlemek için, sayının kendisi hariç pozitif bölenlerinin toplamının kendisine eşit olup olmadığına bakılır.

        //Console.Write("Bir sayı girin: ");
        //int sayi = Convert.ToInt32(Console.ReadLine());


        //int toplam = 0;
        //for (int i = 1; i < sayi; i++)
        //{
        //    if (sayi % i == 0)
        //    {
        //        toplam += i;
        //    }
        //}
        //if (toplam == sayi)
        //{
        //    Console.WriteLine(sayi + " mükemmel bir sayıdır.");
        //}
        //else
        //{
        //    Console.WriteLine(sayi + " mükemmel bir sayı değildir.");
        //}

        // 5 - String metotlarını araştırınız. Her bir metot için örnek yapınız.

        //string BenStringBirMetodum()
        //{

        //    string ad = "Barış";
        //    string soyad = "Aktaş";
        //    string country = "TC";


        //    return ad+" "+soyad+" UYRUK : "+country;
        //}


        //Console.WriteLine(BenStringBirMetodum());

        // 6 - Bir mağazada alınan ürünün fiyatı 300 tl üzerinde ise 50 tl olan kargo ücreti alınmamaktadır.ürünün fiyatı girildiğinde toplam ödemesi gereken tutarı gösteren programı yazınız.

        //Console.WriteLine("Ürün fiyatı giriniz: ");
        //double urunFiyat = Convert.ToDouble(Console.ReadLine());
        //double toplamFiyat = 0;
        //if (urunFiyat > 300)
        //{
        //    toplamFiyat = urunFiyat;
        //    Console.WriteLine("Toplam Tutar : " + toplamFiyat);
        //}
        //else
        //{
        //    toplamFiyat = urunFiyat+50;
        //    Console.WriteLine("Alışveriş tutarınız: " + urunFiyat + " Kargo ücreti : " + 50 + " Toplam Tutar : " + toplamFiyat);
        //}

        // 7 - iki ürünün kullanıcı tarafından fiyatı girildiğinde toplam fiyat 500 tl'den fazla ise 2.üründen %40 indirim yaparak ödenecek tutarı gösteren uygulamayı yazınız.


        //double toplamFiyat = 0;
        //Console.WriteLine("1. ürünün fiyatını giriniz");
        //double urunFiyat1 = Convert.ToInt32(Console.ReadLine());


        //Console.WriteLine("2. ürünün fiyatını giriniz");
        //double urunFiyat2 = int.Parse(Console.ReadLine());

        //toplamFiyat = urunFiyat1+ urunFiyat2;

        //if (toplamFiyat>500)
        //{
        //    double indirimliUrunFiyat2 = urunFiyat2*0.6;
        //    toplamFiyat = urunFiyat1 + indirimliUrunFiyat2;
        //    Console.WriteLine("Toplam Ürün Tutarı 500 Tl den fazla oldugu içim 2. ürüne %40 indirim uygulanmıştır Ürün Fiyatı : "+urunFiyat2 +" TL ' den  : "+indirimliUrunFiyat2+" TL 'ye düşürülmüştür." +
        //        "Güncel Toplam Ödenecek Fiyat : "+toplamFiyat);
        //}
        //else
        //{
        //    Console.WriteLine("Toplam alışveriş tutarı : " + toplamFiyat);

        //}


        // 8 - 1 - 200 arası içinde 3'e veya 5'e tam bölünebilen sayıları listeleyen ve kaç adet olduğunu yazdıran programı yazınız.


        //int uceVeBeseBoluneBilenSayiAdedi = 0;

        //for (int i = 1; i < 200; i++)
        //{


        //    if (i % 3 == 0 || i % 5 == 0)
        //    {
        //        Console.WriteLine("sayi : " + i);
        //        uceVeBeseBoluneBilenSayiAdedi++;

        //    }
        //}

        //Console.WriteLine("3 e ve 5 e tam bölünebilen sayi adedi : " + uceVeBeseBoluneBilenSayiAdedi);


        Console.ReadLine();

    }


}
