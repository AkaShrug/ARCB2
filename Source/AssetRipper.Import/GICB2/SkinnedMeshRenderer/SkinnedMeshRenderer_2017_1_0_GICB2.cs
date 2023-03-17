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
using AssetRipper.SourceGenerated.Classes.ClassID_1002;
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
using AssetRipper.SourceGenerated.Subclasses.AABB;
using AssetRipper.SourceGenerated.Subclasses.PPtr_EditorExtensionImpl;
using AssetRipper.SourceGenerated.Subclasses.PPtr_EditorExtension;
using AssetRipper.SourceGenerated.Subclasses.PPtr_GameObject;
using AssetRipper.SourceGenerated.Subclasses.PPtr_LightmapParameters;
using AssetRipper.SourceGenerated.Subclasses.PPtr_Material;
using AssetRipper.SourceGenerated.Subclasses.PPtr_Mesh;
using AssetRipper.SourceGenerated.Subclasses.PPtr_PrefabInstance;
using AssetRipper.SourceGenerated.Subclasses.PPtr_Prefab;
using AssetRipper.SourceGenerated.Subclasses.PPtr_Transform;
using AssetRipper.SourceGenerated.Subclasses.StaticBatchInfo;
using AssetRipper.SourceGenerated.Subclasses.Vector4f;
using AssetRipper.Yaml;
using AssetRipper.SourceGenerated.Classes.ClassID_137;

namespace AssetRipper.Import.GICB2.SkinnedMeshRenderer
{
	// Token: 0x020030E2 RID: 12514


	public sealed class SkinnedMeshRenderer_2017_1_0_GICB2 : Renderer_2017_1_0, ISkinnedMeshRenderer, IRenderer, IUnityObjectBase, IUnityAssetBase, IAsset, IAssetReadable, IAssetWritable, IYamlExportable, IDependent, ITypeTreeSerializable, IRendererMarker, IHasEnabled, IComponent, IEditorExtension, IEditorExtensionMarker, IObject, IObjectMarker, IHasHideFlags, IComponentMarker, ISkinnedMeshRendererMarker
	{
		// Token: 0x1701B3D1 RID: 111569
		// (get) Token: 0x0604E54E RID: 320846 RVA: 0x00A020CB File Offset: 0x00A002CB

		public IAABB AABB_C137
		{

			get
			{
				return this.m_AABB;
			}
		}

		// Token: 0x1701B3D2 RID: 111570
		// (get) Token: 0x0604E54F RID: 320847 RVA: 0x00A020D3 File Offset: 0x00A002D3
		// (set) Token: 0x0604E550 RID: 320848 RVA: 0x00A020DB File Offset: 0x00A002DB
		public float AutoUVMaxAngle_C137
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

		// Token: 0x1701B3D3 RID: 111571
		// (get) Token: 0x0604E551 RID: 320849 RVA: 0x00A020E4 File Offset: 0x00A002E4
		// (set) Token: 0x0604E552 RID: 320850 RVA: 0x00A020EC File Offset: 0x00A002EC
		public float AutoUVMaxDistance_C137
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

		// Token: 0x1701B3D4 RID: 111572
		// (get) Token: 0x0604E553 RID: 320851 RVA: 0x00A020F5 File Offset: 0x00A002F5
		// (set) Token: 0x0604E554 RID: 320852 RVA: 0x00A020FD File Offset: 0x00A002FD
		public float[] BlendShapeWeights_C137
		{
			[return: NotNull]
			get
			{
				return this.m_BlendShapeWeights;
			}
			set
			{
				this.m_BlendShapeWeights = value ?? Array.Empty<float>();
			}
		}

		// Token: 0x1701B3D5 RID: 111573
		// (get) Token: 0x0604E555 RID: 320853 RVA: 0x00A0210F File Offset: 0x00A0030F

		public AccessListBase<IPPtr_Transform> Bones_C137
		{

			get
			{
				return new AccessList<PPtr_Transform_5_0_0, IPPtr_Transform>(this.m_Bones);
			}
		}

		// Token: 0x1701B3D6 RID: 111574
		// (get) Token: 0x0604E556 RID: 320854 RVA: 0x00A0211C File Offset: 0x00A0031C
		// (set) Token: 0x0604E557 RID: 320855 RVA: 0x00A0211F File Offset: 0x00A0031F
		public bool CastShadows_C137_Boolean
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x1701B3D7 RID: 111575
		// (get) Token: 0x0604E558 RID: 320856 RVA: 0x00A02121 File Offset: 0x00A00321
		// (set) Token: 0x0604E559 RID: 320857 RVA: 0x00A02129 File Offset: 0x00A00329
		public byte CastShadows_C137_Byte
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

		// Token: 0x1701B3D8 RID: 111576
		// (get) Token: 0x0604E55A RID: 320858 RVA: 0x00A02132 File Offset: 0x00A00332
		public IPPtr_EditorExtension CorrespondingSourceObject_C137
		{
			[return: NotNull]
			get
			{
				return this.m_CorrespondingSourceObject;
			}
		}

		// Token: 0x1701B3D9 RID: 111577
		// (get) Token: 0x0604E55B RID: 320859 RVA: 0x00A0213A File Offset: 0x00A0033A
		// (set) Token: 0x0604E55C RID: 320860 RVA: 0x00A02142 File Offset: 0x00A00342
		public bool DirtyAABB_C137
		{
			get
			{
				return this.m_DirtyAABB;
			}
			set
			{
				this.m_DirtyAABB = value;
			}
		}

		// Token: 0x1701B3DA RID: 111578
		// (get) Token: 0x0604E55D RID: 320861 RVA: 0x00A0214B File Offset: 0x00A0034B
		// (set) Token: 0x0604E55E RID: 320862 RVA: 0x00A0214E File Offset: 0x00A0034E
		public byte DynamicOccludee_C137
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x1701B3DB RID: 111579
		// (get) Token: 0x0604E55F RID: 320863 RVA: 0x00A02150 File Offset: 0x00A00350
		// (set) Token: 0x0604E560 RID: 320864 RVA: 0x00A02158 File Offset: 0x00A00358
		public bool Enabled_C137
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

		// Token: 0x1701B3DC RID: 111580
		// (get) Token: 0x0604E561 RID: 320865 RVA: 0x00A02161 File Offset: 0x00A00361
		public PPtr_EditorExtensionImpl ExtensionPtr_C137
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1701B3DD RID: 111581
		// (get) Token: 0x0604E562 RID: 320866 RVA: 0x00A02164 File Offset: 0x00A00364

		public IPPtr_GameObject GameObject_C137
		{

			get
			{
				return this.m_GameObject;
			}
		}

		// Token: 0x1701B3DE RID: 111582
		// (get) Token: 0x0604E563 RID: 320867 RVA: 0x00A0216C File Offset: 0x00A0036C
		// (set) Token: 0x0604E564 RID: 320868 RVA: 0x00A02174 File Offset: 0x00A00374
		public uint HideFlags_C137
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

		// Token: 0x1701B3DF RID: 111583
		// (get) Token: 0x0604E565 RID: 320869 RVA: 0x00A0217D File Offset: 0x00A0037D
		// (set) Token: 0x0604E566 RID: 320870 RVA: 0x00A02185 File Offset: 0x00A00385
		public bool IgnoreNormalsForChartDetection_C137
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

