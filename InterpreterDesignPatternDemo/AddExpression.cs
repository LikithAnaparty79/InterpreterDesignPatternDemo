/******************************************************************************
* Filename    = AddExpression.cs
*
* Author      = Likith Anaparty
*
* Product     = InterpreterDesignPatternDemo
* 
* Project     = SubtractExpression
*
* Description = 
*****************************************************************************/

namespace InterpreterDesignPatternDemo
{
    public class AddExpression : Expression
    {
        private readonly Expression _leftExpression;
        private readonly Expression _rightExpression;
        public AddExpression(Expression left, Expression right) 
        {
            _leftExpression = left;
            _rightExpression = right;
        }

        public int Interpret()
        {
            return _leftExpression.Interpret() + _rightExpression.Interpret();
        }
    }
}
