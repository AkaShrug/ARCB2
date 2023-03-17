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
using AssetRipper.SourceGenerated.Classes.ClassID_18;
using AssetRipper.SourceGenerated.Classes.ClassID_2;
using AssetRipper.SourceGenerated.Classes.ClassID_8;
using AssetRipper.SourceGenerated.Classes.ClassID_84;
using AssetRipper.SourceGenerated.Enums;
using AssetRipper.SourceGenerated.Helpers;
using AssetRipper.SourceGenerated.Interfaces;
using AssetRipper.SourceGenerated.MarkerInterfaces;
using AssetRipper.SourceGenerated.Subclasses.BitField;
using AssetRipper.SourceGenerated.Subclasses.ColorRGBAf;
using AssetRipper.SourceGenerated.Subclasses.PPtr_EditorExtensionImpl;
using AssetRipper.SourceGenerated.Subclasses.PPtr_EditorExtension;
using AssetRipper.SourceGenerated.Subclasses.PPtr_GameObject;
using AssetRipper.SourceGenerated.Subclasses.PPtr_PrefabInstance;
using AssetRipper.SourceGenerated.Subclasses.PPtr_Prefab;
using AssetRipper.SourceGenerated.Subclasses.PPtr_RenderTexture;
using AssetRipper.SourceGenerated.Subclasses.Rectf;
using AssetRipper.SourceGenerated.Subclasses.Vector2f;
using AssetRipper.Yaml;
using AssetRipper.SourceGenerated.Classes.ClassID_20;

namespace AssetRipper.Import.GICB2.Camera
{
	// Token: 0x02002CA6 RID: 11430


	public sealed class Camera_5_6_0_GICB2 : Behaviour_5_5_0, ICamera, IUnityObjectBase, IUnityAssetBase, IAsset, IAssetReadable, IAssetWritable, IYamlExportable, IDependent, ITypeTreeSerializable, ICameraMarker, IBehaviour, IBehaviourMarker, IComponent, IComponentMarker, IEditorExtension, IEditorExtensionMarker, IObject, IObjectMarker, IHasHideFlags, IHasEnabled
	{
		// Token: 0x17013DD4 RID: 81364
		// (get) Token: 0x0603BB6F RID: 244591 RVA: 0x007D9772 File Offset: 0x007D7972
		// (set) Token: 0x0603BB70 RID: 244592 RVA: 0x007D9775 File Offset: 0x007D7975
		public bool AllowDynamicResolution_C20
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17013DD5 RID: 81365
		// (get) Token: 0x0603BB71 RID: 244593 RVA: 0x007D9777 File Offset: 0x007D7977
		// (set) Token: 0x0603BB72 RID: 244594 RVA: 0x007D977F File Offset: 0x007D797F
		public bool AllowMSAA_C20
		{
			get
			{
				return this.m_AllowMSAA;
			}
			set
			{
				this.m_AllowMSAA = value;
			}
		}

		// Token: 0x17013DD6 RID: 81366
		// (get) Token: 0x0603BB73 RID: 244595 RVA: 0x007D9788 File Offset: 0x007D7988
		// (set) Token: 0x0603BB74 RID: 244596 RVA: 0x007D978F File Offset: 0x007D798F
		public float Anamorphism_C20
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17013DD7 RID: 81367
		// (get) Token: 0x0603BB75 RID: 244597 RVA: 0x007D9791 File Offset: 0x007D7991
		// (set) Token: 0x0603BB76 RID: 244598 RVA: 0x007D9798 File Offset: 0x007D7998
		public float Aperture_C20
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17013DD8 RID: 81368
		// (get) Token: 0x0603BB77 RID: 244599 RVA: 0x007D979A File Offset: 0x007D799A

		public IColorRGBAf BackGroundColor_C20
		{

			get
			{
				return this.m_BackGroundColor;
			}
		}

		// Token: 0x17013DD9 RID: 81369
		// (get) Token: 0x0603BB78 RID: 244600 RVA: 0x007D97A2 File Offset: 0x007D79A2
		// (set) Token: 0x0603BB79 RID: 244601 RVA: 0x007D97A9 File Offset: 0x007D79A9
		public float BarrelClipping_C20
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17013DDA RID: 81370
		// (get) Token: 0x0603BB7A RID: 244602 RVA: 0x007D97AB File Offset: 0x007D79AB
		// (set) Token: 0x0603BB7B RID: 244603 RVA: 0x007D97AE File Offset: 0x007D79AE
		public int BladeCount_C20
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x17013DDB RID: 81371
		// (get) Token: 0x0603BB7C RID: 244604 RVA: 0x007D97B0 File Offset: 0x007D79B0
		// (set) Token: 0x0603BB7D RID: 244605 RVA: 0x007D97B8 File Offset: 0x007D79B8
		public uint ClearFlags_C20
		{
			get
			{
				return this.m_ClearFlags;
			}
			set
			{
				this.m_ClearFlags = value;
			}
		}

		// Token: 0x17013DDC RID: 81372
		// (get) Token: 0x0603BB7E RID: 244606 RVA: 0x007D97C1 File Offset: 0x007D79C1
		public IPPtr_EditorExtension CorrespondingSourceObject_C20
		{
			[return: NotNull]
			get
			{
				return this.m_CorrespondingSourceObject;
			}
		}

		// Token: 0x17013DDD RID: 81373
		// (get) Token: 0x0603BB7F RID: 244607 RVA: 0x007D97C9 File Offset: 0x007D79C9

		public BitField CullingMask_C20
		{

			get
			{
				return this.m_CullingMask;
			}
		}

		// Token: 0x17013DDE RID: 81374
		// (get) Token: 0x0603BB80 RID: 244608 RVA: 0x007D97D1 File Offset: 0x007D79D1
		public Vector2f_3_5_0 Curvature_C20
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17013DDF RID: 81375
		// (get) Token: 0x0603BB81 RID: 244609 RVA: 0x007D97D4 File Offset: 0x007D79D4
		// (set) Token: 0x0603BB82 RID: 244610 RVA: 0x007D97DC File Offset: 0x007D79DC
		public float Depth_C20
		{
			get
			{
				return this.m_Depth;
			}
			set
			{
				this.m_Depth = value;
			}
		}

