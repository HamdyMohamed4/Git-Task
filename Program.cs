using System;

// Entry point of the application
class Program
{
    static void Main()
    {
Console.WriteLine("Starting ITI Git Lab...");
        // Create instances of the classes
        HelloSwift hw = new HelloSwift();
        HelloITI hi = new HelloITI();

        // Call the methods
        hw.PrintHelloWorld();
        hi.PrintHelloITI();
        hi.PrintHelloGit();
    }
}