namespace FlyweightPattern{
    public class Tree{
        private int _x, _y;
        private TreeType _treeType;

        public Tree(int x, int y, TreeType treeType){
            _x = x;
            _y = y;
            _treeType = treeType;
        }

        public void Draw(){
            _treeType.Draw(_x, _y);
        }
    }
}