		// Token: 0x17013DE0 RID: 81376
		// (get) Token: 0x0603BB83 RID: 244611 RVA: 0x007D97E5 File Offset: 0x007D79E5
		// (set) Token: 0x0603BB84 RID: 244612 RVA: 0x007D97ED File Offset: 0x007D79ED
		public byte Enabled_C20
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

		// Token: 0x17013DE1 RID: 81377
		// (get) Token: 0x0603BB85 RID: 244613 RVA: 0x007D97F6 File Offset: 0x007D79F6
		public PPtr_EditorExtensionImpl ExtensionPtr_C20
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17013DE2 RID: 81378
		// (get) Token: 0x0603BB86 RID: 244614 RVA: 0x007D97F9 File Offset: 0x007D79F9
		// (set) Token: 0x0603BB87 RID: 244615 RVA: 0x007D9801 File Offset: 0x007D7A01
		public float Far_clip_plane_C20
		{
			get
			{
				return this.m_Far_clip_plane;
			}
			set
			{
				this.m_Far_clip_plane = value;
			}
		}

		// Token: 0x17013DE3 RID: 81379
		// (get) Token: 0x0603BB88 RID: 244616 RVA: 0x007D980A File Offset: 0x007D7A0A
		// (set) Token: 0x0603BB89 RID: 244617 RVA: 0x007D9812 File Offset: 0x007D7A12
		public float Field_of_view_C20
		{
			get
			{
				return this.m_Field_of_view;
			}
			set
			{
				this.m_Field_of_view = value;
			}
		}

		// Token: 0x17013DE4 RID: 81380
		// (get) Token: 0x0603BB8A RID: 244618 RVA: 0x007D981B File Offset: 0x007D7A1B
		// (set) Token: 0x0603BB8B RID: 244619 RVA: 0x007D9822 File Offset: 0x007D7A22
		public float FocalLength_C20
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17013DE5 RID: 81381
		// (get) Token: 0x0603BB8C RID: 244620 RVA: 0x007D9824 File Offset: 0x007D7A24
		// (set) Token: 0x0603BB8D RID: 244621 RVA: 0x007D982B File Offset: 0x007D7A2B
		public float FocusDistance_C20
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17013DE6 RID: 81382
		// (get) Token: 0x0603BB8E RID: 244622 RVA: 0x007D982D File Offset: 0x007D7A2D
		// (set) Token: 0x0603BB8F RID: 244623 RVA: 0x007D9835 File Offset: 0x007D7A35
		public bool ForceIntoRT_C20
		{
			get
			{
				return this.m_ForceIntoRT;
			}
			set
			{
				this.m_ForceIntoRT = value;
			}
		}

		// Token: 0x17013DE7 RID: 81383
		// (get) Token: 0x0603BB90 RID: 244624 RVA: 0x007D983E File Offset: 0x007D7A3E
		// (set) Token: 0x0603BB91 RID: 244625 RVA: 0x007D9841 File Offset: 0x007D7A41
		public int FOVAxisMode_C20
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x17013DE8 RID: 81384
		// (get) Token: 0x0603BB92 RID: 244626 RVA: 0x007D9843 File Offset: 0x007D7A43

		public IPPtr_GameObject GameObject_C20
		{

			get
			{
				return this.m_GameObject;
			}
		}

		// Token: 0x17013DE9 RID: 81385
		// (get) Token: 0x0603BB93 RID: 244627 RVA: 0x007D984B File Offset: 0x007D7A4B
		// (set) Token: 0x0603BB94 RID: 244628 RVA: 0x007D984E File Offset: 0x007D7A4E
		public int GateFitMode_C20
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x17013DEA RID: 81386
		// (get) Token: 0x0603BB95 RID: 244629 RVA: 0x007D9850 File Offset: 0x007D7A50
		// (set) Token: 0x0603BB96 RID: 244630 RVA: 0x007D9858 File Offset: 0x007D7A58
		public bool HDR_C20
		{
			get
			{
				return this.m_HDR;
			}
			set
			{
				this.m_HDR = value;
			}
		}

		// Token: 0x17013DEB RID: 81387
		// (get) Token: 0x0603BB97 RID: 244631 RVA: 0x007D9861 File Offset: 0x007D7A61
		// (set) Token: 0x0603BB98 RID: 244632 RVA: 0x007D9869 File Offset: 0x007D7A69
		public uint HideFlags_C20
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

		// Token: 0x17013DEC RID: 81388
		// (get) Token: 0x0603BB99 RID: 244633 RVA: 0x007D9872 File Offset: 0x007D7A72
		// (set) Token: 0x0603BB9A RID: 244634 RVA: 0x007D9875 File Offset: 0x007D7A75
		public int Iso_C20
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x17013DED RID: 81389
		// (get) Token: 0x0603BB9B RID: 244635 RVA: 0x007D9877 File Offset: 0x007D7A77
		public Vector2f_3_5_0 LensShift_C20
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17013DEE RID: 81390
		// (get) Token: 0x0603BB9C RID: 244636 RVA: 0x007D987A File Offset: 0x007D7A7A
		// (set) Token: 0x0603BB9D RID: 244637 RVA: 0x007D9882 File Offset: 0x007D7A82
		public float Near_clip_plane_C20
		{
			get
			{
				return this.m_Near_clip_plane;
			}
			set
			{
				this.m_Near_clip_plane = value;
			}
		}

		// Token: 0x17013DEF RID: 81391
		// (get) Token: 0x0603BB9E RID: 244638 RVA: 0x007D988B File Offset: 0x007D7A8B

		public Rectf NormalizedViewPortRect_C20
		{

			get
			{
				return this.m_NormalizedViewPortRect;
			}
		}

		// Token: 0x17013DF0 RID: 81392
		// (get) Token: 0x0603BB9F RID: 244639 RVA: 0x007D9893 File Offset: 0x007D7A93
		// (set) Token: 0x0603BBA0 RID: 244640 RVA: 0x007D989B File Offset: 0x007D7A9B
		public bool OcclusionCulling_C20
		{
			get
			{
				return this.m_OcclusionCulling;
			}
			set
			{
				this.m_OcclusionCulling = value;
			}
		}

