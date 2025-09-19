namespace FlyweightDemo
{
    public class Forest
    {
        private List<Tree> trees = new();

        public void PlantTree(int x, int y, string name, string color, string texture)
        {
            TreeType type = TreeFactory.GetTreeType(name, color, texture);
            trees.Add(new Tree(x, y, type));
        }

        public void Draw()
        {
            foreach (var tree in trees)
            {
                tree.Draw();
            }
        }
    }
}
