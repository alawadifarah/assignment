using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class CommandCenter
    {
        public string UserName { get; private set; } = "Guest";
        public bool IsOperational { get; private set; } = true;
        public int CommandProcessed { get; private set; } = 0;

        private readonly Dictionary<string, ICommand> _commands;
        private readonly List<string> _commandHistory = new List<string>();


        public CommandCenter()
        {
            _commands = new Dictionary<string, ICommand>(StringComparer.OrdinalIgnoreCase)
            {
                ["help"] = new HelpCommand(),
                ["status"] = new StatusCommand(),
                ["set_name"] = new SetNameCommand(),
                ["exit"] = new ExitCommand(),
                ["history"] = new HistoryCommand(),
                ["search"] = new SearchCommand(),
                ["diagnose"] = new DiagnosticsCommand()


            };

        }

        public void ShowHelp()
        {
            Console.WriteLine("Available Commands:");
            Console.WriteLine("help - Show available commands");
            Console.WriteLine("status - Check the current status");
            Console.WriteLine("set_name - Change your name");
            Console.WriteLine("exit - Close the program");
            Console.WriteLine("history - List entered commands");
            Console.WriteLine("search - Find commands by keywords");
            Console.WriteLine("diagnose - Run system diagnostics (5s)");
        }
        public void ShowStatus()
        {
            Console.WriteLine("Command Center is Operational.");
            Console.WriteLine("Current user: " + UserName);
            Console.WriteLine("Commands processed: " + CommandProcessed);
        }
        public void SetUserName()
        {
            Console.WriteLine("Enter new name: ");
            var newName = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(newName))
            {
                UserName = newName.Trim();
                Console.WriteLine("Name updated! Hello " + UserName + ".");
            }

        }
        public void Exit()
        {
            Console.WriteLine("Goodbye! " + UserName + ".");
            IsOperational = false;
        }
        public async Task RunAsync()
        {
            while (IsOperational)
            {
                Console.WriteLine("Enter command or type 'help' for options. ");
                var input = Console.ReadLine() ?? string.Empty;
                if (_commands.TryGetValue(input, out var cmd))
                {
                    CommandProcessed++;
                    _commandHistory.Add(input);
                    await cmd.ExecuteAsync(this);
                }
                else
                {
                    Console.WriteLine("Invalid command. Type 'help' for options.");
                }

            }



        }
        public List<string> GetHistory()
        {
            return _commandHistory;
        }
    }
}

    


