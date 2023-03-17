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
using AssetRipper.SourceGenerated.Classes.ClassID_23;

namespace AssetRipper.Import.GICB2.MeshRenderer
{
	// Token: 0x02002AF8 RID: 11000


	public sealed class MeshRenderer_2017_1_0_GICB2 : Renderer_2017_1_0, IMeshRenderer, IUnityObjectBase, IUnityAssetBase, IAsset, IAssetReadable, IAssetWritable, IYamlExportable, IDependent, ITypeTreeSerializable, IMeshRendererMarker, IRenderer, IRendererMarker, IHasEnabled, IComponent, IEditorExtension, IEditorExtensionMarker, IObject, IObjectMarker, IHasHideFlags, IComponentMarker
	{
		// Token: 0x1701025E RID: 66142
		// (get) Token: 0x060325F7 RID: 206327 RVA: 0x006D6718 File Offset: 0x006D4918
		public PPtr_Mesh_5_0_0 AdditionalVertexStreams_C23
		{
			[return: NotNull]
			get
			{
				return this.m_AdditionalVertexStreams;
			}
		}

		// Token: 0x1701025F RID: 66143
		// (get) Token: 0x060325F8 RID: 206328 RVA: 0x006D6720 File Offset: 0x006D4920
		// (set) Token: 0x060325F9 RID: 206329 RVA: 0x006D6728 File Offset: 0x006D4928
		public float AutoUVMaxAngle_C23
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

		// Token: 0x17010260 RID: 66144
		// (get) Token: 0x060325FA RID: 206330 RVA: 0x006D6731 File Offset: 0x006D4931
		// (set) Token: 0x060325FB RID: 206331 RVA: 0x006D6739 File Offset: 0x006D4939
		public float AutoUVMaxDistance_C23
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

		// Token: 0x17010261 RID: 66145
		// (get) Token: 0x060325FC RID: 206332 RVA: 0x006D6742 File Offset: 0x006D4942
		// (set) Token: 0x060325FD RID: 206333 RVA: 0x006D6745 File Offset: 0x006D4945
		public bool CastShadows_C23_Boolean
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17010262 RID: 66146
		// (get) Token: 0x060325FE RID: 206334 RVA: 0x006D6747 File Offset: 0x006D4947
		// (set) Token: 0x060325FF RID: 206335 RVA: 0x006D674F File Offset: 0x006D494F
		public byte CastShadows_C23_Byte
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

		// Token: 0x17010263 RID: 66147
		// (get) Token: 0x06032600 RID: 206336 RVA: 0x006D6758 File Offset: 0x006D4958
		public IPPtr_EditorExtension CorrespondingSourceObject_C23
		{
			[return: NotNull]
			get
			{
				return this.m_CorrespondingSourceObject;
			}
		}

		// Token: 0x17010264 RID: 66148
		// (get) Token: 0x06032601 RID: 206337 RVA: 0x006D6760 File Offset: 0x006D4960
		// (set) Token: 0x06032602 RID: 206338 RVA: 0x006D6763 File Offset: 0x006D4963
		public byte DynamicOccludee_C23
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x17010265 RID: 66149
		// (get) Token: 0x06032603 RID: 206339 RVA: 0x006D6765 File Offset: 0x006D4965
		// (set) Token: 0x06032604 RID: 206340 RVA: 0x006D676D File Offset: 0x006D496D
		public bool Enabled_C23
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

		// Token: 0x17010266 RID: 66150
		// (get) Token: 0x06032605 RID: 206341 RVA: 0x006D6776 File Offset: 0x006D4976
		public PPtr_Mesh_5_0_0 EnlightenVertexStream_C23
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17010267 RID: 66151
		// (get) Token: 0x06032606 RID: 206342 RVA: 0x006D6779 File Offset: 0x006D4979
		public PPtr_EditorExtensionImpl ExtensionPtr_C23
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17010268 RID: 66152
		// (get) Token: 0x06032607 RID: 206343 RVA: 0x006D677C File Offset: 0x006D497C

		public IPPtr_GameObject GameObject_C23
		{

			get
			{
				return this.m_GameObject;
			}
		}

		// Token: 0x17010269 RID: 66153
		// (get) Token: 0x06032608 RID: 206344 RVA: 0x006D6784 File Offset: 0x006D4984
		// (set) Token: 0x06032609 RID: 206345 RVA: 0x006D678C File Offset: 0x006D498C
		public uint HideFlags_C23
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

		// Token: 0x1701026A RID: 66154
		// (get) Token: 0x0603260A RID: 206346 RVA: 0x006D6795 File Offset: 0x006D4995
		// (set) Token: 0x0603260B RID: 206347 RVA: 0x006D679D File Offset: 0x006D499D
		public bool IgnoreNormalsForChartDetection_C23
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

		// Token: 0x1701026B RID: 66155
		// (get) Token: 0x0603260C RID: 206348 RVA: 0x006D67A6 File Offset: 0x006D49A6
		// (set) Token: 0x0603260D RID: 206349 RVA: 0x006D67AE File Offset: 0x006D49AE
		public bool ImportantGI_C23
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

		// Token: 0x1701026C RID: 66156
		// (get) Token: 0x0603260E RID: 206350 RVA: 0x006D67B7 File Offset: 0x006D49B7
		// (set) Token: 0x0603260F RID: 206351 RVA: 0x006D67BA File Offset: 0x006D49BA
		public byte LightmapIndex_C23_Byte
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x1701026D RID: 66157
		// (get) Token: 0x06032610 RID: 206352 RVA: 0x006D67BC File Offset: 0x006D49BC
		// (set) Token: 0x06032611 RID: 206353 RVA: 0x006D67C4 File Offset: 0x006D49C4
		public ushort LightmapIndex_C23_UInt16
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

