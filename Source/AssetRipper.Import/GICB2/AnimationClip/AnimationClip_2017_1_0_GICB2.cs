using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using AssetRipper.Assets;
using AssetRipper.Assets.Cloning;
using AssetRipper.Assets.Export;
using AssetRipper.Assets.Export.Dependencies;
using AssetRipper.Assets.Export.Yaml;
using AssetRipper.Assets.Generics;
using AssetRipper.Assets.Interfaces;
using AssetRipper.Assets.IO;
using AssetRipper.Assets.IO.Reading;
using AssetRipper.Assets.IO.Writing;
using AssetRipper.Assets.Metadata;
using AssetRipper.IO.Files.SerializedFiles.Parser.TypeTrees;
using AssetRipper.SourceGenerated.Classes.ClassID_0;
using AssetRipper.SourceGenerated.Classes.ClassID_1001;
using AssetRipper.SourceGenerated.Classes.ClassID_1001480554;
using AssetRipper.SourceGenerated.Classes.ClassID_1002;
using AssetRipper.SourceGenerated.Classes.ClassID_130;
using AssetRipper.SourceGenerated.Classes.ClassID_18;
using AssetRipper.SourceGenerated.Classes.ClassID_207;
using AssetRipper.SourceGenerated.Enums;
using AssetRipper.SourceGenerated.Helpers;
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
using AssetRipper.Yaml;
using AssetRipper.IClasses.MuscleClipConstant;
using AssetRipper.IClasses.AnimationClip;

namespace AssetRipper.Import.GICB2.AnimationClip
{
	// Token: 0x0200268B RID: 9867

	public class AnimationClip_2017_1_0_GICB2 : Motion_5_0_0, IAnimationClip_ACL, IUnityObjectBase, IUnityAssetBase, IAsset, IAssetReadable, IAssetWritable, IYamlExportable, IDependent, ITypeTreeSerializable, IAnimationClipMarker, IHasName, IHasNameString, INamedObject, INamedObjectMarker, IEditorExtension, IEditorExtensionMarker, IObject, IObjectMarker, IHasHideFlags
	{
		// Token: 0x17008820 RID: 34848
		// (get) Token: 0x0601F33D RID: 127805 RVA: 0x004B22A0 File Offset: 0x004B04A0
		// (set) Token: 0x0601F33E RID: 127806 RVA: 0x004B22A3 File Offset: 0x004B04A3
		public int AnimationType_C74
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x17008821 RID: 34849
		// (get) Token: 0x0601F33F RID: 127807 RVA: 0x004B22A5 File Offset: 0x004B04A5
		public IAABB Bounds_C74
		{
			get
			{
				return this.m_Bounds;
			}
		}

		// Token: 0x17008822 RID: 34850
		// (get) Token: 0x0601F340 RID: 127808 RVA: 0x004B22AD File Offset: 0x004B04AD

		public IAnimationClipBindingConstant ClipBindingConstant_C74
		{

			[return: NotNull]
			get
			{
				return this.m_ClipBindingConstant;
			}
		}

		// Token: 0x17008823 RID: 34851
		// (get) Token: 0x0601F341 RID: 127809 RVA: 0x004B22B5 File Offset: 0x004B04B5
		// (set) Token: 0x0601F342 RID: 127810 RVA: 0x004B22BD File Offset: 0x004B04BD
		public bool Compressed_C74
		{
			get
			{
				return this.m_Compressed;
			}
			set
			{
				this.m_Compressed = value;
			}
		}

		// Token: 0x17008824 RID: 34852
		// (get) Token: 0x0601F343 RID: 127811 RVA: 0x004B22C6 File Offset: 0x004B04C6
		public AssetList<CompressedAnimationCurve> CompressedRotationCurves_C74
		{
			get
			{
				return this.m_CompressedRotationCurves;
			}
		}

		// Token: 0x17008825 RID: 34853
		// (get) Token: 0x0601F344 RID: 127812 RVA: 0x004B22CE File Offset: 0x004B04CE

		public IPPtr_EditorExtension CorrespondingSourceObject_C74
		{

			[return: NotNull]
			get
			{
				return this.m_CorrespondingSourceObject;
			}
		}

		// Token: 0x17008826 RID: 34854
		// (get) Token: 0x0601F345 RID: 127813 RVA: 0x004B22D6 File Offset: 0x004B04D6
		public AccessListBase<IFloatCurve> EditorCurves_C74
		{
			get
			{
				return new AccessList<FloatCurve_2017_1_0, IFloatCurve>(this.m_EditorCurves);
			}
		}

		// Token: 0x17008827 RID: 34855
		// (get) Token: 0x0601F346 RID: 127814 RVA: 0x004B22E3 File Offset: 0x004B04E3

		public AccessListBase<IVector3Curve> EulerCurves_C74
		{

			[return: NotNull]
			get
			{
				return new AccessList<Vector3Curve_2017_1_0, IVector3Curve>(this.m_EulerCurves);
			}
		}

		// Token: 0x17008828 RID: 34856
		// (get) Token: 0x0601F347 RID: 127815 RVA: 0x004B22F0 File Offset: 0x004B04F0
		public AccessListBase<IFloatCurve> EulerEditorCurves_C74
		{
			get
			{
				return new AccessList<FloatCurve_2017_1_0, IFloatCurve>(this.m_EulerEditorCurves);
			}
		}

