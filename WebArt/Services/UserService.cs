

using Microsoft.EntityFrameworkCore;
using WebArt.Data;
using WebArt.Model.Entities;

namespace WebArt.Api.Services
{
    public class UserService : IUserService
    {
        private readonly WebArtDbContext _context;
        public UserService(WebArtDbContext context)
        {
            _context = context;
        }
        public void AddUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public void DeleteUser(int id)
        {
            var user = _context.Users.Find(id);
            if (user != null)
            {
                _context.Users.Remove(user);
                _context.SaveChanges();
            }
        }

        public IEnumerable<User> GetUsers()
        {
            return _context.Users.ToList();
        }

        public void UpdateUser(User user)
        {
            _context.Entry(user).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
