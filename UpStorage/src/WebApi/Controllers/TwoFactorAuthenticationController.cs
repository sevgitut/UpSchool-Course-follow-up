using Application.Common.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    
    public class TwoFactorAuthenticationController : ControllerBase
    {
        private readonly ITwoFactorService _twoFactorService;

        [HttpPost("Generate")]
        public IActionResult Generate(string email)
        {
            var twoFactorDto = _twoFactorService.Generate(email);

            return File(twoFactorDto.OrCodeImage,"image/png");
        }

        [HttpPost("Validate")]
        public IActionResult Validate(string userCode)
        {
            var isValid = _twoFactorService.Validate(userCode);

            if (isValid) return Ok("You're authenticated!");

            return BadRequest("Your code is not valid.Please try again");
        }
    }
    
    
}
