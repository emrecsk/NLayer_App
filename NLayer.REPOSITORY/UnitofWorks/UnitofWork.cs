using NLayer.CORE.UnitofWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.REPOSITORY.UnitofWorks
{
    public class UnitofWork : IUnitofWork
    {
        private readonly AppDbContext _context;

        public UnitofWork(AppDbContext context)
        {
            _context = context;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public async Task CommitAsync()
        {
           await _context.SaveChangesAsync();
        }
    }
}
