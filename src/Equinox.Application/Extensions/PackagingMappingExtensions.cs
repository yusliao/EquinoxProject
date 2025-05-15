using System;
using Equinox.Application.ViewModels.Production;
using Equinox.Domain.Models.Production;

namespace Equinox.Application.Extensions
{
    public static class PackagingMappingExtensions
    {
        public static CellPackagingViewModel ToViewModel(this CellPackaging entity)
        {
            if (entity == null) return null;

            return new CellPackagingViewModel
            {
                Id = entity.Id,
                BatchNumber = entity.BatchNumber,
                CellCode = entity.CellCode,
                PackageType = entity.PackageType,
                Quantity = entity.Quantity,
                OperatorId = entity.OperatorId,
                PackageDate = entity.PackageDate,
                Status = entity.Status
            };
        }

        public static CellPackaging ToEntity(this CellPackagingViewModel viewModel)
        {
            if (viewModel == null) return null;

            return new CellPackaging(
                viewModel.Id,
                viewModel.BatchNumber,
                viewModel.CellCode,
                viewModel.PackageType,
                viewModel.Quantity,
                viewModel.OperatorId,
                viewModel.PackageDate,
                viewModel.Status);
        }

        public static ModulePackagingViewModel ToViewModel(this ModulePackaging entity)
        {
            if (entity == null) return null;

            return new ModulePackagingViewModel
            {
                Id = entity.Id,
                BatchNumber = entity.BatchNumber,
                ModuleCode = entity.ModuleCode,
                PackCode = entity.PackCode,
                PackageType = entity.PackageType,
                Quantity = entity.Quantity,
                OperatorId = entity.OperatorId,
                PackageDate = entity.PackageDate,
                Status = entity.Status
            };
        }

        public static ModulePackaging ToEntity(this ModulePackagingViewModel viewModel)
        {
            if (viewModel == null) return null;

            return new ModulePackaging(
                viewModel.Id,
                viewModel.BatchNumber,
                viewModel.ModuleCode,
                viewModel.PackCode,
                viewModel.PackageType,
                viewModel.Quantity,
                viewModel.OperatorId,
                viewModel.PackageDate,
                viewModel.Status);
        }
    }
} 