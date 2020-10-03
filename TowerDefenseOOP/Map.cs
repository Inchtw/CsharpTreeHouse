namespace TreehouseDefense
{
    class Map
    {
        public readonly int Width;// instant variable 
        public readonly int Height;
        public Map(int width, int height) // method level variable
        {
            Width = width;
            Height = height;
        }
        public bool OnMap(Point point)
        {
            // bool inBounds = point.X >= 0 && point.X < Map.Width && point.Y > -0 && point.Y < Map.Height;
            // bool inBounds = !(point.X < 0 || point.X >= Width || point.Y < 0 || point.Y >= Height);
            // bool outOfBounds = point.X < 0 || point.X >= Width || point.Y < 0 || point.Y >= Height;
            // inBounds = !outOfBounds;
            // return inBounds;

            //short 
            return point.X >= 0 && point.X < Width &&
                   point.Y > -0 && point.Y < Height;
        }
    }
}