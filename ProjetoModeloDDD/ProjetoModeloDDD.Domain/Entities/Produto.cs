using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoModeloDDD.Domain.Entities
{
    public class Produto
    {
        public int ProdutoId { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public bool Disponivel { get; set; }
        
        //Foreign Key
        public int ClienteId { get; set; }
        public virtual Cliente Cliente { get; set; }
    }
}
