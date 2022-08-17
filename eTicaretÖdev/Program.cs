string ceketModel1 = "Pull & Bear Bomber Ceket";
string ceketModel2 = "C & C OKULCUNUZ unisex ceket";
string ceketModel3 = "conoasstime oversize fit ceket";
string ceketModel4 = "Alin erkek kahverengi sandor wax deri ceket";
string ceketModel5 = "Funwood Siyah W Wild one oversize ceket";

Ceket ceket1 = new Ceket()
{

    Id = 1,
    Name = ceketModel1,
    Price = 500,
    Size = "Medium",
    Explanation = "Very Exclusive jacket"
};
Ceket ceket2 = new Ceket()
{

    Id = 2,
    Name = ceketModel2,
    Price = 429,
    Size = "Large",
    Explanation = "Low Profile Jacket"
};
Ceket ceket3 = new Ceket()
{

    Id = 3,
    Name = ceketModel3,
    Price = 222,
    Size = "Small",
    Explanation = "Price-Performans jacket"
    
};
Ceket ceket4 = new Ceket()
{

    Id = 4,
    Name = ceketModel4,
    Price = 144,
    Size = "Small",
    Explanation = "Common jacket"
};
Ceket ceket5 = new Ceket()
{

    Id = 5,
    Name = ceketModel5,
    Price = 199,
    Size = "Small",
    Explanation = "Oversize Luxury jacket"
};
Ceket[] ceketler = new Ceket[] { ceket1,ceket2,ceket3,ceket4,ceket5,};
foreach (Ceket ceket in ceketler) {
    Console.WriteLine(ceket.Id+" "+ceket.Name+" "+ceket.Price+" "+ceket.Explanation+" ");
}

Console.WriteLine("sayfa sonu -footer");
public class Ceket
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public decimal Price { get; set; }
    public string? Size { get; set; }
    public string? Explanation { get; set; }
}




