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
using AssetRipper.SourceGenerated.Classes.ClassID_213;
using AssetRipper.SourceGenerated.Classes.ClassID_25;
using AssetRipper.SourceGenerated.Classes.ClassID_4;
using AssetRipper.SourceGenerated.Enums;
using AssetRipper.SourceGenerated.Helpers;
using AssetRipper.SourceGenerated.Interfaces;
using AssetRipper.SourceGenerated.MarkerInterfaces;
using AssetRipper.SourceGenerated.Subclasses.ColorRGBAf;
using AssetRipper.SourceGenerated.Subclasses.PPtr_EditorExtension;
using AssetRipper.SourceGenerated.Subclasses.PPtr_GameObject;
using AssetRipper.SourceGenerated.Subclasses.PPtr_LightmapParameters;
using AssetRipper.SourceGenerated.Subclasses.PPtr_Material;
using AssetRipper.SourceGenerated.Subclasses.PPtr_PrefabInstance;
using AssetRipper.SourceGenerated.Subclasses.PPtr_Prefab;
using AssetRipper.SourceGenerated.Subclasses.PPtr_Sprite;
using AssetRipper.SourceGenerated.Subclasses.PPtr_Transform;
using AssetRipper.SourceGenerated.Subclasses.StaticBatchInfo;
using AssetRipper.SourceGenerated.Subclasses.Vector2f;
using AssetRipper.SourceGenerated.Subclasses.Vector4f;
using AssetRipper.Yaml;

using AssetRipper.SourceGenerated.Classes.ClassID_212;

namespace AssetRipper.Import.GICB2.SpriteRenderer
{
	// Token: 0x02002C4E RID: 11342


	public sealed class SpriteRenderer_2017_1_0_GICB2 : Renderer_2017_1_0, ISpriteRenderer, IRenderer, IUnityObjectBase, IUnityAssetBase, IAsset, IAssetReadable, IAssetWritable, IYamlExportable, IDependent, ITypeTreeSerializable, IRendererMarker, IHasEnabled, IComponent, IEditorExtension, IEditorExtensionMarker, IObject, IObjectMarker, IHasHideFlags, IComponentMarker, ISpriteRendererMarker
	{
		// Token: 0x17012D26 RID: 77094
		// (get) Token: 0x06038F9F RID: 233375 RVA: 0x007938DA File Offset: 0x00791ADA
		// (set) Token: 0x06038FA0 RID: 233376 RVA: 0x007938E2 File Offset: 0x00791AE2
		public float AdaptiveModeThreshold_C212
		{
			get
			{
				return this.m_AdaptiveModeThreshold;
			}
			set
			{
				this.m_AdaptiveModeThreshold = value;
			}
		}

		// Token: 0x17012D27 RID: 77095
		// (get) Token: 0x06038FA1 RID: 233377 RVA: 0x007938EB File Offset: 0x00791AEB
		// (set) Token: 0x06038FA2 RID: 233378 RVA: 0x007938F3 File Offset: 0x00791AF3
		public float AutoUVMaxAngle_C212
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

		// Token: 0x17012D28 RID: 77096
		// (get) Token: 0x06038FA3 RID: 233379 RVA: 0x007938FC File Offset: 0x00791AFC
		// (set) Token: 0x06038FA4 RID: 233380 RVA: 0x00793904 File Offset: 0x00791B04
		public float AutoUVMaxDistance_C212
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

		// Token: 0x17012D29 RID: 77097
		// (get) Token: 0x06038FA5 RID: 233381 RVA: 0x0079390D File Offset: 0x00791B0D
		// (set) Token: 0x06038FA6 RID: 233382 RVA: 0x00793910 File Offset: 0x00791B10
		public bool CastShadows_C212_Boolean
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17012D2A RID: 77098
		// (get) Token: 0x06038FA7 RID: 233383 RVA: 0x00793912 File Offset: 0x00791B12
		// (set) Token: 0x06038FA8 RID: 233384 RVA: 0x0079391A File Offset: 0x00791B1A
		public byte CastShadows_C212_Byte
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

		// Token: 0x17012D2B RID: 77099
		// (get) Token: 0x06038FA9 RID: 233385 RVA: 0x00793923 File Offset: 0x00791B23

		public ColorRGBAf_3_5_0 Color_C212
		{

			get
			{
				return this.m_Color;
			}
		}

		// Token: 0x17012D2C RID: 77100
		// (get) Token: 0x06038FAA RID: 233386 RVA: 0x0079392B File Offset: 0x00791B2B

		public IPPtr_EditorExtension CorrespondingSourceObject_C212
		{

			get
			{
				return this.m_CorrespondingSourceObject;
			}
		}

		// Token: 0x17012D2D RID: 77101
		// (get) Token: 0x06038FAB RID: 233387 RVA: 0x00793933 File Offset: 0x00791B33
		// (set) Token: 0x06038FAC RID: 233388 RVA: 0x0079393B File Offset: 0x00791B3B
		public int DrawMode_C212
		{
			get
			{
				return this.m_DrawMode;
			}
			set
			{
				this.m_DrawMode = value;
			}
		}

		// Token: 0x17012D2E RID: 77102
		// (get) Token: 0x06038FAD RID: 233389 RVA: 0x00793944 File Offset: 0x00791B44
		// (set) Token: 0x06038FAE RID: 233390 RVA: 0x00793947 File Offset: 0x00791B47
		public byte DynamicOccludee_C212
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x17012D2F RID: 77103
		// (get) Token: 0x06038FAF RID: 233391 RVA: 0x00793949 File Offset: 0x00791B49
		// (set) Token: 0x06038FB0 RID: 233392 RVA: 0x00793951 File Offset: 0x00791B51
		public bool Enabled_C212
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

		// Token: 0x17012D30 RID: 77104
		// (get) Token: 0x06038FB1 RID: 233393 RVA: 0x0079395A File Offset: 0x00791B5A
		// (set) Token: 0x06038FB2 RID: 233394 RVA: 0x00793962 File Offset: 0x00791B62
		public bool FlipX_C212
		{
			get
			{
				return this.m_FlipX;
			}
			set
			{
				this.m_FlipX = value;
			}
		}

		// Token: 0x17012D31 RID: 77105
		// (get) Token: 0x06038FB3 RID: 233395 RVA: 0x0079396B File Offset: 0x00791B6B
		// (set) Token: 0x06038FB4 RID: 233396 RVA: 0x00793973 File Offset: 0x00791B73
		public bool FlipY_C212
		{
			get
			{
				return this.m_FlipY;
			}
			set
			{
				this.m_FlipY = value;
			}
		}

		// Token: 0x17012D32 RID: 77106
		// (get) Token: 0x06038FB5 RID: 233397 RVA: 0x0079397C File Offset: 0x00791B7C