		// Token: 0x17008829 RID: 34857
		// (get) Token: 0x0601F348 RID: 127816 RVA: 0x004B22FD File Offset: 0x004B04FD
		public AccessListBase<IAnimationEvent> Events_C74
		{
			get
			{
				return new AccessList<AnimationEvent_5_0_0, IAnimationEvent>(this.m_Events);
			}
		}

		// Token: 0x1700882A RID: 34858
		// (get) Token: 0x0601F349 RID: 127817 RVA: 0x004B230A File Offset: 0x004B050A

		public PPtr_EditorExtensionImpl ExtensionPtr_C74
		{

			get
			{
				return null;
			}
		}

		// Token: 0x1700882B RID: 34859
		// (get) Token: 0x0601F34A RID: 127818 RVA: 0x004B230D File Offset: 0x004B050D
		public AccessListBase<IFloatCurve> FloatCurves_C74
		{
			get
			{
				return new AccessList<FloatCurve_2017_1_0, IFloatCurve>(this.m_FloatCurves);
			}
		}

		// Token: 0x1700882C RID: 34860
		// (get) Token: 0x0601F34B RID: 127819 RVA: 0x004B231A File Offset: 0x004B051A
		// (set) Token: 0x0601F34C RID: 127820 RVA: 0x004B2322 File Offset: 0x004B0522
		public bool GenerateMotionCurves_C74
		{
			get
			{
				return this.m_GenerateMotionCurves;
			}
			set
			{
				this.m_GenerateMotionCurves = value;
			}
		}

		// Token: 0x1700882D RID: 34861
		// (get) Token: 0x0601F34D RID: 127821 RVA: 0x004B232B File Offset: 0x004B052B
		// (set) Token: 0x0601F34E RID: 127822 RVA: 0x004B2333 File Offset: 0x004B0533
		public bool HasGenericRootTransform_C74
		{
			get
			{
				return this.m_HasGenericRootTransform;
			}
			set
			{
				this.m_HasGenericRootTransform = value;
			}
		}

		// Token: 0x1700882E RID: 34862
		// (get) Token: 0x0601F34F RID: 127823 RVA: 0x004B233C File Offset: 0x004B053C
		// (set) Token: 0x0601F350 RID: 127824 RVA: 0x004B2344 File Offset: 0x004B0544
		public bool HasMotionFloatCurves_C74
		{
			get
			{
				return this.m_HasMotionFloatCurves;
			}
			set
			{
				this.m_HasMotionFloatCurves = value;
			}
		}

		// Token: 0x1700882F RID: 34863
		// (get) Token: 0x0601F351 RID: 127825 RVA: 0x004B234D File Offset: 0x004B054D
		// (set) Token: 0x0601F352 RID: 127826 RVA: 0x004B2355 File Offset: 0x004B0555
		public uint HideFlags_C74
		{
			get
			{
				return this.m_HideFlags;
			}
			set
			{
				this.m_HideFlags = value;
			}
		}

		// Token: 0x17008830 RID: 34864
		// (get) Token: 0x0601F353 RID: 127827 RVA: 0x004B235E File Offset: 0x004B055E
		// (set) Token: 0x0601F354 RID: 127828 RVA: 0x004B2361 File Offset: 0x004B0561
		public bool IsEmpty_C74
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17008831 RID: 34865
		// (get) Token: 0x0601F355 RID: 127829 RVA: 0x004B2363 File Offset: 0x004B0563
		// (set) Token: 0x0601F356 RID: 127830 RVA: 0x004B236B File Offset: 0x004B056B
		public bool Legacy_C74
		{
			get
			{
				return this.m_Legacy;
			}
			set
			{
				this.m_Legacy = value;
			}
		}

		// Token: 0x17008832 RID: 34866
		// (get) Token: 0x0601F357 RID: 127831 RVA: 0x004B2374 File Offset: 0x004B0574

		public IMuscleClipConstant_ACL MuscleClip_C74
		{
			get
			{
				return this.m_MuscleClip;
			}
		}

		// Token: 0x17008833 RID: 34867
		// (get) Token: 0x0601F358 RID: 127832 RVA: 0x004B237C File Offset: 0x004B057C

		public IMuscleClipInfo MuscleClipInfo_C74
		{

			[return: NotNull]
			get
			{
				return this.m_MuscleClipInfo;
			}
		}

		// Token: 0x17008834 RID: 34868
		// (get) Token: 0x0601F359 RID: 127833 RVA: 0x004B2384 File Offset: 0x004B0584
		// (set) Token: 0x0601F35A RID: 127834 RVA: 0x004B238C File Offset: 0x004B058C
		public uint MuscleClipSize_C74
		{
			get
			{
				return this.m_MuscleClipSize;
			}
			set
			{
				this.m_MuscleClipSize = value;
			}
		}

		// Token: 0x17008835 RID: 34869
		// (get) Token: 0x0601F35B RID: 127835 RVA: 0x004B2395 File Offset: 0x004B0595
		public Utf8String Name_C74
		{
			get
			{
				return this.m_Name;
			}
		}

