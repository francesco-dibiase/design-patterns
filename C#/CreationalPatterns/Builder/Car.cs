using System.Drawing;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace DesignPatterns.CreationalPatterns.Builder
{
      public class Car() : ICar
      {

            public Color? Color { get; internal set; } = null;
            public Engine? Engine { get; internal set; } = null;
            public Shift? Shift { get; internal set; } = null;

            public void GearChange()
            {
                  if (Shift == null) throw new CarNotWorkingException();
                  Console.WriteLine("[ -- ]\tGear changed");
            }

            public void StartEngine()
            {
                  if (Engine == null) throw new CarNotWorkingException();
                  Console.WriteLine("[ -- ]\tEngine Started");
            }
      }

      public class Engine(int horsePower)
      {
            public int HorsePower => horsePower;
      }

      public class Shift()
      {

      }

      public class CarNotWorkingException : Exception
      {
            public CarNotWorkingException()
            {
                  Console.WriteLine("Car is not working.");
            }

            public CarNotWorkingException(string message) : base(message)
            {
                  Console.WriteLine($"Car is not working: {message}");
            }
      }
}
