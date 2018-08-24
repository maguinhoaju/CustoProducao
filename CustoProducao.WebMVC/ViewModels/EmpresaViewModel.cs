using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CustoProducao.WebMVC.ViewModels
{
    public class EmpresaViewModel
    {
        public int IdEmpresa { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Campo obrigatório")]
        [Display(Name = "CNPJ")]
        public long NrCnpj { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Campo obrigatório")]
        [StringLength(100, ErrorMessage = "Campo {0} deve ter pelo menos {2} caracteres e no máximo {1} caracteres.", MinimumLength = 3)]
        [Display(Name = "Nome da Empresa")]
        public string NmEmpresa { get; set; }
    }
}
