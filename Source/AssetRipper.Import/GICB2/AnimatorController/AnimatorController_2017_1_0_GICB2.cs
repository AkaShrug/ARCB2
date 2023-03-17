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
using AssetRipper.SourceGenerated.Classes.ClassID_1001;
using AssetRipper.SourceGenerated.Classes.ClassID_1001480554;
using AssetRipper.SourceGenerated.Classes.ClassID_114;
using AssetRipper.SourceGenerated.Classes.ClassID_130;
using AssetRipper.SourceGenerated.Classes.ClassID_18;
using AssetRipper.SourceGenerated.Classes.ClassID_74;
using AssetRipper.SourceGenerated.Classes.ClassID_93;
using AssetRipper.SourceGenerated.Enums;
using AssetRipper.SourceGenerated.Helpers;
using AssetRipper.SourceGenerated.Interfaces;
using AssetRipper.SourceGenerated.MarkerInterfaces;
using AssetRipper.SourceGenerated.Subclasses.AnimatorControllerLayer;
using AssetRipper.SourceGenerated.Subclasses.AnimatorControllerParameter;
using AssetRipper.SourceGenerated.Subclasses.ControllerConstant;
using AssetRipper.SourceGenerated.Subclasses.PPtr_AnimationClip;
using AssetRipper.SourceGenerated.Subclasses.PPtr_EditorExtension;
using AssetRipper.SourceGenerated.Subclasses.PPtr_MonoBehaviour;
using AssetRipper.SourceGenerated.Subclasses.PPtr_PrefabInstance;
using AssetRipper.SourceGenerated.Subclasses.PPtr_Prefab;
using AssetRipper.SourceGenerated.Subclasses.StateMachineBehaviourVectorDescription;
using AssetRipper.SourceGenerated.Subclasses.Utf8String;
using AssetRipper.Yaml;
using AssetRipper.Import.GICB2.PPtr_AnimationClip;
using AssetRipper.IClasses.PPtr_AnimationClip;
using AssetRipper.IClasses.AnimationClip;
using AssetRipper.IClasses.IAnimatorController;

namespace AssetRipper.Import.GICB2.AnimatorController
{
	// Token: 0x02002598 RID: 9624


	public sealed class AnimatorController_2017_1_0_GICB2 : RuntimeAnimatorController_5_0_0, IAnimatorController_ACL, IUnityObjectBase, IUnityAssetBase, IAsset, IAssetReadable, IAssetWritable, IYamlExportable, IDependent, ITypeTreeSerializable, IAnimatorControllerMarker, IHasName, IHasNameString, INamedObject, INamedObjectMarker, IEditorExtension, IEditorExtensionMarker, IObject, IObjectMarker, IHasHideFlags
	{
		// Token: 0x17006B43 RID: 27459
		// (get) Token: 0x0601AC29 RID: 109609 RVA: 0x004276B3 File Offset: 0x004258B3
		public AccessListBase<IPPtr_AnimationClip_ACL> AnimationClips_C91
		{
			get
			{
				return new AccessList<PPtr_AnimationClip_5_0_0_GICB2, IPPtr_AnimationClip_ACL>(this.m_AnimationClips);
			}
		}

		// Token: 0x17006B44 RID: 27460
		// (get) Token: 0x0601AC2A RID: 109610 RVA: 0x004276C0 File Offset: 0x004258C0
		public AccessListBase<IAnimatorControllerLayer> AnimatorLayers_C91
		{
			get
			{
				return new AccessList<AnimatorControllerLayer_2017_1_0, IAnimatorControllerLayer>(this.m_AnimatorLayers);
			}
		}

		// Token: 0x17006B45 RID: 27461
		// (get) Token: 0x0601AC2B RID: 109611 RVA: 0x004276CD File Offset: 0x004258CD
		public AccessListBase<IAnimatorControllerParameter> AnimatorParameters_C91
		{
			get
			{
				return new AccessList<AnimatorControllerParameter_5_0_0, IAnimatorControllerParameter>(this.m_AnimatorParameters);
			}
		}

