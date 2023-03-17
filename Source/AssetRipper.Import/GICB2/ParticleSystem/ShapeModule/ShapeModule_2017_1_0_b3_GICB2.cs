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
using AssetRipper.SourceGenerated.Enums;
using AssetRipper.SourceGenerated.Helpers;
using AssetRipper.SourceGenerated.Subclasses.MultiModeParameter;
using AssetRipper.SourceGenerated.Subclasses.MultiModeParameter_MeshSpawn;
using AssetRipper.SourceGenerated.Subclasses.PPtr_MeshRenderer;
using AssetRipper.SourceGenerated.Subclasses.PPtr_Mesh;
using AssetRipper.SourceGenerated.Subclasses.PPtr_SkinnedMeshRenderer;
using AssetRipper.SourceGenerated.Subclasses.PPtr_SpriteRenderer;
using AssetRipper.SourceGenerated.Subclasses.PPtr_Sprite;
using AssetRipper.SourceGenerated.Subclasses.PPtr_Texture2D;
using AssetRipper.SourceGenerated.Subclasses.Vector3f;
using AssetRipper.Yaml;
using AssetRipper.SourceGenerated.Subclasses.ShapeModule;

namespace AssetRipper.Import.GICB2.ParticleSystem.ShapeModule
{
	// Token: 0x020003A5 RID: 933


	public sealed class ShapeModule_2017_1_0_b3_GICB2 : UnityAssetBase, IShapeModule, IUnityAssetBase, IAsset, IAssetReadable, IAssetWritable, IYamlExportable, IDependent, ITypeTreeSerializable, IEquatable<IShapeModule>, IEquatable<ShapeModule_2017_1_0_b3>
	{
		// Token: 0x17001991 RID: 6545
		// (get) Token: 0x06006314 RID: 25364 RVA: 0x001031AF File Offset: 0x001013AF
		// (set) Token: 0x06006315 RID: 25365 RVA: 0x001031B7 File Offset: 0x001013B7
		public bool AlignToDirection
		{
			get
			{
				return this.m_AlignToDirection;
			}
			set
			{
				this.m_AlignToDirection = value;
			}
		}

		// Token: 0x17001992 RID: 6546
		// (get) Token: 0x06006316 RID: 25366 RVA: 0x001031C0 File Offset: 0x001013C0
		// (set) Token: 0x06006317 RID: 25367 RVA: 0x001031C8 File Offset: 0x001013C8
		public float Angle
		{
			get
			{
				return this.m_Angle;
			}
			set
			{
				this.m_Angle = value;
			}
		}

		// Token: 0x17001993 RID: 6547
		// (get) Token: 0x06006318 RID: 25368 RVA: 0x001031D1 File Offset: 0x001013D1
		// (set) Token: 0x06006319 RID: 25369 RVA: 0x001031D8 File Offset: 0x001013D8
		public float Arc
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17001994 RID: 6548
		// (get) Token: 0x0600631A RID: 25370 RVA: 0x001031DA File Offset: 0x001013DA
		public IMultiModeParameter ArcParameter
		{
			[return: NotNull]
			get
			{
				return this.m_ArcParameter;
			}
		}

		// Token: 0x17001995 RID: 6549
		// (get) Token: 0x0600631B RID: 25371 RVA: 0x001031E2 File Offset: 0x001013E2
		public Vector3f_3_5_0 BoxThickness
		{
			[return: NotNull]
			get
			{
				return this.m_BoxThickness;
			}
		}

		// Token: 0x17001996 RID: 6550
		// (get) Token: 0x0600631C RID: 25372 RVA: 0x001031EA File Offset: 0x001013EA
		// (set) Token: 0x0600631D RID: 25373 RVA: 0x001031F1 File Offset: 0x001013F1
		public float BoxX
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17001997 RID: 6551
		// (get) Token: 0x0600631E RID: 25374 RVA: 0x001031F3 File Offset: 0x001013F3
		// (set) Token: 0x0600631F RID: 25375 RVA: 0x001031FA File Offset: 0x001013FA
		public float BoxY
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17001998 RID: 6552
		// (get) Token: 0x06006320 RID: 25376 RVA: 0x001031FC File Offset: 0x001013FC
		// (set) Token: 0x06006321 RID: 25377 RVA: 0x00103203 File Offset: 0x00101403
		public float BoxZ
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17001999 RID: 6553
		// (get) Token: 0x06006322 RID: 25378 RVA: 0x00103205 File Offset: 0x00101405
		// (set) Token: 0x06006323 RID: 25379 RVA: 0x0010320D File Offset: 0x0010140D
		public float DonutRadius
		{
			get
			{
				return this.m_DonutRadius;
			}
			set
			{
				this.m_DonutRadius = value;
			}
		}

		// Token: 0x1700199A RID: 6554
		// (get) Token: 0x06006324 RID: 25380 RVA: 0x00103216 File Offset: 0x00101416
		// (set) Token: 0x06006325 RID: 25381 RVA: 0x0010321E File Offset: 0x0010141E
		public bool Enabled
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

		// Token: 0x1700199B RID: 6555
		// (get) Token: 0x06006326 RID: 25382 RVA: 0x00103227 File Offset: 0x00101427
		// (set) Token: 0x06006327 RID: 25383 RVA: 0x0010322F File Offset: 0x0010142F
		public float Length
		{
			get
			{
				return this.m_Length;
			}
			set
			{
				this.m_Length = value;
			}
		}

		// Token: 0x1700199C RID: 6556
		// (get) Token: 0x06006328 RID: 25384 RVA: 0x00103238 File Offset: 0x00101438

		public IPPtr_Mesh Mesh
		{

			get
			{
				return this.m_Mesh;
			}
		}

		// Token: 0x1700199D RID: 6557
		// (get) Token: 0x06006329 RID: 25385 RVA: 0x00103240 File Offset: 0x00101440
		// (set) Token: 0x0600632A RID: 25386 RVA: 0x00103248 File Offset: 0x00101448
		public int MeshMaterialIndex
		{
			get
			{
				return this.m_MeshMaterialIndex;
			}
			set
			{
				this.m_MeshMaterialIndex = value;
			}
		}

