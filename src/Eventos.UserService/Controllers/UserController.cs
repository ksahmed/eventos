using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Eventos.UserService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;
        private Business.UserManager _manager;

        public UserController(ILogger<UserController> logger, Business.UserManager manager)
        {
            _logger = logger;
            _manager = manager;
        }

        [HttpPost]
        public IActionResult Authenticate(string username, string password)
        {
            _manager.Authenticate(username, password);
            return Ok();
        }

        [HttpPost]
        public IActionResult Register(Contracts.User newUser)
        {
            _manager.Register(newUser);
            return Ok();
        }
    }
}