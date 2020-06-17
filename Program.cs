using System;
using Implementation_StackLIFO.Library;

namespace Implementation_StackLIFO
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack1 = new StackLIFO<int>();
            stack1.Push(1);
            stack1.Push(2);
            stack1.Push(3);

            Console.WriteLine(stack1.Peek().ToString());

            var stack2 = new StackLIFO<string>();
            stack2.Push("Hola");
            stack2.Push("Mundo");
            stack2.Push("Tres");

            Console.WriteLine(stack2.Peek());

            Console.WriteLine("Hello World!");
        }
    }
}
