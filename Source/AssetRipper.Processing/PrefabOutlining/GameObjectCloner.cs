﻿using AssetRipper.Assets;
using AssetRipper.Assets.Cloning;
using AssetRipper.Assets.Collections;
using AssetRipper.GameChoiceClass;
using AssetRipper.SourceGenerated;
using AssetRipper.SourceGenerated.Classes.ClassID_1;
using AssetRipper.SourceGenerated.Extensions;
using System.Collections.Generic;
using AssetRipper.Import.GICB2;

namespace AssetRipper.Processing.PrefabOutlining
{
	public static class GameObjectCloner
	{
		public static IGameObject Clone(IGameObject source, ProcessedAssetCollection processedCollection)
		{
			Dictionary<IUnityObjectBase, IUnityObjectBase> clonedAssetDictionary = new();
			foreach (IUnityObjectBase asset in source.FetchHierarchy())
			{
				IUnityObjectBase clonedAsset;

				if (GameChoice.GetGame() == GameFlags.GICB2)
				{
					clonedAsset = processedCollection.CreateAsset(asset.ClassID, AssetFactoryForGICB2.CreateAsset);
				}
				else
				{
					clonedAsset = processedCollection.CreateAsset(asset.ClassID, AssetFactory.CreateAsset); ;
				}
				clonedAssetDictionary.Add(asset, clonedAsset);
			}
			ClonedAssetResolver resolver = new ClonedAssetResolver(clonedAssetDictionary);
			foreach ((IUnityObjectBase asset, IUnityObjectBase clonedAsset) in clonedAssetDictionary)
			{
				clonedAsset.CopyValues(asset, new PPtrConverter(asset.Collection, clonedAsset.Collection, resolver));
			}
			return (IGameObject)clonedAssetDictionary[source];
		}

		private sealed class ClonedAssetResolver : IAssetResolver
		{
			private readonly Dictionary<IUnityObjectBase, IUnityObjectBase> cache;

			public ClonedAssetResolver(Dictionary<IUnityObjectBase, IUnityObjectBase> cache)
			{
				this.cache = cache;
			}

			public T? Resolve<T>(IUnityObjectBase? asset) where T : IUnityObjectBase
			{
				if (asset is null)
				{
					return default;
				}
				else if (cache.TryGetValue(asset, out IUnityObjectBase? clonedAsset))
				{
					return TryCast<T>(clonedAsset);
				}
				else
				{
					return TryCast<T>(asset);
				}
			}

			private static T? TryCast<T>(IUnityObjectBase asset) where T : IUnityObjectBase
			{
				return asset is T t ? t : default;
			}
		}
	}
}
