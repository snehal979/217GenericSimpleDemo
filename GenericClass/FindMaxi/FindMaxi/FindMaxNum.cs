namespace FindMaxi
{
    public class FindMaxNum
    {
        public int FindMaxValue(int a, int b, int c)
        {
            if(a>b&& a>c)
            {
                return a;

            }else if (b>c && b>c)
            {
                return b;
            }
            else
            {
                return c;
            }

        }
        public float FindMaxFloatValue(float a, float b, float c)
        {
            if (a>b&& a>c)
            {
                return a;

            }
            else if (b>c && b>c)
            {
                return b;
            }
            else
            {
                return c;
            }

        }
        public string FindMaxStringValue(string a, string b, string c)
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