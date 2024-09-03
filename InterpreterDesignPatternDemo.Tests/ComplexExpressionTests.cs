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
        public void InterpretShouldEvaluateComplexExpression()
        {
            var eight = new NumberExpression( 8 );
            var ten = new NumberExpression( 10 );
            var nine = new NumberExpression( 9 );
            var three = new NumberExpression( 3 );
            var add1 = new AddExpression( three , ten );   
            var add2 = new AddExpression( nine , eight );  
            var complexExpression = new SubtractExpression( add1 , add2 );
            int result = complexExpression.Interpret();

            Assert.AreEqual( -4 , result );
        }

        [TestMethod]
        public void InterpretShouldReturnZeroForEqualOperandsInSubtraction()
        {
            var ten1 = new NumberExpression( 10 );
            var ten2 = new NumberExpression( 10 );
            var subtractExpression = new SubtractExpression( ten1 , ten2 ); // 10 - 10
            int expected = 0;
            int result = subtractExpression.Interpret();

            Assert.AreEqual( expected , result );
        }
    }
}
