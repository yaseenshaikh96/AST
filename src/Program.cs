public class Program
{
    static OperatorC plus = new Plus();
    static OperatorC minus = new Minus();
    static OperatorC multi = new Multi();
    static OperatorC divi = new Divi();

    public static void Main(string[] args)
    {
        Example2();
    }

    public static void Example1()
    {
        ExpressionC left = new ExpressionC(10, new Plus(), 2);
        ExpressionC right = new ExpressionC(4, new Plus(), 4);

        ExpressionC expressionC = new ExpressionC(left, new Minus(), right);
        float value = expressionC.Eval();
        System.Console.Write("Value: " + value);
        System.Console.Write("\nExpression: ");
        expressionC.Print();
    }
    public static void Example2()
    {
        ExpressionC leftleft = new ExpressionC(2, plus, 4); // 6
        ExpressionC leftright = new ExpressionC(6, divi, 2); // 3
        ExpressionC rightleft = new ExpressionC(8, multi, 2); // 16
        ExpressionC rightright = new ExpressionC(6, minus, 6); // 0

        ExpressionC left = new ExpressionC(leftleft, plus, leftright); // 9
        ExpressionC right = new ExpressionC(rightleft, plus, rightright); // 16
        ExpressionC expressionC = new ExpressionC(left, plus, right); // 25

        float value = expressionC.Eval();
        System.Console.Write("Value: " + value);
        System.Console.Write("\nExpression: ");
        expressionC.Print();
    }
}