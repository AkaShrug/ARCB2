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
using AssetRipper.SourceGenerated.Classes.ClassID_4;
using AssetRipper.SourceGenerated.Enums;
using AssetRipper.SourceGenerated.Helpers;
using AssetRipper.SourceGenerated.Interfaces;
using AssetRipper.SourceGenerated.MarkerInterfaces;
using AssetRipper.SourceGenerated.Subclasses.ClampVelocityModule;
using AssetRipper.SourceGenerated.Subclasses.CollisionModule;
using AssetRipper.SourceGenerated.Subclasses.ColorBySpeedModule;
using AssetRipper.SourceGenerated.Subclasses.ColorModule;
using AssetRipper.SourceGenerated.Subclasses.CustomDataModule;
using AssetRipper.SourceGenerated.Subclasses.EmissionModule;
using AssetRipper.SourceGenerated.Subclasses.ExternalForcesModule;
using AssetRipper.SourceGenerated.Subclasses.ForceModule;
using AssetRipper.SourceGenerated.Subclasses.InheritVelocityModule;
using AssetRipper.SourceGenerated.Subclasses.InitialModule;
using AssetRipper.SourceGenerated.Subclasses.LifetimeByEmitterSpeedModule;
using AssetRipper.SourceGenerated.Subclasses.LightsModule;
using AssetRipper.SourceGenerated.Subclasses.MinMaxCurve;
using AssetRipper.SourceGenerated.Subclasses.NoiseModule;
using AssetRipper.SourceGenerated.Subclasses.PPtr_EditorExtension;
using AssetRipper.SourceGenerated.Subclasses.PPtr_GameObject;
using AssetRipper.SourceGenerated.Subclasses.PPtr_PrefabInstance;
using AssetRipper.SourceGenerated.Subclasses.PPtr_Prefab;
using AssetRipper.SourceGenerated.Subclasses.PPtr_Transform;
using AssetRipper.SourceGenerated.Subclasses.RotationBySpeedModule;
using AssetRipper.SourceGenerated.Subclasses.RotationModule;
using AssetRipper.SourceGenerated.Subclasses.ShapeModule;
using AssetRipper.SourceGenerated.Subclasses.SizeBySpeedModule;
using AssetRipper.SourceGenerated.Subclasses.SizeModule;
using AssetRipper.SourceGenerated.Subclasses.SubModule;
using AssetRipper.SourceGenerated.Subclasses.TrailModule;
using AssetRipper.SourceGenerated.Subclasses.TriggerModule;
using AssetRipper.SourceGenerated.Subclasses.UVModule;
using AssetRipper.SourceGenerated.Subclasses.Vector2f;
using AssetRipper.SourceGenerated.Subclasses.VelocityModule;
using AssetRipper.Yaml;
using AssetRipper.SourceGenerated.Classes.ClassID_198;
using AssetRipper.Import.GICB2.ParticleSystem.EmissionModule;
using AssetRipper.Import.GICB2.ParticleSystem.ShapeModule;

namespace AssetRipper.Import.GICB2.ParticleSystem
{
	// Token: 0x02002D55 RID: 11605


	public sealed class ParticleSystem_2017_1_0_b10_GICB2 : Component_5_5_0, IParticleSystem, IParticleSystemMarker, IUnityObjectBase, IUnityAssetBase, IAsset, IAssetReadable, IAssetWritable, IYamlExportable, IDependent, ITypeTreeSerializable, IComponent, IEditorExtension, IEditorExtensionMarker, IObject, IObjectMarker, IHasHideFlags, IComponentMarker
	{

		// Token: 0x170154CE RID: 87246
		// (get) Token: 0x0603F62B RID: 259627 RVA: 0x00843252 File Offset: 0x00841452
		// (set) Token: 0x0603F62C RID: 259628 RVA: 0x0084325A File Offset: 0x0084145A
		public bool AutoRandomSeed_C198
		{
			get
			{
				return this.m_AutoRandomSeed;
			}
			set
			{
				this.m_AutoRandomSeed = value;
			}
		}

		// Token: 0x170154CF RID: 87247
		// (get) Token: 0x0603F62D RID: 259629 RVA: 0x00843263 File Offset: 0x00841463
		public IClampVelocityModule ClampVelocityModule_C198
		{
			get
			{
				return this.m_ClampVelocityModule;
			}
		}

		// Token: 0x170154D0 RID: 87248
		// (get) Token: 0x0603F62E RID: 259630 RVA: 0x0084326B File Offset: 0x0084146B
		public ICollisionModule CollisionModule_C198
		{
			get
			{
				return this.m_CollisionModule;
			}
		}

		// Token: 0x170154D1 RID: 87249
		// (get) Token: 0x0603F62F RID: 259631 RVA: 0x00843273 File Offset: 0x00841473
		public IColorBySpeedModule ColorBySpeedModule_C198
		{
			get
			{
				return this.m_ColorBySpeedModule;
			}
		}

		// Token: 0x170154D2 RID: 87250
		// (get) Token: 0x0603F630 RID: 259632 RVA: 0x0084327B File Offset: 0x0084147B
		public IColorModule ColorModule_C198
		{
			get
			{
				return this.m_ColorModule;
			}
		}

		// Token: 0x170154D3 RID: 87251
		// (get) Token: 0x0603F631 RID: 259633 RVA: 0x00843283 File Offset: 0x00841483
		public IPPtr_EditorExtension CorrespondingSourceObject_C198
		{
			get
			{
				return this.m_CorrespondingSourceObject;
			}
		}

		// Token: 0x170154D4 RID: 87252
		// (get) Token: 0x0603F632 RID: 259634 RVA: 0x0084328B File Offset: 0x0084148B
		// (set) Token: 0x0603F633 RID: 259635 RVA: 0x0084328E File Offset: 0x0084148E
		public int CullingMode_C198
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x170154D5 RID: 87253
		// (get) Token: 0x0603F634 RID: 259636 RVA: 0x00843290 File Offset: 0x00841490

		public ICustomDataModule CustomDataModule_C198
		{

			[return: NotNull]
			get
			{
				return this.m_CustomDataModule;
			}
		}

		// Token: 0x170154D6 RID: 87254
		// (get) Token: 0x0603F635 RID: 259637 RVA: 0x00843298 File Offset: 0x00841498
		public IEmissionModule EmissionModule_C198
		{
			get
			{
				return this.m_EmissionModule;
			}
		}

		// Token: 0x170154D7 RID: 87255
		// (get) Token: 0x0603F636 RID: 259638 RVA: 0x008432A0 File Offset: 0x008414A0
		// (set) Token: 0x0603F637 RID: 259639 RVA: 0x008432A3 File Offset: 0x008414A3
		public int EmitterVelocityMode_C198
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x170154D8 RID: 87256
		// (get) Token: 0x0603F638 RID: 259640 RVA: 0x008432A5 File Offset: 0x008414A5

