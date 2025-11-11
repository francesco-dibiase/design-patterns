using System.Drawing;

namespace DesignPatterns.Creational_Patterns.Builder
{
    internal abstract class Car : ICar
    {
        public virtual Color _Color { get; set; }
        public virtual int _HorsePower {  get; set; }
        public virtual void GearChange()
        {
            Console.WriteLine("Gear changed");
        }

        public virtual void StartEngine()
        {
            Console.WriteLine("Engine Started");
        }
        public virtual void ChangePainting(Color color)
        {
            _Color = color;
            Console.WriteLine($"The car painting has been changed to {color.Name}");
        }
        public virtual void ChangeHorsePower(int hp)
        {
            _HorsePower = hp;
            Console.WriteLine($"Horse Power has been set to \"{hp} Horse Power\"");
        }
    }
}
