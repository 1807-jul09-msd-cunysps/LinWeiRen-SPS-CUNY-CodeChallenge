using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Palindromic;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            bool result = PalidromicClass.Check("343");
            if (result)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
