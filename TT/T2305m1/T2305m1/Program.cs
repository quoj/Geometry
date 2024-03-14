using System;

// Lop co so
class Animal
{
    protected double weight;
    protected string name;

    public Animal()
    {
        weight = 0;
        name = "Chua xac dinh";
    }

    public Animal(double weight, string name)
    {
        this.weight = weight;
        this.name = name;
    }

    public void SetMe(double weight, string name)
    {
        this.weight = weight;
        this.name = name;
    }

    public virtual void Show()
    {
        Console.WriteLine($"Ten: {name}, Can nang: {weight} kg");
    }
}

// Lop dan xuat Lion
class Lion : Animal
{
    public Lion(double weight, string name) : base(weight, name)
    {
    }

    public override void Show()
    {
        Console.WriteLine($"tiger - Ten: {name}, Can nang: {weight} kg");
    }
}

// Lop dan xuat Tiger
class Tiger : Animal
{
    public Tiger(double weight, string name) : base(weight, name)
    {
    }

    public override void Show()
    {
        Console.WriteLine($"lion - Ten: {name}, Can nang: {weight} kg");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Lion suluoi = new Lion(200, "Ho ");
        Tiger ho = new Tiger(180, "Su tu ");

        suluoi.Show();
        ho.Show();
    }
}
