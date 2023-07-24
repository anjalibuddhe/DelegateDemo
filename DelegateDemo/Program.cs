using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculation c=new Calculation();
            //c.Add
            MyDelegate myDelegate = new MyDelegate(c.Add);
            //Console.WriteLine(myDelegate.Invoke(20,30));

            myDelegate += new MyDelegate(c.Sub);

            //myDelegate -= new MyDelegate(c.Sub);

            Delegate[] list = myDelegate.GetInvocationList();

            foreach(Delegate item in list)
            {
                Console.WriteLine(item.Method);
                Console.WriteLine(item.DynamicInvoke(20,10));
            }

            ////Test t1=new Test();
            ////Delegate1 d1 = new Delegate1(t1.AcceptDetails);
            ////d1.Invoke(1, "sara", 25000);
        }
    }
}
