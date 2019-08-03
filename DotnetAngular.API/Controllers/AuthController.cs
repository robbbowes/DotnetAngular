using Microsoft.AspNetCore.Mvc;
using DotnetAngular.API.Data;
using System.Threading.Tasks;
using DotnetAngular.API.Models;
using DotnetAngular.API.Dtos;

namespace DotnetAngular.API.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class AuthController : ControllerBase
  {
    private readonly IAuthRepository _repo;
    public AuthController(IAuthRepository repo)
    {
      _repo = repo;

    }

    [HttpPost("register")]
    public async Task<IActionResult> Register(UserForRegisterDto userForRegisterDto)
    {
        // validate request placeholder

        userForRegisterDto.Username = userForRegisterDto.Username.ToLower();

        if (await _repo.UserExists(userForRegisterDto.Username)) return BadRequest("Username already exists");

        var userToCreate = new User
        {
            Username = userForRegisterDto.Username
        };

        var createdUser = await _repo.Register(userToCreate, userForRegisterDto.Password);

        return StatusCode(201); //fix this later
    }
  }
}