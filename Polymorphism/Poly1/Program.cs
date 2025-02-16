
public abstract class Expression
{
    public abstract double Evaluate();
}

public class Number : Expression
{
    private double value;

    public Number(double value)
    {
        this.value = value;
    }

    public override double Evaluate()
    {
        return value;
    }
}

public class Operation : Expression
{
    private Expression left;
    private Expression right;
    private char op;

    public Operation(Expression left, Expression right, char op)
    {
        this.left = left;
        this.right = right;
        this.op = op;
    }

    public override double Evaluate()
    {
        switch (op)
        {
            case '+': return left.Evaluate() + right.Evaluate();
            case '-': return left.Evaluate() - right.Evaluate();
            case '*': return left.Evaluate() * right.Evaluate();
            case '/': return left.Evaluate() / right.Evaluate();
            default: throw new InvalidOperationException("Invalid operator");
        }
    }
}

public class ExpressionExample
{
    public static void Main(string[] args)
    {
        Expression expr1 = new Operation(new Number(5), new Number(3), '+');
        Expression expr2 = new Operation(expr1, new Number(2), '*');

        Console.WriteLine("Result: " + expr2.Evaluate());
    }
}
