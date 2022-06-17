using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_9
{
    internal class Program
    {
        static void Main(string[] args)
        {

            point p1 = new point(); //(0,0)
        
            point p2 = new point(72,115); // (72,115)
            Console.WriteLine(p1.ToString());
            Console.WriteLine(p2);
        }
    }
}
