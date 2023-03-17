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
using AssetRipper.SourceGenerated.Classes.ClassID_6;
using AssetRipper.SourceGenerated.Classes.ClassID_9;
using AssetRipper.SourceGenerated.Helpers;
using AssetRipper.SourceGenerated.Interfaces;
using AssetRipper.SourceGenerated.MarkerInterfaces;
using AssetRipper.SourceGenerated.Subclasses.SortingLayerEntry;
using AssetRipper.SourceGenerated.Subclasses.Utf8String;
using AssetRipper.Yaml;
using AssetRipper.SourceGenerated.Classes.ClassID_78;

namespace AssetRipper.Import.GICB2.TagManager
{
	// Token: 0x0200266E RID: 9838
	public sealed class TagManager_2017_1_0_GICB2 : GlobalGameManager, ITagManager, IUnityObjectBase, IUnityAssetBase, IAsset, IAssetReadable, IAssetWritable, IYamlExportable, IDependent, ITypeTreeSerializable, ITagManagerMarker, IGlobalGameManager, IGlobalGameManagerMarker, IGameManager, IGameManagerMarker, IObject, IObjectMarker, IHasHideFlags
	{
		// Token: 0x17008611 RID: 34321
		// (get) Token: 0x0601EE28 RID: 126504 RVA: 0x004A79A7 File Offset: 0x004A5BA7
		public Utf8String Builtin_Layer_0_C78
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17008612 RID: 34322
		// (get) Token: 0x0601EE29 RID: 126505 RVA: 0x004A79AA File Offset: 0x004A5BAA
		public Utf8String Builtin_Layer_1_C78
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17008613 RID: 34323
		// (get) Token: 0x0601EE2A RID: 126506 RVA: 0x004A79AD File Offset: 0x004A5BAD
		public Utf8String Builtin_Layer_2_C78
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17008614 RID: 34324
		// (get) Token: 0x0601EE2B RID: 126507 RVA: 0x004A79B0 File Offset: 0x004A5BB0
		public Utf8String Builtin_Layer_3_C78
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17008615 RID: 34325
		// (get) Token: 0x0601EE2C RID: 126508 RVA: 0x004A79B3 File Offset: 0x004A5BB3
		public Utf8String Builtin_Layer_4_C78
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17008616 RID: 34326
		// (get) Token: 0x0601EE2D RID: 126509 RVA: 0x004A79B6 File Offset: 0x004A5BB6
		public Utf8String Builtin_Layer_5_C78
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17008617 RID: 34327
		// (get) Token: 0x0601EE2E RID: 126510 RVA: 0x004A79B9 File Offset: 0x004A5BB9
		public Utf8String Builtin_Layer_6_C78
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17008618 RID: 34328
		// (get) Token: 0x0601EE2F RID: 126511 RVA: 0x004A79BC File Offset: 0x004A5BBC
		public Utf8String Builtin_Layer_7_C78
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17008619 RID: 34329
		// (get) Token: 0x0601EE30 RID: 126512 RVA: 0x004A79BF File Offset: 0x004A5BBF

		public AssetList<Utf8String> Layers_C78
		{

			[return: NotNull]
			get
			{
				return this.m_Layers;
			}
		}

		// Token: 0x1700861A RID: 34330
		// (get) Token: 0x0601EE31 RID: 126513 RVA: 0x004A79C7 File Offset: 0x004A5BC7

		public AccessListBase<ISortingLayerEntry> SortingLayers_C78
		{

			[return: NotNull]
			get
			{
				return new AccessList<SortingLayerEntry_5_0_0, ISortingLayerEntry>(this.m_SortingLayers);
			}
		}

		// Token: 0x1700861B RID: 34331
		// (get) Token: 0x0601EE32 RID: 126514 RVA: 0x004A79D4 File Offset: 0x004A5BD4

		public AssetList<Utf8String> Tags_C78
		{

			get
			{
				return this.m_Tags;
			}
		}

