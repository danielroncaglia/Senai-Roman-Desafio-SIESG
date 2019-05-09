using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Roman.Domains;
using Roman.Interfaces;
using Roman.Repositores;

namespace Roman.Controller
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class ProjetosController : ControllerBase
    {
        private IProjetosRepository ProjetosRepository { get; set; }

        public ProjetosController()
        {
            ProjetosRepository = new ProjetosRepository();
        }

        [HttpPost]
        //[Authorize]
        public IActionResult Cadastro(Projetos projetos)
        {
            try
            {
                ProjetosRepository.Cadastrar(projetos);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpGet]
        //[Authorize]
        public IActionResult Listagem()
        {
            try
            {
                return Ok(ProjetosRepository.ListaProjetos());
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPut("{id}")]
        //[Authorize (Roles = "Administrador")]
        public IActionResult situacao(Projetos projetos, int id)
        {
            try
            {
                Projetos pesquisa = ProjetosRepository.BuscarPorId(id);

                if (pesquisa == null)
                {
                    return BadRequest(new { mensagem = "projeto não encontrado" });
                }
                ProjetosRepository.Situacao(projetos, id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(new { mensagem = "Erro" });
            }
        }

    }
}