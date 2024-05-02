using System;
namespace LOperator
{
    class LogicalOp
    {
        static void Main(string[]args)
        {
            int x = 3;
            int y = 4;
            Console.WriteLine((x>y)&&(x<y));
            Console.WriteLine((x>y)||(x<y));
            Console.WriteLine(!((x>y)&&(x<y)));

        }
    }
}
