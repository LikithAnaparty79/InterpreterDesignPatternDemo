namespace InterpreterDesignPatternDemo
{
    public class MultiplyExpression : Expression
    {
        private readonly Expression _leftExpression;
        private readonly Expression _rightExpression;

        public MultiplyExpression( Expression leftExpression , Expression rightExpression )
        {
            _leftExpression = leftExpression;
            _rightExpression = rightExpression;
        }

        public int Interpret()
        {
            return _leftExpression.Interpret() * _rightExpression.Interpret();
        }
    }
}
