using System.Threading.Tasks;

namespace HRM.Application.Interfaces
{
    internal interface ICommand
    {
        Task ExecuteAsync();
    }
}
