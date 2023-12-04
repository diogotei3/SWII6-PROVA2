using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Security.Principal;
using Server.Security;
using Microsoft.EntityFrameworkCore;
using Server.Data;
using Server.Models;

namespace Server.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {

        private readonly ServerContext _context;

        public AuthController(ServerContext context)
        {
            _context = context;
        }

        [AllowAnonymous]
        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginModel login)
        {
            if (login == null)
            {
                return BadRequest("Login invalido.");
            }

            var user = _context.Usuario.FirstOrDefault(u => u.Nome == login.Login && u.Senha == login.Senha && u.Status == true);

            if (user == null)
            {
                return Unauthorized("Usuario não encontrado ou inativo.");
            }

            return Ok(TokenService.GenerateToken(user));

        }
    }
}
