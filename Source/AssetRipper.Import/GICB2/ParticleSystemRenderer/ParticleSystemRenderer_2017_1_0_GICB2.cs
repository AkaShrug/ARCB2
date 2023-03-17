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
using AssetRipper.SourceGenerated.Classes.ClassID_1;
using AssetRipper.SourceGenerated.Classes.ClassID_1001;
using AssetRipper.SourceGenerated.Classes.ClassID_1001480554;
using AssetRipper.SourceGenerated.Classes.ClassID_1113;
using AssetRipper.SourceGenerated.Classes.ClassID_18;
using AssetRipper.SourceGenerated.Classes.ClassID_2;
using AssetRipper.SourceGenerated.Classes.ClassID_21;
using AssetRipper.SourceGenerated.Classes.ClassID_25;
using AssetRipper.SourceGenerated.Classes.ClassID_4;
using AssetRipper.SourceGenerated.Classes.ClassID_43;
using AssetRipper.SourceGenerated.Enums;
using AssetRipper.SourceGenerated.Helpers;
using AssetRipper.SourceGenerated.Interfaces;
using AssetRipper.SourceGenerated.MarkerInterfaces;
using AssetRipper.SourceGenerated.Subclasses.PPtr_EditorExtension;
using AssetRipper.SourceGenerated.Subclasses.PPtr_GameObject;
using AssetRipper.SourceGenerated.Subclasses.PPtr_LightmapParameters;
using AssetRipper.SourceGenerated.Subclasses.PPtr_Material;
using AssetRipper.SourceGenerated.Subclasses.PPtr_Mesh;
using AssetRipper.SourceGenerated.Subclasses.PPtr_PrefabInstance;
using AssetRipper.SourceGenerated.Subclasses.PPtr_Prefab;
using AssetRipper.SourceGenerated.Subclasses.PPtr_Transform;
using AssetRipper.SourceGenerated.Subclasses.StaticBatchInfo;
using AssetRipper.SourceGenerated.Subclasses.Vector3f;
using AssetRipper.SourceGenerated.Subclasses.Vector4f;
using AssetRipper.Yaml;
using AssetRipper.SourceGenerated.Classes.ClassID_199;
using AssetRipper.SourceGenerated.Subclasses.Vector2f;
using AssetRipper.Import.IO.Extensions;

namespace AssetRipper.Import.GICB2.ParticleSystemRenderer
{
	// Token: 0x02002D33 RID: 11571


	public sealed class ParticleSystemRenderer_2017_1_0_GICB2 : Renderer_2017_1_0, IParticleSystemRenderer, IUnityObjectBase, IUnityAssetBase, IAsset, IAssetReadable, IAssetWritable, IYamlExportable, IDependent, ITypeTreeSerializable, IParticleSystemRendererMarker, IRenderer, IRendererMarker, IHasEnabled, IComponent, IEditorExtension, IEditorExtensionMarker, IObject, IObjectMarker, IHasHideFlags, IComponentMarker
	{
		// Token: 0x17014785 RID: 83845
		// (get) Token: 0x0603D43B RID: 250939 RVA: 0x0080BFBC File Offset: 0x0080A1BC
		// (set) Token: 0x0603D43C RID: 250940 RVA: 0x0080BFBF File Offset: 0x0080A1BF
		public bool AllowRoll_C199
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17014786 RID: 83846
		// (get) Token: 0x0603D43D RID: 250941 RVA: 0x0080BFC1 File Offset: 0x0080A1C1
		// (set) Token: 0x0603D43E RID: 250942 RVA: 0x0080BFC4 File Offset: 0x0080A1C4
		public bool ApplyActiveColorSpace_C199
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17014787 RID: 83847
		// (get) Token: 0x0603D43F RID: 250943 RVA: 0x0080BFC6 File Offset: 0x0080A1C6
		// (set) Token: 0x0603D440 RID: 250944 RVA: 0x0080BFCE File Offset: 0x0080A1CE
		public float AutoUVMaxAngle_C199
		{
			get
			{
				return this.m_AutoUVMaxAngle;
			}
			set
			{
				this.m_AutoUVMaxAngle = value;
			}
		}

		// Token: 0x17014788 RID: 83848
		// (get) Token: 0x0603D441 RID: 250945 RVA: 0x0080BFD7 File Offset: 0x0080A1D7
		// (set) Token: 0x0603D442 RID: 250946 RVA: 0x0080BFDF File Offset: 0x0080A1DF
		public float AutoUVMaxDistance_C199
		{
			get
			{
				return this.m_AutoUVMaxDistance;
			}
			set
			{
				this.m_AutoUVMaxDistance = value;
			}
		}

		// Token: 0x17014789 RID: 83849
		// (get) Token: 0x0603D443 RID: 250947 RVA: 0x0080BFE8 File Offset: 0x0080A1E8
		// (set) Token: 0x0603D444 RID: 250948 RVA: 0x0080BFF0 File Offset: 0x0080A1F0
		public float CameraVelocityScale_C199
		{
			get
			{
				return this.m_CameraVelocityScale;
			}
			set
			{
				this.m_CameraVelocityScale = value;
			}
		}

		// Token: 0x1701478A RID: 83850
		// (get) Token: 0x0603D445 RID: 250949 RVA: 0x0080BFF9 File Offset: 0x0080A1F9
		// (set) Token: 0x0603D446 RID: 250950 RVA: 0x0080BFFC File Offset: 0x0080A1FC
		public bool CastShadows_C199_Boolean
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x1701478B RID: 83851
		// (get) Token: 0x0603D447 RID: 250951 RVA: 0x0080BFFE File Offset: 0x0080A1FE
		// (set) Token: 0x0603D448 RID: 250952 RVA: 0x0080C006 File Offset: 0x0080A206
		public byte CastShadows_C199_Byte
		{
			get
			{
				return this.m_CastShadows;
			}
			set
			{
				this.m_CastShadows = value;
			}
		}

		// Token: 0x1701478C RID: 83852
		// (get) Token: 0x0603D449 RID: 250953 RVA: 0x0080C00F File Offset: 0x0080A20F

		public IPPtr_EditorExtension CorrespondingSourceObject_C199
		{

			get
			{
				return this.m_CorrespondingSourceObject;
			}
		}

		// Token: 0x1701478D RID: 83853
		// (get) Token: 0x0603D44A RID: 250954 RVA: 0x0080C017 File Offset: 0x0080A217
		// (set) Token: 0x0603D44B RID: 250955 RVA: 0x0080C01A File Offset: 0x0080A21A
		public byte DynamicOccludee_C199
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x1701478E RID: 83854
		// (get) Token: 0x0603D44C RID: 250956 RVA: 0x0080C01C File Offset: 0x0080A21C
		// (set) Token: 0x0603D44D RID: 250957 RVA: 0x0080C024 File Offset: 0x0080A224
		public bool Enabled_C199
		{
			get
			{
				return this.m_Enabled;
			}
			set
			{
				this.m_Enabled = value;
			}
		}

		// Token: 0x1701478F RID: 83855
		// (get) Token: 0x0603D44E RID: 250958 RVA: 0x0080C02D File Offset: 0x0080A22D
		// (set) Token: 0x0603D44F RID: 250959 RVA: 0x0080C030 File Offset: 0x0080A230
		public bool EnableGPUInstancing_C199
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17014790 RID: 83856
		// (get) Token: 0x0603D450 RID: 250960 RVA: 0x0080C032 File Offset: 0x0080A232
		public Vector3f_3_5_0 Flip_C199
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17014791 RID: 83857
		// (get) Token: 0x0603D451 RID: 250961 RVA: 0x0080C035 File Offset: 0x0080A235
		// (set) Token: 0x0603D452 RID: 250962 RVA: 0x0080C038 File Offset: 0x0080A238
		public bool FreeformStretching_C199
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17014792 RID: 83858
		// (get) Token: 0x0603D453 RID: 250963 RVA: 0x0080C03A File Offset: 0x0080A23A

		public IPPtr_GameObject GameObject_C199
		{

			get
			{
				return this.m_GameObject;
			}
		}

		// Token: 0x17014793 RID: 83859
		// (get) Token: 0x0603D454 RID: 250964 RVA: 0x0080C042 File Offset: 0x0080A242
		// (set) Token: 0x0603D455 RID: 250965 RVA: 0x0080C04A File Offset: 0x0080A24A
		public uint HideFlags_C199
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

		// Token: 0x17014794 RID: 83860
		// (get) Token: 0x0603D456 RID: 250966 RVA: 0x0080C053 File Offset: 0x0080A253
		// (set) Token: 0x0603D457 RID: 250967 RVA: 0x0080C05B File Offset: 0x0080A25B
		public bool IgnoreNormalsForChartDetection_C199
		{
			get
			{
				return this.m_IgnoreNormalsForChartDetection;
			}
			set
			{
				this.m_IgnoreNormalsForChartDetection = value;
			}
		}

		// Token: 0x17014795 RID: 83861
		// (get) Token: 0x0603D458 RID: 250968 RVA: 0x0080C064 File Offset: 0x0080A264
		// (set) Token: 0x0603D459 RID: 250969 RVA: 0x0080C06C File Offset: 0x0080A26C
		public bool ImportantGI_C199
		{
			get
			{
				return this.m_ImportantGI;
			}
			set
			{
				this.m_ImportantGI = value;
			}
		}

		// Token: 0x17014796 RID: 83862
		// (get) Token: 0x0603D45A RID: 250970 RVA: 0x0080C075 File Offset: 0x0080A275
		// (set) Token: 0x0603D45B RID: 250971 RVA: 0x0080C07D File Offset: 0x0080A27D
		public float LengthScale_C199
		{
			get
			{
				return this.m_LengthScale;
			}
			set
			{
				this.m_LengthScale = value;
			}
		}

		// Token: 0x17014797 RID: 83863
		// (get) Token: 0x0603D45C RID: 250972 RVA: 0x0080C086 File Offset: 0x0080A286
		// (set) Token: 0x0603D45D RID: 250973 RVA: 0x0080C089 File Offset: 0x0080A289
		public byte LightmapIndex_C199_Byte
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x17014798 RID: 83864
		// (get) Token: 0x0603D45E RID: 250974 RVA: 0x0080C08B File Offset: 0x0080A28B
		// (set) Token: 0x0603D45F RID: 250975 RVA: 0x0080C093 File Offset: 0x0080A293
		public ushort LightmapIndex_C199_UInt16
		{
			get
			{
				return this.m_LightmapIndex;
			}
			set
			{
				this.m_LightmapIndex = value;
			}
		}

		// Token: 0x17014799 RID: 83865
		// (get) Token: 0x0603D460 RID: 250976 RVA: 0x0080C09C File Offset: 0x0080A29C
		// (set) Token: 0x0603D461 RID: 250977 RVA: 0x0080C0A4 File Offset: 0x0080A2A4
		public ushort LightmapIndexDynamic_C199
		{
			get
			{
				return this.m_LightmapIndexDynamic;
			}
			set
			{
				this.m_LightmapIndexDynamic = value;
			}
		}

		// Token: 0x1701479A RID: 83866
		// (get) Token: 0x0603D462 RID: 250978 RVA: 0x0080C0AD File Offset: 0x0080A2AD
		public PPtr_LightmapParameters LightmapParameters_C199
		{
			[return: NotNull]
			get
			{
				return this.m_LightmapParameters;
			}
		}