		// Token: 0x17013DF1 RID: 81393
		// (get) Token: 0x0603BBA1 RID: 244641 RVA: 0x007D98A4 File Offset: 0x007D7AA4
		// (set) Token: 0x0603BBA2 RID: 244642 RVA: 0x007D98AC File Offset: 0x007D7AAC
		public bool Orthographic_C20
		{
			get
			{
				return this.m_Orthographic;
			}
			set
			{
				this.m_Orthographic = value;
			}
		}

		// Token: 0x17013DF2 RID: 81394
		// (get) Token: 0x0603BBA3 RID: 244643 RVA: 0x007D98B5 File Offset: 0x007D7AB5
		// (set) Token: 0x0603BBA4 RID: 244644 RVA: 0x007D98BD File Offset: 0x007D7ABD
		public float Orthographic_size_C20
		{
			get
			{
				return this.m_Orthographic_size;
			}
			set
			{
				this.m_Orthographic_size = value;
			}
		}

		// Token: 0x17013DF3 RID: 81395
		// (get) Token: 0x0603BBA5 RID: 244645 RVA: 0x007D98C6 File Offset: 0x007D7AC6
		public PPtr_Prefab_2018_3_0 PrefabAsset_C20
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17013DF4 RID: 81396
		// (get) Token: 0x0603BBA6 RID: 244646 RVA: 0x007D98C9 File Offset: 0x007D7AC9
		public PPtr_PrefabInstance PrefabInstance_C20
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17013DF5 RID: 81397
		// (get) Token: 0x0603BBA7 RID: 244647 RVA: 0x007D98CC File Offset: 0x007D7ACC
		public IPPtr_Prefab PrefabInternal_C20
		{
			[return: NotNull]
			get
			{
				return this.m_PrefabInternal;
			}
		}

		// Token: 0x17013DF6 RID: 81398
		// (get) Token: 0x0603BBA8 RID: 244648 RVA: 0x007D98D4 File Offset: 0x007D7AD4
		// (set) Token: 0x0603BBA9 RID: 244649 RVA: 0x007D98D7 File Offset: 0x007D7AD7
		public int ProjectionMatrixMode_C20
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x17013DF7 RID: 81399
		// (get) Token: 0x0603BBAA RID: 244650 RVA: 0x007D98D9 File Offset: 0x007D7AD9
		// (set) Token: 0x0603BBAB RID: 244651 RVA: 0x007D98E1 File Offset: 0x007D7AE1
		public int RenderingPath_C20
		{
			get
			{
				return this.m_RenderingPath;
			}
			set
			{
				this.m_RenderingPath = value;
			}
		}

		// Token: 0x17013DF8 RID: 81400
		// (get) Token: 0x0603BBAC RID: 244652 RVA: 0x007D98EA File Offset: 0x007D7AEA
		public Vector2f_3_5_0 SensorSize_C20
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17013DF9 RID: 81401
		// (get) Token: 0x0603BBAD RID: 244653 RVA: 0x007D98ED File Offset: 0x007D7AED
		// (set) Token: 0x0603BBAE RID: 244654 RVA: 0x007D98F4 File Offset: 0x007D7AF4
		public float ShutterSpeed_C20
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17013DFA RID: 81402
		// (get) Token: 0x0603BBAF RID: 244655 RVA: 0x007D98F6 File Offset: 0x007D7AF6
		// (set) Token: 0x0603BBB0 RID: 244656 RVA: 0x007D98FE File Offset: 0x007D7AFE
		public float StereoConvergence_C20
		{
			get
			{
				return this.m_StereoConvergence;
			}
			set
			{
				this.m_StereoConvergence = value;
			}
		}

		// Token: 0x17013DFB RID: 81403
		// (get) Token: 0x0603BBB1 RID: 244657 RVA: 0x007D9907 File Offset: 0x007D7B07
		// (set) Token: 0x0603BBB2 RID: 244658 RVA: 0x007D990F File Offset: 0x007D7B0F
		public bool StereoMirrorMode_C20
		{
			get
			{
				return this.m_StereoMirrorMode;
			}
			set
			{
				this.m_StereoMirrorMode = value;
			}
		}

		// Token: 0x17013DFC RID: 81404
		// (get) Token: 0x0603BBB3 RID: 244659 RVA: 0x007D9918 File Offset: 0x007D7B18
		// (set) Token: 0x0603BBB4 RID: 244660 RVA: 0x007D9920 File Offset: 0x007D7B20
		public float StereoSeparation_C20
		{
			get
			{
				return this.m_StereoSeparation;
			}
			set
			{
				this.m_StereoSeparation = value;
			}
		}

		// Token: 0x17013DFD RID: 81405
		// (get) Token: 0x0603BBB5 RID: 244661 RVA: 0x007D9929 File Offset: 0x007D7B29
		// (set) Token: 0x0603BBB6 RID: 244662 RVA: 0x007D992C File Offset: 0x007D7B2C
		public uint TargetDisplay_C20_UInt32
		{
			get
			{
				return 0U;
			}
			set
			{
			}
		}

		// Token: 0x17013DFE RID: 81406
		// (get) Token: 0x0603BBB7 RID: 244663 RVA: 0x007D992E File Offset: 0x007D7B2E
		// (set) Token: 0x0603BBB8 RID: 244664 RVA: 0x007D9936 File Offset: 0x007D7B36
		public int TargetDisplay_C20_Int32
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

		// Token: 0x17013DFF RID: 81407
		// (get) Token: 0x0603BBB9 RID: 244665 RVA: 0x007D993F File Offset: 0x007D7B3F
		// (set) Token: 0x0603BBBA RID: 244666 RVA: 0x007D9947 File Offset: 0x007D7B47
		public int TargetEye_C20
		{
			get
			{
				return this.m_TargetEye;
			}
			set
			{
				this.m_TargetEye = value;
			}
		}

		// Token: 0x17013E00 RID: 81408
		// (get) Token: 0x0603BBBB RID: 244667 RVA: 0x007D9950 File Offset: 0x007D7B50

		public IPPtr_RenderTexture TargetTexture_C20
		{

			get
			{
				return this.m_TargetTexture;
			}
		}