		// Token: 0x1700861C RID: 34332
		// (get) Token: 0x0601EE33 RID: 126515 RVA: 0x004A79DC File Offset: 0x004A5BDC
		public Utf8String User_Layer_10_C78
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700861D RID: 34333
		// (get) Token: 0x0601EE34 RID: 126516 RVA: 0x004A79DF File Offset: 0x004A5BDF
		public Utf8String User_Layer_11_C78
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700861E RID: 34334
		// (get) Token: 0x0601EE35 RID: 126517 RVA: 0x004A79E2 File Offset: 0x004A5BE2
		public Utf8String User_Layer_12_C78
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700861F RID: 34335
		// (get) Token: 0x0601EE36 RID: 126518 RVA: 0x004A79E5 File Offset: 0x004A5BE5
		public Utf8String User_Layer_13_C78
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17008620 RID: 34336
		// (get) Token: 0x0601EE37 RID: 126519 RVA: 0x004A79E8 File Offset: 0x004A5BE8
		public Utf8String User_Layer_14_C78
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17008621 RID: 34337
		// (get) Token: 0x0601EE38 RID: 126520 RVA: 0x004A79EB File Offset: 0x004A5BEB
		public Utf8String User_Layer_15_C78
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17008622 RID: 34338
		// (get) Token: 0x0601EE39 RID: 126521 RVA: 0x004A79EE File Offset: 0x004A5BEE
		public Utf8String User_Layer_16_C78
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17008623 RID: 34339
		// (get) Token: 0x0601EE3A RID: 126522 RVA: 0x004A79F1 File Offset: 0x004A5BF1
		public Utf8String User_Layer_17_C78
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17008624 RID: 34340
		// (get) Token: 0x0601EE3B RID: 126523 RVA: 0x004A79F4 File Offset: 0x004A5BF4
		public Utf8String User_Layer_18_C78
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17008625 RID: 34341
		// (get) Token: 0x0601EE3C RID: 126524 RVA: 0x004A79F7 File Offset: 0x004A5BF7
		public Utf8String User_Layer_19_C78
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17008626 RID: 34342
		// (get) Token: 0x0601EE3D RID: 126525 RVA: 0x004A79FA File Offset: 0x004A5BFA
		public Utf8String User_Layer_20_C78
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17008627 RID: 34343
		// (get) Token: 0x0601EE3E RID: 126526 RVA: 0x004A79FD File Offset: 0x004A5BFD
		public Utf8String User_Layer_21_C78
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17008628 RID: 34344
		// (get) Token: 0x0601EE3F RID: 126527 RVA: 0x004A7A00 File Offset: 0x004A5C00
		public Utf8String User_Layer_22_C78
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17008629 RID: 34345
		// (get) Token: 0x0601EE40 RID: 126528 RVA: 0x004A7A03 File Offset: 0x004A5C03
		public Utf8String User_Layer_23_C78
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700862A RID: 34346
		// (get) Token: 0x0601EE41 RID: 126529 RVA: 0x004A7A06 File Offset: 0x004A5C06
		public Utf8String User_Layer_24_C78
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700862B RID: 34347
		// (get) Token: 0x0601EE42 RID: 126530 RVA: 0x004A7A09 File Offset: 0x004A5C09
		public Utf8String User_Layer_25_C78
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700862C RID: 34348
		// (get) Token: 0x0601EE43 RID: 126531 RVA: 0x004A7A0C File Offset: 0x004A5C0C
		public Utf8String User_Layer_26_C78
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700862D RID: 34349
		// (get) Token: 0x0601EE44 RID: 126532 RVA: 0x004A7A0F File Offset: 0x004A5C0F
		public Utf8String User_Layer_27_C78
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700862E RID: 34350
		// (get) Token: 0x0601EE45 RID: 126533 RVA: 0x004A7A12 File Offset: 0x004A5C12
		public Utf8String User_Layer_28_C78
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700862F RID: 34351
		// (get) Token: 0x0601EE46 RID: 126534 RVA: 0x004A7A15 File Offset: 0x004A5C15
		public Utf8String User_Layer_29_C78
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17008630 RID: 34352
		// (get) Token: 0x0601EE47 RID: 126535 RVA: 0x004A7A18 File Offset: 0x004A5C18
		public Utf8String User_Layer_30_C78
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17008631 RID: 34353
		// (get) Token: 0x0601EE48 RID: 126536 RVA: 0x004A7A1B File Offset: 0x004A5C1B
		public Utf8String User_Layer_31_C78
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17008632 RID: 34354
		// (get) Token: 0x0601EE49 RID: 126537 RVA: 0x004A7A1E File Offset: 0x004A5C1E
		public Utf8String User_Layer_8_C78
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17008633 RID: 34355
		// (get) Token: 0x0601EE4A RID: 126538 RVA: 0x004A7A21 File Offset: 0x004A5C21
		public Utf8String User_Layer_9_C78
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17008634 RID: 34356
		// (get) Token: 0x0601EE4B RID: 126539 RVA: 0x004A7A24 File Offset: 0x004A5C24

		public override string ClassName
		{

			get
			{
				return "TagManager";
			}
		}

