using System;

namespace helloapp;

class Helloapp 
{
    public static void Main() {
        PrintHello();
        GreetWhite();

    }

    public static void PrintHello() {
        Console.WriteLine("hello everyone");
    }

    public static void GreetWhite() {
        Console.WriteLine("hello white");
    }

    public static void GreetBlack() {
        Console.WriteLine("hello black");
    }
}