using CustoProducao.Core.Entities;
using CustoProducao.Core.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CustoProducao.Infrastructure.Data
{
    public class EmpresaRepository : EfRepository<Empresa>, IEmpresaRepository
    {
        public EmpresaRepository(CustoProducaoDbContext dbContext) : base(dbContext)
        {
        }
    }
}
