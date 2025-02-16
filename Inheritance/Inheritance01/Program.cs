
class CentralBank
{
    public virtual void InterestRate()
    {
        Console.WriteLine("Central Bank sets the base interest rate at 5%");
    }
}

class NationalBank:CentralBank
{
    public override void InterestRate()
    {
        Console.WriteLine("National Bank sets the interest rate at 6.5%");
    }
}

class LocalBank:NationalBank
{
    public override void InterestRate()
    {
        Console.WriteLine("Local Bank sets the interest rate at 7.5%");
    }
}

class BankingSystem
{
    public static void Main(string[] args)
    {
        CentralBank c= new CentralBank();
        c.InterestRate();

        NationalBank n=new NationalBank();
        n.InterestRate();

        LocalBank l= new LocalBank();
        l.InterestRate();

    }
}
