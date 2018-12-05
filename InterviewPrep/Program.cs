using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "my.name.is.joe";
            StringReverse(s);
        }
        public static void StringReverse(string s)
        {
            int j = 0;
            int len = 0;
            Stack<string> stack = new Stack<string>();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != '.')
                {
                    len++;
                    if (i == s.Length - 1)
                    {
                        stack.Push(s.Substring(j, len));
                    }
                }
                
                else
                {
                    stack.Push(s.Substring(j, len));
                    if (i != s.Length - 1)
                    {
                        j = i + 1;
                    }

                    len = 0;
                }
            }
            foreach (var item in stack)
            {
                
                Console.Write(item + ".");
            }
        }
    }
}