		// Token: 0x1701026E RID: 66158
		// (get) Token: 0x06032612 RID: 206354 RVA: 0x006D67CD File Offset: 0x006D49CD
		// (set) Token: 0x06032613 RID: 206355 RVA: 0x006D67D5 File Offset: 0x006D49D5
		public ushort LightmapIndexDynamic_C23
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

		// Token: 0x1701026F RID: 66159
		// (get) Token: 0x06032614 RID: 206356 RVA: 0x006D67DE File Offset: 0x006D49DE
		public PPtr_LightmapParameters LightmapParameters_C23
		{
			[return: NotNull]
			get
			{
				return this.m_LightmapParameters;
			}
		}

		// Token: 0x17010270 RID: 66160
		// (get) Token: 0x06032615 RID: 206357 RVA: 0x006D67E6 File Offset: 0x006D49E6

		public IVector4f LightmapTilingOffset_C23
		{

			get
			{
				return this.m_LightmapTilingOffset;
			}
		}

		// Token: 0x17010271 RID: 66161
		// (get) Token: 0x06032616 RID: 206358 RVA: 0x006D67EE File Offset: 0x006D49EE
		public Vector4f_3_5_0 LightmapTilingOffsetDynamic_C23
		{
			[return: NotNull]
			get
			{
				return this.m_LightmapTilingOffsetDynamic;
			}
		}

		// Token: 0x17010272 RID: 66162
		// (get) Token: 0x06032617 RID: 206359 RVA: 0x006D67F6 File Offset: 0x006D49F6
		public PPtr_Transform_3_4_0 LightProbeAnchor_C23
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17010273 RID: 66163
		// (get) Token: 0x06032618 RID: 206360 RVA: 0x006D67F9 File Offset: 0x006D49F9
		// (set) Token: 0x06032619 RID: 206361 RVA: 0x006D6801 File Offset: 0x006D4A01
		public byte LightProbeUsage_C23
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

		// Token: 0x17010274 RID: 66164
		// (get) Token: 0x0603261A RID: 206362 RVA: 0x006D680A File Offset: 0x006D4A0A
		public PPtr_GameObject_5_0_0 LightProbeVolumeOverride_C23
		{
			[return: NotNull]
			get
			{
				return this.m_LightProbeVolumeOverride;
			}
		}

		// Token: 0x17010275 RID: 66165
		// (get) Token: 0x0603261B RID: 206363 RVA: 0x006D6812 File Offset: 0x006D4A12

		public AccessListBase<IPPtr_Material> Materials_C23
		{

			get
			{
				return new AccessList<PPtr_Material_5_0_0, IPPtr_Material>(this.m_Materials);
			}
		}

		// Token: 0x17010276 RID: 66166
		// (get) Token: 0x0603261C RID: 206364 RVA: 0x006D681F File Offset: 0x006D4A1F
		// (set) Token: 0x0603261D RID: 206365 RVA: 0x006D6827 File Offset: 0x006D4A27
		public int MinimumChartSize_C23
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

		// Token: 0x17010277 RID: 66167
		// (get) Token: 0x0603261E RID: 206366 RVA: 0x006D6830 File Offset: 0x006D4A30
		// (set) Token: 0x0603261F RID: 206367 RVA: 0x006D6838 File Offset: 0x006D4A38
		public byte MotionVectors_C23
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

		// Token: 0x17010278 RID: 66168
		// (get) Token: 0x06032620 RID: 206368 RVA: 0x006D6841 File Offset: 0x006D4A41
		public PPtr_Prefab_2018_3_0 PrefabAsset_C23
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17010279 RID: 66169
		// (get) Token: 0x06032621 RID: 206369 RVA: 0x006D6844 File Offset: 0x006D4A44
		public PPtr_PrefabInstance PrefabInstance_C23
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1701027A RID: 66170
		// (get) Token: 0x06032622 RID: 206370 RVA: 0x006D6847 File Offset: 0x006D4A47
		public IPPtr_Prefab PrefabInternal_C23
		{
			[return: NotNull]
			get
			{
				return this.m_PrefabInternal;
			}
		}

		// Token: 0x1701027B RID: 66171
		// (get) Token: 0x06032623 RID: 206371 RVA: 0x006D684F File Offset: 0x006D4A4F
		// (set) Token: 0x06032624 RID: 206372 RVA: 0x006D6857 File Offset: 0x006D4A57
		public bool PreserveUVs_C23
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

		// Token: 0x1701027C RID: 66172
		// (get) Token: 0x06032625 RID: 206373 RVA: 0x006D6860 File Offset: 0x006D4A60
		public PPtr_Transform_5_0_0 ProbeAnchor_C23
		{
			[return: NotNull]
			get
			{
				return this.m_ProbeAnchor;
			}
		}

		// Token: 0x1701027D RID: 66173
		// (get) Token: 0x06032626 RID: 206374 RVA: 0x006D6868 File Offset: 0x006D4A68
		// (set) Token: 0x06032627 RID: 206375 RVA: 0x006D686B File Offset: 0x006D4A6B
		public byte RayTraceProcedural_C23
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x1701027E RID: 66174
		// (get) Token: 0x06032628 RID: 206376 RVA: 0x006D686D File Offset: 0x006D4A6D
		// (set) Token: 0x06032629 RID: 206377 RVA: 0x006D6870 File Offset: 0x006D4A70
		public byte RayTracingMode_C23
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x1701027F RID: 66175
		// (get) Token: 0x0603262A RID: 206378 RVA: 0x006D6872 File Offset: 0x006D4A72
		// (set) Token: 0x0603262B RID: 206379 RVA: 0x006D6875 File Offset: 0x006D4A75
		public int ReceiveGI_C23
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x17010280 RID: 66176
		// (get) Token: 0x0603262C RID: 206380 RVA: 0x006D6877 File Offset: 0x006D4A77
		// (set) Token: 0x0603262D RID: 206381 RVA: 0x006D687A File Offset: 0x006D4A7A
		public bool ReceiveShadows_C23_Boolean
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17010281 RID: 66177
		// (get) Token: 0x0603262E RID: 206382 RVA: 0x006D687C File Offset: 0x006D4A7C
		// (set) Token: 0x0603262F RID: 206383 RVA: 0x006D6884 File Offset: 0x006D4A84
		public byte ReceiveShadows_C23_Byte
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

