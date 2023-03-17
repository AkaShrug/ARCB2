using System.Diagnostics.CodeAnalysis;
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
using AssetRipper.SourceGenerated.Classes.ClassID_1002;
using AssetRipper.SourceGenerated.Classes.ClassID_130;
using AssetRipper.SourceGenerated.Classes.ClassID_18;
using AssetRipper.SourceGenerated.Enums;
using AssetRipper.SourceGenerated.Helpers;
using AssetRipper.SourceGenerated.Interfaces;
using AssetRipper.SourceGenerated.MarkerInterfaces;
using AssetRipper.SourceGenerated.Subclasses.AABB;
using AssetRipper.SourceGenerated.Subclasses.BlendShapeData;
using AssetRipper.SourceGenerated.Subclasses.BoneWeights4;
using AssetRipper.SourceGenerated.Subclasses.ColorRGBA32;
using AssetRipper.SourceGenerated.Subclasses.CompressedMesh;
using AssetRipper.SourceGenerated.Subclasses.Matrix4x4f;
using AssetRipper.SourceGenerated.Subclasses.MeshBlendShape;
using AssetRipper.SourceGenerated.Subclasses.MeshBlendShapeVertex;
using AssetRipper.SourceGenerated.Subclasses.MinMaxAABB;
using AssetRipper.SourceGenerated.Subclasses.PPtr_EditorExtensionImpl;
using AssetRipper.SourceGenerated.Subclasses.PPtr_EditorExtension;
using AssetRipper.SourceGenerated.Subclasses.PPtr_PrefabInstance;
using AssetRipper.SourceGenerated.Subclasses.PPtr_Prefab;
using AssetRipper.SourceGenerated.Subclasses.StreamingInfo;
using AssetRipper.SourceGenerated.Subclasses.SubMesh;
using AssetRipper.SourceGenerated.Subclasses.Utf8String;
using AssetRipper.SourceGenerated.Subclasses.VariableBoneCountWeights;
using AssetRipper.SourceGenerated.Subclasses.Vector2f;
using AssetRipper.SourceGenerated.Subclasses.Vector3f;
using AssetRipper.SourceGenerated.Subclasses.Vector4f;
using AssetRipper.SourceGenerated.Subclasses.VertexData;
using AssetRipper.Yaml;
using AssetRipper.SourceGenerated.Classes.ClassID_43;

namespace AssetRipper.Import.GICB2.Mesh
{
	// Token: 0x020028A5 RID: 10405
	public sealed class Mesh_2017_1_0_GICB2 : NamedObject_5_0_0, IMesh, IUnityObjectBase, IUnityAssetBase, IAsset, IAssetReadable, IAssetWritable, IYamlExportable, IDependent, ITypeTreeSerializable, IMeshMarker, IHasName, IHasNameString, INamedObject, INamedObjectMarker, IEditorExtension, IEditorExtensionMarker, IObject, IObjectMarker, IHasHideFlags
	{
		// Token: 0x1700BFF6 RID: 49142
		// (get) Token: 0x06027EF5 RID: 163573 RVA: 0x005AC835 File Offset: 0x005AAA35
		// (set) Token: 0x06027EF6 RID: 163574 RVA: 0x005AC83D File Offset: 0x005AAA3D
		public byte[] BakedConvexCollisionMesh_C43
		{
			[return: NotNull]
			get
			{
				return this.m_BakedConvexCollisionMesh;
			}
			set
			{
				this.m_BakedConvexCollisionMesh = value ?? Array.Empty<byte>();
			}
		}

		// Token: 0x1700BFF7 RID: 49143
		// (get) Token: 0x06027EF7 RID: 163575 RVA: 0x005AC84F File Offset: 0x005AAA4F
		// (set) Token: 0x06027EF8 RID: 163576 RVA: 0x005AC857 File Offset: 0x005AAA57
		public byte[] BakedTriangleCollisionMesh_C43
		{
			[return: NotNull]
			get
			{
				return this.m_BakedTriangleCollisionMesh;
			}
			set
			{
				this.m_BakedTriangleCollisionMesh = value ?? Array.Empty<byte>();
			}
		}

		// Token: 0x1700BFF8 RID: 49144
		// (get) Token: 0x06027EF9 RID: 163577 RVA: 0x005AC869 File Offset: 0x005AAA69

		public AssetList<Matrix4x4f> BindPose_C43
		{

			get
			{
				return this.m_BindPose;
			}
		}

		// Token: 0x1700BFF9 RID: 49145
		// (get) Token: 0x06027EFA RID: 163578 RVA: 0x005AC871 File Offset: 0x005AAA71
		// (set) Token: 0x06027EFB RID: 163579 RVA: 0x005AC879 File Offset: 0x005AAA79
		public uint[] BoneNameHashes_C43
		{
			[return: NotNull]
			get
			{
				return this.m_BoneNameHashes;
			}
			set
			{
				this.m_BoneNameHashes = value ?? Array.Empty<uint>();
			}
		}

		// Token: 0x1700BFFA RID: 49146
		// (get) Token: 0x06027EFC RID: 163580 RVA: 0x005AC88B File Offset: 0x005AAA8B

		public AssetList<MinMaxAABB> BonesAABB_C43
		{

			get
			{
				return null;
			}
		}

		// Token: 0x1700BFFB RID: 49147
		// (get) Token: 0x06027EFD RID: 163581 RVA: 0x005AC88E File Offset: 0x005AAA8E
		// (set) Token: 0x06027EFE RID: 163582 RVA: 0x005AC891 File Offset: 0x005AAA91
		public uint[] CollisionTriangles_C43
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x1700BFFC RID: 49148
		// (get) Token: 0x06027EFF RID: 163583 RVA: 0x005AC893 File Offset: 0x005AAA93
		// (set) Token: 0x06027F00 RID: 163584 RVA: 0x005AC896 File Offset: 0x005AAA96
		public int CollisionVertexCount_C43
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x1700BFFD RID: 49149
		// (get) Token: 0x06027F01 RID: 163585 RVA: 0x005AC898 File Offset: 0x005AAA98

