using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace ЛАБА7
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                double s = 1;
                for (int a = 1; a <= 6; a++)
                {
                    double f = 1;
                    for (int b = 1; b <= 8; b++)
                    {
                        double k = 1;
                        for (int c = 1; c <= 10; c++)

                            k += Log(a) + Log(b) + Sqrt(c);
                        f += k;
                    }
                    s += f;
                }
                Console.WriteLine(s);
            }
        }

    }
}