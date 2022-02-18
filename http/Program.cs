using System;
using System.Net;
using System.Text;

namespace ListenerExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare the variables


            String S1;

            String S2 = "";
            int i;
            int c = 1;
            Console.WriteLine("Run Length Encoder");

            Console.WriteLine("Enter a String");

            S1 = Console.ReadLine();

            Console.WriteLine("You Entered : " + S1);
            S1 = S1 + " ";

            //Console.ReadLine();

            //Compress Using Run Length Encoding 

            for (i = 0; i < S1.Length - 1; i++)
            {
                if (S1[i] == S1[i + 1])
                {      //When same increment counter
                    c++;
                }
                else
                {

                    S2 += S1[i];
                    S2 += c;
                    c = 1;
                }

            }
            Console.WriteLine("Output" + "\n" + S2);

            Console.ReadLine();
        }
    }
}