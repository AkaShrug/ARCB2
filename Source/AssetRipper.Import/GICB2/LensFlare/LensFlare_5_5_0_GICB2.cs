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
using AssetRipper.SourceGenerated.Classes.ClassID_1002;
using AssetRipper.SourceGenerated.Classes.ClassID_121;
using AssetRipper.SourceGenerated.Classes.ClassID_18;
using AssetRipper.SourceGenerated.Classes.ClassID_2;
using AssetRipper.SourceGenerated.Classes.ClassID_8;
using AssetRipper.SourceGenerated.Enums;
using AssetRipper.SourceGenerated.Helpers;
using AssetRipper.SourceGenerated.Interfaces;
using AssetRipper.SourceGenerated.MarkerInterfaces;
using AssetRipper.SourceGenerated.Subclasses.BitField;
using AssetRipper.SourceGenerated.Subclasses.ColorRGBAf;
using AssetRipper.SourceGenerated.Subclasses.PPtr_EditorExtensionImpl;
using AssetRipper.SourceGenerated.Subclasses.PPtr_EditorExtension;
using AssetRipper.SourceGenerated.Subclasses.PPtr_Flare;
using AssetRipper.SourceGenerated.Subclasses.PPtr_GameObject;
using AssetRipper.SourceGenerated.Subclasses.PPtr_PrefabInstance;
using AssetRipper.SourceGenerated.Subclasses.PPtr_Prefab;
using AssetRipper.Yaml;
using AssetRipper.SourceGenerated.Classes.ClassID_123;

namespace AssetRipper.Import.GICB2.LensFlare
{
	// Token: 0x020032AE RID: 12974


	public sealed class LensFlare_5_5_0_GICB2 : Behaviour_5_5_0, ILensFlare, ILensFlareMarker, IUnityObjectBase, IUnityAssetBase, IAsset, IAssetReadable, IAssetWritable, IYamlExportable, IDependent, ITypeTreeSerializable, IBehaviour, IBehaviourMarker, IComponent, IEditorExtension, IEditorExtensionMarker, IObject, IObjectMarker, IHasHideFlags, IComponentMarker, IHasEnabled
	{
		// Token: 0x1701CCDB RID: 117979
		// (get) Token: 0x06052DF3 RID: 339443 RVA: 0x01321B42 File Offset: 0x0131FD42
		// (set) Token: 0x06052DF4 RID: 339444 RVA: 0x01321B4A File Offset: 0x0131FD4A
		public float Brightness_C123
		{
			get
			{
				return this.m_Brightness;
			}
			set
			{
				this.m_Brightness = value;
			}
		}

		// Token: 0x1701CCDC RID: 117980
		// (get) Token: 0x06052DF5 RID: 339445 RVA: 0x01321B53 File Offset: 0x0131FD53

		public IColorRGBAf Color_C123
		{

			get
			{
				return this.m_Color;
			}
		}

		// Token: 0x1701CCDD RID: 117981
		// (get) Token: 0x06052DF6 RID: 339446 RVA: 0x01321B5B File Offset: 0x0131FD5B
		public IPPtr_EditorExtension CorrespondingSourceObject_C123
		{
			[return: NotNull]
			get
			{
				return this.m_CorrespondingSourceObject;
			}
		}

		// Token: 0x1701CCDE RID: 117982
		// (get) Token: 0x06052DF7 RID: 339447 RVA: 0x01321B63 File Offset: 0x0131FD63
		// (set) Token: 0x06052DF8 RID: 339448 RVA: 0x01321B6B File Offset: 0x0131FD6B
		public bool Directional_C123
		{
			get
			{
				return this.m_Directional;
			}
			set
			{
				this.m_Directional = value;
			}
		}

		// Token: 0x1701CCDF RID: 117983
		// (get) Token: 0x06052DF9 RID: 339449 RVA: 0x01321B74 File Offset: 0x0131FD74
		// (set) Token: 0x06052DFA RID: 339450 RVA: 0x01321B7C File Offset: 0x0131FD7C
		public byte Enabled_C123
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

