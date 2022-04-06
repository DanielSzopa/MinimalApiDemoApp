using MinimalApiDemo.DataAccess.Models;

namespace MinimalApiDemo
{
    public static class Api
    {
        public static void ConfigureApiEndpoints(this WebApplication app)
        {
            app.MapGet("/users", GetUsers);
            app.MapGet("/user/{id}", GetUser);
            app.MapPost("/user", InsertUser);
            app.MapPut("/user", UpdateUser);
            app.MapDelete("/user/{id}", DeleteUser);
        }

        private static async Task<IResult> GetUsers(IUserData data) =>
            Results.Ok(await data.GetUsers());


        private static async Task<IResult> GetUser(int id, IUserData data)
        {
            var result = await data.GetUser(id);
            if (result is null)
                return Results.NotFound();

            return Results.Ok(result);
        }

        private static async Task<IResult> InsertUser(UserModel model, IUserData data)
        {
            await data.InsertUser(model);
            return Results.Ok();
        }

        private static async Task<IResult> UpdateUser(UserModel model, IUserData data)
        {
            await data.UpdateUser(model);
            return Results.Ok();
        }

        private static async Task<IResult> DeleteUser(int id, IUserData data)
        {
            await data.DeleteUser(id);
            return Results.NoContent();
        }
    }
}
