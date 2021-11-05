using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueue
{
    class NodeStack
    {
        public int data;
        public NodeStack next;
        public NodeStack(int data)
        {
            this.data = data;
        }
    }
}