		public IExternalForcesModule ExternalForcesModule_C198
		{

			[return: NotNull]
			get
			{
				return this.m_ExternalForcesModule;
			}
		}

		// Token: 0x170154D9 RID: 87257
		// (get) Token: 0x0603F639 RID: 259641 RVA: 0x008432AD File Offset: 0x008414AD
		public IForceModule ForceModule_C198
		{
			get
			{
				return this.m_ForceModule;
			}
		}

		// Token: 0x170154DA RID: 87258
		// (get) Token: 0x0603F63A RID: 259642 RVA: 0x008432B5 File Offset: 0x008414B5
		public IPPtr_GameObject GameObject_C198
		{
			get
			{
				return this.m_GameObject;
			}
		}

		// Token: 0x170154DB RID: 87259
		// (get) Token: 0x0603F63B RID: 259643 RVA: 0x008432BD File Offset: 0x008414BD
		// (set) Token: 0x0603F63C RID: 259644 RVA: 0x008432C5 File Offset: 0x008414C5
		public uint HideFlags_C198
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

		// Token: 0x170154DC RID: 87260
		// (get) Token: 0x0603F63D RID: 259645 RVA: 0x008432CE File Offset: 0x008414CE

		public IInheritVelocityModule InheritVelocityModule_C198
		{

			[return: NotNull]
			get
			{
				return this.m_InheritVelocityModule;
			}
		}

		// Token: 0x170154DD RID: 87261
		// (get) Token: 0x0603F63E RID: 259646 RVA: 0x008432D6 File Offset: 0x008414D6
		public IInitialModule InitialModule_C198
		{
			get
			{
				return this.m_InitialModule;
			}
		}

		// Token: 0x170154DE RID: 87262
		// (get) Token: 0x0603F63F RID: 259647 RVA: 0x008432DE File Offset: 0x008414DE
		// (set) Token: 0x0603F640 RID: 259648 RVA: 0x008432E6 File Offset: 0x008414E6
		public float LengthInSec_C198
		{
			get
			{
				return this.m_LengthInSec;
			}
			set
			{
				this.m_LengthInSec = value;
			}
		}

		// Token: 0x170154DF RID: 87263
		// (get) Token: 0x0603F641 RID: 259649 RVA: 0x008432EF File Offset: 0x008414EF

		public LifetimeByEmitterSpeedModule LifetimeByEmitterSpeedModule_C198
		{

			get
			{
				return null;
			}
		}

		// Token: 0x170154E0 RID: 87264
		// (get) Token: 0x0603F642 RID: 259650 RVA: 0x008432F2 File Offset: 0x008414F2

		public ILightsModule LightsModule_C198
		{

			[return: NotNull]
			get
			{
				return this.m_LightsModule;
			}
		}

		// Token: 0x170154E1 RID: 87265
		// (get) Token: 0x0603F643 RID: 259651 RVA: 0x008432FA File Offset: 0x008414FA
		// (set) Token: 0x0603F644 RID: 259652 RVA: 0x00843302 File Offset: 0x00841502
		public bool Looping_C198
		{
			get
			{
				return this.m_Looping;
			}
			set
			{
				this.m_Looping = value;
			}
		}

		// Token: 0x170154E2 RID: 87266
		// (get) Token: 0x0603F645 RID: 259653 RVA: 0x0084330B File Offset: 0x0084150B

		public PPtr_Transform_5_0_0 MoveWithCustomTransform_C198
		{

			[return: NotNull]
			get
			{
				return this.m_MoveWithCustomTransform;
			}
		}

		// Token: 0x170154E3 RID: 87267
		// (get) Token: 0x0603F646 RID: 259654 RVA: 0x00843313 File Offset: 0x00841513
		// (set) Token: 0x0603F647 RID: 259655 RVA: 0x00843316 File Offset: 0x00841516
		public bool MoveWithTransform_C198_Boolean
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x170154E4 RID: 87268
		// (get) Token: 0x0603F648 RID: 259656 RVA: 0x00843318 File Offset: 0x00841518
		// (set) Token: 0x0603F649 RID: 259657 RVA: 0x00843320 File Offset: 0x00841520
		public int MoveWithTransform_C198_Int32
		{
			get
			{
				return this.m_MoveWithTransform;
			}
			set
			{
				this.m_MoveWithTransform = value;
			}
		}

		// Token: 0x170154E5 RID: 87269
		// (get) Token: 0x0603F64A RID: 259658 RVA: 0x00843329 File Offset: 0x00841529

		public INoiseModule NoiseModule_C198
		{

			[return: NotNull]
			get
			{
				return this.m_NoiseModule;
			}
		}

		// Token: 0x170154E6 RID: 87270
		// (get) Token: 0x0603F64B RID: 259659 RVA: 0x00843331 File Offset: 0x00841531
		// (set) Token: 0x0603F64C RID: 259660 RVA: 0x00843339 File Offset: 0x00841539
		public bool PlayOnAwake_C198
		{
			get
			{
				return this.m_PlayOnAwake;
			}
			set
			{
				this.m_PlayOnAwake = value;
			}
		}

		// Token: 0x170154E7 RID: 87271
		// (get) Token: 0x0603F64D RID: 259661 RVA: 0x00843342 File Offset: 0x00841542

		public PPtr_Prefab_2018_3_0 PrefabAsset_C198
		{

			get
			{
				return null;
			}
		}

		// Token: 0x170154E8 RID: 87272
		// (get) Token: 0x0603F64E RID: 259662 RVA: 0x00843345 File Offset: 0x00841545

		public PPtr_PrefabInstance PrefabInstance_C198
		{

			get
			{
				return null;
			}
		}

		// Token: 0x170154E9 RID: 87273
		// (get) Token: 0x0603F64F RID: 259663 RVA: 0x00843348 File Offset: 0x00841548

		public IPPtr_Prefab PrefabInternal_C198
		{

			[return: NotNull]
			get
			{
				return this.m_PrefabInternal;
			}
		}

		// Token: 0x170154EA RID: 87274
		// (get) Token: 0x0603F650 RID: 259664 RVA: 0x00843350 File Offset: 0x00841550
		// (set) Token: 0x0603F651 RID: 259665 RVA: 0x00843358 File Offset: 0x00841558
		public bool Prewarm_C198
		{
			get
			{
				return this.m_Prewarm;
			}
			set
			{
				this.m_Prewarm = value;
			}
		}

		// Token: 0x170154EB RID: 87275
		// (get) Token: 0x0603F652 RID: 259666 RVA: 0x00843361 File Offset: 0x00841561
		// (set) Token: 0x0603F653 RID: 259667 RVA: 0x00843364 File Offset: 0x00841564
		public uint RandomSeed_C198_UInt32
		{
			get
			{
				return 0U;
			}
			set
			{
			}
		}

