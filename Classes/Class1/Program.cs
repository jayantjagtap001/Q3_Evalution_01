public class Stock
{
    public string Symbol{ get; set; }
    public int Quantity{ get; set; }
    public decimal PricePerShare{ get; set; }

    public Stock(string symbol,int quantity,decimal pricePerShare)
    {
        Symbol=symbol;
        Quantity=quantity;
        PricePerShare=pricePerShare;
    }
    public decimal GetValue()
    {
        return Quantity * PricePerShare;
    }
}

public class StockPortfolio
{
    private List<Stock> stocks;

    public StockPortfolio()
    {
        stocks = new List<Stock>();
    }

    public void AddStock(string symbol, int quantity, decimal pricePerShare)
    {
        stocks.Add(new Stock(symbol, quantity, pricePerShare));
    }

    public void RemoveStock(string symbol)
    {
        stocks.RemoveAll(s => s.Symbol.Equals(symbol, StringComparison.OrdinalIgnoreCase));
    }

    public decimal GetTotalValue()
    {
        decimal totalValue = 0;
        foreach (var stock in stocks)
        {
            totalValue += stock.GetValue();
        }
        return totalValue;
    }

    public void DisplayPortfolio()
    {
        foreach (var stock in stocks)
        {
            Console.WriteLine($"{stock.Symbol}: {stock.Quantity} shares @ {stock.PricePerShare:C} each, Total: {stock.GetValue():C}");
        }
        Console.WriteLine($"Total Portfolio Value: {GetTotalValue():C}");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        StockPortfolio portfolio = new StockPortfolio();

        portfolio.AddStock("Q3", 10, 145.30m);
        portfolio.AddStock("GOOGL", 5, 2738.27m);
        portfolio.AddStock("TSLA", 8, 710.25m);
         portfolio.AddStock("Maherndra", 5, 910.25m);
          portfolio.AddStock("TATA", 10, 610.25m);

        Console.WriteLine("Initial Portfolio:");
        portfolio.DisplayPortfolio();

        portfolio.RemoveStock("AAPL");
        Console.WriteLine("\nPortfolio after removing AAPL:");
        portfolio.DisplayPortfolio();
    }
}
