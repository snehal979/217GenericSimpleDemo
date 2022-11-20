namespace GenericClass
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 1, 2, 3, 5, 4, 6, 7 };
            double[] doubleArray = { 1.1, 2.2, 2.4, 3.6, 3.5 };
            char[] charArray = { 'a', 'b', 'e', 'r' };

            Generic generic = new Generic();
            generic.ToprintArray<int>(intArray);
            generic.ToprintArray<double>(doubleArray);
            generic.ToprintArray<char>(charArray);
        }
    }
}
