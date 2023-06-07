using HomeworkThirty.ConsoleUILibrary.Extensions;
using HomeworkThirty.Library.Models;
using System;

namespace HomeworkThirty.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonModel person = new PersonModel();

            person.Name = "What is your name: ".RequestString();
            person.Age = "What is your age: ".RequestInt(1, 200);
            person.FavoriteNumber = "What is your favorite number: ".RequestInt();

            Console.WriteLine();
            Console.WriteLine($"{person.Name} ({person.Age}) : {person.FavoriteNumber}");

            Console.ReadLine();
        }
    }
}