		// Token: 0x17010282 RID: 66178
		// (get) Token: 0x06032630 RID: 206384 RVA: 0x006D688D File Offset: 0x006D4A8D
		// (set) Token: 0x06032631 RID: 206385 RVA: 0x006D6890 File Offset: 0x006D4A90
		public int ReflectionProbeUsage_C23_Int32
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x17010283 RID: 66179
		// (get) Token: 0x06032632 RID: 206386 RVA: 0x006D6892 File Offset: 0x006D4A92
		// (set) Token: 0x06032633 RID: 206387 RVA: 0x006D689A File Offset: 0x006D4A9A
		public byte ReflectionProbeUsage_C23_Byte
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

		// Token: 0x17010284 RID: 66180
		// (get) Token: 0x06032634 RID: 206388 RVA: 0x006D68A3 File Offset: 0x006D4AA3
		// (set) Token: 0x06032635 RID: 206389 RVA: 0x006D68A6 File Offset: 0x006D4AA6
		public int RendererPriority_C23
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x17010285 RID: 66181
		// (get) Token: 0x06032636 RID: 206390 RVA: 0x006D68A8 File Offset: 0x006D4AA8
		// (set) Token: 0x06032637 RID: 206391 RVA: 0x006D68AB File Offset: 0x006D4AAB
		public uint RenderingLayerMask_C23
		{
			get
			{
				return 0U;
			}
			set
			{
			}
		}

		// Token: 0x17010286 RID: 66182
		// (get) Token: 0x06032638 RID: 206392 RVA: 0x006D68AD File Offset: 0x006D4AAD
		// (set) Token: 0x06032639 RID: 206393 RVA: 0x006D68B5 File Offset: 0x006D4AB5
		public float ScaleInLightmap_C23
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

		// Token: 0x17010287 RID: 66183
		// (get) Token: 0x0603263A RID: 206394 RVA: 0x006D68BE File Offset: 0x006D4ABE
		// (set) Token: 0x0603263B RID: 206395 RVA: 0x006D68C6 File Offset: 0x006D4AC6
		public int SelectedEditorRenderState_C23
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

		// Token: 0x17010288 RID: 66184
		// (get) Token: 0x0603263C RID: 206396 RVA: 0x006D68CF File Offset: 0x006D4ACF
		// (set) Token: 0x0603263D RID: 206397 RVA: 0x006D68D2 File Offset: 0x006D4AD2
		public bool SelectedWireframeHidden_C23
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17010289 RID: 66185
		// (get) Token: 0x0603263E RID: 206398 RVA: 0x006D68D4 File Offset: 0x006D4AD4
		// (set) Token: 0x0603263F RID: 206399 RVA: 0x006D68DC File Offset: 0x006D4ADC
		public short SortingLayer_C23
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

		// Token: 0x1701028A RID: 66186
		// (get) Token: 0x06032640 RID: 206400 RVA: 0x006D68E5 File Offset: 0x006D4AE5
		// (set) Token: 0x06032641 RID: 206401 RVA: 0x006D68E8 File Offset: 0x006D4AE8
		public uint SortingLayerID_C23_UInt32
		{
			get
			{
				return 0U;
			}
			set
			{
			}
		}

		// Token: 0x1701028B RID: 66187
		// (get) Token: 0x06032642 RID: 206402 RVA: 0x006D68EA File Offset: 0x006D4AEA
		// (set) Token: 0x06032643 RID: 206403 RVA: 0x006D68F2 File Offset: 0x006D4AF2
		public int SortingLayerID_C23_Int32
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

		// Token: 0x1701028C RID: 66188
		// (get) Token: 0x06032644 RID: 206404 RVA: 0x006D68FB File Offset: 0x006D4AFB
		// (set) Token: 0x06032645 RID: 206405 RVA: 0x006D6903 File Offset: 0x006D4B03
		public short SortingOrder_C23
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

		// Token: 0x1701028D RID: 66189
		// (get) Token: 0x06032646 RID: 206406 RVA: 0x006D690C File Offset: 0x006D4B0C
		public StaticBatchInfo StaticBatchInfo_C23
		{
			[return: NotNull]
			get
			{
				return this.m_StaticBatchInfo;
			}
		}

		// Token: 0x1701028E RID: 66190
		// (get) Token: 0x06032647 RID: 206407 RVA: 0x006D6914 File Offset: 0x006D4B14

		public IPPtr_Transform StaticBatchRoot_C23
		{

			get
			{
				return this.m_StaticBatchRoot;
			}
		}

