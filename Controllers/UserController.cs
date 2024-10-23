using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Senior2.Controllers;
using Senior2.Dto;
using Senior2.Models;
using Senior2.Repo;

namespace Senior2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepo _userRepo;
        public UserController(IUserRepo userRepo)
        {
            _userRepo = userRepo;
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var user = _userRepo.GetUserByID(id);
            if (user == null) {
                return NotFound();

            }
            return Ok(user);
           
        }
        [HttpPost]
        public IActionResult Add(UserDto dto) { 
            _userRepo.AddUser(dto);
            return Ok();

        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _userRepo.DeleteUser(id);
            return Ok();

        }
        [HttpPut("{id}")]
        public IActionResult Update(int id,UserDto dto)
        {
            _userRepo.UpdateUser(dto,id);
            return Ok();

        }
    }
}










//private readonly IUserRepo _userRepo;

//public UserController(IUserRepo userRepo)
//{
//    _userRepo = userRepo;

//}

//[HttpGet("{id}")]

//public IActionResult Get(int id)
//{

//    var user = _userRepo.GetUserById(id);
//    if (user == null)
//    {
//        return NotFound();
//    }
//    return Ok(user);
//}

//[HttpPost]
//public IActionResult post(UserDto dto)
//{
//    _userRepo.AddUser(dto);
//    return Ok();


//}
//[HttpPut("{id}")]
//public IActionResult put(int id, UserDto dto)
//{

//    _userRepo.UpdateUser(dto, id);
//    return Ok();

//}

//[HttpDelete("{id}")]

//public IActionResult delete(int id)
//{
//    var user = _userRepo.GetUserById(id);
//    if (user != null)
//    {
//        _userRepo.DeleteUser(id);
//        return Ok();
//    }
//    return NotFound();


//}








    






















