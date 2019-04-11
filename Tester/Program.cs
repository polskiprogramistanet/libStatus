using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using libStatus;

namespace Tester
{
    class Program
    {
        static void Main(string[] args)
        {

            Status state = new Status();


            Console.WriteLine(state.GetStatus(30, 31));


            Console.ReadKey();
        }
    }
}
