using SistemasTarefas.Models;

namespace TasksSystem.Repository.Interfaces
{
    public interface IUserRepository
    {
        Task<List<UserModel>> FindAllUsers();
        Task<UserModel> FindForId (int id);
        Task<UserModel> Add (UserModel user);
        Task<UserModel> Update (UserModel user, int Id);
        Task<bool> Delete (int id);
    }
}