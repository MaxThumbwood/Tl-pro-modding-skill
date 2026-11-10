using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Utilities;
using Terraria.DataStructures;
using Terraria.GameContent;
using Terraria.GameContent.Creative;
using Terraria.GameContent.Items;
using Terraria.GameContent.ObjectInteractions;
using Terraria.ID;
using Terraria.IO;
using Terraria.Localization;
using Terraria.UI.Chat;

namespace Terraria
{
	// Token: 0x02000489 RID: 1161
	[Token(Token = "0x2000489")]
	public class Player : Entity, FileAPI
	{
		// Token: 0x17000589 RID: 1417
		// (get) Token: 0x06002874 RID: 10356 RVA: 0x00013590 File Offset: 0x00011790
		// (set) Token: 0x06002875 RID: 10357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000589")]
		public static int tileRangeX
		{
			[Token(Token = "0x6002874")]
			[Address(RVA = "0x149C7B0", Offset = "0x149C7B0", VA = "0x149C7B0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002875")]
			[Address(RVA = "0x149C818", Offset = "0x149C818", VA = "0x149C818")]
			set
			{
			}
		}

		// Token: 0x1700058A RID: 1418
		// (get) Token: 0x06002876 RID: 10358 RVA: 0x000135A8 File Offset: 0x000117A8
		// (set) Token: 0x06002877 RID: 10359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700058A")]
		public static int tileRangeY
		{
			[Token(Token = "0x6002876")]
			[Address(RVA = "0x149C884", Offset = "0x149C884", VA = "0x149C884")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002877")]
			[Address(RVA = "0x149C8EC", Offset = "0x149C8EC", VA = "0x149C8EC")]
			set
			{
			}
		}

		// Token: 0x1700058B RID: 1419
		// (get) Token: 0x06002878 RID: 10360 RVA: 0x000135C0 File Offset: 0x000117C0
		// (set) Token: 0x06002879 RID: 10361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700058B")]
		public static int tileTargetX
		{
			[Token(Token = "0x6002878")]
			[Address(RVA = "0x149C958", Offset = "0x149C958", VA = "0x149C958")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002879")]
			[Address(RVA = "0x149C9C0", Offset = "0x149C9C0", VA = "0x149C9C0")]
			set
			{
			}
		}

		// Token: 0x1700058C RID: 1420
		// (get) Token: 0x0600287A RID: 10362 RVA: 0x000135D8 File Offset: 0x000117D8
		// (set) Token: 0x0600287B RID: 10363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700058C")]
		public static int tileTargetY
		{
			[Token(Token = "0x600287A")]
			[Address(RVA = "0x149CA2C", Offset = "0x149CA2C", VA = "0x149CA2C")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600287B")]
			[Address(RVA = "0x149CA94", Offset = "0x149CA94", VA = "0x149CA94")]
			set
			{
			}
		}

		// Token: 0x1700058D RID: 1421
		// (get) Token: 0x0600287C RID: 10364 RVA: 0x000135F0 File Offset: 0x000117F0
		// (set) Token: 0x0600287D RID: 10365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700058D")]
		public static int jumpHeight
		{
			[Token(Token = "0x600287C")]
			[Address(RVA = "0x149CB00", Offset = "0x149CB00", VA = "0x149CB00")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600287D")]
			[Address(RVA = "0x149CB68", Offset = "0x149CB68", VA = "0x149CB68")]
			set
			{
			}
		}

		// Token: 0x1700058E RID: 1422
		// (get) Token: 0x0600287E RID: 10366 RVA: 0x00013608 File Offset: 0x00011808
		// (set) Token: 0x0600287F RID: 10367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700058E")]
		public static float jumpSpeed
		{
			[Token(Token = "0x600287E")]
			[Address(RVA = "0x149CBD4", Offset = "0x149CBD4", VA = "0x149CBD4")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600287F")]
			[Address(RVA = "0x149CC3C", Offset = "0x149CC3C", VA = "0x149CC3C")]
			set
			{
			}
		}

		// Token: 0x1700058F RID: 1423
		// (get) Token: 0x06002880 RID: 10368 RVA: 0x00013620 File Offset: 0x00011820
		// (set) Token: 0x06002881 RID: 10369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700058F")]
		public static int BlockInteractionWithProjectiles
		{
			[Token(Token = "0x6002880")]
			[Address(RVA = "0x149CCB4", Offset = "0x149CCB4", VA = "0x149CCB4")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002881")]
			[Address(RVA = "0x149CD1C", Offset = "0x149CD1C", VA = "0x149CD1C")]
			set
			{
			}
		}

		// Token: 0x17000590 RID: 1424
		// (get) Token: 0x06002882 RID: 10370 RVA: 0x00013638 File Offset: 0x00011838
		// (set) Token: 0x06002883 RID: 10371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000590")]
		public static bool lastPound
		{
			[Token(Token = "0x6002882")]
			[Address(RVA = "0x149CD88", Offset = "0x149CD88", VA = "0x149CD88")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002883")]
			[Address(RVA = "0x149CDF0", Offset = "0x149CDF0", VA = "0x149CDF0")]
			set
			{
			}
		}

		// Token: 0x17000591 RID: 1425
		// (get) Token: 0x06002884 RID: 10372 RVA: 0x00013650 File Offset: 0x00011850
		// (set) Token: 0x06002885 RID: 10373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000591")]
		public static int musicNotes
		{
			[Token(Token = "0x6002884")]
			[Address(RVA = "0x149CE5C", Offset = "0x149CE5C", VA = "0x149CE5C")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002885")]
			[Address(RVA = "0x149CEC4", Offset = "0x149CEC4", VA = "0x149CEC4")]
			set
			{
			}
		}

		// Token: 0x17000592 RID: 1426
		// (get) Token: 0x06002886 RID: 10374 RVA: 0x00013668 File Offset: 0x00011868
		[Token(Token = "0x17000592")]
		public Vector2 BlehOldPositionFixer
		{
			[Token(Token = "0x6002886")]
			[Address(RVA = "0x149CF30", Offset = "0x149CF30", VA = "0x149CF30")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x17000593 RID: 1427
		// (get) Token: 0x06002887 RID: 10375 RVA: 0x00013680 File Offset: 0x00011880
		[Token(Token = "0x17000593")]
		public float HeightOffsetVisual
		{
			[Token(Token = "0x6002887")]
			[Address(RVA = "0x149CFFC", Offset = "0x149CFFC", VA = "0x149CFFC")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000594 RID: 1428
		// (get) Token: 0x06002888 RID: 10376 RVA: 0x00013698 File Offset: 0x00011898
		[Token(Token = "0x17000594")]
		public float HeightOffsetHitboxCenter
		{
			[Token(Token = "0x6002888")]
			[Address(RVA = "0x149D070", Offset = "0x149D070", VA = "0x149D070")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000595 RID: 1429
		// (get) Token: 0x06002889 RID: 10377 RVA: 0x000136B0 File Offset: 0x000118B0
		[Token(Token = "0x17000595")]
		public float MountXOffset
		{
			[Token(Token = "0x6002889")]
			[Address(RVA = "0x149D0EC", Offset = "0x149D0EC", VA = "0x149D0EC")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000596 RID: 1430
		// (get) Token: 0x0600288A RID: 10378 RVA: 0x000136C8 File Offset: 0x000118C8
		[Token(Token = "0x17000596")]
		public int HeightOffsetBoost
		{
			[Token(Token = "0x600288A")]
			[Address(RVA = "0x149D14C", Offset = "0x149D14C", VA = "0x149D14C")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000597 RID: 1431
		// (get) Token: 0x0600288B RID: 10379 RVA: 0x000136E0 File Offset: 0x000118E0
		[Token(Token = "0x17000597")]
		public int HeightMapOffset
		{
			[Token(Token = "0x600288B")]
			[Address(RVA = "0x149D1A4", Offset = "0x149D1A4", VA = "0x149D1A4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000598 RID: 1432
		// (get) Token: 0x0600288C RID: 10380 RVA: 0x000136F8 File Offset: 0x000118F8
		[Token(Token = "0x17000598")]
		public Rectangle HitboxForBestiaryNearbyCheck
		{
			[Token(Token = "0x600288C")]
			[Address(RVA = "0x149D1FC", Offset = "0x149D1FC", VA = "0x149D1FC")]
			get
			{
				return default(Rectangle);
			}
		}

		// Token: 0x17000599 RID: 1433
		// (get) Token: 0x0600288D RID: 10381 RVA: 0x00013710 File Offset: 0x00011910
		[Token(Token = "0x17000599")]
		public bool IsConsideredStandingStill
		{
			[Token(Token = "0x600288D")]
			[Address(RVA = "0x149D2F0", Offset = "0x149D2F0", VA = "0x149D2F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700059A RID: 1434
		// (get) Token: 0x0600288E RID: 10382 RVA: 0x00013728 File Offset: 0x00011928
		[Token(Token = "0x1700059A")]
		public float BaseHeight
		{
			[Token(Token = "0x600288E")]
			[Address(RVA = "0x149D3AC", Offset = "0x149D3AC", VA = "0x149D3AC")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700059B RID: 1435
		// (get) Token: 0x0600288F RID: 10383 RVA: 0x00013740 File Offset: 0x00011940
		// (set) Token: 0x06002890 RID: 10384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700059B")]
		public Vector2 MountedCenter
		{
			[Token(Token = "0x600288F")]
			[Address(RVA = "0x149D418", Offset = "0x149D418", VA = "0x149D418")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6002890")]
			[Address(RVA = "0x149D540", Offset = "0x149D540", VA = "0x149D540")]
			set
			{
			}
		}

		// Token: 0x1700059C RID: 1436
		// (get) Token: 0x06002891 RID: 10385 RVA: 0x00013758 File Offset: 0x00011958
		// (set) Token: 0x06002892 RID: 10386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700059C")]
		public Vector2 MountedTop
		{
			[Token(Token = "0x6002891")]
			[Address(RVA = "0x149D680", Offset = "0x149D680", VA = "0x149D680")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6002892")]
			[Address(RVA = "0x149D7E8", Offset = "0x149D7E8", VA = "0x149D7E8")]
			set
			{
			}
		}

		// Token: 0x06002893 RID: 10387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002893")]
		[Address(RVA = "0x149D95C", Offset = "0x149D95C", VA = "0x149D95C")]
		public void RotateRelativePoint(ref float x, ref float y)
		{
		}

		// Token: 0x06002894 RID: 10388 RVA: 0x00013770 File Offset: 0x00011970
		[Token(Token = "0x6002894")]
		[Address(RVA = "0x149D9C8", Offset = "0x149D9C8", VA = "0x149D9C8")]
		public Vector2 RotatedRelativePoint(Vector2 pos, bool reverseRotation = false, bool addGfxOffY = true, int pushFromOriginHack = 0)
		{
			return default(Vector2);
		}

		// Token: 0x06002895 RID: 10389 RVA: 0x00013788 File Offset: 0x00011988
		[Token(Token = "0x6002895")]
		[Address(RVA = "0x149DDF4", Offset = "0x149DDF4", VA = "0x149DDF4")]
		public int CalculateFrameFromMiscCounter(int framerate, int minFrame, int maxFrame)
		{
			return 0;
		}

		// Token: 0x1700059D RID: 1437
		// (get) Token: 0x06002896 RID: 10390 RVA: 0x000137A0 File Offset: 0x000119A0
		[Token(Token = "0x1700059D")]
		public bool TileReplacementEnabled
		{
			[Token(Token = "0x6002896")]
			[Address(RVA = "0x149DF20", Offset = "0x149DF20", VA = "0x149DF20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700059E RID: 1438
		// (get) Token: 0x06002897 RID: 10391 RVA: 0x000137B8 File Offset: 0x000119B8
		[Token(Token = "0x1700059E")]
		public override Vector2 VisualPosition
		{
			[Token(Token = "0x6002897")]
			[Address(RVA = "0x149DF44", Offset = "0x149DF44", VA = "0x149DF44", Slot = "4")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x1700059F RID: 1439
		// (get) Token: 0x06002898 RID: 10392 RVA: 0x000137D0 File Offset: 0x000119D0
		[Token(Token = "0x1700059F")]
		public bool CCed
		{
			[Token(Token = "0x6002898")]
			[Address(RVA = "0x149DFFC", Offset = "0x149DFFC", VA = "0x149DFFC")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170005A0 RID: 1440
		// (get) Token: 0x06002899 RID: 10393 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005A0")]
		public string netName
		{
			[Token(Token = "0x6002899")]
			[Address(RVA = "0x149E02C", Offset = "0x149E02C", VA = "0x149E02C")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005A1 RID: 1441
		// (get) Token: 0x0600289A RID: 10394 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005A1")]
		public string dataName
		{
			[Token(Token = "0x600289A")]
			[Address(RVA = "0x149E034", Offset = "0x149E034", VA = "0x149E034")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600289B RID: 10395 RVA: 0x000137E8 File Offset: 0x000119E8
		[Token(Token = "0x600289B")]
		[Address(RVA = "0x149E03C", Offset = "0x149E03C", VA = "0x149E03C")]
		public bool CanDemonHeartAccessoryBeShown()
		{
			return default(bool);
		}

		// Token: 0x0600289C RID: 10396 RVA: 0x00013800 File Offset: 0x00011A00
		[Token(Token = "0x600289C")]
		[Address(RVA = "0x149E27C", Offset = "0x149E27C", VA = "0x149E27C")]
		public bool CanMasterModeAccessoryBeShown()
		{
			return default(bool);
		}

		// Token: 0x0600289D RID: 10397 RVA: 0x00013818 File Offset: 0x00011A18
		[Token(Token = "0x600289D")]
		[Address(RVA = "0x149E3A4", Offset = "0x149E3A4", VA = "0x149E3A4")]
		public int GetAmountOfExtraAccessorySlotsToShow()
		{
			return 0;
		}

		// Token: 0x170005A2 RID: 1442
		// (get) Token: 0x0600289E RID: 10398 RVA: 0x00013830 File Offset: 0x00011A30
		[Token(Token = "0x170005A2")]
		public float miscCounterNormalized
		{
			[Token(Token = "0x600289E")]
			[Address(RVA = "0x149E3D8", Offset = "0x149E3D8", VA = "0x149E3D8")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x0600289F RID: 10399 RVA: 0x00013848 File Offset: 0x00011A48
		[Token(Token = "0x600289F")]
		[Address(RVA = "0x149E3F4", Offset = "0x149E3F4", VA = "0x149E3F4")]
		public bool EverySomeYoyoHits(int amount, bool countUp)
		{
			return default(bool);
		}

		// Token: 0x170005A3 RID: 1443
		// (get) Token: 0x060028A0 RID: 10400 RVA: 0x00013860 File Offset: 0x00011A60
		// (set) Token: 0x060028A1 RID: 10401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005A3")]
		public bool accSnappingStoneLightUp
		{
			[Token(Token = "0x60028A0")]
			[Address(RVA = "0x149E424", Offset = "0x149E424", VA = "0x149E424")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60028A1")]
			[Address(RVA = "0x149E434", Offset = "0x149E434", VA = "0x149E434")]
			set
			{
			}
		}

		// Token: 0x170005A4 RID: 1444
		// (get) Token: 0x060028A2 RID: 10402 RVA: 0x00013878 File Offset: 0x00011A78
		[Token(Token = "0x170005A4")]
		public bool timerCritChargeFull
		{
			[Token(Token = "0x60028A2")]
			[Address(RVA = "0x149E464", Offset = "0x149E464", VA = "0x149E464")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170005A5 RID: 1445
		// (get) Token: 0x060028A3 RID: 10403 RVA: 0x00013890 File Offset: 0x00011A90
		// (set) Token: 0x060028A4 RID: 10404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005A5")]
		public bool Male
		{
			[Token(Token = "0x60028A3")]
			[Address(RVA = "0x149E484", Offset = "0x149E484", VA = "0x149E484")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60028A4")]
			[Address(RVA = "0x149E504", Offset = "0x149E504", VA = "0x149E504")]
			set
			{
			}
		}

		// Token: 0x170005A6 RID: 1446
		// (get) Token: 0x060028A5 RID: 10405 RVA: 0x000138A8 File Offset: 0x00011AA8
		// (set) Token: 0x060028A6 RID: 10406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005A6")]
		public bool ZoneDungeon
		{
			[Token(Token = "0x60028A5")]
			[Address(RVA = "0x149E610", Offset = "0x149E610", VA = "0x149E610")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60028A6")]
			[Address(RVA = "0x149E624", Offset = "0x149E624", VA = "0x149E624")]
			set
			{
			}
		}

		// Token: 0x170005A7 RID: 1447
		// (get) Token: 0x060028A7 RID: 10407 RVA: 0x000138C0 File Offset: 0x00011AC0
		// (set) Token: 0x060028A8 RID: 10408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005A7")]
		public bool ZoneCorrupt
		{
			[Token(Token = "0x60028A7")]
			[Address(RVA = "0x149E63C", Offset = "0x149E63C", VA = "0x149E63C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60028A8")]
			[Address(RVA = "0x149E650", Offset = "0x149E650", VA = "0x149E650")]
			set
			{
			}
		}

		// Token: 0x170005A8 RID: 1448
		// (get) Token: 0x060028A9 RID: 10409 RVA: 0x000138D8 File Offset: 0x00011AD8
		// (set) Token: 0x060028AA RID: 10410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005A8")]
		public bool ZoneHallow
		{
			[Token(Token = "0x60028A9")]
			[Address(RVA = "0x149E668", Offset = "0x149E668", VA = "0x149E668")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60028AA")]
			[Address(RVA = "0x149E67C", Offset = "0x149E67C", VA = "0x149E67C")]
			set
			{
			}
		}

		// Token: 0x170005A9 RID: 1449
		// (get) Token: 0x060028AB RID: 10411 RVA: 0x000138F0 File Offset: 0x00011AF0
		// (set) Token: 0x060028AC RID: 10412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005A9")]
		public bool ZoneMeteor
		{
			[Token(Token = "0x60028AB")]
			[Address(RVA = "0x149E694", Offset = "0x149E694", VA = "0x149E694")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60028AC")]
			[Address(RVA = "0x149E6A8", Offset = "0x149E6A8", VA = "0x149E6A8")]
			set
			{
			}
		}

		// Token: 0x170005AA RID: 1450
		// (get) Token: 0x060028AD RID: 10413 RVA: 0x00013908 File Offset: 0x00011B08
		// (set) Token: 0x060028AE RID: 10414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005AA")]
		public bool ZoneJungle
		{
			[Token(Token = "0x60028AD")]
			[Address(RVA = "0x149E6C0", Offset = "0x149E6C0", VA = "0x149E6C0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60028AE")]
			[Address(RVA = "0x149E6D4", Offset = "0x149E6D4", VA = "0x149E6D4")]
			set
			{
			}
		}

		// Token: 0x170005AB RID: 1451
		// (get) Token: 0x060028AF RID: 10415 RVA: 0x00013920 File Offset: 0x00011B20
		// (set) Token: 0x060028B0 RID: 10416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005AB")]
		public bool ZoneSnow
		{
			[Token(Token = "0x60028AF")]
			[Address(RVA = "0x149E6EC", Offset = "0x149E6EC", VA = "0x149E6EC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60028B0")]
			[Address(RVA = "0x149E700", Offset = "0x149E700", VA = "0x149E700")]
			set
			{
			}
		}

		// Token: 0x170005AC RID: 1452
		// (get) Token: 0x060028B1 RID: 10417 RVA: 0x00013938 File Offset: 0x00011B38
		// (set) Token: 0x060028B2 RID: 10418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005AC")]
		public bool ZoneCrimson
		{
			[Token(Token = "0x60028B1")]
			[Address(RVA = "0x149E718", Offset = "0x149E718", VA = "0x149E718")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60028B2")]
			[Address(RVA = "0x149E72C", Offset = "0x149E72C", VA = "0x149E72C")]
			set
			{
			}
		}

		// Token: 0x170005AD RID: 1453
		// (get) Token: 0x060028B3 RID: 10419 RVA: 0x00013950 File Offset: 0x00011B50
		// (set) Token: 0x060028B4 RID: 10420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005AD")]
		public bool ZoneWaterCandle
		{
			[Token(Token = "0x60028B3")]
			[Address(RVA = "0x149E744", Offset = "0x149E744", VA = "0x149E744")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60028B4")]
			[Address(RVA = "0x149E758", Offset = "0x149E758", VA = "0x149E758")]
			set
			{
			}
		}

		// Token: 0x170005AE RID: 1454
		// (get) Token: 0x060028B5 RID: 10421 RVA: 0x00013968 File Offset: 0x00011B68
		// (set) Token: 0x060028B6 RID: 10422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005AE")]
		public bool ZonePeaceCandle
		{
			[Token(Token = "0x60028B5")]
			[Address(RVA = "0x149E770", Offset = "0x149E770", VA = "0x149E770")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60028B6")]
			[Address(RVA = "0x149E784", Offset = "0x149E784", VA = "0x149E784")]
			set
			{
			}
		}

		// Token: 0x170005AF RID: 1455
		// (get) Token: 0x060028B7 RID: 10423 RVA: 0x00013980 File Offset: 0x00011B80
		// (set) Token: 0x060028B8 RID: 10424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005AF")]
		public bool ZoneTowerSolar
		{
			[Token(Token = "0x60028B7")]
			[Address(RVA = "0x149E79C", Offset = "0x149E79C", VA = "0x149E79C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60028B8")]
			[Address(RVA = "0x149E7B0", Offset = "0x149E7B0", VA = "0x149E7B0")]
			set
			{
			}
		}

		// Token: 0x170005B0 RID: 1456
		// (get) Token: 0x060028B9 RID: 10425 RVA: 0x00013998 File Offset: 0x00011B98
		// (set) Token: 0x060028BA RID: 10426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005B0")]
		public bool ZoneTowerVortex
		{
			[Token(Token = "0x60028B9")]
			[Address(RVA = "0x149E7C8", Offset = "0x149E7C8", VA = "0x149E7C8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60028BA")]
			[Address(RVA = "0x149E7DC", Offset = "0x149E7DC", VA = "0x149E7DC")]
			set
			{
			}
		}

		// Token: 0x170005B1 RID: 1457
		// (get) Token: 0x060028BB RID: 10427 RVA: 0x000139B0 File Offset: 0x00011BB0
		// (set) Token: 0x060028BC RID: 10428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005B1")]
		public bool ZoneTowerNebula
		{
			[Token(Token = "0x60028BB")]
			[Address(RVA = "0x149E7F4", Offset = "0x149E7F4", VA = "0x149E7F4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60028BC")]
			[Address(RVA = "0x149E808", Offset = "0x149E808", VA = "0x149E808")]
			set
			{
			}
		}

		// Token: 0x170005B2 RID: 1458
		// (get) Token: 0x060028BD RID: 10429 RVA: 0x000139C8 File Offset: 0x00011BC8
		// (set) Token: 0x060028BE RID: 10430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005B2")]
		public bool ZoneTowerStardust
		{
			[Token(Token = "0x60028BD")]
			[Address(RVA = "0x149E820", Offset = "0x149E820", VA = "0x149E820")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60028BE")]
			[Address(RVA = "0x149E834", Offset = "0x149E834", VA = "0x149E834")]
			set
			{
			}
		}

		// Token: 0x170005B3 RID: 1459
		// (get) Token: 0x060028BF RID: 10431 RVA: 0x000139E0 File Offset: 0x00011BE0
		// (set) Token: 0x060028C0 RID: 10432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005B3")]
		public bool ZoneDesert
		{
			[Token(Token = "0x60028BF")]
			[Address(RVA = "0x149E84C", Offset = "0x149E84C", VA = "0x149E84C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60028C0")]
			[Address(RVA = "0x149E860", Offset = "0x149E860", VA = "0x149E860")]
			set
			{
			}
		}

		// Token: 0x170005B4 RID: 1460
		// (get) Token: 0x060028C1 RID: 10433 RVA: 0x000139F8 File Offset: 0x00011BF8
		// (set) Token: 0x060028C2 RID: 10434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005B4")]
		public bool ZoneGlowshroom
		{
			[Token(Token = "0x60028C1")]
			[Address(RVA = "0x149E878", Offset = "0x149E878", VA = "0x149E878")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60028C2")]
			[Address(RVA = "0x149E88C", Offset = "0x149E88C", VA = "0x149E88C")]
			set
			{
			}
		}

		// Token: 0x170005B5 RID: 1461
		// (get) Token: 0x060028C3 RID: 10435 RVA: 0x00013A10 File Offset: 0x00011C10
		// (set) Token: 0x060028C4 RID: 10436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005B5")]
		public bool ZoneUndergroundDesert
		{
			[Token(Token = "0x60028C3")]
			[Address(RVA = "0x149E8A4", Offset = "0x149E8A4", VA = "0x149E8A4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60028C4")]
			[Address(RVA = "0x149E8B8", Offset = "0x149E8B8", VA = "0x149E8B8")]
			set
			{
			}
		}

		// Token: 0x170005B6 RID: 1462
		// (get) Token: 0x060028C5 RID: 10437 RVA: 0x00013A28 File Offset: 0x00011C28
		// (set) Token: 0x060028C6 RID: 10438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005B6")]
		public bool ZoneSkyHeight
		{
			[Token(Token = "0x60028C5")]
			[Address(RVA = "0x149E8D0", Offset = "0x149E8D0", VA = "0x149E8D0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60028C6")]
			[Address(RVA = "0x149E8E4", Offset = "0x149E8E4", VA = "0x149E8E4")]
			set
			{
			}
		}

		// Token: 0x170005B7 RID: 1463
		// (get) Token: 0x060028C7 RID: 10439 RVA: 0x00013A40 File Offset: 0x00011C40
		// (set) Token: 0x060028C8 RID: 10440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005B7")]
		public bool ZoneOverworldHeight
		{
			[Token(Token = "0x60028C7")]
			[Address(RVA = "0x149E8FC", Offset = "0x149E8FC", VA = "0x149E8FC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60028C8")]
			[Address(RVA = "0x149E910", Offset = "0x149E910", VA = "0x149E910")]
			set
			{
			}
		}

		// Token: 0x170005B8 RID: 1464
		// (get) Token: 0x060028C9 RID: 10441 RVA: 0x00013A58 File Offset: 0x00011C58
		// (set) Token: 0x060028CA RID: 10442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005B8")]
		public bool ZoneDirtLayerHeight
		{
			[Token(Token = "0x60028C9")]
			[Address(RVA = "0x149E928", Offset = "0x149E928", VA = "0x149E928")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60028CA")]
			[Address(RVA = "0x149E93C", Offset = "0x149E93C", VA = "0x149E93C")]
			set
			{
			}
		}

		// Token: 0x170005B9 RID: 1465
		// (get) Token: 0x060028CB RID: 10443 RVA: 0x00013A70 File Offset: 0x00011C70
		// (set) Token: 0x060028CC RID: 10444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005B9")]
		public bool ZoneRockLayerHeight
		{
			[Token(Token = "0x60028CB")]
			[Address(RVA = "0x149E954", Offset = "0x149E954", VA = "0x149E954")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60028CC")]
			[Address(RVA = "0x149E968", Offset = "0x149E968", VA = "0x149E968")]
			set
			{
			}
		}

		// Token: 0x170005BA RID: 1466
		// (get) Token: 0x060028CD RID: 10445 RVA: 0x00013A88 File Offset: 0x00011C88
		// (set) Token: 0x060028CE RID: 10446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005BA")]
		public bool ZoneUnderworldHeight
		{
			[Token(Token = "0x60028CD")]
			[Address(RVA = "0x149E980", Offset = "0x149E980", VA = "0x149E980")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60028CE")]
			[Address(RVA = "0x149E994", Offset = "0x149E994", VA = "0x149E994")]
			set
			{
			}
		}

		// Token: 0x170005BB RID: 1467
		// (get) Token: 0x060028CF RID: 10447 RVA: 0x00013AA0 File Offset: 0x00011CA0
		// (set) Token: 0x060028D0 RID: 10448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005BB")]
		public bool ZoneBeach
		{
			[Token(Token = "0x60028CF")]
			[Address(RVA = "0x149E9AC", Offset = "0x149E9AC", VA = "0x149E9AC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60028D0")]
			[Address(RVA = "0x149E9C0", Offset = "0x149E9C0", VA = "0x149E9C0")]
			set
			{
			}
		}

		// Token: 0x170005BC RID: 1468
		// (get) Token: 0x060028D1 RID: 10449 RVA: 0x00013AB8 File Offset: 0x00011CB8
		// (set) Token: 0x060028D2 RID: 10450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005BC")]
		public bool ZoneRain
		{
			[Token(Token = "0x60028D1")]
			[Address(RVA = "0x149E9D8", Offset = "0x149E9D8", VA = "0x149E9D8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60028D2")]
			[Address(RVA = "0x149E9EC", Offset = "0x149E9EC", VA = "0x149E9EC")]
			set
			{
			}
		}

		// Token: 0x170005BD RID: 1469
		// (get) Token: 0x060028D3 RID: 10451 RVA: 0x00013AD0 File Offset: 0x00011CD0
		// (set) Token: 0x060028D4 RID: 10452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005BD")]
		public bool ZoneSandstorm
		{
			[Token(Token = "0x60028D3")]
			[Address(RVA = "0x149EA04", Offset = "0x149EA04", VA = "0x149EA04")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60028D4")]
			[Address(RVA = "0x149EA18", Offset = "0x149EA18", VA = "0x149EA18")]
			set
			{
			}
		}

		// Token: 0x170005BE RID: 1470
		// (get) Token: 0x060028D5 RID: 10453 RVA: 0x00013AE8 File Offset: 0x00011CE8
		// (set) Token: 0x060028D6 RID: 10454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005BE")]
		public bool ZoneOldOneArmy
		{
			[Token(Token = "0x60028D5")]
			[Address(RVA = "0x149EA30", Offset = "0x149EA30", VA = "0x149EA30")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60028D6")]
			[Address(RVA = "0x149EA40", Offset = "0x149EA40", VA = "0x149EA40")]
			set
			{
			}
		}

		// Token: 0x170005BF RID: 1471
		// (get) Token: 0x060028D7 RID: 10455 RVA: 0x00013B00 File Offset: 0x00011D00
		// (set) Token: 0x060028D8 RID: 10456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005BF")]
		public bool ZoneGranite
		{
			[Token(Token = "0x60028D7")]
			[Address(RVA = "0x149EA54", Offset = "0x149EA54", VA = "0x149EA54")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60028D8")]
			[Address(RVA = "0x149EA64", Offset = "0x149EA64", VA = "0x149EA64")]
			set
			{
			}
		}

		// Token: 0x170005C0 RID: 1472
		// (get) Token: 0x060028D9 RID: 10457 RVA: 0x00013B18 File Offset: 0x00011D18
		// (set) Token: 0x060028DA RID: 10458 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005C0")]
		public bool ZoneMarble
		{
			[Token(Token = "0x60028D9")]
			[Address(RVA = "0x149EA78", Offset = "0x149EA78", VA = "0x149EA78")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60028DA")]
			[Address(RVA = "0x149EA88", Offset = "0x149EA88", VA = "0x149EA88")]
			set
			{
			}
		}

		// Token: 0x170005C1 RID: 1473
		// (get) Token: 0x060028DB RID: 10459 RVA: 0x00013B30 File Offset: 0x00011D30
		// (set) Token: 0x060028DC RID: 10460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005C1")]
		public bool ZoneHive
		{
			[Token(Token = "0x60028DB")]
			[Address(RVA = "0x149EA9C", Offset = "0x149EA9C", VA = "0x149EA9C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60028DC")]
			[Address(RVA = "0x149EAAC", Offset = "0x149EAAC", VA = "0x149EAAC")]
			set
			{
			}
		}

		// Token: 0x170005C2 RID: 1474
		// (get) Token: 0x060028DD RID: 10461 RVA: 0x00013B48 File Offset: 0x00011D48
		// (set) Token: 0x060028DE RID: 10462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005C2")]
		public bool ZoneGemCave
		{
			[Token(Token = "0x60028DD")]
			[Address(RVA = "0x149EAC0", Offset = "0x149EAC0", VA = "0x149EAC0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60028DE")]
			[Address(RVA = "0x149EAD0", Offset = "0x149EAD0", VA = "0x149EAD0")]
			set
			{
			}
		}

		// Token: 0x170005C3 RID: 1475
		// (get) Token: 0x060028DF RID: 10463 RVA: 0x00013B60 File Offset: 0x00011D60
		// (set) Token: 0x060028E0 RID: 10464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005C3")]
		public bool ZoneLihzhardTemple
		{
			[Token(Token = "0x60028DF")]
			[Address(RVA = "0x149EAE4", Offset = "0x149EAE4", VA = "0x149EAE4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60028E0")]
			[Address(RVA = "0x149EAF4", Offset = "0x149EAF4", VA = "0x149EAF4")]
			set
			{
			}
		}

		// Token: 0x170005C4 RID: 1476
		// (get) Token: 0x060028E1 RID: 10465 RVA: 0x00013B78 File Offset: 0x00011D78
		// (set) Token: 0x060028E2 RID: 10466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005C4")]
		public bool ZoneGraveyard
		{
			[Token(Token = "0x60028E1")]
			[Address(RVA = "0x149EB08", Offset = "0x149EB08", VA = "0x149EB08")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60028E2")]
			[Address(RVA = "0x149EB18", Offset = "0x149EB18", VA = "0x149EB18")]
			set
			{
			}
		}

		// Token: 0x170005C5 RID: 1477
		// (get) Token: 0x060028E3 RID: 10467 RVA: 0x00013B90 File Offset: 0x00011D90
		// (set) Token: 0x060028E4 RID: 10468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005C5")]
		public bool ZoneShadowCandle
		{
			[Token(Token = "0x60028E3")]
			[Address(RVA = "0x149EB2C", Offset = "0x149EB2C", VA = "0x149EB2C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60028E4")]
			[Address(RVA = "0x149EB3C", Offset = "0x149EB3C", VA = "0x149EB3C")]
			set
			{
			}
		}

		// Token: 0x170005C6 RID: 1478
		// (get) Token: 0x060028E5 RID: 10469 RVA: 0x00013BA8 File Offset: 0x00011DA8
		// (set) Token: 0x060028E6 RID: 10470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005C6")]
		public bool ZoneShimmer
		{
			[Token(Token = "0x60028E5")]
			[Address(RVA = "0x149EB50", Offset = "0x149EB50", VA = "0x149EB50")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60028E6")]
			[Address(RVA = "0x149EB64", Offset = "0x149EB64", VA = "0x149EB64")]
			set
			{
			}
		}

		// Token: 0x170005C7 RID: 1479
		// (get) Token: 0x060028E7 RID: 10471 RVA: 0x00013BC0 File Offset: 0x00011DC0
		[Token(Token = "0x170005C7")]
		public bool ShoppingZone_AnyBiome
		{
			[Token(Token = "0x60028E7")]
			[Address(RVA = "0x149EB7C", Offset = "0x149EB7C", VA = "0x149EB7C")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170005C8 RID: 1480
		// (get) Token: 0x060028E8 RID: 10472 RVA: 0x00013BD8 File Offset: 0x00011DD8
		[Token(Token = "0x170005C8")]
		public bool ShoppingZone_BelowSurface
		{
			[Token(Token = "0x60028E8")]
			[Address(RVA = "0x149EC74", Offset = "0x149EC74", VA = "0x149EC74")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170005C9 RID: 1481
		// (get) Token: 0x060028E9 RID: 10473 RVA: 0x00013BF0 File Offset: 0x00011DF0
		[Token(Token = "0x170005C9")]
		public bool ShoppingZone_Forest
		{
			[Token(Token = "0x60028E9")]
			[Address(RVA = "0x149ED5C", Offset = "0x149ED5C", VA = "0x149ED5C")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170005CA RID: 1482
		// (get) Token: 0x060028EA RID: 10474 RVA: 0x00013C08 File Offset: 0x00011E08
		[Token(Token = "0x170005CA")]
		public Vector2 Directions
		{
			[Token(Token = "0x60028EA")]
			[Address(RVA = "0x149ED84", Offset = "0x149ED84", VA = "0x149ED84")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x170005CB RID: 1483
		// (get) Token: 0x060028EB RID: 10475 RVA: 0x00013C20 File Offset: 0x00011E20
		[Token(Token = "0x170005CB")]
		public int selectedItem
		{
			[Token(Token = "0x60028EB")]
			[Address(RVA = "0x149EDB4", Offset = "0x149EDB4", VA = "0x149EDB4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170005CC RID: 1484
		// (get) Token: 0x060028EC RID: 10476 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005CC")]
		public Item HeldItem
		{
			[Token(Token = "0x60028EC")]
			[Address(RVA = "0x149EDBC", Offset = "0x149EDBC", VA = "0x149EDBC")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005CD RID: 1485
		// (get) Token: 0x060028ED RID: 10477 RVA: 0x00013C38 File Offset: 0x00011E38
		[Token(Token = "0x170005CD")]
		public int breathCDMax
		{
			[Token(Token = "0x60028ED")]
			[Address(RVA = "0x149EDE0", Offset = "0x149EDE0", VA = "0x149EDE0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170005CE RID: 1486
		// (get) Token: 0x060028EE RID: 10478 RVA: 0x00013C50 File Offset: 0x00011E50
		[Token(Token = "0x170005CE")]
		public bool ShouldFloatInWater
		{
			[Token(Token = "0x60028EE")]
			[Address(RVA = "0x149EF14", Offset = "0x149EF14", VA = "0x149EF14")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170005CF RID: 1487
		// (get) Token: 0x060028EF RID: 10479 RVA: 0x00013C68 File Offset: 0x00011E68
		[Token(Token = "0x170005CF")]
		public bool CanBeTalkedTo
		{
			[Token(Token = "0x60028EF")]
			[Address(RVA = "0x149EF80", Offset = "0x149EF80", VA = "0x149EF80")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170005D0 RID: 1488
		// (get) Token: 0x060028F0 RID: 10480 RVA: 0x00013C80 File Offset: 0x00011E80
		// (set) Token: 0x060028F1 RID: 10481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005D0")]
		public bool IsVoidVaultEnabled
		{
			[Token(Token = "0x60028F0")]
			[Address(RVA = "0x149F02C", Offset = "0x149F02C", VA = "0x149F02C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60028F1")]
			[Address(RVA = "0x149F040", Offset = "0x149F040", VA = "0x149F040")]
			set
			{
			}
		}

		// Token: 0x170005D1 RID: 1489
		// (get) Token: 0x060028F2 RID: 10482 RVA: 0x00013C98 File Offset: 0x00011E98
		[Token(Token = "0x170005D1")]
		public Vector2 ReportedCameraPosition
		{
			[Token(Token = "0x60028F2")]
			[Address(RVA = "0x149F058", Offset = "0x149F058", VA = "0x149F058")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x170005D2 RID: 1490
		// (get) Token: 0x060028F3 RID: 10483 RVA: 0x00013CB0 File Offset: 0x00011EB0
		[Token(Token = "0x170005D2")]
		public bool TryingToHoverUp
		{
			[Token(Token = "0x60028F3")]
			[Address(RVA = "0x149F0F0", Offset = "0x149F0F0", VA = "0x149F0F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170005D3 RID: 1491
		// (get) Token: 0x060028F4 RID: 10484 RVA: 0x00013CC8 File Offset: 0x00011EC8
		[Token(Token = "0x170005D3")]
		public bool TryingToHoverDown
		{
			[Token(Token = "0x60028F4")]
			[Address(RVA = "0x149F114", Offset = "0x149F114", VA = "0x149F114")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170005D4 RID: 1492
		// (get) Token: 0x060028F5 RID: 10485 RVA: 0x00013CE0 File Offset: 0x00011EE0
		[Token(Token = "0x170005D4")]
		public Vector2 DefaultSize
		{
			[Token(Token = "0x60028F5")]
			[Address(RVA = "0x149F138", Offset = "0x149F138", VA = "0x149F138")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x060028F6 RID: 10486 RVA: 0x00013CF8 File Offset: 0x00011EF8
		[Token(Token = "0x60028F6")]
		[Address(RVA = "0x149F164", Offset = "0x149F164", VA = "0x149F164")]
		public EntityShadowInfo GetAdvancedShadow(int shadowIndex)
		{
			return default(EntityShadowInfo);
		}

		// Token: 0x060028F7 RID: 10487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028F7")]
		[Address(RVA = "0x149F214", Offset = "0x149F214", VA = "0x149F214")]
		public void UpdateAdvancedShadows()
		{
		}

		// Token: 0x060028F8 RID: 10488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028F8")]
		[Address(RVA = "0x149F26C", Offset = "0x149F26C", VA = "0x149F26C")]
		public void ResetAdvancedShadows()
		{
		}

		// Token: 0x060028F9 RID: 10489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028F9")]
		[Address(RVA = "0x149F278", Offset = "0x149F278", VA = "0x149F278")]
		public void SetCompositeArmFront(bool enabled, Player.CompositeArmStretchAmount stretch, float rotation)
		{
		}

		// Token: 0x060028FA RID: 10490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028FA")]
		[Address(RVA = "0x149F2E8", Offset = "0x149F2E8", VA = "0x149F2E8")]
		public void SetCompositeArmBack(bool enabled, Player.CompositeArmStretchAmount stretch, float rotation)
		{
		}

		// Token: 0x060028FB RID: 10491 RVA: 0x00013D10 File Offset: 0x00011F10
		[Token(Token = "0x60028FB")]
		[Address(RVA = "0x149F354", Offset = "0x149F354", VA = "0x149F354")]
		public int GetArmorPenetration(bool melee)
		{
			return 0;
		}

		// Token: 0x170005D5 RID: 1493
		// (get) Token: 0x060028FC RID: 10492 RVA: 0x00013D28 File Offset: 0x00011F28
		// (set) Token: 0x060028FD RID: 10493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005D5")]
		public bool UsingBiomeTorches
		{
			[Token(Token = "0x60028FC")]
			[Address(RVA = "0x149F36C", Offset = "0x149F36C", VA = "0x149F36C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60028FD")]
			[Address(RVA = "0x149F3A4", Offset = "0x149F3A4", VA = "0x149F3A4")]
			set
			{
			}
		}

		// Token: 0x170005D6 RID: 1494
		// (get) Token: 0x060028FE RID: 10494 RVA: 0x00013D40 File Offset: 0x00011F40
		// (set) Token: 0x060028FF RID: 10495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005D6")]
		public bool UsingSuperCart
		{
			[Token(Token = "0x60028FE")]
			[Address(RVA = "0x149F3CC", Offset = "0x149F3CC", VA = "0x149F3CC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60028FF")]
			[Address(RVA = "0x149F3EC", Offset = "0x149F3EC", VA = "0x149F3EC")]
			set
			{
			}
		}

		// Token: 0x170005D7 RID: 1495
		// (get) Token: 0x06002900 RID: 10496 RVA: 0x00013D58 File Offset: 0x00011F58
		[Token(Token = "0x170005D7")]
		public float bowEffectiveDamage
		{
			[Token(Token = "0x6002900")]
			[Address(RVA = "0x149F3F4", Offset = "0x149F3F4", VA = "0x149F3F4")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170005D8 RID: 1496
		// (get) Token: 0x06002901 RID: 10497 RVA: 0x00013D70 File Offset: 0x00011F70
		[Token(Token = "0x170005D8")]
		public float gunEffectiveDamage
		{
			[Token(Token = "0x6002901")]
			[Address(RVA = "0x149F424", Offset = "0x149F424", VA = "0x149F424")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170005D9 RID: 1497
		// (get) Token: 0x06002902 RID: 10498 RVA: 0x00013D88 File Offset: 0x00011F88
		[Token(Token = "0x170005D9")]
		public float specialistEffectiveDamage
		{
			[Token(Token = "0x6002902")]
			[Address(RVA = "0x149F440", Offset = "0x149F440", VA = "0x149F440")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170005DA RID: 1498
		// (get) Token: 0x06002903 RID: 10499 RVA: 0x00013DA0 File Offset: 0x00011FA0
		[Token(Token = "0x170005DA")]
		public bool CanUseBootFlyingAbilities
		{
			[Token(Token = "0x6002903")]
			[Address(RVA = "0x149F45C", Offset = "0x149F45C", VA = "0x149F45C")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170005DB RID: 1499
		// (get) Token: 0x06002904 RID: 10500 RVA: 0x00013DB8 File Offset: 0x00011FB8
		[Token(Token = "0x170005DB")]
		public bool CanUseWingAbilities
		{
			[Token(Token = "0x6002904")]
			[Address(RVA = "0x149F46C", Offset = "0x149F46C", VA = "0x149F46C")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170005DC RID: 1500
		// (get) Token: 0x06002905 RID: 10501 RVA: 0x00013DD0 File Offset: 0x00011FD0
		[Token(Token = "0x170005DC")]
		public bool ShouldNotDraw
		{
			[Token(Token = "0x6002905")]
			[Address(RVA = "0x149EFF8", Offset = "0x149EFF8", VA = "0x149EFF8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170005DD RID: 1501
		// (get) Token: 0x06002906 RID: 10502 RVA: 0x00013DE8 File Offset: 0x00011FE8
		[Token(Token = "0x170005DD")]
		public bool isLockedToATile
		{
			[Token(Token = "0x6002906")]
			[Address(RVA = "0x149F48C", Offset = "0x149F48C", VA = "0x149F48C")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06002907 RID: 10503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002907")]
		[Address(RVA = "0x149F4B0", Offset = "0x149F4B0", VA = "0x149F4B0")]
		public void SetTalkNPC(int npcIndex)
		{
		}

		// Token: 0x170005DE RID: 1502
		// (get) Token: 0x06002908 RID: 10504 RVA: 0x00013E00 File Offset: 0x00012000
		[Token(Token = "0x170005DE")]
		public bool PortalPhysicsEnabled
		{
			[Token(Token = "0x6002908")]
			[Address(RVA = "0x149F9E0", Offset = "0x149F9E0", VA = "0x149F9E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170005DF RID: 1503
		// (get) Token: 0x06002909 RID: 10505 RVA: 0x00013E18 File Offset: 0x00012018
		[Token(Token = "0x170005DF")]
		public bool MountFishronSpecial
		{
			[Token(Token = "0x6002909")]
			[Address(RVA = "0x149FA18", Offset = "0x149FA18", VA = "0x149FA18")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170005E0 RID: 1504
		// (get) Token: 0x0600290A RID: 10506 RVA: 0x00013E30 File Offset: 0x00012030
		[Token(Token = "0x170005E0")]
		public bool HasMinionRestTarget
		{
			[Token(Token = "0x600290A")]
			[Address(RVA = "0x149FB54", Offset = "0x149FB54", VA = "0x149FB54")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170005E1 RID: 1505
		// (get) Token: 0x0600290B RID: 10507 RVA: 0x00013E48 File Offset: 0x00012048
		[Token(Token = "0x170005E1")]
		public bool HasMinionAttackTargetNPC
		{
			[Token(Token = "0x600290B")]
			[Address(RVA = "0x149FC24", Offset = "0x149FC24", VA = "0x149FC24")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170005E2 RID: 1506
		// (get) Token: 0x0600290C RID: 10508 RVA: 0x00013E60 File Offset: 0x00012060
		[Token(Token = "0x170005E2")]
		public bool ItemTimeIsZero
		{
			[Token(Token = "0x600290C")]
			[Address(RVA = "0x149FC38", Offset = "0x149FC38", VA = "0x149FC38")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600290D RID: 10509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600290D")]
		[Address(RVA = "0x149FC48", Offset = "0x149FC48", VA = "0x149FC48")]
		public void SetItemTime(int frames)
		{
		}

		// Token: 0x0600290E RID: 10510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600290E")]
		[Address(RVA = "0x149FC54", Offset = "0x149FC54", VA = "0x149FC54")]
		public void ApplyItemTime(Item sItem)
		{
		}

		// Token: 0x0600290F RID: 10511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600290F")]
		[Address(RVA = "0x149FC7C", Offset = "0x149FC7C", VA = "0x149FC7C")]
		public void ApplyItemTime(Item sItem, float multiplier)
		{
		}

		// Token: 0x06002910 RID: 10512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002910")]
		[Address(RVA = "0x149FD48", Offset = "0x149FD48", VA = "0x149FD48")]
		public void SetDummyItemTime(int frames)
		{
		}

		// Token: 0x170005E3 RID: 1507
		// (get) Token: 0x06002911 RID: 10513 RVA: 0x00013E78 File Offset: 0x00012078
		[Token(Token = "0x170005E3")]
		public bool ItemAnimationJustStarted
		{
			[Token(Token = "0x6002911")]
			[Address(RVA = "0x149FD5C", Offset = "0x149FD5C", VA = "0x149FD5C")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170005E4 RID: 1508
		// (get) Token: 0x06002912 RID: 10514 RVA: 0x00013E90 File Offset: 0x00012090
		[Token(Token = "0x170005E4")]
		public bool UsingOrReusingItem
		{
			[Token(Token = "0x6002912")]
			[Address(RVA = "0x149FD78", Offset = "0x149FD78", VA = "0x149FD78")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06002913 RID: 10515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002913")]
		[Address(RVA = "0x149FDB4", Offset = "0x149FDB4", VA = "0x149FDB4")]
		public void SetItemAnimation(int frames)
		{
		}

		// Token: 0x06002914 RID: 10516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002914")]
		[Address(RVA = "0x149FDC0", Offset = "0x149FDC0", VA = "0x149FDC0")]
		private void SetItemAnimation(int baseFrames, float multiplier)
		{
		}

		// Token: 0x06002915 RID: 10517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002915")]
		[Address(RVA = "0x149FE78", Offset = "0x149FE78", VA = "0x149FE78")]
		private void ApplyItemAnimation(Item sItem)
		{
		}

		// Token: 0x06002916 RID: 10518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002916")]
		[Address(RVA = "0x14A024C", Offset = "0x14A024C", VA = "0x14A024C")]
		public void MatchItemTimeToItemAnimation()
		{
		}

		// Token: 0x06002917 RID: 10519 RVA: 0x00013EA8 File Offset: 0x000120A8
		[Token(Token = "0x6002917")]
		[Address(RVA = "0x14A0258", Offset = "0x14A0258", VA = "0x14A0258")]
		public bool InOpposingTeam(Player otherPlayer)
		{
			return default(bool);
		}

		// Token: 0x06002918 RID: 10520 RVA: 0x00013EC0 File Offset: 0x000120C0
		[Token(Token = "0x6002918")]
		[Address(RVA = "0x14A02B8", Offset = "0x14A02B8", VA = "0x14A02B8")]
		public bool TeamChangeAllowed()
		{
			return default(bool);
		}

		// Token: 0x06002919 RID: 10521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002919")]
		[Address(RVA = "0x14A02C0", Offset = "0x14A02C0", VA = "0x14A02C0")]
		public void HealEffect(int healAmount, bool broadcast = true)
		{
		}

		// Token: 0x0600291A RID: 10522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600291A")]
		[Address(RVA = "0x14A0490", Offset = "0x14A0490", VA = "0x14A0490")]
		public void ManaEffect(int manaAmount)
		{
		}

		// Token: 0x0600291B RID: 10523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600291B")]
		[Address(RVA = "0x14A0654", Offset = "0x14A0654", VA = "0x14A0654")]
		public void InterruptItemUsageIfOverTile(int tileTypeToBeOver)
		{
		}

		// Token: 0x0600291C RID: 10524 RVA: 0x00013ED8 File Offset: 0x000120D8
		[Token(Token = "0x600291C")]
		[Address(RVA = "0x14A0910", Offset = "0x14A0910", VA = "0x14A0910")]
		public Vector2 GetHairDrawOffset(int hairID, bool hatHair)
		{
			return default(Vector2);
		}

		// Token: 0x0600291D RID: 10525 RVA: 0x00013EF0 File Offset: 0x000120F0
		[Token(Token = "0x600291D")]
		[Address(RVA = "0x14A0A88", Offset = "0x14A0A88", VA = "0x14A0A88")]
		public Vector2 GetFaceDrawOffset(int faceToCheck)
		{
			return default(Vector2);
		}

		// Token: 0x0600291E RID: 10526 RVA: 0x00013F08 File Offset: 0x00012108
		[Token(Token = "0x600291E")]
		[Address(RVA = "0x14A0F54", Offset = "0x14A0F54", VA = "0x14A0F54")]
		public Vector2 GetHelmetDrawOffset(bool minimap = false)
		{
			return default(Vector2);
		}

		// Token: 0x0600291F RID: 10527 RVA: 0x00013F20 File Offset: 0x00012120
		[Token(Token = "0x600291F")]
		[Address(RVA = "0x14A12AC", Offset = "0x14A12AC", VA = "0x14A12AC")]
		public Vector2 GetHelmetOffsetAddonFromFaceHead()
		{
			return default(Vector2);
		}

		// Token: 0x06002920 RID: 10528 RVA: 0x00013F38 File Offset: 0x00012138
		[Token(Token = "0x6002920")]
		[Address(RVA = "0x14A15A0", Offset = "0x14A15A0", VA = "0x14A15A0")]
		public Vector2 GetHelmetOffsetAddonFromMount()
		{
			return default(Vector2);
		}

		// Token: 0x06002921 RID: 10529 RVA: 0x00013F50 File Offset: 0x00012150
		[Token(Token = "0x6002921")]
		[Address(RVA = "0x14A1B08", Offset = "0x14A1B08", VA = "0x14A1B08")]
		public Vector2 GetBeardDrawOffset(bool minimap = false)
		{
			return default(Vector2);
		}

		// Token: 0x06002922 RID: 10530 RVA: 0x00013F68 File Offset: 0x00012168
		[Token(Token = "0x6002922")]
		[Address(RVA = "0x14A1BF8", Offset = "0x14A1BF8", VA = "0x14A1BF8")]
		public Vector2 GetBeardOffsetAddonFromHelmet(Vector2 beardOffset)
		{
			return default(Vector2);
		}

		// Token: 0x06002923 RID: 10531 RVA: 0x00013F80 File Offset: 0x00012180
		[Token(Token = "0x6002923")]
		[Address(RVA = "0x14A1E84", Offset = "0x14A1E84", VA = "0x14A1E84")]
		public Vector2 GetBeardOffsetAddonFromMount(Vector2 beardOffset)
		{
			return default(Vector2);
		}

		// Token: 0x06002924 RID: 10532 RVA: 0x00013F98 File Offset: 0x00012198
		[Token(Token = "0x6002924")]
		[Address(RVA = "0x14A20E4", Offset = "0x14A20E4", VA = "0x14A20E4")]
		public Vector2 GetFaceHeadOffsetFromHelmet()
		{
			return default(Vector2);
		}

		// Token: 0x06002925 RID: 10533 RVA: 0x00013FB0 File Offset: 0x000121B0
		[Token(Token = "0x6002925")]
		[Address(RVA = "0x14A22A8", Offset = "0x14A22A8", VA = "0x14A22A8")]
		public Vector2 GetFrontDrawOffset()
		{
			return default(Vector2);
		}

		// Token: 0x06002926 RID: 10534 RVA: 0x00013FC8 File Offset: 0x000121C8
		[Token(Token = "0x6002926")]
		[Address(RVA = "0x14A23F4", Offset = "0x14A23F4", VA = "0x14A23F4")]
		public Vector2 GetLegsDrawOffset()
		{
			return default(Vector2);
		}

		// Token: 0x06002927 RID: 10535 RVA: 0x00013FE0 File Offset: 0x000121E0
		[Token(Token = "0x6002927")]
		[Address(RVA = "0x14A2544", Offset = "0x14A2544", VA = "0x14A2544")]
		public Vector2 GetShoeDrawOffset()
		{
			return default(Vector2);
		}

		// Token: 0x06002928 RID: 10536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002928")]
		[Address(RVA = "0x14A2698", Offset = "0x14A2698", VA = "0x14A2698")]
		public void AccumulateGolfingScore(int score)
		{
		}

		// Token: 0x06002929 RID: 10537 RVA: 0x00013FF8 File Offset: 0x000121F8
		[Token(Token = "0x6002929")]
		[Address(RVA = "0x14A26C4", Offset = "0x14A26C4", VA = "0x14A26C4")]
		public static byte FindClosest(Vector2 Position, int Width, int Height)
		{
			return 0;
		}

		// Token: 0x0600292A RID: 10538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600292A")]
		[Address(RVA = "0x14A2A7C", Offset = "0x14A2A7C", VA = "0x14A2A7C")]
		public void ToggleInv()
		{
		}

		// Token: 0x0600292B RID: 10539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600292B")]
		[Address(RVA = "0x14A3328", Offset = "0x14A3328", VA = "0x14A3328")]
		public static void OpenInventory(bool quiet = false)
		{
		}

		// Token: 0x0600292C RID: 10540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600292C")]
		[Address(RVA = "0x14A3414", Offset = "0x14A3414", VA = "0x14A3414")]
		public void CheckClearMouseItemSource()
		{
		}

		// Token: 0x0600292D RID: 10541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600292D")]
		[Address(RVA = "0x14A3884", Offset = "0x14A3884", VA = "0x14A3884")]
		public void dropItemCheck()
		{
		}

		// Token: 0x0600292E RID: 10542 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600292E")]
		[Address(RVA = "0x14A68B8", Offset = "0x14A68B8", VA = "0x14A68B8")]
		public void DropSelectedItem()
		{
		}

		// Token: 0x0600292F RID: 10543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600292F")]
		[Address(RVA = "0x14A7270", Offset = "0x14A7270", VA = "0x14A7270")]
		public void PlayDroppedItemAnimation(int time)
		{
		}

		// Token: 0x06002930 RID: 10544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002930")]
		[Address(RVA = "0x14A5F30", Offset = "0x14A5F30", VA = "0x14A5F30")]
		public void DropSelectedItem_InterruptActionsThatUseAnimations()
		{
		}

		// Token: 0x06002931 RID: 10545 RVA: 0x00014010 File Offset: 0x00012210
		[Token(Token = "0x6002931")]
		[Address(RVA = "0x14A728C", Offset = "0x14A728C", VA = "0x14A728C")]
		public int FindBuffIndex(int type)
		{
			return 0;
		}

		// Token: 0x06002932 RID: 10546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002932")]
		[Address(RVA = "0x14A7318", Offset = "0x14A7318", VA = "0x14A7318")]
		public void AddBuff(int type, int time, bool fromNetPvP = false)
		{
		}

		// Token: 0x06002933 RID: 10547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002933")]
		[Address(RVA = "0x14A7D30", Offset = "0x14A7D30", VA = "0x14A7D30")]
		private void AddBuff_ReduceTimeOfRelatedBuffs(int type)
		{
		}

		// Token: 0x06002934 RID: 10548 RVA: 0x00014028 File Offset: 0x00012228
		[Token(Token = "0x6002934")]
		[Address(RVA = "0x14A7E30", Offset = "0x14A7E30", VA = "0x14A7E30")]
		private bool AddBuff_ActuallyTryToAddTheBuff(int type, int time)
		{
			return default(bool);
		}

		// Token: 0x06002935 RID: 10549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002935")]
		[Address(RVA = "0x14A7C0C", Offset = "0x14A7C0C", VA = "0x14A7C0C")]
		private void AddBuff_RemoveOldMeleeBuffsOfMatchingType(int type)
		{
		}

		// Token: 0x06002936 RID: 10550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002936")]
		[Address(RVA = "0x14A7A60", Offset = "0x14A7A60", VA = "0x14A7A60")]
		private void AddBuff_RemoveOldPetBuffsOfMatchingType(int type)
		{
		}

		// Token: 0x06002937 RID: 10551 RVA: 0x00014040 File Offset: 0x00012240
		[Token(Token = "0x6002937")]
		[Address(RVA = "0x14A791C", Offset = "0x14A791C", VA = "0x14A791C")]
		private bool AddBuff_TryUpdatingExistingBuffTime(int type, int time)
		{
			return default(bool);
		}

		// Token: 0x06002938 RID: 10552 RVA: 0x00014058 File Offset: 0x00012258
		[Token(Token = "0x6002938")]
		[Address(RVA = "0x14A76F4", Offset = "0x14A76F4", VA = "0x14A76F4")]
		private int AddBuff_DetermineBuffTimeToAdd(int type, int time)
		{
			return 0;
		}

		// Token: 0x06002939 RID: 10553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002939")]
		[Address(RVA = "0x14A75DC", Offset = "0x14A75DC", VA = "0x14A75DC")]
		public void DelBuff(int b)
		{
		}

		// Token: 0x0600293A RID: 10554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600293A")]
		[Address(RVA = "0x14A7F64", Offset = "0x14A7F64", VA = "0x14A7F64")]
		public void ClearBuff(int type)
		{
		}

		// Token: 0x0600293B RID: 10555 RVA: 0x00014070 File Offset: 0x00012270
		[Token(Token = "0x600293B")]
		[Address(RVA = "0x14A7FB8", Offset = "0x14A7FB8", VA = "0x14A7FB8")]
		public int CountBuffs()
		{
			return 0;
		}

		// Token: 0x0600293C RID: 10556 RVA: 0x00014088 File Offset: 0x00012288
		[Token(Token = "0x600293C")]
		[Address(RVA = "0x14A8000", Offset = "0x14A8000", VA = "0x14A8000")]
		public bool CanConsumeConsumableItem(Item item)
		{
			return default(bool);
		}

		// Token: 0x0600293D RID: 10557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600293D")]
		[Address(RVA = "0x14A8008", Offset = "0x14A8008", VA = "0x14A8008")]
		public void QuickHeal()
		{
		}

		// Token: 0x0600293E RID: 10558 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600293E")]
		[Address(RVA = "0x14A8274", Offset = "0x14A8274", VA = "0x14A8274")]
		public Item QuickHeal_GetItemToUse()
		{
			return null;
		}

		// Token: 0x0600293F RID: 10559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600293F")]
		[Address(RVA = "0x14A8C20", Offset = "0x14A8C20", VA = "0x14A8C20")]
		private static void QuickHeal_GetItemToUse_TryChoosingItem(int lifeDifference, ref Item bestItem, ref int bestDifference, Item nextItem)
		{
		}

		// Token: 0x06002940 RID: 10560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002940")]
		[Address(RVA = "0x14A8D50", Offset = "0x14A8D50", VA = "0x14A8D50")]
		public void QuickMana()
		{
		}

		// Token: 0x06002941 RID: 10561 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002941")]
		[Address(RVA = "0x14A8F2C", Offset = "0x14A8F2C", VA = "0x14A8F2C")]
		public Item QuickMana_GetItemToUse()
		{
			return null;
		}

		// Token: 0x06002942 RID: 10562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002942")]
		[Address(RVA = "0x14A9200", Offset = "0x14A9200", VA = "0x14A9200")]
		public void TrySwitchingToNextLoadout()
		{
		}

		// Token: 0x06002943 RID: 10563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002943")]
		[Address(RVA = "0x14A95EC", Offset = "0x14A95EC", VA = "0x14A95EC")]
		public void TrySwitchingToPreviousLoadout()
		{
		}

		// Token: 0x06002944 RID: 10564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002944")]
		[Address(RVA = "0x14A9234", Offset = "0x14A9234", VA = "0x14A9234")]
		public void TrySwitchingLoadout(int loadoutIndex)
		{
		}

		// Token: 0x06002945 RID: 10565 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002945")]
		[Address(RVA = "0x14A9918", Offset = "0x14A9918", VA = "0x14A9918")]
		public Item GetEffectiveArmor(int slot)
		{
			return null;
		}

		// Token: 0x06002946 RID: 10566 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002946")]
		[Address(RVA = "0x14A993C", Offset = "0x14A993C", VA = "0x14A993C")]
		public Item GetEffectiveArmor(int slot, out int? sharedFromLoadout)
		{
			return null;
		}

		// Token: 0x06002947 RID: 10567 RVA: 0x000140A0 File Offset: 0x000122A0
		[Token(Token = "0x6002947")]
		[Address(RVA = "0x14A9B50", Offset = "0x14A9B50", VA = "0x14A9B50")]
		private bool CanShareArmor(Item shareItem, int slot)
		{
			return default(bool);
		}

		// Token: 0x06002948 RID: 10568 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002948")]
		[Address(RVA = "0x14A9D48", Offset = "0x14A9D48", VA = "0x14A9D48")]
		public Item GetEffectiveDye(int slot)
		{
			return null;
		}

		// Token: 0x06002949 RID: 10569 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002949")]
		[Address(RVA = "0x14A9D6C", Offset = "0x14A9D6C", VA = "0x14A9D6C")]
		public Item GetEffectiveDye(int slot, out int? sharedFromLoadout)
		{
			return null;
		}

		// Token: 0x0600294A RID: 10570 RVA: 0x000140B8 File Offset: 0x000122B8
		[Token(Token = "0x600294A")]
		[Address(RVA = "0x14A9EEC", Offset = "0x14A9EEC", VA = "0x14A9EEC")]
		public bool GetHasAvailableBuff()
		{
			return default(bool);
		}

		// Token: 0x0600294B RID: 10571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600294B")]
		[Address(RVA = "0x14AA694", Offset = "0x14AA694", VA = "0x14AA694")]
		public void QuickBuff()
		{
		}

		// Token: 0x0600294C RID: 10572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600294C")]
		[Address(RVA = "0x14AAF88", Offset = "0x14AAF88", VA = "0x14AAF88")]
		private void QuickBuff_UseItemForBuff(Item item, int btype)
		{
		}

		// Token: 0x0600294D RID: 10573 RVA: 0x000140D0 File Offset: 0x000122D0
		[Token(Token = "0x600294D")]
		[Address(RVA = "0x14AA420", Offset = "0x14AA420", VA = "0x14AA420")]
		private bool QuickBuff_CanUseItem(Item item, out int btype)
		{
			return default(bool);
		}

		// Token: 0x0600294E RID: 10574 RVA: 0x000140E8 File Offset: 0x000122E8
		[Token(Token = "0x600294E")]
		[Address(RVA = "0x14AAC50", Offset = "0x14AAC50", VA = "0x14AAC50")]
		private bool QuickBuff_ShouldUseItem(Item item, out int btype)
		{
			return default(bool);
		}

		// Token: 0x0600294F RID: 10575 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600294F")]
		[Address(RVA = "0x14AA150", Offset = "0x14AA150", VA = "0x14AA150")]
		private Item QuickBuff_PickBestFoodItem()
		{
			return null;
		}

		// Token: 0x06002950 RID: 10576 RVA: 0x00014100 File Offset: 0x00012300
		[Token(Token = "0x6002950")]
		[Address(RVA = "0x14ACDD8", Offset = "0x14ACDD8", VA = "0x14ACDD8")]
		private int QuickBuff_FindFoodPriority(int buffType)
		{
			return 0;
		}

		// Token: 0x06002951 RID: 10577 RVA: 0x00014118 File Offset: 0x00012318
		[Token(Token = "0x6002951")]
		[Address(RVA = "0x14AC920", Offset = "0x14AC920", VA = "0x14AC920")]
		private bool QuickBuff_ShouldBotherUsingThisBuff(int attemptedType)
		{
			return default(bool);
		}

		// Token: 0x06002952 RID: 10578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002952")]
		[Address(RVA = "0x14ACE00", Offset = "0x14ACE00", VA = "0x14ACE00")]
		public void PlayerNoSpaceTeleport()
		{
		}

		// Token: 0x06002953 RID: 10579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002953")]
		[Address(RVA = "0x14ADB9C", Offset = "0x14ADB9C", VA = "0x14ADB9C")]
		private void UpdateFailedDismount()
		{
		}

		// Token: 0x06002954 RID: 10580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002954")]
		[Address(RVA = "0x14ADCC0", Offset = "0x14ADCC0", VA = "0x14ADCC0")]
		public void QuickMount()
		{
		}

		// Token: 0x06002955 RID: 10581 RVA: 0x00014130 File Offset: 0x00012330
		[Token(Token = "0x6002955")]
		[Address(RVA = "0x14AF490", Offset = "0x14AF490", VA = "0x14AF490")]
		public bool CanFitSpace(int heightBoost)
		{
			return default(bool);
		}

		// Token: 0x06002956 RID: 10582 RVA: 0x00014148 File Offset: 0x00012348
		[Token(Token = "0x6002956")]
		[Address(RVA = "0x14AF5E4", Offset = "0x14AF5E4", VA = "0x14AF5E4")]
		public bool CanFitInSpaceWithSize(Vector2 size, [Optional] Vector2 offset)
		{
			return default(bool);
		}

		// Token: 0x06002957 RID: 10583 RVA: 0x00014160 File Offset: 0x00012360
		[Token(Token = "0x6002957")]
		[Address(RVA = "0x14AF79C", Offset = "0x14AF79C", VA = "0x14AF79C")]
		public bool UseQuickMineCartHook()
		{
			return default(bool);
		}

		// Token: 0x06002958 RID: 10584 RVA: 0x00014178 File Offset: 0x00012378
		[Token(Token = "0x6002958")]
		[Address(RVA = "0x14AFF48", Offset = "0x14AFF48", VA = "0x14AFF48")]
		public bool UseQuickMineCartSnapHook()
		{
			return default(bool);
		}

		// Token: 0x06002959 RID: 10585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002959")]
		[Address(RVA = "0x14AEB98", Offset = "0x14AEB98", VA = "0x14AEB98")]
		private void QuickMinecart()
		{
		}

		// Token: 0x0600295A RID: 10586 RVA: 0x00014190 File Offset: 0x00012390
		[Token(Token = "0x600295A")]
		[Address(RVA = "0x14AE2EC", Offset = "0x14AE2EC", VA = "0x14AE2EC")]
		private bool QuickMinecartSnap()
		{
			return default(bool);
		}

		// Token: 0x0600295B RID: 10587 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600295B")]
		[Address(RVA = "0x14AE124", Offset = "0x14AE124", VA = "0x14AE124")]
		public Item QuickMount_GetItemToUse()
		{
			return null;
		}

		// Token: 0x0600295C RID: 10588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600295C")]
		[Address(RVA = "0x14B06C0", Offset = "0x14B06C0", VA = "0x14B06C0")]
		public void ClearGrapplingBlacklist()
		{
		}

		// Token: 0x0600295D RID: 10589 RVA: 0x000141A8 File Offset: 0x000123A8
		[Token(Token = "0x600295D")]
		[Address(RVA = "0x14B0724", Offset = "0x14B0724", VA = "0x14B0724")]
		public bool IsBlacklistedForGrappling(Point p)
		{
			return default(bool);
		}

		// Token: 0x0600295E RID: 10590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600295E")]
		[Address(RVA = "0x14B0798", Offset = "0x14B0798", VA = "0x14B0798")]
		public void UpdateBlacklistedTilesForGrappling()
		{
		}

		// Token: 0x0600295F RID: 10591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600295F")]
		[Address(RVA = "0x14B1050", Offset = "0x14B1050", VA = "0x14B1050")]
		private void FireGrapple(Item grappleItem)
		{
		}

		// Token: 0x06002960 RID: 10592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002960")]
		[Address(RVA = "0x14B1B18", Offset = "0x14B1B18", VA = "0x14B1B18")]
		public void GetPanControlValues(out float panFactor, out bool needsMouseRight)
		{
		}

		// Token: 0x06002961 RID: 10593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002961")]
		[Address(RVA = "0x14B1C10", Offset = "0x14B1C10", VA = "0x14B1C10")]
		public void QuickGrapple()
		{
		}

		// Token: 0x06002962 RID: 10594 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002962")]
		[Address(RVA = "0x14B1E44", Offset = "0x14B1E44", VA = "0x14B1E44")]
		public Item QuickGrapple_GetItemToUse()
		{
			return null;
		}

		// Token: 0x06002963 RID: 10595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002963")]
		[Address(RVA = "0x14B1FA0", Offset = "0x14B1FA0", VA = "0x14B1FA0")]
		public void StatusToNPC(int type, int i)
		{
		}

		// Token: 0x06002964 RID: 10596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002964")]
		[Address(RVA = "0x14B2D5C", Offset = "0x14B2D5C", VA = "0x14B2D5C")]
		public void StatusToPlayerPvP(int type, int i)
		{
		}

		// Token: 0x06002965 RID: 10597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002965")]
		[Address(RVA = "0x14B3750", Offset = "0x14B3750", VA = "0x14B3750")]
		public void Ghost()
		{
		}

		// Token: 0x06002966 RID: 10598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002966")]
		[Address(RVA = "0x14B53A4", Offset = "0x14B53A4", VA = "0x14B53A4")]
		private void TrySyncingInput()
		{
		}

		// Token: 0x06002967 RID: 10599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002967")]
		[Address(RVA = "0x14B5698", Offset = "0x14B5698", VA = "0x14B5698")]
		public void OnHit(float x, float y, Entity victim)
		{
		}

		// Token: 0x06002968 RID: 10600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002968")]
		[Address(RVA = "0x14B68A0", Offset = "0x14B68A0", VA = "0x14B68A0")]
		public void OpenPresent(int itemType)
		{
		}

		// Token: 0x06002969 RID: 10601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002969")]
		[Address(RVA = "0x14B739C", Offset = "0x14B739C", VA = "0x14B739C")]
		public void OpenLegacyPresent(int itemType)
		{
		}

		// Token: 0x0600296A RID: 10602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600296A")]
		[Address(RVA = "0x14B7234", Offset = "0x14B7234", VA = "0x14B7234")]
		public void QuickSpawnItem(IEntitySource source, int item, int stack = 1)
		{
		}

		// Token: 0x0600296B RID: 10603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600296B")]
		[Address(RVA = "0x14B7534", Offset = "0x14B7534", VA = "0x14B7534")]
		public void QuickSpawnItem(IEntitySource source, Item item)
		{
		}

		// Token: 0x0600296C RID: 10604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600296C")]
		[Address(RVA = "0x14B75DC", Offset = "0x14B75DC", VA = "0x14B75DC")]
		public void QuickSpawnItem(IEntitySource source, Item item, GetItemSettings settings)
		{
		}

		// Token: 0x0600296D RID: 10605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600296D")]
		[Address(RVA = "0x14B762C", Offset = "0x14B762C", VA = "0x14B762C")]
		public void GetOrDropItem(Item item, GetItemSettings settings)
		{
		}

		// Token: 0x0600296E RID: 10606 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600296E")]
		[Address(RVA = "0x14B782C", Offset = "0x14B782C", VA = "0x14B782C")]
		public void OpenBossBag(int type)
		{
		}

		// Token: 0x0600296F RID: 10607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600296F")]
		[Address(RVA = "0x14BA9F8", Offset = "0x14BA9F8", VA = "0x14BA9F8")]
		private void TryGettingDevArmor(IEntitySource source)
		{
		}

		// Token: 0x06002970 RID: 10608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002970")]
		[Address(RVA = "0x14BB2A0", Offset = "0x14BB2A0", VA = "0x14BB2A0")]
		public void OpenFishingCrate(int crateItemID)
		{
		}

		// Token: 0x06002971 RID: 10609 RVA: 0x000141C0 File Offset: 0x000123C0
		[Token(Token = "0x6002971")]
		[Address(RVA = "0x14BEE7C", Offset = "0x14BEE7C", VA = "0x14BEE7C")]
		public int CountItem(int type, int stopCountingAt = 0)
		{
			return 0;
		}

		// Token: 0x06002972 RID: 10610 RVA: 0x000141D8 File Offset: 0x000123D8
		[Token(Token = "0x6002972")]
		[Address(RVA = "0x14BEF38", Offset = "0x14BEF38", VA = "0x14BEF38")]
		public bool ConsumeItem(int type, bool reverseOrder = false, bool includeVoidBag = false)
		{
			return default(bool);
		}

		// Token: 0x06002973 RID: 10611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002973")]
		[Address(RVA = "0x14BF2DC", Offset = "0x14BF2DC", VA = "0x14BF2DC")]
		public void OpenShadowLockbox(int boxType)
		{
		}

		// Token: 0x06002974 RID: 10612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002974")]
		[Address(RVA = "0x14BF574", Offset = "0x14BF574", VA = "0x14BF574")]
		public void OpenLockBox(int lockboxItemType)
		{
		}

		// Token: 0x06002975 RID: 10613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002975")]
		[Address(RVA = "0x14BF890", Offset = "0x14BF890", VA = "0x14BF890")]
		public void OpenHerbBag(int bagType)
		{
		}

		// Token: 0x06002976 RID: 10614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002976")]
		[Address(RVA = "0x14BFB50", Offset = "0x14BFB50", VA = "0x14BFB50")]
		public void OpenCanofWorms(int sourceItemType)
		{
		}

		// Token: 0x06002977 RID: 10615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002977")]
		[Address(RVA = "0x14BFD44", Offset = "0x14BFD44", VA = "0x14BFD44")]
		public void OpenOyster(int sourceItemType)
		{
		}

		// Token: 0x06002978 RID: 10616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002978")]
		[Address(RVA = "0x14BFEFC", Offset = "0x14BFEFC", VA = "0x14BFEFC")]
		private void QuickSpawnItem_CostumeSet(IEntitySource source, int item1, int item2, int item3)
		{
		}

		// Token: 0x06002979 RID: 10617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002979")]
		[Address(RVA = "0x14BFF48", Offset = "0x14BFF48", VA = "0x14BFF48")]
		private void QuickSpawnItem_CostumeSet(IEntitySource source, int item1, int item2)
		{
		}

		// Token: 0x0600297A RID: 10618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600297A")]
		[Address(RVA = "0x14BFF80", Offset = "0x14BFF80", VA = "0x14BFF80")]
		public void OpenChilletEgg(int itemType)
		{
		}

		// Token: 0x0600297B RID: 10619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600297B")]
		[Address(RVA = "0x14C0094", Offset = "0x14C0094", VA = "0x14C0094")]
		public void OpenGoodieBag(int itemType)
		{
		}

		// Token: 0x0600297C RID: 10620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600297C")]
		[Address(RVA = "0x14C06F0", Offset = "0x14C06F0", VA = "0x14C06F0")]
		public void UpdateDyes()
		{
		}

		// Token: 0x0600297D RID: 10621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600297D")]
		[Address(RVA = "0x14C09BC", Offset = "0x14C09BC", VA = "0x14C09BC")]
		private void UpdateItemDye(bool isNotInVanitySlot, bool isSetToHidden, Item armorItem, Item dyeItem)
		{
		}

		// Token: 0x0600297E RID: 10622 RVA: 0x000141F0 File Offset: 0x000123F0
		[Token(Token = "0x600297E")]
		[Address(RVA = "0x14C136C", Offset = "0x14C136C", VA = "0x14C136C")]
		public int ArmorSetDye()
		{
			return 0;
		}

		// Token: 0x0600297F RID: 10623 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600297F")]
		[Address(RVA = "0x14C1428", Offset = "0x14C1428", VA = "0x14C1428")]
		public IEntitySource GetProjectileSource_Buff(int buffIndex)
		{
			return null;
		}

		// Token: 0x06002980 RID: 10624 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002980")]
		[Address(RVA = "0x14B1A9C", Offset = "0x14B1A9C", VA = "0x14B1A9C")]
		public IEntitySource GetProjectileSource_Item(Item item)
		{
			return null;
		}

		// Token: 0x06002981 RID: 10625 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002981")]
		[Address(RVA = "0x14B71B8", Offset = "0x14B71B8", VA = "0x14B71B8")]
		public IEntitySource GetItemSource_OpenItem(int itemType)
		{
			return null;
		}

		// Token: 0x06002982 RID: 10626 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002982")]
		[Address(RVA = "0x14C14CC", Offset = "0x14C14CC", VA = "0x14C14CC")]
		public IEntitySource GetItemSource_Death()
		{
			return null;
		}

		// Token: 0x06002983 RID: 10627 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002983")]
		[Address(RVA = "0x14B7778", Offset = "0x14B7778", VA = "0x14B7778")]
		public IEntitySource GetItemSource_InventoryOverflow()
		{
			return null;
		}

		// Token: 0x06002984 RID: 10628 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002984")]
		[Address(RVA = "0x14A71F4", Offset = "0x14A71F4", VA = "0x14A71F4")]
		public IEntitySource GetItemSource_Misc(int itemSourceId)
		{
			return null;
		}

		// Token: 0x06002985 RID: 10629 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002985")]
		[Address(RVA = "0x14C1580", Offset = "0x14C1580", VA = "0x14C1580")]
		public IEntitySource GetProjectileSource_Item_WithPotentialAmmo(Item item, int ammoItemId)
		{
			return null;
		}

		// Token: 0x06002986 RID: 10630 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002986")]
		[Address(RVA = "0x14B682C", Offset = "0x14B682C", VA = "0x14B682C")]
		public IEntitySource GetProjectileSource_SetBonus(int projectileSourceId)
		{
			return null;
		}

		// Token: 0x06002987 RID: 10631 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002987")]
		[Address(RVA = "0x14B679C", Offset = "0x14B679C", VA = "0x14B679C")]
		public IEntitySource GetProjectileSource_OnHit(Entity victim, int projectileSourceId)
		{
			return null;
		}

		// Token: 0x06002988 RID: 10632 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002988")]
		[Address(RVA = "0x14C1610", Offset = "0x14C1610", VA = "0x14C1610")]
		public IEntitySource GetProjectileSource_OnHurt(Entity attacker, int projectileSourceId)
		{
			return null;
		}

		// Token: 0x06002989 RID: 10633 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002989")]
		[Address(RVA = "0x14C16A0", Offset = "0x14C16A0", VA = "0x14C16A0")]
		public IEntitySource GetProjectileSource_Accessory(Item item)
		{
			return null;
		}

		// Token: 0x0600298A RID: 10634 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600298A")]
		[Address(RVA = "0x14C171C", Offset = "0x14C171C", VA = "0x14C171C")]
		public IEntitySource GetProjectileSource_Misc(int projectileSourceId)
		{
			return null;
		}

		// Token: 0x0600298B RID: 10635 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600298B")]
		[Address(RVA = "0x14C1790", Offset = "0x14C1790", VA = "0x14C1790")]
		public IEntitySource GetProjectileSource_TileInteraction(int tileCoordsX, int tileCoordsY)
		{
			return null;
		}

		// Token: 0x0600298C RID: 10636 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600298C")]
		[Address(RVA = "0x14C1820", Offset = "0x14C1820", VA = "0x14C1820")]
		public IEntitySource GetItemSource_TileInteraction(int tileCoordsX, int tileCoordsY)
		{
			return null;
		}

		// Token: 0x0600298D RID: 10637 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600298D")]
		[Address(RVA = "0x14C18B0", Offset = "0x14C18B0", VA = "0x14C18B0")]
		public IEntitySource GetNPCSource_TileInteraction(int tileCoordsX, int tileCoordsY)
		{
			return null;
		}

		// Token: 0x0600298E RID: 10638 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600298E")]
		[Address(RVA = "0x14C1940", Offset = "0x14C1940", VA = "0x14C1940")]
		public IEntitySource GetItemSource_OnHit(Entity victim, int itemSourceId)
		{
			return null;
		}

		// Token: 0x0600298F RID: 10639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600298F")]
		[Address(RVA = "0x14C19D0", Offset = "0x14C19D0", VA = "0x14C19D0")]
		public void UpdateBuffs(int i)
		{
		}

		// Token: 0x06002990 RID: 10640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002990")]
		[Address(RVA = "0x14CDC10", Offset = "0x14CDC10", VA = "0x14CDC10")]
		private void UpdateBuffs_NebulaBuffs(ref int nebulaLevel, int baseBuffId, int b)
		{
		}

		// Token: 0x06002991 RID: 10641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002991")]
		[Address(RVA = "0x14A8B30", Offset = "0x14A8B30", VA = "0x14A8B30")]
		public void TryToResetHungerToNeutral()
		{
		}

		// Token: 0x06002992 RID: 10642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002992")]
		[Address(RVA = "0x14CF118", Offset = "0x14CF118", VA = "0x14CF118")]
		public void UpdateHungerBuffs()
		{
		}

		// Token: 0x06002993 RID: 10643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002993")]
		[Address(RVA = "0x14CAD04", Offset = "0x14CAD04", VA = "0x14CAD04")]
		public void UpdateStarvingState(bool withEmote)
		{
		}

		// Token: 0x06002994 RID: 10644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002994")]
		[Address(RVA = "0x14CF454", Offset = "0x14CF454", VA = "0x14CF454")]
		private void UpdateProjectileCaches(int i)
		{
		}

		// Token: 0x06002995 RID: 10645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002995")]
		[Address(RVA = "0x14CF690", Offset = "0x14CF690", VA = "0x14CF690")]
		private void ResetProjectileCaches()
		{
		}

		// Token: 0x06002996 RID: 10646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002996")]
		[Address(RVA = "0x14CEECC", Offset = "0x14CEECC", VA = "0x14CEECC")]
		public void BuffHandle_SpawnPetIfNeededAndSetTime(int buffIndex, ref bool petBool, int petProjID, int buffTimeToGive = 18000)
		{
		}

		// Token: 0x06002997 RID: 10647 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002997")]
		[Address(RVA = "0x14CF6EC", Offset = "0x14CF6EC", VA = "0x14CF6EC")]
		public void BuffHandle_SpawnPetIfNeeded(ref bool petBool, int petProjID, int buffIndex)
		{
		}

		// Token: 0x06002998 RID: 10648 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002998")]
		[Address(RVA = "0x14CF9CC", Offset = "0x14CF9CC", VA = "0x14CF9CC")]
		private Projectile FindNewestAI_164Minion(int type)
		{
			return null;
		}

		// Token: 0x06002999 RID: 10649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002999")]
		[Address(RVA = "0x14CDD48", Offset = "0x14CDD48", VA = "0x14CDD48")]
		private void UpdateAbigailStatus()
		{
		}

		// Token: 0x0600299A RID: 10650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600299A")]
		[Address(RVA = "0x14CDFB0", Offset = "0x14CDFB0", VA = "0x14CDFB0")]
		private void UpdateStormTigerStatus()
		{
		}

		// Token: 0x0600299B RID: 10651 RVA: 0x00014208 File Offset: 0x00012408
		[Token(Token = "0x600299B")]
		[Address(RVA = "0x14CFAE0", Offset = "0x14CFAE0", VA = "0x14CFAE0")]
		private int GetDesiredStormTigerMinionRank()
		{
			return 0;
		}

		// Token: 0x0600299C RID: 10652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600299C")]
		[Address(RVA = "0x14CFB18", Offset = "0x14CFB18", VA = "0x14CFB18")]
		public void Counterweight(Vector2 hitPos, int dmg, float kb)
		{
		}

		// Token: 0x0600299D RID: 10653 RVA: 0x00014220 File Offset: 0x00012420
		[Token(Token = "0x600299D")]
		[Address(RVA = "0x14D01F4", Offset = "0x14D01F4", VA = "0x14D01F4")]
		public int beeType()
		{
			return 0;
		}

		// Token: 0x0600299E RID: 10654 RVA: 0x00014238 File Offset: 0x00012438
		[Token(Token = "0x600299E")]
		[Address(RVA = "0x14D02A8", Offset = "0x14D02A8", VA = "0x14D02A8")]
		public int beeDamage(int dmg)
		{
			return 0;
		}

		// Token: 0x0600299F RID: 10655 RVA: 0x00014250 File Offset: 0x00012450
		[Token(Token = "0x600299F")]
		[Address(RVA = "0x14D0358", Offset = "0x14D0358", VA = "0x14D0358")]
		public float beeKB(float KB)
		{
			return 0f;
		}

		// Token: 0x060029A0 RID: 10656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029A0")]
		[Address(RVA = "0x14D0380", Offset = "0x14D0380", VA = "0x14D0380")]
		public void Yoraiz0rEye()
		{
		}

		// Token: 0x060029A1 RID: 10657 RVA: 0x00014268 File Offset: 0x00012468
		[Token(Token = "0x60029A1")]
		[Address(RVA = "0x149E174", Offset = "0x149E174", VA = "0x149E174")]
		public bool IsItemSlotUnlockedAndUsable(int slot)
		{
			return default(bool);
		}

		// Token: 0x060029A2 RID: 10658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029A2")]
		[Address(RVA = "0x14D1E84", Offset = "0x14D1E84", VA = "0x14D1E84")]
		public void RefreshInfoAccs()
		{
		}

		// Token: 0x060029A3 RID: 10659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029A3")]
		[Address(RVA = "0x14D2BB4", Offset = "0x14D2BB4", VA = "0x14D2BB4")]
		public void RefreshInfoAccsFromTeamPlayers()
		{
		}

		// Token: 0x060029A4 RID: 10660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029A4")]
		[Address(RVA = "0x14D2088", Offset = "0x14D2088", VA = "0x14D2088")]
		public void RefreshInfoAccsFromItemType(int accType)
		{
		}

		// Token: 0x060029A5 RID: 10661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029A5")]
		[Address(RVA = "0x14D33CC", Offset = "0x14D33CC", VA = "0x14D33CC")]
		public void RefreshMechanicalAccsFromItemType(int accType)
		{
		}

		// Token: 0x060029A6 RID: 10662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029A6")]
		[Address(RVA = "0x14D357C", Offset = "0x14D357C", VA = "0x14D357C")]
		public void RefreshAutoKitingFromItemTypeAndSlot(int accType, int slot)
		{
		}

		// Token: 0x060029A7 RID: 10663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029A7")]
		[Address(RVA = "0x14D3614", Offset = "0x14D3614", VA = "0x14D3614")]
		public void UpdatePermanentBoosters()
		{
		}

		// Token: 0x060029A8 RID: 10664 RVA: 0x00014280 File Offset: 0x00012480
		[Token(Token = "0x60029A8")]
		[Address(RVA = "0x14D3684", Offset = "0x14D3684", VA = "0x14D3684")]
		public bool UpdateEquips_CanItemGrantBenefits(int itemSlot, Item item)
		{
			return default(bool);
		}

		// Token: 0x060029A9 RID: 10665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029A9")]
		[Address(RVA = "0x14D3734", Offset = "0x14D3734", VA = "0x14D3734")]
		public void UpdateEquips(int i)
		{
		}

		// Token: 0x060029AA RID: 10666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029AA")]
		[Address(RVA = "0x14D49F0", Offset = "0x14D49F0", VA = "0x14D49F0")]
		private void GrantArmorBenefits(Item armorPiece)
		{
		}

		// Token: 0x060029AB RID: 10667 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029AB")]
		[Address(RVA = "0x14D481C", Offset = "0x14D481C", VA = "0x14D481C")]
		private void GrantPrefixBenefits(Item item)
		{
		}

		// Token: 0x060029AC RID: 10668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029AC")]
		[Address(RVA = "0x14DC720", Offset = "0x14DC720", VA = "0x14DC720")]
		private void SpawnHallucination(Item item)
		{
		}

		// Token: 0x060029AD RID: 10669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029AD")]
		[Address(RVA = "0x14DC5BC", Offset = "0x14DC5BC", VA = "0x14DC5BC")]
		public void DoBootsEffect(Utils.TileActionAttempt theEffectMethod)
		{
		}

		// Token: 0x060029AE RID: 10670 RVA: 0x00014298 File Offset: 0x00012498
		[Token(Token = "0x60029AE")]
		[Address(RVA = "0x14DCDC8", Offset = "0x14DCDC8", VA = "0x14DCDC8")]
		public bool DoBootsEffect_PlaceFlamesOnTile(int X, int Y)
		{
			return default(bool);
		}

		// Token: 0x060029AF RID: 10671 RVA: 0x000142B0 File Offset: 0x000124B0
		[Token(Token = "0x60029AF")]
		[Address(RVA = "0x14DD17C", Offset = "0x14DD17C", VA = "0x14DD17C")]
		public bool DoBootsEffect_PlaceFlowersOnTile(int X, int Y)
		{
			return default(bool);
		}

		// Token: 0x060029B0 RID: 10672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029B0")]
		[Address(RVA = "0x14DBB6C", Offset = "0x14DBB6C", VA = "0x14DBB6C")]
		private void ApplyEquipVanity(int itemSlot, Item currentItem)
		{
		}

		// Token: 0x060029B1 RID: 10673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029B1")]
		[Address(RVA = "0x14DE7A0", Offset = "0x14DE7A0", VA = "0x14DE7A0")]
		public void ApplyShader(int itemType)
		{
		}

		// Token: 0x060029B2 RID: 10674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029B2")]
		[Address(RVA = "0x14DF2A0", Offset = "0x14DF2A0", VA = "0x14DF2A0")]
		private void DoGlassSlipperSparkles()
		{
		}

		// Token: 0x060029B3 RID: 10675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029B3")]
		[Address(RVA = "0x14DBFA4", Offset = "0x14DBFA4", VA = "0x14DBFA4")]
		private void DoEyebrellaRainEffect()
		{
		}

		// Token: 0x060029B4 RID: 10676 RVA: 0x000142C8 File Offset: 0x000124C8
		[Token(Token = "0x60029B4")]
		[Address(RVA = "0x14DFA14", Offset = "0x14DFA14", VA = "0x14DFA14")]
		public WingStats GetWingStats(int wingID)
		{
			return default(WingStats);
		}

		// Token: 0x060029B5 RID: 10677 RVA: 0x000142E0 File Offset: 0x000124E0
		[Token(Token = "0x60029B5")]
		[Address(RVA = "0x14DFB08", Offset = "0x14DFB08", VA = "0x14DFB08")]
		public bool CanUseStressBall()
		{
			return default(bool);
		}

		// Token: 0x060029B6 RID: 10678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029B6")]
		[Address(RVA = "0x14D6D58", Offset = "0x14D6D58", VA = "0x14D6D58")]
		private void ApplyEquipFunctional(int itemSlot, Item currentItem)
		{
		}

		// Token: 0x060029B7 RID: 10679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029B7")]
		[Address(RVA = "0x14E0E7C", Offset = "0x14E0E7C", VA = "0x14E0E7C")]
		private void ApplyWilsonBeard(Item currentItem)
		{
		}

		// Token: 0x060029B8 RID: 10680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029B8")]
		[Address(RVA = "0x14DE8BC", Offset = "0x14DE8BC", VA = "0x14DE8BC")]
		private void ApplyMusicBox(Item currentItem)
		{
		}

		// Token: 0x060029B9 RID: 10681 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029B9")]
		[Address(RVA = "0x14E0FD8", Offset = "0x14E0FD8", VA = "0x14E0FD8")]
		private string GetArmourSetId(string id, [Optional] string formatId)
		{
			return null;
		}

		// Token: 0x060029BA RID: 10682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029BA")]
		[Address(RVA = "0x14E1290", Offset = "0x14E1290", VA = "0x14E1290")]
		public void UpdateArmorSets(int i)
		{
		}

		// Token: 0x060029BB RID: 10683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029BB")]
		[Address(RVA = "0x14E1AF8", Offset = "0x14E1AF8", VA = "0x14E1AF8")]
		private void UpdateArmorSets_Always_Vortex()
		{
		}

		// Token: 0x060029BC RID: 10684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029BC")]
		[Address(RVA = "0x14E1A9C", Offset = "0x14E1A9C", VA = "0x14E1A9C")]
		private void UpdateArmorSets_Always_Chlorophyte()
		{
		}

		// Token: 0x060029BD RID: 10685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029BD")]
		[Address(RVA = "0x14E1994", Offset = "0x14E1994", VA = "0x14E1994")]
		private void UpdateArmorSets_Always_Stardust()
		{
		}

		// Token: 0x060029BE RID: 10686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029BE")]
		[Address(RVA = "0x14E1CAC", Offset = "0x14E1CAC", VA = "0x14E1CAC")]
		public void ApplySetBonus_Stardust()
		{
		}

		// Token: 0x060029BF RID: 10687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029BF")]
		[Address(RVA = "0x14E1980", Offset = "0x14E1980", VA = "0x14E1980")]
		private void UpdateArmorSets_Always_Solar()
		{
		}

		// Token: 0x060029C0 RID: 10688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029C0")]
		[Address(RVA = "0x14E1F38", Offset = "0x14E1F38", VA = "0x14E1F38")]
		public void ApplySetBonus_Solar()
		{
		}

		// Token: 0x060029C1 RID: 10689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029C1")]
		[Address(RVA = "0x14E13D4", Offset = "0x14E13D4", VA = "0x14E13D4")]
		private void UpdateArmorSets_Always_Beetle()
		{
		}

		// Token: 0x060029C2 RID: 10690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029C2")]
		[Address(RVA = "0x14E2620", Offset = "0x14E2620", VA = "0x14E2620")]
		public void ApplySetBonus_BeetleDefense()
		{
		}

		// Token: 0x060029C3 RID: 10691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029C3")]
		[Address(RVA = "0x14E2704", Offset = "0x14E2704", VA = "0x14E2704")]
		public void ApplySetBonus_BeetleDamage()
		{
		}

		// Token: 0x060029C4 RID: 10692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029C4")]
		[Address(RVA = "0x14E28E4", Offset = "0x14E28E4", VA = "0x14E28E4")]
		public void UpdateSocialShadow()
		{
		}

		// Token: 0x060029C5 RID: 10693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029C5")]
		[Address(RVA = "0x14E2CCC", Offset = "0x14E2CCC", VA = "0x14E2CCC")]
		public void UpdateTeleportVisuals()
		{
		}

		// Token: 0x170005E5 RID: 1509
		// (get) Token: 0x060029C6 RID: 10694 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005E5")]
		public static SceneMetrics SceneMetrics
		{
			[Token(Token = "0x60029C6")]
			[Address(RVA = "0x14DBF44", Offset = "0x14DBF44", VA = "0x14DBF44")]
			get
			{
				return null;
			}
		}

		// Token: 0x060029C7 RID: 10695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029C7")]
		[Address(RVA = "0x14E3648", Offset = "0x14E3648", VA = "0x14E3648")]
		public void UpdateBiomesIfMovedEnoughForBlackFade(Vector2 oldPos)
		{
		}

		// Token: 0x060029C8 RID: 10696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029C8")]
		[Address(RVA = "0x14E374C", Offset = "0x14E374C", VA = "0x14E374C")]
		public void UpdateSceneMetrics()
		{
		}

		// Token: 0x060029C9 RID: 10697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029C9")]
		[Address(RVA = "0x14E3868", Offset = "0x14E3868", VA = "0x14E3868")]
		public void UpdateBiomes()
		{
		}

		// Token: 0x060029CA RID: 10698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029CA")]
		[Address(RVA = "0x14E4B7C", Offset = "0x14E4B7C", VA = "0x14E4B7C")]
		private void TrySpawningFaelings()
		{
		}

		// Token: 0x060029CB RID: 10699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029CB")]
		[Address(RVA = "0x14E4C68", Offset = "0x14E4C68", VA = "0x14E4C68")]
		public void GetHairSettings(out bool fullHair, out bool hatHair, out bool hideHair, out bool backHairDraw, out bool drawsBackHairWithoutHeadgear)
		{
		}

		// Token: 0x060029CC RID: 10700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029CC")]
		[Address(RVA = "0x14E5130", Offset = "0x14E5130", VA = "0x14E5130")]
		public void UpdateDead()
		{
		}

		// Token: 0x060029CD RID: 10701 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029CD")]
		[Address(RVA = "0x14E6968", Offset = "0x14E6968", VA = "0x14E6968")]
		private void HandleSpectatingControls()
		{
		}

		// Token: 0x170005E6 RID: 1510
		// (get) Token: 0x060029CE RID: 10702 RVA: 0x000142F8 File Offset: 0x000124F8
		[Token(Token = "0x170005E6")]
		public Vector2 SpectatingCameraPosition
		{
			[Token(Token = "0x60029CE")]
			[Address(RVA = "0x14E696C", Offset = "0x14E696C", VA = "0x14E696C")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x170005E7 RID: 1511
		// (get) Token: 0x060029CF RID: 10703 RVA: 0x00014310 File Offset: 0x00012510
		[Token(Token = "0x170005E7")]
		public bool CanDeathSpectate
		{
			[Token(Token = "0x60029CF")]
			[Address(RVA = "0x14E6AF0", Offset = "0x14E6AF0", VA = "0x14E6AF0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060029D0 RID: 10704 RVA: 0x00014328 File Offset: 0x00012528
		[Token(Token = "0x60029D0")]
		[Address(RVA = "0x14E6B84", Offset = "0x14E6B84", VA = "0x14E6B84")]
		public bool CanSpectate(int who)
		{
			return default(bool);
		}

		// Token: 0x060029D1 RID: 10705 RVA: 0x00014340 File Offset: 0x00012540
		[Token(Token = "0x60029D1")]
		[Address(RVA = "0x14E6CB8", Offset = "0x14E6CB8", VA = "0x14E6CB8")]
		public bool CanWormholeToSpectating()
		{
			return default(bool);
		}

		// Token: 0x060029D2 RID: 10706 RVA: 0x00014358 File Offset: 0x00012558
		[Token(Token = "0x60029D2")]
		[Address(RVA = "0x14E6F3C", Offset = "0x14E6F3C", VA = "0x14E6F3C")]
		public bool AnyoneToSpectate()
		{
			return default(bool);
		}

		// Token: 0x060029D3 RID: 10707 RVA: 0x00014370 File Offset: 0x00012570
		[Token(Token = "0x60029D3")]
		[Address(RVA = "0x14E6F88", Offset = "0x14E6F88", VA = "0x14E6F88")]
		private int ClosestSpectatablePlayerTo(Vector2 pos)
		{
			return 0;
		}

		// Token: 0x060029D4 RID: 10708 RVA: 0x00014388 File Offset: 0x00012588
		[Token(Token = "0x60029D4")]
		[Address(RVA = "0x14E7090", Offset = "0x14E7090", VA = "0x14E7090")]
		private bool SpectateNextPlayer(int step, bool includeSelf)
		{
			return default(bool);
		}

		// Token: 0x060029D5 RID: 10709 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029D5")]
		[Address(RVA = "0x14E73F4", Offset = "0x14E73F4", VA = "0x14E73F4")]
		private void SpectateNextClosestPlayer()
		{
		}

		// Token: 0x060029D6 RID: 10710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029D6")]
		[Address(RVA = "0x14E7188", Offset = "0x14E7188", VA = "0x14E7188")]
		public void SetOrRequestSpectating(int target)
		{
		}

		// Token: 0x060029D7 RID: 10711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029D7")]
		[Address(RVA = "0x14B4EC0", Offset = "0x14B4EC0", VA = "0x14B4EC0")]
		private void TryOpeningInGameOptionsBasedOnInput()
		{
		}

		// Token: 0x060029D8 RID: 10712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029D8")]
		[Address(RVA = "0x14E742C", Offset = "0x14E742C", VA = "0x14E742C")]
		public void UpdatePet(int i)
		{
		}

		// Token: 0x060029D9 RID: 10713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029D9")]
		[Address(RVA = "0x14E76E8", Offset = "0x14E76E8", VA = "0x14E76E8")]
		public void CheckForPetAchievement(int buffID)
		{
		}

		// Token: 0x060029DA RID: 10714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029DA")]
		[Address(RVA = "0x14E78A4", Offset = "0x14E78A4", VA = "0x14E78A4")]
		public void UpdatePetLight(int i)
		{
		}

		// Token: 0x060029DB RID: 10715 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029DB")]
		[Address(RVA = "0x14E7D04", Offset = "0x14E7D04", VA = "0x14E7D04")]
		public void TogglePet()
		{
		}

		// Token: 0x060029DC RID: 10716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029DC")]
		[Address(RVA = "0x14E7DBC", Offset = "0x14E7DBC", VA = "0x14E7DBC")]
		public void ToggleLight()
		{
		}

		// Token: 0x060029DD RID: 10717 RVA: 0x000143A0 File Offset: 0x000125A0
		[Token(Token = "0x60029DD")]
		[Address(RVA = "0x14E7F28", Offset = "0x14E7F28", VA = "0x14E7F28")]
		public bool IsWithinSnappngRangeToTile(int x, int y, int distanceInPixels)
		{
			return default(bool);
		}

		// Token: 0x060029DE RID: 10718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029DE")]
		[Address(RVA = "0x14E806C", Offset = "0x14E806C", VA = "0x14E806C")]
		public void SmartInteractLookup()
		{
		}

		// Token: 0x060029DF RID: 10719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029DF")]
		[Address(RVA = "0x14E84AC", Offset = "0x14E84AC", VA = "0x14E84AC")]
		private void SmartInteractLookup_PrepareCommonlyUsedInfo(out Vector2 mousevec, out int LX, out int HX, out int LY, out int HY)
		{
		}

		// Token: 0x060029E0 RID: 10720 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029E0")]
		[Address(RVA = "0x14E8958", Offset = "0x14E8958", VA = "0x14E8958")]
		public Item SmartItem()
		{
			return null;
		}

		// Token: 0x060029E1 RID: 10721 RVA: 0x000143B8 File Offset: 0x000125B8
		[Token(Token = "0x60029E1")]
		[Address(RVA = "0x14E9B54", Offset = "0x14E9B54", VA = "0x14E9B54")]
		public bool PickItemSelectionOverride(out int selectedSlot)
		{
			return default(bool);
		}

		// Token: 0x060029E2 RID: 10722 RVA: 0x000143D0 File Offset: 0x000125D0
		[Token(Token = "0x60029E2")]
		[Address(RVA = "0x14E9C8C", Offset = "0x14E9C8C", VA = "0x14E9C8C")]
		public bool SmartSelectLookup(out int selectedSlot)
		{
			return default(bool);
		}

		// Token: 0x060029E3 RID: 10723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029E3")]
		[Address(RVA = "0x14E9EF8", Offset = "0x14E9EF8", VA = "0x14E9EF8")]
		private void SmartSelectLookup_GetTargetTile(out int tX, out int tY)
		{
		}

		// Token: 0x060029E4 RID: 10724 RVA: 0x000143E8 File Offset: 0x000125E8
		[Token(Token = "0x60029E4")]
		[Address(RVA = "0x14E93AC", Offset = "0x14E93AC", VA = "0x14E93AC")]
		private int SmartSelect_PickToolForStrategy(int tX, int tY, int toolStrategy, bool wetTile)
		{
			return 0;
		}

		// Token: 0x060029E5 RID: 10725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029E5")]
		[Address(RVA = "0x14E8B68", Offset = "0x14E8B68", VA = "0x14E8B68")]
		private void SmartSelect_GetToolStrategy(int tX, int tY, out int toolStrategy, out bool wetTile)
		{
		}

		// Token: 0x060029E6 RID: 10726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029E6")]
		[Address(RVA = "0x14EA1A0", Offset = "0x14EA1A0", VA = "0x14EA1A0")]
		private void SmartSelect_GetAvailableToolRanges(out int pickRange, out int axeRange, out int hammerRange, out int cannonRange, out int extractItemRange, out int paintScraperRange)
		{
		}

		// Token: 0x060029E7 RID: 10727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029E7")]
		[Address(RVA = "0x14EA678", Offset = "0x14EA678", VA = "0x14EA678")]
		private void EndOngoingTorchGodEvent()
		{
		}

		// Token: 0x060029E8 RID: 10728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029E8")]
		[Address(RVA = "0x14EAB68", Offset = "0x14EAB68", VA = "0x14EAB68")]
		private void TryRecalculatingTorchLuck()
		{
		}

		// Token: 0x060029E9 RID: 10729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029E9")]
		[Address(RVA = "0x14EA778", Offset = "0x14EA778", VA = "0x14EA778")]
		private void RelightTorches()
		{
		}

		// Token: 0x060029EA RID: 10730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029EA")]
		[Address(RVA = "0x14EB440", Offset = "0x14EB440", VA = "0x14EB440")]
		private void TorchAttack()
		{
		}

		// Token: 0x060029EB RID: 10731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029EB")]
		[Address(RVA = "0x14EC658", Offset = "0x14EC658", VA = "0x14EC658")]
		private void UpdateTorchLuck_ConsumeCountersAndCalculate()
		{
		}

		// Token: 0x060029EC RID: 10732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029EC")]
		[Address(RVA = "0x14ECF00", Offset = "0x14ECF00", VA = "0x14ECF00")]
		public void AddCoinLuck(Vector2 coinPosition, int coinAmount)
		{
		}

		// Token: 0x060029ED RID: 10733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029ED")]
		[Address(RVA = "0x14ECFF8", Offset = "0x14ECFF8", VA = "0x14ECFF8")]
		private void UpdateCoinLuck()
		{
		}

		// Token: 0x060029EE RID: 10734 RVA: 0x00014400 File Offset: 0x00012600
		[Token(Token = "0x60029EE")]
		[Address(RVA = "0x14ED108", Offset = "0x14ED108", VA = "0x14ED108")]
		private float CalculateCoinLuck()
		{
			return 0f;
		}

		// Token: 0x170005E8 RID: 1512
		// (get) Token: 0x060029EF RID: 10735 RVA: 0x00014418 File Offset: 0x00012618
		[Token(Token = "0x170005E8")]
		public float NormalizedLuck
		{
			[Token(Token = "0x60029EF")]
			[Address(RVA = "0x14ED220", Offset = "0x14ED220", VA = "0x14ED220")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x060029F0 RID: 10736 RVA: 0x00014430 File Offset: 0x00012630
		[Token(Token = "0x60029F0")]
		[Address(RVA = "0x14ED280", Offset = "0x14ED280", VA = "0x14ED280")]
		private float GetLadyBugLuck()
		{
			return 0f;
		}

		// Token: 0x060029F1 RID: 10737 RVA: 0x00014448 File Offset: 0x00012648
		[Token(Token = "0x60029F1")]
		[Address(RVA = "0x14ED368", Offset = "0x14ED368", VA = "0x14ED368")]
		public static float GetClosestPlayersLuck(Point Position)
		{
			return 0f;
		}

		// Token: 0x060029F2 RID: 10738 RVA: 0x00014460 File Offset: 0x00012660
		[Token(Token = "0x60029F2")]
		[Address(RVA = "0x14ED480", Offset = "0x14ED480", VA = "0x14ED480")]
		public static float GetClosestPlayersLuck(Vector2 Position)
		{
			return 0f;
		}

		// Token: 0x060029F3 RID: 10739 RVA: 0x00014478 File Offset: 0x00012678
		[Token(Token = "0x60029F3")]
		[Address(RVA = "0x14ED564", Offset = "0x14ED564", VA = "0x14ED564")]
		public bool IsThisCenx()
		{
			return default(bool);
		}

		// Token: 0x060029F4 RID: 10740 RVA: 0x00014490 File Offset: 0x00012690
		[Token(Token = "0x60029F4")]
		[Address(RVA = "0x14ED6C0", Offset = "0x14ED6C0", VA = "0x14ED6C0")]
		public int RollLuck(int range)
		{
			return 0;
		}

		// Token: 0x060029F5 RID: 10741 RVA: 0x000144A8 File Offset: 0x000126A8
		[Token(Token = "0x60029F5")]
		[Address(RVA = "0x14ED6CC", Offset = "0x14ED6CC", VA = "0x14ED6CC")]
		public int RollBadLuck(int range)
		{
			return 0;
		}

		// Token: 0x060029F6 RID: 10742 RVA: 0x000144C0 File Offset: 0x000126C0
		[Token(Token = "0x60029F6")]
		[Address(RVA = "0x14ED6D8", Offset = "0x14ED6D8", VA = "0x14ED6D8")]
		public int RollOnlyBadLuck(int range)
		{
			return 0;
		}

		// Token: 0x060029F7 RID: 10743 RVA: 0x000144D8 File Offset: 0x000126D8
		[Token(Token = "0x60029F7")]
		[Address(RVA = "0x14ED6E4", Offset = "0x14ED6E4", VA = "0x14ED6E4")]
		public int RollBadLuckExtreme(int range)
		{
			return 0;
		}

		// Token: 0x060029F8 RID: 10744 RVA: 0x000144F0 File Offset: 0x000126F0
		[Token(Token = "0x60029F8")]
		[Address(RVA = "0x14ED6F0", Offset = "0x14ED6F0", VA = "0x14ED6F0")]
		public int RollOnlyBadLuckExtreme(int range)
		{
			return 0;
		}

		// Token: 0x060029F9 RID: 10745 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029F9")]
		[Address(RVA = "0x14ED6FC", Offset = "0x14ED6FC", VA = "0x14ED6FC")]
		public static Player GetPlayerWithHighestLuck()
		{
			return null;
		}

		// Token: 0x060029FA RID: 10746 RVA: 0x00014508 File Offset: 0x00012708
		[Token(Token = "0x60029FA")]
		[Address(RVA = "0x14EEE64", Offset = "0x14EEE64", VA = "0x14EEE64")]
		public static float GetClosestRollLuck(Vector2 position, int range)
		{
			return 0f;
		}

		// Token: 0x060029FB RID: 10747 RVA: 0x00014520 File Offset: 0x00012720
		[Token(Token = "0x60029FB")]
		[Address(RVA = "0x14EEF64", Offset = "0x14EEF64", VA = "0x14EEF64")]
		public static float GetClosestRollLuck(int x, int y, int range)
		{
			return 0f;
		}

		// Token: 0x060029FC RID: 10748 RVA: 0x00014538 File Offset: 0x00012738
		[Token(Token = "0x60029FC")]
		[Address(RVA = "0x14EF098", Offset = "0x14EF098", VA = "0x14EF098")]
		public static float GetClosestRollBadLuck(Vector2 position, int range)
		{
			return 0f;
		}

		// Token: 0x060029FD RID: 10749 RVA: 0x00014550 File Offset: 0x00012750
		[Token(Token = "0x60029FD")]
		[Address(RVA = "0x14EF198", Offset = "0x14EF198", VA = "0x14EF198")]
		public static float GetClosestRollBadLuck(int x, int y, int range)
		{
			return 0f;
		}

		// Token: 0x060029FE RID: 10750 RVA: 0x00014568 File Offset: 0x00012768
		[Token(Token = "0x60029FE")]
		[Address(RVA = "0x14EF2CC", Offset = "0x14EF2CC", VA = "0x14EF2CC")]
		public int ApplyRapidAttackBonus(int damage, int itemType, bool increaseBonus = false)
		{
			return 0;
		}

		// Token: 0x060029FF RID: 10751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029FF")]
		[Address(RVA = "0x14EF3D0", Offset = "0x14EF3D0", VA = "0x14EF3D0")]
		public void UpdateSlots()
		{
		}

		// Token: 0x06002A00 RID: 10752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A00")]
		[Address(RVA = "0x14B41B0", Offset = "0x14B41B0", VA = "0x14B41B0")]
		public void ResetEffects()
		{
		}

		// Token: 0x06002A01 RID: 10753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A01")]
		[Address(RVA = "0x14EF718", Offset = "0x14EF718", VA = "0x14EF718")]
		private void UpdateLadyBugLuckTime()
		{
		}

		// Token: 0x06002A02 RID: 10754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A02")]
		[Address(RVA = "0x14EF7D8", Offset = "0x14EF7D8", VA = "0x14EF7D8")]
		public void UpdateImmunity()
		{
		}

		// Token: 0x06002A03 RID: 10755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A03")]
		[Address(RVA = "0x14EF8E0", Offset = "0x14EF8E0", VA = "0x14EF8E0")]
		private void TryToPoop()
		{
		}

		// Token: 0x06002A04 RID: 10756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A04")]
		[Address(RVA = "0x14EFE00", Offset = "0x14EFE00", VA = "0x14EFE00")]
		public void UpdateLifeRegen()
		{
		}

		// Token: 0x06002A05 RID: 10757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A05")]
		[Address(RVA = "0x14F1470", Offset = "0x14F1470", VA = "0x14F1470")]
		private void HurtLifeRegen(int dmg)
		{
		}

		// Token: 0x06002A06 RID: 10758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A06")]
		[Address(RVA = "0x14ACD08", Offset = "0x14ACD08", VA = "0x14ACD08")]
		public void ApplyManaRegenerationDelay()
		{
		}

		// Token: 0x06002A07 RID: 10759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A07")]
		[Address(RVA = "0x14F2D08", Offset = "0x14F2D08", VA = "0x14F2D08")]
		public void UpdateManaRegen()
		{
		}

		// Token: 0x06002A08 RID: 10760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A08")]
		[Address(RVA = "0x14F3380", Offset = "0x14F3380", VA = "0x14F3380")]
		private void ApplyNebulaBuffMana()
		{
		}

		// Token: 0x06002A09 RID: 10761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A09")]
		[Address(RVA = "0x14F33D0", Offset = "0x14F33D0", VA = "0x14F33D0")]
		public void UpdateJumpHeight()
		{
		}

		// Token: 0x06002A0A RID: 10762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A0A")]
		[Address(RVA = "0x14F3FA8", Offset = "0x14F3FA8", VA = "0x14F3FA8")]
		public void FindPulley()
		{
		}

		// Token: 0x06002A0B RID: 10763 RVA: 0x00014580 File Offset: 0x00012780
		[Token(Token = "0x6002A0B")]
		[Address(RVA = "0x14F48C0", Offset = "0x14F48C0", VA = "0x14F48C0")]
		public bool CanBePushedByWind()
		{
			return default(bool);
		}

		// Token: 0x06002A0C RID: 10764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A0C")]
		[Address(RVA = "0x14F49F0", Offset = "0x14F49F0", VA = "0x14F49F0")]
		public void HorizontalMovement()
		{
		}

		// Token: 0x06002A0D RID: 10765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A0D")]
		[Address(RVA = "0x14F6C10", Offset = "0x14F6C10", VA = "0x14F6C10")]
		public void NoteRunning()
		{
		}

		// Token: 0x06002A0E RID: 10766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A0E")]
		[Address(RVA = "0x14F8680", Offset = "0x14F8680", VA = "0x14F8680")]
		private void TryUsingDiggerCart()
		{
		}

		// Token: 0x06002A0F RID: 10767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A0F")]
		[Address(RVA = "0x14F6C90", Offset = "0x14F6C90", VA = "0x14F6C90")]
		private void SpawnFastRunParticles()
		{
		}

		// Token: 0x06002A10 RID: 10768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A10")]
		[Address(RVA = "0x14F8B9C", Offset = "0x14F8B9C", VA = "0x14F8B9C")]
		private void MowTheLawn()
		{
		}

		// Token: 0x06002A11 RID: 10769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A11")]
		[Address(RVA = "0x14F9F4C", Offset = "0x14F9F4C", VA = "0x14F9F4C")]
		private void MowGrassTile(Vector2 thePos)
		{
		}

		// Token: 0x06002A12 RID: 10770 RVA: 0x00014598 File Offset: 0x00012798
		[Token(Token = "0x6002A12")]
		[Address(RVA = "0x14F82E8", Offset = "0x14F82E8", VA = "0x14F82E8")]
		public int CollideWithNPCs(Rectangle myRect, float Damage, float Knockback, int NPCImmuneTime, int PlayerImmuneTime, int sourceItemId = 0)
		{
			return 0;
		}

		// Token: 0x06002A13 RID: 10771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A13")]
		[Address(RVA = "0x14FA398", Offset = "0x14FA398", VA = "0x14FA398")]
		public void TryHittingNPC(NPC npc, int Damage, float Knockback, [Optional] string sourceIdentifier, int sourceItemId = 0, int sourceProjectileId = 0, int ImmuneTime = 10)
		{
		}

		// Token: 0x06002A14 RID: 10772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A14")]
		[Address(RVA = "0x14CB0A0", Offset = "0x14CB0A0", VA = "0x14CB0A0")]
		public void ApplyDamageToNPC(NPC npc, int damage, float knockback, int direction, bool crit, [Optional] string sourceIdentifier, int sourceItemId = 0, int sourceProjectileId = 0)
		{
		}

		// Token: 0x06002A15 RID: 10773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A15")]
		[Address(RVA = "0x14FA514", Offset = "0x14FA514", VA = "0x14FA514")]
		public void ApplyDamageToNPC(NPC npc, int damage, float knockback, int direction, bool crit, PlayerNPCHitSource hitSource)
		{
		}

		// Token: 0x06002A16 RID: 10774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A16")]
		[Address(RVA = "0x14FA984", Offset = "0x14FA984", VA = "0x14FA984")]
		public void OnKillNPC(ref NPCKillAttempt attempt, object externalKillingBlowSource)
		{
		}

		// Token: 0x170005E9 RID: 1513
		// (get) Token: 0x06002A17 RID: 10775 RVA: 0x000145B0 File Offset: 0x000127B0
		[Token(Token = "0x170005E9")]
		public bool SlimeDontHyperJump
		{
			[Token(Token = "0x6002A17")]
			[Address(RVA = "0x14FABE8", Offset = "0x14FABE8", VA = "0x14FABE8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06002A18 RID: 10776 RVA: 0x000145C8 File Offset: 0x000127C8
		[Token(Token = "0x6002A18")]
		[Address(RVA = "0x14FA7C0", Offset = "0x14FA7C0", VA = "0x14FA7C0")]
		public bool GetBannerBuffEffect(NPC npc, out ItemID.BannerEffect effect)
		{
			return default(bool);
		}

		// Token: 0x06002A19 RID: 10777 RVA: 0x000145E0 File Offset: 0x000127E0
		[Token(Token = "0x6002A19")]
		[Address(RVA = "0x14FAC58", Offset = "0x14FAC58", VA = "0x14FAC58")]
		public bool GetBannerBuffEffect(int bannerType, out ItemID.BannerEffect effect)
		{
			return default(bool);
		}

		// Token: 0x06002A1A RID: 10778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A1A")]
		[Address(RVA = "0x14FA330", Offset = "0x14FA330", VA = "0x14FA330")]
		public void GiveImmuneTimeForCollisionAttack(int time)
		{
		}

		// Token: 0x06002A1B RID: 10779 RVA: 0x000145F8 File Offset: 0x000127F8
		[Token(Token = "0x6002A1B")]
		[Address(RVA = "0x14CAED4", Offset = "0x14CAED4", VA = "0x14CAED4")]
		public bool CanNPCBeHitByPlayerOrPlayerProjectile(NPC npc, [Optional] Projectile projectile)
		{
			return default(bool);
		}

		// Token: 0x06002A1C RID: 10780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A1C")]
		[Address(RVA = "0x14FAE38", Offset = "0x14FAE38", VA = "0x14FAE38")]
		public void IncreaseAirTime()
		{
		}

		// Token: 0x06002A1D RID: 10781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A1D")]
		[Address(RVA = "0x14FAF60", Offset = "0x14FAF60", VA = "0x14FAF60")]
		public void ResetAirTime()
		{
		}

		// Token: 0x06002A1E RID: 10782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A1E")]
		[Address(RVA = "0x14FAFE8", Offset = "0x14FAFE8", VA = "0x14FAFE8")]
		public void JumpMovement()
		{
		}

		// Token: 0x06002A1F RID: 10783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A1F")]
		[Address(RVA = "0x14FFDD0", Offset = "0x14FFDD0", VA = "0x14FFDD0")]
		public void DashMovement()
		{
		}

		// Token: 0x06002A20 RID: 10784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A20")]
		[Address(RVA = "0x15055E0", Offset = "0x15055E0", VA = "0x15055E0")]
		private void SolarDashStart(int dashDirection)
		{
		}

		// Token: 0x06002A21 RID: 10785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A21")]
		[Address(RVA = "0x15053C4", Offset = "0x15053C4", VA = "0x15053C4")]
		private void DoCommonDashHandle(out int dir, out bool dashing, [Optional] Player.DashStartAction dashStartAction)
		{
		}

		// Token: 0x06002A22 RID: 10786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A22")]
		[Address(RVA = "0x15055F0", Offset = "0x15055F0", VA = "0x15055F0")]
		public void WallClimbMovement()
		{
		}

		// Token: 0x06002A23 RID: 10787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A23")]
		[Address(RVA = "0x1506494", Offset = "0x1506494", VA = "0x1506494")]
		public void WallslideMovement()
		{
		}

		// Token: 0x06002A24 RID: 10788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A24")]
		[Address(RVA = "0x1506EF8", Offset = "0x1506EF8", VA = "0x1506EF8")]
		public void CarpetMovement()
		{
		}

		// Token: 0x06002A25 RID: 10789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A25")]
		[Address(RVA = "0x1507184", Offset = "0x1507184", VA = "0x1507184")]
		public void DoubleJumpVisuals()
		{
		}

		// Token: 0x06002A26 RID: 10790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A26")]
		[Address(RVA = "0x1508CCC", Offset = "0x1508CCC", VA = "0x1508CCC")]
		public void WingMovement()
		{
		}

		// Token: 0x06002A27 RID: 10791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A27")]
		[Address(RVA = "0x1509BFC", Offset = "0x1509BFC", VA = "0x1509BFC")]
		public void MoonLeechRope()
		{
		}

		// Token: 0x06002A28 RID: 10792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A28")]
		[Address(RVA = "0x150A020", Offset = "0x150A020", VA = "0x150A020")]
		public void WOFTongue()
		{
		}

		// Token: 0x06002A29 RID: 10793 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A29")]
		[Address(RVA = "0x150AA08", Offset = "0x150AA08", VA = "0x150AA08")]
		public void StatusFromNPC(NPC npc)
		{
		}

		// Token: 0x06002A2A RID: 10794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A2A")]
		[Address(RVA = "0x150C410", Offset = "0x150C410", VA = "0x150C410")]
		public void GrappleMovement()
		{
		}

		// Token: 0x06002A2B RID: 10795 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A2B")]
		[Address(RVA = "0x150DF54", Offset = "0x150DF54", VA = "0x150DF54")]
		public void DoQueenSlimeHookTeleport(Vector2 targetPosition)
		{
		}

		// Token: 0x06002A2C RID: 10796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A2C")]
		[Address(RVA = "0x150D26C", Offset = "0x150D26C", VA = "0x150D26C")]
		private void GetGrapplingForces(Vector2 fromPosition, out int? preferredPlayerDirectionToSet, out float preferedPlayerVelocityX, out float preferedPlayerVelocityY)
		{
		}

		// Token: 0x06002A2D RID: 10797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A2D")]
		[Address(RVA = "0x150D1B0", Offset = "0x150D1B0", VA = "0x150D1B0")]
		private void RefreshMovementAbilities(bool doubleJumps = true)
		{
		}

		// Token: 0x06002A2E RID: 10798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A2E")]
		[Address(RVA = "0x14FFD30", Offset = "0x14FFD30", VA = "0x14FFD30")]
		private void RefreshDoubleJumps()
		{
		}

		// Token: 0x06002A2F RID: 10799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A2F")]
		[Address(RVA = "0x150E498", Offset = "0x150E498", VA = "0x150E498")]
		public void StickyMovement()
		{
		}

		// Token: 0x06002A30 RID: 10800 RVA: 0x00014610 File Offset: 0x00012810
		[Token(Token = "0x6002A30")]
		[Address(RVA = "0x150F8E4", Offset = "0x150F8E4", VA = "0x150F8E4")]
		public bool HasLockedInventory()
		{
			return default(bool);
		}

		// Token: 0x06002A31 RID: 10801 RVA: 0x00014628 File Offset: 0x00012828
		[Token(Token = "0x6002A31")]
		[Address(RVA = "0x150FA48", Offset = "0x150FA48", VA = "0x150FA48")]
		public bool IsLockedFromCrafting()
		{
			return default(bool);
		}

		// Token: 0x06002A32 RID: 10802 RVA: 0x00014640 File Offset: 0x00012840
		[Token(Token = "0x6002A32")]
		[Address(RVA = "0x150F960", Offset = "0x150F960", VA = "0x150F960")]
		public bool IsStackingItems()
		{
			return default(bool);
		}

		// Token: 0x06002A33 RID: 10803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A33")]
		[Address(RVA = "0x150FA4C", Offset = "0x150FA4C", VA = "0x150FA4C")]
		public void LockNetSlot(int slot)
		{
		}

		// Token: 0x06002A34 RID: 10804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A34")]
		[Address(RVA = "0x150FB04", Offset = "0x150FB04", VA = "0x150FB04")]
		public void UpdateNearbyInteractableProjectilesList()
		{
		}

		// Token: 0x06002A35 RID: 10805 RVA: 0x00014658 File Offset: 0x00012858
		[Token(Token = "0x6002A35")]
		[Address(RVA = "0x150FCC4", Offset = "0x150FCC4", VA = "0x150FCC4")]
		public bool IsProjectileInteractableAndInInteractionRange(Projectile proj, Vector2 compareSpot)
		{
			return default(bool);
		}

		// Token: 0x06002A36 RID: 10806 RVA: 0x00014670 File Offset: 0x00012870
		[Token(Token = "0x6002A36")]
		[Address(RVA = "0x14A8CC4", Offset = "0x14A8CC4", VA = "0x14A8CC4")]
		public bool useVoidBag()
		{
			return default(bool);
		}

		// Token: 0x170005EA RID: 1514
		// (get) Token: 0x06002A37 RID: 10807 RVA: 0x00014688 File Offset: 0x00012888
		[Token(Token = "0x170005EA")]
		private bool hasBreathingReed
		{
			[Token(Token = "0x6002A37")]
			[Address(RVA = "0x149EE20", Offset = "0x149EE20", VA = "0x149EE20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06002A38 RID: 10808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A38")]
		[Address(RVA = "0x150FE3C", Offset = "0x150FE3C", VA = "0x150FE3C")]
		public void QuickStackAllChests()
		{
		}

		// Token: 0x06002A39 RID: 10809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A39")]
		[Address(RVA = "0x150FF30", Offset = "0x150FF30", VA = "0x150FF30")]
		public void CheckDrowning()
		{
		}

		// Token: 0x06002A3A RID: 10810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A3A")]
		[Address(RVA = "0x1510FD0", Offset = "0x1510FD0", VA = "0x1510FD0")]
		public void CheckCrackedBrickBreak()
		{
		}

		// Token: 0x06002A3B RID: 10811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A3B")]
		[Address(RVA = "0x1512274", Offset = "0x1512274", VA = "0x1512274")]
		public void CheckIceBreak()
		{
		}

		// Token: 0x06002A3C RID: 10812 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A3C")]
		[Address(RVA = "0x1512794", Offset = "0x1512794", VA = "0x1512794")]
		public void SlopeDownMovement()
		{
		}

		// Token: 0x06002A3D RID: 10813 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A3D")]
		[Address(RVA = "0x15128C0", Offset = "0x15128C0", VA = "0x15128C0")]
		public void WetCollision(bool fallThrough, bool ignorePlats, float movementSpeed)
		{
		}

		// Token: 0x06002A3E RID: 10814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A3E")]
		[Address(RVA = "0x1512B0C", Offset = "0x1512B0C", VA = "0x1512B0C")]
		private void TryFloatingInFluid()
		{
		}

		// Token: 0x06002A3F RID: 10815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A3F")]
		[Address(RVA = "0x1512DB0", Offset = "0x1512DB0", VA = "0x1512DB0")]
		public void DryCollision(bool fallThrough, bool ignorePlats)
		{
		}

		// Token: 0x06002A40 RID: 10816 RVA: 0x000146A0 File Offset: 0x000128A0
		[Token(Token = "0x6002A40")]
		[Address(RVA = "0x150E350", Offset = "0x150E350", VA = "0x150E350")]
		public Vector2 TileCollision(Vector2 position, Vector2 velocity, bool fallThrough, bool ignorePlats)
		{
			return default(Vector2);
		}

		// Token: 0x06002A41 RID: 10817 RVA: 0x000146B8 File Offset: 0x000128B8
		[Token(Token = "0x6002A41")]
		[Address(RVA = "0x1514DA8", Offset = "0x1514DA8", VA = "0x1514DA8")]
		private bool TouchBlockSurfaceCenter(int x, int y, Tile tile, out int exitNormalX, out int exitNormalY, out Vector2 surfaceCenter)
		{
			return default(bool);
		}

		// Token: 0x06002A42 RID: 10818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A42")]
		[Address(RVA = "0x1514B54", Offset = "0x1514B54", VA = "0x1514B54")]
		public void SlopingCollision(bool fallThrough, bool ignorePlats)
		{
		}

		// Token: 0x06002A43 RID: 10819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A43")]
		[Address(RVA = "0x1515438", Offset = "0x1515438", VA = "0x1515438")]
		public void FloorVisuals(bool Falling)
		{
		}

		// Token: 0x06002A44 RID: 10820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A44")]
		[Address(RVA = "0x14E5C78", Offset = "0x14E5C78", VA = "0x14E5C78")]
		public void ResetFloorFlags()
		{
		}

		// Token: 0x06002A45 RID: 10821 RVA: 0x000146D0 File Offset: 0x000128D0
		[Token(Token = "0x6002A45")]
		[Address(RVA = "0x1515C2C", Offset = "0x1515C2C", VA = "0x1515C2C")]
		public static Tile GetFloorTile(int x, int y)
		{
			return default(Tile);
		}

		// Token: 0x06002A46 RID: 10822 RVA: 0x000146E8 File Offset: 0x000128E8
		[Token(Token = "0x6002A46")]
		[Address(RVA = "0x15175BC", Offset = "0x15175BC", VA = "0x15175BC")]
		public static int GetFloorTileType(int x, int y)
		{
			return 0;
		}

		// Token: 0x06002A47 RID: 10823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A47")]
		[Address(RVA = "0x1516148", Offset = "0x1516148", VA = "0x1516148")]
		private void MakeFloorDust(bool Falling, int type, int frameX, int frameY, int paintColor)
		{
		}

		// Token: 0x06002A48 RID: 10824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A48")]
		[Address(RVA = "0x1517704", Offset = "0x1517704", VA = "0x1517704")]
		public void BordersMovement()
		{
		}

		// Token: 0x06002A49 RID: 10825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A49")]
		[Address(RVA = "0x1517C30", Offset = "0x1517C30", VA = "0x1517C30")]
		public void CollectTaxes()
		{
		}

		// Token: 0x06002A4A RID: 10826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A4A")]
		[Address(RVA = "0x14A3408", Offset = "0x14A3408", VA = "0x14A3408")]
		public void GamepadEnableGrappleCooldown()
		{
		}

		// Token: 0x06002A4B RID: 10827 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A4B")]
		[Address(RVA = "0x1517F44", Offset = "0x1517F44", VA = "0x1517F44")]
		public void TryInterruptingItemUsage()
		{
		}

		// Token: 0x06002A4C RID: 10828 RVA: 0x00014700 File Offset: 0x00012900
		[Token(Token = "0x6002A4C")]
		[Address(RVA = "0x15187FC", Offset = "0x15187FC", VA = "0x15187FC")]
		private bool CanMoveForwardOnRope(int dir, int x, int y)
		{
			return default(bool);
		}

		// Token: 0x06002A4D RID: 10829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A4D")]
		[Address(RVA = "0x1518EC4", Offset = "0x1518EC4", VA = "0x1518EC4")]
		public void UpdateHairDyeDust()
		{
		}

		// Token: 0x06002A4E RID: 10830 RVA: 0x00014718 File Offset: 0x00012918
		[Token(Token = "0x6002A4E")]
		[Address(RVA = "0x15198B0", Offset = "0x15198B0", VA = "0x15198B0")]
		public bool IsScopeActive()
		{
			return default(bool);
		}

		// Token: 0x06002A4F RID: 10831 RVA: 0x00014730 File Offset: 0x00012930
		[Token(Token = "0x6002A4F")]
		[Address(RVA = "0x1519910", Offset = "0x1519910", VA = "0x1519910")]
		public bool CanAlternativeFire(bool checkIfHasMapping = false)
		{
			return default(bool);
		}

		// Token: 0x06002A50 RID: 10832 RVA: 0x00014748 File Offset: 0x00012948
		[Token(Token = "0x6002A50")]
		[Address(RVA = "0x14E874C", Offset = "0x14E874C", VA = "0x14E874C")]
		public bool IsRightClickItemActive()
		{
			return default(bool);
		}

		// Token: 0x06002A51 RID: 10833 RVA: 0x00014760 File Offset: 0x00012960
		[Token(Token = "0x6002A51")]
		[Address(RVA = "0x15199AC", Offset = "0x15199AC", VA = "0x15199AC")]
		public bool CanOverloadAimAndUse()
		{
			return default(bool);
		}

		// Token: 0x06002A52 RID: 10834 RVA: 0x00014778 File Offset: 0x00012978
		[Token(Token = "0x6002A52")]
		[Address(RVA = "0x1519AD0", Offset = "0x1519AD0", VA = "0x1519AD0")]
		private bool CanUseItem()
		{
			return default(bool);
		}

		// Token: 0x06002A53 RID: 10835 RVA: 0x00014790 File Offset: 0x00012990
		[Token(Token = "0x6002A53")]
		[Address(RVA = "0x1519B04", Offset = "0x1519B04", VA = "0x1519B04")]
		public bool CheckPulley()
		{
			return default(bool);
		}

		// Token: 0x06002A54 RID: 10836 RVA: 0x000147A8 File Offset: 0x000129A8
		[Token(Token = "0x6002A54")]
		[Address(RVA = "0x151A3D8", Offset = "0x151A3D8", VA = "0x151A3D8")]
		public bool CheckCuteFishron()
		{
			return default(bool);
		}

		// Token: 0x06002A55 RID: 10837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A55")]
		[Address(RVA = "0x151AA1C", Offset = "0x151AA1C", VA = "0x151AA1C")]
		private void DoDeadCellsBeheadedParticles()
		{
		}

		// Token: 0x06002A56 RID: 10838 RVA: 0x000147C0 File Offset: 0x000129C0
		[Token(Token = "0x6002A56")]
		[Address(RVA = "0x14AEA80", Offset = "0x14AEA80", VA = "0x14AEA80")]
		public bool TryingToUseItem()
		{
			return default(bool);
		}

		// Token: 0x06002A57 RID: 10839 RVA: 0x000147D8 File Offset: 0x000129D8
		[Token(Token = "0x6002A57")]
		[Address(RVA = "0x151AF70", Offset = "0x151AF70", VA = "0x151AF70")]
		public float GetAutoDoorVelocityContribution()
		{
			return 0f;
		}

		// Token: 0x06002A58 RID: 10840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A58")]
		[Address(RVA = "0x151B0C0", Offset = "0x151B0C0", VA = "0x151B0C0")]
		public void UpdateInventoryKeys()
		{
		}

		// Token: 0x06002A59 RID: 10841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A59")]
		[Address(RVA = "0x14A5228", Offset = "0x14A5228", VA = "0x14A5228")]
		public void LoadTargetPosition()
		{
		}

		// Token: 0x06002A5A RID: 10842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A5A")]
		[Address(RVA = "0x14713F8", Offset = "0x14713F8", VA = "0x14713F8")]
		public void Update(int i)
		{
		}

		// Token: 0x06002A5B RID: 10843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A5B")]
		[Address(RVA = "0x14B419C", Offset = "0x14B419C", VA = "0x14B419C")]
		public void ResetToHellAndBackIfNotCompleted()
		{
		}

		// Token: 0x06002A5C RID: 10844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A5C")]
		[Address(RVA = "0x151B818", Offset = "0x151B818", VA = "0x151B818")]
		private void Update_TimerCrit()
		{
		}

		// Token: 0x06002A5D RID: 10845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A5D")]
		[Address(RVA = "0x1504C94", Offset = "0x1504C94", VA = "0x1504C94")]
		public void TryConsumingTimerCrit(Rectangle hitbox, ref bool crit)
		{
		}

		// Token: 0x06002A5E RID: 10846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A5E")]
		[Address(RVA = "0x151BC64", Offset = "0x151BC64", VA = "0x151BC64")]
		private void Update_SnappingStone()
		{
		}

		// Token: 0x06002A5F RID: 10847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A5F")]
		[Address(RVA = "0x151BEA8", Offset = "0x151BEA8", VA = "0x151BEA8")]
		private void Update_SnakeBand()
		{
		}

		// Token: 0x06002A60 RID: 10848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A60")]
		[Address(RVA = "0x151BEC8", Offset = "0x151BEC8", VA = "0x151BEC8")]
		private void Update_AmmoCycler()
		{
		}

		// Token: 0x06002A61 RID: 10849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A61")]
		[Address(RVA = "0x151BEE8", Offset = "0x151BEE8", VA = "0x151BEE8")]
		private void Update_SentryBackpack()
		{
		}

		// Token: 0x06002A62 RID: 10850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A62")]
		[Address(RVA = "0x151BEFC", Offset = "0x151BEFC", VA = "0x151BEFC")]
		private void Update_HarpyCharm()
		{
		}

		// Token: 0x06002A63 RID: 10851 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A63")]
		[Address(RVA = "0x151BF14", Offset = "0x151BF14", VA = "0x151BF14")]
		private void HarpyCharmEffect()
		{
		}

		// Token: 0x06002A64 RID: 10852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A64")]
		[Address(RVA = "0x151C174", Offset = "0x151C174", VA = "0x151C174")]
		private void Update_AdjustTileTargetForDisplayJars(int i)
		{
		}

		// Token: 0x06002A65 RID: 10853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A65")]
		[Address(RVA = "0x151C9B8", Offset = "0x151C9B8", VA = "0x151C9B8")]
		public void UpdateNearbyCraftingTiles()
		{
		}

		// Token: 0x06002A66 RID: 10854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A66")]
		[Address(RVA = "0x151D5C0", Offset = "0x151D5C0", VA = "0x151D5C0")]
		private void TryClearingCraftingFilter()
		{
		}

		// Token: 0x06002A67 RID: 10855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A67")]
		[Address(RVA = "0x151D928", Offset = "0x151D928", VA = "0x151D928")]
		private void RollerSkateMovement()
		{
		}

		// Token: 0x06002A68 RID: 10856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A68")]
		[Address(RVA = "0x151DD38", Offset = "0x151DD38", VA = "0x151DD38")]
		private void UpdateParticles()
		{
		}

		// Token: 0x06002A69 RID: 10857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A69")]
		[Address(RVA = "0x151DFE8", Offset = "0x151DFE8", VA = "0x151DFE8")]
		private void UpdateSunScorchValues()
		{
		}

		// Token: 0x06002A6A RID: 10858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A6A")]
		[Address(RVA = "0x151E2B0", Offset = "0x151E2B0", VA = "0x151E2B0")]
		private void DoUnbreakableWallScan(bool force = false)
		{
		}

		// Token: 0x06002A6B RID: 10859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A6B")]
		[Address(RVA = "0x151E544", Offset = "0x151E544", VA = "0x151E544")]
		private void UpdateSunScorch()
		{
		}

		// Token: 0x06002A6C RID: 10860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A6C")]
		[Address(RVA = "0x151E79C", Offset = "0x151E79C", VA = "0x151E79C")]
		private void VampireSeedSunlightExposure()
		{
		}

		// Token: 0x06002A6D RID: 10861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A6D")]
		[Address(RVA = "0x14B4EEC", Offset = "0x14B4EEC", VA = "0x14B4EEC")]
		private void UpdateNetOffset(bool fallThrough, bool ignorePlats)
		{
		}

		// Token: 0x06002A6E RID: 10862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A6E")]
		[Address(RVA = "0x15248EC", Offset = "0x15248EC", VA = "0x15248EC")]
		public static void ResetNetOffsets()
		{
		}

		// Token: 0x06002A6F RID: 10863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A6F")]
		[Address(RVA = "0x1524A10", Offset = "0x1524A10", VA = "0x1524A10")]
		public void ChestChangeEvents()
		{
		}

		// Token: 0x06002A70 RID: 10864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A70")]
		[Address(RVA = "0x1524CF4", Offset = "0x1524CF4", VA = "0x1524CF4")]
		private void DoDeadCellsGroundPoundEffect()
		{
		}

		// Token: 0x06002A71 RID: 10865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A71")]
		[Address(RVA = "0x15250BC", Offset = "0x15250BC", VA = "0x15250BC")]
		private void TryToShimmerUnstuck()
		{
		}

		// Token: 0x06002A72 RID: 10866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A72")]
		[Address(RVA = "0x15251A0", Offset = "0x15251A0", VA = "0x15251A0")]
		private void ShimmerUnstuck()
		{
		}

		// Token: 0x06002A73 RID: 10867 RVA: 0x000147F0 File Offset: 0x000129F0
		[Token(Token = "0x6002A73")]
		[Address(RVA = "0x15254C0", Offset = "0x15254C0", VA = "0x15254C0")]
		private Vector2? TryFindingShimmerFreeSpot()
		{
			return null;
		}

		// Token: 0x06002A74 RID: 10868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A74")]
		[Address(RVA = "0x1525AD0", Offset = "0x1525AD0", VA = "0x1525AD0")]
		private void AdjustRemainingPotionSickness()
		{
		}

		// Token: 0x06002A75 RID: 10869 RVA: 0x00014808 File Offset: 0x00012A08
		[Token(Token = "0x6002A75")]
		[Address(RVA = "0x1525C50", Offset = "0x1525C50", VA = "0x1525C50")]
		private Collision.HurtTile GetHurtTile()
		{
			return default(Collision.HurtTile);
		}

		// Token: 0x06002A76 RID: 10870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A76")]
		[Address(RVA = "0x1526324", Offset = "0x1526324", VA = "0x1526324")]
		private void ApplyTouchDamage(int tileId, int x, int y)
		{
		}

		// Token: 0x06002A77 RID: 10871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A77")]
		[Address(RVA = "0x152685C", Offset = "0x152685C", VA = "0x152685C")]
		private void CapAttackSpeeds()
		{
		}

		// Token: 0x06002A78 RID: 10872 RVA: 0x00014820 File Offset: 0x00012A20
		[Token(Token = "0x6002A78")]
		[Address(RVA = "0x15268A8", Offset = "0x15268A8", VA = "0x15268A8")]
		private float TurnAttackSpeedToUseTimeMultiplier(float speed)
		{
			return 0f;
		}

		// Token: 0x170005EB RID: 1515
		// (get) Token: 0x06002A79 RID: 10873 RVA: 0x00014838 File Offset: 0x00012A38
		[Token(Token = "0x170005EB")]
		public bool IsRidingTracks
		{
			[Token(Token = "0x6002A79")]
			[Address(RVA = "0x15268D0", Offset = "0x15268D0", VA = "0x15268D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06002A7A RID: 10874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A7A")]
		[Address(RVA = "0x152695C", Offset = "0x152695C", VA = "0x152695C")]
		public void UpdateLuck()
		{
		}

		// Token: 0x06002A7B RID: 10875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A7B")]
		[Address(RVA = "0x1526F08", Offset = "0x1526F08", VA = "0x1526F08")]
		private void ResetControls()
		{
		}

		// Token: 0x06002A7C RID: 10876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A7C")]
		[Address(RVA = "0x1526F38", Offset = "0x1526F38", VA = "0x1526F38")]
		private void UpdateControlHolds()
		{
		}

		// Token: 0x06002A7D RID: 10877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A7D")]
		[Address(RVA = "0x1527090", Offset = "0x1527090", VA = "0x1527090")]
		public void TryOpeningFullscreenMap()
		{
		}

		// Token: 0x06002A7E RID: 10878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A7E")]
		[Address(RVA = "0x1526A64", Offset = "0x1526A64", VA = "0x1526A64")]
		public void UpdateLuckFactors()
		{
		}

		// Token: 0x06002A7F RID: 10879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A7F")]
		[Address(RVA = "0x1526C50", Offset = "0x1526C50", VA = "0x1526C50")]
		public void RecalculateLuck()
		{
		}

		// Token: 0x06002A80 RID: 10880 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A80")]
		[Address(RVA = "0x15272BC", Offset = "0x15272BC", VA = "0x15272BC")]
		private void UpdateBrokenMirrorLuck()
		{
		}

		// Token: 0x06002A81 RID: 10881 RVA: 0x00014850 File Offset: 0x00012A50
		[Token(Token = "0x6002A81")]
		[Address(RVA = "0x1527364", Offset = "0x1527364", VA = "0x1527364")]
		public static int GetMouseScrollDelta()
		{
			return 0;
		}

		// Token: 0x06002A82 RID: 10882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A82")]
		[Address(RVA = "0x15273D8", Offset = "0x15273D8", VA = "0x15273D8")]
		private void UpdatePortableStoolUsage()
		{
		}

		// Token: 0x06002A83 RID: 10883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A83")]
		[Address(RVA = "0x14EF53C", Offset = "0x14EF53C", VA = "0x14EF53C")]
		private void ResizeHitbox()
		{
		}

		// Token: 0x06002A84 RID: 10884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A84")]
		[Address(RVA = "0x152748C", Offset = "0x152748C", VA = "0x152748C")]
		private void UpdateReleaseUseTile()
		{
		}

		// Token: 0x06002A85 RID: 10885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A85")]
		[Address(RVA = "0x15274F8", Offset = "0x15274F8", VA = "0x15274F8")]
		private void GetMinecartDamage(float currentSpeed, out int damage, out float knockback)
		{
		}

		// Token: 0x06002A86 RID: 10886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A86")]
		[Address(RVA = "0x15277C0", Offset = "0x15277C0", VA = "0x15277C0")]
		public void UpdateMiscCounter()
		{
		}

		// Token: 0x06002A87 RID: 10887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A87")]
		[Address(RVA = "0x15277D8", Offset = "0x15277D8", VA = "0x15277D8")]
		private void WingAirLogicTweaks()
		{
		}

		// Token: 0x06002A88 RID: 10888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A88")]
		[Address(RVA = "0x15278C8", Offset = "0x15278C8", VA = "0x15278C8")]
		private void RocketBootVisuals()
		{
		}

		// Token: 0x06002A89 RID: 10889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A89")]
		[Address(RVA = "0x1528400", Offset = "0x1528400", VA = "0x1528400")]
		public void GetWingsFunctionalityForVisuals(int wingsToUse, out bool canHover, out bool canHoverBoostHorizontally, out bool canBoost)
		{
		}

		// Token: 0x06002A8A RID: 10890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A8A")]
		[Address(RVA = "0x1528490", Offset = "0x1528490", VA = "0x1528490")]
		public void WingFrame(bool wingFlap)
		{
		}

		// Token: 0x06002A8B RID: 10891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A8B")]
		[Address(RVA = "0x152BBD8", Offset = "0x152BBD8", VA = "0x152BBD8")]
		private void ChickenBonesWingDust(bool noDustLight, bool justSwitched)
		{
		}

		// Token: 0x06002A8C RID: 10892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A8C")]
		[Address(RVA = "0x152C5D4", Offset = "0x152C5D4", VA = "0x152C5D4")]
		private void HeroicisWingDust(bool noDustLight, bool justSwitched)
		{
		}

		// Token: 0x06002A8D RID: 10893 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A8D")]
		[Address(RVA = "0x152D170", Offset = "0x152D170", VA = "0x152D170")]
		private void KazzymodusWingDust(bool noDustLight, bool justSwitched)
		{
		}

		// Token: 0x06002A8E RID: 10894 RVA: 0x00014868 File Offset: 0x00012A68
		[Token(Token = "0x6002A8E")]
		[Address(RVA = "0x152BB08", Offset = "0x152BB08", VA = "0x152BB08")]
		public bool ShouldDrawWingsThatAreAlwaysAnimated(bool ignoreMounts = false)
		{
			return default(bool);
		}

		// Token: 0x06002A8F RID: 10895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A8F")]
		[Address(RVA = "0x152D9B4", Offset = "0x152D9B4", VA = "0x152D9B4")]
		private void WingAirVisuals()
		{
		}

		// Token: 0x06002A90 RID: 10896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A90")]
		[Address(RVA = "0x1530530", Offset = "0x1530530", VA = "0x1530530")]
		private void HandleBeingInChestRange()
		{
		}

		// Token: 0x06002A91 RID: 10897 RVA: 0x00014880 File Offset: 0x00012A80
		[Token(Token = "0x6002A91")]
		[Address(RVA = "0x1530BEC", Offset = "0x1530BEC", VA = "0x1530BEC")]
		public bool IsInInteractionRangeToMultiTileHitbox(int chestPointX, int chestPointY)
		{
			return default(bool);
		}

		// Token: 0x06002A92 RID: 10898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A92")]
		[Address(RVA = "0x14B4E98", Offset = "0x14B4E98", VA = "0x14B4E98")]
		public void ResetVisibleAccessories()
		{
		}

		// Token: 0x06002A93 RID: 10899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A93")]
		[Address(RVA = "0x15312BC", Offset = "0x15312BC", VA = "0x15312BC")]
		public void UpdateArmorLights()
		{
		}

		// Token: 0x06002A94 RID: 10900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A94")]
		[Address(RVA = "0x1531C74", Offset = "0x1531C74", VA = "0x1531C74")]
		public void Update_NPCCollision()
		{
		}

		// Token: 0x06002A95 RID: 10901 RVA: 0x00014898 File Offset: 0x00012A98
		[Token(Token = "0x6002A95")]
		[Address(RVA = "0x15328C4", Offset = "0x15328C4", VA = "0x15328C4")]
		public bool CanParryAgainst(Rectangle blockingPlayerRect, Rectangle enemyRect, Vector2 enemyVelocity)
		{
			return default(bool);
		}

		// Token: 0x06002A96 RID: 10902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A96")]
		[Address(RVA = "0x1532A8C", Offset = "0x1532A8C", VA = "0x1532A8C")]
		private void PurgeDD2EnergyCrystals()
		{
		}

		// Token: 0x06002A97 RID: 10903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A97")]
		[Address(RVA = "0x1533064", Offset = "0x1533064", VA = "0x1533064")]
		public void ItemCheck_ManageRightClickFeatures()
		{
		}

		// Token: 0x06002A98 RID: 10904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A98")]
		[Address(RVA = "0x1533F10", Offset = "0x1533F10", VA = "0x1533F10")]
		public void ItemCheck_ManageRightClickFeatures_ShieldRaise(bool theGeneralCheck)
		{
		}

		// Token: 0x06002A99 RID: 10905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A99")]
		[Address(RVA = "0x15344BC", Offset = "0x15344BC", VA = "0x15344BC")]
		public void TryTogglingShield(bool shouldGuard)
		{
		}

		// Token: 0x06002A9A RID: 10906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A9A")]
		[Address(RVA = "0x153452C", Offset = "0x153452C", VA = "0x153452C")]
		private void HandleHotbarControls()
		{
		}

		// Token: 0x06002A9B RID: 10907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A9B")]
		[Address(RVA = "0x1534E10", Offset = "0x1534E10", VA = "0x1534E10")]
		private void ItemCheckWrapped(int i)
		{
		}

		// Token: 0x06002A9C RID: 10908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A9C")]
		[Address(RVA = "0x15350BC", Offset = "0x15350BC", VA = "0x15350BC")]
		private void ForceForwardCursor(bool state)
		{
		}

		// Token: 0x06002A9D RID: 10909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A9D")]
		[Address(RVA = "0x15353CC", Offset = "0x15353CC", VA = "0x15353CC")]
		private void ForceSmartSelectCursor(bool state)
		{
		}

		// Token: 0x06002A9E RID: 10910 RVA: 0x000148B0 File Offset: 0x00012AB0
		[Token(Token = "0x6002A9E")]
		[Address(RVA = "0x1539AC0", Offset = "0x1539AC0", VA = "0x1539AC0")]
		private bool HasNonAFKAnyInput()
		{
			return default(bool);
		}

		// Token: 0x06002A9F RID: 10911 RVA: 0x000148C8 File Offset: 0x00012AC8
		[Token(Token = "0x6002A9F")]
		[Address(RVA = "0x151B780", Offset = "0x151B780", VA = "0x151B780")]
		private bool AfKKiteInUse()
		{
			return default(bool);
		}

		// Token: 0x06002AA0 RID: 10912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AA0")]
		[Address(RVA = "0x1534AC8", Offset = "0x1534AC8", VA = "0x1534AC8")]
		public void UpdateChangeItem()
		{
		}

		// Token: 0x06002AA1 RID: 10913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AA1")]
		[Address(RVA = "0x1539C54", Offset = "0x1539C54", VA = "0x1539C54")]
		public void UseUpdateChangeItem()
		{
		}

		// Token: 0x06002AA2 RID: 10914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AA2")]
		[Address(RVA = "0x1539E64", Offset = "0x1539E64", VA = "0x1539E64")]
		public void ScrollHotbar(int Offset)
		{
		}

		// Token: 0x06002AA3 RID: 10915 RVA: 0x000148E0 File Offset: 0x00012AE0
		[Token(Token = "0x6002AA3")]
		[Address(RVA = "0x151879C", Offset = "0x151879C", VA = "0x151879C")]
		private static int ClampHotbarOffset(int Offset)
		{
			return 0;
		}

		// Token: 0x06002AA4 RID: 10916 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AA4")]
		[Address(RVA = "0x1539F40", Offset = "0x1539F40", VA = "0x1539F40")]
		public List<int> GetListOfProjectilesToInteractWithHack()
		{
			return null;
		}

		// Token: 0x06002AA5 RID: 10917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AA5")]
		[Address(RVA = "0x14A31CC", Offset = "0x14A31CC", VA = "0x14A31CC")]
		public void LockGamepadTileInteractions()
		{
		}

		// Token: 0x06002AA6 RID: 10918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AA6")]
		[Address(RVA = "0x1539F48", Offset = "0x1539F48", VA = "0x1539F48")]
		public void LookForTileInteractions()
		{
		}

		// Token: 0x06002AA7 RID: 10919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AA7")]
		[Address(RVA = "0x153B784", Offset = "0x153B784", VA = "0x153B784")]
		private void TryInteractingWithMinecartTrackInNearbyArea(int selectedTargetX, int selectedTargetY)
		{
		}

		// Token: 0x06002AA8 RID: 10920 RVA: 0x000148F8 File Offset: 0x00012AF8
		[Token(Token = "0x6002AA8")]
		[Address(RVA = "0x153BC6C", Offset = "0x153BC6C", VA = "0x153BC6C")]
		public bool InTileEntityInteractionRange(int interactX, int interactY, int tileSizeX, int tileSizeY, TileReachCheckSettings settings)
		{
			return default(bool);
		}

		// Token: 0x06002AA9 RID: 10921 RVA: 0x00014910 File Offset: 0x00012B10
		[Token(Token = "0x6002AA9")]
		[Address(RVA = "0x14EA53C", Offset = "0x14EA53C", VA = "0x14EA53C")]
		public bool IsInTileInteractionRange(int targetX, int targetY, TileReachCheckSettings settings, int TB = 0)
		{
			return default(bool);
		}

		// Token: 0x06002AAA RID: 10922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AAA")]
		[Address(RVA = "0x153B614", Offset = "0x153B614", VA = "0x153B614")]
		public void TileInteractionsCheck(int myX, int myY)
		{
		}

		// Token: 0x06002AAB RID: 10923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AAB")]
		[Address(RVA = "0x1555500", Offset = "0x1555500", VA = "0x1555500")]
		public void PushTouchCursorState()
		{
		}

		// Token: 0x06002AAC RID: 10924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AAC")]
		[Address(RVA = "0x15558D0", Offset = "0x15558D0", VA = "0x15558D0")]
		public void PopTouchCursorState()
		{
		}

		// Token: 0x06002AAD RID: 10925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AAD")]
		[Address(RVA = "0x153A47C", Offset = "0x153A47C", VA = "0x153A47C")]
		private void TileInteractionsCheckLongDistance(int myX, int myY)
		{
		}

		// Token: 0x06002AAE RID: 10926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AAE")]
		[Address(RVA = "0x1546A50", Offset = "0x1546A50", VA = "0x1546A50")]
		private void TileInteractionsUse(int myX, int myY)
		{
		}

		// Token: 0x06002AAF RID: 10927 RVA: 0x00014928 File Offset: 0x00012B28
		[Token(Token = "0x6002AAF")]
		[Address(RVA = "0x1557210", Offset = "0x1557210", VA = "0x1557210")]
		private static bool IsHoveringOverABottomSideOfABed(int myX, int myY)
		{
			return default(bool);
		}

		// Token: 0x06002AB0 RID: 10928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AB0")]
		[Address(RVA = "0x1557B88", Offset = "0x1557B88", VA = "0x1557B88")]
		public void PetMount(PlayerPettingInfo info)
		{
		}

		// Token: 0x06002AB1 RID: 10929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AB1")]
		[Address(RVA = "0x1557CF8", Offset = "0x1557CF8", VA = "0x1557CF8")]
		public void PetAnimal(PlayerPettingInfo info)
		{
		}

		// Token: 0x06002AB2 RID: 10930 RVA: 0x00014940 File Offset: 0x00012B40
		[Token(Token = "0x6002AB2")]
		[Address(RVA = "0x15581A0", Offset = "0x15581A0", VA = "0x15581A0")]
		public bool CanSnapToPosition(Vector2 offset)
		{
			return default(bool);
		}

		// Token: 0x06002AB3 RID: 10931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AB3")]
		[Address(RVA = "0x15587B4", Offset = "0x15587B4", VA = "0x15587B4")]
		private void TryAllowingSnappingToPosition(ref bool canSnapToPosition, Vector2 pos1, Vector2 pos2)
		{
		}

		// Token: 0x06002AB4 RID: 10932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AB4")]
		[Address(RVA = "0x1505384", Offset = "0x1505384", VA = "0x1505384")]
		public void StopVanityActions(bool multiplayerBroadcast = true)
		{
		}

		// Token: 0x06002AB5 RID: 10933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AB5")]
		[Address(RVA = "0x1557CEC", Offset = "0x1557CEC", VA = "0x1557CEC")]
		public void StopPettingAnimal()
		{
		}

		// Token: 0x06002AB6 RID: 10934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AB6")]
		[Address(RVA = "0x1558AF8", Offset = "0x1558AF8", VA = "0x1558AF8")]
		private void UpdatePettingAnimal()
		{
		}

		// Token: 0x06002AB7 RID: 10935 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AB7")]
		[Address(RVA = "0x1558DB0", Offset = "0x1558DB0", VA = "0x1558DB0")]
		public InventoryStorage GetCurrentContainer()
		{
			return null;
		}

		// Token: 0x06002AB8 RID: 10936 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AB8")]
		[Address(RVA = "0x15578E0", Offset = "0x15578E0", VA = "0x15578E0")]
		private void OpenChest(int x, int y, int newChest)
		{
		}

		// Token: 0x06002AB9 RID: 10937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AB9")]
		[Address(RVA = "0x14A3244", Offset = "0x14A3244", VA = "0x14A3244")]
		public void CloseSign(bool quiet = false)
		{
		}

		// Token: 0x06002ABA RID: 10938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002ABA")]
		[Address(RVA = "0x1558E0C", Offset = "0x1558E0C", VA = "0x1558E0C")]
		public void OpenSign(int s)
		{
		}

		// Token: 0x06002ABB RID: 10939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002ABB")]
		[Address(RVA = "0x14B0484", Offset = "0x14B0484", VA = "0x14B0484")]
		private void LaunchMinecartHook(int myX, int myY)
		{
		}

		// Token: 0x06002ABC RID: 10940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002ABC")]
		[Address(RVA = "0x14CEF1C", Offset = "0x14CEF1C", VA = "0x14CEF1C")]
		public void RemoveAllGrapplingHooks()
		{
		}

		// Token: 0x06002ABD RID: 10941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002ABD")]
		[Address(RVA = "0x1558EF0", Offset = "0x1558EF0", VA = "0x1558EF0")]
		public void RemoveAllFishingBobbers()
		{
		}

		// Token: 0x06002ABE RID: 10942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002ABE")]
		[Address(RVA = "0x153BDF4", Offset = "0x153BDF4", VA = "0x153BDF4")]
		private void TileInteractionsMouseOver(int myX, int myY)
		{
		}

		// Token: 0x06002ABF RID: 10943 RVA: 0x00014958 File Offset: 0x00012B58
		[Token(Token = "0x6002ABF")]
		[Address(RVA = "0x1559074", Offset = "0x1559074", VA = "0x1559074")]
		public Color ChatColor()
		{
			return default(Color);
		}

		// Token: 0x06002AC0 RID: 10944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AC0")]
		[Address(RVA = "0x1555A60", Offset = "0x1555A60", VA = "0x1555A60")]
		private void TileInteractionsMouseOver_Containers(int myX, int myY)
		{
		}

		// Token: 0x06002AC1 RID: 10945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AC1")]
		[Address(RVA = "0x1514704", Offset = "0x1514704", VA = "0x1514704")]
		private void TryLandingOnDetonator()
		{
		}

		// Token: 0x06002AC2 RID: 10946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AC2")]
		[Address(RVA = "0x1514154", Offset = "0x1514154", VA = "0x1514154")]
		private void TryBouncingBlocks(bool Falling)
		{
		}

		// Token: 0x06002AC3 RID: 10947 RVA: 0x00014970 File Offset: 0x00012B70
		[Token(Token = "0x6002AC3")]
		[Address(RVA = "0x155912C", Offset = "0x155912C", VA = "0x155912C")]
		public bool CanAcceptItemIntoInventory(WorldItem item)
		{
			return default(bool);
		}

		// Token: 0x06002AC4 RID: 10948 RVA: 0x00014988 File Offset: 0x00012B88
		[Token(Token = "0x6002AC4")]
		[Address(RVA = "0x15591E8", Offset = "0x15591E8", VA = "0x15591E8")]
		public bool CanAcceptItemIntoInventory(Item item)
		{
			return default(bool);
		}

		// Token: 0x06002AC5 RID: 10949 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AC5")]
		[Address(RVA = "0x1559298", Offset = "0x1559298", VA = "0x1559298")]
		private void GrabItems(int i)
		{
		}

		// Token: 0x06002AC6 RID: 10950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AC6")]
		[Address(RVA = "0x155A394", Offset = "0x155A394", VA = "0x155A394")]
		private void PullItem_ToVoidVault(WorldItem itemToPickUp)
		{
		}

		// Token: 0x06002AC7 RID: 10951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AC7")]
		[Address(RVA = "0x155A3B4", Offset = "0x155A3B4", VA = "0x155A3B4")]
		private void PullItem_Common(WorldItem itemToPickUp, float xPullSpeed)
		{
		}

		// Token: 0x06002AC8 RID: 10952 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AC8")]
		[Address(RVA = "0x155A1D8", Offset = "0x155A1D8", VA = "0x155A1D8")]
		private void PullItem_Pickup(WorldItem itemToPickUp, float speed, int acc)
		{
		}

		// Token: 0x06002AC9 RID: 10953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AC9")]
		[Address(RVA = "0x1559B68", Offset = "0x1559B68", VA = "0x1559B68")]
		private void PickupItem(WorldItem itemToPickUp)
		{
		}

		// Token: 0x06002ACA RID: 10954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002ACA")]
		[Address(RVA = "0x155A894", Offset = "0x155A894", VA = "0x155A894")]
		public void Heal(int amount)
		{
		}

		// Token: 0x06002ACB RID: 10955 RVA: 0x000149A0 File Offset: 0x00012BA0
		[Token(Token = "0x6002ACB")]
		[Address(RVA = "0x155A9A4", Offset = "0x155A9A4", VA = "0x155A9A4")]
		public int GetItemGrabRange(WorldItem item)
		{
			return 0;
		}

		// Token: 0x06002ACC RID: 10956 RVA: 0x000149B8 File Offset: 0x00012BB8
		[Token(Token = "0x6002ACC")]
		[Address(RVA = "0x155A9CC", Offset = "0x155A9CC", VA = "0x155A9CC")]
		public int GetItemGrabRange(Item item)
		{
			return 0;
		}

		// Token: 0x06002ACD RID: 10957 RVA: 0x000149D0 File Offset: 0x00012BD0
		[Token(Token = "0x6002ACD")]
		[Address(RVA = "0x155ACAC", Offset = "0x155ACAC", VA = "0x155ACAC")]
		public long SellItemAmount(Item item, int stack = -1)
		{
			return 0L;
		}

		// Token: 0x06002ACE RID: 10958 RVA: 0x000149E8 File Offset: 0x00012BE8
		[Token(Token = "0x6002ACE")]
		[Address(RVA = "0x155B20C", Offset = "0x155B20C", VA = "0x155B20C")]
		public bool SellItem(Item item, int stack = -1)
		{
			return default(bool);
		}

		// Token: 0x06002ACF RID: 10959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002ACF")]
		[Address(RVA = "0x155C1A8", Offset = "0x155C1A8", VA = "0x155C1A8")]
		public void RefreshItems(bool onlyIfVariantChanged = true)
		{
		}

		// Token: 0x06002AD0 RID: 10960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AD0")]
		[Address(RVA = "0x155C60C", Offset = "0x155C60C", VA = "0x155C60C")]
		private void RefreshItems(Item[] array, bool onlyIfVariantChanged)
		{
		}

		// Token: 0x06002AD1 RID: 10961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AD1")]
		[Address(RVA = "0x155AE78", Offset = "0x155AE78", VA = "0x155AE78")]
		public void GetItemExpectedPrice(Item item, out long calcForSelling, out long calcForBuying)
		{
		}

		// Token: 0x06002AD2 RID: 10962 RVA: 0x00014A00 File Offset: 0x00012C00
		[Token(Token = "0x6002AD2")]
		[Address(RVA = "0x155C668", Offset = "0x155C668", VA = "0x155C668")]
		public bool CanAffordItem(long price, int customCurrency = -1)
		{
			return default(bool);
		}

		// Token: 0x06002AD3 RID: 10963 RVA: 0x00014A18 File Offset: 0x00012C18
		[Token(Token = "0x6002AD3")]
		[Address(RVA = "0x1560788", Offset = "0x1560788", VA = "0x1560788")]
		public bool BuyItem(long price, int customCurrency = -1)
		{
			return default(bool);
		}

		// Token: 0x06002AD4 RID: 10964 RVA: 0x00014A30 File Offset: 0x00012C30
		[Token(Token = "0x6002AD4")]
		[Address(RVA = "0x1562044", Offset = "0x1562044", VA = "0x1562044")]
		private static bool TryPurchasing(long price, List<Item[]> inv, List<Point> slotCoins, List<Point> slotsEmpty, List<Point> slotEmptyBank, List<Point> slotEmptyBank2, List<Point> slotEmptyBank3, List<Point> slotEmptyBank4)
		{
			return default(bool);
		}

		// Token: 0x06002AD5 RID: 10965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AD5")]
		[Address(RVA = "0x151CA30", Offset = "0x151CA30", VA = "0x151CA30")]
		public void AdjTiles()
		{
		}

		// Token: 0x06002AD6 RID: 10966 RVA: 0x00014A48 File Offset: 0x00012C48
		[Token(Token = "0x6002AD6")]
		[Address(RVA = "0x1563E58", Offset = "0x1563E58", VA = "0x1563E58")]
		public bool IsTileTypeInInteractionRange(int targetTileType, TileReachCheckSettings settings)
		{
			return default(bool);
		}

		// Token: 0x06002AD7 RID: 10967 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AD7")]
		[Address(RVA = "0x1564228", Offset = "0x1564228", VA = "0x1564228")]
		public void DisplayDollUpdate()
		{
		}

		// Token: 0x06002AD8 RID: 10968 RVA: 0x00014A60 File Offset: 0x00012C60
		[Token(Token = "0x6002AD8")]
		[Address(RVA = "0x15642AC", Offset = "0x15642AC", VA = "0x15642AC")]
		public bool IsColorfulDye(int dye)
		{
			return default(bool);
		}

		// Token: 0x06002AD9 RID: 10969 RVA: 0x00014A78 File Offset: 0x00012C78
		[Token(Token = "0x6002AD9")]
		[Address(RVA = "0x1564340", Offset = "0x1564340", VA = "0x1564340")]
		public bool ShouldDrawFootball()
		{
			return default(bool);
		}

		// Token: 0x06002ADA RID: 10970 RVA: 0x00014A90 File Offset: 0x00012C90
		[Token(Token = "0x6002ADA")]
		[Address(RVA = "0x14DCD3C", Offset = "0x14DCD3C", VA = "0x14DCD3C")]
		public bool CanSpawnWalkingEffects()
		{
			return default(bool);
		}

		// Token: 0x06002ADB RID: 10971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002ADB")]
		[Address(RVA = "0x15643C8", Offset = "0x15643C8", VA = "0x15643C8")]
		public void UpdateDisplayDollLegs()
		{
		}

		// Token: 0x06002ADC RID: 10972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002ADC")]
		[Address(RVA = "0x151F130", Offset = "0x151F130", VA = "0x151F130")]
		public void PlayerFrame()
		{
		}

		// Token: 0x06002ADD RID: 10973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002ADD")]
		[Address(RVA = "0x1565900", Offset = "0x1565900", VA = "0x1565900")]
		private void CancelAllJumpVisualEffects(bool includeDownDash = true)
		{
		}

		// Token: 0x06002ADE RID: 10974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002ADE")]
		[Address(RVA = "0x1565930", Offset = "0x1565930", VA = "0x1565930")]
		private void CancelAllBootRunVisualEffects()
		{
		}

		// Token: 0x06002ADF RID: 10975 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002ADF")]
		[Address(RVA = "0x14DF268", Offset = "0x14DF268", VA = "0x14DF268")]
		private void UpdateFishingBobber(Item item)
		{
		}

		// Token: 0x06002AE0 RID: 10976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AE0")]
		[Address(RVA = "0x14DF0A4", Offset = "0x14DF0A4", VA = "0x14DF0A4")]
		private void UpdateBootVisualEffects(Item item)
		{
		}

		// Token: 0x06002AE1 RID: 10977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AE1")]
		[Address(RVA = "0x1564454", Offset = "0x1564454", VA = "0x1564454")]
		private void UpdateVisibleAccessories()
		{
		}

		// Token: 0x06002AE2 RID: 10978 RVA: 0x00014AA8 File Offset: 0x00012CA8
		[Token(Token = "0x6002AE2")]
		[Address(RVA = "0x156594C", Offset = "0x156594C", VA = "0x156594C")]
		private bool ItemIsVisuallyIncompatible(Item item)
		{
			return default(bool);
		}

		// Token: 0x06002AE3 RID: 10979 RVA: 0x00014AC0 File Offset: 0x00012CC0
		[Token(Token = "0x6002AE3")]
		[Address(RVA = "0x15660E0", Offset = "0x15660E0", VA = "0x15660E0")]
		private bool IsVisibleCapeBad(int accFrontSlot)
		{
			return default(bool);
		}

		// Token: 0x06002AE4 RID: 10980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AE4")]
		[Address(RVA = "0x1565BA4", Offset = "0x1565BA4", VA = "0x1565BA4")]
		private void UpdateVisibleAccessory(int itemSlot, Item item)
		{
		}

		// Token: 0x06002AE5 RID: 10981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AE5")]
		[Address(RVA = "0x1564D60", Offset = "0x1564D60", VA = "0x1564D60")]
		public void SetArmorEffectVisuals(Player drawPlayer)
		{
		}

		// Token: 0x06002AE6 RID: 10982 RVA: 0x00014AD8 File Offset: 0x00012CD8
		[Token(Token = "0x6002AE6")]
		[Address(RVA = "0x1564768", Offset = "0x1564768", VA = "0x1564768")]
		public static int SetMatch(Player.SetMatchRequest request, ref bool somethingSpecial)
		{
			return 0;
		}

		// Token: 0x06002AE7 RID: 10983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AE7")]
		[Address(RVA = "0x14ACFE0", Offset = "0x14ACFE0", VA = "0x14ACFE0")]
		public void Teleport(Vector2 newPos, int Style = 0, int extraInfo = 0)
		{
		}

		// Token: 0x06002AE8 RID: 10984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AE8")]
		[Address(RVA = "0x15660FC", Offset = "0x15660FC", VA = "0x15660FC")]
		public void DoPotionOfReturnTeleportationAndSetTheComebackPoint()
		{
		}

		// Token: 0x06002AE9 RID: 10985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AE9")]
		[Address(RVA = "0x1566294", Offset = "0x1566294", VA = "0x1566294")]
		public void DoPotionOfReturnReturnToOriginalUsePosition()
		{
		}

		// Token: 0x06002AEA RID: 10986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AEA")]
		[Address(RVA = "0x156647C", Offset = "0x156647C", VA = "0x156647C")]
		public void AutoFinchStaff()
		{
		}

		// Token: 0x06002AEB RID: 10987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AEB")]
		[Address(RVA = "0x14E5C88", Offset = "0x14E5C88", VA = "0x14E5C88")]
		public void Spawn(PlayerSpawnContext context)
		{
		}

		// Token: 0x06002AEC RID: 10988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AEC")]
		[Address(RVA = "0x1566BA8", Offset = "0x1566BA8", VA = "0x1566BA8")]
		public void ResetFallDamage()
		{
		}

		// Token: 0x06002AED RID: 10989 RVA: 0x00014AF0 File Offset: 0x00012CF0
		[Token(Token = "0x6002AED")]
		[Address(RVA = "0x1566F9C", Offset = "0x1566F9C", VA = "0x1566F9C")]
		public bool Spawn_GetPositionAtWorldSpawn(ref int floorX, ref int floorY)
		{
			return default(bool);
		}

		// Token: 0x06002AEE RID: 10990 RVA: 0x00014B08 File Offset: 0x00012D08
		[Token(Token = "0x6002AEE")]
		[Address(RVA = "0x156702C", Offset = "0x156702C", VA = "0x156702C")]
		public bool Spawn_GetPositionAtSpawn(int spawnX, int spawnY, ref int floorX, ref int floorY)
		{
			return default(bool);
		}

		// Token: 0x06002AEF RID: 10991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AEF")]
		[Address(RVA = "0x1566A04", Offset = "0x1566A04", VA = "0x1566A04")]
		private void Spawn_SetPositionAtWorldSpawn()
		{
		}

		// Token: 0x06002AF0 RID: 10992 RVA: 0x00014B20 File Offset: 0x00012D20
		[Token(Token = "0x6002AF0")]
		[Address(RVA = "0x1567C94", Offset = "0x1567C94", VA = "0x1567C94")]
		public static Point Spawn_DescendFromDefaultSpace(int x, int y, out bool validSpace)
		{
			return default(Point);
		}

		// Token: 0x06002AF1 RID: 10993 RVA: 0x00014B38 File Offset: 0x00012D38
		[Token(Token = "0x6002AF1")]
		[Address(RVA = "0x15682F8", Offset = "0x15682F8", VA = "0x15682F8")]
		private static Point Spawn_DescendFromDefaultSpace_Inner(int x, int y, out bool validSpace, bool singleBlockAllowed = false)
		{
			return default(Point);
		}

		// Token: 0x06002AF2 RID: 10994 RVA: 0x00014B50 File Offset: 0x00012D50
		[Token(Token = "0x6002AF2")]
		[Address(RVA = "0x156881C", Offset = "0x156881C", VA = "0x156881C")]
		public static bool Spawn_ValidSpawnFloor(int tX, int tY)
		{
			return default(bool);
		}

		// Token: 0x06002AF3 RID: 10995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AF3")]
		[Address(RVA = "0x1567D88", Offset = "0x1567D88", VA = "0x1567D88")]
		public static void Spawn_ForceClearArea(int floorX, int floorY)
		{
		}

		// Token: 0x06002AF4 RID: 10996 RVA: 0x00014B68 File Offset: 0x00012D68
		[Token(Token = "0x6002AF4")]
		[Address(RVA = "0x156728C", Offset = "0x156728C", VA = "0x156728C")]
		public static bool Spawn_IsAreaValidSpawn(int floorX, int floorY, bool generatingSpawn = false)
		{
			return default(bool);
		}

		// Token: 0x06002AF5 RID: 10997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AF5")]
		[Address(RVA = "0x156679C", Offset = "0x156679C", VA = "0x156679C")]
		private void Spawn_SetPosition(int floorX, int floorY)
		{
		}

		// Token: 0x06002AF6 RID: 10998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AF6")]
		[Address(RVA = "0x15667D8", Offset = "0x15667D8", VA = "0x15667D8")]
		private void Spawn_SetPositionAtTeamSpawn(PlayerSpawnContext context)
		{
		}

		// Token: 0x06002AF7 RID: 10999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AF7")]
		[Address(RVA = "0x1568D48", Offset = "0x1568D48", VA = "0x1568D48")]
		public void SetImmuneTimeForAllTypes(int time)
		{
		}

		// Token: 0x06002AF8 RID: 11000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AF8")]
		[Address(RVA = "0x1568DB0", Offset = "0x1568DB0", VA = "0x1568DB0")]
		public void ShadowDodge()
		{
		}

		// Token: 0x06002AF9 RID: 11001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AF9")]
		[Address(RVA = "0x1568F70", Offset = "0x1568F70", VA = "0x1568F70")]
		private void PutHallowedArmorSetBonusOnCooldown()
		{
		}

		// Token: 0x06002AFA RID: 11002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AFA")]
		[Address(RVA = "0x1568F7C", Offset = "0x1568F7C", VA = "0x1568F7C")]
		public void BrainOfConfusionDodge()
		{
		}

		// Token: 0x06002AFB RID: 11003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AFB")]
		[Address(RVA = "0x15690F4", Offset = "0x15690F4", VA = "0x15690F4")]
		public void DoMysticSashDodge()
		{
		}

		// Token: 0x06002AFC RID: 11004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AFC")]
		[Address(RVA = "0x156A26C", Offset = "0x156A26C", VA = "0x156A26C")]
		public void NinjaDodge()
		{
		}

		// Token: 0x06002AFD RID: 11005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AFD")]
		[Address(RVA = "0x14E1B0C", Offset = "0x14E1B0C", VA = "0x14E1B0C")]
		public void ApplyArmorSoundAndDustChanges()
		{
		}

		// Token: 0x06002AFE RID: 11006 RVA: 0x00014B80 File Offset: 0x00012D80
		[Token(Token = "0x6002AFE")]
		[Address(RVA = "0x156B334", Offset = "0x156B334", VA = "0x156B334")]
		public bool CanDefendWithPaladinsShield(int otherPlayerTeam)
		{
			return default(bool);
		}

		// Token: 0x06002AFF RID: 11007 RVA: 0x00014B98 File Offset: 0x00012D98
		[Token(Token = "0x6002AFF")]
		[Address(RVA = "0x14CB118", Offset = "0x14CB118", VA = "0x14CB118")]
		public double Hurt(PlayerDeathReason damageSource, int Damage, int hitDirection, bool pvp = false, bool quiet = false, bool Crit = false, int cooldownCounter = -1, bool dodgeable = true)
		{
			return 0.0;
		}

		// Token: 0x06002B00 RID: 11008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B00")]
		[Address(RVA = "0x156B5F8", Offset = "0x156B5F8", VA = "0x156B5F8")]
		public void PlayHurtSound()
		{
		}

		// Token: 0x06002B01 RID: 11009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B01")]
		[Address(RVA = "0x156BFB0", Offset = "0x156BFB0", VA = "0x156BFB0")]
		private void PlayDeathSound()
		{
		}

		// Token: 0x06002B02 RID: 11010 RVA: 0x00014BB0 File Offset: 0x00012DB0
		[Token(Token = "0x6002B02")]
		[Address(RVA = "0x156B3AC", Offset = "0x156B3AC", VA = "0x156B3AC")]
		private static bool AllowShimmerDodge(PlayerDeathReason damageSource, int cooldownCounter, bool dodgeable)
		{
			return default(bool);
		}

		// Token: 0x06002B03 RID: 11011 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B03")]
		[Address(RVA = "0x156C2B8", Offset = "0x156C2B8", VA = "0x156C2B8")]
		public void HardcoreDeathPenalty()
		{
		}

		// Token: 0x06002B04 RID: 11012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B04")]
		[Address(RVA = "0x156C388", Offset = "0x156C388", VA = "0x156C388")]
		public void KillMeForGood()
		{
		}

		// Token: 0x06002B05 RID: 11013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B05")]
		[Address(RVA = "0x14F15D8", Offset = "0x14F15D8", VA = "0x14F15D8")]
		public void KillMe(PlayerDeathReason damageSource, double dmg, int hitDirection, bool pvp = false)
		{
		}

		// Token: 0x06002B06 RID: 11014 RVA: 0x00014BC8 File Offset: 0x00012DC8
		[Token(Token = "0x6002B06")]
		[Address(RVA = "0x156D8F8", Offset = "0x156D8F8", VA = "0x156D8F8")]
		public bool AllowsRespawnTimerSkip()
		{
			return default(bool);
		}

		// Token: 0x06002B07 RID: 11015 RVA: 0x00014BE0 File Offset: 0x00012DE0
		[Token(Token = "0x6002B07")]
		[Address(RVA = "0x156DA54", Offset = "0x156DA54", VA = "0x156DA54")]
		private bool NearAnyNPCsThatBlockRespawn()
		{
			return default(bool);
		}

		// Token: 0x06002B08 RID: 11016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B08")]
		[Address(RVA = "0x156DF8C", Offset = "0x156DF8C", VA = "0x156DF8C")]
		public void SkipRespawnTime()
		{
		}

		// Token: 0x06002B09 RID: 11017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B09")]
		[Address(RVA = "0x156CA20", Offset = "0x156CA20", VA = "0x156CA20")]
		private void KillMe_DustExplosion(PlayerDeathReason damageSource, int hitDirection)
		{
		}

		// Token: 0x06002B0A RID: 11018 RVA: 0x00014BF8 File Offset: 0x00012DF8
		[Token(Token = "0x6002B0A")]
		[Address(RVA = "0x156CF40", Offset = "0x156CF40", VA = "0x156CF40")]
		private int GetRespawnTime(bool pvp)
		{
			return 0;
		}

		// Token: 0x06002B0B RID: 11019 RVA: 0x00014C10 File Offset: 0x00012E10
		[Token(Token = "0x6002B0B")]
		[Address(RVA = "0x156DDEC", Offset = "0x156DDEC", VA = "0x156DDEC")]
		private bool AnyBossHindersRespawnTime()
		{
			return default(bool);
		}

		// Token: 0x06002B0C RID: 11020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B0C")]
		[Address(RVA = "0x156D2D0", Offset = "0x156D2D0", VA = "0x156D2D0")]
		public void DropTombstone(long coinsOwned, NetworkText deathText, int hitDirection)
		{
		}

		// Token: 0x06002B0D RID: 11021 RVA: 0x00014C28 File Offset: 0x00012E28
		[Token(Token = "0x6002B0D")]
		[Address(RVA = "0x155A1C8", Offset = "0x155A1C8", VA = "0x155A1C8")]
		public bool CanPullItem(WorldItem item, Player.ItemSpaceStatus status)
		{
			return default(bool);
		}

		// Token: 0x06002B0E RID: 11022 RVA: 0x00014C40 File Offset: 0x00012E40
		[Token(Token = "0x6002B0E")]
		[Address(RVA = "0x156DF98", Offset = "0x156DF98", VA = "0x156DF98")]
		public Player.ItemSpaceStatus ItemSpace(WorldItem newItem)
		{
			return default(Player.ItemSpaceStatus);
		}

		// Token: 0x06002B0F RID: 11023 RVA: 0x00014C58 File Offset: 0x00012E58
		[Token(Token = "0x6002B0F")]
		[Address(RVA = "0x156DFC0", Offset = "0x156DFC0", VA = "0x156DFC0")]
		public Player.ItemSpaceStatus ItemSpace(Item newItem)
		{
			return default(Player.ItemSpaceStatus);
		}

		// Token: 0x06002B10 RID: 11024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B10")]
		[Address(RVA = "0x155A198", Offset = "0x155A198", VA = "0x155A198")]
		public void ItemSpace(WorldItem newItem, ref Player.ItemSpaceStatus status)
		{
		}

		// Token: 0x06002B11 RID: 11025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B11")]
		[Address(RVA = "0x156E5F4", Offset = "0x156E5F4", VA = "0x156E5F4")]
		public void ItemSpace(Item newItem, ref Player.ItemSpaceStatus result)
		{
		}

		// Token: 0x06002B12 RID: 11026 RVA: 0x00014C70 File Offset: 0x00012E70
		[Token(Token = "0x6002B12")]
		[Address(RVA = "0x156E53C", Offset = "0x156E53C", VA = "0x156E53C")]
		public bool ItemSpaceForCofveve(Item newItem)
		{
			return default(bool);
		}

		// Token: 0x06002B13 RID: 11027 RVA: 0x00014C88 File Offset: 0x00012E88
		[Token(Token = "0x6002B13")]
		[Address(RVA = "0x156E404", Offset = "0x156E404", VA = "0x156E404")]
		public bool CanItemSlotAcceptPickup(Item theSlot, Item theItemToAccept)
		{
			return default(bool);
		}

		// Token: 0x06002B14 RID: 11028 RVA: 0x00014CA0 File Offset: 0x00012EA0
		[Token(Token = "0x6002B14")]
		[Address(RVA = "0x156E4E0", Offset = "0x156E4E0", VA = "0x156E4E0")]
		public bool CanGoIntoAmmoOnPickup(Item theSlot, Item theItemToAccept)
		{
			return default(bool);
		}

		// Token: 0x06002B15 RID: 11029 RVA: 0x00014CB8 File Offset: 0x00012EB8
		[Token(Token = "0x6002B15")]
		[Address(RVA = "0x155BF20", Offset = "0x155BF20", VA = "0x155BF20")]
		public bool DoCoins(int i)
		{
			return default(bool);
		}

		// Token: 0x06002B16 RID: 11030 RVA: 0x00014CD0 File Offset: 0x00012ED0
		[Token(Token = "0x6002B16")]
		[Address(RVA = "0x156EB38", Offset = "0x156EB38", VA = "0x156EB38")]
		public bool CanFillAmmo(Item newItem)
		{
			return default(bool);
		}

		// Token: 0x06002B17 RID: 11031 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B17")]
		[Address(RVA = "0x156EDE4", Offset = "0x156EDE4", VA = "0x156EDE4")]
		public Item FillAmmo(Item newItem, GetItemSettings settings)
		{
			return null;
		}

		// Token: 0x06002B18 RID: 11032 RVA: 0x00014CE8 File Offset: 0x00012EE8
		[Token(Token = "0x6002B18")]
		[Address(RVA = "0x156F69C", Offset = "0x156F69C", VA = "0x156F69C")]
		public bool CanStoreItem(Item newItem)
		{
			return default(bool);
		}

		// Token: 0x06002B19 RID: 11033 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B19")]
		[Address(RVA = "0x14A6088", Offset = "0x14A6088", VA = "0x14A6088")]
		public Item GetItemDropAtPlayer(Item newItem, GetItemSettings settings, bool disableMerge = false)
		{
			return null;
		}

		// Token: 0x06002B1A RID: 11034 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B1A")]
		[Address(RVA = "0x14A6168", Offset = "0x14A6168", VA = "0x14A6168")]
		public Item GetItem(Item newItem, GetItemSettings settings, bool disableMerge = false)
		{
			return null;
		}

		// Token: 0x06002B1B RID: 11035 RVA: 0x00014D00 File Offset: 0x00012F00
		[Token(Token = "0x6002B1B")]
		[Address(RVA = "0x156FE70", Offset = "0x156FE70", VA = "0x156FE70")]
		private bool GetItem_VoidVault(Item[] inventory, Item newItem, GetItemSettings settings, Item returnItem)
		{
			return default(bool);
		}

		// Token: 0x06002B1C RID: 11036 RVA: 0x00014D18 File Offset: 0x00012F18
		[Token(Token = "0x6002B1C")]
		[Address(RVA = "0x156EB00", Offset = "0x156EB00", VA = "0x156EB00")]
		private bool CanVoidVaultAccept(Item item)
		{
			return default(bool);
		}

		// Token: 0x06002B1D RID: 11037 RVA: 0x00014D30 File Offset: 0x00012F30
		[Token(Token = "0x6002B1D")]
		[Address(RVA = "0x15704CC", Offset = "0x15704CC", VA = "0x15704CC")]
		private bool GetItem_FillIntoOccupiedSlot_VoidBag(Item[] inv, Item newItem, GetItemSettings settings, Item returnItem, int i)
		{
			return default(bool);
		}

		// Token: 0x06002B1E RID: 11038 RVA: 0x00014D48 File Offset: 0x00012F48
		[Token(Token = "0x6002B1E")]
		[Address(RVA = "0x15709F4", Offset = "0x15709F4", VA = "0x15709F4")]
		private int GetFittingItemSlotContext(int itemSlot)
		{
			return 0;
		}

		// Token: 0x06002B1F RID: 11039 RVA: 0x00014D60 File Offset: 0x00012F60
		[Token(Token = "0x6002B1F")]
		[Address(RVA = "0x1570A10", Offset = "0x1570A10", VA = "0x1570A10")]
		private bool GetItem_FillIntoOccupiedSlot(Item newItem, GetItemSettings settings, Item returnItem, int i)
		{
			return default(bool);
		}

		// Token: 0x06002B20 RID: 11040 RVA: 0x00014D78 File Offset: 0x00012F78
		[Token(Token = "0x6002B20")]
		[Address(RVA = "0x1570244", Offset = "0x1570244", VA = "0x1570244")]
		private bool GetItem_FillEmptyInventorySlot_VoidBag(Item[] inv, Item newItem, GetItemSettings settings, Item returnItem, int i)
		{
			return default(bool);
		}

		// Token: 0x06002B21 RID: 11041 RVA: 0x00014D90 File Offset: 0x00012F90
		[Token(Token = "0x6002B21")]
		[Address(RVA = "0x156FA50", Offset = "0x156FA50", VA = "0x156FA50")]
		private bool GetItem_FillEmptyInventorySlot(Item newItem, GetItemSettings settings, Item returnItem, int i)
		{
			return default(bool);
		}

		// Token: 0x06002B22 RID: 11042 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B22")]
		[Address(RVA = "0x15710CC", Offset = "0x15710CC", VA = "0x15710CC")]
		public void PlaceThing(bool doPlacementAction, ref Player.ItemCheckContext context)
		{
		}

		// Token: 0x06002B23 RID: 11043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B23")]
		[Address(RVA = "0x1576680", Offset = "0x1576680", VA = "0x1576680")]
		private void PlaceThing_Walls()
		{
		}

		// Token: 0x06002B24 RID: 11044 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B24")]
		[Address(RVA = "0x15785A0", Offset = "0x15785A0", VA = "0x15785A0")]
		private void PlaceThing_Walls_FillEmptySpace()
		{
		}

		// Token: 0x06002B25 RID: 11045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B25")]
		[Address(RVA = "0x1575EC8", Offset = "0x1575EC8", VA = "0x1575EC8")]
		private void PlaceThing_Tiles(bool doPlacementAction)
		{
		}

		// Token: 0x06002B26 RID: 11046 RVA: 0x00014DA8 File Offset: 0x00012FA8
		[Token(Token = "0x6002B26")]
		[Address(RVA = "0x157B6BC", Offset = "0x157B6BC", VA = "0x157B6BC")]
		public bool PlaceThing_IsReplaceableBlock(Tile targetTile)
		{
			return default(bool);
		}

		// Token: 0x06002B27 RID: 11047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B27")]
		[Address(RVA = "0x157BE9C", Offset = "0x157BE9C", VA = "0x157BE9C")]
		private void PlaceThing_Tiles_TryPlacing(int tileToCreate, bool? overrideCanPlace, int? forcedRandom, TileObject data, int placeStyle)
		{
		}

		// Token: 0x06002B28 RID: 11048 RVA: 0x00014DC0 File Offset: 0x00012FC0
		[Token(Token = "0x6002B28")]
		[Address(RVA = "0x158ACF8", Offset = "0x158ACF8", VA = "0x158ACF8")]
		private bool ModifyFlexibleWandPlacementInfo(ref int tileType, ref int tileStyle, ref int? forcedRandom)
		{
			return default(bool);
		}

		// Token: 0x06002B29 RID: 11049 RVA: 0x00014DD8 File Offset: 0x00012FD8
		[Token(Token = "0x6002B29")]
		[Address(RVA = "0x1577EE8", Offset = "0x1577EE8", VA = "0x1577EE8")]
		private bool PlaceThing_TryReplacingWalls(bool canUse)
		{
			return default(bool);
		}

		// Token: 0x06002B2A RID: 11050 RVA: 0x00014DF0 File Offset: 0x00012FF0
		[Token(Token = "0x6002B2A")]
		[Address(RVA = "0x158B0B4", Offset = "0x158B0B4", VA = "0x158B0B4")]
		private bool PlaceThing_ValidWallForReplacement()
		{
			return default(bool);
		}

		// Token: 0x06002B2B RID: 11051 RVA: 0x00014E08 File Offset: 0x00013008
		[Token(Token = "0x6002B2B")]
		[Address(RVA = "0x157A4F8", Offset = "0x157A4F8", VA = "0x157A4F8")]
		private bool PlaceThing_TryReplacingTiles(bool canUse)
		{
			return default(bool);
		}

		// Token: 0x06002B2C RID: 11052 RVA: 0x00014E20 File Offset: 0x00013020
		[Token(Token = "0x6002B2C")]
		[Address(RVA = "0x158B4CC", Offset = "0x158B4CC", VA = "0x158B4CC")]
		private bool PlaceThing_ValidTileForReplacement()
		{
			return default(bool);
		}

		// Token: 0x06002B2D RID: 11053 RVA: 0x00014E38 File Offset: 0x00013038
		[Token(Token = "0x6002B2D")]
		[Address(RVA = "0x1592058", Offset = "0x1592058", VA = "0x1592058")]
		private bool PlaceThing_CheckPlatformSolidityForBlockSwap(int tileTypeBeingPlaced, int tileTypeCurrentlyPlaced, int tileX, int tileY)
		{
			return default(bool);
		}

		// Token: 0x06002B2E RID: 11054 RVA: 0x00014E50 File Offset: 0x00013050
		[Token(Token = "0x6002B2E")]
		[Address(RVA = "0x1591BA8", Offset = "0x1591BA8", VA = "0x1591BA8")]
		private bool PlaceThing_CheckSpecificValidtyCaseForBlockSwap(int tileTypeBeingPlaced, int tileTypeCurrentlyPlaced, int liquidTypeCurrentPlaced, int liquidAmountCurrentlyPlaced)
		{
			return default(bool);
		}

		// Token: 0x06002B2F RID: 11055 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B2F")]
		[Address(RVA = "0x158D170", Offset = "0x158D170", VA = "0x158D170")]
		public Item GetBestPickaxe()
		{
			return null;
		}

		// Token: 0x06002B30 RID: 11056 RVA: 0x00014E68 File Offset: 0x00013068
		[Token(Token = "0x6002B30")]
		[Address(RVA = "0x158A094", Offset = "0x158A094", VA = "0x158A094")]
		private TileObject PlaceThing_Tiles_PlaceIt(bool newObjectType, TileObject data, int tileToCreate)
		{
			return default(TileObject);
		}

		// Token: 0x06002B31 RID: 11057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B31")]
		[Address(RVA = "0x1595498", Offset = "0x1595498", VA = "0x1595498")]
		public void PlaceThing_Tiles_PlaceIt_ConsumeFlexibleWandMaterial()
		{
		}

		// Token: 0x06002B32 RID: 11058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B32")]
		[Address(RVA = "0x14CE3B4", Offset = "0x14CE3B4", VA = "0x14CE3B4")]
		private void TorchGodsFlavor()
		{
		}

		// Token: 0x06002B33 RID: 11059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B33")]
		[Address(RVA = "0x158FEF0", Offset = "0x158FEF0", VA = "0x158FEF0")]
		public void BiomeTorchPlaceStyle(ref int type, ref int style, bool useWithoutTorchGodsFavor = false)
		{
		}

		// Token: 0x06002B34 RID: 11060 RVA: 0x00014E80 File Offset: 0x00013080
		[Token(Token = "0x6002B34")]
		[Address(RVA = "0x1596C2C", Offset = "0x1596C2C", VA = "0x1596C2C")]
		public int BiomeTorchHoldStyle(int itemType)
		{
			return 0;
		}

		// Token: 0x06002B35 RID: 11061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B35")]
		[Address(RVA = "0x15901A4", Offset = "0x15901A4", VA = "0x15901A4")]
		public void BiomeCampfirePlaceStyle(ref int type, ref int style)
		{
		}

		// Token: 0x06002B36 RID: 11062 RVA: 0x00014E98 File Offset: 0x00013098
		[Token(Token = "0x6002B36")]
		[Address(RVA = "0x1596EC0", Offset = "0x1596EC0", VA = "0x1596EC0")]
		public int BiomeCampfireHoldStyle(int itemType)
		{
			return 0;
		}

		// Token: 0x06002B37 RID: 11063 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B37")]
		[Address(RVA = "0x158F984", Offset = "0x158F984", VA = "0x158F984")]
		private Vector3[,] PlaceThing_Tiles_GetAutoAccessoryCache()
		{
			return null;
		}

		// Token: 0x06002B38 RID: 11064 RVA: 0x00014EB0 File Offset: 0x000130B0
		[Token(Token = "0x6002B38")]
		[Address(RVA = "0x15921F8", Offset = "0x15921F8", VA = "0x15921F8")]
		private int PlaceThing_Tiles_PlaceIt_GetLegacyTileStyle(int style)
		{
			return 0;
		}

		// Token: 0x06002B39 RID: 11065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B39")]
		[Address(RVA = "0x1595600", Offset = "0x1595600", VA = "0x1595600")]
		private void PlaceThing_Tiles_PlaceIt_UnslopeForSolids()
		{
		}

		// Token: 0x06002B3A RID: 11066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B3A")]
		[Address(RVA = "0x1595F74", Offset = "0x1595F74", VA = "0x1595F74")]
		private void PlaceThing_Tiles_PlaceIt_KillGrassForSolids()
		{
		}

		// Token: 0x06002B3B RID: 11067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B3B")]
		[Address(RVA = "0x1590450", Offset = "0x1590450", VA = "0x1590450")]
		private void PlaceThing_Tiles_PlaceIt_AutoPaintAndActuate(Vector3[,] tileDataCaches, int tileToCreate)
		{
		}

		// Token: 0x06002B3C RID: 11068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B3C")]
		[Address(RVA = "0x1593620", Offset = "0x1593620", VA = "0x1593620")]
		private void PlaceThing_Tiles_PlaceIt_SpinSmartPlatform()
		{
		}

		// Token: 0x06002B3D RID: 11069 RVA: 0x00014EC8 File Offset: 0x000130C8
		[Token(Token = "0x6002B3D")]
		[Address(RVA = "0x1597158", Offset = "0x1597158", VA = "0x1597158")]
		public static int GetSmartPlatformSlope(int x, int y)
		{
			return 0;
		}

		// Token: 0x06002B3E RID: 11070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B3E")]
		[Address(RVA = "0x15933D8", Offset = "0x15933D8", VA = "0x15933D8")]
		private void PlaceThing_Tiles_PlaceIt_TriggerLogicLamp()
		{
		}

		// Token: 0x06002B3F RID: 11071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B3F")]
		[Address(RVA = "0x15929E8", Offset = "0x15929E8", VA = "0x15929E8")]
		private void PlaceThing_Tiles_PlaceIt_SpinBedsAndBaths()
		{
		}

		// Token: 0x06002B40 RID: 11072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B40")]
		[Address(RVA = "0x15924DC", Offset = "0x15924DC", VA = "0x15924DC")]
		private void PlaceThing_Tiles_PlaceIt_SpinChairs()
		{
		}

		// Token: 0x06002B41 RID: 11073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B41")]
		[Address(RVA = "0x1593018", Offset = "0x1593018", VA = "0x1593018")]
		private void PlaceThing_Tiles_PlaceIt_SpinTraps()
		{
		}

		// Token: 0x06002B42 RID: 11074 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B42")]
		[Address(RVA = "0x1592BE8", Offset = "0x1592BE8", VA = "0x1592BE8")]
		private void PlaceThing_Tiles_PlaceIt_AdjustPlants()
		{
		}

		// Token: 0x06002B43 RID: 11075 RVA: 0x00014EE0 File Offset: 0x000130E0
		[Token(Token = "0x6002B43")]
		[Address(RVA = "0x15985AC", Offset = "0x15985AC", VA = "0x15985AC")]
		private bool PlaceThing_Tiles_PlaceIt_StaffOfRegrowthCheck(bool placed)
		{
			return default(bool);
		}

		// Token: 0x06002B44 RID: 11076 RVA: 0x00014EF8 File Offset: 0x000130F8
		[Token(Token = "0x6002B44")]
		[Address(RVA = "0x157D060", Offset = "0x157D060", VA = "0x157D060")]
		private bool PlaceThing_Tiles_BlockPlacementForAssortedThings(bool canPlace)
		{
			return default(bool);
		}

		// Token: 0x06002B45 RID: 11077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B45")]
		[Address(RVA = "0x157C6A0", Offset = "0x157C6A0", VA = "0x157C6A0")]
		private static void PlaceThing_Tiles_BlockPlacementForRepeatedPumpkins(ref bool canPlace, ref TileObject data)
		{
		}

		// Token: 0x06002B46 RID: 11078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B46")]
		[Address(RVA = "0x157CD4C", Offset = "0x157CD4C", VA = "0x157CD4C")]
		private static void PlaceThing_Tiles_BlockPlacementForRepeatedRainbowBoulders(ref bool canPlace, ref TileObject data)
		{
		}

		// Token: 0x06002B47 RID: 11079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B47")]
		[Address(RVA = "0x157C8F8", Offset = "0x157C8F8", VA = "0x157C8F8")]
		private static void PlaceThing_Tiles_BlockPlacementForRepeatedCoralAndBeachPiles(ref bool canPlace, ref TileObject data)
		{
		}

		// Token: 0x06002B48 RID: 11080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B48")]
		[Address(RVA = "0x157C3B8", Offset = "0x157C3B8", VA = "0x157C3B8")]
		private static void PlaceThing_Tiles_BlockPlacementForRepeatedPigronatas(ref bool canPlace, ref TileObject data)
		{
		}

		// Token: 0x06002B49 RID: 11081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B49")]
		[Address(RVA = "0x157C16C", Offset = "0x157C16C", VA = "0x157C16C")]
		private static void PlaceThing_Tiles_BlockPlacementIfOverPlayers(ref bool canPlace, ref TileObject data)
		{
		}

		// Token: 0x06002B4A RID: 11082 RVA: 0x00014F10 File Offset: 0x00013110
		[Token(Token = "0x6002B4A")]
		[Address(RVA = "0x157B4F4", Offset = "0x157B4F4", VA = "0x157B4F4")]
		private bool PlaceThing_Tiles_IsBlockedByLava(int createTile, int placeStyle, Tile targetTile)
		{
			return default(bool);
		}

		// Token: 0x06002B4B RID: 11083 RVA: 0x00014F28 File Offset: 0x00013128
		[Token(Token = "0x6002B4B")]
		[Address(RVA = "0x1579108", Offset = "0x1579108", VA = "0x1579108")]
		private bool PlaceThing_Tiles_CheckRopeUsability(bool canUse)
		{
			return default(bool);
		}

		// Token: 0x06002B4C RID: 11084 RVA: 0x00014F40 File Offset: 0x00013140
		[Token(Token = "0x6002B4C")]
		[Address(RVA = "0x157A408", Offset = "0x157A408", VA = "0x157A408")]
		private bool PlaceThing_Tiles_CheckFlexibleWand(bool canUse)
		{
			return default(bool);
		}

		// Token: 0x06002B4D RID: 11085 RVA: 0x00014F58 File Offset: 0x00013158
		[Token(Token = "0x6002B4D")]
		[Address(RVA = "0x159A480", Offset = "0x159A480", VA = "0x159A480")]
		public bool TryGetFlexibleWandAvailableUsageCount(Item wandItem, out int amount)
		{
			return default(bool);
		}

		// Token: 0x06002B4E RID: 11086 RVA: 0x00014F70 File Offset: 0x00013170
		[Token(Token = "0x6002B4E")]
		[Address(RVA = "0x1579014", Offset = "0x1579014", VA = "0x1579014")]
		private bool PlaceThing_Tiles_CheckWandUsability(bool canUse)
		{
			return default(bool);
		}

		// Token: 0x06002B4F RID: 11087 RVA: 0x00014F88 File Offset: 0x00013188
		[Token(Token = "0x6002B4F")]
		[Address(RVA = "0x1578EB0", Offset = "0x1578EB0", VA = "0x1578EB0")]
		private bool PlaceThing_Tiles_CheckGamepadTorchUsability(bool canUse)
		{
			return default(bool);
		}

		// Token: 0x06002B50 RID: 11088 RVA: 0x00014FA0 File Offset: 0x000131A0
		[Token(Token = "0x6002B50")]
		[Address(RVA = "0x159A590", Offset = "0x159A590", VA = "0x159A590")]
		public bool CanPlaceChestLockAtTarget()
		{
			return default(bool);
		}

		// Token: 0x06002B51 RID: 11089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B51")]
		[Address(RVA = "0x15750D8", Offset = "0x15750D8", VA = "0x15750D8")]
		private void PlaceThing_LockChest()
		{
		}

		// Token: 0x06002B52 RID: 11090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B52")]
		[Address(RVA = "0x157477C", Offset = "0x157477C", VA = "0x157477C")]
		private void PlaceThing_ItemInExtractinator(ref Player.ItemCheckContext context)
		{
		}

		// Token: 0x06002B53 RID: 11091 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B53")]
		[Address(RVA = "0x14EA08C", Offset = "0x14EA08C", VA = "0x14EA08C")]
		private static ItemTrader TryGettingItemTraderFromBlock(Tile targetBlock)
		{
			return null;
		}

		// Token: 0x06002B54 RID: 11092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B54")]
		[Address(RVA = "0x157241C", Offset = "0x157241C", VA = "0x157241C")]
		private void PlaceThing_XMasTreeTops()
		{
		}

		// Token: 0x06002B55 RID: 11093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B55")]
		[Address(RVA = "0x1571EC0", Offset = "0x1571EC0", VA = "0x1571EC0")]
		private void PlaceThing_CannonBall()
		{
		}

		// Token: 0x06002B56 RID: 11094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B56")]
		[Address(RVA = "0x1571B18", Offset = "0x1571B18", VA = "0x1571B18")]
		private void PlaceThing_PaintScraper()
		{
		}

		// Token: 0x06002B57 RID: 11095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B57")]
		[Address(RVA = "0x159B890", Offset = "0x159B890", VA = "0x159B890")]
		private void PlaceThing_PaintScraper_LongMoss(int x, int y)
		{
		}

		// Token: 0x06002B58 RID: 11096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B58")]
		[Address(RVA = "0x159B188", Offset = "0x159B188", VA = "0x159B188")]
		private void PlaceThing_PaintScraper_TryScraping(int x, int y)
		{
		}

		// Token: 0x06002B59 RID: 11097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B59")]
		[Address(RVA = "0x157163C", Offset = "0x157163C", VA = "0x157163C")]
		private void PlaceThing_PaintRoller()
		{
		}

		// Token: 0x06002B5A RID: 11098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B5A")]
		[Address(RVA = "0x157114C", Offset = "0x157114C", VA = "0x157114C")]
		private void PlaceThing_Paintbrush()
		{
		}

		// Token: 0x06002B5B RID: 11099 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B5B")]
		[Address(RVA = "0x159BE78", Offset = "0x159BE78", VA = "0x159BE78")]
		public Item FindPaintOrCoating()
		{
			return null;
		}

		// Token: 0x06002B5C RID: 11100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B5C")]
		[Address(RVA = "0x1578E2C", Offset = "0x1578E2C", VA = "0x1578E2C")]
		private void TryPainting(int x, int y, bool paintingAWall = false, bool applyItemAnimation = true)
		{
		}

		// Token: 0x06002B5D RID: 11101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B5D")]
		[Address(RVA = "0x159C0CC", Offset = "0x159C0CC", VA = "0x159C0CC")]
		private void ApplyCoating(int x, int y, bool paintingAWall, bool applyItemAnimation, Item targetItem)
		{
		}

		// Token: 0x06002B5E RID: 11102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B5E")]
		[Address(RVA = "0x159C328", Offset = "0x159C328", VA = "0x159C328")]
		private void ApplyPaint(int x, int y, bool paintingAWall, bool applyItemAnimation, Item targetItem)
		{
		}

		// Token: 0x06002B5F RID: 11103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B5F")]
		[Address(RVA = "0x159AC64", Offset = "0x159AC64", VA = "0x159AC64")]
		private void ShootFromCannon(int x, int y)
		{
		}

		// Token: 0x06002B60 RID: 11104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B60")]
		[Address(RVA = "0x159AC14", Offset = "0x159AC14", VA = "0x159AC14")]
		private void ExtractinatorUse(int extractType, int extractinatorBlockType)
		{
		}

		// Token: 0x06002B61 RID: 11105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B61")]
		[Address(RVA = "0x159A8FC", Offset = "0x159A8FC", VA = "0x159A8FC")]
		private void DropItemFromExtractinator(int itemType, int stack)
		{
		}

		// Token: 0x06002B62 RID: 11106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B62")]
		[Address(RVA = "0x14F6A04", Offset = "0x14F6A04", VA = "0x14F6A04")]
		public void ChangeDir(int dir)
		{
		}

		// Token: 0x06002B63 RID: 11107 RVA: 0x00014FB8 File Offset: 0x000131B8
		[Token(Token = "0x6002B63")]
		[Address(RVA = "0x14E35E4", Offset = "0x14E35E4", VA = "0x14E35E4")]
		public Rectangle getRect()
		{
			return default(Rectangle);
		}

		// Token: 0x06002B64 RID: 11108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B64")]
		[Address(RVA = "0x159C71C", Offset = "0x159C71C", VA = "0x159C71C")]
		public void HorsemansBlade_SpawnPumpkin(int npcIndex, int dmg, float kb)
		{
		}

		// Token: 0x06002B65 RID: 11109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B65")]
		[Address(RVA = "0x159CAE8", Offset = "0x159CAE8", VA = "0x159CAE8")]
		public void PutItemInInventoryFromItemUsage(int type, int theSelectedItem = -1)
		{
		}

		// Token: 0x06002B66 RID: 11110 RVA: 0x00014FD0 File Offset: 0x000131D0
		[Token(Token = "0x6002B66")]
		[Address(RVA = "0x159CCF0", Offset = "0x159CCF0", VA = "0x159CCF0")]
		public bool SummonItemCheck(Item item)
		{
			return default(bool);
		}

		// Token: 0x06002B67 RID: 11111 RVA: 0x00014FE8 File Offset: 0x000131E8
		[Token(Token = "0x6002B67")]
		[Address(RVA = "0x159CEB4", Offset = "0x159CEB4", VA = "0x159CEB4")]
		public PlayerFishingConditions GetFishingConditions()
		{
			return default(PlayerFishingConditions);
		}

		// Token: 0x06002B68 RID: 11112 RVA: 0x00015000 File Offset: 0x00013200
		[Token(Token = "0x6002B68")]
		[Address(RVA = "0x159D460", Offset = "0x159D460", VA = "0x159D460")]
		private static float Fishing_GetPowerMultiplier()
		{
			return 0f;
		}

		// Token: 0x06002B69 RID: 11113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B69")]
		[Address(RVA = "0x159D1A0", Offset = "0x159D1A0", VA = "0x159D1A0")]
		private void Fishing_GetBait(out int baitPower, out int baitType)
		{
		}

		// Token: 0x06002B6A RID: 11114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B6A")]
		[Address(RVA = "0x159D088", Offset = "0x159D088", VA = "0x159D088")]
		private void Fishing_GetBestFishingPole(out int fishingPolePower, out int fishingPoleType)
		{
		}

		// Token: 0x06002B6B RID: 11115 RVA: 0x00015018 File Offset: 0x00013218
		[Token(Token = "0x6002B6B")]
		[Address(RVA = "0x14E6D90", Offset = "0x14E6D90", VA = "0x14E6D90")]
		public bool HasUnityPotion()
		{
			return default(bool);
		}

		// Token: 0x06002B6C RID: 11116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B6C")]
		[Address(RVA = "0x159D840", Offset = "0x159D840", VA = "0x159D840")]
		public void TakeUnityPotion()
		{
		}

		// Token: 0x06002B6D RID: 11117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B6D")]
		[Address(RVA = "0x159DB38", Offset = "0x159DB38", VA = "0x159DB38")]
		public void UnityTeleport(Vector2 telePos)
		{
		}

		// Token: 0x06002B6E RID: 11118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B6E")]
		[Address(RVA = "0x159E070", Offset = "0x159E070", VA = "0x159E070")]
		private void PayDD2CrystalsBeforeUse(Item item)
		{
		}

		// Token: 0x06002B6F RID: 11119 RVA: 0x00015030 File Offset: 0x00013230
		[Token(Token = "0x6002B6F")]
		[Address(RVA = "0x159E1C4", Offset = "0x159E1C4", VA = "0x159E1C4")]
		private bool CheckDD2CrystalPaymentLock(Item item)
		{
			return default(bool);
		}

		// Token: 0x06002B70 RID: 11120 RVA: 0x00015048 File Offset: 0x00013248
		[Token(Token = "0x6002B70")]
		[Address(RVA = "0x159E184", Offset = "0x159E184", VA = "0x159E184")]
		private int GetRequiredDD2CrystalsToUse(Item item)
		{
			return 0;
		}

		// Token: 0x06002B71 RID: 11121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B71")]
		[Address(RVA = "0x14DFD50", Offset = "0x14DFD50", VA = "0x14DFD50")]
		public void SporeSac(Item sourceItem)
		{
		}

		// Token: 0x06002B72 RID: 11122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B72")]
		[Address(RVA = "0x14E09DC", Offset = "0x14E09DC", VA = "0x14E09DC")]
		public void VolatileGelatin(Item sourceItem)
		{
		}

		// Token: 0x06002B73 RID: 11123 RVA: 0x00015060 File Offset: 0x00013260
		[Token(Token = "0x6002B73")]
		[Address(RVA = "0x1504780", Offset = "0x1504780", VA = "0x1504780")]
		public bool CanHit(Entity ent)
		{
			return default(bool);
		}

		// Token: 0x06002B74 RID: 11124 RVA: 0x00015078 File Offset: 0x00013278
		[Token(Token = "0x6002B74")]
		[Address(RVA = "0x159E294", Offset = "0x159E294", VA = "0x159E294")]
		public Rectangle GetItemDrawFrame(int type)
		{
			return default(Rectangle);
		}

		// Token: 0x06002B75 RID: 11125 RVA: 0x00015090 File Offset: 0x00013290
		[Token(Token = "0x6002B75")]
		[Address(RVA = "0x159E694", Offset = "0x159E694", VA = "0x159E694")]
		public float GetAdjustedItemScale(Item item)
		{
			return 0f;
		}

		// Token: 0x06002B76 RID: 11126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B76")]
		[Address(RVA = "0x159E6EC", Offset = "0x159E6EC", VA = "0x159E6EC")]
		public void ApplyMeleeScale(ref float scale)
		{
		}

		// Token: 0x06002B77 RID: 11127 RVA: 0x000150A8 File Offset: 0x000132A8
		[Token(Token = "0x6002B77")]
		[Address(RVA = "0x159E70C", Offset = "0x159E70C", VA = "0x159E70C")]
		public Vector2 ApplyRangeCompensation(float rangeCompensation, Vector2 startPos, Vector2 targetPos)
		{
			return default(Vector2);
		}

		// Token: 0x06002B78 RID: 11128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B78")]
		[Address(RVA = "0x153590C", Offset = "0x153590C", VA = "0x153590C")]
		public void ItemCheck()
		{
		}

		// Token: 0x06002B79 RID: 11129 RVA: 0x000150C0 File Offset: 0x000132C0
		[Token(Token = "0x6002B79")]
		[Address(RVA = "0x15A0860", Offset = "0x15A0860", VA = "0x15A0860")]
		private bool TryUsingFoxsparksAbility(bool normalFoxparks)
		{
			return default(bool);
		}

		// Token: 0x06002B7A RID: 11130 RVA: 0x000150D8 File Offset: 0x000132D8
		[Token(Token = "0x6002B7A")]
		[Address(RVA = "0x15A21BC", Offset = "0x15A21BC", VA = "0x15A21BC")]
		public Rectangle AnimatePlayerAndGetItemFrame(float mountOffset, Item sItem)
		{
			return default(Rectangle);
		}

		// Token: 0x06002B7B RID: 11131 RVA: 0x000150F0 File Offset: 0x000132F0
		[Token(Token = "0x6002B7B")]
		[Address(RVA = "0x15AEEB4", Offset = "0x15AEEB4", VA = "0x15AEEB4")]
		public float GetPlacementPreviewOpacity()
		{
			return 0f;
		}

		// Token: 0x06002B7C RID: 11132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B7C")]
		[Address(RVA = "0x159F110", Offset = "0x159F110", VA = "0x159F110")]
		private void UpdatePlacementPreview(Item sItem)
		{
		}

		// Token: 0x06002B7D RID: 11133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B7D")]
		[Address(RVA = "0x157BB60", Offset = "0x157BB60", VA = "0x157BB60")]
		private void FigureOutWhatToPlace(Tile targetTile, Item sItem, out int tileToCreate, out int previewPlaceStyle, out bool? overrideCanPlace, out int? forcedRandom)
		{
		}

		// Token: 0x06002B7E RID: 11134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B7E")]
		[Address(RVA = "0x15A62F8", Offset = "0x15A62F8", VA = "0x15A62F8")]
		private void ItemCheck_OwnerOnlyCode(ref Player.ItemCheckContext context, Item sItem, int weaponDamage, Rectangle heldItemFrame)
		{
		}

		// Token: 0x170005EC RID: 1516
		// (get) Token: 0x06002B7F RID: 11135 RVA: 0x00015108 File Offset: 0x00013308
		[Token(Token = "0x170005EC")]
		public Vector2? MouthPosition
		{
			[Token(Token = "0x6002B7F")]
			[Address(RVA = "0x1510D94", Offset = "0x1510D94", VA = "0x1510D94")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002B80 RID: 11136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B80")]
		[Address(RVA = "0x15A5A80", Offset = "0x15A5A80", VA = "0x15A5A80")]
		private void ItemCheck_EmitFoodParticles(Item sItem)
		{
		}

		// Token: 0x06002B81 RID: 11137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B81")]
		[Address(RVA = "0x15A5EB4", Offset = "0x15A5EB4", VA = "0x15A5EB4")]
		private void ItemCheck_EmitDrinkParticles(Item sItem)
		{
		}

		// Token: 0x06002B82 RID: 11138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B82")]
		[Address(RVA = "0x15B987C", Offset = "0x15B987C", VA = "0x15B987C")]
		private void ItemCheck_UseBossSpawners(int onWhichPlayer, Item sItem)
		{
		}

		// Token: 0x06002B83 RID: 11139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B83")]
		[Address(RVA = "0x15B86BC", Offset = "0x15B86BC", VA = "0x15B86BC")]
		private void ItemCheck_UseEventItems(Item sItem)
		{
		}

		// Token: 0x06002B84 RID: 11140 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B84")]
		[Address(RVA = "0x15BB5A0", Offset = "0x15BB5A0", VA = "0x15BB5A0")]
		private void ItemCheck_ReleaseCritter(Item sItem)
		{
		}

		// Token: 0x06002B85 RID: 11141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B85")]
		[Address(RVA = "0x15C1990", Offset = "0x15C1990", VA = "0x15C1990")]
		private void ItemCheck_MeleeHitPVP(Item sItem, Rectangle itemRectangle, int damage, float knockBack)
		{
		}

		// Token: 0x06002B86 RID: 11142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B86")]
		[Address(RVA = "0x15C2DCC", Offset = "0x15C2DCC", VA = "0x15C2DCC")]
		private void Volcano_TrySpawningVolcano(NPC npc, Item sItem, float damage, float knockBack, Rectangle itemRectangle)
		{
		}

		// Token: 0x06002B87 RID: 11143 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B87")]
		[Address(RVA = "0x15C2FBC", Offset = "0x15C2FBC", VA = "0x15C2FBC")]
		private void TentacleSpike_TrySpiking(NPC npc, Item sItem, float damage, float knockBack)
		{
		}

		// Token: 0x06002B88 RID: 11144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B88")]
		[Address(RVA = "0x15C3530", Offset = "0x15C3530", VA = "0x15C3530")]
		private void BloodButcherer_TryButchering(NPC npc, Item sItem, float damage, float knockBack)
		{
		}

		// Token: 0x06002B89 RID: 11145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B89")]
		[Address(RVA = "0x15C2BD4", Offset = "0x15C2BD4", VA = "0x15C2BD4")]
		private void BatBat_TryLifeLeeching(Entity entity)
		{
		}

		// Token: 0x06002B8A RID: 11146 RVA: 0x00015120 File Offset: 0x00013320
		[Token(Token = "0x6002B8A")]
		[Address(RVA = "0x14FAD5C", Offset = "0x14FAD5C", VA = "0x14FAD5C")]
		public bool HasNPCBannerBuff(int bannerType)
		{
			return default(bool);
		}

		// Token: 0x06002B8B RID: 11147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B8B")]
		[Address(RVA = "0x15C3B04", Offset = "0x15C3B04", VA = "0x15C3B04")]
		public static void ResetNPCSlotData(int npcIndex)
		{
		}

		// Token: 0x06002B8C RID: 11148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B8C")]
		[Address(RVA = "0x15C3BE0", Offset = "0x15C3BE0", VA = "0x15C3BE0")]
		public void ResetMeleeHitCooldowns()
		{
		}

		// Token: 0x06002B8D RID: 11149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B8D")]
		[Address(RVA = "0x15C16F0", Offset = "0x15C16F0", VA = "0x15C16F0")]
		public void UpdateMeleeHitCooldowns()
		{
		}

		// Token: 0x06002B8E RID: 11150 RVA: 0x00015138 File Offset: 0x00013338
		[Token(Token = "0x6002B8E")]
		[Address(RVA = "0x15C3C64", Offset = "0x15C3C64", VA = "0x15C3C64")]
		public bool CanHitNPCWithMeleeHit(int npcIndex)
		{
			return default(bool);
		}

		// Token: 0x06002B8F RID: 11151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B8F")]
		[Address(RVA = "0x15C3C94", Offset = "0x15C3C94", VA = "0x15C3C94")]
		public void SetMeleeHitCooldown(int npcIndex, int timeInFrames)
		{
		}

		// Token: 0x06002B90 RID: 11152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B90")]
		[Address(RVA = "0x15C1794", Offset = "0x15C1794", VA = "0x15C1794")]
		private void ItemCheck_MeleeHitNPCs(Item sItem, Rectangle itemRectangle, int originalDamage, float knockBack)
		{
		}

		// Token: 0x06002B91 RID: 11153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B91")]
		[Address(RVA = "0x15C55B0", Offset = "0x15C55B0", VA = "0x15C55B0")]
		public void TakeDamageFromJellyfish(int npcIndex)
		{
		}

		// Token: 0x06002B92 RID: 11154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B92")]
		[Address(RVA = "0x15C3CC0", Offset = "0x15C3CC0", VA = "0x15C3CC0")]
		private void ProcessHitAgainstNPC(Item sItem, Rectangle itemRectangle, int originalDamage, float knockBack, int npcIndex)
		{
		}

		// Token: 0x06002B93 RID: 11155 RVA: 0x00015150 File Offset: 0x00013350
		[Token(Token = "0x6002B93")]
		[Address(RVA = "0x15C5A10", Offset = "0x15C5A10", VA = "0x15C5A10")]
		public static float GetNanoFlaskDamageBoost()
		{
			return 0f;
		}

		// Token: 0x06002B94 RID: 11156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B94")]
		[Address(RVA = "0x15C2D20", Offset = "0x15C2D20", VA = "0x15C2D20")]
		public void ApplyAttackCooldown()
		{
		}

		// Token: 0x06002B95 RID: 11157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B95")]
		[Address(RVA = "0x153451C", Offset = "0x153451C", VA = "0x153451C")]
		public void ApplyAttackCooldown(int frames)
		{
		}

		// Token: 0x06002B96 RID: 11158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B96")]
		[Address(RVA = "0x15C5A20", Offset = "0x15C5A20", VA = "0x15C5A20")]
		private void ApplyNPCOnHitEffects(Item sItem, Rectangle itemRectangle, int damage, float knockBack, NPC npc, int dmgRandomized, int dmgDone)
		{
		}

		// Token: 0x06002B97 RID: 11159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B97")]
		[Address(RVA = "0x15C27D8", Offset = "0x15C27D8", VA = "0x15C27D8")]
		private void ItemCheck_EmitHammushProjectiles(int i, Item sItem, Rectangle itemRectangle, int damage)
		{
		}

		// Token: 0x06002B98 RID: 11160 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B98")]
		[Address(RVA = "0x14F9438", Offset = "0x14F9438", VA = "0x14F9438")]
		private bool[] ItemCheck_GetTileCutIgnoreList(Item sItem)
		{
			return null;
		}

		// Token: 0x06002B99 RID: 11161 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B99")]
		[Address(RVA = "0x15C6E2C", Offset = "0x15C6E2C", VA = "0x15C6E2C")]
		public bool[] GetTileCutIgnorance(bool allowRegrowth, bool fromTrap)
		{
			return null;
		}

		// Token: 0x06002B9A RID: 11162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B9A")]
		[Address(RVA = "0x14F9514", Offset = "0x14F9514", VA = "0x14F9514")]
		private void ItemCheck_CutTiles(Item sItem, Rectangle itemRectangle, bool[] shouldIgnore, bool cutExtraTiles = false)
		{
		}

		// Token: 0x06002B9B RID: 11163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B9B")]
		[Address(RVA = "0x15C1088", Offset = "0x15C1088", VA = "0x15C1088")]
		private void ItemCheck_CatchCritters(Item sItem, Rectangle itemRectangle)
		{
		}

		// Token: 0x06002B9C RID: 11164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B9C")]
		[Address(RVA = "0x15C5778", Offset = "0x15C5778", VA = "0x15C5778")]
		public void GetPointOnSwungItemPath(float spriteWidth, float spriteHeight, float normalizedPointOnPath, float itemScale, out Vector2 location, out Vector2 outwardDirection)
		{
		}

		// Token: 0x06002B9D RID: 11165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B9D")]
		[Address(RVA = "0x15BC904", Offset = "0x15BC904", VA = "0x15BC904")]
		private void ItemCheck_EmitUseVisuals(Item sItem, Rectangle itemRectangle)
		{
		}

		// Token: 0x06002B9E RID: 11166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B9E")]
		[Address(RVA = "0x15BBEF8", Offset = "0x15BBEF8", VA = "0x15BBEF8")]
		private void ItemCheck_GetMeleeHitboxParticles(Item sItem, Rectangle heldItemFrame)
		{
		}

		// Token: 0x06002B9F RID: 11167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B9F")]
		[Address(RVA = "0x15BB948", Offset = "0x15BB948", VA = "0x15BB948")]
		public void ItemCheck_GetMeleeHitbox(Item sItem, Rectangle heldItemFrame, out bool dontAttack, out Rectangle itemRectangle)
		{
		}

		// Token: 0x06002BA0 RID: 11168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BA0")]
		[Address(RVA = "0x15B80A4", Offset = "0x15B80A4", VA = "0x15B80A4")]
		private void ItemCheck_UseDemonHeart(Item sItem)
		{
		}

		// Token: 0x06002BA1 RID: 11169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BA1")]
		[Address(RVA = "0x15B81DC", Offset = "0x15B81DC", VA = "0x15B81DC")]
		private void ItemCheck_UseMinecartPowerUp(Item sItem)
		{
		}

		// Token: 0x06002BA2 RID: 11170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BA2")]
		[Address(RVA = "0x15B85C0", Offset = "0x15B85C0", VA = "0x15B85C0")]
		private void ItemCheck_UseArtisanLoaf(Item sItem)
		{
		}

		// Token: 0x06002BA3 RID: 11171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BA3")]
		[Address(RVA = "0x15B8358", Offset = "0x15B8358", VA = "0x15B8358")]
		private void ItemCheck_UseTorchGodsFavor(Item sItem)
		{
		}

		// Token: 0x06002BA4 RID: 11172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BA4")]
		[Address(RVA = "0x15B6D20", Offset = "0x15B6D20", VA = "0x15B6D20")]
		private void ItemCheck_TryDestroyingDrones(Item sItem)
		{
		}

		// Token: 0x06002BA5 RID: 11173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BA5")]
		[Address(RVA = "0x15B7FA8", Offset = "0x15B7FA8", VA = "0x15B7FA8")]
		private void ItemCheck_UseManaCrystal(Item sItem)
		{
		}

		// Token: 0x06002BA6 RID: 11174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BA6")]
		[Address(RVA = "0x15B7EA0", Offset = "0x15B7EA0", VA = "0x15B7EA0")]
		private void ItemCheck_UseLifeFruit(Item sItem)
		{
		}

		// Token: 0x06002BA7 RID: 11175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BA7")]
		[Address(RVA = "0x15B7DA0", Offset = "0x15B7DA0", VA = "0x15B7DA0")]
		private void ItemCheck_UseLifeCrystal(Item sItem)
		{
		}

		// Token: 0x06002BA8 RID: 11176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BA8")]
		[Address(RVA = "0x15BA7D8", Offset = "0x15BA7D8", VA = "0x15BA7D8")]
		private void ItemCheck_UseCombatBook(Item sItem)
		{
		}

		// Token: 0x06002BA9 RID: 11177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BA9")]
		[Address(RVA = "0x15BAE7C", Offset = "0x15BAE7C", VA = "0x15BAE7C")]
		private void ItemCheck_UsePetLicenses(Item sItem)
		{
		}

		// Token: 0x06002BAA RID: 11178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BAA")]
		[Address(RVA = "0x15BAC10", Offset = "0x15BAC10", VA = "0x15BAC10")]
		private void ItemCheck_UsePeddlersSatchel(Item sItem)
		{
		}

		// Token: 0x06002BAB RID: 11179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BAB")]
		[Address(RVA = "0x15BB050", Offset = "0x15BB050", VA = "0x15BB050")]
		private void ItemCheck_UseShimmerPermanentItems(Item sItem)
		{
		}

		// Token: 0x06002BAC RID: 11180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BAC")]
		[Address(RVA = "0x15BB46C", Offset = "0x15BB46C", VA = "0x15BB46C")]
		private void ItemCheck_UsePlayerSoundOverrideAccessory(Item sItem)
		{
		}

		// Token: 0x06002BAD RID: 11181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BAD")]
		[Address(RVA = "0x15C6EF4", Offset = "0x15C6EF4", VA = "0x15C6EF4")]
		private void LicenseOrExchangePet(Item sItem, ref bool petBoughtFlag, int npcType, string textKeyForLicense, int netMessageData)
		{
		}

		// Token: 0x06002BAE RID: 11182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BAE")]
		[Address(RVA = "0x15C6FEC", Offset = "0x15C6FEC", VA = "0x15C6FEC")]
		public void LimitPointToPlayerReachableArea(ref Vector2 pointPosition)
		{
		}

		// Token: 0x06002BAF RID: 11183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BAF")]
		[Address(RVA = "0x15B7574", Offset = "0x15B7574", VA = "0x15B7574")]
		private void ItemCheck_UseTeleportRod(Item sItem)
		{
		}

		// Token: 0x06002BB0 RID: 11184 RVA: 0x00015168 File Offset: 0x00013368
		[Token(Token = "0x6002BB0")]
		[Address(RVA = "0x15C72E0", Offset = "0x15C72E0", VA = "0x15C72E0")]
		private bool IsAHammerTarget(Tile targetTile)
		{
			return default(bool);
		}

		// Token: 0x06002BB1 RID: 11185 RVA: 0x00015180 File Offset: 0x00013380
		[Token(Token = "0x6002BB1")]
		[Address(RVA = "0x15C7410", Offset = "0x15C7410", VA = "0x15C7410")]
		private bool IsTilePoundable(Tile targetTile)
		{
			return default(bool);
		}

		// Token: 0x06002BB2 RID: 11186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BB2")]
		[Address(RVA = "0x15C78EC", Offset = "0x15C78EC", VA = "0x15C78EC")]
		private void UseShovel(Player user, Item item, int sX, int sY)
		{
		}

		// Token: 0x06002BB3 RID: 11187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BB3")]
		[Address(RVA = "0x15C79A0", Offset = "0x15C79A0", VA = "0x15C79A0")]
		private void DamageTileWithShovel(Player user, Item item, int x, int y)
		{
		}

		// Token: 0x06002BB4 RID: 11188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BB4")]
		[Address(RVA = "0x15B6F4C", Offset = "0x15B6F4C", VA = "0x15B6F4C")]
		private void ItemCheck_UseMiningTools(Item sItem)
		{
		}

		// Token: 0x06002BB5 RID: 11189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BB5")]
		[Address(RVA = "0x15C9590", Offset = "0x15C9590", VA = "0x15C9590")]
		private void ItemCheck_UseMiningTools_ActuallyUseMiningTool(Item sItem, out bool canHitWalls, int x, int y)
		{
		}

		// Token: 0x06002BB6 RID: 11190 RVA: 0x00015198 File Offset: 0x00013398
		[Token(Token = "0x6002BB6")]
		[Address(RVA = "0x15CC21C", Offset = "0x15CC21C", VA = "0x15CC21C")]
		private bool IsBottomOfTreeTrunkNoRoots(int x, int y)
		{
			return default(bool);
		}

		// Token: 0x06002BB7 RID: 11191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BB7")]
		[Address(RVA = "0x15CC5F0", Offset = "0x15CC5F0", VA = "0x15CC5F0")]
		private void TryReplantingTree()
		{
		}

		// Token: 0x06002BB8 RID: 11192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BB8")]
		[Address(RVA = "0x1599BDC", Offset = "0x1599BDC", VA = "0x1599BDC")]
		private void TryReplantingHerbs(int herbStyle)
		{
		}

		// Token: 0x06002BB9 RID: 11193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BB9")]
		[Address(RVA = "0x15CAE64", Offset = "0x15CAE64", VA = "0x15CAE64")]
		private static void ItemCheck_UseMiningTools_TryFindingWallToHammer(out int wX, out int wY)
		{
		}

		// Token: 0x06002BBA RID: 11194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BBA")]
		[Address(RVA = "0x15CBD5C", Offset = "0x15CBD5C", VA = "0x15CBD5C")]
		private void ItemCheck_UseMiningTools_TryHittingWall(Item sItem, int wX, int wY)
		{
		}

		// Token: 0x06002BBB RID: 11195 RVA: 0x000151B0 File Offset: 0x000133B0
		[Token(Token = "0x6002BBB")]
		[Address(RVA = "0x15D0FE0", Offset = "0x15D0FE0", VA = "0x15D0FE0")]
		public static bool CanPlayerSmashWall(int X, int Y)
		{
			return default(bool);
		}

		// Token: 0x06002BBC RID: 11196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BBC")]
		[Address(RVA = "0x15D1448", Offset = "0x15D1448", VA = "0x15D1448")]
		public void PickWall(int x, int y, int damage)
		{
		}

		// Token: 0x06002BBD RID: 11197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BBD")]
		[Address(RVA = "0x15CCB1C", Offset = "0x15CCB1C", VA = "0x15CCB1C")]
		private void ItemCheck_UseMiningTools_TryPoundingTile(Item sItem, int tileHitId, ref bool hitWall, int x, int y)
		{
		}

		// Token: 0x06002BBE RID: 11198 RVA: 0x000151C8 File Offset: 0x000133C8
		[Token(Token = "0x6002BBE")]
		[Address(RVA = "0x15C9410", Offset = "0x15C9410", VA = "0x15C9410")]
		public bool IsTargetTileInItemRange(Item sItem)
		{
			return default(bool);
		}

		// Token: 0x06002BBF RID: 11199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BBF")]
		[Address(RVA = "0x15B258C", Offset = "0x15B258C", VA = "0x15B258C")]
		private void ItemCheck_UseBuckets(Item sItem)
		{
		}

		// Token: 0x06002BC0 RID: 11200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BC0")]
		[Address(RVA = "0x15B141C", Offset = "0x15B141C", VA = "0x15B141C")]
		private void ItemCheck_PlayInstruments(Item sItem)
		{
		}

		// Token: 0x06002BC1 RID: 11201 RVA: 0x000151E0 File Offset: 0x000133E0
		[Token(Token = "0x6002BC1")]
		[Address(RVA = "0x15D1A38", Offset = "0x15D1A38", VA = "0x15D1A38")]
		private bool GetSparkleGuitarTarget(out List<NPC> validTargets)
		{
			return default(bool);
		}

		// Token: 0x06002BC2 RID: 11202 RVA: 0x000151F8 File Offset: 0x000133F8
		[Token(Token = "0x6002BC2")]
		[Address(RVA = "0x15D1D74", Offset = "0x15D1D74", VA = "0x15D1D74")]
		private bool GetZenithTarget(Vector2 searchCenter, float maxDistance, out int npcTargetIndex)
		{
			return default(bool);
		}

		// Token: 0x06002BC3 RID: 11203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BC3")]
		[Address(RVA = "0x15D1730", Offset = "0x15D1730", VA = "0x15D1730")]
		public void PlayGuitarChord(float range)
		{
		}

		// Token: 0x06002BC4 RID: 11204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BC4")]
		[Address(RVA = "0x15D18D4", Offset = "0x15D18D4", VA = "0x15D18D4")]
		public void PlayDrums(float range)
		{
		}

		// Token: 0x06002BC5 RID: 11205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BC5")]
		[Address(RVA = "0x15AF2E0", Offset = "0x15AF2E0", VA = "0x15AF2E0")]
		private void ItemCheck_UseWiringTools(Item sItem)
		{
		}

		// Token: 0x06002BC6 RID: 11206 RVA: 0x00015210 File Offset: 0x00013410
		[Token(Token = "0x6002BC6")]
		[Address(RVA = "0x15D1F70", Offset = "0x15D1F70", VA = "0x15D1F70")]
		public bool CanDoWireStuffHere(int x, int y)
		{
			return default(bool);
		}

		// Token: 0x06002BC7 RID: 11207 RVA: 0x00015228 File Offset: 0x00013428
		[Token(Token = "0x6002BC7")]
		[Address(RVA = "0x15D22E4", Offset = "0x15D22E4", VA = "0x15D22E4")]
		public bool CanShowWireStuffHere(int x, int y)
		{
			return default(bool);
		}

		// Token: 0x06002BC8 RID: 11208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BC8")]
		[Address(RVA = "0x15B10FC", Offset = "0x15B10FC", VA = "0x15B10FC")]
		private void ItemCheck_UseLawnMower(Item sItem)
		{
		}

		// Token: 0x06002BC9 RID: 11209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BC9")]
		[Address(RVA = "0x15D25E8", Offset = "0x15D25E8", VA = "0x15D25E8")]
		private void DestroyOldestProximityMinesOverMinesCap(int minesCap)
		{
		}

		// Token: 0x06002BCA RID: 11210 RVA: 0x00015240 File Offset: 0x00013440
		[Token(Token = "0x6002BCA")]
		[Address(RVA = "0x15D2AA8", Offset = "0x15D2AA8", VA = "0x15D2AA8")]
		public int GetSlowMagicUseTime(int originalTime)
		{
			return 0;
		}

		// Token: 0x06002BCB RID: 11211 RVA: 0x00015258 File Offset: 0x00013458
		[Token(Token = "0x6002BCB")]
		[Address(RVA = "0x15D2B44", Offset = "0x15D2B44", VA = "0x15D2B44")]
		public float GetSlowMagicUseRate()
		{
			return 0f;
		}

		// Token: 0x06002BCC RID: 11212 RVA: 0x00015270 File Offset: 0x00013470
		[Token(Token = "0x6002BCC")]
		[Address(RVA = "0x15D2BC8", Offset = "0x15D2BC8", VA = "0x15D2BC8")]
		public float GetSlowMagicScalar()
		{
			return 0f;
		}

		// Token: 0x06002BCD RID: 11213 RVA: 0x00015288 File Offset: 0x00013488
		[Token(Token = "0x6002BCD")]
		[Address(RVA = "0x14A0240", Offset = "0x14A0240", VA = "0x14A0240")]
		private static float GetSlowMagicMultiplier()
		{
			return 0f;
		}

		// Token: 0x06002BCE RID: 11214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BCE")]
		[Address(RVA = "0x15D2C48", Offset = "0x15D2C48", VA = "0x15D2C48")]
		public void SilentlyShootItem(Item sItem)
		{
		}

		// Token: 0x06002BCF RID: 11215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BCF")]
		[Address(RVA = "0x14870E0", Offset = "0x14870E0", VA = "0x14870E0")]
		private void ItemCheck_Shoot(int i, Item sItem, int weaponDamage, bool withAudioVisualFeedback = true)
		{
		}

		// Token: 0x06002BD0 RID: 11216 RVA: 0x000152A0 File Offset: 0x000134A0
		[Token(Token = "0x6002BD0")]
		[Address(RVA = "0x159F58C", Offset = "0x159F58C", VA = "0x159F58C")]
		private float PackGemStaffFeatures(int shoot)
		{
			return 0f;
		}

		// Token: 0x06002BD1 RID: 11217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BD1")]
		[Address(RVA = "0x15D2C74", Offset = "0x15D2C74", VA = "0x15D2C74")]
		private void SpawnDigtoiseOnCursor(int owner, int shoot, IEntitySource projectileSource)
		{
		}

		// Token: 0x06002BD2 RID: 11218 RVA: 0x000152B8 File Offset: 0x000134B8
		[Token(Token = "0x6002BD2")]
		[Address(RVA = "0x15D2EB4", Offset = "0x15D2EB4", VA = "0x15D2EB4")]
		private static bool TrySpawnDigtoiseAt(int owner, int shoot, IEntitySource projectileSource, int x, int y)
		{
			return default(bool);
		}

		// Token: 0x06002BD3 RID: 11219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BD3")]
		[Address(RVA = "0x15D31E8", Offset = "0x15D31E8", VA = "0x15D31E8")]
		private void PickSentryLandingSpot(Item sItem, out float spawnX, out float spawnY)
		{
		}

		// Token: 0x06002BD4 RID: 11220 RVA: 0x000152D0 File Offset: 0x000134D0
		[Token(Token = "0x6002BD4")]
		[Address(RVA = "0x15D35B8", Offset = "0x15D35B8", VA = "0x15D35B8")]
		public Vector2 GetFarthestSpawnPositionOnLine(Vector2 startPos, float speedX, float speedY)
		{
			return default(Vector2);
		}

		// Token: 0x06002BD5 RID: 11221 RVA: 0x000152E8 File Offset: 0x000134E8
		[Token(Token = "0x6002BD5")]
		[Address(RVA = "0x15D3908", Offset = "0x15D3908", VA = "0x15D3908")]
		public int SpawnMinionOnCursor(IEntitySource projectileSource, int ownerIndex, int minionProjectileId, int originalDamageNotScaledByMinionDamage, float KnockBack, [Optional] Vector2 offsetFromCursor, [Optional] Vector2 velocityOnSpawn)
		{
			return 0;
		}

		// Token: 0x06002BD6 RID: 11222 RVA: 0x00015300 File Offset: 0x00013500
		[Token(Token = "0x6002BD6")]
		[Address(RVA = "0x15D3BF8", Offset = "0x15D3BF8", VA = "0x15D3BF8")]
		private Point FindSharpTearsSpot(Vector2 targetSpot)
		{
			return default(Point);
		}

		// Token: 0x06002BD7 RID: 11223 RVA: 0x00015318 File Offset: 0x00013518
		[Token(Token = "0x6002BD7")]
		[Address(RVA = "0x15D4634", Offset = "0x15D4634", VA = "0x15D4634")]
		private bool FindSharpTearsOpening(int x, int y, bool acceptLeft, bool acceptRight, bool acceptUp, bool acceptDown)
		{
			return default(bool);
		}

		// Token: 0x06002BD8 RID: 11224 RVA: 0x00015330 File Offset: 0x00013530
		[Token(Token = "0x6002BD8")]
		[Address(RVA = "0x15D47BC", Offset = "0x15D47BC", VA = "0x15D47BC")]
		public bool TryPlacingAGolfBallNearANearbyTee(Vector2 placePosition)
		{
			return default(bool);
		}

		// Token: 0x06002BD9 RID: 11225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BD9")]
		[Address(RVA = "0x1556250", Offset = "0x1556250", VA = "0x1556250")]
		public void GetPreferredGolfBallToUse(out int projType)
		{
		}

		// Token: 0x06002BDA RID: 11226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BDA")]
		[Address(RVA = "0x15AF1FC", Offset = "0x15AF1FC", VA = "0x15AF1FC")]
		private void ItemCheck_MinionAltFeatureUse(Item sItem, bool cShoot)
		{
		}

		// Token: 0x06002BDB RID: 11227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BDB")]
		[Address(RVA = "0x15AF038", Offset = "0x15AF038", VA = "0x15AF038")]
		private void ItemCheck_TurretAltFeatureUse(Item sItem, bool cShoot)
		{
		}

		// Token: 0x06002BDC RID: 11228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BDC")]
		[Address(RVA = "0x15A1F58", Offset = "0x15A1F58", VA = "0x15A1F58")]
		private void EmitMaxManaEffect()
		{
		}

		// Token: 0x170005ED RID: 1517
		// (get) Token: 0x06002BDD RID: 11229 RVA: 0x00015348 File Offset: 0x00013548
		[Token(Token = "0x170005ED")]
		public Vector2? HandPosition
		{
			[Token(Token = "0x6002BDD")]
			[Address(RVA = "0x15D50DC", Offset = "0x15D50DC", VA = "0x15D50DC")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002BDE RID: 11230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BDE")]
		[Address(RVA = "0x15A22BC", Offset = "0x15A22BC", VA = "0x15A22BC")]
		public void ItemCheck_EmitHeldItemLight(Item sItem)
		{
		}

		// Token: 0x06002BDF RID: 11231 RVA: 0x00015360 File Offset: 0x00013560
		[Token(Token = "0x6002BDF")]
		[Address(RVA = "0x15657D8", Offset = "0x15657D8", VA = "0x15657D8")]
		public bool CanVisuallyHoldItem(Item item)
		{
			return default(bool);
		}

		// Token: 0x06002BE0 RID: 11232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BE0")]
		[Address(RVA = "0x15ACDB8", Offset = "0x15ACDB8", VA = "0x15ACDB8")]
		private void ItemCheck_ApplyHoldStyle(float mountOffset, Item sItem, Rectangle heldItemFrame)
		{
		}

		// Token: 0x06002BE1 RID: 11233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BE1")]
		[Address(RVA = "0x15A1E3C", Offset = "0x15A1E3C", VA = "0x15A1E3C")]
		private void ItemCheck_ApplyManaRegenDelay(Item sItem)
		{
		}

		// Token: 0x06002BE2 RID: 11234 RVA: 0x00015378 File Offset: 0x00013578
		[Token(Token = "0x6002BE2")]
		[Address(RVA = "0x15D5D58", Offset = "0x15D5D58", VA = "0x15D5D58")]
		public Vector2 GetArmPosition()
		{
			return default(Vector2);
		}

		// Token: 0x06002BE3 RID: 11235 RVA: 0x00015390 File Offset: 0x00013590
		[Token(Token = "0x6002BE3")]
		[Address(RVA = "0x15D61D8", Offset = "0x15D61D8", VA = "0x15D61D8")]
		public Vector2 GetFrontHandPosition(Player.CompositeArmStretchAmount stretch, float rotation)
		{
			return default(Vector2);
		}

		// Token: 0x06002BE4 RID: 11236 RVA: 0x000153A8 File Offset: 0x000135A8
		[Token(Token = "0x6002BE4")]
		[Address(RVA = "0x15D65B0", Offset = "0x15D65B0", VA = "0x15D65B0")]
		public Vector2 GetBackHandPosition(Player.CompositeArmStretchAmount stretch, float rotation)
		{
			return default(Vector2);
		}

		// Token: 0x06002BE5 RID: 11237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BE5")]
		[Address(RVA = "0x15A8F80", Offset = "0x15A8F80", VA = "0x15A8F80")]
		public void ItemCheck_ApplyUseStyle(float mountOffset, Item sItem, Rectangle heldItemFrame)
		{
		}

		// Token: 0x06002BE6 RID: 11238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BE6")]
		[Address(RVA = "0x15D5464", Offset = "0x15D5464", VA = "0x15D5464")]
		public void ApplyItemPositionOffsetFromMount(ref Vector2 pos)
		{
		}

		// Token: 0x06002BE7 RID: 11239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BE7")]
		[Address(RVA = "0x14D1718", Offset = "0x14D1718", VA = "0x14D1718")]
		public void ApplyHeadOffsetFromMount(ref Vector2 pos)
		{
		}

		// Token: 0x06002BE8 RID: 11240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BE8")]
		[Address(RVA = "0x15D5CEC", Offset = "0x15D5CEC", VA = "0x15D5CEC")]
		public void FlipItemLocationAndRotationForGravity()
		{
		}

		// Token: 0x06002BE9 RID: 11241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BE9")]
		[Address(RVA = "0x15A1A4C", Offset = "0x15A1A4C", VA = "0x15A1A4C")]
		private void ItemCheck_StartActualUse(Item sItem)
		{
		}

		// Token: 0x06002BEA RID: 11242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BEA")]
		[Address(RVA = "0x15A0A4C", Offset = "0x15A0A4C", VA = "0x15A0A4C")]
		private void FreeUpPetsAndMinions(Item sItem)
		{
		}

		// Token: 0x06002BEB RID: 11243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BEB")]
		[Address(RVA = "0x14A8678", Offset = "0x14A8678", VA = "0x14A8678")]
		private void ApplyPotionDelay(Item sItem)
		{
		}

		// Token: 0x06002BEC RID: 11244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BEC")]
		[Address(RVA = "0x14A8830", Offset = "0x14A8830", VA = "0x14A8830")]
		private void ApplyLifeAndOrMana(Item item)
		{
		}

		// Token: 0x06002BED RID: 11245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BED")]
		[Address(RVA = "0x15D68BC", Offset = "0x15D68BC", VA = "0x15D68BC")]
		private void UndoSlowMagicUse()
		{
		}

		// Token: 0x06002BEE RID: 11246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BEE")]
		[Address(RVA = "0x15D6AB0", Offset = "0x15D6AB0", VA = "0x15D6AB0")]
		private void ApplyManaPotionManaHeat(Item item)
		{
		}

		// Token: 0x06002BEF RID: 11247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BEF")]
		[Address(RVA = "0x155A934", Offset = "0x155A934", VA = "0x155A934")]
		private void TryApplyManaHeat(float power, float time)
		{
		}

		// Token: 0x06002BF0 RID: 11248 RVA: 0x000153C0 File Offset: 0x000135C0
		[Token(Token = "0x6002BF0")]
		[Address(RVA = "0x14AA41C", Offset = "0x14AA41C", VA = "0x14AA41C")]
		private bool ItemCheck_CanUse(Item sItem, bool ignoreCursed = false)
		{
			return default(bool);
		}

		// Token: 0x06002BF1 RID: 11249 RVA: 0x000153D8 File Offset: 0x000135D8
		[Token(Token = "0x6002BF1")]
		[Address(RVA = "0x14A8540", Offset = "0x14A8540", VA = "0x14A8540")]
		private bool ItemCheck_TryStartUse(Item sItem, bool ignoreCursed = false)
		{
			return default(bool);
		}

		// Token: 0x06002BF2 RID: 11250 RVA: 0x000153F0 File Offset: 0x000135F0
		[Token(Token = "0x6002BF2")]
		[Address(RVA = "0x14AB028", Offset = "0x14AB028", VA = "0x14AB028")]
		private bool ItemCheck_CheckCanUse_Inner(Item sItem, bool ignoreCursed = false)
		{
			return default(bool);
		}

		// Token: 0x06002BF3 RID: 11251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BF3")]
		[Address(RVA = "0x15D71D4", Offset = "0x15D71D4", VA = "0x15D71D4")]
		private void GetTargetTileWithReverseGravity(out int screenTargetTileX, out int screenTargetTileY)
		{
		}

		// Token: 0x06002BF4 RID: 11252 RVA: 0x00015408 File Offset: 0x00013608
		[Token(Token = "0x6002BF4")]
		[Address(RVA = "0x15D6C80", Offset = "0x15D6C80", VA = "0x15D6C80")]
		private bool ItemCheck_CheckCanUse_KillDirtBlock(Item sItem)
		{
			return default(bool);
		}

		// Token: 0x06002BF5 RID: 11253 RVA: 0x00015420 File Offset: 0x00013620
		[Token(Token = "0x6002BF5")]
		[Address(RVA = "0x15D79D0", Offset = "0x15D79D0", VA = "0x15D79D0")]
		private bool ItemCheck_CheckUsabilityOfProjectiles(bool canUse)
		{
			return default(bool);
		}

		// Token: 0x06002BF6 RID: 11254 RVA: 0x00015438 File Offset: 0x00013638
		[Token(Token = "0x6002BF6")]
		[Address(RVA = "0x15D6FC4", Offset = "0x15D6FC4", VA = "0x15D6FC4")]
		private bool ItemCheck_PullFishingBobbers(Item sItem)
		{
			return default(bool);
		}

		// Token: 0x06002BF7 RID: 11255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BF7")]
		[Address(RVA = "0x15D81F0", Offset = "0x15D81F0", VA = "0x15D81F0")]
		private void ItemCheck_CheckFishingBobber_PullBobber(Projectile bobber, int baitTypeUsed)
		{
		}

		// Token: 0x06002BF8 RID: 11256 RVA: 0x00015450 File Offset: 0x00013650
		[Token(Token = "0x6002BF8")]
		[Address(RVA = "0x15D7D08", Offset = "0x15D7D08", VA = "0x15D7D08")]
		private bool ItemCheck_CheckFishingBobber_ConsumeBait(Projectile bobber, out int baitTypeUsed)
		{
			return default(bool);
		}

		// Token: 0x06002BF9 RID: 11257 RVA: 0x00015468 File Offset: 0x00013668
		[Token(Token = "0x6002BF9")]
		[Address(RVA = "0x15D7AB0", Offset = "0x15D7AB0", VA = "0x15D7AB0")]
		private static bool ItemCheck_IsValidDirtRodTarget(Tile t)
		{
			return default(bool);
		}

		// Token: 0x06002BFA RID: 11258 RVA: 0x00015480 File Offset: 0x00013680
		[Token(Token = "0x6002BFA")]
		[Address(RVA = "0x15D8714", Offset = "0x15D8714", VA = "0x15D8714")]
		public bool CheckManaPredictWithoutUse(int amountBeforeManaCost, bool allowQuickMana = true)
		{
			return default(bool);
		}

		// Token: 0x06002BFB RID: 11259 RVA: 0x00015498 File Offset: 0x00013698
		[Token(Token = "0x6002BFB")]
		[Address(RVA = "0x15D871C", Offset = "0x15D871C", VA = "0x15D871C")]
		public bool CheckMana(int amount, bool pay = false, bool blockQuickMana = false)
		{
			return default(bool);
		}

		// Token: 0x06002BFC RID: 11260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BFC")]
		[Address(RVA = "0x15D87C0", Offset = "0x15D87C0", VA = "0x15D87C0")]
		private void DoRunOutOfManaEffect()
		{
		}

		// Token: 0x06002BFD RID: 11261 RVA: 0x000154B0 File Offset: 0x000136B0
		[Token(Token = "0x6002BFD")]
		[Address(RVA = "0x15D7994", Offset = "0x15D7994", VA = "0x15D7994")]
		private bool ItemCheck_CheckCanUse_CanPayMana(Item sItem, bool canUse)
		{
			return default(bool);
		}

		// Token: 0x06002BFE RID: 11262 RVA: 0x000154C8 File Offset: 0x000136C8
		[Token(Token = "0x6002BFE")]
		[Address(RVA = "0x15D6B7C", Offset = "0x15D6B7C", VA = "0x15D6B7C")]
		private bool ItemCheck_ActuallyPayMana(Item sItem)
		{
			return default(bool);
		}

		// Token: 0x06002BFF RID: 11263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BFF")]
		[Address(RVA = "0x15D87CC", Offset = "0x15D87CC", VA = "0x15D87CC")]
		private void GetItemManaUsageDetails(Item sItem, out bool skipUsageCheck, out int rawAmountToPay, out bool freeUsage)
		{
		}

		// Token: 0x06002C00 RID: 11264 RVA: 0x000154E0 File Offset: 0x000136E0
		[Token(Token = "0x6002C00")]
		[Address(RVA = "0x15D8A98", Offset = "0x15D8A98", VA = "0x15D8A98")]
		private static bool ItemCheck_PayMana_ShouldPayManaAfterCheck(Item sItem)
		{
			return default(bool);
		}

		// Token: 0x06002C01 RID: 11265 RVA: 0x000154F8 File Offset: 0x000136F8
		[Token(Token = "0x6002C01")]
		[Address(RVA = "0x15D8A4C", Offset = "0x15D8A4C", VA = "0x15D8A4C")]
		private static int ItemCheck_PayMana_GetManaCostToPay(Item sItem, bool altFire)
		{
			return 0;
		}

		// Token: 0x06002C02 RID: 11266 RVA: 0x00015510 File Offset: 0x00013710
		[Token(Token = "0x6002C02")]
		[Address(RVA = "0x15D88F4", Offset = "0x15D88F4", VA = "0x15D88F4")]
		private bool ItemCheck_PayMana_ShouldSkipManaUse(Item sItem, bool altFire)
		{
			return default(bool);
		}

		// Token: 0x06002C03 RID: 11267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C03")]
		[Address(RVA = "0x15D8AEC", Offset = "0x15D8AEC", VA = "0x15D8AEC")]
		private void ItemCheck_TryPlacingWearablesOnMannequins(Item sItem)
		{
		}

		// Token: 0x06002C04 RID: 11268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C04")]
		[Address(RVA = "0x159F0F8", Offset = "0x159F0F8", VA = "0x159F0F8")]
		private void ApplyReuseDelay()
		{
		}

		// Token: 0x06002C05 RID: 11269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C05")]
		[Address(RVA = "0x159ED40", Offset = "0x159ED40", VA = "0x159ED40")]
		private void ItemCheck_HackHoldStyles(Item sItem)
		{
		}

		// Token: 0x06002C06 RID: 11270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C06")]
		[Address(RVA = "0x159EB74", Offset = "0x159EB74", VA = "0x159EB74")]
		private void ItemCheck_AutoReuseLogic(Item sItem)
		{
		}

		// Token: 0x06002C07 RID: 11271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C07")]
		[Address(RVA = "0x15D9CA4", Offset = "0x15D9CA4", VA = "0x15D9CA4")]
		private void TryAllowingItemReuse(Item sItem)
		{
		}

		// Token: 0x06002C08 RID: 11272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C08")]
		[Address(RVA = "0x159E918", Offset = "0x159E918", VA = "0x159E918")]
		private void ItemCheck_HandleMount()
		{
		}

		// Token: 0x06002C09 RID: 11273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C09")]
		[Address(RVA = "0x15AF020", Offset = "0x15AF020", VA = "0x15AF020")]
		public void StartChanneling()
		{
		}

		// Token: 0x06002C0A RID: 11274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C0A")]
		[Address(RVA = "0x15D6880", Offset = "0x15D6880", VA = "0x15D6880")]
		public void StartChanneling(Item item)
		{
		}

		// Token: 0x06002C0B RID: 11275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C0B")]
		[Address(RVA = "0x15D9DE0", Offset = "0x15D9DE0", VA = "0x15D9DE0")]
		public void TryUpdateChannel(Projectile projectile)
		{
		}

		// Token: 0x06002C0C RID: 11276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C0C")]
		[Address(RVA = "0x15D9DF0", Offset = "0x15D9DF0", VA = "0x15D9DF0")]
		public void TryCancelChannel(Projectile projectile)
		{
		}

		// Token: 0x06002C0D RID: 11277 RVA: 0x00015528 File Offset: 0x00013728
		[Token(Token = "0x6002C0D")]
		[Address(RVA = "0x15D76EC", Offset = "0x15D76EC", VA = "0x15D76EC")]
		public static bool WouldSpotOverlapWithSentry(int worldX, int worldY, bool lightningAura)
		{
			return default(bool);
		}

		// Token: 0x06002C0E RID: 11278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C0E")]
		[Address(RVA = "0x15D7378", Offset = "0x15D7378", VA = "0x15D7378")]
		public void FindSentryRestingSpot(int checkProj, out int worldX, out int worldY, out int pushYUp)
		{
		}

		// Token: 0x06002C0F RID: 11279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C0F")]
		[Address(RVA = "0x15D9E18", Offset = "0x15D9E18", VA = "0x15D9E18")]
		public void UpdateMaxTurrets()
		{
		}

		// Token: 0x06002C10 RID: 11280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C10")]
		[Address(RVA = "0x159F854", Offset = "0x159F854", VA = "0x159F854")]
		private void ItemCheck_ApplyPetBuffs(Item sItem)
		{
		}

		// Token: 0x06002C11 RID: 11281 RVA: 0x00015540 File Offset: 0x00013740
		[Token(Token = "0x6002C11")]
		[Address(RVA = "0x15DA154", Offset = "0x15DA154", VA = "0x15DA154")]
		public float GetWeaponKnockback(Item sItem, float KnockBack)
		{
			return 0f;
		}

		// Token: 0x06002C12 RID: 11282 RVA: 0x00015558 File Offset: 0x00013758
		[Token(Token = "0x6002C12")]
		[Address(RVA = "0x15C59C4", Offset = "0x15C59C4", VA = "0x15C59C4")]
		public int GetWeaponCrit(Item sItem)
		{
			return 0;
		}

		// Token: 0x06002C13 RID: 11283 RVA: 0x00015570 File Offset: 0x00013770
		[Token(Token = "0x6002C13")]
		[Address(RVA = "0x15DA220", Offset = "0x15DA220", VA = "0x15DA220")]
		public float GetWeaponDamageMultiplier(Item item)
		{
			return 0f;
		}

		// Token: 0x06002C14 RID: 11284 RVA: 0x00015588 File Offset: 0x00013788
		[Token(Token = "0x6002C14")]
		[Address(RVA = "0x159EB08", Offset = "0x159EB08", VA = "0x159EB08")]
		public int GetWeaponDamage(Item sItem)
		{
			return 0;
		}

		// Token: 0x06002C15 RID: 11285 RVA: 0x000155A0 File Offset: 0x000137A0
		[Token(Token = "0x6002C15")]
		[Address(RVA = "0x15D7C54", Offset = "0x15D7C54", VA = "0x15D7C54")]
		public bool HasAmmo(Item sItem, bool canUse)
		{
			return default(bool);
		}

		// Token: 0x06002C16 RID: 11286 RVA: 0x000155B8 File Offset: 0x000137B8
		[Token(Token = "0x6002C16")]
		[Address(RVA = "0x15DA500", Offset = "0x15DA500", VA = "0x15DA500")]
		private bool PickAmmo_TryFindingSpecificMatches(int launcher, int ammo, out int pickedProjectileId)
		{
			return default(bool);
		}

		// Token: 0x06002C17 RID: 11287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C17")]
		[Address(RVA = "0x15DA624", Offset = "0x15DA624", VA = "0x15DA624")]
		public void PickAmmo(Item sItem, ref int projToShoot, ref float speed, ref bool canShoot, ref int Damage, ref float KnockBack, out int usedAmmoItemId, bool dontConsume = false)
		{
		}

		// Token: 0x06002C18 RID: 11288 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C18")]
		[Address(RVA = "0x15DB65C", Offset = "0x15DB65C", VA = "0x15DB65C")]
		private Item PickAmmo_IterateRange(Item sItem, Item[] items, int[] slotIterationOrder, bool allowAmmoCycling = true)
		{
			return null;
		}

		// Token: 0x06002C19 RID: 11289 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C19")]
		[Address(RVA = "0x15DB500", Offset = "0x15DB500", VA = "0x15DB500")]
		private Item PickAmmo_PickAmmoItem(Item sItem)
		{
			return null;
		}

		// Token: 0x06002C1A RID: 11290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C1A")]
		[Address(RVA = "0x15DB808", Offset = "0x15DB808", VA = "0x15DB808")]
		public void GetOtherPlayersPickTile(int x, int y, int pickDamage)
		{
		}

		// Token: 0x06002C1B RID: 11291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C1B")]
		[Address(RVA = "0x15C7E40", Offset = "0x15C7E40", VA = "0x15C7E40")]
		public void PickTile(int x, int y, int pickPower, int dealDamageAsIfBaseNumberIs = -1)
		{
		}

		// Token: 0x06002C1C RID: 11292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C1C")]
		[Address(RVA = "0x15DB880", Offset = "0x15DB880", VA = "0x15DB880")]
		public void PickTile_DetermineDamage(int x, int y, int pickPower, Tile tileTarget, bool respectTransformingTiles, out int bufferIndex, out int damage)
		{
		}

		// Token: 0x06002C1D RID: 11293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C1D")]
		[Address(RVA = "0x158F914", Offset = "0x158F914", VA = "0x158F914")]
		private void ClearMiningCacheAt(int x, int y, int hitTileCacheType)
		{
		}

		// Token: 0x06002C1E RID: 11294 RVA: 0x000155D0 File Offset: 0x000137D0
		[Token(Token = "0x6002C1E")]
		[Address(RVA = "0x15DC0FC", Offset = "0x15DC0FC", VA = "0x15DC0FC")]
		public bool isNearFairy()
		{
			return default(bool);
		}

		// Token: 0x06002C1F RID: 11295 RVA: 0x000155E8 File Offset: 0x000137E8
		[Token(Token = "0x6002C1F")]
		[Address(RVA = "0x15DC460", Offset = "0x15DC460", VA = "0x15DC460")]
		public bool isNearNPC(int type, float range = -1f)
		{
			return default(bool);
		}

		// Token: 0x06002C20 RID: 11296 RVA: 0x00015600 File Offset: 0x00013800
		[Token(Token = "0x6002C20")]
		[Address(RVA = "0x15DC6D0", Offset = "0x15DC6D0", VA = "0x15DC6D0")]
		public bool HasEnoughPickPowerToHurtTile(int x, int y)
		{
			return default(bool);
		}

		// Token: 0x06002C21 RID: 11297 RVA: 0x00015618 File Offset: 0x00013818
		[Token(Token = "0x6002C21")]
		[Address(RVA = "0x158D248", Offset = "0x158D248", VA = "0x158D248")]
		private int GetPickaxeDamage(int x, int y, int pickPower, int hitBufferIndex, Tile tileTarget)
		{
			return 0;
		}

		// Token: 0x06002C22 RID: 11298 RVA: 0x00015630 File Offset: 0x00013830
		[Token(Token = "0x6002C22")]
		[Address(RVA = "0x15DB9E0", Offset = "0x15DB9E0", VA = "0x15DB9E0")]
		private bool DoesPickTargetTransformOnKill(HitTile hitCounter, int damage, int x, int y, int pickPower, int bufferIndex, Tile tileTarget)
		{
			return default(bool);
		}

		// Token: 0x06002C23 RID: 11299 RVA: 0x00015648 File Offset: 0x00013848
		[Token(Token = "0x6002C23")]
		[Address(RVA = "0x1556650", Offset = "0x1556650", VA = "0x1556650")]
		public bool ItemFitsWeaponRack(Item i)
		{
			return default(bool);
		}

		// Token: 0x06002C24 RID: 11300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C24")]
		[Address(RVA = "0x15566E8", Offset = "0x15566E8", VA = "0x15566E8")]
		public void PlaceWeapon(int x, int y)
		{
		}

		// Token: 0x06002C25 RID: 11301 RVA: 0x00015660 File Offset: 0x00013860
		[Token(Token = "0x6002C25")]
		[Address(RVA = "0x15DC858", Offset = "0x15DC858", VA = "0x15DC858")]
		public bool ItemFitsItemFrame(Item i)
		{
			return default(bool);
		}

		// Token: 0x06002C26 RID: 11302 RVA: 0x00015678 File Offset: 0x00013878
		[Token(Token = "0x6002C26")]
		[Address(RVA = "0x15DC880", Offset = "0x15DC880", VA = "0x15DC880")]
		public float GetImmuneAlpha(float alphaReduction)
		{
			return 0f;
		}

		// Token: 0x06002C27 RID: 11303 RVA: 0x00015690 File Offset: 0x00013890
		[Token(Token = "0x6002C27")]
		[Address(RVA = "0x15DC918", Offset = "0x15DC918", VA = "0x15DC918")]
		public Color GetImmuneAlpha(Color newColor, float alphaReduction)
		{
			return default(Color);
		}

		// Token: 0x06002C28 RID: 11304 RVA: 0x000156A8 File Offset: 0x000138A8
		[Token(Token = "0x6002C28")]
		[Address(RVA = "0x15DCA5C", Offset = "0x15DCA5C", VA = "0x15DCA5C")]
		public float GetImmuneAlphaPure(float alphaReduction)
		{
			return 0f;
		}

		// Token: 0x06002C29 RID: 11305 RVA: 0x000156C0 File Offset: 0x000138C0
		[Token(Token = "0x6002C29")]
		[Address(RVA = "0x15DCABC", Offset = "0x15DCABC", VA = "0x15DCABC")]
		public Color GetImmuneAlphaPure(Color newColor, float alphaReduction)
		{
			return default(Color);
		}

		// Token: 0x06002C2A RID: 11306 RVA: 0x000156D8 File Offset: 0x000138D8
		[Token(Token = "0x6002C2A")]
		[Address(RVA = "0x15DCB90", Offset = "0x15DCB90", VA = "0x15DCB90")]
		public Color GetDeathAlpha(Color newColor)
		{
			return default(Color);
		}

		// Token: 0x06002C2B RID: 11307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C2B")]
		[Address(RVA = "0x14FA85C", Offset = "0x14FA85C", VA = "0x14FA85C")]
		public void addDPS(int dmg)
		{
		}

		// Token: 0x06002C2C RID: 11308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C2C")]
		[Address(RVA = "0x15DCC38", Offset = "0x15DCC38", VA = "0x15DCC38")]
		public void checkDPSTime()
		{
		}

		// Token: 0x06002C2D RID: 11309 RVA: 0x000156F0 File Offset: 0x000138F0
		[Token(Token = "0x6002C2D")]
		[Address(RVA = "0x15DCD38", Offset = "0x15DCD38", VA = "0x15DCD38")]
		public int getDPS()
		{
			return 0;
		}

		// Token: 0x06002C2E RID: 11310 RVA: 0x00015708 File Offset: 0x00013908
		[Token(Token = "0x6002C2E")]
		[Address(RVA = "0x156D0FC", Offset = "0x156D0FC", VA = "0x156D0FC")]
		public long DropCoins()
		{
			return 0L;
		}

		// Token: 0x06002C2F RID: 11311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C2F")]
		[Address(RVA = "0x156C5D8", Offset = "0x156C5D8", VA = "0x156C5D8")]
		public void DropItems(bool gemsOnly)
		{
		}

		// Token: 0x06002C30 RID: 11312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C30")]
		[Address(RVA = "0x15DD2D0", Offset = "0x15DD2D0", VA = "0x15DD2D0")]
		public void TryDroppingSingleItem(IEntitySource source, Item theItem)
		{
		}

		// Token: 0x06002C31 RID: 11313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C31")]
		[Address(RVA = "0x15DCFE8", Offset = "0x15DCFE8", VA = "0x15DCFE8")]
		public void TryDroppingSingleItem(IEntitySource source, Item theItem, int stack)
		{
		}

		// Token: 0x06002C32 RID: 11314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C32")]
		[Address(RVA = "0x15DD30C", Offset = "0x15DD30C", VA = "0x15DD30C")]
		public void CopyVisuals(Player other)
		{
		}

		// Token: 0x06002C33 RID: 11315 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C33")]
		[Address(RVA = "0x15DD93C", Offset = "0x15DD93C", VA = "0x15DD93C")]
		public object Clone()
		{
			return null;
		}

		// Token: 0x06002C34 RID: 11316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C34")]
		[Address(RVA = "0x15DD944", Offset = "0x15DD944", VA = "0x15DD944")]
		public void OnControlsSynced(Player clonePlayer)
		{
		}

		// Token: 0x06002C35 RID: 11317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C35")]
		[Address(RVA = "0x15DD964", Offset = "0x15DD964", VA = "0x15DD964")]
		public void cloneSyncedControls(Player clonePlayer)
		{
		}

		// Token: 0x06002C36 RID: 11318 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C36")]
		[Address(RVA = "0x15DDB3C", Offset = "0x15DDB3C", VA = "0x15DDB3C")]
		public object clientClone(Player clonePlayer)
		{
			return null;
		}

		// Token: 0x06002C37 RID: 11319 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C37")]
		[Address(RVA = "0x15DE444", Offset = "0x15DE444", VA = "0x15DE444")]
		public Player clientClone()
		{
			return null;
		}

		// Token: 0x06002C38 RID: 11320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C38")]
		[Address(RVA = "0x14A963C", Offset = "0x14A963C", VA = "0x14A963C")]
		private void CloneLoadouts(Player clonePlayer)
		{
		}

		// Token: 0x06002C39 RID: 11321 RVA: 0x00015720 File Offset: 0x00013920
		[Token(Token = "0x6002C39")]
		[Address(RVA = "0x15259D0", Offset = "0x15259D0", VA = "0x15259D0")]
		public static bool CheckSpawn(int x, int y)
		{
			return default(bool);
		}

		// Token: 0x06002C3A RID: 11322 RVA: 0x00015738 File Offset: 0x00013938
		[Token(Token = "0x6002C3A")]
		[Address(RVA = "0x15DEFC0", Offset = "0x15DEFC0", VA = "0x15DEFC0")]
		private static bool CheckSpawn_Internal(int x, int y)
		{
			return default(bool);
		}

		// Token: 0x06002C3B RID: 11323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C3B")]
		[Address(RVA = "0x1525898", Offset = "0x1525898", VA = "0x1525898")]
		public void FindSpawn()
		{
		}

		// Token: 0x06002C3C RID: 11324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C3C")]
		[Address(RVA = "0x1557378", Offset = "0x1557378", VA = "0x1557378")]
		public void RemoveSpawn()
		{
		}

		// Token: 0x06002C3D RID: 11325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C3D")]
		[Address(RVA = "0x1557580", Offset = "0x1557580", VA = "0x1557580")]
		public void ChangeSpawn(int x, int y)
		{
		}

		// Token: 0x06002C3E RID: 11326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C3E")]
		[Address(RVA = "0x15DF97C", Offset = "0x15DF97C", VA = "0x15DF97C")]
		public static void UpdateOldMobilePath(PlayerFileData playerFile)
		{
		}

		// Token: 0x06002C3F RID: 11327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C3F")]
		[Address(RVA = "0x15DFADC", Offset = "0x15DFADC", VA = "0x15DFADC")]
		public static void SavePlayer(PlayerFileData playerFile, bool skipMapSave = false, bool forceSave = false)
		{
		}

		// Token: 0x06002C40 RID: 11328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C40")]
		[Address(RVA = "0x15E01A4", Offset = "0x15E01A4", VA = "0x15E01A4")]
		private static void InternalSavePlayerFile(PlayerFileData playerFile)
		{
		}

		// Token: 0x06002C41 RID: 11329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C41")]
		[Address(RVA = "0x15E3044", Offset = "0x15E3044", VA = "0x15E3044")]
		private void SaveTemporaryItemSlotContents(BinaryWriter writer)
		{
		}

		// Token: 0x06002C42 RID: 11330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C42")]
		[Address(RVA = "0x15E3328", Offset = "0x15E3328", VA = "0x15E3328")]
		private void LoadTemporaryItemSlotContents(BinaryReader reader)
		{
		}

		// Token: 0x06002C43 RID: 11331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C43")]
		[Address(RVA = "0x1566BE0", Offset = "0x1566BE0", VA = "0x1566BE0")]
		public void SetPlayerDataToOutOfClassFields()
		{
		}

		// Token: 0x06002C44 RID: 11332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C44")]
		[Address(RVA = "0x1566ECC", Offset = "0x1566ECC", VA = "0x1566ECC")]
		private void ProcessPendingRefunds()
		{
		}

		// Token: 0x06002C45 RID: 11333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C45")]
		[Address(RVA = "0x15E3694", Offset = "0x15E3694", VA = "0x15E3694")]
		public static void ClearPlayerTempInfo()
		{
		}

		// Token: 0x06002C46 RID: 11334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C46")]
		[Address(RVA = "0x15DFE08", Offset = "0x15DFE08", VA = "0x15DFE08")]
		public static void InternalSaveMap(bool isCloudSave, bool forceSave = false)
		{
		}

		// Token: 0x06002C47 RID: 11335 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C47")]
		[Address(RVA = "0x15E380C", Offset = "0x15E380C", VA = "0x15E380C")]
		public static PlayerFileData LoadPlayerFromResouce(string playerResource = "Tutorial/Player")
		{
			return null;
		}

		// Token: 0x06002C48 RID: 11336 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C48")]
		[Address(RVA = "0x15E87D0", Offset = "0x15E87D0", VA = "0x15E87D0")]
		public static PlayerFileData LoadPlayer(string playerPath, bool cloudSave)
		{
			return null;
		}

		// Token: 0x06002C49 RID: 11337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C49")]
		[Address(RVA = "0x1566538", Offset = "0x1566538", VA = "0x1566538")]
		private static void AdjustRespawnTimerForWorldJoining(Player newPlayer)
		{
		}

		// Token: 0x06002C4A RID: 11338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C4A")]
		[Address(RVA = "0x15ED8B8", Offset = "0x15ED8B8", VA = "0x15ED8B8", Slot = "5")]
		public void FixLoadedData()
		{
		}

		// Token: 0x06002C4B RID: 11339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C4B")]
		[Address(RVA = "0x15EDD08", Offset = "0x15EDD08", VA = "0x15EDD08")]
		public static void FixLoadedData_EliminiateDuplicateAccessories(Item[] armorArray)
		{
		}

		// Token: 0x06002C4C RID: 11340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C4C")]
		[Address(RVA = "0x15EDCB4", Offset = "0x15EDCB4", VA = "0x15EDCB4")]
		private void FixLoadedData_Items(Item[] items)
		{
		}

		// Token: 0x06002C4D RID: 11341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C4D")]
		[Address(RVA = "0x15E8544", Offset = "0x15E8544", VA = "0x15E8544")]
		private static void LoadPlayer_LastMinuteFixes(Player newPlayer)
		{
		}

		// Token: 0x06002C4E RID: 11342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C4E")]
		[Address(RVA = "0x15EDDCC", Offset = "0x15EDDCC", VA = "0x15EDDCC")]
		public static void RemovePrevious(PlayerFileData data)
		{
		}

		// Token: 0x06002C4F RID: 11343 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C4F")]
		[Address(RVA = "0x15EDE6C", Offset = "0x15EDE6C", VA = "0x15EDE6C")]
		public static PlayerFileData GetPreviousData(string file)
		{
			return null;
		}

		// Token: 0x06002C50 RID: 11344 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C50")]
		[Address(RVA = "0x15EE0E8", Offset = "0x15EE0E8", VA = "0x15EE0E8")]
		public static PlayerFileData GetFileData(string file, bool cloudSave)
		{
			return null;
		}

		// Token: 0x06002C51 RID: 11345 RVA: 0x00015750 File Offset: 0x00013950
		[Token(Token = "0x6002C51")]
		[Address(RVA = "0x15EE370", Offset = "0x15EE370", VA = "0x15EE370")]
		public Color GetHairColor(bool useLighting = true)
		{
			return default(Color);
		}

		// Token: 0x06002C52 RID: 11346 RVA: 0x00015768 File Offset: 0x00013968
		[Token(Token = "0x6002C52")]
		[Address(RVA = "0x14BB214", Offset = "0x14BB214", VA = "0x14BB214")]
		public bool HasItem(int type)
		{
			return default(bool);
		}

		// Token: 0x06002C53 RID: 11347 RVA: 0x00015780 File Offset: 0x00013980
		[Token(Token = "0x6002C53")]
		[Address(RVA = "0x15EE524", Offset = "0x15EE524", VA = "0x15EE524")]
		public bool HasItem(int type, Item[] collection)
		{
			return default(bool);
		}

		// Token: 0x06002C54 RID: 11348 RVA: 0x00015798 File Offset: 0x00013998
		[Token(Token = "0x6002C54")]
		[Address(RVA = "0x15564D0", Offset = "0x15564D0", VA = "0x15564D0")]
		public bool HasItemInInventoryOrOpenVoidBag(int type)
		{
			return default(bool);
		}

		// Token: 0x06002C55 RID: 11349 RVA: 0x000157B0 File Offset: 0x000139B0
		[Token(Token = "0x6002C55")]
		[Address(RVA = "0x15E80F8", Offset = "0x15E80F8", VA = "0x15E80F8")]
		public bool HasItemInAnyInventory(int type)
		{
			return default(bool);
		}

		// Token: 0x06002C56 RID: 11350 RVA: 0x000157C8 File Offset: 0x000139C8
		[Token(Token = "0x6002C56")]
		[Address(RVA = "0x14CDCBC", Offset = "0x14CDCBC", VA = "0x14CDCBC")]
		public int FindItem(int type)
		{
			return 0;
		}

		// Token: 0x06002C57 RID: 11351 RVA: 0x000157E0 File Offset: 0x000139E0
		[Token(Token = "0x6002C57")]
		[Address(RVA = "0x15EE5AC", Offset = "0x15EE5AC", VA = "0x15EE5AC")]
		public int FindItem(List<int> types)
		{
			return 0;
		}

		// Token: 0x06002C58 RID: 11352 RVA: 0x000157F8 File Offset: 0x000139F8
		[Token(Token = "0x6002C58")]
		[Address(RVA = "0x15EE690", Offset = "0x15EE690", VA = "0x15EE690")]
		public int FindItem(bool[] validtypes)
		{
			return 0;
		}

		// Token: 0x06002C59 RID: 11353 RVA: 0x00015810 File Offset: 0x00013A10
		[Token(Token = "0x6002C59")]
		[Address(RVA = "0x14BF24C", Offset = "0x14BF24C", VA = "0x14BF24C")]
		public int FindItem(int type, Item[] collection)
		{
			return 0;
		}

		// Token: 0x06002C5A RID: 11354 RVA: 0x00015828 File Offset: 0x00013A28
		[Token(Token = "0x6002C5A")]
		[Address(RVA = "0x15EE730", Offset = "0x15EE730", VA = "0x15EE730")]
		public int FindItemInInventoryOrOpenVoidBag(int type, out bool inVoidBag)
		{
			return 0;
		}

		// Token: 0x06002C5B RID: 11355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C5B")]
		[Address(RVA = "0x14ED830", Offset = "0x14ED830", VA = "0x14ED830")]
		public Player()
		{
		}

		// Token: 0x06002C5C RID: 11356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C5C")]
		[Address(RVA = "0x15A7BEC", Offset = "0x15A7BEC", VA = "0x15A7BEC")]
		public void MagicConch()
		{
		}

		// Token: 0x06002C5D RID: 11357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C5D")]
		[Address(RVA = "0x14AD794", Offset = "0x14AD794", VA = "0x14AD794")]
		public void Shellphone_Spawn()
		{
		}

		// Token: 0x06002C5E RID: 11358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C5E")]
		[Address(RVA = "0x15A8260", Offset = "0x15A8260", VA = "0x15A8260")]
		public void DemonConch()
		{
		}

		// Token: 0x06002C5F RID: 11359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C5F")]
		[Address(RVA = "0x15A8A74", Offset = "0x15A8A74", VA = "0x15A8A74")]
		public void TeleportationPotion()
		{
		}

		// Token: 0x06002C60 RID: 11360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C60")]
		[Address(RVA = "0x15EE8DC", Offset = "0x15EE8DC", VA = "0x15EE8DC")]
		public void GetAnglerReward(NPC angler, int questItemType)
		{
		}

		// Token: 0x06002C61 RID: 11361 RVA: 0x00015840 File Offset: 0x00013A40
		[Token(Token = "0x6002C61")]
		[Address(RVA = "0x15EEAB0", Offset = "0x15EEAB0", VA = "0x15EEAB0")]
		public static float GetAnglerRewardRarityMultiplier(int questsDone)
		{
			return 0f;
		}

		// Token: 0x06002C62 RID: 11362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C62")]
		[Address(RVA = "0x15EEB38", Offset = "0x15EEB38", VA = "0x15EEB38")]
		private void GetAnglerReward_MainReward(IEntitySource source, int questsDone, float rarityReduction, int questItemType, ref GetItemSettings anglerRewardSettings)
		{
		}

		// Token: 0x06002C63 RID: 11363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C63")]
		[Address(RVA = "0x15EFAA0", Offset = "0x15EFAA0", VA = "0x15EFAA0")]
		private void GetAnglerReward_Decoration(IEntitySource source, int questsDone, float rarityReduction, ref GetItemSettings anglerRewardSettings)
		{
		}

		// Token: 0x06002C64 RID: 11364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C64")]
		[Address(RVA = "0x15EFFAC", Offset = "0x15EFFAC", VA = "0x15EFFAC")]
		private void GetAnglerReward_Bait(IEntitySource source, int questsDone, float rarityReduction, ref GetItemSettings anglerRewardSettings)
		{
		}

		// Token: 0x06002C65 RID: 11365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C65")]
		[Address(RVA = "0x15EFD20", Offset = "0x15EFD20", VA = "0x15EFD20")]
		private void GetAnglerReward_Money(IEntitySource source, int questsDone, float rarityReduction, ref GetItemSettings anglerRewardSettings)
		{
		}

		// Token: 0x06002C66 RID: 11366 RVA: 0x00015858 File Offset: 0x00013A58
		[Token(Token = "0x6002C66")]
		[Address(RVA = "0x15F04B8", Offset = "0x15F04B8", VA = "0x15F04B8")]
		public bool DropAnglerAccByMissing(List<int> itemIdsOfAccsWeWant, float totalChance, out bool botheredRollingForADrop, out int itemIdToDrop)
		{
			return default(bool);
		}

		// Token: 0x06002C67 RID: 11367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C67")]
		[Address(RVA = "0x15F0914", Offset = "0x15F0914", VA = "0x15F0914")]
		private void RemoveAnglerAccOptionsFromRewardPool(List<int> itemIdsOfAccsWeWant, Item itemToTestAgainst)
		{
		}

		// Token: 0x06002C68 RID: 11368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C68")]
		[Address(RVA = "0x15F0B08", Offset = "0x15F0B08", VA = "0x15F0B08")]
		public void GetDyeTraderReward(NPC dyeTrader)
		{
		}

		// Token: 0x06002C69 RID: 11369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C69")]
		[Address(RVA = "0x15F1BD4", Offset = "0x15F1BD4", VA = "0x15F1BD4")]
		public void TryPortalJumping()
		{
		}

		// Token: 0x06002C6A RID: 11370 RVA: 0x00015870 File Offset: 0x00013A70
		[Token(Token = "0x6002C6A")]
		[Address(RVA = "0x150525C", Offset = "0x150525C", VA = "0x150525C")]
		public bool ConsumeSolarFlare()
		{
			return default(bool);
		}

		// Token: 0x06002C6B RID: 11371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C6B")]
		[Address(RVA = "0x15F1C78", Offset = "0x15F1C78", VA = "0x15F1C78")]
		public void KeyDoubleTap(int keyDir)
		{
		}

		// Token: 0x06002C6C RID: 11372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C6C")]
		[Address(RVA = "0x15F38BC", Offset = "0x15F38BC", VA = "0x15F38BC")]
		public void UpdateForbiddenSetLock()
		{
		}

		// Token: 0x06002C6D RID: 11373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C6D")]
		[Address(RVA = "0x15F29EC", Offset = "0x15F29EC", VA = "0x15F29EC")]
		public void CommandForbiddenStorm()
		{
		}

		// Token: 0x06002C6E RID: 11374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C6E")]
		[Address(RVA = "0x15F3A98", Offset = "0x15F3A98", VA = "0x15F3A98")]
		public void KeyHoldDown(int keyDir, int holdTime)
		{
		}

		// Token: 0x06002C6F RID: 11375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C6F")]
		[Address(RVA = "0x15D4E60", Offset = "0x15D4E60", VA = "0x15D4E60")]
		public void MinionNPCTargetAim(bool doNotDisableIfTheTargetIsTheSame)
		{
		}

		// Token: 0x06002C70 RID: 11376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C70")]
		[Address(RVA = "0x15F1E2C", Offset = "0x15F1E2C", VA = "0x15F1E2C")]
		public void MinionRestTargetAim()
		{
		}

		// Token: 0x06002C71 RID: 11377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C71")]
		[Address(RVA = "0x15F3C30", Offset = "0x15F3C30", VA = "0x15F3C30")]
		public void UpdateMinionTarget()
		{
		}

		// Token: 0x06002C72 RID: 11378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C72")]
		[Address(RVA = "0x155A68C", Offset = "0x155A68C", VA = "0x155A68C")]
		public void NebulaLevelup(int type)
		{
		}

		// Token: 0x06002C73 RID: 11379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C73")]
		[Address(RVA = "0x1513B60", Offset = "0x1513B60", VA = "0x1513B60")]
		public void UpdateTouchingTiles()
		{
		}

		// Token: 0x0400389D RID: 14493
		[Token(Token = "0x400389D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static float _blizzardSoundVolume;

		// Token: 0x0400389E RID: 14494
		[Token(Token = "0x400389E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static SlotId _strongBlizzardSound;

		// Token: 0x0400389F RID: 14495
		[Token(Token = "0x400389F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static SlotId _insideBlizzardSound;

		// Token: 0x040038A0 RID: 14496
		[Token(Token = "0x40038A0")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public static int taxRate;

		// Token: 0x040038A1 RID: 14497
		[Token(Token = "0x40038A1")]
		public const int crystalLeafDamage = 100;

		// Token: 0x040038A2 RID: 14498
		[Token(Token = "0x40038A2")]
		public const int crystalLeafKB = 10;

		// Token: 0x040038A3 RID: 14499
		[Token(Token = "0x40038A3")]
		public const int manaSickTime = 300;

		// Token: 0x040038A4 RID: 14500
		[Token(Token = "0x40038A4")]
		public const int manaSickTimeMax = 600;

		// Token: 0x040038A5 RID: 14501
		[Token(Token = "0x40038A5")]
		public const float manaSickLessDmg = 0.25f;

		// Token: 0x040038A6 RID: 14502
		[Token(Token = "0x40038A6")]
		public const int nameLen = 20;

		// Token: 0x040038A7 RID: 14503
		[Token(Token = "0x40038A7")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static bool deadForGood;

		// Token: 0x040038A8 RID: 14504
		[Token(Token = "0x40038A8")]
		public const int DefaultTileRangeX = 5;

		// Token: 0x040038A9 RID: 14505
		[Token(Token = "0x40038A9")]
		public const int DefaultTileRangeY = 3;

		// Token: 0x040038AA RID: 14506
		[Token(Token = "0x40038AA")]
		public const float defaultGravity = 0.4f;

		// Token: 0x040038AB RID: 14507
		[Token(Token = "0x40038AB")]
		public const float originalRunSpeed = 3f;

		// Token: 0x040038AC RID: 14508
		[Token(Token = "0x40038AC")]
		public const int defaultItemGrabRange = 42;

		// Token: 0x040038AD RID: 14509
		[Token(Token = "0x40038AD")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private static GameCulture lastArmourCulture;

		// Token: 0x040038AE RID: 14510
		[Token(Token = "0x40038AE")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static string lastId;

		// Token: 0x040038AF RID: 14511
		[Token(Token = "0x40038AF")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private static string lastFormatId;

		// Token: 0x040038B0 RID: 14512
		[Token(Token = "0x40038B0")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static string lastResult;

		// Token: 0x040038B1 RID: 14513
		[Token(Token = "0x40038B1")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private static SmartInteractSystem _smartInteractSys;

		// Token: 0x040038B2 RID: 14514
		[Token(Token = "0x40038B2")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static int[] _torchAttackPosX;

		// Token: 0x040038B3 RID: 14515
		[Token(Token = "0x40038B3")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private static int[] _torchAttackPosY;

		// Token: 0x040038B4 RID: 14516
		[Token(Token = "0x40038B4")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static bool requestedSignInfo;

		// Token: 0x040038B5 RID: 14517
		[Token(Token = "0x40038B5")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public static int lastRequestSignX;

		// Token: 0x040038B6 RID: 14518
		[Token(Token = "0x40038B6")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static int lastRequestSignY;

		// Token: 0x040038B7 RID: 14519
		[Token(Token = "0x40038B7")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private static List<Projectile> _oldestProjCheckList;

		// Token: 0x040038B8 RID: 14520
		[Token(Token = "0x40038B8")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static Player EmptyPlayer;

		// Token: 0x040038B9 RID: 14521
		[Token(Token = "0x40038B9")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x41")]
		public bool active;

		// Token: 0x040038BA RID: 14522
		[Token(Token = "0x40038BA")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x42")]
		public bool host;

		// Token: 0x040038BB RID: 14523
		[Token(Token = "0x40038BB")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Minecart.Customization MinecartSettings;

		// Token: 0x040038BC RID: 14524
		[Token(Token = "0x40038BC")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public int emoteTime;

		// Token: 0x040038BD RID: 14525
		[Token(Token = "0x40038BD")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public CreativeUnlocksTracker creativeTracker;

		// Token: 0x040038BE RID: 14526
		[Token(Token = "0x40038BE")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private static byte[] ENCRYPTION_KEY;

		// Token: 0x040038BF RID: 14527
		[Token(Token = "0x40038BF")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Player.OverheadMessage chatOverhead;

		// Token: 0x040038C0 RID: 14528
		[Token(Token = "0x40038C0")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Player.SelectionRadial DpadRadial;

		// Token: 0x040038C1 RID: 14529
		[Token(Token = "0x40038C1")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public Player.SelectionRadial CircularRadial;

		// Token: 0x040038C2 RID: 14530
		[Token(Token = "0x40038C2")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Player.SelectionRadial QuicksRadial;

		// Token: 0x040038C3 RID: 14531
		[Token(Token = "0x40038C3")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public bool alchemyTable;

		// Token: 0x040038C4 RID: 14532
		[Token(Token = "0x40038C4")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x85")]
		public bool GoingDownWithGrapple;

		// Token: 0x040038C5 RID: 14533
		[Token(Token = "0x40038C5")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x86")]
		public byte spelunkerTimer;

		// Token: 0x040038C6 RID: 14534
		[Token(Token = "0x40038C6")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public bool[] hideInfo;

		// Token: 0x040038C7 RID: 14535
		[Token(Token = "0x40038C7")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public int[] builderAccStatus;

		// Token: 0x040038C8 RID: 14536
		[Token(Token = "0x40038C8")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public long lostCoins;

		// Token: 0x040038C9 RID: 14537
		[Token(Token = "0x40038C9")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public string lostCoinString;

		// Token: 0x040038CA RID: 14538
		[Token(Token = "0x40038CA")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public int soulDrain;

		// Token: 0x040038CB RID: 14539
		[Token(Token = "0x40038CB")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public float drainBoost;

		// Token: 0x040038CC RID: 14540
		[Token(Token = "0x40038CC")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public bool dd2Accessory;

		// Token: 0x040038CD RID: 14541
		[Token(Token = "0x40038CD")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public string name;

		// Token: 0x040038CE RID: 14542
		[Token(Token = "0x40038CE")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public int LastEmoticon;

		// Token: 0x040038CF RID: 14543
		[Token(Token = "0x40038CF")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public int LastEmoticonCount;

		// Token: 0x040038D0 RID: 14544
		[Token(Token = "0x40038D0")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public DateTime LastEmoticonTime;

		// Token: 0x040038D1 RID: 14545
		[Token(Token = "0x40038D1")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public int taxMoney;

		// Token: 0x040038D2 RID: 14546
		[Token(Token = "0x40038D2")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public int taxTimer;

		// Token: 0x040038D3 RID: 14547
		[Token(Token = "0x40038D3")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public int numberOfDeathsPVE;

		// Token: 0x040038D4 RID: 14548
		[Token(Token = "0x40038D4")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		public int numberOfDeathsPVP;

		// Token: 0x040038D5 RID: 14549
		[Token(Token = "0x40038D5")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public float basiliskCharge;

		// Token: 0x040038D6 RID: 14550
		[Token(Token = "0x40038D6")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static float PaladinsShieldRange;

		// Token: 0x040038D7 RID: 14551
		[Token(Token = "0x40038D7")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		public Vector2 lastDeathPostion;

		// Token: 0x040038D8 RID: 14552
		[Token(Token = "0x40038D8")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public DateTime lastDeathTime;

		// Token: 0x040038D9 RID: 14553
		[Token(Token = "0x40038D9")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public bool showLastDeath;

		// Token: 0x040038DA RID: 14554
		[Token(Token = "0x40038DA")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xE9")]
		public bool usedAegisCrystal;

		// Token: 0x040038DB RID: 14555
		[Token(Token = "0x40038DB")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xEA")]
		public bool usedAegisFruit;

		// Token: 0x040038DC RID: 14556
		[Token(Token = "0x40038DC")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xEB")]
		public bool usedArcaneCrystal;

		// Token: 0x040038DD RID: 14557
		[Token(Token = "0x40038DD")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		public bool usedGalaxyPearl;

		// Token: 0x040038DE RID: 14558
		[Token(Token = "0x40038DE")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xED")]
		public bool usedGummyWorm;

		// Token: 0x040038DF RID: 14559
		[Token(Token = "0x40038DF")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xEE")]
		public bool usedAmbrosia;

		// Token: 0x040038E0 RID: 14560
		[Token(Token = "0x40038E0")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public int extraAccessorySlots;

		// Token: 0x040038E1 RID: 14561
		[Token(Token = "0x40038E1")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		public int extraAccessorySlotsUse;

		// Token: 0x040038E2 RID: 14562
		[Token(Token = "0x40038E2")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		public bool extraAccessory;

		// Token: 0x040038E3 RID: 14563
		[Token(Token = "0x40038E3")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xF9")]
		private bool dontConsumeWand;

		// Token: 0x040038E4 RID: 14564
		[Token(Token = "0x40038E4")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		public int tankPet;

		// Token: 0x040038E5 RID: 14565
		[Token(Token = "0x40038E5")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public bool tankPetReset;

		// Token: 0x040038E6 RID: 14566
		[Token(Token = "0x40038E6")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		public int stringColor;

		// Token: 0x040038E7 RID: 14567
		[Token(Token = "0x40038E7")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public int counterWeight;

		// Token: 0x040038E8 RID: 14568
		[Token(Token = "0x40038E8")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		public int vanityCounterWeight;

		// Token: 0x040038E9 RID: 14569
		[Token(Token = "0x40038E9")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public bool magicString;

		// Token: 0x040038EA RID: 14570
		[Token(Token = "0x40038EA")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x111")]
		public bool yoyoString;

		// Token: 0x040038EB RID: 14571
		[Token(Token = "0x40038EB")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x112")]
		public bool yoyoGlove;

		// Token: 0x040038EC RID: 14572
		[Token(Token = "0x40038EC")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		private float rapidAttackBonus;

		// Token: 0x040038ED RID: 14573
		[Token(Token = "0x40038ED")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public bool stressBall;

		// Token: 0x040038EE RID: 14574
		[Token(Token = "0x40038EE")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x119")]
		public bool stressBallPrevious;

		// Token: 0x040038EF RID: 14575
		[Token(Token = "0x40038EF")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x11A")]
		public bool staffOfRegrowthBonus;

		// Token: 0x040038F0 RID: 14576
		[Token(Token = "0x40038F0")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		public int chlorophyteBladeCounter;

		// Token: 0x040038F1 RID: 14577
		[Token(Token = "0x40038F1")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public int beetleOrbs;

		// Token: 0x040038F2 RID: 14578
		[Token(Token = "0x40038F2")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		public float beetleCounter;

		// Token: 0x040038F3 RID: 14579
		[Token(Token = "0x40038F3")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		public int beetleCountdown;

		// Token: 0x040038F4 RID: 14580
		[Token(Token = "0x40038F4")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		public bool beetleDefense;

		// Token: 0x040038F5 RID: 14581
		[Token(Token = "0x40038F5")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x12D")]
		public bool beetleOffense;

		// Token: 0x040038F6 RID: 14582
		[Token(Token = "0x40038F6")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x12E")]
		public bool beetleBuff;

		// Token: 0x040038F7 RID: 14583
		[Token(Token = "0x40038F7")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		public int solarShields;

		// Token: 0x040038F8 RID: 14584
		[Token(Token = "0x40038F8")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x134")]
		public int solarCounter;

		// Token: 0x040038F9 RID: 14585
		[Token(Token = "0x40038F9")]
		public const int maxSolarShields = 3;

		// Token: 0x040038FA RID: 14586
		[Token(Token = "0x40038FA")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		public Vector2[] solarShieldPos;

		// Token: 0x040038FB RID: 14587
		[Token(Token = "0x40038FB")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		public Vector2[] solarShieldVel;

		// Token: 0x040038FC RID: 14588
		[Token(Token = "0x40038FC")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		public bool solarDashing;

		// Token: 0x040038FD RID: 14589
		[Token(Token = "0x40038FD")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x141")]
		public bool solarDashConsumedFlare;

		// Token: 0x040038FE RID: 14590
		[Token(Token = "0x40038FE")]
		public const int nebulaMaxLevel = 3;

		// Token: 0x040038FF RID: 14591
		[Token(Token = "0x40038FF")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x144")]
		public int nebulaLevelLife;

		// Token: 0x04003900 RID: 14592
		[Token(Token = "0x4003900")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		public int nebulaLevelMana;

		// Token: 0x04003901 RID: 14593
		[Token(Token = "0x4003901")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
		public int nebulaManaCounter;

		// Token: 0x04003902 RID: 14594
		[Token(Token = "0x4003902")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		public int nebulaLevelDamage;

		// Token: 0x04003903 RID: 14595
		[Token(Token = "0x4003903")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x154")]
		public bool manaMagnet;

		// Token: 0x04003904 RID: 14596
		[Token(Token = "0x4003904")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x155")]
		public bool lifeMagnet;

		// Token: 0x04003905 RID: 14597
		[Token(Token = "0x4003905")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x156")]
		public bool treasureMagnet;

		// Token: 0x04003906 RID: 14598
		[Token(Token = "0x4003906")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x157")]
		public bool chiselSpeed;

		// Token: 0x04003907 RID: 14599
		[Token(Token = "0x4003907")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		public bool lifeForce;

		// Token: 0x04003908 RID: 14600
		[Token(Token = "0x4003908")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x159")]
		public bool hasDeadCellsDownDash;

		// Token: 0x04003909 RID: 14601
		[Token(Token = "0x4003909")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x15A")]
		public bool calmed;

		// Token: 0x0400390A RID: 14602
		[Token(Token = "0x400390A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x15B")]
		public bool inferno;

		// Token: 0x0400390B RID: 14603
		[Token(Token = "0x400390B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
		public float flameRingRot;

		// Token: 0x0400390C RID: 14604
		[Token(Token = "0x400390C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		public float flameRingScale;

		// Token: 0x0400390D RID: 14605
		[Token(Token = "0x400390D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		public byte flameRingFrame;

		// Token: 0x0400390E RID: 14606
		[Token(Token = "0x400390E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x165")]
		public byte flameRingAlpha;

		// Token: 0x0400390F RID: 14607
		[Token(Token = "0x400390F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		public int netManaTime;

		// Token: 0x04003910 RID: 14608
		[Token(Token = "0x4003910")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		public int netLifeTime;

		// Token: 0x04003911 RID: 14609
		[Token(Token = "0x4003911")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		public bool netMana;

		// Token: 0x04003912 RID: 14610
		[Token(Token = "0x4003912")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x171")]
		public bool netLife;

		// Token: 0x04003913 RID: 14611
		[Token(Token = "0x4003913")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x174")]
		public Vector2[] beetlePos;

		// Token: 0x04003914 RID: 14612
		[Token(Token = "0x4003914")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		public Vector2[] beetleVel;

		// Token: 0x04003915 RID: 14613
		[Token(Token = "0x4003915")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
		public int beetleFrame;

		// Token: 0x04003916 RID: 14614
		[Token(Token = "0x4003916")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		public int beetleFrameCounter;

		// Token: 0x04003917 RID: 14615
		[Token(Token = "0x4003917")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x184")]
		public float manaSickReduction;

		// Token: 0x04003918 RID: 14616
		[Token(Token = "0x4003918")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		public bool manaSick;

		// Token: 0x04003919 RID: 14617
		[Token(Token = "0x4003919")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x189")]
		public bool slowMagicUse;

		// Token: 0x0400391A RID: 14618
		[Token(Token = "0x400391A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
		public float manaHeat;

		// Token: 0x0400391B RID: 14619
		[Token(Token = "0x400391B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		public float latestManaPotionDamageBonus;

		// Token: 0x0400391C RID: 14620
		[Token(Token = "0x400391C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x194")]
		public float latestManaPotionDuration;

		// Token: 0x0400391D RID: 14621
		[Token(Token = "0x400391D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		public int afkCounter;

		// Token: 0x0400391E RID: 14622
		[Token(Token = "0x400391E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public static readonly int AFKTimeNeededForNoWormSpawns;

		// Token: 0x0400391F RID: 14623
		[Token(Token = "0x400391F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public static readonly int AFKTimeNeededForNoLuckyStars;

		// Token: 0x04003920 RID: 14624
		[Token(Token = "0x4003920")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
		public int afkCounterForKiting;

		// Token: 0x04003921 RID: 14625
		[Token(Token = "0x4003921")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public static int AFKTimeNeededForAutoKiting;

		// Token: 0x04003922 RID: 14626
		[Token(Token = "0x4003922")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		public bool stairFall;

		// Token: 0x04003923 RID: 14627
		[Token(Token = "0x4003923")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1A4")]
		public int loadStatus;

		// Token: 0x04003924 RID: 14628
		[Token(Token = "0x4003924")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		public Vector2[] itemFlamePos;

		// Token: 0x04003925 RID: 14629
		[Token(Token = "0x4003925")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1AC")]
		public int itemFlameCount;

		// Token: 0x04003926 RID: 14630
		[Token(Token = "0x4003926")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		public bool outOfRange;

		// Token: 0x04003927 RID: 14631
		[Token(Token = "0x4003927")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1B4")]
		public float lifeSteal;

		// Token: 0x04003928 RID: 14632
		[Token(Token = "0x4003928")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		public float ghostDmg;

		// Token: 0x04003929 RID: 14633
		[Token(Token = "0x4003929")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1BC")]
		public bool teleporting;

		// Token: 0x0400392A RID: 14634
		[Token(Token = "0x400392A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		public float teleportTime;

		// Token: 0x0400392B RID: 14635
		[Token(Token = "0x400392B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C4")]
		public int teleportStyle;

		// Token: 0x0400392C RID: 14636
		[Token(Token = "0x400392C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		public int unacknowledgedTeleports;

		// Token: 0x0400392D RID: 14637
		[Token(Token = "0x400392D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1CC")]
		public bool sloping;

		// Token: 0x0400392E RID: 14638
		[Token(Token = "0x400392E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1CD")]
		public bool chilled;

		// Token: 0x0400392F RID: 14639
		[Token(Token = "0x400392F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1CE")]
		public bool dazed;

		// Token: 0x04003930 RID: 14640
		[Token(Token = "0x4003930")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1CF")]
		public bool frozen;

		// Token: 0x04003931 RID: 14641
		[Token(Token = "0x4003931")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		public bool stoned;

		// Token: 0x04003932 RID: 14642
		[Token(Token = "0x4003932")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1D1")]
		public bool lastStoned;

		// Token: 0x04003933 RID: 14643
		[Token(Token = "0x4003933")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1D2")]
		public bool ichor;

		// Token: 0x04003934 RID: 14644
		[Token(Token = "0x4003934")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1D3")]
		public bool webbed;

		// Token: 0x04003935 RID: 14645
		[Token(Token = "0x4003935")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1D4")]
		public bool tipsy;

		// Token: 0x04003936 RID: 14646
		[Token(Token = "0x4003936")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1D5")]
		public bool noBuilding;

		// Token: 0x04003937 RID: 14647
		[Token(Token = "0x4003937")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		public int ropeCount;

		// Token: 0x04003938 RID: 14648
		[Token(Token = "0x4003938")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1DC")]
		public int manaRegenBonus;

		// Token: 0x04003939 RID: 14649
		[Token(Token = "0x4003939")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		public float manaRegenDelayBonus;

		// Token: 0x0400393A RID: 14650
		[Token(Token = "0x400393A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1E4")]
		public int dashType;

		// Token: 0x0400393B RID: 14651
		[Token(Token = "0x400393B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		public int dash;

		// Token: 0x0400393C RID: 14652
		[Token(Token = "0x400393C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1EC")]
		public int dashTime;

		// Token: 0x0400393D RID: 14653
		[Token(Token = "0x400393D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		public int timeSinceLastDashStarted;

		// Token: 0x0400393E RID: 14654
		[Token(Token = "0x400393E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1F4")]
		public int dashDelay;

		// Token: 0x0400393F RID: 14655
		[Token(Token = "0x400393F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		public int eocDash;

		// Token: 0x04003940 RID: 14656
		[Token(Token = "0x4003940")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1FC")]
		public int eocHit;

		// Token: 0x04003941 RID: 14657
		[Token(Token = "0x4003941")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		public float accRunSpeed;

		// Token: 0x04003942 RID: 14658
		[Token(Token = "0x4003942")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x204")]
		public bool cordage;

		// Token: 0x04003943 RID: 14659
		[Token(Token = "0x4003943")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		public int gem;

		// Token: 0x04003944 RID: 14660
		[Token(Token = "0x4003944")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x20C")]
		public int gemCount;

		// Token: 0x04003945 RID: 14661
		[Token(Token = "0x4003945")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x210")]
		public BitsByte ownedLargeGems;

		// Token: 0x04003946 RID: 14662
		[Token(Token = "0x4003946")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x211")]
		public byte meleeEnchant;

		// Token: 0x04003947 RID: 14663
		[Token(Token = "0x4003947")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x212")]
		public byte pulleyDir;

		// Token: 0x04003948 RID: 14664
		[Token(Token = "0x4003948")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x213")]
		public bool pulley;

		// Token: 0x04003949 RID: 14665
		[Token(Token = "0x4003949")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x214")]
		public int pulleyFrame;

		// Token: 0x0400394A RID: 14666
		[Token(Token = "0x400394A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		public float pulleyFrameCounter;

		// Token: 0x0400394B RID: 14667
		[Token(Token = "0x400394B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x21C")]
		public bool blackBelt;

		// Token: 0x0400394C RID: 14668
		[Token(Token = "0x400394C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x21D")]
		public bool mysticSashDodge;

		// Token: 0x0400394D RID: 14669
		[Token(Token = "0x400394D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x21E")]
		public bool sliding;

		// Token: 0x0400394E RID: 14670
		[Token(Token = "0x400394E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x220")]
		public int slideDir;

		// Token: 0x0400394F RID: 14671
		[Token(Token = "0x400394F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x224")]
		public int snowBallLauncherInteractionCooldown;

		// Token: 0x04003950 RID: 14672
		[Token(Token = "0x4003950")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x228")]
		public bool iceSkate;

		// Token: 0x04003951 RID: 14673
		[Token(Token = "0x4003951")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x229")]
		public bool carpet;

		// Token: 0x04003952 RID: 14674
		[Token(Token = "0x4003952")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x22C")]
		public int spikedBoots;

		// Token: 0x04003953 RID: 14675
		[Token(Token = "0x4003953")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x230")]
		public int carpetFrame;

		// Token: 0x04003954 RID: 14676
		[Token(Token = "0x4003954")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x234")]
		public float carpetFrameCounter;

		// Token: 0x04003955 RID: 14677
		[Token(Token = "0x4003955")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x238")]
		public bool canCarpet;

		// Token: 0x04003956 RID: 14678
		[Token(Token = "0x4003956")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x23C")]
		public int carpetTime;

		// Token: 0x04003957 RID: 14679
		[Token(Token = "0x4003957")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x240")]
		public int miscCounter;

		// Token: 0x04003958 RID: 14680
		[Token(Token = "0x4003958")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x244")]
		public int infernoCounter;

		// Token: 0x04003959 RID: 14681
		[Token(Token = "0x4003959")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x248")]
		public int insanityShadowCooldown;

		// Token: 0x0400395A RID: 14682
		[Token(Token = "0x400395A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x24C")]
		public int starCloakCooldown;

		// Token: 0x0400395B RID: 14683
		[Token(Token = "0x400395B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x250")]
		public bool sandStorm;

		// Token: 0x0400395C RID: 14684
		[Token(Token = "0x400395C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x251")]
		public bool crimsonRegen;

		// Token: 0x0400395D RID: 14685
		[Token(Token = "0x400395D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x252")]
		public bool ghostHeal;

		// Token: 0x0400395E RID: 14686
		[Token(Token = "0x400395E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x253")]
		public bool ghostHurt;

		// Token: 0x0400395F RID: 14687
		[Token(Token = "0x400395F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x254")]
		public bool sticky;

		// Token: 0x04003960 RID: 14688
		[Token(Token = "0x4003960")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x255")]
		public bool slippy;

		// Token: 0x04003961 RID: 14689
		[Token(Token = "0x4003961")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x256")]
		public bool slippy2;

		// Token: 0x04003962 RID: 14690
		[Token(Token = "0x4003962")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x257")]
		public bool powerrun;

		// Token: 0x04003963 RID: 14691
		[Token(Token = "0x4003963")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x258")]
		public bool runningOnSand;

		// Token: 0x04003964 RID: 14692
		[Token(Token = "0x4003964")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x259")]
		public bool flapSound;

		// Token: 0x04003965 RID: 14693
		[Token(Token = "0x4003965")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x25A")]
		public bool iceBarrier;

		// Token: 0x04003966 RID: 14694
		[Token(Token = "0x4003966")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x25B")]
		public bool dangerSense;

		// Token: 0x04003967 RID: 14695
		[Token(Token = "0x4003967")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x25C")]
		public byte luckPotion;

		// Token: 0x04003968 RID: 14696
		[Token(Token = "0x4003968")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x25D")]
		public byte oldLuckPotion;

		// Token: 0x04003969 RID: 14697
		[Token(Token = "0x4003969")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x260")]
		public float endurance;

		// Token: 0x0400396A RID: 14698
		[Token(Token = "0x400396A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x264")]
		public float whipRangeMultiplier;

		// Token: 0x0400396B RID: 14699
		[Token(Token = "0x400396B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x268")]
		public float whipUseTimeMultiplier;

		// Token: 0x0400396C RID: 14700
		[Token(Token = "0x400396C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x26C")]
		public bool loveStruck;

		// Token: 0x0400396D RID: 14701
		[Token(Token = "0x400396D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x26D")]
		public bool stinky;

		// Token: 0x0400396E RID: 14702
		[Token(Token = "0x400396E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x26E")]
		public bool resistCold;

		// Token: 0x0400396F RID: 14703
		[Token(Token = "0x400396F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x26F")]
		public bool electrified;

		// Token: 0x04003970 RID: 14704
		[Token(Token = "0x4003970")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x270")]
		public bool dryadWard;

		// Token: 0x04003971 RID: 14705
		[Token(Token = "0x4003971")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x271")]
		public bool panic;

		// Token: 0x04003972 RID: 14706
		[Token(Token = "0x4003972")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x274")]
		public Item brainOfConfusionItem;

		// Token: 0x04003973 RID: 14707
		[Token(Token = "0x4003973")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x278")]
		public int brainOfConfusionDodgeAnimationCounter;

		// Token: 0x04003974 RID: 14708
		[Token(Token = "0x4003974")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x27C")]
		public byte iceBarrierFrame;

		// Token: 0x04003975 RID: 14709
		[Token(Token = "0x4003975")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x27D")]
		public byte iceBarrierFrameCounter;

		// Token: 0x04003976 RID: 14710
		[Token(Token = "0x4003976")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x27E")]
		public bool shadowDodge;

		// Token: 0x04003977 RID: 14711
		[Token(Token = "0x4003977")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x280")]
		public float shadowDodgeCount;

		// Token: 0x04003978 RID: 14712
		[Token(Token = "0x4003978")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x284")]
		public bool palladiumRegen;

		// Token: 0x04003979 RID: 14713
		[Token(Token = "0x4003979")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x285")]
		public bool onHitDodge;

		// Token: 0x0400397A RID: 14714
		[Token(Token = "0x400397A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x286")]
		public bool onHitRegen;

		// Token: 0x0400397B RID: 14715
		[Token(Token = "0x400397B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x287")]
		public bool onHitPetal;

		// Token: 0x0400397C RID: 14716
		[Token(Token = "0x400397C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x288")]
		public bool onHitTitaniumStorm;

		// Token: 0x0400397D RID: 14717
		[Token(Token = "0x400397D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x28C")]
		public int titaniumStormCooldown;

		// Token: 0x0400397E RID: 14718
		[Token(Token = "0x400397E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x290")]
		public bool hasTitaniumStormBuff;

		// Token: 0x0400397F RID: 14719
		[Token(Token = "0x400397F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x294")]
		public int petalTimer;

		// Token: 0x04003980 RID: 14720
		[Token(Token = "0x4003980")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x298")]
		public int shadowDodgeTimer;

		// Token: 0x04003981 RID: 14721
		[Token(Token = "0x4003981")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x29C")]
		public int boneGloveTimer;

		// Token: 0x04003982 RID: 14722
		[Token(Token = "0x4003982")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x2A0")]
		public int phantomPhoneixCounter;

		// Token: 0x04003983 RID: 14723
		[Token(Token = "0x4003983")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x2A4")]
		public int fishingSkill;

		// Token: 0x04003984 RID: 14724
		[Token(Token = "0x4003984")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x2A8")]
		public bool cratePotion;

		// Token: 0x04003985 RID: 14725
		[Token(Token = "0x4003985")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x2A9")]
		public bool sonarPotion;

		// Token: 0x04003986 RID: 14726
		[Token(Token = "0x4003986")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x2AA")]
		public bool accFishingLine;

		// Token: 0x04003987 RID: 14727
		[Token(Token = "0x4003987")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x2AB")]
		public bool accFishingBobber;

		// Token: 0x04003988 RID: 14728
		[Token(Token = "0x4003988")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x2AC")]
		public bool accTackleBox;

		// Token: 0x04003989 RID: 14729
		[Token(Token = "0x4003989")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x2AD")]
		public bool accLavaFishing;

		// Token: 0x0400398A RID: 14730
		[Token(Token = "0x400398A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x2B0")]
		public int maxTagEffects;

		// Token: 0x0400398B RID: 14731
		[Token(Token = "0x400398B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x2B4")]
		public float tagEffectDuration;

		// Token: 0x0400398C RID: 14732
		[Token(Token = "0x400398C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x2B8")]
		public bool accSnakeBand;

		// Token: 0x0400398D RID: 14733
		[Token(Token = "0x400398D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x2B9")]
		public bool accSilverBracer;

		// Token: 0x0400398E RID: 14734
		[Token(Token = "0x400398E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x2BA")]
		public bool accMobiusStrip;

		// Token: 0x0400398F RID: 14735
		[Token(Token = "0x400398F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x2BB")]
		public bool accWickedArmlet;

		// Token: 0x04003990 RID: 14736
		[Token(Token = "0x4003990")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x2BC")]
		public int repeatWhipSwings;

		// Token: 0x04003991 RID: 14737
		[Token(Token = "0x4003991")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x2C0")]
		public int repeatWhipsResetCooldown;

		// Token: 0x04003992 RID: 14738
		[Token(Token = "0x4003992")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x2C4")]
		public int yoyoHitCounter;

		// Token: 0x04003993 RID: 14739
		[Token(Token = "0x4003993")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x2C8")]
		public bool accAmmoCyclerDamage;

		// Token: 0x04003994 RID: 14740
		[Token(Token = "0x4003994")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x2C9")]
		public bool accSharpBarb;

		// Token: 0x04003995 RID: 14741
		[Token(Token = "0x4003995")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x2CA")]
		public bool accSnappingStone;

		// Token: 0x04003996 RID: 14742
		[Token(Token = "0x4003996")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x2CB")]
		public bool accPyroclast;

		// Token: 0x04003997 RID: 14743
		[Token(Token = "0x4003997")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x2CC")]
		public bool accArmletOfRuin;

		// Token: 0x04003998 RID: 14744
		[Token(Token = "0x4003998")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x2D0")]
		public int accSnappingStoneCooldown;

		// Token: 0x04003999 RID: 14745
		[Token(Token = "0x4003999")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x2D4")]
		public bool accHarpyCharm;

		// Token: 0x0400399A RID: 14746
		[Token(Token = "0x400399A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x2D8")]
		public int accHarpyCharmCooldown;

		// Token: 0x0400399B RID: 14747
		[Token(Token = "0x400399B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x2DC")]
		public bool accSeraphNecklace;

		// Token: 0x0400399C RID: 14748
		[Token(Token = "0x400399C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x2DD")]
		public bool accPoisonBarb;

		// Token: 0x0400399D RID: 14749
		[Token(Token = "0x400399D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x2DE")]
		public bool accHoneyedBarb;

		// Token: 0x0400399E RID: 14750
		[Token(Token = "0x400399E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x2E0")]
		public PlayerAmmoCyclingMode ammoCyclingMode;

		// Token: 0x0400399F RID: 14751
		[Token(Token = "0x400399F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x2E4")]
		public int ammoCyclingCooldown;

		// Token: 0x040039A0 RID: 14752
		[Token(Token = "0x40039A0")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x2E8")]
		public int ammoCyclingOffset;

		// Token: 0x040039A1 RID: 14753
		[Token(Token = "0x40039A1")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x2EC")]
		public bool accSentryBackpack;

		// Token: 0x040039A2 RID: 14754
		[Token(Token = "0x40039A2")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x2ED")]
		public bool accGolemSentryBackpack;

		// Token: 0x040039A3 RID: 14755
		[Token(Token = "0x40039A3")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x2F0")]
		public int accSentryBackpackGrabCooldown;

		// Token: 0x040039A4 RID: 14756
		[Token(Token = "0x40039A4")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x2F4")]
		public bool accTimerCrit;

		// Token: 0x040039A5 RID: 14757
		[Token(Token = "0x40039A5")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x2F8")]
		public float accTimerCritCharge;

		// Token: 0x040039A6 RID: 14758
		[Token(Token = "0x40039A6")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x2FC")]
		public int maxMinions;

		// Token: 0x040039A7 RID: 14759
		[Token(Token = "0x40039A7")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x300")]
		public int numMinions;

		// Token: 0x040039A8 RID: 14760
		[Token(Token = "0x40039A8")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x304")]
		public float slotsMinions;

		// Token: 0x040039A9 RID: 14761
		[Token(Token = "0x40039A9")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x308")]
		public bool pygmy;

		// Token: 0x040039AA RID: 14762
		[Token(Token = "0x40039AA")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x309")]
		public bool raven;

		// Token: 0x040039AB RID: 14763
		[Token(Token = "0x40039AB")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x30A")]
		public bool slime;

		// Token: 0x040039AC RID: 14764
		[Token(Token = "0x40039AC")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x30B")]
		public bool hornetMinion;

		// Token: 0x040039AD RID: 14765
		[Token(Token = "0x40039AD")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x30C")]
		public bool impMinion;

		// Token: 0x040039AE RID: 14766
		[Token(Token = "0x40039AE")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x30D")]
		public bool twinsMinion;

		// Token: 0x040039AF RID: 14767
		[Token(Token = "0x40039AF")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x30E")]
		public bool spiderMinion;

		// Token: 0x040039B0 RID: 14768
		[Token(Token = "0x40039B0")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x310")]
		public int nextCycledSpiderMinionType;

		// Token: 0x040039B1 RID: 14769
		[Token(Token = "0x40039B1")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x314")]
		public bool pirateMinion;

		// Token: 0x040039B2 RID: 14770
		[Token(Token = "0x40039B2")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x315")]
		public bool sharknadoMinion;

		// Token: 0x040039B3 RID: 14771
		[Token(Token = "0x40039B3")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x316")]
		public bool UFOMinion;

		// Token: 0x040039B4 RID: 14772
		[Token(Token = "0x40039B4")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x317")]
		public bool DeadlySphereMinion;

		// Token: 0x040039B5 RID: 14773
		[Token(Token = "0x40039B5")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x318")]
		public bool stardustMinion;

		// Token: 0x040039B6 RID: 14774
		[Token(Token = "0x40039B6")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x319")]
		public bool stardustGuardian;

		// Token: 0x040039B7 RID: 14775
		[Token(Token = "0x40039B7")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x31A")]
		public bool stardustDragon;

		// Token: 0x040039B8 RID: 14776
		[Token(Token = "0x40039B8")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x31B")]
		public bool batsOfLight;

		// Token: 0x040039B9 RID: 14777
		[Token(Token = "0x40039B9")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x31C")]
		public bool babyBird;

		// Token: 0x040039BA RID: 14778
		[Token(Token = "0x40039BA")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x31D")]
		public bool vampireFrog;

		// Token: 0x040039BB RID: 14779
		[Token(Token = "0x40039BB")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x31E")]
		public bool stormTiger;

		// Token: 0x040039BC RID: 14780
		[Token(Token = "0x40039BC")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x320")]
		public int highestStormTigerGemOriginalDamage;

		// Token: 0x040039BD RID: 14781
		[Token(Token = "0x40039BD")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x324")]
		public bool smolstar;

		// Token: 0x040039BE RID: 14782
		[Token(Token = "0x40039BE")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x325")]
		public bool empressBlade;

		// Token: 0x040039BF RID: 14783
		[Token(Token = "0x40039BF")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x326")]
		public bool flinxMinion;

		// Token: 0x040039C0 RID: 14784
		[Token(Token = "0x40039C0")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x327")]
		public bool abigailMinion;

		// Token: 0x040039C1 RID: 14785
		[Token(Token = "0x40039C1")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x328")]
		public int highestAbigailCounterOriginalDamage;

		// Token: 0x040039C2 RID: 14786
		[Token(Token = "0x40039C2")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x32C")]
		public bool deadCellsMushroomBoiMinion;

		// Token: 0x040039C3 RID: 14787
		[Token(Token = "0x40039C3")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x32D")]
		public bool palworldCattivaMinion;

		// Token: 0x040039C4 RID: 14788
		[Token(Token = "0x40039C4")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x32E")]
		public bool palworldFoxsparksMinion;

		// Token: 0x040039C5 RID: 14789
		[Token(Token = "0x40039C5")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x32F")]
		public bool palworldTrustyCattivaMinion;

		// Token: 0x040039C6 RID: 14790
		[Token(Token = "0x40039C6")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x330")]
		public bool palworldTrustyFoxsparksMinion;

		// Token: 0x040039C7 RID: 14791
		[Token(Token = "0x40039C7")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x331")]
		public bool clayPotMinion;

		// Token: 0x040039C8 RID: 14792
		[Token(Token = "0x40039C8")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x332")]
		public bool forbiddenMinion;

		// Token: 0x040039C9 RID: 14793
		[Token(Token = "0x40039C9")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x334")]
		public float wingTime;

		// Token: 0x040039CA RID: 14794
		[Token(Token = "0x40039CA")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x338")]
		public int wings;

		// Token: 0x040039CB RID: 14795
		[Token(Token = "0x40039CB")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x33C")]
		public int wingsLogic;

		// Token: 0x040039CC RID: 14796
		[Token(Token = "0x40039CC")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x340")]
		public bool hasWings;

		// Token: 0x040039CD RID: 14797
		[Token(Token = "0x40039CD")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x344")]
		public int wingTimeMax;

		// Token: 0x040039CE RID: 14798
		[Token(Token = "0x40039CE")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x348")]
		public int wingFrame;

		// Token: 0x040039CF RID: 14799
		[Token(Token = "0x40039CF")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x34C")]
		public int wingFrameCounter;

		// Token: 0x040039D0 RID: 14800
		[Token(Token = "0x40039D0")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x350")]
		public int skinVariant;

		// Token: 0x040039D1 RID: 14801
		[Token(Token = "0x40039D1")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x354")]
		public int voiceVariant;

		// Token: 0x040039D2 RID: 14802
		[Token(Token = "0x40039D2")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x358")]
		public float voicePitchOffset;

		// Token: 0x040039D3 RID: 14803
		[Token(Token = "0x40039D3")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x35C")]
		public bool ghost;

		// Token: 0x040039D4 RID: 14804
		[Token(Token = "0x40039D4")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x360")]
		public int ghostFrame;

		// Token: 0x040039D5 RID: 14805
		[Token(Token = "0x40039D5")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x364")]
		public int ghostFrameCounter;

		// Token: 0x040039D6 RID: 14806
		[Token(Token = "0x40039D6")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x368")]
		public int miscTimer;

		// Token: 0x040039D7 RID: 14807
		[Token(Token = "0x40039D7")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x36C")]
		public int environmentBuffImmunityTimer;

		// Token: 0x040039D8 RID: 14808
		[Token(Token = "0x40039D8")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x370")]
		public int _framesLeftEligibleForDeadmansChestDeathAchievement;

		// Token: 0x040039D9 RID: 14809
		[Token(Token = "0x40039D9")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x374")]
		public bool pvpDeath;

		// Token: 0x040039DA RID: 14810
		[Token(Token = "0x40039DA")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x375")]
		public BitsByte zone1;

		// Token: 0x040039DB RID: 14811
		[Token(Token = "0x40039DB")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x376")]
		public BitsByte zone2;

		// Token: 0x040039DC RID: 14812
		[Token(Token = "0x40039DC")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x377")]
		public BitsByte zone3;

		// Token: 0x040039DD RID: 14813
		[Token(Token = "0x40039DD")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x378")]
		public BitsByte zone4;

		// Token: 0x040039DE RID: 14814
		[Token(Token = "0x40039DE")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x379")]
		public BitsByte zone5;

		// Token: 0x040039DF RID: 14815
		[Token(Token = "0x40039DF")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x37A")]
		private bool _wasInShimmerZone;

		// Token: 0x040039E0 RID: 14816
		[Token(Token = "0x40039E0")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x37B")]
		public bool boneArmor;

		// Token: 0x040039E1 RID: 14817
		[Token(Token = "0x40039E1")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x37C")]
		public bool frostArmor;

		// Token: 0x040039E2 RID: 14818
		[Token(Token = "0x40039E2")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x37D")]
		public bool honey;

		// Token: 0x040039E3 RID: 14819
		[Token(Token = "0x40039E3")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x37E")]
		public bool crystalLeaf;

		// Token: 0x040039E4 RID: 14820
		[Token(Token = "0x40039E4")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x380")]
		public int crystalLeafCooldown;

		// Token: 0x040039E5 RID: 14821
		[Token(Token = "0x40039E5")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x384")]
		public PortableStoolUsage portableStoolInfo;

		// Token: 0x040039E6 RID: 14822
		[Token(Token = "0x40039E6")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x394")]
		public bool preventAllItemPickups;

		// Token: 0x040039E7 RID: 14823
		[Token(Token = "0x40039E7")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x395")]
		public bool dontHurtCritters;

		// Token: 0x040039E8 RID: 14824
		[Token(Token = "0x40039E8")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x396")]
		public bool hasLucyTheAxe;

		// Token: 0x040039E9 RID: 14825
		[Token(Token = "0x40039E9")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x397")]
		public bool dontHurtNature;

		// Token: 0x040039EA RID: 14826
		[Token(Token = "0x40039EA")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x398")]
		public bool acceleratePoisons;

		// Token: 0x040039EB RID: 14827
		[Token(Token = "0x40039EB")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x399")]
		public bool blueLightning;

		// Token: 0x040039EC RID: 14828
		[Token(Token = "0x40039EC")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x39A")]
		public bool redLightning;

		// Token: 0x040039ED RID: 14829
		[Token(Token = "0x40039ED")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x39C")]
		public int[] doubleTapCardinalTimer;

		// Token: 0x040039EE RID: 14830
		[Token(Token = "0x40039EE")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x3A0")]
		public int[] holdDownCardinalTimer;

		// Token: 0x040039EF RID: 14831
		[Token(Token = "0x40039EF")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x3A4")]
		public bool defendedByPaladin;

		// Token: 0x040039F0 RID: 14832
		[Token(Token = "0x40039F0")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x3A5")]
		public bool hasPaladinShield;

		// Token: 0x040039F1 RID: 14833
		[Token(Token = "0x40039F1")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x3A8")]
		public float[] speedSlice;

		// Token: 0x040039F2 RID: 14834
		[Token(Token = "0x40039F2")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x3AC")]
		public int townNPCs;

		// Token: 0x040039F3 RID: 14835
		[Token(Token = "0x40039F3")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x3B0")]
		public double headFrameCounter;

		// Token: 0x040039F4 RID: 14836
		[Token(Token = "0x40039F4")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x3B8")]
		public double bodyFrameCounter;

		// Token: 0x040039F5 RID: 14837
		[Token(Token = "0x40039F5")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x3C0")]
		public double legFrameCounter;

		// Token: 0x040039F6 RID: 14838
		[Token(Token = "0x40039F6")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x3C8")]
		public bool immune;

		// Token: 0x040039F7 RID: 14839
		[Token(Token = "0x40039F7")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x3C9")]
		public bool immuneNoBlink;

		// Token: 0x040039F8 RID: 14840
		[Token(Token = "0x40039F8")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x3CC")]
		public int immuneTime;

		// Token: 0x040039F9 RID: 14841
		[Token(Token = "0x40039F9")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x3D0")]
		public int immuneAlphaDirection;

		// Token: 0x040039FA RID: 14842
		[Token(Token = "0x40039FA")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x3D4")]
		public int immuneAlpha;

		// Token: 0x040039FB RID: 14843
		[Token(Token = "0x40039FB")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x3D8")]
		public int team;

		// Token: 0x040039FC RID: 14844
		[Token(Token = "0x40039FC")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x3DC")]
		private int _timeSinceLastImmuneGet;

		// Token: 0x040039FD RID: 14845
		[Token(Token = "0x40039FD")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x3E0")]
		private int _immuneStrikes;

		// Token: 0x040039FE RID: 14846
		[Token(Token = "0x40039FE")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x3E4")]
		public bool hbLocked;

		// Token: 0x040039FF RID: 14847
		[Token(Token = "0x40039FF")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x3E8")]
		public int sign;

		// Token: 0x04003A00 RID: 14848
		[Token(Token = "0x4003A00")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x3EC")]
		public bool editedChestName;

		// Token: 0x04003A01 RID: 14849
		[Token(Token = "0x4003A01")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x3F0")]
		public int reuseDelay;

		// Token: 0x04003A02 RID: 14850
		[Token(Token = "0x4003A02")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x3F4")]
		public int aggro;

		// Token: 0x04003A03 RID: 14851
		[Token(Token = "0x4003A03")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x3F8")]
		public float nearbyActiveNPCs;

		// Token: 0x04003A04 RID: 14852
		[Token(Token = "0x4003A04")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x3FC")]
		public bool creativeInterface;

		// Token: 0x04003A05 RID: 14853
		[Token(Token = "0x4003A05")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x3FD")]
		public bool mouseInterface;

		// Token: 0x04003A06 RID: 14854
		[Token(Token = "0x4003A06")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x3FE")]
		public bool lastMouseInterface;

		// Token: 0x04003A07 RID: 14855
		[Token(Token = "0x4003A07")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x400")]
		public int noThrow;

		// Token: 0x04003A08 RID: 14856
		[Token(Token = "0x4003A08")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x404")]
		public int changeItem;

		// Token: 0x04003A09 RID: 14857
		[Token(Token = "0x4003A09")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x408")]
		public int lastHotbarItem;

		// Token: 0x04003A0A RID: 14858
		[Token(Token = "0x4003A0A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x40C")]
		public bool pendingItemReuse;

		// Token: 0x04003A0B RID: 14859
		[Token(Token = "0x4003A0B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x410")]
		public Player.SelectedItemState selectedItemState;

		// Token: 0x04003A0C RID: 14860
		[Token(Token = "0x4003A0C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x424")]
		public int selectedKite;

		// Token: 0x04003A0D RID: 14861
		[Token(Token = "0x4003A0D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x428")]
		public int afkSelectedItem;

		// Token: 0x04003A0E RID: 14862
		[Token(Token = "0x4003A0E")]
		public const int SupportedSlotsArmor = 3;

		// Token: 0x04003A0F RID: 14863
		[Token(Token = "0x4003A0F")]
		public const int SupportedSlotsAccs = 7;

		// Token: 0x04003A10 RID: 14864
		[Token(Token = "0x4003A10")]
		public const int SupportedSlotSets = 10;

		// Token: 0x04003A11 RID: 14865
		[Token(Token = "0x4003A11")]
		public const int InitialAccSlotCount = 5;

		// Token: 0x04003A12 RID: 14866
		[Token(Token = "0x4003A12")]
		public const int miscSlotPet = 0;

		// Token: 0x04003A13 RID: 14867
		[Token(Token = "0x4003A13")]
		public const int miscSlotLight = 1;

		// Token: 0x04003A14 RID: 14868
		[Token(Token = "0x4003A14")]
		public const int miscSlotCart = 2;

		// Token: 0x04003A15 RID: 14869
		[Token(Token = "0x4003A15")]
		public const int miscSlotMount = 3;

		// Token: 0x04003A16 RID: 14870
		[Token(Token = "0x4003A16")]
		public const int miscSlotHook = 4;

		// Token: 0x04003A17 RID: 14871
		[Token(Token = "0x4003A17")]
		public const int SupportedMiscSlotCount = 5;

		// Token: 0x04003A18 RID: 14872
		[Token(Token = "0x4003A18")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x42C")]
		public Item[] armor;

		// Token: 0x04003A19 RID: 14873
		[Token(Token = "0x4003A19")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x430")]
		public Item[] dye;

		// Token: 0x04003A1A RID: 14874
		[Token(Token = "0x4003A1A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x434")]
		public Item[] miscEquips;

		// Token: 0x04003A1B RID: 14875
		[Token(Token = "0x4003A1B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x438")]
		public Item[] miscDyes;

		// Token: 0x04003A1C RID: 14876
		[Token(Token = "0x4003A1C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x43C")]
		public Item trashItem;

		// Token: 0x04003A1D RID: 14877
		[Token(Token = "0x4003A1D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x440")]
		public float itemRotation;

		// Token: 0x04003A1E RID: 14878
		[Token(Token = "0x4003A1E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x444")]
		public Vector2 itemLocation;

		// Token: 0x04003A1F RID: 14879
		[Token(Token = "0x4003A1F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x44C")]
		public bool poundRelease;

		// Token: 0x04003A20 RID: 14880
		[Token(Token = "0x4003A20")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x450")]
		public float ghostFade;

		// Token: 0x04003A21 RID: 14881
		[Token(Token = "0x4003A21")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x454")]
		public float ghostDir;

		// Token: 0x04003A22 RID: 14882
		[Token(Token = "0x4003A22")]
		public const int maxBuffs = 44;

		// Token: 0x04003A23 RID: 14883
		[Token(Token = "0x4003A23")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x458")]
		public int[] buffType;

		// Token: 0x04003A24 RID: 14884
		[Token(Token = "0x4003A24")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x45C")]
		public int[] buffTime;

		// Token: 0x04003A25 RID: 14885
		[Token(Token = "0x4003A25")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x460")]
		public bool[] buffImmune;

		// Token: 0x04003A26 RID: 14886
		[Token(Token = "0x4003A26")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x464")]
		public int heldProj;

		// Token: 0x04003A27 RID: 14887
		[Token(Token = "0x4003A27")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x468")]
		public int breathCD;

		// Token: 0x04003A28 RID: 14888
		[Token(Token = "0x4003A28")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x46C")]
		public int breathMax;

		// Token: 0x04003A29 RID: 14889
		[Token(Token = "0x4003A29")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x470")]
		public int breath;

		// Token: 0x04003A2A RID: 14890
		[Token(Token = "0x4003A2A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x474")]
		public int lavaCD;

		// Token: 0x04003A2B RID: 14891
		[Token(Token = "0x4003A2B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x478")]
		public int lavaMax;

		// Token: 0x04003A2C RID: 14892
		[Token(Token = "0x4003A2C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x47C")]
		public int lavaTime;

		// Token: 0x04003A2D RID: 14893
		[Token(Token = "0x4003A2D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x480")]
		public bool ignoreWater;

		// Token: 0x04003A2E RID: 14894
		[Token(Token = "0x4003A2E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x481")]
		public bool lavaVision;

		// Token: 0x04003A2F RID: 14895
		[Token(Token = "0x4003A2F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x484")]
		public float lavaOpacity;

		// Token: 0x04003A30 RID: 14896
		[Token(Token = "0x4003A30")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x488")]
		public bool armorEffectDrawShadow;

		// Token: 0x04003A31 RID: 14897
		[Token(Token = "0x4003A31")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x489")]
		public bool armorEffectDrawShadowSubtle;

		// Token: 0x04003A32 RID: 14898
		[Token(Token = "0x4003A32")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x48A")]
		public bool armorEffectDrawOutlines;

		// Token: 0x04003A33 RID: 14899
		[Token(Token = "0x4003A33")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x48B")]
		public bool armorEffectDrawShadowLokis;

		// Token: 0x04003A34 RID: 14900
		[Token(Token = "0x4003A34")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x48C")]
		public bool armorEffectDrawShadowBasilisk;

		// Token: 0x04003A35 RID: 14901
		[Token(Token = "0x4003A35")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x48D")]
		public bool armorEffectDrawOutlinesForbidden;

		// Token: 0x04003A36 RID: 14902
		[Token(Token = "0x4003A36")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x48E")]
		public bool armorEffectDrawShadowEOCShield;

		// Token: 0x04003A37 RID: 14903
		[Token(Token = "0x4003A37")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x48F")]
		public bool socialShadowRocketBoots;

		// Token: 0x04003A38 RID: 14904
		[Token(Token = "0x4003A38")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x490")]
		public bool socialGhost;

		// Token: 0x04003A39 RID: 14905
		[Token(Token = "0x4003A39")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x491")]
		public bool shroomiteStealth;

		// Token: 0x04003A3A RID: 14906
		[Token(Token = "0x4003A3A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x492")]
		public bool ashWoodBonus;

		// Token: 0x04003A3B RID: 14907
		[Token(Token = "0x4003A3B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x493")]
		public bool socialIgnoreLight;

		// Token: 0x04003A3C RID: 14908
		[Token(Token = "0x4003A3C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x494")]
		public int stealthTimer;

		// Token: 0x04003A3D RID: 14909
		[Token(Token = "0x4003A3D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x498")]
		public float stealth;

		// Token: 0x04003A3E RID: 14910
		[Token(Token = "0x4003A3E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x49C")]
		public int beardGrowthTimer;

		// Token: 0x04003A3F RID: 14911
		[Token(Token = "0x4003A3F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x4A0")]
		public bool isDisplayDollOrInanimate;

		// Token: 0x04003A40 RID: 14912
		[Token(Token = "0x4003A40")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x4A1")]
		public bool isFullbright;

		// Token: 0x04003A41 RID: 14913
		[Token(Token = "0x4003A41")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x4A2")]
		public bool isHatRackDoll;

		// Token: 0x04003A42 RID: 14914
		[Token(Token = "0x4003A42")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x4A3")]
		public bool isFirstFractalAfterImage;

		// Token: 0x04003A43 RID: 14915
		[Token(Token = "0x4003A43")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x4A4")]
		public float firstFractalAfterImageOpacity;

		// Token: 0x04003A44 RID: 14916
		[Token(Token = "0x4003A44")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x4A8")]
		public Item[] inventory;

		// Token: 0x04003A45 RID: 14917
		[Token(Token = "0x4003A45")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x4AC")]
		public bool[] inventoryChestStack;

		// Token: 0x04003A46 RID: 14918
		[Token(Token = "0x4003A46")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x4B0")]
		public Item lastVisualizedSelectedItem;

		// Token: 0x04003A47 RID: 14919
		[Token(Token = "0x4003A47")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x4B4")]
		public InventoryStorage bank;

		// Token: 0x04003A48 RID: 14920
		[Token(Token = "0x4003A48")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x4B8")]
		public InventoryStorage bank2;

		// Token: 0x04003A49 RID: 14921
		[Token(Token = "0x4003A49")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x4BC")]
		public InventoryStorage bank3;

		// Token: 0x04003A4A RID: 14922
		[Token(Token = "0x4003A4A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x4C0")]
		public InventoryStorage bank4;

		// Token: 0x04003A4B RID: 14923
		[Token(Token = "0x4003A4B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x4C4")]
		public BitsByte voidVaultInfo;

		// Token: 0x04003A4C RID: 14924
		[Token(Token = "0x4003A4C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x4C8")]
		public float headRotation;

		// Token: 0x04003A4D RID: 14925
		[Token(Token = "0x4003A4D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x4CC")]
		public float bodyRotation;

		// Token: 0x04003A4E RID: 14926
		[Token(Token = "0x4003A4E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x4D0")]
		public float legRotation;

		// Token: 0x04003A4F RID: 14927
		[Token(Token = "0x4003A4F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x4D4")]
		public Vector2 headPosition;

		// Token: 0x04003A50 RID: 14928
		[Token(Token = "0x4003A50")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x4DC")]
		public Vector2 bodyPosition;

		// Token: 0x04003A51 RID: 14929
		[Token(Token = "0x4003A51")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x4E4")]
		public Vector2 legPosition;

		// Token: 0x04003A52 RID: 14930
		[Token(Token = "0x4003A52")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x4EC")]
		public Vector2 headVelocity;

		// Token: 0x04003A53 RID: 14931
		[Token(Token = "0x4003A53")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x4F4")]
		public Vector2 bodyVelocity;

		// Token: 0x04003A54 RID: 14932
		[Token(Token = "0x4003A54")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x4FC")]
		public Vector2 legVelocity;

		// Token: 0x04003A55 RID: 14933
		[Token(Token = "0x4003A55")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x504")]
		public float fullRotation;

		// Token: 0x04003A56 RID: 14934
		[Token(Token = "0x4003A56")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x508")]
		public Vector2 fullRotationOrigin;

		// Token: 0x04003A57 RID: 14935
		[Token(Token = "0x4003A57")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x510")]
		public int fartKartCloudDelay;

		// Token: 0x04003A58 RID: 14936
		[Token(Token = "0x4003A58")]
		public const int fartKartCloudDelayMax = 20;

		// Token: 0x04003A59 RID: 14937
		[Token(Token = "0x4003A59")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x514")]
		public float gfxOffY;

		// Token: 0x04003A5A RID: 14938
		[Token(Token = "0x4003A5A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x518")]
		public float stepSpeed;

		// Token: 0x04003A5B RID: 14939
		[Token(Token = "0x4003A5B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x51C")]
		public Vector2 netOffset;

		// Token: 0x04003A5C RID: 14940
		[Token(Token = "0x4003A5C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x524")]
		internal Vector2? netCameraTarget;

		// Token: 0x04003A5D RID: 14941
		[Token(Token = "0x4003A5D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x530")]
		internal Vector2? lastSyncedNetCameraTarget;

		// Token: 0x04003A5E RID: 14942
		[Token(Token = "0x4003A5E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x53C")]
		public bool dead;

		// Token: 0x04003A5F RID: 14943
		[Token(Token = "0x4003A5F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x540")]
		public int deadTime;

		// Token: 0x04003A60 RID: 14944
		[Token(Token = "0x4003A60")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x544")]
		public int spectating;

		// Token: 0x04003A61 RID: 14945
		[Token(Token = "0x4003A61")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x548")]
		public int respawnTimer;

		// Token: 0x04003A62 RID: 14946
		[Token(Token = "0x4003A62")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public static readonly int respawnTimerMax;

		// Token: 0x04003A63 RID: 14947
		[Token(Token = "0x4003A63")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public static readonly int DeadSpectatingLockoutTime;

		// Token: 0x04003A64 RID: 14948
		[Token(Token = "0x4003A64")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public static readonly int SpectatingLingerAfterDeath;

		// Token: 0x04003A65 RID: 14949
		[Token(Token = "0x4003A65")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public static readonly int DeadSkipLockoutTime;

		// Token: 0x04003A66 RID: 14950
		[Token(Token = "0x4003A66")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x550")]
		public long lastTimePlayerWasSaved;

		// Token: 0x04003A67 RID: 14951
		[Token(Token = "0x4003A67")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x558")]
		public int attackCD;

		// Token: 0x04003A68 RID: 14952
		[Token(Token = "0x4003A68")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x55C")]
		public int potionDelay;

		// Token: 0x04003A69 RID: 14953
		[Token(Token = "0x4003A69")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x560")]
		public int manaPotionDelay;

		// Token: 0x04003A6A RID: 14954
		[Token(Token = "0x4003A6A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x564")]
		public byte difficulty;

		// Token: 0x04003A6B RID: 14955
		[Token(Token = "0x4003A6B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x565")]
		public byte wetSlime;

		// Token: 0x04003A6C RID: 14956
		[Token(Token = "0x4003A6C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x568")]
		public HitTile hitTile;

		// Token: 0x04003A6D RID: 14957
		[Token(Token = "0x4003A6D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x56C")]
		public HitTile hitReplace;

		// Token: 0x04003A6E RID: 14958
		[Token(Token = "0x4003A6E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x570")]
		public float startJumpY;

		// Token: 0x04003A6F RID: 14959
		[Token(Token = "0x4003A6F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x574")]
		public bool jumping;

		// Token: 0x04003A70 RID: 14960
		[Token(Token = "0x4003A70")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x578")]
		public int jump;

		// Token: 0x04003A71 RID: 14961
		[Token(Token = "0x4003A71")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x57C")]
		public int head;

		// Token: 0x04003A72 RID: 14962
		[Token(Token = "0x4003A72")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x580")]
		public int body;

		// Token: 0x04003A73 RID: 14963
		[Token(Token = "0x4003A73")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x584")]
		public int legs;

		// Token: 0x04003A74 RID: 14964
		[Token(Token = "0x4003A74")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x588")]
		public int coat;

		// Token: 0x04003A75 RID: 14965
		[Token(Token = "0x4003A75")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x58C")]
		public sbyte handon;

		// Token: 0x04003A76 RID: 14966
		[Token(Token = "0x4003A76")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x58D")]
		public sbyte handoff;

		// Token: 0x04003A77 RID: 14967
		[Token(Token = "0x4003A77")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x58E")]
		public sbyte back;

		// Token: 0x04003A78 RID: 14968
		[Token(Token = "0x4003A78")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x58F")]
		public sbyte front;

		// Token: 0x04003A79 RID: 14969
		[Token(Token = "0x4003A79")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x590")]
		public sbyte shoe;

		// Token: 0x04003A7A RID: 14970
		[Token(Token = "0x4003A7A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x591")]
		public sbyte waist;

		// Token: 0x04003A7B RID: 14971
		[Token(Token = "0x4003A7B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x592")]
		public sbyte shield;

		// Token: 0x04003A7C RID: 14972
		[Token(Token = "0x4003A7C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x593")]
		public sbyte neck;

		// Token: 0x04003A7D RID: 14973
		[Token(Token = "0x4003A7D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x594")]
		public sbyte face;

		// Token: 0x04003A7E RID: 14974
		[Token(Token = "0x4003A7E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x595")]
		public sbyte balloon;

		// Token: 0x04003A7F RID: 14975
		[Token(Token = "0x4003A7F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x596")]
		public sbyte backpack;

		// Token: 0x04003A80 RID: 14976
		[Token(Token = "0x4003A80")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x597")]
		public sbyte tail;

		// Token: 0x04003A81 RID: 14977
		[Token(Token = "0x4003A81")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x598")]
		public sbyte faceHead;

		// Token: 0x04003A82 RID: 14978
		[Token(Token = "0x4003A82")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x599")]
		public sbyte faceFlower;

		// Token: 0x04003A83 RID: 14979
		[Token(Token = "0x4003A83")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x59A")]
		public sbyte faceMask;

		// Token: 0x04003A84 RID: 14980
		[Token(Token = "0x4003A84")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x59B")]
		public sbyte balloonFront;

		// Token: 0x04003A85 RID: 14981
		[Token(Token = "0x4003A85")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x59C")]
		public sbyte beard;

		// Token: 0x04003A86 RID: 14982
		[Token(Token = "0x4003A86")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x59D")]
		public sbyte voiceOverride;

		// Token: 0x04003A87 RID: 14983
		[Token(Token = "0x4003A87")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x5A0")]
		public bool[] hideVisibleAccessory;

		// Token: 0x04003A88 RID: 14984
		[Token(Token = "0x4003A88")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x5A4")]
		public BitsByte hideMisc;

		// Token: 0x04003A89 RID: 14985
		[Token(Token = "0x4003A89")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x5A8")]
		public Rectangle headFrame;

		// Token: 0x04003A8A RID: 14986
		[Token(Token = "0x4003A8A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x5B8")]
		public Rectangle bodyFrame;

		// Token: 0x04003A8B RID: 14987
		[Token(Token = "0x4003A8B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x5C8")]
		public Rectangle legFrame;

		// Token: 0x04003A8C RID: 14988
		[Token(Token = "0x4003A8C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x5D8")]
		public Rectangle hairFrame;

		// Token: 0x04003A8D RID: 14989
		[Token(Token = "0x4003A8D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x5E8")]
		public Player.PlayerInputSyncCache LocalInputCache;

		// Token: 0x04003A8E RID: 14990
		[Token(Token = "0x4003A8E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x5ED")]
		public bool blockUseItem;

		// Token: 0x04003A8F RID: 14991
		[Token(Token = "0x4003A8F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x5EE")]
		public bool holdUpJump;

		// Token: 0x04003A90 RID: 14992
		[Token(Token = "0x4003A90")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x5EF")]
		private bool rewsing;

		// Token: 0x04003A91 RID: 14993
		[Token(Token = "0x4003A91")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x5F0")]
		public short InitialItemUsing;

		// Token: 0x04003A92 RID: 14994
		[Token(Token = "0x4003A92")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x5F2")]
		public short InitialItemUsingType;

		// Token: 0x04003A93 RID: 14995
		[Token(Token = "0x4003A93")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x5F4")]
		public int InitialItemUsingSlot;

		// Token: 0x04003A94 RID: 14996
		[Token(Token = "0x4003A94")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x5F8")]
		public bool disableUseUntilRelease;

		// Token: 0x04003A95 RID: 14997
		[Token(Token = "0x4003A95")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x5F9")]
		public bool controlLeft;

		// Token: 0x04003A96 RID: 14998
		[Token(Token = "0x4003A96")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x5FA")]
		public bool controlRight;

		// Token: 0x04003A97 RID: 14999
		[Token(Token = "0x4003A97")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x5FB")]
		public bool controlUp;

		// Token: 0x04003A98 RID: 15000
		[Token(Token = "0x4003A98")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x5FC")]
		public bool controlDown;

		// Token: 0x04003A99 RID: 15001
		[Token(Token = "0x4003A99")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x5FD")]
		public bool controlJump;

		// Token: 0x04003A9A RID: 15002
		[Token(Token = "0x4003A9A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x5FE")]
		public bool controlUseItem;

		// Token: 0x04003A9B RID: 15003
		[Token(Token = "0x4003A9B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x5FF")]
		public bool controlUseTile;

		// Token: 0x04003A9C RID: 15004
		[Token(Token = "0x4003A9C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x600")]
		public bool controlThrow;

		// Token: 0x04003A9D RID: 15005
		[Token(Token = "0x4003A9D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x601")]
		public bool controlInv;

		// Token: 0x04003A9E RID: 15006
		[Token(Token = "0x4003A9E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x602")]
		public bool controlHook;

		// Token: 0x04003A9F RID: 15007
		[Token(Token = "0x4003A9F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x603")]
		public bool controlTorch;

		// Token: 0x04003AA0 RID: 15008
		[Token(Token = "0x4003AA0")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x604")]
		public bool controlMap;

		// Token: 0x04003AA1 RID: 15009
		[Token(Token = "0x4003AA1")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x605")]
		public bool controlSmart;

		// Token: 0x04003AA2 RID: 15010
		[Token(Token = "0x4003AA2")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x606")]
		public bool controlMount;

		// Token: 0x04003AA3 RID: 15011
		[Token(Token = "0x4003AA3")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x607")]
		public bool controlDash;

		// Token: 0x04003AA4 RID: 15012
		[Token(Token = "0x4003AA4")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x608")]
		public bool controlArmorSetAbility;

		// Token: 0x04003AA5 RID: 15013
		[Token(Token = "0x4003AA5")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x609")]
		public bool releaseJump;

		// Token: 0x04003AA6 RID: 15014
		[Token(Token = "0x4003AA6")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x60A")]
		public bool releaseUp;

		// Token: 0x04003AA7 RID: 15015
		[Token(Token = "0x4003AA7")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x60B")]
		public bool releaseUseItem;

		// Token: 0x04003AA8 RID: 15016
		[Token(Token = "0x4003AA8")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x60C")]
		public bool releaseUseTile;

		// Token: 0x04003AA9 RID: 15017
		[Token(Token = "0x4003AA9")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x60D")]
		public bool releaseInventory;

		// Token: 0x04003AAA RID: 15018
		[Token(Token = "0x4003AAA")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x60E")]
		public bool releaseHook;

		// Token: 0x04003AAB RID: 15019
		[Token(Token = "0x4003AAB")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x60F")]
		public bool releaseThrow;

		// Token: 0x04003AAC RID: 15020
		[Token(Token = "0x4003AAC")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x610")]
		public bool releaseQuickMana;

		// Token: 0x04003AAD RID: 15021
		[Token(Token = "0x4003AAD")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x611")]
		public bool releaseQuickHeal;

		// Token: 0x04003AAE RID: 15022
		[Token(Token = "0x4003AAE")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x612")]
		public bool releaseLeft;

		// Token: 0x04003AAF RID: 15023
		[Token(Token = "0x4003AAF")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x613")]
		public bool releaseRight;

		// Token: 0x04003AB0 RID: 15024
		[Token(Token = "0x4003AB0")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x614")]
		public bool releaseSmart;

		// Token: 0x04003AB1 RID: 15025
		[Token(Token = "0x4003AB1")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x615")]
		public bool releaseMount;

		// Token: 0x04003AB2 RID: 15026
		[Token(Token = "0x4003AB2")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x616")]
		public bool releaseDown;

		// Token: 0x04003AB3 RID: 15027
		[Token(Token = "0x4003AB3")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x617")]
		public bool releaseQuickBuff;

		// Token: 0x04003AB4 RID: 15028
		[Token(Token = "0x4003AB4")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x618")]
		public bool releaseLoadout1;

		// Token: 0x04003AB5 RID: 15029
		[Token(Token = "0x4003AB5")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x619")]
		public bool releaseLoadout2;

		// Token: 0x04003AB6 RID: 15030
		[Token(Token = "0x4003AB6")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x61A")]
		public bool releaseLoadout3;

		// Token: 0x04003AB7 RID: 15031
		[Token(Token = "0x4003AB7")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x61B")]
		public bool releaseNextLoadout;

		// Token: 0x04003AB8 RID: 15032
		[Token(Token = "0x4003AB8")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x61C")]
		public bool releasePreviousLoadout;

		// Token: 0x04003AB9 RID: 15033
		[Token(Token = "0x4003AB9")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x61D")]
		public bool releaseArmorSetAbility;

		// Token: 0x04003ABA RID: 15034
		[Token(Token = "0x4003ABA")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x61E")]
		public bool releaseDash;

		// Token: 0x04003ABB RID: 15035
		[Token(Token = "0x4003ABB")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x61F")]
		public bool controlQuickMana;

		// Token: 0x04003ABC RID: 15036
		[Token(Token = "0x4003ABC")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x620")]
		public bool controlQuickHeal;

		// Token: 0x04003ABD RID: 15037
		[Token(Token = "0x4003ABD")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x621")]
		public bool controlCreativeMenu;

		// Token: 0x04003ABE RID: 15038
		[Token(Token = "0x4003ABE")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x622")]
		public bool releaseCreativeMenu;

		// Token: 0x04003ABF RID: 15039
		[Token(Token = "0x4003ABF")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x624")]
		public int checkProjectilesFrame;

		// Token: 0x04003AC0 RID: 15040
		[Token(Token = "0x4003AC0")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x628")]
		public bool controlQuickBuff;

		// Token: 0x04003AC1 RID: 15041
		[Token(Token = "0x4003AC1")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x629")]
		public bool controlFireRelease;

		// Token: 0x04003AC2 RID: 15042
		[Token(Token = "0x4003AC2")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x62A")]
		public bool controlFire;

		// Token: 0x04003AC3 RID: 15043
		[Token(Token = "0x4003AC3")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x62B")]
		public bool controlInteractionRelease;

		// Token: 0x04003AC4 RID: 15044
		[Token(Token = "0x4003AC4")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x62C")]
		public bool controlInteraction;

		// Token: 0x04003AC5 RID: 15045
		[Token(Token = "0x4003AC5")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x62D")]
		public bool controlLayout1;

		// Token: 0x04003AC6 RID: 15046
		[Token(Token = "0x4003AC6")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x62E")]
		public bool controlLayout2;

		// Token: 0x04003AC7 RID: 15047
		[Token(Token = "0x4003AC7")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x62F")]
		public bool controlLayout3;

		// Token: 0x04003AC8 RID: 15048
		[Token(Token = "0x4003AC8")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x630")]
		public bool controlLayoutCycle;

		// Token: 0x04003AC9 RID: 15049
		[Token(Token = "0x4003AC9")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x634")]
		public int lockInteractionForFrame;

		// Token: 0x04003ACA RID: 15050
		[Token(Token = "0x4003ACA")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x638")]
		public PlatformUser UserData;

		// Token: 0x04003ACB RID: 15051
		[Token(Token = "0x4003ACB")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x640")]
		public LocalUser LocalUser;

		// Token: 0x04003ACC RID: 15052
		[Token(Token = "0x4003ACC")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x644")]
		public Bits256 UserChatDisabled;

		// Token: 0x04003ACD RID: 15053
		[Token(Token = "0x4003ACD")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x664")]
		public bool IsHosting;

		// Token: 0x04003ACE RID: 15054
		[Token(Token = "0x4003ACE")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x665")]
		public bool tileInteractionHappened;

		// Token: 0x04003ACF RID: 15055
		[Token(Token = "0x4003ACF")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x666")]
		public bool tileInteractAttempted;

		// Token: 0x04003AD0 RID: 15056
		[Token(Token = "0x4003AD0")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x667")]
		public bool controlDownHold;

		// Token: 0x04003AD1 RID: 15057
		[Token(Token = "0x4003AD1")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x668")]
		public bool isOperatingAnotherEntity;

		// Token: 0x04003AD2 RID: 15058
		[Token(Token = "0x4003AD2")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x669")]
		public bool lastItemUseAttemptSuccess;

		// Token: 0x04003AD3 RID: 15059
		[Token(Token = "0x4003AD3")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x66A")]
		public bool autoReuseAllWeapons;

		// Token: 0x04003AD4 RID: 15060
		[Token(Token = "0x4003AD4")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x66B")]
		public bool isControlledByFilm;

		// Token: 0x04003AD5 RID: 15061
		[Token(Token = "0x4003AD5")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x66C")]
		public bool tryKeepingHoveringDown;

		// Token: 0x04003AD6 RID: 15062
		[Token(Token = "0x4003AD6")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x66D")]
		public bool tryKeepingHoveringUp;

		// Token: 0x04003AD7 RID: 15063
		[Token(Token = "0x4003AD7")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x670")]
		public int altFunctionUse;

		// Token: 0x04003AD8 RID: 15064
		[Token(Token = "0x4003AD8")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x674")]
		public bool mapZoomIn;

		// Token: 0x04003AD9 RID: 15065
		[Token(Token = "0x4003AD9")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x675")]
		public bool mapZoomOut;

		// Token: 0x04003ADA RID: 15066
		[Token(Token = "0x4003ADA")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x676")]
		public bool mapAlphaUp;

		// Token: 0x04003ADB RID: 15067
		[Token(Token = "0x4003ADB")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x677")]
		public bool mapAlphaDown;

		// Token: 0x04003ADC RID: 15068
		[Token(Token = "0x4003ADC")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x678")]
		public bool mapFullScreen;

		// Token: 0x04003ADD RID: 15069
		[Token(Token = "0x4003ADD")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x679")]
		public bool mapStyle;

		// Token: 0x04003ADE RID: 15070
		[Token(Token = "0x4003ADE")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x67A")]
		public bool releaseMapFullscreen;

		// Token: 0x04003ADF RID: 15071
		[Token(Token = "0x4003ADF")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x67B")]
		public bool releaseMapStyle;

		// Token: 0x04003AE0 RID: 15072
		[Token(Token = "0x4003AE0")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x67C")]
		public int leftTimer;

		// Token: 0x04003AE1 RID: 15073
		[Token(Token = "0x4003AE1")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x680")]
		public int rightTimer;

		// Token: 0x04003AE2 RID: 15074
		[Token(Token = "0x4003AE2")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x684")]
		public bool delayUseItem;

		// Token: 0x04003AE3 RID: 15075
		[Token(Token = "0x4003AE3")]
		public const int defaultWidth = 20;

		// Token: 0x04003AE4 RID: 15076
		[Token(Token = "0x4003AE4")]
		public const int defaultHeight = 42;

		// Token: 0x04003AE5 RID: 15077
		[Token(Token = "0x4003AE5")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x685")]
		public bool cursorItemIconEnabled;

		// Token: 0x04003AE6 RID: 15078
		[Token(Token = "0x4003AE6")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x686")]
		public bool cursorItemIconReversed;

		// Token: 0x04003AE7 RID: 15079
		[Token(Token = "0x4003AE7")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x688")]
		public int cursorItemIconID;

		// Token: 0x04003AE8 RID: 15080
		[Token(Token = "0x4003AE8")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x68C")]
		public int cursorItemIconPush;

		// Token: 0x04003AE9 RID: 15081
		[Token(Token = "0x4003AE9")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x690")]
		public int cursorChestItemIconID;

		// Token: 0x04003AEA RID: 15082
		[Token(Token = "0x4003AEA")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x694")]
		public string cursorItemIconText;

		// Token: 0x04003AEB RID: 15083
		[Token(Token = "0x4003AEB")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x698")]
		public int runSoundDelay;

		// Token: 0x04003AEC RID: 15084
		[Token(Token = "0x4003AEC")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x69C")]
		public float opacityForAnimation;

		// Token: 0x04003AED RID: 15085
		[Token(Token = "0x4003AED")]
		public const int shadowMax = 3;

		// Token: 0x04003AEE RID: 15086
		[Token(Token = "0x4003AEE")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x6A0")]
		public Vector2[] shadowPos;

		// Token: 0x04003AEF RID: 15087
		[Token(Token = "0x4003AEF")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x6A4")]
		public float[] shadowRotation;

		// Token: 0x04003AF0 RID: 15088
		[Token(Token = "0x4003AF0")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x6A8")]
		public Vector2[] shadowOrigin;

		// Token: 0x04003AF1 RID: 15089
		[Token(Token = "0x4003AF1")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x6AC")]
		public int[] shadowDirection;

		// Token: 0x04003AF2 RID: 15090
		[Token(Token = "0x4003AF2")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x6B0")]
		public int shadowCount;

		// Token: 0x04003AF3 RID: 15091
		[Token(Token = "0x4003AF3")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x6B4")]
		public float manaCost;

		// Token: 0x04003AF4 RID: 15092
		[Token(Token = "0x4003AF4")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x6B8")]
		public bool fireWalk;

		// Token: 0x04003AF5 RID: 15093
		[Token(Token = "0x4003AF5")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x6B9")]
		public bool channel;

		// Token: 0x04003AF6 RID: 15094
		[Token(Token = "0x4003AF6")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x6BC")]
		public int step;

		// Token: 0x04003AF7 RID: 15095
		[Token(Token = "0x4003AF7")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x6C0")]
		public TagEffectStack TagEffectStack;

		// Token: 0x04003AF8 RID: 15096
		[Token(Token = "0x4003AF8")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x6C4")]
		public PlayerIntentionGuesser IntentionGuesser;

		// Token: 0x04003AF9 RID: 15097
		[Token(Token = "0x4003AF9")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x6C8")]
		public PlayerDamageTracker DamageTracker;

		// Token: 0x04003AFA RID: 15098
		[Token(Token = "0x4003AFA")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x6CC")]
		private Player.ChannelCancelKey _channelShotCache;

		// Token: 0x04003AFB RID: 15099
		[Token(Token = "0x4003AFB")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x6D4")]
		public bool skipAnimatingValuesInPlayerFrame;

		// Token: 0x04003AFC RID: 15100
		[Token(Token = "0x4003AFC")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x6D8")]
		public Player.RabbitOrderFrameHelper rabbitOrderFrame;

		// Token: 0x04003AFD RID: 15101
		[Token(Token = "0x4003AFD")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x6E4")]
		public bool creativeGodMode;

		// Token: 0x04003AFE RID: 15102
		[Token(Token = "0x4003AFE")]
		private const int MaxAdvancedShadows = 60;

		// Token: 0x04003AFF RID: 15103
		[Token(Token = "0x4003AFF")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x6E8")]
		public int availableAdvancedShadowsCount;

		// Token: 0x04003B00 RID: 15104
		[Token(Token = "0x4003B00")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x6EC")]
		private EntityShadowInfo[] _advancedShadows;

		// Token: 0x04003B01 RID: 15105
		[Token(Token = "0x4003B01")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x6F0")]
		private int _lastAddedAvancedShadow;

		// Token: 0x04003B02 RID: 15106
		[Token(Token = "0x4003B02")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x6F4")]
		public Player.CompositeArmData compositeFrontArm;

		// Token: 0x04003B03 RID: 15107
		[Token(Token = "0x4003B03")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x700")]
		public Player.CompositeArmData compositeBackArm;

		// Token: 0x04003B04 RID: 15108
		[Token(Token = "0x4003B04")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x70C")]
		public int anglerQuestsFinished;

		// Token: 0x04003B05 RID: 15109
		[Token(Token = "0x4003B05")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x710")]
		public int golferScoreAccumulated;

		// Token: 0x04003B06 RID: 15110
		[Token(Token = "0x4003B06")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x714")]
		public int bartenderQuestLog;

		// Token: 0x04003B07 RID: 15111
		[Token(Token = "0x4003B07")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x718")]
		public bool downedDD2EventAnyDifficulty;

		// Token: 0x04003B08 RID: 15112
		[Token(Token = "0x4003B08")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x71C")]
		public int armorPenetration;

		// Token: 0x04003B09 RID: 15113
		[Token(Token = "0x4003B09")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x720")]
		public int meleeArmorPenetration;

		// Token: 0x04003B0A RID: 15114
		[Token(Token = "0x4003B0A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x724")]
		public int statDefense;

		// Token: 0x04003B0B RID: 15115
		[Token(Token = "0x4003B0B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x728")]
		public int statLifeMax;

		// Token: 0x04003B0C RID: 15116
		[Token(Token = "0x4003B0C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x72C")]
		public int statLifeMax2;

		// Token: 0x04003B0D RID: 15117
		[Token(Token = "0x4003B0D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x730")]
		public int statLife;

		// Token: 0x04003B0E RID: 15118
		[Token(Token = "0x4003B0E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x734")]
		public int statMana;

		// Token: 0x04003B0F RID: 15119
		[Token(Token = "0x4003B0F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x738")]
		public int statManaMax;

		// Token: 0x04003B10 RID: 15120
		[Token(Token = "0x4003B10")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x73C")]
		public int statManaMax2;

		// Token: 0x04003B11 RID: 15121
		[Token(Token = "0x4003B11")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x740")]
		public int lifeRegen;

		// Token: 0x04003B12 RID: 15122
		[Token(Token = "0x4003B12")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x744")]
		public int lifeRegenCount;

		// Token: 0x04003B13 RID: 15123
		[Token(Token = "0x4003B13")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x748")]
		public float lifeRegenTime;

		// Token: 0x04003B14 RID: 15124
		[Token(Token = "0x4003B14")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x74C")]
		public int manaRegen;

		// Token: 0x04003B15 RID: 15125
		[Token(Token = "0x4003B15")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x750")]
		public int manaRegenCount;

		// Token: 0x04003B16 RID: 15126
		[Token(Token = "0x4003B16")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x754")]
		public float manaRegenDelay;

		// Token: 0x04003B17 RID: 15127
		[Token(Token = "0x4003B17")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x758")]
		public bool manaRegenBuff;

		// Token: 0x04003B18 RID: 15128
		[Token(Token = "0x4003B18")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x759")]
		public bool noKnockback;

		// Token: 0x04003B19 RID: 15129
		[Token(Token = "0x4003B19")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x75A")]
		private bool shimmerImmune;

		// Token: 0x04003B1A RID: 15130
		[Token(Token = "0x4003B1A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x75B")]
		public bool spaceGun;

		// Token: 0x04003B1B RID: 15131
		[Token(Token = "0x4003B1B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x75C")]
		public float gravDir;

		// Token: 0x04003B1C RID: 15132
		[Token(Token = "0x4003B1C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x760")]
		public bool chloroAmmoCost80;

		// Token: 0x04003B1D RID: 15133
		[Token(Token = "0x4003B1D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x761")]
		public bool huntressAmmoCost90;

		// Token: 0x04003B1E RID: 15134
		[Token(Token = "0x4003B1E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x762")]
		public bool ammoCost80;

		// Token: 0x04003B1F RID: 15135
		[Token(Token = "0x4003B1F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x763")]
		public bool ammoCost75;

		// Token: 0x04003B20 RID: 15136
		[Token(Token = "0x4003B20")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x764")]
		public int stickyBreak;

		// Token: 0x04003B21 RID: 15137
		[Token(Token = "0x4003B21")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x768")]
		public bool magicQuiver;

		// Token: 0x04003B22 RID: 15138
		[Token(Token = "0x4003B22")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x769")]
		public bool magmaStone;

		// Token: 0x04003B23 RID: 15139
		[Token(Token = "0x4003B23")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x76A")]
		public bool lavaRose;

		// Token: 0x04003B24 RID: 15140
		[Token(Token = "0x4003B24")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x76B")]
		public bool hasMoltenQuiver;

		// Token: 0x04003B25 RID: 15141
		[Token(Token = "0x4003B25")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x76C")]
		public bool hasPhoenixQuiver;

		// Token: 0x04003B26 RID: 15142
		[Token(Token = "0x4003B26")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x76D")]
		public bool catalystBand;

		// Token: 0x04003B27 RID: 15143
		[Token(Token = "0x4003B27")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x770")]
		public int phantasmTime;

		// Token: 0x04003B28 RID: 15144
		[Token(Token = "0x4003B28")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x774")]
		public bool ammoBox;

		// Token: 0x04003B29 RID: 15145
		[Token(Token = "0x4003B29")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x775")]
		public bool ammoPotion;

		// Token: 0x04003B2A RID: 15146
		[Token(Token = "0x4003B2A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x776")]
		public bool chaosState;

		// Token: 0x04003B2B RID: 15147
		[Token(Token = "0x4003B2B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x777")]
		public bool strongBees;

		// Token: 0x04003B2C RID: 15148
		[Token(Token = "0x4003B2C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x778")]
		public bool sporeSac;

		// Token: 0x04003B2D RID: 15149
		[Token(Token = "0x4003B2D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x779")]
		public bool shinyStone;

		// Token: 0x04003B2E RID: 15150
		[Token(Token = "0x4003B2E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x77A")]
		public bool empressBrooch;

		// Token: 0x04003B2F RID: 15151
		[Token(Token = "0x4003B2F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x77B")]
		public bool volatileGelatin;

		// Token: 0x04003B30 RID: 15152
		[Token(Token = "0x4003B30")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x77C")]
		public int volatileGelatinCounter;

		// Token: 0x04003B31 RID: 15153
		[Token(Token = "0x4003B31")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x780")]
		public bool hasMagiluminescence;

		// Token: 0x04003B32 RID: 15154
		[Token(Token = "0x4003B32")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x781")]
		public bool shadowArmor;

		// Token: 0x04003B33 RID: 15155
		[Token(Token = "0x4003B33")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x782")]
		public bool dontStarveShader;

		// Token: 0x04003B34 RID: 15156
		[Token(Token = "0x4003B34")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x783")]
		public bool noirShader;

		// Token: 0x04003B35 RID: 15157
		[Token(Token = "0x4003B35")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x784")]
		public bool eyebrellaCloud;

		// Token: 0x04003B36 RID: 15158
		[Token(Token = "0x4003B36")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x788")]
		public int yoraiz0rEye;

		// Token: 0x04003B37 RID: 15159
		[Token(Token = "0x4003B37")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x78C")]
		public bool yoraiz0rDarkness;

		// Token: 0x04003B38 RID: 15160
		[Token(Token = "0x4003B38")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x78D")]
		public bool hasUnicornHorn;

		// Token: 0x04003B39 RID: 15161
		[Token(Token = "0x4003B39")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x78E")]
		public bool hasAngelHalo;

		// Token: 0x04003B3A RID: 15162
		[Token(Token = "0x4003B3A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x78F")]
		public bool hasRainbowCursor;

		// Token: 0x04003B3B RID: 15163
		[Token(Token = "0x4003B3B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x790")]
		public bool leinforsHair;

		// Token: 0x04003B3C RID: 15164
		[Token(Token = "0x4003B3C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x791")]
		public bool musicBoxSilence;

		// Token: 0x04003B3D RID: 15165
		[Token(Token = "0x4003B3D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x792")]
		public bool stardustMonolithShader;

		// Token: 0x04003B3E RID: 15166
		[Token(Token = "0x4003B3E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x793")]
		public bool nebulaMonolithShader;

		// Token: 0x04003B3F RID: 15167
		[Token(Token = "0x4003B3F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x794")]
		public bool vortexMonolithShader;

		// Token: 0x04003B40 RID: 15168
		[Token(Token = "0x4003B40")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x795")]
		public bool solarMonolithShader;

		// Token: 0x04003B41 RID: 15169
		[Token(Token = "0x4003B41")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x796")]
		public bool moonLordMonolithShader;

		// Token: 0x04003B42 RID: 15170
		[Token(Token = "0x4003B42")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x797")]
		public bool bloodMoonMonolithShader;

		// Token: 0x04003B43 RID: 15171
		[Token(Token = "0x4003B43")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x798")]
		public bool shimmerMonolithShader;

		// Token: 0x04003B44 RID: 15172
		[Token(Token = "0x4003B44")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x799")]
		public bool CRTMonolithShader;

		// Token: 0x04003B45 RID: 15173
		[Token(Token = "0x4003B45")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x79A")]
		public bool retroMonolithShader;

		// Token: 0x04003B46 RID: 15174
		[Token(Token = "0x4003B46")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x79C")]
		public int musicBox;

		// Token: 0x04003B47 RID: 15175
		[Token(Token = "0x4003B47")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x7A0")]
		public int overrideFishingBobber;

		// Token: 0x04003B48 RID: 15176
		[Token(Token = "0x4003B48")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x7A4")]
		public bool unlockedBiomeTorches;

		// Token: 0x04003B49 RID: 15177
		[Token(Token = "0x4003B49")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x7A5")]
		public bool ateArtisanBread;

		// Token: 0x04003B4A RID: 15178
		[Token(Token = "0x4003B4A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x7A6")]
		public bool oldStyleParkour;

		// Token: 0x04003B4B RID: 15179
		[Token(Token = "0x4003B4B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x7A7")]
		public bool unlockedSuperCart;

		// Token: 0x04003B4C RID: 15180
		[Token(Token = "0x4003B4C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x7A8")]
		public bool enabledSuperCart;

		// Token: 0x04003B4D RID: 15181
		[Token(Token = "0x4003B4D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x7A9")]
		public bool suspiciouslookingTentacle;

		// Token: 0x04003B4E RID: 15182
		[Token(Token = "0x4003B4E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x7AA")]
		public bool crimsonHeart;

		// Token: 0x04003B4F RID: 15183
		[Token(Token = "0x4003B4F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x7AB")]
		public bool lightOrb;

		// Token: 0x04003B50 RID: 15184
		[Token(Token = "0x4003B50")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x7AC")]
		public bool blueFairy;

		// Token: 0x04003B51 RID: 15185
		[Token(Token = "0x4003B51")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x7AD")]
		public bool redFairy;

		// Token: 0x04003B52 RID: 15186
		[Token(Token = "0x4003B52")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x7AE")]
		public bool greenFairy;

		// Token: 0x04003B53 RID: 15187
		[Token(Token = "0x4003B53")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x7AF")]
		public bool bunny;

		// Token: 0x04003B54 RID: 15188
		[Token(Token = "0x4003B54")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x7B0")]
		public bool turtle;

		// Token: 0x04003B55 RID: 15189
		[Token(Token = "0x4003B55")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x7B1")]
		public bool eater;

		// Token: 0x04003B56 RID: 15190
		[Token(Token = "0x4003B56")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x7B2")]
		public bool penguin;

		// Token: 0x04003B57 RID: 15191
		[Token(Token = "0x4003B57")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x7B3")]
		public bool HasGardenGnomeNearby;

		// Token: 0x04003B58 RID: 15192
		[Token(Token = "0x4003B58")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x7B4")]
		public bool brokenMirrorBadLuck;

		// Token: 0x04003B59 RID: 15193
		[Token(Token = "0x4003B59")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x7B8")]
		public int brokenMirrorBadLuckTime;

		// Token: 0x04003B5A RID: 15194
		[Token(Token = "0x4003B5A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x7BC")]
		public bool magicLantern;

		// Token: 0x04003B5B RID: 15195
		[Token(Token = "0x4003B5B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x7BD")]
		public bool rabid;

		// Token: 0x04003B5C RID: 15196
		[Token(Token = "0x4003B5C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x7BE")]
		public bool sunflower;

		// Token: 0x04003B5D RID: 15197
		[Token(Token = "0x4003B5D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x7BF")]
		public bool wellFed;

		// Token: 0x04003B5E RID: 15198
		[Token(Token = "0x4003B5E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x7C0")]
		public bool puppy;

		// Token: 0x04003B5F RID: 15199
		[Token(Token = "0x4003B5F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x7C1")]
		public bool grinch;

		// Token: 0x04003B60 RID: 15200
		[Token(Token = "0x4003B60")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x7C2")]
		public bool miniMinotaur;

		// Token: 0x04003B61 RID: 15201
		[Token(Token = "0x4003B61")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x7C3")]
		public bool flowerBoots;

		// Token: 0x04003B62 RID: 15202
		[Token(Token = "0x4003B62")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x7C4")]
		public bool fairyBoots;

		// Token: 0x04003B63 RID: 15203
		[Token(Token = "0x4003B63")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x7C5")]
		public bool hellfireTreads;

		// Token: 0x04003B64 RID: 15204
		[Token(Token = "0x4003B64")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x7C6")]
		public bool moonLordLegs;

		// Token: 0x04003B65 RID: 15205
		[Token(Token = "0x4003B65")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x7C7")]
		public bool deadMansSweater;

		// Token: 0x04003B66 RID: 15206
		[Token(Token = "0x4003B66")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x7C8")]
		public bool arcticDivingGear;

		// Token: 0x04003B67 RID: 15207
		[Token(Token = "0x4003B67")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x7C9")]
		public bool coolWhipBuff;

		// Token: 0x04003B68 RID: 15208
		[Token(Token = "0x4003B68")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x7CA")]
		public bool cobWhipBuff;

		// Token: 0x04003B69 RID: 15209
		[Token(Token = "0x4003B69")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x7CB")]
		public bool wearsRobe;

		// Token: 0x04003B6A RID: 15210
		[Token(Token = "0x4003B6A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x7CC")]
		public bool onWrongGround;

		// Token: 0x04003B6B RID: 15211
		[Token(Token = "0x4003B6B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x7CD")]
		public bool onTrack;

		// Token: 0x04003B6C RID: 15212
		[Token(Token = "0x4003B6C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x7D0")]
		public int cartRampTime;

		// Token: 0x04003B6D RID: 15213
		[Token(Token = "0x4003B6D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x7D4")]
		public bool cartFlip;

		// Token: 0x04003B6E RID: 15214
		[Token(Token = "0x4003B6E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x7D8")]
		public float trackBoost;

		// Token: 0x04003B6F RID: 15215
		[Token(Token = "0x4003B6F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x7DC")]
		public Vector2 lastBoost;

		// Token: 0x04003B70 RID: 15216
		[Token(Token = "0x4003B70")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x7E4")]
		public Mount mount;

		// Token: 0x04003B71 RID: 15217
		[Token(Token = "0x4003B71")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x7E8")]
		public bool blackCat;

		// Token: 0x04003B72 RID: 15218
		[Token(Token = "0x4003B72")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x7E9")]
		public bool spider;

		// Token: 0x04003B73 RID: 15219
		[Token(Token = "0x4003B73")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x7EA")]
		public bool squashling;

		// Token: 0x04003B74 RID: 15220
		[Token(Token = "0x4003B74")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x7EB")]
		public bool petFlagDD2Gato;

		// Token: 0x04003B75 RID: 15221
		[Token(Token = "0x4003B75")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x7EC")]
		public bool petFlagDD2Ghost;

		// Token: 0x04003B76 RID: 15222
		[Token(Token = "0x4003B76")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x7ED")]
		public bool petFlagDD2Dragon;

		// Token: 0x04003B77 RID: 15223
		[Token(Token = "0x4003B77")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x7EE")]
		public bool petFlagUpbeatStar;

		// Token: 0x04003B78 RID: 15224
		[Token(Token = "0x4003B78")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x7EF")]
		public bool petFlagSugarGlider;

		// Token: 0x04003B79 RID: 15225
		[Token(Token = "0x4003B79")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x7F0")]
		public bool petFlagBabyShark;

		// Token: 0x04003B7A RID: 15226
		[Token(Token = "0x4003B7A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x7F1")]
		public bool petFlagLilHarpy;

		// Token: 0x04003B7B RID: 15227
		[Token(Token = "0x4003B7B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x7F2")]
		public bool petFlagFennecFox;

		// Token: 0x04003B7C RID: 15228
		[Token(Token = "0x4003B7C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x7F3")]
		public bool petFlagGlitteryButterfly;

		// Token: 0x04003B7D RID: 15229
		[Token(Token = "0x4003B7D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x7F4")]
		public bool petFlagBabyImp;

		// Token: 0x04003B7E RID: 15230
		[Token(Token = "0x4003B7E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x7F5")]
		public bool petFlagBabyRedPanda;

		// Token: 0x04003B7F RID: 15231
		[Token(Token = "0x4003B7F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x7F6")]
		public bool petFlagPlantero;

		// Token: 0x04003B80 RID: 15232
		[Token(Token = "0x4003B80")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x7F7")]
		public bool petFlagDynamiteKitten;

		// Token: 0x04003B81 RID: 15233
		[Token(Token = "0x4003B81")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x7F8")]
		public bool petFlagBabyWerewolf;

		// Token: 0x04003B82 RID: 15234
		[Token(Token = "0x4003B82")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x7F9")]
		public bool petFlagShadowMimic;

		// Token: 0x04003B83 RID: 15235
		[Token(Token = "0x4003B83")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x7FA")]
		public bool petFlagVoltBunny;

		// Token: 0x04003B84 RID: 15236
		[Token(Token = "0x4003B84")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x7FB")]
		public bool petFlagKingSlimePet;

		// Token: 0x04003B85 RID: 15237
		[Token(Token = "0x4003B85")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x7FC")]
		public bool petFlagEyeOfCthulhuPet;

		// Token: 0x04003B86 RID: 15238
		[Token(Token = "0x4003B86")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x7FD")]
		public bool petFlagEaterOfWorldsPet;

		// Token: 0x04003B87 RID: 15239
		[Token(Token = "0x4003B87")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x7FE")]
		public bool petFlagBrainOfCthulhuPet;

		// Token: 0x04003B88 RID: 15240
		[Token(Token = "0x4003B88")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x7FF")]
		public bool petFlagSkeletronPet;

		// Token: 0x04003B89 RID: 15241
		[Token(Token = "0x4003B89")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x800")]
		public bool petFlagQueenBeePet;

		// Token: 0x04003B8A RID: 15242
		[Token(Token = "0x4003B8A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x801")]
		public bool petFlagDestroyerPet;

		// Token: 0x04003B8B RID: 15243
		[Token(Token = "0x4003B8B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x802")]
		public bool petFlagTwinsPet;

		// Token: 0x04003B8C RID: 15244
		[Token(Token = "0x4003B8C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x803")]
		public bool petFlagSkeletronPrimePet;

		// Token: 0x04003B8D RID: 15245
		[Token(Token = "0x4003B8D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x804")]
		public bool petFlagPlanteraPet;

		// Token: 0x04003B8E RID: 15246
		[Token(Token = "0x4003B8E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x805")]
		public bool petFlagGolemPet;

		// Token: 0x04003B8F RID: 15247
		[Token(Token = "0x4003B8F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x806")]
		public bool petFlagDukeFishronPet;

		// Token: 0x04003B90 RID: 15248
		[Token(Token = "0x4003B90")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x807")]
		public bool petFlagLunaticCultistPet;

		// Token: 0x04003B91 RID: 15249
		[Token(Token = "0x4003B91")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x808")]
		public bool petFlagMoonLordPet;

		// Token: 0x04003B92 RID: 15250
		[Token(Token = "0x4003B92")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x809")]
		public bool petFlagFairyQueenPet;

		// Token: 0x04003B93 RID: 15251
		[Token(Token = "0x4003B93")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x80A")]
		public bool petFlagPumpkingPet;

		// Token: 0x04003B94 RID: 15252
		[Token(Token = "0x4003B94")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x80B")]
		public bool petFlagEverscreamPet;

		// Token: 0x04003B95 RID: 15253
		[Token(Token = "0x4003B95")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x80C")]
		public bool petFlagIceQueenPet;

		// Token: 0x04003B96 RID: 15254
		[Token(Token = "0x4003B96")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x80D")]
		public bool petFlagMartianPet;

		// Token: 0x04003B97 RID: 15255
		[Token(Token = "0x4003B97")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x80E")]
		public bool petFlagDD2OgrePet;

		// Token: 0x04003B98 RID: 15256
		[Token(Token = "0x4003B98")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x80F")]
		public bool petFlagDD2BetsyPet;

		// Token: 0x04003B99 RID: 15257
		[Token(Token = "0x4003B99")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x810")]
		public bool petFlagQueenSlimePet;

		// Token: 0x04003B9A RID: 15258
		[Token(Token = "0x4003B9A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x811")]
		public bool petFlagBerniePet;

		// Token: 0x04003B9B RID: 15259
		[Token(Token = "0x4003B9B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x812")]
		public bool petFlagGlommerPet;

		// Token: 0x04003B9C RID: 15260
		[Token(Token = "0x4003B9C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x813")]
		public bool petFlagDeerclopsPet;

		// Token: 0x04003B9D RID: 15261
		[Token(Token = "0x4003B9D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x814")]
		public bool petFlagPigPet;

		// Token: 0x04003B9E RID: 15262
		[Token(Token = "0x4003B9E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x815")]
		public bool petFlagChesterPet;

		// Token: 0x04003B9F RID: 15263
		[Token(Token = "0x4003B9F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x816")]
		public bool petFlagJunimoPet;

		// Token: 0x04003BA0 RID: 15264
		[Token(Token = "0x4003BA0")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x817")]
		public bool petFlagBlueChickenPet;

		// Token: 0x04003BA1 RID: 15265
		[Token(Token = "0x4003BA1")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x818")]
		public bool petFlagSpiffo;

		// Token: 0x04003BA2 RID: 15266
		[Token(Token = "0x4003BA2")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x819")]
		public bool petFlagCaveling;

		// Token: 0x04003BA3 RID: 15267
		[Token(Token = "0x4003BA3")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x81A")]
		public bool petFlagDirtiestBlock;

		// Token: 0x04003BA4 RID: 15268
		[Token(Token = "0x4003BA4")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x81B")]
		public bool petFlagBoulderPet;

		// Token: 0x04003BA5 RID: 15269
		[Token(Token = "0x4003BA5")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x81C")]
		public bool petFlagRainbowBoulderPet;

		// Token: 0x04003BA6 RID: 15270
		[Token(Token = "0x4003BA6")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x81D")]
		public bool petFlagDeadCellsSwarmBiter;

		// Token: 0x04003BA7 RID: 15271
		[Token(Token = "0x4003BA7")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x81E")]
		public bool petFlagPufferfish;

		// Token: 0x04003BA8 RID: 15272
		[Token(Token = "0x4003BA8")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x81F")]
		public bool petFlagAxeFairyPet;

		// Token: 0x04003BA9 RID: 15273
		[Token(Token = "0x4003BA9")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x820")]
		public bool petFlagChillet;

		// Token: 0x04003BAA RID: 15274
		[Token(Token = "0x4003BAA")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x821")]
		public bool petFlagChilletIgnis;

		// Token: 0x04003BAB RID: 15275
		[Token(Token = "0x4003BAB")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x822")]
		public bool companionCube;

		// Token: 0x04003BAC RID: 15276
		[Token(Token = "0x4003BAC")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x823")]
		public bool babyFaceMonster;

		// Token: 0x04003BAD RID: 15277
		[Token(Token = "0x4003BAD")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x824")]
		public bool magicCuffs;

		// Token: 0x04003BAE RID: 15278
		[Token(Token = "0x4003BAE")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x825")]
		public bool coldDash;

		// Token: 0x04003BAF RID: 15279
		[Token(Token = "0x4003BAF")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x826")]
		public bool sailDash;

		// Token: 0x04003BB0 RID: 15280
		[Token(Token = "0x4003BB0")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x827")]
		public bool desertDash;

		// Token: 0x04003BB1 RID: 15281
		[Token(Token = "0x4003BB1")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x828")]
		public bool desertBoots;

		// Token: 0x04003BB2 RID: 15282
		[Token(Token = "0x4003BB2")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x829")]
		public bool eyeSpring;

		// Token: 0x04003BB3 RID: 15283
		[Token(Token = "0x4003BB3")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x82A")]
		public bool snowman;

		// Token: 0x04003BB4 RID: 15284
		[Token(Token = "0x4003BB4")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x82B")]
		public bool scope;

		// Token: 0x04003BB5 RID: 15285
		[Token(Token = "0x4003BB5")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x82C")]
		public bool dino;

		// Token: 0x04003BB6 RID: 15286
		[Token(Token = "0x4003BB6")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x82D")]
		public bool skeletron;

		// Token: 0x04003BB7 RID: 15287
		[Token(Token = "0x4003BB7")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x82E")]
		public bool hornet;

		// Token: 0x04003BB8 RID: 15288
		[Token(Token = "0x4003BB8")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x82F")]
		public bool zephyrfish;

		// Token: 0x04003BB9 RID: 15289
		[Token(Token = "0x4003BB9")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x830")]
		public bool tiki;

		// Token: 0x04003BBA RID: 15290
		[Token(Token = "0x4003BBA")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x831")]
		public bool parrot;

		// Token: 0x04003BBB RID: 15291
		[Token(Token = "0x4003BBB")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x832")]
		public bool truffle;

		// Token: 0x04003BBC RID: 15292
		[Token(Token = "0x4003BBC")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x833")]
		public bool sapling;

		// Token: 0x04003BBD RID: 15293
		[Token(Token = "0x4003BBD")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x834")]
		public bool cSapling;

		// Token: 0x04003BBE RID: 15294
		[Token(Token = "0x4003BBE")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x835")]
		public bool wisp;

		// Token: 0x04003BBF RID: 15295
		[Token(Token = "0x4003BBF")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x836")]
		public bool lizard;

		// Token: 0x04003BC0 RID: 15296
		[Token(Token = "0x4003BC0")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x837")]
		public bool archery;

		// Token: 0x04003BC1 RID: 15297
		[Token(Token = "0x4003BC1")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x838")]
		public bool poisoned;

		// Token: 0x04003BC2 RID: 15298
		[Token(Token = "0x4003BC2")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x839")]
		public bool venom;

		// Token: 0x04003BC3 RID: 15299
		[Token(Token = "0x4003BC3")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x83A")]
		public bool chlorophyteSpore;

		// Token: 0x04003BC4 RID: 15300
		[Token(Token = "0x4003BC4")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x83B")]
		public bool blind;

		// Token: 0x04003BC5 RID: 15301
		[Token(Token = "0x4003BC5")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x83C")]
		public bool blackout;

		// Token: 0x04003BC6 RID: 15302
		[Token(Token = "0x4003BC6")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x83D")]
		public bool headcovered;

		// Token: 0x04003BC7 RID: 15303
		[Token(Token = "0x4003BC7")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x83E")]
		public bool frostBurn;

		// Token: 0x04003BC8 RID: 15304
		[Token(Token = "0x4003BC8")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x83F")]
		public bool onFrostBurn;

		// Token: 0x04003BC9 RID: 15305
		[Token(Token = "0x4003BC9")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x840")]
		public bool onFrostBurn2;

		// Token: 0x04003BCA RID: 15306
		[Token(Token = "0x4003BCA")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x841")]
		public bool burned;

		// Token: 0x04003BCB RID: 15307
		[Token(Token = "0x4003BCB")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x842")]
		public bool shimmering;

		// Token: 0x04003BCC RID: 15308
		[Token(Token = "0x4003BCC")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x844")]
		public int timeShimmering;

		// Token: 0x04003BCD RID: 15309
		[Token(Token = "0x4003BCD")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x848")]
		public float shimmerTransparency;

		// Token: 0x04003BCE RID: 15310
		[Token(Token = "0x4003BCE")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x84C")]
		public ShimmerUnstuckHelper shimmerUnstuckHelper;

		// Token: 0x04003BCF RID: 15311
		[Token(Token = "0x4003BCF")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x854")]
		public bool suffocating;

		// Token: 0x04003BD0 RID: 15312
		[Token(Token = "0x4003BD0")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x855")]
		public byte suffocateDelay;

		// Token: 0x04003BD1 RID: 15313
		[Token(Token = "0x4003BD1")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x856")]
		public bool dripping;

		// Token: 0x04003BD2 RID: 15314
		[Token(Token = "0x4003BD2")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x857")]
		public bool drippingSlime;

		// Token: 0x04003BD3 RID: 15315
		[Token(Token = "0x4003BD3")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x858")]
		public bool drippingSparkleSlime;

		// Token: 0x04003BD4 RID: 15316
		[Token(Token = "0x4003BD4")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x859")]
		public bool onFire;

		// Token: 0x04003BD5 RID: 15317
		[Token(Token = "0x4003BD5")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x85A")]
		public bool onFire2;

		// Token: 0x04003BD6 RID: 15318
		[Token(Token = "0x4003BD6")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x85B")]
		public bool onFire3;

		// Token: 0x04003BD7 RID: 15319
		[Token(Token = "0x4003BD7")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x85C")]
		public bool noItems;

		// Token: 0x04003BD8 RID: 15320
		[Token(Token = "0x4003BD8")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x85D")]
		public bool cursed;

		// Token: 0x04003BD9 RID: 15321
		[Token(Token = "0x4003BD9")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x85E")]
		public bool hungry;

		// Token: 0x04003BDA RID: 15322
		[Token(Token = "0x4003BDA")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x85F")]
		public bool starving;

		// Token: 0x04003BDB RID: 15323
		[Token(Token = "0x4003BDB")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x860")]
		public bool heartyMeal;

		// Token: 0x04003BDC RID: 15324
		[Token(Token = "0x4003BDC")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x861")]
		public bool windPushed;

		// Token: 0x04003BDD RID: 15325
		[Token(Token = "0x4003BDD")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x862")]
		public bool wereWolf;

		// Token: 0x04003BDE RID: 15326
		[Token(Token = "0x4003BDE")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x863")]
		public bool wolfAcc;

		// Token: 0x04003BDF RID: 15327
		[Token(Token = "0x4003BDF")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x864")]
		public bool hideMerman;

		// Token: 0x04003BE0 RID: 15328
		[Token(Token = "0x4003BE0")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x865")]
		public bool hideWolf;

		// Token: 0x04003BE1 RID: 15329
		[Token(Token = "0x4003BE1")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x866")]
		public bool forceMerman;

		// Token: 0x04003BE2 RID: 15330
		[Token(Token = "0x4003BE2")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x867")]
		public bool forceWerewolf;

		// Token: 0x04003BE3 RID: 15331
		[Token(Token = "0x4003BE3")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x868")]
		public int sunScorchCounter;

		// Token: 0x04003BE4 RID: 15332
		[Token(Token = "0x4003BE4")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x86C")]
		public bool rulerGrid;

		// Token: 0x04003BE5 RID: 15333
		[Token(Token = "0x4003BE5")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x86D")]
		public bool rulerLine;

		// Token: 0x04003BE6 RID: 15334
		[Token(Token = "0x4003BE6")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x86E")]
		public bool bleed;

		// Token: 0x04003BE7 RID: 15335
		[Token(Token = "0x4003BE7")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x86F")]
		public bool confused;

		// Token: 0x04003BE8 RID: 15336
		[Token(Token = "0x4003BE8")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x870")]
		public bool accMerman;

		// Token: 0x04003BE9 RID: 15337
		[Token(Token = "0x4003BE9")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x871")]
		public bool merman;

		// Token: 0x04003BEA RID: 15338
		[Token(Token = "0x4003BEA")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x872")]
		public bool trident;

		// Token: 0x04003BEB RID: 15339
		[Token(Token = "0x4003BEB")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x873")]
		public bool brokenArmor;

		// Token: 0x04003BEC RID: 15340
		[Token(Token = "0x4003BEC")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x874")]
		public bool silence;

		// Token: 0x04003BED RID: 15341
		[Token(Token = "0x4003BED")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x875")]
		public bool slow;

		// Token: 0x04003BEE RID: 15342
		[Token(Token = "0x4003BEE")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x876")]
		public bool gross;

		// Token: 0x04003BEF RID: 15343
		[Token(Token = "0x4003BEF")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x877")]
		public bool tongued;

		// Token: 0x04003BF0 RID: 15344
		[Token(Token = "0x4003BF0")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x878")]
		public bool kbGlove;

		// Token: 0x04003BF1 RID: 15345
		[Token(Token = "0x4003BF1")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x879")]
		public bool autoReuseGlove;

		// Token: 0x04003BF2 RID: 15346
		[Token(Token = "0x4003BF2")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x87A")]
		public bool meleeScaleGlove;

		// Token: 0x04003BF3 RID: 15347
		[Token(Token = "0x4003BF3")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x87B")]
		public bool kbBuff;

		// Token: 0x04003BF4 RID: 15348
		[Token(Token = "0x4003BF4")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x87C")]
		public bool remoteVisionForDrone;

		// Token: 0x04003BF5 RID: 15349
		[Token(Token = "0x4003BF5")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x880")]
		public Item starCloakItem;

		// Token: 0x04003BF6 RID: 15350
		[Token(Token = "0x4003BF6")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x884")]
		public Item starCloakItem_manaCloakOverrideItem;

		// Token: 0x04003BF7 RID: 15351
		[Token(Token = "0x4003BF7")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x888")]
		public Item starCloakItem_starVeilOverrideItem;

		// Token: 0x04003BF8 RID: 15352
		[Token(Token = "0x4003BF8")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x88C")]
		public Item starCloakItem_beeCloakOverrideItem;

		// Token: 0x04003BF9 RID: 15353
		[Token(Token = "0x4003BF9")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x890")]
		public Item starCloakItem_snakeCloakOverrideItem;

		// Token: 0x04003BFA RID: 15354
		[Token(Token = "0x4003BFA")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x894")]
		public bool longInvince;

		// Token: 0x04003BFB RID: 15355
		[Token(Token = "0x4003BFB")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x895")]
		public bool pStone;

		// Token: 0x04003BFC RID: 15356
		[Token(Token = "0x4003BFC")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public static readonly float PhilosopherStoneDurationMultiplier;

		// Token: 0x04003BFD RID: 15357
		[Token(Token = "0x4003BFD")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x896")]
		public bool manaFlower;

		// Token: 0x04003BFE RID: 15358
		[Token(Token = "0x4003BFE")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x897")]
		public bool moonLeech;

		// Token: 0x04003BFF RID: 15359
		[Token(Token = "0x4003BFF")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x898")]
		public bool vortexDebuff;

		// Token: 0x04003C00 RID: 15360
		[Token(Token = "0x4003C00")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x899")]
		public bool trapDebuffSource;

		// Token: 0x04003C01 RID: 15361
		[Token(Token = "0x4003C01")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x89A")]
		public bool witheredArmor;

		// Token: 0x04003C02 RID: 15362
		[Token(Token = "0x4003C02")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x89B")]
		public bool witheredWeapon;

		// Token: 0x04003C03 RID: 15363
		[Token(Token = "0x4003C03")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x89C")]
		public bool slowOgreSpit;

		// Token: 0x04003C04 RID: 15364
		[Token(Token = "0x4003C04")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x89D")]
		public bool parryDamageBuff;

		// Token: 0x04003C05 RID: 15365
		[Token(Token = "0x4003C05")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x89E")]
		public bool ballistaPanic;

		// Token: 0x04003C06 RID: 15366
		[Token(Token = "0x4003C06")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x89F")]
		public bool JustDroppedAnItem;

		// Token: 0x04003C07 RID: 15367
		[Token(Token = "0x4003C07")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8A0")]
		public bool IsAllowedToHoldItems;

		// Token: 0x04003C08 RID: 15368
		[Token(Token = "0x4003C08")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8A4")]
		public int selectedCrit;

		// Token: 0x04003C09 RID: 15369
		[Token(Token = "0x4003C09")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8A8")]
		public int meleeCrit;

		// Token: 0x04003C0A RID: 15370
		[Token(Token = "0x4003C0A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8AC")]
		public int magicCrit;

		// Token: 0x04003C0B RID: 15371
		[Token(Token = "0x4003C0B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8B0")]
		public int rangedCrit;

		// Token: 0x04003C0C RID: 15372
		[Token(Token = "0x4003C0C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8B4")]
		public float meleeDamage;

		// Token: 0x04003C0D RID: 15373
		[Token(Token = "0x4003C0D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8B8")]
		public float magicDamage;

		// Token: 0x04003C0E RID: 15374
		[Token(Token = "0x4003C0E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8BC")]
		public float rangedDamage;

		// Token: 0x04003C0F RID: 15375
		[Token(Token = "0x4003C0F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8C0")]
		public float rangedMultDamage;

		// Token: 0x04003C10 RID: 15376
		[Token(Token = "0x4003C10")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8C4")]
		public float arrowDamageAdditiveStack;

		// Token: 0x04003C11 RID: 15377
		[Token(Token = "0x4003C11")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8C8")]
		public float arrowDamage;

		// Token: 0x04003C12 RID: 15378
		[Token(Token = "0x4003C12")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8CC")]
		public float bulletDamage;

		// Token: 0x04003C13 RID: 15379
		[Token(Token = "0x4003C13")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8D0")]
		public float rocketDamage;

		// Token: 0x04003C14 RID: 15380
		[Token(Token = "0x4003C14")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8D4")]
		public float minionDamage;

		// Token: 0x04003C15 RID: 15381
		[Token(Token = "0x4003C15")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8D8")]
		public float minionKB;

		// Token: 0x04003C16 RID: 15382
		[Token(Token = "0x4003C16")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8DC")]
		public int revolverCritChanceBonus;

		// Token: 0x04003C17 RID: 15383
		[Token(Token = "0x4003C17")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8E0")]
		public float meleeSpeed;

		// Token: 0x04003C18 RID: 15384
		[Token(Token = "0x4003C18")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8E4")]
		public float summonerWeaponSpeedBonus;

		// Token: 0x04003C19 RID: 15385
		[Token(Token = "0x4003C19")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8E8")]
		public float strongestMoveSpeedDebuff;

		// Token: 0x04003C1A RID: 15386
		[Token(Token = "0x4003C1A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8EC")]
		public float moveSpeed;

		// Token: 0x04003C1B RID: 15387
		[Token(Token = "0x4003C1B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8F0")]
		public float pickSpeed;

		// Token: 0x04003C1C RID: 15388
		[Token(Token = "0x4003C1C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8F4")]
		public float wallSpeed;

		// Token: 0x04003C1D RID: 15389
		[Token(Token = "0x4003C1D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8F8")]
		public float tileSpeed;

		// Token: 0x04003C1E RID: 15390
		[Token(Token = "0x4003C1E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8FC")]
		public bool autoPaint;

		// Token: 0x04003C1F RID: 15391
		[Token(Token = "0x4003C1F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8FD")]
		public bool autoActuator;

		// Token: 0x04003C20 RID: 15392
		[Token(Token = "0x4003C20")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x900")]
		public int SpawnX;

		// Token: 0x04003C21 RID: 15393
		[Token(Token = "0x4003C21")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x904")]
		public int SpawnY;

		// Token: 0x04003C22 RID: 15394
		[Token(Token = "0x4003C22")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x908")]
		public Vector2? PotionOfReturnOriginalUsePosition;

		// Token: 0x04003C23 RID: 15395
		[Token(Token = "0x4003C23")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x914")]
		public Vector2? PotionOfReturnHomePosition;

		// Token: 0x04003C24 RID: 15396
		[Token(Token = "0x4003C24")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x920")]
		public int[] spX;

		// Token: 0x04003C25 RID: 15397
		[Token(Token = "0x4003C25")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x924")]
		public int[] spY;

		// Token: 0x04003C26 RID: 15398
		[Token(Token = "0x4003C26")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x928")]
		public string[] spN;

		// Token: 0x04003C27 RID: 15399
		[Token(Token = "0x4003C27")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x92C")]
		public int[] spI;

		// Token: 0x04003C28 RID: 15400
		[Token(Token = "0x4003C28")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x930")]
		public int lastTileRangeX;

		// Token: 0x04003C29 RID: 15401
		[Token(Token = "0x4003C29")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x934")]
		public int lastTileRangeY;

		// Token: 0x04003C2A RID: 15402
		[Token(Token = "0x4003C2A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x938")]
		public float gravity;

		// Token: 0x04003C2B RID: 15403
		[Token(Token = "0x4003C2B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x93C")]
		public float maxFallSpeed;

		// Token: 0x04003C2C RID: 15404
		[Token(Token = "0x4003C2C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x940")]
		public float maxRunSpeed;

		// Token: 0x04003C2D RID: 15405
		[Token(Token = "0x4003C2D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x944")]
		public float runAcceleration;

		// Token: 0x04003C2E RID: 15406
		[Token(Token = "0x4003C2E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x948")]
		public float runSlowdown;

		// Token: 0x04003C2F RID: 15407
		[Token(Token = "0x4003C2F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x94C")]
		public int TotalRunTime;

		// Token: 0x04003C30 RID: 15408
		[Token(Token = "0x4003C30")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x950")]
		public bool adjWaterSource;

		// Token: 0x04003C31 RID: 15409
		[Token(Token = "0x4003C31")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x951")]
		public bool adjHoney;

		// Token: 0x04003C32 RID: 15410
		[Token(Token = "0x4003C32")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x952")]
		public bool adjLava;

		// Token: 0x04003C33 RID: 15411
		[Token(Token = "0x4003C33")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x953")]
		public bool oldAdjWaterSource;

		// Token: 0x04003C34 RID: 15412
		[Token(Token = "0x4003C34")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x954")]
		public bool oldAdjHoney;

		// Token: 0x04003C35 RID: 15413
		[Token(Token = "0x4003C35")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x955")]
		public bool oldAdjLava;

		// Token: 0x04003C36 RID: 15414
		[Token(Token = "0x4003C36")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x958")]
		public bool[] adjTile;

		// Token: 0x04003C37 RID: 15415
		[Token(Token = "0x4003C37")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private static float itemGrabSpeed;

		// Token: 0x04003C38 RID: 15416
		[Token(Token = "0x4003C38")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static float itemGrabSpeedMax;

		// Token: 0x04003C39 RID: 15417
		[Token(Token = "0x4003C39")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x95C")]
		public byte hairDye;

		// Token: 0x04003C3A RID: 15418
		[Token(Token = "0x4003C3A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x95D")]
		public Color hairDyeColor;

		// Token: 0x04003C3B RID: 15419
		[Token(Token = "0x4003C3B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x964")]
		public float hairDyeVar;

		// Token: 0x04003C3C RID: 15420
		[Token(Token = "0x4003C3C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x968")]
		public int skinDyePacked;

		// Token: 0x04003C3D RID: 15421
		[Token(Token = "0x4003C3D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x96C")]
		public Color hairColor;

		// Token: 0x04003C3E RID: 15422
		[Token(Token = "0x4003C3E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x970")]
		public Color skinColor;

		// Token: 0x04003C3F RID: 15423
		[Token(Token = "0x4003C3F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x974")]
		public Color eyeColor;

		// Token: 0x04003C40 RID: 15424
		[Token(Token = "0x4003C40")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x978")]
		public Color shirtColor;

		// Token: 0x04003C41 RID: 15425
		[Token(Token = "0x4003C41")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x97C")]
		public Color underShirtColor;

		// Token: 0x04003C42 RID: 15426
		[Token(Token = "0x4003C42")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x980")]
		public Color pantsColor;

		// Token: 0x04003C43 RID: 15427
		[Token(Token = "0x4003C43")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x984")]
		public Color shoeColor;

		// Token: 0x04003C44 RID: 15428
		[Token(Token = "0x4003C44")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x988")]
		public int hair;

		// Token: 0x04003C45 RID: 15429
		[Token(Token = "0x4003C45")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x98C")]
		public bool hostile;

		// Token: 0x04003C46 RID: 15430
		[Token(Token = "0x4003C46")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x990")]
		public SoundPlaySet hermesStepSound;

		// Token: 0x04003C47 RID: 15431
		[Token(Token = "0x4003C47")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x994")]
		public Vector2 instantMovementAccumulatedThisFrame;

		// Token: 0x04003C48 RID: 15432
		[Token(Token = "0x4003C48")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x99C")]
		public int accCompass;

		// Token: 0x04003C49 RID: 15433
		[Token(Token = "0x4003C49")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x9A0")]
		public int accWatch;

		// Token: 0x04003C4A RID: 15434
		[Token(Token = "0x4003C4A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x9A8")]
		public double accWatchTime;

		// Token: 0x04003C4B RID: 15435
		[Token(Token = "0x4003C4B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x9B0")]
		public int accDepthMeter;

		// Token: 0x04003C4C RID: 15436
		[Token(Token = "0x4003C4C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x9B4")]
		public bool accFishFinder;

		// Token: 0x04003C4D RID: 15437
		[Token(Token = "0x4003C4D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x9B5")]
		public bool accWeatherRadio;

		// Token: 0x04003C4E RID: 15438
		[Token(Token = "0x4003C4E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x9B6")]
		public bool accJarOfSouls;

		// Token: 0x04003C4F RID: 15439
		[Token(Token = "0x4003C4F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x9B7")]
		public bool accCalendar;

		// Token: 0x04003C50 RID: 15440
		[Token(Token = "0x4003C50")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x9B8")]
		public int lastCreatureHit;

		// Token: 0x04003C51 RID: 15441
		[Token(Token = "0x4003C51")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x9BC")]
		public bool accThirdEye;

		// Token: 0x04003C52 RID: 15442
		[Token(Token = "0x4003C52")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x9BD")]
		public byte accThirdEyeCounter;

		// Token: 0x04003C53 RID: 15443
		[Token(Token = "0x4003C53")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x9BE")]
		public byte accThirdEyeNumber;

		// Token: 0x04003C54 RID: 15444
		[Token(Token = "0x4003C54")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x9BF")]
		public bool accStopwatch;

		// Token: 0x04003C55 RID: 15445
		[Token(Token = "0x4003C55")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x9C0")]
		public bool accOreFinder;

		// Token: 0x04003C56 RID: 15446
		[Token(Token = "0x4003C56")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x9C1")]
		public bool accCritterGuide;

		// Token: 0x04003C57 RID: 15447
		[Token(Token = "0x4003C57")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x9C2")]
		public byte accCritterGuideCounter;

		// Token: 0x04003C58 RID: 15448
		[Token(Token = "0x4003C58")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x9C3")]
		public byte accCritterGuideNumber;

		// Token: 0x04003C59 RID: 15449
		[Token(Token = "0x4003C59")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x9C4")]
		public bool accDreamCatcher;

		// Token: 0x04003C5A RID: 15450
		[Token(Token = "0x4003C5A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x9C5")]
		public bool hasFootball;

		// Token: 0x04003C5B RID: 15451
		[Token(Token = "0x4003C5B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x9C6")]
		public bool drawingFootball;

		// Token: 0x04003C5C RID: 15452
		[Token(Token = "0x4003C5C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x9C7")]
		public bool ActuationRodLock;

		// Token: 0x04003C5D RID: 15453
		[Token(Token = "0x4003C5D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x9C8")]
		public bool ActuationRodLockSetting;

		// Token: 0x04003C5E RID: 15454
		[Token(Token = "0x4003C5E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x9C9")]
		public bool InfoAccMechShowWires;

		// Token: 0x04003C5F RID: 15455
		[Token(Token = "0x4003C5F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x9D0")]
		public DateTime dpsStart;

		// Token: 0x04003C60 RID: 15456
		[Token(Token = "0x4003C60")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x9D8")]
		public DateTime dpsEnd;

		// Token: 0x04003C61 RID: 15457
		[Token(Token = "0x4003C61")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x9E0")]
		public DateTime dpsLastHit;

		// Token: 0x04003C62 RID: 15458
		[Token(Token = "0x4003C62")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x9E8")]
		public int dpsDamage;

		// Token: 0x04003C63 RID: 15459
		[Token(Token = "0x4003C63")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x9EC")]
		public bool dpsStarted;

		// Token: 0x04003C64 RID: 15460
		[Token(Token = "0x4003C64")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x9F0")]
		public string displayedFishingInfo;

		// Token: 0x04003C65 RID: 15461
		[Token(Token = "0x4003C65")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x9F4")]
		public bool discountEquipped;

		// Token: 0x04003C66 RID: 15462
		[Token(Token = "0x4003C66")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x9F5")]
		public bool discountAvailable;

		// Token: 0x04003C67 RID: 15463
		[Token(Token = "0x4003C67")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x9F6")]
		public bool hasLuckyCoin;

		// Token: 0x04003C68 RID: 15464
		[Token(Token = "0x4003C68")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x9F8")]
		public Item boneGloveItem;

		// Token: 0x04003C69 RID: 15465
		[Token(Token = "0x4003C69")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x9FC")]
		public bool goldRing;

		// Token: 0x04003C6A RID: 15466
		[Token(Token = "0x4003C6A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x9FD")]
		public bool accDivingHelm;

		// Token: 0x04003C6B RID: 15467
		[Token(Token = "0x4003C6B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x9FE")]
		public bool accFlipper;

		// Token: 0x04003C6C RID: 15468
		[Token(Token = "0x4003C6C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x9FF")]
		public bool deadCellsPotionStation;

		// Token: 0x04003C6D RID: 15469
		[Token(Token = "0x4003C6D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA00")]
		public bool hasLuck_LuckyCoin;

		// Token: 0x04003C6E RID: 15470
		[Token(Token = "0x4003C6E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA01")]
		public bool hasLuck_LuckyHorseshoe;

		// Token: 0x04003C6F RID: 15471
		[Token(Token = "0x4003C6F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA02")]
		public bool hasLuck_LuckyClover;

		// Token: 0x04003C70 RID: 15472
		[Token(Token = "0x4003C70")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA03")]
		public bool hasLuck_WiltedClover;

		// Token: 0x04003C71 RID: 15473
		[Token(Token = "0x4003C71")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA04")]
		public bool hasLuck_RavenFeather;

		// Token: 0x04003C72 RID: 15474
		[Token(Token = "0x4003C72")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA08")]
		public int doubleJumpsPerformed;

		// Token: 0x04003C73 RID: 15475
		[Token(Token = "0x4003C73")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA0C")]
		public bool isPerformingJump_DownDash;

		// Token: 0x04003C74 RID: 15476
		[Token(Token = "0x4003C74")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA10")]
		public int downDashTime;

		// Token: 0x04003C75 RID: 15477
		[Token(Token = "0x4003C75")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA14")]
		public bool hasJumpOption_Cloud;

		// Token: 0x04003C76 RID: 15478
		[Token(Token = "0x4003C76")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA15")]
		public bool canJumpAgain_Cloud;

		// Token: 0x04003C77 RID: 15479
		[Token(Token = "0x4003C77")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA16")]
		public bool isPerformingJump_Cloud;

		// Token: 0x04003C78 RID: 15480
		[Token(Token = "0x4003C78")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA17")]
		public bool hasJumpOption_Sandstorm;

		// Token: 0x04003C79 RID: 15481
		[Token(Token = "0x4003C79")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA18")]
		public bool canJumpAgain_Sandstorm;

		// Token: 0x04003C7A RID: 15482
		[Token(Token = "0x4003C7A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA19")]
		public bool isPerformingJump_Sandstorm;

		// Token: 0x04003C7B RID: 15483
		[Token(Token = "0x4003C7B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA1A")]
		public bool hasJumpOption_Blizzard;

		// Token: 0x04003C7C RID: 15484
		[Token(Token = "0x4003C7C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA1B")]
		public bool canJumpAgain_Blizzard;

		// Token: 0x04003C7D RID: 15485
		[Token(Token = "0x4003C7D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA1C")]
		public bool isPerformingJump_Blizzard;

		// Token: 0x04003C7E RID: 15486
		[Token(Token = "0x4003C7E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA1D")]
		public bool hasJumpOption_Fart;

		// Token: 0x04003C7F RID: 15487
		[Token(Token = "0x4003C7F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA1E")]
		public bool canJumpAgain_Fart;

		// Token: 0x04003C80 RID: 15488
		[Token(Token = "0x4003C80")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA1F")]
		public bool isPerformingJump_Fart;

		// Token: 0x04003C81 RID: 15489
		[Token(Token = "0x4003C81")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA20")]
		public bool hasJumpOption_Sail;

		// Token: 0x04003C82 RID: 15490
		[Token(Token = "0x4003C82")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA21")]
		public bool canJumpAgain_Sail;

		// Token: 0x04003C83 RID: 15491
		[Token(Token = "0x4003C83")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA22")]
		public bool isPerformingJump_Sail;

		// Token: 0x04003C84 RID: 15492
		[Token(Token = "0x4003C84")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA23")]
		public bool hasJumpOption_Unicorn;

		// Token: 0x04003C85 RID: 15493
		[Token(Token = "0x4003C85")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA24")]
		public bool canJumpAgain_Unicorn;

		// Token: 0x04003C86 RID: 15494
		[Token(Token = "0x4003C86")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA25")]
		public bool isPerformingJump_Unicorn;

		// Token: 0x04003C87 RID: 15495
		[Token(Token = "0x4003C87")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA26")]
		public bool hasJumpOption_Santank;

		// Token: 0x04003C88 RID: 15496
		[Token(Token = "0x4003C88")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA27")]
		public bool canJumpAgain_Santank;

		// Token: 0x04003C89 RID: 15497
		[Token(Token = "0x4003C89")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA28")]
		public bool isPerformingJump_Santank;

		// Token: 0x04003C8A RID: 15498
		[Token(Token = "0x4003C8A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA29")]
		public bool hasJumpOption_WallOfFleshGoat;

		// Token: 0x04003C8B RID: 15499
		[Token(Token = "0x4003C8B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA2A")]
		public bool canJumpAgain_WallOfFleshGoat;

		// Token: 0x04003C8C RID: 15500
		[Token(Token = "0x4003C8C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA2B")]
		public bool isPerformingJump_WallOfFleshGoat;

		// Token: 0x04003C8D RID: 15501
		[Token(Token = "0x4003C8D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA2C")]
		public bool hasJumpOption_Basilisk;

		// Token: 0x04003C8E RID: 15502
		[Token(Token = "0x4003C8E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA2D")]
		public bool canJumpAgain_Basilisk;

		// Token: 0x04003C8F RID: 15503
		[Token(Token = "0x4003C8F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA2E")]
		public bool isPerformingJump_Basilisk;

		// Token: 0x04003C90 RID: 15504
		[Token(Token = "0x4003C90")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA2F")]
		public bool isPerformingPogostickTricks;

		// Token: 0x04003C91 RID: 15505
		[Token(Token = "0x4003C91")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA30")]
		public bool autoJump;

		// Token: 0x04003C92 RID: 15506
		[Token(Token = "0x4003C92")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA31")]
		public bool justJumped;

		// Token: 0x04003C93 RID: 15507
		[Token(Token = "0x4003C93")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA34")]
		public float jumpSpeedBoost;

		// Token: 0x04003C94 RID: 15508
		[Token(Token = "0x4003C94")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA38")]
		public int extraFall;

		// Token: 0x04003C95 RID: 15509
		[Token(Token = "0x4003C95")]
		private const float PixelsPerMeter = 26.24672f;

		// Token: 0x04003C96 RID: 15510
		[Token(Token = "0x4003C96")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA3C")]
		private float FractionalDistanceTraveled;

		// Token: 0x04003C97 RID: 15511
		[Token(Token = "0x4003C97")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA40")]
		public bool canFloatInWater;

		// Token: 0x04003C98 RID: 15512
		[Token(Token = "0x4003C98")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA41")]
		public bool hasFloatingTube;

		// Token: 0x04003C99 RID: 15513
		[Token(Token = "0x4003C99")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA42")]
		public bool frogLegJumpBoost;

		// Token: 0x04003C9A RID: 15514
		[Token(Token = "0x4003C9A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA43")]
		public bool skyStoneEffects;

		// Token: 0x04003C9B RID: 15515
		[Token(Token = "0x4003C9B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA44")]
		public bool spawnMax;

		// Token: 0x04003C9C RID: 15516
		[Token(Token = "0x4003C9C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA48")]
		public int blockRange;

		// Token: 0x04003C9D RID: 15517
		[Token(Token = "0x4003C9D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA4C")]
		public int[] grappling;

		// Token: 0x04003C9E RID: 15518
		[Token(Token = "0x4003C9E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA50")]
		public int grapCount;

		// Token: 0x04003C9F RID: 15519
		[Token(Token = "0x4003C9F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA54")]
		public int rocketTime;

		// Token: 0x04003CA0 RID: 15520
		[Token(Token = "0x4003CA0")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA58")]
		public int rocketTimeMax;

		// Token: 0x04003CA1 RID: 15521
		[Token(Token = "0x4003CA1")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA5C")]
		public int rocketDelay;

		// Token: 0x04003CA2 RID: 15522
		[Token(Token = "0x4003CA2")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA60")]
		public int rocketDelay2;

		// Token: 0x04003CA3 RID: 15523
		[Token(Token = "0x4003CA3")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA64")]
		public int rocketSoundDelay;

		// Token: 0x04003CA4 RID: 15524
		[Token(Token = "0x4003CA4")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA68")]
		public bool rocketRelease;

		// Token: 0x04003CA5 RID: 15525
		[Token(Token = "0x4003CA5")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA69")]
		public bool rocketFrame;

		// Token: 0x04003CA6 RID: 15526
		[Token(Token = "0x4003CA6")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA6C")]
		public int rocketBoots;

		// Token: 0x04003CA7 RID: 15527
		[Token(Token = "0x4003CA7")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA70")]
		public int vanityRocketBoots;

		// Token: 0x04003CA8 RID: 15528
		[Token(Token = "0x4003CA8")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA74")]
		public bool canRocket;

		// Token: 0x04003CA9 RID: 15529
		[Token(Token = "0x4003CA9")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA75")]
		public bool jumpBoost;

		// Token: 0x04003CAA RID: 15530
		[Token(Token = "0x4003CAA")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA76")]
		public bool noFallDmg;

		// Token: 0x04003CAB RID: 15531
		[Token(Token = "0x4003CAB")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA78")]
		public int swimTime;

		// Token: 0x04003CAC RID: 15532
		[Token(Token = "0x4003CAC")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA7C")]
		public bool killGuide;

		// Token: 0x04003CAD RID: 15533
		[Token(Token = "0x4003CAD")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA7D")]
		public bool killClothier;

		// Token: 0x04003CAE RID: 15534
		[Token(Token = "0x4003CAE")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA80")]
		public float equipmentBasedLuckBonus;

		// Token: 0x04003CAF RID: 15535
		[Token(Token = "0x4003CAF")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA84")]
		public float lastEquipmentBasedLuckBonus;

		// Token: 0x04003CB0 RID: 15536
		[Token(Token = "0x4003CB0")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA88")]
		public bool hasCreditsSceneMusicBox;

		// Token: 0x04003CB1 RID: 15537
		[Token(Token = "0x4003CB1")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA89")]
		public bool lavaImmune;

		// Token: 0x04003CB2 RID: 15538
		[Token(Token = "0x4003CB2")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA8A")]
		public bool gills;

		// Token: 0x04003CB3 RID: 15539
		[Token(Token = "0x4003CB3")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA8B")]
		public bool slowFall;

		// Token: 0x04003CB4 RID: 15540
		[Token(Token = "0x4003CB4")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA8C")]
		public bool findTreasure;

		// Token: 0x04003CB5 RID: 15541
		[Token(Token = "0x4003CB5")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA8D")]
		public bool biomeSight;

		// Token: 0x04003CB6 RID: 15542
		[Token(Token = "0x4003CB6")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA8E")]
		public bool invis;

		// Token: 0x04003CB7 RID: 15543
		[Token(Token = "0x4003CB7")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA8F")]
		public bool detectCreature;

		// Token: 0x04003CB8 RID: 15544
		[Token(Token = "0x4003CB8")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA90")]
		public bool nightVision;

		// Token: 0x04003CB9 RID: 15545
		[Token(Token = "0x4003CB9")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA91")]
		public bool enemySpawns;

		// Token: 0x04003CBA RID: 15546
		[Token(Token = "0x4003CBA")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA94")]
		public float thorns;

		// Token: 0x04003CBB RID: 15547
		[Token(Token = "0x4003CBB")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA98")]
		public bool turtleArmor;

		// Token: 0x04003CBC RID: 15548
		[Token(Token = "0x4003CBC")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA99")]
		public bool turtleThorns;

		// Token: 0x04003CBD RID: 15549
		[Token(Token = "0x4003CBD")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA9A")]
		public bool cactusThorns;

		// Token: 0x04003CBE RID: 15550
		[Token(Token = "0x4003CBE")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA9B")]
		public bool spiderArmor;

		// Token: 0x04003CBF RID: 15551
		[Token(Token = "0x4003CBF")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA9C")]
		public bool anglerSetSpawnReduction;

		// Token: 0x04003CC0 RID: 15552
		[Token(Token = "0x4003CC0")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA9D")]
		public bool vampireBurningInSunlight;

		// Token: 0x04003CC1 RID: 15553
		[Token(Token = "0x4003CC1")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA9E")]
		public bool insideUnbreakableWalls;

		// Token: 0x04003CC2 RID: 15554
		[Token(Token = "0x4003CC2")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA9F")]
		public bool CanSeeInvisibleBlocks;

		// Token: 0x04003CC3 RID: 15555
		[Token(Token = "0x4003CC3")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xAA0")]
		public bool setSolar;

		// Token: 0x04003CC4 RID: 15556
		[Token(Token = "0x4003CC4")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xAA1")]
		public bool setVortex;

		// Token: 0x04003CC5 RID: 15557
		[Token(Token = "0x4003CC5")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xAA2")]
		public bool setNebula;

		// Token: 0x04003CC6 RID: 15558
		[Token(Token = "0x4003CC6")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xAA4")]
		public int nebulaCD;

		// Token: 0x04003CC7 RID: 15559
		[Token(Token = "0x4003CC7")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xAA8")]
		public bool setStardust;

		// Token: 0x04003CC8 RID: 15560
		[Token(Token = "0x4003CC8")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xAA9")]
		public bool setForbidden;

		// Token: 0x04003CC9 RID: 15561
		[Token(Token = "0x4003CC9")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xAAA")]
		public bool setForbiddenCooldownLocked;

		// Token: 0x04003CCA RID: 15562
		[Token(Token = "0x4003CCA")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xAAB")]
		public bool setChlorophyte;

		// Token: 0x04003CCB RID: 15563
		[Token(Token = "0x4003CCB")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xAAC")]
		public bool setSquireT3;

		// Token: 0x04003CCC RID: 15564
		[Token(Token = "0x4003CCC")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xAAD")]
		public bool setHuntressT3;

		// Token: 0x04003CCD RID: 15565
		[Token(Token = "0x4003CCD")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xAAE")]
		public bool setApprenticeT3;

		// Token: 0x04003CCE RID: 15566
		[Token(Token = "0x4003CCE")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xAAF")]
		public bool setMonkT3;

		// Token: 0x04003CCF RID: 15567
		[Token(Token = "0x4003CCF")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xAB0")]
		public bool setSquireT2;

		// Token: 0x04003CD0 RID: 15568
		[Token(Token = "0x4003CD0")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xAB1")]
		public bool setHuntressT2;

		// Token: 0x04003CD1 RID: 15569
		[Token(Token = "0x4003CD1")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xAB2")]
		public bool setApprenticeT2;

		// Token: 0x04003CD2 RID: 15570
		[Token(Token = "0x4003CD2")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xAB3")]
		public bool setMonkT2;

		// Token: 0x04003CD3 RID: 15571
		[Token(Token = "0x4003CD3")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xAB4")]
		public int maxTurrets;

		// Token: 0x04003CD4 RID: 15572
		[Token(Token = "0x4003CD4")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xAB8")]
		public int maxTurretsOld;

		// Token: 0x04003CD5 RID: 15573
		[Token(Token = "0x4003CD5")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xABC")]
		public bool vortexStealthActive;

		// Token: 0x04003CD6 RID: 15574
		[Token(Token = "0x4003CD6")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xABD")]
		public bool hasClickPanOn;

		// Token: 0x04003CD7 RID: 15575
		[Token(Token = "0x4003CD7")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xABE")]
		public bool waterWalk;

		// Token: 0x04003CD8 RID: 15576
		[Token(Token = "0x4003CD8")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xABF")]
		public bool waterWalk2;

		// Token: 0x04003CD9 RID: 15577
		[Token(Token = "0x4003CD9")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xAC0")]
		public int forcedGravity;

		// Token: 0x04003CDA RID: 15578
		[Token(Token = "0x4003CDA")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xAC4")]
		public bool gravControl;

		// Token: 0x04003CDB RID: 15579
		[Token(Token = "0x4003CDB")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xAC5")]
		public bool gravControl2;

		// Token: 0x04003CDC RID: 15580
		[Token(Token = "0x4003CDC")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xAC8")]
		public Item honeyCombItem;

		// Token: 0x04003CDD RID: 15581
		[Token(Token = "0x4003CDD")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xACC")]
		public int wireOperationsCooldown;

		// Token: 0x04003CDE RID: 15582
		[Token(Token = "0x4003CDE")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xAD0")]
		public int lastChest;

		// Token: 0x04003CDF RID: 15583
		[Token(Token = "0x4003CDF")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xAD4")]
		public TrackedProjectileReference piggyBankProjTracker;

		// Token: 0x04003CE0 RID: 15584
		[Token(Token = "0x4003CE0")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xADC")]
		public List<int> interactableProjectiles;

		// Token: 0x04003CE1 RID: 15585
		[Token(Token = "0x4003CE1")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xAE0")]
		public TrackedProjectileReference voidLensChest;

		// Token: 0x04003CE2 RID: 15586
		[Token(Token = "0x4003CE2")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xAE8")]
		public int chest;

		// Token: 0x04003CE3 RID: 15587
		[Token(Token = "0x4003CE3")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xAEC")]
		public InventoryStorage chestStorage;

		// Token: 0x04003CE4 RID: 15588
		[Token(Token = "0x4003CE4")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xAF0")]
		public int chestX;

		// Token: 0x04003CE5 RID: 15589
		[Token(Token = "0x4003CE5")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xAF4")]
		public int chestY;

		// Token: 0x04003CE6 RID: 15590
		[Token(Token = "0x4003CE6")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xAF8")]
		public Player.eToHellAndBackStatus ToHellAndBackStatus;

		// Token: 0x04003CE7 RID: 15591
		[Token(Token = "0x4003CE7")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xAFC")]
		public int talkNPC;

		// Token: 0x04003CE8 RID: 15592
		[Token(Token = "0x4003CE8")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xB00")]
		public int fallStart;

		// Token: 0x04003CE9 RID: 15593
		[Token(Token = "0x4003CE9")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xB04")]
		public int fallStart2;

		// Token: 0x04003CEA RID: 15594
		[Token(Token = "0x4003CEA")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xB08")]
		public int potionDelayTime;

		// Token: 0x04003CEB RID: 15595
		[Token(Token = "0x4003CEB")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xB0C")]
		public int restorationDelayTime;

		// Token: 0x04003CEC RID: 15596
		[Token(Token = "0x4003CEC")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xB10")]
		public int eggnogDelayTime;

		// Token: 0x04003CED RID: 15597
		[Token(Token = "0x4003CED")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xB14")]
		public int mushroomDelayTime;

		// Token: 0x04003CEE RID: 15598
		[Token(Token = "0x4003CEE")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xB18")]
		private bool _batbatCanHeal;

		// Token: 0x04003CEF RID: 15599
		[Token(Token = "0x4003CEF")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xB19")]
		private bool _spawnTentacleSpikes;

		// Token: 0x04003CF0 RID: 15600
		[Token(Token = "0x4003CF0")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xB1A")]
		private bool _spawnBloodButcherer;

		// Token: 0x04003CF1 RID: 15601
		[Token(Token = "0x4003CF1")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xB1B")]
		private bool _spawnVolcanoExplosion;

		// Token: 0x04003CF2 RID: 15602
		[Token(Token = "0x4003CF2")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xB1C")]
		private bool _spawnMuramasaCut;

		// Token: 0x04003CF3 RID: 15603
		[Token(Token = "0x4003CF3")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xB20")]
		public PlayerPettingInfo petting;

		// Token: 0x04003CF4 RID: 15604
		[Token(Token = "0x4003CF4")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xB40")]
		public PlayerSittingHelper sitting;

		// Token: 0x04003CF5 RID: 15605
		[Token(Token = "0x4003CF5")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xB50")]
		public PlayerSleepingHelper sleeping;

		// Token: 0x04003CF6 RID: 15606
		[Token(Token = "0x4003CF6")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xB64")]
		public PlayerEyeHelper eyeHelper;

		// Token: 0x04003CF7 RID: 15607
		[Token(Token = "0x4003CF7")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xB70")]
		public PlayerInteractionAnchor tileEntityAnchor;

		// Token: 0x04003CF8 RID: 15608
		[Token(Token = "0x4003CF8")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xB7C")]
		public DoorOpeningHelper doorHelper;

		// Token: 0x04003CF9 RID: 15609
		[Token(Token = "0x4003CF9")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xB80")]
		public ShoppingSettings currentShoppingSettings;

		// Token: 0x04003CFA RID: 15610
		[Token(Token = "0x4003CFA")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xB88")]
		public int cHead;

		// Token: 0x04003CFB RID: 15611
		[Token(Token = "0x4003CFB")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xB8C")]
		public int cBody;

		// Token: 0x04003CFC RID: 15612
		[Token(Token = "0x4003CFC")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xB90")]
		public int cLegs;

		// Token: 0x04003CFD RID: 15613
		[Token(Token = "0x4003CFD")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xB94")]
		public int cHandOn;

		// Token: 0x04003CFE RID: 15614
		[Token(Token = "0x4003CFE")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xB98")]
		public int cHandOff;

		// Token: 0x04003CFF RID: 15615
		[Token(Token = "0x4003CFF")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xB9C")]
		public int cBack;

		// Token: 0x04003D00 RID: 15616
		[Token(Token = "0x4003D00")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xBA0")]
		public int cFront;

		// Token: 0x04003D01 RID: 15617
		[Token(Token = "0x4003D01")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xBA4")]
		public int cShoe;

		// Token: 0x04003D02 RID: 15618
		[Token(Token = "0x4003D02")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xBA8")]
		public int cWaist;

		// Token: 0x04003D03 RID: 15619
		[Token(Token = "0x4003D03")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xBAC")]
		public int cShield;

		// Token: 0x04003D04 RID: 15620
		[Token(Token = "0x4003D04")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xBB0")]
		public int cNeck;

		// Token: 0x04003D05 RID: 15621
		[Token(Token = "0x4003D05")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xBB4")]
		public int cFace;

		// Token: 0x04003D06 RID: 15622
		[Token(Token = "0x4003D06")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xBB8")]
		public int cFaceHead;

		// Token: 0x04003D07 RID: 15623
		[Token(Token = "0x4003D07")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xBBC")]
		public int cFaceFlower;

		// Token: 0x04003D08 RID: 15624
		[Token(Token = "0x4003D08")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xBC0")]
		public int cFaceMask;

		// Token: 0x04003D09 RID: 15625
		[Token(Token = "0x4003D09")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xBC4")]
		public int cBalloon;

		// Token: 0x04003D0A RID: 15626
		[Token(Token = "0x4003D0A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xBC8")]
		public int cBalloonFront;

		// Token: 0x04003D0B RID: 15627
		[Token(Token = "0x4003D0B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xBCC")]
		public int cWings;

		// Token: 0x04003D0C RID: 15628
		[Token(Token = "0x4003D0C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xBD0")]
		public int cCarpet;

		// Token: 0x04003D0D RID: 15629
		[Token(Token = "0x4003D0D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xBD4")]
		public int cFloatingTube;

		// Token: 0x04003D0E RID: 15630
		[Token(Token = "0x4003D0E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xBD8")]
		public int cBackpack;

		// Token: 0x04003D0F RID: 15631
		[Token(Token = "0x4003D0F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xBDC")]
		public int cTail;

		// Token: 0x04003D10 RID: 15632
		[Token(Token = "0x4003D10")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xBE0")]
		public int cShieldFallback;

		// Token: 0x04003D11 RID: 15633
		[Token(Token = "0x4003D11")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xBE4")]
		public int cGrapple;

		// Token: 0x04003D12 RID: 15634
		[Token(Token = "0x4003D12")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xBE8")]
		public int cMount;

		// Token: 0x04003D13 RID: 15635
		[Token(Token = "0x4003D13")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xBEC")]
		public int cMinecart;

		// Token: 0x04003D14 RID: 15636
		[Token(Token = "0x4003D14")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xBF0")]
		public int cPet;

		// Token: 0x04003D15 RID: 15637
		[Token(Token = "0x4003D15")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xBF4")]
		public int cLight;

		// Token: 0x04003D16 RID: 15638
		[Token(Token = "0x4003D16")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xBF8")]
		public int cYorai;

		// Token: 0x04003D17 RID: 15639
		[Token(Token = "0x4003D17")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xBFC")]
		public int cPortableStool;

		// Token: 0x04003D18 RID: 15640
		[Token(Token = "0x4003D18")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC00")]
		public int cUnicornHorn;

		// Token: 0x04003D19 RID: 15641
		[Token(Token = "0x4003D19")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC04")]
		public int cAngelHalo;

		// Token: 0x04003D1A RID: 15642
		[Token(Token = "0x4003D1A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC08")]
		public int cBeard;

		// Token: 0x04003D1B RID: 15643
		[Token(Token = "0x4003D1B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC0C")]
		public int cMinion;

		// Token: 0x04003D1C RID: 15644
		[Token(Token = "0x4003D1C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC10")]
		public int cLeinShampoo;

		// Token: 0x04003D1D RID: 15645
		[Token(Token = "0x4003D1D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC14")]
		public int cFlameWaker;

		// Token: 0x04003D1E RID: 15646
		[Token(Token = "0x4003D1E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC18")]
		public int cCoat;

		// Token: 0x04003D1F RID: 15647
		[Token(Token = "0x4003D1F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC1C")]
		public int[] ownedProjectileCounts;

		// Token: 0x04003D20 RID: 15648
		[Token(Token = "0x4003D20")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC20")]
		public bool[] npcTypeNoAggro;

		// Token: 0x04003D21 RID: 15649
		[Token(Token = "0x4003D21")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC24")]
		public int lastPortalColorIndex;

		// Token: 0x04003D22 RID: 15650
		[Token(Token = "0x4003D22")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC28")]
		public int _portalPhysicsTime;

		// Token: 0x04003D23 RID: 15651
		[Token(Token = "0x4003D23")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC2C")]
		public bool portalPhysicsFlag;

		// Token: 0x04003D24 RID: 15652
		[Token(Token = "0x4003D24")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC30")]
		public int lastTeleportPylonStyleUsed;

		// Token: 0x04003D25 RID: 15653
		[Token(Token = "0x4003D25")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC34")]
		public float MountFishronSpecialCounter;

		// Token: 0x04003D26 RID: 15654
		[Token(Token = "0x4003D26")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC38")]
		public Vector2 MinionRestTargetPoint;

		// Token: 0x04003D27 RID: 15655
		[Token(Token = "0x4003D27")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC40")]
		public int MinionAttackTargetNPC;

		// Token: 0x04003D28 RID: 15656
		[Token(Token = "0x4003D28")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private static MinionRespawner _localMinionRespawner;

		// Token: 0x04003D29 RID: 15657
		[Token(Token = "0x4003D29")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC44")]
		public List<Point> TouchedTiles;

		// Token: 0x04003D2A RID: 15658
		[Token(Token = "0x4003D2A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC48")]
		public int itemAnimation;

		// Token: 0x04003D2B RID: 15659
		[Token(Token = "0x4003D2B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC4C")]
		public int itemAnimationMax;

		// Token: 0x04003D2C RID: 15660
		[Token(Token = "0x4003D2C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC50")]
		public int itemTime;

		// Token: 0x04003D2D RID: 15661
		[Token(Token = "0x4003D2D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC54")]
		public int itemTimeMax;

		// Token: 0x04003D2E RID: 15662
		[Token(Token = "0x4003D2E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC58")]
		public int toolTime;

		// Token: 0x04003D2F RID: 15663
		[Token(Token = "0x4003D2F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static Item defaultItem;

		// Token: 0x04003D30 RID: 15664
		[Token(Token = "0x4003D30")]
		public const int SafeItemAnimationTimeForPreventingExploits = 20;

		// Token: 0x04003D31 RID: 15665
		[Token(Token = "0x4003D31")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC5C")]
		private Point FailedNoSpaceLocation;

		// Token: 0x04003D32 RID: 15666
		[Token(Token = "0x4003D32")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC64")]
		private int FailedNoSpaceCount;

		// Token: 0x04003D33 RID: 15667
		[Token(Token = "0x4003D33")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private static List<Point> QuickMinecartPts;

		// Token: 0x04003D34 RID: 15668
		[Token(Token = "0x4003D34")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC68")]
		private HashSet<Point> _blackListedTileCoordsForGrappling;

		// Token: 0x04003D35 RID: 15669
		[Token(Token = "0x4003D35")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC6C")]
		private bool makeStrongBee;

		// Token: 0x04003D36 RID: 15670
		[Token(Token = "0x4003D36")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC6D")]
		public bool equippedAnyTileRangeAcc;

		// Token: 0x04003D37 RID: 15671
		[Token(Token = "0x4003D37")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC6E")]
		public bool equippedAnyTileSpeedAcc;

		// Token: 0x04003D38 RID: 15672
		[Token(Token = "0x4003D38")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC6F")]
		public bool equippedAnyWallSpeedAcc;

		// Token: 0x04003D39 RID: 15673
		[Token(Token = "0x4003D39")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static List<NPC> _hallucinationCandidates;

		// Token: 0x04003D3A RID: 15674
		[Token(Token = "0x4003D3A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC70")]
		public bool behindBackWall;

		// Token: 0x04003D3B RID: 15675
		[Token(Token = "0x4003D3B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC74")]
		public int _funkytownAchievementCheckCooldown;

		// Token: 0x04003D3C RID: 15676
		[Token(Token = "0x4003D3C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public static int[] PetBuffs;

		// Token: 0x04003D3D RID: 15677
		[Token(Token = "0x4003D3D")]
		public const int ChairSittingMaxDistance = 40;

		// Token: 0x04003D3E RID: 15678
		[Token(Token = "0x4003D3E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC78")]
		private int _lastSmartCursorToolStrategy;

		// Token: 0x04003D3F RID: 15679
		[Token(Token = "0x4003D3F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC7C")]
		private bool[] nearbyTorch;

		// Token: 0x04003D40 RID: 15680
		[Token(Token = "0x4003D40")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC80")]
		private bool dryCoralTorch;

		// Token: 0x04003D41 RID: 15681
		[Token(Token = "0x4003D41")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC84")]
		private int luckyTorchCounter;

		// Token: 0x04003D42 RID: 15682
		[Token(Token = "0x4003D42")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC88")]
		private int nearbyTorches;

		// Token: 0x04003D43 RID: 15683
		[Token(Token = "0x4003D43")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC8C")]
		public float torchLuck;

		// Token: 0x04003D44 RID: 15684
		[Token(Token = "0x4003D44")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC90")]
		private Vector2 _nextTorchLuckCheckCenter;

		// Token: 0x04003D45 RID: 15685
		[Token(Token = "0x4003D45")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC98")]
		public bool happyFunTorchTime;

		// Token: 0x04003D46 RID: 15686
		[Token(Token = "0x4003D46")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC9C")]
		private int torchFunTimer;

		// Token: 0x04003D47 RID: 15687
		[Token(Token = "0x4003D47")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xCA0")]
		private int torchGodCooldown;

		// Token: 0x04003D48 RID: 15688
		[Token(Token = "0x4003D48")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xCA4")]
		private int numberOfTorchAttacksMade;

		// Token: 0x04003D49 RID: 15689
		[Token(Token = "0x4003D49")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static int maxTorchAttacks;

		// Token: 0x04003D4A RID: 15690
		[Token(Token = "0x4003D4A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xCA8")]
		private int[] unlitTorchX;

		// Token: 0x04003D4B RID: 15691
		[Token(Token = "0x4003D4B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xCAC")]
		private int[] unlitTorchY;

		// Token: 0x04003D4C RID: 15692
		[Token(Token = "0x4003D4C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xCB0")]
		public int ladyBugLuckTimeLeft;

		// Token: 0x04003D4D RID: 15693
		[Token(Token = "0x4003D4D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xCB4")]
		public float luck;

		// Token: 0x04003D4E RID: 15694
		[Token(Token = "0x4003D4E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xCB8")]
		public float luckMinimumCap;

		// Token: 0x04003D4F RID: 15695
		[Token(Token = "0x4003D4F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xCBC")]
		public float luckMaximumCap;

		// Token: 0x04003D50 RID: 15696
		[Token(Token = "0x4003D50")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xCC0")]
		public float coinLuck;

		// Token: 0x04003D51 RID: 15697
		[Token(Token = "0x4003D51")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xCC4")]
		public byte kiteLuckLevel;

		// Token: 0x04003D52 RID: 15698
		[Token(Token = "0x4003D52")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xCC5")]
		public bool luckNeedsSync;

		// Token: 0x04003D53 RID: 15699
		[Token(Token = "0x4003D53")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private static PlayerDeathReason _debuffsDamageTrackerSource;

		// Token: 0x04003D54 RID: 15700
		[Token(Token = "0x4003D54")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xCC8")]
		private Player.DashStartAction SolarDashStartAction;

		// Token: 0x04003D55 RID: 15701
		[Token(Token = "0x4003D55")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xCCC")]
		public int disableVoidBag;

		// Token: 0x04003D56 RID: 15702
		[Token(Token = "0x4003D56")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xCD0")]
		private int _quickGrappleCooldown;

		// Token: 0x04003D57 RID: 15703
		[Token(Token = "0x4003D57")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xCD4")]
		public PlayerMovementAccsCache movementAbilitiesCache;

		// Token: 0x04003D58 RID: 15704
		[Token(Token = "0x4003D58")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xCF0")]
		private bool wasScopeActionActive;

		// Token: 0x04003D59 RID: 15705
		[Token(Token = "0x4003D59")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static bool[] TouchCanAlterntiveFireAxis;

		// Token: 0x04003D5A RID: 15706
		[Token(Token = "0x4003D5A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private static bool[] ItemUsesRightFire;

		// Token: 0x04003D5B RID: 15707
		[Token(Token = "0x4003D5B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xCF1")]
		private bool UsingAlternativeFire;

		// Token: 0x04003D5C RID: 15708
		[Token(Token = "0x4003D5C")]
		private const int SunScorchGraceTime = 120;

		// Token: 0x04003D5D RID: 15709
		[Token(Token = "0x4003D5D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static readonly int UnbreakableWallRescanPeriod;

		// Token: 0x04003D5E RID: 15710
		[Token(Token = "0x4003D5E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private static readonly int UnbreakableWallRescanDistance;

		// Token: 0x04003D5F RID: 15711
		[Token(Token = "0x4003D5F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xCF4")]
		private int _unbreakableWallScanCooldown;

		// Token: 0x04003D60 RID: 15712
		[Token(Token = "0x4003D60")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xCF8")]
		private Vector2 _unbreakableWallScanLastPosition;

		// Token: 0x04003D61 RID: 15713
		[Token(Token = "0x4003D61")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xD00")]
		private SlotId _sizzleAudioHandle;

		// Token: 0x04003D62 RID: 15714
		[Token(Token = "0x4003D62")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xD04")]
		public float wingAccRunSpeed;

		// Token: 0x04003D63 RID: 15715
		[Token(Token = "0x4003D63")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xD08")]
		public float wingRunAccelerationMult;

		// Token: 0x04003D64 RID: 15716
		[Token(Token = "0x4003D64")]
		public const int SHIELD_PARRY_DURATION = 20;

		// Token: 0x04003D65 RID: 15717
		[Token(Token = "0x4003D65")]
		public const int SHIELD_PARRY_DURATION_DRAWING_TWEAKER = 20;

		// Token: 0x04003D66 RID: 15718
		[Token(Token = "0x4003D66")]
		public const int SHIELD_PARRY_DAMAGE_BUFF_MULTIPLIER = 5;

		// Token: 0x04003D67 RID: 15719
		[Token(Token = "0x4003D67")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xD0C")]
		public bool hasRaisableShield;

		// Token: 0x04003D68 RID: 15720
		[Token(Token = "0x4003D68")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xD0D")]
		public bool shieldRaised;

		// Token: 0x04003D69 RID: 15721
		[Token(Token = "0x4003D69")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xD10")]
		public int shieldParryTimeLeft;

		// Token: 0x04003D6A RID: 15722
		[Token(Token = "0x4003D6A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xD14")]
		public int shield_parry_cooldown;

		// Token: 0x04003D6B RID: 15723
		[Token(Token = "0x4003D6B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xD18")]
		private bool _forceForwardCursor;

		// Token: 0x04003D6C RID: 15724
		[Token(Token = "0x4003D6C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xD1C")]
		private Point _inputMouseCoordsForward;

		// Token: 0x04003D6D RID: 15725
		[Token(Token = "0x4003D6D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xD24")]
		private Point _mainMouseCoordsForward;

		// Token: 0x04003D6E RID: 15726
		[Token(Token = "0x4003D6E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xD2C")]
		private bool _forceSmartSelectCursor;

		// Token: 0x04003D6F RID: 15727
		[Token(Token = "0x4003D6F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xD30")]
		private Point _inputMouseCoordsSmartSelect;

		// Token: 0x04003D70 RID: 15728
		[Token(Token = "0x4003D70")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xD38")]
		private Point _mainMouseCoordsSmartSelect;

		// Token: 0x04003D71 RID: 15729
		[Token(Token = "0x4003D71")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xD40")]
		private Point _tileTargetSmartSelect;

		// Token: 0x04003D72 RID: 15730
		[Token(Token = "0x4003D72")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xD48")]
		private bool botherWithUnaimedMinecartTracks;

		// Token: 0x04003D73 RID: 15731
		[Token(Token = "0x4003D73")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xD4C")]
		private List<int> _projectilesToInteractWith;

		// Token: 0x04003D74 RID: 15732
		[Token(Token = "0x4003D74")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xD50")]
		private int _lockTileInteractionsTimer;

		// Token: 0x04003D75 RID: 15733
		[Token(Token = "0x4003D75")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static int backupCursorChestItemIconID;

		// Token: 0x04003D76 RID: 15734
		[Token(Token = "0x4003D76")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private static bool backupCursorItemIconEnabled;

		// Token: 0x04003D77 RID: 15735
		[Token(Token = "0x4003D77")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static int backupCursorItemIconID;

		// Token: 0x04003D78 RID: 15736
		[Token(Token = "0x4003D78")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private static string backupSursorItemIconText;

		// Token: 0x04003D79 RID: 15737
		[Token(Token = "0x4003D79")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private static int backupCursorItemIconPush;

		// Token: 0x04003D7A RID: 15738
		[Token(Token = "0x4003D7A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private static int backupSignHover;

		// Token: 0x04003D7B RID: 15739
		[Token(Token = "0x4003D7B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private static int backupTileTargetX;

		// Token: 0x04003D7C RID: 15740
		[Token(Token = "0x4003D7C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private static int backupTileTargetY;

		// Token: 0x04003D7D RID: 15741
		[Token(Token = "0x4003D7D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xD54")]
		private bool extractinateHover;

		// Token: 0x04003D7E RID: 15742
		[Token(Token = "0x4003D7E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xD58")]
		public int hoveredChestIndex;

		// Token: 0x04003D7F RID: 15743
		[Token(Token = "0x4003D7F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private static Item[] costInventory;

		// Token: 0x04003D80 RID: 15744
		[Token(Token = "0x4003D80")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private static Item[] costBankInventory;

		// Token: 0x04003D81 RID: 15745
		[Token(Token = "0x4003D81")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private static Item[] costBank2Inventory;

		// Token: 0x04003D82 RID: 15746
		[Token(Token = "0x4003D82")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private static Item[] costBank3Inventory;

		// Token: 0x04003D83 RID: 15747
		[Token(Token = "0x4003D83")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private static Item[] costBank4Inventory;

		// Token: 0x04003D84 RID: 15748
		[Token(Token = "0x4003D84")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		public static float DisplayLegFrameCounter;

		// Token: 0x04003D85 RID: 15749
		[Token(Token = "0x4003D85")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public static int DisplayLegFrameIndex;

		// Token: 0x04003D86 RID: 15750
		[Token(Token = "0x4003D86")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xD5C")]
		public int[] hurtCooldowns;

		// Token: 0x04003D87 RID: 15751
		[Token(Token = "0x4003D87")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		public static PlayerGetItemLogger GetItemLogger;

		// Token: 0x04003D88 RID: 15752
		[Token(Token = "0x4003D88")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public static int FlexibleWandRandomSeed;

		// Token: 0x04003D89 RID: 15753
		[Token(Token = "0x4003D89")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		public static int FlexibleWandCycleOffset;

		// Token: 0x04003D8A RID: 15754
		[Token(Token = "0x4003D8A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public static Point FlexibleWandLastPosition;

		// Token: 0x04003D8B RID: 15755
		[Token(Token = "0x4003D8B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xD60")]
		private ushort cannonCooldown;

		// Token: 0x04003D8C RID: 15756
		[Token(Token = "0x4003D8C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xD64")]
		public int framesInMovementForPlacementPreview;

		// Token: 0x04003D8D RID: 15757
		[Token(Token = "0x4003D8D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private static Point[] _tentacleSpikesMax5;

		// Token: 0x04003D8E RID: 15758
		[Token(Token = "0x4003D8E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private static Point[] _bloodButchererMax5;

		// Token: 0x04003D8F RID: 15759
		[Token(Token = "0x4003D8F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xD68")]
		public int[] meleeNPCHitCooldown;

		// Token: 0x04003D90 RID: 15760
		[Token(Token = "0x4003D90")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xD6C")]
		public float musicDist;

		// Token: 0x04003D91 RID: 15761
		[Token(Token = "0x4003D91")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xD70")]
		private int killingCardFireType;

		// Token: 0x04003D92 RID: 15762
		[Token(Token = "0x4003D92")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private static List<Item> _pickAmmo_foundAmmo;

		// Token: 0x04003D93 RID: 15763
		[Token(Token = "0x4003D93")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		private static readonly int[] AmmoSlotOrder_Default;

		// Token: 0x04003D94 RID: 15764
		[Token(Token = "0x4003D94")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private static readonly int[] AmmoSlotOrder_AmmoOnly;

		// Token: 0x04003D95 RID: 15765
		[Token(Token = "0x4003D95")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		private static readonly int[] AmmoSlotOrder_CoinsOnly;

		// Token: 0x04003D96 RID: 15766
		[Token(Token = "0x4003D96")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xD74")]
		public EquipmentLoadout[] Loadouts;

		// Token: 0x04003D97 RID: 15767
		[Token(Token = "0x4003D97")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xD78")]
		public int CurrentLoadoutIndex;

		// Token: 0x04003D98 RID: 15768
		[Token(Token = "0x4003D98")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xD7C")]
		public HashSet<string> oneTimeDialoguesSeen;

		// Token: 0x04003D99 RID: 15769
		[Token(Token = "0x4003D99")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xD80")]
		public Player.SavedPlayerDataWithAnnoyingRules savedPerPlayerFieldsThatArentInThePlayerClass;

		// Token: 0x04003D9A RID: 15770
		[Token(Token = "0x4003D9A")]
		private const int SaveSlotIndex_MouseItem = 0;

		// Token: 0x04003D9B RID: 15771
		[Token(Token = "0x4003D9B")]
		private const int SaveSlotIndex_CreativeSacrifice = 1;

		// Token: 0x04003D9C RID: 15772
		[Token(Token = "0x4003D9C")]
		private const int SaveSlotIndex_GuideItem = 2;

		// Token: 0x04003D9D RID: 15773
		[Token(Token = "0x4003D9D")]
		private const int SaveSlotIndex_TinkererItem = 3;

		// Token: 0x04003D9E RID: 15774
		[Token(Token = "0x4003D9E")]
		private const int SaveSlotIndexCount = 4;

		// Token: 0x04003D9F RID: 15775
		[Token(Token = "0x4003D9F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xD84")]
		private Item[] _temporaryItemSlots;

		// Token: 0x04003DA0 RID: 15776
		[Token(Token = "0x4003DA0")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xD88")]
		private Item[] _pendingRefunds;

		// Token: 0x0200048A RID: 1162
		[Token(Token = "0x200048A")]
		public class SmartCursorSettings
		{
			// Token: 0x170005EE RID: 1518
			// (get) Token: 0x06002C75 RID: 11381 RVA: 0x00015888 File Offset: 0x00013A88
			// (set) Token: 0x06002C76 RID: 11382 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170005EE")]
			public static bool SmartBlocksEnabled
			{
				[Token(Token = "0x6002C75")]
				[Address(RVA = "0x160C2A0", Offset = "0x160C2A0", VA = "0x160C2A0")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6002C76")]
				[Address(RVA = "0x160C308", Offset = "0x160C308", VA = "0x160C308")]
				set
				{
				}
			}

			// Token: 0x170005EF RID: 1519
			// (get) Token: 0x06002C77 RID: 11383 RVA: 0x000158A0 File Offset: 0x00013AA0
			// (set) Token: 0x06002C78 RID: 11384 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170005EF")]
			public static bool SmartAxeAfterPickaxe
			{
				[Token(Token = "0x6002C77")]
				[Address(RVA = "0x160C374", Offset = "0x160C374", VA = "0x160C374")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6002C78")]
				[Address(RVA = "0x160C3DC", Offset = "0x160C3DC", VA = "0x160C3DC")]
				set
				{
				}
			}

			// Token: 0x06002C79 RID: 11385 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002C79")]
			[Address(RVA = "0x160C448", Offset = "0x160C448", VA = "0x160C448")]
			public SmartCursorSettings()
			{
			}
		}

		// Token: 0x0200048B RID: 1163
		[Token(Token = "0x200048B")]
		public class Settings
		{
			// Token: 0x170005F0 RID: 1520
			// (get) Token: 0x06002C7A RID: 11386 RVA: 0x000158B8 File Offset: 0x00013AB8
			// (set) Token: 0x06002C7B RID: 11387 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170005F0")]
			public static Player.Settings.StackToNearbyChestsdMode StackToChestsPreferredMode
			{
				[Token(Token = "0x6002C7A")]
				[Address(RVA = "0x160C450", Offset = "0x160C450", VA = "0x160C450")]
				get
				{
					return Player.Settings.StackToNearbyChestsdMode.QuickStackToNearbyChests;
				}
				[Token(Token = "0x6002C7B")]
				[Address(RVA = "0x160C4B8", Offset = "0x160C4B8", VA = "0x160C4B8")]
				set
				{
				}
			}

			// Token: 0x06002C7C RID: 11388 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002C7C")]
			[Address(RVA = "0x160C524", Offset = "0x160C524", VA = "0x160C524")]
			public static void CycleQuickStackMode()
			{
			}

			// Token: 0x170005F1 RID: 1521
			// (get) Token: 0x06002C7D RID: 11389 RVA: 0x000158D0 File Offset: 0x00013AD0
			// (set) Token: 0x06002C7E RID: 11390 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170005F1")]
			public static bool CraftFromNearbyChests
			{
				[Token(Token = "0x6002C7D")]
				[Address(RVA = "0x160C634", Offset = "0x160C634", VA = "0x160C634")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6002C7E")]
				[Address(RVA = "0x160C69C", Offset = "0x160C69C", VA = "0x160C69C")]
				set
				{
				}
			}

			// Token: 0x06002C7F RID: 11391 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002C7F")]
			[Address(RVA = "0x160C708", Offset = "0x160C708", VA = "0x160C708")]
			public static void CycleHoverControl()
			{
			}

			// Token: 0x170005F2 RID: 1522
			// (get) Token: 0x06002C80 RID: 11392 RVA: 0x000158E8 File Offset: 0x00013AE8
			// (set) Token: 0x06002C81 RID: 11393 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170005F2")]
			public static Player.Settings.DashPreference DashControl
			{
				[Token(Token = "0x6002C80")]
				[Address(RVA = "0x160C77C", Offset = "0x160C77C", VA = "0x160C77C")]
				get
				{
					return Player.Settings.DashPreference.AllowDoubleTap;
				}
				[Token(Token = "0x6002C81")]
				[Address(RVA = "0x160C7E4", Offset = "0x160C7E4", VA = "0x160C7E4")]
				set
				{
				}
			}

			// Token: 0x170005F3 RID: 1523
			// (get) Token: 0x06002C82 RID: 11394 RVA: 0x00015900 File Offset: 0x00013B00
			// (set) Token: 0x06002C83 RID: 11395 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170005F3")]
			public static Player.Settings.DashPreference ArmorAbilityControl
			{
				[Token(Token = "0x6002C82")]
				[Address(RVA = "0x160C850", Offset = "0x160C850", VA = "0x160C850")]
				get
				{
					return Player.Settings.DashPreference.AllowDoubleTap;
				}
				[Token(Token = "0x6002C83")]
				[Address(RVA = "0x160C8B8", Offset = "0x160C8B8", VA = "0x160C8B8")]
				set
				{
				}
			}

			// Token: 0x170005F4 RID: 1524
			// (get) Token: 0x06002C84 RID: 11396 RVA: 0x00015918 File Offset: 0x00013B18
			// (set) Token: 0x06002C85 RID: 11397 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170005F4")]
			public static bool ShowLoadoutShareHint
			{
				[Token(Token = "0x6002C84")]
				[Address(RVA = "0x160C924", Offset = "0x160C924", VA = "0x160C924")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6002C85")]
				[Address(RVA = "0x160C98C", Offset = "0x160C98C", VA = "0x160C98C")]
				set
				{
				}
			}

			// Token: 0x06002C86 RID: 11398 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002C86")]
			[Address(RVA = "0x160C9F8", Offset = "0x160C9F8", VA = "0x160C9F8")]
			public static void DisableLoadoutShareHint()
			{
			}

			// Token: 0x06002C87 RID: 11399 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002C87")]
			[Address(RVA = "0x160CB0C", Offset = "0x160CB0C", VA = "0x160CB0C")]
			public Settings()
			{
			}

			// Token: 0x04003DA1 RID: 15777
			[Token(Token = "0x4003DA1")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static Player.Settings.HoverControlMode HoverControl;

			// Token: 0x04003DA2 RID: 15778
			[Token(Token = "0x4003DA2")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public static Player.Settings.CraftingGridMode CraftingGridControl;

			// Token: 0x0200048C RID: 1164
			[Token(Token = "0x200048C")]
			public enum StackToNearbyChestsdMode : byte
			{
				// Token: 0x04003DA4 RID: 15780
				[Token(Token = "0x4003DA4")]
				QuickStackToNearbyChests,
				// Token: 0x04003DA5 RID: 15781
				[Token(Token = "0x4003DA5")]
				SmartStackToNearbyChests
			}

			// Token: 0x0200048D RID: 1165
			[Token(Token = "0x200048D")]
			public enum HoverControlMode
			{
				// Token: 0x04003DA7 RID: 15783
				[Token(Token = "0x4003DA7")]
				Hold,
				// Token: 0x04003DA8 RID: 15784
				[Token(Token = "0x4003DA8")]
				Click
			}

			// Token: 0x0200048E RID: 1166
			[Token(Token = "0x200048E")]
			public enum CraftingGridMode
			{
				// Token: 0x04003DAA RID: 15786
				[Token(Token = "0x4003DAA")]
				Modern,
				// Token: 0x04003DAB RID: 15787
				[Token(Token = "0x4003DAB")]
				Classic
			}

			// Token: 0x0200048F RID: 1167
			[Token(Token = "0x200048F")]
			public enum DashPreference
			{
				// Token: 0x04003DAD RID: 15789
				[Token(Token = "0x4003DAD")]
				AllowDoubleTap,
				// Token: 0x04003DAE RID: 15790
				[Token(Token = "0x4003DAE")]
				OnlyThroughHotkeys
			}
		}

		// Token: 0x02000490 RID: 1168
		[Token(Token = "0x2000490")]
		public static class BuilderAccToggleIDs
		{
			// Token: 0x04003DAF RID: 15791
			[Token(Token = "0x4003DAF")]
			public const int RulerLine = 0;

			// Token: 0x04003DB0 RID: 15792
			[Token(Token = "0x4003DB0")]
			public const int RulerGrid = 1;

			// Token: 0x04003DB1 RID: 15793
			[Token(Token = "0x4003DB1")]
			public const int AutoActuate = 2;

			// Token: 0x04003DB2 RID: 15794
			[Token(Token = "0x4003DB2")]
			public const int AutoPaint = 3;

			// Token: 0x04003DB3 RID: 15795
			[Token(Token = "0x4003DB3")]
			public const int WireVisibility_Red = 4;

			// Token: 0x04003DB4 RID: 15796
			[Token(Token = "0x4003DB4")]
			public const int WireVisibility_Green = 5;

			// Token: 0x04003DB5 RID: 15797
			[Token(Token = "0x4003DB5")]
			public const int WireVisibility_Blue = 6;

			// Token: 0x04003DB6 RID: 15798
			[Token(Token = "0x4003DB6")]
			public const int WireVisibility_Yellow = 7;

			// Token: 0x04003DB7 RID: 15799
			[Token(Token = "0x4003DB7")]
			public const int HideAllWires = 8;

			// Token: 0x04003DB8 RID: 15800
			[Token(Token = "0x4003DB8")]
			public const int WireVisibility_Actuators = 9;

			// Token: 0x04003DB9 RID: 15801
			[Token(Token = "0x4003DB9")]
			public const int BlockSwap = 10;

			// Token: 0x04003DBA RID: 15802
			[Token(Token = "0x4003DBA")]
			public const int TorchBiome = 11;

			// Token: 0x04003DBB RID: 15803
			[Token(Token = "0x4003DBB")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly int Count;
		}

		// Token: 0x02000491 RID: 1169
		[Token(Token = "0x2000491")]
		public struct PlayerInputSyncCache
		{
			// Token: 0x170005F5 RID: 1525
			// (get) Token: 0x06002C89 RID: 11401 RVA: 0x00015930 File Offset: 0x00013B30
			[Token(Token = "0x170005F5")]
			public bool PressingAnyInput
			{
				[Token(Token = "0x6002C89")]
				[Address(RVA = "0x160CB68", Offset = "0x160CB68", VA = "0x160CB68")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06002C8A RID: 11402 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002C8A")]
			[Address(RVA = "0x160CBAC", Offset = "0x160CBAC", VA = "0x160CBAC")]
			public PlayerInputSyncCache(Player player)
			{
			}

			// Token: 0x04003DBC RID: 15804
			[Token(Token = "0x4003DBC")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool controlLeft;

			// Token: 0x04003DBD RID: 15805
			[Token(Token = "0x4003DBD")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x1")]
			public bool controlRight;

			// Token: 0x04003DBE RID: 15806
			[Token(Token = "0x4003DBE")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x2")]
			public bool controlUp;

			// Token: 0x04003DBF RID: 15807
			[Token(Token = "0x4003DBF")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x3")]
			public bool controlDown;

			// Token: 0x04003DC0 RID: 15808
			[Token(Token = "0x4003DC0")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public bool controlJump;
		}

		// Token: 0x02000492 RID: 1170
		[Token(Token = "0x2000492")]
		private struct ChannelCancelKey
		{
			// Token: 0x06002C8B RID: 11403 RVA: 0x00015948 File Offset: 0x00013B48
			[Token(Token = "0x6002C8B")]
			[Address(RVA = "0x160CC34", Offset = "0x160CC34", VA = "0x160CC34")]
			public bool Matches(Projectile projectile)
			{
				return default(bool);
			}

			// Token: 0x06002C8C RID: 11404 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002C8C")]
			[Address(RVA = "0x160CCAC", Offset = "0x160CCAC", VA = "0x160CCAC")]
			public void TryTracking(Projectile projectile)
			{
			}

			// Token: 0x04003DC1 RID: 15809
			[Token(Token = "0x4003DC1")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int ProjectileTypeExpected;

			// Token: 0x04003DC2 RID: 15810
			[Token(Token = "0x4003DC2")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public int ProjectileIndexExpected;
		}

		// Token: 0x02000493 RID: 1171
		[Token(Token = "0x2000493")]
		public struct RabbitOrderFrameHelper
		{
			// Token: 0x06002C8D RID: 11405 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002C8D")]
			[Address(RVA = "0x160CCDC", Offset = "0x160CCDC", VA = "0x160CCDC")]
			public void Update()
			{
			}

			// Token: 0x06002C8E RID: 11406 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002C8E")]
			[Address(RVA = "0x160CF18", Offset = "0x160CF18", VA = "0x160CF18")]
			public void Reset()
			{
			}

			// Token: 0x06002C8F RID: 11407 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002C8F")]
			[Address(RVA = "0x160CF28", Offset = "0x160CF28", VA = "0x160CF28")]
			private void ChangeToAIState(int aiState)
			{
			}

			// Token: 0x06002C90 RID: 11408 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002C90")]
			[Address(RVA = "0x160CE3C", Offset = "0x160CE3C", VA = "0x160CE3C")]
			private void UpdateFrame(int displayFrameMin, int displayFrameMax, int exitAIState, int gameFramesPerDisplayFrame)
			{
			}

			// Token: 0x04003DC3 RID: 15811
			[Token(Token = "0x4003DC3")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int DisplayFrame;

			// Token: 0x04003DC4 RID: 15812
			[Token(Token = "0x4003DC4")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			private int _frameCounter;

			// Token: 0x04003DC5 RID: 15813
			[Token(Token = "0x4003DC5")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private int _aiState;

			// Token: 0x04003DC6 RID: 15814
			[Token(Token = "0x4003DC6")]
			private const int AIState_Idle = 0;

			// Token: 0x04003DC7 RID: 15815
			[Token(Token = "0x4003DC7")]
			private const int AIState_LookingAtCamera = 1;

			// Token: 0x04003DC8 RID: 15816
			[Token(Token = "0x4003DC8")]
			private const int AIState_Resting = 2;

			// Token: 0x04003DC9 RID: 15817
			[Token(Token = "0x4003DC9")]
			private const int AIState_EatingCarrot = 3;
		}

		// Token: 0x02000494 RID: 1172
		[Token(Token = "0x2000494")]
		public enum CompositeArmStretchAmount
		{
			// Token: 0x04003DCB RID: 15819
			[Token(Token = "0x4003DCB")]
			Full,
			// Token: 0x04003DCC RID: 15820
			[Token(Token = "0x4003DCC")]
			None,
			// Token: 0x04003DCD RID: 15821
			[Token(Token = "0x4003DCD")]
			Quarter,
			// Token: 0x04003DCE RID: 15822
			[Token(Token = "0x4003DCE")]
			ThreeQuarters
		}

		// Token: 0x02000495 RID: 1173
		[Token(Token = "0x2000495")]
		public struct CompositeArmData
		{
			// Token: 0x06002C91 RID: 11409 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002C91")]
			[Address(RVA = "0x160CF38", Offset = "0x160CF38", VA = "0x160CF38")]
			public CompositeArmData(bool enabled, Player.CompositeArmStretchAmount intendedStrech, float rotation)
			{
			}

			// Token: 0x04003DCF RID: 15823
			[Token(Token = "0x4003DCF")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool enabled;

			// Token: 0x04003DD0 RID: 15824
			[Token(Token = "0x4003DD0")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public Player.CompositeArmStretchAmount stretch;

			// Token: 0x04003DD1 RID: 15825
			[Token(Token = "0x4003DD1")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public float rotation;
		}

		// Token: 0x02000496 RID: 1174
		[Token(Token = "0x2000496")]
		public enum eToHellAndBackStatus
		{
			// Token: 0x04003DD3 RID: 15827
			[Token(Token = "0x4003DD3")]
			NotStarted,
			// Token: 0x04003DD4 RID: 15828
			[Token(Token = "0x4003DD4")]
			SurfaceToHell,
			// Token: 0x04003DD5 RID: 15829
			[Token(Token = "0x4003DD5")]
			HellToSurface,
			// Token: 0x04003DD6 RID: 15830
			[Token(Token = "0x4003DD6")]
			Completed
		}

		// Token: 0x02000497 RID: 1175
		// (Invoke) Token: 0x06002C93 RID: 11411
		[Token(Token = "0x2000497")]
		public delegate void DashStartAction(int dashDirection);

		// Token: 0x02000498 RID: 1176
		[Token(Token = "0x2000498")]
		public struct SetMatchRequest
		{
			// Token: 0x04003DD7 RID: 15831
			[Token(Token = "0x4003DD7")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Player Player;

			// Token: 0x04003DD8 RID: 15832
			[Token(Token = "0x4003DD8")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public int Head;

			// Token: 0x04003DD9 RID: 15833
			[Token(Token = "0x4003DD9")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public int Body;

			// Token: 0x04003DDA RID: 15834
			[Token(Token = "0x4003DDA")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public int Legs;

			// Token: 0x04003DDB RID: 15835
			[Token(Token = "0x4003DDB")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int ArmorSlotRequested;

			// Token: 0x04003DDC RID: 15836
			[Token(Token = "0x4003DDC")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public bool Male;
		}

		// Token: 0x02000499 RID: 1177
		[Token(Token = "0x2000499")]
		public struct ItemSpaceStatus
		{
			// Token: 0x170005F6 RID: 1526
			// (get) Token: 0x06002C96 RID: 11414 RVA: 0x00015960 File Offset: 0x00013B60
			[Token(Token = "0x170005F6")]
			public bool CanTakeItemToPersonalInventory
			{
				[Token(Token = "0x6002C96")]
				[Address(RVA = "0x160D0C8", Offset = "0x160D0C8", VA = "0x160D0C8")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06002C97 RID: 11415 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002C97")]
			[Address(RVA = "0x160D0E4", Offset = "0x160D0E4", VA = "0x160D0E4")]
			public ItemSpaceStatus(bool CanTakeItem = false, bool ItemIsGoingToVoidVault = false)
			{
			}

			// Token: 0x06002C98 RID: 11416 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002C98")]
			[Address(RVA = "0x160D0F0", Offset = "0x160D0F0", VA = "0x160D0F0")]
			public void Set(bool CanTakeItem, bool ItemIsGoingToVoidVault = false)
			{
			}

			// Token: 0x04003DDD RID: 15837
			[Token(Token = "0x4003DDD")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool CanTakeItem;

			// Token: 0x04003DDE RID: 15838
			[Token(Token = "0x4003DDE")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x1")]
			public bool ItemIsGoingToVoidVault;
		}

		// Token: 0x0200049A RID: 1178
		[Token(Token = "0x200049A")]
		public struct ItemCheckContext
		{
			// Token: 0x04003DDF RID: 15839
			[Token(Token = "0x4003DDF")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool SkipItemConsumption;
		}

		// Token: 0x0200049B RID: 1179
		[Token(Token = "0x200049B")]
		private struct SpecialToolUsageSettings
		{
			// Token: 0x04003DE0 RID: 15840
			[Token(Token = "0x4003DE0")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool IsAValidTool;

			// Token: 0x04003DE1 RID: 15841
			[Token(Token = "0x4003DE1")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public Player.SpecialToolUsageSettings.CanUseToolCondition UsageCondition;

			// Token: 0x04003DE2 RID: 15842
			[Token(Token = "0x4003DE2")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Player.SpecialToolUsageSettings.UseToolAction UsageAction;

			// Token: 0x0200049C RID: 1180
			// (Invoke) Token: 0x06002C9A RID: 11418
			[Token(Token = "0x200049C")]
			public delegate bool CanUseToolCondition(Player user, Item item, int targetX, int targetY);

			// Token: 0x0200049D RID: 1181
			// (Invoke) Token: 0x06002C9E RID: 11422
			[Token(Token = "0x200049D")]
			public delegate void UseToolAction(Player user, Item item, int targetX, int targetY);
		}

		// Token: 0x0200049E RID: 1182
		[Token(Token = "0x200049E")]
		public class SavedPlayerDataWithAnnoyingRules
		{
			// Token: 0x06002CA1 RID: 11425 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002CA1")]
			[Address(RVA = "0x160D5A8", Offset = "0x160D5A8", VA = "0x160D5A8")]
			public SavedPlayerDataWithAnnoyingRules()
			{
			}

			// Token: 0x04003DE3 RID: 15843
			[Token(Token = "0x4003DE3")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public bool godmodePowerEnabled;

			// Token: 0x04003DE4 RID: 15844
			[Token(Token = "0x4003DE4")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x9")]
			public bool farPlacementRangePowerEnabled;

			// Token: 0x04003DE5 RID: 15845
			[Token(Token = "0x4003DE5")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public float spawnRatePowerSliderValue;
		}

		// Token: 0x0200049F RID: 1183
		[Token(Token = "0x200049F")]
		public static class Hooks
		{
			// Token: 0x1400002B RID: 43
			// (add) Token: 0x06002CA2 RID: 11426 RVA: 0x00002053 File Offset: 0x00000253
			// (remove) Token: 0x06002CA3 RID: 11427 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1400002B")]
			public static event Action<Player> OnEnterWorld
			{
				[Token(Token = "0x6002CA2")]
				[Address(RVA = "0x160D5B0", Offset = "0x160D5B0", VA = "0x160D5B0")]
				add
				{
				}
				[Token(Token = "0x6002CA3")]
				[Address(RVA = "0x160D68C", Offset = "0x160D68C", VA = "0x160D68C")]
				remove
				{
				}
			}

			// Token: 0x06002CA4 RID: 11428 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002CA4")]
			[Address(RVA = "0x160D768", Offset = "0x160D768", VA = "0x160D768")]
			public static void PlayerConnect(int playerIndex)
			{
			}

			// Token: 0x06002CA5 RID: 11429 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002CA5")]
			[Address(RVA = "0x160D7D0", Offset = "0x160D7D0", VA = "0x160D7D0")]
			public static void PlayerDisconnect(int playerIndex)
			{
			}

			// Token: 0x06002CA6 RID: 11430 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002CA6")]
			[Address(RVA = "0x160D8A0", Offset = "0x160D8A0", VA = "0x160D8A0")]
			public static void EnterWorld(int playerIndex)
			{
			}
		}

		// Token: 0x020004A0 RID: 1184
		[Token(Token = "0x20004A0")]
		public struct SelectedItemState
		{
			// Token: 0x06002CA7 RID: 11431 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002CA7")]
			[Address(RVA = "0x160DAB0", Offset = "0x160DAB0", VA = "0x160DAB0")]
			public SelectedItemState(Player player)
			{
			}

			// Token: 0x170005F7 RID: 1527
			// (get) Token: 0x06002CA8 RID: 11432 RVA: 0x00015978 File Offset: 0x00013B78
			[Token(Token = "0x170005F7")]
			public bool CanChangeSelectedItemImmediately
			{
				[Token(Token = "0x6002CA8")]
				[Address(RVA = "0x160DAE0", Offset = "0x160DAE0", VA = "0x160DAE0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170005F8 RID: 1528
			// (get) Token: 0x06002CA9 RID: 11433 RVA: 0x00015990 File Offset: 0x00013B90
			[Token(Token = "0x170005F8")]
			public int Selected
			{
				[Token(Token = "0x6002CA9")]
				[Address(RVA = "0x160DB34", Offset = "0x160DB34", VA = "0x160DB34")]
				get
				{
					return 0;
				}
			}

			// Token: 0x170005F9 RID: 1529
			// (get) Token: 0x06002CAA RID: 11434 RVA: 0x000159A8 File Offset: 0x00013BA8
			[Token(Token = "0x170005F9")]
			public int Hotbar
			{
				[Token(Token = "0x6002CAA")]
				[Address(RVA = "0x160DB3C", Offset = "0x160DB3C", VA = "0x160DB3C")]
				get
				{
					return 0;
				}
			}

			// Token: 0x170005FA RID: 1530
			// (get) Token: 0x06002CAB RID: 11435 RVA: 0x000159C0 File Offset: 0x00013BC0
			[Token(Token = "0x170005FA")]
			public bool HasActiveOverride
			{
				[Token(Token = "0x6002CAB")]
				[Address(RVA = "0x160DB44", Offset = "0x160DB44", VA = "0x160DB44")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170005FB RID: 1531
			// (get) Token: 0x06002CAC RID: 11436 RVA: 0x000159D8 File Offset: 0x00013BD8
			[Token(Token = "0x170005FB")]
			public bool HasBufferedChange
			{
				[Token(Token = "0x6002CAC")]
				[Address(RVA = "0x160DB54", Offset = "0x160DB54", VA = "0x160DB54")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170005FC RID: 1532
			// (get) Token: 0x06002CAD RID: 11437 RVA: 0x000159F0 File Offset: 0x00013BF0
			[Token(Token = "0x170005FC")]
			public int LastNonOverridenSelection
			{
				[Token(Token = "0x6002CAD")]
				[Address(RVA = "0x160DB64", Offset = "0x160DB64", VA = "0x160DB64")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06002CAE RID: 11438 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002CAE")]
			[Address(RVA = "0x160DB90", Offset = "0x160DB90", VA = "0x160DB90")]
			private void OverrideSelection(int item)
			{
			}

			// Token: 0x06002CAF RID: 11439 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002CAF")]
			[Address(RVA = "0x160DC18", Offset = "0x160DC18", VA = "0x160DC18")]
			public void Select(int item)
			{
			}

			// Token: 0x06002CB0 RID: 11440 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002CB0")]
			[Address(RVA = "0x160DD44", Offset = "0x160DD44", VA = "0x160DD44")]
			public void Update()
			{
			}

			// Token: 0x06002CB1 RID: 11441 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002CB1")]
			[Address(RVA = "0x160DF0C", Offset = "0x160DF0C", VA = "0x160DF0C")]
			private void OnSelectionChanged(bool continueAutoReuseWithNewItem)
			{
			}

			// Token: 0x04003DE7 RID: 15847
			[Token(Token = "0x4003DE7")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private readonly Player player;

			// Token: 0x04003DE8 RID: 15848
			[Token(Token = "0x4003DE8")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public int selected;

			// Token: 0x04003DE9 RID: 15849
			[Token(Token = "0x4003DE9")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private int hotbar;

			// Token: 0x04003DEA RID: 15850
			[Token(Token = "0x4003DEA")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			private int buffered;

			// Token: 0x04003DEB RID: 15851
			[Token(Token = "0x4003DEB")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int overridden;
		}

		// Token: 0x020004A1 RID: 1185
		[Token(Token = "0x20004A1")]
		public class SelectionRadial
		{
			// Token: 0x170005FD RID: 1533
			// (get) Token: 0x06002CB2 RID: 11442 RVA: 0x00015A08 File Offset: 0x00013C08
			[Token(Token = "0x170005FD")]
			public int SelectedBinding
			{
				[Token(Token = "0x6002CB2")]
				[Address(RVA = "0x160E040", Offset = "0x160E040", VA = "0x160E040")]
				get
				{
					return 0;
				}
			}

			// Token: 0x170005FE RID: 1534
			// (get) Token: 0x06002CB3 RID: 11443 RVA: 0x00015A20 File Offset: 0x00013C20
			[Token(Token = "0x170005FE")]
			public int SelectedItem
			{
				[Token(Token = "0x6002CB3")]
				[Address(RVA = "0x160E048", Offset = "0x160E048", VA = "0x160E048")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06002CB4 RID: 11444 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002CB4")]
			[Address(RVA = "0x160E1D0", Offset = "0x160E1D0", VA = "0x160E1D0")]
			public void LoadNPCHeldItem(int heldItem)
			{
			}

			// Token: 0x06002CB5 RID: 11445 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002CB5")]
			[Address(RVA = "0x160E1E0", Offset = "0x160E1E0", VA = "0x160E1E0")]
			public void LoadScryingItem(int heldItem)
			{
			}

			// Token: 0x06002CB6 RID: 11446 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002CB6")]
			[Address(RVA = "0x160E1F0", Offset = "0x160E1F0", VA = "0x160E1F0")]
			public SelectionRadial(Player.SelectionRadial.SelectionMode mode = Player.SelectionRadial.SelectionMode.Dpad4)
			{
			}

			// Token: 0x06002CB7 RID: 11447 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002CB7")]
			[Address(RVA = "0x160E2D0", Offset = "0x160E2D0", VA = "0x160E2D0")]
			public void Update()
			{
			}

			// Token: 0x06002CB8 RID: 11448 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002CB8")]
			[Address(RVA = "0x160E9F4", Offset = "0x160E9F4", VA = "0x160E9F4")]
			public void ChangeBinding(int itemSlot)
			{
			}

			// Token: 0x06002CB9 RID: 11449 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002CB9")]
			[Address(RVA = "0x160E8A8", Offset = "0x160E8A8", VA = "0x160E8A8")]
			public void ChangeSelection(int to)
			{
			}

			// Token: 0x06002CBA RID: 11450 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002CBA")]
			[Address(RVA = "0x160EBE4", Offset = "0x160EBE4", VA = "0x160EBE4")]
			public void Bind(int itemslot, int radialslot)
			{
			}

			// Token: 0x06002CBB RID: 11451 RVA: 0x00015A38 File Offset: 0x00013C38
			[Token(Token = "0x6002CBB")]
			[Address(RVA = "0x160ECD0", Offset = "0x160ECD0", VA = "0x160ECD0")]
			public int GetSlotBinding(int itemSlot)
			{
				return 0;
			}

			// Token: 0x06002CBC RID: 11452 RVA: 0x00015A50 File Offset: 0x00013C50
			[Token(Token = "0x6002CBC")]
			[Address(RVA = "0x160ED30", Offset = "0x160ED30", VA = "0x160ED30")]
			public int GetDrawMode(int itemslot)
			{
				return 0;
			}

			// Token: 0x06002CBD RID: 11453 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002CBD")]
			[Address(RVA = "0x160EDBC", Offset = "0x160EDBC", VA = "0x160EDBC")]
			public void CopyTo(Player.SelectionRadial that)
			{
			}

			// Token: 0x04003DEC RID: 15852
			[Token(Token = "0x4003DEC")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private int _SelectedBinding;

			// Token: 0x04003DED RID: 15853
			[Token(Token = "0x4003DED")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			private int _NPCHeldItem;

			// Token: 0x04003DEE RID: 15854
			[Token(Token = "0x4003DEE")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int RadialCount;

			// Token: 0x04003DEF RID: 15855
			[Token(Token = "0x4003DEF")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public int[] Bindings;

			// Token: 0x04003DF0 RID: 15856
			[Token(Token = "0x4003DF0")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Player.SelectionRadial.SelectionMode Mode;

			// Token: 0x04003DF1 RID: 15857
			[Token(Token = "0x4003DF1")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int restoreTo;

			// Token: 0x020004A2 RID: 1186
			[Token(Token = "0x20004A2")]
			public enum SelectionMode
			{
				// Token: 0x04003DF3 RID: 15859
				[Token(Token = "0x4003DF3")]
				Dpad4,
				// Token: 0x04003DF4 RID: 15860
				[Token(Token = "0x4003DF4")]
				RadialCircular,
				// Token: 0x04003DF5 RID: 15861
				[Token(Token = "0x4003DF5")]
				RadialQuicks
			}
		}

		// Token: 0x020004A3 RID: 1187
		[Token(Token = "0x20004A3")]
		public struct OverheadMessage
		{
			// Token: 0x06002CBE RID: 11454 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002CBE")]
			[Address(RVA = "0x187F7A0", Offset = "0x187F7A0", VA = "0x187F7A0")]
			public void NewMessage(string message, int displayTime)
			{
			}

			// Token: 0x04003DF6 RID: 15862
			[Token(Token = "0x4003DF6")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string chatText;

			// Token: 0x04003DF7 RID: 15863
			[Token(Token = "0x4003DF7")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public TextSnippet[] snippets;

			// Token: 0x04003DF8 RID: 15864
			[Token(Token = "0x4003DF8")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Vector2 messageSize;

			// Token: 0x04003DF9 RID: 15865
			[Token(Token = "0x4003DF9")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int timeLeft;

			// Token: 0x04003DFA RID: 15866
			[Token(Token = "0x4003DFA")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Color color;
		}
	}
}
