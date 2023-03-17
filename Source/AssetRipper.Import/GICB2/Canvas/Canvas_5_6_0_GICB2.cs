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
using AssetRipper.SourceGenerated.Classes.ClassID_18;
using AssetRipper.SourceGenerated.Classes.ClassID_2;
using AssetRipper.SourceGenerated.Classes.ClassID_20;
using AssetRipper.SourceGenerated.Classes.ClassID_8;
using AssetRipper.SourceGenerated.Enums;
using AssetRipper.SourceGenerated.Helpers;
using AssetRipper.SourceGenerated.Interfaces;
using AssetRipper.SourceGenerated.MarkerInterfaces;
using AssetRipper.SourceGenerated.Subclasses.PPtr_Camera;
using AssetRipper.SourceGenerated.Subclasses.PPtr_EditorExtension;
using AssetRipper.SourceGenerated.Subclasses.PPtr_GameObject;
using AssetRipper.SourceGenerated.Subclasses.PPtr_PrefabInstance;
using AssetRipper.SourceGenerated.Subclasses.PPtr_Prefab;
using AssetRipper.Yaml;
using AssetRipper.SourceGenerated.Classes.ClassID_223;

namespace AssetRipper.Import.GICB2.Canvas
{
	// Token: 0x02002BCF RID: 11215


	public sealed class Canvas_5_6_0_GICB2 : Behaviour_5_5_0, ICanvas, IUnityObjectBase, IUnityAssetBase, IAsset, IAssetReadable, IAssetWritable, IYamlExportable, IDependent, ITypeTreeSerializable, ICanvasMarker, IBehaviour, IBehaviourMarker, IComponent, IEditorExtension, IEditorExtensionMarker, IObject, IObjectMarker, IHasHideFlags, IComponentMarker, IHasEnabled
	{
		// Token: 0x17011E51 RID: 73297
		// (get) Token: 0x06036BEB RID: 224235 RVA: 0x00753BF2 File Offset: 0x00751DF2
		// (set) Token: 0x06036BEC RID: 224236 RVA: 0x00753BFA File Offset: 0x00751DFA
		public int AdditionalShaderChannelsFlag_C223
		{
			get
			{
				return this.m_AdditionalShaderChannelsFlag;
			}
			set
			{
				this.m_AdditionalShaderChannelsFlag = value;
			}
		}

		// Token: 0x17011E52 RID: 73298
		// (get) Token: 0x06036BED RID: 224237 RVA: 0x00753C03 File Offset: 0x00751E03
		// (set) Token: 0x06036BEE RID: 224238 RVA: 0x00753C0A File Offset: 0x00751E0A
		public float Alpha_C223
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17011E53 RID: 73299
		// (get) Token: 0x06036BEF RID: 224239 RVA: 0x00753C0C File Offset: 0x00751E0C

		public IPPtr_Camera Camera_C223
		{

			get
			{
				return this.m_Camera;
			}
		}

		// Token: 0x17011E54 RID: 73300
		// (get) Token: 0x06036BF0 RID: 224240 RVA: 0x00753C14 File Offset: 0x00751E14

		public IPPtr_EditorExtension CorrespondingSourceObject_C223
		{

			get
			{
				return this.m_CorrespondingSourceObject;
			}
		}

		// Token: 0x17011E55 RID: 73301
		// (get) Token: 0x06036BF1 RID: 224241 RVA: 0x00753C1C File Offset: 0x00751E1C
		// (set) Token: 0x06036BF2 RID: 224242 RVA: 0x00753C24 File Offset: 0x00751E24
		public byte Enabled_C223
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

		// Token: 0x17011E56 RID: 73302
		// (get) Token: 0x06036BF3 RID: 224243 RVA: 0x00753C2D File Offset: 0x00751E2D

		public IPPtr_GameObject GameObject_C223
		{

			get
			{
				return this.m_GameObject;
			}
		}

		// Token: 0x17011E57 RID: 73303
		// (get) Token: 0x06036BF4 RID: 224244 RVA: 0x00753C35 File Offset: 0x00751E35
		// (set) Token: 0x06036BF5 RID: 224245 RVA: 0x00753C3D File Offset: 0x00751E3D
		public uint HideFlags_C223
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

