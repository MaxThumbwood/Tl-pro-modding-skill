using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.DataStructures;

namespace Terraria
{
	// Token: 0x020004D8 RID: 1240
	[Token(Token = "0x20004D8")]
	public class Mount
	{
		// Token: 0x060030DE RID: 12510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030DE")]
		[Address(RVA = "0x18DDC60", Offset = "0x18DDC60", VA = "0x18DDC60")]
		public void ApplyDummyFrameCounters()
		{
		}

		// Token: 0x060030DF RID: 12511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030DF")]
		[Address(RVA = "0x18DDC6C", Offset = "0x18DDC6C", VA = "0x18DDC6C")]
		private static void MeowcartLandingSound(Player Player, Vector2 Position, int Width, int Height)
		{
		}

		// Token: 0x060030E0 RID: 12512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030E0")]
		[Address(RVA = "0x18DDCE8", Offset = "0x18DDCE8", VA = "0x18DDCE8")]
		private static void MeowcartBumperSound(Player Player, Vector2 Position, int Width, int Height)
		{
		}

		// Token: 0x060030E1 RID: 12513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030E1")]
		[Address(RVA = "0x18DDD64", Offset = "0x18DDD64", VA = "0x18DDD64")]
		public Mount()
		{
		}

		// Token: 0x060030E2 RID: 12514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030E2")]
		[Address(RVA = "0x18DDE80", Offset = "0x18DDE80", VA = "0x18DDE80")]
		public void Reset()
		{
		}

		// Token: 0x060030E3 RID: 12515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030E3")]
		[Address(RVA = "0x18DDED0", Offset = "0x18DDED0", VA = "0x18DDED0")]
		public static void Initialize()
		{
		}

		// Token: 0x060030E4 RID: 12516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030E4")]
		[Address(RVA = "0x18EB974", Offset = "0x18EB974", VA = "0x18EB974")]
		public static void SetAsRollerSkate(Mount.MountData newMount, int buff)
		{
		}

		// Token: 0x060030E5 RID: 12517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030E5")]
		[Address(RVA = "0x18EB3C0", Offset = "0x18EB3C0", VA = "0x18EB3C0")]
		public static void SetAsHorse(Mount.MountData newMount, int buff, Asset<Texture2D> texture)
		{
		}

		// Token: 0x060030E6 RID: 12518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030E6")]
		[Address(RVA = "0x18EBC60", Offset = "0x18EBC60", VA = "0x18EBC60")]
		public static void SetAsChillet(Mount.MountData newMount, int buff, Asset<Texture2D> texture, bool hardmode)
		{
		}

		// Token: 0x060030E7 RID: 12519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030E7")]
		[Address(RVA = "0x18EAF70", Offset = "0x18EAF70", VA = "0x18EAF70")]
		public static void SetAsMinecart(Mount.MountData newMount, int buff, Asset<Texture2D> texture, int verticalOffset = 0, int playerVerticalOffset = 0)
		{
		}

