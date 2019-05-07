﻿using System;
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
    public class ProjetosController : ControllerBase
    {
        private IProjetosRepository ProjetosRepository { get; set; }

        public ProjetosController()
        {
            ProjetosRepository = new ProjetosRepository();
        }

        [HttpPost]
        public IActionResult Cadastro(Projetos projetos)
        {
            try
            {
                ProjetosRepository.Cadastrar(projetos);
                return Ok();
            }
            catch(Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpGet]
        public IActionResult Listagem()
        {
            try
            {
                return Ok(ProjetosRepository.ListaProjetos());
            }
            catch(Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}