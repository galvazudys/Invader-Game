using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Path
    {
        private readonly MapLocation[] _path;

        public int Length => _path.Length;

        public Path(MapLocation[] path)
        {
            _path = path;
        }

        public MapLocation GetLocationAt(int pathStep)
        {//first option longer,with  next one we gone make it more apiling

            /* if(pathStep < _path.Length)
             {
                 return _path[pathStep];
             }
            else 
             {

                 return null;
             }
  */
            return (pathStep < _path.Length) ? _path[pathStep] : null;
        }

        public bool IsOnPath(MapLocation location)
        {
            foreach (var pathLocation in _path)
            {
                if (location == pathLocation)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
