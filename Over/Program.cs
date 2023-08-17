using Static;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Over
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle(5, 8);
            r.CalculateArea();
            Console.WriteLine(r.ToString());

        }
    }
}
