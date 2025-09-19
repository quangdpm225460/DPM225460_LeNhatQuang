namespace FlyweightDemo
{
    // Flyweight: trạng thái dùng chung
    public class TreeType
    {
        public string Name { get; }
        public string Color { get; }
        public string Texture { get; }

        public TreeType(string name, string color, string texture)
        {
            Name = name;
            Color = color;
            Texture = texture;
        }

        public void Draw(int x, int y)
        {
            Console.WriteLine($"Draw {Name} tree with color {Color} at ({x}, {y})");
        }
    }
}
