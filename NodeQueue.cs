using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueue
{
    class NodeQueue
    {
        public int data;
        public NodeQueue next;
        public NodeQueue(int data)
        {
            this.data = data;
        }
    }
}
