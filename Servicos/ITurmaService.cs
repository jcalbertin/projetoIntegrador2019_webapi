using System.Collections.Generic;
using projetoIntegrador2019_webapi.Modelos;

namespace projetoIntegrador2019_webapi.Servicos
{
    public interface ITurmaService
    {
         void Adicionar(Turma Turma);  
         List<Turma> ListarTodas();
         List<Turma> ListarPorCurso(string Curso);
         Turma ObterUma(int Id);
    }
}