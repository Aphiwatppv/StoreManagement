
namespace DataAccess.SqlAccess
{
    public interface ISqlDataAccessInternal
    {
        Task<IEnumerable<T>> LoadDataAsync<T, U>(string storedProcedure, U parameters);
        Task SaveDataAsync<T>(string storedProcedure, T parameters);
    }
}