		// Token: 0x1701B3E0 RID: 111584
		// (get) Token: 0x0604E567 RID: 320871 RVA: 0x00A0218E File Offset: 0x00A0038E
		// (set) Token: 0x0604E568 RID: 320872 RVA: 0x00A02196 File Offset: 0x00A00396
		public bool ImportantGI_C137
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

		// Token: 0x1701B3E1 RID: 111585
		// (get) Token: 0x0604E569 RID: 320873 RVA: 0x00A0219F File Offset: 0x00A0039F
		// (set) Token: 0x0604E56A RID: 320874 RVA: 0x00A021A2 File Offset: 0x00A003A2
		public byte LightmapIndex_C137_Byte
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x1701B3E2 RID: 111586
		// (get) Token: 0x0604E56B RID: 320875 RVA: 0x00A021A4 File Offset: 0x00A003A4
		// (set) Token: 0x0604E56C RID: 320876 RVA: 0x00A021AC File Offset: 0x00A003AC
		public ushort LightmapIndex_C137_UInt16
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

		// Token: 0x1701B3E3 RID: 111587
		// (get) Token: 0x0604E56D RID: 320877 RVA: 0x00A021B5 File Offset: 0x00A003B5
		// (set) Token: 0x0604E56E RID: 320878 RVA: 0x00A021BD File Offset: 0x00A003BD
		public ushort LightmapIndexDynamic_C137
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

		// Token: 0x1701B3E4 RID: 111588
		// (get) Token: 0x0604E56F RID: 320879 RVA: 0x00A021C6 File Offset: 0x00A003C6
		public PPtr_LightmapParameters LightmapParameters_C137
		{
			[return: NotNull]
			get
			{
				return this.m_LightmapParameters;
			}
		}

		// Token: 0x1701B3E5 RID: 111589
		// (get) Token: 0x0604E570 RID: 320880 RVA: 0x00A021CE File Offset: 0x00A003CE

		public IVector4f LightmapTilingOffset_C137
		{

			get
			{
				return this.m_LightmapTilingOffset;
			}
		}

		// Token: 0x1701B3E6 RID: 111590
		// (get) Token: 0x0604E571 RID: 320881 RVA: 0x00A021D6 File Offset: 0x00A003D6
		public Vector4f_3_5_0 LightmapTilingOffsetDynamic_C137
		{
			[return: NotNull]
			get
			{
				return this.m_LightmapTilingOffsetDynamic;
			}
		}

		// Token: 0x1701B3E7 RID: 111591
		// (get) Token: 0x0604E572 RID: 320882 RVA: 0x00A021DE File Offset: 0x00A003DE
		public PPtr_Transform_3_4_0 LightProbeAnchor_C137
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1701B3E8 RID: 111592
		// (get) Token: 0x0604E573 RID: 320883 RVA: 0x00A021E1 File Offset: 0x00A003E1
		// (set) Token: 0x0604E574 RID: 320884 RVA: 0x00A021E9 File Offset: 0x00A003E9
		public byte LightProbeUsage_C137
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

		// Token: 0x1701B3E9 RID: 111593
		// (get) Token: 0x0604E575 RID: 320885 RVA: 0x00A021F2 File Offset: 0x00A003F2
		public PPtr_GameObject_5_0_0 LightProbeVolumeOverride_C137
		{
			[return: NotNull]
			get
			{
				return this.m_LightProbeVolumeOverride;
			}
		}

		// Token: 0x1701B3EA RID: 111594
		// (get) Token: 0x0604E576 RID: 320886 RVA: 0x00A021FA File Offset: 0x00A003FA

		public AccessListBase<IPPtr_Material> Materials_C137
		{

			get
			{
				return new AccessList<PPtr_Material_5_0_0, IPPtr_Material>(this.m_Materials);
			}
		}

		// Token: 0x1701B3EB RID: 111595
		// (get) Token: 0x0604E577 RID: 320887 RVA: 0x00A02207 File Offset: 0x00A00407

		public IPPtr_Mesh Mesh_C137
		{

			get
			{
				return this.m_Mesh;
			}
		}

		// Token: 0x1701B3EC RID: 111596
		// (get) Token: 0x0604E578 RID: 320888 RVA: 0x00A0220F File Offset: 0x00A0040F
		// (set) Token: 0x0604E579 RID: 320889 RVA: 0x00A02217 File Offset: 0x00A00417
		public int MinimumChartSize_C137
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

		// Token: 0x1701B3ED RID: 111597
		// (get) Token: 0x0604E57A RID: 320890 RVA: 0x00A02220 File Offset: 0x00A00420
		// (set) Token: 0x0604E57B RID: 320891 RVA: 0x00A02228 File Offset: 0x00A00428
		public byte MotionVectors_C137
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

		// Token: 0x1701B3EE RID: 111598
		// (get) Token: 0x0604E57C RID: 320892 RVA: 0x00A02231 File Offset: 0x00A00431
		public PPtr_Prefab_2018_3_0 PrefabAsset_C137
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1701B3EF RID: 111599
		// (get) Token: 0x0604E57D RID: 320893 RVA: 0x00A02234 File Offset: 0x00A00434
		public PPtr_PrefabInstance PrefabInstance_C137
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1701B3F0 RID: 111600
		// (get) Token: 0x0604E57E RID: 320894 RVA: 0x00A02237 File Offset: 0x00A00437
		public IPPtr_Prefab PrefabInternal_C137
		{
			[return: NotNull]
			get
			{
				return this.m_PrefabInternal;
			}
		}

		// Token: 0x1701B3F1 RID: 111601
		// (get) Token: 0x0604E57F RID: 320895 RVA: 0x00A0223F File Offset: 0x00A0043F
		// (set) Token: 0x0604E580 RID: 320896 RVA: 0x00A02247 File Offset: 0x00A00447
		public bool PreserveUVs_C137
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

		// Token: 0x1701B3F2 RID: 111602
		// (get) Token: 0x0604E581 RID: 320897 RVA: 0x00A02250 File Offset: 0x00A00450
		public PPtr_Transform_5_0_0 ProbeAnchor_C137
		{
			[return: NotNull]
			get
			{
				return this.m_ProbeAnchor;
			}
		}

		// Token: 0x1701B3F3 RID: 111603
		// (get) Token: 0x0604E582 RID: 320898 RVA: 0x00A02258 File Offset: 0x00A00458
		// (set) Token: 0x0604E583 RID: 320899 RVA: 0x00A02260 File Offset: 0x00A00460
		public int Quality_C137
		{
			get
			{
				return this.m_Quality;
			}
			set
			{
				this.m_Quality = value;
			}
		}

