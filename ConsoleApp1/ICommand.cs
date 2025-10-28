using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ConsoleApp1
{
    public interface ICommand

    {
        string Name { get; }
        Task ExecuteAsync(CommandCenter center);
    }
}
