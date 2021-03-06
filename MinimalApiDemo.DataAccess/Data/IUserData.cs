using MinimalApiDemo.DataAccess.Models;

namespace MinimalApiDemo.DataAccess.Data
{
    public interface IUserData
    {
        Task DeleteUser(int id);
        Task<UserModel?> GetUser(int id);
        Task<IEnumerable<UserModel>> GetUsers();
        Task InsertUser(UserModel model);
        Task UpdateUser(UserModel model);
    }
}