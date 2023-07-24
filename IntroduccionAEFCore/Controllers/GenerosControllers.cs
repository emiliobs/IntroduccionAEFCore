using AutoMapper;
using IntroduccionAEFCore.DTOs;
using IntroduccionAEFCore.Entidades;
using Microsoft.AspNetCore.Mvc;

namespace IntroduccionAEFCore.Controllers
{
    [ApiController]
    [Route("api/generos")]
    public class GenerosControllers : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public GenerosControllers(ApplicationDbContext context, IMapper mapper)
        {
            this._context = context;
            this._mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> Post(GEneroCreacionDTO generoCreacion)
        {
            //var genero = new Genero()
            //{
            //    Nombre = generoCreacion.Nombre,
            //};

            var genero = _mapper.Map<Genero>(generoCreacion);

            _context.Add(genero);
            await _context.SaveChangesAsync();

            return Ok(genero);
        }
    }
}