		// Token: 0x17008836 RID: 34870
		// (get) Token: 0x0601F35C RID: 127836 RVA: 0x004B239D File Offset: 0x004B059D
		public AccessListBase<IVector3Curve> PositionCurves_C74
		{
			get
			{
				return new AccessList<Vector3Curve_2017_1_0, IVector3Curve>(this.m_PositionCurves);
			}
		}

		// Token: 0x17008837 RID: 34871
		// (get) Token: 0x0601F35D RID: 127837 RVA: 0x004B23AA File Offset: 0x004B05AA

		public AccessListBase<IPPtrCurve> PPtrCurves_C74
		{

			[return: NotNull]
			get
			{
				return new AccessList<PPtrCurve_2017_1_0, IPPtrCurve>(this.m_PPtrCurves);
			}
		}

		// Token: 0x17008838 RID: 34872
		// (get) Token: 0x0601F35E RID: 127838 RVA: 0x004B23B7 File Offset: 0x004B05B7

		public PPtr_Prefab_2018_3_0 PrefabAsset_C74
		{

			get
			{
				return null;
			}
		}

		// Token: 0x17008839 RID: 34873
		// (get) Token: 0x0601F35F RID: 127839 RVA: 0x004B23BA File Offset: 0x004B05BA

		public PPtr_PrefabInstance PrefabInstance_C74
		{

			get
			{
				return null;
			}
		}

		// Token: 0x1700883A RID: 34874
		// (get) Token: 0x0601F360 RID: 127840 RVA: 0x004B23BD File Offset: 0x004B05BD

		public IPPtr_Prefab PrefabInternal_C74
		{

			[return: NotNull]
			get
			{
				return this.m_PrefabInternal;
			}
		}

		// Token: 0x1700883B RID: 34875
		// (get) Token: 0x0601F361 RID: 127841 RVA: 0x004B23C5 File Offset: 0x004B05C5
		public AccessListBase<IQuaternionCurve> RotationCurves_C74
		{
			get
			{
				return new AccessList<QuaternionCurve_2017_1_0, IQuaternionCurve>(this.m_RotationCurves);
			}
		}

		// Token: 0x1700883C RID: 34876
		// (get) Token: 0x0601F362 RID: 127842 RVA: 0x004B23D2 File Offset: 0x004B05D2
		// (set) Token: 0x0601F363 RID: 127843 RVA: 0x004B23DA File Offset: 0x004B05DA
		public float SampleRate_C74
		{
			get
			{
				return this.m_SampleRate;
			}
			set
			{
				this.m_SampleRate = value;
			}
		}

		// Token: 0x1700883D RID: 34877
		// (get) Token: 0x0601F364 RID: 127844 RVA: 0x004B23E3 File Offset: 0x004B05E3
		public AccessListBase<IVector3Curve> ScaleCurves_C74
		{
			get
			{
				return new AccessList<Vector3Curve_2017_1_0, IVector3Curve>(this.m_ScaleCurves);
			}
		}

		// Token: 0x1700883E RID: 34878
		// (get) Token: 0x0601F365 RID: 127845 RVA: 0x004B23F0 File Offset: 0x004B05F0
		// (set) Token: 0x0601F366 RID: 127846 RVA: 0x004B23F8 File Offset: 0x004B05F8
		public bool UseHighQualityCurve_C74
		{
			get
			{
				return this.m_UseHighQualityCurve;
			}
			set
			{
				this.m_UseHighQualityCurve = value;
			}
		}

		// Token: 0x1700883F RID: 34879
		// (get) Token: 0x0601F367 RID: 127847 RVA: 0x004B2401 File Offset: 0x004B0601
		// (set) Token: 0x0601F368 RID: 127848 RVA: 0x004B2409 File Offset: 0x004B0609
		public int WrapMode_C74
		{
			get
			{
				return this.m_WrapMode;
			}
			set
			{
				this.m_WrapMode = value;
			}
		}

		// Token: 0x17008840 RID: 34880
		// (get) Token: 0x0601F369 RID: 127849 RVA: 0x004B2412 File Offset: 0x004B0612
		// (set) Token: 0x0601F36A RID: 127850 RVA: 0x004B241A File Offset: 0x004B061A
		public HideFlags HideFlags_C74E
		{
			get
			{
				return (HideFlags)this.m_HideFlags;
			}
			set
			{
				this.m_HideFlags = (uint)value;
			}
		}

		// Token: 0x17008841 RID: 34881
		// (get) Token: 0x0601F36B RID: 127851 RVA: 0x004B2423 File Offset: 0x004B0623
		// (set) Token: 0x0601F36C RID: 127852 RVA: 0x004B242B File Offset: 0x004B062B
		public WrapMode WrapMode_C74E
		{
			get
			{
				return (WrapMode)this.m_WrapMode;
			}
			set
			{
				this.m_WrapMode = (int)value;
			}
		}

		// Token: 0x17008842 RID: 34882
		// (get) Token: 0x0601F36D RID: 127853 RVA: 0x004B2434 File Offset: 0x004B0634
		// (set) Token: 0x0601F36E RID: 127854 RVA: 0x004B2447 File Offset: 0x004B0647

