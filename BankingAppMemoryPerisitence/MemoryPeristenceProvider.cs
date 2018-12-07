using BankingApp.Interfaces;
using BankingApp.Persistence;
using BankingAppMemoryPersistence.Repositories;

namespace BankingAppMemoryPerisitence
{
    public class MemoryPeristenceProvider : IPersistenceProvider
    {
        public IRepository<IClient> GetClientRepository() => new ClientRepository();

        public IRepository<IAccount> GetAccountRepository() => new AccountRepository();

        public IRepository<IPerson> GetPersonRepository() => PersonRepository.Repository;
    }
}
