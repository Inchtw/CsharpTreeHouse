using System;
namespace TreehouseDefense
{
    class Game
    {
        public static void Main()
        {

            Map map = new Map(8, 5);
            // Point point = new Point(4, 2);





            // int area = map.Width * map.Height;
            // // Console.WriteLine(area);

            // bool isOnMap = map.OnMap(point);
            // // Console.WriteLine(isOnMap);
            // point = new Point(5, 8);
            // isOnMap = map.OnMap(point);
            // Console.WriteLine(isOnMap);
            // Console.WriteLine(point.DistanceTo(1, 4));

            try
            {
                MapLocation[] arrays =
                {
                    new MapLocation(0, 2, map),
                    new MapLocation(1, 2, map),
                    new MapLocation(2, 2, map),
                    new MapLocation(3, 2, map),
                    new MapLocation(4, 2, map),
                    new MapLocation(5, 2, map),
                    new MapLocation(6, 2, map),
                    new MapLocation(7, 2, map)
                    };

                Path path = new Path(arrays);



                Invader[] invaders = {
                    new Invader(path),
                    new Invader(path),
                    new Invader(path),
                    new Invader(path)
                };

                Tower[] towers = {
                    new Tower(new MapLocation(1, 3, map)),
                    new Tower(new MapLocation(3, 3, map)),
                    new Tower(new MapLocation(5, 3, map))
                };

                Level level = new Level(invaders)
                {
                    Towers = towers // 可以直接這樣寫 不然要寫成 level.Towers = towers; 
                    // 這是傳說中的 property

                };

                // level.Towers = towers;
                bool result = level.Play();
                Console.WriteLine(result);

                Console.WriteLine("Player " + (result ? "won" : "lost"));

            }
            catch (OutOfBoundsException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (TreehouseDefenseException)
            {
                Console.WriteLine("unhandled TreehouseException");
            }
            catch (Exception ex)
            {
                Console.WriteLine("unhandled Exception " + ex.Message);
            }




        }

    }
}