		// Token: 0x17013E01 RID: 81409
		// (get) Token: 0x0603BBBC RID: 244668 RVA: 0x007D9958 File Offset: 0x007D7B58
		// (set) Token: 0x0603BBBD RID: 244669 RVA: 0x007D9960 File Offset: 0x007D7B60
		public CameraClearFlags ClearFlags_C20E
		{
			get
			{
				return (CameraClearFlags)this.m_ClearFlags;
			}
			set
			{
				this.m_ClearFlags = (uint)value;
			}
		}

		// Token: 0x17013E02 RID: 81410
		// (get) Token: 0x0603BBBE RID: 244670 RVA: 0x007D9969 File Offset: 0x007D7B69
		// (set) Token: 0x0603BBBF RID: 244671 RVA: 0x007D9971 File Offset: 0x007D7B71
		public HideFlags HideFlags_C20E
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

		// Token: 0x17013E03 RID: 81411
		// (get) Token: 0x0603BBC0 RID: 244672 RVA: 0x007D997A File Offset: 0x007D7B7A
		// (set) Token: 0x0603BBC1 RID: 244673 RVA: 0x007D997D File Offset: 0x007D7B7D
		public ProjectionMatrixMode ProjectionMatrixMode_C20E
		{
			get
			{
				return ProjectionMatrixMode.Explicit;
			}
			set
			{
			}
		}

		// Token: 0x17013E04 RID: 81412
		// (get) Token: 0x0603BBC2 RID: 244674 RVA: 0x007D997F File Offset: 0x007D7B7F
		// (set) Token: 0x0603BBC3 RID: 244675 RVA: 0x007D9987 File Offset: 0x007D7B87
		public RenderingPath RenderingPath_C20E
		{
			get
			{
				return (RenderingPath)this.m_RenderingPath;
			}
			set
			{
				this.m_RenderingPath = (int)value;
			}
		}

		// Token: 0x17013E05 RID: 81413
		// (get) Token: 0x0603BBC4 RID: 244676 RVA: 0x007D9990 File Offset: 0x007D7B90
		// (set) Token: 0x0603BBC5 RID: 244677 RVA: 0x007D99A3 File Offset: 0x007D7BA3
		public IEditorExtension CorrespondingSourceObject_C20P
		{
			get
			{
				return PPtrExtensions.TryGetAsset<IEditorExtension>(this.CorrespondingSourceObject_C20, base.Collection);
			}
			set
			{
				PPtrExtensions.SetAsset<IEditorExtension>(this.CorrespondingSourceObject_C20, base.Collection, value);
			}
		}

		// Token: 0x17013E06 RID: 81414
		// (get) Token: 0x0603BBC6 RID: 244678 RVA: 0x007D99B7 File Offset: 0x007D7BB7
		// (set) Token: 0x0603BBC7 RID: 244679 RVA: 0x007D99BA File Offset: 0x007D7BBA
		public IEditorExtensionImpl ExtensionPtr_C20P
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x17013E07 RID: 81415
		// (get) Token: 0x0603BBC8 RID: 244680 RVA: 0x007D99BC File Offset: 0x007D7BBC
		// (set) Token: 0x0603BBC9 RID: 244681 RVA: 0x007D99CF File Offset: 0x007D7BCF
		public IGameObject GameObject_C20P
		{
			get
			{
				return PPtrExtensions.TryGetAsset<IGameObject>(this.GameObject_C20, base.Collection);
			}
			set
			{
				PPtrExtensions.SetAsset<IGameObject>(this.GameObject_C20, base.Collection, value);
			}
		}

		// Token: 0x17013E08 RID: 81416
		// (get) Token: 0x0603BBCA RID: 244682 RVA: 0x007D99E3 File Offset: 0x007D7BE3
		// (set) Token: 0x0603BBCB RID: 244683 RVA: 0x007D99E6 File Offset: 0x007D7BE6
		public IPrefab PrefabAsset_C20P
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x17013E09 RID: 81417
		// (get) Token: 0x0603BBCC RID: 244684 RVA: 0x007D99E8 File Offset: 0x007D7BE8
		// (set) Token: 0x0603BBCD RID: 244685 RVA: 0x007D99EB File Offset: 0x007D7BEB
		public IPrefabInstance PrefabInstance_C20P
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x17013E0A RID: 81418
		// (get) Token: 0x0603BBCE RID: 244686 RVA: 0x007D99ED File Offset: 0x007D7BED
		// (set) Token: 0x0603BBCF RID: 244687 RVA: 0x007D9A00 File Offset: 0x007D7C00
		public IPrefabMarker PrefabInternal_C20P
		{
			get
			{
				return PPtrExtensions.TryGetAsset<IPrefabMarker>(this.PrefabInternal_C20, base.Collection);
			}
			set
			{
				PPtrExtensions.SetAsset<IPrefabMarker>(this.PrefabInternal_C20, base.Collection, value);
			}
		}

		// Token: 0x17013E0B RID: 81419
		// (get) Token: 0x0603BBD0 RID: 244688 RVA: 0x007D9A14 File Offset: 0x007D7C14
		// (set) Token: 0x0603BBD1 RID: 244689 RVA: 0x007D9A27 File Offset: 0x007D7C27
		public IRenderTexture TargetTexture_C20P
		{
			get
			{
				return PPtrExtensions.TryGetAsset<IRenderTexture>(this.TargetTexture_C20, base.Collection);
			}
			set
			{
				PPtrExtensions.SetAsset<IRenderTexture>(this.TargetTexture_C20, base.Collection, value);
			}
		}

		// Token: 0x17013E0C RID: 81420
		// (get) Token: 0x0603BBD2 RID: 244690 RVA: 0x007D9A3B File Offset: 0x007D7C3B

		public override string ClassName
		{

			get
			{
				return "Camera";
			}
		}

		// Token: 0x0603BBD3 RID: 244691 RVA: 0x007D9A42 File Offset: 0x007D7C42
		public Camera_5_6_0_GICB2()
			: this(AssetInfo.MakeDummyAssetInfo(20))
		{
		}

		// Token: 0x0603BBD4 RID: 244692 RVA: 0x007D9A51 File Offset: 0x007D7C51
		public Camera_5_6_0_GICB2(AssetInfo info)
			: base(info)
		{
			this.m_BackGroundColor = new ColorRGBAf_3_5_0();
			this.m_NormalizedViewPortRect = new Rectf();
			this.m_CullingMask = new BitField();
			this.m_TargetTexture = new PPtr_RenderTexture_5_0_0();
		}

