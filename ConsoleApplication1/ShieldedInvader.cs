using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class ShieldedInvader : Invader
    {
        public override int Health { get; protected set; } = 2;
        private static Random _random = new Random();
        public ShieldedInvader(Path path) : base(path)
        {

        }

        public override void DecreaseHealth(int factor)
        {
            if (_random.NextDouble() < .5)
            {
                base.DecreaseHealth(factor);
            }
            else
            {
                Console.WriteLine("Shot at Shielded Invader but  sustained no damage.");
            }
        }
    }
}