		public IEditorExtension CorrespondingSourceObject_C74P
		{

			get
			{
				return PPtrExtensions.TryGetAsset<IEditorExtension>(this.CorrespondingSourceObject_C74, base.Collection);
			}

			set
			{
				PPtrExtensions.SetAsset<IEditorExtension>(this.CorrespondingSourceObject_C74, base.Collection, value);
			}
		}

		// Token: 0x17008843 RID: 34883
		// (get) Token: 0x0601F36F RID: 127855 RVA: 0x004B245B File Offset: 0x004B065B
		// (set) Token: 0x0601F370 RID: 127856 RVA: 0x004B245E File Offset: 0x004B065E

		public IEditorExtensionImpl ExtensionPtr_C74P
		{

			get
			{
				return null;
			}

			set
			{
			}
		}

		// Token: 0x17008844 RID: 34884
		// (get) Token: 0x0601F371 RID: 127857 RVA: 0x004B2460 File Offset: 0x004B0660
		// (set) Token: 0x0601F372 RID: 127858 RVA: 0x004B2463 File Offset: 0x004B0663

		public IPrefab PrefabAsset_C74P
		{

			get
			{
				return null;
			}

			set
			{
			}
		}

		// Token: 0x17008845 RID: 34885
		// (get) Token: 0x0601F373 RID: 127859 RVA: 0x004B2465 File Offset: 0x004B0665
		// (set) Token: 0x0601F374 RID: 127860 RVA: 0x004B2468 File Offset: 0x004B0668

		public IPrefabInstance PrefabInstance_C74P
		{

			get
			{
				return null;
			}

			set
			{
			}
		}

		// Token: 0x17008846 RID: 34886
		// (get) Token: 0x0601F375 RID: 127861 RVA: 0x004B246A File Offset: 0x004B066A
		// (set) Token: 0x0601F376 RID: 127862 RVA: 0x004B247D File Offset: 0x004B067D

		public IPrefabMarker PrefabInternal_C74P
		{

			get
			{
				return PPtrExtensions.TryGetAsset<IPrefabMarker>(this.PrefabInternal_C74, base.Collection);
			}

			set
			{
				PPtrExtensions.SetAsset<IPrefabMarker>(this.PrefabInternal_C74, base.Collection, value);
			}
		}

		// Token: 0x17008847 RID: 34887
		// (get) Token: 0x0601F377 RID: 127863 RVA: 0x004B2491 File Offset: 0x004B0691
		public override string ClassName
		{
			get
			{
				return "AnimationClip";
			}
		}

		// Token: 0x0601F378 RID: 127864 RVA: 0x004B2498 File Offset: 0x004B0698
		public AnimationClip_2017_1_0_GICB2()
			: this(AssetInfo.MakeDummyAssetInfo(74))
		{
		}

		// Token: 0x0601F379 RID: 127865 RVA: 0x004B24A8 File Offset: 0x004B06A8
		public AnimationClip_2017_1_0_GICB2(AssetInfo info)
			: base(info)
		{
			this.m_MuscleClip = new MuscleClipConstant_5_6_0_ACL();
			this.m_MuscleClipInfo = new MuscleClipInfo_5_3_0();
			this.m_EditorCurves = new AssetList<FloatCurve_2017_1_0>();
			this.m_EulerEditorCurves = new AssetList<FloatCurve_2017_1_0>();
			this.m_RotationCurves = new AssetList<QuaternionCurve_2017_1_0>();
			this.m_CompressedRotationCurves = new AssetList<CompressedAnimationCurve>();
			this.m_EulerCurves = new AssetList<Vector3Curve_2017_1_0>();
			this.m_PositionCurves = new AssetList<Vector3Curve_2017_1_0>();
			this.m_ScaleCurves = new AssetList<Vector3Curve_2017_1_0>();
			this.m_FloatCurves = new AssetList<FloatCurve_2017_1_0>();
			this.m_PPtrCurves = new AssetList<PPtrCurve_2017_1_0>();
			this.m_Bounds = new AABB_3_5_0();
			this.m_ClipBindingConstant = new AnimationClipBindingConstant_2017_1_0();
			this.m_Events = new AssetList<AnimationEvent_5_0_0>();
		}

		// Token: 0x0601F37A RID: 127866 RVA: 0x004B2556 File Offset: 0x004B0756
		public bool Has_AnimationType_C74()
		{
			return false;
		}

		// Token: 0x0601F37B RID: 127867 RVA: 0x004B2559 File Offset: 0x004B0759
		public bool Has_ClipBindingConstant_C74()
		{
			return true;
		}

		// Token: 0x0601F37C RID: 127868 RVA: 0x004B255C File Offset: 0x004B075C
		public bool Has_CorrespondingSourceObject_C74()
		{
			return true;
		}

		// Token: 0x0601F37D RID: 127869 RVA: 0x004B255F File Offset: 0x004B075F
		public bool Has_EulerCurves_C74()
		{
			return true;
		}

		// Token: 0x0601F37E RID: 127870 RVA: 0x004B2562 File Offset: 0x004B0762
		public bool Has_ExtensionPtr_C74()
		{
			return false;
		}

