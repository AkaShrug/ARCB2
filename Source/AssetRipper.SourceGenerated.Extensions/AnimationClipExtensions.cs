﻿using AssetRipper.Assets;
using AssetRipper.Assets.Generics;
using AssetRipper.Assets.Metadata;
using AssetRipper.IClasses.Animation;
using AssetRipper.IClasses.AnimationClip;
using AssetRipper.SourceGenerated.Classes.ClassID_1;
using AssetRipper.SourceGenerated.Classes.ClassID_111;
using AssetRipper.SourceGenerated.Classes.ClassID_74;
using AssetRipper.SourceGenerated.Classes.ClassID_90;
using AssetRipper.SourceGenerated.Classes.ClassID_95;
using AssetRipper.SourceGenerated.Subclasses.GenericBinding;
using AssetRipper.SourceGenerated.Subclasses.Utf8String;

namespace AssetRipper.SourceGenerated.Extensions
{
	public static class AnimationClipExtensions
	{

		public enum AnimationType
		{
			Legacy = 1,
			Mecanim = 2,
			Human = 3,
		}

		public static bool GetLegacy(this IAnimationClip clip)
		{
			if (clip.Has_Legacy_C74())
			{
				return clip.Legacy_C74;
			}
			return clip.AnimationType_C74 == (int)AnimationType.Legacy;
		}

		public static IEnumerable<IGameObject> FindRoots(this IAnimationClip clip)
		{
			foreach (IUnityObjectBase asset in clip.Collection.Bundle.FetchAssetsInHierarchy())
			{
				if (asset is IAnimator animator)
				{
					if (clip.IsAnimatorContainsClip(animator))
					{
						yield return animator.GameObject_C8.GetAsset(animator.Collection);
					}
				}
				else if (asset is IAnimation animation)
				{
					if (clip.IsAnimationContainsClip(animation))
					{
						yield return animation.GameObject_C8.GetAsset(animation.Collection);
					}
				}
			}

			yield break;
		}

		public static IEnumerable<IGameObject> FindRoots(this IAnimationClip_ACL clip)
		{
			foreach (IUnityObjectBase asset in clip.Collection.Bundle.FetchAssetsInHierarchy())
			{
				if (asset is IAnimator animator)
				{
					if (clip.IsAnimatorContainsClip(animator))
					{
						yield return animator.GameObject_C8.GetAsset(animator.Collection);
					}
				}
				else if (asset is IAnimation animation)
				{
					if (clip.IsAnimationContainsClip(animation))
					{
						yield return animation.GameObject_C8.GetAsset(animation.Collection);
					}
				}
				else if (asset is IAnimation_ACL animation_ACL)
				{
					if (clip.IsAnimationContainsClip(animation_ACL))
					{
						yield return animation_ACL.GameObject_C8.GetAsset(animation_ACL.Collection);
					}
				}
			}

			yield break;
		}

		private static bool IsAnimatorContainsClip(this IAnimationClip clip, IAnimator animator)
		{
			return animator.IsContainsAnimationClip(clip);
		}

		private static bool IsAnimatorContainsClip(this IAnimationClip_ACL clip, IAnimator animator)
		{
			return animator.IsContainsAnimationClip(clip);
		}

		private static bool IsAnimationContainsClip(this IAnimationClip clip, IAnimation animation)
		{
			return animation.IsContainsAnimationClip(clip);
		}

		private static bool IsAnimationContainsClip(this IAnimationClip_ACL clip, IAnimation animation)
		{
			return animation.IsContainsAnimationClip(clip);
		}

		private static bool IsAnimationContainsClip(this IAnimationClip_ACL clip, IAnimation_ACL animation)
		{
			return animation.IsContainsAnimationClip(clip);
		}

		public static IReadOnlyDictionary<uint, string> FindTOS(this IAnimationClip clip, AnimationCache cache)
		{
			Dictionary<uint, string> tos = new() { { 0, string.Empty } };

			foreach (IAvatar avatar in cache.CachedAvatars)
			{
				if (clip.AddAvatarTOS(avatar, tos))
				{
					return tos;
				}
			}

			foreach (IAnimator animator in cache.CachedAnimators)
			{
				if (clip.IsAnimatorContainsClip(animator) && clip.AddAnimatorTOS(animator, tos))
				{
					return tos;
				}
			}

			foreach (IAnimation animation in cache.CachedAnimations)
			{
				if (clip.IsAnimationContainsClip(animation) && clip.AddAnimationTOS(animation, tos))
				{
					return tos;
				}
			}

			return tos;
		}

		public static IReadOnlyDictionary<uint, string> FindTOS(this IAnimationClip_ACL clip, AnimationCache cache)
		{
			Dictionary<uint, string> tos = new() { { 0, string.Empty } };

			foreach (IAvatar avatar in cache.CachedAvatars)
			{
				if (clip.AddAvatarTOS(avatar, tos))
				{
					return tos;
				}
			}

			foreach (IAnimator animator in cache.CachedAnimators)
			{
				if (clip.IsAnimatorContainsClip(animator) && clip.AddAnimatorTOS(animator, tos))
				{
					return tos;
				}
			}

			foreach (IAnimation animation in cache.CachedAnimations)
			{
				if (clip.IsAnimationContainsClip(animation) && clip.AddAnimationTOS(animation, tos))
				{
					return tos;
				}
			}

			foreach (IAnimation_ACL animation_ACL in cache.CachedAnimations_ACL)
			{
				if (clip.IsAnimationContainsClip(animation_ACL) && clip.AddAnimationTOS(animation_ACL, tos))
				{
					return tos;
				}
			}

			return tos;
		}