		// Token: 0x1701CCE0 RID: 117984
		// (get) Token: 0x06052DFB RID: 339451 RVA: 0x01321B85 File Offset: 0x0131FD85
		public PPtr_EditorExtensionImpl ExtensionPtr_C123
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1701CCE1 RID: 117985
		// (get) Token: 0x06052DFC RID: 339452 RVA: 0x01321B88 File Offset: 0x0131FD88
		// (set) Token: 0x06052DFD RID: 339453 RVA: 0x01321B90 File Offset: 0x0131FD90
		public float FadeSpeed_C123
		{
			get
			{
				return this.m_FadeSpeed;
			}
			set
			{
				this.m_FadeSpeed = value;
			}
		}

		// Token: 0x1701CCE2 RID: 117986
		// (get) Token: 0x06052DFE RID: 339454 RVA: 0x01321B99 File Offset: 0x0131FD99

		public IPPtr_Flare Flare_C123
		{

			get
			{
				return this.m_Flare;
			}
		}

		// Token: 0x1701CCE3 RID: 117987
		// (get) Token: 0x06052DFF RID: 339455 RVA: 0x01321BA1 File Offset: 0x0131FDA1

		public IPPtr_GameObject GameObject_C123
		{

			get
			{
				return this.m_GameObject;
			}
		}

		// Token: 0x1701CCE4 RID: 117988
		// (get) Token: 0x06052E00 RID: 339456 RVA: 0x01321BA9 File Offset: 0x0131FDA9
		// (set) Token: 0x06052E01 RID: 339457 RVA: 0x01321BB1 File Offset: 0x0131FDB1
		public uint HideFlags_C123
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

		// Token: 0x1701CCE5 RID: 117989
		// (get) Token: 0x06052E02 RID: 339458 RVA: 0x01321BBA File Offset: 0x0131FDBA

		public BitField IgnoreLayers_C123
		{

			get
			{
				return this.m_IgnoreLayers;
			}
		}

		// Token: 0x1701CCE6 RID: 117990
		// (get) Token: 0x06052E03 RID: 339459 RVA: 0x01321BC2 File Offset: 0x0131FDC2
		public PPtr_Prefab_2018_3_0 PrefabAsset_C123
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1701CCE7 RID: 117991
		// (get) Token: 0x06052E04 RID: 339460 RVA: 0x01321BC5 File Offset: 0x0131FDC5
		public PPtr_PrefabInstance PrefabInstance_C123
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1701CCE8 RID: 117992
		// (get) Token: 0x06052E05 RID: 339461 RVA: 0x01321BC8 File Offset: 0x0131FDC8
		public IPPtr_Prefab PrefabInternal_C123
		{
			[return: NotNull]
			get
			{
				return this.m_PrefabInternal;
			}
		}

		// Token: 0x1701CCE9 RID: 117993
		// (get) Token: 0x06052E06 RID: 339462 RVA: 0x01321BD0 File Offset: 0x0131FDD0
		// (set) Token: 0x06052E07 RID: 339463 RVA: 0x01321BD8 File Offset: 0x0131FDD8
		public HideFlags HideFlags_C123E
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

		// Token: 0x1701CCEA RID: 117994
		// (get) Token: 0x06052E08 RID: 339464 RVA: 0x01321BE1 File Offset: 0x0131FDE1
		// (set) Token: 0x06052E09 RID: 339465 RVA: 0x01321BF4 File Offset: 0x0131FDF4
		public IEditorExtension CorrespondingSourceObject_C123P
		{
			get
			{
				return PPtrExtensions.TryGetAsset<IEditorExtension>(this.CorrespondingSourceObject_C123, base.Collection);
			}
			set
			{
				PPtrExtensions.SetAsset<IEditorExtension>(this.CorrespondingSourceObject_C123, base.Collection, value);
			}
		}

