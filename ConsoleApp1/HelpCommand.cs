using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class HelpCommand : ICommand
    {
        public string Name => "help";
        public Task ExecuteAsync(CommandCenter center)
        {
            center.ShowHelp();
            return Task.CompletedTask;
        }
    }
    
    
}
