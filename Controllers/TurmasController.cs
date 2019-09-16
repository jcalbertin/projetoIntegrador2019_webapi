using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using projetoIntegrador2019_webapi.Modelos;
using projetoIntegrador2019_webapi.Servicos;

namespace projetoIntegrador2019_webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TurmasController : Controller
    {
        private readonly ITurmaService _service;
        public TurmasController(ITurmaService service)
        {
            this._service = service;
        }

        // GET api/turmas
        [HttpGet]
        public IEnumerable<Turma> Get()
        {
            return this._service.ListarTodas().ToArray();
        }

        // GET api/turmas/1
        [HttpGet("{id}")]
        public Turma Obter(int id)
        {
            return this._service.ObterUma(id);
        }

        // GET api/turmas/curso
        
        [HttpGet("pesquisar/{curso}")]
        public IEnumerable<Turma> ListarPorCurso(string curso)
        {
            return this._service.ListarPorCurso(curso);
        }

        [HttpPost]
        public IActionResult Post(Turma Turma)
        {
            this._service.Adicionar(Turma);
            return Ok(); //retorna codigo 200
        }

    }
}