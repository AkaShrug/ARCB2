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
using AssetRipper.SourceGenerated.Classes.ClassID_156;
using AssetRipper.SourceGenerated.Classes.ClassID_18;
using AssetRipper.SourceGenerated.Classes.ClassID_2;
using AssetRipper.SourceGenerated.Classes.ClassID_21;
using AssetRipper.SourceGenerated.Classes.ClassID_8;
using AssetRipper.SourceGenerated.Enums;
using AssetRipper.SourceGenerated.Helpers;
using AssetRipper.SourceGenerated.Interfaces;
using AssetRipper.SourceGenerated.MarkerInterfaces;
using AssetRipper.SourceGenerated.Subclasses.ColorRGBA32;
using AssetRipper.SourceGenerated.Subclasses.Hash128;
using AssetRipper.SourceGenerated.Subclasses.PPtr_EditorExtension;
using AssetRipper.SourceGenerated.Subclasses.PPtr_GameObject;
using AssetRipper.SourceGenerated.Subclasses.PPtr_LightmapParameters;
using AssetRipper.SourceGenerated.Subclasses.PPtr_Material;
using AssetRipper.SourceGenerated.Subclasses.PPtr_PrefabInstance;
using AssetRipper.SourceGenerated.Subclasses.PPtr_Prefab;
using AssetRipper.SourceGenerated.Subclasses.PPtr_TerrainData;
using AssetRipper.SourceGenerated.Subclasses.Vector4f;
using AssetRipper.Yaml;
using AssetRipper.SourceGenerated.Classes.ClassID_218;

namespace AssetRipper.Import.GICB2.Terrain
{
	// Token: 0x02002C18 RID: 11288

	public sealed class Terrain_5_5_0_GICB2 : Behaviour_5_5_0, ITerrain, IUnityObjectBase, IUnityAssetBase, IAsset, IAssetReadable, IAssetWritable, IYamlExportable, IDependent, ITypeTreeSerializable, ITerrainMarker, IBehaviour, IBehaviourMarker, IComponent, IEditorExtension, IEditorExtensionMarker, IObject, IObjectMarker, IHasHideFlags, IComponentMarker, IHasEnabled
	{
		// Token: 0x170126E5 RID: 75493
		// (get) Token: 0x0603811E RID: 229662 RVA: 0x007792DA File Offset: 0x007774DA
		// (set) Token: 0x0603811F RID: 229663 RVA: 0x007792DD File Offset: 0x007774DD
		public bool AllowAutoConnect_C218
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x170126E6 RID: 75494
		// (get) Token: 0x06038120 RID: 229664 RVA: 0x007792DF File Offset: 0x007774DF
		// (set) Token: 0x06038121 RID: 229665 RVA: 0x007792E7 File Offset: 0x007774E7
		public bool BakeLightProbesForTrees_C218
		{
			get
			{
				return this.m_BakeLightProbesForTrees;
			}
			set
			{
				this.m_BakeLightProbesForTrees = value;
			}
		}

		// Token: 0x170126E7 RID: 75495
		// (get) Token: 0x06038122 RID: 229666 RVA: 0x007792F0 File Offset: 0x007774F0
		// (set) Token: 0x06038123 RID: 229667 RVA: 0x007792F8 File Offset: 0x007774F8
		public bool CastShadows_C218
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

		// Token: 0x170126E8 RID: 75496
		// (get) Token: 0x06038124 RID: 229668 RVA: 0x00779301 File Offset: 0x00777501
		public Vector4f_3_5_0 ChunkDynamicUVST_C218
		{
			get
			{
				return this.m_ChunkDynamicUVST;
			}
		}

		// Token: 0x170126E9 RID: 75497
		// (get) Token: 0x06038125 RID: 229669 RVA: 0x00779309 File Offset: 0x00777509
		public PPtr_EditorExtension_5_0_0 CorrespondingSourceObject_C218
		{
			get
			{
				return this.m_CorrespondingSourceObject;
			}
		}

		// Token: 0x170126EA RID: 75498
		// (get) Token: 0x06038126 RID: 229670 RVA: 0x00779311 File Offset: 0x00777511
		// (set) Token: 0x06038127 RID: 229671 RVA: 0x00779318 File Offset: 0x00777518
		public float DefaultSmoothness_C218
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x170126EB RID: 75499
		// (get) Token: 0x06038128 RID: 229672 RVA: 0x0077931A File Offset: 0x0077751A
		// (set) Token: 0x06038129 RID: 229673 RVA: 0x0077931D File Offset: 0x0077751D
		public bool DeringLightProbesForTrees_C218
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x170126EC RID: 75500
		// (get) Token: 0x0603812A RID: 229674 RVA: 0x0077931F File Offset: 0x0077751F
		// (set) Token: 0x0603812B RID: 229675 RVA: 0x00779327 File Offset: 0x00777527
		public float DetailObjectDensity_C218
		{
			get
			{
				return this.m_DetailObjectDensity;
			}
			set
			{
				this.m_DetailObjectDensity = value;
			}
		}

		// Token: 0x170126ED RID: 75501
		// (get) Token: 0x0603812C RID: 229676 RVA: 0x00779330 File Offset: 0x00777530
		// (set) Token: 0x0603812D RID: 229677 RVA: 0x00779338 File Offset: 0x00777538
		public float DetailObjectDistance_C218
		{
			get
			{
				return this.m_DetailObjectDistance;
			}
			set
			{
				this.m_DetailObjectDistance = value;
			}
		}

		// Token: 0x170126EE RID: 75502
		// (get) Token: 0x0603812E RID: 229678 RVA: 0x00779341 File Offset: 0x00777541
		// (set) Token: 0x0603812F RID: 229679 RVA: 0x00779349 File Offset: 0x00777549
		public bool DrawHeightmap_C218
		{
			get
			{
				return this.m_DrawHeightmap;
			}
			set
			{
				this.m_DrawHeightmap = value;
			}
		}

		// Token: 0x170126EF RID: 75503
		// (get) Token: 0x06038130 RID: 229680 RVA: 0x00779352 File Offset: 0x00777552
		// (set) Token: 0x06038131 RID: 229681 RVA: 0x00779355 File Offset: 0x00777555
		public bool DrawInstanced_C218
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x170126F0 RID: 75504
		// (get) Token: 0x06038132 RID: 229682 RVA: 0x00779357 File Offset: 0x00777557
		// (set) Token: 0x06038133 RID: 229683 RVA: 0x0077935F File Offset: 0x0077755F
		public bool DrawTreesAndFoliage_C218
		{
			get
			{
				return this.m_DrawTreesAndFoliage;
			}
			set
			{
				this.m_DrawTreesAndFoliage = value;
			}
		}

