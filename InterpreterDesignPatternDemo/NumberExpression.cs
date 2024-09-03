/******************************************************************************
* Filename    = NumberExpression.cs
*
* Author      = Likith Anaparty
*
* Product     = InterpreterDesignPatternDemo
* 
* Project     = NumberExpression
*
* Description = Creates a terminal number expression
*****************************************************************************/

namespace InterpreterDesignPatternDemo
{
    public class NumberExpression : IExpression
    {
        private int _number;
        public NumberExpression(int number)
        {
            _number = number;
        }

        public int Interpret()
        {
            return _number;
        }
    }
}
