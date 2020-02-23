using System;
using System.Linq;

namespace Get_the_Middle_Character
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetMiddle("atta"));
            Console.WriteLine(GetMiddle("atkta"));
        }

        public static string GetMiddle(string s)
        {
            if (s.Length <= 1) return s;
            if (s.Length % 2 == 0) return new string(s.Skip(s.Length / 2 - 1).Take(2).ToArray());
            else if (s.Length % 2 != 0) return s[s.Length / 2].ToString();
            return ""; //
        }
    }
}
