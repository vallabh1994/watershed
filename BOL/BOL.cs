using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL
{
   public static class BOL
    {
        public static String RandomNum()
        {
            Random r = new Random();
            String rInt = r.Next(0, 100).ToString(); //for ints
            return rInt;
        }
    }
}
