string[] names = new string[] { "Salim", "Süleyman", "Selim", "Ahmet" };
Console.WriteLine(names[0]);
Console.WriteLine(names[1]);
Console.WriteLine(names[2]);
Console.WriteLine(names[3]);

names = new string[5];
names[4] = "Musa";
Console.WriteLine(names[4]);
Console.WriteLine(names[0]);

List<string> names2 = new List<string> { "Salim", "Süleyman", "Selim", "Ahmet" };
Console.WriteLine(names2[0]);
Console.WriteLine(names2[1]);
Console.WriteLine(names2[2]);
Console.WriteLine(names2[3]);
names2.Add("Musa");
Console.WriteLine(names2[4]);
Console.WriteLine(names2[0]);
 