		// Token: 0x1700199E RID: 6558
		// (get) Token: 0x0600632B RID: 25387 RVA: 0x00103251 File Offset: 0x00101451
		// (set) Token: 0x0600632C RID: 25388 RVA: 0x00103259 File Offset: 0x00101459
		public float MeshNormalOffset
		{
			get
			{
				return this.m_MeshNormalOffset;
			}
			set
			{
				this.m_MeshNormalOffset = value;
			}
		}

		// Token: 0x1700199F RID: 6559
		// (get) Token: 0x0600632D RID: 25389 RVA: 0x00103262 File Offset: 0x00101462
		public PPtr_MeshRenderer MeshRenderer
		{
			[return: NotNull]
			get
			{
				return this.m_MeshRenderer;
			}
		}

		// Token: 0x170019A0 RID: 6560
		// (get) Token: 0x0600632E RID: 25390 RVA: 0x0010326A File Offset: 0x0010146A
		// (set) Token: 0x0600632F RID: 25391 RVA: 0x00103271 File Offset: 0x00101471
		public float MeshScale
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x170019A1 RID: 6561
		// (get) Token: 0x06006330 RID: 25392 RVA: 0x00103273 File Offset: 0x00101473
		public MultiModeParameter_MeshSpawn MeshSpawn
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170019A2 RID: 6562
		// (get) Token: 0x06006331 RID: 25393 RVA: 0x00103276 File Offset: 0x00101476
		// (set) Token: 0x06006332 RID: 25394 RVA: 0x0010327E File Offset: 0x0010147E
		public int PlacementMode
		{
			get
			{
				return this.m_PlacementMode;
			}
			set
			{
				this.m_PlacementMode = value;
			}
		}

		// Token: 0x170019A3 RID: 6563
		// (get) Token: 0x06006333 RID: 25395 RVA: 0x00103287 File Offset: 0x00101487
		public Vector3f_3_5_0 Position
		{
			[return: NotNull]
			get
			{
				return this.m_Position;
			}
		}

		// Token: 0x170019A4 RID: 6564
		// (get) Token: 0x06006334 RID: 25396 RVA: 0x0010328F File Offset: 0x0010148F
		// (set) Token: 0x06006335 RID: 25397 RVA: 0x00103296 File Offset: 0x00101496
		public float Radius
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x170019A5 RID: 6565
		// (get) Token: 0x06006336 RID: 25398 RVA: 0x00103298 File Offset: 0x00101498
		public IMultiModeParameter RadiusParameter
		{
			[return: NotNull]
			get
			{
				return this.m_RadiusParameter;
			}
		}

		// Token: 0x170019A6 RID: 6566
		// (get) Token: 0x06006337 RID: 25399 RVA: 0x001032A0 File Offset: 0x001014A0
		// (set) Token: 0x06006338 RID: 25400 RVA: 0x001032A8 File Offset: 0x001014A8
		public float RadiusThickness
		{
			get
			{
				return this.m_RadiusThickness;
			}
			set
			{
				this.m_RadiusThickness = value;
			}
		}

		// Token: 0x170019A7 RID: 6567
		// (get) Token: 0x06006339 RID: 25401 RVA: 0x001032B1 File Offset: 0x001014B1
		// (set) Token: 0x0600633A RID: 25402 RVA: 0x001032B4 File Offset: 0x001014B4
		public bool RandomDirection
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x170019A8 RID: 6568
		// (get) Token: 0x0600633B RID: 25403 RVA: 0x001032B6 File Offset: 0x001014B6
		// (set) Token: 0x0600633C RID: 25404 RVA: 0x001032BE File Offset: 0x001014BE
		public float RandomDirectionAmount
		{
			get
			{
				return this.m_RandomDirectionAmount;
			}
			set
			{
				this.m_RandomDirectionAmount = value;
			}
		}

		// Token: 0x170019A9 RID: 6569
		// (get) Token: 0x0600633D RID: 25405 RVA: 0x001032C7 File Offset: 0x001014C7
		// (set) Token: 0x0600633E RID: 25406 RVA: 0x001032CF File Offset: 0x001014CF
		public float RandomPositionAmount
		{
			get
			{
				return this.m_RandomPositionAmount;
			}
			set
			{
				this.m_RandomPositionAmount = value;
			}
		}

		// Token: 0x170019AA RID: 6570
		// (get) Token: 0x0600633F RID: 25407 RVA: 0x001032D8 File Offset: 0x001014D8
		public Vector3f_3_5_0 Rotation
		{
			[return: NotNull]
			get
			{
				return this.m_Rotation;
			}
		}

		// Token: 0x170019AB RID: 6571
		// (get) Token: 0x06006340 RID: 25408 RVA: 0x001032E0 File Offset: 0x001014E0
		public Vector3f_3_5_0 Scale
		{
			[return: NotNull]
			get
			{
				return this.m_Scale;
			}
		}

		// Token: 0x170019AC RID: 6572
		// (get) Token: 0x06006341 RID: 25409 RVA: 0x001032E8 File Offset: 0x001014E8
		public PPtr_SkinnedMeshRenderer SkinnedMeshRenderer
		{
			[return: NotNull]
			get
			{
				return this.m_SkinnedMeshRenderer;
			}
		}

		// Token: 0x170019AD RID: 6573
		// (get) Token: 0x06006342 RID: 25410 RVA: 0x001032F0 File Offset: 0x001014F0
		// (set) Token: 0x06006343 RID: 25411 RVA: 0x001032F8 File Offset: 0x001014F8
		public float SphericalDirectionAmount
		{
			get
			{
				return this.m_SphericalDirectionAmount;
			}
			set
			{
				this.m_SphericalDirectionAmount = value;
			}
		}