		// Token: 0x170154EC RID: 87276
		// (get) Token: 0x0603F654 RID: 259668 RVA: 0x00843366 File Offset: 0x00841566
		// (set) Token: 0x0603F655 RID: 259669 RVA: 0x0084336E File Offset: 0x0084156E
		public int RandomSeed_C198_Int32
		{
			get
			{
				return this.m_RandomSeed;
			}
			set
			{
				this.m_RandomSeed = value;
			}
		}

		// Token: 0x170154ED RID: 87277
		// (get) Token: 0x0603F656 RID: 259670 RVA: 0x00843377 File Offset: 0x00841577

		public Vector2f_3_5_0 RingBufferLoopRange_C198
		{

			get
			{
				return null;
			}
		}

		// Token: 0x170154EE RID: 87278
		// (get) Token: 0x0603F657 RID: 259671 RVA: 0x0084337A File Offset: 0x0084157A
		// (set) Token: 0x0603F658 RID: 259672 RVA: 0x0084337D File Offset: 0x0084157D
		public int RingBufferMode_C198
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x170154EF RID: 87279
		// (get) Token: 0x0603F659 RID: 259673 RVA: 0x0084337F File Offset: 0x0084157F
		public IRotationBySpeedModule RotationBySpeedModule_C198
		{
			get
			{
				return this.m_RotationBySpeedModule;
			}
		}

		// Token: 0x170154F0 RID: 87280
		// (get) Token: 0x0603F65A RID: 259674 RVA: 0x00843387 File Offset: 0x00841587
		public IRotationModule RotationModule_C198
		{
			get
			{
				return this.m_RotationModule;
			}
		}

		// Token: 0x170154F1 RID: 87281
		// (get) Token: 0x0603F65B RID: 259675 RVA: 0x0084338F File Offset: 0x0084158F
		// (set) Token: 0x0603F65C RID: 259676 RVA: 0x00843397 File Offset: 0x00841597
		public int ScalingMode_C198
		{
			get
			{
				return this.m_ScalingMode;
			}
			set
			{
				this.m_ScalingMode = value;
			}
		}

		// Token: 0x170154F2 RID: 87282
		// (get) Token: 0x0603F65D RID: 259677 RVA: 0x008433A0 File Offset: 0x008415A0
		public IShapeModule ShapeModule_C198
		{
			get
			{
				return this.m_ShapeModule;
			}
		}

		// Token: 0x170154F3 RID: 87283
		// (get) Token: 0x0603F65E RID: 259678 RVA: 0x008433A8 File Offset: 0x008415A8
		// (set) Token: 0x0603F65F RID: 259679 RVA: 0x008433B0 File Offset: 0x008415B0
		public float SimulationSpeed_C198
		{
			get
			{
				return this.m_SimulationSpeed;
			}
			set
			{
				this.m_SimulationSpeed = value;
			}
		}

		// Token: 0x170154F4 RID: 87284
		// (get) Token: 0x0603F660 RID: 259680 RVA: 0x008433B9 File Offset: 0x008415B9
		public ISizeBySpeedModule SizeBySpeedModule_C198
		{
			get
			{
				return this.m_SizeBySpeedModule;
			}
		}

		// Token: 0x170154F5 RID: 87285
		// (get) Token: 0x0603F661 RID: 259681 RVA: 0x008433C1 File Offset: 0x008415C1
		public ISizeModule SizeModule_C198
		{
			get
			{
				return this.m_SizeModule;
			}
		}

		// Token: 0x170154F6 RID: 87286
		// (get) Token: 0x0603F662 RID: 259682 RVA: 0x008433C9 File Offset: 0x008415C9
		// (set) Token: 0x0603F663 RID: 259683 RVA: 0x008433D0 File Offset: 0x008415D0
		public float Speed_C198
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x170154F7 RID: 87287
		// (get) Token: 0x0603F664 RID: 259684 RVA: 0x008433D2 File Offset: 0x008415D2
		// (set) Token: 0x0603F665 RID: 259685 RVA: 0x008433D9 File Offset: 0x008415D9
		public float StartDelay_float_C198
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x170154F8 RID: 87288
		// (get) Token: 0x0603F666 RID: 259686 RVA: 0x008433DB File Offset: 0x008415DB

		public IMinMaxCurve StartDelay_MinMaxCurve_C198
		{

			[return: NotNull]
			get
			{
				return this.m_StartDelay_MinMaxCurve;
			}
		}

		// Token: 0x170154F9 RID: 87289
		// (get) Token: 0x0603F667 RID: 259687 RVA: 0x008433E3 File Offset: 0x008415E3
		// (set) Token: 0x0603F668 RID: 259688 RVA: 0x008433E6 File Offset: 0x008415E6
		public int StopAction_C198
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x170154FA RID: 87290
		// (get) Token: 0x0603F669 RID: 259689 RVA: 0x008433E8 File Offset: 0x008415E8
		public ISubModule SubModule_C198
		{
			get
			{
				return this.m_SubModule;
			}
		}

		// Token: 0x170154FB RID: 87291
		// (get) Token: 0x0603F66A RID: 259690 RVA: 0x008433F0 File Offset: 0x008415F0

		public ITrailModule TrailModule_C198
		{

			[return: NotNull]
			get
			{
				return this.m_TrailModule;
			}
		}

		// Token: 0x170154FC RID: 87292
		// (get) Token: 0x0603F66B RID: 259691 RVA: 0x008433F8 File Offset: 0x008415F8

		public ITriggerModule TriggerModule_C198
		{

			[return: NotNull]
			get
			{
				return this.m_TriggerModule;
			}
		}

		// Token: 0x170154FD RID: 87293
		// (get) Token: 0x0603F66C RID: 259692 RVA: 0x00843400 File Offset: 0x00841600
		// (set) Token: 0x0603F66D RID: 259693 RVA: 0x00843408 File Offset: 0x00841608
		public bool UseRigidbodyForVelocity_C198
		{
			get
			{
				return this.m_UseRigidbodyForVelocity;
			}
			set
			{
				this.m_UseRigidbodyForVelocity = value;
			}
		}

		// Token: 0x170154FE RID: 87294
		// (get) Token: 0x0603F66E RID: 259694 RVA: 0x00843411 File Offset: 0x00841611
		// (set) Token: 0x0603F66F RID: 259695 RVA: 0x00843419 File Offset: 0x00841619
		public bool UseUnscaledTime_C198
		{
			get
			{
				return this.m_UseUnscaledTime;
			}
			set
			{
				this.m_UseUnscaledTime = value;
			}
		}

		// Token: 0x170154FF RID: 87295
		// (get) Token: 0x0603F670 RID: 259696 RVA: 0x00843422 File Offset: 0x00841622
		public IUVModule UVModule_C198
		{
			get
			{
				return this.m_UVModule;
			}
		}

		// Token: 0x17015500 RID: 87296
		// (get) Token: 0x0603F671 RID: 259697 RVA: 0x0084342A File Offset: 0x0084162A
		public IVelocityModule VelocityModule_C198
		{
			get
			{
				return this.m_VelocityModule;
			}
		}

