using Microsoft.AspNetCore.Mvc;
using UserManagementApi.Models;

namespace UserManagementApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetUsers()
        {
            return Ok(UserStore.Users);
        }

        [HttpGet("{id}")]
        public IActionResult GetUser(int id)
        {
            var user = UserStore.Users.FirstOrDefault(u => u.Id == id);

            if (user == null)
                return NotFound();

            return Ok(user);
        }

        [HttpPost]
        public IActionResult CreateUser([FromBody] User user)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            int newId = UserStore.Users.Any() ? UserStore.Users.Max(u => u.Id) + 1 : 1;
            user.Id = newId;

            UserStore.Users.Add(user);

            return CreatedAtAction(nameof(GetUser), new { id = user.Id }, user);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateUser(int id, [FromBody] User updatedUser)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var existingUser = UserStore.Users.FirstOrDefault(u => u.Id == id);

            if (existingUser == null)
                return NotFound();

            existingUser.Name = updatedUser.Name;
            existingUser.Email = updatedUser.Email;
            existingUser.Age = updatedUser.Age;

            return Ok(existingUser);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteUser(int id)
        {
            var user = UserStore.Users.FirstOrDefault(u => u.Id == id);

            if (user == null)
                return NotFound();

            UserStore.Users.Remove(user);

            return NoContent();
        }
    }
}