		// Token: 0x1701028F RID: 66191
		// (get) Token: 0x06032648 RID: 206408 RVA: 0x006D691C File Offset: 0x006D4B1C
		// (set) Token: 0x06032649 RID: 206409 RVA: 0x006D691F File Offset: 0x006D4B1F
		public byte StaticShadowCaster_C23
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x17010290 RID: 66192
		// (get) Token: 0x0603264A RID: 206410 RVA: 0x006D6921 File Offset: 0x006D4B21
		// (set) Token: 0x0603264B RID: 206411 RVA: 0x006D6924 File Offset: 0x006D4B24
		public bool StitchLightmapSeams_C23
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17010291 RID: 66193
		// (get) Token: 0x0603264C RID: 206412 RVA: 0x006D6926 File Offset: 0x006D4B26
		// (set) Token: 0x0603264D RID: 206413 RVA: 0x006D6929 File Offset: 0x006D4B29
		public uint[] SubsetIndices_C23
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x17010292 RID: 66194
		// (get) Token: 0x0603264E RID: 206414 RVA: 0x006D692B File Offset: 0x006D4B2B
		// (set) Token: 0x0603264F RID: 206415 RVA: 0x006D692E File Offset: 0x006D4B2E
		public bool UseLightProbes_C23
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17010293 RID: 66195
		// (get) Token: 0x06032650 RID: 206416 RVA: 0x006D6930 File Offset: 0x006D4B30
		// (set) Token: 0x06032651 RID: 206417 RVA: 0x006D6938 File Offset: 0x006D4B38
		public HideFlags HideFlags_C23E
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

		// Token: 0x17010294 RID: 66196
		// (get) Token: 0x06032652 RID: 206418 RVA: 0x006D6941 File Offset: 0x006D4B41
		// (set) Token: 0x06032653 RID: 206419 RVA: 0x006D6949 File Offset: 0x006D4B49
		public LightProbeUsage LightProbeUsage_C23E
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

		// Token: 0x17010295 RID: 66197
		// (get) Token: 0x06032654 RID: 206420 RVA: 0x006D6953 File Offset: 0x006D4B53
		// (set) Token: 0x06032655 RID: 206421 RVA: 0x006D6956 File Offset: 0x006D4B56
		public RayTracingMode RayTracingMode_C23E
		{
			get
			{
				return RayTracingMode.Off;
			}
			set
			{
			}
		}

		// Token: 0x17010296 RID: 66198
		// (get) Token: 0x06032656 RID: 206422 RVA: 0x006D6958 File Offset: 0x006D4B58
		// (set) Token: 0x06032657 RID: 206423 RVA: 0x006D695B File Offset: 0x006D4B5B
		public ReceiveGI ReceiveGI_C23E
		{
			get
			{
				return (ReceiveGI)0;
			}
			set
			{
			}
		}

		// Token: 0x17010297 RID: 66199
		// (get) Token: 0x06032658 RID: 206424 RVA: 0x006D695D File Offset: 0x006D4B5D
		// (set) Token: 0x06032659 RID: 206425 RVA: 0x006D6960 File Offset: 0x006D4B60
		public ReflectionProbeUsage ReflectionProbeUsage_C23_Int32E
		{
			get
			{
				return ReflectionProbeUsage.Off;
			}
			set
			{
			}
		}

		// Token: 0x17010298 RID: 66200
		// (get) Token: 0x0603265A RID: 206426 RVA: 0x006D6962 File Offset: 0x006D4B62
		// (set) Token: 0x0603265B RID: 206427 RVA: 0x006D696A File Offset: 0x006D4B6A
		public ReflectionProbeUsage ReflectionProbeUsage_C23_ByteE
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

		// Token: 0x17010299 RID: 66201
		// (get) Token: 0x0603265C RID: 206428 RVA: 0x006D6974 File Offset: 0x006D4B74
		// (set) Token: 0x0603265D RID: 206429 RVA: 0x006D6987 File Offset: 0x006D4B87
		public IMesh AdditionalVertexStreams_C23P
		{
			get
			{
				return PPtrExtensions.TryGetAsset<IMesh>(this.AdditionalVertexStreams_C23, base.Collection);
			}
			set
			{
				PPtrExtensions.SetAsset<IMesh>(this.AdditionalVertexStreams_C23, base.Collection, value);
			}
		}

		// Token: 0x1701029A RID: 66202
		// (get) Token: 0x0603265E RID: 206430 RVA: 0x006D699B File Offset: 0x006D4B9B
		// (set) Token: 0x0603265F RID: 206431 RVA: 0x006D69AE File Offset: 0x006D4BAE
		public IEditorExtension CorrespondingSourceObject_C23P
		{
			get
			{
				return PPtrExtensions.TryGetAsset<IEditorExtension>(this.CorrespondingSourceObject_C23, base.Collection);
			}
			set
			{
				PPtrExtensions.SetAsset<IEditorExtension>(this.CorrespondingSourceObject_C23, base.Collection, value);
			}
		}

		// Token: 0x1701029B RID: 66203
		// (get) Token: 0x06032660 RID: 206432 RVA: 0x006D69C2 File Offset: 0x006D4BC2
		// (set) Token: 0x06032661 RID: 206433 RVA: 0x006D69C5 File Offset: 0x006D4BC5
		public IMesh EnlightenVertexStream_C23P
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x1701029C RID: 66204
		// (get) Token: 0x06032662 RID: 206434 RVA: 0x006D69C7 File Offset: 0x006D4BC7
		// (set) Token: 0x06032663 RID: 206435 RVA: 0x006D69CA File Offset: 0x006D4BCA
		public IEditorExtensionImpl ExtensionPtr_C23P
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x1701029D RID: 66205
		// (get) Token: 0x06032664 RID: 206436 RVA: 0x006D69CC File Offset: 0x006D4BCC
		// (set) Token: 0x06032665 RID: 206437 RVA: 0x006D69DF File Offset: 0x006D4BDF
		public IGameObject GameObject_C23P
		{
			get
			{
				return PPtrExtensions.TryGetAsset<IGameObject>(this.GameObject_C23, base.Collection);
			}
			set
			{
				PPtrExtensions.SetAsset<IGameObject>(this.GameObject_C23, base.Collection, value);
			}
		}

