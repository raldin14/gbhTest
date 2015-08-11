using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace gbhTest
{
    class Program
    {
        static void Main(string[] args)
        {
            ///////////////////////////////////////////Part 1/////////////////////////////

            /*usado para crear los numeros del 1 al 1000000.*/
            //StreamWriter sw = new StreamWriter("number.txt");
            

            //for (int i = 0; i <= 1000000; i++)
            //{
            //    sw.Write(i);
            //    if (i < 1000000)
            //    {
            //        sw.Write(",");
            //    }
            //}
            //sw.Close();
            /*usado para asegurare de que se leyera todo correctamente*/
            StreamReader sr = new StreamReader("number.txt");
            string line = sr.ReadLine();
            //Console.WriteLine(line);
            ///*esta parte es usado para encontrar los repetidos*/
            ////int[] num = {1,2,3,2,5,6,7,3};
            ////int[] temp = new int[10];
            ////se utlizara para encontrar los repetidos en el archivo txt el cuales son 1, 23 y 350
            string[] num = line.Split(',');
            string[] temp = new string[line.Length];
            for (int i = 0; i < num.Length; i++)
            {
                temp[i] = num[i];
                for (int j = i + 1; j < num.Length; j++)
                {
                    if (temp[i] == num[j])
                    {
                        Console.WriteLine("El numero {0} esta repetido", num[i]);
                        break;
                    }

                }

            }
           
            Console.ReadLine();
        }
    }
    
}
