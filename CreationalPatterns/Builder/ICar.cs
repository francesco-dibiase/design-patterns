using System.Drawing;

namespace DesignPatterns.Creational_Patterns.Builder
{
    internal interface ICar
    {
        void ChangePainting(Color color);
        void StartEngine();
        void GearChange();
    }
}
