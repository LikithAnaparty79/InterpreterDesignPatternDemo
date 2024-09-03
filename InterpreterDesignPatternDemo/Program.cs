
using InterpreterDesignPatternDemo;

class Program
{
    public static void Main()
    {
        Expression five = new NumberExpression( 5 );
        Expression ten = new NumberExpression( 10 );
        Expression two = new NumberExpression( 2 );
        Expression three = new NumberExpression( 3 );

        Expression add1 = new AddExpression( five , ten );
        Expression add2 = new AddExpression(two, three);

        Expression subtract = new SubtractExpression( add1 , add2 );

        int result = subtract.Interpret();

        Console.WriteLine( result );
    }
}
