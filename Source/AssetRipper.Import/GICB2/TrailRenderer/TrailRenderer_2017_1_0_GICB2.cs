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
using AssetRipper.SourceGenerated.Subclasses.GradientOld;
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
using AssetRipper.SourceGenerated.Subclasses.Vector4f;
using AssetRipper.Yaml;
using AssetRipper.Import.GICB2.TrailRenderer.LineParameters;
using AssetRipper.SourceGenerated.Classes.ClassID_96;

namespace AssetRipper.Import.GICB2.TrailRenderer
{
	// Token: 0x02002543 RID: 9539


	public sealed class TrailRenderer_2017_1_0_GICB2 : Renderer_2017_1_0, ITrailRenderer, IUnityObjectBase, IUnityAssetBase, IAsset, IAssetReadable, IAssetWritable, IYamlExportable, IDependent, ITypeTreeSerializable, ITrailRendererMarker, IRenderer, IRendererMarker, IHasEnabled, IComponent, IEditorExtension, IEditorExtensionMarker, IObject, IObjectMarker, IHasHideFlags, IComponentMarker
	{
		// Token: 0x17005F12 RID: 24338
		// (get) Token: 0x06018C36 RID: 101430 RVA: 0x003F6EAE File Offset: 0x003F50AE
		// (set) Token: 0x06018C37 RID: 101431 RVA: 0x003F6EB1 File Offset: 0x003F50B1
		public bool ApplyActiveColorSpace_C96
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17005F13 RID: 24339
		// (get) Token: 0x06018C38 RID: 101432 RVA: 0x003F6EB3 File Offset: 0x003F50B3
		// (set) Token: 0x06018C39 RID: 101433 RVA: 0x003F6EBB File Offset: 0x003F50BB
		public bool Autodestruct_C96
		{
			get
			{
				return this.m_Autodestruct;
			}
			set
			{
				this.m_Autodestruct = value;
			}
		}

		// Token: 0x17005F14 RID: 24340
		// (get) Token: 0x06018C3A RID: 101434 RVA: 0x003F6EC4 File Offset: 0x003F50C4
		// (set) Token: 0x06018C3B RID: 101435 RVA: 0x003F6ECC File Offset: 0x003F50CC
		public float AutoUVMaxAngle_C96
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

		// Token: 0x17005F15 RID: 24341
		// (get) Token: 0x06018C3C RID: 101436 RVA: 0x003F6ED5 File Offset: 0x003F50D5
		// (set) Token: 0x06018C3D RID: 101437 RVA: 0x003F6EDD File Offset: 0x003F50DD
		public float AutoUVMaxDistance_C96
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

		// Token: 0x17005F16 RID: 24342
		// (get) Token: 0x06018C3E RID: 101438 RVA: 0x003F6EE6 File Offset: 0x003F50E6
		// (set) Token: 0x06018C3F RID: 101439 RVA: 0x003F6EE9 File Offset: 0x003F50E9
		public bool CastShadows_C96_Boolean
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17005F17 RID: 24343
		// (get) Token: 0x06018C40 RID: 101440 RVA: 0x003F6EEB File Offset: 0x003F50EB
		// (set) Token: 0x06018C41 RID: 101441 RVA: 0x003F6EF3 File Offset: 0x003F50F3
		public byte CastShadows_C96_Byte
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

		// Token: 0x17005F18 RID: 24344
		// (get) Token: 0x06018C42 RID: 101442 RVA: 0x003F6EFC File Offset: 0x003F50FC
		public GradientOld Colors_C96
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005F19 RID: 24345
		// (get) Token: 0x06018C43 RID: 101443 RVA: 0x003F6EFF File Offset: 0x003F50FF
		public IPPtr_EditorExtension CorrespondingSourceObject_C96
		{
			[return: NotNull]
			get
			{
				return this.m_CorrespondingSourceObject;
			}
		}

		// Token: 0x17005F1A RID: 24346
		// (get) Token: 0x06018C44 RID: 101444 RVA: 0x003F6F07 File Offset: 0x003F5107
		// (set) Token: 0x06018C45 RID: 101445 RVA: 0x003F6F0A File Offset: 0x003F510A
		public byte DynamicOccludee_C96
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x17005F1B RID: 24347
		// (get) Token: 0x06018C46 RID: 101446 RVA: 0x003F6F0C File Offset: 0x003F510C
		// (set) Token: 0x06018C47 RID: 101447 RVA: 0x003F6F0F File Offset: 0x003F510F
		public bool Emitting_C96
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17005F1C RID: 24348
		// (get) Token: 0x06018C48 RID: 101448 RVA: 0x003F6F11 File Offset: 0x003F5111
		// (set) Token: 0x06018C49 RID: 101449 RVA: 0x003F6F19 File Offset: 0x003F5119
		public bool Enabled_C96
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

		// Token: 0x17005F1D RID: 24349
		// (get) Token: 0x06018C4A RID: 101450 RVA: 0x003F6F22 File Offset: 0x003F5122
		// (set) Token: 0x06018C4B RID: 101451 RVA: 0x003F6F29 File Offset: 0x003F5129
		public float EndWidth_C96
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17005F1E RID: 24350
		// (get) Token: 0x06018C4C RID: 101452 RVA: 0x003F6F2B File Offset: 0x003F512B
		public PPtr_EditorExtensionImpl ExtensionPtr_C96
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005F1F RID: 24351
		// (get) Token: 0x06018C4D RID: 101453 RVA: 0x003F6F2E File Offset: 0x003F512E

		public IPPtr_GameObject GameObject_C96
		{

			get
			{
				return this.m_GameObject;
			}
		}

		// Token: 0x17005F20 RID: 24352
		// (get) Token: 0x06018C4E RID: 101454 RVA: 0x003F6F36 File Offset: 0x003F5136
		// (set) Token: 0x06018C4F RID: 101455 RVA: 0x003F6F3E File Offset: 0x003F513E
		public uint HideFlags_C96
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

