using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace gbhTest7Nodes
{
    class ListaEnlazada
    {
        Nodo primero;
        Nodo ultimo;
        public ListaEnlazada()//UN  CONSTRUCTOR POR DEFAULT
        {
            primero = null;
            ultimo = null;
        }

        public void Insertar(int v)
        {
            Nodo temp = new Nodo(v);
            if (ListaVacia())
            {
                primero = temp;
                ultimo = temp;
            }
            else
            {
                temp.prox = primero;
                primero.ant = temp;
                primero = temp;
            }

        }
        public void Visited()
        {
            Nodo aux;
            aux = primero;
            while (aux != null)
            {
                Console.Write(aux.val + "->");
                aux = aux.prox;
            }
            Console.Write(" NULL ");
            Console.WriteLine();
        }

        public void VisitedCiclo()
        {
            Nodo aux;
            aux = primero;
            while (aux != null)
            {
                Console.Write(aux.val + "->");
                aux = aux.prox;

            }
            UltimoCiclo();
            Console.WriteLine();
        }
        public bool ListaVacia()
        {
            if (primero == null)
                return true;
            return false;
        }

        public void UltimoCiclo()
        {
            if (!ListaVacia())
                Console.Write(primero.val);
        }
    }
}