		// Token: 0x170126F1 RID: 75505
		// (get) Token: 0x06038134 RID: 229684 RVA: 0x00779368 File Offset: 0x00777568
		public Vector4f_3_5_0 DynamicUVST_C218
		{
			get
			{
				return this.m_DynamicUVST;
			}
		}

		// Token: 0x170126F2 RID: 75506
		// (get) Token: 0x06038135 RID: 229685 RVA: 0x00779370 File Offset: 0x00777570
		// (set) Token: 0x06038136 RID: 229686 RVA: 0x00779378 File Offset: 0x00777578
		public byte Enabled_C218
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

		// Token: 0x170126F3 RID: 75507
		// (get) Token: 0x06038137 RID: 229687 RVA: 0x00779381 File Offset: 0x00777581
		// (set) Token: 0x06038138 RID: 229688 RVA: 0x00779384 File Offset: 0x00777584
		public bool EnableHeightmapRayTracing_C218
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x170126F4 RID: 75508
		// (get) Token: 0x06038139 RID: 229689 RVA: 0x00779386 File Offset: 0x00777586
		// (set) Token: 0x0603813A RID: 229690 RVA: 0x00779389 File Offset: 0x00777589
		public bool EnableTreesAndDetailsRayTracing_C218
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x170126F5 RID: 75509
		// (get) Token: 0x0603813B RID: 229691 RVA: 0x0077938B File Offset: 0x0077758B

		public Hash128 ExplicitProbeSetHash_C218
		{

			get
			{
				return null;
			}
		}

		// Token: 0x170126F6 RID: 75510
		// (get) Token: 0x0603813C RID: 229692 RVA: 0x0077938E File Offset: 0x0077758E
		public PPtr_GameObject_5_0_0 GameObject_C218
		{
			get
			{
				return this.m_GameObject;
			}
		}

		// Token: 0x170126F7 RID: 75511
		// (get) Token: 0x0603813D RID: 229693 RVA: 0x00779396 File Offset: 0x00777596
		// (set) Token: 0x0603813E RID: 229694 RVA: 0x00779399 File Offset: 0x00777599
		public int GroupingID_C218
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x170126F8 RID: 75512
		// (get) Token: 0x0603813F RID: 229695 RVA: 0x0077939B File Offset: 0x0077759B
		// (set) Token: 0x06038140 RID: 229696 RVA: 0x007793A3 File Offset: 0x007775A3
		public int HeightmapMaximumLOD_C218
		{
			get
			{
				return this.m_HeightmapMaximumLOD;
			}
			set
			{
				this.m_HeightmapMaximumLOD = value;
			}
		}

		// Token: 0x170126F9 RID: 75513
		// (get) Token: 0x06038141 RID: 229697 RVA: 0x007793AC File Offset: 0x007775AC
		// (set) Token: 0x06038142 RID: 229698 RVA: 0x007793B4 File Offset: 0x007775B4
		public float HeightmapPixelError_C218
		{
			get
			{
				return this.m_HeightmapPixelError;
			}
			set
			{
				this.m_HeightmapPixelError = value;
			}
		}

		// Token: 0x170126FA RID: 75514
		// (get) Token: 0x06038143 RID: 229699 RVA: 0x007793BD File Offset: 0x007775BD
		// (set) Token: 0x06038144 RID: 229700 RVA: 0x007793C5 File Offset: 0x007775C5
		public uint HideFlags_C218
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

		// Token: 0x170126FB RID: 75515
		// (get) Token: 0x06038145 RID: 229701 RVA: 0x007793CE File Offset: 0x007775CE
		// (set) Token: 0x06038146 RID: 229702 RVA: 0x007793D1 File Offset: 0x007775D1
		public bool IgnoreQualitySettings_C218
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x170126FC RID: 75516
		// (get) Token: 0x06038147 RID: 229703 RVA: 0x007793D3 File Offset: 0x007775D3
		// (set) Token: 0x06038148 RID: 229704 RVA: 0x007793DB File Offset: 0x007775DB
		public float LegacyShininess_C218
		{
			get
			{
				return this.m_LegacyShininess;
			}
			set
			{
				this.m_LegacyShininess = value;
			}
		}

		// Token: 0x170126FD RID: 75517
		// (get) Token: 0x06038149 RID: 229705 RVA: 0x007793E4 File Offset: 0x007775E4

		public ColorRGBA32 LegacySpecular_C218
		{

			[return: NotNull]
			get
			{
				return this.m_LegacySpecular;
			}
		}

		// Token: 0x170126FE RID: 75518
		// (get) Token: 0x0603814A RID: 229706 RVA: 0x007793EC File Offset: 0x007775EC
		// (set) Token: 0x0603814B RID: 229707 RVA: 0x007793F4 File Offset: 0x007775F4
		public ushort LightmapIndex_C218
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

		// Token: 0x170126FF RID: 75519
		// (get) Token: 0x0603814C RID: 229708 RVA: 0x007793FD File Offset: 0x007775FD
		// (set) Token: 0x0603814D RID: 229709 RVA: 0x00779405 File Offset: 0x00777605
		public ushort LightmapIndexDynamic_C218
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

		// Token: 0x17012700 RID: 75520
		// (get) Token: 0x0603814E RID: 229710 RVA: 0x0077940E File Offset: 0x0077760E
		public PPtr_LightmapParameters LightmapParameters_C218
		{
			get
			{
				return this.m_LightmapParameters;
			}
		}

		// Token: 0x17012701 RID: 75521
		// (get) Token: 0x0603814F RID: 229711 RVA: 0x00779416 File Offset: 0x00777616
		public Vector4f_3_5_0 LightmapTilingOffset_C218
		{
			get
			{
				return this.m_LightmapTilingOffset;
			}
		}

		// Token: 0x17012702 RID: 75522
		// (get) Token: 0x06038150 RID: 229712 RVA: 0x0077941E File Offset: 0x0077761E
		public Vector4f_3_5_0 LightmapTilingOffsetDynamic_C218
		{
			get
			{
				return this.m_LightmapTilingOffsetDynamic;
			}
		}

