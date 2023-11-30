namespace FlyweightPattern{
    public class Forest{
        private List<Tree> _trees = new();

        public void PlantTree(int x, int y, string name, string color, string texture){
            TreeType type = TreeFactory.GetTreeType(name, color, texture);
            Tree tree = new(x, y, type);
            _trees.Add(tree);
        }

        public void Draw(){
            foreach(Tree tree in _trees){
                tree.Draw();
            }
        }
    }
}