		// Token: 0x0601EE4C RID: 126540 RVA: 0x004A7A2B File Offset: 0x004A5C2B
		public TagManager_2017_1_0_GICB2()
			: this(AssetInfo.MakeDummyAssetInfo(78))
		{
		}

		// Token: 0x0601EE4D RID: 126541 RVA: 0x004A7A3A File Offset: 0x004A5C3A
		public TagManager_2017_1_0_GICB2(AssetInfo info)
			: base(info)
		{
			this.m_Tags = new AssetList<Utf8String>();
			this.m_Layers = new AssetList<Utf8String>();
			this.m_SortingLayers = new AssetList<SortingLayerEntry_5_0_0>();
		}

		// Token: 0x0601EE4E RID: 126542 RVA: 0x004A7A64 File Offset: 0x004A5C64
		public bool Has_Builtin_Layer_0_C78()
		{
			return false;
		}

		// Token: 0x0601EE4F RID: 126543 RVA: 0x004A7A67 File Offset: 0x004A5C67
		public bool Has_Builtin_Layer_1_C78()
		{
			return false;
		}

		// Token: 0x0601EE50 RID: 126544 RVA: 0x004A7A6A File Offset: 0x004A5C6A
		public bool Has_Builtin_Layer_2_C78()
		{
			return false;
		}

		// Token: 0x0601EE51 RID: 126545 RVA: 0x004A7A6D File Offset: 0x004A5C6D
		public bool Has_Builtin_Layer_3_C78()
		{
			return false;
		}

		// Token: 0x0601EE52 RID: 126546 RVA: 0x004A7A70 File Offset: 0x004A5C70
		public bool Has_Builtin_Layer_4_C78()
		{
			return false;
		}

		// Token: 0x0601EE53 RID: 126547 RVA: 0x004A7A73 File Offset: 0x004A5C73
		public bool Has_Builtin_Layer_5_C78()
		{
			return false;
		}

		// Token: 0x0601EE54 RID: 126548 RVA: 0x004A7A76 File Offset: 0x004A5C76
		public bool Has_Builtin_Layer_6_C78()
		{
			return false;
		}

		// Token: 0x0601EE55 RID: 126549 RVA: 0x004A7A79 File Offset: 0x004A5C79
		public bool Has_Builtin_Layer_7_C78()
		{
			return false;
		}

		// Token: 0x0601EE56 RID: 126550 RVA: 0x004A7A7C File Offset: 0x004A5C7C
		public bool Has_Layers_C78()
		{
			return true;
		}

		// Token: 0x0601EE57 RID: 126551 RVA: 0x004A7A7F File Offset: 0x004A5C7F
		public bool Has_SortingLayers_C78()
		{
			return true;
		}

		// Token: 0x0601EE58 RID: 126552 RVA: 0x004A7A82 File Offset: 0x004A5C82
		public bool Has_User_Layer_10_C78()
		{
			return false;
		}

		// Token: 0x0601EE59 RID: 126553 RVA: 0x004A7A85 File Offset: 0x004A5C85
		public bool Has_User_Layer_11_C78()
		{
			return false;
		}

		// Token: 0x0601EE5A RID: 126554 RVA: 0x004A7A88 File Offset: 0x004A5C88
		public bool Has_User_Layer_12_C78()
		{
			return false;
		}

		// Token: 0x0601EE5B RID: 126555 RVA: 0x004A7A8B File Offset: 0x004A5C8B
		public bool Has_User_Layer_13_C78()
		{
			return false;
		}

		// Token: 0x0601EE5C RID: 126556 RVA: 0x004A7A8E File Offset: 0x004A5C8E
		public bool Has_User_Layer_14_C78()
		{
			return false;
		}

		// Token: 0x0601EE5D RID: 126557 RVA: 0x004A7A91 File Offset: 0x004A5C91
		public bool Has_User_Layer_15_C78()
		{
			return false;
		}

		// Token: 0x0601EE5E RID: 126558 RVA: 0x004A7A94 File Offset: 0x004A5C94
		public bool Has_User_Layer_16_C78()
		{
			return false;
		}

		// Token: 0x0601EE5F RID: 126559 RVA: 0x004A7A97 File Offset: 0x004A5C97
		public bool Has_User_Layer_17_C78()
		{
			return false;
		}

		// Token: 0x0601EE60 RID: 126560 RVA: 0x004A7A9A File Offset: 0x004A5C9A
		public bool Has_User_Layer_18_C78()
		{
			return false;
		}

