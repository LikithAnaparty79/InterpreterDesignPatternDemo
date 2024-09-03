/******************************************************************************
* Filename    = AddExpression.cs
*
* Author      = Likith Anaparty
*
* Product     = InterpreterDesignPatternDemo
* 
* Project     = AddExpresion
*
* Description = Contains a non terminal add expression.
*****************************************************************************/

namespace InterpreterDesignPatternDemo { 

    /// <summary>
    /// Creates a add expression implementing interpret method.
    /// </summary>
    public class AddExpression : IExpression
    {
        private readonly IExpression _leftExpression; // For the left operand of the expression
        private readonly IExpression _rightExpression; // For the right operand of the expression

        /// <summary>
        /// Initialises the left and right expressions
        /// </summary>
        /// <param name="left">The left expression of add.</param>
        /// <param name="right">The right expression of add.</param>
        public AddExpression(IExpression left, IExpression right) 
        {
            _leftExpression = left;
            _rightExpression = right;
        }
        
        /// <summary>
        /// Adds the value associated with the left and right expression.
        /// </summary>
        /// <returns>The sum of the values of left and right expressions</returns>
        public int Interpret()
        {
            return _leftExpression.Interpret() + _rightExpression.Interpret();
        }
    }
}
