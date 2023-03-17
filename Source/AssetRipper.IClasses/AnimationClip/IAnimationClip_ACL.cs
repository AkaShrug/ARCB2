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
using AssetRipper.SourceGenerated.Classes.ClassID_1001;
using AssetRipper.SourceGenerated.Classes.ClassID_1001480554;
using AssetRipper.SourceGenerated.Classes.ClassID_1002;
using AssetRipper.SourceGenerated.Classes.ClassID_130;
using AssetRipper.SourceGenerated.Classes.ClassID_18;
using AssetRipper.SourceGenerated.Enums;
using AssetRipper.SourceGenerated.Interfaces;
using AssetRipper.SourceGenerated.MarkerInterfaces;
using AssetRipper.SourceGenerated.Subclasses.AABB;
using AssetRipper.SourceGenerated.Subclasses.AnimationClipBindingConstant;
using AssetRipper.SourceGenerated.Subclasses.AnimationEvent;
using AssetRipper.SourceGenerated.Subclasses.CompressedAnimationCurve;
using AssetRipper.SourceGenerated.Subclasses.FloatCurve;
using AssetRipper.SourceGenerated.Subclasses.MuscleClipInfo;
using AssetRipper.SourceGenerated.Subclasses.PPtrCurve;
using AssetRipper.SourceGenerated.Subclasses.PPtr_EditorExtensionImpl;
using AssetRipper.SourceGenerated.Subclasses.PPtr_EditorExtension;
using AssetRipper.SourceGenerated.Subclasses.PPtr_PrefabInstance;
using AssetRipper.SourceGenerated.Subclasses.PPtr_Prefab;
using AssetRipper.SourceGenerated.Subclasses.QuaternionCurve;
using AssetRipper.SourceGenerated.Subclasses.Utf8String;
using AssetRipper.SourceGenerated.Subclasses.Vector3Curve;
using AssetRipper.IClasses.MuscleClipConstant;

namespace AssetRipper.IClasses.AnimationClip
{
	// Token: 0x020026A0 RID: 9888

	public interface IAnimationClip_ACL : IUnityObjectBase, IUnityAssetBase, IAsset, IAssetReadable, IAssetWritable, IYamlExportable, IDependent, ITypeTreeSerializable, IAnimationClipMarker, IHasName, IHasNameString, INamedObject, INamedObjectMarker, IEditorExtension, IEditorExtensionMarker, IObject, IObjectMarker, IHasHideFlags
	{
		// Token: 0x17008B68 RID: 35688
		// (get) Token: 0x0601FAC9 RID: 129737
		// (set) Token: 0x0601FACA RID: 129738
		int AnimationType_C74 { get; set; }

		// Token: 0x17008B69 RID: 35689
		// (get) Token: 0x0601FACB RID: 129739

		IAABB Bounds_C74
		{

			get;
		}

		// Token: 0x17008B6A RID: 35690
		// (get) Token: 0x0601FACC RID: 129740
		IAnimationClipBindingConstant ClipBindingConstant_C74 { get; }

		// Token: 0x17008B6B RID: 35691
		// (get) Token: 0x0601FACD RID: 129741
		// (set) Token: 0x0601FACE RID: 129742
		bool Compressed_C74 { get; set; }

		// Token: 0x17008B6C RID: 35692
		// (get) Token: 0x0601FACF RID: 129743

		AssetList<CompressedAnimationCurve> CompressedRotationCurves_C74
		{

			get;
		}

		// Token: 0x17008B6D RID: 35693
		// (get) Token: 0x0601FAD0 RID: 129744
		IPPtr_EditorExtension CorrespondingSourceObject_C74 { get; }

		// Token: 0x17008B6E RID: 35694
		// (get) Token: 0x0601FAD1 RID: 129745

		AccessListBase<IFloatCurve> EditorCurves_C74
		{

			get;
		}

		// Token: 0x17008B6F RID: 35695
		// (get) Token: 0x0601FAD2 RID: 129746
		AccessListBase<IVector3Curve> EulerCurves_C74
		{
			get;
		}

		// Token: 0x17008B70 RID: 35696
		// (get) Token: 0x0601FAD3 RID: 129747

		AccessListBase<IFloatCurve> EulerEditorCurves_C74
		{

			get;
		}

		// Token: 0x17008B71 RID: 35697
		// (get) Token: 0x0601FAD4 RID: 129748

		AccessListBase<IAnimationEvent> Events_C74
		{

			get;
		}

		// Token: 0x17008B72 RID: 35698
		// (get) Token: 0x0601FAD5 RID: 129749
		PPtr_EditorExtensionImpl ExtensionPtr_C74 { get; }

		// Token: 0x17008B73 RID: 35699
		// (get) Token: 0x0601FAD6 RID: 129750

