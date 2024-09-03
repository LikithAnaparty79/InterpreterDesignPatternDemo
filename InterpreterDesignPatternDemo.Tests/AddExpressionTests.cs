/******************************************************************************
* Filename    = AddExpressionTests.cs
*
* Author      = Likith Anaparty
*
* Product     = InterpreterDesignPatternDemo
* 
* Project     = AddExpressionTests
*
* Description = Unit test for checking add expression
*****************************************************************************/

namespace InterpreterDesignPatternDemo.Tests
{
    /// <summary>
    /// Unit test for comptuting addition of two expressions
    /// </summary>
    [TestClass]
    public class AddExpressionTests
    {
        /// <summary>
        /// Tests 5 + 10 = 15
        /// </summary>
        [TestMethod]
        public void InterpretShouldReturnSumOfTwoNumbers()
        {
            var leftExpression = new NumberExpression( 5 );
            var rightExpression = new NumberExpression( 10 );
            var addExpression = new AddExpression( leftExpression , rightExpression );
            int result = addExpression.Interpret();

            // Assert
            Assert.AreEqual( 15 , result );
        }
    }
}
