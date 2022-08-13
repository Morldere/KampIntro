
string adi = "Selman";
int yas = 22;

kurs kurs1 = new kurs();
kurs1.kursAdi = "C#";
kurs1.Egitmen = "Selman Aldemir";
kurs1.IzlenmeOrani = 31;

kurs kurs2 = new kurs();
kurs2.kursAdi = "Java";
kurs2.Egitmen = "SevbanKirwe";
kurs2.IzlenmeOrani = 69;

kurs kurs3 = new kurs();
kurs3.kursAdi = "Python";
kurs3.Egitmen = "Süleyman";
kurs3.IzlenmeOrani = 14;

kurs kurs4 = new kurs();
kurs4.kursAdi = "Profesyonelyaklasım";
kurs4.Egitmen = "YavşakSalim";
kurs4.IzlenmeOrani = 150;



Console.WriteLine(kurs1.kursAdi + " " + kurs1.Egitmen);

kurs[] kurslar = new kurs[] { kurs1, kurs2, kurs3, kurs4};

foreach (var kurs in kurslar)
{
    Console.WriteLine(kurs.kursAdi + " " + kurs.Egitmen);
}


Console.ReadLine();










class kurs
{
    public string kursAdi { get; set; }
    public string Egitmen { get; set; }
    public int IzlenmeOrani { get; set; }

}
