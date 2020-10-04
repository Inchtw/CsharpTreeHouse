namespace TreehouseDefense
{
    class Invader
    {
        // private MapLocation _location;
        // 手動做get / set
        // public MapLocation GetLocation()
        // {
        //     return _location;
        // }
        // public void SetLocation(MapLocation value)
        // {
        //     _location = value;
        // }

        // properties get /set 
        // private MapLocation _location;
        // public MapLocation Location
        // {
        //     get
        //     {
        //         return _location;
        //     }
        //     set
        //     {
        //         _location = value;
        //         System.Console.WriteLine("location change (" + value.X + "," + value.Y + ")");
        //     }

        private readonly Path _path; //因為要改變 就要開一個var 存：
        private int _pathStep = 0; // 都從0 開始  keep changing -> not readonly 
                                   // private int _pathStep; 其實可以這樣寫 因為int預設是0

        // }
        //auto - Properties
        // public MapLocation Location { get; private set; } // 因為set private 所以只能在內部set  -> constructor 

        // public Invader(Path path)
        // {
        //     _path = path;
        //     Location = _path.GetLocationAt(_pathStep);
        // }
        // public void Move()
        // {
        //     _pathStep += 1;
        //     Location = _path.GetLocationAt(_pathStep);
        // }


        // refractor 最大的好處就是 使用者不用管內部 只知道 打 invader.Location 就有相應的位置出來
        // public MapLocation Location     
        // {
        //     get
        //     {
        //         return _path.GetLocationAt(_pathStep);
        //     }
        // } 

        public MapLocation Location => _path.GetLocationAt(_pathStep);
        public Invader(Path path)
        {
            _path = path;
        }
        public void Move()
        {
            _pathStep += 1;
        }

        // new health properties
        public int Health { get; private set; } = 2; // private set 只能用 DecreaseHealth
        public void DecreaseHealth(int factor)
        {
            Health -= factor;
        }

        // property practice 
        public bool HasScored { get { return _pathStep >= _path.Length; } }
        public bool IsNeutralized => Health <= 0;
        public bool IsActive => !(IsNeutralized || HasScored);

    }
}