using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string dogGenre = "Németjuhász";
            var dog = new Dog();
            dog.Name = "Test Dog";
            dog.Genre = dogGenre;
            Console.WriteLine("Hello {0}",dog.Name);
            dog.Vau();
        }
    }
}
