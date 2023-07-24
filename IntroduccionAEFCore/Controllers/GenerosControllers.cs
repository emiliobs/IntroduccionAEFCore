﻿using IntroduccionAEFCore.DTOs;
using IntroduccionAEFCore.Entidades;
using Microsoft.AspNetCore.Mvc;

namespace IntroduccionAEFCore.Controllers
{
    [ApiController]
    [Route("api/generos")]
    public class GenerosControllers : Controller
    {
        private readonly ApplicationDbContext _context;

        public GenerosControllers(ApplicationDbContext context)
        {
            this._context = context;
        }

        [HttpPost]
        public async Task<IActionResult> Post(GEneroCreacionDTO generoCreacion)
        {
            var genero = new Genero()
            {
                Nombre = generoCreacion.Nombre,
            };

            _context.Add(genero);
            await _context.SaveChangesAsync();

            return Ok(genero);
        }
    }
}