
namespace MinimalApiDemo.DataAccess.DbAccess
{
    public interface ISqlDataAccess
    {
        Task<IEnumerable<T>> QueryData<T, U>(string storedProcedure, U parameters);
        Task Execute<T>(string storedProcedure, T parameters);
    }
}