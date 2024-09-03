/******************************************************************************
* Filename    = DivisionExpression.cs
*
* Author      = Likith Anaparty
*
* Product     = InterpreterDesignPatternDemo
* 
* Project     = DivisionExpression
*
* Description = Contains a non terminal divide expression.
*****************************************************************************/

namespace InterpreterDesignPatternDemo
{
    /// <summary>
    /// Creates a divide expression implementing interpret method.
    /// </summary>
    public class DivideExpression : Expression
    {
        private readonly Expression _leftExpression; // For the left operand of the expression
        private readonly Expression _rightExpression; // For the right operand of the expression

        /// <summary>
        /// Initialises the left and right expressions
        /// </summary>
        /// <param name="left">The left expression of divide.</param>
        /// <param name="right">The right expression of divide.</param>

        public DivideExpression( Expression leftExpression , Expression rightExpression )
        {
            _leftExpression = leftExpression;
            _rightExpression = rightExpression;
        }

        /// <summary>
        /// Checks the numerical value associated with the right expression.
        /// Divides the value associated with the left and right expression.
        /// </summary>
        /// <returns>Throws an error if the value associated with the right expression is zero.
        /// or The division of the values of left and right expressions</returns>

        public int Interpret()
        {
            int rightResult = _rightExpression.Interpret();
            if (rightResult == 0)
            {
                throw new DivideByZeroException( "Cannot divide by zero." );
            }
            return _leftExpression.Interpret() / rightResult;
        }
    }
}
