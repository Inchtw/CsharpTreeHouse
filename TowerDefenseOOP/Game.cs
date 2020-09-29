using System;
namespace TreehouseDefense
{
    class Game
    {
        public static void Main()
        {
            Map map = new Map(5, 8);

            int area = map.Width * map.Height;
            Console.WriteLine(area);
            Tower tower = new Tower();
        }

    }
}