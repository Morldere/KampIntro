﻿//Dont repeat yourself - DRY - Clean Code - Best Practice
using Metotlar;


    string urunAdi = "Elma";
    double fiyati = 15;
    string aciklama = "Amasya Elması";

    string[] meyveler = new string[] {"Elma","Karpuz" };

    Urun urun1 = new Urun();
    urun1.urununAdi = "Elma";
    urun1.Fiyati = 15;
    urun1.Aciklama = "Amasya elması";

    Urun urun2 = new Urun();
    urun2.urununAdi = "Karpuz";
    urun2.Fiyati = 53;
    urun2.Aciklama = "Diyarbakır Karpuzu";

    Urun[] urunler = new Urun[] { urun1, urun2 };

    //type-safe -- tip güvenli

    foreach (var urun in urunler)
    {
        Console.WriteLine(urun.urununAdi);
        Console.WriteLine(urun.Fiyati);
        Console.WriteLine(urun.Aciklama);
        Console.WriteLine("-------------");

    }

Console.WriteLine("---------------Metodlar------------");
//instance - örnek
//encapsulation

SepetManager sepetManager = new SepetManager();
sepetManager.Ekle(urun1);
sepetManager.Ekle(urun2);

sepetManager.Ekle2("Armut", "Yeşil armut", 12, 10);
sepetManager.Ekle2("Elma", "Yeşil elma", 12,44);
sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 12,55);