		// Token: 0x1701479B RID: 83867
		// (get) Token: 0x0603D463 RID: 250979 RVA: 0x0080C0B5 File Offset: 0x0080A2B5

		public Vector4f_3_5_0 LightmapTilingOffset_C199
		{

			get
			{
				return this.m_LightmapTilingOffset;
			}
		}

		// Token: 0x1701479C RID: 83868
		// (get) Token: 0x0603D464 RID: 250980 RVA: 0x0080C0BD File Offset: 0x0080A2BD
		public Vector4f_3_5_0 LightmapTilingOffsetDynamic_C199
		{
			[return: NotNull]
			get
			{
				return this.m_LightmapTilingOffsetDynamic;
			}
		}

		// Token: 0x1701479D RID: 83869
		// (get) Token: 0x0603D465 RID: 250981 RVA: 0x0080C0C5 File Offset: 0x0080A2C5
		public PPtr_Transform_3_4_0 LightProbeAnchor_C199
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1701479E RID: 83870
		// (get) Token: 0x0603D466 RID: 250982 RVA: 0x0080C0C8 File Offset: 0x0080A2C8
		// (set) Token: 0x0603D467 RID: 250983 RVA: 0x0080C0D0 File Offset: 0x0080A2D0
		public byte LightProbeUsage_C199
		{
			get
			{
				return this.m_LightProbeUsage;
			}
			set
			{
				this.m_LightProbeUsage = value;
			}
		}

		// Token: 0x1701479F RID: 83871
		// (get) Token: 0x0603D468 RID: 250984 RVA: 0x0080C0D9 File Offset: 0x0080A2D9
		public PPtr_GameObject_5_0_0 LightProbeVolumeOverride_C199
		{
			[return: NotNull]
			get
			{
				return this.m_LightProbeVolumeOverride;
			}
		}

		// Token: 0x170147A0 RID: 83872
		// (get) Token: 0x0603D469 RID: 250985 RVA: 0x0080C0E1 File Offset: 0x0080A2E1
		// (set) Token: 0x0603D46A RID: 250986 RVA: 0x0080C0E9 File Offset: 0x0080A2E9
		public int MaskInteraction_C199
		{
			get
			{
				return this.m_MaskInteraction;
			}
			set
			{
				this.m_MaskInteraction = value;
			}
		}

		// Token: 0x170147A1 RID: 83873
		// (get) Token: 0x0603D46B RID: 250987 RVA: 0x0080C0F2 File Offset: 0x0080A2F2

		public AccessListBase<IPPtr_Material> Materials_C199
		{

			get
			{
				return new AccessList<PPtr_Material_5_0_0, IPPtr_Material>(this.m_Materials);
			}
		}

		// Token: 0x170147A2 RID: 83874
		// (get) Token: 0x0603D46C RID: 250988 RVA: 0x0080C0FF File Offset: 0x0080A2FF
		// (set) Token: 0x0603D46D RID: 250989 RVA: 0x0080C107 File Offset: 0x0080A307
		public float MaxParticleSize_C199
		{
			get
			{
				return this.m_MaxParticleSize;
			}
			set
			{
				this.m_MaxParticleSize = value;
			}
		}

		// Token: 0x170147A3 RID: 83875
		// (get) Token: 0x0603D46E RID: 250990 RVA: 0x0080C110 File Offset: 0x0080A310

		public IPPtr_Mesh Mesh_C199
		{

			get
			{
				return this.m_Mesh;
			}
		}

		// Token: 0x170147A4 RID: 83876
		// (get) Token: 0x0603D46F RID: 250991 RVA: 0x0080C118 File Offset: 0x0080A318
		public IPPtr_Mesh Mesh1_C199
		{
			[return: NotNull]
			get
			{
				return this.m_Mesh1;
			}
		}

		// Token: 0x170147A5 RID: 83877
		// (get) Token: 0x0603D470 RID: 250992 RVA: 0x0080C120 File Offset: 0x0080A320
		public IPPtr_Mesh Mesh2_C199
		{
			[return: NotNull]
			get
			{
				return this.m_Mesh2;
			}
		}

		// Token: 0x170147A6 RID: 83878
		// (get) Token: 0x0603D471 RID: 250993 RVA: 0x0080C128 File Offset: 0x0080A328
		public IPPtr_Mesh Mesh3_C199
		{
			[return: NotNull]
			get
			{
				return this.m_Mesh3;
			}
		}

		// Token: 0x170147A7 RID: 83879
		// (get) Token: 0x0603D472 RID: 250994 RVA: 0x0080C130 File Offset: 0x0080A330
		// (set) Token: 0x0603D473 RID: 250995 RVA: 0x0080C133 File Offset: 0x0080A333
		public byte MeshDistribution_C199
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x170147A8 RID: 83880
		// (get) Token: 0x0603D474 RID: 250996 RVA: 0x0080C135 File Offset: 0x0080A335
		// (set) Token: 0x0603D475 RID: 250997 RVA: 0x0080C13C File Offset: 0x0080A33C
		public float MeshWeighting_C199
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x170147A9 RID: 83881
		// (get) Token: 0x0603D476 RID: 250998 RVA: 0x0080C13E File Offset: 0x0080A33E
		// (set) Token: 0x0603D477 RID: 250999 RVA: 0x0080C145 File Offset: 0x0080A345
		public float MeshWeighting1_C199
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x170147AA RID: 83882
		// (get) Token: 0x0603D478 RID: 251000 RVA: 0x0080C147 File Offset: 0x0080A347
		// (set) Token: 0x0603D479 RID: 251001 RVA: 0x0080C14E File Offset: 0x0080A34E
		public float MeshWeighting2_C199
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x170147AB RID: 83883
		// (get) Token: 0x0603D47A RID: 251002 RVA: 0x0080C150 File Offset: 0x0080A350
		// (set) Token: 0x0603D47B RID: 251003 RVA: 0x0080C157 File Offset: 0x0080A357
		public float MeshWeighting3_C199
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x170147AC RID: 83884
		// (get) Token: 0x0603D47C RID: 251004 RVA: 0x0080C159 File Offset: 0x0080A359
		// (set) Token: 0x0603D47D RID: 251005 RVA: 0x0080C161 File Offset: 0x0080A361
		public int MinimumChartSize_C199
		{
			get
			{
				return this.m_MinimumChartSize;
			}
			set
			{
				this.m_MinimumChartSize = value;
			}
		}

		// Token: 0x170147AD RID: 83885
		// (get) Token: 0x0603D47E RID: 251006 RVA: 0x0080C16A File Offset: 0x0080A36A
		// (set) Token: 0x0603D47F RID: 251007 RVA: 0x0080C172 File Offset: 0x0080A372
		public float MinParticleSize_C199
		{
			get
			{
				return this.m_MinParticleSize;
			}
			set
			{
				this.m_MinParticleSize = value;
			}
		}

		// Token: 0x170147AE RID: 83886
		// (get) Token: 0x0603D480 RID: 251008 RVA: 0x0080C17B File Offset: 0x0080A37B
		// (set) Token: 0x0603D481 RID: 251009 RVA: 0x0080C183 File Offset: 0x0080A383
		public byte MotionVectors_C199
		{
			get
			{
				return this.m_MotionVectors;
			}
			set
			{
				this.m_MotionVectors = value;
			}
		}

		// Token: 0x170147AF RID: 83887
		// (get) Token: 0x0603D482 RID: 251010 RVA: 0x0080C18C File Offset: 0x0080A38C
		// (set) Token: 0x0603D483 RID: 251011 RVA: 0x0080C194 File Offset: 0x0080A394
		public float NormalDirection_C199
		{
			get
			{
				return this.m_NormalDirection;
			}
			set
			{
				this.m_NormalDirection = value;
			}
		}

		// Token: 0x170147B0 RID: 83888
		// (get) Token: 0x0603D484 RID: 251012 RVA: 0x0080C19D File Offset: 0x0080A39D
		public Vector3f_3_5_0 Pivot_C199
		{
			[return: NotNull]
			get
			{
				return this.m_Pivot;
			}
		}

		// Token: 0x170147B1 RID: 83889
		// (get) Token: 0x0603D485 RID: 251013 RVA: 0x0080C1A5 File Offset: 0x0080A3A5
		public PPtr_Prefab_2018_3_0 PrefabAsset_C199
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170147B2 RID: 83890
		// (get) Token: 0x0603D486 RID: 251014 RVA: 0x0080C1A8 File Offset: 0x0080A3A8
		public PPtr_PrefabInstance PrefabInstance_C199
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170147B3 RID: 83891
		// (get) Token: 0x0603D487 RID: 251015 RVA: 0x0080C1AB File Offset: 0x0080A3AB
		public IPPtr_Prefab PrefabInternal_C199
		{
			[return: NotNull]
			get
			{
				return this.m_PrefabInternal;
			}
		}

		// Token: 0x170147B4 RID: 83892
		// (get) Token: 0x0603D488 RID: 251016 RVA: 0x0080C1B3 File Offset: 0x0080A3B3
		// (set) Token: 0x0603D489 RID: 251017 RVA: 0x0080C1BB File Offset: 0x0080A3BB
		public bool PreserveUVs_C199
		{
			get
			{
				return this.m_PreserveUVs;
			}
			set
			{
				this.m_PreserveUVs = value;
			}
		}

		// Token: 0x170147B5 RID: 83893
		// (get) Token: 0x0603D48A RID: 251018 RVA: 0x0080C1C4 File Offset: 0x0080A3C4
		public PPtr_Transform_5_0_0 ProbeAnchor_C199
		{
			[return: NotNull]
			get
			{
				return this.m_ProbeAnchor;
			}
		}

		// Token: 0x170147B6 RID: 83894
		// (get) Token: 0x0603D48B RID: 251019 RVA: 0x0080C1CC File Offset: 0x0080A3CC
		// (set) Token: 0x0603D48C RID: 251020 RVA: 0x0080C1CF File Offset: 0x0080A3CF
		public byte RayTraceProcedural_C199
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x170147B7 RID: 83895
		// (get) Token: 0x0603D48D RID: 251021 RVA: 0x0080C1D1 File Offset: 0x0080A3D1
		// (set) Token: 0x0603D48E RID: 251022 RVA: 0x0080C1D4 File Offset: 0x0080A3D4
		public byte RayTracingMode_C199
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x170147B8 RID: 83896
		// (get) Token: 0x0603D48F RID: 251023 RVA: 0x0080C1D6 File Offset: 0x0080A3D6
		// (set) Token: 0x0603D490 RID: 251024 RVA: 0x0080C1D9 File Offset: 0x0080A3D9
		public int ReceiveGI_C199
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x170147B9 RID: 83897
		// (get) Token: 0x0603D491 RID: 251025 RVA: 0x0080C1DB File Offset: 0x0080A3DB
		// (set) Token: 0x0603D492 RID: 251026 RVA: 0x0080C1DE File Offset: 0x0080A3DE
		public bool ReceiveShadows_C199_Boolean
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x170147BA RID: 83898
		// (get) Token: 0x0603D493 RID: 251027 RVA: 0x0080C1E0 File Offset: 0x0080A3E0
		// (set) Token: 0x0603D494 RID: 251028 RVA: 0x0080C1E8 File Offset: 0x0080A3E8
		public byte ReceiveShadows_C199_Byte
		{
			get
			{
				return this.m_ReceiveShadows;
			}
			set
			{
				this.m_ReceiveShadows = value;
			}
		}

