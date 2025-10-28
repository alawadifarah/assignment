using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class SetNameCommand : ICommand
    {
        public string Name => "set_name";
        public Task ExecuteAsync(CommandCenter center)
        {
            center.SetUserName();
            return Task.CompletedTask;
        }
    }
    
    
}