		public IPPtr_GameObject GameObject_C212
		{

			get
			{
				return this.m_GameObject;
			}
		}

		// Token: 0x17012D33 RID: 77107
		// (get) Token: 0x06038FB6 RID: 233398 RVA: 0x00793984 File Offset: 0x00791B84
		// (set) Token: 0x06038FB7 RID: 233399 RVA: 0x0079398C File Offset: 0x00791B8C
		public uint HideFlags_C212
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

		// Token: 0x17012D34 RID: 77108
		// (get) Token: 0x06038FB8 RID: 233400 RVA: 0x00793995 File Offset: 0x00791B95
		// (set) Token: 0x06038FB9 RID: 233401 RVA: 0x0079399D File Offset: 0x00791B9D
		public bool IgnoreNormalsForChartDetection_C212
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

		// Token: 0x17012D35 RID: 77109
		// (get) Token: 0x06038FBA RID: 233402 RVA: 0x007939A6 File Offset: 0x00791BA6
		// (set) Token: 0x06038FBB RID: 233403 RVA: 0x007939AE File Offset: 0x00791BAE
		public bool ImportantGI_C212
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

		// Token: 0x17012D36 RID: 77110
		// (get) Token: 0x06038FBC RID: 233404 RVA: 0x007939B7 File Offset: 0x00791BB7
		// (set) Token: 0x06038FBD RID: 233405 RVA: 0x007939BA File Offset: 0x00791BBA
		public byte LightmapIndex_C212_Byte
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x17012D37 RID: 77111
		// (get) Token: 0x06038FBE RID: 233406 RVA: 0x007939BC File Offset: 0x00791BBC
		// (set) Token: 0x06038FBF RID: 233407 RVA: 0x007939C4 File Offset: 0x00791BC4
		public ushort LightmapIndex_C212_UInt16
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

		// Token: 0x17012D38 RID: 77112
		// (get) Token: 0x06038FC0 RID: 233408 RVA: 0x007939CD File Offset: 0x00791BCD
		// (set) Token: 0x06038FC1 RID: 233409 RVA: 0x007939D5 File Offset: 0x00791BD5
		public ushort LightmapIndexDynamic_C212
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

		// Token: 0x17012D39 RID: 77113
		// (get) Token: 0x06038FC2 RID: 233410 RVA: 0x007939DE File Offset: 0x00791BDE
		public PPtr_LightmapParameters LightmapParameters_C212
		{
			[return: NotNull]
			get
			{
				return this.m_LightmapParameters;
			}
		}

		// Token: 0x17012D3A RID: 77114
		// (get) Token: 0x06038FC3 RID: 233411 RVA: 0x007939E6 File Offset: 0x00791BE6

		public Vector4f_3_5_0 LightmapTilingOffset_C212
		{

			get
			{
				return this.m_LightmapTilingOffset;
			}
		}

		// Token: 0x17012D3B RID: 77115
		// (get) Token: 0x06038FC4 RID: 233412 RVA: 0x007939EE File Offset: 0x00791BEE
		public Vector4f_3_5_0 LightmapTilingOffsetDynamic_C212
		{
			[return: NotNull]
			get
			{
				return this.m_LightmapTilingOffsetDynamic;
			}
		}

		// Token: 0x17012D3C RID: 77116
		// (get) Token: 0x06038FC5 RID: 233413 RVA: 0x007939F6 File Offset: 0x00791BF6
		public PPtr_Transform_3_4_0 LightProbeAnchor_C212
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17012D3D RID: 77117
		// (get) Token: 0x06038FC6 RID: 233414 RVA: 0x007939F9 File Offset: 0x00791BF9
		// (set) Token: 0x06038FC7 RID: 233415 RVA: 0x00793A01 File Offset: 0x00791C01
		public byte LightProbeUsage_C212
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

		// Token: 0x17012D3E RID: 77118
		// (get) Token: 0x06038FC8 RID: 233416 RVA: 0x00793A0A File Offset: 0x00791C0A
		public PPtr_GameObject_5_0_0 LightProbeVolumeOverride_C212
		{
			[return: NotNull]
			get
			{
				return this.m_LightProbeVolumeOverride;
			}
		}

		// Token: 0x17012D3F RID: 77119
		// (get) Token: 0x06038FC9 RID: 233417 RVA: 0x00793A12 File Offset: 0x00791C12
		// (set) Token: 0x06038FCA RID: 233418 RVA: 0x00793A1A File Offset: 0x00791C1A
		public int MaskInteraction_C212
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

		// Token: 0x17012D40 RID: 77120
		// (get) Token: 0x06038FCB RID: 233419 RVA: 0x00793A23 File Offset: 0x00791C23

		public AccessListBase<IPPtr_Material> Materials_C212
		{

			get
			{
				return new AccessList<PPtr_Material_5_0_0, IPPtr_Material>(this.m_Materials);
			}
		}

		// Token: 0x17012D41 RID: 77121
		// (get) Token: 0x06038FCC RID: 233420 RVA: 0x00793A30 File Offset: 0x00791C30
		// (set) Token: 0x06038FCD RID: 233421 RVA: 0x00793A38 File Offset: 0x00791C38
		public int MinimumChartSize_C212
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

		// Token: 0x17012D42 RID: 77122
		// (get) Token: 0x06038FCE RID: 233422 RVA: 0x00793A41 File Offset: 0x00791C41
		// (set) Token: 0x06038FCF RID: 233423 RVA: 0x00793A49 File Offset: 0x00791C49
		public byte MotionVectors_C212
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

		// Token: 0x17012D43 RID: 77123
		// (get) Token: 0x06038FD0 RID: 233424 RVA: 0x00793A52 File Offset: 0x00791C52
		public PPtr_Prefab_2018_3_0 PrefabAsset_C212
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17012D44 RID: 77124
		// (get) Token: 0x06038FD1 RID: 233425 RVA: 0x00793A55 File Offset: 0x00791C55
		public PPtr_PrefabInstance PrefabInstance_C212
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17012D45 RID: 77125
		// (get) Token: 0x06038FD2 RID: 233426 RVA: 0x00793A58 File Offset: 0x00791C58
		public IPPtr_Prefab PrefabInternal_C212
		{
			[return: NotNull]
			get
			{
				return this.m_PrefabInternal;
			}
		}

		// Token: 0x17012D46 RID: 77126
		// (get) Token: 0x06038FD3 RID: 233427 RVA: 0x00793A60 File Offset: 0x00791C60
		// (set) Token: 0x06038FD4 RID: 233428 RVA: 0x00793A68 File Offset: 0x00791C68
		public bool PreserveUVs_C212
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