		// Token: 0x17012703 RID: 75523
		// (get) Token: 0x06038151 RID: 229713 RVA: 0x00779426 File Offset: 0x00777626
		public PPtr_Material_5_0_0 MaterialTemplate_C218
		{
			get
			{
				return this.m_MaterialTemplate;
			}
		}

		// Token: 0x17012704 RID: 75524
		// (get) Token: 0x06038152 RID: 229714 RVA: 0x0077942E File Offset: 0x0077762E
		// (set) Token: 0x06038153 RID: 229715 RVA: 0x00779436 File Offset: 0x00777636
		public int MaterialType_C218
		{
			get
			{
				return this.m_MaterialType;
			}
			set
			{
				this.m_MaterialType = value;
			}
		}

		// Token: 0x17012705 RID: 75525
		// (get) Token: 0x06038154 RID: 229716 RVA: 0x0077943F File Offset: 0x0077763F

		public PPtr_Prefab_2018_3_0 PrefabAsset_C218
		{

			get
			{
				return null;
			}
		}

		// Token: 0x17012706 RID: 75526
		// (get) Token: 0x06038155 RID: 229717 RVA: 0x00779442 File Offset: 0x00777642

		public PPtr_PrefabInstance PrefabInstance_C218
		{

			get
			{
				return null;
			}
		}

		// Token: 0x17012707 RID: 75527
		// (get) Token: 0x06038156 RID: 229718 RVA: 0x00779445 File Offset: 0x00777645

		public PPtr_Prefab_5_0_0 PrefabInternal_C218
		{

			[return: NotNull]
			get
			{
				return this.m_PrefabInternal;
			}
		}

		// Token: 0x17012708 RID: 75528
		// (get) Token: 0x06038157 RID: 229719 RVA: 0x0077944D File Offset: 0x0077764D
		// (set) Token: 0x06038158 RID: 229720 RVA: 0x00779450 File Offset: 0x00777650
		public bool PreserveTreePrototypeLayers_C218
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17012709 RID: 75529
		// (get) Token: 0x06038159 RID: 229721 RVA: 0x00779452 File Offset: 0x00777652
		// (set) Token: 0x0603815A RID: 229722 RVA: 0x00779455 File Offset: 0x00777655
		public int ReceiveGI_C218
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x1701270A RID: 75530
		// (get) Token: 0x0603815B RID: 229723 RVA: 0x00779457 File Offset: 0x00777657
		// (set) Token: 0x0603815C RID: 229724 RVA: 0x0077945F File Offset: 0x0077765F
		public int ReflectionProbeUsage_C218
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

		// Token: 0x1701270B RID: 75531
		// (get) Token: 0x0603815D RID: 229725 RVA: 0x00779468 File Offset: 0x00777668
		// (set) Token: 0x0603815E RID: 229726 RVA: 0x0077946B File Offset: 0x0077766B
		public uint RenderingLayerMask_C218
		{
			get
			{
				return 0U;
			}
			set
			{
			}
		}

		// Token: 0x1701270C RID: 75532
		// (get) Token: 0x0603815F RID: 229727 RVA: 0x0077946D File Offset: 0x0077766D
		// (set) Token: 0x06038160 RID: 229728 RVA: 0x00779475 File Offset: 0x00777675
		public float ScaleInLightmap_C218
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

		// Token: 0x1701270D RID: 75533
		// (get) Token: 0x06038161 RID: 229729 RVA: 0x0077947E File Offset: 0x0077767E
		// (set) Token: 0x06038162 RID: 229730 RVA: 0x00779481 File Offset: 0x00777681
		public int ShadowCastingMode_C218
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x1701270E RID: 75534
		// (get) Token: 0x06038163 RID: 229731 RVA: 0x00779483 File Offset: 0x00777683
		// (set) Token: 0x06038164 RID: 229732 RVA: 0x0077948B File Offset: 0x0077768B
		public float SplatMapDistance_C218
		{
			get
			{
				return this.m_SplatMapDistance;
			}
			set
			{
				this.m_SplatMapDistance = value;
			}
		}

		// Token: 0x1701270F RID: 75535
		// (get) Token: 0x06038165 RID: 229733 RVA: 0x00779494 File Offset: 0x00777694
		// (set) Token: 0x06038166 RID: 229734 RVA: 0x00779497 File Offset: 0x00777697
		public bool StaticShadowCaster_C218
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17012710 RID: 75536
		// (get) Token: 0x06038167 RID: 229735 RVA: 0x00779499 File Offset: 0x00777699
		public PPtr_TerrainData_5_0_0 TerrainData_C218
		{
			get
			{
				return this.m_TerrainData;
			}
		}

		// Token: 0x17012711 RID: 75537
		// (get) Token: 0x06038168 RID: 229736 RVA: 0x007794A1 File Offset: 0x007776A1
		// (set) Token: 0x06038169 RID: 229737 RVA: 0x007794A9 File Offset: 0x007776A9
		public float TreeBillboardDistance_C218
		{
			get
			{
				return this.m_TreeBillboardDistance;
			}
			set
			{
				this.m_TreeBillboardDistance = value;
			}
		}

		// Token: 0x17012712 RID: 75538
		// (get) Token: 0x0603816A RID: 229738 RVA: 0x007794B2 File Offset: 0x007776B2
		// (set) Token: 0x0603816B RID: 229739 RVA: 0x007794BA File Offset: 0x007776BA
		public float TreeCrossFadeLength_C218
		{
			get
			{
				return this.m_TreeCrossFadeLength;
			}
			set
			{
				this.m_TreeCrossFadeLength = value;
			}
		}

		// Token: 0x17012713 RID: 75539
		// (get) Token: 0x0603816C RID: 229740 RVA: 0x007794C3 File Offset: 0x007776C3
		// (set) Token: 0x0603816D RID: 229741 RVA: 0x007794CB File Offset: 0x007776CB
		public float TreeDistance_C218
		{
			get
			{
				return this.m_TreeDistance;
			}
			set
			{
				this.m_TreeDistance = value;
			}
		}

