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
using AssetRipper.SourceGenerated.Enums;
using AssetRipper.SourceGenerated.Helpers;
using AssetRipper.SourceGenerated.Interfaces;
using AssetRipper.SourceGenerated.MarkerInterfaces;
using AssetRipper.SourceGenerated.Subclasses.LineParameters;
using AssetRipper.SourceGenerated.Subclasses.PPtr_EditorExtensionImpl;
using AssetRipper.SourceGenerated.Subclasses.PPtr_EditorExtension;
using AssetRipper.SourceGenerated.Subclasses.PPtr_GameObject;
using AssetRipper.SourceGenerated.Subclasses.PPtr_LightmapParameters;
using AssetRipper.SourceGenerated.Subclasses.PPtr_Material;
using AssetRipper.SourceGenerated.Subclasses.PPtr_PrefabInstance;
using AssetRipper.SourceGenerated.Subclasses.PPtr_Prefab;
using AssetRipper.SourceGenerated.Subclasses.PPtr_Transform;
using AssetRipper.SourceGenerated.Subclasses.StaticBatchInfo;
using AssetRipper.SourceGenerated.Subclasses.Vector3f;
using AssetRipper.SourceGenerated.Subclasses.Vector4f;
using AssetRipper.Yaml;

using AssetRipper.SourceGenerated.Classes.ClassID_120;
using AssetRipper.Import.GICB2.TrailRenderer.LineParameters;

namespace AssetRipper.Import.GICB2.LineRenderer
{
	// Token: 0x020032D6 RID: 13014


	public sealed class LineRenderer_2017_1_0_GICB2 : Renderer_2017_1_0, ILineRenderer, ILineRendererMarker, IUnityObjectBase, IUnityAssetBase, IAsset, IAssetReadable, IAssetWritable, IYamlExportable, IDependent, ITypeTreeSerializable, IRenderer, IRendererMarker, IHasEnabled, IComponent, IEditorExtension, IEditorExtensionMarker, IObject, IObjectMarker, IHasHideFlags, IComponentMarker
	{
		// Token: 0x1701CFCE RID: 118734
		// (get) Token: 0x0605353E RID: 341310 RVA: 0x0132D436 File Offset: 0x0132B636
		// (set) Token: 0x0605353F RID: 341311 RVA: 0x0132D439 File Offset: 0x0132B639
		public bool ApplyActiveColorSpace_C120
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x1701CFCF RID: 118735
		// (get) Token: 0x06053540 RID: 341312 RVA: 0x0132D43B File Offset: 0x0132B63B
		// (set) Token: 0x06053541 RID: 341313 RVA: 0x0132D443 File Offset: 0x0132B643
		public float AutoUVMaxAngle_C120
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

		// Token: 0x1701CFD0 RID: 118736
		// (get) Token: 0x06053542 RID: 341314 RVA: 0x0132D44C File Offset: 0x0132B64C
		// (set) Token: 0x06053543 RID: 341315 RVA: 0x0132D454 File Offset: 0x0132B654
		public float AutoUVMaxDistance_C120
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

		// Token: 0x1701CFD1 RID: 118737
		// (get) Token: 0x06053544 RID: 341316 RVA: 0x0132D45D File Offset: 0x0132B65D
		// (set) Token: 0x06053545 RID: 341317 RVA: 0x0132D460 File Offset: 0x0132B660
		public bool CastShadows_C120_Boolean
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x1701CFD2 RID: 118738
		// (get) Token: 0x06053546 RID: 341318 RVA: 0x0132D462 File Offset: 0x0132B662
		// (set) Token: 0x06053547 RID: 341319 RVA: 0x0132D46A File Offset: 0x0132B66A
		public byte CastShadows_C120_Byte
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

		// Token: 0x1701CFD3 RID: 118739
		// (get) Token: 0x06053548 RID: 341320 RVA: 0x0132D473 File Offset: 0x0132B673
		public IPPtr_EditorExtension CorrespondingSourceObject_C120
		{
			[return: NotNull]
			get
			{
				return this.m_CorrespondingSourceObject;
			}
		}

		// Token: 0x1701CFD4 RID: 118740
		// (get) Token: 0x06053549 RID: 341321 RVA: 0x0132D47B File Offset: 0x0132B67B
		// (set) Token: 0x0605354A RID: 341322 RVA: 0x0132D47E File Offset: 0x0132B67E
		public byte DynamicOccludee_C120
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x1701CFD5 RID: 118741
		// (get) Token: 0x0605354B RID: 341323 RVA: 0x0132D480 File Offset: 0x0132B680
		// (set) Token: 0x0605354C RID: 341324 RVA: 0x0132D488 File Offset: 0x0132B688
		public bool Enabled_C120
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

		// Token: 0x1701CFD6 RID: 118742
		// (get) Token: 0x0605354D RID: 341325 RVA: 0x0132D491 File Offset: 0x0132B691
		public PPtr_EditorExtensionImpl ExtensionPtr_C120
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1701CFD7 RID: 118743
		// (get) Token: 0x0605354E RID: 341326 RVA: 0x0132D494 File Offset: 0x0132B694

		public IPPtr_GameObject GameObject_C120
		{

			get
			{
				return this.m_GameObject;
			}
		}

		// Token: 0x1701CFD8 RID: 118744
		// (get) Token: 0x0605354F RID: 341327 RVA: 0x0132D49C File Offset: 0x0132B69C
		// (set) Token: 0x06053550 RID: 341328 RVA: 0x0132D4A4 File Offset: 0x0132B6A4
		public uint HideFlags_C120
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

		// Token: 0x1701CFD9 RID: 118745
		// (get) Token: 0x06053551 RID: 341329 RVA: 0x0132D4AD File Offset: 0x0132B6AD
		// (set) Token: 0x06053552 RID: 341330 RVA: 0x0132D4B5 File Offset: 0x0132B6B5
		public bool IgnoreNormalsForChartDetection_C120
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

		// Token: 0x1701CFDA RID: 118746
		// (get) Token: 0x06053553 RID: 341331 RVA: 0x0132D4BE File Offset: 0x0132B6BE
		// (set) Token: 0x06053554 RID: 341332 RVA: 0x0132D4C6 File Offset: 0x0132B6C6
		public bool ImportantGI_C120
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

