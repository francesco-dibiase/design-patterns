namespace DesignPatterns.Creational_Patterns.Prototype
{
    internal class Circle : Shape
    {
        public Circle(string id)
        {
            base.Type = "Circle";
            base.Id = id;
        }
        public override object Clone()
        {
            Shape shape = (Shape)this.MemberwiseClone();
            return shape;
        }
        public override object Clone(string id)
        {
            Shape shape = (Shape)this.MemberwiseClone();
            shape.Id = id;
            return shape;
        }
    }
}
