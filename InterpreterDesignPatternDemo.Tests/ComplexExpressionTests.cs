﻿/******************************************************************************
* Filename    = ComplexExpressionTests.cs
*
* Author      = Likith Anaparty
*
* Product     = InterpreterDesignPatternDemo
* 
* Project     = ComplexExpressionTests
*
* Description = Unit tests for calculating values of complex expression
*****************************************************************************/
namespace InterpreterDesignPatternDemo.Tests
{
    /// <summary>
    /// Unit test for comptuting values of complex expressions
    /// </summary>
    [TestClass]
    public class ComplexExpressionTests
    {
        /// <summary>
        /// Tests if ((3+10) * (9+8)) = 221
        /// </summary>
        [TestMethod]
        public void InterpretShouldEvaluateComplexExpression()
        {
            var eight = new NumberExpression( 8 );
            var ten = new NumberExpression( 10 );
            var nine = new NumberExpression( 9 );
            var three = new NumberExpression( 3 );
            var add1 = new AddExpression( three , ten );   
            var add2 = new AddExpression( nine , eight );  
            var complexExpression = new MultiplyExpression( add1 , add2 );
            int result = complexExpression.Interpret();

            Assert.AreEqual( 221 , result );
        }
        // <summary>
        /// Tests if 10 - 10 = 0
        /// </summary>
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