		// Token: 0x17015501 RID: 87297
		// (get) Token: 0x0603F672 RID: 259698 RVA: 0x00843432 File Offset: 0x00841632
		// (set) Token: 0x0603F673 RID: 259699 RVA: 0x0084343A File Offset: 0x0084163A
		public HideFlags HideFlags_C198E
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

		// Token: 0x17015502 RID: 87298
		// (get) Token: 0x0603F674 RID: 259700 RVA: 0x00843443 File Offset: 0x00841643
		// (set) Token: 0x0603F675 RID: 259701 RVA: 0x0084344B File Offset: 0x0084164B
		public ParticleSystemScalingMode ScalingMode_C198E
		{
			get
			{
				return (ParticleSystemScalingMode)this.m_ScalingMode;
			}
			set
			{
				this.m_ScalingMode = (int)value;
			}
		}

		// Token: 0x17015503 RID: 87299
		// (get) Token: 0x0603F676 RID: 259702 RVA: 0x00843454 File Offset: 0x00841654
		// (set) Token: 0x0603F677 RID: 259703 RVA: 0x00843467 File Offset: 0x00841667

		public IEditorExtension CorrespondingSourceObject_C198P
		{

			get
			{
				return PPtrExtensions.TryGetAsset<IEditorExtension>(this.CorrespondingSourceObject_C198, base.Collection);
			}

			set
			{
				PPtrExtensions.SetAsset<IEditorExtension>(this.CorrespondingSourceObject_C198, base.Collection, value);
			}
		}

		// Token: 0x17015504 RID: 87300
		// (get) Token: 0x0603F678 RID: 259704 RVA: 0x0084347B File Offset: 0x0084167B
		// (set) Token: 0x0603F679 RID: 259705 RVA: 0x0084348E File Offset: 0x0084168E

		public IGameObject GameObject_C198P
		{

			get
			{
				return PPtrExtensions.TryGetAsset<IGameObject>(this.GameObject_C198, base.Collection);
			}

			set
			{
				PPtrExtensions.SetAsset<IGameObject>(this.GameObject_C198, base.Collection, value);
			}
		}

		// Token: 0x17015505 RID: 87301
		// (get) Token: 0x0603F67A RID: 259706 RVA: 0x008434A2 File Offset: 0x008416A2
		// (set) Token: 0x0603F67B RID: 259707 RVA: 0x008434B5 File Offset: 0x008416B5

		public ITransform MoveWithCustomTransform_C198P
		{

			get
			{
				return PPtrExtensions.TryGetAsset<ITransform>(this.MoveWithCustomTransform_C198, base.Collection);
			}

			set
			{
				PPtrExtensions.SetAsset<ITransform>(this.MoveWithCustomTransform_C198, base.Collection, value);
			}
		}

		// Token: 0x17015506 RID: 87302
		// (get) Token: 0x0603F67C RID: 259708 RVA: 0x008434C9 File Offset: 0x008416C9
		// (set) Token: 0x0603F67D RID: 259709 RVA: 0x008434CC File Offset: 0x008416CC

		public IPrefab PrefabAsset_C198P
		{

			get
			{
				return null;
			}

			set
			{
			}
		}

		// Token: 0x17015507 RID: 87303
		// (get) Token: 0x0603F67E RID: 259710 RVA: 0x008434CE File Offset: 0x008416CE
		// (set) Token: 0x0603F67F RID: 259711 RVA: 0x008434D1 File Offset: 0x008416D1

		public IPrefabInstance PrefabInstance_C198P
		{

			get
			{
				return null;
			}

			set
			{
			}
		}

		// Token: 0x17015508 RID: 87304
		// (get) Token: 0x0603F680 RID: 259712 RVA: 0x008434D3 File Offset: 0x008416D3
		// (set) Token: 0x0603F681 RID: 259713 RVA: 0x008434E6 File Offset: 0x008416E6

		public IPrefabMarker PrefabInternal_C198P
		{

			get
			{
				return PPtrExtensions.TryGetAsset<IPrefabMarker>(this.PrefabInternal_C198, base.Collection);
			}

			set
			{
				PPtrExtensions.SetAsset<IPrefabMarker>(this.PrefabInternal_C198, base.Collection, value);
			}
		}

		// Token: 0x17015509 RID: 87305
		// (get) Token: 0x0603F682 RID: 259714 RVA: 0x008434FA File Offset: 0x008416FA
		public override string ClassName
		{
			get
			{
				return "ParticleSystem";
			}
		}

		// Token: 0x0603F683 RID: 259715 RVA: 0x00843501 File Offset: 0x00841701
		public ParticleSystem_2017_1_0_b10_GICB2()
			: this(AssetInfo.MakeDummyAssetInfo(198))
		{
		}

		// Token: 0x0603F684 RID: 259716 RVA: 0x00843514 File Offset: 0x00841714
		public ParticleSystem_2017_1_0_b10_GICB2(AssetInfo info)
			: base(info)
		{
			this.m_StartDelay_MinMaxCurve = new MinMaxCurve_2017_1_0_b3();
			this.m_MoveWithCustomTransform = new PPtr_Transform_5_0_0();
			this.m_InitialModule = new InitialModule_2017_1_0_b3();
			this.m_ShapeModule = new ShapeModule_2017_1_0_b3_GICB2();
			this.m_EmissionModule = new EmissionModule_2017_1_0_b3_GICB2();
			this.m_SizeModule = new SizeModule_2017_1_0_b3();
			this.m_RotationModule = new RotationModule_2017_1_0_b3();
			this.m_ColorModule = new ColorModule_2017_1_0_b3();
			this.m_UVModule = new UVModule_2017_1_0_b3();
			this.m_VelocityModule = new VelocityModule_2017_1_0_b3();
			this.m_InheritVelocityModule = new InheritVelocityModule_2017_1_0_b3();
			this.m_ForceModule = new ForceModule_2017_1_0_b3();
			this.m_ExternalForcesModule = new ExternalForcesModule_4_0_0();
			this.m_ClampVelocityModule = new ClampVelocityModule_2017_1_0_b3();
			this.m_NoiseModule = new NoiseModule_2017_1_0_b3();
			this.m_SizeBySpeedModule = new SizeBySpeedModule_2017_1_0_b3();
			this.m_RotationBySpeedModule = new RotationBySpeedModule_2017_1_0_b3();
			this.m_ColorBySpeedModule = new ColorBySpeedModule_2017_1_0_b3();
			this.m_CollisionModule = new CollisionModule_2017_1_0_b3();
			this.m_TriggerModule = new TriggerModule_5_4_0();
			this.m_SubModule = new SubModule_2017_1_0();
			this.m_LightsModule = new LightsModule_2017_1_0_b3();
			this.m_TrailModule = new TrailModule_2017_1_0_b3();
			this.m_CustomDataModule = new CustomDataModule_2017_1_0_b3();
		}

		// Token: 0x0603F685 RID: 259717 RVA: 0x00843630 File Offset: 0x00841830
		public bool Has_AutoRandomSeed_C198()
		{
			return true;
		}

