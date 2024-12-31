using Microsoft.AspNetCore.Mvc;


namespace Clients_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {


        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }


        // POST api/<ValuesController>
        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginRequest request)
        {
            if (request.Email == "test@test.com" && request.Password == "Password123")
            {
                return Ok(new { Message = "Login Successful" });
            }

            return Unauthorized(new { Message = "Invalid credentials" });
        }

        public class LoginRequest
        {
            public string Email { get; set; }
            public string Password { get; set; }

        }


    }


}