using System;
using System.Collections.Generic;

namespace CustoProducao.Core.Entities
{
    public partial class Insumo : BaseEntity
    {
        public Guid IdInsumo { get; set; }
        public string CdInsumo { get; set; }
        public DateTime DtInsumoCadastro { get; set; }
        public string NmInsumo { get; set; }
        public string DsInsumo { get; set; }
        public decimal VlInsumoNota { get; set; }
        public decimal VlInsumoFrete { get; set; }
    }
}