		// Token: 0x170019AE RID: 6574
		// (get) Token: 0x06006344 RID: 25412 RVA: 0x00103301 File Offset: 0x00101501
		public PPtr_Sprite_5_0_0 Sprite
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170019AF RID: 6575
		// (get) Token: 0x06006345 RID: 25413 RVA: 0x00103304 File Offset: 0x00101504
		public PPtr_SpriteRenderer SpriteRenderer
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170019B0 RID: 6576
		// (get) Token: 0x06006346 RID: 25414 RVA: 0x00103307 File Offset: 0x00101507
		public PPtr_Texture2D_5_0_0 Texture
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170019B1 RID: 6577
		// (get) Token: 0x06006347 RID: 25415 RVA: 0x0010330A File Offset: 0x0010150A
		// (set) Token: 0x06006348 RID: 25416 RVA: 0x0010330D File Offset: 0x0010150D
		public bool TextureAlphaAffectsParticles
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x170019B2 RID: 6578
		// (get) Token: 0x06006349 RID: 25417 RVA: 0x0010330F File Offset: 0x0010150F
		// (set) Token: 0x0600634A RID: 25418 RVA: 0x00103312 File Offset: 0x00101512
		public bool TextureBilinearFiltering
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x170019B3 RID: 6579
		// (get) Token: 0x0600634B RID: 25419 RVA: 0x00103314 File Offset: 0x00101514
		// (set) Token: 0x0600634C RID: 25420 RVA: 0x00103317 File Offset: 0x00101517
		public int TextureClipChannel
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x170019B4 RID: 6580
		// (get) Token: 0x0600634D RID: 25421 RVA: 0x00103319 File Offset: 0x00101519
		// (set) Token: 0x0600634E RID: 25422 RVA: 0x00103320 File Offset: 0x00101520
		public float TextureClipThreshold
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x170019B5 RID: 6581
		// (get) Token: 0x0600634F RID: 25423 RVA: 0x00103322 File Offset: 0x00101522
		// (set) Token: 0x06006350 RID: 25424 RVA: 0x00103325 File Offset: 0x00101525
		public bool TextureColorAffectsParticles
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x170019B6 RID: 6582
		// (get) Token: 0x06006351 RID: 25425 RVA: 0x00103327 File Offset: 0x00101527
		// (set) Token: 0x06006352 RID: 25426 RVA: 0x0010332A File Offset: 0x0010152A
		public int TextureUVChannel
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x170019B7 RID: 6583
		// (get) Token: 0x06006353 RID: 25427 RVA: 0x0010332C File Offset: 0x0010152C
		// (set) Token: 0x06006354 RID: 25428 RVA: 0x00103334 File Offset: 0x00101534
		public int Type
		{
			get
			{
				return this.m_Type;
			}
			set
			{
				this.m_Type = value;
			}
		}

		// Token: 0x170019B8 RID: 6584
		// (get) Token: 0x06006355 RID: 25429 RVA: 0x0010333D File Offset: 0x0010153D
		// (set) Token: 0x06006356 RID: 25430 RVA: 0x00103345 File Offset: 0x00101545
		public bool UseMeshColors
		{
			get
			{
				return this.m_UseMeshColors;
			}
			set
			{
				this.m_UseMeshColors = value;
			}
		}

		// Token: 0x170019B9 RID: 6585
		// (get) Token: 0x06006357 RID: 25431 RVA: 0x0010334E File Offset: 0x0010154E
		// (set) Token: 0x06006358 RID: 25432 RVA: 0x00103356 File Offset: 0x00101556
		public bool UseMeshMaterialIndex
		{
			get
			{
				return this.m_UseMeshMaterialIndex;
			}
			set
			{
				this.m_UseMeshMaterialIndex = value;
			}
		}

		// Token: 0x170019BA RID: 6586
		// (get) Token: 0x06006359 RID: 25433 RVA: 0x0010335F File Offset: 0x0010155F
		// (set) Token: 0x0600635A RID: 25434 RVA: 0x00103362 File Offset: 0x00101562
		public ParticleSystemShapeTextureChannel TextureClipChannelE
		{
			get
			{
				return ParticleSystemShapeTextureChannel.Red;
			}
			set
			{
			}
		}

		// Token: 0x0600635B RID: 25435 RVA: 0x00103364 File Offset: 0x00101564
		public ShapeModule_2017_1_0_b3_GICB2()
		{
			this.m_BoxThickness = new Vector3f_3_5_0();
			this.m_Position = new Vector3f_3_5_0();
			this.m_Rotation = new Vector3f_3_5_0();
			this.m_Scale = new Vector3f_3_5_0();
			this.m_Mesh = new PPtr_Mesh_5_0_0();
			this.m_MeshRenderer = new PPtr_MeshRenderer();
			this.m_SkinnedMeshRenderer = new PPtr_SkinnedMeshRenderer();
			this.m_RadiusParameter = new MultiModeParameter_2017_1_0_b3();
			this.m_ArcParameter = new MultiModeParameter_2017_1_0_b3();
		}

		// Token: 0x0600635C RID: 25436 RVA: 0x001033DA File Offset: 0x001015DA
		public bool Has_AlignToDirection()
		{
			return true;
		}

		// Token: 0x0600635D RID: 25437 RVA: 0x001033DD File Offset: 0x001015DD
		public bool Has_Arc()
		{
			return false;
		}

		// Token: 0x0600635E RID: 25438 RVA: 0x001033E0 File Offset: 0x001015E0
		public bool Has_ArcParameter()
		{
			return true;
		}

		// Token: 0x0600635F RID: 25439 RVA: 0x001033E3 File Offset: 0x001015E3
		public bool Has_BoxThickness()
		{
			return true;
		}

		// Token: 0x06006360 RID: 25440 RVA: 0x001033E6 File Offset: 0x001015E6
		public bool Has_BoxX()
		{
			return false;
		}

		// Token: 0x06006361 RID: 25441 RVA: 0x001033E9 File Offset: 0x001015E9
		public bool Has_BoxY()
		{
			return false;
		}

		// Token: 0x06006362 RID: 25442 RVA: 0x001033EC File Offset: 0x001015EC
		public bool Has_BoxZ()
		{
			return false;
		}

		// Token: 0x06006363 RID: 25443 RVA: 0x001033EF File Offset: 0x001015EF
		public bool Has_DonutRadius()
		{
			return true;
		}

		// Token: 0x06006364 RID: 25444 RVA: 0x001033F2 File Offset: 0x001015F2
		public bool Has_Length()
		{
			return true;
		}

		// Token: 0x06006365 RID: 25445 RVA: 0x001033F5 File Offset: 0x001015F5
		public bool Has_MeshMaterialIndex()
		{
			return true;
		}

		// Token: 0x06006366 RID: 25446 RVA: 0x001033F8 File Offset: 0x001015F8
		public bool Has_MeshNormalOffset()
		{
			return true;
		}

