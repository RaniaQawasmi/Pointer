using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_9
{
   public class point
    {
        private int x;
        private int y;
        public point() { 
            
            x = 0; y = 0; }
        public point(int xvalue, int yvalue)
        {
            x = xvalue;
            y = yvalue;
        }

        public int X
        {
            set { x = value; }
            get { return x; }
        }
        public int Y
        {
            set { y = value; }
            get { return y; }
        }
        public override string ToString()
        {
            return "(" + x + "," + y + ")";
        }

    }





}