		// Token: 0x1701CCEB RID: 117995
		// (get) Token: 0x06052E0A RID: 339466 RVA: 0x01321C08 File Offset: 0x0131FE08
		// (set) Token: 0x06052E0B RID: 339467 RVA: 0x01321C0B File Offset: 0x0131FE0B
		public IEditorExtensionImpl ExtensionPtr_C123P
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x1701CCEC RID: 117996
		// (get) Token: 0x06052E0C RID: 339468 RVA: 0x01321C0D File Offset: 0x0131FE0D
		// (set) Token: 0x06052E0D RID: 339469 RVA: 0x01321C20 File Offset: 0x0131FE20
		public IFlare Flare_C123P
		{
			get
			{
				return PPtrExtensions.TryGetAsset<IFlare>(this.Flare_C123, base.Collection);
			}
			set
			{
				PPtrExtensions.SetAsset<IFlare>(this.Flare_C123, base.Collection, value);
			}
		}

		// Token: 0x1701CCED RID: 117997
		// (get) Token: 0x06052E0E RID: 339470 RVA: 0x01321C34 File Offset: 0x0131FE34
		// (set) Token: 0x06052E0F RID: 339471 RVA: 0x01321C47 File Offset: 0x0131FE47
		public IGameObject GameObject_C123P
		{
			get
			{
				return PPtrExtensions.TryGetAsset<IGameObject>(this.GameObject_C123, base.Collection);
			}
			set
			{
				PPtrExtensions.SetAsset<IGameObject>(this.GameObject_C123, base.Collection, value);
			}
		}

		// Token: 0x1701CCEE RID: 117998
		// (get) Token: 0x06052E10 RID: 339472 RVA: 0x01321C5B File Offset: 0x0131FE5B
		// (set) Token: 0x06052E11 RID: 339473 RVA: 0x01321C5E File Offset: 0x0131FE5E
		public IPrefab PrefabAsset_C123P
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x1701CCEF RID: 117999
		// (get) Token: 0x06052E12 RID: 339474 RVA: 0x01321C60 File Offset: 0x0131FE60
		// (set) Token: 0x06052E13 RID: 339475 RVA: 0x01321C63 File Offset: 0x0131FE63
		public IPrefabInstance PrefabInstance_C123P
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x1701CCF0 RID: 118000
		// (get) Token: 0x06052E14 RID: 339476 RVA: 0x01321C65 File Offset: 0x0131FE65
		// (set) Token: 0x06052E15 RID: 339477 RVA: 0x01321C78 File Offset: 0x0131FE78
		public IPrefabMarker PrefabInternal_C123P
		{
			get
			{
				return PPtrExtensions.TryGetAsset<IPrefabMarker>(this.PrefabInternal_C123, base.Collection);
			}
			set
			{
				PPtrExtensions.SetAsset<IPrefabMarker>(this.PrefabInternal_C123, base.Collection, value);
			}
		}

		// Token: 0x1701CCF1 RID: 118001
		// (get) Token: 0x06052E16 RID: 339478 RVA: 0x01321C8C File Offset: 0x0131FE8C

		public override string ClassName
		{

			get
			{
				return "LensFlare";
			}
		}

		// Token: 0x06052E17 RID: 339479 RVA: 0x01321C93 File Offset: 0x0131FE93
		public LensFlare_5_5_0_GICB2()
			: this(AssetInfo.MakeDummyAssetInfo(123))
		{
		}

		// Token: 0x06052E18 RID: 339480 RVA: 0x01321CA2 File Offset: 0x0131FEA2
		public LensFlare_5_5_0_GICB2(AssetInfo info)
			: base(info)
		{
			this.m_Flare = new PPtr_Flare_5_0_0();
			this.m_Color = new ColorRGBAf_3_5_0();
			this.m_IgnoreLayers = new BitField();
		}

		// Token: 0x06052E19 RID: 339481 RVA: 0x01321CCC File Offset: 0x0131FECC
		public bool Has_CorrespondingSourceObject_C123()
		{
			return true;
		}

		// Token: 0x06052E1A RID: 339482 RVA: 0x01321CCF File Offset: 0x0131FECF
		public bool Has_ExtensionPtr_C123()
		{
			return false;
		}

