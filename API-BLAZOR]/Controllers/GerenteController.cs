using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace API_BLAZOR_
{
    [ApiController]
    [Route("[controller]")]
    public class GerenteController : Controller
    {
        private AppDbContext _context;
        private IMapper _mapper;

        public GerenteController(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult PostGerente([FromBody] CreateGerenteDto gerenteDto)
        {
            var gerente = _mapper.Map<Gerente>(gerenteDto);
            _context.Add(gerente);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetGerentesPorId), new {Id = gerente.Id}, gerente);    
        }

        [HttpGet]
        public IEnumerable<Gerente> GetGerentes([FromQuery] string nomeGere)
        {
            return _context.Gerentes;
        }

        [HttpGet("{id}")]
        public IActionResult GetGerentesPorId(int id)
        {
            var gerentes = _context.Gerentes;
            var gerente = gerentes.FirstOrDefault(gerente => gerente.Id == id);
            if (gerente != null)
            {
                ReadGerenteDto gerenteDto = _mapper.Map<ReadGerenteDto>(gerente);
                return Ok(gerenteDto);
            }
            return NotFound();
        }   

        [HttpDelete("{id}")]
        public IActionResult DeleteGerente([FromBody] int id)
        {
            var gerentes = _context.Gerentes;
            var gerente = gerentes.FirstOrDefault(gerente => gerente.Id == id);
            if (gerente != null)
            {
                _context.Remove(gerente);
                _context.SaveChanges();
                return NoContent();
            }
                return NotFound();    
        }
    }
}