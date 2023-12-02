namespace FlyweightPattern{
    public class Forest{
        private readonly List<Tree> _trees = new();

        public void PlantTree(int x, int y, string name, string color, string texture){
            TreeType type = TreeFactory.GetTreeType(name, color, texture);
            Tree newTree = new(x,y,type);
            _trees.Add(newTree);
        }

        public void Draw(){
            foreach(Tree tree in _trees){
                tree.Draw();
            }
        }
    }
}