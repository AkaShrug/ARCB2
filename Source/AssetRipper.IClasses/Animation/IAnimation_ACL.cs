using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using AssetRipper.Assets;
using AssetRipper.Assets.Cloning;
using AssetRipper.Assets.Export.Dependencies;
using AssetRipper.Assets.Export.Yaml;
using AssetRipper.Assets.Generics;
using AssetRipper.Assets.Interfaces;
using AssetRipper.Assets.IO;
using AssetRipper.Assets.IO.Reading;
using AssetRipper.Assets.IO.Writing;
using AssetRipper.SourceGenerated.Classes.ClassID_0;
using AssetRipper.SourceGenerated.Classes.ClassID_1;
using AssetRipper.SourceGenerated.Classes.ClassID_1001;
using AssetRipper.SourceGenerated.Classes.ClassID_1001480554;
using AssetRipper.SourceGenerated.Classes.ClassID_1002;
using AssetRipper.SourceGenerated.Classes.ClassID_18;
using AssetRipper.SourceGenerated.Classes.ClassID_2;
using AssetRipper.SourceGenerated.Classes.ClassID_74;
using AssetRipper.SourceGenerated.Classes.ClassID_8;
using AssetRipper.SourceGenerated.Enums;
using AssetRipper.SourceGenerated.Interfaces;
using AssetRipper.SourceGenerated.MarkerInterfaces;
using AssetRipper.SourceGenerated.Subclasses.AABB;
using AssetRipper.SourceGenerated.Subclasses.PPtr_AnimationClip;
using AssetRipper.SourceGenerated.Subclasses.PPtr_EditorExtensionImpl;
using AssetRipper.SourceGenerated.Subclasses.PPtr_EditorExtension;
using AssetRipper.SourceGenerated.Subclasses.PPtr_GameObject;
using AssetRipper.SourceGenerated.Subclasses.PPtr_PrefabInstance;
using AssetRipper.SourceGenerated.Subclasses.PPtr_Prefab;
using AssetRipper.IClasses.PPtr_AnimationClip;
using AssetRipper.IClasses.AnimationClip;

namespace AssetRipper.IClasses.Animation
{
	// Token: 0x020033E4 RID: 13284

	public interface IAnimation_ACL : IBehaviour, IBehaviourMarker, IUnityObjectBase, IUnityAssetBase, IAsset, IAssetReadable, IAssetWritable, IYamlExportable, IDependent, ITypeTreeSerializable, IComponent, IEditorExtension, IEditorExtensionMarker, IObject, IObjectMarker, IHasHideFlags, IComponentMarker, IHasEnabled, IAnimationMarker
	{
		// Token: 0x170205A5 RID: 132517
		// (get) Token: 0x0605B821 RID: 374817
		// (set) Token: 0x0605B822 RID: 374818
		bool AnimatePhysics_C111 { get; set; }

		// Token: 0x170205A6 RID: 132518
		// (get) Token: 0x0605B823 RID: 374819

		IPPtr_AnimationClip_ACL Animation_C111
		{

			get;
		}

		// Token: 0x170205A7 RID: 132519
		// (get) Token: 0x0605B824 RID: 374820

		AccessListBase<IPPtr_AnimationClip_ACL> Animations_C111
		{

			get;
		}

		// Token: 0x170205A8 RID: 132520
		// (get) Token: 0x0605B825 RID: 374821
		IPPtr_EditorExtension CorrespondingSourceObject_C111 { get; }

		// Token: 0x170205A9 RID: 132521
		// (get) Token: 0x0605B826 RID: 374822
		// (set) Token: 0x0605B827 RID: 374823
		int CullingType_C111 { get; set; }

		// Token: 0x170205AA RID: 132522
		// (get) Token: 0x0605B828 RID: 374824
		// (set) Token: 0x0605B829 RID: 374825
		byte Enabled_C111 { get; set; }

		// Token: 0x170205AB RID: 132523
		// (get) Token: 0x0605B82A RID: 374826
		PPtr_EditorExtensionImpl ExtensionPtr_C111 { get; }

		// Token: 0x170205AC RID: 132524
		// (get) Token: 0x0605B82B RID: 374827

		IPPtr_GameObject GameObject_C111
		{

			get;
		}

		// Token: 0x170205AD RID: 132525
		// (get) Token: 0x0605B82C RID: 374828
		// (set) Token: 0x0605B82D RID: 374829
		uint HideFlags_C111 { get; set; }

		// Token: 0x170205AE RID: 132526
		// (get) Token: 0x0605B82E RID: 374830
		// (set) Token: 0x0605B82F RID: 374831
		bool PlayAutomatically_C111 { get; set; }

		// Token: 0x170205AF RID: 132527
		// (get) Token: 0x0605B830 RID: 374832
		PPtr_Prefab_2018_3_0 PrefabAsset_C111 { get; }

		// Token: 0x170205B0 RID: 132528
		// (get) Token: 0x0605B831 RID: 374833
		PPtr_PrefabInstance PrefabInstance_C111 { get; }

