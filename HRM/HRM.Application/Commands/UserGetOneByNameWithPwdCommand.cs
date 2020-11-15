using HRM.Domain;
using HRM.Repository.Interfaces;
using HRM.Repository.Factory;
using HRM.Application.Interfaces;
using System.Threading.Tasks;

namespace HRM.Application.Commands
{
    public class UserGetOneByNameWithPwdCommand:ICommand
    {
        private IGetDataRepository getData;
        public UserGetOneByNameWithPwdCommand(UserDomain user)
        {
            getData = GetDataRepoFactory.GetInstance().BuildUserGetOneByNameWithPwdRepository(user);
        }

        public async Task ExecuteAsync()
        {
            await getData.GetDataAsync();
        }
    }
}