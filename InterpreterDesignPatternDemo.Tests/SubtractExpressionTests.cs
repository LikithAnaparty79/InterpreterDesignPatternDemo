﻿/******************************************************************************
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
        public void InterpretShouldReturnDifferenceOfTwoNumbers()
        {
            var leftExpression = new NumberExpression( 10 );
            var rightExpression = new NumberExpression( 5 );
            var subtractExpression = new SubtractExpression( leftExpression , rightExpression );
            int expected = 5;
            int result = subtractExpression.Interpret();

            Assert.AreEqual( expected , result );
        }
    }
}