		// Token: 0x0601F37F RID: 127871 RVA: 0x004B2565 File Offset: 0x004B0765
		public bool Has_GenerateMotionCurves_C74()
		{
			return true;
		}

		// Token: 0x0601F380 RID: 127872 RVA: 0x004B2568 File Offset: 0x004B0768
		public bool Has_HasGenericRootTransform_C74()
		{
			return true;
		}

		// Token: 0x0601F381 RID: 127873 RVA: 0x004B256B File Offset: 0x004B076B
		public bool Has_HasMotionFloatCurves_C74()
		{
			return true;
		}

		// Token: 0x0601F382 RID: 127874 RVA: 0x004B256E File Offset: 0x004B076E
		public bool Has_IsEmpty_C74()
		{
			return false;
		}

		// Token: 0x0601F383 RID: 127875 RVA: 0x004B2571 File Offset: 0x004B0771
		public bool Has_Legacy_C74()
		{
			return true;
		}

		// Token: 0x0601F384 RID: 127876 RVA: 0x004B2574 File Offset: 0x004B0774
		public bool Has_MuscleClip_C74()
		{
			return true;
		}

		// Token: 0x0601F385 RID: 127877 RVA: 0x004B2577 File Offset: 0x004B0777
		public bool Has_MuscleClipInfo_C74()
		{
			return true;
		}

		// Token: 0x0601F386 RID: 127878 RVA: 0x004B257A File Offset: 0x004B077A
		public bool Has_MuscleClipSize_C74()
		{
			return true;
		}

		// Token: 0x0601F387 RID: 127879 RVA: 0x004B257D File Offset: 0x004B077D
		public bool Has_PPtrCurves_C74()
		{
			return true;
		}

		// Token: 0x0601F388 RID: 127880 RVA: 0x004B2580 File Offset: 0x004B0780
		public bool Has_PrefabAsset_C74()
		{
			return false;
		}

		// Token: 0x0601F389 RID: 127881 RVA: 0x004B2583 File Offset: 0x004B0783
		public bool Has_PrefabInstance_C74()
		{
			return false;
		}

		// Token: 0x0601F38A RID: 127882 RVA: 0x004B2586 File Offset: 0x004B0786
		public bool Has_PrefabInternal_C74()
		{
			return true;
		}

		// Token: 0x0601F38B RID: 127883 RVA: 0x004B2589 File Offset: 0x004B0789
		public bool Has_UseHighQualityCurve_C74()
		{
			return true;
		}

		// Token: 0x0601F38C RID: 127884 RVA: 0x004B258C File Offset: 0x004B078C
		public override void ReadRelease(AssetReader reader)
		{
			this.m_Name.ReadRelease(reader);
			this.m_Legacy = reader.ReadBoolean();
			this.m_Compressed = reader.ReadBoolean();
			this.m_UseHighQualityCurve = reader.ReadRelease_BooleanAlign();
			this.m_RotationCurves.ReadRelease_ArrayAlign_Asset(reader);
			this.m_CompressedRotationCurves.ReadRelease_ArrayAlign_Asset(reader);
			this.m_EulerCurves.ReadRelease_ArrayAlign_Asset(reader);
			this.m_PositionCurves.ReadRelease_ArrayAlign_Asset(reader);
			this.m_ScaleCurves.ReadRelease_ArrayAlign_Asset(reader);
			this.m_FloatCurves.ReadRelease_ArrayAlign_Asset(reader);
			this.m_PPtrCurves.ReadRelease_ArrayAlign_Asset(reader);
			this.m_SampleRate = reader.ReadSingle();
			this.m_WrapMode = reader.ReadInt32();
			this.m_Bounds.ReadRelease(reader);
			this.m_MuscleClipSize = reader.ReadUInt32();
			this.m_MuscleClip.ReadRelease(reader);
			this.m_ClipBindingConstant.ReadRelease(reader);
			this.m_Events.ReadRelease_ArrayAlign_Asset(reader);

			AclCompressedProcess();
		}

		private void AclCompressedProcess()
		{
			m_Compressed = this.m_MuscleClip.m_Clip.m_Data.m_AclClip.CurveCount == 0 ? m_Compressed : false;
		}

		// Token: 0x0601F38D RID: 127885 RVA: 0x004B2674 File Offset: 0x004B0874
		public override void ReadEditor(AssetReader reader)
		{
		}

		// Token: 0x0601F38E RID: 127886 RVA: 0x004B27B0 File Offset: 0x004B09B0
		public override void WriteRelease(AssetWriter writer)
		{
			this.m_Name.WriteRelease(writer);
			this.m_Legacy.WriteRelease_Boolean(writer);
			this.m_Compressed.WriteRelease_Boolean(writer);
			this.m_UseHighQualityCurve.WriteRelease_BooleanAlign(writer);
			this.m_RotationCurves.WriteRelease_ArrayAlign_Asset(writer);
			this.m_CompressedRotationCurves.WriteRelease_ArrayAlign_Asset(writer);
			this.m_EulerCurves.WriteRelease_ArrayAlign_Asset(writer);
			this.m_PositionCurves.WriteRelease_ArrayAlign_Asset(writer);
			this.m_ScaleCurves.WriteRelease_ArrayAlign_Asset(writer);
			this.m_FloatCurves.WriteRelease_ArrayAlign_Asset(writer);
			this.m_PPtrCurves.WriteRelease_ArrayAlign_Asset(writer);
			this.m_SampleRate.WriteRelease_Single(writer);
			this.m_WrapMode.WriteRelease_Int32(writer);
			this.m_Bounds.WriteRelease(writer);
			this.m_MuscleClipSize.WriteRelease_UInt32(writer);
			this.m_MuscleClip.WriteRelease(writer);
			this.m_ClipBindingConstant.WriteRelease(writer);
			this.m_Events.WriteRelease_ArrayAlign_Asset(writer);
		}

