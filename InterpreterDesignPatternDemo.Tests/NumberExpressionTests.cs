/******************************************************************************
* Filename    = NumberExpressionTests.cs
*
* Author      = Likith Anaparty
*
* Product     = InterpreterDesignPatternDemo
* 
* Project     = NumberExpressionTests
*
* Description = Unit test for number expression
*****************************************************************************/

namespace InterpreterDesignPatternDemo.Tests
{
    /// <summary>
    /// Unit test for checking number expression
    /// </summary>
    [TestClass]
    public class NumberExpressionTests
    {
        /// <summary>
        /// Tests if the number expression with input 5 outputs 5
        /// </summary>
        [TestMethod]
        public void InterpretShouldReturnNumber()
        {
            var numberExpression = new NumberExpression( 5 );
            int result = numberExpression.Interpret();

            Assert.AreEqual( 5, result );
        }
    }
}
