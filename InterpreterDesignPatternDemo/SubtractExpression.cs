/******************************************************************************
* Filename    = SubtractExpression.cs
*
* Author      = Likith Anaparty
*
* Product     = InterpreterDesignPatternDemo
* 
* Project     = SubtractExpression
*
* Description = Contains a non terminal subtract expression.
*****************************************************************************/

namespace InterpreterDesignPatternDemo
{
    /// <summary>
    /// Creates a subtract expression implementing interpret method.
    /// </summary>
    public class SubtractExpression : IExpression
    {
        private readonly IExpression _leftExpression; // For the left operand of the expression
        private readonly IExpression _rightExpression; // For the right operand of the expression

        /// <summary>
        /// Initialises the left and right expressions
        /// </summary>
        /// <param name="left">The left expression of subtract.</param>
        /// <param name="right">The right expression of subtract.</param>

        public SubtractExpression(IExpression left, IExpression right)
        {
            _leftExpression = left;
            _rightExpression = right;
        }
        /// <summary>
        /// Subtracts the value associated with the left and right expression.
        /// </summary>
        /// <returns>The difference of the values of left and right expressions</returns>
        public int Interpret()
        {
            return _leftExpression.Interpret() - _rightExpression.Interpret();
        }
    }
}