		// Token: 0x1701B3F4 RID: 111604
		// (get) Token: 0x0604E584 RID: 320900 RVA: 0x00A02269 File Offset: 0x00A00469
		// (set) Token: 0x0604E585 RID: 320901 RVA: 0x00A0226C File Offset: 0x00A0046C
		public byte RayTraceProcedural_C137
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x1701B3F5 RID: 111605
		// (get) Token: 0x0604E586 RID: 320902 RVA: 0x00A0226E File Offset: 0x00A0046E
		// (set) Token: 0x0604E587 RID: 320903 RVA: 0x00A02271 File Offset: 0x00A00471
		public byte RayTracingMode_C137
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x1701B3F6 RID: 111606
		// (get) Token: 0x0604E588 RID: 320904 RVA: 0x00A02273 File Offset: 0x00A00473
		// (set) Token: 0x0604E589 RID: 320905 RVA: 0x00A02276 File Offset: 0x00A00476
		public int ReceiveGI_C137
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x1701B3F7 RID: 111607
		// (get) Token: 0x0604E58A RID: 320906 RVA: 0x00A02278 File Offset: 0x00A00478
		// (set) Token: 0x0604E58B RID: 320907 RVA: 0x00A0227B File Offset: 0x00A0047B
		public bool ReceiveShadows_C137_Boolean
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x1701B3F8 RID: 111608
		// (get) Token: 0x0604E58C RID: 320908 RVA: 0x00A0227D File Offset: 0x00A0047D
		// (set) Token: 0x0604E58D RID: 320909 RVA: 0x00A02285 File Offset: 0x00A00485
		public byte ReceiveShadows_C137_Byte
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

		// Token: 0x1701B3F9 RID: 111609
		// (get) Token: 0x0604E58E RID: 320910 RVA: 0x00A0228E File Offset: 0x00A0048E
		// (set) Token: 0x0604E58F RID: 320911 RVA: 0x00A02291 File Offset: 0x00A00491
		public int ReflectionProbeUsage_C137_Int32
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x1701B3FA RID: 111610
		// (get) Token: 0x0604E590 RID: 320912 RVA: 0x00A02293 File Offset: 0x00A00493
		// (set) Token: 0x0604E591 RID: 320913 RVA: 0x00A0229B File Offset: 0x00A0049B
		public byte ReflectionProbeUsage_C137_Byte
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

		// Token: 0x1701B3FB RID: 111611
		// (get) Token: 0x0604E592 RID: 320914 RVA: 0x00A022A4 File Offset: 0x00A004A4
		// (set) Token: 0x0604E593 RID: 320915 RVA: 0x00A022A7 File Offset: 0x00A004A7
		public int RendererPriority_C137
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x1701B3FC RID: 111612
		// (get) Token: 0x0604E594 RID: 320916 RVA: 0x00A022A9 File Offset: 0x00A004A9
		// (set) Token: 0x0604E595 RID: 320917 RVA: 0x00A022AC File Offset: 0x00A004AC
		public uint RenderingLayerMask_C137
		{
			get
			{
				return 0U;
			}
			set
			{
			}
		}

		// Token: 0x1701B3FD RID: 111613
		// (get) Token: 0x0604E596 RID: 320918 RVA: 0x00A022AE File Offset: 0x00A004AE
		public IPPtr_Transform RootBone_C137
		{
			[return: NotNull]
			get
			{
				return this.m_RootBone;
			}
		}

		// Token: 0x1701B3FE RID: 111614
		// (get) Token: 0x0604E597 RID: 320919 RVA: 0x00A022B6 File Offset: 0x00A004B6
		// (set) Token: 0x0604E598 RID: 320920 RVA: 0x00A022BE File Offset: 0x00A004BE
		public float ScaleInLightmap_C137
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

		// Token: 0x1701B3FF RID: 111615
		// (get) Token: 0x0604E599 RID: 320921 RVA: 0x00A022C7 File Offset: 0x00A004C7
		// (set) Token: 0x0604E59A RID: 320922 RVA: 0x00A022CF File Offset: 0x00A004CF
		public int SelectedEditorRenderState_C137
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

		// Token: 0x1701B400 RID: 111616
		// (get) Token: 0x0604E59B RID: 320923 RVA: 0x00A022D8 File Offset: 0x00A004D8
		// (set) Token: 0x0604E59C RID: 320924 RVA: 0x00A022DB File Offset: 0x00A004DB
		public bool SelectedWireframeHidden_C137
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x1701B401 RID: 111617
		// (get) Token: 0x0604E59D RID: 320925 RVA: 0x00A022DD File Offset: 0x00A004DD
		// (set) Token: 0x0604E59E RID: 320926 RVA: 0x00A022E5 File Offset: 0x00A004E5
		public bool SkinnedMotionVectors_C137
		{
			get
			{
				return this.m_SkinnedMotionVectors;
			}
			set
			{
				this.m_SkinnedMotionVectors = value;
			}
		}

		// Token: 0x1701B402 RID: 111618
		// (get) Token: 0x0604E59F RID: 320927 RVA: 0x00A022EE File Offset: 0x00A004EE
		// (set) Token: 0x0604E5A0 RID: 320928 RVA: 0x00A022F6 File Offset: 0x00A004F6
		public short SortingLayer_C137
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

		// Token: 0x1701B403 RID: 111619
		// (get) Token: 0x0604E5A1 RID: 320929 RVA: 0x00A022FF File Offset: 0x00A004FF
		// (set) Token: 0x0604E5A2 RID: 320930 RVA: 0x00A02302 File Offset: 0x00A00502
		public uint SortingLayerID_C137_UInt32
		{
			get
			{
				return 0U;
			}
			set
			{
			}
		}

		// Token: 0x1701B404 RID: 111620
		// (get) Token: 0x0604E5A3 RID: 320931 RVA: 0x00A02304 File Offset: 0x00A00504
		// (set) Token: 0x0604E5A4 RID: 320932 RVA: 0x00A0230C File Offset: 0x00A0050C
		public int SortingLayerID_C137_Int32
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

		// Token: 0x1701B405 RID: 111621
		// (get) Token: 0x0604E5A5 RID: 320933 RVA: 0x00A02315 File Offset: 0x00A00515
		// (set) Token: 0x0604E5A6 RID: 320934 RVA: 0x00A0231D File Offset: 0x00A0051D
		public short SortingOrder_C137
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

		// Token: 0x1701B406 RID: 111622
		// (get) Token: 0x0604E5A7 RID: 320935 RVA: 0x00A02326 File Offset: 0x00A00526
		public StaticBatchInfo StaticBatchInfo_C137
		{
			[return: NotNull]
			get
			{
				return this.m_StaticBatchInfo;
			}
		}

		// Token: 0x1701B407 RID: 111623
		// (get) Token: 0x0604E5A8 RID: 320936 RVA: 0x00A0232E File Offset: 0x00A0052E

		public IPPtr_Transform StaticBatchRoot_C137
		{

			get
			{
				return this.m_StaticBatchRoot;
			}
		}

		// Token: 0x1701B408 RID: 111624
		// (get) Token: 0x0604E5A9 RID: 320937 RVA: 0x00A02336 File Offset: 0x00A00536
		// (set) Token: 0x0604E5AA RID: 320938 RVA: 0x00A02339 File Offset: 0x00A00539
		public byte StaticShadowCaster_C137
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x1701B409 RID: 111625
		// (get) Token: 0x0604E5AB RID: 320939 RVA: 0x00A0233B File Offset: 0x00A0053B
		// (set) Token: 0x0604E5AC RID: 320940 RVA: 0x00A0233E File Offset: 0x00A0053E
		public bool StitchLightmapSeams_C137
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x1701B40A RID: 111626
		// (get) Token: 0x0604E5AD RID: 320941 RVA: 0x00A02340 File Offset: 0x00A00540
		// (set) Token: 0x0604E5AE RID: 320942 RVA: 0x00A02343 File Offset: 0x00A00543
		public bool StitchSeams_C137
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x1701B40B RID: 111627
		// (get) Token: 0x0604E5AF RID: 320943 RVA: 0x00A02345 File Offset: 0x00A00545
		// (set) Token: 0x0604E5B0 RID: 320944 RVA: 0x00A02348 File Offset: 0x00A00548
		public uint[] SubsetIndices_C137
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x1701B40C RID: 111628
		// (get) Token: 0x0604E5B1 RID: 320945 RVA: 0x00A0234A File Offset: 0x00A0054A
		// (set) Token: 0x0604E5B2 RID: 320946 RVA: 0x00A02352 File Offset: 0x00A00552
		public bool UpdateWhenOffscreen_C137
		{
			get
			{
				return this.m_UpdateWhenOffscreen;
			}
			set
			{
				this.m_UpdateWhenOffscreen = value;
			}
		}

