
public class Product
{
    public string Name { get; set; }
    public double Price { get; set; }

    public Product(string name, double price)
    {
        Name = name;
        Price = price;
    }

    public virtual double CalculateDiscount(double percentage)
    {
        return Price - (Price * percentage / 100);
    }
}

public class Electronics : Product
{
    public Electronics(string name, double price) : base(name, price) 
    { 
        // Console.Write(""):
    }

    public override double CalculateDiscount(double percentage)
    {
        percentage += 5;
        return base.CalculateDiscount(percentage);
    }
}

public class Clothing : Product
{
    public Clothing(string name, double price) : base(name, price) { }

    public override double CalculateDiscount(double percentage)
    {
        percentage += 10;
        return base.CalculateDiscount(percentage);
    }
}

public class Laptop : Electronics
{
    public Laptop(string name, double price) : base(name, price) { }

    public override double CalculateDiscount(double percentage)
    {
        percentage += 2;
        return base.CalculateDiscount(percentage);
    }
}

public class TShirt : Clothing
{
    public TShirt(string name, double price) : base(name, price) { }

    public override double CalculateDiscount(double percentage)
    {
        percentage += 3;
        return base.CalculateDiscount(percentage);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Laptop laptop = new Laptop("MAC m3", 4200);
        Console.WriteLine($"Laptop Price after discount: ${laptop.CalculateDiscount(10)}");

        TShirt tshirt = new TShirt("Nike Tee", 100);
        Console.WriteLine($"T-Shirt Price after discount: ${tshirt.CalculateDiscount(15)}");
    }
}