		// Token: 0x170147BB RID: 83899
		// (get) Token: 0x0603D495 RID: 251029 RVA: 0x0080C1F1 File Offset: 0x0080A3F1
		// (set) Token: 0x0603D496 RID: 251030 RVA: 0x0080C1F4 File Offset: 0x0080A3F4
		public int ReflectionProbeUsage_C199_Int32
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x170147BC RID: 83900
		// (get) Token: 0x0603D497 RID: 251031 RVA: 0x0080C1F6 File Offset: 0x0080A3F6
		// (set) Token: 0x0603D498 RID: 251032 RVA: 0x0080C1FE File Offset: 0x0080A3FE
		public byte ReflectionProbeUsage_C199_Byte
		{
			get
			{
				return this.m_ReflectionProbeUsage;
			}
			set
			{
				this.m_ReflectionProbeUsage = value;
			}
		}

		// Token: 0x170147BD RID: 83901
		// (get) Token: 0x0603D499 RID: 251033 RVA: 0x0080C207 File Offset: 0x0080A407
		// (set) Token: 0x0603D49A RID: 251034 RVA: 0x0080C20F File Offset: 0x0080A40F
		public int RenderAlignment_C199
		{
			get
			{
				return this.m_RenderAlignment;
			}
			set
			{
				this.m_RenderAlignment = value;
			}
		}

		// Token: 0x170147BE RID: 83902
		// (get) Token: 0x0603D49B RID: 251035 RVA: 0x0080C218 File Offset: 0x0080A418
		// (set) Token: 0x0603D49C RID: 251036 RVA: 0x0080C21B File Offset: 0x0080A41B
		public int RendererPriority_C199
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x170147BF RID: 83903
		// (get) Token: 0x0603D49D RID: 251037 RVA: 0x0080C21D File Offset: 0x0080A41D
		// (set) Token: 0x0603D49E RID: 251038 RVA: 0x0080C220 File Offset: 0x0080A420
		public uint RenderingLayerMask_C199
		{
			get
			{
				return 0U;
			}
			set
			{
			}
		}

		// Token: 0x170147C0 RID: 83904
		// (get) Token: 0x0603D49F RID: 251039 RVA: 0x0080C222 File Offset: 0x0080A422
		// (set) Token: 0x0603D4A0 RID: 251040 RVA: 0x0080C225 File Offset: 0x0080A425
		public int RenderMode_C199_Int32
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x170147C1 RID: 83905
		// (get) Token: 0x0603D4A1 RID: 251041 RVA: 0x0080C227 File Offset: 0x0080A427
		// (set) Token: 0x0603D4A2 RID: 251042 RVA: 0x0080C22F File Offset: 0x0080A42F
		public ushort RenderMode_C199_UInt16
		{
			get
			{
				return this.m_RenderMode;
			}
			set
			{
				this.m_RenderMode = value;
			}
		}

		// Token: 0x170147C2 RID: 83906
		// (get) Token: 0x0603D4A3 RID: 251043 RVA: 0x0080C238 File Offset: 0x0080A438
		// (set) Token: 0x0603D4A4 RID: 251044 RVA: 0x0080C23B File Offset: 0x0080A43B
		public bool RotateWithStretchDirection_C199
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x170147C3 RID: 83907
		// (get) Token: 0x0603D4A5 RID: 251045 RVA: 0x0080C23D File Offset: 0x0080A43D
		// (set) Token: 0x0603D4A6 RID: 251046 RVA: 0x0080C245 File Offset: 0x0080A445
		public float ScaleInLightmap_C199
		{
			get
			{
				return this.m_ScaleInLightmap;
			}
			set
			{
				this.m_ScaleInLightmap = value;
			}
		}

		// Token: 0x170147C4 RID: 83908
		// (get) Token: 0x0603D4A7 RID: 251047 RVA: 0x0080C24E File Offset: 0x0080A44E
		// (set) Token: 0x0603D4A8 RID: 251048 RVA: 0x0080C256 File Offset: 0x0080A456
		public int SelectedEditorRenderState_C199
		{
			get
			{
				return this.m_SelectedEditorRenderState;
			}
			set
			{
				this.m_SelectedEditorRenderState = value;
			}
		}

		// Token: 0x170147C5 RID: 83909
		// (get) Token: 0x0603D4A9 RID: 251049 RVA: 0x0080C25F File Offset: 0x0080A45F
		// (set) Token: 0x0603D4AA RID: 251050 RVA: 0x0080C262 File Offset: 0x0080A462
		public bool SelectedWireframeHidden_C199
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x170147C6 RID: 83910
		// (get) Token: 0x0603D4AB RID: 251051 RVA: 0x0080C264 File Offset: 0x0080A464
		// (set) Token: 0x0603D4AC RID: 251052 RVA: 0x0080C26B File Offset: 0x0080A46B
		public float ShadowBias_C199
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x170147C7 RID: 83911
		// (get) Token: 0x0603D4AD RID: 251053 RVA: 0x0080C26D File Offset: 0x0080A46D
		// (set) Token: 0x0603D4AE RID: 251054 RVA: 0x0080C275 File Offset: 0x0080A475
		public float SortingFudge_C199
		{
			get
			{
				return this.m_SortingFudge;
			}
			set
			{
				this.m_SortingFudge = value;
			}
		}

		// Token: 0x170147C8 RID: 83912
		// (get) Token: 0x0603D4AF RID: 251055 RVA: 0x0080C27E File Offset: 0x0080A47E
		// (set) Token: 0x0603D4B0 RID: 251056 RVA: 0x0080C286 File Offset: 0x0080A486
		public short SortingLayer_C199
		{
			get
			{
				return this.m_SortingLayer;
			}
			set
			{
				this.m_SortingLayer = value;
			}
		}

		// Token: 0x170147C9 RID: 83913
		// (get) Token: 0x0603D4B1 RID: 251057 RVA: 0x0080C28F File Offset: 0x0080A48F
		// (set) Token: 0x0603D4B2 RID: 251058 RVA: 0x0080C292 File Offset: 0x0080A492
		public uint SortingLayerID_C199_UInt32
		{
			get
			{
				return 0U;
			}
			set
			{
			}
		}

		// Token: 0x170147CA RID: 83914
		// (get) Token: 0x0603D4B3 RID: 251059 RVA: 0x0080C294 File Offset: 0x0080A494
		// (set) Token: 0x0603D4B4 RID: 251060 RVA: 0x0080C29C File Offset: 0x0080A49C
		public int SortingLayerID_C199_Int32
		{
			get
			{
				return this.m_SortingLayerID;
			}
			set
			{
				this.m_SortingLayerID = value;
			}
		}

		// Token: 0x170147CB RID: 83915
		// (get) Token: 0x0603D4B5 RID: 251061 RVA: 0x0080C2A5 File Offset: 0x0080A4A5
		// (set) Token: 0x0603D4B6 RID: 251062 RVA: 0x0080C2AD File Offset: 0x0080A4AD
		public short SortingOrder_C199
		{
			get
			{
				return this.m_SortingOrder;
			}
			set
			{
				this.m_SortingOrder = value;
			}
		}

		// Token: 0x170147CC RID: 83916
		// (get) Token: 0x0603D4B7 RID: 251063 RVA: 0x0080C2B6 File Offset: 0x0080A4B6
		// (set) Token: 0x0603D4B8 RID: 251064 RVA: 0x0080C2B9 File Offset: 0x0080A4B9
		public int SortMode_C199_Int32
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x170147CD RID: 83917
		// (get) Token: 0x0603D4B9 RID: 251065 RVA: 0x0080C2BB File Offset: 0x0080A4BB
		// (set) Token: 0x0603D4BA RID: 251066 RVA: 0x0080C2C3 File Offset: 0x0080A4C3
		public ushort SortMode_C199_UInt16
		{
			get
			{
				return this.m_SortMode;
			}
			set
			{
				this.m_SortMode = value;
			}
		}

		// Token: 0x170147CE RID: 83918
		// (get) Token: 0x0603D4BB RID: 251067 RVA: 0x0080C2CC File Offset: 0x0080A4CC
		// (set) Token: 0x0603D4BC RID: 251068 RVA: 0x0080C2CF File Offset: 0x0080A4CF
		public byte SortMode_C199_Byte
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x170147CF RID: 83919
		// (get) Token: 0x0603D4BD RID: 251069 RVA: 0x0080C2D1 File Offset: 0x0080A4D1
		public StaticBatchInfo StaticBatchInfo_C199
		{
			[return: NotNull]
			get
			{
				return this.m_StaticBatchInfo;
			}
		}

		// Token: 0x170147D0 RID: 83920
		// (get) Token: 0x0603D4BE RID: 251070 RVA: 0x0080C2D9 File Offset: 0x0080A4D9

		public IPPtr_Transform StaticBatchRoot_C199
		{

			get
			{
				return this.m_StaticBatchRoot;
			}
		}

		// Token: 0x170147D1 RID: 83921
		// (get) Token: 0x0603D4BF RID: 251071 RVA: 0x0080C2E1 File Offset: 0x0080A4E1
		// (set) Token: 0x0603D4C0 RID: 251072 RVA: 0x0080C2E4 File Offset: 0x0080A4E4
		public byte StaticShadowCaster_C199
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x170147D2 RID: 83922
		// (get) Token: 0x0603D4C1 RID: 251073 RVA: 0x0080C2E6 File Offset: 0x0080A4E6
		// (set) Token: 0x0603D4C2 RID: 251074 RVA: 0x0080C2E9 File Offset: 0x0080A4E9
		public bool StitchLightmapSeams_C199
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x170147D3 RID: 83923
		// (get) Token: 0x0603D4C3 RID: 251075 RVA: 0x0080C2EB File Offset: 0x0080A4EB
		// (set) Token: 0x0603D4C4 RID: 251076 RVA: 0x0080C2EE File Offset: 0x0080A4EE
		public bool StitchSeams_C199
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x170147D4 RID: 83924
		// (get) Token: 0x0603D4C5 RID: 251077 RVA: 0x0080C2F0 File Offset: 0x0080A4F0
		// (set) Token: 0x0603D4C6 RID: 251078 RVA: 0x0080C2F3 File Offset: 0x0080A4F3
		public uint[] SubsetIndices_C199
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x170147D5 RID: 83925
		// (get) Token: 0x0603D4C7 RID: 251079 RVA: 0x0080C2F5 File Offset: 0x0080A4F5
		// (set) Token: 0x0603D4C8 RID: 251080 RVA: 0x0080C2FD File Offset: 0x0080A4FD
		public bool UseCustomVertexStreams_C199
		{
			get
			{
				return this.m_UseCustomVertexStreams;
			}
			set
			{
				this.m_UseCustomVertexStreams = value;
			}
		}