		// Token: 0x0601EE61 RID: 126561 RVA: 0x004A7A9D File Offset: 0x004A5C9D
		public bool Has_User_Layer_19_C78()
		{
			return false;
		}

		// Token: 0x0601EE62 RID: 126562 RVA: 0x004A7AA0 File Offset: 0x004A5CA0
		public bool Has_User_Layer_20_C78()
		{
			return false;
		}

		// Token: 0x0601EE63 RID: 126563 RVA: 0x004A7AA3 File Offset: 0x004A5CA3
		public bool Has_User_Layer_21_C78()
		{
			return false;
		}

		// Token: 0x0601EE64 RID: 126564 RVA: 0x004A7AA6 File Offset: 0x004A5CA6
		public bool Has_User_Layer_22_C78()
		{
			return false;
		}

		// Token: 0x0601EE65 RID: 126565 RVA: 0x004A7AA9 File Offset: 0x004A5CA9
		public bool Has_User_Layer_23_C78()
		{
			return false;
		}

		// Token: 0x0601EE66 RID: 126566 RVA: 0x004A7AAC File Offset: 0x004A5CAC
		public bool Has_User_Layer_24_C78()
		{
			return false;
		}

		// Token: 0x0601EE67 RID: 126567 RVA: 0x004A7AAF File Offset: 0x004A5CAF
		public bool Has_User_Layer_25_C78()
		{
			return false;
		}

		// Token: 0x0601EE68 RID: 126568 RVA: 0x004A7AB2 File Offset: 0x004A5CB2
		public bool Has_User_Layer_26_C78()
		{
			return false;
		}

		// Token: 0x0601EE69 RID: 126569 RVA: 0x004A7AB5 File Offset: 0x004A5CB5
		public bool Has_User_Layer_27_C78()
		{
			return false;
		}

		// Token: 0x0601EE6A RID: 126570 RVA: 0x004A7AB8 File Offset: 0x004A5CB8
		public bool Has_User_Layer_28_C78()
		{
			return false;
		}

		// Token: 0x0601EE6B RID: 126571 RVA: 0x004A7ABB File Offset: 0x004A5CBB
		public bool Has_User_Layer_29_C78()
		{
			return false;
		}

		// Token: 0x0601EE6C RID: 126572 RVA: 0x004A7ABE File Offset: 0x004A5CBE
		public bool Has_User_Layer_30_C78()
		{
			return false;
		}

		// Token: 0x0601EE6D RID: 126573 RVA: 0x004A7AC1 File Offset: 0x004A5CC1
		public bool Has_User_Layer_31_C78()
		{
			return false;
		}

		// Token: 0x0601EE6E RID: 126574 RVA: 0x004A7AC4 File Offset: 0x004A5CC4
		public bool Has_User_Layer_8_C78()
		{
			return false;
		}

		// Token: 0x0601EE6F RID: 126575 RVA: 0x004A7AC7 File Offset: 0x004A5CC7
		public bool Has_User_Layer_9_C78()
		{
			return false;
		}

		// Token: 0x0601EE70 RID: 126576 RVA: 0x004A7ACA File Offset: 0x004A5CCA

		public override void ReadRelease(AssetReader reader)
		{
			this.m_Tags.ReadRelease_ArrayAlign_Asset(reader);
			this.m_Layers.ReadRelease_ArrayAlign_Asset(reader);
			surfaceTypes = reader.ReadStringArray();
			isSpecialLayerArray = reader.ReadByteArray();
			this.m_SortingLayers.ReadRelease_ArrayAlign_Asset(reader);
		}

		// Token: 0x0601EE71 RID: 126577 RVA: 0x004A7AF0 File Offset: 0x004A5CF0

		public override void ReadEditor(AssetReader reader)
		{
			// this.m_Tags.ReadEditor_ArrayAlign_Asset(reader);
			// this.m_Layers.ReadEditor_ArrayAlign_Asset(reader);
			// this.m_SortingLayers.ReadEditor_ArrayAlign_Asset(reader);
		}

		// Token: 0x0601EE72 RID: 126578 RVA: 0x004A7B16 File Offset: 0x004A5D16

		public override void WriteRelease(AssetWriter writer)
		{
			this.m_Tags.WriteRelease_ArrayAlign_Asset(writer);
			this.m_Layers.WriteRelease_ArrayAlign_Asset(writer);
			this.m_SortingLayers.WriteRelease_ArrayAlign_Asset(writer);
		}

		// Token: 0x0601EE73 RID: 126579 RVA: 0x004A7B3C File Offset: 0x004A5D3C