		// Token: 0x17005F21 RID: 24353
		// (get) Token: 0x06018C50 RID: 101456 RVA: 0x003F6F47 File Offset: 0x003F5147
		// (set) Token: 0x06018C51 RID: 101457 RVA: 0x003F6F4F File Offset: 0x003F514F
		public bool IgnoreNormalsForChartDetection_C96
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

		// Token: 0x17005F22 RID: 24354
		// (get) Token: 0x06018C52 RID: 101458 RVA: 0x003F6F58 File Offset: 0x003F5158
		// (set) Token: 0x06018C53 RID: 101459 RVA: 0x003F6F60 File Offset: 0x003F5160
		public bool ImportantGI_C96
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

		// Token: 0x17005F23 RID: 24355
		// (get) Token: 0x06018C54 RID: 101460 RVA: 0x003F6F69 File Offset: 0x003F5169
		// (set) Token: 0x06018C55 RID: 101461 RVA: 0x003F6F6C File Offset: 0x003F516C
		public byte LightmapIndex_C96_Byte
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x17005F24 RID: 24356
		// (get) Token: 0x06018C56 RID: 101462 RVA: 0x003F6F6E File Offset: 0x003F516E
		// (set) Token: 0x06018C57 RID: 101463 RVA: 0x003F6F76 File Offset: 0x003F5176
		public ushort LightmapIndex_C96_UInt16
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

		// Token: 0x17005F25 RID: 24357
		// (get) Token: 0x06018C58 RID: 101464 RVA: 0x003F6F7F File Offset: 0x003F517F
		// (set) Token: 0x06018C59 RID: 101465 RVA: 0x003F6F87 File Offset: 0x003F5187
		public ushort LightmapIndexDynamic_C96
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

		// Token: 0x17005F26 RID: 24358
		// (get) Token: 0x06018C5A RID: 101466 RVA: 0x003F6F90 File Offset: 0x003F5190
		public PPtr_LightmapParameters LightmapParameters_C96
		{
			[return: NotNull]
			get
			{
				return this.m_LightmapParameters;
			}
		}

		// Token: 0x17005F27 RID: 24359
		// (get) Token: 0x06018C5B RID: 101467 RVA: 0x003F6F98 File Offset: 0x003F5198

		public IVector4f LightmapTilingOffset_C96
		{

			get
			{
				return this.m_LightmapTilingOffset;
			}
		}

		// Token: 0x17005F28 RID: 24360
		// (get) Token: 0x06018C5C RID: 101468 RVA: 0x003F6FA0 File Offset: 0x003F51A0
		public Vector4f_3_5_0 LightmapTilingOffsetDynamic_C96
		{
			[return: NotNull]
			get
			{
				return this.m_LightmapTilingOffsetDynamic;
			}
		}

		// Token: 0x17005F29 RID: 24361
		// (get) Token: 0x06018C5D RID: 101469 RVA: 0x003F6FA8 File Offset: 0x003F51A8
		public PPtr_Transform_3_4_0 LightProbeAnchor_C96
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005F2A RID: 24362
		// (get) Token: 0x06018C5E RID: 101470 RVA: 0x003F6FAB File Offset: 0x003F51AB
		// (set) Token: 0x06018C5F RID: 101471 RVA: 0x003F6FB3 File Offset: 0x003F51B3
		public byte LightProbeUsage_C96
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

		// Token: 0x17005F2B RID: 24363
		// (get) Token: 0x06018C60 RID: 101472 RVA: 0x003F6FBC File Offset: 0x003F51BC
		public PPtr_GameObject_5_0_0 LightProbeVolumeOverride_C96
		{
			[return: NotNull]
			get
			{
				return this.m_LightProbeVolumeOverride;
			}
		}

		// Token: 0x17005F2C RID: 24364
		// (get) Token: 0x06018C61 RID: 101473 RVA: 0x003F6FC4 File Offset: 0x003F51C4
		// (set) Token: 0x06018C62 RID: 101474 RVA: 0x003F6FC7 File Offset: 0x003F51C7
		public int MaskInteraction_C96
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x17005F2D RID: 24365
		// (get) Token: 0x06018C63 RID: 101475 RVA: 0x003F6FC9 File Offset: 0x003F51C9

		public AccessListBase<IPPtr_Material> Materials_C96
		{

			get
			{
				return new AccessList<PPtr_Material_5_0_0, IPPtr_Material>(this.m_Materials);
			}
		}

		// Token: 0x17005F2E RID: 24366
		// (get) Token: 0x06018C64 RID: 101476 RVA: 0x003F6FD6 File Offset: 0x003F51D6
		// (set) Token: 0x06018C65 RID: 101477 RVA: 0x003F6FDE File Offset: 0x003F51DE
		public int MinimumChartSize_C96
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

		// Token: 0x17005F2F RID: 24367
		// (get) Token: 0x06018C66 RID: 101478 RVA: 0x003F6FE7 File Offset: 0x003F51E7
		// (set) Token: 0x06018C67 RID: 101479 RVA: 0x003F6FEF File Offset: 0x003F51EF
		public float MinVertexDistance_C96
		{
			get
			{
				return this.m_MinVertexDistance;
			}
			set
			{
				this.m_MinVertexDistance = value;
			}
		}

		// Token: 0x17005F30 RID: 24368
		// (get) Token: 0x06018C68 RID: 101480 RVA: 0x003F6FF8 File Offset: 0x003F51F8
		// (set) Token: 0x06018C69 RID: 101481 RVA: 0x003F7000 File Offset: 0x003F5200
		public byte MotionVectors_C96
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

		// Token: 0x17005F31 RID: 24369
		// (get) Token: 0x06018C6A RID: 101482 RVA: 0x003F7009 File Offset: 0x003F5209
		public ILineParameters Parameters_C96
		{
			[return: NotNull]
			get
			{
				return this.m_Parameters;
			}
		}

		// Token: 0x17005F32 RID: 24370
		// (get) Token: 0x06018C6B RID: 101483 RVA: 0x003F7011 File Offset: 0x003F5211
		public PPtr_Prefab_2018_3_0 PrefabAsset_C96
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005F33 RID: 24371
		// (get) Token: 0x06018C6C RID: 101484 RVA: 0x003F7014 File Offset: 0x003F5214
		public PPtr_PrefabInstance PrefabInstance_C96
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005F34 RID: 24372
		// (get) Token: 0x06018C6D RID: 101485 RVA: 0x003F7017 File Offset: 0x003F5217
		public IPPtr_Prefab PrefabInternal_C96
		{
			[return: NotNull]
			get
			{
				return this.m_PrefabInternal;
			}
		}

