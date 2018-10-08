using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new[] { 6, 5, 4, 3, 2, 1 };

            Console.WriteLine("length: " + numbers.Length);

            Console.WriteLine("All numbers: ");
            foreach (var n in numbers)
                Console.WriteLine(n);

            var index = Array.IndexOf(numbers, 9);
            Console.WriteLine("index of 9: " + index);

            Console.WriteLine("effect of clear: ");
            Array.Clear(numbers, 4, 2);
            foreach (var n in numbers)
                Console.WriteLine(n);

            var another = new int[3];
            Array.Copy(numbers, another, 3);

            Console.WriteLine("effect of copy:");
            foreach (var n in another)
                Console.WriteLine(n);

            Array.Sort(another);
            Console.WriteLine("effecet of sort: ");
            foreach (var n in another)
                Console.WriteLine(n);

            Array.Reverse(numbers);
            Console.WriteLine("effects of reverse: ");
            foreach (var n in numbers)
                Console.WriteLine(n);
        }
    }
}
