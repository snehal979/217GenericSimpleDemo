using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass
{
    public class Generic
    {
        public void ToprintArray<T>(T[] intArray)
        {
            foreach(var data in intArray)
            {
                Console.WriteLine(data);
            }
        }
        //public void ToprintArray(double[] doubleArray)
        //{
        //    foreach (var data in doubleArray)
        //    {
        //        Console.WriteLine(data);
        //    }
        //}
        //public void ToprintArray(char[] charArray)
        //{
        //    foreach (var data in charArray)
        //    {
        //        Console.WriteLine(data);
        //    }
        //}
    }
}
