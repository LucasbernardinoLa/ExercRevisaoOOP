using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc1
{
    internal class Piramide
    {
        public int N { get; set; }

        public Piramide(int n)
        {
            if (n <= 0)
            {
                throw new SystemException();
            }
            else
            {
                N = n;
            }
            
                     
        }

        public void desenha(int n)
        {
            N = n;

            for (int i = 1; i <= n; i++)
            { 

                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                for (int j = 1; j <= i - 1; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();                      
                                             
            }

        }

    }
}


