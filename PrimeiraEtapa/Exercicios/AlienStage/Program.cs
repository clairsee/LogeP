using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AlienStage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string phrase = "Geudaewa hamkkein na\r\nMeolli jihaui byeollo uri\r\nYeongwon eojjeomyeon geu neomeokkaji\r\nDangsingwa na, tto uri\r\n\r\nGeudaewa hamkkein na\r\nBiroso jihaui byeollo uri\r\nYeongwon eojjeomyeon geu neomeokkaji\r\nDangsingwa na, tto uri\r\n\r\nEoseureum naeryeowa uril gamssa aneumyeon\r\nDangsingwa nae simjang heudeureojige utji\r\nBarameul tagoseo yeongwonhi yeongwonhan goseuro\r\nGeudaewa hamkkeramyeon i sarang\r\n\r\nEoseureum naeryeowa uril gamssa aneumyeon\r\nDangsingwa nae simjang heudeureojige utji\r\nBarameul tagoseo yeongwonhi yeongwonhan goseuro\r\nGeudaewa hamkkeramyeon i sarang";
            foreach (char c in phrase)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(c);
                Thread.Sleep(25);
            }

            Console.ReadKey();
        }
    }
}