		public AssetList<ColorRGBA32> Colors_C43
		{

			get
			{
				return null;
			}
		}

		// Token: 0x1700BFFE RID: 49150
		// (get) Token: 0x06027F02 RID: 163586 RVA: 0x005AC89B File Offset: 0x005AAA9B

		public ICompressedMesh CompressedMesh_C43
		{

			get
			{
				return this.m_CompressedMesh;
			}
		}

		// Token: 0x1700BFFF RID: 49151
		// (get) Token: 0x06027F03 RID: 163587 RVA: 0x005AC8A3 File Offset: 0x005AAAA3
		// (set) Token: 0x06027F04 RID: 163588 RVA: 0x005AC8A6 File Offset: 0x005AAAA6
		public int CookingOptions_C43
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x1700C000 RID: 49152
		// (get) Token: 0x06027F05 RID: 163589 RVA: 0x005AC8A8 File Offset: 0x005AAAA8
		public IPPtr_EditorExtension CorrespondingSourceObject_C43
		{
			[return: NotNull]
			get
			{
				return this.m_CorrespondingSourceObject;
			}
		}

		// Token: 0x1700C001 RID: 49153
		// (get) Token: 0x06027F06 RID: 163590 RVA: 0x005AC8B0 File Offset: 0x005AAAB0
		public PPtr_EditorExtensionImpl ExtensionPtr_C43
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700C002 RID: 49154
		// (get) Token: 0x06027F07 RID: 163591 RVA: 0x005AC8B3 File Offset: 0x005AAAB3
		// (set) Token: 0x06027F08 RID: 163592 RVA: 0x005AC8BB File Offset: 0x005AAABB
		public uint HideFlags_C43
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

		// Token: 0x1700C003 RID: 49155
		// (get) Token: 0x06027F09 RID: 163593 RVA: 0x005AC8C4 File Offset: 0x005AAAC4
		// (set) Token: 0x06027F0A RID: 163594 RVA: 0x005AC8CC File Offset: 0x005AAACC

		public byte[] IndexBuffer_C43
		{

			get
			{
				return this.m_IndexBuffer;
			}

			set
			{
				this.m_IndexBuffer = value;
			}
		}

		// Token: 0x1700C004 RID: 49156
		// (get) Token: 0x06027F0B RID: 163595 RVA: 0x005AC8D5 File Offset: 0x005AAAD5
		// (set) Token: 0x06027F0C RID: 163596 RVA: 0x005AC8D8 File Offset: 0x005AAAD8
		public int IndexFormat_C43
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x1700C005 RID: 49157
		// (get) Token: 0x06027F0D RID: 163597 RVA: 0x005AC8DA File Offset: 0x005AAADA
		// (set) Token: 0x06027F0E RID: 163598 RVA: 0x005AC8E2 File Offset: 0x005AAAE2
		public bool IsReadable_C43
		{
			get
			{
				return this.m_IsReadable;
			}
			set
			{
				this.m_IsReadable = value;
			}
		}

		// Token: 0x1700C006 RID: 49158
		// (get) Token: 0x06027F0F RID: 163599 RVA: 0x005AC8EB File Offset: 0x005AAAEB
		// (set) Token: 0x06027F10 RID: 163600 RVA: 0x005AC8F3 File Offset: 0x005AAAF3
		public bool KeepIndices_C43
		{
			get
			{
				return this.m_KeepIndices;
			}
			set
			{
				this.m_KeepIndices = value;
			}
		}

		// Token: 0x1700C007 RID: 49159
		// (get) Token: 0x06027F11 RID: 163601 RVA: 0x005AC8FC File Offset: 0x005AAAFC
		// (set) Token: 0x06027F12 RID: 163602 RVA: 0x005AC904 File Offset: 0x005AAB04
		public bool KeepVertices_C43
		{
			get
			{
				return this.m_KeepVertices;
			}
			set
			{
				this.m_KeepVertices = value;
			}
		}

		// Token: 0x1700C008 RID: 49160
		// (get) Token: 0x06027F13 RID: 163603 RVA: 0x005AC90D File Offset: 0x005AAB0D

		public IAABB LocalAABB_C43
		{

			get
			{
				return this.m_LocalAABB;
			}
		}

		// Token: 0x1700C009 RID: 49161
		// (get) Token: 0x06027F14 RID: 163604 RVA: 0x005AC915 File Offset: 0x005AAB15
		// (set) Token: 0x06027F15 RID: 163605 RVA: 0x005AC91D File Offset: 0x005AAB1D
		public byte MeshCompression_C43
		{
			get
			{
				return this.m_MeshCompression;
			}
			set
			{
				this.m_MeshCompression = value;
			}
		}

		// Token: 0x1700C00A RID: 49162
		// (get) Token: 0x06027F16 RID: 163606 RVA: 0x005AC926 File Offset: 0x005AAB26
		// (set) Token: 0x06027F17 RID: 163607 RVA: 0x005AC92D File Offset: 0x005AAB2D
		public float MeshMetrics_0__C43
		{
			get
			{
				return this.m_MeshMetrics_0;
			}
			set
			{
				this.m_MeshMetrics_0 = value;
			}
		}

		// Token: 0x1700C00B RID: 49163
		// (get) Token: 0x06027F18 RID: 163608 RVA: 0x005AC92F File Offset: 0x005AAB2F
		// (set) Token: 0x06027F19 RID: 163609 RVA: 0x005AC936 File Offset: 0x005AAB36
		public float MeshMetrics_1__C43
		{
			get
			{
				return m_MeshMetrics_1;
			}
			set
			{
				this.m_MeshMetrics_1 = value;
			}
		}