		// Token: 0x17005F35 RID: 24373
		// (get) Token: 0x06018C6E RID: 101486 RVA: 0x003F701F File Offset: 0x003F521F
		// (set) Token: 0x06018C6F RID: 101487 RVA: 0x003F7027 File Offset: 0x003F5227
		public bool PreserveUVs_C96
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

		// Token: 0x17005F36 RID: 24374
		// (get) Token: 0x06018C70 RID: 101488 RVA: 0x003F7030 File Offset: 0x003F5230
		// (set) Token: 0x06018C71 RID: 101489 RVA: 0x003F7037 File Offset: 0x003F5237
		public float PreviewTimeScale_C96
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17005F37 RID: 24375
		// (get) Token: 0x06018C72 RID: 101490 RVA: 0x003F7039 File Offset: 0x003F5239
		public PPtr_Transform_5_0_0 ProbeAnchor_C96
		{
			[return: NotNull]
			get
			{
				return this.m_ProbeAnchor;
			}
		}

		// Token: 0x17005F38 RID: 24376
		// (get) Token: 0x06018C73 RID: 101491 RVA: 0x003F7041 File Offset: 0x003F5241
		// (set) Token: 0x06018C74 RID: 101492 RVA: 0x003F7044 File Offset: 0x003F5244
		public byte RayTraceProcedural_C96
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x17005F39 RID: 24377
		// (get) Token: 0x06018C75 RID: 101493 RVA: 0x003F7046 File Offset: 0x003F5246
		// (set) Token: 0x06018C76 RID: 101494 RVA: 0x003F7049 File Offset: 0x003F5249
		public byte RayTracingMode_C96
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x17005F3A RID: 24378
		// (get) Token: 0x06018C77 RID: 101495 RVA: 0x003F704B File Offset: 0x003F524B
		// (set) Token: 0x06018C78 RID: 101496 RVA: 0x003F704E File Offset: 0x003F524E
		public int ReceiveGI_C96
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x17005F3B RID: 24379
		// (get) Token: 0x06018C79 RID: 101497 RVA: 0x003F7050 File Offset: 0x003F5250
		// (set) Token: 0x06018C7A RID: 101498 RVA: 0x003F7053 File Offset: 0x003F5253
		public bool ReceiveShadows_C96_Boolean
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17005F3C RID: 24380
		// (get) Token: 0x06018C7B RID: 101499 RVA: 0x003F7055 File Offset: 0x003F5255
		// (set) Token: 0x06018C7C RID: 101500 RVA: 0x003F705D File Offset: 0x003F525D
		public byte ReceiveShadows_C96_Byte
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

		// Token: 0x17005F3D RID: 24381
		// (get) Token: 0x06018C7D RID: 101501 RVA: 0x003F7066 File Offset: 0x003F5266
		// (set) Token: 0x06018C7E RID: 101502 RVA: 0x003F7069 File Offset: 0x003F5269
		public int ReflectionProbeUsage_C96_Int32
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x17005F3E RID: 24382
		// (get) Token: 0x06018C7F RID: 101503 RVA: 0x003F706B File Offset: 0x003F526B
		// (set) Token: 0x06018C80 RID: 101504 RVA: 0x003F7073 File Offset: 0x003F5273
		public byte ReflectionProbeUsage_C96_Byte
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

		// Token: 0x17005F3F RID: 24383
		// (get) Token: 0x06018C81 RID: 101505 RVA: 0x003F707C File Offset: 0x003F527C
		// (set) Token: 0x06018C82 RID: 101506 RVA: 0x003F707F File Offset: 0x003F527F
		public int RendererPriority_C96
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x17005F40 RID: 24384
		// (get) Token: 0x06018C83 RID: 101507 RVA: 0x003F7081 File Offset: 0x003F5281
		// (set) Token: 0x06018C84 RID: 101508 RVA: 0x003F7084 File Offset: 0x003F5284
		public uint RenderingLayerMask_C96
		{
			get
			{
				return 0U;
			}
			set
			{
			}
		}

		// Token: 0x17005F41 RID: 24385
		// (get) Token: 0x06018C85 RID: 101509 RVA: 0x003F7086 File Offset: 0x003F5286
		// (set) Token: 0x06018C86 RID: 101510 RVA: 0x003F708E File Offset: 0x003F528E
		public float ScaleInLightmap_C96
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

		// Token: 0x17005F42 RID: 24386
		// (get) Token: 0x06018C87 RID: 101511 RVA: 0x003F7097 File Offset: 0x003F5297
		// (set) Token: 0x06018C88 RID: 101512 RVA: 0x003F709F File Offset: 0x003F529F
		public int SelectedEditorRenderState_C96
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

		// Token: 0x17005F43 RID: 24387
		// (get) Token: 0x06018C89 RID: 101513 RVA: 0x003F70A8 File Offset: 0x003F52A8
		// (set) Token: 0x06018C8A RID: 101514 RVA: 0x003F70AB File Offset: 0x003F52AB
		public bool SelectedWireframeHidden_C96
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17005F44 RID: 24388
		// (get) Token: 0x06018C8B RID: 101515 RVA: 0x003F70AD File Offset: 0x003F52AD
		// (set) Token: 0x06018C8C RID: 101516 RVA: 0x003F70B5 File Offset: 0x003F52B5
		public short SortingLayer_C96
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

		// Token: 0x17005F45 RID: 24389
		// (get) Token: 0x06018C8D RID: 101517 RVA: 0x003F70BE File Offset: 0x003F52BE
		// (set) Token: 0x06018C8E RID: 101518 RVA: 0x003F70C1 File Offset: 0x003F52C1
		public uint SortingLayerID_C96_UInt32
		{
			get
			{
				return 0U;
			}
			set
			{
			}
		}

