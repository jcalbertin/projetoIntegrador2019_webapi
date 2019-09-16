using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using projetoIntegrador2019_webapi.Modelos;

namespace projetoIntegrador2019_webapi.Servicos
{
    public class AlunoService : IAlunoService
    {
        private readonly TurmaContext _contexto;

        public AlunoService(TurmaContext contexto)
        {
            this._contexto = contexto;
        }
        public void Adicionar(Aluno Aluno)
        {
            _contexto.Add(Aluno);
            _contexto.SaveChanges();
        }

        public void Excluir(Aluno Aluno)
        {
            _contexto.Remove(_contexto.Alunos.Find(Aluno.Id));
            _contexto.SaveChanges();
        }

        public Aluno ObterUm(int Id)
        {
            return _contexto.Alunos.Find(Id);
        }

        public void Salvar(Aluno Aluno)
        {
           _contexto.Alunos.Update(Aluno);
           _contexto.SaveChanges();
        }

        public List<Aluno> ListarTodos()
        {
            return _contexto.Alunos.ToList();
        }
    }
}