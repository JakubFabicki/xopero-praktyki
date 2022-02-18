using System;

namespace BFRLE
{
    class Program
    {
        static void Main(string[] args)
        {
            
            String s1 = null;
            String s2 = null;
            int c = 1;

            s1 = "++++++++++[>+>+++>+++++++>++++++++++<<<<-]>>>++.>+.+++++++..+++.<<++.>+++++++++++++++.>.+++.------.--------.<<+.<. ";

            for (int i = 0; i < s1.Length - 1; i++)
            {
                if (s1[i] == s1[i + 1])
                    c++;
                else
                {
                    if(c>1)
                        s2 += c;
                    s2 += s1[i];
                    c = 1;
                }

            }
            Console.WriteLine(s2);

            Console.ReadLine();
        }
    }
}
