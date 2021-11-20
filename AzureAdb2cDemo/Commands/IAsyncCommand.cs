using System.Threading.Tasks;
using System.Windows.Input;

namespace AzureAdb2cDemo.Commands
{
    public interface IAsyncCommand : ICommand
    {
        Task ExecuteAsync();
        bool CanExecute();
    }
}
