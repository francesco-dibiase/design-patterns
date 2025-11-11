using System.Drawing;

namespace DesignPatterns.Creational_Patterns.Builder
{
    internal class BMW : Car
    {
        public readonly string Brand = "BMW";
        public readonly string HorsePower = "150hp";
        public Color painting { get; private set; } = Color.White;
        public BMW() { }
        public override void ChangePainting(Color color)
        {
            painting = color;
            Console.WriteLine($"the color of your BMW has been changed to ${color.Name}");
        }
        public override void GearChange()
        {
            base.GearChange();
        }
        public override void StartEngine()
        {
            Console.WriteLine("BMW Engine Started");
        }
    }
}
