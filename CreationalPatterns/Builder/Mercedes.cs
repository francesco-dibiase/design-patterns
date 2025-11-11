using System.Drawing;

namespace DesignPatterns.Creational_Patterns.Builder
{
    internal class Mercedes : Car
    {
        public readonly string Brand = "Mercedes";
        public readonly string HorsePower = "180hp";
        public Color painting { get; private set; } = Color.Red;
        public Mercedes() { }

        public override void ChangePainting(Color color)
        {
            painting = color;
            Console.WriteLine($"the color of your Mercedes has been changed to ${color.Name}");
        }
        public override void StartEngine()
        {
            Console.WriteLine("Mercedes Engine Started");
        }
        public override void ChangeHorsePower(int hp)
        {
            _HorsePower = hp;
            Console.WriteLine($"Mercedes horse Power has been set to \"{hp} Horse Power\"");
        }
    }
}
