using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Server.Database;
using Server.Database.DatabaseContext;
using Server.Database.Model;
using System.Threading.Tasks;

namespace Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IDatabaseWorker<User> _databaseWorker;

        public AccountController(Context context)
        {
            _databaseWorker = new UserDatabaseWorker(context);
        }

        [HttpPost]
        public async Task<string> Post([FromBody] string token)
        {
            JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();
            JwtSecurityToken security = handler.ReadJwtToken(token);
            string sub = security.Claims.FirstOrDefault(el => el.Type == "sub").Value;
            User user = await _databaseWorker.GetAsync(sub);
            if (user == null)
            {
                //create
            }
            //get token
            return "";
        }
    }
}