		// Token: 0x1701B40D RID: 111629
		// (get) Token: 0x0604E5B3 RID: 320947 RVA: 0x00A0235B File Offset: 0x00A0055B
		// (set) Token: 0x0604E5B4 RID: 320948 RVA: 0x00A0235E File Offset: 0x00A0055E
		public bool UseLightProbes_C137
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x1701B40E RID: 111630
		// (get) Token: 0x0604E5B5 RID: 320949 RVA: 0x00A02360 File Offset: 0x00A00560
		// (set) Token: 0x0604E5B6 RID: 320950 RVA: 0x00A02368 File Offset: 0x00A00568
		public HideFlags HideFlags_C137E
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

		// Token: 0x1701B40F RID: 111631
		// (get) Token: 0x0604E5B7 RID: 320951 RVA: 0x00A02371 File Offset: 0x00A00571
		// (set) Token: 0x0604E5B8 RID: 320952 RVA: 0x00A02379 File Offset: 0x00A00579
		public LightProbeUsage LightProbeUsage_C137E
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

		// Token: 0x1701B410 RID: 111632
		// (get) Token: 0x0604E5B9 RID: 320953 RVA: 0x00A02383 File Offset: 0x00A00583
		// (set) Token: 0x0604E5BA RID: 320954 RVA: 0x00A0238B File Offset: 0x00A0058B
		public SkinQuality Quality_C137E
		{
			get
			{
				return (SkinQuality)this.m_Quality;
			}
			set
			{
				this.m_Quality = (int)value;
			}
		}

		// Token: 0x1701B411 RID: 111633
		// (get) Token: 0x0604E5BB RID: 320955 RVA: 0x00A02394 File Offset: 0x00A00594
		// (set) Token: 0x0604E5BC RID: 320956 RVA: 0x00A02397 File Offset: 0x00A00597
		public RayTracingMode RayTracingMode_C137E
		{
			get
			{
				return RayTracingMode.Off;
			}
			set
			{
			}
		}

		// Token: 0x1701B412 RID: 111634
		// (get) Token: 0x0604E5BD RID: 320957 RVA: 0x00A02399 File Offset: 0x00A00599
		// (set) Token: 0x0604E5BE RID: 320958 RVA: 0x00A0239C File Offset: 0x00A0059C
		public ReflectionProbeUsage ReflectionProbeUsage_C137_Int32E
		{
			get
			{
				return ReflectionProbeUsage.Off;
			}
			set
			{
			}
		}

		// Token: 0x1701B413 RID: 111635
		// (get) Token: 0x0604E5BF RID: 320959 RVA: 0x00A0239E File Offset: 0x00A0059E
		// (set) Token: 0x0604E5C0 RID: 320960 RVA: 0x00A023A6 File Offset: 0x00A005A6
		public ReflectionProbeUsage ReflectionProbeUsage_C137_ByteE
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

		// Token: 0x1701B414 RID: 111636
		// (get) Token: 0x0604E5C1 RID: 320961 RVA: 0x00A023B0 File Offset: 0x00A005B0
		public PPtrAccessList<IPPtr_Transform, ITransform> Bones_C137P
		{
			get
			{
				return new PPtrAccessList<IPPtr_Transform, ITransform>(this.Bones_C137, this);
			}
		}

		// Token: 0x1701B415 RID: 111637
		// (get) Token: 0x0604E5C2 RID: 320962 RVA: 0x00A023BE File Offset: 0x00A005BE
		// (set) Token: 0x0604E5C3 RID: 320963 RVA: 0x00A023D1 File Offset: 0x00A005D1
		public IEditorExtension CorrespondingSourceObject_C137P
		{
			get
			{
				return PPtrExtensions.TryGetAsset<IEditorExtension>(this.CorrespondingSourceObject_C137, base.Collection);
			}
			set
			{
				PPtrExtensions.SetAsset<IEditorExtension>(this.CorrespondingSourceObject_C137, base.Collection, value);
			}
		}

		// Token: 0x1701B416 RID: 111638
		// (get) Token: 0x0604E5C4 RID: 320964 RVA: 0x00A023E5 File Offset: 0x00A005E5
		// (set) Token: 0x0604E5C5 RID: 320965 RVA: 0x00A023E8 File Offset: 0x00A005E8
		public IEditorExtensionImpl ExtensionPtr_C137P
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x1701B417 RID: 111639
		// (get) Token: 0x0604E5C6 RID: 320966 RVA: 0x00A023EA File Offset: 0x00A005EA
		// (set) Token: 0x0604E5C7 RID: 320967 RVA: 0x00A023FD File Offset: 0x00A005FD
		public IGameObject GameObject_C137P
		{
			get
			{
				return PPtrExtensions.TryGetAsset<IGameObject>(this.GameObject_C137, base.Collection);
			}
			set
			{
				PPtrExtensions.SetAsset<IGameObject>(this.GameObject_C137, base.Collection, value);
			}
		}

		// Token: 0x1701B418 RID: 111640
		// (get) Token: 0x0604E5C8 RID: 320968 RVA: 0x00A02411 File Offset: 0x00A00611
		// (set) Token: 0x0604E5C9 RID: 320969 RVA: 0x00A02424 File Offset: 0x00A00624
		public ILightmapParameters LightmapParameters_C137P
		{
			get
			{
				return PPtrExtensions.TryGetAsset<ILightmapParameters>(this.LightmapParameters_C137, base.Collection);
			}
			set
			{
				PPtrExtensions.SetAsset<ILightmapParameters>(this.LightmapParameters_C137, base.Collection, value);
			}
		}

		// Token: 0x1701B419 RID: 111641
		// (get) Token: 0x0604E5CA RID: 320970 RVA: 0x00A02438 File Offset: 0x00A00638
		// (set) Token: 0x0604E5CB RID: 320971 RVA: 0x00A0243B File Offset: 0x00A0063B
		public ITransform LightProbeAnchor_C137P
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x1701B41A RID: 111642
		// (get) Token: 0x0604E5CC RID: 320972 RVA: 0x00A0243D File Offset: 0x00A0063D
		// (set) Token: 0x0604E5CD RID: 320973 RVA: 0x00A02450 File Offset: 0x00A00650
		public IGameObject LightProbeVolumeOverride_C137P
		{
			get
			{
				return PPtrExtensions.TryGetAsset<IGameObject>(this.LightProbeVolumeOverride_C137, base.Collection);
			}
			set
			{
				PPtrExtensions.SetAsset<IGameObject>(this.LightProbeVolumeOverride_C137, base.Collection, value);
			}
		}

