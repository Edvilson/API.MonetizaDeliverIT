using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Monetiza.Data;
using Monetiza.Models;
using Monetiza.Services;

namespace Monetiza.Controllers
{
    [ApiController]
    [Route("v1/contas")]
    [AllowAnonymous]
    public class ContasController : Controller
    {
        
        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Conta>>> Get([FromServices] DataContext context)
        {
            var contas = await context.Contas.ToListAsync();
            return contas;
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<ActionResult<Conta>> GetById([FromServices] DataContext context, int id)
        {
            Conta contas = await context.Contas.FirstOrDefaultAsync(x => x.codcpagar == id);
            return contas;
        }

        [HttpPost]
        [Route("")]
        public async Task<ActionResult<Conta>> Post(
            [FromServices] DataContext context,
            [FromBody] Conta model)
        {
            int diasAtraso;
            double percMulta;
            double valMulta;
            double percJuros;
            double valJuros;
            double valCorrigido;

            if (ModelState.IsValid)
            {
                CalculaAtrasoService calcula = new CalculaAtrasoService();

                calcula.Calcular(model, out diasAtraso, out percMulta, out valMulta, out percJuros, out valJuros, out valCorrigido);

                model.diasatraso = diasAtraso;
                model.percmultaatraso = percMulta;
                model.valormultaatraso = valMulta;
                model.percjurosdia = percJuros;
                model.valorjurosdia = valJuros;
                model.valorcorrigido = valCorrigido;

                context.Contas.Add(model);
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
