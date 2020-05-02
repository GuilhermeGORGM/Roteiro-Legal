using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Roteiro.Domain.Repositories
{
    public interface IGenericRepository<T> where T : Entity
    {
        T Adicionar(T obj);
        T ObterPorId(int id);
        IEnumerable<T> ObterTodos();
        T Atualizar(T obj);
        bool Remover(int id);
        IQueryable<T> BuscarPor(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includes);
        T Desativar(int Id);
        T Ativar(int Id);
        int SaveChanges();
        void Inativar(T obj);
        void Ativar(T obj);
    }
}
