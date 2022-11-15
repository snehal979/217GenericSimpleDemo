using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaxi
{
    public class FindMaxGeneric<T> where T : IComparable
    {
        public T FindMax(T a,T b,T c) 
        {
            if (a.CompareTo(b)>0 && a.CompareTo(c)>0)
            {
                return a;

            }
            else if (b.CompareTo(c)>0 && b.CompareTo(c)>0)
            {
                return b;
            }
            else
            {
                return c;
            }
        }
    }
    public class FindMaxGenericMethod
    {
        public T FindMax<T>(T a, T b, T c) where T : IComparable
        {
            if (a.CompareTo(b)>0 && a.CompareTo(c)>0)
            {
                return a;

            }
            else if (b.CompareTo(c)>0 && b.CompareTo(c)>0)
            {
                return b;
            }
            else
            {
                return c;
            }
        }
    }
}
