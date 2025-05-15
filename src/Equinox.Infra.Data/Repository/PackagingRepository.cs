using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Equinox.Domain.Interfaces.Production;
using Equinox.Domain.Models.Production;
using Equinox.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using NetDevPack.Data;

namespace Equinox.Infra.Data.Repository
{
    public class PackagingRepository : IPackagingRepository
    {
        protected readonly EquinoxContext Db;
        protected readonly DbSet<CellPackaging> CellPackagingDbSet;
        protected readonly DbSet<ModulePackaging> ModulePackagingDbSet;

        public PackagingRepository(EquinoxContext context)
        {
            Db = context;
            CellPackagingDbSet = Db.Set<CellPackaging>();
            ModulePackagingDbSet = Db.Set<ModulePackaging>();
        }

        public IUnitOfWork UnitOfWork => Db;

        public async Task<CellPackaging> GetCellPackagingById(Guid id)
        {
            return await CellPackagingDbSet.FindAsync(id);
        }

        public async Task<IEnumerable<CellPackaging>> GetCellPackagingByBatch(string batchNumber)
        {
            return await CellPackagingDbSet
                .Where(x => x.BatchNumber == batchNumber)
                .ToListAsync();
        }

        public async Task<CellPackaging> AddCellPackaging(CellPackaging cellPackaging)
        {
            var result = await CellPackagingDbSet.AddAsync(cellPackaging);
            return result.Entity;
        }

        public async Task<ModulePackaging> GetModulePackagingById(Guid id)
        {
            return await ModulePackagingDbSet.FindAsync(id);
        }

        public async Task<IEnumerable<ModulePackaging>> GetModulePackagingByBatch(string batchNumber)
        {
            return await ModulePackagingDbSet
                .Where(x => x.BatchNumber == batchNumber)
                .ToListAsync();
        }

        public async Task<ModulePackaging> AddModulePackaging(ModulePackaging modulePackaging)
        {
            var result = await ModulePackagingDbSet.AddAsync(modulePackaging);
            return result.Entity;
        }

        public void Dispose()
        {
            Db?.Dispose();
        }
    }
} 