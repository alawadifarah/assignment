using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentPart1
{
     class Program
    {
        static async Task Main(string[] args)
        {
            string userName = "Guest";

            Console.WriteLine("Welcome to Command Center!");
            bool running = true;
            while (running)
            {
                Console.WriteLine("Enter command or type 'help' for options. ");
                string command = Console.ReadLine().ToLower();

                switch (command)
                {
                    case "help":
                        Console.WriteLine("Available Commands:");
                        Console.WriteLine("help - Show available commands");
                        Console.WriteLine("status - Check the current status");
                        Console.WriteLine("set_name - Change your name");
                        Console.WriteLine("exit - Close the program");
                        break;

                    case "status":
                        Console.WriteLine("Command Center is Operational.");
                        Console.WriteLine("Current user:" + userName);
                        break;

                    case "set_name":
                        Console.WriteLine("Enter new name: ");
                        userName = Console.ReadLine();
                        Console.WriteLine("Name updated! Hello " + userName + ".");
                        break;

                    case "exit":
                        Console.WriteLine("Goodbye!" + userName + ".");
                        running = false;
                        break;

                    default:
                        Console.WriteLine("invalid command. Type 'help' for options.");
                        break;


                }

            center.Run();

            }
        }
    }
}
