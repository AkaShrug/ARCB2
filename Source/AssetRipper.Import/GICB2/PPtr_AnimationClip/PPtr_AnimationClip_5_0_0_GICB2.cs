using System;
using System.Collections.Generic;
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
using AssetRipper.SourceGenerated.Classes.ClassID_74;
using AssetRipper.Yaml;
using AssetRipper.IClasses.PPtr_AnimationClip;
using AssetRipper.IClasses.AnimationClip;
using AssetRipper.SourceGenerated.Helpers;

namespace AssetRipper.Import.GICB2.PPtr_AnimationClip
{
	// Token: 0x0200067C RID: 1660
	public sealed class PPtr_AnimationClip_5_0_0_GICB2 : UnityAssetBase, IPPtr_AnimationClip_ACL, IUnityAssetBase, IAsset, IAssetReadable, IAssetWritable, IYamlExportable, IDependent, ITypeTreeSerializable, IPPtr<IAnimationClip_ACL>, IPPtr, IEquatable<IPPtr_AnimationClip_ACL>, IEquatable<PPtr_AnimationClip_5_0_0_GICB2>
	{
		// Token: 0x17002EE4 RID: 12004
		// (get) Token: 0x0600B488 RID: 46216 RVA: 0x001BC18C File Offset: 0x001BA38C
		// (set) Token: 0x0600B489 RID: 46217 RVA: 0x001BC194 File Offset: 0x001BA394
		public int FileID_
		{
			get
			{
				return this.m_FileID_;
			}
			set
			{
				this.m_FileID_ = value;
			}
		}

		// Token: 0x17002EE5 RID: 12005
		// (get) Token: 0x0600B48A RID: 46218 RVA: 0x001BC19D File Offset: 0x001BA39D
		// (set) Token: 0x0600B48B RID: 46219 RVA: 0x001BC1A0 File Offset: 0x001BA3A0
		public int PathID__Int32
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x17002EE6 RID: 12006
		// (get) Token: 0x0600B48C RID: 46220 RVA: 0x001BC1A2 File Offset: 0x001BA3A2
		// (set) Token: 0x0600B48D RID: 46221 RVA: 0x001BC1AA File Offset: 0x001BA3AA
		public long PathID__Int64
		{
			get
			{
				return this.m_PathID_;
			}
			set
			{
				this.m_PathID_ = value;
			}
		}

		// Token: 0x17002EE7 RID: 12007
		// (get) Token: 0x0600B48E RID: 46222 RVA: 0x001BC1B3 File Offset: 0x001BA3B3
		// (set) Token: 0x0600B48F RID: 46223 RVA: 0x001BC1BB File Offset: 0x001BA3BB
		public int FileID
		{
			get
			{
				return this.m_FileID_;
			}
			set
			{
				this.m_FileID_ = value;
			}
		}

		// Token: 0x17002EE8 RID: 12008
		// (get) Token: 0x0600B490 RID: 46224 RVA: 0x001BC1C4 File Offset: 0x001BA3C4
		// (set) Token: 0x0600B491 RID: 46225 RVA: 0x001BC1CC File Offset: 0x001BA3CC
		public long PathID
		{
			get
			{
				return this.m_PathID_;
			}
			set
			{
				this.m_PathID_ = value;
			}
		}

		// Token: 0x0600B492 RID: 46226 RVA: 0x001BC1D5 File Offset: 0x001BA3D5
		public bool Has_PathID__Int32()
		{
			return false;
		}

		// Token: 0x0600B493 RID: 46227 RVA: 0x001BC1D8 File Offset: 0x001BA3D8
		public bool Has_PathID__Int64()
		{
			return true;
		}

		// Token: 0x0600B494 RID: 46228 RVA: 0x001BC1DB File Offset: 0x001BA3DB
		public static implicit operator PPtr<IAnimationClip_ACL>(PPtr_AnimationClip_5_0_0_GICB2 value)
		{
			return new PPtr<IAnimationClip_ACL>(value.m_FileID_, value.m_PathID_);
		}

		// Token: 0x0600B495 RID: 46229 RVA: 0x001BC1EE File Offset: 0x001BA3EE
		public static implicit operator PPtr<IUnityObjectBase>(PPtr_AnimationClip_5_0_0_GICB2 value)
		{
			return new PPtr<IUnityObjectBase>(value.m_FileID_, value.m_PathID_);
		}

		// Token: 0x0600B496 RID: 46230 RVA: 0x001BC201 File Offset: 0x001BA401
		public override void ReadRelease(AssetReader reader)
		{
			this.m_FileID_ = reader.ReadInt32();
			this.m_PathID_ = reader.ReadInt64();
		}

		// Token: 0x0600B497 RID: 46231 RVA: 0x001BC21B File Offset: 0x001BA41B
		public override void ReadEditor(AssetReader reader)
		{
		}

		// Token: 0x0600B498 RID: 46232 RVA: 0x001BC235 File Offset: 0x001BA435
		public override void WriteRelease(AssetWriter writer)
		{
			this.m_FileID_.WriteRelease_Int32(writer);
			this.m_PathID_.WriteRelease_Int64(writer);
		}

		// Token: 0x0600B499 RID: 46233 RVA: 0x001BC24F File Offset: 0x001BA44F
		public override void WriteEditor(AssetWriter writer)
		{
		}