		// Token: 0x170147D6 RID: 83926
		// (get) Token: 0x0603D4C9 RID: 251081 RVA: 0x0080C306 File Offset: 0x0080A506
		// (set) Token: 0x0603D4CA RID: 251082 RVA: 0x0080C309 File Offset: 0x0080A509
		public bool UseLightProbes_C199
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x170147D7 RID: 83927
		// (get) Token: 0x0603D4CB RID: 251083 RVA: 0x0080C30B File Offset: 0x0080A50B
		// (set) Token: 0x0603D4CC RID: 251084 RVA: 0x0080C313 File Offset: 0x0080A513
		public float VelocityScale_C199
		{
			get
			{
				return this.m_VelocityScale;
			}
			set
			{
				this.m_VelocityScale = value;
			}
		}

		// Token: 0x170147D8 RID: 83928
		// (get) Token: 0x0603D4CD RID: 251085 RVA: 0x0080C31C File Offset: 0x0080A51C
		// (set) Token: 0x0603D4CE RID: 251086 RVA: 0x0080C31F File Offset: 0x0080A51F
		public int VertexStreamMask_C199
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x170147D9 RID: 83929
		// (get) Token: 0x0603D4CF RID: 251087 RVA: 0x0080C321 File Offset: 0x0080A521
		// (set) Token: 0x0603D4D0 RID: 251088 RVA: 0x0080C329 File Offset: 0x0080A529
		public byte[] VertexStreams_C199
		{
			[return: NotNull]
			get
			{
				return this.m_VertexStreams;
			}
			set
			{
				this.m_VertexStreams = value ?? Array.Empty<byte>();
			}
		}

		// Token: 0x170147DA RID: 83930
		// (get) Token: 0x0603D4D1 RID: 251089 RVA: 0x0080C33B File Offset: 0x0080A53B
		// (set) Token: 0x0603D4D2 RID: 251090 RVA: 0x0080C343 File Offset: 0x0080A543
		public HideFlags HideFlags_C199E
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

		// Token: 0x170147DB RID: 83931
		// (get) Token: 0x0603D4D3 RID: 251091 RVA: 0x0080C34C File Offset: 0x0080A54C
		// (set) Token: 0x0603D4D4 RID: 251092 RVA: 0x0080C354 File Offset: 0x0080A554
		public LightProbeUsage LightProbeUsage_C199E
		{
			get
			{
				return (LightProbeUsage)this.m_LightProbeUsage;
			}
			set
			{
				this.m_LightProbeUsage = (byte)value;
			}
		}

		// Token: 0x170147DC RID: 83932
		// (get) Token: 0x0603D4D5 RID: 251093 RVA: 0x0080C35E File Offset: 0x0080A55E
		// (set) Token: 0x0603D4D6 RID: 251094 RVA: 0x0080C366 File Offset: 0x0080A566
		public SpriteMaskInteraction MaskInteraction_C199E
		{
			get
			{
				return (SpriteMaskInteraction)this.m_MaskInteraction;
			}
			set
			{
				this.m_MaskInteraction = (int)value;
			}
		}

		// Token: 0x170147DD RID: 83933
		// (get) Token: 0x0603D4D7 RID: 251095 RVA: 0x0080C36F File Offset: 0x0080A56F
		// (set) Token: 0x0603D4D8 RID: 251096 RVA: 0x0080C372 File Offset: 0x0080A572
		public ParticleSystemMeshDistribution MeshDistribution_C199E
		{
			get
			{
				return ParticleSystemMeshDistribution.UniformRandom;
			}
			set
			{
			}
		}

		// Token: 0x170147DE RID: 83934
		// (get) Token: 0x0603D4D9 RID: 251097 RVA: 0x0080C374 File Offset: 0x0080A574
		// (set) Token: 0x0603D4DA RID: 251098 RVA: 0x0080C377 File Offset: 0x0080A577
		public RayTracingMode RayTracingMode_C199E
		{
			get
			{
				return RayTracingMode.Off;
			}
			set
			{
			}
		}

		// Token: 0x170147DF RID: 83935
		// (get) Token: 0x0603D4DB RID: 251099 RVA: 0x0080C379 File Offset: 0x0080A579
		// (set) Token: 0x0603D4DC RID: 251100 RVA: 0x0080C37C File Offset: 0x0080A57C
		public ReflectionProbeUsage ReflectionProbeUsage_C199_Int32E
		{
			get
			{
				return ReflectionProbeUsage.Off;
			}
			set
			{
			}
		}

		// Token: 0x170147E0 RID: 83936
		// (get) Token: 0x0603D4DD RID: 251101 RVA: 0x0080C37E File Offset: 0x0080A57E
		// (set) Token: 0x0603D4DE RID: 251102 RVA: 0x0080C386 File Offset: 0x0080A586
		public ReflectionProbeUsage ReflectionProbeUsage_C199_ByteE
		{
			get
			{
				return (ReflectionProbeUsage)this.m_ReflectionProbeUsage;
			}
			set
			{
				this.m_ReflectionProbeUsage = (byte)value;
			}
		}

		// Token: 0x170147E1 RID: 83937
		// (get) Token: 0x0603D4DF RID: 251103 RVA: 0x0080C390 File Offset: 0x0080A590
		// (set) Token: 0x0603D4E0 RID: 251104 RVA: 0x0080C398 File Offset: 0x0080A598
		public ParticleSystemRenderSpace RenderAlignment_C199E
		{
			get
			{
				return (ParticleSystemRenderSpace)this.m_RenderAlignment;
			}
			set
			{
				this.m_RenderAlignment = (int)value;
			}
		}

		// Token: 0x170147E2 RID: 83938
		// (get) Token: 0x0603D4E1 RID: 251105 RVA: 0x0080C3A1 File Offset: 0x0080A5A1
		// (set) Token: 0x0603D4E2 RID: 251106 RVA: 0x0080C3A4 File Offset: 0x0080A5A4
		public ParticleSystemRenderMode RenderMode_C199_Int32E
		{
			get
			{
				return ParticleSystemRenderMode.Billboard;
			}
			set
			{
			}
		}

		// Token: 0x170147E3 RID: 83939
		// (get) Token: 0x0603D4E3 RID: 251107 RVA: 0x0080C3A6 File Offset: 0x0080A5A6
		// (set) Token: 0x0603D4E4 RID: 251108 RVA: 0x0080C3AE File Offset: 0x0080A5AE
		public ParticleSystemRenderMode RenderMode_C199_UInt16E
		{
			get
			{
				return (ParticleSystemRenderMode)this.m_RenderMode;
			}
			set
			{
				this.m_RenderMode = (ushort)value;
			}
		}

		// Token: 0x170147E4 RID: 83940
		// (get) Token: 0x0603D4E5 RID: 251109 RVA: 0x0080C3B8 File Offset: 0x0080A5B8
		// (set) Token: 0x0603D4E6 RID: 251110 RVA: 0x0080C3C0 File Offset: 0x0080A5C0
		public ParticleSystemSortMode SortMode_C199_UInt16E
		{
			get
			{
				return (ParticleSystemSortMode)this.m_SortMode;
			}
			set
			{
				this.m_SortMode = (ushort)value;
			}
		}

		// Token: 0x170147E5 RID: 83941
		// (get) Token: 0x0603D4E7 RID: 251111 RVA: 0x0080C3CA File Offset: 0x0080A5CA
		// (set) Token: 0x0603D4E8 RID: 251112 RVA: 0x0080C3CD File Offset: 0x0080A5CD
		public ParticleSystemSortMode SortMode_C199_ByteE
		{
			get
			{
				return ParticleSystemSortMode.None;
			}
			set
			{
			}
		}

		// Token: 0x170147E6 RID: 83942
		// (get) Token: 0x0603D4E9 RID: 251113 RVA: 0x0080C3CF File Offset: 0x0080A5CF
		// (set) Token: 0x0603D4EA RID: 251114 RVA: 0x0080C3E2 File Offset: 0x0080A5E2
		public IEditorExtension CorrespondingSourceObject_C199P
		{
			get
			{
				return PPtrExtensions.TryGetAsset<IEditorExtension>(this.CorrespondingSourceObject_C199, base.Collection);
			}
			set
			{
				PPtrExtensions.SetAsset<IEditorExtension>(this.CorrespondingSourceObject_C199, base.Collection, value);
			}
		}

		// Token: 0x170147E7 RID: 83943
		// (get) Token: 0x0603D4EB RID: 251115 RVA: 0x0080C3F6 File Offset: 0x0080A5F6
		// (set) Token: 0x0603D4EC RID: 251116 RVA: 0x0080C409 File Offset: 0x0080A609
		public IGameObject GameObject_C199P
		{
			get
			{
				return PPtrExtensions.TryGetAsset<IGameObject>(this.GameObject_C199, base.Collection);
			}
			set
			{
				PPtrExtensions.SetAsset<IGameObject>(this.GameObject_C199, base.Collection, value);
			}
		}

		// Token: 0x170147E8 RID: 83944
		// (get) Token: 0x0603D4ED RID: 251117 RVA: 0x0080C41D File Offset: 0x0080A61D
		// (set) Token: 0x0603D4EE RID: 251118 RVA: 0x0080C430 File Offset: 0x0080A630
		public ILightmapParameters LightmapParameters_C199P
		{
			get
			{
				return PPtrExtensions.TryGetAsset<ILightmapParameters>(this.LightmapParameters_C199, base.Collection);
			}
			set
			{
				PPtrExtensions.SetAsset<ILightmapParameters>(this.LightmapParameters_C199, base.Collection, value);
			}
		}

		// Token: 0x170147E9 RID: 83945
		// (get) Token: 0x0603D4EF RID: 251119 RVA: 0x0080C444 File Offset: 0x0080A644
		// (set) Token: 0x0603D4F0 RID: 251120 RVA: 0x0080C447 File Offset: 0x0080A647
		public ITransform LightProbeAnchor_C199P
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x170147EA RID: 83946
		// (get) Token: 0x0603D4F1 RID: 251121 RVA: 0x0080C449 File Offset: 0x0080A649
		// (set) Token: 0x0603D4F2 RID: 251122 RVA: 0x0080C45C File Offset: 0x0080A65C
		public IGameObject LightProbeVolumeOverride_C199P
		{
			get
			{
				return PPtrExtensions.TryGetAsset<IGameObject>(this.LightProbeVolumeOverride_C199, base.Collection);
			}
			set
			{
				PPtrExtensions.SetAsset<IGameObject>(this.LightProbeVolumeOverride_C199, base.Collection, value);
			}
		}

		// Token: 0x170147EB RID: 83947
		// (get) Token: 0x0603D4F3 RID: 251123 RVA: 0x0080C470 File Offset: 0x0080A670
		public PPtrAccessList<IPPtr_Material, IMaterial> Materials_C199P
		{
			get
			{
				return new PPtrAccessList<IPPtr_Material, IMaterial>(this.Materials_C199, this);
			}
		}

		// Token: 0x170147EC RID: 83948
		// (get) Token: 0x0603D4F4 RID: 251124 RVA: 0x0080C47E File Offset: 0x0080A67E
		// (set) Token: 0x0603D4F5 RID: 251125 RVA: 0x0080C491 File Offset: 0x0080A691
		public IMesh Mesh_C199P
		{
			get
			{
				return PPtrExtensions.TryGetAsset<IMesh>(this.Mesh_C199, base.Collection);
			}
			set
			{
				PPtrExtensions.SetAsset<IMesh>(this.Mesh_C199, base.Collection, value);
			}
		}