		// Token: 0x17005F46 RID: 24390
		// (get) Token: 0x06018C8F RID: 101519 RVA: 0x003F70C3 File Offset: 0x003F52C3
		// (set) Token: 0x06018C90 RID: 101520 RVA: 0x003F70CB File Offset: 0x003F52CB
		public int SortingLayerID_C96_Int32
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

		// Token: 0x17005F47 RID: 24391
		// (get) Token: 0x06018C91 RID: 101521 RVA: 0x003F70D4 File Offset: 0x003F52D4
		// (set) Token: 0x06018C92 RID: 101522 RVA: 0x003F70DC File Offset: 0x003F52DC
		public short SortingOrder_C96
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

		// Token: 0x17005F48 RID: 24392
		// (get) Token: 0x06018C93 RID: 101523 RVA: 0x003F70E5 File Offset: 0x003F52E5
		// (set) Token: 0x06018C94 RID: 101524 RVA: 0x003F70EC File Offset: 0x003F52EC
		public float StartWidth_C96
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17005F49 RID: 24393
		// (get) Token: 0x06018C95 RID: 101525 RVA: 0x003F70EE File Offset: 0x003F52EE
		public StaticBatchInfo StaticBatchInfo_C96
		{
			[return: NotNull]
			get
			{
				return this.m_StaticBatchInfo;
			}
		}

		// Token: 0x17005F4A RID: 24394
		// (get) Token: 0x06018C96 RID: 101526 RVA: 0x003F70F6 File Offset: 0x003F52F6

		public IPPtr_Transform StaticBatchRoot_C96
		{

			get
			{
				return this.m_StaticBatchRoot;
			}
		}

		// Token: 0x17005F4B RID: 24395
		// (get) Token: 0x06018C97 RID: 101527 RVA: 0x003F70FE File Offset: 0x003F52FE
		// (set) Token: 0x06018C98 RID: 101528 RVA: 0x003F7101 File Offset: 0x003F5301
		public byte StaticShadowCaster_C96
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x17005F4C RID: 24396
		// (get) Token: 0x06018C99 RID: 101529 RVA: 0x003F7103 File Offset: 0x003F5303
		// (set) Token: 0x06018C9A RID: 101530 RVA: 0x003F7106 File Offset: 0x003F5306
		public bool StitchLightmapSeams_C96
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17005F4D RID: 24397
		// (get) Token: 0x06018C9B RID: 101531 RVA: 0x003F7108 File Offset: 0x003F5308
		// (set) Token: 0x06018C9C RID: 101532 RVA: 0x003F710B File Offset: 0x003F530B
		public bool StitchSeams_C96
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17005F4E RID: 24398
		// (get) Token: 0x06018C9D RID: 101533 RVA: 0x003F710D File Offset: 0x003F530D
		// (set) Token: 0x06018C9E RID: 101534 RVA: 0x003F7110 File Offset: 0x003F5310
		public uint[] SubsetIndices_C96
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x17005F4F RID: 24399
		// (get) Token: 0x06018C9F RID: 101535 RVA: 0x003F7112 File Offset: 0x003F5312
		// (set) Token: 0x06018CA0 RID: 101536 RVA: 0x003F711A File Offset: 0x003F531A
		public float Time_C96
		{
			get
			{
				return this.m_Time;
			}
			set
			{
				this.m_Time = value;
			}
		}

		// Token: 0x17005F50 RID: 24400
		// (get) Token: 0x06018CA1 RID: 101537 RVA: 0x003F7123 File Offset: 0x003F5323
		// (set) Token: 0x06018CA2 RID: 101538 RVA: 0x003F7126 File Offset: 0x003F5326
		public bool UseLightProbes_C96
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17005F51 RID: 24401
		// (get) Token: 0x06018CA3 RID: 101539 RVA: 0x003F7128 File Offset: 0x003F5328
		// (set) Token: 0x06018CA4 RID: 101540 RVA: 0x003F7130 File Offset: 0x003F5330
		public HideFlags HideFlags_C96E
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

		// Token: 0x17005F52 RID: 24402
		// (get) Token: 0x06018CA5 RID: 101541 RVA: 0x003F7139 File Offset: 0x003F5339
		// (set) Token: 0x06018CA6 RID: 101542 RVA: 0x003F7141 File Offset: 0x003F5341
		public LightProbeUsage LightProbeUsage_C96E
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

		// Token: 0x17005F53 RID: 24403
		// (get) Token: 0x06018CA7 RID: 101543 RVA: 0x003F714B File Offset: 0x003F534B
		// (set) Token: 0x06018CA8 RID: 101544 RVA: 0x003F714E File Offset: 0x003F534E
		public SpriteMaskInteraction MaskInteraction_C96E
		{
			get
			{
				return SpriteMaskInteraction.None;
			}
			set
			{
			}
		}

		// Token: 0x17005F54 RID: 24404
		// (get) Token: 0x06018CA9 RID: 101545 RVA: 0x003F7150 File Offset: 0x003F5350
		// (set) Token: 0x06018CAA RID: 101546 RVA: 0x003F7153 File Offset: 0x003F5353
		public RayTracingMode RayTracingMode_C96E
		{
			get
			{
				return RayTracingMode.Off;
			}
			set
			{
			}
		}

		// Token: 0x17005F55 RID: 24405
		// (get) Token: 0x06018CAB RID: 101547 RVA: 0x003F7155 File Offset: 0x003F5355
		// (set) Token: 0x06018CAC RID: 101548 RVA: 0x003F7158 File Offset: 0x003F5358
		public ReflectionProbeUsage ReflectionProbeUsage_C96_Int32E
		{
			get
			{
				return ReflectionProbeUsage.Off;
			}
			set
			{
			}
		}

		// Token: 0x17005F56 RID: 24406
		// (get) Token: 0x06018CAD RID: 101549 RVA: 0x003F715A File Offset: 0x003F535A
		// (set) Token: 0x06018CAE RID: 101550 RVA: 0x003F7162 File Offset: 0x003F5362
		public ReflectionProbeUsage ReflectionProbeUsage_C96_ByteE
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

