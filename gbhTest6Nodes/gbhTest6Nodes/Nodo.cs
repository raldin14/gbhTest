using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace gbhTest6Nodes
{
    class Nodo
    {
        public int val;
        public Nodo prox;
        public Nodo ant;

        public Nodo(int nV)
        {
            val = nV;
        }

        public void ListaNodo()
        {
            Console.WriteLine("{" + val + "}");
        }
    }
}