		// Token: 0x0603BBD5 RID: 244693 RVA: 0x007D9A86 File Offset: 0x007D7C86
		public bool Has_AllowDynamicResolution_C20()
		{
			return false;
		}

		// Token: 0x0603BBD6 RID: 244694 RVA: 0x007D9A89 File Offset: 0x007D7C89
		public bool Has_AllowMSAA_C20()
		{
			return true;
		}

		// Token: 0x0603BBD7 RID: 244695 RVA: 0x007D9A8C File Offset: 0x007D7C8C
		public bool Has_Anamorphism_C20()
		{
			return false;
		}

		// Token: 0x0603BBD8 RID: 244696 RVA: 0x007D9A8F File Offset: 0x007D7C8F
		public bool Has_Aperture_C20()
		{
			return false;
		}

		// Token: 0x0603BBD9 RID: 244697 RVA: 0x007D9A92 File Offset: 0x007D7C92
		public bool Has_BarrelClipping_C20()
		{
			return false;
		}

		// Token: 0x0603BBDA RID: 244698 RVA: 0x007D9A95 File Offset: 0x007D7C95
		public bool Has_BladeCount_C20()
		{
			return false;
		}

		// Token: 0x0603BBDB RID: 244699 RVA: 0x007D9A98 File Offset: 0x007D7C98
		public bool Has_CorrespondingSourceObject_C20()
		{
			return true;
		}

		// Token: 0x0603BBDC RID: 244700 RVA: 0x007D9A9B File Offset: 0x007D7C9B
		public bool Has_Curvature_C20()
		{
			return false;
		}

		// Token: 0x0603BBDD RID: 244701 RVA: 0x007D9A9E File Offset: 0x007D7C9E
		public bool Has_ExtensionPtr_C20()
		{
			return false;
		}

		// Token: 0x0603BBDE RID: 244702 RVA: 0x007D9AA1 File Offset: 0x007D7CA1
		public bool Has_FocalLength_C20()
		{
			return false;
		}

		// Token: 0x0603BBDF RID: 244703 RVA: 0x007D9AA4 File Offset: 0x007D7CA4
		public bool Has_FocusDistance_C20()
		{
			return false;
		}

		// Token: 0x0603BBE0 RID: 244704 RVA: 0x007D9AA7 File Offset: 0x007D7CA7
		public bool Has_ForceIntoRT_C20()
		{
			return true;
		}

		// Token: 0x0603BBE1 RID: 244705 RVA: 0x007D9AAA File Offset: 0x007D7CAA
		public bool Has_FOVAxisMode_C20()
		{
			return false;
		}

		// Token: 0x0603BBE2 RID: 244706 RVA: 0x007D9AAD File Offset: 0x007D7CAD
		public bool Has_GateFitMode_C20()
		{
			return false;
		}

		// Token: 0x0603BBE3 RID: 244707 RVA: 0x007D9AB0 File Offset: 0x007D7CB0
		public bool Has_HDR_C20()
		{
			return true;
		}

		// Token: 0x0603BBE4 RID: 244708 RVA: 0x007D9AB3 File Offset: 0x007D7CB3
		public bool Has_Iso_C20()
		{
			return false;
		}

		// Token: 0x0603BBE5 RID: 244709 RVA: 0x007D9AB6 File Offset: 0x007D7CB6
		public bool Has_LensShift_C20()
		{
			return false;
		}

		// Token: 0x0603BBE6 RID: 244710 RVA: 0x007D9AB9 File Offset: 0x007D7CB9
		public bool Has_OcclusionCulling_C20()
		{
			return true;
		}

		// Token: 0x0603BBE7 RID: 244711 RVA: 0x007D9ABC File Offset: 0x007D7CBC
		public bool Has_PrefabAsset_C20()
		{
			return false;
		}

		// Token: 0x0603BBE8 RID: 244712 RVA: 0x007D9ABF File Offset: 0x007D7CBF
		public bool Has_PrefabInstance_C20()
		{
			return false;
		}

		// Token: 0x0603BBE9 RID: 244713 RVA: 0x007D9AC2 File Offset: 0x007D7CC2
		public bool Has_PrefabInternal_C20()
		{
			return true;
		}

		// Token: 0x0603BBEA RID: 244714 RVA: 0x007D9AC5 File Offset: 0x007D7CC5
		public bool Has_ProjectionMatrixMode_C20()
		{
			return false;
		}

		// Token: 0x0603BBEB RID: 244715 RVA: 0x007D9AC8 File Offset: 0x007D7CC8
		public bool Has_SensorSize_C20()
		{
			return false;
		}

		// Token: 0x0603BBEC RID: 244716 RVA: 0x007D9ACB File Offset: 0x007D7CCB
		public bool Has_ShutterSpeed_C20()
		{
			return false;
		}

		// Token: 0x0603BBED RID: 244717 RVA: 0x007D9ACE File Offset: 0x007D7CCE
		public bool Has_StereoConvergence_C20()
		{
			return true;
		}

		// Token: 0x0603BBEE RID: 244718 RVA: 0x007D9AD1 File Offset: 0x007D7CD1
		public bool Has_StereoMirrorMode_C20()
		{
			return true;
		}

		// Token: 0x0603BBEF RID: 244719 RVA: 0x007D9AD4 File Offset: 0x007D7CD4
		public bool Has_StereoSeparation_C20()
		{
			return true;
		}

		// Token: 0x0603BBF0 RID: 244720 RVA: 0x007D9AD7 File Offset: 0x007D7CD7
		public bool Has_TargetDisplay_C20_UInt32()
		{
			return false;
		}

		// Token: 0x0603BBF1 RID: 244721 RVA: 0x007D9ADA File Offset: 0x007D7CDA
		public bool Has_TargetDisplay_C20_Int32()
		{
			return true;
		}

		// Token: 0x0603BBF2 RID: 244722 RVA: 0x007D9ADD File Offset: 0x007D7CDD
		public bool Has_TargetEye_C20()
		{
			return true;
		}

