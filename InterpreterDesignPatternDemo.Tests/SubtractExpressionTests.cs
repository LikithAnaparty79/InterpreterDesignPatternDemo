/******************************************************************************
* Filename    = SubtractExpressionTests.cs
*
* Author      = Likith Anaparty
*
* Product     = InterpreterDesignPatternDemo
* 
* Project     = SubtractExpressionTests
*
* Description = Unit test for subtract expression
*****************************************************************************/

namespace InterpreterDesignPatternDemo.Tests
{
    /// <summary>
    /// Unit test for comptuting subtraction of two expressions
    /// </summary>
    [TestClass]
    public class SubtractExpressionTests
    {
        /// <summary>
        /// Tests if 10 - 5 = 5
        /// </summary>
        [TestMethod]
        public void InterpretShouldReturnDifferenceOfTwoNumbers()
        {
            var leftExpression = new NumberExpression( 10 );
            var rightExpression = new NumberExpression( 5 );
            var subtractExpression = new SubtractExpression( leftExpression , rightExpression );
            int expected = 5;
            int result = subtractExpression.Interpret();

            Assert.AreEqual( expected , result );
        }
    }
}
