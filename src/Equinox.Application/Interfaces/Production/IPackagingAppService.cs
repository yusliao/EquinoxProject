using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Equinox.Application.ViewModels.Production;

namespace Equinox.Application.Interfaces.Production
{
    public interface IPackagingAppService : IDisposable
    {
        Task<CellPackagingViewModel> GetCellPackagingById(Guid id);
        Task<IEnumerable<CellPackagingViewModel>> GetCellPackagingByBatch(string batchNumber);
        Task<CellPackagingViewModel> AddCellPackaging(CellPackagingViewModel cellPackagingViewModel);

        Task<ModulePackagingViewModel> GetModulePackagingById(Guid id);
        Task<IEnumerable<ModulePackagingViewModel>> GetModulePackagingByBatch(string batchNumber);
        Task<ModulePackagingViewModel> AddModulePackaging(ModulePackagingViewModel modulePackagingViewModel);
    }
} 