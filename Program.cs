using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var dog = new Dog();
            dog.Name = "Test Dog";
            Console.WriteLine("Hello {0}",dog.Name);
        }
    }
}