		private static bool AddAvatarTOS(this IAnimationClip clip, IAvatar avatar, Dictionary<uint, string> tos)
		{
			return clip.AddTOS(avatar.TOS_C90, tos);
		}

		private static bool AddAvatarTOS(this IAnimationClip_ACL clip, IAvatar avatar, Dictionary<uint, string> tos)
		{
			return clip.AddTOS(avatar.TOS_C90, tos);
		}

		private static bool AddAnimatorTOS(this IAnimationClip clip, IAnimator animator, Dictionary<uint, string> tos)
		{
			IAvatar? avatar = animator.Avatar_C95P;
			if (avatar != null && clip.AddAvatarTOS(avatar, tos))
			{
				return true;
			}

			IReadOnlyDictionary<uint, string> animatorTOS = animator.BuildTOS();
			return clip.AddTOS(animatorTOS, tos);
		}

		private static bool AddAnimatorTOS(this IAnimationClip_ACL clip, IAnimator animator, Dictionary<uint, string> tos)
		{
			IAvatar? avatar = animator.Avatar_C95P;
			if (avatar != null && clip.AddAvatarTOS(avatar, tos))
			{
				return true;
			}

			IReadOnlyDictionary<uint, string> animatorTOS = animator.BuildTOS();
			return clip.AddTOS(animatorTOS, tos);
		}

		private static bool AddAnimationTOS(this IAnimationClip clip, IAnimation animation, Dictionary<uint, string> tos)
		{
			IGameObject go = animation.GameObject_C8.GetAsset(animation.Collection);
			IReadOnlyDictionary<uint, string> animationTOS = go.BuildTOS();
			return clip.AddTOS(animationTOS, tos);
		}

		private static bool AddAnimationTOS(this IAnimationClip_ACL clip, IAnimation animation, Dictionary<uint, string> tos)
		{
			IGameObject go = animation.GameObject_C8.GetAsset(animation.Collection);
			IReadOnlyDictionary<uint, string> animationTOS = go.BuildTOS();
			return clip.AddTOS(animationTOS, tos);
		}

		private static bool AddAnimationTOS(this IAnimationClip_ACL clip, IAnimation_ACL animation, Dictionary<uint, string> tos)
		{
			IGameObject go = animation.GameObject_C8.GetAsset(animation.Collection);
			IReadOnlyDictionary<uint, string> animationTOS = go.BuildTOS();
			return clip.AddTOS(animationTOS, tos);
		}

		private static bool AddTOS(this IAnimationClip clip, IReadOnlyDictionary<uint, string> src, Dictionary<uint, string> dest)
		{
			if (clip.Has_ClipBindingConstant_C74())
			{
				int tosCount = clip.ClipBindingConstant_C74.GenericBindings.Count;
				for (int i = 0; i < tosCount; i++)
				{
					IGenericBinding binding = clip.ClipBindingConstant_C74.GenericBindings[i];
					if (src.TryGetValue(binding.Path, out string? path))
					{
						dest[binding.Path] = path;
						if (dest.Count == tosCount)
						{
							return true;
						}
					}
				}
			}
			return false;
		}

		private static bool AddTOS(this IAnimationClip_ACL clip, IReadOnlyDictionary<uint, string> src, Dictionary<uint, string> dest)
		{
			if (clip.Has_ClipBindingConstant_C74())
			{
				int tosCount = clip.ClipBindingConstant_C74.GenericBindings.Count;
				for (int i = 0; i < tosCount; i++)
				{
					IGenericBinding binding = clip.ClipBindingConstant_C74.GenericBindings[i];
					if (src.TryGetValue(binding.Path, out string? path))
					{
						dest[binding.Path] = path;
						if (dest.Count == tosCount)
						{
							return true;
						}
					}
				}
			}
			return false;
		}

		private static bool AddTOS(this IAnimationClip clip, AssetDictionary<uint, Utf8String> src, Dictionary<uint, string> dest)
		{
			if (clip.Has_ClipBindingConstant_C74())
			{
				AccessListBase<IGenericBinding> bindings = clip.ClipBindingConstant_C74.GenericBindings;
				int tosCount = bindings.Count;
				for (int i = 0; i < tosCount; i++)
				{
					IGenericBinding binding = bindings[i];
					if (src.TryGetValue(binding.Path, out Utf8String? path))
					{
						dest[binding.Path] = path.String;
						if (dest.Count == tosCount)
						{
							return true;
						}
					}
				}
			}
			return false;
		}

		private static bool AddTOS(this IAnimationClip_ACL clip, AssetDictionary<uint, Utf8String> src, Dictionary<uint, string> dest)
		{
			if (clip.Has_ClipBindingConstant_C74())
			{
				AccessListBase<IGenericBinding> bindings = clip.ClipBindingConstant_C74.GenericBindings;
				int tosCount = bindings.Count;
				for (int i = 0; i < tosCount; i++)
				{
					IGenericBinding binding = bindings[i];
					if (src.TryGetValue(binding.Path, out Utf8String? path))
					{
						dest[binding.Path] = path.String;
						if (dest.Count == tosCount)
						{
							return true;
						}
					}
				}
			}
			return false;
		}
	}
}
