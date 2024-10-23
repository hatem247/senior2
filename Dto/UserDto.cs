using System.ComponentModel.DataAnnotations;

namespace Senior2.Dto
{
    public class UserDto
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }


    }
}
