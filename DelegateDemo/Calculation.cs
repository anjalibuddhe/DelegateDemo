using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{

    public delegate int MyDelegate(int x,int y);
    public class Calculation
    {
        public int Add(int x, int y)
        {
            return x + y;
        }
        public int  Sub(int x, int y)
        {
            return x - y;
        }
    }

    public delegate void Delegate1(int id, string name, double salary);

    public class Test
    {
        public void AcceptDetails(int id ,string name,double salary)
        {
            Console.WriteLine($"{id} {name} {salary}");
        }
    }
}
