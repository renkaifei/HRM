using Microsoft.VisualStudio.TestTools.UnitTesting;
using HRM.Repository.Factory;
using HRM.Repository.Interface;
using System.Threading.Tasks;
using HRM.Domain;

namespace HRM.UnitTest
{
    [TestClass]
    public class UnitTestUserGetOneByNameWithPwd
    {
        [TestMethod]
        public async Task GetOne()
        {
            UserDomain user = new UserDomain();
            user.LoginName = "renkf01";
            user.Pwd = "123456";
            IGetDataRepository getData = GetDataRepoFactory.GetInstance().BuildUserGetOneByNameWithPwdRepository(user);
            await getData.GetData();
            Assert.IsTrue(user.UserID != 0,"没有获取到用户信息");
        }
    }
}