		// Token: 0x17005F57 RID: 24407
		// (get) Token: 0x06018CAF RID: 101551 RVA: 0x003F716C File Offset: 0x003F536C
		// (set) Token: 0x06018CB0 RID: 101552 RVA: 0x003F717F File Offset: 0x003F537F
		public IEditorExtension CorrespondingSourceObject_C96P
		{
			get
			{
				return PPtrExtensions.TryGetAsset<IEditorExtension>(this.CorrespondingSourceObject_C96, base.Collection);
			}
			set
			{
				PPtrExtensions.SetAsset<IEditorExtension>(this.CorrespondingSourceObject_C96, base.Collection, value);
			}
		}

		// Token: 0x17005F58 RID: 24408
		// (get) Token: 0x06018CB1 RID: 101553 RVA: 0x003F7193 File Offset: 0x003F5393
		// (set) Token: 0x06018CB2 RID: 101554 RVA: 0x003F7196 File Offset: 0x003F5396
		public IEditorExtensionImpl ExtensionPtr_C96P
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x17005F59 RID: 24409
		// (get) Token: 0x06018CB3 RID: 101555 RVA: 0x003F7198 File Offset: 0x003F5398
		// (set) Token: 0x06018CB4 RID: 101556 RVA: 0x003F71AB File Offset: 0x003F53AB
		public IGameObject GameObject_C96P
		{
			get
			{
				return PPtrExtensions.TryGetAsset<IGameObject>(this.GameObject_C96, base.Collection);
			}
			set
			{
				PPtrExtensions.SetAsset<IGameObject>(this.GameObject_C96, base.Collection, value);
			}
		}

		// Token: 0x17005F5A RID: 24410
		// (get) Token: 0x06018CB5 RID: 101557 RVA: 0x003F71BF File Offset: 0x003F53BF
		// (set) Token: 0x06018CB6 RID: 101558 RVA: 0x003F71D2 File Offset: 0x003F53D2
		public ILightmapParameters LightmapParameters_C96P
		{
			get
			{
				return PPtrExtensions.TryGetAsset<ILightmapParameters>(this.LightmapParameters_C96, base.Collection);
			}
			set
			{
				PPtrExtensions.SetAsset<ILightmapParameters>(this.LightmapParameters_C96, base.Collection, value);
			}
		}

		// Token: 0x17005F5B RID: 24411
		// (get) Token: 0x06018CB7 RID: 101559 RVA: 0x003F71E6 File Offset: 0x003F53E6
		// (set) Token: 0x06018CB8 RID: 101560 RVA: 0x003F71E9 File Offset: 0x003F53E9
		public ITransform LightProbeAnchor_C96P
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x17005F5C RID: 24412
		// (get) Token: 0x06018CB9 RID: 101561 RVA: 0x003F71EB File Offset: 0x003F53EB
		// (set) Token: 0x06018CBA RID: 101562 RVA: 0x003F71FE File Offset: 0x003F53FE
		public IGameObject LightProbeVolumeOverride_C96P
		{
			get
			{
				return PPtrExtensions.TryGetAsset<IGameObject>(this.LightProbeVolumeOverride_C96, base.Collection);
			}
			set
			{
				PPtrExtensions.SetAsset<IGameObject>(this.LightProbeVolumeOverride_C96, base.Collection, value);
			}
		}

		// Token: 0x17005F5D RID: 24413
		// (get) Token: 0x06018CBB RID: 101563 RVA: 0x003F7212 File Offset: 0x003F5412

		public PPtrAccessList<IPPtr_Material, IMaterial> Materials_C96P
		{

			get
			{
				return new PPtrAccessList<IPPtr_Material, IMaterial>(this.Materials_C96, this);
			}
		}

		// Token: 0x17005F5E RID: 24414
		// (get) Token: 0x06018CBC RID: 101564 RVA: 0x003F7220 File Offset: 0x003F5420
		// (set) Token: 0x06018CBD RID: 101565 RVA: 0x003F7223 File Offset: 0x003F5423
		public IPrefab PrefabAsset_C96P
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x17005F5F RID: 24415
		// (get) Token: 0x06018CBE RID: 101566 RVA: 0x003F7225 File Offset: 0x003F5425
		// (set) Token: 0x06018CBF RID: 101567 RVA: 0x003F7228 File Offset: 0x003F5428
		public IPrefabInstance PrefabInstance_C96P
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x17005F60 RID: 24416
		// (get) Token: 0x06018CC0 RID: 101568 RVA: 0x003F722A File Offset: 0x003F542A
		// (set) Token: 0x06018CC1 RID: 101569 RVA: 0x003F723D File Offset: 0x003F543D
		public IPrefabMarker PrefabInternal_C96P
		{
			get
			{
				return PPtrExtensions.TryGetAsset<IPrefabMarker>(this.PrefabInternal_C96, base.Collection);
			}
			set
			{
				PPtrExtensions.SetAsset<IPrefabMarker>(this.PrefabInternal_C96, base.Collection, value);
			}
		}

		// Token: 0x17005F61 RID: 24417
		// (get) Token: 0x06018CC2 RID: 101570 RVA: 0x003F7251 File Offset: 0x003F5451
		// (set) Token: 0x06018CC3 RID: 101571 RVA: 0x003F7264 File Offset: 0x003F5464
		public ITransform ProbeAnchor_C96P
		{
			get
			{
				return PPtrExtensions.TryGetAsset<ITransform>(this.ProbeAnchor_C96, base.Collection);
			}
			set
			{
				PPtrExtensions.SetAsset<ITransform>(this.ProbeAnchor_C96, base.Collection, value);
			}
		}

		// Token: 0x17005F62 RID: 24418
		// (get) Token: 0x06018CC4 RID: 101572 RVA: 0x003F7278 File Offset: 0x003F5478
		// (set) Token: 0x06018CC5 RID: 101573 RVA: 0x003F728B File Offset: 0x003F548B
		public ITransform StaticBatchRoot_C96P
		{
			get
			{
				return PPtrExtensions.TryGetAsset<ITransform>(this.StaticBatchRoot_C96, base.Collection);
			}
			set
			{
				PPtrExtensions.SetAsset<ITransform>(this.StaticBatchRoot_C96, base.Collection, value);
			}
		}