		// Token: 0x17011E58 RID: 73304
		// (get) Token: 0x06036BF6 RID: 224246 RVA: 0x00753C46 File Offset: 0x00751E46
		// (set) Token: 0x06036BF7 RID: 224247 RVA: 0x00753C49 File Offset: 0x00751E49
		public bool Normals_C223
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17011E59 RID: 73305
		// (get) Token: 0x06036BF8 RID: 224248 RVA: 0x00753C4B File Offset: 0x00751E4B
		// (set) Token: 0x06036BF9 RID: 224249 RVA: 0x00753C53 File Offset: 0x00751E53
		public bool OverridePixelPerfect_C223
		{
			get
			{
				return this.m_OverridePixelPerfect;
			}
			set
			{
				this.m_OverridePixelPerfect = value;
			}
		}

		// Token: 0x17011E5A RID: 73306
		// (get) Token: 0x06036BFA RID: 224250 RVA: 0x00753C5C File Offset: 0x00751E5C
		// (set) Token: 0x06036BFB RID: 224251 RVA: 0x00753C64 File Offset: 0x00751E64
		public bool OverrideSorting_C223
		{
			get
			{
				return this.m_OverrideSorting;
			}
			set
			{
				this.m_OverrideSorting = value;
			}
		}

		// Token: 0x17011E5B RID: 73307
		// (get) Token: 0x06036BFC RID: 224252 RVA: 0x00753C6D File Offset: 0x00751E6D
		// (set) Token: 0x06036BFD RID: 224253 RVA: 0x00753C75 File Offset: 0x00751E75
		public bool PixelPerfect_C223
		{
			get
			{
				return this.m_PixelPerfect;
			}
			set
			{
				this.m_PixelPerfect = value;
			}
		}

		// Token: 0x17011E5C RID: 73308
		// (get) Token: 0x06036BFE RID: 224254 RVA: 0x00753C7E File Offset: 0x00751E7E
		// (set) Token: 0x06036BFF RID: 224255 RVA: 0x00753C86 File Offset: 0x00751E86
		public float PlaneDistance_C223
		{
			get
			{
				return this.m_PlaneDistance;
			}
			set
			{
				this.m_PlaneDistance = value;
			}
		}

		// Token: 0x17011E5D RID: 73309
		// (get) Token: 0x06036C00 RID: 224256 RVA: 0x00753C8F File Offset: 0x00751E8F
		// (set) Token: 0x06036C01 RID: 224257 RVA: 0x00753C92 File Offset: 0x00751E92
		public bool PositionUVs_C223
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17011E5E RID: 73310
		// (get) Token: 0x06036C02 RID: 224258 RVA: 0x00753C94 File Offset: 0x00751E94
		public PPtr_Prefab_2018_3_0 PrefabAsset_C223
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17011E5F RID: 73311
		// (get) Token: 0x06036C03 RID: 224259 RVA: 0x00753C97 File Offset: 0x00751E97
		public PPtr_PrefabInstance PrefabInstance_C223
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17011E60 RID: 73312
		// (get) Token: 0x06036C04 RID: 224260 RVA: 0x00753C9A File Offset: 0x00751E9A
		public IPPtr_Prefab PrefabInternal_C223
		{
			[return: NotNull]
			get
			{
				return this.m_PrefabInternal;
			}
		}

		// Token: 0x17011E61 RID: 73313
		// (get) Token: 0x06036C05 RID: 224261 RVA: 0x00753CA2 File Offset: 0x00751EA2
		// (set) Token: 0x06036C06 RID: 224262 RVA: 0x00753CAA File Offset: 0x00751EAA
		public bool ReceivesEvents_C223
		{
			get
			{
				return this.m_ReceivesEvents;
			}
			set
			{
				this.m_ReceivesEvents = value;
			}
		}

		// Token: 0x17011E62 RID: 73314
		// (get) Token: 0x06036C07 RID: 224263 RVA: 0x00753CB3 File Offset: 0x00751EB3
		// (set) Token: 0x06036C08 RID: 224264 RVA: 0x00753CBB File Offset: 0x00751EBB
		public int RenderMode_C223
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

		// Token: 0x17011E63 RID: 73315
		// (get) Token: 0x06036C09 RID: 224265 RVA: 0x00753CC4 File Offset: 0x00751EC4
		// (set) Token: 0x06036C0A RID: 224266 RVA: 0x00753CCC File Offset: 0x00751ECC
		public float SortingBucketNormalizedSize_C223
		{
			get
			{
				return this.m_SortingBucketNormalizedSize;
			}
			set
			{
				this.m_SortingBucketNormalizedSize = value;
			}
		}