		// Token: 0x1701B41B RID: 111643
		// (get) Token: 0x0604E5CE RID: 320974 RVA: 0x00A02464 File Offset: 0x00A00664
		public PPtrAccessList<IPPtr_Material, IMaterial> Materials_C137P
		{
			get
			{
				return new PPtrAccessList<IPPtr_Material, IMaterial>(this.Materials_C137, this);
			}
		}

		// Token: 0x1701B41C RID: 111644
		// (get) Token: 0x0604E5CF RID: 320975 RVA: 0x00A02472 File Offset: 0x00A00672
		// (set) Token: 0x0604E5D0 RID: 320976 RVA: 0x00A02485 File Offset: 0x00A00685
		public IMesh Mesh_C137P
		{
			get
			{
				return PPtrExtensions.TryGetAsset<IMesh>(this.Mesh_C137, base.Collection);
			}
			set
			{
				PPtrExtensions.SetAsset<IMesh>(this.Mesh_C137, base.Collection, value);
			}
		}

		// Token: 0x1701B41D RID: 111645
		// (get) Token: 0x0604E5D1 RID: 320977 RVA: 0x00A02499 File Offset: 0x00A00699
		// (set) Token: 0x0604E5D2 RID: 320978 RVA: 0x00A0249C File Offset: 0x00A0069C
		public IPrefab PrefabAsset_C137P
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x1701B41E RID: 111646
		// (get) Token: 0x0604E5D3 RID: 320979 RVA: 0x00A0249E File Offset: 0x00A0069E
		// (set) Token: 0x0604E5D4 RID: 320980 RVA: 0x00A024A1 File Offset: 0x00A006A1
		public IPrefabInstance PrefabInstance_C137P
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x1701B41F RID: 111647
		// (get) Token: 0x0604E5D5 RID: 320981 RVA: 0x00A024A3 File Offset: 0x00A006A3
		// (set) Token: 0x0604E5D6 RID: 320982 RVA: 0x00A024B6 File Offset: 0x00A006B6
		public IPrefabMarker PrefabInternal_C137P
		{
			get
			{
				return PPtrExtensions.TryGetAsset<IPrefabMarker>(this.PrefabInternal_C137, base.Collection);
			}
			set
			{
				PPtrExtensions.SetAsset<IPrefabMarker>(this.PrefabInternal_C137, base.Collection, value);
			}
		}

		// Token: 0x1701B420 RID: 111648
		// (get) Token: 0x0604E5D7 RID: 320983 RVA: 0x00A024CA File Offset: 0x00A006CA
		// (set) Token: 0x0604E5D8 RID: 320984 RVA: 0x00A024DD File Offset: 0x00A006DD
		public ITransform ProbeAnchor_C137P
		{
			get
			{
				return PPtrExtensions.TryGetAsset<ITransform>(this.ProbeAnchor_C137, base.Collection);
			}
			set
			{
				PPtrExtensions.SetAsset<ITransform>(this.ProbeAnchor_C137, base.Collection, value);
			}
		}

		// Token: 0x1701B421 RID: 111649
		// (get) Token: 0x0604E5D9 RID: 320985 RVA: 0x00A024F1 File Offset: 0x00A006F1
		// (set) Token: 0x0604E5DA RID: 320986 RVA: 0x00A02504 File Offset: 0x00A00704
		public ITransform RootBone_C137P
		{
			get
			{
				return PPtrExtensions.TryGetAsset<ITransform>(this.RootBone_C137, base.Collection);
			}
			set
			{
				PPtrExtensions.SetAsset<ITransform>(this.RootBone_C137, base.Collection, value);
			}
		}

		// Token: 0x1701B422 RID: 111650
		// (get) Token: 0x0604E5DB RID: 320987 RVA: 0x00A02518 File Offset: 0x00A00718
		// (set) Token: 0x0604E5DC RID: 320988 RVA: 0x00A0252B File Offset: 0x00A0072B
		public ITransform StaticBatchRoot_C137P
		{
			get
			{
				return PPtrExtensions.TryGetAsset<ITransform>(this.StaticBatchRoot_C137, base.Collection);
			}
			set
			{
				PPtrExtensions.SetAsset<ITransform>(this.StaticBatchRoot_C137, base.Collection, value);
			}
		}

		// Token: 0x1701B423 RID: 111651
		// (get) Token: 0x0604E5DD RID: 320989 RVA: 0x00A0253F File Offset: 0x00A0073F

		public override string ClassName
		{

			get
			{
				return "SkinnedMeshRenderer";
			}
		}

		// Token: 0x0604E5DE RID: 320990 RVA: 0x00A02546 File Offset: 0x00A00746
		public SkinnedMeshRenderer_2017_1_0_GICB2()
			: this(AssetInfo.MakeDummyAssetInfo(137))
		{
		}

		// Token: 0x0604E5DF RID: 320991 RVA: 0x00A02558 File Offset: 0x00A00758
		public SkinnedMeshRenderer_2017_1_0_GICB2(AssetInfo info)
			: base(info)
		{
			this.m_Mesh = new PPtr_Mesh_5_0_0();
			this.m_Bones = new AssetList<PPtr_Transform_5_0_0>();
			this.m_BlendShapeWeights = Array.Empty<float>();
			this.m_RootBone = new PPtr_Transform_5_0_0();
			this.m_AABB = new AABB_3_5_0();
		}

		// Token: 0x0604E5E0 RID: 320992 RVA: 0x00A02598 File Offset: 0x00A00798
		public bool Has_AutoUVMaxAngle_C137()
		{
			return true;
		}

		// Token: 0x0604E5E1 RID: 320993 RVA: 0x00A0259B File Offset: 0x00A0079B
		public bool Has_AutoUVMaxDistance_C137()
		{
			return true;
		}

		// Token: 0x0604E5E2 RID: 320994 RVA: 0x00A0259E File Offset: 0x00A0079E
		public bool Has_BlendShapeWeights_C137()
		{
			return true;
		}

		// Token: 0x0604E5E3 RID: 320995 RVA: 0x00A025A1 File Offset: 0x00A007A1
		public bool Has_CastShadows_C137_Boolean()
		{
			return false;
		}

		// Token: 0x0604E5E4 RID: 320996 RVA: 0x00A025A4 File Offset: 0x00A007A4
		public bool Has_CastShadows_C137_Byte()
		{
			return true;
		}

		// Token: 0x0604E5E5 RID: 320997 RVA: 0x00A025A7 File Offset: 0x00A007A7
		public bool Has_CorrespondingSourceObject_C137()
		{
			return true;
		}

		// Token: 0x0604E5E6 RID: 320998 RVA: 0x00A025AA File Offset: 0x00A007AA
		public bool Has_DynamicOccludee_C137()
		{
			return false;
		}

		// Token: 0x0604E5E7 RID: 320999 RVA: 0x00A025AD File Offset: 0x00A007AD
		public bool Has_ExtensionPtr_C137()
		{
			return false;
		}

		// Token: 0x0604E5E8 RID: 321000 RVA: 0x00A025B0 File Offset: 0x00A007B0
		public bool Has_IgnoreNormalsForChartDetection_C137()
		{
			return true;
		}

		// Token: 0x0604E5E9 RID: 321001 RVA: 0x00A025B3 File Offset: 0x00A007B3
		public bool Has_ImportantGI_C137()
		{
			return true;
		}

