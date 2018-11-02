using System;
using System.Text;

namespace ConsoleApp9
{
    class Program
    {
        static void Main()
        {
            // Concatenate three strings
            string str1 = "a";
            string str2 = "b";
            string str3 = "c";

            string strConcat = String.Concat(str1, str2, str3);
            Console.WriteLine(strConcat);

            // Convert a string to uppercase.
            string strLower = "the tech academy";
            string strUpper = strLower.ToUpper();

            Console.WriteLine(strUpper);

            // Create a Stringbuilder and build a paragraph of text, one sentence at a time.
            StringBuilder sb = new StringBuilder();
            sb.Append("We the People of the United States, ");
            sb.Append("in Order to form a more perfect Union, ");
            sb.Append("establish justice, ");
            sb.Append("insure domestic tranquility, ");
            sb.Append("provide for the common defense, ");
            sb.Append("promote the general welfare, ");
            sb.Append("and secure the blessings of liberty to ourselves and our posterity, ");
            sb.Append("do ordain and establish this Constitution for the United States of America.");

            Console.WriteLine(sb);

            Console.ReadLine();

        }
    }
}
