using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    abstract class Invader : IInvader
    {

        /*  public MapLocation GetLocation() // here we get and set method
          {
              return _location;
          }

          public void SetLocation(MapLocation value)
          {
              _location = value;
          }*/

        // we can do same just by using properties
        private readonly Path _path;

        private int _pathStep = 0;

        protected virtual int StepSize { get; } = 1;

        public MapLocation Location => _path.GetLocationAt(_pathStep);

        public abstract int Health { get; protected set; }

        public bool HasScored { get { return _pathStep >= _path.Length; } }

        public bool isNeutralized => Health <= 0;

        public bool isActive => !(isNeutralized || HasScored);

        public Invader(Path path)
        {
            _path = path;
        }

        public void Move() => _pathStep += StepSize;

        //add health to invaders
        // 
        public virtual void DecreaseHealth(int factor)
        {
            Health -= factor;
            Console.WriteLine("Shot at and hit an invader");
        }

    }

}



