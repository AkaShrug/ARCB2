using AssetRipper.Assets;
using AssetRipper.Assets.Bundles;
using AssetRipper.SourceGenerated.Classes.ClassID_111;
using AssetRipper.SourceGenerated.Classes.ClassID_90;
using AssetRipper.SourceGenerated.Classes.ClassID_95;
using AssetRipper.IClasses.Animation;

namespace AssetRipper.SourceGenerated.Extensions
{
	public class AnimationCache
	{
		public List<IAvatar> CachedAvatars = new();
		public List<IAnimator> CachedAnimators = new();
		public List<IAnimation> CachedAnimations = new();
		public List<IAnimation_ACL> CachedAnimations_ACL = new();

		private void CacheAssets(Bundle bundle)
		{
			foreach (IUnityObjectBase asset in bundle.FetchAssetsInHierarchy())
			{
				switch (asset)
				{
					case IAvatar avatar:
						CachedAvatars.Add(avatar);
						break;
					case IAnimator animator:
						CachedAnimators.Add(animator);
						break;
					case IAnimation animation:
						CachedAnimations.Add(animation);
						break;
					case IAnimation_ACL animation_ACL:
						CachedAnimations_ACL.Add(animation_ACL);
						break;
				}
			}
		}

		public static AnimationCache CreateCache(Bundle bundle)
		{
			AnimationCache cache = new();
			cache.CacheAssets(bundle);
			return cache;
		}
	}
}
