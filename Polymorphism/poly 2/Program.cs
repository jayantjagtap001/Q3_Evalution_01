using System;

public abstract class DatabaseConnector
{
    public abstract void Connect();
}

public class SQLConnector : DatabaseConnector
{
    public override void Connect()
    {
        Console.WriteLine("Connected to SQL Database.");
    }
}

public class MongoDBConnector : DatabaseConnector
{
    public override void Connect()
    {
        Console.WriteLine("Connected to MongoDB.");
    }
}

public class FirebaseConnector : DatabaseConnector
{
    public override void Connect()
    {
        Console.WriteLine("Connected to Firebase.");
    }
}

public class DatabaseTest
{
    public static void Main(string[] args)
    {
        DatabaseConnector sql = new SQLConnector();
        DatabaseConnector mongo = new MongoDBConnector();
        DatabaseConnector firebase = new FirebaseConnector();

        sql.Connect();
        mongo.Connect();
        firebase.Connect();
    }
}