		// Token: 0x17012D47 RID: 77127
		// (get) Token: 0x06038FD5 RID: 233429 RVA: 0x00793A71 File Offset: 0x00791C71
		public PPtr_Transform_5_0_0 ProbeAnchor_C212
		{
			[return: NotNull]
			get
			{
				return this.m_ProbeAnchor;
			}
		}

		// Token: 0x17012D48 RID: 77128
		// (get) Token: 0x06038FD6 RID: 233430 RVA: 0x00793A79 File Offset: 0x00791C79
		// (set) Token: 0x06038FD7 RID: 233431 RVA: 0x00793A7C File Offset: 0x00791C7C
		public byte RayTraceProcedural_C212
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x17012D49 RID: 77129
		// (get) Token: 0x06038FD8 RID: 233432 RVA: 0x00793A7E File Offset: 0x00791C7E
		// (set) Token: 0x06038FD9 RID: 233433 RVA: 0x00793A81 File Offset: 0x00791C81
		public byte RayTracingMode_C212
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x17012D4A RID: 77130
		// (get) Token: 0x06038FDA RID: 233434 RVA: 0x00793A83 File Offset: 0x00791C83
		// (set) Token: 0x06038FDB RID: 233435 RVA: 0x00793A86 File Offset: 0x00791C86
		public int ReceiveGI_C212
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x17012D4B RID: 77131
		// (get) Token: 0x06038FDC RID: 233436 RVA: 0x00793A88 File Offset: 0x00791C88
		// (set) Token: 0x06038FDD RID: 233437 RVA: 0x00793A8B File Offset: 0x00791C8B
		public bool ReceiveShadows_C212_Boolean
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17012D4C RID: 77132
		// (get) Token: 0x06038FDE RID: 233438 RVA: 0x00793A8D File Offset: 0x00791C8D
		// (set) Token: 0x06038FDF RID: 233439 RVA: 0x00793A95 File Offset: 0x00791C95
		public byte ReceiveShadows_C212_Byte
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

		// Token: 0x17012D4D RID: 77133
		// (get) Token: 0x06038FE0 RID: 233440 RVA: 0x00793A9E File Offset: 0x00791C9E
		// (set) Token: 0x06038FE1 RID: 233441 RVA: 0x00793AA1 File Offset: 0x00791CA1
		public int ReflectionProbeUsage_C212_Int32
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x17012D4E RID: 77134
		// (get) Token: 0x06038FE2 RID: 233442 RVA: 0x00793AA3 File Offset: 0x00791CA3
		// (set) Token: 0x06038FE3 RID: 233443 RVA: 0x00793AAB File Offset: 0x00791CAB
		public byte ReflectionProbeUsage_C212_Byte
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

		// Token: 0x17012D4F RID: 77135
		// (get) Token: 0x06038FE4 RID: 233444 RVA: 0x00793AB4 File Offset: 0x00791CB4
		// (set) Token: 0x06038FE5 RID: 233445 RVA: 0x00793AB7 File Offset: 0x00791CB7
		public int RendererPriority_C212
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x17012D50 RID: 77136
		// (get) Token: 0x06038FE6 RID: 233446 RVA: 0x00793AB9 File Offset: 0x00791CB9
		// (set) Token: 0x06038FE7 RID: 233447 RVA: 0x00793ABC File Offset: 0x00791CBC
		public uint RenderingLayerMask_C212
		{
			get
			{
				return 0U;
			}
			set
			{
			}
		}

		// Token: 0x17012D51 RID: 77137
		// (get) Token: 0x06038FE8 RID: 233448 RVA: 0x00793ABE File Offset: 0x00791CBE
		// (set) Token: 0x06038FE9 RID: 233449 RVA: 0x00793AC6 File Offset: 0x00791CC6
		public float ScaleInLightmap_C212
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

		// Token: 0x17012D52 RID: 77138
		// (get) Token: 0x06038FEA RID: 233450 RVA: 0x00793ACF File Offset: 0x00791CCF
		// (set) Token: 0x06038FEB RID: 233451 RVA: 0x00793AD7 File Offset: 0x00791CD7
		public int SelectedEditorRenderState_C212
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

		// Token: 0x17012D53 RID: 77139
		// (get) Token: 0x06038FEC RID: 233452 RVA: 0x00793AE0 File Offset: 0x00791CE0
		// (set) Token: 0x06038FED RID: 233453 RVA: 0x00793AE3 File Offset: 0x00791CE3
		public bool SelectedWireframeHidden_C212
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17012D54 RID: 77140
		// (get) Token: 0x06038FEE RID: 233454 RVA: 0x00793AE5 File Offset: 0x00791CE5
		public Vector2f_3_5_0 Size_C212
		{
			[return: NotNull]
			get
			{
				return this.m_Size;
			}
		}

		// Token: 0x17012D55 RID: 77141
		// (get) Token: 0x06038FEF RID: 233455 RVA: 0x00793AED File Offset: 0x00791CED
		// (set) Token: 0x06038FF0 RID: 233456 RVA: 0x00793AF5 File Offset: 0x00791CF5
		public short SortingLayer_C212
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

		// Token: 0x17012D56 RID: 77142
		// (get) Token: 0x06038FF1 RID: 233457 RVA: 0x00793AFE File Offset: 0x00791CFE
		// (set) Token: 0x06038FF2 RID: 233458 RVA: 0x00793B01 File Offset: 0x00791D01
		public uint SortingLayerID_C212_UInt32
		{
			get
			{
				return 0U;
			}
			set
			{
			}
		}

		// Token: 0x17012D57 RID: 77143
		// (get) Token: 0x06038FF3 RID: 233459 RVA: 0x00793B03 File Offset: 0x00791D03
		// (set) Token: 0x06038FF4 RID: 233460 RVA: 0x00793B0B File Offset: 0x00791D0B
		public int SortingLayerID_C212_Int32
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

		// Token: 0x17012D58 RID: 77144
		// (get) Token: 0x06038FF5 RID: 233461 RVA: 0x00793B14 File Offset: 0x00791D14
		// (set) Token: 0x06038FF6 RID: 233462 RVA: 0x00793B1C File Offset: 0x00791D1C
		public short SortingOrder_C212
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

		// Token: 0x17012D59 RID: 77145
		// (get) Token: 0x06038FF7 RID: 233463 RVA: 0x00793B25 File Offset: 0x00791D25

		public IPPtr_Sprite Sprite_C212
		{

			get
			{
				return this.m_Sprite;
			}
		}

