using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        GreetUser("User");
        ShowInfo();
        ShowDate();
        ShowMessage();
    }

    static void GreetUser(string name)
    {
        Console.WriteLine($"Hello, {name}!");
    }

    static void ShowInfo()
    {
        Console.WriteLine("Welcome to my .NET Core project!");
        Console.WriteLine("This program was created using C#.");
    }

    static void ShowDate()
    {
        Console.WriteLine($"Today is: {DateTime.Now:dd.MM.yyyy}");
    }
    static void ShowMessage()
    {
        Console.WriteLine("Have a great day!");
    }
}