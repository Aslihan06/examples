using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        // 1 - Aşağıdaki çıktıyı yazan bir program.
        Console.WriteLine("Merhaba");
        Console.WriteLine("Nasılsın ?");
        Console.WriteLine("İyiyim");
        Console.WriteLine("Sen nasılsın ?");

        // 2 - Bir adet metinsel, bir adet tam sayı verisi tutmak için 2 adet değişken tanımlayınız.
        string isim = "Aslı";
        int yas = 25;
        Console.WriteLine("İsim: " + isim);
        Console.WriteLine("Yaş: " + yas);

        // 3 - Rastgele bir sayı üretip, ekrana yazdırınız.
        Random random = new Random();
        int rastgeleSayi = random.Next(1, 101);
        Console.WriteLine("Rastgele Sayı: " + rastgeleSayi);

        // 4 - Rastgele bir sayı üretip, bunun 3'e bölümünden kalanı ekrana yazdırınız.
        int kalan = rastgeleSayi % 3;
        Console.WriteLine("Rastgele Sayının 3'e bölümünden kalan: " + kalan);

        // 5 - Kullanıcıya yaşını sorup, 18'den büyükse "+" küçükse "-" yazdıran bir uygulama.
        Console.Write("Yaşınızı giriniz: ");
        int kullaniciYasi = int.Parse(Console.ReadLine());
        if (kullaniciYasi >= 18)
        {
            Console.WriteLine("+");
        }
        else
        {
            Console.WriteLine("-");
        }

        // 6 - Ekrana 10 defa bir mesaj yazan uygulama.
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Sen Vodafone gibi anı yaşarken, ben Turkcell gibi seni her yerde çekemem.");
        }

        // 7 - Kullanıcıdan 2 metinsel değer alıp yerlerini değiştiren uygulama.
        Console.Write("Birinci isim: ");
        string isim1 = Console.ReadLine();
        Console.Write("İkinci isim: ");
        string isim2 = Console.ReadLine();
        string temp = isim1;
        isim1 = isim2;
        isim2 = temp;
        Console.WriteLine("Yeni birinci isim: " + isim1);
        Console.WriteLine("Yeni ikinci isim: " + isim2);

        // 8 - Değer döndürmeyen metot.
        BenDegerDondurmem();

        // 9 - İki sayıyı alıp bunların toplam değerini döndüren metot.
        int toplam = Topla(5, 8);
        Console.WriteLine("Toplam: " + toplam);

        // 10 - Kullanıcıdan true/false alıp string dönen metot.
        Console.Write("True veya False giriniz: ");
        bool kullaniciDegeri = bool.Parse(Console.ReadLine());
        string sonuc = TrueFalseMetodu(kullaniciDegeri);
        Console.WriteLine("Sonuç: " + sonuc);

        // 11 - 3 kişinin yaşlarını alıp en yaşlı olanı dönen metot.
        int enYasli = EnYasliBul(25, 30, 28);
        Console.WriteLine("En yaşlı olanın yaşı: " + enYasli);

        // 12 - Sınırsız sayıda sayı alıp en büyüğünü dönen metot.
        int enBuyuk = EnBuyukSayiBul();
        Console.WriteLine("En büyük sayı: " + enBuyuk);

        // 13 - Kullanıcıdan alınan iki ismin yerlerini değiştiren metot.
        IsimleriDegistir("Ahmet", "Mehmet");

        // 14 - Sayının tek mi çift mi olduğunu dönen metot.
        Console.Write("Bir sayı giriniz: ");
        int sayi = int.Parse(Console.ReadLine());
        bool tekMi = TekMiCiftMi(sayi);
        Console.WriteLine("Sayı tek mi? " + tekMi);

        // 15 - Hız ve zaman ile gidilen yolu hesaplayan metot.
        int yol = GidilenYoluHesapla(100, 2);
        Console.WriteLine("Gidilen yol: " + yol);

        // 16 - Yarıçap bilgisiyle daire alanı hesaplayan metot.
        double alan = DaireAlaniHesapla(5);
        Console.WriteLine("Dairenin alanı: " + alan);

        // 17 - Cümleyi büyük ve küçük harflerle yazdıran uygulama.
        string cumle = "Zaman bir GeRi SayIm";
        Console.WriteLine(cumle.ToUpper());
        Console.WriteLine(cumle.ToLower());

        // 18 - Metindeki boşlukları silen uygulama.
        string metin = "    Selamlar   ";
        metin = metin.Trim();
        Console.WriteLine("Metin: '" + metin + "'");
    }

    // 8. BenDegerDondurmem metodu
    static void BenDegerDondurmem()
    {
        Console.WriteLine("Ben değer döndürmem, benim bir karşılığım yok, beni değişkene atamaya çalışma.");
    }

    // 9. Topla metodu
    static int Topla(int sayi1, int sayi2)
    {
        return sayi1 + sayi2;
    }

    // 10. TrueFalseMetodu
    static string TrueFalseMetodu(bool deger)
    {
        return deger ? "Doğru" : "Yanlış";
    }

    // 11. EnYasliBul metodu
    static int EnYasliBul(int yas1, int yas2, int yas3)
    {
        return Math.Max(yas1, Math.Max(yas2, yas3));
    }

    // 12. EnBuyukSayiBul metodu
    static int EnBuyukSayiBul()
    {
        Console.WriteLine("Sayıları girin, bitirmek için -1 yazın.");
        int enBuyuk = int.MinValue;
        while (true)
        {
            int sayi = int.Parse(Console.ReadLine());
            if (sayi == -1) break;
            if (sayi > enBuyuk) enBuyuk = sayi;
        }
        return enBuyuk;
    }

    // 13. IsimleriDegistir metodu
    static void IsimleriDegistir(string isim1, string isim2)
    {
        string temp = isim1;
        isim1 = isim2;
        isim2 = temp;
        Console.WriteLine($"İsimler değişti: {isim1}, {isim2}");
    }

    // 14. TekMiCiftMi metodu
    static bool TekMiCiftMi(int sayi)
    {
        return sayi % 2 != 0;
    }

    // 15. GidilenYoluHesapla metodu
    static int GidilenYoluHesapla(int hiz, int zaman)
    {
        return hiz * zaman;
    }

    // 16. DaireAlaniHesapla metodu
    static double DaireAlaniHesapla(double yaricap)
    {
        return Math.PI * yaricap * yaricap;
    }
}
