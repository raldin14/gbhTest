using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace gbhTest7Nodes
{
    class Program
    {
        static void Main(string[] args)
        {             
            ///////////////////////////////////////////Part 7/////////////////////////////
            ListaEnlazada listNodes = new ListaEnlazada();

            listNodes.Insertar(12);
            listNodes.Insertar(99);
            listNodes.Insertar(37);
            listNodes.VisitedCiclo();
            Console.ReadLine();
        }
    }
}
