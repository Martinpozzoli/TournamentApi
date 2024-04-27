using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Model.Interface;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using TournamentApi.DTO;

namespace TournamentApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public IConfiguration _configuration;
        //private readonly IMapper _mapper;

        public LoginController(IUnitOfWork unitOfWork, IConfiguration configuration) // IMapper mapper,
        {
            _unitOfWork = unitOfWork;
            _configuration = configuration;
            //_mapper = mapper;
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<ActionResult<object>> Login(LoginDTO login)
        {
            var userEntity = await _unitOfWork.UserRepository.GetByNamePassword(login.UserName, login.Password);

            if (userEntity != null)
            {
                var claims = new[]
                {
                    new Claim(JwtRegisteredClaimNames.Sub,_configuration["Jwt:Subject"]),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                    new Claim(JwtRegisteredClaimNames.Iat, DateTime.UtcNow.ToString()),
                    new Claim("UserId", userEntity.Id.ToString()),
                    new Claim("DisplayName", userEntity.Name),
                    new Claim("UserName", userEntity.UserName),
                    new Claim("Email", userEntity.Email),
                };
                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
                var signIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
                var token = new JwtSecurityToken(
                    _configuration["Jwt:Issuer"],
                    _configuration["Jwt:Audience"],
                    claims,
                    expires: DateTime.UtcNow.AddMinutes(10),
                    signingCredentials: signIn);

                return Ok(new JwtSecurityTokenHandler().WriteToken(token));
            }
            else
            {
                return BadRequest("");
            }
        }
    }
}
