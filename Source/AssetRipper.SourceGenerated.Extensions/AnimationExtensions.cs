﻿using AssetRipper.Assets.Metadata;
using AssetRipper.IClasses.Animation;
using AssetRipper.IClasses.AnimationClip;
using AssetRipper.IClasses.PPtr_AnimationClip;
using AssetRipper.SourceGenerated.Classes.ClassID_111;
using AssetRipper.SourceGenerated.Classes.ClassID_74;
using AssetRipper.SourceGenerated.Enums;
using AssetRipper.SourceGenerated.Subclasses.PPtr_AnimationClip;

namespace AssetRipper.SourceGenerated.Extensions
{
	public static class AnimationExtensions
	{
		public static bool IsContainsAnimationClip(this IAnimation animation, IAnimationClip clip)
		{
			foreach (IPPtr_AnimationClip clipPtr in animation.Animations_C111)
			{
				if (clipPtr.IsAsset(animation.Collection, clip))
				{
					return true;
				}
			}
			return false;
		}

		public static bool IsContainsAnimationClip(this IAnimation animation, IAnimationClip_ACL clip)
		{
			foreach (IPPtr_AnimationClip clipPtr in animation.Animations_C111)
			{
				if (clipPtr.IsAsset(animation.Collection, clip))
				{
					return true;
				}
			}
			return false;
		}

		public static bool IsContainsAnimationClip(this IAnimation_ACL animation, IAnimationClip_ACL clip)
		{
			foreach (IPPtr_AnimationClip_ACL clipPtr in animation.Animations_C111)
			{
				if (clipPtr.IsAsset(animation.Collection, clip))
				{
					return true;
				}
			}
			return false;
		}

		public static bool GetAnimateOnlyIfVisible(this IAnimation animation)
		{
			// 2.6.0 to 3.4.0 exclusive
			//if (animation.Has_AnimateOnlyIfVisible_C111())
			{
				//return animation.AnimateOnlyIfVisible_C111;
			}
			//else if (animation.Has_CullingType_C111())
			{
				return animation.CullingType_C111E != AnimationCullingType.AlwaysAnimate;
			}
			//else
			//{
			//	return false;
			//}
		}

		public static AnimationCullingType GetAnimationCullingType(this IAnimation animation)
		{
			// 2.6.0 to 3.4.0 exclusive
			//if (animation.Has_AnimateOnlyIfVisible_C111())
			{
				//return animation.AnimateOnlyIfVisible_C111 ? AnimationCullingType.BasedOnRenderers : AnimationCullingType.AlwaysAnimate;
			}
			//else if (animation.Has_CullingType_C111())
			{
				return animation.CullingType_C111E;
			}
			//else
			//{
			//	return default;
			//}
		}
	}
}
