using NoSqlWrapper.Repositories;

namespace NoSqlWrapper
{

    public interface IStore : INoSqlRepository
    {
        void SaveChanges();
    }

}
