using Microsoft.EntityFrameworkCore;
using Nest;
using SistemasTarefas.Models;
using TasksSystem.Date;
using TasksSystem.Repository.Interfaces;

namespace TasksSystem.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly TasksSystemDBContext _dbContext;

        public UserRepository(TasksSystemDBContext tasksSystemDBContext) 
        {
            _dbContext = tasksSystemDBContext;
        }

        public async Task<UserModel> Add(UserModel user)
        {
            await _dbContext.Users.AddAsync(user);
            await _dbContext.SaveChangesAsync();

            return user;
        }

        public async Task<bool> Delete(int id)
        {
            UserModel userForId = await FindForId(id);

            if (userForId == null)
            {
                throw new Exception($"o Usuario para o ID: {id} não foi encontrado!");
            }

            _dbContext.Users.Remove(userForId);
            await _dbContext.SaveChangesAsync();

            return true;
        }

        public async Task<List<UserModel>> FindAllUsers()
        {
            return await _dbContext.Users.ToListAsync();
        }

        public async Task<UserModel> FindForId(int id)
        {
            return await _dbContext.Users.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<UserModel> Update(UserModel user, int id)
        {
            UserModel userForId = await FindForId(id);

            if (userForId == null)
            {
                throw new Exception($"o Usuario para o ID: {id} não foi encontrado!");
            }

            userForId.Name = user.Name;
            userForId.Email = user.Email;

            _dbContext.Users.Update(userForId);
            await _dbContext.SaveChangesAsync();

            return userForId;
        }
    }
}
