using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Equinox.Domain.Models.Production;
using NetDevPack.Data;

namespace Equinox.Domain.Interfaces.Production
{
    public interface IPackagingRepository : IRepository<CellPackaging>
    {
        Task<CellPackaging> GetCellPackagingById(Guid id);
        Task<IEnumerable<CellPackaging>> GetCellPackagingByBatch(string batchNumber);
        Task<CellPackaging> AddCellPackaging(CellPackaging cellPackaging);
        
        Task<ModulePackaging> GetModulePackagingById(Guid id);
        Task<IEnumerable<ModulePackaging>> GetModulePackagingByBatch(string batchNumber);
        Task<ModulePackaging> AddModulePackaging(ModulePackaging modulePackaging);
    }
} 