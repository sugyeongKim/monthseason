using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monthseason
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("월을 입력>> ");
            var input = Console.ReadLine();

            if (input.Contains("월"))
            {
                input = input.Substring(0,1);
            }

            switch (int.Parse(input))
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("겨울 입니당~");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("봄 입니당~");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("여름 입니당~");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("가을 입니당~");
                    break;
                default:
                    Console.WriteLine("잘못입력하셨습니당~");
                    break;
                
            }

        }
    }
}