		AccessListBase<IFloatCurve> FloatCurves_C74
		{

			get;
		}

		// Token: 0x17008B74 RID: 35700
		// (get) Token: 0x0601FAD7 RID: 129751
		// (set) Token: 0x0601FAD8 RID: 129752
		bool GenerateMotionCurves_C74 { get; set; }

		// Token: 0x17008B75 RID: 35701
		// (get) Token: 0x0601FAD9 RID: 129753
		// (set) Token: 0x0601FADA RID: 129754
		bool HasGenericRootTransform_C74 { get; set; }

		// Token: 0x17008B76 RID: 35702
		// (get) Token: 0x0601FADB RID: 129755
		// (set) Token: 0x0601FADC RID: 129756
		bool HasMotionFloatCurves_C74 { get; set; }

		// Token: 0x17008B77 RID: 35703
		// (get) Token: 0x0601FADD RID: 129757
		// (set) Token: 0x0601FADE RID: 129758
		uint HideFlags_C74 { get; set; }

		// Token: 0x17008B78 RID: 35704
		// (get) Token: 0x0601FADF RID: 129759
		// (set) Token: 0x0601FAE0 RID: 129760
		bool IsEmpty_C74 { get; set; }

		// Token: 0x17008B79 RID: 35705
		// (get) Token: 0x0601FAE1 RID: 129761
		// (set) Token: 0x0601FAE2 RID: 129762
		bool Legacy_C74 { get; set; }

		// Token: 0x17008B7A RID: 35706
		// (get) Token: 0x0601FAE3 RID: 129763
		IMuscleClipConstant_ACL MuscleClip_C74 { get; }

		// Token: 0x17008B7B RID: 35707
		// (get) Token: 0x0601FAE4 RID: 129764
		IMuscleClipInfo MuscleClipInfo_C74 { get; }

		// Token: 0x17008B7C RID: 35708
		// (get) Token: 0x0601FAE5 RID: 129765
		// (set) Token: 0x0601FAE6 RID: 129766
		uint MuscleClipSize_C74 { get; set; }

		// Token: 0x17008B7D RID: 35709
		// (get) Token: 0x0601FAE7 RID: 129767

		Utf8String Name_C74
		{

			get;
		}

		// Token: 0x17008B7E RID: 35710
		// (get) Token: 0x0601FAE8 RID: 129768

		AccessListBase<IVector3Curve> PositionCurves_C74
		{

			get;
		}

		// Token: 0x17008B7F RID: 35711
		// (get) Token: 0x0601FAE9 RID: 129769
		AccessListBase<IPPtrCurve> PPtrCurves_C74
		{
			get;
		}

		// Token: 0x17008B80 RID: 35712
		// (get) Token: 0x0601FAEA RID: 129770
		PPtr_Prefab_2018_3_0 PrefabAsset_C74 { get; }

		// Token: 0x17008B81 RID: 35713
		// (get) Token: 0x0601FAEB RID: 129771
		PPtr_PrefabInstance PrefabInstance_C74 { get; }

		// Token: 0x17008B82 RID: 35714
		// (get) Token: 0x0601FAEC RID: 129772
		IPPtr_Prefab PrefabInternal_C74 { get; }

		// Token: 0x17008B83 RID: 35715
		// (get) Token: 0x0601FAED RID: 129773

		AccessListBase<IQuaternionCurve> RotationCurves_C74
		{

			get;
		}

		// Token: 0x17008B84 RID: 35716
		// (get) Token: 0x0601FAEE RID: 129774
		// (set) Token: 0x0601FAEF RID: 129775
		float SampleRate_C74 { get; set; }

		// Token: 0x17008B85 RID: 35717
		// (get) Token: 0x0601FAF0 RID: 129776

		AccessListBase<IVector3Curve> ScaleCurves_C74
		{

			get;
		}

		// Token: 0x17008B86 RID: 35718
		// (get) Token: 0x0601FAF1 RID: 129777
		// (set) Token: 0x0601FAF2 RID: 129778
		bool UseHighQualityCurve_C74 { get; set; }

		// Token: 0x17008B87 RID: 35719
		// (get) Token: 0x0601FAF3 RID: 129779
		// (set) Token: 0x0601FAF4 RID: 129780
		int WrapMode_C74 { get; set; }

		// Token: 0x17008B88 RID: 35720
		// (get) Token: 0x0601FAF5 RID: 129781
		// (set) Token: 0x0601FAF6 RID: 129782
		HideFlags HideFlags_C74E { get; set; }

		// Token: 0x17008B89 RID: 35721
		// (get) Token: 0x0601FAF7 RID: 129783
		// (set) Token: 0x0601FAF8 RID: 129784
		WrapMode WrapMode_C74E { get; set; }