		// Token: 0x17000673 RID: 1651
		// (get) Token: 0x060030E8 RID: 12520 RVA: 0x00017880 File Offset: 0x00015A80
		[Token(Token = "0x17000673")]
		public bool Active
		{
			[Token(Token = "0x60030E8")]
			[Address(RVA = "0x18EC284", Offset = "0x18EC284", VA = "0x18EC284")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060030E9 RID: 12521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030E9")]
		[Address(RVA = "0x18EC28C", Offset = "0x18EC28C", VA = "0x18EC28C")]
		public void OverrideActive(bool active)
		{
		}

		// Token: 0x17000674 RID: 1652
		// (get) Token: 0x060030EA RID: 12522 RVA: 0x00017898 File Offset: 0x00015A98
		[Token(Token = "0x17000674")]
		public int Type
		{
			[Token(Token = "0x60030EA")]
			[Address(RVA = "0x18EC294", Offset = "0x18EC294", VA = "0x18EC294")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000675 RID: 1653
		// (get) Token: 0x060030EB RID: 12523 RVA: 0x000178B0 File Offset: 0x00015AB0
		[Token(Token = "0x17000675")]
		public int Frame
		{
			[Token(Token = "0x60030EB")]
			[Address(RVA = "0x18EC29C", Offset = "0x18EC29C", VA = "0x18EC29C")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000676 RID: 1654
		// (get) Token: 0x060030EC RID: 12524 RVA: 0x000178C8 File Offset: 0x00015AC8
		[Token(Token = "0x17000676")]
		public int FlyTime
		{
			[Token(Token = "0x60030EC")]
			[Address(RVA = "0x18EC2A4", Offset = "0x18EC2A4", VA = "0x18EC2A4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000677 RID: 1655
		// (get) Token: 0x060030ED RID: 12525 RVA: 0x000178E0 File Offset: 0x00015AE0
		[Token(Token = "0x17000677")]
		public int BuffType
		{
			[Token(Token = "0x60030ED")]
			[Address(RVA = "0x18EC2AC", Offset = "0x18EC2AC", VA = "0x18EC2AC")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000678 RID: 1656
		// (get) Token: 0x060030EE RID: 12526 RVA: 0x000178F8 File Offset: 0x00015AF8
		[Token(Token = "0x17000678")]
		public int BodyFrame
		{
			[Token(Token = "0x60030EE")]
			[Address(RVA = "0x18EC2D0", Offset = "0x18EC2D0", VA = "0x18EC2D0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000679 RID: 1657
		// (get) Token: 0x060030EF RID: 12527 RVA: 0x00017910 File Offset: 0x00015B10
		[Token(Token = "0x17000679")]
		public int XOffset
		{
			[Token(Token = "0x60030EF")]
			[Address(RVA = "0x18EC2F4", Offset = "0x18EC2F4", VA = "0x18EC2F4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700067A RID: 1658
		// (get) Token: 0x060030F0 RID: 12528 RVA: 0x00017928 File Offset: 0x00015B28
		[Token(Token = "0x1700067A")]
		public int YOffset
		{
			[Token(Token = "0x60030F0")]
			[Address(RVA = "0x18EC318", Offset = "0x18EC318", VA = "0x18EC318")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700067B RID: 1659
		// (get) Token: 0x060030F1 RID: 12529 RVA: 0x00017940 File Offset: 0x00015B40
		[Token(Token = "0x1700067B")]
		public int RunningGraceTime
		{
			[Token(Token = "0x60030F1")]
			[Address(RVA = "0x18EC33C", Offset = "0x18EC33C", VA = "0x18EC33C")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700067C RID: 1660
		// (get) Token: 0x060030F2 RID: 12530 RVA: 0x00017958 File Offset: 0x00015B58
		[Token(Token = "0x1700067C")]
		public int PlayerXOFfset
		{
			[Token(Token = "0x60030F2")]
			[Address(RVA = "0x18EC344", Offset = "0x18EC344", VA = "0x18EC344")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700067D RID: 1661
		// (get) Token: 0x060030F3 RID: 12531 RVA: 0x00017970 File Offset: 0x00015B70
		[Token(Token = "0x1700067D")]
		public int PlayerOffset
		{
			[Token(Token = "0x60030F3")]
			[Address(RVA = "0x18EC368", Offset = "0x18EC368", VA = "0x18EC368")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700067E RID: 1662
		// (get) Token: 0x060030F4 RID: 12532 RVA: 0x00017988 File Offset: 0x00015B88
		[Token(Token = "0x1700067E")]
		public int PlayerOffsetHitbox
		{
			[Token(Token = "0x60030F4")]
			[Address(RVA = "0x18EC3D4", Offset = "0x18EC3D4", VA = "0x18EC3D4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700067F RID: 1663
		// (get) Token: 0x060030F5 RID: 12533 RVA: 0x000179A0 File Offset: 0x00015BA0
		[Token(Token = "0x1700067F")]
		public int PlayerHeadOffset
		{
			[Token(Token = "0x60030F5")]
			[Address(RVA = "0x18EC460", Offset = "0x18EC460", VA = "0x18EC460")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000680 RID: 1664
		// (get) Token: 0x060030F6 RID: 12534 RVA: 0x000179B8 File Offset: 0x00015BB8
		[Token(Token = "0x17000680")]
		public int HeightBoost
		{
			[Token(Token = "0x60030F6")]
			[Address(RVA = "0x18EC498", Offset = "0x18EC498", VA = "0x18EC498")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060030F7 RID: 12535 RVA: 0x000179D0 File Offset: 0x00015BD0
		[Token(Token = "0x60030F7")]
		[Address(RVA = "0x18EC4BC", Offset = "0x18EC4BC", VA = "0x18EC4BC")]
		public static int GetHeightBoost(int MountType)
		{
			return 0;
		}

		// Token: 0x17000681 RID: 1665
		// (get) Token: 0x060030F8 RID: 12536 RVA: 0x000179E8 File Offset: 0x00015BE8
		[Token(Token = "0x17000681")]
		public float RunSpeed
		{
			[Token(Token = "0x60030F8")]
			[Address(RVA = "0x18EC59C", Offset = "0x18EC59C", VA = "0x18EC59C")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000682 RID: 1666
		// (get) Token: 0x060030F9 RID: 12537 RVA: 0x00017A00 File Offset: 0x00015C00
		[Token(Token = "0x17000682")]
		public float DashSpeed
		{
			[Token(Token = "0x60030F9")]
			[Address(RVA = "0x18EC800", Offset = "0x18EC800", VA = "0x18EC800")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000683 RID: 1667
		// (get) Token: 0x060030FA RID: 12538 RVA: 0x00017A18 File Offset: 0x00015C18
		[Token(Token = "0x17000683")]
		public float Acceleration
		{
			[Token(Token = "0x60030FA")]
			[Address(RVA = "0x18EC894", Offset = "0x18EC894", VA = "0x18EC894")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000684 RID: 1668
		// (get) Token: 0x060030FB RID: 12539 RVA: 0x00017A30 File Offset: 0x00015C30
		[Token(Token = "0x17000684")]
		public int ExtraFall
		{
			[Token(Token = "0x60030FB")]
			[Address(RVA = "0x18EC928", Offset = "0x18EC928", VA = "0x18EC928")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000685 RID: 1669
		// (get) Token: 0x060030FC RID: 12540 RVA: 0x00017A48 File Offset: 0x00015C48
		[Token(Token = "0x17000685")]
		public float FallDamage
		{
			[Token(Token = "0x60030FC")]
			[Address(RVA = "0x18EC94C", Offset = "0x18EC94C", VA = "0x18EC94C")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x060030FD RID: 12541 RVA: 0x00017A60 File Offset: 0x00015C60
		[Token(Token = "0x60030FD")]
		[Address(RVA = "0x18EC970", Offset = "0x18EC970", VA = "0x18EC970")]
		public int JumpHeight(float xVelocity)
		{
			return 0;
		}

		// Token: 0x060030FE RID: 12542 RVA: 0x00017A78 File Offset: 0x00015C78
		[Token(Token = "0x60030FE")]
		[Address(RVA = "0x18ECAD0", Offset = "0x18ECAD0", VA = "0x18ECAD0")]
		public float JumpSpeed(float xVelocity)
		{
			return 0f;
		}

		// Token: 0x17000686 RID: 1670
		// (get) Token: 0x060030FF RID: 12543 RVA: 0x00017A90 File Offset: 0x00015C90
		[Token(Token = "0x17000686")]
		public bool AutoJump
		{
			[Token(Token = "0x60030FF")]
			[Address(RVA = "0x18ECBDC", Offset = "0x18ECBDC", VA = "0x18ECBDC")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000687 RID: 1671
		// (get) Token: 0x06003100 RID: 12544 RVA: 0x00017AA8 File Offset: 0x00015CA8
		[Token(Token = "0x17000687")]
		public bool BlockExtraJumps
		{
			[Token(Token = "0x6003100")]
			[Address(RVA = "0x18ECC00", Offset = "0x18ECC00", VA = "0x18ECC00")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000688 RID: 1672
		// (get) Token: 0x06003101 RID: 12545 RVA: 0x00017AC0 File Offset: 0x00015CC0
		[Token(Token = "0x17000688")]
		public bool IsConsideredASlimeMount
		{
			[Token(Token = "0x6003101")]
			[Address(RVA = "0x18ECC24", Offset = "0x18ECC24", VA = "0x18ECC24")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000689 RID: 1673
		// (get) Token: 0x06003102 RID: 12546 RVA: 0x00017AD8 File Offset: 0x00015CD8
		[Token(Token = "0x17000689")]
		public bool Cart
		{
			[Token(Token = "0x6003102")]
			[Address(RVA = "0x18ECC48", Offset = "0x18ECC48", VA = "0x18ECC48")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700068A RID: 1674
		// (get) Token: 0x06003103 RID: 12547 RVA: 0x00017AF0 File Offset: 0x00015CF0
		[Token(Token = "0x1700068A")]
		public bool CanGrindRails
		{
			[Token(Token = "0x6003103")]
			[Address(RVA = "0x18ECC78", Offset = "0x18ECC78", VA = "0x18ECC78")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700068B RID: 1675
		// (get) Token: 0x06003104 RID: 12548 RVA: 0x00017B08 File Offset: 0x00015D08
		[Token(Token = "0x1700068B")]
		public bool AnyTrackRider
		{
			[Token(Token = "0x6003104")]
			[Address(RVA = "0x18ECCA8", Offset = "0x18ECCA8", VA = "0x18ECCA8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700068C RID: 1676
		// (get) Token: 0x06003105 RID: 12549 RVA: 0x00017B20 File Offset: 0x00015D20
		[Token(Token = "0x1700068C")]
		public bool CanUseWings
		{
			[Token(Token = "0x6003105")]
			[Address(RVA = "0x18ECCE8", Offset = "0x18ECCE8", VA = "0x18ECCE8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700068D RID: 1677
		// (get) Token: 0x06003106 RID: 12550 RVA: 0x00017B38 File Offset: 0x00015D38
		[Token(Token = "0x1700068D")]
		public bool MovementStatsAreAdditive
		{
			[Token(Token = "0x6003106")]
			[Address(RVA = "0x18ECD18", Offset = "0x18ECD18", VA = "0x18ECD18")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700068E RID: 1678
		// (get) Token: 0x06003107 RID: 12551 RVA: 0x00017B50 File Offset: 0x00015D50
		[Token(Token = "0x1700068E")]
		public bool IsAtIdle
		{
			[Token(Token = "0x6003107")]
			[Address(RVA = "0x18ECD48", Offset = "0x18ECD48", VA = "0x18ECD48")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700068F RID: 1679
		// (get) Token: 0x06003108 RID: 12552 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700068F")]
		public Mount.MountDelegatesData Delegations
		{
			[Token(Token = "0x6003108")]
			[Address(RVA = "0x18ECD8C", Offset = "0x18ECD8C", VA = "0x18ECD8C")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000690 RID: 1680
		// (get) Token: 0x06003109 RID: 12553 RVA: 0x00017B68 File Offset: 0x00015D68
		[Token(Token = "0x17000690")]
		public Vector2 Origin
		{
			[Token(Token = "0x6003109")]
			[Address(RVA = "0x18ECDA4", Offset = "0x18ECDA4", VA = "0x18ECDA4")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x0600310A RID: 12554 RVA: 0x00017B80 File Offset: 0x00015D80
		[Token(Token = "0x600310A")]
		[Address(RVA = "0x18ECE44", Offset = "0x18ECE44", VA = "0x18ECE44")]
		public bool CanFly(Player mountedPlayer)
		{
			return default(bool);
		}

		// Token: 0x0600310B RID: 12555 RVA: 0x00017B98 File Offset: 0x00015D98
		[Token(Token = "0x600310B")]
		[Address(RVA = "0x18ECF5C", Offset = "0x18ECF5C", VA = "0x18ECF5C")]
		public bool CanHover()
		{
			return default(bool);
		}

		// Token: 0x17000691 RID: 1681
		// (get) Token: 0x0600310C RID: 12556 RVA: 0x00017BB0 File Offset: 0x00015DB0
		[Token(Token = "0x17000691")]
		public bool AbilityCharging
		{
			[Token(Token = "0x600310C")]
			[Address(RVA = "0x18ECFD4", Offset = "0x18ECFD4", VA = "0x18ECFD4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000692 RID: 1682
		// (get) Token: 0x0600310D RID: 12557 RVA: 0x00017BC8 File Offset: 0x00015DC8
		[Token(Token = "0x17000692")]
		public bool AbilityActive
		{
			[Token(Token = "0x600310D")]
			[Address(RVA = "0x18ECFDC", Offset = "0x18ECFDC", VA = "0x18ECFDC")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000693 RID: 1683
		// (get) Token: 0x0600310E RID: 12558 RVA: 0x00017BE0 File Offset: 0x00015DE0
		[Token(Token = "0x17000693")]
		public float AbilityCharge
		{
			[Token(Token = "0x600310E")]
			[Address(RVA = "0x18ECFE4", Offset = "0x18ECFE4", VA = "0x18ECFE4")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x0600310F RID: 12559 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600310F")]
		[Address(RVA = "0x18ED018", Offset = "0x18ED018", VA = "0x18ED018")]
		public IEntitySource GetProjectileSpawnSource(Player mountedPlayer)
		{
			return null;
		}

		// Token: 0x06003110 RID: 12560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003110")]
		[Address(RVA = "0x18ED098", Offset = "0x18ED098", VA = "0x18ED098")]
		public void StartAbilityCharge(Player mountedPlayer)
		{
		}

		// Token: 0x06003111 RID: 12561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003111")]
		[Address(RVA = "0x18ED29C", Offset = "0x18ED29C", VA = "0x18ED29C")]
		public void StopAbilityCharge()
		{
		}

		// Token: 0x06003112 RID: 12562 RVA: 0x00017BF8 File Offset: 0x00015DF8
		[Token(Token = "0x6003112")]
		[Address(RVA = "0x18ED300", Offset = "0x18ED300", VA = "0x18ED300")]
		public bool CheckBuff(int buffID)
		{
			return default(bool);
		}

		// Token: 0x06003113 RID: 12563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003113")]
		[Address(RVA = "0x18ED32C", Offset = "0x18ED32C", VA = "0x18ED32C")]
		public void AbilityRecovery()
		{
		}

		// Token: 0x06003114 RID: 12564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003114")]
		[Address(RVA = "0x18ED3A0", Offset = "0x18ED3A0", VA = "0x18ED3A0")]
		public void FatigueRecovery()
		{
		}

		// Token: 0x06003115 RID: 12565 RVA: 0x00017C10 File Offset: 0x00015E10
		[Token(Token = "0x6003115")]
		[Address(RVA = "0x18ED3CC", Offset = "0x18ED3CC", VA = "0x18ED3CC")]
		public bool Flight()
		{
			return default(bool);
		}

		// Token: 0x17000694 RID: 1684
		// (get) Token: 0x06003116 RID: 12566 RVA: 0x00017C28 File Offset: 0x00015E28
		[Token(Token = "0x17000694")]
		public bool AllowDirectionChange
		{
			[Token(Token = "0x6003116")]
			[Address(RVA = "0x18ED3E8", Offset = "0x18ED3E8", VA = "0x18ED3E8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06003117 RID: 12567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003117")]
		[Address(RVA = "0x18ED42C", Offset = "0x18ED42C", VA = "0x18ED42C")]
		public void UpdateAfterEquips(Player mountedPlayer)
		{
		}

		// Token: 0x06003118 RID: 12568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003118")]
		[Address(RVA = "0x18ED7E4", Offset = "0x18ED7E4", VA = "0x18ED7E4")]
		public void UpdateDrill(Player mountedPlayer, bool controlUp, bool controlDown)
		{
		}

		// Token: 0x06003119 RID: 12569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003119")]
		[Address(RVA = "0x18ED9BC", Offset = "0x18ED9BC", VA = "0x18ED9BC")]
		public void UseDrill(Player mountedPlayer)
		{
		}

		// Token: 0x0600311A RID: 12570 RVA: 0x00017C40 File Offset: 0x00015E40
		[Token(Token = "0x600311A")]
		[Address(RVA = "0x18EEF3C", Offset = "0x18EEF3C", VA = "0x18EEF3C")]
		private static bool DrillSmartCursor_BlocksPlot(int x, int y)
		{
			return default(bool);
		}

		// Token: 0x0600311B RID: 12571 RVA: 0x00017C58 File Offset: 0x00015E58
		[Token(Token = "0x600311B")]
		[Address(RVA = "0x18EE810", Offset = "0x18EE810", VA = "0x18EE810")]
		private Point16 DrillSmartCursor_Blocks(Player mountedPlayer, Mount.DrillMountData data)
		{
			return default(Point16);
		}

		// Token: 0x0600311C RID: 12572 RVA: 0x00017C70 File Offset: 0x00015E70
		[Token(Token = "0x600311C")]
		[Address(RVA = "0x18EEB74", Offset = "0x18EEB74", VA = "0x18EEB74")]
		private Point16 DrillSmartCursor_Walls(Player mountedPlayer, Mount.DrillMountData data)
		{
			return default(Point16);
		}

		// Token: 0x0600311D RID: 12573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600311D")]
		[Address(RVA = "0x18EF190", Offset = "0x18EF190", VA = "0x18EF190")]
		public void UseAbility(Player mountedPlayer, Vector2 mousePosition, bool toggleOn)
		{
		}

		// Token: 0x0600311E RID: 12574 RVA: 0x00017C88 File Offset: 0x00015E88
		[Token(Token = "0x600311E")]
		[Address(RVA = "0x18F0188", Offset = "0x18F0188", VA = "0x18F0188")]
		public bool Hover(Player mountedPlayer)
		{
			return default(bool);
		}

		// Token: 0x0600311F RID: 12575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600311F")]
		[Address(RVA = "0x18F0CCC", Offset = "0x18F0CCC", VA = "0x18F0CCC")]
		private static void TryStabilizingSmallMountPositionBetweenSlopes(Player mountedPlayer)
		{
		}

		// Token: 0x06003120 RID: 12576 RVA: 0x00017CA0 File Offset: 0x00015EA0
		[Token(Token = "0x6003120")]
		[Address(RVA = "0x18F0BDC", Offset = "0x18F0BDC", VA = "0x18F0BDC")]
		private bool DoesHoverIgnoresFatigue()
		{
			return default(bool);
		}

		// Token: 0x06003121 RID: 12577 RVA: 0x00017CB8 File Offset: 0x00015EB8
		[Token(Token = "0x6003121")]
		[Address(RVA = "0x18F0DF0", Offset = "0x18F0DF0", VA = "0x18F0DF0")]
		private float GetWitchBroomTrinketRotation(Player player)
		{
			return 0f;
		}

		// Token: 0x06003122 RID: 12578 RVA: 0x00017CD0 File Offset: 0x00015ED0
		[Token(Token = "0x6003122")]
		[Address(RVA = "0x18F110C", Offset = "0x18F110C", VA = "0x18F110C")]
		private Vector2 GetWitchBroomTrinketOriginOffset(Player player)
		{
			return default(Vector2);
		}

		// Token: 0x06003123 RID: 12579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003123")]
		[Address(RVA = "0x18F1160", Offset = "0x18F1160", VA = "0x18F1160")]
		public void UpdateFrame(Player mountedPlayer, int state, Vector2 velocity)
		{
		}

		// Token: 0x06003124 RID: 12580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003124")]
		[Address(RVA = "0x18F6130", Offset = "0x18F6130", VA = "0x18F6130")]
		public void UpdateFrame_Velociraptor(Player mountedPlayer, ref int state)
		{
		}

		// Token: 0x06003125 RID: 12581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003125")]
		[Address(RVA = "0x18F66B0", Offset = "0x18F66B0", VA = "0x18F66B0")]
		public void TryBeginningFlight(Player mountedPlayer, int state)
		{
		}

		// Token: 0x06003126 RID: 12582 RVA: 0x00017CE8 File Offset: 0x00015EE8
		[Token(Token = "0x6003126")]
		[Address(RVA = "0x18F69A0", Offset = "0x18F69A0", VA = "0x18F69A0")]
		public int GetIntendedGroundedFrame(Player mountedPlayer)
		{
			return 0;
		}

		// Token: 0x06003127 RID: 12583 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003127")]
		[Address(RVA = "0x18F6AC8", Offset = "0x18F6AC8", VA = "0x18F6AC8")]
		public void TryLanding(Player mountedPlayer)
		{
		}

		// Token: 0x06003128 RID: 12584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003128")]
		[Address(RVA = "0x18F62EC", Offset = "0x18F62EC", VA = "0x18F62EC")]
		private void UpdateFrame_GolfCart(Player mountedPlayer, int state, Vector2 velocity)
		{
		}

		// Token: 0x06003129 RID: 12585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003129")]
		[Address(RVA = "0x18F7358", Offset = "0x18F7358", VA = "0x18F7358")]
		private static void EmitGolfCartSmoke(Player mountedPlayer, bool rushing)
		{
		}

		// Token: 0x0600312A RID: 12586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600312A")]
		[Address(RVA = "0x18F709C", Offset = "0x18F709C", VA = "0x18F709C")]
		private static void EmitGolfCartlight(Vector2 worldLocation, int playerDirection)
		{
		}

		// Token: 0x0600312B RID: 12587 RVA: 0x00017D00 File Offset: 0x00015F00
		[Token(Token = "0x600312B")]
		[Address(RVA = "0x18F7704", Offset = "0x18F7704", VA = "0x18F7704")]
		private static bool ShouldGolfCartEmitLight()
		{
			return default(bool);
		}

		// Token: 0x0600312C RID: 12588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600312C")]
		[Address(RVA = "0x18F6CEC", Offset = "0x18F6CEC", VA = "0x18F6CEC")]
		private static void EmitGolfCartWheelDust(Player mountedPlayer, Vector2 legSpot)
		{
		}

		// Token: 0x0600312D RID: 12589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600312D")]
		[Address(RVA = "0x18F770C", Offset = "0x18F770C", VA = "0x18F770C")]
		private void DoGemMinecartEffect(Player mountedPlayer, int dustType)
		{
		}

		// Token: 0x0600312E RID: 12590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600312E")]
		[Address(RVA = "0x18F7B0C", Offset = "0x18F7B0C", VA = "0x18F7B0C")]
		private void DoSteamMinecartEffect(Player mountedPlayer, int dustType)
		{
		}

		// Token: 0x0600312F RID: 12591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600312F")]
		[Address(RVA = "0x18F7F1C", Offset = "0x18F7F1C", VA = "0x18F7F1C")]
		private void DoExhaustMinecartEffect(Player mountedPlayer, int dustType)
		{
		}

		// Token: 0x06003130 RID: 12592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003130")]
		[Address(RVA = "0x18F8524", Offset = "0x18F8524", VA = "0x18F8524")]
		private void DoConfettiMinecartEffect(Player mountedPlayer)
		{
		}

		// Token: 0x06003131 RID: 12593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003131")]
		[Address(RVA = "0x18F8C08", Offset = "0x18F8C08", VA = "0x18F8C08")]
		public void UpdateEffects(Player mountedPlayer)
		{
		}

		// Token: 0x06003132 RID: 12594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003132")]
		[Address(RVA = "0x18FC344", Offset = "0x18FC344", VA = "0x18FC344")]
		private void CastSuperCartLaser(Player mountedPlayer)
		{
		}

		// Token: 0x06003133 RID: 12595 RVA: 0x00017D18 File Offset: 0x00015F18
		[Token(Token = "0x6003133")]
		[Address(RVA = "0x18FD504", Offset = "0x18FD504", VA = "0x18FD504")]
		public static Vector2 GetMinecartMechPoint(Player mountedPlayer, int offX, int offY)
		{
			return default(Vector2);
		}

		// Token: 0x06003134 RID: 12596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003134")]
		[Address(RVA = "0x18FD86C", Offset = "0x18FD86C", VA = "0x18FD86C")]
		public void ResetFlightTime(Player mountedPlayer)
		{
		}

		// Token: 0x06003135 RID: 12597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003135")]
		[Address(RVA = "0x18FD97C", Offset = "0x18FD97C", VA = "0x18FD97C")]
		public void CheckMountBuff(Player mountedPlayer)
		{
		}

		// Token: 0x06003136 RID: 12598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003136")]
		[Address(RVA = "0x18FD4DC", Offset = "0x18FD4DC", VA = "0x18FD4DC")]
		public void ResetHeadPosition()
		{
		}

		// Token: 0x06003137 RID: 12599 RVA: 0x00017D30 File Offset: 0x00015F30
		[Token(Token = "0x6003137")]
		[Address(RVA = "0x18EFE3C", Offset = "0x18EFE3C", VA = "0x18EFE3C")]
		private Vector2 ClampToDeadZone(Player mountedPlayer, Vector2 position)
		{
			return default(Vector2);
		}

		// Token: 0x06003138 RID: 12600 RVA: 0x00017D48 File Offset: 0x00015F48
		[Token(Token = "0x6003138")]
		[Address(RVA = "0x18FCA94", Offset = "0x18FCA94", VA = "0x18FCA94")]
		public bool AimAbility(Player mountedPlayer, Vector2 mousePosition)
		{
			return default(bool);
		}

		// Token: 0x06003139 RID: 12601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003139")]
		[Address(RVA = "0x18FDA30", Offset = "0x18FDA30", VA = "0x18FDA30")]
		public void Draw(PlayerDrawSet playerDrawData, int drawType, Player drawPlayer, Vector2 Position, Color drawColor, SpriteEffects playerEffect, float shadow)
		{
		}

		// Token: 0x0600313A RID: 12602 RVA: 0x00017D60 File Offset: 0x00015F60
		[Token(Token = "0x600313A")]
		[Address(RVA = "0x1900F54", Offset = "0x1900F54", VA = "0x1900F54")]
		public bool CheckPettingMount(Player player, int mouseX, int mouseY)
		{
			return default(bool);
		}

		// Token: 0x0600313B RID: 12603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600313B")]
		[Address(RVA = "0x190096C", Offset = "0x190096C", VA = "0x190096C")]
		private void TryPettingMount(Player player)
		{
		}

		// Token: 0x0600313C RID: 12604 RVA: 0x00017D78 File Offset: 0x00015F78
		[Token(Token = "0x600313C")]
		[Address(RVA = "0x1901214", Offset = "0x1901214", VA = "0x1901214")]
		public Mount.DismountCheckResult TryDismountWithResult(Player mountedPlayer)
		{
			return Mount.DismountCheckResult.Succeeded;
		}

		// Token: 0x0600313D RID: 12605 RVA: 0x00017D90 File Offset: 0x00015F90
		[Token(Token = "0x600313D")]
		[Address(RVA = "0x18FD9F8", Offset = "0x18FD9F8", VA = "0x18FD9F8")]
		public bool TryDismount(Player mountedPlayer)
		{
			return default(bool);
		}

		// Token: 0x0600313E RID: 12606 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600313E")]
		[Address(RVA = "0x19013A4", Offset = "0x19013A4", VA = "0x19013A4")]
		public void Dismount(Player mountedPlayer, bool ignoreEffect = false)
		{
		}

		// Token: 0x0600313F RID: 12607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600313F")]
		[Address(RVA = "0x1903D18", Offset = "0x1903D18", VA = "0x1903D18")]
		public void SetMount(int m, Player mountedPlayer, bool ignoreEffect = false)
		{
		}

		// Token: 0x06003140 RID: 12608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003140")]
		[Address(RVA = "0x19047AC", Offset = "0x19047AC", VA = "0x19047AC")]
		public void FinalizeMountData(int m, Player mountedPlayer)
		{
		}

		// Token: 0x06003141 RID: 12609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003141")]
		[Address(RVA = "0x19048B4", Offset = "0x19048B4", VA = "0x19048B4")]
		public void DoFailedDismountDust(Player mountedPlayer, int dustAmount)
		{
		}

		// Token: 0x06003142 RID: 12610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003142")]
		[Address(RVA = "0x1901930", Offset = "0x1901930", VA = "0x1901930")]
		public void DoSpawnDust(Player mountedPlayer, bool isDismounting)
		{
		}

		// Token: 0x06003143 RID: 12611 RVA: 0x00017DA8 File Offset: 0x00015FA8
		[Token(Token = "0x6003143")]
		[Address(RVA = "0x1905154", Offset = "0x1905154", VA = "0x1905154")]
		public static bool DismountsOnItemUse(int mountType)
		{
			return default(bool);
		}

		// Token: 0x06003144 RID: 12612 RVA: 0x00017DC0 File Offset: 0x00015FC0
		[Token(Token = "0x6003144")]
		[Address(RVA = "0x19051E8", Offset = "0x19051E8", VA = "0x19051E8")]
		public bool CanVisuallyHoldItem(Player mountedPlayer, Item item)
		{
			return default(bool);
		}

		// Token: 0x06003145 RID: 12613 RVA: 0x00017DD8 File Offset: 0x00015FD8
		[Token(Token = "0x6003145")]
		[Address(RVA = "0x1905288", Offset = "0x1905288", VA = "0x1905288")]
		public bool CanMount(int m, Player mountingPlayer)
		{
			return default(bool);
		}

		// Token: 0x06003146 RID: 12614 RVA: 0x00017DF0 File Offset: 0x00015FF0
		[Token(Token = "0x6003146")]
		[Address(RVA = "0x19056FC", Offset = "0x19056FC", VA = "0x19056FC")]
		public bool CanDismount(Player mountingPlayer)
		{
			return default(bool);
		}

		// Token: 0x06003147 RID: 12615 RVA: 0x00017E08 File Offset: 0x00016008
		[Token(Token = "0x6003147")]
		[Address(RVA = "0x1901250", Offset = "0x1901250", VA = "0x1901250")]
		public Mount.DismountCheckResult CanDismountWithResult(Player mountingPlayer)
		{
			return Mount.DismountCheckResult.Succeeded;
		}

		// Token: 0x17000695 RID: 1685
		// (get) Token: 0x06003148 RID: 12616 RVA: 0x00017E20 File Offset: 0x00016020
		[Token(Token = "0x17000695")]
		public bool DismountOnItemUse
		{
			[Token(Token = "0x6003148")]
			[Address(RVA = "0x1905710", Offset = "0x1905710", VA = "0x1905710")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06003149 RID: 12617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003149")]
		[Address(RVA = "0x1905748", Offset = "0x1905748", VA = "0x1905748")]
		public void TryEarlyDismount(Player player)
		{
		}

		// Token: 0x0600314A RID: 12618 RVA: 0x00017E38 File Offset: 0x00016038
		[Token(Token = "0x600314A")]
		[Address(RVA = "0x19057E0", Offset = "0x19057E0", VA = "0x19057E0")]
		public bool FindTileHeight(Vector2 position, int maxTilesDown, out float tileHeight)
		{
			return default(bool);
		}

		// Token: 0x04004150 RID: 16720
		[Token(Token = "0x4004150")]
		[FieldOffset(Offset = "0x0")]
		public static int currentShader;

		// Token: 0x04004151 RID: 16721
		[Token(Token = "0x4004151")]
		public const int FrameStanding = 0;

		// Token: 0x04004152 RID: 16722
		[Token(Token = "0x4004152")]
		public const int FrameRunning = 1;

		// Token: 0x04004153 RID: 16723
		[Token(Token = "0x4004153")]
		public const int FrameInAir = 2;

		// Token: 0x04004154 RID: 16724
		[Token(Token = "0x4004154")]
		public const int FrameFlying = 3;

		// Token: 0x04004155 RID: 16725
		[Token(Token = "0x4004155")]
		public const int FrameSwimming = 4;

		// Token: 0x04004156 RID: 16726
		[Token(Token = "0x4004156")]
		public const int FrameDashing = 5;

		// Token: 0x04004157 RID: 16727
		[Token(Token = "0x4004157")]
		public const int DrawBack = 0;

		// Token: 0x04004158 RID: 16728
		[Token(Token = "0x4004158")]
		public const int DrawBackExtra = 1;

		// Token: 0x04004159 RID: 16729
		[Token(Token = "0x4004159")]
		public const int DrawFront = 2;

		// Token: 0x0400415A RID: 16730
		[Token(Token = "0x400415A")]
		public const int DrawFrontExtra = 3;

		// Token: 0x0400415B RID: 16731
		[Token(Token = "0x400415B")]
		[FieldOffset(Offset = "0x4")]
		private static Mount.MountData[] mounts;

		// Token: 0x0400415C RID: 16732
		[Token(Token = "0x400415C")]
		[FieldOffset(Offset = "0x8")]
		private static Vector2[] scutlixEyePositions;

		// Token: 0x0400415D RID: 16733
		[Token(Token = "0x400415D")]
		[FieldOffset(Offset = "0xC")]
		private static Vector2 scutlixTextureSize;

		// Token: 0x0400415E RID: 16734
		[Token(Token = "0x400415E")]
		public const int scutlixBaseDamage = 50;

		// Token: 0x0400415F RID: 16735
		[Token(Token = "0x400415F")]
		[FieldOffset(Offset = "0x14")]
		public static Vector2 drillDiodePoint1;

		// Token: 0x04004160 RID: 16736
		[Token(Token = "0x4004160")]
		[FieldOffset(Offset = "0x1C")]
		public static Vector2 drillDiodePoint2;

		// Token: 0x04004161 RID: 16737
		[Token(Token = "0x4004161")]
		[FieldOffset(Offset = "0x24")]
		public static Vector2 drillTextureSize;

		// Token: 0x04004162 RID: 16738
		[Token(Token = "0x4004162")]
		public const int drillTextureWidth = 80;

		// Token: 0x04004163 RID: 16739
		[Token(Token = "0x4004163")]
		public const float drillRotationChange = 0.05235988f;

		// Token: 0x04004164 RID: 16740
		[Token(Token = "0x4004164")]
		[FieldOffset(Offset = "0x2C")]
		public static int drillPickPower;

		// Token: 0x04004165 RID: 16741
		[Token(Token = "0x4004165")]
		[FieldOffset(Offset = "0x30")]
		public static int drillPickTime;

		// Token: 0x04004166 RID: 16742
		[Token(Token = "0x4004166")]
		[FieldOffset(Offset = "0x34")]
		public static int amountOfBeamsAtOnce;

		// Token: 0x04004167 RID: 16743
		[Token(Token = "0x4004167")]
		public const float maxDrillLength = 48f;

		// Token: 0x04004168 RID: 16744
		[Token(Token = "0x4004168")]
		[FieldOffset(Offset = "0x38")]
		private static Vector2 santankTextureSize;

		// Token: 0x04004169 RID: 16745
		[Token(Token = "0x4004169")]
		[FieldOffset(Offset = "0x8")]
		private Mount.MountData _data;

		// Token: 0x0400416A RID: 16746
		[Token(Token = "0x400416A")]
		[FieldOffset(Offset = "0xC")]
		private int _type;

		// Token: 0x0400416B RID: 16747
		[Token(Token = "0x400416B")]
		[FieldOffset(Offset = "0x10")]
		private bool _flipDraw;

		// Token: 0x0400416C RID: 16748
		[Token(Token = "0x400416C")]
		[FieldOffset(Offset = "0x14")]
		private int _frame;

		// Token: 0x0400416D RID: 16749
		[Token(Token = "0x400416D")]
		[FieldOffset(Offset = "0x18")]
		private float _frameCounter;

		// Token: 0x0400416E RID: 16750
		[Token(Token = "0x400416E")]
		[FieldOffset(Offset = "0x1C")]
		private int _frameExtra;

		// Token: 0x0400416F RID: 16751
		[Token(Token = "0x400416F")]
		[FieldOffset(Offset = "0x20")]
		private float _frameExtraCounter;

		// Token: 0x04004170 RID: 16752
		[Token(Token = "0x4004170")]
		[FieldOffset(Offset = "0x24")]
		private int _frameState;

		// Token: 0x04004171 RID: 16753
		[Token(Token = "0x4004171")]
		[FieldOffset(Offset = "0x28")]
		private int _flyTime;

		// Token: 0x04004172 RID: 16754
		[Token(Token = "0x4004172")]
		[FieldOffset(Offset = "0x2C")]
		private int _idleTime;

		// Token: 0x04004173 RID: 16755
		[Token(Token = "0x4004173")]
		[FieldOffset(Offset = "0x30")]
		private int _idleTimeNext;

		// Token: 0x04004174 RID: 16756
		[Token(Token = "0x4004174")]
		[FieldOffset(Offset = "0x34")]
		private float _fatigue;

		// Token: 0x04004175 RID: 16757
		[Token(Token = "0x4004175")]
		[FieldOffset(Offset = "0x38")]
		private float _fatigueMax;

		// Token: 0x04004176 RID: 16758
		[Token(Token = "0x4004176")]
		[FieldOffset(Offset = "0x3C")]
		private bool _abilityCharging;

		// Token: 0x04004177 RID: 16759
		[Token(Token = "0x4004177")]
		[FieldOffset(Offset = "0x40")]
		private int _abilityCharge;

		// Token: 0x04004178 RID: 16760
		[Token(Token = "0x4004178")]
		[FieldOffset(Offset = "0x44")]
		private int _abilityCooldown;

		// Token: 0x04004179 RID: 16761
		[Token(Token = "0x4004179")]
		[FieldOffset(Offset = "0x48")]
		private int _abilityDuration;

		// Token: 0x0400417A RID: 16762
		[Token(Token = "0x400417A")]
		[FieldOffset(Offset = "0x4C")]
		private bool _abilityActive;

		// Token: 0x0400417B RID: 16763
		[Token(Token = "0x400417B")]
		[FieldOffset(Offset = "0x4D")]
		private bool _aiming;

		// Token: 0x0400417C RID: 16764
		[Token(Token = "0x400417C")]
		[FieldOffset(Offset = "0x4E")]
		private bool _shouldSuperCart;

		// Token: 0x0400417D RID: 16765
		[Token(Token = "0x400417D")]
		[FieldOffset(Offset = "0x50")]
		private int _walkingGraceTimeLeft;

		// Token: 0x0400417E RID: 16766
		[Token(Token = "0x400417E")]
		[FieldOffset(Offset = "0x54")]
		public List<DrillDebugDraw> _debugDraw;

		// Token: 0x0400417F RID: 16767
		[Token(Token = "0x400417F")]
		[FieldOffset(Offset = "0x58")]
		private object _mountSpecificData;

		// Token: 0x04004180 RID: 16768
		[Token(Token = "0x4004180")]
		[FieldOffset(Offset = "0x5C")]
		private bool _active;

		// Token: 0x04004181 RID: 16769
		[Token(Token = "0x4004181")]
		[FieldOffset(Offset = "0x40")]
		public static float SuperCartRunSpeed;

		// Token: 0x04004182 RID: 16770
		[Token(Token = "0x4004182")]
		[FieldOffset(Offset = "0x44")]
		public static float SuperCartDashSpeed;

		// Token: 0x04004183 RID: 16771
		[Token(Token = "0x4004183")]
		[FieldOffset(Offset = "0x48")]
		public static float SuperCartAcceleration;

		// Token: 0x04004184 RID: 16772
		[Token(Token = "0x4004184")]
		[FieldOffset(Offset = "0x4C")]
		public static int SuperCartJumpHeight;

		// Token: 0x04004185 RID: 16773
		[Token(Token = "0x4004185")]
		[FieldOffset(Offset = "0x50")]
		public static float SuperCartJumpSpeed;

		// Token: 0x04004186 RID: 16774
		[Token(Token = "0x4004186")]
		[FieldOffset(Offset = "0x60")]
		private Mount.MountDelegatesData _defaultDelegatesData;

		// Token: 0x04004187 RID: 16775
		[Token(Token = "0x4004187")]
		[FieldOffset(Offset = "0x54")]
		private static Mount.DrillMountData DrillSmartCursor_BlocksPlotData;

		// Token: 0x04004188 RID: 16776
		[Token(Token = "0x4004188")]
		[FieldOffset(Offset = "0x58")]
		private static int DrillSmartCursor_BlocksPlotX;

		// Token: 0x04004189 RID: 16777
		[Token(Token = "0x4004189")]
		[FieldOffset(Offset = "0x5C")]
		private static int DrillSmartCursor_BlocksPlotY;

		// Token: 0x0400418A RID: 16778
		[Token(Token = "0x400418A")]
		[FieldOffset(Offset = "0x60")]
		private static Utils.TileActionAttempt DrillSmartCursor_BlocksPlotInstance;

		// Token: 0x0400418B RID: 16779
		[Token(Token = "0x400418B")]
		[FieldOffset(Offset = "0x64")]
		public static int[] idleFrames_Rat;

		// Token: 0x020004D9 RID: 1241
		[Token(Token = "0x20004D9")]
		private class DrillBeam
		{
			// Token: 0x0600314C RID: 12620 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600314C")]
			[Address(RVA = "0x19F8AB8", Offset = "0x19F8AB8", VA = "0x19F8AB8")]
			public DrillBeam()
			{
			}

			// Token: 0x0400418C RID: 16780
			[Token(Token = "0x400418C")]
			[FieldOffset(Offset = "0x8")]
			public Point16 curTileTarget;

			// Token: 0x0400418D RID: 16781
			[Token(Token = "0x400418D")]
			[FieldOffset(Offset = "0xC")]
			public int cooldown;

			// Token: 0x0400418E RID: 16782
			[Token(Token = "0x400418E")]
			[FieldOffset(Offset = "0x10")]
			public int lastPurpose;
		}

		// Token: 0x020004DA RID: 1242
		[Token(Token = "0x20004DA")]
		private class DrillMountData
		{
			// Token: 0x0600314D RID: 12621 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600314D")]
			[Address(RVA = "0x19F8B3C", Offset = "0x19F8B3C", VA = "0x19F8B3C")]
			public DrillMountData()
			{
			}

			// Token: 0x0400418F RID: 16783
			[Token(Token = "0x400418F")]
			[FieldOffset(Offset = "0x8")]
			public float diodeRotationTarget;

			// Token: 0x04004190 RID: 16784
			[Token(Token = "0x4004190")]
			[FieldOffset(Offset = "0xC")]
			public float diodeRotation;

			// Token: 0x04004191 RID: 16785
			[Token(Token = "0x4004191")]
			[FieldOffset(Offset = "0x10")]
			public float outerRingRotation;

			// Token: 0x04004192 RID: 16786
			[Token(Token = "0x4004192")]
			[FieldOffset(Offset = "0x14")]
			public Mount.DrillBeam[] beams;

			// Token: 0x04004193 RID: 16787
			[Token(Token = "0x4004193")]
			[FieldOffset(Offset = "0x18")]
			public int beamCooldown;

			// Token: 0x04004194 RID: 16788
			[Token(Token = "0x4004194")]
			[FieldOffset(Offset = "0x1C")]
			public Vector2 crosshairPosition;
		}

		// Token: 0x020004DB RID: 1243
		[Token(Token = "0x20004DB")]
		private class BooleanMountData
		{
			// Token: 0x0600314E RID: 12622 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600314E")]
			[Address(RVA = "0x19F8CC0", Offset = "0x19F8CC0", VA = "0x19F8CC0")]
			public BooleanMountData()
			{
			}

			// Token: 0x04004195 RID: 16789
			[Token(Token = "0x4004195")]
			[FieldOffset(Offset = "0x8")]
			public bool boolean;
		}

		// Token: 0x020004DC RID: 1244
		[Token(Token = "0x20004DC")]
		private class SelectiveFlyingMountData
		{
			// Token: 0x0600314F RID: 12623 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600314F")]
			[Address(RVA = "0x19F8CDC", Offset = "0x19F8CDC", VA = "0x19F8CDC")]
			public SelectiveFlyingMountData()
			{
			}

			// Token: 0x04004196 RID: 16790
			[Token(Token = "0x4004196")]
			[FieldOffset(Offset = "0x8")]
			public bool showFlyingFrames;

			// Token: 0x04004197 RID: 16791
			[Token(Token = "0x4004197")]
			[FieldOffset(Offset = "0x9")]
			public bool allowedToFly;
		}

		// Token: 0x020004DD RID: 1245
		[Token(Token = "0x20004DD")]
		private class ExtraFrameMountData
		{
			// Token: 0x06003150 RID: 12624 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003150")]
			[Address(RVA = "0x19F8CF8", Offset = "0x19F8CF8", VA = "0x19F8CF8")]
			public ExtraFrameMountData()
			{
			}

			// Token: 0x04004198 RID: 16792
			[Token(Token = "0x4004198")]
			[FieldOffset(Offset = "0x8")]
			public int frame;

			// Token: 0x04004199 RID: 16793
			[Token(Token = "0x4004199")]
			[FieldOffset(Offset = "0xC")]
			public float frameCounter;
		}

		// Token: 0x020004DE RID: 1246
		[Token(Token = "0x20004DE")]
		public class MountDelegatesData
		{
			// Token: 0x06003151 RID: 12625 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003151")]
			[Address(RVA = "0x19F8D18", Offset = "0x19F8D18", VA = "0x19F8D18")]
			public MountDelegatesData()
			{
			}

			// Token: 0x0400419A RID: 16794
			[Token(Token = "0x400419A")]
			[FieldOffset(Offset = "0x8")]
			public Action<Vector2> MinecartDust;

			// Token: 0x0400419B RID: 16795
			[Token(Token = "0x400419B")]
			[FieldOffset(Offset = "0xC")]
			public Action<Player, Vector2, int, int> MinecartJumpingSound;

			// Token: 0x0400419C RID: 16796
			[Token(Token = "0x400419C")]
			[FieldOffset(Offset = "0x10")]
			public Action<Player, Vector2, int, int> MinecartLandingSound;

			// Token: 0x0400419D RID: 16797
			[Token(Token = "0x400419D")]
			[FieldOffset(Offset = "0x14")]
			public Action<Player, Vector2, int, int> MinecartBumperSound;

			// Token: 0x0400419E RID: 16798
			[Token(Token = "0x400419E")]
			[FieldOffset(Offset = "0x18")]
			public Mount.MountDelegatesData.OverridePositionMethod MouthPosition;

			// Token: 0x0400419F RID: 16799
			[Token(Token = "0x400419F")]
			[FieldOffset(Offset = "0x1C")]
			public Mount.MountDelegatesData.OverridePositionMethod HandPosition;

			// Token: 0x040041A0 RID: 16800
			[Token(Token = "0x40041A0")]
			[FieldOffset(Offset = "0x20")]
			public Mount.MountDelegatesData.OverrideSizeMethod PlayerSize;

			// Token: 0x040041A1 RID: 16801
			[Token(Token = "0x40041A1")]
			[FieldOffset(Offset = "0x24")]
			public Mount.MountDelegatesData.AdjustDashDustMethod DashDust;

			// Token: 0x020004DF RID: 1247
			// (Invoke) Token: 0x06003153 RID: 12627
			[Token(Token = "0x20004DF")]
			public delegate bool OverridePositionMethod(Player player, out Vector2? position);

			// Token: 0x020004E0 RID: 1248
			// (Invoke) Token: 0x06003157 RID: 12631
			[Token(Token = "0x20004E0")]
			public delegate bool OverrideSizeMethod(Player player, out Vector2? size);

			// Token: 0x020004E1 RID: 1249
			// (Invoke) Token: 0x0600315B RID: 12635
			[Token(Token = "0x20004E1")]
			public delegate Dust AdjustDashDustMethod(Player player, int currentDustCount, Dust dust);
		}

		// Token: 0x020004E2 RID: 1250
		[Token(Token = "0x20004E2")]
		public class MountData
		{
			// Token: 0x0600315E RID: 12638 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600315E")]
			[Address(RVA = "0x19F9564", Offset = "0x19F9564", VA = "0x19F9564")]
			public MountData()
			{
			}

			// Token: 0x040041A2 RID: 16802
			[Token(Token = "0x40041A2")]
			[FieldOffset(Offset = "0x8")]
			public Asset<Texture2D> backTexture;

			// Token: 0x040041A3 RID: 16803
			[Token(Token = "0x40041A3")]
			[FieldOffset(Offset = "0xC")]
			public Asset<Texture2D> backTextureGlow;

			// Token: 0x040041A4 RID: 16804
			[Token(Token = "0x40041A4")]
			[FieldOffset(Offset = "0x10")]
			public Asset<Texture2D> backTextureExtra;

			// Token: 0x040041A5 RID: 16805
			[Token(Token = "0x40041A5")]
			[FieldOffset(Offset = "0x14")]
			public Asset<Texture2D> backTextureExtraGlow;

			// Token: 0x040041A6 RID: 16806
			[Token(Token = "0x40041A6")]
			[FieldOffset(Offset = "0x18")]
			public Asset<Texture2D> frontTexture;

			// Token: 0x040041A7 RID: 16807
			[Token(Token = "0x40041A7")]
			[FieldOffset(Offset = "0x1C")]
			public Asset<Texture2D> frontTextureGlow;

			// Token: 0x040041A8 RID: 16808
			[Token(Token = "0x40041A8")]
			[FieldOffset(Offset = "0x20")]
			public Asset<Texture2D> frontTextureExtra;

			// Token: 0x040041A9 RID: 16809
			[Token(Token = "0x40041A9")]
			[FieldOffset(Offset = "0x24")]
			public Asset<Texture2D> frontTextureExtraGlow;

			// Token: 0x040041AA RID: 16810
			[Token(Token = "0x40041AA")]
			[FieldOffset(Offset = "0x28")]
			public int textureWidth;

			// Token: 0x040041AB RID: 16811
			[Token(Token = "0x40041AB")]
			[FieldOffset(Offset = "0x2C")]
			public int textureHeight;

			// Token: 0x040041AC RID: 16812
			[Token(Token = "0x40041AC")]
			[FieldOffset(Offset = "0x30")]
			public int xOffset;

			// Token: 0x040041AD RID: 16813
			[Token(Token = "0x40041AD")]
			[FieldOffset(Offset = "0x34")]
			public int yOffset;

			// Token: 0x040041AE RID: 16814
			[Token(Token = "0x40041AE")]
			[FieldOffset(Offset = "0x38")]
			public int[] playerYOffsets;

			// Token: 0x040041AF RID: 16815
			[Token(Token = "0x40041AF")]
			[FieldOffset(Offset = "0x3C")]
			public int bodyFrame;

			// Token: 0x040041B0 RID: 16816
			[Token(Token = "0x40041B0")]
			[FieldOffset(Offset = "0x40")]
			public int playerHeadOffset;

			// Token: 0x040041B1 RID: 16817
			[Token(Token = "0x40041B1")]
			[FieldOffset(Offset = "0x44")]
			public int heightBoost;

			// Token: 0x040041B2 RID: 16818
			[Token(Token = "0x40041B2")]
			[FieldOffset(Offset = "0x48")]
			public int buff;

			// Token: 0x040041B3 RID: 16819
			[Token(Token = "0x40041B3")]
			[FieldOffset(Offset = "0x4C")]
			public int flightTimeMax;

			// Token: 0x040041B4 RID: 16820
			[Token(Token = "0x40041B4")]
			[FieldOffset(Offset = "0x50")]
			public bool usesHover;

			// Token: 0x040041B5 RID: 16821
			[Token(Token = "0x40041B5")]
			[FieldOffset(Offset = "0x54")]
			public float runSpeed;

			// Token: 0x040041B6 RID: 16822
			[Token(Token = "0x40041B6")]
			[FieldOffset(Offset = "0x58")]
			public float dashSpeed;

			// Token: 0x040041B7 RID: 16823
			[Token(Token = "0x40041B7")]
			[FieldOffset(Offset = "0x5C")]
			public float swimSpeed;

			// Token: 0x040041B8 RID: 16824
			[Token(Token = "0x40041B8")]
			[FieldOffset(Offset = "0x60")]
			public float acceleration;

			// Token: 0x040041B9 RID: 16825
			[Token(Token = "0x40041B9")]
			[FieldOffset(Offset = "0x64")]
			public float jumpSpeed;

			// Token: 0x040041BA RID: 16826
			[Token(Token = "0x40041BA")]
			[FieldOffset(Offset = "0x68")]
			public int jumpHeight;

			// Token: 0x040041BB RID: 16827
			[Token(Token = "0x40041BB")]
			[FieldOffset(Offset = "0x6C")]
			public float fallDamage;

			// Token: 0x040041BC RID: 16828
			[Token(Token = "0x40041BC")]
			[FieldOffset(Offset = "0x70")]
			public int extraFall;

			// Token: 0x040041BD RID: 16829
			[Token(Token = "0x40041BD")]
			[FieldOffset(Offset = "0x74")]
			public int fatigueMax;

			// Token: 0x040041BE RID: 16830
			[Token(Token = "0x40041BE")]
			[FieldOffset(Offset = "0x78")]
			public bool constantJump;

			// Token: 0x040041BF RID: 16831
			[Token(Token = "0x40041BF")]
			[FieldOffset(Offset = "0x79")]
			public bool blockExtraJumps;

			// Token: 0x040041C0 RID: 16832
			[Token(Token = "0x40041C0")]
			[FieldOffset(Offset = "0x7C")]
			public int abilityChargeMax;

			// Token: 0x040041C1 RID: 16833
			[Token(Token = "0x40041C1")]
			[FieldOffset(Offset = "0x80")]
			public int abilityDuration;

			// Token: 0x040041C2 RID: 16834
			[Token(Token = "0x40041C2")]
			[FieldOffset(Offset = "0x84")]
			public int abilityCooldown;

			// Token: 0x040041C3 RID: 16835
			[Token(Token = "0x40041C3")]
			[FieldOffset(Offset = "0x88")]
			public int walkingGraceTimeMax;

			// Token: 0x040041C4 RID: 16836
			[Token(Token = "0x40041C4")]
			[FieldOffset(Offset = "0x8C")]
			public bool dismountsOnItemUse;

			// Token: 0x040041C5 RID: 16837
			[Token(Token = "0x40041C5")]
			[FieldOffset(Offset = "0x90")]
			public int spawnDust;

			// Token: 0x040041C6 RID: 16838
			[Token(Token = "0x40041C6")]
			[FieldOffset(Offset = "0x94")]
			public bool spawnDustNoGravity;

			// Token: 0x040041C7 RID: 16839
			[Token(Token = "0x40041C7")]
			[FieldOffset(Offset = "0x98")]
			public int totalFrames;

			// Token: 0x040041C8 RID: 16840
			[Token(Token = "0x40041C8")]
			[FieldOffset(Offset = "0x9C")]
			public int standingFrameStart;

			// Token: 0x040041C9 RID: 16841
			[Token(Token = "0x40041C9")]
			[FieldOffset(Offset = "0xA0")]
			public int standingFrameCount;

			// Token: 0x040041CA RID: 16842
			[Token(Token = "0x40041CA")]
			[FieldOffset(Offset = "0xA4")]
			public int standingFrameDelay;

			// Token: 0x040041CB RID: 16843
			[Token(Token = "0x40041CB")]
			[FieldOffset(Offset = "0xA8")]
			public int runningFrameStart;

			// Token: 0x040041CC RID: 16844
			[Token(Token = "0x40041CC")]
			[FieldOffset(Offset = "0xAC")]
			public int runningFrameCount;

			// Token: 0x040041CD RID: 16845
			[Token(Token = "0x40041CD")]
			[FieldOffset(Offset = "0xB0")]
			public int runningFrameDelay;

			// Token: 0x040041CE RID: 16846
			[Token(Token = "0x40041CE")]
			[FieldOffset(Offset = "0xB4")]
			public int flyingFrameStart;

			// Token: 0x040041CF RID: 16847
			[Token(Token = "0x40041CF")]
			[FieldOffset(Offset = "0xB8")]
			public int flyingFrameCount;

			// Token: 0x040041D0 RID: 16848
			[Token(Token = "0x40041D0")]
			[FieldOffset(Offset = "0xBC")]
			public int flyingFrameDelay;

			// Token: 0x040041D1 RID: 16849
			[Token(Token = "0x40041D1")]
			[FieldOffset(Offset = "0xC0")]
			public int inAirFrameStart;

			// Token: 0x040041D2 RID: 16850
			[Token(Token = "0x40041D2")]
			[FieldOffset(Offset = "0xC4")]
			public int inAirFrameCount;

			// Token: 0x040041D3 RID: 16851
			[Token(Token = "0x40041D3")]
			[FieldOffset(Offset = "0xC8")]
			public int inAirFrameDelay;

			// Token: 0x040041D4 RID: 16852
			[Token(Token = "0x40041D4")]
			[FieldOffset(Offset = "0xCC")]
			public int idleFrameStart;

			// Token: 0x040041D5 RID: 16853
			[Token(Token = "0x40041D5")]
			[FieldOffset(Offset = "0xD0")]
			public int idleFrameCount;

			// Token: 0x040041D6 RID: 16854
			[Token(Token = "0x40041D6")]
			[FieldOffset(Offset = "0xD4")]
			public int idleFrameDelay;

			// Token: 0x040041D7 RID: 16855
			[Token(Token = "0x40041D7")]
			[FieldOffset(Offset = "0xD8")]
			public bool idleFrameLoop;

			// Token: 0x040041D8 RID: 16856
			[Token(Token = "0x40041D8")]
			[FieldOffset(Offset = "0xDC")]
			public int swimFrameStart;

			// Token: 0x040041D9 RID: 16857
			[Token(Token = "0x40041D9")]
			[FieldOffset(Offset = "0xE0")]
			public int swimFrameCount;

			// Token: 0x040041DA RID: 16858
			[Token(Token = "0x40041DA")]
			[FieldOffset(Offset = "0xE4")]
			public int swimFrameDelay;

			// Token: 0x040041DB RID: 16859
			[Token(Token = "0x40041DB")]
			[FieldOffset(Offset = "0xE8")]
			public int dashingFrameStart;

			// Token: 0x040041DC RID: 16860
			[Token(Token = "0x40041DC")]
			[FieldOffset(Offset = "0xEC")]
			public int dashingFrameCount;

			// Token: 0x040041DD RID: 16861
			[Token(Token = "0x40041DD")]
			[FieldOffset(Offset = "0xF0")]
			public int dashingFrameDelay;

			// Token: 0x040041DE RID: 16862
			[Token(Token = "0x40041DE")]
			[FieldOffset(Offset = "0xF4")]
			public bool Minecart;

			// Token: 0x040041DF RID: 16863
			[Token(Token = "0x40041DF")]
			[FieldOffset(Offset = "0xF5")]
			public bool CanRideMinecartTracks;

			// Token: 0x040041E0 RID: 16864
			[Token(Token = "0x40041E0")]
			[FieldOffset(Offset = "0xF6")]
			public bool CanUseWings;

			// Token: 0x040041E1 RID: 16865
			[Token(Token = "0x40041E1")]
			[FieldOffset(Offset = "0xF7")]
			public bool MovementStatsAreAdditive;

			// Token: 0x040041E2 RID: 16866
			[Token(Token = "0x40041E2")]
			[FieldOffset(Offset = "0xF8")]
			public Vector3 lightColor;

			// Token: 0x040041E3 RID: 16867
			[Token(Token = "0x40041E3")]
			[FieldOffset(Offset = "0x104")]
			public bool emitsLight;

			// Token: 0x040041E4 RID: 16868
			[Token(Token = "0x40041E4")]
			[FieldOffset(Offset = "0x108")]
			public Mount.MountDelegatesData delegations;

			// Token: 0x040041E5 RID: 16869
			[Token(Token = "0x40041E5")]
			[FieldOffset(Offset = "0x10C")]
			public int playerXOffset;
		}

		// Token: 0x020004E3 RID: 1251
		[Token(Token = "0x20004E3")]
		public enum DismountCheckResult
		{
			// Token: 0x040041E7 RID: 16871
			[Token(Token = "0x40041E7")]
			Succeeded,
			// Token: 0x040041E8 RID: 16872
			[Token(Token = "0x40041E8")]
			FailedCCed,
			// Token: 0x040041E9 RID: 16873
			[Token(Token = "0x40041E9")]
			FailedNoSpace
		}

		// Token: 0x020004E4 RID: 1252
		[Token(Token = "0x20004E4")]
		private sealed class <>c__DisplayClass162_0
		{
			// Token: 0x0600315F RID: 12639 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600315F")]
			[Address(RVA = "0x19F96B0", Offset = "0x19F96B0", VA = "0x19F96B0")]
			public <>c__DisplayClass162_0()
			{
			}

			// Token: 0x06003160 RID: 12640 RVA: 0x00017E50 File Offset: 0x00016050
			[Token(Token = "0x6003160")]
			[Address(RVA = "0x19F96B8", Offset = "0x19F96B8", VA = "0x19F96B8")]
			internal bool <DrillSmartCursor_Walls>b__0(int x, int y)
			{
				return default(bool);
			}

			// Token: 0x040041EA RID: 16874
			[Token(Token = "0x40041EA")]
			[FieldOffset(Offset = "0x8")]
			public Point16 tilePoint;

			// Token: 0x040041EB RID: 16875
			[Token(Token = "0x40041EB")]
			[FieldOffset(Offset = "0xC")]
			public Mount.DrillMountData data;
		}
	}
}
