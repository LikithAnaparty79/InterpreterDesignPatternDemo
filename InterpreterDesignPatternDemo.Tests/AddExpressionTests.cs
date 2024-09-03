/******************************************************************************
* Filename    = AddExpressionTests.cs
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
    public class AddExpressionTests
    {
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
