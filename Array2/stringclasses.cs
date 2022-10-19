using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array2
{
    internal class stringclasses
    {
        static void Main(string[]args)
        {
            string str1 = "Hellow";
            string str2 = "sample text";

            // count the character + space= print total 
            Console.WriteLine(str1.Length);
            Console.WriteLine(str2.Length);

            // All Words in one line

            string str3 = string.Concat(str1, " ", str2);
            // OR
            //string str3 = string.Concat(str1 + "" + str2);
            Console.WriteLine(str3);

            //all character in capital letter or small letter written
            Console.WriteLine(str3.ToUpper());
            Console.WriteLine(str3.ToLower());


            //eka row la ekach character lihnyasathi
            char[] ch = str3.ToCharArray();
            foreach (var item in ch)
            {
                Console.WriteLine(item);
            }

            //chect the position(if position is wright print true otherwise false)
            bool res = str3.StartsWith("Hello");
            bool res1 = str3.EndsWith("text");

            Console.WriteLine(res);
            Console.WriteLine(res1);
            

            
        }
    }
}
