using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using HRM.Application.Services;
using HRM.Domain;


namespace HRM.WebUI.Controllers
{
    public class UserController:Controller
    {
        private UserService userService;

        public UserController()
        {
            userService = new UserService();
        }

        [HttpPost]
        public async Task<string> GetOneByNameWithPwd(string loginName,string pwd)
        {
            UserDomain user = new UserDomain(){ LoginName = loginName,Pwd = pwd };
            await userService.GetOneByNameWithPwdAsync(user);
            return user.Serialize();
        }


    }
}