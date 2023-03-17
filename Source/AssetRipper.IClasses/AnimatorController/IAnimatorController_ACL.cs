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
using AssetRipper.SourceGenerated.Classes.ClassID_114;
using AssetRipper.SourceGenerated.Classes.ClassID_130;
using AssetRipper.SourceGenerated.Classes.ClassID_18;
using AssetRipper.SourceGenerated.Classes.ClassID_74;
using AssetRipper.SourceGenerated.Enums;
using AssetRipper.SourceGenerated.Interfaces;
using AssetRipper.SourceGenerated.MarkerInterfaces;
using AssetRipper.SourceGenerated.Subclasses.AnimatorControllerLayer;
using AssetRipper.SourceGenerated.Subclasses.AnimatorControllerParameter;
using AssetRipper.SourceGenerated.Subclasses.ControllerConstant;
using AssetRipper.SourceGenerated.Subclasses.PPtr_AnimationClip;
using AssetRipper.SourceGenerated.Subclasses.PPtr_EditorExtension;
using AssetRipper.SourceGenerated.Subclasses.PPtr_MonoBehaviour;
using AssetRipper.SourceGenerated.Subclasses.PPtr_PrefabInstance;
using AssetRipper.SourceGenerated.Subclasses.PPtr_Prefab;
using AssetRipper.SourceGenerated.Subclasses.StateMachineBehaviourVectorDescription;
using AssetRipper.SourceGenerated.Subclasses.Utf8String;
using AssetRipper.IClasses.AnimationClip;
using AssetRipper.IClasses.PPtr_AnimationClip;

namespace AssetRipper.IClasses.IAnimatorController
{
	// Token: 0x020025AE RID: 9646

	public interface IAnimatorController_ACL : IUnityObjectBase, IUnityAssetBase, IAsset, IAssetReadable, IAssetWritable, IYamlExportable, IDependent, ITypeTreeSerializable, IAnimatorControllerMarker, IHasName, IHasNameString, INamedObject, INamedObjectMarker, IEditorExtension, IEditorExtensionMarker, IObject, IObjectMarker, IHasHideFlags
	{
		// Token: 0x17006D3D RID: 27965
		// (get) Token: 0x0601B0A1 RID: 110753

		AccessListBase<IPPtr_AnimationClip_ACL> AnimationClips_C91
		{

			get;
		}

		// Token: 0x17006D3E RID: 27966
		// (get) Token: 0x0601B0A2 RID: 110754

		AccessListBase<IAnimatorControllerLayer> AnimatorLayers_C91
		{

			get;
		}

		// Token: 0x17006D3F RID: 27967
		// (get) Token: 0x0601B0A3 RID: 110755

		AccessListBase<IAnimatorControllerParameter> AnimatorParameters_C91
		{

			get;
		}

		// Token: 0x17006D40 RID: 27968
		// (get) Token: 0x0601B0A4 RID: 110756

		IControllerConstant Controller_C91
		{

			get;
		}

		// Token: 0x17006D41 RID: 27969
		// (get) Token: 0x0601B0A5 RID: 110757
		// (set) Token: 0x0601B0A6 RID: 110758
		uint ControllerSize_C91 { get; set; }

		// Token: 0x17006D42 RID: 27970
		// (get) Token: 0x0601B0A7 RID: 110759

		IPPtr_EditorExtension CorrespondingSourceObject_C91
		{

			get;
		}

		// Token: 0x17006D43 RID: 27971
		// (get) Token: 0x0601B0A8 RID: 110760
		// (set) Token: 0x0601B0A9 RID: 110761
		uint HideFlags_C91 { get; set; }

		// Token: 0x17006D44 RID: 27972
		// (get) Token: 0x0601B0AA RID: 110762
		// (set) Token: 0x0601B0AB RID: 110763
		bool MultiThreadedStateMachine_C91 { get; set; }

		// Token: 0x17006D45 RID: 27973
		// (get) Token: 0x0601B0AC RID: 110764

		Utf8String Name_C91
		{

			get;
		}

		// Token: 0x17006D46 RID: 27974
		// (get) Token: 0x0601B0AD RID: 110765
		PPtr_Prefab_2018_3_0 PrefabAsset_C91 { get; }

		// Token: 0x17006D47 RID: 27975
		// (get) Token: 0x0601B0AE RID: 110766
		PPtr_PrefabInstance PrefabInstance_C91 { get; }

		// Token: 0x17006D48 RID: 27976
		// (get) Token: 0x0601B0AF RID: 110767
		IPPtr_Prefab PrefabInternal_C91 { get; }

		// Token: 0x17006D49 RID: 27977
		// (get) Token: 0x0601B0B0 RID: 110768
		AssetList<PPtr_MonoBehaviour_5_0_0> StateMachineBehaviours_C91
		{
			get;
		}