		// Token: 0x1701029E RID: 66206
		// (get) Token: 0x06032666 RID: 206438 RVA: 0x006D69F3 File Offset: 0x006D4BF3
		// (set) Token: 0x06032667 RID: 206439 RVA: 0x006D6A06 File Offset: 0x006D4C06
		public ILightmapParameters LightmapParameters_C23P
		{
			get
			{
				return PPtrExtensions.TryGetAsset<ILightmapParameters>(this.LightmapParameters_C23, base.Collection);
			}
			set
			{
				PPtrExtensions.SetAsset<ILightmapParameters>(this.LightmapParameters_C23, base.Collection, value);
			}
		}

		// Token: 0x1701029F RID: 66207
		// (get) Token: 0x06032668 RID: 206440 RVA: 0x006D6A1A File Offset: 0x006D4C1A
		// (set) Token: 0x06032669 RID: 206441 RVA: 0x006D6A1D File Offset: 0x006D4C1D
		public ITransform LightProbeAnchor_C23P
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x170102A0 RID: 66208
		// (get) Token: 0x0603266A RID: 206442 RVA: 0x006D6A1F File Offset: 0x006D4C1F
		// (set) Token: 0x0603266B RID: 206443 RVA: 0x006D6A32 File Offset: 0x006D4C32
		public IGameObject LightProbeVolumeOverride_C23P
		{
			get
			{
				return PPtrExtensions.TryGetAsset<IGameObject>(this.LightProbeVolumeOverride_C23, base.Collection);
			}
			set
			{
				PPtrExtensions.SetAsset<IGameObject>(this.LightProbeVolumeOverride_C23, base.Collection, value);
			}
		}

		// Token: 0x170102A1 RID: 66209

		public PPtrAccessList<IPPtr_Material, IMaterial> Materials_C23P
		{
			get
			{
				return new PPtrAccessList<IPPtr_Material, IMaterial>(this.Materials_C23, this);
			}
		}

		// Token: 0x170102A2 RID: 66210
		// (get) Token: 0x0603266D RID: 206445 RVA: 0x006D6A54 File Offset: 0x006D4C54
		// (set) Token: 0x0603266E RID: 206446 RVA: 0x006D6A57 File Offset: 0x006D4C57
		public IPrefab PrefabAsset_C23P
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x170102A3 RID: 66211
		// (get) Token: 0x0603266F RID: 206447 RVA: 0x006D6A59 File Offset: 0x006D4C59
		// (set) Token: 0x06032670 RID: 206448 RVA: 0x006D6A5C File Offset: 0x006D4C5C
		public IPrefabInstance PrefabInstance_C23P
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x170102A4 RID: 66212
		// (get) Token: 0x06032671 RID: 206449 RVA: 0x006D6A5E File Offset: 0x006D4C5E
		// (set) Token: 0x06032672 RID: 206450 RVA: 0x006D6A71 File Offset: 0x006D4C71
		public IPrefabMarker PrefabInternal_C23P
		{
			get
			{
				return PPtrExtensions.TryGetAsset<IPrefabMarker>(this.PrefabInternal_C23, base.Collection);
			}
			set
			{
				PPtrExtensions.SetAsset<IPrefabMarker>(this.PrefabInternal_C23, base.Collection, value);
			}
		}

		// Token: 0x170102A5 RID: 66213
		// (get) Token: 0x06032673 RID: 206451 RVA: 0x006D6A85 File Offset: 0x006D4C85
		// (set) Token: 0x06032674 RID: 206452 RVA: 0x006D6A98 File Offset: 0x006D4C98
		public ITransform ProbeAnchor_C23P
		{
			get
			{
				return PPtrExtensions.TryGetAsset<ITransform>(this.ProbeAnchor_C23, base.Collection);
			}
			set
			{
				PPtrExtensions.SetAsset<ITransform>(this.ProbeAnchor_C23, base.Collection, value);
			}
		}

		// Token: 0x170102A6 RID: 66214
		// (get) Token: 0x06032675 RID: 206453 RVA: 0x006D6AAC File Offset: 0x006D4CAC
		// (set) Token: 0x06032676 RID: 206454 RVA: 0x006D6ABF File Offset: 0x006D4CBF
		public ITransform StaticBatchRoot_C23P
		{
			get
			{
				return PPtrExtensions.TryGetAsset<ITransform>(this.StaticBatchRoot_C23, base.Collection);
			}
			set
			{
				PPtrExtensions.SetAsset<ITransform>(this.StaticBatchRoot_C23, base.Collection, value);
			}
		}

		// Token: 0x170102A7 RID: 66215
		// (get) Token: 0x06032677 RID: 206455 RVA: 0x006D6AD3 File Offset: 0x006D4CD3

		public override string ClassName
		{

			get
			{
				return "MeshRenderer";
			}
		}

		// Token: 0x06032678 RID: 206456 RVA: 0x006D6ADA File Offset: 0x006D4CDA
		public MeshRenderer_2017_1_0_GICB2()
			: this(AssetInfo.MakeDummyAssetInfo(23))
		{
		}

		// Token: 0x06032679 RID: 206457 RVA: 0x006D6AE9 File Offset: 0x006D4CE9
		public MeshRenderer_2017_1_0_GICB2(AssetInfo info)
			: base(info)
		{
			this.m_AdditionalVertexStreams = new PPtr_Mesh_5_0_0();
		}

		// Token: 0x0603267A RID: 206458 RVA: 0x006D6AFD File Offset: 0x006D4CFD
		public bool Has_AdditionalVertexStreams_C23()
		{
			return true;
		}

		// Token: 0x0603267B RID: 206459 RVA: 0x006D6B00 File Offset: 0x006D4D00
		public bool Has_AutoUVMaxAngle_C23()
		{
			return true;
		}

		// Token: 0x0603267C RID: 206460 RVA: 0x006D6B03 File Offset: 0x006D4D03
		public bool Has_AutoUVMaxDistance_C23()
		{
			return true;
		}