		// Token: 0x17012714 RID: 75540
		// (get) Token: 0x0603816E RID: 229742 RVA: 0x007794D4 File Offset: 0x007776D4
		// (set) Token: 0x0603816F RID: 229743 RVA: 0x007794DC File Offset: 0x007776DC
		public int TreeMaximumFullLODCount_C218
		{
			get
			{
				return this.m_TreeMaximumFullLODCount;
			}
			set
			{
				this.m_TreeMaximumFullLODCount = value;
			}
		}

		// Token: 0x17012715 RID: 75541
		// (get) Token: 0x06038170 RID: 229744 RVA: 0x007794E5 File Offset: 0x007776E5
		// (set) Token: 0x06038171 RID: 229745 RVA: 0x007794E8 File Offset: 0x007776E8
		public bool UseDefaultSmoothness_C218
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17012716 RID: 75542
		// (get) Token: 0x06038172 RID: 229746 RVA: 0x007794EA File Offset: 0x007776EA
		// (set) Token: 0x06038173 RID: 229747 RVA: 0x007794F2 File Offset: 0x007776F2
		public HideFlags HideFlags_C218E
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

		// Token: 0x17012717 RID: 75543
		// (get) Token: 0x06038174 RID: 229748 RVA: 0x007794FB File Offset: 0x007776FB
		// (set) Token: 0x06038175 RID: 229749 RVA: 0x00779503 File Offset: 0x00777703
		public MaterialType MaterialType_C218E
		{
			get
			{
				return (MaterialType)this.m_MaterialType;
			}
			set
			{
				this.m_MaterialType = (int)value;
			}
		}

		// Token: 0x17012718 RID: 75544
		// (get) Token: 0x06038176 RID: 229750 RVA: 0x0077950C File Offset: 0x0077770C
		// (set) Token: 0x06038177 RID: 229751 RVA: 0x00779514 File Offset: 0x00777714
		public ReflectionProbeUsage ReflectionProbeUsage_C218E
		{
			get
			{
				return (ReflectionProbeUsage)this.m_ReflectionProbeUsage;
			}
			set
			{
				this.m_ReflectionProbeUsage = (int)value;
			}
		}

		// Token: 0x17012719 RID: 75545
		// (get) Token: 0x06038178 RID: 229752 RVA: 0x0077951D File Offset: 0x0077771D
		// (set) Token: 0x06038179 RID: 229753 RVA: 0x00779520 File Offset: 0x00777720
		public ShadowCastingMode ShadowCastingMode_C218E
		{
			get
			{
				return ShadowCastingMode.Off;
			}
			set
			{
			}
		}

		// Token: 0x1701271A RID: 75546
		// (get) Token: 0x0603817A RID: 229754 RVA: 0x00779522 File Offset: 0x00777722
		// (set) Token: 0x0603817B RID: 229755 RVA: 0x00779535 File Offset: 0x00777735

		public IEditorExtension CorrespondingSourceObject_C218P
		{

			get
			{
				return PPtrExtensions.TryGetAsset<IEditorExtension>(this.CorrespondingSourceObject_C218, base.Collection);
			}

			set
			{
				PPtrExtensions.SetAsset<IEditorExtension>(this.CorrespondingSourceObject_C218, base.Collection, value);
			}
		}

		// Token: 0x1701271B RID: 75547
		// (get) Token: 0x0603817C RID: 229756 RVA: 0x00779549 File Offset: 0x00777749
		// (set) Token: 0x0603817D RID: 229757 RVA: 0x0077955C File Offset: 0x0077775C

		public IGameObject GameObject_C218P
		{

			get
			{
				return PPtrExtensions.TryGetAsset<IGameObject>(this.GameObject_C218, base.Collection);
			}

			set
			{
				PPtrExtensions.SetAsset<IGameObject>(this.GameObject_C218, base.Collection, value);
			}
		}

		// Token: 0x1701271C RID: 75548
		// (get) Token: 0x0603817E RID: 229758 RVA: 0x00779570 File Offset: 0x00777770
		// (set) Token: 0x0603817F RID: 229759 RVA: 0x00779583 File Offset: 0x00777783

		public ILightmapParameters LightmapParameters_C218P
		{

			get
			{
				return PPtrExtensions.TryGetAsset<ILightmapParameters>(this.LightmapParameters_C218, base.Collection);
			}

			set
			{
				PPtrExtensions.SetAsset<ILightmapParameters>(this.LightmapParameters_C218, base.Collection, value);
			}
		}

		// Token: 0x1701271D RID: 75549
		// (get) Token: 0x06038180 RID: 229760 RVA: 0x00779597 File Offset: 0x00777797
		// (set) Token: 0x06038181 RID: 229761 RVA: 0x007795AA File Offset: 0x007777AA

		public IMaterial MaterialTemplate_C218P
		{

			get
			{
				return PPtrExtensions.TryGetAsset<IMaterial>(this.MaterialTemplate_C218, base.Collection);
			}

			set
			{
				PPtrExtensions.SetAsset<IMaterial>(this.MaterialTemplate_C218, base.Collection, value);
			}
		}

		// Token: 0x1701271E RID: 75550
		// (get) Token: 0x06038182 RID: 229762 RVA: 0x007795BE File Offset: 0x007777BE
		// (set) Token: 0x06038183 RID: 229763 RVA: 0x007795C1 File Offset: 0x007777C1

		public IPrefab PrefabAsset_C218P
		{

			get
			{
				return null;
			}

			set
			{
			}
		}

		// Token: 0x1701271F RID: 75551
		// (get) Token: 0x06038184 RID: 229764 RVA: 0x007795C3 File Offset: 0x007777C3
		// (set) Token: 0x06038185 RID: 229765 RVA: 0x007795C6 File Offset: 0x007777C6

		public IPrefabInstance PrefabInstance_C218P
		{

			get
			{
				return null;
			}

			set
			{
			}
		}

		// Token: 0x17012720 RID: 75552
		// (get) Token: 0x06038186 RID: 229766 RVA: 0x007795C8 File Offset: 0x007777C8
		// (set) Token: 0x06038187 RID: 229767 RVA: 0x007795DB File Offset: 0x007777DB

		public IPrefabInstance PrefabInternal_C218P
		{

			get
			{
				return PPtrExtensions.TryGetAsset<IPrefabInstance>(this.PrefabInternal_C218, base.Collection);
			}

			set
			{
				PPtrExtensions.SetAsset<IPrefabInstance>(this.PrefabInternal_C218, base.Collection, value);
			}
		}

