using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using AssetRipper.Assets;
using AssetRipper.Assets.Export.Dependencies;
using AssetRipper.Assets.Export.Yaml;
using AssetRipper.Assets.Generics;
using AssetRipper.Assets.Interfaces;
using AssetRipper.Assets.IO;
using AssetRipper.Assets.IO.Reading;
using AssetRipper.Assets.IO.Writing;
using AssetRipper.IClasses.OffsetPtr_Clip;
using AssetRipper.SourceGenerated.Subclasses.HumanPose;
using AssetRipper.SourceGenerated.Subclasses.ValueDelta;
using AssetRipper.SourceGenerated.Subclasses.Vector3Float;
using AssetRipper.SourceGenerated.Subclasses.Vector4Float;
using AssetRipper.SourceGenerated.Subclasses.Xform;

namespace AssetRipper.IClasses.MuscleClipConstant
{
	// Token: 0x020007A6 RID: 1958

	public interface IMuscleClipConstant_ACL : IUnityAssetBase, IAsset, IAssetReadable, IAssetWritable, IYamlExportable, IDependent, ITypeTreeSerializable, IEquatable<IMuscleClipConstant_ACL>
	{
		// Token: 0x17003375 RID: 13173
		// (get) Token: 0x0600CCC2 RID: 52418
		// (set) Token: 0x0600CCC3 RID: 52419
		int[] AdditionalCurveIndexArray { get; set; }

		// Token: 0x17003376 RID: 13174
		// (get) Token: 0x0600CCC4 RID: 52420
		// (set) Token: 0x0600CCC5 RID: 52421
		float AverageAngularSpeed { get; set; }

		// Token: 0x17003377 RID: 13175
		// (get) Token: 0x0600CCC6 RID: 52422
		IVector3Float AverageSpeed3 { get; }

		// Token: 0x17003378 RID: 13176
		// (get) Token: 0x0600CCC7 RID: 52423
		Vector4Float_4_0_0 AverageSpeed4 { get; }

		// Token: 0x17003379 RID: 13177
		// (get) Token: 0x0600CCC8 RID: 52424

		IOffsetPtr_Clip_ACL Clip
		{

			get;
		}

		// Token: 0x1700337A RID: 13178
		// (get) Token: 0x0600CCC9 RID: 52425
		// (set) Token: 0x0600CCCA RID: 52426
		float CycleOffset { get; set; }

		// Token: 0x1700337B RID: 13179
		// (get) Token: 0x0600CCCB RID: 52427

		IHumanPose DeltaPose
		{

			get;
		}

		// Token: 0x1700337C RID: 13180
		// (get) Token: 0x0600CCCC RID: 52428
		// (set) Token: 0x0600CCCD RID: 52429
		bool HeightFromFeet { get; set; }

		// Token: 0x1700337D RID: 13181
		// (get) Token: 0x0600CCCE RID: 52430
		// (set) Token: 0x0600CCCF RID: 52431

		int[] IndexArray
		{

			get;

			set;
		}

		// Token: 0x1700337E RID: 13182
		// (get) Token: 0x0600CCD0 RID: 52432
		// (set) Token: 0x0600CCD1 RID: 52433
		bool KeepOriginalOrientation { get; set; }

		// Token: 0x1700337F RID: 13183
		// (get) Token: 0x0600CCD2 RID: 52434
		// (set) Token: 0x0600CCD3 RID: 52435
		bool KeepOriginalPositionXZ { get; set; }

		// Token: 0x17003380 RID: 13184
		// (get) Token: 0x0600CCD4 RID: 52436
		// (set) Token: 0x0600CCD5 RID: 52437
		bool KeepOriginalPositionY { get; set; }

		// Token: 0x17003381 RID: 13185
		// (get) Token: 0x0600CCD6 RID: 52438

		IXform LeftFootStartX
		{

			get;
		}

		// Token: 0x17003382 RID: 13186
		// (get) Token: 0x0600CCD7 RID: 52439
		// (set) Token: 0x0600CCD8 RID: 52440
		float Level { get; set; }

		// Token: 0x17003383 RID: 13187
		// (get) Token: 0x0600CCD9 RID: 52441
		// (set) Token: 0x0600CCDA RID: 52442
		bool LoopBlend { get; set; }

		// Token: 0x17003384 RID: 13188
		// (get) Token: 0x0600CCDB RID: 52443
		// (set) Token: 0x0600CCDC RID: 52444
		bool LoopBlendOrientation { get; set; }

		// Token: 0x17003385 RID: 13189
		// (get) Token: 0x0600CCDD RID: 52445
		// (set) Token: 0x0600CCDE RID: 52446
		bool LoopBlendPositionXZ { get; set; }

		// Token: 0x17003386 RID: 13190
		// (get) Token: 0x0600CCDF RID: 52447
		// (set) Token: 0x0600CCE0 RID: 52448
		bool LoopBlendPositionY { get; set; }

		// Token: 0x17003387 RID: 13191
		// (get) Token: 0x0600CCE1 RID: 52449
		// (set) Token: 0x0600CCE2 RID: 52450
		bool LoopTime { get; set; }

