using System;
using HRM.Domain;
using HRM.Application.Commands;
using HRM.Application.Interfaces;
using System.Threading.Tasks;

namespace HRM.Application.Services
{
    public class UserService
    {
        public async Task GetOneByNameWithPwdAsync(UserDomain user)
        {
            ICommand command1 = new UserGetOneByNameWithPwdCommand(user);
            await command1.ExecuteAsync();
        }
    }
}
