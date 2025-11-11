namespace DesignPatterns.Creational_Patterns.Prototype
{
    internal class Square : Shape
    {
        public Square(string id)
        {
            base.Type = "Square";
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
