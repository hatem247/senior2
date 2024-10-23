using Microsoft.EntityFrameworkCore;
using Senior2.Dto;
using Senior2.Models;

namespace Senior2
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<UserDto> UsersDto { get; set; }
    }
}