		// Token: 0x0603F686 RID: 259718 RVA: 0x00843633 File Offset: 0x00841833
		public bool Has_CullingMode_C198()
		{
			return false;
		}

		// Token: 0x0603F687 RID: 259719 RVA: 0x00843636 File Offset: 0x00841836
		public bool Has_CustomDataModule_C198()
		{
			return true;
		}

		// Token: 0x0603F688 RID: 259720 RVA: 0x00843639 File Offset: 0x00841839
		public bool Has_EmitterVelocityMode_C198()
		{
			return false;
		}

		// Token: 0x0603F689 RID: 259721 RVA: 0x0084363C File Offset: 0x0084183C
		public bool Has_ExternalForcesModule_C198()
		{
			return true;
		}

		// Token: 0x0603F68A RID: 259722 RVA: 0x0084363F File Offset: 0x0084183F
		public bool Has_InheritVelocityModule_C198()
		{
			return true;
		}

		// Token: 0x0603F68B RID: 259723 RVA: 0x00843642 File Offset: 0x00841842
		public bool Has_LifetimeByEmitterSpeedModule_C198()
		{
			return false;
		}

		// Token: 0x0603F68C RID: 259724 RVA: 0x00843645 File Offset: 0x00841845
		public bool Has_LightsModule_C198()
		{
			return true;
		}

		// Token: 0x0603F68D RID: 259725 RVA: 0x00843648 File Offset: 0x00841848
		public bool Has_MoveWithCustomTransform_C198()
		{
			return true;
		}

		// Token: 0x0603F68E RID: 259726 RVA: 0x0084364B File Offset: 0x0084184B
		public bool Has_MoveWithTransform_C198_Boolean()
		{
			return false;
		}

		// Token: 0x0603F68F RID: 259727 RVA: 0x0084364E File Offset: 0x0084184E
		public bool Has_MoveWithTransform_C198_Int32()
		{
			return true;
		}

		// Token: 0x0603F690 RID: 259728 RVA: 0x00843651 File Offset: 0x00841851
		public bool Has_NoiseModule_C198()
		{
			return true;
		}

		// Token: 0x0603F691 RID: 259729 RVA: 0x00843654 File Offset: 0x00841854
		public bool Has_PrefabAsset_C198()
		{
			return false;
		}

		// Token: 0x0603F692 RID: 259730 RVA: 0x00843657 File Offset: 0x00841857
		public bool Has_PrefabInstance_C198()
		{
			return false;
		}

		// Token: 0x0603F693 RID: 259731 RVA: 0x0084365A File Offset: 0x0084185A
		public bool Has_PrefabInternal_C198()
		{
			return true;
		}

		// Token: 0x0603F694 RID: 259732 RVA: 0x0084365D File Offset: 0x0084185D
		public bool Has_RandomSeed_C198_UInt32()
		{
			return false;
		}

		// Token: 0x0603F695 RID: 259733 RVA: 0x00843660 File Offset: 0x00841860
		public bool Has_RandomSeed_C198_Int32()
		{
			return true;
		}

		// Token: 0x0603F696 RID: 259734 RVA: 0x00843663 File Offset: 0x00841863
		public bool Has_RingBufferLoopRange_C198()
		{
			return false;
		}

		// Token: 0x0603F697 RID: 259735 RVA: 0x00843666 File Offset: 0x00841866
		public bool Has_RingBufferMode_C198()
		{
			return false;
		}

		// Token: 0x0603F698 RID: 259736 RVA: 0x00843669 File Offset: 0x00841869
		public bool Has_ScalingMode_C198()
		{
			return true;
		}

		// Token: 0x0603F699 RID: 259737 RVA: 0x0084366C File Offset: 0x0084186C
		public bool Has_SimulationSpeed_C198()
		{
			return true;
		}

		// Token: 0x0603F69A RID: 259738 RVA: 0x0084366F File Offset: 0x0084186F
		public bool Has_Speed_C198()
		{
			return false;
		}

		// Token: 0x0603F69B RID: 259739 RVA: 0x00843672 File Offset: 0x00841872
		public bool Has_StartDelay_float_C198()
		{
			return false;
		}

		// Token: 0x0603F69C RID: 259740 RVA: 0x00843675 File Offset: 0x00841875
		public bool Has_StartDelay_MinMaxCurve_C198()
		{
			return true;
		}

		// Token: 0x0603F69D RID: 259741 RVA: 0x00843678 File Offset: 0x00841878
		public bool Has_StopAction_C198()
		{
			return false;
		}

		// Token: 0x0603F69E RID: 259742 RVA: 0x0084367B File Offset: 0x0084187B
		public bool Has_TrailModule_C198()
		{
			return true;
		}

		// Token: 0x0603F69F RID: 259743 RVA: 0x0084367E File Offset: 0x0084187E
		public bool Has_TriggerModule_C198()
		{
			return true;
		}

		// Token: 0x0603F6A0 RID: 259744 RVA: 0x00843681 File Offset: 0x00841881
		public bool Has_UseRigidbodyForVelocity_C198()
		{
			return true;
		}

		// Token: 0x0603F6A1 RID: 259745 RVA: 0x00843684 File Offset: 0x00841884
		public bool Has_UseUnscaledTime_C198()
		{
			return true;
		}

		// Token: 0x0603F6A2 RID: 259746 RVA: 0x00843688 File Offset: 0x00841888
		public override void ReadRelease(AssetReader reader)
		{
			this.m_GameObject.ReadRelease(reader);
			this.m_LengthInSec = reader.ReadSingle();
			this.m_SimulationSpeed = reader.ReadSingle();
			this.m_Looping = reader.ReadBoolean();
			this.m_Prewarm = reader.ReadBoolean();
			this.m_PlayOnAwake = reader.ReadBoolean();
			this.m_UseUnscaledTime = reader.ReadBoolean();
			this.m_AutoRandomSeed = reader.ReadBoolean();
			this.m_UseRigidbodyForVelocity = reader.ReadRelease_BooleanAlign();
			// GICB2
			bool useDistanceLOD = reader.ReadBoolean();
			reader.AlignStream();
			bool useCullingUpdate = reader.ReadBoolean();
			reader.AlignStream();

			this.m_StartDelay_MinMaxCurve.ReadRelease_AssetAlign(reader);
			this.m_MoveWithTransform = reader.ReadRelease_Int32Align();
			this.m_MoveWithCustomTransform.ReadRelease(reader);
			this.m_ScalingMode = reader.ReadInt32();
			this.m_RandomSeed = reader.ReadInt32();
			this.m_InitialModule.ReadRelease(reader);
			this.m_ShapeModule.ReadRelease(reader);
			this.m_EmissionModule.ReadRelease(reader);
			this.m_SizeModule.ReadRelease(reader);
			this.m_RotationModule.ReadRelease(reader);
			this.m_ColorModule.ReadRelease(reader);
			this.m_UVModule.ReadRelease(reader);
			this.m_VelocityModule.ReadRelease(reader);
			this.m_InheritVelocityModule.ReadRelease(reader);
			this.m_ForceModule.ReadRelease(reader);
			this.m_ExternalForcesModule.ReadRelease(reader);
			this.m_ClampVelocityModule.ReadRelease(reader);
			this.m_NoiseModule.ReadRelease(reader);
			this.m_SizeBySpeedModule.ReadRelease(reader);
			this.m_RotationBySpeedModule.ReadRelease(reader);
			this.m_ColorBySpeedModule.ReadRelease(reader);
			this.m_CollisionModule.ReadRelease(reader);
			this.m_TriggerModule.ReadRelease(reader);
			this.m_SubModule.ReadRelease(reader);
			this.m_LightsModule.ReadRelease(reader);
			this.m_TrailModule.ReadRelease(reader);
			this.m_CustomDataModule.ReadRelease(reader);

			// GICB2
			TextModule.Read(reader);
			ColorOverDayModule.Read(reader);
		}

