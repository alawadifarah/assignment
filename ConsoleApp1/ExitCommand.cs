using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ExitCommand : ICommand
    {
        public string Name => "exit";
        public Task ExecuteAsync(CommandCenter center)
        {
            center.Exit();
            return Task.CompletedTask;
        }
    }
    
    
}
