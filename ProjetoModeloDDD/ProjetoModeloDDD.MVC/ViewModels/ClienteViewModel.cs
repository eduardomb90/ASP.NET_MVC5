using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoModeloDDD.MVC.ViewModels
{
    public class ClienteViewModel
    {
        [Key]
        public int ClienteId { get; set; }
        
        [Required(ErrorMessage ="Preencha o campo Nome")]
        [StringLength(150, MinimumLength = 2, ErrorMessage ="Este campo deve conter entre {1} e {0} caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Preencha o campo Sobrenome")]
        [StringLength(150, MinimumLength = 2, ErrorMessage = "Este campo deve conter entre {1} e {0} caracteres")]
        public string Sobrenome { get; set; }
        
        [Required(ErrorMessage ="Preencha o campo E-mail")]
        [DisplayName("E-mail")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Este campo deve conter entre {1} e {0} caracteres")]
        [EmailAddress(ErrorMessage ="Preencha um e-mail valido")]
        public string Email { get; set; }
        
        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }

        public bool Ativo { get; set; }
        public virtual IEnumerable<ProdutoViewModel> Produtos { get; set; }
    }
}