		// Token: 0x0604E5EA RID: 321002 RVA: 0x00A025B6 File Offset: 0x00A007B6
		public bool Has_LightmapIndex_C137_Byte()
		{
			return false;
		}

		// Token: 0x0604E5EB RID: 321003 RVA: 0x00A025B9 File Offset: 0x00A007B9
		public bool Has_LightmapIndex_C137_UInt16()
		{
			return true;
		}

		// Token: 0x0604E5EC RID: 321004 RVA: 0x00A025BC File Offset: 0x00A007BC
		public bool Has_LightmapIndexDynamic_C137()
		{
			return true;
		}

		// Token: 0x0604E5ED RID: 321005 RVA: 0x00A025BF File Offset: 0x00A007BF
		public bool Has_LightmapParameters_C137()
		{
			return true;
		}

		// Token: 0x0604E5EE RID: 321006 RVA: 0x00A025C2 File Offset: 0x00A007C2
		public bool Has_LightmapTilingOffsetDynamic_C137()
		{
			return true;
		}

		// Token: 0x0604E5EF RID: 321007 RVA: 0x00A025C5 File Offset: 0x00A007C5
		public bool Has_LightProbeAnchor_C137()
		{
			return false;
		}

		// Token: 0x0604E5F0 RID: 321008 RVA: 0x00A025C8 File Offset: 0x00A007C8
		public bool Has_LightProbeUsage_C137()
		{
			return true;
		}

		// Token: 0x0604E5F1 RID: 321009 RVA: 0x00A025CB File Offset: 0x00A007CB
		public bool Has_LightProbeVolumeOverride_C137()
		{
			return true;
		}

		// Token: 0x0604E5F2 RID: 321010 RVA: 0x00A025CE File Offset: 0x00A007CE
		public bool Has_MinimumChartSize_C137()
		{
			return true;
		}

		// Token: 0x0604E5F3 RID: 321011 RVA: 0x00A025D1 File Offset: 0x00A007D1
		public bool Has_MotionVectors_C137()
		{
			return true;
		}

		// Token: 0x0604E5F4 RID: 321012 RVA: 0x00A025D4 File Offset: 0x00A007D4
		public bool Has_PrefabAsset_C137()
		{
			return false;
		}

		// Token: 0x0604E5F5 RID: 321013 RVA: 0x00A025D7 File Offset: 0x00A007D7
		public bool Has_PrefabInstance_C137()
		{
			return false;
		}

		// Token: 0x0604E5F6 RID: 321014 RVA: 0x00A025DA File Offset: 0x00A007DA
		public bool Has_PrefabInternal_C137()
		{
			return true;
		}

		// Token: 0x0604E5F7 RID: 321015 RVA: 0x00A025DD File Offset: 0x00A007DD
		public bool Has_PreserveUVs_C137()
		{
			return true;
		}

		// Token: 0x0604E5F8 RID: 321016 RVA: 0x00A025E0 File Offset: 0x00A007E0
		public bool Has_ProbeAnchor_C137()
		{
			return true;
		}

		// Token: 0x0604E5F9 RID: 321017 RVA: 0x00A025E3 File Offset: 0x00A007E3
		public bool Has_RayTraceProcedural_C137()
		{
			return false;
		}

		// Token: 0x0604E5FA RID: 321018 RVA: 0x00A025E6 File Offset: 0x00A007E6
		public bool Has_RayTracingMode_C137()
		{
			return false;
		}

		// Token: 0x0604E5FB RID: 321019 RVA: 0x00A025E9 File Offset: 0x00A007E9
		public bool Has_ReceiveGI_C137()
		{
			return false;
		}

		// Token: 0x0604E5FC RID: 321020 RVA: 0x00A025EC File Offset: 0x00A007EC
		public bool Has_ReceiveShadows_C137_Boolean()
		{
			return false;
		}

		// Token: 0x0604E5FD RID: 321021 RVA: 0x00A025EF File Offset: 0x00A007EF
		public bool Has_ReceiveShadows_C137_Byte()
		{
			return true;
		}

		// Token: 0x0604E5FE RID: 321022 RVA: 0x00A025F2 File Offset: 0x00A007F2
		public bool Has_ReflectionProbeUsage_C137_Int32()
		{
			return false;
		}

		// Token: 0x0604E5FF RID: 321023 RVA: 0x00A025F5 File Offset: 0x00A007F5
		public bool Has_ReflectionProbeUsage_C137_Byte()
		{
			return true;
		}

		// Token: 0x0604E600 RID: 321024 RVA: 0x00A025F8 File Offset: 0x00A007F8
		public bool Has_RendererPriority_C137()
		{
			return false;
		}

		// Token: 0x0604E601 RID: 321025 RVA: 0x00A025FB File Offset: 0x00A007FB
		public bool Has_RenderingLayerMask_C137()
		{
			return false;
		}

		// Token: 0x0604E602 RID: 321026 RVA: 0x00A025FE File Offset: 0x00A007FE
		public bool Has_RootBone_C137()
		{
			return true;
		}

		// Token: 0x0604E603 RID: 321027 RVA: 0x00A02601 File Offset: 0x00A00801
		public bool Has_SelectedEditorRenderState_C137()
		{
			return true;
		}

		// Token: 0x0604E604 RID: 321028 RVA: 0x00A02604 File Offset: 0x00A00804
		public bool Has_SelectedWireframeHidden_C137()
		{
			return false;
		}

		// Token: 0x0604E605 RID: 321029 RVA: 0x00A02607 File Offset: 0x00A00807
		public bool Has_SkinnedMotionVectors_C137()
		{
			return true;
		}

		// Token: 0x0604E606 RID: 321030 RVA: 0x00A0260A File Offset: 0x00A0080A
		public bool Has_SortingLayer_C137()
		{
			return true;
		}

		// Token: 0x0604E607 RID: 321031 RVA: 0x00A0260D File Offset: 0x00A0080D
		public bool Has_SortingLayerID_C137_UInt32()
		{
			return false;
		}

		// Token: 0x0604E608 RID: 321032 RVA: 0x00A02610 File Offset: 0x00A00810
		public bool Has_SortingLayerID_C137_Int32()
		{
			return true;
		}

		// Token: 0x0604E609 RID: 321033 RVA: 0x00A02613 File Offset: 0x00A00813
		public bool Has_SortingOrder_C137()
		{
			return true;
		}

		// Token: 0x0604E60A RID: 321034 RVA: 0x00A02616 File Offset: 0x00A00816
		public bool Has_StaticBatchInfo_C137()
		{
			return true;
		}

		// Token: 0x0604E60B RID: 321035 RVA: 0x00A02619 File Offset: 0x00A00819
		public bool Has_StaticShadowCaster_C137()
		{
			return false;
		}

		// Token: 0x0604E60C RID: 321036 RVA: 0x00A0261C File Offset: 0x00A0081C
		public bool Has_StitchLightmapSeams_C137()
		{
			return false;
		}

		// Token: 0x0604E60D RID: 321037 RVA: 0x00A0261F File Offset: 0x00A0081F
		public bool Has_StitchSeams_C137()
		{
			return false;
		}

		// Token: 0x0604E60E RID: 321038 RVA: 0x00A02622 File Offset: 0x00A00822
		public bool Has_SubsetIndices_C137()
		{
			return false;
		}

