using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;
using Persistence.Data;

namespace Aplication.Repository
{
    public class RolRepository : GenericRepository<Rol>, IRolRepository
    {
        private readonly CuatroCapasContext _context;

        public RolRepository(CuatroCapasContext context) : base(context)
        {
            _context = context;
        }
    }
}