		// Token: 0x17012D5A RID: 77146
		// (get) Token: 0x06038FF8 RID: 233464 RVA: 0x00793B2D File Offset: 0x00791D2D
		// (set) Token: 0x06038FF9 RID: 233465 RVA: 0x00793B30 File Offset: 0x00791D30
		public int SpriteSortPoint_C212
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x17012D5B RID: 77147
		// (get) Token: 0x06038FFA RID: 233466 RVA: 0x00793B32 File Offset: 0x00791D32
		// (set) Token: 0x06038FFB RID: 233467 RVA: 0x00793B3A File Offset: 0x00791D3A
		public int SpriteTileMode_C212
		{
			get
			{
				return this.m_SpriteTileMode;
			}
			set
			{
				this.m_SpriteTileMode = value;
			}
		}

		// Token: 0x17012D5C RID: 77148
		// (get) Token: 0x06038FFC RID: 233468 RVA: 0x00793B43 File Offset: 0x00791D43
		public StaticBatchInfo StaticBatchInfo_C212
		{
			[return: NotNull]
			get
			{
				return this.m_StaticBatchInfo;
			}
		}

		// Token: 0x17012D5D RID: 77149
		// (get) Token: 0x06038FFD RID: 233469 RVA: 0x00793B4B File Offset: 0x00791D4B

		public IPPtr_Transform StaticBatchRoot_C212
		{

			get
			{
				return this.m_StaticBatchRoot;
			}
		}

		// Token: 0x17012D5E RID: 77150
		// (get) Token: 0x06038FFE RID: 233470 RVA: 0x00793B53 File Offset: 0x00791D53
		// (set) Token: 0x06038FFF RID: 233471 RVA: 0x00793B56 File Offset: 0x00791D56
		public byte StaticShadowCaster_C212
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x17012D5F RID: 77151
		// (get) Token: 0x06039000 RID: 233472 RVA: 0x00793B58 File Offset: 0x00791D58
		// (set) Token: 0x06039001 RID: 233473 RVA: 0x00793B5B File Offset: 0x00791D5B
		public bool StitchLightmapSeams_C212
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17012D60 RID: 77152
		// (get) Token: 0x06039002 RID: 233474 RVA: 0x00793B5D File Offset: 0x00791D5D
		// (set) Token: 0x06039003 RID: 233475 RVA: 0x00793B60 File Offset: 0x00791D60
		public bool StitchSeams_C212
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17012D61 RID: 77153
		// (get) Token: 0x06039004 RID: 233476 RVA: 0x00793B62 File Offset: 0x00791D62
		// (set) Token: 0x06039005 RID: 233477 RVA: 0x00793B65 File Offset: 0x00791D65
		public uint[] SubsetIndices_C212
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x17012D62 RID: 77154
		// (get) Token: 0x06039006 RID: 233478 RVA: 0x00793B67 File Offset: 0x00791D67
		// (set) Token: 0x06039007 RID: 233479 RVA: 0x00793B6A File Offset: 0x00791D6A
		public bool UseLightProbes_C212
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17012D63 RID: 77155
		// (get) Token: 0x06039008 RID: 233480 RVA: 0x00793B6C File Offset: 0x00791D6C
		// (set) Token: 0x06039009 RID: 233481 RVA: 0x00793B74 File Offset: 0x00791D74
		public bool WasSpriteAssigned_C212
		{
			get
			{
				return this.m_WasSpriteAssigned;
			}
			set
			{
				this.m_WasSpriteAssigned = value;
			}
		}

		// Token: 0x17012D64 RID: 77156
		// (get) Token: 0x0603900A RID: 233482 RVA: 0x00793B7D File Offset: 0x00791D7D
		// (set) Token: 0x0603900B RID: 233483 RVA: 0x00793B85 File Offset: 0x00791D85
		public SpriteDrawMode DrawMode_C212E
		{
			get
			{
				return (SpriteDrawMode)this.m_DrawMode;
			}
			set
			{
				this.m_DrawMode = (int)value;
			}
		}

		// Token: 0x17012D65 RID: 77157
		// (get) Token: 0x0603900C RID: 233484 RVA: 0x00793B8E File Offset: 0x00791D8E
		// (set) Token: 0x0603900D RID: 233485 RVA: 0x00793B96 File Offset: 0x00791D96
		public HideFlags HideFlags_C212E
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

		// Token: 0x17012D66 RID: 77158
		// (get) Token: 0x0603900E RID: 233486 RVA: 0x00793B9F File Offset: 0x00791D9F
		// (set) Token: 0x0603900F RID: 233487 RVA: 0x00793BA7 File Offset: 0x00791DA7
		public LightProbeUsage LightProbeUsage_C212E
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

		// Token: 0x17012D67 RID: 77159
		// (get) Token: 0x06039010 RID: 233488 RVA: 0x00793BB1 File Offset: 0x00791DB1
		// (set) Token: 0x06039011 RID: 233489 RVA: 0x00793BB9 File Offset: 0x00791DB9
		public SpriteMaskInteraction MaskInteraction_C212E
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

		// Token: 0x17012D68 RID: 77160
		// (get) Token: 0x06039012 RID: 233490 RVA: 0x00793BC2 File Offset: 0x00791DC2
		// (set) Token: 0x06039013 RID: 233491 RVA: 0x00793BC5 File Offset: 0x00791DC5
		public RayTracingMode RayTracingMode_C212E
		{
			get
			{
				return RayTracingMode.Off;
			}
			set
			{
			}
		}

		// Token: 0x17012D69 RID: 77161
		// (get) Token: 0x06039014 RID: 233492 RVA: 0x00793BC7 File Offset: 0x00791DC7
		// (set) Token: 0x06039015 RID: 233493 RVA: 0x00793BCA File Offset: 0x00791DCA
		public ReflectionProbeUsage ReflectionProbeUsage_C212_Int32E
		{
			get
			{
				return ReflectionProbeUsage.Off;
			}
			set
			{
			}
		}

		// Token: 0x17012D6A RID: 77162
		// (get) Token: 0x06039016 RID: 233494 RVA: 0x00793BCC File Offset: 0x00791DCC
		// (set) Token: 0x06039017 RID: 233495 RVA: 0x00793BD4 File Offset: 0x00791DD4
		public ReflectionProbeUsage ReflectionProbeUsage_C212_ByteE
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

		// Token: 0x17012D6B RID: 77163
		// (get) Token: 0x06039018 RID: 233496 RVA: 0x00793BDE File Offset: 0x00791DDE
		// (set) Token: 0x06039019 RID: 233497 RVA: 0x00793BE1 File Offset: 0x00791DE1
		public SpriteSortPoint SpriteSortPoint_C212E
		{
			get
			{
				return SpriteSortPoint.Center;
			}
			set
			{
			}
		}

		// Token: 0x17012D6C RID: 77164
		// (get) Token: 0x0603901A RID: 233498 RVA: 0x00793BE3 File Offset: 0x00791DE3
		// (set) Token: 0x0603901B RID: 233499 RVA: 0x00793BF6 File Offset: 0x00791DF6
		public IEditorExtension CorrespondingSourceObject_C212P
		{
			get
			{
				return PPtrExtensions.TryGetAsset<IEditorExtension>(this.CorrespondingSourceObject_C212, base.Collection);
			}
			set
			{
				PPtrExtensions.SetAsset<IEditorExtension>(this.CorrespondingSourceObject_C212, base.Collection, value);
			}
		}

