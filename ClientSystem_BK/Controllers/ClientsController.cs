using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Clients_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetClients()
        {
            var clients = new List<Client>
            {
                new Client { Name = "Alice Johnson", Nationality = "American", Occupation = "Engineer", Email="alice@example.com" },
                new Client { Name = "Carlos García", Nationality = "Mexican", Occupation = "Teacher", Email = "carlos@example.com" },
                new Client { Name = "Marie Dubois", Nationality = "French", Occupation = "Artist", Email = "marie@example.com" },
                new Client { Name = "John Smith", Nationality = "British", Occupation = "Designer", Email = "john.smith@example.com" },
                new Client { Name = "Sophia Lee", Nationality = "Canadian", Occupation = "Doctor", Email = "sophia.lee@example.com" },
                new Client { Name = "David Kim", Nationality = "Korean", Occupation = "Chef", Email = "david.kim@example.com" },
                new Client { Name = "Emily Zhang", Nationality = "Chinese", Occupation = "Lawyer", Email = "emily.zhang@example.com" },
                new Client { Name = "Liam O'Conner", Nationality = "Irish", Occupation = "Pilot", Email = "liam.oconnor@example.com" },
                new Client { Name = "Olivia Brown", Nationality = "Australian", Occupation = "Architect", Email = "olivia.brown@example.com" },
                new Client { Name = "Lucas Martinez", Nationality = "Spanish", Occupation = "Photographer", Email = "lucas.martinez@example.com" },
                new Client { Name = "Mia Taylor", Nationality = "American", Occupation = "Scientist", Email = "mia.taylor@example.com" },
                new Client { Name = "Amir Hassan", Nationality = "Egyptian", Occupation = "Engineer", Email = "amir.hassan@example.com" },
                new Client { Name = "Natalie Petrova", Nationality = "Russian", Occupation = "Musician", Email = "natalie.petrova@example.com" },
            };

            return Ok(clients);
        }

        public class Client
        {
            public string Name { get; set; }
            public string Nationality { get; set; }
            public string Occupation { get; set; }
            public string Email { get; set; }
        }
    }
}
