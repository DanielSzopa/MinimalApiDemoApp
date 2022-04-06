using MinimalApiDemo.DataAccess.DbAccess;
using MinimalApiDemo.DataAccess.Models;

namespace MinimalApiDemo.DataAccess.Data
{
    public class UserData : IUserData
    {
        private readonly ISqlDataAccess _sqlDataAccess;

        public UserData(ISqlDataAccess sqlDataAccess)
        {
            _sqlDataAccess = sqlDataAccess;
        }

        public async Task<IEnumerable<UserModel>> GetUsers() =>
           await _sqlDataAccess.QueryData<UserModel, dynamic>("dbo.spUser_GetAll", new { });

        public async Task<UserModel?> GetUser(int id)
        {
            var results = await _sqlDataAccess.QueryData<UserModel, dynamic>
                ("dbo.spUser_Get", new { Id = id });

            var user = results.FirstOrDefault();
            return user;
        }

        public async Task InsertUser(UserModel model)
        {
            var parameters = new
            {
                FirstName = model.FirstName,
                LastName = model.LastName
            };

            await _sqlDataAccess.Execute("dbo.spUser_Insert", parameters);
        }

        public async Task UpdateUser(UserModel model) =>
            await _sqlDataAccess.Execute("dbo.spUser_Update", model);


        public async Task DeleteUser(int id) =>
            await _sqlDataAccess.Execute("dbo.spUser_Delete", new { Id = id });

    }
}