		// Token: 0x0603BBF3 RID: 244723 RVA: 0x007D9AE0 File Offset: 0x007D7CE0

		public override void ReadRelease(AssetReader reader)
		{
			this.m_GameObject.ReadRelease(reader);
			this.m_Enabled = reader.ReadRelease_ByteAlign();
			this.m_ClearFlags = reader.ReadUInt32();
			this.m_BackGroundColor.ReadRelease(reader);
			this.m_NormalizedViewPortRect.ReadRelease(reader);
			this.m_Near_clip_plane = reader.ReadSingle();
			this.m_Far_clip_plane = reader.ReadSingle();
			this.m_Field_of_view = reader.ReadSingle();
			this.m_Orthographic = reader.ReadRelease_BooleanAlign();
			this.m_Orthographic_size = reader.ReadSingle();
			this.m_Depth = reader.ReadSingle();
			this.m_CullingMask.ReadRelease(reader);
			Bits = reader.ReadUInt32();
			this.m_RenderingPath = reader.ReadInt32();
			this.m_TargetTexture.ReadRelease(reader);
			this.m_TargetDisplay = reader.ReadInt32();
			this.m_TargetEye = reader.ReadInt32();
			this.m_HDR = reader.ReadBoolean();
			this.m_AllowMSAA = reader.ReadBoolean();
			this.m_ForceIntoRT = reader.ReadBoolean();
			this.m_OcclusionCulling = reader.ReadRelease_BooleanAlign();
			this.m_StereoConvergence = reader.ReadSingle();
			this.m_StereoSeparation = reader.ReadSingle();
			this.m_StereoMirrorMode = reader.ReadBoolean();
			reader.AlignStream();
			AOMode = reader.ReadInt32();
			reader.AlignStream();
			AORadius = reader.ReadSingle();
			AOAmount = reader.ReadSingle();
			SsrEnabled = reader.ReadBoolean();
			SsrQuality = reader.ReadSingle();
			SsrShininessThreshold = reader.ReadSingle();
			SsrZThickness = reader.ReadSingle();
			SsrBlur = reader.ReadSingle();
			GPUCullingEnabled = reader.ReadBoolean();
			DepthBlendEnabled = reader.ReadBoolean();
			MergedDeferredShadingPass = reader.ReadBoolean();
			EarlyZEnable = reader.ReadBoolean();
			CombineCasterSubmeshEnable = reader.ReadBoolean();
			HalfResolutionParticleEnable = reader.ReadBoolean();
			DistortionVectorsEnable = reader.ReadBoolean();
			reader.AlignStream();
			ViewDistanceRatio = reader.ReadSingle();
			ClearInFinalPass = reader.ReadBoolean();
			UseStaticLightMapInGeoPass = reader.ReadBoolean();
			bUsingHalfLightBuffer = reader.ReadBoolean();
			bAvatarCamera = reader.ReadBoolean();
			reader.AlignStream();
			CullStatsCheckEnable = reader.ReadBoolean();
			reader.AlignStream();
			bUsingMulthreadRendering = reader.ReadBoolean();
			UsedForTextureStreaming = reader.ReadBoolean();
			reader.AlignStream();
		}

		// Token: 0x0603BBF4 RID: 244724 RVA: 0x007D9C04 File Offset: 0x007D7E04

		public override void ReadEditor(AssetReader reader)
		{
		}

		// Token: 0x0603BBF5 RID: 244725 RVA: 0x007D9D4C File Offset: 0x007D7F4C

		public override void WriteRelease(AssetWriter writer)
		{
			this.m_GameObject.WriteRelease(writer);
			this.m_Enabled.WriteRelease_ByteAlign(writer);
			this.m_ClearFlags.WriteRelease_UInt32(writer);
			this.m_BackGroundColor.WriteRelease(writer);
			this.m_NormalizedViewPortRect.WriteRelease(writer);
			this.m_Near_clip_plane.WriteRelease_Single(writer);
			this.m_Far_clip_plane.WriteRelease_Single(writer);
			this.m_Field_of_view.WriteRelease_Single(writer);
			this.m_Orthographic.WriteRelease_BooleanAlign(writer);
			this.m_Orthographic_size.WriteRelease_Single(writer);
			this.m_Depth.WriteRelease_Single(writer);
			this.m_CullingMask.WriteRelease(writer);
			this.m_RenderingPath.WriteRelease_Int32(writer);
			this.m_TargetTexture.WriteRelease(writer);
			this.m_TargetDisplay.WriteRelease_Int32(writer);
			this.m_TargetEye.WriteRelease_Int32(writer);
			this.m_HDR.WriteRelease_Boolean(writer);
			this.m_AllowMSAA.WriteRelease_Boolean(writer);
			this.m_ForceIntoRT.WriteRelease_Boolean(writer);
			this.m_OcclusionCulling.WriteRelease_BooleanAlign(writer);
			this.m_StereoConvergence.WriteRelease_Single(writer);
			this.m_StereoSeparation.WriteRelease_Single(writer);
			this.m_StereoMirrorMode.WriteRelease_Boolean(writer);
		}

		// Token: 0x0603BBF6 RID: 244726 RVA: 0x007D9E70 File Offset: 0x007D8070

		public override void WriteEditor(AssetWriter writer)
		{
		}

		// Token: 0x0603BBF7 RID: 244727 RVA: 0x007D9FB8 File Offset: 0x007D81B8

