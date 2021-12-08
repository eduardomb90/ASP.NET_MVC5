using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoModeloDDD.MVC.ViewModels
{
    public class ProdutoViewModel
    {
        [Key]
        public int ProdutoId { get; set; }

        [Required(ErrorMessage = "Preencha o campo Nome")]
        [StringLength(250, MinimumLength = 2, ErrorMessage = "Este campo deve conter entre {1} e {0} caracteres")]
        public string Nome { get; set; }
        
        [DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "9999999999")]
        [Required(ErrorMessage ="Preencha um valor")]
        public decimal Valor { get; set; }

        [DisplayName("Disponível?")]
        public bool Disponivel { get; set; }

        //Foreign Key
        public int ClienteId { get; set; }
        public virtual ClienteViewModel Cliente { get; set; }
    }
}