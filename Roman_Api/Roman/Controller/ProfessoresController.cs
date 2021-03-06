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
    public class ProfessoresController : ControllerBase
    {
        private IProfessorRepository ProfessorRepository { get; set; }

        public ProfessoresController()
        {
            ProfessorRepository = new ProfessorRepository();
        }

        [HttpPost]
        public IActionResult Cadastro(Professor professor)
        {
            try
            {
                ProfessorRepository.Cadastrar(professor);
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
                return Ok(ProfessorRepository.ListaProfessor());
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}