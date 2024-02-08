using DatingApp.Server.Data;
using Microsoft.AspNetCore.Mvc;

namespace DatingApp.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly DataContext context;

        public UsersController(DataContext context)
        {
            this.context = context;
        }
    }
}