		// Token: 0x1700C00C RID: 49164
		// (get) Token: 0x06027F1A RID: 163610 RVA: 0x005AC938 File Offset: 0x005AAB38
		// (set) Token: 0x06027F1B RID: 163611 RVA: 0x005AC93B File Offset: 0x005AAB3B
		public int MeshOptimizationFlags_C43
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x1700C00D RID: 49165
		// (get) Token: 0x06027F1C RID: 163612 RVA: 0x005AC93D File Offset: 0x005AAB3D
		// (set) Token: 0x06027F1D RID: 163613 RVA: 0x005AC945 File Offset: 0x005AAB45
		public bool MeshOptimized_C43
		{
			get
			{
				return this.m_MeshOptimized;
			}
			set
			{
				this.m_MeshOptimized = value;
			}
		}

		// Token: 0x1700C00E RID: 49166
		// (get) Token: 0x06027F1E RID: 163614 RVA: 0x005AC94E File Offset: 0x005AAB4E
		// (set) Token: 0x06027F1F RID: 163615 RVA: 0x005AC956 File Offset: 0x005AAB56
		public int MeshUsageFlags_C43
		{
			get
			{
				return this.m_MeshUsageFlags;
			}
			set
			{
				this.m_MeshUsageFlags = value;
			}
		}

		// Token: 0x1700C00F RID: 49167
		// (get) Token: 0x06027F20 RID: 163616 RVA: 0x005AC95F File Offset: 0x005AAB5F

		public Utf8String Name_C43
		{

			get
			{
				return this.m_Name;
			}
		}

		// Token: 0x1700C010 RID: 49168
		// (get) Token: 0x06027F21 RID: 163617 RVA: 0x005AC967 File Offset: 0x005AAB67

		public AssetList<Vector3f_3_4_0> Normals_C43
		{

			get
			{
				return null;
			}
		}

		// Token: 0x1700C011 RID: 49169
		// (get) Token: 0x06027F22 RID: 163618 RVA: 0x005AC96A File Offset: 0x005AAB6A
		public PPtr_Prefab_2018_3_0 PrefabAsset_C43
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700C012 RID: 49170
		// (get) Token: 0x06027F23 RID: 163619 RVA: 0x005AC96D File Offset: 0x005AAB6D
		public PPtr_PrefabInstance PrefabInstance_C43
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700C013 RID: 49171
		// (get) Token: 0x06027F24 RID: 163620 RVA: 0x005AC970 File Offset: 0x005AAB70
		public IPPtr_Prefab PrefabInternal_C43
		{
			[return: NotNull]
			get
			{
				return this.m_PrefabInternal;
			}
		}

		// Token: 0x1700C014 RID: 49172
		// (get) Token: 0x06027F25 RID: 163621 RVA: 0x005AC978 File Offset: 0x005AAB78
		// (set) Token: 0x06027F26 RID: 163622 RVA: 0x005AC980 File Offset: 0x005AAB80
		public uint RootBoneNameHash_C43
		{
			get
			{
				return this.m_RootBoneNameHash;
			}
			set
			{
				this.m_RootBoneNameHash = value;
			}
		}

		// Token: 0x1700C015 RID: 49173
		// (get) Token: 0x06027F27 RID: 163623 RVA: 0x005AC989 File Offset: 0x005AAB89
		public IBlendShapeData Shapes_C43
		{
			[return: NotNull]
			get
			{
				return this.m_Shapes;
			}
		}

		// Token: 0x1700C016 RID: 49174
		// (get) Token: 0x06027F28 RID: 163624 RVA: 0x005AC991 File Offset: 0x005AAB91

		public AssetList<MeshBlendShape_4_1_0> ShapesList_C43
		{

			get
			{
				return null;
			}
		}

		// Token: 0x1700C017 RID: 49175
		// (get) Token: 0x06027F29 RID: 163625 RVA: 0x005AC994 File Offset: 0x005AAB94

		public AssetList<MeshBlendShapeVertex> ShapeVertices_C43
		{

			get
			{
				return null;
			}
		}

		// Token: 0x1700C018 RID: 49176
		// (get) Token: 0x06027F2A RID: 163626 RVA: 0x005AC997 File Offset: 0x005AAB97

		public AccessListBase<IBoneWeights4> Skin_C43
		{

			[return: NotNull]
			get
			{
				return new AccessList<BoneWeights4_2017_1_0, IBoneWeights4>(this.m_Skin);
			}
		}

		// Token: 0x1700C019 RID: 49177
		// (get) Token: 0x06027F2B RID: 163627 RVA: 0x005AC9A4 File Offset: 0x005AABA4
		// (set) Token: 0x06027F2C RID: 163628 RVA: 0x005AC9A7 File Offset: 0x005AABA7
		public byte StreamCompression_C43
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x1700C01A RID: 49178
		// (get) Token: 0x06027F2D RID: 163629 RVA: 0x005AC9A9 File Offset: 0x005AABA9
		public IStreamingInfo StreamData_C43
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700C01B RID: 49179
		// (get) Token: 0x06027F2E RID: 163630 RVA: 0x005AC9AC File Offset: 0x005AABAC

		public AccessListBase<ISubMesh> SubMeshes_C43
		{

			get
			{
				return new AccessList<SubMesh_4_0_0, ISubMesh>(this.m_SubMeshes);
			}
		}

		// Token: 0x1700C01C RID: 49180
		// (get) Token: 0x06027F2F RID: 163631 RVA: 0x005AC9B9 File Offset: 0x005AABB9

		public AssetList<Vector4f_3_4_0> Tangents_C43
		{

			get
			{
				return null;
			}
		}

