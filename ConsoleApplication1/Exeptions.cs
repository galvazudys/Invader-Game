using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class TreehouseDefenceException : Exception
    {
        public TreehouseDefenceException()
        {

        }
        public TreehouseDefenceException(string message) : base(message)
        {

        }
    }
    class OutOfBoundsException : TreehouseDefenceException // we can inhereth as many we  want even from subclass
    {
        public OutOfBoundsException()
        {

        }
        public OutOfBoundsException(string message) : base(message)
        {

        }
    }
}
