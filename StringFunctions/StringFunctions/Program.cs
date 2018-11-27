using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "Ron";
            //string quote = "The man said \"Hello\", Ron. \nHello on a new line. \n\t Hello on a tab";
            //string fileName = @"C:\User\Ron";

            //bool trueOrFalse = name.Contains("s");
            //trueOrFalse = name.EndsWith("s");

            //int l = name.Length;

            //name = name.ToUpper();
            //name = name.ToLower();

            StringBuilder sb = new StringBuilder();

            sb.Append("My name is Ron");

            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