		// Token: 0x1700C01D RID: 49181
		// (get) Token: 0x06027F30 RID: 163632 RVA: 0x005AC9BC File Offset: 0x005AABBC
		// (set) Token: 0x06027F31 RID: 163633 RVA: 0x005AC9BF File Offset: 0x005AABBF
		public int Use16BitIndices_C43
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x1700C01E RID: 49182
		// (get) Token: 0x06027F32 RID: 163634 RVA: 0x005AC9C1 File Offset: 0x005AABC1

		public AssetList<Vector2f_3_4_0> UV_C43
		{

			get
			{
				return null;
			}
		}

		// Token: 0x1700C01F RID: 49183
		// (get) Token: 0x06027F33 RID: 163635 RVA: 0x005AC9C4 File Offset: 0x005AABC4

		public AssetList<Vector2f_3_4_0> UV1_C43
		{

			get
			{
				return null;
			}
		}

		// Token: 0x1700C020 RID: 49184
		// (get) Token: 0x06027F34 RID: 163636 RVA: 0x005AC9C7 File Offset: 0x005AABC7
		public VariableBoneCountWeights VariableBoneCountWeights_C43
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700C021 RID: 49185
		// (get) Token: 0x06027F35 RID: 163637 RVA: 0x005AC9CA File Offset: 0x005AABCA
		public IVertexData VertexData_C43
		{
			[return: NotNull]
			get
			{
				return this.m_VertexData;
			}
		}

		// Token: 0x1700C022 RID: 49186
		// (get) Token: 0x06027F36 RID: 163638 RVA: 0x005AC9D2 File Offset: 0x005AABD2

		public AssetList<Vector3f_3_4_0> Vertices_C43
		{

			get
			{
				return null;
			}
		}

		// Token: 0x1700C023 RID: 49187
		// (get) Token: 0x06027F37 RID: 163639 RVA: 0x005AC9D5 File Offset: 0x005AABD5
		// (set) Token: 0x06027F38 RID: 163640 RVA: 0x005AC9DD File Offset: 0x005AABDD
		public HideFlags HideFlags_C43E
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

		// Token: 0x1700C024 RID: 49188
		// (get) Token: 0x06027F39 RID: 163641 RVA: 0x005AC9E6 File Offset: 0x005AABE6
		// (set) Token: 0x06027F3A RID: 163642 RVA: 0x005AC9E9 File Offset: 0x005AABE9
		public IndexFormat IndexFormat_C43E
		{
			get
			{
				return IndexFormat.UInt16;
			}
			set
			{
			}
		}

		// Token: 0x1700C025 RID: 49189
		// (get) Token: 0x06027F3B RID: 163643 RVA: 0x005AC9EB File Offset: 0x005AABEB
		// (set) Token: 0x06027F3C RID: 163644 RVA: 0x005AC9FE File Offset: 0x005AABFE
		public IEditorExtension CorrespondingSourceObject_C43P
		{
			get
			{
				return PPtrExtensions.TryGetAsset<IEditorExtension>(this.CorrespondingSourceObject_C43, base.Collection);
			}
			set
			{
				PPtrExtensions.SetAsset<IEditorExtension>(this.CorrespondingSourceObject_C43, base.Collection, value);
			}
		}

		// Token: 0x1700C026 RID: 49190
		// (get) Token: 0x06027F3D RID: 163645 RVA: 0x005ACA12 File Offset: 0x005AAC12
		// (set) Token: 0x06027F3E RID: 163646 RVA: 0x005ACA15 File Offset: 0x005AAC15
		public IEditorExtensionImpl ExtensionPtr_C43P
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x1700C027 RID: 49191
		// (get) Token: 0x06027F3F RID: 163647 RVA: 0x005ACA17 File Offset: 0x005AAC17
		// (set) Token: 0x06027F40 RID: 163648 RVA: 0x005ACA1A File Offset: 0x005AAC1A
		public IPrefab PrefabAsset_C43P
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x1700C028 RID: 49192
		// (get) Token: 0x06027F41 RID: 163649 RVA: 0x005ACA1C File Offset: 0x005AAC1C
		// (set) Token: 0x06027F42 RID: 163650 RVA: 0x005ACA1F File Offset: 0x005AAC1F
		public IPrefabInstance PrefabInstance_C43P
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x1700C029 RID: 49193
		// (get) Token: 0x06027F43 RID: 163651 RVA: 0x005ACA21 File Offset: 0x005AAC21
		// (set) Token: 0x06027F44 RID: 163652 RVA: 0x005ACA34 File Offset: 0x005AAC34
		public IPrefabMarker PrefabInternal_C43P
		{
			get
			{
				return PPtrExtensions.TryGetAsset<IPrefabMarker>(this.PrefabInternal_C43, base.Collection);
			}
			set
			{
				PPtrExtensions.SetAsset<IPrefabMarker>(this.PrefabInternal_C43, base.Collection, value);
			}
		}

		// Token: 0x1700C02A RID: 49194
		// (get) Token: 0x06027F45 RID: 163653 RVA: 0x005ACA48 File Offset: 0x005AAC48

		public override string ClassName
		{

			get
			{
				return "Mesh";
			}
		}

		// Token: 0x06027F46 RID: 163654 RVA: 0x005ACA4F File Offset: 0x005AAC4F
		public Mesh_2017_1_0_GICB2()
			: this(AssetInfo.MakeDummyAssetInfo(43))
		{
		}

		// Token: 0x06027F47 RID: 163655 RVA: 0x005ACA60 File Offset: 0x005AAC60
		public Mesh_2017_1_0_GICB2(AssetInfo info)
			: base(info)
		{
			this.m_SubMeshes = new AssetList<SubMesh_4_0_0>();
			this.m_Shapes = new BlendShapeData_2017_1_0();
			this.m_BindPose = new AssetList<Matrix4x4f>();
			this.m_BoneNameHashes = Array.Empty<uint>();
			this.m_IndexBuffer = Array.Empty<byte>();
			this.m_Skin = new AssetList<BoneWeights4_2017_1_0>();
			this.m_VertexData = new VertexData_2017_1_0();
			this.m_CompressedMesh = new CompressedMesh_5_0_0();
			this.m_LocalAABB = new AABB_3_5_0();
			this.m_BakedConvexCollisionMesh = Array.Empty<byte>();
			this.m_BakedTriangleCollisionMesh = Array.Empty<byte>();
		}

