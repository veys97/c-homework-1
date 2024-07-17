using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework__1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Ödev Soruları
 * 1 - Girilen sayının tek ya da çift olduğunu gösteren örneği oluşturunuz
2 - Girilen sayı çift ise yarısını, tek ise 2 katını alarak ekrana yazdıran program
3 - Kullanıcıdan 2 tane sayı isteyerek 1. sayının 2. sayıya tam bölünmesi durumunda "Tam Bölünüyor" yazan,
aksi durumda "Tam bölünmüyor" diyerek kalanı ekranda gösteren program 
4 - Klavyeden girilen bir sayının seçime bağlı olarak karesini, küpünü ve karekökünü alan programı yazınız.
5 - Girilen tam bir sayının 3' e ve 5' e tam olarak bölünebiliyor mu? bulan programı yazınız.
6 - Ehliyet sınavı için yaşı 18 ve üzeri olanlar için başvuru yapabileceklerini, 18 yaşın altında ise kaç yıl sonra ehliyet alabileceğini ekrana yazan c# kodlarını yazınız.
7 - Bir kişi mağazadan 100 TL ve üzeri alışveriş yaparsa %10 indirim, 
200TL ve üzeri alışveriş yaparsa %15 indirim, 300TL ve üzeri alışveriş yaparsa %20 indirim kazandığını 
ve ödeyeceği miktarı ekrana yazan C# kodlarını yazınız.
8 - Klavyeden girilen öğrenci notuna göre harf notunu yazdıran program. Koşullar (0-39 = F, 40-59 = E, 60-60 = D, 70-79 = C, 80-89 = B, 90,100 = A)
9 - Bir otoparkta saate göre ödenecek tutarı ekrana yazan program (0-3 saat 10₺, 4-6 saat 15₺, 7 saat ve üzeri 20₺)
10 - Aylık elektrik faturası hesaplanacaktır. 
Kullanıcıdan kaç kWh tükettiğini alınız. 
Eğer tüketim 150' den küçükse kWh'i 20 kuruş, eğer 150 ile 300 arsında ise 30 kuruş, 300 ve üzeri ise 50 kuruş olarak hesaplanmaktadır. 
Kişilerin yaptığı tüketime göre faturasının kaç TL olacağını hesaplayıp ekrana yazdırınız
*/
            #region Soru - 1
            //Kullanıcıdan sayı isteyerek başladım.
            //int sayi;

            //Console.Write("Lütfen bir sayı giriniz : ");
            //sayi = int.Parse(Console.ReadLine());

            ////Kullanıcıdan almış olduğum sayının mod 2'sini alarak tek ve çift olduğunu programa hesaplattırdım.

            //if (sayi % 2 == 0)
            //{
            //    Console.WriteLine("Girdiğiniz sayı çifttir!");
            //}
            //else
            //{
            //    Console.WriteLine("Girdiğiniz sayı tektir!");
            //}

            //Girilen sayının tek ya dad çift olduğunu dair mesajı ekrana yazdırdım.

            //Console.ReadKey();
            #endregion
            #region Soru - 2
            ////Kullanıcıdan sayı isteyerek başladım.
            //int s, c, t;

            //Console.Write("Lütfen bir sayı giriniz : ");
            //s = int.Parse(Console.ReadLine());

            ////Kullanıcıdan almış olduğum sayının tek mi çift mi olduğunu hesapladım.
            //if (s % 2 == 0)
            //{
            //    //Girilen sayının modunu aldıktan sonra, soruda belirtildiği şekilde sayının yarısını isteyerek ekrana yazdırdım.
            //    c = s / 2;
            //    Console.WriteLine("Girdiğiniz Sayı Çifttir  Sayınızın Yarısı : " + c);
            //}
            //else
            //{
            //    //Girilen sayının modunu aldıktan sonra, soruda belirtildiği şekilde sayının iki katını alarak ekrana yazdırdım.
            //    t = s * 2;
            //    Console.WriteLine("Girdiğiniz Sayı Tektir ve Sayınızın İki Katı : " + t);
            //}
            //Console.ReadKey();
            #endregion
            #region Soru - 3
            ////Kullanıcıdan 2 adet sayı istedim.
            //int sayi1, sayi2;

            //Console.Write("1. Sayıyı Giriniz : ");
            //sayi1 = int.Parse(Console.ReadLine());

            //Console.Write("2. Sayıyı Giriniz : ");
            //sayi2 = int.Parse(Console.ReadLine());

            ////Sayıları istedikten sonra ekranı temizleyerek, şartımı yazdım.
            //Console.Clear();
            //if (sayi1 % sayi2 == 0)
            //{
            //    //Şartımı oluşturduktan sonra, eğer gerçekleşiyorsa gerekli mesajı yazdırdım.
            //    Console.WriteLine("Girmiş olduğunuz iki sayı da birbirine tam bölünür!");
            //}
            //else
            //{
            //    //Şartımı oluşturduktan sonra, gerçekleşmiyorsa da gerekli mesajı yazdırdım.
            //    Console.WriteLine("Girmiş olduğunuz iki sayı  birbirine tam bölünmez!");

            //}


            //Console.ReadKey();
            #endregion
            #region Soru - 4
            ////Kullanıcıdan sayı isteyerek başladım.
            //int sayi,kare, kup, karekok;

            //Console.Write("Bir sayı giriniz : ");
            //sayi = int.Parse(Console.ReadLine());


            ////Sonrasında almış olduğum sayının karesini hesaplayarak ekrana yazdırdım.
            //kare = sayi * sayi;
            //Console.WriteLine($"Girmiş olduğunuz sayının karesi : {kare}");
            //Console.WriteLine("------------");

            ////Burada ise almış olduğum sayının küpünü hesaplayarak ekrana yazdırdım.
            //kup = sayi * kare;
            //Console.WriteLine($"Girmiş olduğunuz sayının küpü : {kup}");
            //Console.WriteLine("------------");

            ////Son olarak ise almış olduğum sayının karekökünü hesaplayarak ekrana yazdırdım.
            //karekok = (int) Math.Sqrt(sayi);
            //Console.WriteLine($"Girmiş olduğunuz sayının karekökü : {karekok}");

            //Console.ReadKey();
            #endregion
            #region Soru - 5
            ////Kullanıcıdan sayı isteyerek başladım.
            //int sayi;
            //Console.Write("Bir sayı giriniz : ");
            //sayi = int.Parse(Console.ReadLine());

            ////Kullanıcıdan almış olduğum sayının 3'e ve 5' tam bölünüp bölünememe durumunu if ile kontrol ederek gerekli mesajları ekrana yazdırdım.
            //if (sayi % 3 == 0 && sayi % 5 == 0)
            //{
            //    Console.WriteLine("Girmiş olduğunuz sayı 3'e ve 5'e tam bölünüyor!");
            //}
            //else 
            //{
            //    Console.WriteLine("Girmiş olduğunuz sayı 3'e ve 5'e tam bölünmüyor!");
            //}
            //Console.ReadKey();
            #endregion
            #region Soru - 6
            ////Öncelikle kullanıcıdan adını ve yaşını istedim
            //int yas;
            //string isim;

            //Console.Write("Adınızı Giriniz : ");
            //isim = Console.ReadLine();

            //Console.Write("Yaşınızı Giriniz : ");
            //yas = int.Parse(Console.ReadLine());

            ////Kullanıcıdan gerekli verileri aldıktan sonra da ehliyet alabilmesi için gerekli olan 18 yaş şartını if kullanarak kontrol ettim.
            //if (yas >= 18)
            //{
            //    Console.WriteLine($"{isim} ehliyet alabilirsin!");
            //}
            //else
            //{
            //    Console.WriteLine($"{isim}, ehliyet alamazsın, çünkü yaşın tutmuyor!");
            //}


            //Console.ReadKey();
            #endregion
            #region Soru - 7
            //Kullanıcıdan alışveriş tutarını istedim.
            //double tutar;

            //Console.Write("Alışveriş Tutarınızı Giriniz : ");
            //tutar = double.Parse(Console.ReadLine());

            //Kullanıcıdan alışveriş tutarını aldıktan sonra alacağı indirimi if-else kullanarak ekrana yazdırdım.

            //if (tutar >= 100)

            //{
            //    tutar = tutar - (tutar * 10 / 100);
            //}

            //else if (tutar >= 200)

            //{
            //    tutar = tutar - (tutar * 15 / 100);
            //}

            //else if (tutar >= 300)
            //{
            //    tutar = tutar - (tutar * 20 / 100);
            //}
            //Console.WriteLine("Ödeyeceğiniz Toplam Tutar : " + tutar + " TL'dir.");
            //Console.ReadKey();
            #endregion
            #region Soru - 8
            //1. adım olarak kullanıcıdan sınavdan almış olduğu notu girmesini istedim.
            //int not;

            //Console.Write("Notunuzu Giriniz : ");
            //not = int.Parse(Console.ReadLine());

            ////2. adım olarak ise not aralıklarını if else kullanarak belirtip, ekrana yazdırdım.
            //if (not == 0 || not < 39)
            //{
            //    Console.WriteLine("Notunuz F");
            //}

            //else if (not == 40 || not < 59)
            //{
            //    Console.WriteLine("Notunuz E");
            //}
            //else if (not == 60 || not < 69)
            //{
            //    Console.WriteLine("Notunuz D");
            //}
            //else if (not == 70 || not < 79)
            //{
            //    Console.WriteLine("Notunuz C");
            //}
            //else if (not == 80 || not < 89)
            //{
            //    Console.WriteLine("Notunuz B");
            //}
            //else if (not == 90 || not <= 100)
            //{
            //    Console.WriteLine("Notunuz A");
            //}

            //Console.ReadKey();
            #endregion
        }
    }
}
