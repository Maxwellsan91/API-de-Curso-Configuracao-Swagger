using curso.api.Bussines.Entities;
using System.Collections.Generic;

namespace curso.api.Bussines.Repositories
{
    public interface ICursoRepository
    {
        void Adicionar(Curso curso);

        void Commit();

        IList<Curso> ObterPorUsuario(int codigoUsuario);
    }
}