		// Token: 0x17008B8A RID: 35722
		// (get) Token: 0x0601FAF9 RID: 129785
		// (set) Token: 0x0601FAFA RID: 129786
		IEditorExtension CorrespondingSourceObject_C74P { get; set; }

		// Token: 0x17008B8B RID: 35723
		// (get) Token: 0x0601FAFB RID: 129787
		// (set) Token: 0x0601FAFC RID: 129788
		IEditorExtensionImpl ExtensionPtr_C74P { get; set; }

		// Token: 0x17008B8C RID: 35724
		// (get) Token: 0x0601FAFD RID: 129789
		// (set) Token: 0x0601FAFE RID: 129790
		IPrefab PrefabAsset_C74P { get; set; }

		// Token: 0x17008B8D RID: 35725
		// (get) Token: 0x0601FAFF RID: 129791
		// (set) Token: 0x0601FB00 RID: 129792
		IPrefabInstance PrefabInstance_C74P { get; set; }

		// Token: 0x17008B8E RID: 35726
		// (get) Token: 0x0601FB01 RID: 129793
		// (set) Token: 0x0601FB02 RID: 129794
		IPrefabMarker PrefabInternal_C74P { get; set; }

		// Token: 0x0601FB03 RID: 129795
		[MemberNotNullWhen(true, "MuscleClipInfo_C74")]
		[MemberNotNullWhen(true, "MuscleClip_C74")]
		[MemberNotNullWhen(true, "CorrespondingSourceObject_C74")]
		[MemberNotNullWhen(true, "PrefabInternal_C74")]
		bool Has_AnimationType_C74();

		// Token: 0x0601FB04 RID: 129796
		[MemberNotNullWhen(true, "CorrespondingSourceObject_C74")]
		[MemberNotNullWhen(true, "MuscleClip_C74")]
		[MemberNotNullWhen(true, "MuscleClipInfo_C74")]
		[MemberNotNullWhen(true, "PPtrCurves_C74")]
		[MemberNotNullWhen(true, "ClipBindingConstant_C74")]
		bool Has_ClipBindingConstant_C74();

		// Token: 0x0601FB05 RID: 129797
		[MemberNotNullWhen(false, "ExtensionPtr_C74")]
		[MemberNotNullWhen(true, "CorrespondingSourceObject_C74")]
		bool Has_CorrespondingSourceObject_C74();

		// Token: 0x0601FB06 RID: 129798
		[MemberNotNullWhen(true, "PPtrCurves_C74")]
		[MemberNotNullWhen(true, "MuscleClipInfo_C74")]
		[MemberNotNullWhen(true, "MuscleClip_C74")]
		[MemberNotNullWhen(true, "EulerCurves_C74")]
		[MemberNotNullWhen(true, "CorrespondingSourceObject_C74")]
		[MemberNotNullWhen(true, "ClipBindingConstant_C74")]
		bool Has_EulerCurves_C74();

		// Token: 0x0601FB07 RID: 129799
		[MemberNotNullWhen(false, "CorrespondingSourceObject_C74")]
		[MemberNotNullWhen(true, "ExtensionPtr_C74")]
		bool Has_ExtensionPtr_C74();

		// Token: 0x0601FB08 RID: 129800
		[MemberNotNullWhen(true, "MuscleClip_C74")]
		[MemberNotNullWhen(true, "MuscleClipInfo_C74")]
		[MemberNotNullWhen(true, "PPtrCurves_C74")]
		[MemberNotNullWhen(true, "ClipBindingConstant_C74")]
		[MemberNotNullWhen(true, "PrefabInternal_C74")]
		[MemberNotNullWhen(true, "CorrespondingSourceObject_C74")]
		bool Has_GenerateMotionCurves_C74();

		// Token: 0x0601FB09 RID: 129801
		[MemberNotNullWhen(true, "ClipBindingConstant_C74")]
		[MemberNotNullWhen(true, "CorrespondingSourceObject_C74")]
		[MemberNotNullWhen(true, "MuscleClip_C74")]
		[MemberNotNullWhen(true, "PPtrCurves_C74")]
		[MemberNotNullWhen(true, "MuscleClipInfo_C74")]
		bool Has_HasGenericRootTransform_C74();

		// Token: 0x0601FB0A RID: 129802
		[MemberNotNullWhen(true, "ClipBindingConstant_C74")]
		[MemberNotNullWhen(true, "MuscleClipInfo_C74")]
		[MemberNotNullWhen(true, "PPtrCurves_C74")]
		[MemberNotNullWhen(true, "CorrespondingSourceObject_C74")]
		[MemberNotNullWhen(true, "MuscleClip_C74")]
		bool Has_HasMotionFloatCurves_C74();

