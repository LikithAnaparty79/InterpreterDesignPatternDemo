

namespace InterpreterDesignPatternDemo.Tests
{
    [TestClass]
    public class DivideExpressionTests
    {
        [TestMethod]
        public void Interpret_ShouldReturnQuotientOfTwoNumbers()
        {
            // Arrange
            var leftExpression = new NumberExpression( 20 );
            var rightExpression = new NumberExpression( 4 );
            var divideExpression = new DivideExpression( leftExpression , rightExpression );
            int expected = 5;

            // Act
            int result = divideExpression.Interpret();

            // Assert
            Assert.AreEqual( expected , result );
        }

        [TestMethod]
        [ExpectedException( typeof( DivideByZeroException ) )]
        public void Interpret_ShouldThrowDivideByZeroException()
        {
            // Arrange
            var leftExpression = new NumberExpression( 20 );
            var rightExpression = new NumberExpression( 0 );
            var divideExpression = new DivideExpression( leftExpression , rightExpression );

            // Act
            divideExpression.Interpret();
        }
    }
}
