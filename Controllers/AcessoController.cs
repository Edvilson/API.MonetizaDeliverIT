using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Monetiza.Data;
using Monetiza.Models;
using Monetiza.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Monetiza.Controllers
{
    [Route("v1/acesso")]
    public class AcessoController : Controller
    {
        [HttpPost]
        [Route("login/{id}:int")]
        [AllowAnonymous]
        public async Task<ActionResult<dynamic>> Authenticate([FromServices] DataContext context, int id)
        {
            var usuario = await context.Usuarios.FirstOrDefaultAsync(x => x.codusuario == id);

            if (usuario == null)
                return NotFound(new { message = "Usuário Inválido"});

            var token = TokenService.GerarToken(usuario);

            usuario.dscsenha = "";

            return new
            {
                usuario = usuario,
                token = token
            };

        }
    }
}
