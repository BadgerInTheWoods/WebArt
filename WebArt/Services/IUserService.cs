using WebArt.Model.Entities;

namespace WebArt.Api.Services
{
    public interface IUserService
    {
        IEnumerable<User> GetUsers();
        void AddUser(User user);
        void UpdateUser(User user);
        void DeleteUser(int id);
    }
}
