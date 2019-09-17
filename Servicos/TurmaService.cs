using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using projetoIntegrador2019_webapi.Modelos;

namespace projetoIntegrador2019_webapi.Servicos
{
    public class TurmaService : ITurmaService
    {
        private readonly TurmaContext _contexto;

        public TurmaService(TurmaContext contexto)
        {
            this._contexto = contexto;
        }

        public Turma Adicionar(Turma Turma)
        {
            _contexto.Add(Turma);
            _contexto.SaveChanges();
            return Turma;
        }

        public List<Turma> ListarPorCurso(string Curso)
        {
            return _contexto.Turmas.Where(t => 
                  EF.Functions.Like(t.Curso, "%"+Curso+"%")
                  ).ToList();
        }

        public List<Turma> ListarTodas() 
        {
            return _contexto.Turmas.Include(d => d.Alunos).ToList();
        }

        public Turma ObterUma(int Id)
        {
            var turma = _contexto.Turmas.Include(d => d.Alunos).Where(d => d.Id == Id).Single();
            return turma;
        }
    }
}