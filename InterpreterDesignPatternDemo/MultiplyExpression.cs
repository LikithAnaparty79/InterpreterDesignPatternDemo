/******************************************************************************
* Filename    = MultiplyExpression.cs
*
* Author      = Likith Anaparty
*
* Product     = InterpreterDesignPatternDemo
* 
* Project     = MultiplyExpression
*
* Description = Contains a non terminal multiply expression.
*****************************************************************************/

namespace InterpreterDesignPatternDemo
{
    /// <summary>
    /// Creates a multiply expression implementing interpret method.
    /// </summary>
    public class MultiplyExpression : Expression
    {
        private readonly Expression _leftExpression; // For the left operand of the expression
        private readonly Expression _rightExpression; // For the right operand of the expression

        /// <summary>
        /// Initialises the left and right expressions
        /// </summary>
        /// <param name="left">The left expression of multiply.</param>
        /// <param name="right">The right expression of multiply.</param>

        public MultiplyExpression( Expression leftExpression , Expression rightExpression )
        {
            _leftExpression = leftExpression;
            _rightExpression = rightExpression;
        }

        /// <summary>
        /// Multiplies the value associated with the left and right expression.
        /// </summary>
        /// <returns>The product of the values of left and right expressions</returns>

        public int Interpret()
        {
            return _leftExpression.Interpret() * _rightExpression.Interpret();
        }
    }
}
