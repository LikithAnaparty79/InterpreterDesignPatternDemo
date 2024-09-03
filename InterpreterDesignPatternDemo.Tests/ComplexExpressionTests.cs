/******************************************************************************
* Filename    = ComplexExpressionTests.cs
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
    public class ComplexExpressionTests
    {
        [TestMethod]
        public void Interpret_ShouldEvaluateComplexExpression()
        {
            // Arrange
            var five = new NumberExpression( 5 );
            var ten = new NumberExpression( 10 );
            var two = new NumberExpression( 2 );
            var three = new NumberExpression( 3 );

            var add1 = new AddExpression( five , ten );   // (5 + 10)
            var add2 = new AddExpression( two , three );  // (2 + 3)

            var complexExpression = new SubtractExpression( add1 , add2 ); // (5 + 10) - (2 + 3)
            int expected = 10;

            // Act
            int result = complexExpression.Interpret();

            // Assert
            Assert.AreEqual( expected , result );
        }

        [TestMethod]
        public void Interpret_ShouldReturnZeroForEqualOperandsInSubtraction()
        {
            // Arrange
            var ten1 = new NumberExpression( 10 );
            var ten2 = new NumberExpression( 10 );

            var subtractExpression = new SubtractExpression( ten1 , ten2 ); // 10 - 10
            int expected = 0;

            // Act
            int result = subtractExpression.Interpret();

            // Assert
            Assert.AreEqual( expected , result );
        }
    }
}
