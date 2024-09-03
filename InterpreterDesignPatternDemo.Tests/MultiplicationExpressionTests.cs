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

namespace InterpreterDesignPatternDemo.Tests
{
    [TestClass]
    public class MultiplyExpressionTests
    {
        [TestMethod]
        public void InterpretShouldReturnProductOfTwoNumbers()
        { 
            var leftExpression = new NumberExpression( 5 );
            var rightExpression = new NumberExpression( 10 );
            var multiplyExpression = new MultiplyExpression( leftExpression , rightExpression );
            int result = multiplyExpression.Interpret();

            Assert.AreEqual( 50 , result );
        }
    }
}