		// Token: 0x17012D6D RID: 77165
		// (get) Token: 0x0603901C RID: 233500 RVA: 0x00793C0A File Offset: 0x00791E0A
		// (set) Token: 0x0603901D RID: 233501 RVA: 0x00793C1D File Offset: 0x00791E1D
		public IGameObject GameObject_C212P
		{
			get
			{
				return PPtrExtensions.TryGetAsset<IGameObject>(this.GameObject_C212, base.Collection);
			}
			set
			{
				PPtrExtensions.SetAsset<IGameObject>(this.GameObject_C212, base.Collection, value);
			}
		}

		// Token: 0x17012D6E RID: 77166
		// (get) Token: 0x0603901E RID: 233502 RVA: 0x00793C31 File Offset: 0x00791E31
		// (set) Token: 0x0603901F RID: 233503 RVA: 0x00793C44 File Offset: 0x00791E44
		public ILightmapParameters LightmapParameters_C212P
		{
			get
			{
				return PPtrExtensions.TryGetAsset<ILightmapParameters>(this.LightmapParameters_C212, base.Collection);
			}
			set
			{
				PPtrExtensions.SetAsset<ILightmapParameters>(this.LightmapParameters_C212, base.Collection, value);
			}
		}

		// Token: 0x17012D6F RID: 77167
		// (get) Token: 0x06039020 RID: 233504 RVA: 0x00793C58 File Offset: 0x00791E58
		// (set) Token: 0x06039021 RID: 233505 RVA: 0x00793C5B File Offset: 0x00791E5B
		public ITransform LightProbeAnchor_C212P
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x17012D70 RID: 77168
		// (get) Token: 0x06039022 RID: 233506 RVA: 0x00793C5D File Offset: 0x00791E5D
		// (set) Token: 0x06039023 RID: 233507 RVA: 0x00793C70 File Offset: 0x00791E70
		public IGameObject LightProbeVolumeOverride_C212P
		{
			get
			{
				return PPtrExtensions.TryGetAsset<IGameObject>(this.LightProbeVolumeOverride_C212, base.Collection);
			}
			set
			{
				PPtrExtensions.SetAsset<IGameObject>(this.LightProbeVolumeOverride_C212, base.Collection, value);
			}
		}

		// Token: 0x17012D71 RID: 77169
		// (get) Token: 0x06039024 RID: 233508 RVA: 0x00793C84 File Offset: 0x00791E84

		public PPtrAccessList<IPPtr_Material, IMaterial> Materials_C212P
		{

			get
			{
				return new PPtrAccessList<IPPtr_Material, IMaterial>(this.Materials_C212, this);
			}
		}

		// Token: 0x17012D72 RID: 77170
		// (get) Token: 0x06039025 RID: 233509 RVA: 0x00793C92 File Offset: 0x00791E92
		// (set) Token: 0x06039026 RID: 233510 RVA: 0x00793C95 File Offset: 0x00791E95
		public IPrefab PrefabAsset_C212P
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x17012D73 RID: 77171
		// (get) Token: 0x06039027 RID: 233511 RVA: 0x00793C97 File Offset: 0x00791E97
		// (set) Token: 0x06039028 RID: 233512 RVA: 0x00793C9A File Offset: 0x00791E9A
		public IPrefabInstance PrefabInstance_C212P
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x17012D74 RID: 77172
		// (get) Token: 0x06039029 RID: 233513 RVA: 0x00793C9C File Offset: 0x00791E9C
		// (set) Token: 0x0603902A RID: 233514 RVA: 0x00793CAF File Offset: 0x00791EAF
		public IPrefabMarker PrefabInternal_C212P
		{
			get
			{
				return PPtrExtensions.TryGetAsset<IPrefabMarker>(this.PrefabInternal_C212, base.Collection);
			}
			set
			{
				PPtrExtensions.SetAsset<IPrefabMarker>(this.PrefabInternal_C212, base.Collection, value);
			}
		}

		// Token: 0x17012D75 RID: 77173
		// (get) Token: 0x0603902B RID: 233515 RVA: 0x00793CC3 File Offset: 0x00791EC3
		// (set) Token: 0x0603902C RID: 233516 RVA: 0x00793CD6 File Offset: 0x00791ED6
		public ITransform ProbeAnchor_C212P
		{
			get
			{
				return PPtrExtensions.TryGetAsset<ITransform>(this.ProbeAnchor_C212, base.Collection);
			}
			set
			{
				PPtrExtensions.SetAsset<ITransform>(this.ProbeAnchor_C212, base.Collection, value);
			}
		}

		// Token: 0x17012D76 RID: 77174
		// (get) Token: 0x0603902D RID: 233517 RVA: 0x00793CEA File Offset: 0x00791EEA
		// (set) Token: 0x0603902E RID: 233518 RVA: 0x00793CFD File Offset: 0x00791EFD
		public ISprite Sprite_C212P
		{
			get
			{
				return PPtrExtensions.TryGetAsset<ISprite>(this.Sprite_C212, base.Collection);
			}
			set
			{
				PPtrExtensions.SetAsset<ISprite>(this.Sprite_C212, base.Collection, value);
			}
		}

		// Token: 0x17012D77 RID: 77175
		// (get) Token: 0x0603902F RID: 233519 RVA: 0x00793D11 File Offset: 0x00791F11
		// (set) Token: 0x06039030 RID: 233520 RVA: 0x00793D24 File Offset: 0x00791F24
		public ITransform StaticBatchRoot_C212P
		{
			get
			{
				return PPtrExtensions.TryGetAsset<ITransform>(this.StaticBatchRoot_C212, base.Collection);
			}
			set
			{
				PPtrExtensions.SetAsset<ITransform>(this.StaticBatchRoot_C212, base.Collection, value);
			}
		}

		// Token: 0x17012D78 RID: 77176
		// (get) Token: 0x06039031 RID: 233521 RVA: 0x00793D38 File Offset: 0x00791F38

		public override string ClassName
		{

			get
			{
				return "SpriteRenderer";
			}
		}

		// Token: 0x06039032 RID: 233522 RVA: 0x00793D3F File Offset: 0x00791F3F
		public SpriteRenderer_2017_1_0_GICB2()
			: this(AssetInfo.MakeDummyAssetInfo(212))
		{
		}