		// Token: 0x0604E60F RID: 321039 RVA: 0x00A02625 File Offset: 0x00A00825
		public bool Has_UseLightProbes_C137()
		{
			return false;
		}

		// Token: 0x0604E610 RID: 321040 RVA: 0x00A02628 File Offset: 0x00A00828

		public override void ReadRelease(AssetReader reader)
		{
			this.m_GameObject.ReadRelease(reader);
			this.m_Enabled = reader.ReadBoolean();
			this.m_CastShadows = reader.ReadByte();
			this.m_ReceiveShadows = reader.ReadByte();

			// GICB2
			var ReceiveDecals = reader.ReadByte();
			var EnableShadowCulling = reader.ReadByte();
			var EnableGpuQuery = reader.ReadByte();
			var AllowHalfResolution = reader.ReadByte();
			var IsRainOccluder = reader.ReadByte();
			var IsDynamic = reader.ReadByte();

			this.m_MotionVectors = reader.ReadByte();
			this.m_LightProbeUsage = reader.ReadByte();
			this.m_ReflectionProbeUsage = reader.ReadRelease_ByteAlign();
			this.m_LightmapIndex = reader.ReadUInt16();
			this.m_LightmapIndexDynamic = reader.ReadUInt16();
			this.m_LightmapTilingOffset.ReadRelease(reader);
			this.m_LightmapTilingOffsetDynamic.ReadRelease(reader);

			// GICB2
			var ViewDistanceRatio = reader.ReadSingle();
			var ShaderLODDistanceRatio = reader.ReadSingle();

			this.m_Materials.ReadRelease_ArrayAlign_Asset(reader);
			this.m_StaticBatchInfo.ReadRelease(reader);
			this.m_StaticBatchRoot.ReadRelease(reader);

			var MatLayers = reader.ReadInt32(); // GICB2

			this.m_ProbeAnchor.ReadRelease(reader);
			this.m_LightProbeVolumeOverride.ReadRelease_AssetAlign(reader);
			this.m_SortingLayerID = reader.ReadInt32();
			this.m_SortingLayer = reader.ReadInt16();
			this.m_SortingOrder = reader.ReadRelease_Int16Align();

			var UseHighestMip = reader.ReadRelease_BooleanAlign(); // GICB2

			this.m_Quality = reader.ReadInt32();
			this.m_UpdateWhenOffscreen = reader.ReadBoolean();
			this.m_SkinnedMotionVectors = reader.ReadRelease_BooleanAlign();
			this.m_Mesh.ReadRelease(reader);
			this.m_Bones.ReadRelease_ArrayAlign_Asset(reader);
			this.m_BlendShapeWeights = reader.ReadRelease_ArrayAlign_Single();
			this.m_RootBone.ReadRelease(reader);
			this.m_AABB.ReadRelease(reader);
			this.m_DirtyAABB = reader.ReadRelease_BooleanAlign();
		}

		// Token: 0x0604E611 RID: 321041 RVA: 0x00A02788 File Offset: 0x00A00988

		public override void ReadEditor(AssetReader reader)
		{
		}

		// Token: 0x0604E612 RID: 321042 RVA: 0x00A02948 File Offset: 0x00A00B48

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
			this.m_Quality.WriteRelease_Int32(writer);
			this.m_UpdateWhenOffscreen.WriteRelease_Boolean(writer);
			this.m_SkinnedMotionVectors.WriteRelease_BooleanAlign(writer);
			this.m_Mesh.WriteRelease(writer);
			this.m_Bones.WriteRelease_ArrayAlign_Asset(writer);
			this.m_BlendShapeWeights.WriteRelease_ArrayAlign_Single(writer);
			this.m_RootBone.WriteRelease(writer);
			this.m_AABB.WriteRelease(writer);
			this.m_DirtyAABB.WriteRelease_BooleanAlign(writer);
		}

		// Token: 0x0604E613 RID: 321043 RVA: 0x00A02AA8 File Offset: 0x00A00CA8

		public override void WriteEditor(AssetWriter writer)
		{
		}

		// Token: 0x0604E614 RID: 321044 RVA: 0x00A02C68 File Offset: 0x00A00E68

