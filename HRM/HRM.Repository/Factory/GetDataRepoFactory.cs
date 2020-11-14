using System;
using HRM.Domain;
using HRM.Repository.Interfaces;

namespace HRM.Repository.Factory
{
    public class GetDataRepoFactory
    {
        private static GetDataRepoFactory instance;
        private static object obj = new object();
        
        private GetDataRepoFactory()
        {

        }

        public static GetDataRepoFactory GetInstance()
        {
            if(instance == null)
            {
                lock(obj)
                {
                    if(instance == null)
                    {
                        instance = new GetDataRepoFactory();
                    }
                }
            }
            return instance;
        }

        public IGetDataRepository BuildUserGetOneByNameWithPwdRepository(UserDomain user)
        {
            IGetDataRepository getData = new UserGetOneByNameWithPwdRepository(user);
            return getData;
        }
    }
}