		// Token: 0x06052E1B RID: 339483 RVA: 0x01321CD2 File Offset: 0x0131FED2
		public bool Has_FadeSpeed_C123()
		{
			return true;
		}

		// Token: 0x06052E1C RID: 339484 RVA: 0x01321CD5 File Offset: 0x0131FED5
		public bool Has_PrefabAsset_C123()
		{
			return false;
		}

		// Token: 0x06052E1D RID: 339485 RVA: 0x01321CD8 File Offset: 0x0131FED8
		public bool Has_PrefabInstance_C123()
		{
			return false;
		}

		// Token: 0x06052E1E RID: 339486 RVA: 0x01321CDB File Offset: 0x0131FEDB
		public bool Has_PrefabInternal_C123()
		{
			return true;
		}

		// Token: 0x06052E1F RID: 339487 RVA: 0x01321CE0 File Offset: 0x0131FEE0

		public override void ReadRelease(AssetReader reader)
		{
			this.m_GameObject.ReadRelease(reader);
			this.m_Enabled = reader.ReadRelease_ByteAlign();
			this.m_Flare.ReadRelease(reader);
			this.m_Color.ReadRelease(reader);
			this.m_Brightness = reader.ReadSingle();
			this.m_FadeSpeed = reader.ReadSingle();
			this.m_IgnoreLayers.ReadRelease(reader);
			this.m_Directional = reader.ReadBoolean();
			reader.AlignStream();
			var GPUOcclusion = reader.ReadBoolean();
		}

		// Token: 0x06052E20 RID: 339488 RVA: 0x01321D50 File Offset: 0x0131FF50

		public override void ReadEditor(AssetReader reader)
		{
		}

		// Token: 0x06052E21 RID: 339489 RVA: 0x01321DE4 File Offset: 0x0131FFE4

		public override void WriteRelease(AssetWriter writer)
		{
			this.m_GameObject.WriteRelease(writer);
			this.m_Enabled.WriteRelease_ByteAlign(writer);
			this.m_Flare.WriteRelease(writer);
			this.m_Color.WriteRelease(writer);
			this.m_Brightness.WriteRelease_Single(writer);
			this.m_FadeSpeed.WriteRelease_Single(writer);
			this.m_IgnoreLayers.WriteRelease(writer);
			this.m_Directional.WriteRelease_Boolean(writer);
		}

		// Token: 0x06052E22 RID: 339490 RVA: 0x01321E54 File Offset: 0x01320054

		public override void WriteEditor(AssetWriter writer)
		{
		}

		// Token: 0x06052E23 RID: 339491 RVA: 0x01321EE8 File Offset: 0x013200E8

		public override YamlNode ExportYamlRelease(IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			YamlSerializedVersionExtensions.AddSerializedVersion(yamlMappingNode, 1);
			yamlMappingNode.Add(new YamlScalarNode("m_GameObject"), this.m_GameObject.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Enabled"), this.m_Enabled.ExportYamlRelease_Byte(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Flare"), this.m_Flare.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Color"), this.m_Color.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Brightness"), this.m_Brightness.ExportYamlRelease_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("m_FadeSpeed"), this.m_FadeSpeed.ExportYamlRelease_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("m_IgnoreLayers"), this.m_IgnoreLayers.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Directional"), this.m_Directional.ExportYamlRelease_Boolean(container));
			return yamlMappingNode;
		}

		// Token: 0x06052E24 RID: 339492 RVA: 0x01321FE4 File Offset: 0x013201E4

