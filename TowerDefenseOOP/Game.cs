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
                    new MapLocation(6, 2,map),
                    new MapLocation(7, 2,map)
                    };

                Path path = new Path(arrays);

                MapLocation location = path.GetLocationAt(0);

                Console.WriteLine(location.X + "," + location.Y);


                Path abc = new Path(
                    new[] {
                    new MapLocation(0, 2, map),
                    new MapLocation(1, 2, map),
                    new MapLocation(2, 2, map),
                    new MapLocation(3, 2, map),
                    new MapLocation(4, 2, map),
                    new MapLocation(5, 2, map),
                    new MapLocation(6, 2,map),
                    new MapLocation(7, 2,map)
                    }
                );

                // MapLocation location2 = abc.GetLocationAt(8);
                // if (location2 != null)
                // {
                //     Console.WriteLine(location2.X + "," + location2.Y);
                // }

                Invader invader = new Invader(abc);
                //  MapLocation invaderlocation = new MapLocation(1, 2, map);
                // invader.Location = invaderlocation;
                // invaderlocation = invader.Location;
                // MapLocation invaderlocation2 = new MapLocation(3, 2, map);
                // invader.Location = invaderlocation2;
                // invaderlocation2 = invader.Location;
                // Console.WriteLine(invader.Location.X + "," + invader.Location.Y);
                // MapLocation ppp = new MapLocation(9, 4, map);

                // Console.WriteLine(point.DistanceTo(ppp));


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