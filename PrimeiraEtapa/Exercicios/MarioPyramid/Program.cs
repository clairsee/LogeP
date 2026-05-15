using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarioPyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What will be the desired Height of the Pyramid: ");
            int height = int.Parse(Console.ReadLine());

            for (int i=0; i<height;i++)
            {
                pyramidBlank(height-i);
                pyramid(i);
                Console.Write("  ");
                pyramid(i);
                Console.Write("\n");
            }
            Console.ReadKey();
        }
        
        static void pyramid(int bricks)
        {
            for (int i=0;i<=bricks;i++)
            {
                Console.Write("*");
            }
        }

        static void pyramidBlank(int bricks)
        {
            for (int i = 1; i <= bricks; i++)
            {
                Console.Write(" ");
            }
        }
    }
}
