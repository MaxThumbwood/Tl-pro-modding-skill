using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent
{
	// Token: 0x02000939 RID: 2361
	[Token(Token = "0x2000939")]
	public class PortalHelper
	{
		// Token: 0x06004ED5 RID: 20181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004ED5")]
		[Address(RVA = "0x73C460", Offset = "0x73C460", VA = "0x73C460")]
		public static void UpdatePortalPoints()
		{
		}

		// Token: 0x06004ED6 RID: 20182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004ED6")]
		[Address(RVA = "0x73C910", Offset = "0x73C910", VA = "0x73C910")]
		public static void ResetNPCSlotData(int npcIndex)
		{
		}

		// Token: 0x06004ED7 RID: 20183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004ED7")]
		[Address(RVA = "0x73C990", Offset = "0x73C990", VA = "0x73C990")]
		public static void TryGoingThroughPortals(Entity ent)
		{
		}

		// Token: 0x06004ED8 RID: 20184 RVA: 0x00024AE0 File Offset: 0x00022CE0
		[Token(Token = "0x6004ED8")]
		[Address(RVA = "0x73E4D0", Offset = "0x73E4D0", VA = "0x73E4D0")]
		public static int TryPlacingPortal(Projectile theBolt, Vector2 velocity, Vector2 theCrashVelocity)
		{
			return 0;
		}

		// Token: 0x06004ED9 RID: 20185 RVA: 0x00024AF8 File Offset: 0x00022CF8
		[Token(Token = "0x6004ED9")]
		[Address(RVA = "0x73F100", Offset = "0x73F100", VA = "0x73F100")]
		private static bool FindValidLine(Point position, int xOffset, int yOffset, out Point bestPosition)
		{
			return default(bool);
		}

		// Token: 0x06004EDA RID: 20186 RVA: 0x00024B10 File Offset: 0x00022D10
		[Token(Token = "0x6004EDA")]
		[Address(RVA = "0x73F4B8", Offset = "0x73F4B8", VA = "0x73F4B8")]
		private static bool IsValidLine(Point position, int xOffset, int yOffset)
		{
			return default(bool);
		}

		// Token: 0x06004EDB RID: 20187 RVA: 0x00024B28 File Offset: 0x00022D28
		[Token(Token = "0x6004EDB")]
		[Address(RVA = "0x73FC28", Offset = "0x73FC28", VA = "0x73FC28")]
		private static bool CanPlacePortalOn(Tile t)
		{
			return default(bool);
		}

		// Token: 0x06004EDC RID: 20188 RVA: 0x00024B40 File Offset: 0x00022D40
		[Token(Token = "0x6004EDC")]
		[Address(RVA = "0x73FD78", Offset = "0x73FD78", VA = "0x73FD78")]
		private static bool DoesTileTypeSupportPortals(ushort tileType)
		{
			return default(bool);
		}

		// Token: 0x06004EDD RID: 20189 RVA: 0x00024B58 File Offset: 0x00022D58
		[Token(Token = "0x6004EDD")]
		[Address(RVA = "0x73F8FC", Offset = "0x73F8FC", VA = "0x73F8FC")]
		private static bool BlockPortals(Tile t)
		{
			return default(bool);
		}

		// Token: 0x06004EDE RID: 20190 RVA: 0x00024B70 File Offset: 0x00022D70
		[Token(Token = "0x6004EDE")]
		[Address(RVA = "0x73EF20", Offset = "0x73EF20", VA = "0x73EF20")]
		private static Vector2 FindCollision(Vector2 startPosition, Vector2 stopPosition)
		{
			return default(Vector2);
		}

		// Token: 0x06004EDF RID: 20191 RVA: 0x00024B88 File Offset: 0x00022D88
		[Token(Token = "0x6004EDF")]
		[Address(RVA = "0x73F2C0", Offset = "0x73F2C0", VA = "0x73F2C0")]
		private static int AddPortal(Projectile sourceProjectile, Vector2 position, float angle, int form, int direction)
		{
			return 0;
		}

		// Token: 0x06004EE0 RID: 20192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EE0")]
		[Address(RVA = "0x740430", Offset = "0x740430", VA = "0x740430")]
		private static void RemoveMyOldPortal(int form)
		{
		}

		// Token: 0x06004EE1 RID: 20193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EE1")]
		[Address(RVA = "0x740550", Offset = "0x740550", VA = "0x740550")]
		private static void RemoveIntersectingPortals(Vector2 position, float angle)
		{
		}

		// Token: 0x06004EE2 RID: 20194 RVA: 0x00024BA0 File Offset: 0x00022DA0
		[Token(Token = "0x6004EE2")]
		[Address(RVA = "0x7408A8", Offset = "0x7408A8", VA = "0x7408A8")]
		public static Color GetPortalColor(int colorIndex)
		{
			return default(Color);
		}

		// Token: 0x06004EE3 RID: 20195 RVA: 0x00024BB8 File Offset: 0x00022DB8
		[Token(Token = "0x6004EE3")]
		[Address(RVA = "0x740918", Offset = "0x740918", VA = "0x740918")]
		public static Color GetPortalColor(int player, int portal)
		{
			return default(Color);
		}

		// Token: 0x06004EE4 RID: 20196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EE4")]
		[Address(RVA = "0x73E00C", Offset = "0x73E00C", VA = "0x73E00C")]
		private static void GetPortalEdges(Vector2 position, float angle, out Vector2 start, out Vector2 end)
		{
		}

		// Token: 0x06004EE5 RID: 20197 RVA: 0x00024BD0 File Offset: 0x00022DD0
		[Token(Token = "0x6004EE5")]
		[Address(RVA = "0x73E158", Offset = "0x73E158", VA = "0x73E158")]
		private static Vector2 GetPortalOutingPoint(Vector2 objectSize, Vector2 portalPosition, float portalAngle, out int bonusX, out int bonusY)
		{
			return default(Vector2);
		}

		// Token: 0x06004EE6 RID: 20198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EE6")]
		[Address(RVA = "0x740A74", Offset = "0x740A74", VA = "0x740A74")]
		public static void SyncPortalsOnPlayerJoin(int plr, int fluff, List<Point> dontInclude, out List<Point> portalSections)
		{
		}

		// Token: 0x06004EE7 RID: 20199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EE7")]
		[Address(RVA = "0x740F0C", Offset = "0x740F0C", VA = "0x740F0C")]
		public static void SyncPortalSections(Vector2 portalPosition, int fluff)
		{
		}

		// Token: 0x06004EE8 RID: 20200 RVA: 0x00024BE8 File Offset: 0x00022DE8
		[Token(Token = "0x6004EE8")]
		[Address(RVA = "0x73FD90", Offset = "0x73FD90", VA = "0x73FD90")]
		public static bool SupportedTilesAreFine(Vector2 portalCenter, float portalAngle)
		{
			return default(bool);
		}

		// Token: 0x06004EE9 RID: 20201 RVA: 0x00024C00 File Offset: 0x00022E00
		[Token(Token = "0x6004EE9")]
		[Address(RVA = "0x741068", Offset = "0x741068", VA = "0x741068")]
		private static bool SupportedSlope(int x, int y, int slope)
		{
			return default(bool);
		}

		// Token: 0x06004EEA RID: 20202 RVA: 0x00024C18 File Offset: 0x00022E18
		[Token(Token = "0x6004EEA")]
		[Address(RVA = "0x741A6C", Offset = "0x741A6C", VA = "0x741A6C")]
		private static bool SupportedHalfbrick(int x, int y)
		{
			return default(bool);
		}

		// Token: 0x06004EEB RID: 20203 RVA: 0x00024C30 File Offset: 0x00022E30
		[Token(Token = "0x6004EEB")]
		[Address(RVA = "0x7414D4", Offset = "0x7414D4", VA = "0x7414D4")]
		private static bool SupportedNormal(int x, int y)
		{
			return default(bool);
		}

		// Token: 0x06004EEC RID: 20204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EEC")]
		[Address(RVA = "0x741ED0", Offset = "0x741ED0", VA = "0x741ED0")]
		public PortalHelper()
		{
		}

		// Token: 0x04009341 RID: 37697
		[Token(Token = "0x4009341")]
		[FieldOffset(Offset = "0x0")]
		private static int[,] FoundPortals;

		// Token: 0x04009342 RID: 37698
		[Token(Token = "0x4009342")]
		[FieldOffset(Offset = "0x4")]
		private static int[] PortalCooldownForPlayers;

		// Token: 0x04009343 RID: 37699
		[Token(Token = "0x4009343")]
		[FieldOffset(Offset = "0x8")]
		private static int[] PortalCooldownForNPCs;

		// Token: 0x04009344 RID: 37700
		[Token(Token = "0x4009344")]
		[FieldOffset(Offset = "0xC")]
		private static bool anyPortalAtAll;

		// Token: 0x04009345 RID: 37701
		[Token(Token = "0x4009345")]
		public const int PORTALS_PER_PERSON = 2;

		// Token: 0x04009346 RID: 37702
		[Token(Token = "0x4009346")]
		[FieldOffset(Offset = "0x10")]
		private static readonly Vector2[] EDGES;

		// Token: 0x04009347 RID: 37703
		[Token(Token = "0x4009347")]
		[FieldOffset(Offset = "0x14")]
		private static readonly Vector2[] SLOPE_EDGES;

		// Token: 0x04009348 RID: 37704
		[Token(Token = "0x4009348")]
		[FieldOffset(Offset = "0x18")]
		private static readonly Point[] SLOPE_OFFSETS;

		// Token: 0x0200093A RID: 2362
		[Token(Token = "0x200093A")]
		private sealed class <>c__DisplayClass18_0
		{
			// Token: 0x06004EED RID: 20205 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004EED")]
			[Address(RVA = "0x73FD84", Offset = "0x73FD84", VA = "0x73FD84")]
			public <>c__DisplayClass18_0()
			{
			}

			// Token: 0x06004EEE RID: 20206 RVA: 0x00024C48 File Offset: 0x00022E48
			[Token(Token = "0x6004EEE")]
			[Address(RVA = "0x741ED8", Offset = "0x741ED8", VA = "0x741ED8")]
			internal bool <FindCollision>b__0(int x, int y)
			{
				return default(bool);
			}

			// Token: 0x04009349 RID: 37705
			[Token(Token = "0x4009349")]
			[FieldOffset(Offset = "0x8")]
			public int lastX;

			// Token: 0x0400934A RID: 37706
			[Token(Token = "0x400934A")]
			[FieldOffset(Offset = "0xC")]
			public int lastY;
		}
	}
}