		// Token: 0x17011E64 RID: 73316
		// (get) Token: 0x06036C0B RID: 224267 RVA: 0x00753CD5 File Offset: 0x00751ED5
		// (set) Token: 0x06036C0C RID: 224268 RVA: 0x00753CD8 File Offset: 0x00751ED8
		public uint SortingLayerID_C223_UInt32
		{
			get
			{
				return 0U;
			}
			set
			{
			}
		}

		// Token: 0x17011E65 RID: 73317
		// (get) Token: 0x06036C0D RID: 224269 RVA: 0x00753CDA File Offset: 0x00751EDA
		// (set) Token: 0x06036C0E RID: 224270 RVA: 0x00753CE2 File Offset: 0x00751EE2
		public int SortingLayerID_C223_Int32
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

		// Token: 0x17011E66 RID: 73318
		// (get) Token: 0x06036C0F RID: 224271 RVA: 0x00753CEB File Offset: 0x00751EEB
		// (set) Token: 0x06036C10 RID: 224272 RVA: 0x00753CF3 File Offset: 0x00751EF3
		public short SortingOrder_C223
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

		// Token: 0x17011E67 RID: 73319
		// (get) Token: 0x06036C11 RID: 224273 RVA: 0x00753CFC File Offset: 0x00751EFC
		// (set) Token: 0x06036C12 RID: 224274 RVA: 0x00753D04 File Offset: 0x00751F04
		public sbyte TargetDisplay_C223
		{
			get
			{
				return this.m_TargetDisplay;
			}
			set
			{
				this.m_TargetDisplay = value;
			}
		}

		// Token: 0x17011E68 RID: 73320
		// (get) Token: 0x06036C13 RID: 224275 RVA: 0x00753D0D File Offset: 0x00751F0D
		// (set) Token: 0x06036C14 RID: 224276 RVA: 0x00753D10 File Offset: 0x00751F10
		public int UpdateRectTransformForStandalone_C223
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x17011E69 RID: 73321
		// (get) Token: 0x06036C15 RID: 224277 RVA: 0x00753D12 File Offset: 0x00751F12
		// (set) Token: 0x06036C16 RID: 224278 RVA: 0x00753D1A File Offset: 0x00751F1A
		public HideFlags HideFlags_C223E
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

		// Token: 0x17011E6A RID: 73322
		// (get) Token: 0x06036C17 RID: 224279 RVA: 0x00753D23 File Offset: 0x00751F23
		// (set) Token: 0x06036C18 RID: 224280 RVA: 0x00753D2B File Offset: 0x00751F2B
		public RenderMode_2 RenderMode_C223E
		{
			get
			{
				return (RenderMode_2)this.m_RenderMode;
			}
			set
			{
				this.m_RenderMode = (int)value;
			}
		}

		// Token: 0x17011E6B RID: 73323
		// (get) Token: 0x06036C19 RID: 224281 RVA: 0x00753D34 File Offset: 0x00751F34
		// (set) Token: 0x06036C1A RID: 224282 RVA: 0x00753D37 File Offset: 0x00751F37
		public StandaloneRenderResize UpdateRectTransformForStandalone_C223E
		{
			get
			{
				return StandaloneRenderResize.Enabled;
			}
			set
			{
			}
		}

		// Token: 0x17011E6C RID: 73324
		// (get) Token: 0x06036C1B RID: 224283 RVA: 0x00753D39 File Offset: 0x00751F39
		// (set) Token: 0x06036C1C RID: 224284 RVA: 0x00753D4C File Offset: 0x00751F4C
		public ICamera Camera_C223P
		{
			get
			{
				return PPtrExtensions.TryGetAsset<ICamera>(this.Camera_C223, base.Collection);
			}
			set
			{
				PPtrExtensions.SetAsset<ICamera>(this.Camera_C223, base.Collection, value);
			}
		}

		// Token: 0x17011E6D RID: 73325
		// (get) Token: 0x06036C1D RID: 224285 RVA: 0x00753D60 File Offset: 0x00751F60
		// (set) Token: 0x06036C1E RID: 224286 RVA: 0x00753D73 File Offset: 0x00751F73
		public IEditorExtension CorrespondingSourceObject_C223P
		{
			get
			{
				return PPtrExtensions.TryGetAsset<IEditorExtension>(this.CorrespondingSourceObject_C223, base.Collection);
			}
			set
			{
				PPtrExtensions.SetAsset<IEditorExtension>(this.CorrespondingSourceObject_C223, base.Collection, value);
			}
		}

