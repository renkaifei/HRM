using HRM.Repository;
using System.Threading.Tasks;

namespace HRM.Repository.Factory
{
    public interface ICreateRepository 
    {
        Task CreateAsync();
    }

    public class CreateRepoFactory
    {
        private static CreateRepoFactory instance;
        private static object obj = new object();
        private CreateRepoFactory()
        {
            
        }

        public static CreateRepoFactory GetInstance()
        {
            if(instance == null)
            {
                lock(obj)
                {
                    if(instance == null)
                    {
                        instance = new CreateRepoFactory();
                    }
                }
            }
            return instance;
        }

        public ICreateRepository BuildDatabaseCreateRepository()
        {
            ICreateRepository repo = new DatabaseCreateRepository();
            return repo;
        }
    }
}