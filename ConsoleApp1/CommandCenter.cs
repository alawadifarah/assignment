using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class CommandCenter
    {
        public string UserName { get; private set; } = "Guest";
        public bool IsOperational { get; private set; } = true;
   
        public CommandCenter()
        {
            UserName = "Guest";
            IsOperational = true;
            
        }

        public void ShowHelp()
        {
            Console.WriteLine("Available Commands:");
            Console.WriteLine("help - Show available commands");
            Console.WriteLine("status - Check the current status");
            Console.WriteLine("set_name - Change your name");
            Console.WriteLine("exit - Close the program");
        }

        public void Run()
        {
            while (IsOperational)
            {
                Console.WriteLine("Enter command or type 'help' for options. ");
                string command = Console.ReadLine().ToLower();


                switch (command)
                {
                    case "help":
                        ShowHelp();
                        break;
                    case "status":
                        Console.WriteLine("Command Center is Operational.");
                        Console.WriteLine("Current user:" + UserName);
                        break;
                    case "set_name":
                        Console.WriteLine("Enter new name: ");
                        UserName = Console.ReadLine();
                        Console.WriteLine("Name updated! Hello " + UserName + ".");
                        break;
                    case "exit":
                        Console.WriteLine("Goodbye!" + UserName + ".");
                        IsOperational = false;
                        break;
                    default:
                        Console.WriteLine("invalid command. Type 'help' for options.");
                        break;
                }

            }
        }

    }
}