		// Token: 0x17011E6E RID: 73326
		// (get) Token: 0x06036C1F RID: 224287 RVA: 0x00753D87 File Offset: 0x00751F87
		// (set) Token: 0x06036C20 RID: 224288 RVA: 0x00753D9A File Offset: 0x00751F9A
		public IGameObject GameObject_C223P
		{
			get
			{
				return PPtrExtensions.TryGetAsset<IGameObject>(this.GameObject_C223, base.Collection);
			}
			set
			{
				PPtrExtensions.SetAsset<IGameObject>(this.GameObject_C223, base.Collection, value);
			}
		}

		// Token: 0x17011E6F RID: 73327
		// (get) Token: 0x06036C21 RID: 224289 RVA: 0x00753DAE File Offset: 0x00751FAE
		// (set) Token: 0x06036C22 RID: 224290 RVA: 0x00753DB1 File Offset: 0x00751FB1
		public IPrefab PrefabAsset_C223P
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x17011E70 RID: 73328
		// (get) Token: 0x06036C23 RID: 224291 RVA: 0x00753DB3 File Offset: 0x00751FB3
		// (set) Token: 0x06036C24 RID: 224292 RVA: 0x00753DB6 File Offset: 0x00751FB6
		public IPrefabInstance PrefabInstance_C223P
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x17011E71 RID: 73329
		// (get) Token: 0x06036C25 RID: 224293 RVA: 0x00753DB8 File Offset: 0x00751FB8
		// (set) Token: 0x06036C26 RID: 224294 RVA: 0x00753DCB File Offset: 0x00751FCB
		public IPrefabMarker PrefabInternal_C223P
		{
			get
			{
				return PPtrExtensions.TryGetAsset<IPrefabMarker>(this.PrefabInternal_C223, base.Collection);
			}
			set
			{
				PPtrExtensions.SetAsset<IPrefabMarker>(this.PrefabInternal_C223, base.Collection, value);
			}
		}

		// Token: 0x17011E72 RID: 73330
		// (get) Token: 0x06036C27 RID: 224295 RVA: 0x00753DDF File Offset: 0x00751FDF

		public override string ClassName
		{

			get
			{
				return "Canvas";
			}
		}

		// Token: 0x06036C28 RID: 224296 RVA: 0x00753DE6 File Offset: 0x00751FE6
		public Canvas_5_6_0_GICB2()
			: this(AssetInfo.MakeDummyAssetInfo(223))
		{
		}

		// Token: 0x06036C29 RID: 224297 RVA: 0x00753DF8 File Offset: 0x00751FF8
		public Canvas_5_6_0_GICB2(AssetInfo info)
			: base(info)
		{
			this.m_Camera = new PPtr_Camera_5_0_0();
		}

		// Token: 0x06036C2A RID: 224298 RVA: 0x00753E0C File Offset: 0x0075200C
		public bool Has_AdditionalShaderChannelsFlag_C223()
		{
			return true;
		}

		// Token: 0x06036C2B RID: 224299 RVA: 0x00753E0F File Offset: 0x0075200F
		public bool Has_Alpha_C223()
		{
			return false;
		}

		// Token: 0x06036C2C RID: 224300 RVA: 0x00753E12 File Offset: 0x00752012
		public bool Has_Normals_C223()
		{
			return false;
		}

		// Token: 0x06036C2D RID: 224301 RVA: 0x00753E15 File Offset: 0x00752015
		public bool Has_OverridePixelPerfect_C223()
		{
			return true;
		}

		// Token: 0x06036C2E RID: 224302 RVA: 0x00753E18 File Offset: 0x00752018
		public bool Has_OverrideSorting_C223()
		{
			return true;
		}

		// Token: 0x06036C2F RID: 224303 RVA: 0x00753E1B File Offset: 0x0075201B
		public bool Has_PlaneDistance_C223()
		{
			return true;
		}

		// Token: 0x06036C30 RID: 224304 RVA: 0x00753E1E File Offset: 0x0075201E
		public bool Has_PositionUVs_C223()
		{
			return false;
		}

