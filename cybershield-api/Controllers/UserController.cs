using cybershield_api.Data;
using cybershield_api.Models;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

namespace cybershield_api.Controllers
{
    [ApiController]
    [Route("Users")]
    public class UserController : Controller
    {
        private readonly IMongoCollection<Usuarios>? _users;
        public UserController(DBContext db)
        {
            _users = db.Database?.GetCollection<Usuarios>("Usuario");
        }
        [HttpGet]
        public async Task<IEnumerable<Usuarios>> getUsers()
        {   
            return await _users.Find(FilterDefinition<Usuarios>.Empty).ToListAsync();
        }

        [HttpGet("cad/user={username}&email={email}&password={password}")]
        public async Task<ActionResult> cadUser(string username, string email, string password)
        {
            var allUsers = await _users.Find(FilterDefinition<Usuarios>.Empty).ToListAsync();
            for(int i = 0; i < allUsers.Count(); i++)
            {
                if (allUsers[i].Username == username)
                {
                    return Ok("Ja existe alguém usando este nome");
                }
                else if(allUsers[i].Email == email){
                    return Ok("Ja existe alguém usando este email");
                }
            }
            var new_user = new Usuarios(username, email, password);
            await _users.InsertOneAsync(new_user);
            return Ok("Cadastrado com sucesso");
        }
        [HttpGet("login/email={email}&&password={password}")]
        public async Task<ActionResult> loginUser(string email, string password)
        {
            var filterEmail = Builders<Usuarios>.Filter.Eq(user => user.Email, email);
            var filterPass = Builders<Usuarios>.Filter.Eq(user => user.Password, password);
            var combinedFilter = Builders<Usuarios>.Filter.And(filterEmail, filterPass);
            var allUsers = await _users.Find(combinedFilter).ToListAsync();
            if(allUsers.Count == 0)
            {
                return Ok("Email ou senha incorretos");
            }
            else
            {
                return Ok(allUsers[0]);
            }
        }
    }
}
