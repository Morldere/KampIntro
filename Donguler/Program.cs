﻿string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
string kurs2 = "Programlamaya başlangıç için temel kurs";
string kurs3 = "Java";
string kurs4 = "python";
string kurs5 = "C++";

Console.WriteLine(kurs1);
Console.WriteLine(kurs2);
Console.WriteLine(kurs3);
Console.WriteLine(kurs4);
Console.WriteLine(kurs5);

//array -dizi

string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı", 
    "Programlamaya başlangıç için temel kurs", "Java","Python","C#" };


for (int i = 0; i<kurslar.Length; i++)
{
    Console.WriteLine(kurslar[i]);
}

// in eki sonrası gelen yazı burada örneğin: kursları dolaş
Console.WriteLine("For bitti");

foreach (string kurs in kurslar)
{
    Console.WriteLine(kurs);

}

Console.WriteLine("sayfa sonu -footer"); 
