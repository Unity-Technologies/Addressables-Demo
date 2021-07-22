using System;
using System.Collections.Generic;

namespace AddressablesPlayAssetDelivery
{
    [Serializable]
    public class CustomAssetPackDataEntry
    {
        public string AssetPackName;

        public DeliveryType DeliveryType;
        
        public List<string> AssetBundles;

        public CustomAssetPackDataEntry(string assetPackName, DeliveryType deliveryType, IEnumerable<string> assetBundles)
        {
            AssetPackName = assetPackName;
            DeliveryType = deliveryType;
            AssetBundles = new List<string>(assetBundles);
        }
    }

    [Serializable]
    public class CustomAssetPacksData
    {
        public List<CustomAssetPackDataEntry> Entries;

        public CustomAssetPacksData(List<CustomAssetPackDataEntry> entries)
        {
            Entries = new List<CustomAssetPackDataEntry>(entries);
        }
    }
}
