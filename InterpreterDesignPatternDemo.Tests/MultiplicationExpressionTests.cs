
namespace InterpreterDesignPatternDemo.Tests
{
    [TestClass]
    public class MultiplyExpressionTests
    {
        [TestMethod]
        public void InterpretShouldReturnProductOfTwoNumbers()
        {
            // Arrange
            var leftExpression = new NumberExpression( 5 );
            var rightExpression = new NumberExpression( 10 );
            var multiplyExpression = new MultiplyExpression( leftExpression , rightExpression );
            int expected = 50;

            // Act
            int result = multiplyExpression.Interpret();

            // Assert
            Assert.AreEqual( expected , result );
        }
    }
}
