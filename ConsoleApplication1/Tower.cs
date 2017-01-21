using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Tower
    {
        protected virtual int Range { get; } = 1;
        protected virtual int Power { get; } = 1;
        protected virtual double Accuracy { get; } = .75;

        private static readonly Random _random = new Random();

        private readonly MapLocation _location;

        public Tower(MapLocation location)
        {
            _location = location;
        }

        public bool IsSuccessfulShot()
        {
            return _random.NextDouble() < Accuracy;
        }

        public void FireOnInvaders(IInvader[] invaders)
        {
            /* for (int index = 0; index < invaders.Length; index++)
             {
                 Invader invader = invaders[index];
             }*/

            foreach (IInvader invader in invaders)
            {
                if (invader.isActive && _location.InRangeOf(invader.Location, Range))
                {
                    if (IsSuccessfulShot())
                    {
                        invader.DecreaseHealth(Power);


                        if (invader.isNeutralized)
                        {
                            Console.WriteLine("Neutralized and invader " + invader.Location + " !");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Shot and missed an invader.");
                    }

                    break;
                }
            }
        }
    }
}