		// Token: 0x0601FB0B RID: 129803
		[MemberNotNullWhen(true, "ClipBindingConstant_C74")]
		[MemberNotNullWhen(true, "CorrespondingSourceObject_C74")]
		[MemberNotNullWhen(true, "EulerCurves_C74")]
		[MemberNotNullWhen(true, "MuscleClip_C74")]
		[MemberNotNullWhen(true, "MuscleClipInfo_C74")]
		[MemberNotNullWhen(true, "PPtrCurves_C74")]
		[MemberNotNullWhen(true, "PrefabInternal_C74")]
		bool Has_IsEmpty_C74();

		// Token: 0x0601FB0C RID: 129804
		[MemberNotNullWhen(true, "PPtrCurves_C74")]
		[MemberNotNullWhen(true, "MuscleClip_C74")]
		[MemberNotNullWhen(true, "CorrespondingSourceObject_C74")]
		[MemberNotNullWhen(true, "MuscleClipInfo_C74")]
		[MemberNotNullWhen(true, "ClipBindingConstant_C74")]
		bool Has_Legacy_C74();

		// Token: 0x0601FB0D RID: 129805
		[MemberNotNullWhen(true, "CorrespondingSourceObject_C74")]
		[MemberNotNullWhen(true, "MuscleClip_C74")]
		[MemberNotNullWhen(true, "MuscleClipInfo_C74")]
		bool Has_MuscleClip_C74();

		// Token: 0x0601FB0E RID: 129806
		[MemberNotNullWhen(true, "MuscleClip_C74")]
		[MemberNotNullWhen(true, "MuscleClipInfo_C74")]
		[MemberNotNullWhen(true, "CorrespondingSourceObject_C74")]
		bool Has_MuscleClipInfo_C74();

		// Token: 0x0601FB0F RID: 129807
		[MemberNotNullWhen(true, "CorrespondingSourceObject_C74")]
		[MemberNotNullWhen(true, "MuscleClipInfo_C74")]
		[MemberNotNullWhen(true, "MuscleClip_C74")]
		bool Has_MuscleClipSize_C74();

		// Token: 0x0601FB10 RID: 129808
		[MemberNotNullWhen(true, "ClipBindingConstant_C74")]
		[MemberNotNullWhen(true, "CorrespondingSourceObject_C74")]
		[MemberNotNullWhen(true, "MuscleClip_C74")]
		[MemberNotNullWhen(true, "PPtrCurves_C74")]
		[MemberNotNullWhen(true, "MuscleClipInfo_C74")]
		bool Has_PPtrCurves_C74();

		// Token: 0x0601FB11 RID: 129809
		[MemberNotNullWhen(true, "CorrespondingSourceObject_C74")]
		[MemberNotNullWhen(true, "EulerCurves_C74")]
		[MemberNotNullWhen(true, "MuscleClip_C74")]
		[MemberNotNullWhen(true, "PPtrCurves_C74")]
		[MemberNotNullWhen(true, "PrefabAsset_C74")]
		[MemberNotNullWhen(true, "PrefabInstance_C74")]
		[MemberNotNullWhen(true, "ClipBindingConstant_C74")]
		[MemberNotNullWhen(true, "MuscleClipInfo_C74")]
		bool Has_PrefabAsset_C74();

		// Token: 0x0601FB12 RID: 129810
		[MemberNotNullWhen(true, "MuscleClip_C74")]
		[MemberNotNullWhen(true, "ClipBindingConstant_C74")]
		[MemberNotNullWhen(true, "PPtrCurves_C74")]
		[MemberNotNullWhen(true, "CorrespondingSourceObject_C74")]
		[MemberNotNullWhen(true, "MuscleClipInfo_C74")]
		[MemberNotNullWhen(true, "PrefabInstance_C74")]
		[MemberNotNullWhen(true, "EulerCurves_C74")]
		[MemberNotNullWhen(true, "PrefabAsset_C74")]
		bool Has_PrefabInstance_C74();

		// Token: 0x0601FB13 RID: 129811
		[MemberNotNullWhen(true, "CorrespondingSourceObject_C74")]
		[MemberNotNullWhen(true, "PrefabInternal_C74")]
		bool Has_PrefabInternal_C74();

		// Token: 0x0601FB14 RID: 129812
		[MemberNotNullWhen(true, "CorrespondingSourceObject_C74")]
		[MemberNotNullWhen(true, "MuscleClip_C74")]
		[MemberNotNullWhen(true, "MuscleClipInfo_C74")]
		[MemberNotNullWhen(true, "PPtrCurves_C74")]
		[MemberNotNullWhen(true, "ClipBindingConstant_C74")]
		bool Has_UseHighQualityCurve_C74();

		// Token: 0x0601FB15 RID: 129813

		void CopyValues(IAnimationClip_ACL source, PPtrConverter converter);

		// Token: 0x0601FB16 RID: 129814

		void CopyValues(IAnimationClip_ACL source);
	}
}