		// Token: 0x1701CFDB RID: 118747
		// (get) Token: 0x06053555 RID: 341333 RVA: 0x0132D4CF File Offset: 0x0132B6CF
		// (set) Token: 0x06053556 RID: 341334 RVA: 0x0132D4D2 File Offset: 0x0132B6D2
		public byte LightmapIndex_C120_Byte
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x1701CFDC RID: 118748
		// (get) Token: 0x06053557 RID: 341335 RVA: 0x0132D4D4 File Offset: 0x0132B6D4
		// (set) Token: 0x06053558 RID: 341336 RVA: 0x0132D4DC File Offset: 0x0132B6DC
		public ushort LightmapIndex_C120_UInt16
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

		// Token: 0x1701CFDD RID: 118749
		// (get) Token: 0x06053559 RID: 341337 RVA: 0x0132D4E5 File Offset: 0x0132B6E5
		// (set) Token: 0x0605355A RID: 341338 RVA: 0x0132D4ED File Offset: 0x0132B6ED
		public ushort LightmapIndexDynamic_C120
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

		// Token: 0x1701CFDE RID: 118750
		// (get) Token: 0x0605355B RID: 341339 RVA: 0x0132D4F6 File Offset: 0x0132B6F6
		public PPtr_LightmapParameters LightmapParameters_C120
		{
			[return: NotNull]
			get
			{
				return this.m_LightmapParameters;
			}
		}

		// Token: 0x1701CFDF RID: 118751
		// (get) Token: 0x0605355C RID: 341340 RVA: 0x0132D4FE File Offset: 0x0132B6FE

		public IVector4f LightmapTilingOffset_C120
		{

			get
			{
				return this.m_LightmapTilingOffset;
			}
		}

		// Token: 0x1701CFE0 RID: 118752
		// (get) Token: 0x0605355D RID: 341341 RVA: 0x0132D506 File Offset: 0x0132B706
		public Vector4f_3_5_0 LightmapTilingOffsetDynamic_C120
		{
			[return: NotNull]
			get
			{
				return this.m_LightmapTilingOffsetDynamic;
			}
		}

		// Token: 0x1701CFE1 RID: 118753
		// (get) Token: 0x0605355E RID: 341342 RVA: 0x0132D50E File Offset: 0x0132B70E
		public PPtr_Transform_3_4_0 LightProbeAnchor_C120
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1701CFE2 RID: 118754
		// (get) Token: 0x0605355F RID: 341343 RVA: 0x0132D511 File Offset: 0x0132B711
		// (set) Token: 0x06053560 RID: 341344 RVA: 0x0132D519 File Offset: 0x0132B719
		public byte LightProbeUsage_C120
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

		// Token: 0x1701CFE3 RID: 118755
		// (get) Token: 0x06053561 RID: 341345 RVA: 0x0132D522 File Offset: 0x0132B722
		public PPtr_GameObject_5_0_0 LightProbeVolumeOverride_C120
		{
			[return: NotNull]
			get
			{
				return this.m_LightProbeVolumeOverride;
			}
		}

		// Token: 0x1701CFE4 RID: 118756
		// (get) Token: 0x06053562 RID: 341346 RVA: 0x0132D52A File Offset: 0x0132B72A
		// (set) Token: 0x06053563 RID: 341347 RVA: 0x0132D532 File Offset: 0x0132B732
		public bool Loop_C120
		{
			get
			{
				return this.m_Loop;
			}
			set
			{
				this.m_Loop = value;
			}
		}

		// Token: 0x1701CFE5 RID: 118757
		// (get) Token: 0x06053564 RID: 341348 RVA: 0x0132D53B File Offset: 0x0132B73B
		// (set) Token: 0x06053565 RID: 341349 RVA: 0x0132D53E File Offset: 0x0132B73E
		public int MaskInteraction_C120
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x1701CFE6 RID: 118758
		// (get) Token: 0x06053566 RID: 341350 RVA: 0x0132D540 File Offset: 0x0132B740

		public AccessListBase<IPPtr_Material> Materials_C120
		{

			get
			{
				return new AccessList<PPtr_Material_5_0_0, IPPtr_Material>(this.m_Materials);
			}
		}

		// Token: 0x1701CFE7 RID: 118759
		// (get) Token: 0x06053567 RID: 341351 RVA: 0x0132D54D File Offset: 0x0132B74D
		// (set) Token: 0x06053568 RID: 341352 RVA: 0x0132D555 File Offset: 0x0132B755
		public int MinimumChartSize_C120
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

		// Token: 0x1701CFE8 RID: 118760
		// (get) Token: 0x06053569 RID: 341353 RVA: 0x0132D55E File Offset: 0x0132B75E
		// (set) Token: 0x0605356A RID: 341354 RVA: 0x0132D566 File Offset: 0x0132B766
		public byte MotionVectors_C120
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

		// Token: 0x1701CFE9 RID: 118761
		// (get) Token: 0x0605356B RID: 341355 RVA: 0x0132D56F File Offset: 0x0132B76F

		public ILineParameters Parameters_C120
		{

			get
			{
				return this.m_Parameters;
			}
		}

		// Token: 0x1701CFEA RID: 118762
		// (get) Token: 0x0605356C RID: 341356 RVA: 0x0132D577 File Offset: 0x0132B777

		public AccessListBase<IVector3f> Positions_C120
		{

			get
			{
				return new AccessList<Vector3f_3_5_0, IVector3f>(this.m_Positions);
			}
		}

		// Token: 0x1701CFEB RID: 118763
		// (get) Token: 0x0605356D RID: 341357 RVA: 0x0132D584 File Offset: 0x0132B784
		public PPtr_Prefab_2018_3_0 PrefabAsset_C120
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1701CFEC RID: 118764
		// (get) Token: 0x0605356E RID: 341358 RVA: 0x0132D587 File Offset: 0x0132B787
		public PPtr_PrefabInstance PrefabInstance_C120
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1701CFED RID: 118765
		// (get) Token: 0x0605356F RID: 341359 RVA: 0x0132D58A File Offset: 0x0132B78A
		public IPPtr_Prefab PrefabInternal_C120
		{
			[return: NotNull]
			get
			{
				return this.m_PrefabInternal;
			}
		}