		// Token: 0x17006B46 RID: 27462
		// (get) Token: 0x0601AC2C RID: 109612 RVA: 0x004276DA File Offset: 0x004258DA
		public IControllerConstant Controller_C91
		{
			get
			{
				return this.m_Controller;
			}
		}

		// Token: 0x17006B47 RID: 27463
		// (get) Token: 0x0601AC2D RID: 109613 RVA: 0x004276E2 File Offset: 0x004258E2
		// (set) Token: 0x0601AC2E RID: 109614 RVA: 0x004276EA File Offset: 0x004258EA
		public uint ControllerSize_C91
		{
			get
			{
				return this.m_ControllerSize;
			}
			set
			{
				this.m_ControllerSize = value;
			}
		}

		// Token: 0x17006B48 RID: 27464
		// (get) Token: 0x0601AC2F RID: 109615 RVA: 0x004276F3 File Offset: 0x004258F3
		public IPPtr_EditorExtension CorrespondingSourceObject_C91
		{
			get
			{
				return this.m_CorrespondingSourceObject;
			}
		}

		// Token: 0x17006B49 RID: 27465
		// (get) Token: 0x0601AC30 RID: 109616 RVA: 0x004276FB File Offset: 0x004258FB
		// (set) Token: 0x0601AC31 RID: 109617 RVA: 0x00427703 File Offset: 0x00425903
		public uint HideFlags_C91
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

		// Token: 0x17006B4A RID: 27466
		// (get) Token: 0x0601AC32 RID: 109618 RVA: 0x0042770C File Offset: 0x0042590C
		// (set) Token: 0x0601AC33 RID: 109619 RVA: 0x00427714 File Offset: 0x00425914
		public bool MultiThreadedStateMachine_C91
		{
			get
			{
				return this.m_MultiThreadedStateMachine;
			}
			set
			{
				this.m_MultiThreadedStateMachine = value;
			}
		}

		// Token: 0x17006B4B RID: 27467
		// (get) Token: 0x0601AC34 RID: 109620 RVA: 0x0042771D File Offset: 0x0042591D
		public Utf8String Name_C91
		{
			get
			{
				return this.m_Name;
			}
		}

		// Token: 0x17006B4C RID: 27468
		// (get) Token: 0x0601AC35 RID: 109621 RVA: 0x00427725 File Offset: 0x00425925

		public PPtr_Prefab_2018_3_0 PrefabAsset_C91
		{

			get
			{
				return null;
			}
		}

		// Token: 0x17006B4D RID: 27469
		// (get) Token: 0x0601AC36 RID: 109622 RVA: 0x00427728 File Offset: 0x00425928

		public PPtr_PrefabInstance PrefabInstance_C91
		{

			get
			{
				return null;
			}
		}

		// Token: 0x17006B4E RID: 27470
		// (get) Token: 0x0601AC37 RID: 109623 RVA: 0x0042772B File Offset: 0x0042592B

		public IPPtr_Prefab PrefabInternal_C91
		{

			[return: NotNull]
			get
			{
				return this.m_PrefabInternal;
			}
		}

		// Token: 0x17006B4F RID: 27471
		// (get) Token: 0x0601AC38 RID: 109624 RVA: 0x00427733 File Offset: 0x00425933

		public AssetList<PPtr_MonoBehaviour_5_0_0> StateMachineBehaviours_C91
		{

			[return: NotNull]
			get
			{
				return this.m_StateMachineBehaviours;
			}
		}

		// Token: 0x17006B50 RID: 27472
		// (get) Token: 0x0601AC39 RID: 109625 RVA: 0x0042773B File Offset: 0x0042593B

		public IStateMachineBehaviourVectorDescription StateMachineBehaviourVectorDescription_C91
		{

			[return: NotNull]
			get
			{
				return this.m_StateMachineBehaviourVectorDescription;
			}
		}

