using System.Collections.Generic;
using projetoIntegrador2019_webapi.Modelos;

namespace projetoIntegrador2019_webapi.Servicos
{
    public interface IAlunoService
    {
         void Adicionar(Aluno Aluno);
         Aluno ObterUm(int Id);
         void Salvar(Aluno Aluno);
         void Excluir(Aluno Aluno);

         List<Aluno> ListarTodos();

    }
}