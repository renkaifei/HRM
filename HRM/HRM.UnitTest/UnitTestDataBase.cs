using Microsoft.VisualStudio.TestTools.UnitTesting;
using HRM.Repository.Factory;
using System.Threading.Tasks;

namespace HRM.UnitTest
{
    [TestClass]
    public class UnitTestDataBase
    {
        [TestMethod]
        public async Task DbInit()
        {
            ICreateRepository repo = CreateRepoFactory.GetInstance().BuildDatabaseCreateRepository();
            await repo.CreateAsync();
        }
    }
}