		// Token: 0x17006B51 RID: 27473
		// (get) Token: 0x0601AC3A RID: 109626 RVA: 0x00427743 File Offset: 0x00425943
		public AssetDictionary<uint, Utf8String> TOS_C91
		{
			get
			{
				return this.m_TOS;
			}
		}

		// Token: 0x17006B52 RID: 27474
		// (get) Token: 0x0601AC3B RID: 109627 RVA: 0x0042774B File Offset: 0x0042594B
		// (set) Token: 0x0601AC3C RID: 109628 RVA: 0x00427753 File Offset: 0x00425953
		public HideFlags HideFlags_C91E
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

		// Token: 0x17006B53 RID: 27475
		// (get) Token: 0x0601AC3D RID: 109629 RVA: 0x0042775C File Offset: 0x0042595C

		public PPtrAccessList<IPPtr_AnimationClip_ACL, IAnimationClip_ACL> AnimationClips_C91P
		{

			get
			{
				return new PPtrAccessList<IPPtr_AnimationClip_ACL, IAnimationClip_ACL>(this.AnimationClips_C91, this);
			}
		}

		// Token: 0x17006B54 RID: 27476
		// (get) Token: 0x0601AC3E RID: 109630 RVA: 0x0042776A File Offset: 0x0042596A
		// (set) Token: 0x0601AC3F RID: 109631 RVA: 0x0042777D File Offset: 0x0042597D

		public IEditorExtension CorrespondingSourceObject_C91P
		{

			get
			{
				return PPtrExtensions.TryGetAsset<IEditorExtension>(this.CorrespondingSourceObject_C91, base.Collection);
			}

			set
			{
				PPtrExtensions.SetAsset<IEditorExtension>(this.CorrespondingSourceObject_C91, base.Collection, value);
			}
		}

		// Token: 0x17006B55 RID: 27477
		// (get) Token: 0x0601AC40 RID: 109632 RVA: 0x00427791 File Offset: 0x00425991
		// (set) Token: 0x0601AC41 RID: 109633 RVA: 0x00427794 File Offset: 0x00425994

		public IPrefab PrefabAsset_C91P
		{

			get
			{
				return null;
			}

			set
			{
			}
		}

		// Token: 0x17006B56 RID: 27478
		// (get) Token: 0x0601AC42 RID: 109634 RVA: 0x00427796 File Offset: 0x00425996
		// (set) Token: 0x0601AC43 RID: 109635 RVA: 0x00427799 File Offset: 0x00425999

		public IPrefabInstance PrefabInstance_C91P
		{

			get
			{
				return null;
			}

			set
			{
			}
		}

		// Token: 0x17006B57 RID: 27479
		// (get) Token: 0x0601AC44 RID: 109636 RVA: 0x0042779B File Offset: 0x0042599B
		// (set) Token: 0x0601AC45 RID: 109637 RVA: 0x004277AE File Offset: 0x004259AE

		public IPrefabMarker PrefabInternal_C91P
		{

			get
			{
				return PPtrExtensions.TryGetAsset<IPrefabMarker>(this.PrefabInternal_C91, base.Collection);
			}

			set
			{
				PPtrExtensions.SetAsset<IPrefabMarker>(this.PrefabInternal_C91, base.Collection, value);
			}
		}

		// Token: 0x17006B58 RID: 27480
		// (get) Token: 0x0601AC46 RID: 109638 RVA: 0x004277C2 File Offset: 0x004259C2

		public PPtrAccessList<PPtr_MonoBehaviour_5_0_0, IMonoBehaviour> StateMachineBehaviours_C91P
		{

			get
			{
				return new PPtrAccessList<PPtr_MonoBehaviour_5_0_0, IMonoBehaviour>(this.StateMachineBehaviours_C91, this);
			}
		}

		// Token: 0x17006B59 RID: 27481
		// (get) Token: 0x0601AC47 RID: 109639 RVA: 0x004277D0 File Offset: 0x004259D0
		public override string ClassName
		{
			get
			{
				return "AnimatorController";
			}
		}

