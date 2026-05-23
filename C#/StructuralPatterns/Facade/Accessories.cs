namespace DesignPatterns.Structural_Patterns.Facade.Accessories
{
    public interface IDisk
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
    }
    public abstract class Disk : IDisk
    {
        public string Name { get => Name; set => Name = value; }
        public string Description { get => Description; set => Description = value; }
        public string Type { get => Type; set => Type = this.GetType().Name; }
    }

    public class DVD : Disk
    {
        public DVD(string name, string description)
        {
            base.Name = name;
            base.Description = description;
        }
    }
}