		// Token: 0x06027F48 RID: 163656 RVA: 0x005ACAED File Offset: 0x005AACED
		public bool Has_BakedConvexCollisionMesh_C43()
		{
			return true;
		}

		// Token: 0x06027F49 RID: 163657 RVA: 0x005ACAF0 File Offset: 0x005AACF0
		public bool Has_BakedTriangleCollisionMesh_C43()
		{
			return true;
		}

		// Token: 0x06027F4A RID: 163658 RVA: 0x005ACAF3 File Offset: 0x005AACF3
		public bool Has_BoneNameHashes_C43()
		{
			return true;
		}

		// Token: 0x06027F4B RID: 163659 RVA: 0x005ACAF6 File Offset: 0x005AACF6
		public bool Has_BonesAABB_C43()
		{
			return false;
		}

		// Token: 0x06027F4C RID: 163660 RVA: 0x005ACAF9 File Offset: 0x005AACF9
		public bool Has_CollisionTriangles_C43()
		{
			return false;
		}

		// Token: 0x06027F4D RID: 163661 RVA: 0x005ACAFC File Offset: 0x005AACFC
		public bool Has_CollisionVertexCount_C43()
		{
			return false;
		}

		// Token: 0x06027F4E RID: 163662 RVA: 0x005ACAFF File Offset: 0x005AACFF
		public bool Has_Colors_C43()
		{
			return false;
		}

		// Token: 0x06027F4F RID: 163663 RVA: 0x005ACB02 File Offset: 0x005AAD02
		public bool Has_CookingOptions_C43()
		{
			return false;
		}

		// Token: 0x06027F50 RID: 163664 RVA: 0x005ACB05 File Offset: 0x005AAD05
		public bool Has_CorrespondingSourceObject_C43()
		{
			return true;
		}

		// Token: 0x06027F51 RID: 163665 RVA: 0x005ACB08 File Offset: 0x005AAD08
		public bool Has_ExtensionPtr_C43()
		{
			return false;
		}

		// Token: 0x06027F52 RID: 163666 RVA: 0x005ACB0B File Offset: 0x005AAD0B
		public bool Has_IndexFormat_C43()
		{
			return false;
		}

		// Token: 0x06027F53 RID: 163667 RVA: 0x005ACB0E File Offset: 0x005AAD0E
		public bool Has_IsReadable_C43()
		{
			return true;
		}

		// Token: 0x06027F54 RID: 163668 RVA: 0x005ACB11 File Offset: 0x005AAD11
		public bool Has_KeepIndices_C43()
		{
			return true;
		}

		// Token: 0x06027F55 RID: 163669 RVA: 0x005ACB14 File Offset: 0x005AAD14
		public bool Has_KeepVertices_C43()
		{
			return true;
		}

		// Token: 0x06027F56 RID: 163670 RVA: 0x005ACB17 File Offset: 0x005AAD17
		public bool Has_MeshMetrics_0__C43()
		{
			return true;
		}

		// Token: 0x06027F57 RID: 163671 RVA: 0x005ACB1A File Offset: 0x005AAD1A
		public bool Has_MeshMetrics_1__C43()
		{
			return true;
		}

		// Token: 0x06027F58 RID: 163672 RVA: 0x005ACB1D File Offset: 0x005AAD1D
		public bool Has_MeshOptimizationFlags_C43()
		{
			return false;
		}

		// Token: 0x06027F59 RID: 163673 RVA: 0x005ACB20 File Offset: 0x005AAD20
		public bool Has_MeshOptimized_C43()
		{
			return true;
		}

		// Token: 0x06027F5A RID: 163674 RVA: 0x005ACB23 File Offset: 0x005AAD23
		public bool Has_Normals_C43()
		{
			return false;
		}

		// Token: 0x06027F5B RID: 163675 RVA: 0x005ACB26 File Offset: 0x005AAD26
		public bool Has_PrefabAsset_C43()
		{
			return false;
		}

		// Token: 0x06027F5C RID: 163676 RVA: 0x005ACB29 File Offset: 0x005AAD29
		public bool Has_PrefabInstance_C43()
		{
			return false;
		}

		// Token: 0x06027F5D RID: 163677 RVA: 0x005ACB2C File Offset: 0x005AAD2C
		public bool Has_PrefabInternal_C43()
		{
			return true;
		}

		// Token: 0x06027F5E RID: 163678 RVA: 0x005ACB2F File Offset: 0x005AAD2F
		public bool Has_RootBoneNameHash_C43()
		{
			return true;
		}

		// Token: 0x06027F5F RID: 163679 RVA: 0x005ACB32 File Offset: 0x005AAD32
		public bool Has_Shapes_C43()
		{
			return true;
		}

		// Token: 0x06027F60 RID: 163680 RVA: 0x005ACB35 File Offset: 0x005AAD35
		public bool Has_ShapesList_C43()
		{
			return false;
		}

		// Token: 0x06027F61 RID: 163681 RVA: 0x005ACB38 File Offset: 0x005AAD38
		public bool Has_ShapeVertices_C43()
		{
			return false;
		}

		// Token: 0x06027F62 RID: 163682 RVA: 0x005ACB3B File Offset: 0x005AAD3B
		public bool Has_Skin_C43()
		{
			return true;
		}

		// Token: 0x06027F63 RID: 163683 RVA: 0x005ACB3E File Offset: 0x005AAD3E
		public bool Has_StreamCompression_C43()
		{
			return false;
		}

		// Token: 0x06027F64 RID: 163684 RVA: 0x005ACB41 File Offset: 0x005AAD41
		public bool Has_StreamData_C43()
		{
			return false;
		}