		// Token: 0x170147ED RID: 83949
		// (get) Token: 0x0603D4F6 RID: 251126 RVA: 0x0080C4A5 File Offset: 0x0080A6A5
		// (set) Token: 0x0603D4F7 RID: 251127 RVA: 0x0080C4B8 File Offset: 0x0080A6B8
		public IMesh Mesh1_C199P
		{
			get
			{
				return PPtrExtensions.TryGetAsset<IMesh>(this.Mesh1_C199, base.Collection);
			}
			set
			{
				PPtrExtensions.SetAsset<IMesh>(this.Mesh1_C199, base.Collection, value);
			}
		}

		// Token: 0x170147EE RID: 83950
		// (get) Token: 0x0603D4F8 RID: 251128 RVA: 0x0080C4CC File Offset: 0x0080A6CC
		// (set) Token: 0x0603D4F9 RID: 251129 RVA: 0x0080C4DF File Offset: 0x0080A6DF
		public IMesh Mesh2_C199P
		{
			get
			{
				return PPtrExtensions.TryGetAsset<IMesh>(this.Mesh2_C199, base.Collection);
			}
			set
			{
				PPtrExtensions.SetAsset<IMesh>(this.Mesh2_C199, base.Collection, value);
			}
		}

		// Token: 0x170147EF RID: 83951
		// (get) Token: 0x0603D4FA RID: 251130 RVA: 0x0080C4F3 File Offset: 0x0080A6F3
		// (set) Token: 0x0603D4FB RID: 251131 RVA: 0x0080C506 File Offset: 0x0080A706
		public IMesh Mesh3_C199P
		{
			get
			{
				return PPtrExtensions.TryGetAsset<IMesh>(this.Mesh3_C199, base.Collection);
			}
			set
			{
				PPtrExtensions.SetAsset<IMesh>(this.Mesh3_C199, base.Collection, value);
			}
		}

		// Token: 0x170147F0 RID: 83952
		// (get) Token: 0x0603D4FC RID: 251132 RVA: 0x0080C51A File Offset: 0x0080A71A
		// (set) Token: 0x0603D4FD RID: 251133 RVA: 0x0080C51D File Offset: 0x0080A71D
		public IPrefab PrefabAsset_C199P
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x170147F1 RID: 83953
		// (get) Token: 0x0603D4FE RID: 251134 RVA: 0x0080C51F File Offset: 0x0080A71F
		// (set) Token: 0x0603D4FF RID: 251135 RVA: 0x0080C522 File Offset: 0x0080A722
		public IPrefabInstance PrefabInstance_C199P
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x170147F2 RID: 83954
		// (get) Token: 0x0603D500 RID: 251136 RVA: 0x0080C524 File Offset: 0x0080A724
		// (set) Token: 0x0603D501 RID: 251137 RVA: 0x0080C537 File Offset: 0x0080A737
		public IPrefabMarker PrefabInternal_C199P
		{
			get
			{
				return PPtrExtensions.TryGetAsset<IPrefabMarker>(this.PrefabInternal_C199, base.Collection);
			}
			set
			{
				PPtrExtensions.SetAsset<IPrefabMarker>(this.PrefabInternal_C199, base.Collection, value);
			}
		}

		// Token: 0x170147F3 RID: 83955
		// (get) Token: 0x0603D502 RID: 251138 RVA: 0x0080C54B File Offset: 0x0080A74B
		// (set) Token: 0x0603D503 RID: 251139 RVA: 0x0080C55E File Offset: 0x0080A75E
		public ITransform ProbeAnchor_C199P
		{
			get
			{
				return PPtrExtensions.TryGetAsset<ITransform>(this.ProbeAnchor_C199, base.Collection);
			}
			set
			{
				PPtrExtensions.SetAsset<ITransform>(this.ProbeAnchor_C199, base.Collection, value);
			}
		}

		// Token: 0x170147F4 RID: 83956
		// (get) Token: 0x0603D504 RID: 251140 RVA: 0x0080C572 File Offset: 0x0080A772
		// (set) Token: 0x0603D505 RID: 251141 RVA: 0x0080C585 File Offset: 0x0080A785
		public ITransform StaticBatchRoot_C199P
		{
			get
			{
				return PPtrExtensions.TryGetAsset<ITransform>(this.StaticBatchRoot_C199, base.Collection);
			}
			set
			{
				PPtrExtensions.SetAsset<ITransform>(this.StaticBatchRoot_C199, base.Collection, value);
			}
		}

		// Token: 0x170147F5 RID: 83957
		// (get) Token: 0x0603D506 RID: 251142 RVA: 0x0080C599 File Offset: 0x0080A799

		public override string ClassName
		{

			get
			{
				return "ParticleSystemRenderer";
			}
		}

		// Token: 0x0603D507 RID: 251143 RVA: 0x0080C5A0 File Offset: 0x0080A7A0
		public ParticleSystemRenderer_2017_1_0_GICB2()
			: this(AssetInfo.MakeDummyAssetInfo(199))
		{
		}

		// Token: 0x0603D508 RID: 251144 RVA: 0x0080C5B4 File Offset: 0x0080A7B4
		public ParticleSystemRenderer_2017_1_0_GICB2(AssetInfo info)
			: base(info)
		{
			this.m_Pivot = new Vector3f_3_5_0();
			this.m_VertexStreams = Array.Empty<byte>();
			this.m_Mesh = new PPtr_Mesh_5_0_0();
			this.m_Mesh1 = new PPtr_Mesh_5_0_0();
			this.m_Mesh2 = new PPtr_Mesh_5_0_0();
			this.m_Mesh3 = new PPtr_Mesh_5_0_0();
		}

		// Token: 0x0603D509 RID: 251145 RVA: 0x0080C60A File Offset: 0x0080A80A
		public bool Has_AllowRoll_C199()
		{
			return false;
		}

		// Token: 0x0603D50A RID: 251146 RVA: 0x0080C60D File Offset: 0x0080A80D
		public bool Has_ApplyActiveColorSpace_C199()
		{
			return false;
		}

		// Token: 0x0603D50B RID: 251147 RVA: 0x0080C610 File Offset: 0x0080A810
		public bool Has_AutoUVMaxAngle_C199()
		{
			return true;
		}

		// Token: 0x0603D50C RID: 251148 RVA: 0x0080C613 File Offset: 0x0080A813
		public bool Has_AutoUVMaxDistance_C199()
		{
			return true;
		}

		// Token: 0x0603D50D RID: 251149 RVA: 0x0080C616 File Offset: 0x0080A816
		public bool Has_CastShadows_C199_Boolean()
		{
			return false;
		}

		// Token: 0x0603D50E RID: 251150 RVA: 0x0080C619 File Offset: 0x0080A819
		public bool Has_CastShadows_C199_Byte()
		{
			return true;
		}

		// Token: 0x0603D50F RID: 251151 RVA: 0x0080C61C File Offset: 0x0080A81C
		public bool Has_DynamicOccludee_C199()
		{
			return false;
		}

		// Token: 0x0603D510 RID: 251152 RVA: 0x0080C61F File Offset: 0x0080A81F
		public bool Has_EnableGPUInstancing_C199()
		{
			return false;
		}

		// Token: 0x0603D511 RID: 251153 RVA: 0x0080C622 File Offset: 0x0080A822
		public bool Has_Flip_C199()
		{
			return false;
		}

		// Token: 0x0603D512 RID: 251154 RVA: 0x0080C625 File Offset: 0x0080A825
		public bool Has_FreeformStretching_C199()
		{
			return false;
		}

		// Token: 0x0603D513 RID: 251155 RVA: 0x0080C628 File Offset: 0x0080A828
		public bool Has_IgnoreNormalsForChartDetection_C199()
		{
			return true;
		}

		// Token: 0x0603D514 RID: 251156 RVA: 0x0080C62B File Offset: 0x0080A82B
		public bool Has_ImportantGI_C199()
		{
			return true;
		}

		// Token: 0x0603D515 RID: 251157 RVA: 0x0080C62E File Offset: 0x0080A82E
		public bool Has_LightmapIndex_C199_Byte()
		{
			return false;
		}

		// Token: 0x0603D516 RID: 251158 RVA: 0x0080C631 File Offset: 0x0080A831
		public bool Has_LightmapIndex_C199_UInt16()
		{
			return true;
		}

		// Token: 0x0603D517 RID: 251159 RVA: 0x0080C634 File Offset: 0x0080A834
		public bool Has_LightmapIndexDynamic_C199()
		{
			return true;
		}

		// Token: 0x0603D518 RID: 251160 RVA: 0x0080C637 File Offset: 0x0080A837
		public bool Has_LightmapParameters_C199()
		{
			return true;
		}

		// Token: 0x0603D519 RID: 251161 RVA: 0x0080C63A File Offset: 0x0080A83A
		public bool Has_LightmapTilingOffsetDynamic_C199()
		{
			return true;
		}

		// Token: 0x0603D51A RID: 251162 RVA: 0x0080C63D File Offset: 0x0080A83D
		public bool Has_LightProbeAnchor_C199()
		{
			return false;
		}

		// Token: 0x0603D51B RID: 251163 RVA: 0x0080C640 File Offset: 0x0080A840
		public bool Has_LightProbeUsage_C199()
		{
			return true;
		}

		// Token: 0x0603D51C RID: 251164 RVA: 0x0080C643 File Offset: 0x0080A843
		public bool Has_LightProbeVolumeOverride_C199()
		{
			return true;
		}

		// Token: 0x0603D51D RID: 251165 RVA: 0x0080C646 File Offset: 0x0080A846
		public bool Has_MaskInteraction_C199()
		{
			return true;
		}

		// Token: 0x0603D51E RID: 251166 RVA: 0x0080C649 File Offset: 0x0080A849
		public bool Has_Mesh1_C199()
		{
			return true;
		}

		// Token: 0x0603D51F RID: 251167 RVA: 0x0080C64C File Offset: 0x0080A84C
		public bool Has_Mesh2_C199()
		{
			return true;
		}

		// Token: 0x0603D520 RID: 251168 RVA: 0x0080C64F File Offset: 0x0080A84F
		public bool Has_Mesh3_C199()
		{
			return true;
		}

		// Token: 0x0603D521 RID: 251169 RVA: 0x0080C652 File Offset: 0x0080A852
		public bool Has_MeshDistribution_C199()
		{
			return false;
		}

		// Token: 0x0603D522 RID: 251170 RVA: 0x0080C655 File Offset: 0x0080A855
		public bool Has_MeshWeighting_C199()
		{
			return false;
		}

		// Token: 0x0603D523 RID: 251171 RVA: 0x0080C658 File Offset: 0x0080A858
		public bool Has_MeshWeighting1_C199()
		{
			return false;
		}

		// Token: 0x0603D524 RID: 251172 RVA: 0x0080C65B File Offset: 0x0080A85B
		public bool Has_MeshWeighting2_C199()
		{
			return false;
		}

		// Token: 0x0603D525 RID: 251173 RVA: 0x0080C65E File Offset: 0x0080A85E
		public bool Has_MeshWeighting3_C199()
		{
			return false;
		}