		// Token: 0x0603F6A3 RID: 259747 RVA: 0x00843848 File Offset: 0x00841A48
		public override void ReadEditor(AssetReader reader)
		{
		}

		// Token: 0x0603F6A4 RID: 259748 RVA: 0x00843A2C File Offset: 0x00841C2C
		public override void WriteRelease(AssetWriter writer)
		{
			this.m_GameObject.WriteRelease(writer);
			this.m_LengthInSec.WriteRelease_Single(writer);
			this.m_SimulationSpeed.WriteRelease_Single(writer);
			this.m_Looping.WriteRelease_Boolean(writer);
			this.m_Prewarm.WriteRelease_Boolean(writer);
			this.m_PlayOnAwake.WriteRelease_Boolean(writer);
			this.m_UseUnscaledTime.WriteRelease_Boolean(writer);
			this.m_AutoRandomSeed.WriteRelease_Boolean(writer);
			this.m_UseRigidbodyForVelocity.WriteRelease_BooleanAlign(writer);
			this.m_StartDelay_MinMaxCurve.WriteRelease_AssetAlign(writer);
			this.m_MoveWithTransform.WriteRelease_Int32Align(writer);
			this.m_MoveWithCustomTransform.WriteRelease(writer);
			this.m_ScalingMode.WriteRelease_Int32(writer);
			this.m_RandomSeed.WriteRelease_Int32(writer);
			this.m_InitialModule.WriteRelease(writer);
			this.m_ShapeModule.WriteRelease(writer);
			this.m_EmissionModule.WriteRelease(writer);
			this.m_SizeModule.WriteRelease(writer);
			this.m_RotationModule.WriteRelease(writer);
			this.m_ColorModule.WriteRelease(writer);
			this.m_UVModule.WriteRelease(writer);
			this.m_VelocityModule.WriteRelease(writer);
			this.m_InheritVelocityModule.WriteRelease(writer);
			this.m_ForceModule.WriteRelease(writer);
			this.m_ExternalForcesModule.WriteRelease(writer);
			this.m_ClampVelocityModule.WriteRelease(writer);
			this.m_NoiseModule.WriteRelease(writer);
			this.m_SizeBySpeedModule.WriteRelease(writer);
			this.m_RotationBySpeedModule.WriteRelease(writer);
			this.m_ColorBySpeedModule.WriteRelease(writer);
			this.m_CollisionModule.WriteRelease(writer);
			this.m_TriggerModule.WriteRelease(writer);
			this.m_SubModule.WriteRelease(writer);
			this.m_LightsModule.WriteRelease(writer);
			this.m_TrailModule.WriteRelease(writer);
			this.m_CustomDataModule.WriteRelease(writer);
		}

		// Token: 0x0603F6A5 RID: 259749 RVA: 0x00843BEC File Offset: 0x00841DEC
		public override void WriteEditor(AssetWriter writer)
		{
		}

		// Token: 0x0603F6A6 RID: 259750 RVA: 0x00843DD0 File Offset: 0x00841FD0
		public override YamlNode ExportYamlRelease(IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			YamlSerializedVersionExtensions.AddSerializedVersion(yamlMappingNode, 5);
			yamlMappingNode.Add(new YamlScalarNode("m_GameObject"), this.m_GameObject.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("lengthInSec"), this.m_LengthInSec.ExportYamlRelease_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("simulationSpeed"), this.m_SimulationSpeed.ExportYamlRelease_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("looping"), this.m_Looping.ExportYamlRelease_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("prewarm"), this.m_Prewarm.ExportYamlRelease_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("playOnAwake"), this.m_PlayOnAwake.ExportYamlRelease_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("useUnscaledTime"), this.m_UseUnscaledTime.ExportYamlRelease_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("autoRandomSeed"), this.m_AutoRandomSeed.ExportYamlRelease_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("useRigidbodyForVelocity"), this.m_UseRigidbodyForVelocity.ExportYamlRelease_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("startDelay"), this.m_StartDelay_MinMaxCurve.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("moveWithTransform"), this.m_MoveWithTransform.ExportYamlRelease_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("moveWithCustomTransform"), this.m_MoveWithCustomTransform.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("scalingMode"), this.m_ScalingMode.ExportYamlRelease_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("randomSeed"), this.m_RandomSeed.ExportYamlRelease_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("InitialModule"), this.m_InitialModule.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("ShapeModule"), this.m_ShapeModule.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("EmissionModule"), this.m_EmissionModule.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("SizeModule"), this.m_SizeModule.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("RotationModule"), this.m_RotationModule.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("ColorModule"), this.m_ColorModule.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("UVModule"), this.m_UVModule.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("VelocityModule"), this.m_VelocityModule.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("InheritVelocityModule"), this.m_InheritVelocityModule.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("ForceModule"), this.m_ForceModule.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("ExternalForcesModule"), this.m_ExternalForcesModule.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("ClampVelocityModule"), this.m_ClampVelocityModule.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("NoiseModule"), this.m_NoiseModule.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("SizeBySpeedModule"), this.m_SizeBySpeedModule.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("RotationBySpeedModule"), this.m_RotationBySpeedModule.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("ColorBySpeedModule"), this.m_ColorBySpeedModule.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("CollisionModule"), this.m_CollisionModule.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("TriggerModule"), this.m_TriggerModule.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("SubModule"), this.m_SubModule.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("LightsModule"), this.m_LightsModule.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("TrailModule"), this.m_TrailModule.ExportYamlRelease(container));
			yamlMappingNode.Add(new YamlScalarNode("CustomDataModule"), this.m_CustomDataModule.ExportYamlRelease(container));
			return yamlMappingNode;
		}

