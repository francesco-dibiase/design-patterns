using System.Drawing;

namespace DesignPatterns.CreationalPatterns.Builder
{
      public class CarBuilder : ICarBuilder
      {

            private Car Car;

            public CarBuilder()
            {
                  Car = new Car();
                  Console.WriteLine($"[ -- ]\tIt's been created a {Car.GetType().Name} builder");
            }

            public Car BuildCar()
            {
                  return Car;
            }

            public ICarBuilder MountEngine(Engine engine)
            {
                  Car.Engine = engine;
                  return this;
            }

            public ICarBuilder MountShift(Shift shift)
            {
                  Car.Shift = shift;
                  return this;
            }

            public ICarBuilder Paint(Color color)
            {
                  Car.Color = color;
                  return this;
            }
      }
}