		// Token: 0x0603267D RID: 206461 RVA: 0x006D6B06 File Offset: 0x006D4D06
		public bool Has_CastShadows_C23_Boolean()
		{
			return false;
		}

		// Token: 0x0603267E RID: 206462 RVA: 0x006D6B09 File Offset: 0x006D4D09
		public bool Has_CastShadows_C23_Byte()
		{
			return true;
		}

		// Token: 0x0603267F RID: 206463 RVA: 0x006D6B0C File Offset: 0x006D4D0C
		public bool Has_CorrespondingSourceObject_C23()
		{
			return true;
		}

		// Token: 0x06032680 RID: 206464 RVA: 0x006D6B0F File Offset: 0x006D4D0F
		public bool Has_DynamicOccludee_C23()
		{
			return false;
		}

		// Token: 0x06032681 RID: 206465 RVA: 0x006D6B12 File Offset: 0x006D4D12
		public bool Has_EnlightenVertexStream_C23()
		{
			return false;
		}

		// Token: 0x06032682 RID: 206466 RVA: 0x006D6B15 File Offset: 0x006D4D15
		public bool Has_ExtensionPtr_C23()
		{
			return false;
		}

		// Token: 0x06032683 RID: 206467 RVA: 0x006D6B18 File Offset: 0x006D4D18
		public bool Has_IgnoreNormalsForChartDetection_C23()
		{
			return true;
		}

		// Token: 0x06032684 RID: 206468 RVA: 0x006D6B1B File Offset: 0x006D4D1B
		public bool Has_ImportantGI_C23()
		{
			return true;
		}

		// Token: 0x06032685 RID: 206469 RVA: 0x006D6B1E File Offset: 0x006D4D1E
		public bool Has_LightmapIndex_C23_Byte()
		{
			return false;
		}

		// Token: 0x06032686 RID: 206470 RVA: 0x006D6B21 File Offset: 0x006D4D21
		public bool Has_LightmapIndex_C23_UInt16()
		{
			return true;
		}

		// Token: 0x06032687 RID: 206471 RVA: 0x006D6B24 File Offset: 0x006D4D24
		public bool Has_LightmapIndexDynamic_C23()
		{
			return true;
		}

		// Token: 0x06032688 RID: 206472 RVA: 0x006D6B27 File Offset: 0x006D4D27
		public bool Has_LightmapParameters_C23()
		{
			return true;
		}

		// Token: 0x06032689 RID: 206473 RVA: 0x006D6B2A File Offset: 0x006D4D2A
		public bool Has_LightmapTilingOffsetDynamic_C23()
		{
			return true;
		}

		// Token: 0x0603268A RID: 206474 RVA: 0x006D6B2D File Offset: 0x006D4D2D
		public bool Has_LightProbeAnchor_C23()
		{
			return false;
		}

		// Token: 0x0603268B RID: 206475 RVA: 0x006D6B30 File Offset: 0x006D4D30
		public bool Has_LightProbeUsage_C23()
		{
			return true;
		}

		// Token: 0x0603268C RID: 206476 RVA: 0x006D6B33 File Offset: 0x006D4D33
		public bool Has_LightProbeVolumeOverride_C23()
		{
			return true;
		}

		// Token: 0x0603268D RID: 206477 RVA: 0x006D6B36 File Offset: 0x006D4D36
		public bool Has_MinimumChartSize_C23()
		{
			return true;
		}

		// Token: 0x0603268E RID: 206478 RVA: 0x006D6B39 File Offset: 0x006D4D39
		public bool Has_MotionVectors_C23()
		{
			return true;
		}

		// Token: 0x0603268F RID: 206479 RVA: 0x006D6B3C File Offset: 0x006D4D3C
		public bool Has_PrefabAsset_C23()
		{
			return false;
		}

		// Token: 0x06032690 RID: 206480 RVA: 0x006D6B3F File Offset: 0x006D4D3F
		public bool Has_PrefabInstance_C23()
		{
			return false;
		}

		// Token: 0x06032691 RID: 206481 RVA: 0x006D6B42 File Offset: 0x006D4D42
		public bool Has_PrefabInternal_C23()
		{
			return true;
		}

		// Token: 0x06032692 RID: 206482 RVA: 0x006D6B45 File Offset: 0x006D4D45
		public bool Has_PreserveUVs_C23()
		{
			return true;
		}

		// Token: 0x06032693 RID: 206483 RVA: 0x006D6B48 File Offset: 0x006D4D48
		public bool Has_ProbeAnchor_C23()
		{
			return true;
		}

		// Token: 0x06032694 RID: 206484 RVA: 0x006D6B4B File Offset: 0x006D4D4B
		public bool Has_RayTraceProcedural_C23()
		{
			return false;
		}

		// Token: 0x06032695 RID: 206485 RVA: 0x006D6B4E File Offset: 0x006D4D4E
		public bool Has_RayTracingMode_C23()
		{
			return false;
		}

		// Token: 0x06032696 RID: 206486 RVA: 0x006D6B51 File Offset: 0x006D4D51
		public bool Has_ReceiveGI_C23()
		{
			return false;
		}

		// Token: 0x06032697 RID: 206487 RVA: 0x006D6B54 File Offset: 0x006D4D54
		public bool Has_ReceiveShadows_C23_Boolean()
		{
			return false;
		}

		// Token: 0x06032698 RID: 206488 RVA: 0x006D6B57 File Offset: 0x006D4D57
		public bool Has_ReceiveShadows_C23_Byte()
		{
			return true;
		}

		// Token: 0x06032699 RID: 206489 RVA: 0x006D6B5A File Offset: 0x006D4D5A
		public bool Has_ReflectionProbeUsage_C23_Int32()
		{
			return false;
		}

