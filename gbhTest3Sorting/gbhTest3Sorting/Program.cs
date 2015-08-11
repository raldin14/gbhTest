using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace gbhTest3Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            ///////////////////////////////////////////Part 3/////////////////////////////
             StreamReader sre = new StreamReader("​IntegerArray.txt");
             string linea = sre.ReadLine();
             string[] vals = linea.Split(',');
             int[] sort = Array.ConvertAll(vals, s => int.Parse(s));
             //int[] sort = {5,7,2,4,1,3};
             int sortLH;

             for (int i = sort.Length - 1; i > 0; i--)
             {
                // sortLH[i] = sort[i];
                 for (int j = 0; j <= i - 1; j++ )
                 {
                     if (sort[j] > sort[j + 1])
                     {
                         sortLH = sort[j];
                         sort[j] = sort[j + 1];
                         sort[j + 1] = sortLH;
                     }
                                        
                 }
                
             }

             foreach (int v in sort)
             {
                 Console.WriteLine(v);
             }
             Console.ReadLine();
        }
    }
}
