namespace InterpreterDesignPatternDemo
{
    public class DivideExpression : Expression
    {
        private readonly Expression _leftExpression;
        private readonly Expression _rightExpression;

        public DivideExpression( Expression leftExpression , Expression rightExpression )
        {
            _leftExpression = leftExpression;
            _rightExpression = rightExpression;
        }

        public int Interpret()
        {
            int rightResult = _rightExpression.Interpret();
            if (rightResult == 0)
            {
                throw new DivideByZeroException( "Cannot divide by zero." );
            }
            return _leftExpression.Interpret() / rightResult;
        }
    }
}
