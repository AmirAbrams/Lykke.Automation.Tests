﻿using System;
using System.Collections.Generic;
using System.Text;
using Autofac;
using XUnitTestData.Repositories.Assets;
using AzureStorage.Tables;
using XUnitTestCommon;
using XUnitTestData.Domains;
using XUnitTestData.Domains.Assets;
using Common.Log;
using System.Threading.Tasks;
using XUnitTestData.Services;
using XUnitTestCommon.Utils;

namespace AssetsData.DependencyInjection
{
    class AssetsTestModule : Module
    {
        private ConfigBuilder _configBuilder;

        public AssetsTestModule(ConfigBuilder configBuilder)
        {
            this._configBuilder = configBuilder;
        }

        protected override void Load(ContainerBuilder builder)
        {
            builder.Register(c => new AssetsRepository(
                    new AzureTableStorage<AssetEntity>(
                        _configBuilder.Config["DictionariesConnectionString"], "Dictionaries", null)))
                .As<IDictionaryRepository<IAsset>>();

            RepositoryUtils.RegisterDictionaryManager<IAsset>(builder);



            builder.Register(c => new AssetExtendedInfosRepository(
                    new AzureTableStorage<AssetExtendedInfosEntity>(
                        _configBuilder.Config["DictionariesConnectionString"], "Dictionaries", null)))
                .As<IDictionaryRepository<IAssetExtendedInfo>>();

            RepositoryUtils.RegisterDictionaryManager<IAssetExtendedInfo>(builder);

            builder.Register(c => new AssetCategoryRepository(
                    new AzureTableStorage<AssetCategoryEntity>(
                        _configBuilder.Config["DictionariesConnectionString"], "AssetCategories", null)))
                .As<IDictionaryRepository<IAssetCategory>>();

            RepositoryUtils.RegisterDictionaryManager<IAssetCategory>(builder);

            builder.Register(c => new AssetAttributesRepository(
                    new AzureTableStorage<AssetAttributesEntity>(
                        _configBuilder.Config["DictionariesConnectionString"], "AssetAttributes", null)))
                .As<IDictionaryRepository<IAssetAttributes>>();

            RepositoryUtils.RegisterDictionaryManager<IAssetAttributes>(builder);

            builder.Register(c => new AssetGroupsRepository(
                    new AzureTableStorage<AssetGroupEntity>(
                        _configBuilder.Config["MainConnectionString"], "AssetGroups", null)))
                .As<IDictionaryRepository<IAssetGroup>>();

            RepositoryUtils.RegisterDictionaryManager<IAssetGroup>(builder);

            builder.Register(c => new AssetPairsRepository(
                    new AzureTableStorage<AssetPairEntity>(
                        _configBuilder.Config["DictionariesConnectionString"], "Dictionaries", null)))
                .As<IDictionaryRepository<IAssetPair>>();

            RepositoryUtils.RegisterDictionaryManager<IAssetPair>(builder);

            builder.Register(c => new AssetSettingsRepository(
                    new AzureTableStorage<AssetSettingsEntity>(
                        _configBuilder.Config["DictionariesConnectionString"], "AssetSettings", null)))
                .As<IDictionaryRepository<IAssetSettings>>();

            RepositoryUtils.RegisterDictionaryManager<IAssetSettings>(builder);

            builder.Register(c => new AssetIssuersRepository(
                    new AzureTableStorage<AssetIssuersEntity>(
                        _configBuilder.Config["DictionariesConnectionString"], "AssetIssuers", null)))
                .As<IDictionaryRepository<IAssetIssuers>>();

            RepositoryUtils.RegisterDictionaryManager<IAssetIssuers>(builder);

            builder.Register(c => new MarginAssetPairsRepository(
                    new AzureTableStorage<MarginAssetPairsEntity>(
                        _configBuilder.Config["DictionariesConnectionString"], "Dictionaries", null)))
                .As<IDictionaryRepository<IMarginAssetPairs>>();

            RepositoryUtils.RegisterDictionaryManager<IMarginAssetPairs>(builder);

            builder.Register(c => new MarginAssetRepository(
                    new AzureTableStorage<MarginAssetEntity>(
                        _configBuilder.Config["DictionariesConnectionString"], "Dictionaries", null)))
                .As<IDictionaryRepository<IMarginAsset>>();

            RepositoryUtils.RegisterDictionaryManager<IMarginAsset>(builder);

            builder.Register(c => new MarginIssuerRepository(
                    new AzureTableStorage<MarginIssuerEntity>(
                        _configBuilder.Config["DictionariesConnectionString"], "AssetIssuers", null)))
                .As<IDictionaryRepository<IMarginIssuer>>();

            RepositoryUtils.RegisterDictionaryManager<IMarginIssuer>(builder);

            builder.Register(c => new WatchListRepository(
                    new AzureTableStorage<WatchListEntity>(
                        _configBuilder.Config["DictionariesConnectionString"], "WatchLists", null)))
                .As<IDictionaryRepository<IWatchList>>();

            base.Load(builder);
        }
    }
}