		// Token: 0x0603269A RID: 206490 RVA: 0x006D6B5D File Offset: 0x006D4D5D
		public bool Has_ReflectionProbeUsage_C23_Byte()
		{
			return true;
		}

		// Token: 0x0603269B RID: 206491 RVA: 0x006D6B60 File Offset: 0x006D4D60
		public bool Has_RendererPriority_C23()
		{
			return false;
		}

		// Token: 0x0603269C RID: 206492 RVA: 0x006D6B63 File Offset: 0x006D4D63
		public bool Has_RenderingLayerMask_C23()
		{
			return false;
		}

		// Token: 0x0603269D RID: 206493 RVA: 0x006D6B66 File Offset: 0x006D4D66
		public bool Has_SelectedEditorRenderState_C23()
		{
			return true;
		}

		// Token: 0x0603269E RID: 206494 RVA: 0x006D6B69 File Offset: 0x006D4D69
		public bool Has_SelectedWireframeHidden_C23()
		{
			return false;
		}

		// Token: 0x0603269F RID: 206495 RVA: 0x006D6B6C File Offset: 0x006D4D6C
		public bool Has_SortingLayer_C23()
		{
			return true;
		}

		// Token: 0x060326A0 RID: 206496 RVA: 0x006D6B6F File Offset: 0x006D4D6F
		public bool Has_SortingLayerID_C23_UInt32()
		{
			return false;
		}

		// Token: 0x060326A1 RID: 206497 RVA: 0x006D6B72 File Offset: 0x006D4D72
		public bool Has_SortingLayerID_C23_Int32()
		{
			return true;
		}

		// Token: 0x060326A2 RID: 206498 RVA: 0x006D6B75 File Offset: 0x006D4D75
		public bool Has_SortingOrder_C23()
		{
			return true;
		}

		// Token: 0x060326A3 RID: 206499 RVA: 0x006D6B78 File Offset: 0x006D4D78
		public bool Has_StaticBatchInfo_C23()
		{
			return true;
		}

		// Token: 0x060326A4 RID: 206500 RVA: 0x006D6B7B File Offset: 0x006D4D7B
		public bool Has_StaticShadowCaster_C23()
		{
			return false;
		}

		// Token: 0x060326A5 RID: 206501 RVA: 0x006D6B7E File Offset: 0x006D4D7E
		public bool Has_StitchLightmapSeams_C23()
		{
			return false;
		}

		// Token: 0x060326A6 RID: 206502 RVA: 0x006D6B81 File Offset: 0x006D4D81
		public bool Has_SubsetIndices_C23()
		{
			return false;
		}

		// Token: 0x060326A7 RID: 206503 RVA: 0x006D6B84 File Offset: 0x006D4D84
		public bool Has_UseLightProbes_C23()
		{
			return false;
		}

		// Token: 0x060326A8 RID: 206504 RVA: 0x006D6B88 File Offset: 0x006D4D88

		public override void ReadRelease(AssetReader reader)
		{
			this.m_GameObject.ReadRelease(reader);
			this.m_CastShadows = reader.ReadByte();
			this.m_ReceiveShadows = reader.ReadByte();

			// GICB2
			this.ReceiveDecals = reader.ReadByte();
			this.EnableShadowCulling = reader.ReadByte();
			this.EnableGpuQuery = reader.ReadByte();
			this.AllowHalfResolution = reader.ReadByte();
			this.IsRainOccluder = reader.ReadByte();
			this.IsDynamic = reader.ReadByte();

			this.m_MotionVectors = reader.ReadByte();
			this.m_LightProbeUsage = reader.ReadByte();
			this.m_ReflectionProbeUsage = reader.ReadRelease_ByteAlign();
			this.m_LightmapIndex = reader.ReadUInt16();
			this.m_LightmapIndexDynamic = reader.ReadUInt16();
			this.m_LightmapTilingOffset.ReadRelease(reader);
			this.m_LightmapTilingOffsetDynamic.ReadRelease(reader);

			// GICB2
			this.ViewDistanceRatio = reader.ReadSingle();
			this.ShaderLODDistanceRatio = reader.ReadSingle();

			this.m_Materials.ReadRelease_ArrayAlign_Asset(reader);
			this.m_StaticBatchInfo.ReadRelease(reader);
			this.m_StaticBatchRoot.ReadRelease(reader);

			this.MatLayers = reader.ReadInt32(); // GICB2

			this.m_ProbeAnchor.ReadRelease(reader);
			this.m_LightProbeVolumeOverride.ReadRelease_AssetAlign(reader);
			this.m_SortingLayerID = reader.ReadInt32();
			this.m_SortingLayer = reader.ReadInt16();
			this.m_SortingOrder = reader.ReadRelease_Int16Align();

			this.UseHighestMip = reader.ReadRelease_BooleanAlign(); // GICB2

			this.m_AdditionalVertexStreams.ReadRelease(reader);
		}

		// Token: 0x060326A9 RID: 206505 RVA: 0x006D6C88 File Offset: 0x006D4E88

		public override void ReadEditor(AssetReader reader)
		{
		}

		// Token: 0x060326AA RID: 206506 RVA: 0x006D6DDC File Offset: 0x006D4FDC

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
			this.m_AdditionalVertexStreams.WriteRelease(writer);
		}

		// Token: 0x060326AB RID: 206507 RVA: 0x006D6EDC File Offset: 0x006D50DC

		public override void WriteEditor(AssetWriter writer)
		{
		}