		// Token: 0x17012721 RID: 75553
		// (get) Token: 0x06038188 RID: 229768 RVA: 0x007795EF File Offset: 0x007777EF
		// (set) Token: 0x06038189 RID: 229769 RVA: 0x00779602 File Offset: 0x00777802

		public ITerrainData TerrainData_C218P
		{

			get
			{
				return PPtrExtensions.TryGetAsset<ITerrainData>(this.TerrainData_C218, base.Collection);
			}

			set
			{
				PPtrExtensions.SetAsset<ITerrainData>(this.TerrainData_C218, base.Collection, value);
			}
		}

		// Token: 0x17012722 RID: 75554
		// (get) Token: 0x0603818A RID: 229770 RVA: 0x00779616 File Offset: 0x00777816
		public override string ClassName
		{
			get
			{
				return "Terrain";
			}
		}

		// Token: 0x0603818B RID: 229771 RVA: 0x0077961D File Offset: 0x0077781D
		public Terrain_5_5_0_GICB2()
			: this(AssetInfo.MakeDummyAssetInfo(218))
		{
		}

		// Token: 0x0603818C RID: 229772 RVA: 0x00779630 File Offset: 0x00777830
		public Terrain_5_5_0_GICB2(AssetInfo info)
			: base(info)
		{
			this.m_LightmapTilingOffset = new Vector4f_3_5_0();
			this.m_LightmapTilingOffsetDynamic = new Vector4f_3_5_0();
			this.m_DynamicUVST = new Vector4f_3_5_0();
			this.m_ChunkDynamicUVST = new Vector4f_3_5_0();
			this.m_LightmapParameters = new PPtr_LightmapParameters();
			this.m_TerrainData = new PPtr_TerrainData_5_0_0();
			this.m_LegacySpecular = new ColorRGBA32();
			this.m_MaterialTemplate = new PPtr_Material_5_0_0();
		}

		// Token: 0x0603818D RID: 229773 RVA: 0x0077969C File Offset: 0x0077789C
		public bool Has_AllowAutoConnect_C218()
		{
			return false;
		}

		// Token: 0x0603818E RID: 229774 RVA: 0x0077969F File Offset: 0x0077789F
		public bool Has_CastShadows_C218()
		{
			return true;
		}

		// Token: 0x0603818F RID: 229775 RVA: 0x007796A2 File Offset: 0x007778A2
		public bool Has_DefaultSmoothness_C218()
		{
			return false;
		}

		// Token: 0x06038190 RID: 229776 RVA: 0x007796A5 File Offset: 0x007778A5
		public bool Has_DeringLightProbesForTrees_C218()
		{
			return false;
		}

		// Token: 0x06038191 RID: 229777 RVA: 0x007796A8 File Offset: 0x007778A8
		public bool Has_DrawInstanced_C218()
		{
			return false;
		}

		// Token: 0x06038192 RID: 229778 RVA: 0x007796AB File Offset: 0x007778AB
		public bool Has_EnableHeightmapRayTracing_C218()
		{
			return false;
		}

		// Token: 0x06038193 RID: 229779 RVA: 0x007796AE File Offset: 0x007778AE
		public bool Has_EnableTreesAndDetailsRayTracing_C218()
		{
			return false;
		}

		// Token: 0x06038194 RID: 229780 RVA: 0x007796B1 File Offset: 0x007778B1
		public bool Has_ExplicitProbeSetHash_C218()
		{
			return false;
		}

		// Token: 0x06038195 RID: 229781 RVA: 0x007796B4 File Offset: 0x007778B4
		public bool Has_GroupingID_C218()
		{
			return false;
		}

		// Token: 0x06038196 RID: 229782 RVA: 0x007796B7 File Offset: 0x007778B7
		public bool Has_IgnoreQualitySettings_C218()
		{
			return false;
		}

		// Token: 0x06038197 RID: 229783 RVA: 0x007796BA File Offset: 0x007778BA
		public bool Has_LegacyShininess_C218()
		{
			return true;
		}

		// Token: 0x06038198 RID: 229784 RVA: 0x007796BD File Offset: 0x007778BD
		public bool Has_LegacySpecular_C218()
		{
			return true;
		}

		// Token: 0x06038199 RID: 229785 RVA: 0x007796C0 File Offset: 0x007778C0
		public bool Has_MaterialType_C218()
		{
			return true;
		}

		// Token: 0x0603819A RID: 229786 RVA: 0x007796C3 File Offset: 0x007778C3
		public bool Has_PrefabAsset_C218()
		{
			return false;
		}

		// Token: 0x0603819B RID: 229787 RVA: 0x007796C6 File Offset: 0x007778C6
		public bool Has_PrefabInstance_C218()
		{
			return false;
		}

		// Token: 0x0603819C RID: 229788 RVA: 0x007796C9 File Offset: 0x007778C9
		public bool Has_PrefabInternal_C218()
		{
			return true;
		}

		// Token: 0x0603819D RID: 229789 RVA: 0x007796CC File Offset: 0x007778CC
		public bool Has_PreserveTreePrototypeLayers_C218()
		{
			return false;
		}

		// Token: 0x0603819E RID: 229790 RVA: 0x007796CF File Offset: 0x007778CF
		public bool Has_ReceiveGI_C218()
		{
			return false;
		}

		// Token: 0x0603819F RID: 229791 RVA: 0x007796D2 File Offset: 0x007778D2
		public bool Has_RenderingLayerMask_C218()
		{
			return false;
		}

		// Token: 0x060381A0 RID: 229792 RVA: 0x007796D5 File Offset: 0x007778D5
		public bool Has_ShadowCastingMode_C218()
		{
			return false;
		}

		// Token: 0x060381A1 RID: 229793 RVA: 0x007796D8 File Offset: 0x007778D8
		public bool Has_StaticShadowCaster_C218()
		{
			return false;
		}

		// Token: 0x060381A2 RID: 229794 RVA: 0x007796DB File Offset: 0x007778DB
		public bool Has_UseDefaultSmoothness_C218()
		{
			return false;
		}