		public override YamlNode ExportYamlRelease(IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			YamlSerializedVersionExtensions.AddSerializedVersion(yamlMappingNode, 2);
			yamlMappingNode.Add(new YamlScalarNode("m_GameObject"), this.m_GameObject.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Enabled"), this.m_Enabled.ExportYamlRelease_Byte(container));
			yamlMappingNode.Add(new YamlScalarNode("m_ClearFlags"), this.m_ClearFlags.ExportYamlRelease_UInt32(container));
			yamlMappingNode.Add(new YamlScalarNode("m_BackGroundColor"), this.m_BackGroundColor.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("m_NormalizedViewPortRect"), this.m_NormalizedViewPortRect.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("near clip plane"), this.m_Near_clip_plane.ExportYamlRelease_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("far clip plane"), this.m_Far_clip_plane.ExportYamlRelease_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("field of view"), this.m_Field_of_view.ExportYamlRelease_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("orthographic"), this.m_Orthographic.ExportYamlRelease_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("orthographic size"), this.m_Orthographic_size.ExportYamlRelease_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Depth"), this.m_Depth.ExportYamlRelease_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("m_CullingMask"), this.m_CullingMask.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("m_RenderingPath"), this.m_RenderingPath.ExportYamlRelease_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("m_TargetTexture"), this.m_TargetTexture.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("m_TargetDisplay"), this.m_TargetDisplay.ExportYamlRelease_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("m_TargetEye"), this.m_TargetEye.ExportYamlRelease_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("m_HDR"), this.m_HDR.ExportYamlRelease_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("m_AllowMSAA"), this.m_AllowMSAA.ExportYamlRelease_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("m_ForceIntoRT"), this.m_ForceIntoRT.ExportYamlRelease_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("m_OcclusionCulling"), this.m_OcclusionCulling.ExportYamlRelease_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("m_StereoConvergence"), this.m_StereoConvergence.ExportYamlRelease_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("m_StereoSeparation"), this.m_StereoSeparation.ExportYamlRelease_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("m_StereoMirrorMode"), this.m_StereoMirrorMode.ExportYamlRelease_Boolean(container));
			return yamlMappingNode;
		}

		// Token: 0x0603BBF8 RID: 244728 RVA: 0x007DA258 File Offset: 0x007D8458
		public override YamlNode ExportYamlEditor(IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			YamlSerializedVersionExtensions.AddSerializedVersion(yamlMappingNode, 2);
			yamlMappingNode.Add(new YamlScalarNode("m_ObjectHideFlags"), this.m_HideFlags.ExportYamlEditor_UInt32(container));
			yamlMappingNode.Add(new YamlScalarNode("m_PrefabParentObject"), this.m_CorrespondingSourceObject.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_PrefabInternal"), this.m_PrefabInternal.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_GameObject"), this.m_GameObject.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Enabled"), this.m_Enabled.ExportYamlEditor_Byte(container));
			yamlMappingNode.Add(new YamlScalarNode("m_ClearFlags"), this.m_ClearFlags.ExportYamlEditor_UInt32(container));
			yamlMappingNode.Add(new YamlScalarNode("m_BackGroundColor"), this.m_BackGroundColor.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_NormalizedViewPortRect"), this.m_NormalizedViewPortRect.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("near clip plane"), this.m_Near_clip_plane.ExportYamlEditor_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("far clip plane"), this.m_Far_clip_plane.ExportYamlEditor_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("field of view"), this.m_Field_of_view.ExportYamlEditor_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("orthographic"), this.m_Orthographic.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("orthographic size"), this.m_Orthographic_size.ExportYamlEditor_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Depth"), this.m_Depth.ExportYamlEditor_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("m_CullingMask"), this.m_CullingMask.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_RenderingPath"), this.m_RenderingPath.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("m_TargetTexture"), this.m_TargetTexture.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_TargetDisplay"), this.m_TargetDisplay.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("m_TargetEye"), this.m_TargetEye.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("m_HDR"), this.m_HDR.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("m_AllowMSAA"), this.m_AllowMSAA.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("m_ForceIntoRT"), this.m_ForceIntoRT.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("m_OcclusionCulling"), this.m_OcclusionCulling.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("m_StereoConvergence"), this.m_StereoConvergence.ExportYamlEditor_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("m_StereoSeparation"), this.m_StereoSeparation.ExportYamlEditor_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("m_StereoMirrorMode"), this.m_StereoMirrorMode.ExportYamlEditor_Boolean(container));
			return yamlMappingNode;
		}

		// Token: 0x0603BBF9 RID: 244729 RVA: 0x007DA54C File Offset: 0x007D874C
		public override void Reset()
		{
			this.m_AllowMSAA = false;
			this.m_BackGroundColor.Reset();
			this.m_ClearFlags = 0U;
			this.m_CorrespondingSourceObject.Reset();
			this.m_CullingMask.Reset();
			this.m_Depth = 0f;
			this.m_Enabled = 0;
			this.m_Far_clip_plane = 0f;
			this.m_Field_of_view = 0f;
			this.m_ForceIntoRT = false;
			this.m_GameObject.Reset();
			this.m_HDR = false;
			this.m_HideFlags = 0U;
			this.m_Near_clip_plane = 0f;
			this.m_NormalizedViewPortRect.Reset();
			this.m_OcclusionCulling = false;
			this.m_Orthographic = false;
			this.m_Orthographic_size = 0f;
			this.m_PrefabInternal.Reset();
			this.m_RenderingPath = 0;
			this.m_StereoConvergence = 0f;
			this.m_StereoMirrorMode = false;
			this.m_StereoSeparation = 0f;
			this.m_TargetDisplay = 0;
			this.m_TargetEye = 0;
			this.m_TargetTexture.Reset();
		}

		// Token: 0x0603BBFA RID: 244730 RVA: 0x007DA647 File Offset: 0x007D8847
		//public override IEnumerable<ValueTuple<FieldName, PPtr<IUnityObjectBase>>> FetchDependencies(FieldName parent)
		//{
		//	return Enumerable.Empty<ValueTuple<FieldName, PPtr<IUnityObjectBase>>>().Append_Camera_5_6_0(parent, this);
		//}

		// Token: 0x0603BBFB RID: 244731 RVA: 0x007DA658 File Offset: 0x007D8858

