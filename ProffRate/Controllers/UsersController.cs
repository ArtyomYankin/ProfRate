using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using PR.Data;
using PR.Service;
using PR.Service.EmailSender;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace ProffRate.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IEmailService _emailService;
        public UserController(IUserService userService, IEmailService emailService)
        {
            _userService = userService;
            _emailService = emailService;
        }
        [HttpPost]
        [Route("Register")]
        public async Task<Object> PostApplicationUser(User user)
        {
            var applicationUser = new User()
            {
                Email = user.Email,
                RateTimesCount = 0,
            };


            try
            {
                var result =  _userService.AddUser(applicationUser);
                return Ok();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [HttpGet]
        public async Task<IActionResult> GetUser(User user)
        {
            var responseUser = new User();
            if (user.Email != null)
            {
                responseUser = _userService.AddUser(user);
            }
            
            return Ok(new { responseUser });
            
        }
        //public string ComputeHash(string input, HashAlgorithm algorithm)
        //{
        //    Byte[] inputBytes = Encoding.UTF8.GetBytes(input);

        //    Byte[] hashedBytes = algorithm.ComputeHash(inputBytes);

        //    return BitConverter.ToString(hashedBytes);
        //}
        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> Login(User model)
        {
            if (model.Email != null)
            {
                string code = _emailService.SendCodeToEmail(model.Email);
                _userService.AddUser(model);

                return Ok(new { code });
            }
            else
                return BadRequest(new { message = "Username or password is incorrect." });
        }
    }
}