		// Token: 0x060381A3 RID: 229795 RVA: 0x007796E0 File Offset: 0x007778E0
		public override void ReadRelease(AssetReader reader)
		{
			// typedef signed long long SInt64;
			this.m_GameObject.ReadRelease(reader);
			this.m_Enabled = reader.ReadRelease_ByteAlign();
			this.m_TerrainData.ReadRelease(reader);
			this.m_TreeDistance = reader.ReadSingle();
			this.m_TreeBillboardDistance = reader.ReadSingle();
			this.m_TreeCrossFadeLength = reader.ReadSingle();
			this.m_TreeMaximumFullLODCount = reader.ReadInt32();
			this.m_DetailObjectDistance = reader.ReadSingle();
			this.m_DetailObjectDensity = reader.ReadSingle();
			this.m_HeightmapPixelError = reader.ReadSingle();
			this.m_SplatMapDistance = reader.ReadSingle();
			this.m_HeightmapMaximumLOD = reader.ReadInt32();

			// GICB2
			this.MaskmapMaximumLOD = reader.ReadInt32();
			this.MaskmapMinimumLOD = reader.ReadInt32();

			this.m_CastShadows = reader.ReadBoolean();

			// GICB2
			this.UseMaskmap = reader.ReadBoolean();

			this.m_DrawHeightmap = reader.ReadBoolean();
			this.m_DrawTreesAndFoliage = reader.ReadRelease_BooleanAlign();
			this.m_ReflectionProbeUsage = reader.ReadInt32();
			this.m_MaterialType = reader.ReadInt32();
			this.m_LegacySpecular.ReadRelease(reader);
			this.m_LegacyShininess = reader.ReadSingle();
			this.m_MaterialTemplate.ReadRelease(reader);
			this.m_LightmapIndex = reader.ReadUInt16();
			this.m_LightmapIndexDynamic = reader.ReadUInt16();
			this.m_LightmapTilingOffset.ReadRelease(reader);
			this.m_LightmapTilingOffsetDynamic.ReadRelease(reader);
			this.m_BakeLightProbesForTrees = reader.ReadRelease_BooleanAlign();
			this.m_DynamicUVST.ReadRelease(reader);
			this.m_ChunkDynamicUVST.ReadRelease(reader);
		}

		// Token: 0x060381A4 RID: 229796 RVA: 0x00779834 File Offset: 0x00777A34
		public override void ReadEditor(AssetReader reader)
		{
		}

		// Token: 0x060381A5 RID: 229797 RVA: 0x0077997C File Offset: 0x00777B7C
		public override void WriteRelease(AssetWriter writer)
		{
			this.m_GameObject.WriteRelease(writer);
			this.m_Enabled.WriteRelease_ByteAlign(writer);
			this.m_TerrainData.WriteRelease(writer);
			this.m_TreeDistance.WriteRelease_Single(writer);
			this.m_TreeBillboardDistance.WriteRelease_Single(writer);
			this.m_TreeCrossFadeLength.WriteRelease_Single(writer);
			this.m_TreeMaximumFullLODCount.WriteRelease_Int32(writer);
			this.m_DetailObjectDistance.WriteRelease_Single(writer);
			this.m_DetailObjectDensity.WriteRelease_Single(writer);
			this.m_HeightmapPixelError.WriteRelease_Single(writer);
			this.m_SplatMapDistance.WriteRelease_Single(writer);
			this.m_HeightmapMaximumLOD.WriteRelease_Int32(writer);
			this.m_CastShadows.WriteRelease_Boolean(writer);
			this.m_DrawHeightmap.WriteRelease_Boolean(writer);
			this.m_DrawTreesAndFoliage.WriteRelease_BooleanAlign(writer);
			this.m_ReflectionProbeUsage.WriteRelease_Int32(writer);
			this.m_MaterialType.WriteRelease_Int32(writer);
			this.m_LegacySpecular.WriteRelease(writer);
			this.m_LegacyShininess.WriteRelease_Single(writer);
			this.m_MaterialTemplate.WriteRelease(writer);
			this.m_LightmapIndex.WriteRelease_UInt16(writer);
			this.m_LightmapIndexDynamic.WriteRelease_UInt16(writer);
			this.m_LightmapTilingOffset.WriteRelease(writer);
			this.m_LightmapTilingOffsetDynamic.WriteRelease(writer);
			this.m_BakeLightProbesForTrees.WriteRelease_BooleanAlign(writer);
			this.m_DynamicUVST.WriteRelease(writer);
			this.m_ChunkDynamicUVST.WriteRelease(writer);
		}

		// Token: 0x060381A6 RID: 229798 RVA: 0x00779AD0 File Offset: 0x00777CD0
		public override void WriteEditor(AssetWriter writer)
		{
		}

