using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Roman.Domains;
using Roman.Interfaces;
using Roman.Repositores;

namespace Roman.Controller
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class GrupoController : ControllerBase
    {
        private IGrupoRepository GrupoRepository { get; set; }

        public GrupoController()
        {
            GrupoRepository = new GrupoRepository();
        }

        [HttpPost]
        public IActionResult Cadastro(Grupo grupo)
        {
            try
            {
                GrupoRepository.Cadastrar(grupo);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}