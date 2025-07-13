namespace DesignPatterns.BehavioralPatterns.Interpreter
{
    public interface IExpression<T>
    {
        public T Interpret();
    }
}
