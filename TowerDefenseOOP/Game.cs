using System;
namespace TreehouseDefense
{
    class Game
    {
        public static void Main()
        {

            Map map = new Map(5, 8);
            Point point = new Point(4, 2);

            int area = map.Width * map.Height;
            Console.WriteLine(area);

            bool isOnMap = map.OnMap(point);
            Console.WriteLine(isOnMap);
            point = new Point(5, 8);
            isOnMap = map.OnMap(point);
            Console.WriteLine(isOnMap);
            Console.WriteLine(point.DistanceTo(1, 4));

            try
            {
                MapLocation ppp = new MapLocation(9, 4, map);

                Console.WriteLine(point.DistanceTo(ppp));
            }
            catch (OutrOfBoundsException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (TreehouseDefenseException)
            {
                Console.WriteLine("unhandled TreehouseException");
            }
            catch (Exception)
            {
                Console.WriteLine("unhandled Exception");
            }




        }

    }
}