using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetoModeloDDD.Infra.Data.Repositories
{
    class ProdutoRepository : RepositoryBase<Produto>, IProdutoRepository
    {
        public IEnumerable<Produto> GetByName(string name)
        {
            return context.Produtos.Where(p => p.Nome == name)/*.ToList()*/;
        }
    }
}
