using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 10;
            double num2 = 2394.334;
            string str = "string";
            char sym = 'Y';
            Wqw w = new Wqw();
            w.TestGeneric(num);
            w.TestGeneric(num2);
            w.TestGeneric(str);
            w.TestGeneric(sym);
        }
    }
    public class Wqw
    {
        public void TestGeneric<T>(T things)
        {
            Console.WriteLine(things);
        }
    }
}