		// Token: 0x17005F63 RID: 24419
		// (get) Token: 0x06018CC6 RID: 101574 RVA: 0x003F729F File Offset: 0x003F549F

		public override string ClassName
		{

			get
			{
				return "TrailRenderer";
			}
		}

		// Token: 0x06018CC7 RID: 101575 RVA: 0x003F72A6 File Offset: 0x003F54A6
		public TrailRenderer_2017_1_0_GICB2()
			: this(AssetInfo.MakeDummyAssetInfo(96))
		{
		}

		// Token: 0x06018CC8 RID: 101576 RVA: 0x003F72B5 File Offset: 0x003F54B5
		public TrailRenderer_2017_1_0_GICB2(AssetInfo info)
			: base(info)
		{
			this.m_Parameters = new LineParameters_2017_1_0_GICB2();
		}

		// Token: 0x06018CC9 RID: 101577 RVA: 0x003F72C9 File Offset: 0x003F54C9
		public bool Has_ApplyActiveColorSpace_C96()
		{
			return false;
		}

		// Token: 0x06018CCA RID: 101578 RVA: 0x003F72CC File Offset: 0x003F54CC
		public bool Has_AutoUVMaxAngle_C96()
		{
			return true;
		}

		// Token: 0x06018CCB RID: 101579 RVA: 0x003F72CF File Offset: 0x003F54CF
		public bool Has_AutoUVMaxDistance_C96()
		{
			return true;
		}

		// Token: 0x06018CCC RID: 101580 RVA: 0x003F72D2 File Offset: 0x003F54D2
		public bool Has_CastShadows_C96_Boolean()
		{
			return false;
		}

		// Token: 0x06018CCD RID: 101581 RVA: 0x003F72D5 File Offset: 0x003F54D5
		public bool Has_CastShadows_C96_Byte()
		{
			return true;
		}

		// Token: 0x06018CCE RID: 101582 RVA: 0x003F72D8 File Offset: 0x003F54D8
		public bool Has_Colors_C96()
		{
			return false;
		}

		// Token: 0x06018CCF RID: 101583 RVA: 0x003F72DB File Offset: 0x003F54DB
		public bool Has_CorrespondingSourceObject_C96()
		{
			return true;
		}

		// Token: 0x06018CD0 RID: 101584 RVA: 0x003F72DE File Offset: 0x003F54DE
		public bool Has_DynamicOccludee_C96()
		{
			return false;
		}

		// Token: 0x06018CD1 RID: 101585 RVA: 0x003F72E1 File Offset: 0x003F54E1
		public bool Has_Emitting_C96()
		{
			return false;
		}

		// Token: 0x06018CD2 RID: 101586 RVA: 0x003F72E4 File Offset: 0x003F54E4
		public bool Has_EndWidth_C96()
		{
			return false;
		}

		// Token: 0x06018CD3 RID: 101587 RVA: 0x003F72E7 File Offset: 0x003F54E7
		public bool Has_ExtensionPtr_C96()
		{
			return false;
		}

		// Token: 0x06018CD4 RID: 101588 RVA: 0x003F72EA File Offset: 0x003F54EA
		public bool Has_IgnoreNormalsForChartDetection_C96()
		{
			return true;
		}

		// Token: 0x06018CD5 RID: 101589 RVA: 0x003F72ED File Offset: 0x003F54ED
		public bool Has_ImportantGI_C96()
		{
			return true;
		}

		// Token: 0x06018CD6 RID: 101590 RVA: 0x003F72F0 File Offset: 0x003F54F0
		public bool Has_LightmapIndex_C96_Byte()
		{
			return false;
		}

		// Token: 0x06018CD7 RID: 101591 RVA: 0x003F72F3 File Offset: 0x003F54F3
		public bool Has_LightmapIndex_C96_UInt16()
		{
			return true;
		}

		// Token: 0x06018CD8 RID: 101592 RVA: 0x003F72F6 File Offset: 0x003F54F6
		public bool Has_LightmapIndexDynamic_C96()
		{
			return true;
		}

		// Token: 0x06018CD9 RID: 101593 RVA: 0x003F72F9 File Offset: 0x003F54F9
		public bool Has_LightmapParameters_C96()
		{
			return true;
		}

		// Token: 0x06018CDA RID: 101594 RVA: 0x003F72FC File Offset: 0x003F54FC
		public bool Has_LightmapTilingOffsetDynamic_C96()
		{
			return true;
		}

		// Token: 0x06018CDB RID: 101595 RVA: 0x003F72FF File Offset: 0x003F54FF
		public bool Has_LightProbeAnchor_C96()
		{
			return false;
		}

		// Token: 0x06018CDC RID: 101596 RVA: 0x003F7302 File Offset: 0x003F5502
		public bool Has_LightProbeUsage_C96()
		{
			return true;
		}

		// Token: 0x06018CDD RID: 101597 RVA: 0x003F7305 File Offset: 0x003F5505
		public bool Has_LightProbeVolumeOverride_C96()
		{
			return true;
		}

		// Token: 0x06018CDE RID: 101598 RVA: 0x003F7308 File Offset: 0x003F5508
		public bool Has_MaskInteraction_C96()
		{
			return false;
		}

		// Token: 0x06018CDF RID: 101599 RVA: 0x003F730B File Offset: 0x003F550B
		public bool Has_MinimumChartSize_C96()
		{
			return true;
		}

		// Token: 0x06018CE0 RID: 101600 RVA: 0x003F730E File Offset: 0x003F550E
		public bool Has_MotionVectors_C96()
		{
			return true;
		}

		// Token: 0x06018CE1 RID: 101601 RVA: 0x003F7311 File Offset: 0x003F5511
		public bool Has_Parameters_C96()
		{
			return true;
		}

		// Token: 0x06018CE2 RID: 101602 RVA: 0x003F7314 File Offset: 0x003F5514
		public bool Has_PrefabAsset_C96()
		{
			return false;
		}

