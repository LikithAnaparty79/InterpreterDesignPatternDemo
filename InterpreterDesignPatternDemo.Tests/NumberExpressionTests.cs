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
        public void InterpretShouldReturnNumber()
        {
            int expected = 5;
            var numberExpression = new NumberExpression( expected );
            int result = numberExpression.Interpret();

            Assert.AreEqual( expected , result );
        }
    }
}