		// Token: 0x0601F38F RID: 127887 RVA: 0x004B2898 File Offset: 0x004B0A98
		public override void WriteEditor(AssetWriter writer)
		{
		}

		// Token: 0x0601F390 RID: 127888 RVA: 0x004B29D4 File Offset: 0x004B0BD4
		public override YamlNode ExportYamlRelease(IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			YamlSerializedVersionExtensions.AddSerializedVersion(yamlMappingNode, 6);
			yamlMappingNode.Add(new YamlScalarNode("m_Name"), this.m_Name.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Legacy"), this.m_Legacy.ExportYamlRelease_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Compressed"), this.m_Compressed.ExportYamlRelease_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("m_UseHighQualityCurve"), this.m_UseHighQualityCurve.ExportYamlRelease_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("m_RotationCurves"), this.m_RotationCurves.ExportYamlRelease_Array_QuaternionCurve_2017_1_0(container));
			yamlMappingNode.Add(new YamlScalarNode("m_CompressedRotationCurves"), this.m_CompressedRotationCurves.ExportYamlRelease_Array_CompressedAnimationCurve(container));
			yamlMappingNode.Add(new YamlScalarNode("m_EulerCurves"), this.m_EulerCurves.ExportYamlRelease_Array_Vector3Curve_2017_1_0(container));
			yamlMappingNode.Add(new YamlScalarNode("m_PositionCurves"), this.m_PositionCurves.ExportYamlRelease_Array_Vector3Curve_2017_1_0(container));
			yamlMappingNode.Add(new YamlScalarNode("m_ScaleCurves"), this.m_ScaleCurves.ExportYamlRelease_Array_Vector3Curve_2017_1_0(container));
			yamlMappingNode.Add(new YamlScalarNode("m_FloatCurves"), this.m_FloatCurves.ExportYamlRelease_Array_FloatCurve_2017_1_0(container));
			yamlMappingNode.Add(new YamlScalarNode("m_PPtrCurves"), this.m_PPtrCurves.ExportYamlRelease_Array_PPtrCurve_2017_1_0(container));
			yamlMappingNode.Add(new YamlScalarNode("m_SampleRate"), this.m_SampleRate.ExportYamlRelease_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("m_WrapMode"), this.m_WrapMode.ExportYamlRelease_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Bounds"), this.m_Bounds.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("m_MuscleClipSize"), this.m_MuscleClipSize.ExportYamlRelease_UInt32(container));
			yamlMappingNode.Add(new YamlScalarNode("m_MuscleClip"), this.m_MuscleClip.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("m_ClipBindingConstant"), this.m_ClipBindingConstant.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Events"), this.m_Events.ExportYamlRelease_Array_AnimationEvent_5_0_0(container));
			return yamlMappingNode;
		}

		public override YamlNode ExportYamlEditor(IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			YamlSerializedVersionExtensions.AddSerializedVersion(yamlMappingNode, 6);
			yamlMappingNode.Add(new YamlScalarNode("m_ObjectHideFlags"), this.m_HideFlags.ExportYamlEditor_UInt32(container));
			yamlMappingNode.Add(new YamlScalarNode("m_PrefabParentObject"), this.m_CorrespondingSourceObject.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_PrefabInternal"), this.m_PrefabInternal.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Name"), this.m_Name.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Legacy"), this.m_Legacy.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Compressed"), this.m_Compressed.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("m_UseHighQualityCurve"), this.m_UseHighQualityCurve.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("m_RotationCurves"), this.m_RotationCurves.ExportYamlEditor_Array_QuaternionCurve_2017_1_0(container));
			yamlMappingNode.Add(new YamlScalarNode("m_CompressedRotationCurves"), this.m_CompressedRotationCurves.ExportYamlEditor_Array_CompressedAnimationCurve(container));
			yamlMappingNode.Add(new YamlScalarNode("m_EulerCurves"), this.m_EulerCurves.ExportYamlEditor_Array_Vector3Curve_2017_1_0(container));
			yamlMappingNode.Add(new YamlScalarNode("m_PositionCurves"), this.m_PositionCurves.ExportYamlEditor_Array_Vector3Curve_2017_1_0(container));
			yamlMappingNode.Add(new YamlScalarNode("m_ScaleCurves"), this.m_ScaleCurves.ExportYamlEditor_Array_Vector3Curve_2017_1_0(container));
			yamlMappingNode.Add(new YamlScalarNode("m_FloatCurves"), this.m_FloatCurves.ExportYamlEditor_Array_FloatCurve_2017_1_0(container));
			yamlMappingNode.Add(new YamlScalarNode("m_PPtrCurves"), this.m_PPtrCurves.ExportYamlEditor_Array_PPtrCurve_2017_1_0(container));
			yamlMappingNode.Add(new YamlScalarNode("m_SampleRate"), this.m_SampleRate.ExportYamlEditor_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("m_WrapMode"), this.m_WrapMode.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Bounds"), this.m_Bounds.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_ClipBindingConstant"), this.m_ClipBindingConstant.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_AnimationClipSettings"), this.m_MuscleClipInfo.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_EditorCurves"), this.m_EditorCurves.ExportYamlEditor_Array_FloatCurve_2017_1_0(container));
			yamlMappingNode.Add(new YamlScalarNode("m_EulerEditorCurves"), this.m_EulerEditorCurves.ExportYamlEditor_Array_FloatCurve_2017_1_0(container));
			yamlMappingNode.Add(new YamlScalarNode("m_HasGenericRootTransform"), this.m_HasGenericRootTransform.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("m_HasMotionFloatCurves"), this.m_HasMotionFloatCurves.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("m_GenerateMotionCurves"), this.m_GenerateMotionCurves.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Events"), this.m_Events.ExportYamlEditor_Array_AnimationEvent_5_0_0(container));
			return yamlMappingNode;
		}

		// Token: 0x0601F392 RID: 127890 RVA: 0x004B2EC0 File Offset: 0x004B10C0
		public override void Reset()
		{
			this.m_Bounds.Reset();
			this.m_ClipBindingConstant.Reset();
			this.m_Compressed = false;
			this.m_CompressedRotationCurves.Clear();
			this.m_CorrespondingSourceObject.Reset();
			this.m_EditorCurves.Clear();
			this.m_EulerCurves.Clear();
			this.m_EulerEditorCurves.Clear();
			this.m_Events.Clear();
			this.m_FloatCurves.Clear();
			this.m_GenerateMotionCurves = false;
			this.m_HasGenericRootTransform = false;
			this.m_HasMotionFloatCurves = false;
			this.m_HideFlags = 0U;
			this.m_Legacy = false;
			this.m_MuscleClip.Reset();
			this.m_MuscleClipInfo.Reset();
			this.m_MuscleClipSize = 0U;
			this.m_Name.Reset();
			this.m_PositionCurves.Clear();
			this.m_PPtrCurves.Clear();
			this.m_PrefabInternal.Reset();
			this.m_RotationCurves.Clear();
			this.m_SampleRate = 0f;
			this.m_ScaleCurves.Clear();
			this.m_UseHighQualityCurve = false;
			this.m_WrapMode = 0;
		}

		// Token: 0x0601F393 RID: 127891 RVA: 0x004B2FD2 File Offset: 0x004B11D2

		//public override IEnumerable<ValueTuple<FieldName, PPtr<IUnityObjectBase>>> FetchDependencies(FieldName parent)
		//{
		//	return Enumerable.Empty<ValueTuple<FieldName, PPtr<IUnityObjectBase>>>().Append_AnimationClip_2017_1_0(parent, this);
		//}

		// Token: 0x0601F394 RID: 127892 RVA: 0x004B2FE0 File Offset: 0x004B11E0
		public void CopyValues(IAnimationClip_ACL source, PPtrConverter converter)
		{
			this.m_Bounds.CopyValues(source.Bounds_C74);
			this.m_ClipBindingConstant.CopyValues(source.ClipBindingConstant_C74, converter);
			this.m_Compressed = source.Compressed_C74;
			CopyValuesHelper.CopyValues__AssetList_CompressedAnimationCurve__AssetList_CompressedAnimationCurve(this.m_CompressedRotationCurves, source.CompressedRotationCurves_C74);
			this.m_CorrespondingSourceObject.CopyValues(source.CorrespondingSourceObject_C74, converter);
			CopyValuesHelper.CopyValues__AssetList_FloatCurve_2017_1_0__AccessListBase_IFloatCurve(this.m_EditorCurves, source.EditorCurves_C74, converter);
			CopyValuesHelper.CopyValues__AssetList_Vector3Curve_2017_1_0__AccessListBase_IVector3Curve(this.m_EulerCurves, source.EulerCurves_C74);
			CopyValuesHelper.CopyValues__AssetList_FloatCurve_2017_1_0__AccessListBase_IFloatCurve(this.m_EulerEditorCurves, source.EulerEditorCurves_C74, converter);
			CopyValuesHelper.CopyValues__AssetList_AnimationEvent_5_0_0__AccessListBase_IAnimationEvent(this.m_Events, source.Events_C74, converter);
			CopyValuesHelper.CopyValues__AssetList_FloatCurve_2017_1_0__AccessListBase_IFloatCurve(this.m_FloatCurves, source.FloatCurves_C74, converter);
			this.m_GenerateMotionCurves = source.GenerateMotionCurves_C74;
			this.m_HasGenericRootTransform = source.HasGenericRootTransform_C74;
			this.m_HasMotionFloatCurves = source.HasMotionFloatCurves_C74;
			this.m_HideFlags = source.HideFlags_C74;
			this.m_Legacy = source.Legacy_C74;
			this.m_MuscleClip.CopyValues(source.MuscleClip_C74);
			this.m_MuscleClipInfo.CopyValues(source.MuscleClipInfo_C74, converter);
			this.m_MuscleClipSize = source.MuscleClipSize_C74;
			this.m_Name.CopyValues(source.Name_C74);
			CopyValuesHelper.CopyValues__AssetList_Vector3Curve_2017_1_0__AccessListBase_IVector3Curve(this.m_PositionCurves, source.PositionCurves_C74);
			CopyValuesHelper.CopyValues__AssetList_PPtrCurve_2017_1_0__AccessListBase_IPPtrCurve(this.m_PPtrCurves, source.PPtrCurves_C74, converter);
			this.m_PrefabInternal.CopyValues(source.PrefabInternal_C74, converter);
			CopyValuesHelper.CopyValues__AssetList_QuaternionCurve_2017_1_0__AccessListBase_IQuaternionCurve(this.m_RotationCurves, source.RotationCurves_C74);
			this.m_SampleRate = source.SampleRate_C74;
			CopyValuesHelper.CopyValues__AssetList_Vector3Curve_2017_1_0__AccessListBase_IVector3Curve(this.m_ScaleCurves, source.ScaleCurves_C74);
			this.m_UseHighQualityCurve = source.UseHighQualityCurve_C74;
			this.m_WrapMode = source.WrapMode_C74;
		}

		// Token: 0x0601F395 RID: 127893 RVA: 0x004B318F File Offset: 0x004B138F
		public void CopyValues(IAnimationClip_ACL source)
		{
			this.CopyValues(source, new PPtrConverter(source, this));
		}

		// Token: 0x0601F396 RID: 127894 RVA: 0x004B31A0 File Offset: 0x004B13A0

		public override void CopyValues(IUnityAssetBase source, PPtrConverter converter)
		{
			IAnimationClip_ACL animationClip = source as IAnimationClip_ACL;
			if (animationClip != null)
			{
				this.CopyValues(animationClip, converter);
				return;
			}
			base.CopyValues(source, converter);
		}

		// Token: 0x0601F397 RID: 127895 RVA: 0x004B31C8 File Offset: 0x004B13C8
		public override List<TypeTreeNode> MakeEditorTypeTreeNodes(int depth, int startingIndex)
		{
			throw new NotSupportedException();
		}

		// Token: 0x0601F398 RID: 127896 RVA: 0x004B31CF File Offset: 0x004B13CF
		public override List<TypeTreeNode> MakeReleaseTypeTreeNodes(int depth, int startingIndex)
		{
			throw new NotSupportedException();
		}

		// Token: 0x0401146D RID: 70765
		public uint m_MuscleClipSize;

		// Token: 0x0401146E RID: 70766
		public MuscleClipConstant_5_6_0_ACL m_MuscleClip;

		// Token: 0x0401146F RID: 70767
		public MuscleClipInfo_5_3_0 m_MuscleClipInfo;

		// Token: 0x04011470 RID: 70768
		public AssetList<FloatCurve_2017_1_0> m_EditorCurves;

		// Token: 0x04011471 RID: 70769
		public AssetList<FloatCurve_2017_1_0> m_EulerEditorCurves;

		// Token: 0x04011472 RID: 70770
		public bool m_HasGenericRootTransform;

		// Token: 0x04011473 RID: 70771
		public bool m_HasMotionFloatCurves;

		// Token: 0x04011474 RID: 70772
		public bool m_GenerateMotionCurves;

		// Token: 0x04011475 RID: 70773
		public bool m_Legacy;

		// Token: 0x04011476 RID: 70774
		public bool m_Compressed;

		// Token: 0x04011477 RID: 70775
		public bool m_UseHighQualityCurve;

		// Token: 0x04011478 RID: 70776
		public AssetList<QuaternionCurve_2017_1_0> m_RotationCurves;

		// Token: 0x04011479 RID: 70777
		public AssetList<CompressedAnimationCurve> m_CompressedRotationCurves;

		// Token: 0x0401147A RID: 70778
		public AssetList<Vector3Curve_2017_1_0> m_EulerCurves;

		// Token: 0x0401147B RID: 70779
		public AssetList<Vector3Curve_2017_1_0> m_PositionCurves;

		// Token: 0x0401147C RID: 70780
		public AssetList<Vector3Curve_2017_1_0> m_ScaleCurves;

		// Token: 0x0401147D RID: 70781
		public AssetList<FloatCurve_2017_1_0> m_FloatCurves;

		// Token: 0x0401147E RID: 70782
		public AssetList<PPtrCurve_2017_1_0> m_PPtrCurves;

		// Token: 0x0401147F RID: 70783
		public float m_SampleRate;

		// Token: 0x04011480 RID: 70784
		public int m_WrapMode;

		// Token: 0x04011481 RID: 70785
		public AABB_3_5_0 m_Bounds;

		// Token: 0x04011482 RID: 70786
		public AnimationClipBindingConstant_2017_1_0 m_ClipBindingConstant;

		// Token: 0x04011483 RID: 70787
		public AssetList<AnimationEvent_5_0_0> m_Events;
	}
}