		public override YamlNode ExportYamlRelease(IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			YamlSerializedVersionExtensions.AddSerializedVersion(yamlMappingNode, 2);
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
			yamlMappingNode.Add(new YamlScalarNode("m_Quality"), this.m_Quality.ExportYamlRelease_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("m_UpdateWhenOffscreen"), this.m_UpdateWhenOffscreen.ExportYamlRelease_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("m_SkinnedMotionVectors"), this.m_SkinnedMotionVectors.ExportYamlRelease_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Mesh"), this.m_Mesh.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Bones"), this.m_Bones.ExportYamlRelease_Array_PPtr_Transform_5_0_0(container));
			yamlMappingNode.Add(new YamlScalarNode("m_BlendShapeWeights"), this.m_BlendShapeWeights.ExportYamlRelease_Array_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("m_RootBone"), this.m_RootBone.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("m_AABB"), this.m_AABB.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("m_DirtyAABB"), this.m_DirtyAABB.ExportYamlRelease_Boolean(container));
			return yamlMappingNode;
		}

		// Token: 0x0604E615 RID: 321045 RVA: 0x00A02F94 File Offset: 0x00A01194

		public override YamlNode ExportYamlEditor(IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			YamlSerializedVersionExtensions.AddSerializedVersion(yamlMappingNode, 2);
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
			yamlMappingNode.Add(new YamlScalarNode("m_Quality"), this.m_Quality.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("m_UpdateWhenOffscreen"), this.m_UpdateWhenOffscreen.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("m_SkinnedMotionVectors"), this.m_SkinnedMotionVectors.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Mesh"), this.m_Mesh.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Bones"), this.m_Bones.ExportYamlEditor_Array_PPtr_Transform_5_0_0(container));
			yamlMappingNode.Add(new YamlScalarNode("m_BlendShapeWeights"), this.m_BlendShapeWeights.ExportYamlEditor_Array_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("m_RootBone"), this.m_RootBone.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_AABB"), this.m_AABB.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_DirtyAABB"), this.m_DirtyAABB.ExportYamlEditor_Boolean(container));
			return yamlMappingNode;
		}

		// Token: 0x0604E616 RID: 321046 RVA: 0x00A033A0 File Offset: 0x00A015A0
		public override void Reset()
		{
			this.m_AABB.Reset();
			this.m_AutoUVMaxAngle = 0f;
			this.m_AutoUVMaxDistance = 0f;
			this.m_BlendShapeWeights = Array.Empty<float>();
			this.m_Bones.Clear();
			this.m_CastShadows = 0;
			this.m_CorrespondingSourceObject.Reset();
			this.m_DirtyAABB = false;
			this.m_Enabled = false;
			this.m_GameObject.Reset();
			this.m_HideFlags = 0U;
			this.m_IgnoreNormalsForChartDetection = false;
			this.m_ImportantGI = false;
			this.m_LightmapIndex = 0;
			this.m_LightmapIndexDynamic = 0;
			this.m_LightmapParameters.Reset();
			this.m_LightmapTilingOffset.Reset();
			this.m_LightmapTilingOffsetDynamic.Reset();
			this.m_LightProbeUsage = 0;
			this.m_LightProbeVolumeOverride.Reset();
			this.m_Materials.Clear();
			this.m_Mesh.Reset();
			this.m_MinimumChartSize = 0;
			this.m_MotionVectors = 0;
			this.m_PrefabInternal.Reset();
			this.m_PreserveUVs = false;
			this.m_ProbeAnchor.Reset();
			this.m_Quality = 0;
			this.m_ReceiveShadows = 0;
			this.m_ReflectionProbeUsage = 0;
			this.m_RootBone.Reset();
			this.m_ScaleInLightmap = 0f;
			this.m_SelectedEditorRenderState = 0;
			this.m_SkinnedMotionVectors = false;
			this.m_SortingLayer = 0;
			this.m_SortingLayerID = 0;
			this.m_SortingOrder = 0;
			this.m_StaticBatchInfo.Reset();
			this.m_StaticBatchRoot.Reset();
			this.m_UpdateWhenOffscreen = false;
		}

		// Token: 0x0604E617 RID: 321047 RVA: 0x00A03511 File Offset: 0x00A01711
		//public override IEnumerable<ValueTuple<FieldName, PPtr<IUnityObjectBase>>> FetchDependencies(FieldName parent)
		//{
		//	return Enumerable.Empty<ValueTuple<FieldName, PPtr<IUnityObjectBase>>>().Append_SkinnedMeshRenderer_2017_1_0(parent, this);
		//}

		// Token: 0x0604E618 RID: 321048 RVA: 0x00A03520 File Offset: 0x00A01720

		public void CopyValues(ISkinnedMeshRenderer source, PPtrConverter converter)
		{
			this.m_AABB.CopyValues(source.AABB_C137);
			this.m_AutoUVMaxAngle = source.AutoUVMaxAngle_C137;
			this.m_AutoUVMaxDistance = source.AutoUVMaxDistance_C137;
			this.m_BlendShapeWeights = CopyValuesHelper.DuplicateArray<float>(source.BlendShapeWeights_C137);
			CopyValuesHelper.CopyValues__AssetList_PPtr_Transform_5_0_0__AccessListBase_IPPtr_Transform(this.m_Bones, source.Bones_C137, converter);
			this.m_CastShadows = source.CastShadows_C137_Byte;
			this.m_CorrespondingSourceObject.CopyValues(source.CorrespondingSourceObject_C137, converter);
			this.m_DirtyAABB = source.DirtyAABB_C137;
			this.m_Enabled = source.Enabled_C137;
			this.m_GameObject.CopyValues(source.GameObject_C137, converter);
			this.m_HideFlags = source.HideFlags_C137;
			this.m_IgnoreNormalsForChartDetection = source.IgnoreNormalsForChartDetection_C137;
			this.m_ImportantGI = source.ImportantGI_C137;
			this.m_LightmapIndex = source.LightmapIndex_C137_UInt16;
			this.m_LightmapIndexDynamic = source.LightmapIndexDynamic_C137;
			this.m_LightmapParameters.CopyValues(source.LightmapParameters_C137, converter);
			this.m_LightmapTilingOffset.CopyValues(source.LightmapTilingOffset_C137);
			this.m_LightmapTilingOffsetDynamic.CopyValues(source.LightmapTilingOffsetDynamic_C137);
			this.m_LightProbeUsage = source.LightProbeUsage_C137;
			this.m_LightProbeVolumeOverride.CopyValues(source.LightProbeVolumeOverride_C137, converter);
			CopyValuesHelper.CopyValues__AssetList_PPtr_Material_5_0_0__AccessListBase_IPPtr_Material(this.m_Materials, source.Materials_C137, converter);
			this.m_Mesh.CopyValues(source.Mesh_C137, converter);
			this.m_MinimumChartSize = source.MinimumChartSize_C137;
			this.m_MotionVectors = source.MotionVectors_C137;
			this.m_PrefabInternal.CopyValues(source.PrefabInternal_C137, converter);
			this.m_PreserveUVs = source.PreserveUVs_C137;
			this.m_ProbeAnchor.CopyValues(source.ProbeAnchor_C137, converter);
			this.m_Quality = source.Quality_C137;
			this.m_ReceiveShadows = source.ReceiveShadows_C137_Byte;
			this.m_ReflectionProbeUsage = source.ReflectionProbeUsage_C137_Byte;
			this.m_RootBone.CopyValues(source.RootBone_C137, converter);
			this.m_ScaleInLightmap = source.ScaleInLightmap_C137;
			this.m_SelectedEditorRenderState = source.SelectedEditorRenderState_C137;
			this.m_SkinnedMotionVectors = source.SkinnedMotionVectors_C137;
			this.m_SortingLayer = source.SortingLayer_C137;
			this.m_SortingLayerID = source.SortingLayerID_C137_Int32;
			this.m_SortingOrder = source.SortingOrder_C137;
			this.m_StaticBatchInfo.CopyValues(source.StaticBatchInfo_C137);
			this.m_StaticBatchRoot.CopyValues(source.StaticBatchRoot_C137, converter);
			this.m_UpdateWhenOffscreen = source.UpdateWhenOffscreen_C137;
		}

		// Token: 0x0604E619 RID: 321049 RVA: 0x00A03768 File Offset: 0x00A01968

		public void CopyValues(ISkinnedMeshRenderer source)
		{
			this.CopyValues(source, new PPtrConverter(source, this));
		}

		// Token: 0x0604E61A RID: 321050 RVA: 0x00A03778 File Offset: 0x00A01978
		public override void CopyValues(IUnityAssetBase source, PPtrConverter converter)
		{
			ISkinnedMeshRenderer skinnedMeshRenderer = source as ISkinnedMeshRenderer;
			if (skinnedMeshRenderer != null)
			{
				this.CopyValues(skinnedMeshRenderer, converter);
				return;
			}
			base.CopyValues(source, converter);
		}

		// Token: 0x0604E61B RID: 321051 RVA: 0x00A037A0 File Offset: 0x00A019A0

		public override List<TypeTreeNode> MakeEditorTypeTreeNodes(int depth, int startingIndex)
		{
			throw new NotSupportedException();
		}

		// Token: 0x0604E61C RID: 321052 RVA: 0x00A037A7 File Offset: 0x00A019A7

		public override List<TypeTreeNode> MakeReleaseTypeTreeNodes(int depth, int startingIndex)
		{
			throw new NotSupportedException();
		}

		// Token: 0x04015B3D RID: 88893
		public int m_Quality;

		// Token: 0x04015B3E RID: 88894
		public bool m_UpdateWhenOffscreen;

		// Token: 0x04015B3F RID: 88895
		public bool m_SkinnedMotionVectors;

		// Token: 0x04015B40 RID: 88896

		public PPtr_Mesh_5_0_0 m_Mesh;

		// Token: 0x04015B41 RID: 88897

		public AssetList<PPtr_Transform_5_0_0> m_Bones;

		// Token: 0x04015B42 RID: 88898

		public float[] m_BlendShapeWeights;

		// Token: 0x04015B43 RID: 88899

		public PPtr_Transform_5_0_0 m_RootBone;

		// Token: 0x04015B44 RID: 88900

		public AABB_3_5_0 m_AABB;

		// Token: 0x04015B45 RID: 88901
		public bool m_DirtyAABB;
	}
}
