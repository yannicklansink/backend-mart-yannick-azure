using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [ApiController]
    [Route("api/v1/users")]
    public class UserController : Controller
    {
        public UserController() { }

        [HttpPost]
        public IActionResult Post([FromBody] UserFormModel userForm)
        {
            Console.WriteLine($"First Name: {userForm.FirstName}");
            Console.WriteLine($"Last Name: {userForm.LastName}");
            Console.WriteLine($"License Plate: {userForm.LicensePlate}");
            //Console.WriteLine($"Picture Length: {userForm.Picture.Length}");

            return Ok(new { message = "Data received" });
        }

        public class UserFormModel
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string LicensePlate { get; set; }
            public string? Picture { get; set; } 
        }


    }
}
