//type safetiy - tip güvenliği
//do not repeat yourself
//alias - takma isim



string kategoriEtiketi = "kategoriler" ;
int ogrenciSayisi = 320000000;
double faizorani = 1.45;
bool sistemeGirisYapmisMi = true;
double dolarDun = 7.45;
double dolarBugun = 7.45;

if (dolarDun>dolarBugun)
{
    Console.WriteLine("Azalış Butonu");
}
else if(dolarDun<dolarBugun)
{
    Console.WriteLine("Artış butonu");
}
else
{
    Console.WriteLine("değişmedi butonu");
}

if (sistemeGirisYapmisMi == true)
{
    Console.WriteLine("Kullanıcı ayarları butonu");
}
else
{
    Console.WriteLine("Giris yap butonu");
}

Console.WriteLine(kategoriEtiketi);
