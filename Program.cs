using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

            string quantity = "";
            string output = "";
            /*
             * Quantity: 5000
             * Output: <h2>Widgets &reg;</h2><span>5000</span>
             */

            // Your work here
            int openingPosition = input.IndexOf("<span>");
            int closingPosition = input.IndexOf("</span>");
            openingPosition += 6;
            quantity = input.Substring(openingPosition,closingPosition-openingPosition);
            Console.WriteLine(quantity);

            output = input.Replace("trade", "reg");
            output = output.Remove(0, 5);
            output = output.Remove(39);
            Console.WriteLine(output);

            Console.ReadLine();
        }
    }
}