		// Token: 0x1701CFEE RID: 118766
		// (get) Token: 0x06053570 RID: 341360 RVA: 0x0132D592 File Offset: 0x0132B792
		// (set) Token: 0x06053571 RID: 341361 RVA: 0x0132D59A File Offset: 0x0132B79A
		public bool PreserveUVs_C120
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

		// Token: 0x1701CFEF RID: 118767
		// (get) Token: 0x06053572 RID: 341362 RVA: 0x0132D5A3 File Offset: 0x0132B7A3
		public PPtr_Transform_5_0_0 ProbeAnchor_C120
		{
			[return: NotNull]
			get
			{
				return this.m_ProbeAnchor;
			}
		}

		// Token: 0x1701CFF0 RID: 118768
		// (get) Token: 0x06053573 RID: 341363 RVA: 0x0132D5AB File Offset: 0x0132B7AB
		// (set) Token: 0x06053574 RID: 341364 RVA: 0x0132D5AE File Offset: 0x0132B7AE
		public byte RayTraceProcedural_C120
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x1701CFF1 RID: 118769
		// (get) Token: 0x06053575 RID: 341365 RVA: 0x0132D5B0 File Offset: 0x0132B7B0
		// (set) Token: 0x06053576 RID: 341366 RVA: 0x0132D5B3 File Offset: 0x0132B7B3
		public byte RayTracingMode_C120
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x1701CFF2 RID: 118770
		// (get) Token: 0x06053577 RID: 341367 RVA: 0x0132D5B5 File Offset: 0x0132B7B5
		// (set) Token: 0x06053578 RID: 341368 RVA: 0x0132D5B8 File Offset: 0x0132B7B8
		public int ReceiveGI_C120
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x1701CFF3 RID: 118771
		// (get) Token: 0x06053579 RID: 341369 RVA: 0x0132D5BA File Offset: 0x0132B7BA
		// (set) Token: 0x0605357A RID: 341370 RVA: 0x0132D5BD File Offset: 0x0132B7BD
		public bool ReceiveShadows_C120_Boolean
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x1701CFF4 RID: 118772
		// (get) Token: 0x0605357B RID: 341371 RVA: 0x0132D5BF File Offset: 0x0132B7BF
		// (set) Token: 0x0605357C RID: 341372 RVA: 0x0132D5C7 File Offset: 0x0132B7C7
		public byte ReceiveShadows_C120_Byte
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

		// Token: 0x1701CFF5 RID: 118773
		// (get) Token: 0x0605357D RID: 341373 RVA: 0x0132D5D0 File Offset: 0x0132B7D0
		// (set) Token: 0x0605357E RID: 341374 RVA: 0x0132D5D3 File Offset: 0x0132B7D3
		public int ReflectionProbeUsage_C120_Int32
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x1701CFF6 RID: 118774
		// (get) Token: 0x0605357F RID: 341375 RVA: 0x0132D5D5 File Offset: 0x0132B7D5
		// (set) Token: 0x06053580 RID: 341376 RVA: 0x0132D5DD File Offset: 0x0132B7DD
		public byte ReflectionProbeUsage_C120_Byte
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

		// Token: 0x1701CFF7 RID: 118775
		// (get) Token: 0x06053581 RID: 341377 RVA: 0x0132D5E6 File Offset: 0x0132B7E6
		// (set) Token: 0x06053582 RID: 341378 RVA: 0x0132D5E9 File Offset: 0x0132B7E9
		public int RendererPriority_C120
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x1701CFF8 RID: 118776
		// (get) Token: 0x06053583 RID: 341379 RVA: 0x0132D5EB File Offset: 0x0132B7EB
		// (set) Token: 0x06053584 RID: 341380 RVA: 0x0132D5EE File Offset: 0x0132B7EE
		public uint RenderingLayerMask_C120
		{
			get
			{
				return 0U;
			}
			set
			{
			}
		}

		// Token: 0x1701CFF9 RID: 118777
		// (get) Token: 0x06053585 RID: 341381 RVA: 0x0132D5F0 File Offset: 0x0132B7F0
		// (set) Token: 0x06053586 RID: 341382 RVA: 0x0132D5F8 File Offset: 0x0132B7F8
		public float ScaleInLightmap_C120
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

		// Token: 0x1701CFFA RID: 118778
		// (get) Token: 0x06053587 RID: 341383 RVA: 0x0132D601 File Offset: 0x0132B801
		// (set) Token: 0x06053588 RID: 341384 RVA: 0x0132D609 File Offset: 0x0132B809
		public int SelectedEditorRenderState_C120
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

		// Token: 0x1701CFFB RID: 118779
		// (get) Token: 0x06053589 RID: 341385 RVA: 0x0132D612 File Offset: 0x0132B812
		// (set) Token: 0x0605358A RID: 341386 RVA: 0x0132D615 File Offset: 0x0132B815
		public bool SelectedWireframeHidden_C120
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x1701CFFC RID: 118780
		// (get) Token: 0x0605358B RID: 341387 RVA: 0x0132D617 File Offset: 0x0132B817
		// (set) Token: 0x0605358C RID: 341388 RVA: 0x0132D61F File Offset: 0x0132B81F
		public short SortingLayer_C120
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

		// Token: 0x1701CFFD RID: 118781
		// (get) Token: 0x0605358D RID: 341389 RVA: 0x0132D628 File Offset: 0x0132B828
		// (set) Token: 0x0605358E RID: 341390 RVA: 0x0132D62B File Offset: 0x0132B82B
		public uint SortingLayerID_C120_UInt32
		{
			get
			{
				return 0U;
			}
			set
			{
			}
		}

		// Token: 0x1701CFFE RID: 118782
		// (get) Token: 0x0605358F RID: 341391 RVA: 0x0132D62D File Offset: 0x0132B82D
		// (set) Token: 0x06053590 RID: 341392 RVA: 0x0132D635 File Offset: 0x0132B835
		public int SortingLayerID_C120_Int32
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

