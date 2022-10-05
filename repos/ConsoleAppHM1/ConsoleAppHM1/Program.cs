// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

namespace HelloWorld
{
    using ClassLibrary;
    class Program
    {
        static void Main(string[] args)

        {
            AddTimeToUserName userNameTime = new AddTimeToUserName();
            
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            Console.WriteLine(userNameTime.AddTime(name) );

            Console.WriteLine($"{Environment.NewLine} Press any key to exit...");  
            Console.ReadKey(true);

            //Console.WriteLine($"{Environment.NewLine} Hello, {name} ");
        }
    }
}   
