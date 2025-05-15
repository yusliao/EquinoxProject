using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Equinox.Application.Extensions;
using Equinox.Application.Interfaces.Production;
using Equinox.Application.ViewModels.Production;
using Equinox.Domain.Interfaces.Production;
using NetDevPack.Mediator;

namespace Equinox.Application.Services.Production
{
    public class PackagingAppService : IPackagingAppService
    {
        private readonly IPackagingRepository _packagingRepository;
        private readonly IMediatorHandler _mediator;

        public PackagingAppService(
            IPackagingRepository packagingRepository,
            IMediatorHandler mediator)
        {
            _packagingRepository = packagingRepository;
            _mediator = mediator;
        }

        public async Task<CellPackagingViewModel> GetCellPackagingById(Guid id)
        {
            var cellPackaging = await _packagingRepository.GetCellPackagingById(id);
            return cellPackaging?.ToViewModel();
        }

        public async Task<IEnumerable<CellPackagingViewModel>> GetCellPackagingByBatch(string batchNumber)
        {
            var cellPackagings = await _packagingRepository.GetCellPackagingByBatch(batchNumber);
            return cellPackagings?.Select(x => x.ToViewModel());
        }

        public async Task<CellPackagingViewModel> AddCellPackaging(CellPackagingViewModel cellPackagingViewModel)
        {
            var cellPackaging = cellPackagingViewModel.ToEntity();
            
            if (!cellPackaging.IsValid())
            {
                return null; // 在实际应用中应该抛出验证异常
            }

            var result = await _packagingRepository.AddCellPackaging(cellPackaging);
            return result.ToViewModel();
        }

        public async Task<ModulePackagingViewModel> GetModulePackagingById(Guid id)
        {
            var modulePackaging = await _packagingRepository.GetModulePackagingById(id);
            return modulePackaging?.ToViewModel();
        }

        public async Task<IEnumerable<ModulePackagingViewModel>> GetModulePackagingByBatch(string batchNumber)
        {
            var modulePackagings = await _packagingRepository.GetModulePackagingByBatch(batchNumber);
            return modulePackagings?.Select(x => x.ToViewModel());
        }

        public async Task<ModulePackagingViewModel> AddModulePackaging(ModulePackagingViewModel modulePackagingViewModel)
        {
            var modulePackaging = modulePackagingViewModel.ToEntity();
            
            if (!modulePackaging.IsValid())
            {
                return null; // 在实际应用中应该抛出验证异常
            }

            var result = await _packagingRepository.AddModulePackaging(modulePackaging);
            return result.ToViewModel();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
} 