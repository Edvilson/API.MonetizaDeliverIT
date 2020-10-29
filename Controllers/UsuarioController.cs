using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Monetiza.Data;
using Monetiza.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Monetiza.Controllers
{

    [ApiController]
    [Route("v1/usuario")]
    [AllowAnonymous]
    public class UsuarioController : Controller
    {
        [Authorize]
        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Usuario>>> Get([FromServices] DataContext context)
        {
            var usuarios = await context.Usuarios.ToListAsync();
            return usuarios;
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<ActionResult<Usuario>> GetById([FromServices] DataContext context, int id)
        {
            Usuario usuarios = await context.Usuarios.FirstOrDefaultAsync(x => x.codusuario == id);
            return usuarios;
        }

        [HttpPost]
        [Route("")]
        public async Task<ActionResult<Usuario>> Post(
            [FromServices] DataContext context,
            [FromBody] Usuario model)
        {
            
            if (ModelState.IsValid)
            {
                context.Usuarios.Add(model);
                await context.SaveChangesAsync();
                return model;
            }
            else
            {
                return BadRequest(ModelState);
            }
        }

    }

 }
