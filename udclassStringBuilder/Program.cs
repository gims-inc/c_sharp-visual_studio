using System;
using System.Text;

namespace udclassStringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {

            var sbulider = new StringBuilder();

            sbulider.Append('-', 9)
            //sbulider.AppendLine();
            .Append("header")
            // sbulider.AppendLine();
            .Append('-', 9)
            .AppendLine()
            .Replace('-', '.')
            .Remove(0, 10)

           .Insert(0, new string('-', 9));



            Console.WriteLine(sbulider + "\n First charracter: " + sbulider[0]);
        }
    }
}