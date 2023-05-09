using Application.Common.Helpers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WebApi.Controllers
{
    public class MathController : ApiControllerBase
    {
        private readonly MathHelper _mathHelper;

        public MathController(MathHelper mathHelper)
        {
            _mathHelper = new MathHelper();
        }

        [HttpGet]
        public IActionResult IsEven(int number)
        {
            var result= _mathHelper.IsEven(number);

            if (result)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost]
        public IActionResult Sum(params int[] numbers)
        {
            var result = _mathHelper.Sum(numbers);

            return Ok(result);
        }
    }
}
