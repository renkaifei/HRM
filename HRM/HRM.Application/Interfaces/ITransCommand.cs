using System.Threading.Tasks;

namespace HRM.Application.Interfaces
{
    internal interface ITransCommand:ICommand
    {
        Task JoinTrans();
    }
}