		public override void WriteEditor(AssetWriter writer)
		{
			// this.m_Tags.WriteEditor_ArrayAlign_Asset(writer);
			// this.m_Layers.WriteEditor_ArrayAlign_Asset(writer);
			// this.m_SortingLayers.WriteEditor_ArrayAlign_Asset(writer);
		}

		// Token: 0x0601EE74 RID: 126580 RVA: 0x004A7B64 File Offset: 0x004A5D64

		public override YamlNode ExportYamlRelease(IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			YamlSerializedVersionExtensions.AddSerializedVersion(yamlMappingNode, 2);
			yamlMappingNode.Add(new YamlScalarNode("tags"), this.m_Tags.ExportYamlRelease_Array_Utf8String(container));
			yamlMappingNode.Add(new YamlScalarNode("layers"), this.m_Layers.ExportYamlRelease_Array_Utf8String(container));
			yamlMappingNode.Add(new YamlScalarNode("m_SortingLayers"), this.m_SortingLayers.ExportYamlRelease_Array_SortingLayerEntry_5_0_0(container));
			return yamlMappingNode;
		}

		// Token: 0x0601EE75 RID: 126581 RVA: 0x004A7BD4 File Offset: 0x004A5DD4
		// 
		public override YamlNode ExportYamlEditor(IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			YamlSerializedVersionExtensions.AddSerializedVersion(yamlMappingNode, 2);
			yamlMappingNode.Add(new YamlScalarNode("tags"), this.m_Tags.ExportYamlEditor_Array_Utf8String(container));
			yamlMappingNode.Add(new YamlScalarNode("layers"), this.m_Layers.ExportYamlEditor_Array_Utf8String(container));
			yamlMappingNode.Add(new YamlScalarNode("m_SortingLayers"), this.m_SortingLayers.ExportYamlEditor_Array_SortingLayerEntry_5_0_0(container));
			return yamlMappingNode;
		}

		// Token: 0x0601EE76 RID: 126582 RVA: 0x004A7C41 File Offset: 0x004A5E41
		public override void Reset()
		{
			this.m_Layers.Clear();
			this.m_SortingLayers.Clear();
			this.m_Tags.Clear();
		}

		// Token: 0x0601EE77 RID: 126583 RVA: 0x004A7C64 File Offset: 0x004A5E64

		public override IEnumerable<ValueTuple<FieldName, PPtr<IUnityObjectBase>>> FetchDependencies(FieldName parent)
		{
			return Enumerable.Empty<ValueTuple<FieldName, PPtr<IUnityObjectBase>>>();
		}

		// Token: 0x0601EE78 RID: 126584 RVA: 0x004A7C6B File Offset: 0x004A5E6B

		public void CopyValues(ITagManager source)
		{
			CopyValuesHelper.CopyValues__AssetList_Utf8String__AssetList_Utf8String(this.m_Layers, source.Layers_C78);
			CopyValuesHelper.CopyValues__AssetList_SortingLayerEntry_5_0_0__AccessListBase_ISortingLayerEntry(this.m_SortingLayers, source.SortingLayers_C78);
			CopyValuesHelper.CopyValues__AssetList_Utf8String__AssetList_Utf8String(this.m_Tags, source.Tags_C78);
		}

		// Token: 0x0601EE79 RID: 126585 RVA: 0x004A7CA0 File Offset: 0x004A5EA0
		public override void CopyValues(IUnityAssetBase source, PPtrConverter converter)
		{
			ITagManager tagManager = source as ITagManager;
			if (tagManager != null)
			{
				this.CopyValues(tagManager);
				return;
			}
			base.CopyValues(source, converter);
		}

		// Token: 0x0601EE7A RID: 126586 RVA: 0x004A7CC7 File Offset: 0x004A5EC7

		public override List<TypeTreeNode> MakeEditorTypeTreeNodes(int depth, int startingIndex)
		{
			throw new NotSupportedException();
		}

		// Token: 0x0601EE7B RID: 126587 RVA: 0x004A7CCE File Offset: 0x004A5ECE

		public override List<TypeTreeNode> MakeReleaseTypeTreeNodes(int depth, int startingIndex)
		{
			throw new NotSupportedException();
		}

		// Token: 0x040113BC RID: 70588

		public AssetList<Utf8String> m_Tags;

		// Token: 0x040113BD RID: 70589

		public AssetList<Utf8String> m_Layers;

		public string[] surfaceTypes { get; set; }
		public byte[] isSpecialLayerArray { get; set; }

		// Token: 0x040113BE RID: 70590

		public AssetList<SortingLayerEntry_5_0_0> m_SortingLayers;
	}
}