		// Token: 0x06006367 RID: 25447 RVA: 0x001033FB File Offset: 0x001015FB
		public bool Has_MeshRenderer()
		{
			return true;
		}

		// Token: 0x06006368 RID: 25448 RVA: 0x001033FE File Offset: 0x001015FE
		public bool Has_MeshScale()
		{
			return false;
		}

		// Token: 0x06006369 RID: 25449 RVA: 0x00103401 File Offset: 0x00101601
		public bool Has_MeshSpawn()
		{
			return false;
		}

		// Token: 0x0600636A RID: 25450 RVA: 0x00103404 File Offset: 0x00101604
		public bool Has_Position()
		{
			return true;
		}

		// Token: 0x0600636B RID: 25451 RVA: 0x00103407 File Offset: 0x00101607
		public bool Has_Radius()
		{
			return false;
		}

		// Token: 0x0600636C RID: 25452 RVA: 0x0010340A File Offset: 0x0010160A
		public bool Has_RadiusParameter()
		{
			return true;
		}

		// Token: 0x0600636D RID: 25453 RVA: 0x0010340D File Offset: 0x0010160D
		public bool Has_RadiusThickness()
		{
			return true;
		}

		// Token: 0x0600636E RID: 25454 RVA: 0x00103410 File Offset: 0x00101610
		public bool Has_RandomDirection()
		{
			return false;
		}

		// Token: 0x0600636F RID: 25455 RVA: 0x00103413 File Offset: 0x00101613
		public bool Has_RandomDirectionAmount()
		{
			return true;
		}

		// Token: 0x06006370 RID: 25456 RVA: 0x00103416 File Offset: 0x00101616
		public bool Has_RandomPositionAmount()
		{
			return true;
		}

		// Token: 0x06006371 RID: 25457 RVA: 0x00103419 File Offset: 0x00101619
		public bool Has_Rotation()
		{
			return true;
		}

		// Token: 0x06006372 RID: 25458 RVA: 0x0010341C File Offset: 0x0010161C
		public bool Has_Scale()
		{
			return true;
		}

		// Token: 0x06006373 RID: 25459 RVA: 0x0010341F File Offset: 0x0010161F
		public bool Has_SkinnedMeshRenderer()
		{
			return true;
		}

		// Token: 0x06006374 RID: 25460 RVA: 0x00103422 File Offset: 0x00101622
		public bool Has_SphericalDirectionAmount()
		{
			return true;
		}

		// Token: 0x06006375 RID: 25461 RVA: 0x00103425 File Offset: 0x00101625
		public bool Has_Sprite()
		{
			return false;
		}

		// Token: 0x06006376 RID: 25462 RVA: 0x00103428 File Offset: 0x00101628
		public bool Has_SpriteRenderer()
		{
			return false;
		}

		// Token: 0x06006377 RID: 25463 RVA: 0x0010342B File Offset: 0x0010162B
		public bool Has_Texture()
		{
			return false;
		}

		// Token: 0x06006378 RID: 25464 RVA: 0x0010342E File Offset: 0x0010162E
		public bool Has_TextureAlphaAffectsParticles()
		{
			return false;
		}

		// Token: 0x06006379 RID: 25465 RVA: 0x00103431 File Offset: 0x00101631
		public bool Has_TextureBilinearFiltering()
		{
			return false;
		}

		// Token: 0x0600637A RID: 25466 RVA: 0x00103434 File Offset: 0x00101634
		public bool Has_TextureClipChannel()
		{
			return false;
		}

		// Token: 0x0600637B RID: 25467 RVA: 0x00103437 File Offset: 0x00101637
		public bool Has_TextureClipThreshold()
		{
			return false;
		}

		// Token: 0x0600637C RID: 25468 RVA: 0x0010343A File Offset: 0x0010163A
		public bool Has_TextureColorAffectsParticles()
		{
			return false;
		}

		// Token: 0x0600637D RID: 25469 RVA: 0x0010343D File Offset: 0x0010163D
		public bool Has_TextureUVChannel()
		{
			return false;
		}

		// Token: 0x0600637E RID: 25470 RVA: 0x00103440 File Offset: 0x00101640
		public bool Has_UseMeshColors()
		{
			return true;
		}

		// Token: 0x0600637F RID: 25471 RVA: 0x00103443 File Offset: 0x00101643
		public bool Has_UseMeshMaterialIndex()
		{
			return true;
		}

		// Token: 0x06006380 RID: 25472 RVA: 0x00103448 File Offset: 0x00101648

		public override void ReadRelease(AssetReader reader)
		{
			this.m_Enabled = reader.ReadRelease_BooleanAlign();
			this.m_Type = reader.ReadInt32();
			this.m_Angle = reader.ReadSingle();
			this.m_Length = reader.ReadSingle();
			this.m_BoxThickness.ReadRelease(reader);
			this.m_RadiusThickness = reader.ReadSingle();
			this.m_DonutRadius = reader.ReadSingle();
			this.m_Position.ReadRelease(reader);
			this.m_Rotation.ReadRelease(reader);
			this.m_Scale.ReadRelease(reader);
			this.m_PlacementMode = reader.ReadInt32();
			this.m_Mesh.ReadRelease(reader);
			this.m_MeshRenderer.ReadRelease(reader);
			this.m_SkinnedMeshRenderer.ReadRelease(reader);
			this.m_MeshMaterialIndex = reader.ReadInt32();
			this.m_MeshNormalOffset = reader.ReadSingle();
			this.m_UseMeshMaterialIndex = reader.ReadBoolean();
			this.m_UseMeshColors = reader.ReadBoolean();
			this.m_AlignToDirection = reader.ReadRelease_BooleanAlign();
			this.m_RandomDirectionAmount = reader.ReadSingle();
			this.m_SphericalDirectionAmount = reader.ReadSingle();
			this.m_RandomPositionAmount = reader.ReadSingle();
			this.m_RadiusParameter.ReadRelease(reader);
			this.m_ArcParameter.ReadRelease(reader);
			// GICB2
			this.UseMeshScale = reader.ReadBoolean();
			reader.AlignStream();
		}

		// Token: 0x06006381 RID: 25473 RVA: 0x00103578 File Offset: 0x00101778

