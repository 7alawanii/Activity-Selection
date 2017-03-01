using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_Selection
{
    public class Node
    {

        public int Start;
        public int End;
        public int Dur;
        public int Order;
        public Node(int s, int e,int o)
        {
            this.Start = s;
            this.End = e;
            this.Dur = e-s;
            this.Order = o;
        }
    }
}
