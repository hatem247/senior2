using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using Senior2;
using Senior2.Dto;
using Senior2.Models;
using Senior2.Repo;

namespace Senior2.Repo
{
    
    public class UserRepo : IUserRepo
    {
        private readonly ApplicationDbContext _context;
        public UserRepo(ApplicationDbContext context)
        {
            _context = context;
        }
        public void AddUser(UserDto user)
        {
            var u = new User
            {
                Name = user.Name,
                Email = user.Email,

            };  
            _context.Users.Add(u);
            _context.SaveChanges();
        }

        public void DeleteUser(int id)
        {
            var user=GetUserByID(id);
            _context.Users.Remove(user);
            _context.SaveChanges();
        }

        public User GetUserByID(int id)
        {
            var user = _context.Users.FirstOrDefault(x => x.Id == id);

            return user;



        }

        public void UpdateUser(UserDto user, int id)
        {
            var u = GetUserByID(id);
            u.Name = user.Name;
            u.Email = user.Email;
            _context.Users.Update(u);
            _context.SaveChanges();
















        }
    }

}