		// Token: 0x170205B1 RID: 132529
		// (get) Token: 0x0605B832 RID: 374834
		IPPtr_Prefab PrefabInternal_C111 { get; }

		// Token: 0x170205B2 RID: 132530
		// (get) Token: 0x0605B833 RID: 374835
		IAABB UserAABB_C111 { get; }

		// Token: 0x170205B3 RID: 132531
		// (get) Token: 0x0605B834 RID: 374836
		// (set) Token: 0x0605B835 RID: 374837
		int WrapMode_C111 { get; set; }

		// Token: 0x170205B4 RID: 132532
		// (get) Token: 0x0605B836 RID: 374838
		// (set) Token: 0x0605B837 RID: 374839
		AnimationCullingType CullingType_C111E { get; set; }

		// Token: 0x170205B5 RID: 132533
		// (get) Token: 0x0605B838 RID: 374840
		// (set) Token: 0x0605B839 RID: 374841
		HideFlags HideFlags_C111E { get; set; }

		// Token: 0x170205B6 RID: 132534
		// (get) Token: 0x0605B83A RID: 374842
		// (set) Token: 0x0605B83B RID: 374843
		WrapMode WrapMode_C111E { get; set; }

		// Token: 0x170205B7 RID: 132535
		// (get) Token: 0x0605B83C RID: 374844
		// (set) Token: 0x0605B83D RID: 374845
		IAnimationClip_ACL Animation_C111P { get; set; }

		// Token: 0x170205B8 RID: 132536
		// (get) Token: 0x0605B83E RID: 374846
		PPtrAccessList<IPPtr_AnimationClip_ACL, IAnimationClip_ACL> Animations_C111P
		{
			get;
		}

		// Token: 0x170205B9 RID: 132537
		// (get) Token: 0x0605B83F RID: 374847
		// (set) Token: 0x0605B840 RID: 374848
		IEditorExtension CorrespondingSourceObject_C111P { get; set; }

		// Token: 0x170205BA RID: 132538
		// (get) Token: 0x0605B841 RID: 374849
		// (set) Token: 0x0605B842 RID: 374850
		IEditorExtensionImpl ExtensionPtr_C111P { get; set; }

		// Token: 0x170205BB RID: 132539
		// (get) Token: 0x0605B843 RID: 374851
		// (set) Token: 0x0605B844 RID: 374852
		IGameObject GameObject_C111P { get; set; }

		// Token: 0x170205BC RID: 132540
		// (get) Token: 0x0605B845 RID: 374853
		// (set) Token: 0x0605B846 RID: 374854
		IPrefab PrefabAsset_C111P { get; set; }

		// Token: 0x170205BD RID: 132541
		// (get) Token: 0x0605B847 RID: 374855
		// (set) Token: 0x0605B848 RID: 374856
		IPrefabInstance PrefabInstance_C111P { get; set; }

		// Token: 0x170205BE RID: 132542
		// (get) Token: 0x0605B849 RID: 374857
		// (set) Token: 0x0605B84A RID: 374858
		IPrefabMarker PrefabInternal_C111P { get; set; }

		// Token: 0x0605B84B RID: 374859
		[MemberNotNullWhen(true, "CorrespondingSourceObject_C111")]
		[MemberNotNullWhen(false, "UserAABB_C111")]
		[MemberNotNullWhen(false, "ExtensionPtr_C111")]
		bool Has_CorrespondingSourceObject_C111();

		// Token: 0x0605B84C RID: 374860
		[MemberNotNullWhen(false, "CorrespondingSourceObject_C111")]
		[MemberNotNullWhen(true, "ExtensionPtr_C111")]
		[MemberNotNullWhen(true, "UserAABB_C111")]
		bool Has_ExtensionPtr_C111();

		// Token: 0x0605B84D RID: 374861
		[MemberNotNullWhen(true, "PrefabAsset_C111")]
		[MemberNotNullWhen(true, "CorrespondingSourceObject_C111")]
		[MemberNotNullWhen(true, "PrefabInstance_C111")]
		bool Has_PrefabAsset_C111();

		// Token: 0x0605B84E RID: 374862
		[MemberNotNullWhen(true, "PrefabInstance_C111")]
		[MemberNotNullWhen(true, "PrefabAsset_C111")]
		[MemberNotNullWhen(true, "CorrespondingSourceObject_C111")]
		bool Has_PrefabInstance_C111();

		// Token: 0x0605B84F RID: 374863
		[MemberNotNullWhen(true, "PrefabInternal_C111")]
		[MemberNotNullWhen(true, "CorrespondingSourceObject_C111")]
		bool Has_PrefabInternal_C111();

		// Token: 0x0605B850 RID: 374864
		[MemberNotNullWhen(false, "CorrespondingSourceObject_C111")]
		[MemberNotNullWhen(true, "UserAABB_C111")]
		bool Has_UserAABB_C111();

		// Token: 0x0605B851 RID: 374865

		void CopyValues(IAnimation_ACL source, PPtrConverter converter);

		// Token: 0x0605B852 RID: 374866

		void CopyValues(IAnimation_ACL source);
	}
}
