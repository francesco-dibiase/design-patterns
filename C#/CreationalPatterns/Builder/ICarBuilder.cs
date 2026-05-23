using System.Drawing;

namespace DesignPatterns.CreationalPatterns.Builder
{
      public interface ICarBuilder
      {
            public ICarBuilder Paint(Color color);
            public ICarBuilder MountEngine(Engine engine);
            public ICarBuilder MountShift(Shift shift);
            public Car BuildCar();
      }
}