		// Token: 0x06036C31 RID: 224305 RVA: 0x00753E21 File Offset: 0x00752021
		public bool Has_PrefabAsset_C223()
		{
			return false;
		}

		// Token: 0x06036C32 RID: 224306 RVA: 0x00753E24 File Offset: 0x00752024
		public bool Has_PrefabInstance_C223()
		{
			return false;
		}

		// Token: 0x06036C33 RID: 224307 RVA: 0x00753E27 File Offset: 0x00752027
		public bool Has_PrefabInternal_C223()
		{
			return true;
		}

		// Token: 0x06036C34 RID: 224308 RVA: 0x00753E2A File Offset: 0x0075202A
		public bool Has_ReceivesEvents_C223()
		{
			return true;
		}

		// Token: 0x06036C35 RID: 224309 RVA: 0x00753E2D File Offset: 0x0075202D
		public bool Has_SortingBucketNormalizedSize_C223()
		{
			return true;
		}

		// Token: 0x06036C36 RID: 224310 RVA: 0x00753E30 File Offset: 0x00752030
		public bool Has_SortingLayerID_C223_UInt32()
		{
			return false;
		}

		// Token: 0x06036C37 RID: 224311 RVA: 0x00753E33 File Offset: 0x00752033
		public bool Has_SortingLayerID_C223_Int32()
		{
			return true;
		}

		// Token: 0x06036C38 RID: 224312 RVA: 0x00753E36 File Offset: 0x00752036
		public bool Has_SortingOrder_C223()
		{
			return true;
		}

		// Token: 0x06036C39 RID: 224313 RVA: 0x00753E39 File Offset: 0x00752039
		public bool Has_TargetDisplay_C223()
		{
			return true;
		}

		// Token: 0x06036C3A RID: 224314 RVA: 0x00753E3C File Offset: 0x0075203C
		public bool Has_UpdateRectTransformForStandalone_C223()
		{
			return false;
		}

		// Token: 0x06036C3B RID: 224315 RVA: 0x00753E40 File Offset: 0x00752040

		public override void ReadRelease(AssetReader reader)
		{
			this.m_GameObject.ReadRelease(reader);
			this.m_Enabled = reader.ReadRelease_ByteAlign();
			this.m_RenderMode = reader.ReadInt32();
			this.m_Camera.ReadRelease(reader);
			this.m_PlaneDistance = reader.ReadSingle();
			this.m_PixelPerfect = reader.ReadBoolean();
			this.m_ReceivesEvents = reader.ReadBoolean();
			this.m_OverrideSorting = reader.ReadBoolean();
			this.m_OverridePixelPerfect = reader.ReadBoolean();
			this.m_SortingBucketNormalizedSize = reader.ReadSingle();
			this.m_AdditionalShaderChannelsFlag = reader.ReadInt32();
			this.m_UpdateBatchByTransformChanged = reader.ReadBoolean();
			reader.AlignStream();
			this.m_SortingLayerID = reader.ReadInt32();
			this.m_SortingOrder = reader.ReadInt16();
			this.m_TargetDisplay = reader.ReadSByte();
		}

		// Token: 0x06036C3C RID: 224316 RVA: 0x00753EF8 File Offset: 0x007520F8

		public override void ReadEditor(AssetReader reader)
		{
		}

		// Token: 0x06036C3D RID: 224317 RVA: 0x00753FD4 File Offset: 0x007521D4

		public override void WriteRelease(AssetWriter writer)
		{
			this.m_GameObject.WriteRelease(writer);
			this.m_Enabled.WriteRelease_ByteAlign(writer);
			this.m_RenderMode.WriteRelease_Int32(writer);
			this.m_Camera.WriteRelease(writer);
			this.m_PlaneDistance.WriteRelease_Single(writer);
			this.m_PixelPerfect.WriteRelease_Boolean(writer);
			this.m_ReceivesEvents.WriteRelease_Boolean(writer);
			this.m_OverrideSorting.WriteRelease_Boolean(writer);
			this.m_OverridePixelPerfect.WriteRelease_Boolean(writer);
			this.m_SortingBucketNormalizedSize.WriteRelease_Single(writer);
			this.m_AdditionalShaderChannelsFlag.WriteRelease_Int32Align(writer);
			this.m_SortingLayerID.WriteRelease_Int32(writer);
			this.m_SortingOrder.WriteRelease_Int16(writer);
			this.m_TargetDisplay.WriteRelease_SByte(writer);
		}