		public override YamlNode ExportYamlEditor(IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			YamlSerializedVersionExtensions.AddSerializedVersion(yamlMappingNode, 1);
			yamlMappingNode.Add(new YamlScalarNode("m_ObjectHideFlags"), this.m_HideFlags.ExportYamlEditor_UInt32(container));
			yamlMappingNode.Add(new YamlScalarNode("m_PrefabParentObject"), this.m_CorrespondingSourceObject.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_PrefabInternal"), this.m_PrefabInternal.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_GameObject"), this.m_GameObject.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Enabled"), this.m_Enabled.ExportYamlEditor_Byte(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Flare"), this.m_Flare.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Color"), this.m_Color.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Brightness"), this.m_Brightness.ExportYamlEditor_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("m_FadeSpeed"), this.m_FadeSpeed.ExportYamlEditor_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("m_IgnoreLayers"), this.m_IgnoreLayers.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Directional"), this.m_Directional.ExportYamlEditor_Boolean(container));
			return yamlMappingNode;
		}

		// Token: 0x06052E25 RID: 339493 RVA: 0x01322134 File Offset: 0x01320334
		public override void Reset()
		{
			this.m_Brightness = 0f;
			this.m_Color.Reset();
			this.m_CorrespondingSourceObject.Reset();
			this.m_Directional = false;
			this.m_Enabled = 0;
			this.m_FadeSpeed = 0f;
			this.m_Flare.Reset();
			this.m_GameObject.Reset();
			this.m_HideFlags = 0U;
			this.m_IgnoreLayers.Reset();
			this.m_PrefabInternal.Reset();
		}

		// Token: 0x06052E26 RID: 339494 RVA: 0x013221AE File Offset: 0x013203AE
		//public override IEnumerable<ValueTuple<FieldName, PPtr<IUnityObjectBase>>> FetchDependencies(FieldName parent)
		//{
		//	return Enumerable.Empty<ValueTuple<FieldName, PPtr<IUnityObjectBase>>>().Append_LensFlare_5_5_0(parent, this);
		//

		// Token: 0x06052E27 RID: 339495 RVA: 0x013221BC File Offset: 0x013203BC

		public void CopyValues(ILensFlare source, PPtrConverter converter)
		{
			this.m_Brightness = source.Brightness_C123;
			this.m_Color.CopyValues(source.Color_C123);
			this.m_CorrespondingSourceObject.CopyValues(source.CorrespondingSourceObject_C123, converter);
			this.m_Directional = source.Directional_C123;
			this.m_Enabled = source.Enabled_C123;
			this.m_FadeSpeed = source.FadeSpeed_C123;
			this.m_Flare.CopyValues(source.Flare_C123, converter);
			this.m_GameObject.CopyValues(source.GameObject_C123, converter);
			this.m_HideFlags = source.HideFlags_C123;
			this.m_IgnoreLayers.CopyValues(source.IgnoreLayers_C123);
			this.m_PrefabInternal.CopyValues(source.PrefabInternal_C123, converter);
		}

		// Token: 0x06052E28 RID: 339496 RVA: 0x0132226F File Offset: 0x0132046F

		public void CopyValues(ILensFlare source)
		{
			this.CopyValues(source, new PPtrConverter(source, this));
		}

		// Token: 0x06052E29 RID: 339497 RVA: 0x01322280 File Offset: 0x01320480
		public override void CopyValues(IUnityAssetBase source, PPtrConverter converter)
		{
			ILensFlare lensFlare = source as ILensFlare;
			if (lensFlare != null)
			{
				this.CopyValues(lensFlare, converter);
				return;
			}
			base.CopyValues(source, converter);
		}

		// Token: 0x06052E2A RID: 339498 RVA: 0x013222A8 File Offset: 0x013204A8

		public override List<TypeTreeNode> MakeEditorTypeTreeNodes(int depth, int startingIndex)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06052E2B RID: 339499 RVA: 0x013222AF File Offset: 0x013204AF

		public override List<TypeTreeNode> MakeReleaseTypeTreeNodes(int depth, int startingIndex)
		{
			throw new NotSupportedException();
		}

		// Token: 0x040361C6 RID: 221638

		public PPtr_Flare_5_0_0 m_Flare;

		// Token: 0x040361C7 RID: 221639

		public ColorRGBAf_3_5_0 m_Color;

		// Token: 0x040361C8 RID: 221640
		public float m_Brightness;

		// Token: 0x040361C9 RID: 221641
		public float m_FadeSpeed;

		// Token: 0x040361CA RID: 221642

		public BitField m_IgnoreLayers;

		// Token: 0x040361CB RID: 221643
		public bool m_Directional;
	}
}
