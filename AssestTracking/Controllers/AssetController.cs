using AssetTracking.Data;
using AssetTracking.Repository.Servies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AssetTracking.Web.Controllers
{
    // Controllers/AssetController.cs
    public class AssetController : Controller
    {
        private readonly AssetService _assetService;

        public AssetController(AssetService assetService)
        {
            _assetService = assetService;
        }

        public async Task<IActionResult> Index()
        {
            var assetViewModels = await _assetService.GetAllAssetViewModelsAsync();
            return View(assetViewModels);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(AssetViewModel assetViewModel)
        {
            if (ModelState.IsValid)
            {
                await _assetService.AddAssetViewModelAsync(assetViewModel);
                return RedirectToAction(nameof(Index));
            }
            return View(assetViewModel);
        }

        public async Task<IActionResult> Details(int id)
        {
            var assetViewModel = await _assetService.GetAssetViewModelByIdAsync(id);
            if (assetViewModel == null)
            {
                return NotFound();
            }
            return View(assetViewModel);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var assetViewModel = await _assetService.GetAssetViewModelByIdAsync(id);
            if (assetViewModel == null)
            {
                return NotFound();
            }
            return View(assetViewModel);
        }

        [HttpPost]
       
        public async Task<IActionResult> Edit(int id, AssetViewModel assetViewModel)
        {
            if (id != assetViewModel.AssetId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _assetService.UpdateAssetViewModelAsync(assetViewModel);
                }
                catch (DbUpdateConcurrencyException)
                {
                    var assetExists = await _assetService.AssetExistsAsync(id);

                    if (!assetExists)
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(assetViewModel);
        }


        public async Task<IActionResult> Delete(int id)
        {
            var assetViewModel = await _assetService.GetAssetViewModelByIdAsync(id);
            if (assetViewModel == null)
            {
                return NotFound();
            }
            return View(assetViewModel);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _assetService.DeleteAssetViewModelAsync(id);
            return RedirectToAction(nameof(Index));
        }

        private async Task<bool> AssetExistsAsync(int id)
        {
            return await _assetService.AssetExistsAsync(id);
        }
    }

}