		// Token: 0x1701CFFF RID: 118783
		// (get) Token: 0x06053591 RID: 341393 RVA: 0x0132D63E File Offset: 0x0132B83E
		// (set) Token: 0x06053592 RID: 341394 RVA: 0x0132D646 File Offset: 0x0132B846
		public short SortingOrder_C120
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

		// Token: 0x1701D000 RID: 118784
		// (get) Token: 0x06053593 RID: 341395 RVA: 0x0132D64F File Offset: 0x0132B84F
		public StaticBatchInfo StaticBatchInfo_C120
		{
			[return: NotNull]
			get
			{
				return this.m_StaticBatchInfo;
			}
		}

		// Token: 0x1701D001 RID: 118785
		// (get) Token: 0x06053594 RID: 341396 RVA: 0x0132D657 File Offset: 0x0132B857

		public IPPtr_Transform StaticBatchRoot_C120
		{

			get
			{
				return this.m_StaticBatchRoot;
			}
		}

		// Token: 0x1701D002 RID: 118786
		// (get) Token: 0x06053595 RID: 341397 RVA: 0x0132D65F File Offset: 0x0132B85F
		// (set) Token: 0x06053596 RID: 341398 RVA: 0x0132D662 File Offset: 0x0132B862
		public byte StaticShadowCaster_C120
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x1701D003 RID: 118787
		// (get) Token: 0x06053597 RID: 341399 RVA: 0x0132D664 File Offset: 0x0132B864
		// (set) Token: 0x06053598 RID: 341400 RVA: 0x0132D667 File Offset: 0x0132B867
		public bool StitchLightmapSeams_C120
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x1701D004 RID: 118788
		// (get) Token: 0x06053599 RID: 341401 RVA: 0x0132D669 File Offset: 0x0132B869
		// (set) Token: 0x0605359A RID: 341402 RVA: 0x0132D66C File Offset: 0x0132B86C
		public bool StitchSeams_C120
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x1701D005 RID: 118789
		// (get) Token: 0x0605359B RID: 341403 RVA: 0x0132D66E File Offset: 0x0132B86E
		// (set) Token: 0x0605359C RID: 341404 RVA: 0x0132D671 File Offset: 0x0132B871
		public uint[] SubsetIndices_C120
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x1701D006 RID: 118790
		// (get) Token: 0x0605359D RID: 341405 RVA: 0x0132D673 File Offset: 0x0132B873
		// (set) Token: 0x0605359E RID: 341406 RVA: 0x0132D676 File Offset: 0x0132B876
		public bool UseLightProbes_C120
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x1701D007 RID: 118791
		// (get) Token: 0x0605359F RID: 341407 RVA: 0x0132D678 File Offset: 0x0132B878
		// (set) Token: 0x060535A0 RID: 341408 RVA: 0x0132D680 File Offset: 0x0132B880
		public bool UseWorldSpace_C120
		{
			get
			{
				return this.m_UseWorldSpace;
			}
			set
			{
				this.m_UseWorldSpace = value;
			}
		}

		// Token: 0x1701D008 RID: 118792
		// (get) Token: 0x060535A1 RID: 341409 RVA: 0x0132D689 File Offset: 0x0132B889
		// (set) Token: 0x060535A2 RID: 341410 RVA: 0x0132D691 File Offset: 0x0132B891
		public HideFlags HideFlags_C120E
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

		// Token: 0x1701D009 RID: 118793
		// (get) Token: 0x060535A3 RID: 341411 RVA: 0x0132D69A File Offset: 0x0132B89A
		// (set) Token: 0x060535A4 RID: 341412 RVA: 0x0132D6A2 File Offset: 0x0132B8A2
		public LightProbeUsage LightProbeUsage_C120E
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

		// Token: 0x1701D00A RID: 118794
		// (get) Token: 0x060535A5 RID: 341413 RVA: 0x0132D6AC File Offset: 0x0132B8AC
		// (set) Token: 0x060535A6 RID: 341414 RVA: 0x0132D6AF File Offset: 0x0132B8AF
		public SpriteMaskInteraction MaskInteraction_C120E
		{
			get
			{
				return SpriteMaskInteraction.None;
			}
			set
			{
			}
		}

		// Token: 0x1701D00B RID: 118795
		// (get) Token: 0x060535A7 RID: 341415 RVA: 0x0132D6B1 File Offset: 0x0132B8B1
		// (set) Token: 0x060535A8 RID: 341416 RVA: 0x0132D6B4 File Offset: 0x0132B8B4
		public RayTracingMode RayTracingMode_C120E
		{
			get
			{
				return RayTracingMode.Off;
			}
			set
			{
			}
		}

		// Token: 0x1701D00C RID: 118796
		// (get) Token: 0x060535A9 RID: 341417 RVA: 0x0132D6B6 File Offset: 0x0132B8B6
		// (set) Token: 0x060535AA RID: 341418 RVA: 0x0132D6B9 File Offset: 0x0132B8B9
		public ReflectionProbeUsage ReflectionProbeUsage_C120_Int32E
		{
			get
			{
				return ReflectionProbeUsage.Off;
			}
			set
			{
			}
		}

		// Token: 0x1701D00D RID: 118797
		// (get) Token: 0x060535AB RID: 341419 RVA: 0x0132D6BB File Offset: 0x0132B8BB
		// (set) Token: 0x060535AC RID: 341420 RVA: 0x0132D6C3 File Offset: 0x0132B8C3
		public ReflectionProbeUsage ReflectionProbeUsage_C120_ByteE
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

		// Token: 0x1701D00E RID: 118798
		// (get) Token: 0x060535AD RID: 341421 RVA: 0x0132D6CD File Offset: 0x0132B8CD
		// (set) Token: 0x060535AE RID: 341422 RVA: 0x0132D6E0 File Offset: 0x0132B8E0
		public IEditorExtension CorrespondingSourceObject_C120P
		{
			get
			{
				return PPtrExtensions.TryGetAsset<IEditorExtension>(this.CorrespondingSourceObject_C120, base.Collection);
			}
			set
			{
				PPtrExtensions.SetAsset<IEditorExtension>(this.CorrespondingSourceObject_C120, base.Collection, value);
			}
		}

