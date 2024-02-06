using AssestTracking.Data.Models;
using AssetTracking.Data;
using AssetTracking.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetTracking.Repository.Servies
{
    // Services/AssetService.cs
    public class AssetService
    {
        private readonly IAssetRepository _assetRepository;

        public AssetService(IAssetRepository assetRepository)
        {
            _assetRepository = assetRepository;
        }

        public async Task<IEnumerable<AssetViewModel>> GetAllAssetViewModelsAsync()
        {
            var assets = await _assetRepository.GetAllAssetsAsync();
            return assets.Select(MapAssetToViewModel);
        }

        public async Task<AssetViewModel> GetAssetViewModelByIdAsync(int assetId)
        {
            var asset = await _assetRepository.GetAssetByIdAsync(assetId);
            return MapAssetToViewModel(asset);
        }

        public async Task AddAssetViewModelAsync(AssetViewModel assetViewModel)
        {
            var asset = MapViewModelToAsset(assetViewModel);
            await _assetRepository.AddAssetAsync(asset);
        }

        public async Task UpdateAssetViewModelAsync(AssetViewModel assetViewModel)
        {
            var asset = MapViewModelToAsset(assetViewModel);
            await _assetRepository.UpdateAssetAsync(asset);
        }

        public async Task DeleteAssetViewModelAsync(int assetId)
        {
            await _assetRepository.DeleteAssetAsync(assetId);
        }

        private AssetViewModel MapAssetToViewModel(Asset asset)
        {
            return new AssetViewModel
            {
                AssetId = asset.AssetId,
                AssetName = asset.AssetName,
                // Map other properties
            };
        }

        private Asset MapViewModelToAsset(AssetViewModel assetViewModel)
        {
            return new Asset
            {
                AssetId = assetViewModel.AssetId,
                AssetName = assetViewModel.AssetName,
                // Map other properties
            };
        }

        public async Task<bool> AssetExistsAsync(int id)
        {
            return await _assetRepository.AssetExistsAsync(id);
        }
    }

}