		// Token: 0x06027F65 RID: 163685 RVA: 0x005ACB44 File Offset: 0x005AAD44
		public bool Has_Tangents_C43()
		{
			return false;
		}

		// Token: 0x06027F66 RID: 163686 RVA: 0x005ACB47 File Offset: 0x005AAD47
		public bool Has_Use16BitIndices_C43()
		{
			return false;
		}

		// Token: 0x06027F67 RID: 163687 RVA: 0x005ACB4A File Offset: 0x005AAD4A
		public bool Has_UV_C43()
		{
			return false;
		}

		// Token: 0x06027F68 RID: 163688 RVA: 0x005ACB4D File Offset: 0x005AAD4D
		public bool Has_UV1_C43()
		{
			return false;
		}

		// Token: 0x06027F69 RID: 163689 RVA: 0x005ACB50 File Offset: 0x005AAD50
		public bool Has_VariableBoneCountWeights_C43()
		{
			return false;
		}

		// Token: 0x06027F6A RID: 163690 RVA: 0x005ACB53 File Offset: 0x005AAD53
		public bool Has_VertexData_C43()
		{
			return true;
		}

		// Token: 0x06027F6B RID: 163691 RVA: 0x005ACB56 File Offset: 0x005AAD56
		public bool Has_Vertices_C43()
		{
			return false;
		}

		// Token: 0x06027F6C RID: 163692 RVA: 0x005ACB5C File Offset: 0x005AAD5C

		public override void ReadRelease(AssetReader reader)
		{
			this.m_Name.ReadRelease(reader);
			this.m_SubMeshes.ReadRelease_ArrayAlign_Asset(reader);
			this.m_Shapes.ReadRelease(reader);
			this.m_BindPose.ReadRelease_ArrayAlign_Asset(reader);
			this.m_BoneNameHashes = reader.ReadRelease_ArrayAlign_UInt32();
			this.m_RootBoneNameHash = reader.ReadUInt32();
			this.m_MeshCompression = reader.ReadByte();
			this.m_IsReadable = reader.ReadBoolean();
			this.m_KeepVertices = reader.ReadBoolean();
			this.m_KeepIndices = reader.ReadRelease_BooleanAlign();
			this.m_PackSkinDataToUV2UV3 = reader.ReadRelease_BooleanAlign(); // GICB2
			this.m_IndexBuffer = reader.ReadRelease_ArrayAlign_Byte();
			this.m_Skin.ReadRelease_ArrayAlign_Asset(reader);
			this.m_VertexData.ReadRelease_AssetAlign(reader);
			this.m_CompressedMesh.ReadRelease(reader);
			this.m_LocalAABB.ReadRelease(reader);
			this.m_MeshUsageFlags = reader.ReadInt32();
			this.m_BakedConvexCollisionMesh = reader.ReadRelease_ArrayAlign_Byte();
			this.m_BakedTriangleCollisionMesh = reader.ReadRelease_ArrayAlign_Byte();

			// GICB2
			this.m_MeshMetrics_0 = reader.ReadSingle(); // MeshMetrics[0]
			this.m_MeshMetrics_1 = reader.ReadSingle(); // MeshMetrics[1]
			this.m_MetricsDirty = reader.ReadRelease_BooleanAlign();
			this.m_CloseMeshDynamicCompression = reader.ReadRelease_BooleanAlign();
			this.m_IsStreamingMesh = reader.ReadRelease_BooleanAlign();
		}

		// Token: 0x06027F6D RID: 163693 RVA: 0x005ACC44 File Offset: 0x005AAE44

		public override void ReadEditor(AssetReader reader)
		{
		}

		// Token: 0x06027F6E RID: 163694 RVA: 0x005ACD5C File Offset: 0x005AAF5C

		public override void WriteRelease(AssetWriter writer)
		{
			this.m_Name.WriteRelease(writer);
			this.m_SubMeshes.WriteRelease_ArrayAlign_Asset(writer);
			this.m_Shapes.WriteRelease(writer);
			this.m_BindPose.WriteRelease_ArrayAlign_Asset(writer);
			this.m_BoneNameHashes.WriteRelease_ArrayAlign_UInt32(writer);
			this.m_RootBoneNameHash.WriteRelease_UInt32(writer);
			this.m_MeshCompression.WriteRelease_Byte(writer);
			this.m_IsReadable.WriteRelease_Boolean(writer);
			this.m_KeepVertices.WriteRelease_Boolean(writer);
			this.m_KeepIndices.WriteRelease_BooleanAlign(writer);
			this.m_IndexBuffer.WriteRelease_ArrayAlign_Byte(writer);
			this.m_Skin.WriteRelease_ArrayAlign_Asset(writer);
			this.m_VertexData.WriteRelease_AssetAlign(writer);
			this.m_CompressedMesh.WriteRelease(writer);
			this.m_LocalAABB.WriteRelease(writer);
			this.m_MeshUsageFlags.WriteRelease_Int32(writer);
			this.m_BakedConvexCollisionMesh.WriteRelease_ArrayAlign_Byte(writer);
			this.m_BakedTriangleCollisionMesh.WriteRelease_ArrayAlign_Byte(writer);
		}

		// Token: 0x06027F6F RID: 163695 RVA: 0x005ACE44 File Offset: 0x005AB044

		public override void WriteEditor(AssetWriter writer)
		{
		}

		// Token: 0x06027F70 RID: 163696 RVA: 0x005ACF5C File Offset: 0x005AB15C

