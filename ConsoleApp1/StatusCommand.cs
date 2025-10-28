using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class StatusCommand : ICommand
    {
        public string Name => "status";
        public Task ExecuteAsync(CommandCenter center)
        {
            center.ShowStatus();
            return Task.CompletedTask;
        }
    }
    
    
}
