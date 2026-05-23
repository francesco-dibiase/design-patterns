namespace DesignPatterns.Creational_Patterns.Builder
{
    internal interface ICarBuilder<T> where T : ICar
    {
        T BuildCar();
    }
}
