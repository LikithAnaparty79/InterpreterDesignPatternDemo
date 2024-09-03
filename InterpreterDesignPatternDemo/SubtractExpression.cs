/******************************************************************************
* Filename    = SubtractExpression.cs
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
    /// <summary>
    /// Creates a subtract expression implementing interpret method.
    /// </summary>
    public class SubtractExpression : Expression
    {
        private readonly Expression _leftExpression; // For the left operand of the expression
        private readonly Expression _rightExpression; // For the right operand of the expression

        /// <summary>
        /// Initialises the left and right expressions
        /// </summary>
        /// <param name="left">The left expression of subtract.</param>
        /// <param name="right">The right expression of subtract.</param>

        public SubtractExpression(Expression left, Expression right)
        {
            _leftExpression = left;
            _rightExpression = right;
        }
        public int Interpret()
        {
            return _leftExpression.Interpret() - _rightExpression.Interpret();
        }
    }
}
