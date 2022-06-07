using ConsoleGame.Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Map map = new Map();
            string newMap = string.Join(null, map.GameMap);
            map.DrawMap(newMap);
        }
    }
}