		// Token: 0x17006D4A RID: 27978
		// (get) Token: 0x0601B0B1 RID: 110769
		IStateMachineBehaviourVectorDescription StateMachineBehaviourVectorDescription_C91 { get; }

		// Token: 0x17006D4B RID: 27979
		// (get) Token: 0x0601B0B2 RID: 110770

		AssetDictionary<uint, Utf8String> TOS_C91
		{

			get;
		}

		// Token: 0x17006D4C RID: 27980
		// (get) Token: 0x0601B0B3 RID: 110771
		// (set) Token: 0x0601B0B4 RID: 110772
		HideFlags HideFlags_C91E { get; set; }

		// Token: 0x17006D4D RID: 27981
		// (get) Token: 0x0601B0B5 RID: 110773
		PPtrAccessList<IPPtr_AnimationClip_ACL, IAnimationClip_ACL> AnimationClips_C91P
		{
			get;
		}

		// Token: 0x17006D4E RID: 27982
		// (get) Token: 0x0601B0B6 RID: 110774
		// (set) Token: 0x0601B0B7 RID: 110775
		IEditorExtension CorrespondingSourceObject_C91P { get; set; }

		// Token: 0x17006D4F RID: 27983
		// (get) Token: 0x0601B0B8 RID: 110776
		// (set) Token: 0x0601B0B9 RID: 110777
		IPrefab PrefabAsset_C91P { get; set; }

		// Token: 0x17006D50 RID: 27984
		// (get) Token: 0x0601B0BA RID: 110778
		// (set) Token: 0x0601B0BB RID: 110779
		IPrefabInstance PrefabInstance_C91P { get; set; }

		// Token: 0x17006D51 RID: 27985
		// (get) Token: 0x0601B0BC RID: 110780
		// (set) Token: 0x0601B0BD RID: 110781
		IPrefabMarker PrefabInternal_C91P { get; set; }

		// Token: 0x17006D52 RID: 27986
		// (get) Token: 0x0601B0BE RID: 110782
		PPtrAccessList<PPtr_MonoBehaviour_5_0_0, IMonoBehaviour> StateMachineBehaviours_C91P
		{
			get;
		}

		// Token: 0x0601B0BF RID: 110783
		[MemberNotNullWhen(true, "StateMachineBehaviourVectorDescription_C91")]
		[MemberNotNullWhen(true, "StateMachineBehaviours_C91")]
		[MemberNotNullWhen(false, "PrefabInternal_C91")]
		bool Has_MultiThreadedStateMachine_C91();

		// Token: 0x0601B0C0 RID: 110784
		[MemberNotNullWhen(true, "StateMachineBehaviourVectorDescription_C91")]
		[MemberNotNullWhen(true, "PrefabAsset_C91")]
		[MemberNotNullWhen(false, "PrefabInternal_C91")]
		[MemberNotNullWhen(true, "StateMachineBehaviours_C91")]
		[MemberNotNullWhen(true, "PrefabInstance_C91")]
		bool Has_PrefabAsset_C91();

		// Token: 0x0601B0C1 RID: 110785
		[MemberNotNullWhen(true, "PrefabAsset_C91")]
		[MemberNotNullWhen(true, "PrefabInstance_C91")]
		[MemberNotNullWhen(false, "PrefabInternal_C91")]
		[MemberNotNullWhen(true, "StateMachineBehaviours_C91")]
		[MemberNotNullWhen(true, "StateMachineBehaviourVectorDescription_C91")]
		bool Has_PrefabInstance_C91();

		// Token: 0x0601B0C2 RID: 110786
		[MemberNotNullWhen(false, "StateMachineBehaviourVectorDescription_C91")]
		[MemberNotNullWhen(false, "StateMachineBehaviours_C91")]
		[MemberNotNullWhen(false, "PrefabInstance_C91")]
		[MemberNotNullWhen(false, "PrefabAsset_C91")]
		[MemberNotNullWhen(true, "PrefabInternal_C91")]
		bool Has_PrefabInternal_C91();

		// Token: 0x0601B0C3 RID: 110787
		[MemberNotNullWhen(true, "StateMachineBehaviours_C91")]
		[MemberNotNullWhen(true, "StateMachineBehaviourVectorDescription_C91")]
		[MemberNotNullWhen(false, "PrefabInternal_C91")]
		bool Has_StateMachineBehaviours_C91();

		// Token: 0x0601B0C4 RID: 110788
		[MemberNotNullWhen(false, "PrefabInternal_C91")]
		[MemberNotNullWhen(true, "StateMachineBehaviours_C91")]
		[MemberNotNullWhen(true, "StateMachineBehaviourVectorDescription_C91")]
		bool Has_StateMachineBehaviourVectorDescription_C91();

		// Token: 0x0601B0C5 RID: 110789

		void CopyValues(IAnimatorController_ACL source, PPtrConverter converter);

		// Token: 0x0601B0C6 RID: 110790

		void CopyValues(IAnimatorController_ACL source);
	}
}