		// Token: 0x06039033 RID: 233523 RVA: 0x00793D51 File Offset: 0x00791F51
		public SpriteRenderer_2017_1_0_GICB2(AssetInfo info)
			: base(info)
		{
			this.m_Sprite = new PPtr_Sprite_5_0_0();
			this.m_Color = new ColorRGBAf_3_5_0();
			this.m_Size = new Vector2f_3_5_0();
		}

		// Token: 0x06039034 RID: 233524 RVA: 0x00793D7B File Offset: 0x00791F7B
		public bool Has_AdaptiveModeThreshold_C212()
		{
			return true;
		}

		// Token: 0x06039035 RID: 233525 RVA: 0x00793D7E File Offset: 0x00791F7E
		public bool Has_AutoUVMaxAngle_C212()
		{
			return true;
		}

		// Token: 0x06039036 RID: 233526 RVA: 0x00793D81 File Offset: 0x00791F81
		public bool Has_AutoUVMaxDistance_C212()
		{
			return true;
		}

		// Token: 0x06039037 RID: 233527 RVA: 0x00793D84 File Offset: 0x00791F84
		public bool Has_CastShadows_C212_Boolean()
		{
			return false;
		}

		// Token: 0x06039038 RID: 233528 RVA: 0x00793D87 File Offset: 0x00791F87
		public bool Has_CastShadows_C212_Byte()
		{
			return true;
		}

		// Token: 0x06039039 RID: 233529 RVA: 0x00793D8A File Offset: 0x00791F8A
		public bool Has_DrawMode_C212()
		{
			return true;
		}

		// Token: 0x0603903A RID: 233530 RVA: 0x00793D8D File Offset: 0x00791F8D
		public bool Has_DynamicOccludee_C212()
		{
			return false;
		}

		// Token: 0x0603903B RID: 233531 RVA: 0x00793D90 File Offset: 0x00791F90
		public bool Has_FlipX_C212()
		{
			return true;
		}

		// Token: 0x0603903C RID: 233532 RVA: 0x00793D93 File Offset: 0x00791F93
		public bool Has_FlipY_C212()
		{
			return true;
		}

		// Token: 0x0603903D RID: 233533 RVA: 0x00793D96 File Offset: 0x00791F96
		public bool Has_IgnoreNormalsForChartDetection_C212()
		{
			return true;
		}

		// Token: 0x0603903E RID: 233534 RVA: 0x00793D99 File Offset: 0x00791F99
		public bool Has_ImportantGI_C212()
		{
			return true;
		}

		// Token: 0x0603903F RID: 233535 RVA: 0x00793D9C File Offset: 0x00791F9C
		public bool Has_LightmapIndex_C212_Byte()
		{
			return false;
		}

		// Token: 0x06039040 RID: 233536 RVA: 0x00793D9F File Offset: 0x00791F9F
		public bool Has_LightmapIndex_C212_UInt16()
		{
			return true;
		}

		// Token: 0x06039041 RID: 233537 RVA: 0x00793DA2 File Offset: 0x00791FA2
		public bool Has_LightmapIndexDynamic_C212()
		{
			return true;
		}

		// Token: 0x06039042 RID: 233538 RVA: 0x00793DA5 File Offset: 0x00791FA5
		public bool Has_LightmapParameters_C212()
		{
			return true;
		}

		// Token: 0x06039043 RID: 233539 RVA: 0x00793DA8 File Offset: 0x00791FA8
		public bool Has_LightmapTilingOffsetDynamic_C212()
		{
			return true;
		}

		// Token: 0x06039044 RID: 233540 RVA: 0x00793DAB File Offset: 0x00791FAB
		public bool Has_LightProbeAnchor_C212()
		{
			return false;
		}

		// Token: 0x06039045 RID: 233541 RVA: 0x00793DAE File Offset: 0x00791FAE
		public bool Has_LightProbeUsage_C212()
		{
			return true;
		}

		// Token: 0x06039046 RID: 233542 RVA: 0x00793DB1 File Offset: 0x00791FB1
		public bool Has_LightProbeVolumeOverride_C212()
		{
			return true;
		}

		// Token: 0x06039047 RID: 233543 RVA: 0x00793DB4 File Offset: 0x00791FB4
		public bool Has_MaskInteraction_C212()
		{
			return true;
		}

		// Token: 0x06039048 RID: 233544 RVA: 0x00793DB7 File Offset: 0x00791FB7
		public bool Has_MinimumChartSize_C212()
		{
			return true;
		}

		// Token: 0x06039049 RID: 233545 RVA: 0x00793DBA File Offset: 0x00791FBA
		public bool Has_MotionVectors_C212()
		{
			return true;
		}

		// Token: 0x0603904A RID: 233546 RVA: 0x00793DBD File Offset: 0x00791FBD
		public bool Has_PrefabAsset_C212()
		{
			return false;
		}

		// Token: 0x0603904B RID: 233547 RVA: 0x00793DC0 File Offset: 0x00791FC0
		public bool Has_PrefabInstance_C212()
		{
			return false;
		}

		// Token: 0x0603904C RID: 233548 RVA: 0x00793DC3 File Offset: 0x00791FC3
		public bool Has_PrefabInternal_C212()
		{
			return true;
		}

		// Token: 0x0603904D RID: 233549 RVA: 0x00793DC6 File Offset: 0x00791FC6
		public bool Has_PreserveUVs_C212()
		{
			return true;
		}

		// Token: 0x0603904E RID: 233550 RVA: 0x00793DC9 File Offset: 0x00791FC9
		public bool Has_ProbeAnchor_C212()
		{
			return true;
		}

		// Token: 0x0603904F RID: 233551 RVA: 0x00793DCC File Offset: 0x00791FCC
		public bool Has_RayTraceProcedural_C212()
		{
			return false;
		}

		// Token: 0x06039050 RID: 233552 RVA: 0x00793DCF File Offset: 0x00791FCF
		public bool Has_RayTracingMode_C212()
		{
			return false;
		}

		// Token: 0x06039051 RID: 233553 RVA: 0x00793DD2 File Offset: 0x00791FD2
		public bool Has_ReceiveGI_C212()
		{
			return false;
		}

		// Token: 0x06039052 RID: 233554 RVA: 0x00793DD5 File Offset: 0x00791FD5
		public bool Has_ReceiveShadows_C212_Boolean()
		{
			return false;
		}

		// Token: 0x06039053 RID: 233555 RVA: 0x00793DD8 File Offset: 0x00791FD8
		public bool Has_ReceiveShadows_C212_Byte()
		{
			return true;
		}

		// Token: 0x06039054 RID: 233556 RVA: 0x00793DDB File Offset: 0x00791FDB
		public bool Has_ReflectionProbeUsage_C212_Int32()
		{
			return false;
		}

		// Token: 0x06039055 RID: 233557 RVA: 0x00793DDE File Offset: 0x00791FDE
		public bool Has_ReflectionProbeUsage_C212_Byte()
		{
			return true;
		}

