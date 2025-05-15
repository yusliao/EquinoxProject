using System;
using System.Threading.Tasks;
using Equinox.Application.Interfaces.Production;
using Equinox.Application.ViewModels.Production;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Equinox.UI.Web.Controllers
{
    [Authorize]
    public class ProductionController : Controller
    {
        private readonly IPackagingAppService _packagingAppService;

        public ProductionController(IPackagingAppService packagingAppService)
        {
            _packagingAppService = packagingAppService;
        }

        // 电芯包装
        public IActionResult CellPackaging()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddCellPackaging(CellPackagingViewModel viewModel)
        {
            if (!ModelState.IsValid)
                return View(viewModel);

            viewModel.PackageDate = DateTime.Now;
            await _packagingAppService.AddCellPackaging(viewModel);

            return RedirectToAction(nameof(CellPackaging));
        }

        [HttpGet]
        public async Task<IActionResult> GetCellPackagingByBatch(string batchNumber)
        {
            var result = await _packagingAppService.GetCellPackagingByBatch(batchNumber);
            return Json(result);
        }

        // 模组PACK包装
        public IActionResult ModulePackaging()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddModulePackaging(ModulePackagingViewModel viewModel)
        {
            if (!ModelState.IsValid)
                return View(viewModel);

            viewModel.PackageDate = DateTime.Now;
            await _packagingAppService.AddModulePackaging(viewModel);

            return RedirectToAction(nameof(ModulePackaging));
        }

        [HttpGet]
        public async Task<IActionResult> GetModulePackagingByBatch(string batchNumber)
        {
            var result = await _packagingAppService.GetModulePackagingByBatch(batchNumber);
            return Json(result);
        }
    }
} 