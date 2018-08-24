using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace CustoProducao.WebMVC.ViewModels
{
    public class InsumoViewModel
    {
        public int IdInsumo { get; set; }

        [Required(AllowEmptyStrings =false,ErrorMessage ="Campo obrigatório")]
        [Display(Name = "Código do Insumo")]
        public string CdInsumo { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [ReadOnly(true)]
        [Display(Name = "Data do Cadastro")]
        public DateTime DtInsumoCadastro { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Campo obrigatório")]
        [StringLength(100, ErrorMessage = "Campo {0} deve ter pelo menos {2} caracteres e no máximo {1} caracteres.", MinimumLength = 5)]
        [Display(Name = "Nome do Insumo")]
        public string NmInsumo { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Campo obrigatório")]
        [StringLength(1000, ErrorMessage = "Campo {0} deve ter pelo menos {2} caracteres e no máximo {1} caracteres.", MinimumLength = 5)]
        [Display(Name = "Descrição do Insumo")]
        public string DsInsumo { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "Valor do Insumo na Nota Fiscal")]
        [DataType(DataType.Currency)]
        public decimal VlInsumoNota { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "Valor do Frete pago neste Insumo")]
        [DataType(DataType.Currency)]
        public decimal VlInsumoFrete { get; set; }
    }
}