		// Token: 0x0603F6A7 RID: 259751 RVA: 0x008441DC File Offset: 0x008423DC
		public override YamlNode ExportYamlEditor(IExportContainer container)
		{
			YamlMappingNode yamlMappingNode = new YamlMappingNode();
			YamlSerializedVersionExtensions.AddSerializedVersion(yamlMappingNode, 5);
			yamlMappingNode.Add(new YamlScalarNode("m_ObjectHideFlags"), this.m_HideFlags.ExportYamlEditor_UInt32(container));
			yamlMappingNode.Add(new YamlScalarNode("m_PrefabParentObject"), this.m_CorrespondingSourceObject.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_PrefabInternal"), this.m_PrefabInternal.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("m_GameObject"), this.m_GameObject.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("lengthInSec"), this.m_LengthInSec.ExportYamlEditor_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("simulationSpeed"), this.m_SimulationSpeed.ExportYamlEditor_Single(container));
			yamlMappingNode.Add(new YamlScalarNode("looping"), this.m_Looping.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("prewarm"), this.m_Prewarm.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("playOnAwake"), this.m_PlayOnAwake.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("useUnscaledTime"), this.m_UseUnscaledTime.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("autoRandomSeed"), this.m_AutoRandomSeed.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("useRigidbodyForVelocity"), this.m_UseRigidbodyForVelocity.ExportYamlEditor_Boolean(container));
			yamlMappingNode.Add(new YamlScalarNode("startDelay"), this.m_StartDelay_MinMaxCurve.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("moveWithTransform"), this.m_MoveWithTransform.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("moveWithCustomTransform"), this.m_MoveWithCustomTransform.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("scalingMode"), this.m_ScalingMode.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("randomSeed"), this.m_RandomSeed.ExportYamlEditor_Int32(container));
			yamlMappingNode.Add(new YamlScalarNode("InitialModule"), this.m_InitialModule.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("ShapeModule"), this.m_ShapeModule.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("EmissionModule"), this.m_EmissionModule.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("SizeModule"), this.m_SizeModule.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("RotationModule"), this.m_RotationModule.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("ColorModule"), this.m_ColorModule.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("UVModule"), this.m_UVModule.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("VelocityModule"), this.m_VelocityModule.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("InheritVelocityModule"), this.m_InheritVelocityModule.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("ForceModule"), this.m_ForceModule.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("ExternalForcesModule"), this.m_ExternalForcesModule.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("ClampVelocityModule"), this.m_ClampVelocityModule.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("NoiseModule"), this.m_NoiseModule.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("SizeBySpeedModule"), this.m_SizeBySpeedModule.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("RotationBySpeedModule"), this.m_RotationBySpeedModule.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("ColorBySpeedModule"), this.m_ColorBySpeedModule.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("CollisionModule"), this.m_CollisionModule.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("TriggerModule"), this.m_TriggerModule.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("SubModule"), this.m_SubModule.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("LightsModule"), this.m_LightsModule.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("TrailModule"), this.m_TrailModule.ExportYamlEditor(container));
			yamlMappingNode.Add(new YamlScalarNode("CustomDataModule"), this.m_CustomDataModule.ExportYamlEditor(container));
			return yamlMappingNode;
		}

		// Token: 0x0603F6A8 RID: 259752 RVA: 0x0084463C File Offset: 0x0084283C
		public override void Reset()
		{
			this.m_AutoRandomSeed = false;
			this.m_ClampVelocityModule.Reset();
			this.m_CollisionModule.Reset();
			this.m_ColorBySpeedModule.Reset();
			this.m_ColorModule.Reset();
			this.m_CorrespondingSourceObject.Reset();
			this.m_CustomDataModule.Reset();
			this.m_EmissionModule.Reset();
			this.m_ExternalForcesModule.Reset();
			this.m_ForceModule.Reset();
			this.m_GameObject.Reset();
			this.m_HideFlags = 0U;
			this.m_InheritVelocityModule.Reset();
			this.m_InitialModule.Reset();
			this.m_LengthInSec = 0f;
			this.m_LightsModule.Reset();
			this.m_Looping = false;
			this.m_MoveWithCustomTransform.Reset();
			this.m_MoveWithTransform = 0;
			this.m_NoiseModule.Reset();
			this.m_PlayOnAwake = false;
			this.m_PrefabInternal.Reset();
			this.m_Prewarm = false;
			this.m_RandomSeed = 0;
			this.m_RotationBySpeedModule.Reset();
			this.m_RotationModule.Reset();
			this.m_ScalingMode = 0;
			this.m_ShapeModule.Reset();
			this.m_SimulationSpeed = 0f;
			this.m_SizeBySpeedModule.Reset();
			this.m_SizeModule.Reset();
			this.m_StartDelay_MinMaxCurve.Reset();
			this.m_SubModule.Reset();
			this.m_TrailModule.Reset();
			this.m_TriggerModule.Reset();
			this.m_UseRigidbodyForVelocity = false;
			this.m_UseUnscaledTime = false;
			this.m_UVModule.Reset();
			this.m_VelocityModule.Reset();
		}

		// Token: 0x0603F6A9 RID: 259753 RVA: 0x008447CE File Offset: 0x008429CE

		//public override IEnumerable<ValueTuple<FieldName, PPtr<IUnityObjectBase>>> FetchDependencies(FieldName parent)
		//{
		//	return Enumerable.Empty<ValueTuple<FieldName, PPtr<IUnityObjectBase>>>().Append_ParticleSystem_2017_1_0_b10(parent, this);
		//}

		// Token: 0x0603F6AA RID: 259754 RVA: 0x008447DC File Offset: 0x008429DC
		public void CopyValues(IParticleSystem source, PPtrConverter converter)
		{
			this.m_AutoRandomSeed = source.AutoRandomSeed_C198;
			this.m_ClampVelocityModule.CopyValues(source.ClampVelocityModule_C198);
			this.m_CollisionModule.CopyValues(source.CollisionModule_C198, converter);
			this.m_ColorBySpeedModule.CopyValues(source.ColorBySpeedModule_C198);
			this.m_ColorModule.CopyValues(source.ColorModule_C198);
			this.m_CorrespondingSourceObject.CopyValues(source.CorrespondingSourceObject_C198, converter);
			this.m_CustomDataModule.CopyValues(source.CustomDataModule_C198);
			this.m_EmissionModule.CopyValues(source.EmissionModule_C198);
			this.m_ExternalForcesModule.CopyValues(source.ExternalForcesModule_C198, converter);
			this.m_ForceModule.CopyValues(source.ForceModule_C198);
			this.m_GameObject.CopyValues(source.GameObject_C198, converter);
			this.m_HideFlags = source.HideFlags_C198;
			this.m_InheritVelocityModule.CopyValues(source.InheritVelocityModule_C198);
			this.m_InitialModule.CopyValues(source.InitialModule_C198);
			this.m_LengthInSec = source.LengthInSec_C198;
			this.m_LightsModule.CopyValues(source.LightsModule_C198, converter);
			this.m_Looping = source.Looping_C198;
			this.m_MoveWithCustomTransform.CopyValues(source.MoveWithCustomTransform_C198, converter);
			this.m_MoveWithTransform = source.MoveWithTransform_C198_Int32;
			this.m_NoiseModule.CopyValues(source.NoiseModule_C198);
			this.m_PlayOnAwake = source.PlayOnAwake_C198;
			this.m_PrefabInternal.CopyValues(source.PrefabInternal_C198, converter);
			this.m_Prewarm = source.Prewarm_C198;
			this.m_RandomSeed = source.RandomSeed_C198_Int32;
			this.m_RotationBySpeedModule.CopyValues(source.RotationBySpeedModule_C198);
			this.m_RotationModule.CopyValues(source.RotationModule_C198);
			this.m_ScalingMode = source.ScalingMode_C198;
			this.m_ShapeModule.CopyValues(source.ShapeModule_C198, converter);
			this.m_SimulationSpeed = source.SimulationSpeed_C198;
			this.m_SizeBySpeedModule.CopyValues(source.SizeBySpeedModule_C198);
			this.m_SizeModule.CopyValues(source.SizeModule_C198);
			this.m_StartDelay_MinMaxCurve.CopyValues(source.StartDelay_MinMaxCurve_C198);
			this.m_SubModule.CopyValues(source.SubModule_C198, converter);
			this.m_TrailModule.CopyValues(source.TrailModule_C198);
			this.m_TriggerModule.CopyValues(source.TriggerModule_C198, converter);
			this.m_UseRigidbodyForVelocity = source.UseRigidbodyForVelocity_C198;
			this.m_UseUnscaledTime = source.UseUnscaledTime_C198;
			this.m_UVModule.CopyValues(source.UVModule_C198, converter);
			this.m_VelocityModule.CopyValues(source.VelocityModule_C198);
		}

		// Token: 0x0603F6AB RID: 259755 RVA: 0x00844A4F File Offset: 0x00842C4F
		public void CopyValues(IParticleSystem source)
		{
			this.CopyValues(source, new PPtrConverter(source, this));
		}

		// Token: 0x0603F6AC RID: 259756 RVA: 0x00844A60 File Offset: 0x00842C60

		public override void CopyValues(IUnityAssetBase source, PPtrConverter converter)
		{
			IParticleSystem particleSystem = source as IParticleSystem;
			if (particleSystem != null)
			{
				this.CopyValues(particleSystem, converter);
				return;
			}
			base.CopyValues(source, converter);
		}

		// Token: 0x0603F6AD RID: 259757 RVA: 0x00844A88 File Offset: 0x00842C88
		public override List<TypeTreeNode> MakeEditorTypeTreeNodes(int depth, int startingIndex)
		{
			throw new NotSupportedException();
		}

		// Token: 0x0603F6AE RID: 259758 RVA: 0x00844A8F File Offset: 0x00842C8F
		public override List<TypeTreeNode> MakeReleaseTypeTreeNodes(int depth, int startingIndex)
		{
			throw new NotSupportedException();
		}

		// Token: 0x040140FB RID: 82171
		public float m_LengthInSec;

		// Token: 0x040140FC RID: 82172
		public float m_SimulationSpeed;

		// Token: 0x040140FD RID: 82173
		public bool m_Looping;

		// Token: 0x040140FE RID: 82174
		public bool m_Prewarm;

		// Token: 0x040140FF RID: 82175
		public bool m_PlayOnAwake;

		// Token: 0x04014100 RID: 82176
		public bool m_UseUnscaledTime;

		// Token: 0x04014101 RID: 82177
		public bool m_AutoRandomSeed;

		// Token: 0x04014102 RID: 82178
		public bool m_UseRigidbodyForVelocity;

		// Token: 0x04014103 RID: 82179
		public MinMaxCurve_2017_1_0_b3 m_StartDelay_MinMaxCurve;

		// Token: 0x04014104 RID: 82180
		public int m_MoveWithTransform;

		// Token: 0x04014105 RID: 82181
		public PPtr_Transform_5_0_0 m_MoveWithCustomTransform;

		// Token: 0x04014106 RID: 82182
		public int m_ScalingMode;

		// Token: 0x04014107 RID: 82183
		public int m_RandomSeed;

		// Token: 0x04014108 RID: 82184
		public InitialModule_2017_1_0_b3 m_InitialModule;

		// Token: 0x04014109 RID: 82185
		public ShapeModule_2017_1_0_b3_GICB2 m_ShapeModule;

		// Token: 0x0401410A RID: 82186
		public EmissionModule_2017_1_0_b3_GICB2 m_EmissionModule;

		// Token: 0x0401410B RID: 82187
		public SizeModule_2017_1_0_b3 m_SizeModule;

		// Token: 0x0401410C RID: 82188
		public RotationModule_2017_1_0_b3 m_RotationModule;

		// Token: 0x0401410D RID: 82189
		public ColorModule_2017_1_0_b3 m_ColorModule;

		// Token: 0x0401410E RID: 82190
		public UVModule_2017_1_0_b3 m_UVModule;

		// Token: 0x0401410F RID: 82191
		public VelocityModule_2017_1_0_b3 m_VelocityModule;

		// Token: 0x04014110 RID: 82192
		public InheritVelocityModule_2017_1_0_b3 m_InheritVelocityModule;

		// Token: 0x04014111 RID: 82193
		public ForceModule_2017_1_0_b3 m_ForceModule;

		// Token: 0x04014112 RID: 82194
		public ExternalForcesModule_4_0_0 m_ExternalForcesModule;

		// Token: 0x04014113 RID: 82195
		public ClampVelocityModule_2017_1_0_b3 m_ClampVelocityModule;

		// Token: 0x04014114 RID: 82196
		public NoiseModule_2017_1_0_b3 m_NoiseModule;

		// Token: 0x04014115 RID: 82197
		public SizeBySpeedModule_2017_1_0_b3 m_SizeBySpeedModule;

		// Token: 0x04014116 RID: 82198
		public RotationBySpeedModule_2017_1_0_b3 m_RotationBySpeedModule;

		// Token: 0x04014117 RID: 82199
		public ColorBySpeedModule_2017_1_0_b3 m_ColorBySpeedModule;

		// Token: 0x04014118 RID: 82200
		public CollisionModule_2017_1_0_b3 m_CollisionModule;

		// Token: 0x04014119 RID: 82201
		public TriggerModule_5_4_0 m_TriggerModule;

		// Token: 0x0401411A RID: 82202
		public SubModule_2017_1_0 m_SubModule;

		// Token: 0x0401411B RID: 82203
		public LightsModule_2017_1_0_b3 m_LightsModule;

		// Token: 0x0401411C RID: 82204
		public TrailModule_2017_1_0_b3 m_TrailModule;

		// Token: 0x0401411D RID: 82205
		public CustomDataModule_2017_1_0_b3 m_CustomDataModule;
		public TextModule TextModule { get; } = new TextModule();
		public ColorOverDayModule ColorOverDayModule { get; } = new ColorOverDayModule();
	}
}
