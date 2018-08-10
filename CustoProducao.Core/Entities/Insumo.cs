using System;
using System.Collections.Generic;

namespace CustoProducao.Core
{
    public partial class Insumo
    {
        public Guid IdInsumo { get; set; }
        public DateTime DtInsumoCadastro { get; set; }
        public string NmInsumo { get; set; }
        public string DsInsumo { get; set; }
        public decimal VlInsumoNota { get; set; }
        public decimal VlInsumoFrete { get; set; }
    }
}
