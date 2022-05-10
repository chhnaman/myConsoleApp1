using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            a = 9;
            b = 15;
            c = a & b;
            Console.WriteLine("c=" + c);
            

            c = a|b;
            Console.WriteLine("c=" + c);
     

            c = a^b;
            Console.WriteLine("c=" + c);
         
            
            c = a<<1;
            Console.WriteLine("c=" + c);
          

            c = a>>1
                ;
            Console.WriteLine("c=" + c);

            int x = 100;
            x+=10;
            Console.WriteLine("x=" +x);


            int y = 24;
            y-= 10;
            Console.WriteLine("y="+y);

            int d= 25;
            d= 24*d;
            Console.WriteLine("d="+d);

            int v = 100;
            Console.WriteLine("v="+(++v));
            v = v / 2;
            Console.WriteLine("v=" + v);

            int




            Console.Read();



        }

      





    }
}