		// Token: 0x060381A7 RID: 229799 RVA: 0x00779C18 File Offset: 0x00777E18
		public override YamlNode ExportYamlRelease(IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			YamlSerializedVersionExtensions.AddSerializedVersion(yamlMappingNode, 3);
			yamlMappingNode.Add(new YamlScalarNode("m_GameObject"), this.m_GameObject.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Enabled"), this.m_Enabled.ExportYamlRelease_Byte(container));
			yamlMappingNode.Add(new YamlScalarNode("m_TerrainData"), this.m_TerrainData.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("m_TreeDistance"), this.m_TreeDistance.ExportYamlRelease_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("m_TreeBillboardDistance"), this.m_TreeBillboardDistance.ExportYamlRelease_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("m_TreeCrossFadeLength"), this.m_TreeCrossFadeLength.ExportYamlRelease_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("m_TreeMaximumFullLODCount"), this.m_TreeMaximumFullLODCount.ExportYamlRelease_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("m_DetailObjectDistance"), this.m_DetailObjectDistance.ExportYamlRelease_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("m_DetailObjectDensity"), this.m_DetailObjectDensity.ExportYamlRelease_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("m_HeightmapPixelError"), this.m_HeightmapPixelError.ExportYamlRelease_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("m_SplatMapDistance"), this.m_SplatMapDistance.ExportYamlRelease_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("m_HeightmapMaximumLOD"), this.m_HeightmapMaximumLOD.ExportYamlRelease_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("m_CastShadows"), this.m_CastShadows.ExportYamlRelease_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("m_DrawHeightmap"), this.m_DrawHeightmap.ExportYamlRelease_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("m_DrawTreesAndFoliage"), this.m_DrawTreesAndFoliage.ExportYamlRelease_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("m_ReflectionProbeUsage"), this.m_ReflectionProbeUsage.ExportYamlRelease_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("m_MaterialType"), this.m_MaterialType.ExportYamlRelease_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("m_LegacySpecular"), this.m_LegacySpecular.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("m_LegacyShininess"), this.m_LegacyShininess.ExportYamlRelease_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("m_MaterialTemplate"), this.m_MaterialTemplate.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("m_LightmapIndex"), this.m_LightmapIndex.ExportYamlRelease_UInt16(container));
			yamlMappingNode.Add(new YamlScalarNode("m_LightmapIndexDynamic"), this.m_LightmapIndexDynamic.ExportYamlRelease_UInt16(container));
			yamlMappingNode.Add(new YamlScalarNode("m_LightmapTilingOffset"), this.m_LightmapTilingOffset.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("m_LightmapTilingOffsetDynamic"), this.m_LightmapTilingOffsetDynamic.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("m_BakeLightProbesForTrees"), this.m_BakeLightProbesForTrees.ExportYamlRelease_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("m_DynamicUVST"), this.m_DynamicUVST.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("m_ChunkDynamicUVST"), this.m_ChunkDynamicUVST.ExportYamlRelease(container));
			return yamlMappingNode;
		}

		// Token: 0x060381A8 RID: 229800 RVA: 0x00779F28 File Offset: 0x00778128
		public override YamlNode ExportYamlEditor(IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			YamlSerializedVersionExtensions.AddSerializedVersion(yamlMappingNode, 3);
			yamlMappingNode.Add(new YamlScalarNode("m_ObjectHideFlags"), this.m_HideFlags.ExportYamlEditor_UInt32(container));
			yamlMappingNode.Add(new YamlScalarNode("m_PrefabParentObject"), this.m_CorrespondingSourceObject.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_PrefabInternal"), this.m_PrefabInternal.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_GameObject"), this.m_GameObject.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Enabled"), this.m_Enabled.ExportYamlEditor_Byte(container));
			yamlMappingNode.Add(new YamlScalarNode("m_TerrainData"), this.m_TerrainData.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_TreeDistance"), this.m_TreeDistance.ExportYamlEditor_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("m_TreeBillboardDistance"), this.m_TreeBillboardDistance.ExportYamlEditor_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("m_TreeCrossFadeLength"), this.m_TreeCrossFadeLength.ExportYamlEditor_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("m_TreeMaximumFullLODCount"), this.m_TreeMaximumFullLODCount.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("m_DetailObjectDistance"), this.m_DetailObjectDistance.ExportYamlEditor_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("m_DetailObjectDensity"), this.m_DetailObjectDensity.ExportYamlEditor_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("m_HeightmapPixelError"), this.m_HeightmapPixelError.ExportYamlEditor_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("m_SplatMapDistance"), this.m_SplatMapDistance.ExportYamlEditor_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("m_HeightmapMaximumLOD"), this.m_HeightmapMaximumLOD.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("m_CastShadows"), this.m_CastShadows.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("m_DrawHeightmap"), this.m_DrawHeightmap.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("m_DrawTreesAndFoliage"), this.m_DrawTreesAndFoliage.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("m_ReflectionProbeUsage"), this.m_ReflectionProbeUsage.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("m_MaterialType"), this.m_MaterialType.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("m_LegacySpecular"), this.m_LegacySpecular.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_LegacyShininess"), this.m_LegacyShininess.ExportYamlEditor_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("m_MaterialTemplate"), this.m_MaterialTemplate.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_BakeLightProbesForTrees"), this.m_BakeLightProbesForTrees.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("m_ScaleInLightmap"), this.m_ScaleInLightmap.ExportYamlEditor_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("m_LightmapParameters"), this.m_LightmapParameters.ExportYamlEditor(container));
			return yamlMappingNode;
		}

		// Token: 0x060381A9 RID: 229801 RVA: 0x0077A21C File Offset: 0x0077841C
		public override void Reset()
		{
			this.m_BakeLightProbesForTrees = false;
			this.m_CastShadows = false;
			this.m_ChunkDynamicUVST.Reset();
			this.m_CorrespondingSourceObject.Reset();
			this.m_DetailObjectDensity = 0f;
			this.m_DetailObjectDistance = 0f;
			this.m_DrawHeightmap = false;
			this.m_DrawTreesAndFoliage = false;
			this.m_DynamicUVST.Reset();
			this.m_Enabled = 0;
			this.m_GameObject.Reset();
			this.m_HeightmapMaximumLOD = 0;
			this.m_HeightmapPixelError = 0f;
			this.m_HideFlags = 0U;
			this.m_LegacyShininess = 0f;
			this.m_LegacySpecular.Reset();
			this.m_LightmapIndex = 0;
			this.m_LightmapIndexDynamic = 0;
			this.m_LightmapParameters.Reset();
			this.m_LightmapTilingOffset.Reset();
			this.m_LightmapTilingOffsetDynamic.Reset();
			this.m_MaterialTemplate.Reset();
			this.m_MaterialType = 0;
			this.m_PrefabInternal.Reset();
			this.m_ReflectionProbeUsage = 0;
			this.m_ScaleInLightmap = 0f;
			this.m_SplatMapDistance = 0f;
			this.m_TerrainData.Reset();
			this.m_TreeBillboardDistance = 0f;
			this.m_TreeCrossFadeLength = 0f;
			this.m_TreeDistance = 0f;
			this.m_TreeMaximumFullLODCount = 0;
		}

		// Token: 0x060381AA RID: 229802 RVA: 0x0077A359 File Offset: 0x00778559
		//public override IEnumerable<ValueTuple<FieldName, PPtr<IUnityObjectBase>>> FetchDependencies(FieldName parent)
		//{
		//	return Enumerable.Empty<ValueTuple<FieldName, PPtr<IUnityObjectBase>>>().Append_Terrain_5_5_0(parent, this);
		//}

		// Token: 0x060381AB RID: 229803 RVA: 0x0077A368 File Offset: 0x00778568
		public void CopyValues(ITerrain source, PPtrConverter converter)
		{
			this.m_BakeLightProbesForTrees = source.BakeLightProbesForTrees_C218;
			this.m_CastShadows = source.CastShadows_C218;
			this.m_ChunkDynamicUVST.CopyValues(source.ChunkDynamicUVST_C218);
			this.m_CorrespondingSourceObject.CopyValues(source.CorrespondingSourceObject_C218, converter);
			this.m_DetailObjectDensity = source.DetailObjectDensity_C218;
			this.m_DetailObjectDistance = source.DetailObjectDistance_C218;
			this.m_DrawHeightmap = source.DrawHeightmap_C218;
			this.m_DrawTreesAndFoliage = source.DrawTreesAndFoliage_C218;
			this.m_DynamicUVST.CopyValues(source.DynamicUVST_C218);
			this.m_Enabled = source.Enabled_C218;
			this.m_GameObject.CopyValues(source.GameObject_C218, converter);
			this.m_HeightmapMaximumLOD = source.HeightmapMaximumLOD_C218;
			this.m_HeightmapPixelError = source.HeightmapPixelError_C218;
			this.m_HideFlags = source.HideFlags_C218;
			this.m_LegacyShininess = source.LegacyShininess_C218;
			this.m_LegacySpecular.CopyValues(source.LegacySpecular_C218);
			this.m_LightmapIndex = source.LightmapIndex_C218;
			this.m_LightmapIndexDynamic = source.LightmapIndexDynamic_C218;
			this.m_LightmapParameters.CopyValues(source.LightmapParameters_C218, converter);
			this.m_LightmapTilingOffset.CopyValues(source.LightmapTilingOffset_C218);
			this.m_LightmapTilingOffsetDynamic.CopyValues(source.LightmapTilingOffsetDynamic_C218);
			this.m_MaterialTemplate.CopyValues(source.MaterialTemplate_C218, converter);
			this.m_MaterialType = source.MaterialType_C218;
			this.m_PrefabInternal.CopyValues(source.PrefabInternal_C218, converter);
			this.m_ReflectionProbeUsage = source.ReflectionProbeUsage_C218;
			this.m_ScaleInLightmap = source.ScaleInLightmap_C218;
			this.m_SplatMapDistance = source.SplatMapDistance_C218;
			this.m_TerrainData.CopyValues(source.TerrainData_C218, converter);
			this.m_TreeBillboardDistance = source.TreeBillboardDistance_C218;
			this.m_TreeCrossFadeLength = source.TreeCrossFadeLength_C218;
			this.m_TreeDistance = source.TreeDistance_C218;
			this.m_TreeMaximumFullLODCount = source.TreeMaximumFullLODCount_C218;
		}

		// Token: 0x060381AC RID: 229804 RVA: 0x0077A532 File Offset: 0x00778732
		public void CopyValues(ITerrain source)
		{
			this.CopyValues(source, new PPtrConverter(source, this));
		}

		// Token: 0x060381AD RID: 229805 RVA: 0x0077A544 File Offset: 0x00778744

		public override void CopyValues(IUnityAssetBase source, PPtrConverter converter)
		{
			ITerrain terrain = source as ITerrain;
			if (terrain != null)
			{
				this.CopyValues(terrain, converter);
				return;
			}
			base.CopyValues(source, converter);
		}

		// Token: 0x060381AE RID: 229806 RVA: 0x0077A56C File Offset: 0x0077876C
		public override List<TypeTreeNode> MakeEditorTypeTreeNodes(int depth, int startingIndex)
		{
			throw new NotSupportedException();
		}

		// Token: 0x060381AF RID: 229807 RVA: 0x0077A573 File Offset: 0x00778773
		public override List<TypeTreeNode> MakeReleaseTypeTreeNodes(int depth, int startingIndex)
		{
			throw new NotSupportedException();
		}

		// Token: 0x04013698 RID: 79512
		public ushort m_LightmapIndex;

		// Token: 0x04013699 RID: 79513
		public ushort m_LightmapIndexDynamic;

		// Token: 0x0401369A RID: 79514
		public Vector4f_3_5_0 m_LightmapTilingOffset;

		// Token: 0x0401369B RID: 79515
		public Vector4f_3_5_0 m_LightmapTilingOffsetDynamic;

		// Token: 0x0401369C RID: 79516
		public Vector4f_3_5_0 m_DynamicUVST;

		// Token: 0x0401369D RID: 79517
		public Vector4f_3_5_0 m_ChunkDynamicUVST;

		// Token: 0x0401369E RID: 79518
		public float m_ScaleInLightmap;

		// Token: 0x0401369F RID: 79519
		public PPtr_LightmapParameters m_LightmapParameters;

		// Token: 0x040136A0 RID: 79520
		public PPtr_TerrainData_5_0_0 m_TerrainData;

		// Token: 0x040136A1 RID: 79521
		public float m_TreeDistance;

		// Token: 0x040136A2 RID: 79522
		public float m_TreeBillboardDistance;

		// Token: 0x040136A3 RID: 79523
		public float m_TreeCrossFadeLength;

		// Token: 0x040136A4 RID: 79524
		public int m_TreeMaximumFullLODCount;

		// Token: 0x040136A5 RID: 79525
		public float m_DetailObjectDistance;

		// Token: 0x040136A6 RID: 79526
		public float m_DetailObjectDensity;

		// Token: 0x040136A7 RID: 79527
		public float m_HeightmapPixelError;

		// Token: 0x040136A8 RID: 79528
		public float m_SplatMapDistance;

		// Token: 0x040136A9 RID: 79529
		public int m_HeightmapMaximumLOD;

		// Token: 0x040136AA RID: 79530
		public bool m_CastShadows;

		// Token: 0x040136AB RID: 79531
		public bool m_DrawHeightmap;

		// Token: 0x040136AC RID: 79532
		public bool m_DrawTreesAndFoliage;

		// Token: 0x040136AD RID: 79533
		public int m_ReflectionProbeUsage;

		// Token: 0x040136AE RID: 79534
		public int m_MaterialType;

		// Token: 0x040136AF RID: 79535
		public ColorRGBA32 m_LegacySpecular;

		// Token: 0x040136B0 RID: 79536
		public float m_LegacyShininess;

		// Token: 0x040136B1 RID: 79537
		public PPtr_Material_5_0_0 m_MaterialTemplate;

		// Token: 0x040136B2 RID: 79538
		public bool m_BakeLightProbesForTrees;

		public int m_FileID;

		public long m_PathID;
		public int MaskmapMaximumLOD { get; set; }
		public int MaskmapMinimumLOD { get; set; }
		public bool UseMaskmap { get; set; }
	}
}