		// Token: 0x1701D00F RID: 118799
		// (get) Token: 0x060535AF RID: 341423 RVA: 0x0132D6F4 File Offset: 0x0132B8F4
		// (set) Token: 0x060535B0 RID: 341424 RVA: 0x0132D6F7 File Offset: 0x0132B8F7
		public IEditorExtensionImpl ExtensionPtr_C120P
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x1701D010 RID: 118800
		// (get) Token: 0x060535B1 RID: 341425 RVA: 0x0132D6F9 File Offset: 0x0132B8F9
		// (set) Token: 0x060535B2 RID: 341426 RVA: 0x0132D70C File Offset: 0x0132B90C
		public IGameObject GameObject_C120P
		{
			get
			{
				return PPtrExtensions.TryGetAsset<IGameObject>(this.GameObject_C120, base.Collection);
			}
			set
			{
				PPtrExtensions.SetAsset<IGameObject>(this.GameObject_C120, base.Collection, value);
			}
		}

		// Token: 0x1701D011 RID: 118801
		// (get) Token: 0x060535B3 RID: 341427 RVA: 0x0132D720 File Offset: 0x0132B920
		// (set) Token: 0x060535B4 RID: 341428 RVA: 0x0132D733 File Offset: 0x0132B933
		public ILightmapParameters LightmapParameters_C120P
		{
			get
			{
				return PPtrExtensions.TryGetAsset<ILightmapParameters>(this.LightmapParameters_C120, base.Collection);
			}
			set
			{
				PPtrExtensions.SetAsset<ILightmapParameters>(this.LightmapParameters_C120, base.Collection, value);
			}
		}

		// Token: 0x1701D012 RID: 118802
		// (get) Token: 0x060535B5 RID: 341429 RVA: 0x0132D747 File Offset: 0x0132B947
		// (set) Token: 0x060535B6 RID: 341430 RVA: 0x0132D74A File Offset: 0x0132B94A
		public ITransform LightProbeAnchor_C120P
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x1701D013 RID: 118803
		// (get) Token: 0x060535B7 RID: 341431 RVA: 0x0132D74C File Offset: 0x0132B94C
		// (set) Token: 0x060535B8 RID: 341432 RVA: 0x0132D75F File Offset: 0x0132B95F
		public IGameObject LightProbeVolumeOverride_C120P
		{
			get
			{
				return PPtrExtensions.TryGetAsset<IGameObject>(this.LightProbeVolumeOverride_C120, base.Collection);
			}
			set
			{
				PPtrExtensions.SetAsset<IGameObject>(this.LightProbeVolumeOverride_C120, base.Collection, value);
			}
		}

		// Token: 0x1701D014 RID: 118804
		// (get) Token: 0x060535B9 RID: 341433 RVA: 0x0132D773 File Offset: 0x0132B973

		public PPtrAccessList<IPPtr_Material, IMaterial> Materials_C120P
		{

			get
			{
				return new PPtrAccessList<IPPtr_Material, IMaterial>(this.Materials_C120, this);
			}
		}

		// Token: 0x1701D015 RID: 118805
		// (get) Token: 0x060535BA RID: 341434 RVA: 0x0132D781 File Offset: 0x0132B981
		// (set) Token: 0x060535BB RID: 341435 RVA: 0x0132D784 File Offset: 0x0132B984
		public IPrefab PrefabAsset_C120P
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x1701D016 RID: 118806
		// (get) Token: 0x060535BC RID: 341436 RVA: 0x0132D786 File Offset: 0x0132B986
		// (set) Token: 0x060535BD RID: 341437 RVA: 0x0132D789 File Offset: 0x0132B989
		public IPrefabInstance PrefabInstance_C120P
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x1701D017 RID: 118807
		// (get) Token: 0x060535BE RID: 341438 RVA: 0x0132D78B File Offset: 0x0132B98B
		// (set) Token: 0x060535BF RID: 341439 RVA: 0x0132D79E File Offset: 0x0132B99E
		public IPrefabMarker PrefabInternal_C120P
		{
			get
			{
				return PPtrExtensions.TryGetAsset<IPrefabMarker>(this.PrefabInternal_C120, base.Collection);
			}
			set
			{
				PPtrExtensions.SetAsset<IPrefabMarker>(this.PrefabInternal_C120, base.Collection, value);
			}
		}

		// Token: 0x1701D018 RID: 118808
		// (get) Token: 0x060535C0 RID: 341440 RVA: 0x0132D7B2 File Offset: 0x0132B9B2
		// (set) Token: 0x060535C1 RID: 341441 RVA: 0x0132D7C5 File Offset: 0x0132B9C5
		public ITransform ProbeAnchor_C120P
		{
			get
			{
				return PPtrExtensions.TryGetAsset<ITransform>(this.ProbeAnchor_C120, base.Collection);
			}
			set
			{
				PPtrExtensions.SetAsset<ITransform>(this.ProbeAnchor_C120, base.Collection, value);
			}
		}

		// Token: 0x1701D019 RID: 118809
		// (get) Token: 0x060535C2 RID: 341442 RVA: 0x0132D7D9 File Offset: 0x0132B9D9
		// (set) Token: 0x060535C3 RID: 341443 RVA: 0x0132D7EC File Offset: 0x0132B9EC
		public ITransform StaticBatchRoot_C120P
		{
			get
			{
				return PPtrExtensions.TryGetAsset<ITransform>(this.StaticBatchRoot_C120, base.Collection);
			}
			set
			{
				PPtrExtensions.SetAsset<ITransform>(this.StaticBatchRoot_C120, base.Collection, value);
			}
		}

		// Token: 0x1701D01A RID: 118810
		// (get) Token: 0x060535C4 RID: 341444 RVA: 0x0132D800 File Offset: 0x0132BA00

		public override string ClassName
		{

			get
			{
				return "LineRenderer";
			}
		}