		public override YamlNode ExportYamlRelease(IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			YamlSerializedVersionExtensions.AddSerializedVersion(yamlMappingNode, 8);
			yamlMappingNode.Add(new YamlScalarNode("m_Name"), this.m_Name.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("m_SubMeshes"), this.m_SubMeshes.ExportYamlRelease_Array_SubMesh_4_0_0(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Shapes"), this.m_Shapes.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("m_BindPose"), this.m_BindPose.ExportYamlRelease_Array_Matrix4x4f(container));
			yamlMappingNode.Add(new YamlScalarNode("m_BoneNameHashes"), this.m_BoneNameHashes.ExportYamlRelease_Array_UInt32(container));
			yamlMappingNode.Add(new YamlScalarNode("m_RootBoneNameHash"), this.m_RootBoneNameHash.ExportYamlRelease_UInt32(container));
			yamlMappingNode.Add(new YamlScalarNode("m_MeshCompression"), this.m_MeshCompression.ExportYamlRelease_Byte(container));
			yamlMappingNode.Add(new YamlScalarNode("m_IsReadable"), this.m_IsReadable.ExportYamlRelease_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("m_KeepVertices"), this.m_KeepVertices.ExportYamlRelease_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("m_KeepIndices"), this.m_KeepIndices.ExportYamlRelease_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("m_IndexBuffer"), this.m_IndexBuffer.ExportYamlRelease_Array_Byte(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Skin"), this.m_Skin.ExportYamlRelease_Array_BoneWeights4_2017_1_0(container));
			yamlMappingNode.Add(new YamlScalarNode("m_VertexData"), this.m_VertexData.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("m_CompressedMesh"), this.m_CompressedMesh.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("m_LocalAABB"), this.m_LocalAABB.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("m_MeshUsageFlags"), this.m_MeshUsageFlags.ExportYamlRelease_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("m_BakedConvexCollisionMesh"), this.m_BakedConvexCollisionMesh.ExportYamlRelease_Array_Byte(container));
			yamlMappingNode.Add(new YamlScalarNode("m_BakedTriangleCollisionMesh"), this.m_BakedTriangleCollisionMesh.ExportYamlRelease_Array_Byte(container));
			return yamlMappingNode;
		}

		// Token: 0x06027F71 RID: 163697 RVA: 0x005AD170 File Offset: 0x005AB370

		public override YamlNode ExportYamlEditor(IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			YamlSerializedVersionExtensions.AddSerializedVersion(yamlMappingNode, 8);
			yamlMappingNode.Add(new YamlScalarNode("m_ObjectHideFlags"), this.m_HideFlags.ExportYamlEditor_UInt32(container));
			yamlMappingNode.Add(new YamlScalarNode("m_PrefabParentObject"), this.m_CorrespondingSourceObject.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_PrefabInternal"), this.m_PrefabInternal.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Name"), this.m_Name.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_SubMeshes"), this.m_SubMeshes.ExportYamlEditor_Array_SubMesh_4_0_0(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Shapes"), this.m_Shapes.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_BindPose"), this.m_BindPose.ExportYamlEditor_Array_Matrix4x4f(container));
			yamlMappingNode.Add(new YamlScalarNode("m_BoneNameHashes"), this.m_BoneNameHashes.ExportYamlEditor_Array_UInt32(container));
			yamlMappingNode.Add(new YamlScalarNode("m_RootBoneNameHash"), this.m_RootBoneNameHash.ExportYamlEditor_UInt32(container));
			yamlMappingNode.Add(new YamlScalarNode("m_MeshCompression"), this.m_MeshCompression.ExportYamlEditor_Byte(container));
			yamlMappingNode.Add(new YamlScalarNode("m_IsReadable"), this.m_IsReadable.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("m_KeepVertices"), this.m_KeepVertices.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("m_KeepIndices"), this.m_KeepIndices.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("m_IndexBuffer"), this.m_IndexBuffer.ExportYamlEditor_Array_Byte(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Skin"), this.m_Skin.ExportYamlEditor_Array_BoneWeights4_2017_1_0(container));
			yamlMappingNode.Add(new YamlScalarNode("m_VertexData"), this.m_VertexData.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_CompressedMesh"), this.m_CompressedMesh.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_LocalAABB"), this.m_LocalAABB.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_MeshUsageFlags"), this.m_MeshUsageFlags.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("m_BakedConvexCollisionMesh"), this.m_BakedConvexCollisionMesh.ExportYamlEditor_Array_Byte(container));
			yamlMappingNode.Add(new YamlScalarNode("m_BakedTriangleCollisionMesh"), this.m_BakedTriangleCollisionMesh.ExportYamlEditor_Array_Byte(container));
			yamlMappingNode.Add(new YamlScalarNode("m_MeshOptimized"), this.m_MeshOptimized.ExportYamlEditor_Boolean(container));
			return yamlMappingNode;
		}

		// Token: 0x06027F72 RID: 163698 RVA: 0x005AD3F4 File Offset: 0x005AB5F4
		public override void Reset()
		{
			this.m_BakedConvexCollisionMesh = Array.Empty<byte>();
			this.m_BakedTriangleCollisionMesh = Array.Empty<byte>();
			this.m_BindPose.Clear();
			this.m_BoneNameHashes = Array.Empty<uint>();
			this.m_CompressedMesh.Reset();
			this.m_CorrespondingSourceObject.Reset();
			this.m_HideFlags = 0U;
			this.m_IndexBuffer = Array.Empty<byte>();
			this.m_IsReadable = false;
			this.m_KeepIndices = false;
			this.m_KeepVertices = false;
			this.m_LocalAABB.Reset();
			this.m_MeshCompression = 0;
			this.m_MeshOptimized = false;
			this.m_MeshUsageFlags = 0;
			this.m_Name.Reset();
			this.m_PrefabInternal.Reset();
			this.m_RootBoneNameHash = 0U;
			this.m_Shapes.Reset();
			this.m_Skin.Clear();
			this.m_SubMeshes.Clear();
			this.m_VertexData.Reset();
		}

		// Token: 0x06027F73 RID: 163699 RVA: 0x005AD4D3 File Offset: 0x005AB6D3
		//public override IEnumerable<ValueTuple<FieldName, PPtr<IUnityObjectBase>>> FetchDependencies(FieldName parent)
		//{
		//	return Enumerable.Empty<ValueTuple<FieldName, PPtr<IUnityObjectBase>>>().Append_Mesh_2017_1_0(parent, this);
		//}

		// Token: 0x06027F74 RID: 163700 RVA: 0x005AD4E4 File Offset: 0x005AB6E4

		public void CopyValues(IMesh source, PPtrConverter converter)
		{
			this.m_BakedConvexCollisionMesh = CopyValuesHelper.DuplicateArray<byte>(source.BakedConvexCollisionMesh_C43);
			this.m_BakedTriangleCollisionMesh = CopyValuesHelper.DuplicateArray<byte>(source.BakedTriangleCollisionMesh_C43);
			CopyValuesHelper.CopyValues__AssetList_Matrix4x4f__AssetList_Matrix4x4f(this.m_BindPose, source.BindPose_C43);
			this.m_BoneNameHashes = CopyValuesHelper.DuplicateArray<uint>(source.BoneNameHashes_C43);
			this.m_CompressedMesh.CopyValues(source.CompressedMesh_C43);
			this.m_CorrespondingSourceObject.CopyValues(source.CorrespondingSourceObject_C43, converter);
			this.m_HideFlags = source.HideFlags_C43;
			this.m_IndexBuffer = CopyValuesHelper.DuplicateArray<byte>(source.IndexBuffer_C43);
			this.m_IsReadable = source.IsReadable_C43;
			this.m_KeepIndices = source.KeepIndices_C43;
			this.m_KeepVertices = source.KeepVertices_C43;
			this.m_LocalAABB.CopyValues(source.LocalAABB_C43);
			this.m_MeshCompression = source.MeshCompression_C43;
			this.m_MeshOptimized = source.MeshOptimized_C43;
			this.m_MeshUsageFlags = source.MeshUsageFlags_C43;
			this.m_Name.CopyValues(source.Name_C43);
			this.m_PrefabInternal.CopyValues(source.PrefabInternal_C43, converter);
			this.m_RootBoneNameHash = source.RootBoneNameHash_C43;
			this.m_Shapes.CopyValues(source.Shapes_C43);
			CopyValuesHelper.CopyValues__AssetList_BoneWeights4_2017_1_0__AccessListBase_IBoneWeights4(this.m_Skin, source.Skin_C43);
			CopyValuesHelper.CopyValues__AssetList_SubMesh_4_0_0__AccessListBase_ISubMesh(this.m_SubMeshes, source.SubMeshes_C43);
			this.m_VertexData.CopyValues(source.VertexData_C43);
		}

		// Token: 0x06027F75 RID: 163701 RVA: 0x005AD641 File Offset: 0x005AB841

		public void CopyValues(IMesh source)
		{
			this.CopyValues(source, new PPtrConverter(source, this));
		}

		// Token: 0x06027F76 RID: 163702 RVA: 0x005AD654 File Offset: 0x005AB854
		public override void CopyValues(IUnityAssetBase source, PPtrConverter converter)
		{
			IMesh mesh = source as IMesh;
			if (mesh != null)
			{
				this.CopyValues(mesh, converter);
				return;
			}
			base.CopyValues(source, converter);
		}

		// Token: 0x06027F77 RID: 163703 RVA: 0x005AD67C File Offset: 0x005AB87C

		public override List<TypeTreeNode> MakeEditorTypeTreeNodes(int depth, int startingIndex)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06027F78 RID: 163704 RVA: 0x005AD683 File Offset: 0x005AB883

		public override List<TypeTreeNode> MakeReleaseTypeTreeNodes(int depth, int startingIndex)
		{
			throw new NotSupportedException();
		}

		// Token: 0x04011FC2 RID: 73666
		public bool m_MeshOptimized;

		// Token: 0x04011FC3 RID: 73667

		public AssetList<SubMesh_4_0_0> m_SubMeshes;

		// Token: 0x04011FC4 RID: 73668

		public BlendShapeData_2017_1_0 m_Shapes;

		// Token: 0x04011FC5 RID: 73669

		public AssetList<Matrix4x4f> m_BindPose;

		// Token: 0x04011FC6 RID: 73670

		public uint[] m_BoneNameHashes;

		// Token: 0x04011FC7 RID: 73671
		public uint m_RootBoneNameHash;

		// Token: 0x04011FC8 RID: 73672
		public byte m_MeshCompression;

		// Token: 0x04011FC9 RID: 73673
		public bool m_IsReadable;

		// Token: 0x04011FCA RID: 73674
		public bool m_KeepVertices;

		// Token: 0x04011FCB RID: 73675
		public bool m_KeepIndices;

		public bool m_PackSkinDataToUV2UV3;

		public bool m_MetricsDirty;

		public bool m_CloseMeshDynamicCompression;

		public bool m_IsStreamingMesh;

		// Token: 0x04011FCC RID: 73676

		public byte[] m_IndexBuffer;

		// Token: 0x04011FCD RID: 73677

		public AssetList<BoneWeights4_2017_1_0> m_Skin;

		// Token: 0x04011FCE RID: 73678

		public VertexData_2017_1_0 m_VertexData;

		// Token: 0x04011FCF RID: 73679

		public CompressedMesh_5_0_0 m_CompressedMesh;

		// Token: 0x04011FD0 RID: 73680

		public AABB_3_5_0 m_LocalAABB;

		// Token: 0x04011FD1 RID: 73681
		public int m_MeshUsageFlags;

		// Token: 0x04011FD2 RID: 73682

		public byte[] m_BakedConvexCollisionMesh;

		// Token: 0x04011FD3 RID: 73683

		public byte[] m_BakedTriangleCollisionMesh;

		public float m_MeshMetrics_0;

		public float m_MeshMetrics_1;
	}
}