		// Token: 0x0601AC48 RID: 109640 RVA: 0x004277D7 File Offset: 0x004259D7
		public AnimatorController_2017_1_0_GICB2()
			: this(AssetInfo.MakeDummyAssetInfo(91))
		{
		}

		// Token: 0x0601AC49 RID: 109641 RVA: 0x004277E8 File Offset: 0x004259E8
		public AnimatorController_2017_1_0_GICB2(AssetInfo info)
			: base(info)
		{
			this.m_Controller = new ControllerConstant_5_5_0();
			this.m_TOS = new AssetDictionary<uint, Utf8String>();
			this.m_AnimationClips = new AssetList<PPtr_AnimationClip_5_0_0_GICB2>();
			this.m_StateMachineBehaviourVectorDescription = new StateMachineBehaviourVectorDescription_2017_1_0();
			this.m_StateMachineBehaviours = new AssetList<PPtr_MonoBehaviour_5_0_0>();
			this.m_AnimatorParameters = new AssetList<AnimatorControllerParameter_5_0_0>();
			this.m_AnimatorLayers = new AssetList<AnimatorControllerLayer_2017_1_0>();
		}

		// Token: 0x0601AC4A RID: 109642 RVA: 0x00427849 File Offset: 0x00425A49
		public bool Has_MultiThreadedStateMachine_C91()
		{
			return true;
		}

		// Token: 0x0601AC4B RID: 109643 RVA: 0x0042784C File Offset: 0x00425A4C
		public bool Has_PrefabAsset_C91()
		{
			return false;
		}

		// Token: 0x0601AC4C RID: 109644 RVA: 0x0042784F File Offset: 0x00425A4F
		public bool Has_PrefabInstance_C91()
		{
			return false;
		}

		// Token: 0x0601AC4D RID: 109645 RVA: 0x00427852 File Offset: 0x00425A52
		public bool Has_PrefabInternal_C91()
		{
			return true;
		}

		// Token: 0x0601AC4E RID: 109646 RVA: 0x00427855 File Offset: 0x00425A55
		public bool Has_StateMachineBehaviours_C91()
		{
			return true;
		}

		// Token: 0x0601AC4F RID: 109647 RVA: 0x00427858 File Offset: 0x00425A58
		public bool Has_StateMachineBehaviourVectorDescription_C91()
		{
			return true;
		}

		// Token: 0x0601AC50 RID: 109648 RVA: 0x0042785C File Offset: 0x00425A5C
		public override void ReadRelease(AssetReader reader)
		{
			this.m_Name.ReadRelease_AssetAlign(reader);
			this.m_ControllerSize = reader.ReadUInt32();
			this.m_Controller.ReadRelease(reader);
			this.m_TOS.ReadRelease_Map_UInt32_Utf8String(reader);
			this.m_AnimationClips.ReadRelease_ArrayAlign_Asset(reader);
			this.m_StateMachineBehaviourVectorDescription.ReadRelease(reader);
			this.m_StateMachineBehaviours.ReadRelease_ArrayAlign_Asset(reader);
			this.m_MultiThreadedStateMachine = reader.ReadRelease_BooleanAlign();
		}

		// Token: 0x0601AC51 RID: 109649 RVA: 0x004278CC File Offset: 0x00425ACC
		public override void ReadEditor(AssetReader reader)
		{
		}

		// Token: 0x0601AC52 RID: 109650 RVA: 0x00427924 File Offset: 0x00425B24
		public override void WriteRelease(AssetWriter writer)
		{
			this.m_Name.WriteRelease_AssetAlign(writer);
			this.m_ControllerSize.WriteRelease_UInt32(writer);
			this.m_Controller.WriteRelease(writer);
			this.m_TOS.WriteRelease_Map_UInt32_Utf8String(writer);
			this.m_AnimationClips.WriteRelease_ArrayAlign_Asset(writer);
			this.m_StateMachineBehaviourVectorDescription.WriteRelease(writer);
			this.m_StateMachineBehaviours.WriteRelease_ArrayAlign_Asset(writer);
			this.m_MultiThreadedStateMachine.WriteRelease_BooleanAlign(writer);
		}