		// Token: 0x06039056 RID: 233558 RVA: 0x00793DE1 File Offset: 0x00791FE1
		public bool Has_RendererPriority_C212()
		{
			return false;
		}

		// Token: 0x06039057 RID: 233559 RVA: 0x00793DE4 File Offset: 0x00791FE4
		public bool Has_RenderingLayerMask_C212()
		{
			return false;
		}

		// Token: 0x06039058 RID: 233560 RVA: 0x00793DE7 File Offset: 0x00791FE7
		public bool Has_SelectedEditorRenderState_C212()
		{
			return true;
		}

		// Token: 0x06039059 RID: 233561 RVA: 0x00793DEA File Offset: 0x00791FEA
		public bool Has_SelectedWireframeHidden_C212()
		{
			return false;
		}

		// Token: 0x0603905A RID: 233562 RVA: 0x00793DED File Offset: 0x00791FED
		public bool Has_Size_C212()
		{
			return true;
		}

		// Token: 0x0603905B RID: 233563 RVA: 0x00793DF0 File Offset: 0x00791FF0
		public bool Has_SortingLayer_C212()
		{
			return true;
		}

		// Token: 0x0603905C RID: 233564 RVA: 0x00793DF3 File Offset: 0x00791FF3
		public bool Has_SortingLayerID_C212_UInt32()
		{
			return false;
		}

		// Token: 0x0603905D RID: 233565 RVA: 0x00793DF6 File Offset: 0x00791FF6
		public bool Has_SortingLayerID_C212_Int32()
		{
			return true;
		}

		// Token: 0x0603905E RID: 233566 RVA: 0x00793DF9 File Offset: 0x00791FF9
		public bool Has_SpriteSortPoint_C212()
		{
			return false;
		}

		// Token: 0x0603905F RID: 233567 RVA: 0x00793DFC File Offset: 0x00791FFC
		public bool Has_SpriteTileMode_C212()
		{
			return true;
		}

		// Token: 0x06039060 RID: 233568 RVA: 0x00793DFF File Offset: 0x00791FFF
		public bool Has_StaticBatchInfo_C212()
		{
			return true;
		}

		// Token: 0x06039061 RID: 233569 RVA: 0x00793E02 File Offset: 0x00792002
		public bool Has_StaticShadowCaster_C212()
		{
			return false;
		}

		// Token: 0x06039062 RID: 233570 RVA: 0x00793E05 File Offset: 0x00792005
		public bool Has_StitchLightmapSeams_C212()
		{
			return false;
		}

		// Token: 0x06039063 RID: 233571 RVA: 0x00793E08 File Offset: 0x00792008
		public bool Has_StitchSeams_C212()
		{
			return false;
		}

		// Token: 0x06039064 RID: 233572 RVA: 0x00793E0B File Offset: 0x0079200B
		public bool Has_SubsetIndices_C212()
		{
			return false;
		}

		// Token: 0x06039065 RID: 233573 RVA: 0x00793E0E File Offset: 0x0079200E
		public bool Has_UseLightProbes_C212()
		{
			return false;
		}

		// Token: 0x06039066 RID: 233574 RVA: 0x00793E11 File Offset: 0x00792011
		public bool Has_WasSpriteAssigned_C212()
		{
			return true;
		}

		// Token: 0x06039067 RID: 233575 RVA: 0x00793E14 File Offset: 0x00792014

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

			this.m_Sprite.ReadRelease(reader);
			this.m_Color.ReadRelease_AssetAlign(reader);
			this.m_FlipX = reader.ReadBoolean();
			this.m_FlipY = reader.ReadRelease_BooleanAlign();
			this.m_DrawMode = reader.ReadInt32();
			this.m_Size.ReadRelease(reader);
			this.m_AdaptiveModeThreshold = reader.ReadSingle();
			this.m_SpriteTileMode = reader.ReadInt32();
			this.m_WasSpriteAssigned = reader.ReadRelease_BooleanAlign();
			this.m_MaskInteraction = reader.ReadInt32();
		}

		// Token: 0x06039068 RID: 233576 RVA: 0x00793F80 File Offset: 0x00792180