		// Token: 0x0603D526 RID: 251174 RVA: 0x0080C661 File Offset: 0x0080A861
		public bool Has_MinimumChartSize_C199()
		{
			return true;
		}

		// Token: 0x0603D527 RID: 251175 RVA: 0x0080C664 File Offset: 0x0080A864
		public bool Has_MinParticleSize_C199()
		{
			return true;
		}

		// Token: 0x0603D528 RID: 251176 RVA: 0x0080C667 File Offset: 0x0080A867
		public bool Has_MotionVectors_C199()
		{
			return true;
		}

		// Token: 0x0603D529 RID: 251177 RVA: 0x0080C66A File Offset: 0x0080A86A
		public bool Has_NormalDirection_C199()
		{
			return true;
		}

		// Token: 0x0603D52A RID: 251178 RVA: 0x0080C66D File Offset: 0x0080A86D
		public bool Has_Pivot_C199()
		{
			return true;
		}

		// Token: 0x0603D52B RID: 251179 RVA: 0x0080C670 File Offset: 0x0080A870
		public bool Has_PrefabAsset_C199()
		{
			return false;
		}

		// Token: 0x0603D52C RID: 251180 RVA: 0x0080C673 File Offset: 0x0080A873
		public bool Has_PrefabInstance_C199()
		{
			return false;
		}

		// Token: 0x0603D52D RID: 251181 RVA: 0x0080C676 File Offset: 0x0080A876
		public bool Has_PrefabInternal_C199()
		{
			return true;
		}

		// Token: 0x0603D52E RID: 251182 RVA: 0x0080C679 File Offset: 0x0080A879
		public bool Has_PreserveUVs_C199()
		{
			return true;
		}

		// Token: 0x0603D52F RID: 251183 RVA: 0x0080C67C File Offset: 0x0080A87C
		public bool Has_ProbeAnchor_C199()
		{
			return true;
		}

		// Token: 0x0603D530 RID: 251184 RVA: 0x0080C67F File Offset: 0x0080A87F
		public bool Has_RayTraceProcedural_C199()
		{
			return false;
		}

		// Token: 0x0603D531 RID: 251185 RVA: 0x0080C682 File Offset: 0x0080A882
		public bool Has_RayTracingMode_C199()
		{
			return false;
		}

		// Token: 0x0603D532 RID: 251186 RVA: 0x0080C685 File Offset: 0x0080A885
		public bool Has_ReceiveGI_C199()
		{
			return false;
		}

		// Token: 0x0603D533 RID: 251187 RVA: 0x0080C688 File Offset: 0x0080A888
		public bool Has_ReceiveShadows_C199_Boolean()
		{
			return false;
		}

		// Token: 0x0603D534 RID: 251188 RVA: 0x0080C68B File Offset: 0x0080A88B
		public bool Has_ReceiveShadows_C199_Byte()
		{
			return true;
		}

		// Token: 0x0603D535 RID: 251189 RVA: 0x0080C68E File Offset: 0x0080A88E
		public bool Has_ReflectionProbeUsage_C199_Int32()
		{
			return false;
		}

		// Token: 0x0603D536 RID: 251190 RVA: 0x0080C691 File Offset: 0x0080A891
		public bool Has_ReflectionProbeUsage_C199_Byte()
		{
			return true;
		}

		// Token: 0x0603D537 RID: 251191 RVA: 0x0080C694 File Offset: 0x0080A894
		public bool Has_RenderAlignment_C199()
		{
			return true;
		}

		// Token: 0x0603D538 RID: 251192 RVA: 0x0080C697 File Offset: 0x0080A897
		public bool Has_RendererPriority_C199()
		{
			return false;
		}

		// Token: 0x0603D539 RID: 251193 RVA: 0x0080C69A File Offset: 0x0080A89A
		public bool Has_RenderingLayerMask_C199()
		{
			return false;
		}

		// Token: 0x0603D53A RID: 251194 RVA: 0x0080C69D File Offset: 0x0080A89D
		public bool Has_RenderMode_C199_Int32()
		{
			return false;
		}

		// Token: 0x0603D53B RID: 251195 RVA: 0x0080C6A0 File Offset: 0x0080A8A0
		public bool Has_RenderMode_C199_UInt16()
		{
			return true;
		}

		// Token: 0x0603D53C RID: 251196 RVA: 0x0080C6A3 File Offset: 0x0080A8A3
		public bool Has_RotateWithStretchDirection_C199()
		{
			return false;
		}

		// Token: 0x0603D53D RID: 251197 RVA: 0x0080C6A6 File Offset: 0x0080A8A6
		public bool Has_SelectedEditorRenderState_C199()
		{
			return true;
		}

		// Token: 0x0603D53E RID: 251198 RVA: 0x0080C6A9 File Offset: 0x0080A8A9
		public bool Has_SelectedWireframeHidden_C199()
		{
			return false;
		}

		// Token: 0x0603D53F RID: 251199 RVA: 0x0080C6AC File Offset: 0x0080A8AC
		public bool Has_ShadowBias_C199()
		{
			return false;
		}

		// Token: 0x0603D540 RID: 251200 RVA: 0x0080C6AF File Offset: 0x0080A8AF
		public bool Has_SortingLayer_C199()
		{
			return true;
		}

		// Token: 0x0603D541 RID: 251201 RVA: 0x0080C6B2 File Offset: 0x0080A8B2
		public bool Has_SortingLayerID_C199_UInt32()
		{
			return false;
		}

		// Token: 0x0603D542 RID: 251202 RVA: 0x0080C6B5 File Offset: 0x0080A8B5
		public bool Has_SortingLayerID_C199_Int32()
		{
			return true;
		}

		// Token: 0x0603D543 RID: 251203 RVA: 0x0080C6B8 File Offset: 0x0080A8B8
		public bool Has_SortingOrder_C199()
		{
			return true;
		}

		// Token: 0x0603D544 RID: 251204 RVA: 0x0080C6BB File Offset: 0x0080A8BB
		public bool Has_SortMode_C199_Int32()
		{
			return false;
		}

		// Token: 0x0603D545 RID: 251205 RVA: 0x0080C6BE File Offset: 0x0080A8BE
		public bool Has_SortMode_C199_UInt16()
		{
			return true;
		}

		// Token: 0x0603D546 RID: 251206 RVA: 0x0080C6C1 File Offset: 0x0080A8C1
		public bool Has_SortMode_C199_Byte()
		{
			return false;
		}

		// Token: 0x0603D547 RID: 251207 RVA: 0x0080C6C4 File Offset: 0x0080A8C4
		public bool Has_StaticBatchInfo_C199()
		{
			return true;
		}

		// Token: 0x0603D548 RID: 251208 RVA: 0x0080C6C7 File Offset: 0x0080A8C7
		public bool Has_StaticShadowCaster_C199()
		{
			return false;
		}

		// Token: 0x0603D549 RID: 251209 RVA: 0x0080C6CA File Offset: 0x0080A8CA
		public bool Has_StitchLightmapSeams_C199()
		{
			return false;
		}

		// Token: 0x0603D54A RID: 251210 RVA: 0x0080C6CD File Offset: 0x0080A8CD
		public bool Has_StitchSeams_C199()
		{
			return false;
		}

		// Token: 0x0603D54B RID: 251211 RVA: 0x0080C6D0 File Offset: 0x0080A8D0
		public bool Has_SubsetIndices_C199()
		{
			return false;
		}

		// Token: 0x0603D54C RID: 251212 RVA: 0x0080C6D3 File Offset: 0x0080A8D3
		public bool Has_UseCustomVertexStreams_C199()
		{
			return true;
		}

		// Token: 0x0603D54D RID: 251213 RVA: 0x0080C6D6 File Offset: 0x0080A8D6
		public bool Has_UseLightProbes_C199()
		{
			return false;
		}

		// Token: 0x0603D54E RID: 251214 RVA: 0x0080C6D9 File Offset: 0x0080A8D9
		public bool Has_VertexStreamMask_C199()
		{
			return false;
		}

		// Token: 0x0603D54F RID: 251215 RVA: 0x0080C6DC File Offset: 0x0080A8DC
		public bool Has_VertexStreams_C199()
		{
			return true;
		}

		// Token: 0x0603D550 RID: 251216 RVA: 0x0080C6E0 File Offset: 0x0080A8E0

		public override void ReadRelease(AssetReader reader)
		{
			this.m_GameObject.ReadRelease(reader);
			this.m_Enabled = reader.ReadBoolean();
			this.m_CastShadows = reader.ReadByte();
			this.m_ReceiveShadows = reader.ReadByte();

			// GICB2
			var m_ReceiveDecals = reader.ReadByte();
			var m_EnableShadowCulling = reader.ReadByte();
			var m_EnableGpuQuery = reader.ReadByte();
			var m_AllowHalfResolution = reader.ReadByte();
			var m_IsRainOccluder = reader.ReadByte();
			var m_IsDynamic = reader.ReadByte();

			this.m_MotionVectors = reader.ReadByte();
			this.m_LightProbeUsage = reader.ReadByte();
			this.m_ReflectionProbeUsage = reader.ReadRelease_ByteAlign();
			this.m_LightmapIndex = reader.ReadUInt16();
			this.m_LightmapIndexDynamic = reader.ReadUInt16();
			this.m_LightmapTilingOffset.ReadRelease(reader);
			this.m_LightmapTilingOffsetDynamic.ReadRelease(reader);

			// GICB2
			var m_ViewDistanceRatio = reader.ReadSingle();
			var m_ShaderLODDistanceRatio = reader.ReadSingle();

			this.m_Materials.ReadRelease_ArrayAlign_Asset(reader);
			this.m_StaticBatchInfo.ReadRelease(reader);
			this.m_StaticBatchRoot.ReadRelease(reader);

			var m_MatLayers = reader.ReadInt32(); // GICB2

			this.m_ProbeAnchor.ReadRelease(reader);
			this.m_LightProbeVolumeOverride.ReadRelease_AssetAlign(reader);
			this.m_SortingLayerID = reader.ReadInt32();
			this.m_SortingLayer = reader.ReadInt16();
			this.m_SortingOrder = reader.ReadRelease_Int16Align();

			// GICB2
			var m_UseHighestMip = reader.ReadBoolean();
			reader.AlignStream();

			this.m_RenderMode = reader.ReadUInt16();
			this.m_SortMode = reader.ReadUInt16();
			this.m_MinParticleSize = reader.ReadSingle();
			this.m_MaxParticleSize = reader.ReadSingle();
			this.m_CameraVelocityScale = reader.ReadSingle();
			this.m_VelocityScale = reader.ReadSingle();
			this.m_LengthScale = reader.ReadSingle();
			this.m_SortingFudge = reader.ReadSingle();
			this.m_NormalDirection = reader.ReadSingle();
			this.m_RenderAlignment = reader.ReadInt32();
			this.m_Pivot.ReadRelease(reader);
			this.m_UseCustomVertexStreams = reader.ReadRelease_BooleanAlign();

			// GICB2
			this.m_EnableGPUInstancing = reader.ReadBoolean();
			UseOctagonShape = reader.ReadBoolean();
			reader.AlignStream();
			OctagonCoordinate = reader.ReadAssetArray<Vector2f_3_5_0>(false);
			reader.AlignStream();
			RotateWithParent = reader.ReadBoolean();
			reader.AlignStream();
			ParentScale = reader.ReadAsset<Vector3f_3_5_0>();
			ParentRotation = reader.ReadAsset<Vector4f_3_5_0>();

			this.m_VertexStreams = reader.ReadRelease_ArrayAlign_Byte();
			this.m_Mesh.ReadRelease(reader);
			this.m_Mesh1.ReadRelease(reader);
			this.m_Mesh2.ReadRelease(reader);
			this.m_Mesh3.ReadRelease(reader);
			this.m_MaskInteraction = reader.ReadInt32();
		}