		public override void ReadEditor(AssetReader reader)
		{
			// this.m_Enabled = reader.ReadEditor_BooleanAlign();
			// this.m_Type = reader.ReadInt32();
			// this.m_Angle = reader.ReadSingle();
			// this.m_Length = reader.ReadSingle();
			// this.m_BoxThickness.ReadEditor(reader);
			// this.m_RadiusThickness = reader.ReadSingle();
			// this.m_DonutRadius = reader.ReadSingle();
			// this.m_Position.ReadEditor(reader);
			// this.m_Rotation.ReadEditor(reader);
			// this.m_Scale.ReadEditor(reader);
			// this.m_PlacementMode = reader.ReadInt32();
			// this.m_Mesh.ReadEditor(reader);
			// this.m_MeshRenderer.ReadEditor(reader);
			// this.m_SkinnedMeshRenderer.ReadEditor(reader);
			// this.m_MeshMaterialIndex = reader.ReadInt32();
			// this.m_MeshNormalOffset = reader.ReadSingle();
			// this.m_UseMeshMaterialIndex = reader.ReadBoolean();
			// this.m_UseMeshColors = reader.ReadBoolean();
			// this.m_AlignToDirection = reader.ReadEditor_BooleanAlign();
			// this.m_RandomDirectionAmount = reader.ReadSingle();
			// this.m_SphericalDirectionAmount = reader.ReadSingle();
			// this.m_RandomPositionAmount = reader.ReadSingle();
			// this.m_RadiusParameter.ReadEditor(reader);
			// this.m_ArcParameter.ReadEditor(reader);
		}

		// Token: 0x06006382 RID: 25474 RVA: 0x001036A8 File Offset: 0x001018A8

		public override void WriteRelease(AssetWriter writer)
		{
			this.m_Enabled.WriteRelease_BooleanAlign(writer);
			this.m_Type.WriteRelease_Int32(writer);
			this.m_Angle.WriteRelease_Single(writer);
			this.m_Length.WriteRelease_Single(writer);
			this.m_BoxThickness.WriteRelease(writer);
			this.m_RadiusThickness.WriteRelease_Single(writer);
			this.m_DonutRadius.WriteRelease_Single(writer);
			this.m_Position.WriteRelease(writer);
			this.m_Rotation.WriteRelease(writer);
			this.m_Scale.WriteRelease(writer);
			this.m_PlacementMode.WriteRelease_Int32(writer);
			this.m_Mesh.WriteRelease(writer);
			this.m_MeshRenderer.WriteRelease(writer);
			this.m_SkinnedMeshRenderer.WriteRelease(writer);
			this.m_MeshMaterialIndex.WriteRelease_Int32(writer);
			this.m_MeshNormalOffset.WriteRelease_Single(writer);
			this.m_UseMeshMaterialIndex.WriteRelease_Boolean(writer);
			this.m_UseMeshColors.WriteRelease_Boolean(writer);
			this.m_AlignToDirection.WriteRelease_BooleanAlign(writer);
			this.m_RandomDirectionAmount.WriteRelease_Single(writer);
			this.m_SphericalDirectionAmount.WriteRelease_Single(writer);
			this.m_RandomPositionAmount.WriteRelease_Single(writer);
			this.m_RadiusParameter.WriteRelease(writer);
			this.m_ArcParameter.WriteRelease(writer);
		}

		// Token: 0x06006383 RID: 25475 RVA: 0x001037D8 File Offset: 0x001019D8

		public override void WriteEditor(AssetWriter writer)
		{
			// this.m_Enabled.WriteEditor_BooleanAlign(writer);
			// this.m_Type.WriteEditor_Int32(writer);
			// this.m_Angle.WriteEditor_Single(writer);
			// this.m_Length.WriteEditor_Single(writer);
			// this.m_BoxThickness.WriteEditor(writer);
			// this.m_RadiusThickness.WriteEditor_Single(writer);
			// this.m_DonutRadius.WriteEditor_Single(writer);
			// this.m_Position.WriteEditor(writer);
			// this.m_Rotation.WriteEditor(writer);
			// this.m_Scale.WriteEditor(writer);
			// this.m_PlacementMode.WriteEditor_Int32(writer);
			// this.m_Mesh.WriteEditor(writer);
			// this.m_MeshRenderer.WriteEditor(writer);
			// this.m_SkinnedMeshRenderer.WriteEditor(writer);
			// this.m_MeshMaterialIndex.WriteEditor_Int32(writer);
			// this.m_MeshNormalOffset.WriteEditor_Single(writer);
			// this.m_UseMeshMaterialIndex.WriteEditor_Boolean(writer);
			// this.m_UseMeshColors.WriteEditor_Boolean(writer);
			// this.m_AlignToDirection.WriteEditor_BooleanAlign(writer);
			// this.m_RandomDirectionAmount.WriteEditor_Single(writer);
			// this.m_SphericalDirectionAmount.WriteEditor_Single(writer);
			// this.m_RandomPositionAmount.WriteEditor_Single(writer);
			// this.m_RadiusParameter.WriteEditor(writer);
			// this.m_ArcParameter.WriteEditor(writer);
		}

		// Token: 0x06006384 RID: 25476 RVA: 0x00103908 File Offset: 0x00101B08

