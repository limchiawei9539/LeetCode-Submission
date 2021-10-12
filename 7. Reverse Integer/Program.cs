using System;

namespace _7._Reverse_Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Reverse(-1534236469));
            Console.WriteLine(Reverse(1943));
        }

        public static int Reverse(int x)
        {
            var result = 0;
            //var arr = new char[x.ToString().Length];
            //arr = x.ToString().ToCharArray();
            var strx = x.ToString();
            var str = "";
            for (int i = (strx.Length - 1) ; i >= 0; i--)
            {
                if (strx[i] == '-')
                {
                    str = str.Insert(0, "-");
                }
                else
                {
                    str += strx[i];
                }
            }

            Int32.TryParse(str, out result);
            return result;
        }
    }
}
