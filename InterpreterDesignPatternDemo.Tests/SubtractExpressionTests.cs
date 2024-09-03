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
    public class SubtractExpressionTests
    {
        [TestMethod]
        public void Interpret_ShouldReturnDifferenceOfTwoNumbers()
        {
            // Arrange
            var leftExpression = new NumberExpression( 10 );
            var rightExpression = new NumberExpression( 5 );
            var subtractExpression = new SubtractExpression( leftExpression , rightExpression );
            int expected = 5;

            // Act
            int result = subtractExpression.Interpret();

            // Assert
            Assert.AreEqual( expected , result );
        }
    }
}