		public void CopyValues(ICamera source, PPtrConverter converter)
		{
			this.m_AllowMSAA = source.AllowMSAA_C20;
			this.m_BackGroundColor.CopyValues(source.BackGroundColor_C20);
			this.m_ClearFlags = source.ClearFlags_C20;
			this.m_CorrespondingSourceObject.CopyValues(source.CorrespondingSourceObject_C20, converter);
			this.m_CullingMask.CopyValues(source.CullingMask_C20);
			this.m_Depth = source.Depth_C20;
			this.m_Enabled = source.Enabled_C20;
			this.m_Far_clip_plane = source.Far_clip_plane_C20;
			this.m_Field_of_view = source.Field_of_view_C20;
			this.m_ForceIntoRT = source.ForceIntoRT_C20;
			this.m_GameObject.CopyValues(source.GameObject_C20, converter);
			this.m_HDR = source.HDR_C20;
			this.m_HideFlags = source.HideFlags_C20;
			this.m_Near_clip_plane = source.Near_clip_plane_C20;
			this.m_NormalizedViewPortRect.CopyValues(source.NormalizedViewPortRect_C20);
			this.m_OcclusionCulling = source.OcclusionCulling_C20;
			this.m_Orthographic = source.Orthographic_C20;
			this.m_Orthographic_size = source.Orthographic_size_C20;
			this.m_PrefabInternal.CopyValues(source.PrefabInternal_C20, converter);
			this.m_RenderingPath = source.RenderingPath_C20;
			this.m_StereoConvergence = source.StereoConvergence_C20;
			this.m_StereoMirrorMode = source.StereoMirrorMode_C20;
			this.m_StereoSeparation = source.StereoSeparation_C20;
			this.m_TargetDisplay = source.TargetDisplay_C20_Int32;
			this.m_TargetEye = source.TargetEye_C20;
			this.m_TargetTexture.CopyValues(source.TargetTexture_C20, converter);
		}

		// Token: 0x0603BBFC RID: 244732 RVA: 0x007DA7C4 File Offset: 0x007D89C4

		public void CopyValues(ICamera source)
		{
			this.CopyValues(source, new PPtrConverter(source, this));
		}

		// Token: 0x0603BBFD RID: 244733 RVA: 0x007DA7D4 File Offset: 0x007D89D4
		public override void CopyValues(IUnityAssetBase source, PPtrConverter converter)
		{
			ICamera camera = source as ICamera;
			if (camera != null)
			{
				this.CopyValues(camera, converter);
				return;
			}
			base.CopyValues(source, converter);
		}

		// Token: 0x0603BBFE RID: 244734 RVA: 0x007DA7FC File Offset: 0x007D89FC

		public override List<TypeTreeNode> MakeEditorTypeTreeNodes(int depth, int startingIndex)
		{
			throw new NotSupportedException();
		}

		// Token: 0x0603BBFF RID: 244735 RVA: 0x007DA803 File Offset: 0x007D8A03

		public override List<TypeTreeNode> MakeReleaseTypeTreeNodes(int depth, int startingIndex)
		{
			throw new NotSupportedException();
		}

		// Token: 0x04013B85 RID: 80773
		public uint m_ClearFlags;

		// Token: 0x04013B86 RID: 80774

		public ColorRGBAf_3_5_0 m_BackGroundColor;

		// Token: 0x04013B87 RID: 80775

		public Rectf m_NormalizedViewPortRect;

		// Token: 0x04013B88 RID: 80776
		public float m_Near_clip_plane;

		// Token: 0x04013B89 RID: 80777
		public float m_Far_clip_plane;

		// Token: 0x04013B8A RID: 80778
		public float m_Field_of_view;

		// Token: 0x04013B8B RID: 80779
		public bool m_Orthographic;

		// Token: 0x04013B8C RID: 80780
		public float m_Orthographic_size;

		// Token: 0x04013B8D RID: 80781
		public float m_Depth;

		public uint Bits { get; set; }

		// Token: 0x04013B8E RID: 80782

		public BitField m_CullingMask;

		// Token: 0x04013B8F RID: 80783
		public int m_RenderingPath;

		// Token: 0x04013B90 RID: 80784

		public PPtr_RenderTexture_5_0_0 m_TargetTexture;

		// Token: 0x04013B91 RID: 80785
		public int m_TargetDisplay;

		// Token: 0x04013B92 RID: 80786
		public int m_TargetEye;

		// Token: 0x04013B93 RID: 80787
		public bool m_HDR;

		// Token: 0x04013B94 RID: 80788
		public bool m_AllowMSAA;

		// Token: 0x04013B95 RID: 80789
		public bool m_ForceIntoRT;

		// Token: 0x04013B96 RID: 80790
		public bool m_OcclusionCulling;

		// Token: 0x04013B97 RID: 80791
		public float m_StereoConvergence;

		// Token: 0x04013B98 RID: 80792
		public float m_StereoSeparation;

		// Token: 0x04013B99 RID: 80793
		public bool m_StereoMirrorMode;

		public int AOMode { get; set; }
		public float AORadius { get; set; }
		public float AOAmount { get; set; }
		public float HBAOStrength { get; set; }
		public float HBAOMaximum { get; set; }
		public bool AOFieldEnabled { get; set; }
		public float AOFieldAmount { get; set; }
		public bool ReflectionEnabled { get; set; }
		public bool SsrEnabled { get; set; }
		public bool SsrQuaterSize { get; set; }
		public bool SsrHiZ { get; set; }
		public float SsrSize { get; set; }
		public float SsrQuality { get; set; }
		public float SsrShininessThreshold { get; set; }
		public float SsrZThickness { get; set; }
		public float SsrTemporalRatio { get; set; }
		public float SsrBlur { get; set; }
		public bool GPUCullingEnabled { get; set; }
		public bool DepthBlendEnabled { get; set; }
		public bool MergedDeferredShadingPass { get; set; }
		public bool EarlyZEnable { get; set; }
		public bool CombineCasterSubmeshEnable { get; set; }
		public bool HalfResolutionParticleEnable { get; set; }
		public bool DistortionVectorsEnable { get; set; }
		public float ViewDistanceRatio { get; set; }
		public bool ClearInFinalPass { get; set; }
		public bool UseStaticLightMapInGeoPass { get; set; }
		public bool bUsingHalfLightBuffer { get; set; }
		public bool bAvatarCamera { get; set; }
		public bool CullStatsCheckEnable { get; set; }
		public bool bUsingMulthreadRendering { get; set; }
		public bool GrassEnabled { get; set; }
		public bool DeformationEnabled { get; set; }
		public bool LPVEnable { get; set; }
		public float LPVPropagateScale { get; set; }
		public float LPVColorIntensity { get; set; }
		public bool DeferredMSAA4xEnable { get; set; }
		public bool DeferredMSAA2xEnable { get; set; }
		public bool subPassEnable { get; set; }
		public bool UsedForTextureStreaming { get; set; }
	}
}