		// Token: 0x06018CE3 RID: 101603 RVA: 0x003F7317 File Offset: 0x003F5517
		public bool Has_PrefabInstance_C96()
		{
			return false;
		}

		// Token: 0x06018CE4 RID: 101604 RVA: 0x003F731A File Offset: 0x003F551A
		public bool Has_PrefabInternal_C96()
		{
			return true;
		}

		// Token: 0x06018CE5 RID: 101605 RVA: 0x003F731D File Offset: 0x003F551D
		public bool Has_PreserveUVs_C96()
		{
			return true;
		}

		// Token: 0x06018CE6 RID: 101606 RVA: 0x003F7320 File Offset: 0x003F5520
		public bool Has_PreviewTimeScale_C96()
		{
			return false;
		}

		// Token: 0x06018CE7 RID: 101607 RVA: 0x003F7323 File Offset: 0x003F5523
		public bool Has_ProbeAnchor_C96()
		{
			return true;
		}

		// Token: 0x06018CE8 RID: 101608 RVA: 0x003F7326 File Offset: 0x003F5526
		public bool Has_RayTraceProcedural_C96()
		{
			return false;
		}

		// Token: 0x06018CE9 RID: 101609 RVA: 0x003F7329 File Offset: 0x003F5529
		public bool Has_RayTracingMode_C96()
		{
			return false;
		}

		// Token: 0x06018CEA RID: 101610 RVA: 0x003F732C File Offset: 0x003F552C
		public bool Has_ReceiveGI_C96()
		{
			return false;
		}

		// Token: 0x06018CEB RID: 101611 RVA: 0x003F732F File Offset: 0x003F552F
		public bool Has_ReceiveShadows_C96_Boolean()
		{
			return false;
		}

		// Token: 0x06018CEC RID: 101612 RVA: 0x003F7332 File Offset: 0x003F5532
		public bool Has_ReceiveShadows_C96_Byte()
		{
			return true;
		}

		// Token: 0x06018CED RID: 101613 RVA: 0x003F7335 File Offset: 0x003F5535
		public bool Has_ReflectionProbeUsage_C96_Int32()
		{
			return false;
		}

		// Token: 0x06018CEE RID: 101614 RVA: 0x003F7338 File Offset: 0x003F5538
		public bool Has_ReflectionProbeUsage_C96_Byte()
		{
			return true;
		}

		// Token: 0x06018CEF RID: 101615 RVA: 0x003F733B File Offset: 0x003F553B
		public bool Has_RendererPriority_C96()
		{
			return false;
		}

		// Token: 0x06018CF0 RID: 101616 RVA: 0x003F733E File Offset: 0x003F553E
		public bool Has_RenderingLayerMask_C96()
		{
			return false;
		}

		// Token: 0x06018CF1 RID: 101617 RVA: 0x003F7341 File Offset: 0x003F5541
		public bool Has_SelectedEditorRenderState_C96()
		{
			return true;
		}

		// Token: 0x06018CF2 RID: 101618 RVA: 0x003F7344 File Offset: 0x003F5544
		public bool Has_SelectedWireframeHidden_C96()
		{
			return false;
		}

		// Token: 0x06018CF3 RID: 101619 RVA: 0x003F7347 File Offset: 0x003F5547
		public bool Has_SortingLayer_C96()
		{
			return true;
		}

		// Token: 0x06018CF4 RID: 101620 RVA: 0x003F734A File Offset: 0x003F554A
		public bool Has_SortingLayerID_C96_UInt32()
		{
			return false;
		}

		// Token: 0x06018CF5 RID: 101621 RVA: 0x003F734D File Offset: 0x003F554D
		public bool Has_SortingLayerID_C96_Int32()
		{
			return true;
		}

		// Token: 0x06018CF6 RID: 101622 RVA: 0x003F7350 File Offset: 0x003F5550
		public bool Has_SortingOrder_C96()
		{
			return true;
		}

		// Token: 0x06018CF7 RID: 101623 RVA: 0x003F7353 File Offset: 0x003F5553
		public bool Has_StartWidth_C96()
		{
			return false;
		}

		// Token: 0x06018CF8 RID: 101624 RVA: 0x003F7356 File Offset: 0x003F5556
		public bool Has_StaticBatchInfo_C96()
		{
			return true;
		}

		// Token: 0x06018CF9 RID: 101625 RVA: 0x003F7359 File Offset: 0x003F5559
		public bool Has_StaticShadowCaster_C96()
		{
			return false;
		}

		// Token: 0x06018CFA RID: 101626 RVA: 0x003F735C File Offset: 0x003F555C
		public bool Has_StitchLightmapSeams_C96()
		{
			return false;
		}

		// Token: 0x06018CFB RID: 101627 RVA: 0x003F735F File Offset: 0x003F555F
		public bool Has_StitchSeams_C96()
		{
			return false;
		}

		// Token: 0x06018CFC RID: 101628 RVA: 0x003F7362 File Offset: 0x003F5562
		public bool Has_SubsetIndices_C96()
		{
			return false;
		}

		// Token: 0x06018CFD RID: 101629 RVA: 0x003F7365 File Offset: 0x003F5565
		public bool Has_UseLightProbes_C96()
		{
			return false;
		}

		// Token: 0x06018CFE RID: 101630 RVA: 0x003F7368 File Offset: 0x003F5568

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

			this.m_Time = reader.ReadSingle();
			this.m_Parameters.ReadRelease(reader);
			this.m_MinVertexDistance = reader.ReadSingle();
			this.m_Autodestruct = reader.ReadBoolean();
		}

		// Token: 0x06018CFF RID: 101631 RVA: 0x003F748C File Offset: 0x003F568C



