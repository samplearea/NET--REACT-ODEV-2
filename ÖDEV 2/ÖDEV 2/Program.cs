using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        RakamlarToplami();
        SayiAl();
        YasKategorisi();
        TekrarEdenElemanlar();
        EnUzunEnKisaKelime();
        CumleyiSirala();
        DiziGenişlet();
        TersKelimeListesi();
        OrtalamaVeSirala();
        KucukleriSil();
        NotlariGuncelle();
    }

    // 1. Sayının rakamlarının toplamını bulan algoritma
    static void RakamlarToplami()
    {
        Console.Write("Bir sayı girin: ");
        int sayi = int.Parse(Console.ReadLine());
        int toplam = 0;
        for (int temp = sayi; temp > 0; temp /= 10)
            toplam += temp % 10;
        Console.WriteLine("Rakamların toplamı: " + toplam);
    }

    // 2. 10 ile 100 arasında bir sayı alan algoritma
    static void SayiAl()
    {
        int sayi;
        do
        {
            Console.Write("10 ile 100 arasında bir sayı giriniz: ");
            sayi = int.Parse(Console.ReadLine());
        } while (sayi < 10 || sayi > 100);
        Console.WriteLine("Geçerli sayı girildi: " + sayi);
    }

    // 3. Yaş kategorisini belirleyen algoritma
    static void YasKategorisi()
    {
        int[] yaslar = { 5, 15, 25, 70, 45, 12 };
        foreach (int yas in yaslar)
        {
            string kategori = yas switch
            {
                <= 12 => "Çocuk",
                <= 19 => "Genç",
                <= 64 => "Yetişkin",
                _ => "Yaşlı"
            };
            Console.WriteLine($"{yas}: {kategori}");
        }
    }

    // 4. Bir dizide tekrar eden elemanları bulan algoritma
    static void TekrarEdenElemanlar()
    {
        int[] dizi = { 1, 2, 3, 4, 2, 5, 6, 1, 7, 8, 3 };
        var tekrarEdenler = dizi.GroupBy(x => x).Where(g => g.Count() > 1).Select(g => g.Key);
        Console.WriteLine("Tekrar eden elemanlar: " + string.Join(", ", tekrarEdenler));
    }

    // 5. En uzun ve en kısa kelimeyi bulan algoritma
    static void EnUzunEnKisaKelime()
    {
        string[] kelimeler = { "elma", "armut", "kiraz", "muz", "çilek" };
        Console.WriteLine($"En uzun kelime: {kelimeler.OrderByDescending(k => k.Length).First()}");
        Console.WriteLine($"En kısa kelime: {kelimeler.OrderBy(k => k.Length).First()}");
    }

    // 6. Kullanıcının girdiği bir cümleyi alfabetik olarak sıralayan algoritma
    static void CumleyiSirala()
    {
        Console.Write("Bir cümle girin: ");
        string[] kelimeler = Console.ReadLine().Split(' ');
        Array.Sort(kelimeler);
        Console.WriteLine("Alfabetik sırayla: " + string.Join(", ", kelimeler));
    }

    // 7. String dizisinin boyutunu dinamik olarak genişleten algoritma
    static void DiziGenişlet()
    {
        List<string> liste = new List<string> { "Merhaba", "Dünya", "C#" };
        Console.WriteLine("Dizi elemanları: " + string.Join(", ", liste));
    }

    // 8. Girilen kelimeleri listeye kaydedip tersten yazdıran algoritma
    static void TersKelimeListesi()
    {
        List<string> kelimeler = new List<string>();
        Console.WriteLine("Kelime giriniz (Çıkmak için 'exit' yazın):");
        while (true)
        {
            string kelime = Console.ReadLine();
            if (kelime.ToLower() == "exit") break;
            kelimeler.Add(kelime);
        }
        kelimeler.Reverse();
        Console.WriteLine("Tersten sıralama: " + string.Join(", ", kelimeler));
    }

    // 9. Kullanıcıdan rastgele sayılar alıp listeye ekleyen ve ortalama hesaplayan algoritma
    static void OrtalamaVeSirala()
    {
        List<int> sayilar = new List<int>();
        Console.WriteLine("Sayı giriniz (Çıkmak için -1 yazın):");
        while (true)
        {
            int sayi = int.Parse(Console.ReadLine());
            if (sayi == -1) break;
            sayilar.Add(sayi);
        }
        Console.WriteLine($"Ortalama: {sayilar.Average()}");
        sayilar.Sort();
        Console.WriteLine("Sıralı Liste: " + string.Join(", ", sayilar));
    }

    // 10. Bir sayı listesinde 10’dan küçük olanları silen algoritma
    static void KucukleriSil()
    {
        List<int> sayilar = new List<int> { 3, 15, 8, 20, 5, 30 };
        sayilar.RemoveAll(s => s < 10);
        Console.WriteLine("Güncellenmiş Liste: " + string.Join(", ", sayilar));
    }

    // 11. Öğrenci notlarını güncelleyen algoritma (50'nin altındaki notları 50 yapar)
    static void NotlariGuncelle()
    {
        List<int> notlar = new List<int> { 45, 60, 70, 30, 90, 48 };
        notlar = notlar.Select(n => n < 50 ? 50 : n).ToList();
        Console.WriteLine("Güncellenmiş Notlar: " + string.Join(", ", notlar));
    }
}
