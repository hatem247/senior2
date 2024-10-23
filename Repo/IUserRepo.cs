using Senior2.Dto;
using Senior2.Models;

namespace Senior2.Repo
{
    public interface IUserRepo
    {
        User GetUserByID(int id);

        void AddUser(UserDto user);
        void UpdateUser(UserDto user,int id);
        void DeleteUser(int id);
        

    }
}