		// Token: 0x06018D00 RID: 101632 RVA: 0x003F7610 File Offset: 0x003F5810

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
			this.m_Time.WriteRelease_Single(writer);
			this.m_Parameters.WriteRelease(writer);
			this.m_MinVertexDistance.WriteRelease_Single(writer);
			this.m_Autodestruct.WriteRelease_Boolean(writer);
		}

		// Token: 0x06018D01 RID: 101633 RVA: 0x003F7734 File Offset: 0x003F5934



		// Token: 0x06018D02 RID: 101634 RVA: 0x003F78B8 File Offset: 0x003F5AB8

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
			yamlMappingNode.Add(new YamlScalarNode("m_Time"), this.m_Time.ExportYamlRelease_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Parameters"), this.m_Parameters.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("m_MinVertexDistance"), this.m_MinVertexDistance.ExportYamlRelease_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Autodestruct"), this.m_Autodestruct.ExportYamlRelease_Boolean(container));
			return yamlMappingNode;
		}

		// Token: 0x06018D03 RID: 101635 RVA: 0x003F7B58 File Offset: 0x003F5D58

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
			yamlMappingNode.Add(new YamlScalarNode("m_Time"), this.m_Time.ExportYamlEditor_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Parameters"), this.m_Parameters.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_MinVertexDistance"), this.m_MinVertexDistance.ExportYamlEditor_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Autodestruct"), this.m_Autodestruct.ExportYamlEditor_Boolean(container));
			return yamlMappingNode;
		}

		// Token: 0x06018D04 RID: 101636 RVA: 0x003F7ED8 File Offset: 0x003F60D8
		public override void Reset()
		{
			this.m_Autodestruct = false;
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
			this.m_MinVertexDistance = 0f;
			this.m_MotionVectors = 0;
			this.m_Parameters.Reset();
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
			this.m_Time = 0f;
		}

		// Token: 0x06018D05 RID: 101637 RVA: 0x003F801E File Offset: 0x003F621E



		// Token: 0x06018D06 RID: 101638 RVA: 0x003F802C File Offset: 0x003F622C

		public void CopyValues(ITrailRenderer source, PPtrConverter converter)
		{
			this.m_Autodestruct = source.Autodestruct_C96;
			this.m_AutoUVMaxAngle = source.AutoUVMaxAngle_C96;
			this.m_AutoUVMaxDistance = source.AutoUVMaxDistance_C96;
			this.m_CastShadows = source.CastShadows_C96_Byte;
			this.m_CorrespondingSourceObject.CopyValues(source.CorrespondingSourceObject_C96, converter);
			this.m_Enabled = source.Enabled_C96;
			this.m_GameObject.CopyValues(source.GameObject_C96, converter);
			this.m_HideFlags = source.HideFlags_C96;
			this.m_IgnoreNormalsForChartDetection = source.IgnoreNormalsForChartDetection_C96;
			this.m_ImportantGI = source.ImportantGI_C96;
			this.m_LightmapIndex = source.LightmapIndex_C96_UInt16;
			this.m_LightmapIndexDynamic = source.LightmapIndexDynamic_C96;
			this.m_LightmapParameters.CopyValues(source.LightmapParameters_C96, converter);
			this.m_LightmapTilingOffset.CopyValues(source.LightmapTilingOffset_C96);
			this.m_LightmapTilingOffsetDynamic.CopyValues(source.LightmapTilingOffsetDynamic_C96);
			this.m_LightProbeUsage = source.LightProbeUsage_C96;
			this.m_LightProbeVolumeOverride.CopyValues(source.LightProbeVolumeOverride_C96, converter);
			CopyValuesHelper.CopyValues__AssetList_PPtr_Material_5_0_0__AccessListBase_IPPtr_Material(this.m_Materials, source.Materials_C96, converter);
			this.m_MinimumChartSize = source.MinimumChartSize_C96;
			this.m_MinVertexDistance = source.MinVertexDistance_C96;
			this.m_MotionVectors = source.MotionVectors_C96;
			this.m_Parameters.CopyValues(source.Parameters_C96);
			this.m_PrefabInternal.CopyValues(source.PrefabInternal_C96, converter);
			this.m_PreserveUVs = source.PreserveUVs_C96;
			this.m_ProbeAnchor.CopyValues(source.ProbeAnchor_C96, converter);
			this.m_ReceiveShadows = source.ReceiveShadows_C96_Byte;
			this.m_ReflectionProbeUsage = source.ReflectionProbeUsage_C96_Byte;
			this.m_ScaleInLightmap = source.ScaleInLightmap_C96;
			this.m_SelectedEditorRenderState = source.SelectedEditorRenderState_C96;
			this.m_SortingLayer = source.SortingLayer_C96;
			this.m_SortingLayerID = source.SortingLayerID_C96_Int32;
			this.m_SortingOrder = source.SortingOrder_C96;
			this.m_StaticBatchInfo.CopyValues(source.StaticBatchInfo_C96);
			this.m_StaticBatchRoot.CopyValues(source.StaticBatchRoot_C96, converter);
			this.m_Time = source.Time_C96;
		}

		// Token: 0x06018D07 RID: 101639 RVA: 0x003F8221 File Offset: 0x003F6421

		public void CopyValues(ITrailRenderer source)
		{
			this.CopyValues(source, new PPtrConverter(source, this));
		}

		// Token: 0x06018D08 RID: 101640 RVA: 0x003F8234 File Offset: 0x003F6434
		public override void CopyValues(IUnityAssetBase source, PPtrConverter converter)
		{
			ITrailRenderer trailRenderer = source as ITrailRenderer;
			if (trailRenderer != null)
			{
				this.CopyValues(trailRenderer, converter);
				return;
			}
			base.CopyValues(source, converter);
		}

		// Token: 0x06018D09 RID: 101641 RVA: 0x003F825C File Offset: 0x003F645C

		public override List<TypeTreeNode> MakeEditorTypeTreeNodes(int depth, int startingIndex)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06018D0A RID: 101642 RVA: 0x003F8263 File Offset: 0x003F6463

		public override List<TypeTreeNode> MakeReleaseTypeTreeNodes(int depth, int startingIndex)
		{
			throw new NotSupportedException();
		}

		// Token: 0x04010B1B RID: 68379
		public float m_Time;

		// Token: 0x04010B1C RID: 68380

		public LineParameters_2017_1_0_GICB2 m_Parameters;

		// Token: 0x04010B1D RID: 68381
		public float m_MinVertexDistance;

		// Token: 0x04010B1E RID: 68382
		public bool m_Autodestruct;
	}
}
