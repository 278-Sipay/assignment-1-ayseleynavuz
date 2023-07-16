using FluentValidation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sipay.Bootcamp.AleynaYavuz.Models;

namespace Sipay.Bootcamp.AleynaYavuz.Controllers
{
    [ApiController]
    [Route("sipy/api/[controller]")]
    public class PersonController : ControllerBase
    {
        private readonly IValidator<Person> _validator;
        public PersonController(IValidator<Person> validator)
        {
            _validator = validator;
        }

        [HttpPost]
        public IActionResult Post([FromBody] Person person)
        {
            var result = _validator.Validate(person);
            if (!result.IsValid)
            {
                return BadRequest(result.Errors);
            }

            return Ok(person);

        }
    }
}