		// Token: 0x0603D551 RID: 251217 RVA: 0x0080C8AC File Offset: 0x0080AAAC

		public override void ReadEditor(AssetReader reader)
		{
		}

		// Token: 0x0603D552 RID: 251218 RVA: 0x0080CAD8 File Offset: 0x0080ACD8

		public override void WriteRelease(AssetWriter writer)
		{
			this.m_GameObject.WriteRelease(writer);
			this.m_Enabled.WriteRelease_Boolean(writer);
			this.m_CastShadows.WriteRelease_Byte(writer);
			this.m_ReceiveShadows.WriteRelease_Byte(writer);
			this.m_MotionVectors.WriteRelease_Byte(writer);
			this.m_LightProbeUsage.WriteRelease_Byte(writer);
			this.m_ReflectionProbeUsage.WriteRelease_ByteAlign(writer);
			this.m_LightmapIndex.WriteRelease_UInt16(writer);
			this.m_LightmapIndexDynamic.WriteRelease_UInt16(writer);
			this.m_LightmapTilingOffset.WriteRelease(writer);
			this.m_LightmapTilingOffsetDynamic.WriteRelease(writer);
			this.m_Materials.WriteRelease_ArrayAlign_Asset(writer);
			this.m_StaticBatchInfo.WriteRelease(writer);
			this.m_StaticBatchRoot.WriteRelease(writer);
			this.m_ProbeAnchor.WriteRelease(writer);
			this.m_LightProbeVolumeOverride.WriteRelease_AssetAlign(writer);
			this.m_SortingLayerID.WriteRelease_Int32(writer);
			this.m_SortingLayer.WriteRelease_Int16(writer);
			this.m_SortingOrder.WriteRelease_Int16Align(writer);
			this.m_RenderMode.WriteRelease_UInt16(writer);
			this.m_SortMode.WriteRelease_UInt16(writer);
			this.m_MinParticleSize.WriteRelease_Single(writer);
			this.m_MaxParticleSize.WriteRelease_Single(writer);
			this.m_CameraVelocityScale.WriteRelease_Single(writer);
			this.m_VelocityScale.WriteRelease_Single(writer);
			this.m_LengthScale.WriteRelease_Single(writer);
			this.m_SortingFudge.WriteRelease_Single(writer);
			this.m_NormalDirection.WriteRelease_Single(writer);
			this.m_RenderAlignment.WriteRelease_Int32(writer);
			this.m_Pivot.WriteRelease(writer);
			this.m_UseCustomVertexStreams.WriteRelease_BooleanAlign(writer);
			this.m_VertexStreams.WriteRelease_ArrayAlign_Byte(writer);
			this.m_Mesh.WriteRelease(writer);
			this.m_Mesh1.WriteRelease(writer);
			this.m_Mesh2.WriteRelease(writer);
			this.m_Mesh3.WriteRelease(writer);
			this.m_MaskInteraction.WriteRelease_Int32(writer);
		}

		// Token: 0x0603D553 RID: 251219 RVA: 0x0080CCA4 File Offset: 0x0080AEA4

		public override void WriteEditor(AssetWriter writer)
		{
		}

		// Token: 0x0603D554 RID: 251220 RVA: 0x0080CED0 File Offset: 0x0080B0D0

