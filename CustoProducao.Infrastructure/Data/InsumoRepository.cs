using CustoProducao.Core.Entities;
using CustoProducao.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustoProducao.Infrastructure.Data
{
    public class InsumoRepository : EfRepository<Insumo>, IInsumoRepository
    {
        public InsumoRepository(CustoProducaoDbContext dbContext) : base(dbContext)
        {
        }

        public IEnumerable<Insumo> ListAll(int idEmpresa)
        {
            var query = from insumo in _dbContext.Insumos
                        where (insumo.IdEmpresa == idEmpresa)
                        select insumo;
            return query;
        }
    }
}
