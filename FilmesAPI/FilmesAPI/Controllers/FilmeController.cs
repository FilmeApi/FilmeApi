﻿using FilmesAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace FilmesAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FilmeController : ControllerBase
    {
        private static List<Filme> filmes = new List<Filme>();

        [HttpPost]
        public void AdicioanrFilme([FromBody] Filme filme)
        {

            filmes.Add(filme);
            Console.WriteLine(filme.Titulo);
        }

    }
}
