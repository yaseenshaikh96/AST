public class ExpressionC
{
    public ExpressionC? left, right;
    public OperatorC operatorC;
    public float? valueLeft, valueRight;

    public ExpressionC(ExpressionC? left, OperatorC operatorC, ExpressionC right)
    {
        this.left = left;
        this.operatorC = operatorC;
        this.right = right;
        valueLeft = null;
    }
    public ExpressionC(float left, OperatorC operatorC, float right)
    {
        this.valueLeft = left;
        this.operatorC = operatorC;
        this.valueRight = right;
    }

    public float Eval()
    {
        float valueLeftTemp = 0, valueRightTemp = 0;

        if (valueLeft != null && valueRight != null)
            return operatorC.Eval((float)valueLeft, (float)valueRight);

        if (left != null)
            valueLeftTemp = left.Eval();

        if (right != null)
            valueRightTemp = right.Eval();

        return operatorC.Eval(valueLeftTemp, valueRightTemp);
    }

    public void Print()
    {
        if (valueLeft != null && valueRight != null)
        {
            System.Console.Write(valueLeft + " " + operatorC.symbol + " " + valueRight);
            return;
        }

        if (left != null)
            left.Print();

        System.Console.Write(" " + operatorC.symbol + " ");

        if (right != null)
            right.Print();
    }
}
public abstract class OperatorC
{
    public abstract char symbol { get; }
    public abstract float Eval(float left, float right);
}

public class Plus : OperatorC
{
    public override char symbol { get; }
    public Plus() => symbol = '+';

    public override float Eval(float left, float right) =>
        left + right;
}

public class Minus : OperatorC
{
    public override char symbol { get; }
    public Minus() => symbol = '-';

    public override float Eval(float left, float right) =>
        left - right;
}

public class Multi : OperatorC
{
    public override char symbol { get; }
    public Multi() => symbol = '*';

    public override float Eval(float left, float right) =>
        left * right;
}

public class Divi : OperatorC
{
    public override char symbol { get; }
    public Divi() => symbol = '/';

    public override float Eval(float left, float right) =>
        left / right;
}