using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter your Channel name : ");
        string name = Console.ReadLine();
        Console.Write("Enter your Subscriber Count : ");
        int count = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("<----- Channel Details ----->");
        Console.WriteLine("Name : "+ name);
        Console.WriteLine("Subscriber Count : "+ count);
        
    }
}