		// Token: 0x06036C3E RID: 224318 RVA: 0x0075408C File Offset: 0x0075228C

		public override void WriteEditor(AssetWriter writer)
		{
		}

		// Token: 0x06036C3F RID: 224319 RVA: 0x00754168 File Offset: 0x00752368

		public override YamlNode ExportYamlRelease(IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			YamlSerializedVersionExtensions.AddSerializedVersion(yamlMappingNode, 3);
			yamlMappingNode.Add(new YamlScalarNode("m_GameObject"), this.m_GameObject.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Enabled"), this.m_Enabled.ExportYamlRelease_Byte(container));
			yamlMappingNode.Add(new YamlScalarNode("m_RenderMode"), this.m_RenderMode.ExportYamlRelease_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Camera"), this.m_Camera.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("m_PlaneDistance"), this.m_PlaneDistance.ExportYamlRelease_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("m_PixelPerfect"), this.m_PixelPerfect.ExportYamlRelease_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("m_ReceivesEvents"), this.m_ReceivesEvents.ExportYamlRelease_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("m_OverrideSorting"), this.m_OverrideSorting.ExportYamlRelease_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("m_OverridePixelPerfect"), this.m_OverridePixelPerfect.ExportYamlRelease_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("m_SortingBucketNormalizedSize"), this.m_SortingBucketNormalizedSize.ExportYamlRelease_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("m_AdditionalShaderChannelsFlag"), this.m_AdditionalShaderChannelsFlag.ExportYamlRelease_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("m_SortingLayerID"), this.m_SortingLayerID.ExportYamlRelease_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("m_SortingOrder"), this.m_SortingOrder.ExportYamlRelease_Int16(container));
			yamlMappingNode.Add(new YamlScalarNode("m_TargetDisplay"), this.m_TargetDisplay.ExportYamlRelease_SByte(container));
			return yamlMappingNode;
		}

		// Token: 0x06036C40 RID: 224320 RVA: 0x0075430C File Offset: 0x0075250C

		public override YamlNode ExportYamlEditor(IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			YamlSerializedVersionExtensions.AddSerializedVersion(yamlMappingNode, 3);
			yamlMappingNode.Add(new YamlScalarNode("m_ObjectHideFlags"), this.m_HideFlags.ExportYamlEditor_UInt32(container));
			yamlMappingNode.Add(new YamlScalarNode("m_PrefabParentObject"), this.m_CorrespondingSourceObject.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_PrefabInternal"), this.m_PrefabInternal.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_GameObject"), this.m_GameObject.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Enabled"), this.m_Enabled.ExportYamlEditor_Byte(container));
			yamlMappingNode.Add(new YamlScalarNode("m_RenderMode"), this.m_RenderMode.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Camera"), this.m_Camera.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_PlaneDistance"), this.m_PlaneDistance.ExportYamlEditor_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("m_PixelPerfect"), this.m_PixelPerfect.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("m_ReceivesEvents"), this.m_ReceivesEvents.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("m_OverrideSorting"), this.m_OverrideSorting.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("m_OverridePixelPerfect"), this.m_OverridePixelPerfect.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("m_SortingBucketNormalizedSize"), this.m_SortingBucketNormalizedSize.ExportYamlEditor_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("m_AdditionalShaderChannelsFlag"), this.m_AdditionalShaderChannelsFlag.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("m_SortingLayerID"), this.m_SortingLayerID.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("m_SortingOrder"), this.m_SortingOrder.ExportYamlEditor_Int16(container));
			yamlMappingNode.Add(new YamlScalarNode("m_TargetDisplay"), this.m_TargetDisplay.ExportYamlEditor_SByte(container));
			return yamlMappingNode;
		}

		// Token: 0x06036C41 RID: 224321 RVA: 0x00754504 File Offset: 0x00752704
		public override void Reset()
		{
			this.m_AdditionalShaderChannelsFlag = 0;
			this.m_Camera.Reset();
			this.m_CorrespondingSourceObject.Reset();
			this.m_Enabled = 0;
			this.m_GameObject.Reset();
			this.m_HideFlags = 0U;
			this.m_OverridePixelPerfect = false;
			this.m_OverrideSorting = false;
			this.m_PixelPerfect = false;
			this.m_PlaneDistance = 0f;
			this.m_PrefabInternal.Reset();
			this.m_ReceivesEvents = false;
			this.m_RenderMode = 0;
			this.m_SortingBucketNormalizedSize = 0f;
			this.m_SortingLayerID = 0;
			this.m_SortingOrder = 0;
			this.m_TargetDisplay = 0;
		}

		// Token: 0x06036C42 RID: 224322 RVA: 0x007545A0 File Offset: 0x007527A0
		//public override IEnumerable<ValueTuple<FieldName, PPtr<IUnityObjectBase>>> FetchDependencies(FieldName parent)
		//{
		//	return Enumerable.Empty<ValueTuple<FieldName, PPtr<IUnityObjectBase>>>().Append_Canvas_5_6_0(parent, this);
		//}

		// Token: 0x06036C43 RID: 224323 RVA: 0x007545B0 File Offset: 0x007527B0

		public void CopyValues(ICanvas source, PPtrConverter converter)
		{
			this.m_AdditionalShaderChannelsFlag = source.AdditionalShaderChannelsFlag_C223;
			this.m_Camera.CopyValues(source.Camera_C223, converter);
			this.m_CorrespondingSourceObject.CopyValues(source.CorrespondingSourceObject_C223, converter);
			this.m_Enabled = source.Enabled_C223;
			this.m_GameObject.CopyValues(source.GameObject_C223, converter);
			this.m_HideFlags = source.HideFlags_C223;
			this.m_OverridePixelPerfect = source.OverridePixelPerfect_C223;
			this.m_OverrideSorting = source.OverrideSorting_C223;
			this.m_PixelPerfect = source.PixelPerfect_C223;
			this.m_PlaneDistance = source.PlaneDistance_C223;
			this.m_PrefabInternal.CopyValues(source.PrefabInternal_C223, converter);
			this.m_ReceivesEvents = source.ReceivesEvents_C223;
			this.m_RenderMode = source.RenderMode_C223;
			this.m_SortingBucketNormalizedSize = source.SortingBucketNormalizedSize_C223;
			this.m_SortingLayerID = source.SortingLayerID_C223_Int32;
			this.m_SortingOrder = source.SortingOrder_C223;
			this.m_TargetDisplay = source.TargetDisplay_C223;
		}

		// Token: 0x06036C44 RID: 224324 RVA: 0x007546A1 File Offset: 0x007528A1

		public void CopyValues(ICanvas source)
		{
			this.CopyValues(source, new PPtrConverter(source, this));
		}

		// Token: 0x06036C45 RID: 224325 RVA: 0x007546B4 File Offset: 0x007528B4
		public override void CopyValues(IUnityAssetBase source, PPtrConverter converter)
		{
			ICanvas canvas = source as ICanvas;
			if (canvas != null)
			{
				this.CopyValues(canvas, converter);
				return;
			}
			base.CopyValues(source, converter);
		}

		// Token: 0x06036C46 RID: 224326 RVA: 0x007546DC File Offset: 0x007528DC

		public override List<TypeTreeNode> MakeEditorTypeTreeNodes(int depth, int startingIndex)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06036C47 RID: 224327 RVA: 0x007546E3 File Offset: 0x007528E3

		public override List<TypeTreeNode> MakeReleaseTypeTreeNodes(int depth, int startingIndex)
		{
			throw new NotSupportedException();
		}

		// Token: 0x040133F7 RID: 78839
		public int m_RenderMode;

		// Token: 0x040133F8 RID: 78840

		public PPtr_Camera_5_0_0 m_Camera;

		// Token: 0x040133F9 RID: 78841
		public float m_PlaneDistance;

		// Token: 0x040133FA RID: 78842
		public bool m_PixelPerfect;

		// Token: 0x040133FB RID: 78843
		public bool m_ReceivesEvents;

		// Token: 0x040133FC RID: 78844
		public bool m_OverrideSorting;

		// Token: 0x040133FD RID: 78845
		public bool m_OverridePixelPerfect;

		// Token: 0x040133FE RID: 78846
		public float m_SortingBucketNormalizedSize;

		// Token: 0x040133FF RID: 78847
		public int m_AdditionalShaderChannelsFlag;

		// Token: 0x04013400 RID: 78848
		public int m_SortingLayerID;

		// Token: 0x04013401 RID: 78849
		public short m_SortingOrder;

		// Token: 0x04013402 RID: 78850
		public sbyte m_TargetDisplay;

		public bool m_UpdateBatchByTransformChanged { get; set; }
	}
}
