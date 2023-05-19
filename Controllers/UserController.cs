using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace windows_auth.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class UserController : ControllerBase
    {
        private readonly IHttpContextAccessor _httpC;
        public UserController(IHttpContextAccessor httpC)
        {
            _httpC = httpC;
        }

        [HttpGet]
        public string GetUserName()
        {
            string? user = _httpC.HttpContext?.User.Identity?.Name;

            return user ?? "";
        }
    }
}