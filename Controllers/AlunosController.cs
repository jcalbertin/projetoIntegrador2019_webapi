using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using projetoIntegrador2019_webapi.Modelos;
using projetoIntegrador2019_webapi.Servicos;

namespace projetoIntegrador2019_webapi.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class AlunosController : Controller
    {
        private readonly IAlunoService _alunoService;
        public AlunosController(IAlunoService alunoService)
        {
            this._alunoService = alunoService;
        }

        // GET api/alunos
        [HttpGet]
        public IEnumerable<Aluno> Get()
        {
            return this._alunoService.ListarTodos().ToArray();
        }

        // GET api/alunos
        [HttpGet("{id}")]
        public Aluno Obter(int id)
        {
            return this._alunoService.ObterUm(id);
        }

        [HttpPost]
        public IActionResult Post(Aluno Aluno)
        {
            this._alunoService.Adicionar(Aluno);
            return Ok(); //retorna codigo 200
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            this._alunoService.Excluir(new Aluno{Id=id});
            return Ok(); //retorna codigo 200
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Aluno Aluno)
        {
            Aluno.Id = id;
            this._alunoService.Salvar(Aluno);
            return Ok(); //retorna codigo 200
        }
    }
}