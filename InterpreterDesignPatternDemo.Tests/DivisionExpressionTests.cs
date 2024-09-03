/******************************************************************************
* Filename    = DivisionExpressionTests.cs
*
* Author      = Likith Anaparty
*
* Product     = InterpreterDesignPatternDemo
* 
* Project     = DivisionExpressionTests
*
* Description = Unit test for divide expression
*****************************************************************************/

namespace InterpreterDesignPatternDemo.Tests
{
    /// <summary>
    /// Unit test for comptuting division of two expressions
    /// </summary>
    [TestClass]
    public class DivideExpressionTests
    {
        // <summary>
        /// Tests if 20/4 = 5
        /// </summary>
        [TestMethod]
        public void InterpretShouldReturnQuotientOfTwoNumbers()
        {
            var leftExpression = new NumberExpression( 20 );
            var rightExpression = new NumberExpression( 4 );
            var divideExpression = new DivideExpression( leftExpression , rightExpression );
            int expected = 5;
            int result = divideExpression.Interpret();

            Assert.AreEqual( expected , result );
        }

        // <summary>
        /// Tests if 20/0 throws an exception "DivideByZeroException"
        /// </summary>

        [TestMethod]
        [ExpectedException( typeof( DivideByZeroException ) )]
        [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
        public void InterpretShouldThrowDivideByZeroException()
        {
            var leftExpression = new NumberExpression( 20 );
            var rightExpression = new NumberExpression( 0 );
            var divideExpression = new DivideExpression( leftExpression , rightExpression );

            divideExpression.Interpret();
        }
    }
}
