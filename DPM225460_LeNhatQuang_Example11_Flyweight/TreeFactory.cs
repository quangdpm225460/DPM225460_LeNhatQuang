﻿namespace FlyweightDemo
{
    // Flyweight Factory
    public class TreeFactory
    {
        private static Dictionary<string, TreeType> _treeTypes = new();

        public TreeFactory()
        {
        }

        public static TreeType GetTreeType(string name, string color, string texture)
        {
            string key = name + color + texture;
            if (!_treeTypes.ContainsKey(key))
            {
                _treeTypes[key] = new TreeType(name, color, texture);
            }
            return _treeTypes[key];
        }
    }
}
