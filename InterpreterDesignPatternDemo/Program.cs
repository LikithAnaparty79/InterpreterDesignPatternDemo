/******************************************************************************
* Filename    = SubtractExpression.cs
*
* Author      = Likith Anaparty
*
* Product     = InterpreterDesignPatternDemo
* 
* Project     = SubtractExpression
*
* Description = Client program to run the calculator
*****************************************************************************/

using InterpreterDesignPatternDemo;

class Program
{
    public static void Main()
    {
        IExpression five = new NumberExpression( 5 );
        IExpression ten = new NumberExpression( 10 );
        IExpression two = new NumberExpression( 2 );
        IExpression three = new NumberExpression( 3 );

        IExpression add1 = new AddExpression( five , ten );
        IExpression add2 = new AddExpression(two, three);

        IExpression subtract = new SubtractExpression( add1 , add2 );

        int result = subtract.Interpret();

        Console.WriteLine( result );
    }
}
