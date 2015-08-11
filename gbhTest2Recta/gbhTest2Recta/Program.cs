using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace gbhTest2Recta
{
    class Program
    {
        static void Main(string[] args)
        {
            ///////////////////////////////////////////Part 2/////////////////////////////
            /*Parte 2 del test
             * 1.  Cafe
             * 2.  Mantequilla
             * 4.  Arroz 
             * 8.  Habichuela
             * 16. Carne
             * 32. Pan
             * 64. Azucar
             * 128.Espaguetti
             * 255.Guandules             
             */
            
            int[] ingredente = {1,2,4,8,16,32,64,128,255};
            int receta = 12;
            int[] olla = new int[10];
            int c = 0;
            int sum = 0;
            int remain = receta;
            while(sum < receta && !(sum > receta)){

                for (int i = 0; i < remain; i++) 
                {

                    if (ingredente[i] > remain )
                    {
                        olla[c] = ingredente[i - 1];
                        remain -= olla[c];
                        c++;
                        break;
                    }
                    else if (ingredente[i] == remain)
                    {
                        olla[c] = ingredente[i];
                        remain -= olla[c];
                        c++;
                        break;
                    }
                }
                sum = olla.Sum();
            }
            Console.WriteLine("Receta #{0}", sum);
            Console.Write("Rica receta de ");
            for (int j = 0; j < olla.Length; j++)
            {
                switch (olla[j])
                {
                    case 1:
                        Console.Write(" Cafe ");
                        break;
                    case 2:
                        Console.Write(" Mantequilla ");
                        break;
                    case 4:
                        Console.Write(" Arroz ");
                        break;
                    case 8:
                        Console.Write(" Habichuela ");
                        break;
                    case 16:
                        Console.Write(" Carne ");
                        break;
                    case 32:
                        Console.Write(" Pan ");
                        break;
                    case 64:
                        Console.Write(" Azucar ");
                        break;
                    case 128:
                        Console.Write(" Espaguetti ");
                        break;
                    case 255:
                        Console.Write(" Guandules ");
                        break;
                    default:
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}
