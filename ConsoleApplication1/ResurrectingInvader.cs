using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class ResurrectingInvader : IInvader
    {
        private BasicInvader _incarnacion1;
        private StrongInvader _incarnation2;


        public bool HasScored => _incarnacion1.HasScored || _incarnation2.HasScored;
        public int Health => _incarnacion1.isNeutralized ? _incarnation2.Health : _incarnacion1.Health;
        public bool isActive => !(isNeutralized || HasScored);
        public bool isNeutralized => _incarnacion1.isNeutralized && _incarnation2.isNeutralized;
        public MapLocation Location => _incarnacion1.isNeutralized ? _incarnation2.Location : _incarnacion1.Location;


        public ResurrectingInvader(Path path)
        {
            _incarnacion1 = new BasicInvader(path);
            _incarnation2 = new StrongInvader(path);

        }



        public void Move()
        {
            _incarnacion1.Move();
            _incarnation2.Move();
        }

        public void DecreaseHealth(int factor)
        {
            if (!_incarnacion1.isNeutralized)
            {
                _incarnacion1.DecreaseHealth(factor);
            }
            else
            {
                _incarnation2.DecreaseHealth(factor);
            }
        }
    }
}