		// Token: 0x0601AC53 RID: 109651 RVA: 0x00427994 File Offset: 0x00425B94
		public override void WriteEditor(AssetWriter writer)
		{
		}

		// Token: 0x0601AC54 RID: 109652 RVA: 0x004279EC File Offset: 0x00425BEC
		public override YamlNode ExportYamlRelease(IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			YamlSerializedVersionExtensions.AddSerializedVersion(yamlMappingNode, 5);
			yamlMappingNode.Add(new YamlScalarNode("m_Name"), this.m_Name.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("m_ControllerSize"), this.m_ControllerSize.ExportYamlRelease_UInt32(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Controller"), this.m_Controller.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("m_TOS"), this.m_TOS.ExportYamlRelease_Map_UInt32_Utf8String(container));
			yamlMappingNode.Add(new YamlScalarNode("m_AnimationClips"), this.m_AnimationClips.ExportYamlRelease_Array_PPtr_AnimationClip_5_0_0_GICB2(container));
			yamlMappingNode.Add(new YamlScalarNode("m_StateMachineBehaviourVectorDescription"), this.m_StateMachineBehaviourVectorDescription.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("m_StateMachineBehaviours"), this.m_StateMachineBehaviours.ExportYamlRelease_Array_PPtr_MonoBehaviour_5_0_0(container));
			yamlMappingNode.Add(new YamlScalarNode("m_MultiThreadedStateMachine"), this.m_MultiThreadedStateMachine.ExportYamlRelease_Boolean(container));
			return yamlMappingNode;
		}

		// Token: 0x0601AC55 RID: 109653 RVA: 0x00427AE8 File Offset: 0x00425CE8
		public override YamlNode ExportYamlEditor(IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			YamlSerializedVersionExtensions.AddSerializedVersion(yamlMappingNode, 5);
			yamlMappingNode.Add(new YamlScalarNode("m_ObjectHideFlags"), this.m_HideFlags.ExportYamlEditor_UInt32(container));
			yamlMappingNode.Add(new YamlScalarNode("m_PrefabParentObject"), this.m_CorrespondingSourceObject.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_PrefabInternal"), this.m_PrefabInternal.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Name"), this.m_Name.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_AnimatorParameters"), this.m_AnimatorParameters.ExportYamlEditor_Array_AnimatorControllerParameter_5_0_0(container));
			yamlMappingNode.Add(new YamlScalarNode("m_AnimatorLayers"), this.m_AnimatorLayers.ExportYamlEditor_Array_AnimatorControllerLayer_2017_1_0(container));
			return yamlMappingNode;
		}

		// Token: 0x0601AC56 RID: 109654 RVA: 0x00427BAC File Offset: 0x00425DAC
		public override void Reset()
		{
			this.m_AnimationClips.Clear();
			this.m_AnimatorLayers.Clear();
			this.m_AnimatorParameters.Clear();
			this.m_Controller.Reset();
			this.m_ControllerSize = 0U;
			this.m_CorrespondingSourceObject.Reset();
			this.m_HideFlags = 0U;
			this.m_MultiThreadedStateMachine = false;
			this.m_Name.Reset();
			this.m_PrefabInternal.Reset();
			this.m_StateMachineBehaviours.Clear();
			this.m_StateMachineBehaviourVectorDescription.Reset();
			this.m_TOS.Clear();
		}

		// Token: 0x0601AC58 RID: 109656 RVA: 0x00427C4C File Offset: 0x00425E4C
		public void CopyValues(IAnimatorController_ACL source, PPtrConverter converter)
		{
			CopyValuesHelper.CopyValues__AssetList_PPtr_AnimationClip_5_0_0_GICB2__AccessListBase_IPPtr_AnimationClip(this.m_AnimationClips, source.AnimationClips_C91, converter);
			CopyValuesHelper.CopyValues__AssetList_AnimatorControllerLayer_2017_1_0__AccessListBase_IAnimatorControllerLayer(this.m_AnimatorLayers, source.AnimatorLayers_C91, converter);
			CopyValuesHelper.CopyValues__AssetList_AnimatorControllerParameter_5_0_0__AccessListBase_IAnimatorControllerParameter(this.m_AnimatorParameters, source.AnimatorParameters_C91, converter);
			this.m_Controller.CopyValues(source.Controller_C91);
			this.m_ControllerSize = source.ControllerSize_C91;
			this.m_CorrespondingSourceObject.CopyValues(source.CorrespondingSourceObject_C91, converter);
			this.m_HideFlags = source.HideFlags_C91;
			this.m_MultiThreadedStateMachine = source.MultiThreadedStateMachine_C91;
			this.m_Name.CopyValues(source.Name_C91);
			this.m_PrefabInternal.CopyValues(source.PrefabInternal_C91, converter);
			CopyValuesHelper.CopyValues__AssetList_PPtr_MonoBehaviour_5_0_0__AssetList_PPtr_MonoBehaviour_5_0_0(this.m_StateMachineBehaviours, source.StateMachineBehaviours_C91, converter);
			this.m_StateMachineBehaviourVectorDescription.CopyValues(source.StateMachineBehaviourVectorDescription_C91);
			CopyValuesHelper.CopyValues__AssetDictionary_UInt32_Utf8String__AssetDictionary_UInt32_Utf8String(this.m_TOS, source.TOS_C91);
		}

		// Token: 0x0601AC59 RID: 109657 RVA: 0x00427D2D File Offset: 0x00425F2D
		public void CopyValues(IAnimatorController_ACL source)
		{
			this.CopyValues(source, new PPtrConverter(source, this));
		}

		// Token: 0x0601AC5A RID: 109658 RVA: 0x00427D40 File Offset: 0x00425F40

		public override void CopyValues(IUnityAssetBase source, PPtrConverter converter)
		{
			IAnimatorController_ACL animatorController = source as IAnimatorController_ACL;
			if (animatorController != null)
			{
				this.CopyValues(animatorController, converter);
				return;
			}
			base.CopyValues(source, converter);
		}

		// Token: 0x0601AC5B RID: 109659 RVA: 0x00427D68 File Offset: 0x00425F68
		public override List<TypeTreeNode> MakeEditorTypeTreeNodes(int depth, int startingIndex)
		{
			throw new NotSupportedException();
		}

		// Token: 0x0601AC5C RID: 109660 RVA: 0x00427D6F File Offset: 0x00425F6F
		public override List<TypeTreeNode> MakeReleaseTypeTreeNodes(int depth, int startingIndex)
		{
			throw new NotSupportedException();
		}

		// Token: 0x04010C4E RID: 68686
		public uint m_ControllerSize;

		// Token: 0x04010C4F RID: 68687
		public ControllerConstant_5_5_0 m_Controller;

		// Token: 0x04010C50 RID: 68688
		public AssetDictionary<uint, Utf8String> m_TOS;

		// Token: 0x04010C51 RID: 68689
		public AssetList<PPtr_AnimationClip_5_0_0_GICB2> m_AnimationClips;

		// Token: 0x04010C52 RID: 68690
		public StateMachineBehaviourVectorDescription_2017_1_0 m_StateMachineBehaviourVectorDescription;

		// Token: 0x04010C53 RID: 68691
		public AssetList<PPtr_MonoBehaviour_5_0_0> m_StateMachineBehaviours;

		// Token: 0x04010C54 RID: 68692
		public bool m_MultiThreadedStateMachine;

		// Token: 0x04010C55 RID: 68693
		public AssetList<AnimatorControllerParameter_5_0_0> m_AnimatorParameters;

		// Token: 0x04010C56 RID: 68694
		public AssetList<AnimatorControllerLayer_2017_1_0> m_AnimatorLayers;
	}
}
