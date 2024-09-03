/******************************************************************************
* Filename    = NumberExpressionTests.cs
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
    public class NumberExpressionTests
    {
        [TestMethod]
        public void Interpret_ShouldReturnNumber()
        {
            // Arrange
            int expected = 5;
            var numberExpression = new NumberExpression( expected );

            // Act
            int result = numberExpression.Interpret();

            // Assert
            Assert.AreEqual( expected , result );
        }
    }
}
