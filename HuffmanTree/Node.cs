using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _12253021HW3
{
    class Node 
    {
        string value;
        int value2;

        public int Value2
        {
            get { return value2; }
            set { value2 = value; }
        }

        public string Value
        {
            get { return this.value; }
            set { this.value = value; }
        }

        
        Node left, right,next;

        public Node Next
        {
            get { return next; }
            set { next = value; }
        }

        internal Node Right
        {
            get { return right; }
            set { right = value; }
        }

        internal Node Left
        {
            get { return left; }
            set { left = value; }
        }
        public Node(string val)
        {
            value = val;
            
        }
        public override string ToString()
        {
            return value.ToString();
        }

    }
}
