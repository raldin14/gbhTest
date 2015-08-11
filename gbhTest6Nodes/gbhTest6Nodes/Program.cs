using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace gbhTest6Nodes
{
    class Program
    {
        static void Main(string[] args)
        {
            ///////////////////////////////////////////Part 6/////////////////////////////
            ListaEnlazada listNodes = new ListaEnlazada();

            listNodes.Insertar(12);
            listNodes.Insertar(99);
            listNodes.Insertar(37);

            listNodes.Visited();

            Console.ReadLine();
        }
    }
}