		public override YamlNode ExportYamlRelease(IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			YamlSerializedVersionExtensions.AddSerializedVersion(yamlMappingNode, 3);
			yamlMappingNode.Add(new YamlScalarNode("m_GameObject"), this.m_GameObject.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Enabled"), this.m_Enabled.ExportYamlRelease_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("m_CastShadows"), this.m_CastShadows.ExportYamlRelease_Byte(container));
			yamlMappingNode.Add(new YamlScalarNode("m_ReceiveShadows"), this.m_ReceiveShadows.ExportYamlRelease_Byte(container));
			yamlMappingNode.Add(new YamlScalarNode("m_MotionVectors"), this.m_MotionVectors.ExportYamlRelease_Byte(container));
			yamlMappingNode.Add(new YamlScalarNode("m_LightProbeUsage"), this.m_LightProbeUsage.ExportYamlRelease_Byte(container));
			yamlMappingNode.Add(new YamlScalarNode("m_ReflectionProbeUsage"), this.m_ReflectionProbeUsage.ExportYamlRelease_Byte(container));
			yamlMappingNode.Add(new YamlScalarNode("m_LightmapIndex"), this.m_LightmapIndex.ExportYamlRelease_UInt16(container));
			yamlMappingNode.Add(new YamlScalarNode("m_LightmapIndexDynamic"), this.m_LightmapIndexDynamic.ExportYamlRelease_UInt16(container));
			yamlMappingNode.Add(new YamlScalarNode("m_LightmapTilingOffset"), this.m_LightmapTilingOffset.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("m_LightmapTilingOffsetDynamic"), this.m_LightmapTilingOffsetDynamic.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Materials"), this.m_Materials.ExportYamlRelease_Array_PPtr_Material_5_0_0(container));
			yamlMappingNode.Add(new YamlScalarNode("m_StaticBatchInfo"), this.m_StaticBatchInfo.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("m_StaticBatchRoot"), this.m_StaticBatchRoot.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("m_ProbeAnchor"), this.m_ProbeAnchor.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("m_LightProbeVolumeOverride"), this.m_LightProbeVolumeOverride.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("m_SortingLayerID"), this.m_SortingLayerID.ExportYamlRelease_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("m_SortingLayer"), this.m_SortingLayer.ExportYamlRelease_Int16(container));
			yamlMappingNode.Add(new YamlScalarNode("m_SortingOrder"), this.m_SortingOrder.ExportYamlRelease_Int16(container));
			yamlMappingNode.Add(new YamlScalarNode("m_RenderMode"), this.m_RenderMode.ExportYamlRelease_UInt16(container));
			yamlMappingNode.Add(new YamlScalarNode("m_SortMode"), this.m_SortMode.ExportYamlRelease_UInt16(container));
			yamlMappingNode.Add(new YamlScalarNode("m_MinParticleSize"), this.m_MinParticleSize.ExportYamlRelease_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("m_MaxParticleSize"), this.m_MaxParticleSize.ExportYamlRelease_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("m_CameraVelocityScale"), this.m_CameraVelocityScale.ExportYamlRelease_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("m_VelocityScale"), this.m_VelocityScale.ExportYamlRelease_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("m_LengthScale"), this.m_LengthScale.ExportYamlRelease_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("m_SortingFudge"), this.m_SortingFudge.ExportYamlRelease_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("m_NormalDirection"), this.m_NormalDirection.ExportYamlRelease_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("m_RenderAlignment"), this.m_RenderAlignment.ExportYamlRelease_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Pivot"), this.m_Pivot.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("m_UseCustomVertexStreams"), this.m_UseCustomVertexStreams.ExportYamlRelease_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("m_VertexStreams"), this.m_VertexStreams.ExportYamlRelease_Array_Byte(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Mesh"), this.m_Mesh.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Mesh1"), this.m_Mesh1.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Mesh2"), this.m_Mesh2.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Mesh3"), this.m_Mesh3.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("m_MaskInteraction"), this.m_MaskInteraction.ExportYamlRelease_Int32(container));
			return yamlMappingNode;
		}

		// Token: 0x0603D555 RID: 251221 RVA: 0x0080D2F8 File Offset: 0x0080B4F8

		public override YamlNode ExportYamlEditor(IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			YamlSerializedVersionExtensions.AddSerializedVersion(yamlMappingNode, 3);
			yamlMappingNode.Add(new YamlScalarNode("m_ObjectHideFlags"), this.m_HideFlags.ExportYamlEditor_UInt32(container));
			yamlMappingNode.Add(new YamlScalarNode("m_PrefabParentObject"), this.m_CorrespondingSourceObject.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_PrefabInternal"), this.m_PrefabInternal.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_GameObject"), this.m_GameObject.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Enabled"), this.m_Enabled.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("m_CastShadows"), this.m_CastShadows.ExportYamlEditor_Byte(container));
			yamlMappingNode.Add(new YamlScalarNode("m_ReceiveShadows"), this.m_ReceiveShadows.ExportYamlEditor_Byte(container));
			yamlMappingNode.Add(new YamlScalarNode("m_MotionVectors"), this.m_MotionVectors.ExportYamlEditor_Byte(container));
			yamlMappingNode.Add(new YamlScalarNode("m_LightProbeUsage"), this.m_LightProbeUsage.ExportYamlEditor_Byte(container));
			yamlMappingNode.Add(new YamlScalarNode("m_ReflectionProbeUsage"), this.m_ReflectionProbeUsage.ExportYamlEditor_Byte(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Materials"), this.m_Materials.ExportYamlEditor_Array_PPtr_Material_5_0_0(container));
			yamlMappingNode.Add(new YamlScalarNode("m_StaticBatchInfo"), this.m_StaticBatchInfo.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_StaticBatchRoot"), this.m_StaticBatchRoot.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_ProbeAnchor"), this.m_ProbeAnchor.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_LightProbeVolumeOverride"), this.m_LightProbeVolumeOverride.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_ScaleInLightmap"), this.m_ScaleInLightmap.ExportYamlEditor_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("m_PreserveUVs"), this.m_PreserveUVs.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("m_IgnoreNormalsForChartDetection"), this.m_IgnoreNormalsForChartDetection.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("m_ImportantGI"), this.m_ImportantGI.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("m_SelectedEditorRenderState"), this.m_SelectedEditorRenderState.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("m_MinimumChartSize"), this.m_MinimumChartSize.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("m_AutoUVMaxDistance"), this.m_AutoUVMaxDistance.ExportYamlEditor_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("m_AutoUVMaxAngle"), this.m_AutoUVMaxAngle.ExportYamlEditor_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("m_LightmapParameters"), this.m_LightmapParameters.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_SortingLayerID"), this.m_SortingLayerID.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("m_SortingLayer"), this.m_SortingLayer.ExportYamlEditor_Int16(container));
			yamlMappingNode.Add(new YamlScalarNode("m_SortingOrder"), this.m_SortingOrder.ExportYamlEditor_Int16(container));
			yamlMappingNode.Add(new YamlScalarNode("m_RenderMode"), this.m_RenderMode.ExportYamlEditor_UInt16(container));
			yamlMappingNode.Add(new YamlScalarNode("m_SortMode"), this.m_SortMode.ExportYamlEditor_UInt16(container));
			yamlMappingNode.Add(new YamlScalarNode("m_MinParticleSize"), this.m_MinParticleSize.ExportYamlEditor_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("m_MaxParticleSize"), this.m_MaxParticleSize.ExportYamlEditor_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("m_CameraVelocityScale"), this.m_CameraVelocityScale.ExportYamlEditor_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("m_VelocityScale"), this.m_VelocityScale.ExportYamlEditor_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("m_LengthScale"), this.m_LengthScale.ExportYamlEditor_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("m_SortingFudge"), this.m_SortingFudge.ExportYamlEditor_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("m_NormalDirection"), this.m_NormalDirection.ExportYamlEditor_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("m_RenderAlignment"), this.m_RenderAlignment.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Pivot"), this.m_Pivot.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_UseCustomVertexStreams"), this.m_UseCustomVertexStreams.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("m_VertexStreams"), this.m_VertexStreams.ExportYamlEditor_Array_Byte(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Mesh"), this.m_Mesh.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Mesh1"), this.m_Mesh1.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Mesh2"), this.m_Mesh2.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Mesh3"), this.m_Mesh3.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_MaskInteraction"), this.m_MaskInteraction.ExportYamlEditor_Int32(container));
			return yamlMappingNode;
		}

		// Token: 0x0603D556 RID: 251222 RVA: 0x0080D800 File Offset: 0x0080BA00
		public override void Reset()
		{
			this.m_AutoUVMaxAngle = 0f;
			this.m_AutoUVMaxDistance = 0f;
			this.m_CameraVelocityScale = 0f;
			this.m_CastShadows = 0;
			this.m_CorrespondingSourceObject.Reset();
			this.m_Enabled = false;
			this.m_GameObject.Reset();
			this.m_HideFlags = 0U;
			this.m_IgnoreNormalsForChartDetection = false;
			this.m_ImportantGI = false;
			this.m_LengthScale = 0f;
			this.m_LightmapIndex = 0;
			this.m_LightmapIndexDynamic = 0;
			this.m_LightmapParameters.Reset();
			this.m_LightmapTilingOffset.Reset();
			this.m_LightmapTilingOffsetDynamic.Reset();
			this.m_LightProbeUsage = 0;
			this.m_LightProbeVolumeOverride.Reset();
			this.m_MaskInteraction = 0;
			this.m_Materials.Clear();
			this.m_MaxParticleSize = 0f;
			this.m_Mesh.Reset();
			this.m_Mesh1.Reset();
			this.m_Mesh2.Reset();
			this.m_Mesh3.Reset();
			this.m_MinimumChartSize = 0;
			this.m_MinParticleSize = 0f;
			this.m_MotionVectors = 0;
			this.m_NormalDirection = 0f;
			this.m_Pivot.Reset();
			this.m_PrefabInternal.Reset();
			this.m_PreserveUVs = false;
			this.m_ProbeAnchor.Reset();
			this.m_ReceiveShadows = 0;
			this.m_ReflectionProbeUsage = 0;
			this.m_RenderAlignment = 0;
			this.m_RenderMode = 0;
			this.m_ScaleInLightmap = 0f;
			this.m_SelectedEditorRenderState = 0;
			this.m_SortingFudge = 0f;
			this.m_SortingLayer = 0;
			this.m_SortingLayerID = 0;
			this.m_SortingOrder = 0;
			this.m_SortMode = 0;
			this.m_StaticBatchInfo.Reset();
			this.m_StaticBatchRoot.Reset();
			this.m_UseCustomVertexStreams = false;
			this.m_VelocityScale = 0f;
			this.m_VertexStreams = Array.Empty<byte>();
		}

		// Token: 0x0603D557 RID: 251223 RVA: 0x0080D9D0 File Offset: 0x0080BBD0
		//public override IEnumerable<ValueTuple<FieldName, PPtr<IUnityObjectBase>>> FetchDependencies(FieldName parent)
		//{
		//	return Enumerable.Empty<ValueTuple<FieldName, PPtr<IUnityObjectBase>>>().Append_ParticleSystemRenderer_2017_1_0(parent, this);
		//}

		// Token: 0x0603D558 RID: 251224 RVA: 0x0080D9E0 File Offset: 0x0080BBE0

		public void CopyValues(IParticleSystemRenderer source, PPtrConverter converter)
		{
			this.m_AutoUVMaxAngle = source.AutoUVMaxAngle_C199;
			this.m_AutoUVMaxDistance = source.AutoUVMaxDistance_C199;
			this.m_CameraVelocityScale = source.CameraVelocityScale_C199;
			this.m_CastShadows = source.CastShadows_C199_Byte;
			this.m_CorrespondingSourceObject.CopyValues(source.CorrespondingSourceObject_C199, converter);
			this.m_Enabled = source.Enabled_C199;
			this.m_GameObject.CopyValues(source.GameObject_C199, converter);
			this.m_HideFlags = source.HideFlags_C199;
			this.m_IgnoreNormalsForChartDetection = source.IgnoreNormalsForChartDetection_C199;
			this.m_ImportantGI = source.ImportantGI_C199;
			this.m_LengthScale = source.LengthScale_C199;
			this.m_LightmapIndex = source.LightmapIndex_C199_UInt16;
			this.m_LightmapIndexDynamic = source.LightmapIndexDynamic_C199;
			this.m_LightmapParameters.CopyValues(source.LightmapParameters_C199, converter);
			this.m_LightmapTilingOffset.CopyValues(source.LightmapTilingOffset_C199);
			this.m_LightmapTilingOffsetDynamic.CopyValues(source.LightmapTilingOffsetDynamic_C199);
			this.m_LightProbeUsage = source.LightProbeUsage_C199;
			this.m_LightProbeVolumeOverride.CopyValues(source.LightProbeVolumeOverride_C199, converter);
			this.m_MaskInteraction = source.MaskInteraction_C199;
			CopyValuesHelper.CopyValues__AssetList_PPtr_Material_5_0_0__AccessListBase_IPPtr_Material(this.m_Materials, source.Materials_C199, converter);
			this.m_MaxParticleSize = source.MaxParticleSize_C199;
			this.m_Mesh.CopyValues(source.Mesh_C199, converter);
			this.m_Mesh1.CopyValues(source.Mesh1_C199, converter);
			this.m_Mesh2.CopyValues(source.Mesh2_C199, converter);
			this.m_Mesh3.CopyValues(source.Mesh3_C199, converter);
			this.m_MinimumChartSize = source.MinimumChartSize_C199;
			this.m_MinParticleSize = source.MinParticleSize_C199;
			this.m_MotionVectors = source.MotionVectors_C199;
			this.m_NormalDirection = source.NormalDirection_C199;
			this.m_Pivot.CopyValues(source.Pivot_C199);
			this.m_PrefabInternal.CopyValues(source.PrefabInternal_C199, converter);
			this.m_PreserveUVs = source.PreserveUVs_C199;
			this.m_ProbeAnchor.CopyValues(source.ProbeAnchor_C199, converter);
			this.m_ReceiveShadows = source.ReceiveShadows_C199_Byte;
			this.m_ReflectionProbeUsage = source.ReflectionProbeUsage_C199_Byte;
			this.m_RenderAlignment = source.RenderAlignment_C199;
			this.m_RenderMode = source.RenderMode_C199_UInt16;
			this.m_ScaleInLightmap = source.ScaleInLightmap_C199;
			this.m_SelectedEditorRenderState = source.SelectedEditorRenderState_C199;
			this.m_SortingFudge = source.SortingFudge_C199;
			this.m_SortingLayer = source.SortingLayer_C199;
			this.m_SortingLayerID = source.SortingLayerID_C199_Int32;
			this.m_SortingOrder = source.SortingOrder_C199;
			this.m_SortMode = source.SortMode_C199_UInt16;
			this.m_StaticBatchInfo.CopyValues(source.StaticBatchInfo_C199);
			this.m_StaticBatchRoot.CopyValues(source.StaticBatchRoot_C199, converter);
			this.m_UseCustomVertexStreams = source.UseCustomVertexStreams_C199;
			this.m_VelocityScale = source.VelocityScale_C199;
			this.m_VertexStreams = CopyValuesHelper.DuplicateArray<byte>(source.VertexStreams_C199);
		}

		// Token: 0x0603D559 RID: 251225 RVA: 0x0080DC9A File Offset: 0x0080BE9A

		public void CopyValues(IParticleSystemRenderer source)
		{
			this.CopyValues(source, new PPtrConverter(source, this));
		}

		// Token: 0x0603D55A RID: 251226 RVA: 0x0080DCAC File Offset: 0x0080BEAC
		public override void CopyValues(IUnityAssetBase source, PPtrConverter converter)
		{
			IParticleSystemRenderer particleSystemRenderer = source as IParticleSystemRenderer;
			if (particleSystemRenderer != null)
			{
				this.CopyValues(particleSystemRenderer, converter);
				return;
			}
			base.CopyValues(source, converter);
		}

		// Token: 0x0603D55B RID: 251227 RVA: 0x0080DCD4 File Offset: 0x0080BED4

		public override List<TypeTreeNode> MakeEditorTypeTreeNodes(int depth, int startingIndex)
		{
			throw new NotSupportedException();
		}

		// Token: 0x0603D55C RID: 251228 RVA: 0x0080DCDB File Offset: 0x0080BEDB

		public override List<TypeTreeNode> MakeReleaseTypeTreeNodes(int depth, int startingIndex)
		{
			throw new NotSupportedException();
		}

		// Token: 0x04013EBE RID: 81598
		public ushort m_RenderMode;

		// Token: 0x04013EBF RID: 81599
		public ushort m_SortMode;

		// Token: 0x04013EC0 RID: 81600
		public float m_MinParticleSize;

		// Token: 0x04013EC1 RID: 81601
		public float m_MaxParticleSize;

		// Token: 0x04013EC2 RID: 81602
		public float m_CameraVelocityScale;

		// Token: 0x04013EC3 RID: 81603
		public float m_VelocityScale;

		// Token: 0x04013EC4 RID: 81604
		public float m_LengthScale;

		// Token: 0x04013EC5 RID: 81605
		public float m_SortingFudge;

		// Token: 0x04013EC6 RID: 81606
		public float m_NormalDirection;

		// Token: 0x04013EC7 RID: 81607
		public int m_RenderAlignment;

		// Token: 0x04013EC8 RID: 81608

		public Vector3f_3_5_0 m_Pivot;

		// Token: 0x04013EC9 RID: 81609
		public bool m_UseCustomVertexStreams;

		// Token: 0x04013ECA RID: 81610

		public byte[] m_VertexStreams;

		// Token: 0x04013ECB RID: 81611

		public PPtr_Mesh_5_0_0 m_Mesh;

		// Token: 0x04013ECC RID: 81612

		public PPtr_Mesh_5_0_0 m_Mesh1;

		// Token: 0x04013ECD RID: 81613

		public PPtr_Mesh_5_0_0 m_Mesh2;

		// Token: 0x04013ECE RID: 81614

		public PPtr_Mesh_5_0_0 m_Mesh3;

		// Token: 0x04013ECF RID: 81615
		public int m_MaskInteraction;

		public bool UseOctagonShape { get; set; }
		public Vector2f_3_5_0[] OctagonCoordinate { get; set; }
		public bool RotateWithParent { get; set; }
		public Vector3f_3_5_0 ParentScale { get; set; }
		public Vector4f_3_5_0 ParentRotation { get; set; }
		public bool m_EnableGPUInstancing { get; set; }
	}
}
