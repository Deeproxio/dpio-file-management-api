﻿using Deeproxio.Asset.DAL.Contracts;

namespace Deeproxio.Asset.DAL.Configuration
{
    internal class AssetsDatabaseSettings : IAssetsDatabaseSettings
    {
        public string CollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}
