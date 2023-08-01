using AutoMapper;
using IntroduccionAEFCore.DTOs;
using IntroduccionAEFCore.Entidades;
using Microsoft.AspNetCore.Mvc;

namespace IntroduccionAEFCore.Controllers
{
    [Route("api/pelicula/{peliculaId:int}/comentarios")]
    [ApiController]
    public class ComentariosController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public ComentariosController(ApplicationDbContext context, IMapper mapper)
        {
            this._context = context;
            this._mapper = mapper;
        }


        [HttpPost]
        public async Task<ActionResult> Post(int peliculaId, ComentariosCreacionDTO comentariosCreacionDTO)
        {
            var comentario = _mapper.Map<Comentario>(comentariosCreacionDTO);
            comentario.PeliculaId = peliculaId;
            _context.Add(comentario);
            await _context.SaveChangesAsync();

            return Ok();
        }

    }
}