		// Token: 0x0600B49A RID: 46234 RVA: 0x001BC269 File Offset: 0x001BA469
		public override YamlNode ExportYamlRelease(IExportContainer container)
		{
			return PPtrExtensions.ExportYaml<IAnimationClip_ACL>(this, container, 74);
		}

		// Token: 0x0600B49B RID: 46235 RVA: 0x001BC274 File Offset: 0x001BA474
		public override YamlNode ExportYamlEditor(IExportContainer container)
		{
			return PPtrExtensions.ExportYaml<IAnimationClip_ACL>(this, container, 74);
		}

		// Token: 0x0600B49C RID: 46236 RVA: 0x001BC27F File Offset: 0x001BA47F
		public override void Reset()
		{
			this.m_FileID_ = 0;
			this.m_PathID_ = 0L;
		}

		// Token: 0x0600B49D RID: 46237 RVA: 0x001BC290 File Offset: 0x001BA490



		// Token: 0x0600B49E RID: 46238 RVA: 0x001BC2A3 File Offset: 0x001BA4A3

		public void CopyValues(IPPtr_AnimationClip_ACL source, PPtrConverter converter)
		{
			if (source != null)
			{
				CopyValuesHelper.CopyPPtr<IAnimationClip_ACL>(this, source, converter);
				return;
			}
			this.Reset();
		}

		// Token: 0x0600B49F RID: 46239 RVA: 0x001BC2B7 File Offset: 0x001BA4B7
		public IPPtr_AnimationClip_ACL DeepClone(PPtrConverter converter)
		{
			PPtr_AnimationClip_5_0_0_GICB2 pptr_AnimationClip_5_0_0_f = new PPtr_AnimationClip_5_0_0_GICB2();
			pptr_AnimationClip_5_0_0_f.CopyValues(this, converter);
			return pptr_AnimationClip_5_0_0_f;
		}

		// Token: 0x0600B4A0 RID: 46240 RVA: 0x001BC2C8 File Offset: 0x001BA4C8

		public override void CopyValues(IUnityAssetBase source, PPtrConverter converter)
		{
			IPPtr_AnimationClip_ACL ipptr_AnimationClip = source as IPPtr_AnimationClip_ACL;
			if (ipptr_AnimationClip != null)
			{
				this.CopyValues(ipptr_AnimationClip, converter);
				return;
			}
			this.Reset();
		}

		// Token: 0x0600B4A1 RID: 46241 RVA: 0x001BC2EE File Offset: 0x001BA4EE

		public bool Equals(IPPtr_AnimationClip_ACL other)
		{
			return other != null && this.FileID_ == other.FileID_ && this.PathID__Int32 == other.PathID__Int32 && this.PathID__Int64 == other.PathID__Int64;
		}

		// Token: 0x0600B4A2 RID: 46242 RVA: 0x001BC320 File Offset: 0x001BA520

		public bool Equals(PPtr_AnimationClip_5_0_0_GICB2 other)
		{
			return other != null && this.m_FileID_ == other.m_FileID_ && this.m_PathID_ == other.m_PathID_;
		}

		// Token: 0x0600B4A3 RID: 46243 RVA: 0x001BC344 File Offset: 0x001BA544

		public override bool Equals(object other)
		{
			return this.Equals(other as IPPtr_AnimationClip_ACL);
		}

		// Token: 0x0600B4A4 RID: 46244 RVA: 0x001BC352 File Offset: 0x001BA552

		public static bool operator ==(PPtr_AnimationClip_5_0_0_GICB2 left, PPtr_AnimationClip_5_0_0_GICB2 right)
		{
			return EqualityComparer<PPtr_AnimationClip_5_0_0_GICB2>.Default.Equals(left, right);
		}

		// Token: 0x0600B4A5 RID: 46245 RVA: 0x001BC360 File Offset: 0x001BA560

		public static bool operator !=(PPtr_AnimationClip_5_0_0_GICB2 left, PPtr_AnimationClip_5_0_0_GICB2 right)
		{
			return !(left == right);
		}

		// Token: 0x0600B4A6 RID: 46246 RVA: 0x001BC36C File Offset: 0x001BA56C
		public override int GetHashCode()
		{
			HashCode hashCode = default(HashCode);
			hashCode.Add<int>(this.FileID_);
			hashCode.Add<int>(this.PathID__Int32);
			hashCode.Add<long>(this.PathID__Int64);
			return hashCode.ToHashCode();
		}

		// Token: 0x0600B4A7 RID: 46247 RVA: 0x001BC3AF File Offset: 0x001BA5AF
		public void SetValues(int fileID_, int pathID__Int32, long pathID__Int64)
		{
			this.FileID_ = fileID_;
			this.PathID__Int32 = pathID__Int32;
			this.PathID__Int64 = pathID__Int64;
		}

		// Token: 0x0600B4A8 RID: 46248 RVA: 0x001BC3C6 File Offset: 0x001BA5C6
		public override List<TypeTreeNode> MakeEditorTypeTreeNodes(int depth, int startingIndex)
		{
			throw new NotSupportedException();
		}

		// Token: 0x0600B4A9 RID: 46249 RVA: 0x001BC3CD File Offset: 0x001BA5CD
		public override List<TypeTreeNode> MakeReleaseTypeTreeNodes(int depth, int startingIndex)
		{
			throw new NotSupportedException();
		}

		// Token: 0x04001CC4 RID: 7364
		public int m_FileID_;

		// Token: 0x04001CC5 RID: 7365
		public long m_PathID_;
	}
}