		// Token: 0x060535C5 RID: 341445 RVA: 0x0132D807 File Offset: 0x0132BA07
		public LineRenderer_2017_1_0_GICB2()
			: this(AssetInfo.MakeDummyAssetInfo(120))
		{
		}

		// Token: 0x060535C6 RID: 341446 RVA: 0x0132D816 File Offset: 0x0132BA16
		public LineRenderer_2017_1_0_GICB2(AssetInfo info)
			: base(info)
		{
			this.m_Positions = new AssetList<Vector3f_3_5_0>();
			this.m_Parameters = new LineParameters_2017_1_0_GICB2();
		}

		// Token: 0x060535C7 RID: 341447 RVA: 0x0132D835 File Offset: 0x0132BA35
		public bool Has_ApplyActiveColorSpace_C120()
		{
			return false;
		}

		// Token: 0x060535C8 RID: 341448 RVA: 0x0132D838 File Offset: 0x0132BA38
		public bool Has_AutoUVMaxAngle_C120()
		{
			return true;
		}

		// Token: 0x060535C9 RID: 341449 RVA: 0x0132D83B File Offset: 0x0132BA3B
		public bool Has_AutoUVMaxDistance_C120()
		{
			return true;
		}

		// Token: 0x060535CA RID: 341450 RVA: 0x0132D83E File Offset: 0x0132BA3E
		public bool Has_CastShadows_C120_Boolean()
		{
			return false;
		}

		// Token: 0x060535CB RID: 341451 RVA: 0x0132D841 File Offset: 0x0132BA41
		public bool Has_CastShadows_C120_Byte()
		{
			return true;
		}

		// Token: 0x060535CC RID: 341452 RVA: 0x0132D844 File Offset: 0x0132BA44
		public bool Has_CorrespondingSourceObject_C120()
		{
			return true;
		}

		// Token: 0x060535CD RID: 341453 RVA: 0x0132D847 File Offset: 0x0132BA47
		public bool Has_DynamicOccludee_C120()
		{
			return false;
		}

		// Token: 0x060535CE RID: 341454 RVA: 0x0132D84A File Offset: 0x0132BA4A
		public bool Has_ExtensionPtr_C120()
		{
			return false;
		}

		// Token: 0x060535CF RID: 341455 RVA: 0x0132D84D File Offset: 0x0132BA4D
		public bool Has_IgnoreNormalsForChartDetection_C120()
		{
			return true;
		}

		// Token: 0x060535D0 RID: 341456 RVA: 0x0132D850 File Offset: 0x0132BA50
		public bool Has_ImportantGI_C120()
		{
			return true;
		}

		// Token: 0x060535D1 RID: 341457 RVA: 0x0132D853 File Offset: 0x0132BA53
		public bool Has_LightmapIndex_C120_Byte()
		{
			return false;
		}

		// Token: 0x060535D2 RID: 341458 RVA: 0x0132D856 File Offset: 0x0132BA56
		public bool Has_LightmapIndex_C120_UInt16()
		{
			return true;
		}

		// Token: 0x060535D3 RID: 341459 RVA: 0x0132D859 File Offset: 0x0132BA59
		public bool Has_LightmapIndexDynamic_C120()
		{
			return true;
		}

		// Token: 0x060535D4 RID: 341460 RVA: 0x0132D85C File Offset: 0x0132BA5C
		public bool Has_LightmapParameters_C120()
		{
			return true;
		}

		// Token: 0x060535D5 RID: 341461 RVA: 0x0132D85F File Offset: 0x0132BA5F
		public bool Has_LightmapTilingOffsetDynamic_C120()
		{
			return true;
		}

		// Token: 0x060535D6 RID: 341462 RVA: 0x0132D862 File Offset: 0x0132BA62
		public bool Has_LightProbeAnchor_C120()
		{
			return false;
		}

		// Token: 0x060535D7 RID: 341463 RVA: 0x0132D865 File Offset: 0x0132BA65
		public bool Has_LightProbeUsage_C120()
		{
			return true;
		}

		// Token: 0x060535D8 RID: 341464 RVA: 0x0132D868 File Offset: 0x0132BA68
		public bool Has_LightProbeVolumeOverride_C120()
		{
			return true;
		}

		// Token: 0x060535D9 RID: 341465 RVA: 0x0132D86B File Offset: 0x0132BA6B
		public bool Has_Loop_C120()
		{
			return true;
		}

		// Token: 0x060535DA RID: 341466 RVA: 0x0132D86E File Offset: 0x0132BA6E
		public bool Has_MaskInteraction_C120()
		{
			return false;
		}

		// Token: 0x060535DB RID: 341467 RVA: 0x0132D871 File Offset: 0x0132BA71
		public bool Has_MinimumChartSize_C120()
		{
			return true;
		}

		// Token: 0x060535DC RID: 341468 RVA: 0x0132D874 File Offset: 0x0132BA74
		public bool Has_MotionVectors_C120()
		{
			return true;
		}

		// Token: 0x060535DD RID: 341469 RVA: 0x0132D877 File Offset: 0x0132BA77
		public bool Has_PrefabAsset_C120()
		{
			return false;
		}

		// Token: 0x060535DE RID: 341470 RVA: 0x0132D87A File Offset: 0x0132BA7A
		public bool Has_PrefabInstance_C120()
		{
			return false;
		}

		// Token: 0x060535DF RID: 341471 RVA: 0x0132D87D File Offset: 0x0132BA7D
		public bool Has_PrefabInternal_C120()
		{
			return true;
		}

		// Token: 0x060535E0 RID: 341472 RVA: 0x0132D880 File Offset: 0x0132BA80
		public bool Has_PreserveUVs_C120()
		{
			return true;
		}

		// Token: 0x060535E1 RID: 341473 RVA: 0x0132D883 File Offset: 0x0132BA83
		public bool Has_ProbeAnchor_C120()
		{
			return true;
		}

		// Token: 0x060535E2 RID: 341474 RVA: 0x0132D886 File Offset: 0x0132BA86
		public bool Has_RayTraceProcedural_C120()
		{
			return false;
		}

		// Token: 0x060535E3 RID: 341475 RVA: 0x0132D889 File Offset: 0x0132BA89
		public bool Has_RayTracingMode_C120()
		{
			return false;
		}

