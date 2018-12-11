using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "        Welcome   User  @  ";
            string pattern = @"(?<=^\s*)\s|\s(?=\s*$)";
            string replacement = "?";

            Regex rgx = new Regex(pattern);
            string result = rgx.Replace(input, replacement);

            Console.WriteLine("Original String: {0}", input);
            Console.WriteLine("Replacement String:{0}", result);
            


            string s = "   Hi this is empty string. This should be in new line.   ", t = "";
            int countSpaces = s.Count(Char.IsWhiteSpace);
            if (countSpaces > 3)
            {
                int count = 0;
                char n;
                foreach (char c in s)
                {
                    if (c == ' ') count++;
                    if (count == 1 || count == countSpaces)
                    {
                        n = '?';
                        count++;
                    }
                    else n = c;
                    t += n;
                }
            }
            else t = s;
            Console.WriteLine(t);


            string pp = "  5   ddfgdfg dfgfg dfdf dsdds  9    ";
            string startspace = pp.Substring(0, (pp.Length - pp.TrimStart(' ').Length));
            string Endspace = pp.Substring((pp.TrimEnd(' ').Length), (pp.Length - pp.TrimEnd(' ').Length));
            string oo = startspace.Replace(' ', '?').ToString() + pp.Trim() + Endspace.Replace(' ', '?').ToString();

            Console.WriteLine(oo);


            string k = "    5      Welcome   User  @     ";
            StringBuilder sb = new StringBuilder(k);
            int length = sb.Length;
            for (int postion = 0; (postion < length) && (sb[postion] == ' '); postion++)
                sb[postion] = '_';
            for (int postion = length - 1; (postion > 0) && (sb[postion] == ' '); postion--)
                sb[postion] = '_';
            k = sb.ToString();
            Console.WriteLine(k);



            String a = "   5  My name is xyz   @_  y";
            char[] chars = a.ToCharArray();
            var cy = a.ElementAt(0);
            String d = cy.ToString();
            if (d == " ")
            {
                chars[0] = '_';
            }
            int r = chars.Length - 1;
            var p = a.ElementAt(r);
            String q = p.ToString();
            if (q == " ")
            {
                chars[r] = '_';
            }
            string sv = new string(chars);
            Console.WriteLine(sv);

            Console.ReadKey();
        }
    }
}