		public override YamlNode ExportYamlRelease(IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			YamlSerializedVersionExtensions.AddSerializedVersion(yamlMappingNode, 5);
			yamlMappingNode.Add(new YamlScalarNode("enabled"), this.m_Enabled.ExportYamlRelease_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("type"), this.m_Type.ExportYamlRelease_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("angle"), this.m_Angle.ExportYamlRelease_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("length"), this.m_Length.ExportYamlRelease_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("boxThickness"), this.m_BoxThickness.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("radiusThickness"), this.m_RadiusThickness.ExportYamlRelease_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("donutRadius"), this.m_DonutRadius.ExportYamlRelease_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Position"), this.m_Position.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Rotation"), this.m_Rotation.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Scale"), this.m_Scale.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("placementMode"), this.m_PlacementMode.ExportYamlRelease_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Mesh"), this.m_Mesh.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("m_MeshRenderer"), this.m_MeshRenderer.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("m_SkinnedMeshRenderer"), this.m_SkinnedMeshRenderer.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("m_MeshMaterialIndex"), this.m_MeshMaterialIndex.ExportYamlRelease_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("m_MeshNormalOffset"), this.m_MeshNormalOffset.ExportYamlRelease_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("m_UseMeshMaterialIndex"), this.m_UseMeshMaterialIndex.ExportYamlRelease_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("m_UseMeshColors"), this.m_UseMeshColors.ExportYamlRelease_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("alignToDirection"), this.m_AlignToDirection.ExportYamlRelease_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("randomDirectionAmount"), this.m_RandomDirectionAmount.ExportYamlRelease_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("sphericalDirectionAmount"), this.m_SphericalDirectionAmount.ExportYamlRelease_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("randomPositionAmount"), this.m_RandomPositionAmount.ExportYamlRelease_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("radius"), this.m_RadiusParameter.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("arc"), this.m_ArcParameter.ExportYamlRelease(container));
			return yamlMappingNode;
		}

		// Token: 0x06006385 RID: 25477 RVA: 0x00103BC4 File Offset: 0x00101DC4

		public override YamlNode ExportYamlEditor(IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			YamlSerializedVersionExtensions.AddSerializedVersion(yamlMappingNode, 5);
			yamlMappingNode.Add(new YamlScalarNode("enabled"), this.m_Enabled.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("type"), this.m_Type.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("angle"), this.m_Angle.ExportYamlEditor_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("length"), this.m_Length.ExportYamlEditor_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("boxThickness"), this.m_BoxThickness.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("radiusThickness"), this.m_RadiusThickness.ExportYamlEditor_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("donutRadius"), this.m_DonutRadius.ExportYamlEditor_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Position"), this.m_Position.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Rotation"), this.m_Rotation.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Scale"), this.m_Scale.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("placementMode"), this.m_PlacementMode.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("m_Mesh"), this.m_Mesh.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_MeshRenderer"), this.m_MeshRenderer.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_SkinnedMeshRenderer"), this.m_SkinnedMeshRenderer.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_MeshMaterialIndex"), this.m_MeshMaterialIndex.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("m_MeshNormalOffset"), this.m_MeshNormalOffset.ExportYamlEditor_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("m_UseMeshMaterialIndex"), this.m_UseMeshMaterialIndex.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("m_UseMeshColors"), this.m_UseMeshColors.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("alignToDirection"), this.m_AlignToDirection.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("randomDirectionAmount"), this.m_RandomDirectionAmount.ExportYamlEditor_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("sphericalDirectionAmount"), this.m_SphericalDirectionAmount.ExportYamlEditor_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("randomPositionAmount"), this.m_RandomPositionAmount.ExportYamlEditor_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("radius"), this.m_RadiusParameter.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("arc"), this.m_ArcParameter.ExportYamlEditor(container));
			return yamlMappingNode;
		}

		// Token: 0x06006386 RID: 25478 RVA: 0x00103E80 File Offset: 0x00102080
		public override void Reset()
		{
			this.m_AlignToDirection = false;
			this.m_Angle = 0f;
			this.m_ArcParameter.Reset();
			this.m_BoxThickness.Reset();
			this.m_DonutRadius = 0f;
			this.m_Enabled = false;
			this.m_Length = 0f;
			this.m_Mesh.Reset();
			this.m_MeshMaterialIndex = 0;
			this.m_MeshNormalOffset = 0f;
			this.m_MeshRenderer.Reset();
			this.m_PlacementMode = 0;
			this.m_Position.Reset();
			this.m_RadiusParameter.Reset();
			this.m_RadiusThickness = 0f;
			this.m_RandomDirectionAmount = 0f;
			this.m_RandomPositionAmount = 0f;
			this.m_Rotation.Reset();
			this.m_Scale.Reset();
			this.m_SkinnedMeshRenderer.Reset();
			this.m_SphericalDirectionAmount = 0f;
			this.m_Type = 0;
			this.m_UseMeshColors = false;
			this.m_UseMeshMaterialIndex = false;
		}

		// Token: 0x06006387 RID: 25479 RVA: 0x00103F79 File Offset: 0x00102179

		//public override IEnumerable<ValueTuple<FieldName, PPtr<IUnityObjectBase>>> FetchDependencies(FieldName parent)
		//{
		//	return Enumerable.Empty<ValueTuple<FieldName, PPtr<IUnityObjectBase>>>().Append_ShapeModule_2017_1_0_b3(parent, this);
		//}

		// Token: 0x06006388 RID: 25480 RVA: 0x00103F88 File Offset: 0x00102188
		public void CopyValues(IShapeModule source, PPtrConverter converter)
		{
			if (source != null)
			{
				this.m_AlignToDirection = source.AlignToDirection;
				this.m_Angle = source.Angle;
				this.m_ArcParameter.CopyValues(source.ArcParameter);
				this.m_BoxThickness.CopyValues(source.BoxThickness);
				this.m_DonutRadius = source.DonutRadius;
				this.m_Enabled = source.Enabled;
				this.m_Length = source.Length;
				this.m_Mesh.CopyValues(source.Mesh, converter);
				this.m_MeshMaterialIndex = source.MeshMaterialIndex;
				this.m_MeshNormalOffset = source.MeshNormalOffset;
				this.m_MeshRenderer.CopyValues(source.MeshRenderer, converter);
				this.m_PlacementMode = source.PlacementMode;
				this.m_Position.CopyValues(source.Position);
				this.m_RadiusParameter.CopyValues(source.RadiusParameter);
				this.m_RadiusThickness = source.RadiusThickness;
				this.m_RandomDirectionAmount = source.RandomDirectionAmount;
				this.m_RandomPositionAmount = source.RandomPositionAmount;
				this.m_Rotation.CopyValues(source.Rotation);
				this.m_Scale.CopyValues(source.Scale);
				this.m_SkinnedMeshRenderer.CopyValues(source.SkinnedMeshRenderer, converter);
				this.m_SphericalDirectionAmount = source.SphericalDirectionAmount;
				this.m_Type = source.Type;
				this.m_UseMeshColors = source.UseMeshColors;
				this.m_UseMeshMaterialIndex = source.UseMeshMaterialIndex;
				return;
			}
			this.Reset();
		}

		// Token: 0x06006389 RID: 25481 RVA: 0x001040F2 File Offset: 0x001022F2

		public IShapeModule DeepClone(PPtrConverter converter)
		{
			ShapeModule_2017_1_0_b3 shapeModule_2017_1_0_b = new ShapeModule_2017_1_0_b3();
			shapeModule_2017_1_0_b.CopyValues(this, converter);
			return shapeModule_2017_1_0_b;
		}

		// Token: 0x0600638A RID: 25482 RVA: 0x00104104 File Offset: 0x00102304
		public override void CopyValues(IUnityAssetBase source, PPtrConverter converter)
		{
			IShapeModule shapeModule = source as IShapeModule;
			if (shapeModule != null)
			{
				this.CopyValues(shapeModule, converter);
				return;
			}
			this.Reset();
		}

		// Token: 0x0600638B RID: 25483 RVA: 0x0010412C File Offset: 0x0010232C
		public bool Equals(IShapeModule other)
		{
			return other != null && this.AlignToDirection == other.AlignToDirection && this.Angle == other.Angle && this.Arc == other.Arc && EqualityComparer<IMultiModeParameter>.Default.Equals(this.ArcParameter, other.ArcParameter) && EqualityComparer<Vector3f_3_5_0>.Default.Equals(this.BoxThickness, other.BoxThickness) && this.BoxX == other.BoxX && this.BoxY == other.BoxY && this.BoxZ == other.BoxZ && this.DonutRadius == other.DonutRadius && this.Enabled == other.Enabled && this.Length == other.Length && EqualityComparer<IPPtr_Mesh>.Default.Equals(this.Mesh, other.Mesh) && this.MeshMaterialIndex == other.MeshMaterialIndex && this.MeshNormalOffset == other.MeshNormalOffset && EqualityComparer<PPtr_MeshRenderer>.Default.Equals(this.MeshRenderer, other.MeshRenderer) && this.MeshScale == other.MeshScale && EqualityComparer<MultiModeParameter_MeshSpawn>.Default.Equals(this.MeshSpawn, other.MeshSpawn) && this.PlacementMode == other.PlacementMode && EqualityComparer<Vector3f_3_5_0>.Default.Equals(this.Position, other.Position) && this.Radius == other.Radius && EqualityComparer<IMultiModeParameter>.Default.Equals(this.RadiusParameter, other.RadiusParameter) && this.RadiusThickness == other.RadiusThickness && this.RandomDirection == other.RandomDirection && this.RandomDirectionAmount == other.RandomDirectionAmount && this.RandomPositionAmount == other.RandomPositionAmount && EqualityComparer<Vector3f_3_5_0>.Default.Equals(this.Rotation, other.Rotation) && EqualityComparer<Vector3f_3_5_0>.Default.Equals(this.Scale, other.Scale) && EqualityComparer<PPtr_SkinnedMeshRenderer>.Default.Equals(this.SkinnedMeshRenderer, other.SkinnedMeshRenderer) && this.SphericalDirectionAmount == other.SphericalDirectionAmount && EqualityComparer<PPtr_Sprite_5_0_0>.Default.Equals(this.Sprite, other.Sprite) && EqualityComparer<PPtr_SpriteRenderer>.Default.Equals(this.SpriteRenderer, other.SpriteRenderer) && EqualityComparer<PPtr_Texture2D_5_0_0>.Default.Equals(this.Texture, other.Texture) && this.TextureAlphaAffectsParticles == other.TextureAlphaAffectsParticles && this.TextureBilinearFiltering == other.TextureBilinearFiltering && this.TextureClipChannel == other.TextureClipChannel && this.TextureClipThreshold == other.TextureClipThreshold && this.TextureColorAffectsParticles == other.TextureColorAffectsParticles && this.TextureUVChannel == other.TextureUVChannel && this.Type == other.Type && this.UseMeshColors == other.UseMeshColors && this.UseMeshMaterialIndex == other.UseMeshMaterialIndex;
		}

		// Token: 0x0600638C RID: 25484 RVA: 0x00104464 File Offset: 0x00102664
		public bool Equals(ShapeModule_2017_1_0_b3 other)
		{
			return other != null && this.m_Enabled == other.m_Enabled && this.m_Type == other.m_Type && this.m_Angle == other.m_Angle && this.m_Length == other.m_Length && EqualityComparer<Vector3f_3_5_0>.Default.Equals(this.m_BoxThickness, other.m_BoxThickness) && this.m_RadiusThickness == other.m_RadiusThickness && this.m_DonutRadius == other.m_DonutRadius && EqualityComparer<Vector3f_3_5_0>.Default.Equals(this.m_Position, other.m_Position) && EqualityComparer<Vector3f_3_5_0>.Default.Equals(this.m_Rotation, other.m_Rotation) && EqualityComparer<Vector3f_3_5_0>.Default.Equals(this.m_Scale, other.m_Scale) && this.m_PlacementMode == other.m_PlacementMode && EqualityComparer<PPtr_Mesh_5_0_0>.Default.Equals(this.m_Mesh, other.m_Mesh) && EqualityComparer<PPtr_MeshRenderer>.Default.Equals(this.m_MeshRenderer, other.m_MeshRenderer) && EqualityComparer<PPtr_SkinnedMeshRenderer>.Default.Equals(this.m_SkinnedMeshRenderer, other.m_SkinnedMeshRenderer) && this.m_MeshMaterialIndex == other.m_MeshMaterialIndex && this.m_MeshNormalOffset == other.m_MeshNormalOffset && this.m_UseMeshMaterialIndex == other.m_UseMeshMaterialIndex && this.m_UseMeshColors == other.m_UseMeshColors && this.m_AlignToDirection == other.m_AlignToDirection && this.m_RandomDirectionAmount == other.m_RandomDirectionAmount && this.m_SphericalDirectionAmount == other.m_SphericalDirectionAmount && this.m_RandomPositionAmount == other.m_RandomPositionAmount && EqualityComparer<MultiModeParameter_2017_1_0_b3>.Default.Equals(this.m_RadiusParameter, other.m_RadiusParameter) && EqualityComparer<MultiModeParameter_2017_1_0_b3>.Default.Equals(this.m_ArcParameter, other.m_ArcParameter);
		}

		// Token: 0x0600638D RID: 25485 RVA: 0x00104654 File Offset: 0x00102854
		public override bool Equals(object other)
		{
			return this.Equals(other as IShapeModule);
		}

		// Token: 0x0600638E RID: 25486 RVA: 0x00104662 File Offset: 0x00102862
		public static bool operator ==(ShapeModule_2017_1_0_b3_GICB2 left, ShapeModule_2017_1_0_b3_GICB2 right)
		{
			return EqualityComparer<ShapeModule_2017_1_0_b3_GICB2>.Default.Equals(left, right);
		}

		// Token: 0x0600638F RID: 25487 RVA: 0x00104670 File Offset: 0x00102870
		public static bool operator !=(ShapeModule_2017_1_0_b3_GICB2 left, ShapeModule_2017_1_0_b3_GICB2 right)
		{
			return !(left == right);
		}

		// Token: 0x06006390 RID: 25488 RVA: 0x0010467C File Offset: 0x0010287C
		public override int GetHashCode()
		{
			HashCode hashCode = default(HashCode);
			hashCode.Add<bool>(this.AlignToDirection);
			hashCode.Add<float>(this.Angle);
			hashCode.Add<float>(this.Arc);
			hashCode.Add<IMultiModeParameter>(this.ArcParameter);
			hashCode.Add<Vector3f_3_5_0>(this.BoxThickness);
			hashCode.Add<float>(this.BoxX);
			hashCode.Add<float>(this.BoxY);
			hashCode.Add<float>(this.BoxZ);
			hashCode.Add<float>(this.DonutRadius);
			hashCode.Add<bool>(this.Enabled);
			hashCode.Add<float>(this.Length);
			hashCode.Add<IPPtr_Mesh>(this.Mesh);
			hashCode.Add<int>(this.MeshMaterialIndex);
			hashCode.Add<float>(this.MeshNormalOffset);
			hashCode.Add<PPtr_MeshRenderer>(this.MeshRenderer);
			hashCode.Add<float>(this.MeshScale);
			hashCode.Add<MultiModeParameter_MeshSpawn>(this.MeshSpawn);
			hashCode.Add<int>(this.PlacementMode);
			hashCode.Add<Vector3f_3_5_0>(this.Position);
			hashCode.Add<float>(this.Radius);
			hashCode.Add<IMultiModeParameter>(this.RadiusParameter);
			hashCode.Add<float>(this.RadiusThickness);
			hashCode.Add<bool>(this.RandomDirection);
			hashCode.Add<float>(this.RandomDirectionAmount);
			hashCode.Add<float>(this.RandomPositionAmount);
			hashCode.Add<Vector3f_3_5_0>(this.Rotation);
			hashCode.Add<Vector3f_3_5_0>(this.Scale);
			hashCode.Add<PPtr_SkinnedMeshRenderer>(this.SkinnedMeshRenderer);
			hashCode.Add<float>(this.SphericalDirectionAmount);
			hashCode.Add<PPtr_Sprite_5_0_0>(this.Sprite);
			hashCode.Add<PPtr_SpriteRenderer>(this.SpriteRenderer);
			hashCode.Add<PPtr_Texture2D_5_0_0>(this.Texture);
			hashCode.Add<bool>(this.TextureAlphaAffectsParticles);
			hashCode.Add<bool>(this.TextureBilinearFiltering);
			hashCode.Add<int>(this.TextureClipChannel);
			hashCode.Add<float>(this.TextureClipThreshold);
			hashCode.Add<bool>(this.TextureColorAffectsParticles);
			hashCode.Add<int>(this.TextureUVChannel);
			hashCode.Add<int>(this.Type);
			hashCode.Add<bool>(this.UseMeshColors);
			hashCode.Add<bool>(this.UseMeshMaterialIndex);
			return hashCode.ToHashCode();
		}

		// Token: 0x06006391 RID: 25489 RVA: 0x001048AD File Offset: 0x00102AAD

		public override List<TypeTreeNode> MakeEditorTypeTreeNodes(int depth, int startingIndex)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06006392 RID: 25490 RVA: 0x001048B4 File Offset: 0x00102AB4

		public override List<TypeTreeNode> MakeReleaseTypeTreeNodes(int depth, int startingIndex)
		{
			throw new NotSupportedException();
		}

		// Token: 0x04001134 RID: 4404
		public bool m_Enabled;

		// Token: 0x04001135 RID: 4405
		public int m_Type;

		// Token: 0x04001136 RID: 4406
		public float m_Angle;

		// Token: 0x04001137 RID: 4407
		public float m_Length;

		// Token: 0x04001138 RID: 4408

		public Vector3f_3_5_0 m_BoxThickness;

		// Token: 0x04001139 RID: 4409
		public float m_RadiusThickness;

		// Token: 0x0400113A RID: 4410
		public float m_DonutRadius;

		// Token: 0x0400113B RID: 4411

		public Vector3f_3_5_0 m_Position;

		// Token: 0x0400113C RID: 4412

		public Vector3f_3_5_0 m_Rotation;

		// Token: 0x0400113D RID: 4413

		public Vector3f_3_5_0 m_Scale;

		// Token: 0x0400113E RID: 4414
		public int m_PlacementMode;

		// Token: 0x0400113F RID: 4415

		public PPtr_Mesh_5_0_0 m_Mesh;

		// Token: 0x04001140 RID: 4416

		public PPtr_MeshRenderer m_MeshRenderer;

		// Token: 0x04001141 RID: 4417

		public PPtr_SkinnedMeshRenderer m_SkinnedMeshRenderer;

		// Token: 0x04001142 RID: 4418
		public int m_MeshMaterialIndex;

		// Token: 0x04001143 RID: 4419
		public float m_MeshNormalOffset;

		// Token: 0x04001144 RID: 4420
		public bool m_UseMeshMaterialIndex;

		// Token: 0x04001145 RID: 4421
		public bool m_UseMeshColors;

		// Token: 0x04001146 RID: 4422
		public bool m_AlignToDirection;

		// Token: 0x04001147 RID: 4423
		public float m_RandomDirectionAmount;

		// Token: 0x04001148 RID: 4424
		public float m_SphericalDirectionAmount;

		// Token: 0x04001149 RID: 4425
		public float m_RandomPositionAmount;

		// Token: 0x0400114A RID: 4426

		public MultiModeParameter_2017_1_0_b3 m_RadiusParameter;

		// Token: 0x0400114B RID: 4427

		public MultiModeParameter_2017_1_0_b3 m_ArcParameter;

		public bool UseMeshScale { get; set; }
	}
}