		// Token: 0x060535E4 RID: 341476 RVA: 0x0132D88C File Offset: 0x0132BA8C
		public bool Has_ReceiveGI_C120()
		{
			return false;
		}

		// Token: 0x060535E5 RID: 341477 RVA: 0x0132D88F File Offset: 0x0132BA8F
		public bool Has_ReceiveShadows_C120_Boolean()
		{
			return false;
		}

		// Token: 0x060535E6 RID: 341478 RVA: 0x0132D892 File Offset: 0x0132BA92
		public bool Has_ReceiveShadows_C120_Byte()
		{
			return true;
		}

		// Token: 0x060535E7 RID: 341479 RVA: 0x0132D895 File Offset: 0x0132BA95
		public bool Has_ReflectionProbeUsage_C120_Int32()
		{
			return false;
		}

		// Token: 0x060535E8 RID: 341480 RVA: 0x0132D898 File Offset: 0x0132BA98
		public bool Has_ReflectionProbeUsage_C120_Byte()
		{
			return true;
		}

		// Token: 0x060535E9 RID: 341481 RVA: 0x0132D89B File Offset: 0x0132BA9B
		public bool Has_RendererPriority_C120()
		{
			return false;
		}

		// Token: 0x060535EA RID: 341482 RVA: 0x0132D89E File Offset: 0x0132BA9E
		public bool Has_RenderingLayerMask_C120()
		{
			return false;
		}

		// Token: 0x060535EB RID: 341483 RVA: 0x0132D8A1 File Offset: 0x0132BAA1
		public bool Has_SelectedEditorRenderState_C120()
		{
			return true;
		}

		// Token: 0x060535EC RID: 341484 RVA: 0x0132D8A4 File Offset: 0x0132BAA4
		public bool Has_SelectedWireframeHidden_C120()
		{
			return false;
		}

		// Token: 0x060535ED RID: 341485 RVA: 0x0132D8A7 File Offset: 0x0132BAA7
		public bool Has_SortingLayer_C120()
		{
			return true;
		}

		// Token: 0x060535EE RID: 341486 RVA: 0x0132D8AA File Offset: 0x0132BAAA
		public bool Has_SortingLayerID_C120_UInt32()
		{
			return false;
		}

		// Token: 0x060535EF RID: 341487 RVA: 0x0132D8AD File Offset: 0x0132BAAD
		public bool Has_SortingLayerID_C120_Int32()
		{
			return true;
		}

		// Token: 0x060535F0 RID: 341488 RVA: 0x0132D8B0 File Offset: 0x0132BAB0
		public bool Has_SortingOrder_C120()
		{
			return true;
		}

		// Token: 0x060535F1 RID: 341489 RVA: 0x0132D8B3 File Offset: 0x0132BAB3
		public bool Has_StaticBatchInfo_C120()
		{
			return true;
		}

		// Token: 0x060535F2 RID: 341490 RVA: 0x0132D8B6 File Offset: 0x0132BAB6
		public bool Has_StaticShadowCaster_C120()
		{
			return false;
		}

		// Token: 0x060535F3 RID: 341491 RVA: 0x0132D8B9 File Offset: 0x0132BAB9
		public bool Has_StitchLightmapSeams_C120()
		{
			return false;
		}

		// Token: 0x060535F4 RID: 341492 RVA: 0x0132D8BC File Offset: 0x0132BABC
		public bool Has_StitchSeams_C120()
		{
			return false;
		}

		// Token: 0x060535F5 RID: 341493 RVA: 0x0132D8BF File Offset: 0x0132BABF
		public bool Has_SubsetIndices_C120()
		{
			return false;
		}

		// Token: 0x060535F6 RID: 341494 RVA: 0x0132D8C2 File Offset: 0x0132BAC2
		public bool Has_UseLightProbes_C120()
		{
			return false;
		}

		// Token: 0x060535F7 RID: 341495 RVA: 0x0132D8C8 File Offset: 0x0132BAC8

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

			this.m_Positions.ReadRelease_ArrayAlign_Asset(reader);
			this.m_Parameters.ReadRelease(reader);
			this.m_UseWorldSpace = reader.ReadBoolean();
			this.m_Loop = reader.ReadBoolean();
		}

		// Token: 0x060535F8 RID: 341496 RVA: 0x0132D9EC File Offset: 0x0132BBEC



