using System;
using System.Collections.Generic;
using System.Linq;

class Dizi
{
    public string DiziAdi {  get; set; }
    public int YapimYili { get; set; }
    public string Tur {  get; set; }
    public int  YayinYili { get; set; }
    public string Yonetmen { get; set; }
    public string YayinlananIlkPlatform { get; set; }

    public Dizi(string diziAdi, int yapimYili, string tur, int yayinYili, string yonetmen, string yayinlananIlkPlatform)
    {
        DiziAdi = diziAdi;
        YapimYili = yapimYili;
        Tur = tur;
        YayinYili = yayinYili;
        Yonetmen = yonetmen;
        YayinlananIlkPlatform = yayinlananIlkPlatform;
    }

    public override string ToString()
    {
        return $"Dizi Adı: {DiziAdi}, Yapım Yılı: {YapimYili}, Türü: {Tur}, Yayınlandığı Yıl: {YayinYili}, Yönetmen: {Yonetmen}, Yayınlandığı İlk Platform: {YayinlananIlkPlatform}";

    }

    public void BilgileriYazdir()
    {
        Console.WriteLine(this.ToString());
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Dizi> list = new List<Dizi>();
        {
            list.Add(new Dizi("Avrupa Yakası", 2004, "Komedi", 2004, "Yüksel Aksu", "Kanal D"));
            list.Add(new Dizi("Yalan Dünya", 2012, "Komedi", 2012, "Gülseren Buda Başkaya", "Fox TV"));
            list.Add(new Dizi("Jet Sosyete", 2018, "Komedi", 2018, "Gülseren Buda Başkaya", "TV8"));
            list.Add(new Dizi("Dadı", 2006, "Komedi", 2006, "Yusuf Pirhasan", "Kanal D"));
            list.Add(new Dizi("Belalı Baldız", 2007, "Komedi", 2007, "Yüksel Aksu", "Kanal D"));
            list.Add(new Dizi("Arka Sokaklar", 2004, "Polisiye, Dram", 2004, "Orhan Oğuz", "Kanal D"));
            list.Add(new Dizi("Aşk-ı Memnu", 2008, "Dram, Romantik", 2008, "Hilal Saral", "Kanal D"));
            list.Add(new Dizi("Muhteşem Yüzyıl", 2011, "Tarihi, Dram", 2011, "Mercan Çilingiroğlu", "Star TV"));
            list.Add(new Dizi("Yaprak Dökümü", 2006, "Dram", 2006, "Serdar Akar", "Kanal D"));
        };

        bool yeniDiziEkle = true;

        while (yeniDiziEkle)
        {
            Console.WriteLine("Eklemek istediğiniz dizinin adı:");
            string diziAdi = Console.ReadLine();

            Console.WriteLine("Eklemek istediğiniz dizinin yapım yılı:");
            int yapimYili = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Eklemek istediğiniz dizinin türü:");
            string Tur = Console.ReadLine();

            Console.WriteLine("Eklemek istediğiniz dizinin yayın yılı:");
            int yayinYili = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Eklemek istediğiniz dizinin yönetmeni:");
            string yonetmen = Console.ReadLine();

            Console.WriteLine("Eklemek istediğiniz dizinin yayınlandığı ilk platform");
            string yayinlandigiIlkPlatform = Console.ReadLine();

            Dizi yeniDizi = new Dizi(diziAdi, yapimYili, Tur, yayinYili, yonetmen, yayinlandigiIlkPlatform);

            list.Add(yeniDizi);

            Console.WriteLine("Yeni bir dizi eklemek ister misiniz? (Evet/Hayır)");
            string cevap = Console.ReadLine().ToLower();

            yeniDiziEkle = cevap == "Evet";
        }

        //listeyi ekrana yazdır
        Console.WriteLine("Yeni dizi listesi:");
        foreach (var dizi in list)
        {
            dizi.BilgileriYazdir();
        }

        //komedi dizilerinden liste oluştur

        List<Dizi> komediDizi = list.Where(dizi => dizi.Tur.ToLower() == "komedi").ToList();

        Console.WriteLine("Komedi dizileri:");
        foreach(var dizi in komediDizi)
        {
            dizi.BilgileriYazdir();
        }

    }
}
