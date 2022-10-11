using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Lydia's code
//Corrected by Kevin Bloomquist

namespace CST117_IC08_console
{
    class Set
    {
        private List<int> elements;

        public Set()
        {
            elements = new List<int>();
        }
        public bool addElement(int val)
        {
            if (containsElement(val)) return false;
            else
            {
                elements.Add(val);
                return true;
            }
        }
        private bool containsElement(int val)
        {
            for (int i = 0; i < elements.Count; i++)
            {
                if (val == elements[i])
                    return true;
                //breaks loop after first iteration
                //else
                //    return false;
            }
            return false;
        }
        public override string ToString()
        {
            string str = "";
            foreach (int i in elements)
            {
                str += i + " ";
            }
            return str;
        }
        public void clearSet()
        {
            elements.Clear();
        }
        public Set union(Set rhs)
        {
            //create empty template to preserve original sets
            Set unionOut = new Set();
            for (int i = 0; i < rhs.elements.Count; i++)
            {
                //adds elements to original set
                //this.addElement(rhs.elements[i]);
                unionOut.addElement(rhs.elements[i]);
            }
            //missing elements from local set
            for (int i = 0; i < elements.Count; i++)
            {
                unionOut.addElement(elements[i]);
            }
            //returns unmodified input set
            //return rhs;

            return unionOut;
        }
    }
}