		// Token: 0x17003388 RID: 13192
		// (get) Token: 0x0600CCE3 RID: 52451
		// (set) Token: 0x0600CCE4 RID: 52452
		bool Mirror { get; set; }

		// Token: 0x17003389 RID: 13193
		// (get) Token: 0x0600CCE5 RID: 52453
		Xform_4_0_0 MotionStartX { get; }

		// Token: 0x1700338A RID: 13194
		// (get) Token: 0x0600CCE6 RID: 52454
		Xform_4_0_0 MotionStopX { get; }

		// Token: 0x1700338B RID: 13195
		// (get) Token: 0x0600CCE7 RID: 52455
		// (set) Token: 0x0600CCE8 RID: 52456
		float OrientationOffsetY { get; set; }

		// Token: 0x1700338C RID: 13196
		// (get) Token: 0x0600CCE9 RID: 52457

		IXform RightFootStartX
		{

			get;
		}

		// Token: 0x1700338D RID: 13197
		// (get) Token: 0x0600CCEA RID: 52458
		// (set) Token: 0x0600CCEB RID: 52459
		bool StartAtOrigin { get; set; }

		// Token: 0x1700338E RID: 13198
		// (get) Token: 0x0600CCEC RID: 52460
		// (set) Token: 0x0600CCED RID: 52461
		float StartTime { get; set; }

		// Token: 0x1700338F RID: 13199
		// (get) Token: 0x0600CCEE RID: 52462

		IXform StartX
		{

			get;
		}

		// Token: 0x17003390 RID: 13200
		// (get) Token: 0x0600CCEF RID: 52463
		// (set) Token: 0x0600CCF0 RID: 52464
		float StopTime { get; set; }

		// Token: 0x17003391 RID: 13201
		// (get) Token: 0x0600CCF1 RID: 52465
		Xform_5_5_0 StopX { get; }

		// Token: 0x17003392 RID: 13202
		// (get) Token: 0x0600CCF2 RID: 52466

		AssetList<ValueDelta> ValueArrayDelta
		{

			get;
		}

		// Token: 0x17003393 RID: 13203
		// (get) Token: 0x0600CCF3 RID: 52467
		// (set) Token: 0x0600CCF4 RID: 52468
		float[] ValueArrayReferencePose { get; set; }

		// Token: 0x0600CCF5 RID: 52469
		[MemberNotNullWhen(true, "MotionStopX")]
		[MemberNotNullWhen(true, "MotionStartX")]
		[MemberNotNullWhen(true, "AdditionalCurveIndexArray")]
		[MemberNotNullWhen(true, "AverageSpeed4")]
		bool Has_AdditionalCurveIndexArray();

		// Token: 0x0600CCF6 RID: 52470
		[MemberNotNullWhen(true, "AverageSpeed3")]
		[MemberNotNullWhen(false, "AverageSpeed4")]
		[MemberNotNullWhen(true, "ValueArrayReferencePose")]
		bool Has_AverageSpeed3();

		// Token: 0x0600CCF7 RID: 52471
		[MemberNotNullWhen(false, "AverageSpeed3")]
		[MemberNotNullWhen(true, "AverageSpeed4")]
		[MemberNotNullWhen(false, "ValueArrayReferencePose")]
		bool Has_AverageSpeed4();

		// Token: 0x0600CCF8 RID: 52472
		[MemberNotNullWhen(false, "MotionStopX")]
		[MemberNotNullWhen(false, "AverageSpeed4")]
		[MemberNotNullWhen(false, "AdditionalCurveIndexArray")]
		[MemberNotNullWhen(false, "MotionStartX")]
		bool Has_LoopTime();

		// Token: 0x0600CCF9 RID: 52473
		[MemberNotNullWhen(true, "AverageSpeed4")]
		[MemberNotNullWhen(true, "MotionStartX")]
		[MemberNotNullWhen(true, "MotionStopX")]
		bool Has_MotionStartX();

		// Token: 0x0600CCFA RID: 52474
		[MemberNotNullWhen(true, "AverageSpeed4")]
		[MemberNotNullWhen(true, "MotionStartX")]
		[MemberNotNullWhen(true, "MotionStopX")]
		bool Has_MotionStopX();

		// Token: 0x0600CCFB RID: 52475
		[MemberNotNullWhen(true, "AverageSpeed3")]
		[MemberNotNullWhen(true, "StopX")]
		[MemberNotNullWhen(true, "ValueArrayReferencePose")]
		bool Has_StartAtOrigin();

		// Token: 0x0600CCFC RID: 52476
		[MemberNotNullWhen(true, "AverageSpeed3")]
		[MemberNotNullWhen(true, "StopX")]
		[MemberNotNullWhen(true, "ValueArrayReferencePose")]
		bool Has_StopX();

		// Token: 0x0600CCFD RID: 52477
		[MemberNotNullWhen(false, "AverageSpeed4")]
		[MemberNotNullWhen(true, "ValueArrayReferencePose")]
		bool Has_ValueArrayReferencePose();

		// Token: 0x0600CCFE RID: 52478
		void CopyValues(IMuscleClipConstant_ACL source);

		// Token: 0x0600CCFF RID: 52479

		IMuscleClipConstant_ACL DeepClone();
	}
}
