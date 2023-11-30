namespace FlyweightPattern{
    public class TreeFactory{
        private static Dictionary<(string, string, string), TreeType> _treeTypes = new();

        public static TreeType GetTreeType(string name, string color, string texture){
            var key = (name, color, texture);

            if(!_treeTypes.TryGetValue(key, out TreeType? type)){
                type = new TreeType(name, color, texture);
                _treeTypes[key] = type;
            }

            return type;
        }
    }
}