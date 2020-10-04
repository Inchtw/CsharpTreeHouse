using System;
namespace TreehouseDefense
{
    // final one
    class Tower
    {
        private const int _range = 1; // follow by private rule
        private const int _power = 1;

        private const double _accuracy = .75;
        // for 不準確射擊
        private static readonly Random _random = new Random();

        public bool IsSuccessfulShot()
        {
            return _random.NextDouble() < _accuracy;  // 表示75％機率會中  
        }

        private readonly MapLocation _location;
        public Tower(MapLocation location)
        {
            _location = location;
        }
        public void FireOnInvaders(Invader[] invaders)
        {
            // int i = 0;
            // while (i < invaders.Length)
            // {
            //     Invader invader = invaders[i];
            //     i++;
            // }
            // for 
            // for (int i; i < invaders.Length; i++)
            // {
            //     Invader invader = invaders[i];
            // }
            foreach (Invader invader in invaders)
            {
                if (invader.IsActive && _location.InRangeOf(invader.Location, _range))
                {
                    if (IsSuccessfulShot())
                    {
                        invader.DecreaseHealth(_power);
                        Console.WriteLine("Shot at and hit an invader!");
                        if (invader.IsNeutralized)
                        {
                            Console.WriteLine("Neutralized an invader!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Shot at but not hit an invader!");
                    }

                    break;//  Finally let's handicap the towers a bit by only letting them shoot at one tower at a time.

                }
            }
        }

    }
}