		// Token: 0x060535F9 RID: 341497 RVA: 0x0132DB70 File Offset: 0x0132BD70

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
			this.m_Positions.WriteRelease_ArrayAlign_Asset(writer);
			this.m_Parameters.WriteRelease(writer);
			this.m_UseWorldSpace.WriteRelease_Boolean(writer);
			this.m_Loop.WriteRelease_Boolean(writer);
		}

		// Token: 0x060535FA RID: 341498 RVA: 0x0132DC94 File Offset: 0x0132BE94



		// Token: 0x060535FB RID: 341499 RVA: 0x0132DE18 File Offset: 0x0132C018

		public override YamlNode ExportYamlRelease(IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			YamlSerializedVersionExtensions.AddSerializedVersion(yamlMappingNode, 1);
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
			yamlMappingNode.Add(new YamlScalarNode("m_Positions"), this.m_Positions.ExportYamlRelease_Array_Vector3f_3_5_0(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Parameters"), this.m_Parameters.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("m_UseWorldSpace"), this.m_UseWorldSpace.ExportYamlRelease_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Loop"), this.m_Loop.ExportYamlRelease_Boolean(container));
			return yamlMappingNode;
		}

		// Token: 0x060535FC RID: 341500 RVA: 0x0132E0B8 File Offset: 0x0132C2B8

		public override YamlNode ExportYamlEditor(IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			YamlSerializedVersionExtensions.AddSerializedVersion(yamlMappingNode, 1);
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
			yamlMappingNode.Add(new YamlScalarNode("m_Positions"), this.m_Positions.ExportYamlEditor_Array_Vector3f_3_5_0(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Parameters"), this.m_Parameters.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_UseWorldSpace"), this.m_UseWorldSpace.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Loop"), this.m_Loop.ExportYamlEditor_Boolean(container));
			return yamlMappingNode;
		}

		// Token: 0x060535FD RID: 341501 RVA: 0x0132E438 File Offset: 0x0132C638
		public override void Reset()
		{
			this.m_AutoUVMaxAngle = 0f;
			this.m_AutoUVMaxDistance = 0f;
			this.m_CastShadows = 0;
			this.m_CorrespondingSourceObject.Reset();
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
			this.m_Loop = false;
			this.m_Materials.Clear();
			this.m_MinimumChartSize = 0;
			this.m_MotionVectors = 0;
			this.m_Parameters.Reset();
			this.m_Positions.Clear();
			this.m_PrefabInternal.Reset();
			this.m_PreserveUVs = false;
			this.m_ProbeAnchor.Reset();
			this.m_ReceiveShadows = 0;
			this.m_ReflectionProbeUsage = 0;
			this.m_ScaleInLightmap = 0f;
			this.m_SelectedEditorRenderState = 0;
			this.m_SortingLayer = 0;
			this.m_SortingLayerID = 0;
			this.m_SortingOrder = 0;
			this.m_StaticBatchInfo.Reset();
			this.m_StaticBatchRoot.Reset();
			this.m_UseWorldSpace = false;
		}

		// Token: 0x060535FE RID: 341502 RVA: 0x0132E57A File Offset: 0x0132C77A



		// Token: 0x060535FF RID: 341503 RVA: 0x0132E588 File Offset: 0x0132C788

		public void CopyValues(ILineRenderer source, PPtrConverter converter)
		{
			this.m_AutoUVMaxAngle = source.AutoUVMaxAngle_C120;
			this.m_AutoUVMaxDistance = source.AutoUVMaxDistance_C120;
			this.m_CastShadows = source.CastShadows_C120_Byte;
			this.m_CorrespondingSourceObject.CopyValues(source.CorrespondingSourceObject_C120, converter);
			this.m_Enabled = source.Enabled_C120;
			this.m_GameObject.CopyValues(source.GameObject_C120, converter);
			this.m_HideFlags = source.HideFlags_C120;
			this.m_IgnoreNormalsForChartDetection = source.IgnoreNormalsForChartDetection_C120;
			this.m_ImportantGI = source.ImportantGI_C120;
			this.m_LightmapIndex = source.LightmapIndex_C120_UInt16;
			this.m_LightmapIndexDynamic = source.LightmapIndexDynamic_C120;
			this.m_LightmapParameters.CopyValues(source.LightmapParameters_C120, converter);
			this.m_LightmapTilingOffset.CopyValues(source.LightmapTilingOffset_C120);
			this.m_LightmapTilingOffsetDynamic.CopyValues(source.LightmapTilingOffsetDynamic_C120);
			this.m_LightProbeUsage = source.LightProbeUsage_C120;
			this.m_LightProbeVolumeOverride.CopyValues(source.LightProbeVolumeOverride_C120, converter);
			this.m_Loop = source.Loop_C120;
			CopyValuesHelper.CopyValues__AssetList_PPtr_Material_5_0_0__AccessListBase_IPPtr_Material(this.m_Materials, source.Materials_C120, converter);
			this.m_MinimumChartSize = source.MinimumChartSize_C120;
			this.m_MotionVectors = source.MotionVectors_C120;
			this.m_Parameters.CopyValues(source.Parameters_C120);
			CopyValuesHelper.CopyValues__AssetList_Vector3f_3_5_0__AccessListBase_IVector3f(this.m_Positions, source.Positions_C120);
			this.m_PrefabInternal.CopyValues(source.PrefabInternal_C120, converter);
			this.m_PreserveUVs = source.PreserveUVs_C120;
			this.m_ProbeAnchor.CopyValues(source.ProbeAnchor_C120, converter);
			this.m_ReceiveShadows = source.ReceiveShadows_C120_Byte;
			this.m_ReflectionProbeUsage = source.ReflectionProbeUsage_C120_Byte;
			this.m_ScaleInLightmap = source.ScaleInLightmap_C120;
			this.m_SelectedEditorRenderState = source.SelectedEditorRenderState_C120;
			this.m_SortingLayer = source.SortingLayer_C120;
			this.m_SortingLayerID = source.SortingLayerID_C120_Int32;
			this.m_SortingOrder = source.SortingOrder_C120;
			this.m_StaticBatchInfo.CopyValues(source.StaticBatchInfo_C120);
			this.m_StaticBatchRoot.CopyValues(source.StaticBatchRoot_C120, converter);
			this.m_UseWorldSpace = source.UseWorldSpace_C120;
		}

		// Token: 0x06053600 RID: 341504 RVA: 0x0132E782 File Offset: 0x0132C982

		public void CopyValues(ILineRenderer source)
		{
			this.CopyValues(source, new PPtrConverter(source, this));
		}

		// Token: 0x06053601 RID: 341505 RVA: 0x0132E794 File Offset: 0x0132C994
		public override void CopyValues(IUnityAssetBase source, PPtrConverter converter)
		{
			ILineRenderer lineRenderer = source as ILineRenderer;
			if (lineRenderer != null)
			{
				this.CopyValues(lineRenderer, converter);
				return;
			}
			base.CopyValues(source, converter);
		}

		// Token: 0x06053602 RID: 341506 RVA: 0x0132E7BC File Offset: 0x0132C9BC

		public override List<TypeTreeNode> MakeEditorTypeTreeNodes(int depth, int startingIndex)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06053603 RID: 341507 RVA: 0x0132E7C3 File Offset: 0x0132C9C3

		public override List<TypeTreeNode> MakeReleaseTypeTreeNodes(int depth, int startingIndex)
		{
			throw new NotSupportedException();
		}

		// Token: 0x04036215 RID: 221717

		public AssetList<Vector3f_3_5_0> m_Positions;

		// Token: 0x04036216 RID: 221718

		public LineParameters_2017_1_0_GICB2 m_Parameters;

		// Token: 0x04036217 RID: 221719
		public bool m_UseWorldSpace;

		// Token: 0x04036218 RID: 221720
		public bool m_Loop;
	}
}
