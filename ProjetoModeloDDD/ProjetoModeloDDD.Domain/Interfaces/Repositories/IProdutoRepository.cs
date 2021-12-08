using ProjetoModeloDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoModeloDDD.Domain.Interfaces.Repositories
{
    public interface IProdutoRepository : IRepositoryBase<Produto>
    {
        IEnumerable<Produto> GetByName(string name);
    }
}
