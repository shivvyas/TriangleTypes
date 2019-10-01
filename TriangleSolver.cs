using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methodologies_Assign2
{
    public static class TriangleSolver
    {
        public static  int v1 = 0;
        public static  int v2 = 0;
        public static  int v3 = 0;

        public static string Analyze(int v1,int v2, int v3)
        {
            string str = " ";
            if ((v1 + v2 <= v3) || (v1 + v3 <= v2) || (v2 + v3 <= v1))
            {
                str = "It is not a valid triangle!!";
                Console.WriteLine("{0}", str);
            }
            else
            {
                Console.WriteLine("It is a valid Triangle!");
                if (v1 == v2 && v2 == v3)
                {
                    str = "It is an equilateral triangle!!";
                    Console.WriteLine("{0}", str);

                }
                else if (v1 == v2 || v1 == v3 || v2 == v3)
                {
                    str = "It is an isosceles triangle!!";
                    Console.WriteLine("{0}", str);
                }
                else
                {
                    str = "It is an scalene triangle!!";
                    Console.WriteLine("{0}", str);
                }
            }

                
            return str;
        }
    }

}