		// Token: 0x06039069 RID: 233577 RVA: 0x0079414C File Offset: 0x0079234C

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
			this.m_Sprite.WriteRelease(writer);
			this.m_Color.WriteRelease_AssetAlign(writer);
			this.m_FlipX.WriteRelease_Boolean(writer);
			this.m_FlipY.WriteRelease_BooleanAlign(writer);
			this.m_DrawMode.WriteRelease_Int32(writer);
			this.m_Size.WriteRelease(writer);
			this.m_AdaptiveModeThreshold.WriteRelease_Single(writer);
			this.m_SpriteTileMode.WriteRelease_Int32(writer);
			this.m_WasSpriteAssigned.WriteRelease_BooleanAlign(writer);
			this.m_MaskInteraction.WriteRelease_Int32(writer);
		}

		// Token: 0x0603906A RID: 233578 RVA: 0x007942B8 File Offset: 0x007924B8



		// Token: 0x0603906B RID: 233579 RVA: 0x00794484 File Offset: 0x00792684

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
			yamlMappingNode.Add(new YamlScalarNode("m_Sprite"), this.m_Sprite.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Color"), this.m_Color.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("m_FlipX"), this.m_FlipX.ExportYamlRelease_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("m_FlipY"), this.m_FlipY.ExportYamlRelease_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("m_DrawMode"), this.m_DrawMode.ExportYamlRelease_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Size"), this.m_Size.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("m_AdaptiveModeThreshold"), this.m_AdaptiveModeThreshold.ExportYamlRelease_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("m_SpriteTileMode"), this.m_SpriteTileMode.ExportYamlRelease_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("m_WasSpriteAssigned"), this.m_WasSpriteAssigned.ExportYamlRelease_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("m_MaskInteraction"), this.m_MaskInteraction.ExportYamlRelease_Int32(container));
			return yamlMappingNode;
		}

		// Token: 0x0603906C RID: 233580 RVA: 0x007947CC File Offset: 0x007929CC

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
			yamlMappingNode.Add(new YamlScalarNode("m_Sprite"), this.m_Sprite.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Color"), this.m_Color.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_FlipX"), this.m_FlipX.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("m_FlipY"), this.m_FlipY.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("m_DrawMode"), this.m_DrawMode.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Size"), this.m_Size.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_AdaptiveModeThreshold"), this.m_AdaptiveModeThreshold.ExportYamlEditor_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("m_SpriteTileMode"), this.m_SpriteTileMode.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("m_WasSpriteAssigned"), this.m_WasSpriteAssigned.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("m_MaskInteraction"), this.m_MaskInteraction.ExportYamlEditor_Int32(container));
			return yamlMappingNode;
		}

		// Token: 0x0603906D RID: 233581 RVA: 0x00794BF4 File Offset: 0x00792DF4
		public override void Reset()
		{
			this.m_AdaptiveModeThreshold = 0f;
			this.m_AutoUVMaxAngle = 0f;
			this.m_AutoUVMaxDistance = 0f;
			this.m_CastShadows = 0;
			this.m_Color.Reset();
			this.m_CorrespondingSourceObject.Reset();
			this.m_DrawMode = 0;
			this.m_Enabled = false;
			this.m_FlipX = false;
			this.m_FlipY = false;
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
			this.m_MaskInteraction = 0;
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
			this.m_Size.Reset();
			this.m_SortingLayer = 0;
			this.m_SortingLayerID = 0;
			this.m_SortingOrder = 0;
			this.m_Sprite.Reset();
			this.m_SpriteTileMode = 0;
			this.m_StaticBatchInfo.Reset();
			this.m_StaticBatchRoot.Reset();
			this.m_WasSpriteAssigned = false;
		}

		// Token: 0x0603906E RID: 233582 RVA: 0x00794D68 File Offset: 0x00792F68



		// Token: 0x0603906F RID: 233583 RVA: 0x00794D78 File Offset: 0x00792F78

		public void CopyValues(ISpriteRenderer source, PPtrConverter converter)
		{
			this.m_AdaptiveModeThreshold = source.AdaptiveModeThreshold_C212;
			this.m_AutoUVMaxAngle = source.AutoUVMaxAngle_C212;
			this.m_AutoUVMaxDistance = source.AutoUVMaxDistance_C212;
			this.m_CastShadows = source.CastShadows_C212_Byte;
			this.m_Color.CopyValues(source.Color_C212);
			this.m_CorrespondingSourceObject.CopyValues(source.CorrespondingSourceObject_C212, converter);
			this.m_DrawMode = source.DrawMode_C212;
			this.m_Enabled = source.Enabled_C212;
			this.m_FlipX = source.FlipX_C212;
			this.m_FlipY = source.FlipY_C212;
			this.m_GameObject.CopyValues(source.GameObject_C212, converter);
			this.m_HideFlags = source.HideFlags_C212;
			this.m_IgnoreNormalsForChartDetection = source.IgnoreNormalsForChartDetection_C212;
			this.m_ImportantGI = source.ImportantGI_C212;
			this.m_LightmapIndex = source.LightmapIndex_C212_UInt16;
			this.m_LightmapIndexDynamic = source.LightmapIndexDynamic_C212;
			this.m_LightmapParameters.CopyValues(source.LightmapParameters_C212, converter);
			this.m_LightmapTilingOffset.CopyValues(source.LightmapTilingOffset_C212);
			this.m_LightmapTilingOffsetDynamic.CopyValues(source.LightmapTilingOffsetDynamic_C212);
			this.m_LightProbeUsage = source.LightProbeUsage_C212;
			this.m_LightProbeVolumeOverride.CopyValues(source.LightProbeVolumeOverride_C212, converter);
			this.m_MaskInteraction = source.MaskInteraction_C212;
			CopyValuesHelper.CopyValues__AssetList_PPtr_Material_5_0_0__AccessListBase_IPPtr_Material(this.m_Materials, source.Materials_C212, converter);
			this.m_MinimumChartSize = source.MinimumChartSize_C212;
			this.m_MotionVectors = source.MotionVectors_C212;
			this.m_PrefabInternal.CopyValues(source.PrefabInternal_C212, converter);
			this.m_PreserveUVs = source.PreserveUVs_C212;
			this.m_ProbeAnchor.CopyValues(source.ProbeAnchor_C212, converter);
			this.m_ReceiveShadows = source.ReceiveShadows_C212_Byte;
			this.m_ReflectionProbeUsage = source.ReflectionProbeUsage_C212_Byte;
			this.m_ScaleInLightmap = source.ScaleInLightmap_C212;
			this.m_SelectedEditorRenderState = source.SelectedEditorRenderState_C212;
			this.m_Size.CopyValues(source.Size_C212);
			this.m_SortingLayer = source.SortingLayer_C212;
			this.m_SortingLayerID = source.SortingLayerID_C212_Int32;
			this.m_SortingOrder = source.SortingOrder_C212;
			this.m_Sprite.CopyValues(source.Sprite_C212, converter);
			this.m_SpriteTileMode = source.SpriteTileMode_C212;
			this.m_StaticBatchInfo.CopyValues(source.StaticBatchInfo_C212);
			this.m_StaticBatchRoot.CopyValues(source.StaticBatchRoot_C212, converter);
			this.m_WasSpriteAssigned = source.WasSpriteAssigned_C212;
		}

		// Token: 0x06039070 RID: 233584 RVA: 0x00794FC0 File Offset: 0x007931C0

		public void CopyValues(ISpriteRenderer source)
		{
			this.CopyValues(source, new PPtrConverter(source, this));
		}

		// Token: 0x06039071 RID: 233585 RVA: 0x00794FD0 File Offset: 0x007931D0
		public override void CopyValues(IUnityAssetBase source, PPtrConverter converter)
		{
			ISpriteRenderer spriteRenderer = source as ISpriteRenderer;
			if (spriteRenderer != null)
			{
				this.CopyValues(spriteRenderer, converter);
				return;
			}
			base.CopyValues(source, converter);
		}

		// Token: 0x06039072 RID: 233586 RVA: 0x00794FF8 File Offset: 0x007931F8

		public override List<TypeTreeNode> MakeEditorTypeTreeNodes(int depth, int startingIndex)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06039073 RID: 233587 RVA: 0x00794FFF File Offset: 0x007931FF

		public override List<TypeTreeNode> MakeReleaseTypeTreeNodes(int depth, int startingIndex)
		{
			throw new NotSupportedException();
		}

		// Token: 0x04013882 RID: 80002

		public PPtr_Sprite_5_0_0 m_Sprite;

		// Token: 0x04013883 RID: 80003

		public ColorRGBAf_3_5_0 m_Color;

		// Token: 0x04013884 RID: 80004
		public bool m_FlipX;

		// Token: 0x04013885 RID: 80005
		public bool m_FlipY;

		// Token: 0x04013886 RID: 80006
		public int m_DrawMode;

		// Token: 0x04013887 RID: 80007

		public Vector2f_3_5_0 m_Size;

		// Token: 0x04013888 RID: 80008
		public float m_AdaptiveModeThreshold;

		// Token: 0x04013889 RID: 80009
		public int m_SpriteTileMode;

		// Token: 0x0401388A RID: 80010
		public bool m_WasSpriteAssigned;

		// Token: 0x0401388B RID: 80011
		public int m_MaskInteraction;
	}
}
