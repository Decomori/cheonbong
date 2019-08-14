using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program

    {
        static void main(string[] args)
        {
            for (int y = 0; y <= 3; y++)
            {
                Console.Write(y);
                switch (y)

                {
                    case 1 :
                        Console.Write("은 하나입니다.\n");
                        break;
                    case 2:
                        Console.Write("은 둘입니다.\n");
                        break;
                    case 3:
                        Console.Write("은 셋입니다.\n");
                        break;
                    default:
                        Console.Write("아무것도 아니네요!\n");
                        break;
                }
            }
        }
    }
}