namespace TreehouseDefense
{
    class Path
    {
        private readonly MapLocation[] _path;

        // properties part
        public int Length => _path.Length;

        public Path(MapLocation[] path)
        {
            _path = path;
        }
        // private MapLocation[] path;
        // public Path(MapLocation[] path) // this path = MapLocation
        // {
        //     this.path = path;
        // }
        public MapLocation GetLocationAt(int pathStep)
        {
            // try
            // {
            //     return _path[pathStep];
            // }
            // catch (System.IndexOutOfRangeException)
            // {
            //     return null;
            // }
            //  this kind catch is expensive 

            // // original 
            // if (pathStep < _path.Length)
            // {
            //     return _path[pathStep];
            // }
            // else
            // {
            //     return null;
            // }

            //short

            return (pathStep < _path.Length) ? _path[pathStep] : null;



        }


    }
}