		// Token: 0x060326AC RID: 206508 RVA: 0x006D7030 File Offset: 0x006D5230

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
			yamlMappingNode.Add(new YamlScalarNode("m_AdditionalVertexStreams"), this.m_AdditionalVertexStreams.ExportYamlRelease(container));
			return yamlMappingNode;
		}

		// Token: 0x060326AD RID: 206509 RVA: 0x006D727C File Offset: 0x006D547C

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
			return yamlMappingNode;
		}

		// Token: 0x060326AE RID: 206510 RVA: 0x006D758C File Offset: 0x006D578C
		public override void Reset()
		{
			this.m_AdditionalVertexStreams.Reset();
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
			this.m_Materials.Clear();
			this.m_MinimumChartSize = 0;
			this.m_MotionVectors = 0;
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
		}

		// Token: 0x060326AF RID: 206511 RVA: 0x006D76B5 File Offset: 0x006D58B5
		//public override IEnumerable<ValueTuple<FieldName, PPtr<IUnityObjectBase>>> FetchDependencies(FieldName parent)
		//{
		//	return Enumerable.Empty<ValueTuple<FieldName, PPtr<IUnityObjectBase>>>().Append_MeshRenderer_2017_1_0(parent, this);
		//}

		// Token: 0x060326B0 RID: 206512 RVA: 0x006D76C4 File Offset: 0x006D58C4

		public void CopyValues(IMeshRenderer source, PPtrConverter converter)
		{
			this.m_AdditionalVertexStreams.CopyValues(source.AdditionalVertexStreams_C23, converter);
			this.m_AutoUVMaxAngle = source.AutoUVMaxAngle_C23;
			this.m_AutoUVMaxDistance = source.AutoUVMaxDistance_C23;
			this.m_CastShadows = source.CastShadows_C23_Byte;
			this.m_CorrespondingSourceObject.CopyValues(source.CorrespondingSourceObject_C23, converter);
			this.m_Enabled = source.Enabled_C23;
			this.m_GameObject.CopyValues(source.GameObject_C23, converter);
			this.m_HideFlags = source.HideFlags_C23;
			this.m_IgnoreNormalsForChartDetection = source.IgnoreNormalsForChartDetection_C23;
			this.m_ImportantGI = source.ImportantGI_C23;
			this.m_LightmapIndex = source.LightmapIndex_C23_UInt16;
			this.m_LightmapIndexDynamic = source.LightmapIndexDynamic_C23;
			this.m_LightmapParameters.CopyValues(source.LightmapParameters_C23, converter);
			this.m_LightmapTilingOffset.CopyValues(source.LightmapTilingOffset_C23);
			this.m_LightmapTilingOffsetDynamic.CopyValues(source.LightmapTilingOffsetDynamic_C23);
			this.m_LightProbeUsage = source.LightProbeUsage_C23;
			this.m_LightProbeVolumeOverride.CopyValues(source.LightProbeVolumeOverride_C23, converter);
			CopyValuesHelper.CopyValues__AssetList_PPtr_Material_5_0_0__AccessListBase_IPPtr_Material(this.m_Materials, source.Materials_C23, converter);
			this.m_MinimumChartSize = source.MinimumChartSize_C23;
			this.m_MotionVectors = source.MotionVectors_C23;
			this.m_PrefabInternal.CopyValues(source.PrefabInternal_C23, converter);
			this.m_PreserveUVs = source.PreserveUVs_C23;
			this.m_ProbeAnchor.CopyValues(source.ProbeAnchor_C23, converter);
			this.m_ReceiveShadows = source.ReceiveShadows_C23_Byte;
			this.m_ReflectionProbeUsage = source.ReflectionProbeUsage_C23_Byte;
			this.m_ScaleInLightmap = source.ScaleInLightmap_C23;
			this.m_SelectedEditorRenderState = source.SelectedEditorRenderState_C23;
			this.m_SortingLayer = source.SortingLayer_C23;
			this.m_SortingLayerID = source.SortingLayerID_C23_Int32;
			this.m_SortingOrder = source.SortingOrder_C23;
			this.m_StaticBatchInfo.CopyValues(source.StaticBatchInfo_C23);
			this.m_StaticBatchRoot.CopyValues(source.StaticBatchRoot_C23, converter);
		}

		// Token: 0x060326B1 RID: 206513 RVA: 0x006D7896 File Offset: 0x006D5A96

		public void CopyValues(IMeshRenderer source)
		{
			this.CopyValues(source, new PPtrConverter(source, this));
		}

		// Token: 0x060326B2 RID: 206514 RVA: 0x006D78A8 File Offset: 0x006D5AA8
		public override void CopyValues(IUnityAssetBase source, PPtrConverter converter)
		{
			IMeshRenderer meshRenderer = source as IMeshRenderer;
			if (meshRenderer != null)
			{
				this.CopyValues(meshRenderer, converter);
				return;
			}
			base.CopyValues(source, converter);
		}

		// Token: 0x060326B3 RID: 206515 RVA: 0x006D78D0 File Offset: 0x006D5AD0

		public override List<TypeTreeNode> MakeEditorTypeTreeNodes(int depth, int startingIndex)
		{
			throw new NotSupportedException();
		}

		// Token: 0x060326B4 RID: 206516 RVA: 0x006D78D7 File Offset: 0x006D5AD7

		public override List<TypeTreeNode> MakeReleaseTypeTreeNodes(int depth, int startingIndex)
		{
			throw new NotSupportedException();
		}

		// Token: 0x04013138 RID: 78136

		public PPtr_Mesh_5_0_0 m_AdditionalVertexStreams;


		public byte ReceiveDecals { get; set; }
		public byte EnableShadowCulling { get; set; }
		public byte EnableGpuQuery { get; set; }
		public byte AllowHalfResolution { get; set; }
		public byte IsRainOccluder { get; set; }
		public byte IsDynamic { get; set; }
		public float ViewDistanceRatio { get; set; }
		public float ShaderLODDistanceRatio { get; set; }
		public int MatLayers { get; set; }
		public bool UseHighestMip { get; set; }
	}
}
