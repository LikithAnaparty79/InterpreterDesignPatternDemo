/******************************************************************************
* Filename    = MultiplicationExpressionTests.cs
*
* Author      = Likith Anaparty
*
* Product     = InterpreterDesignPatternDemo
* 
* Project     = MultiplicationExpressionTests
*
* Description = Unit test for multiply expression
*****************************************************************************/

namespace InterpreterDesignPatternDemo.Tests
{

    /// <summary>
    /// Unit test for comptuting multiplication of two expressions
    /// </summary>
    [TestClass]
    public class MultiplyExpressionTests
    {
        /// <summary>
        /// Tests if 5 * 10 = 50
        /// </summary>
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
