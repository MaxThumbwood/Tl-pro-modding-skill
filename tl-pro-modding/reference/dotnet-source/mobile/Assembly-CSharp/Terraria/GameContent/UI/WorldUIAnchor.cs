using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

namespace Terraria.GameContent.UI
{
	// Token: 0x02000D3D RID: 3389
	[Token(Token = "0x2000D3D")]
	public class WorldUIAnchor
	{
		// Token: 0x06006475 RID: 25717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006475")]
		[Address(RVA = "0xB2B99C", Offset = "0xB2B99C", VA = "0xB2B99C")]
		public WorldUIAnchor()
		{
		}

		// Token: 0x06006476 RID: 25718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006476")]
		[Address(RVA = "0xB2BAD0", Offset = "0xB2BAD0", VA = "0xB2BAD0")]
		public WorldUIAnchor(Entity anchor)
		{
		}

		// Token: 0x06006477 RID: 25719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006477")]
		[Address(RVA = "0xB2BC0C", Offset = "0xB2BC0C", VA = "0xB2BC0C")]
		public WorldUIAnchor(Vector2 anchor)
		{
		}

		// Token: 0x06006478 RID: 25720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006478")]
		[Address(RVA = "0xB2BD50", Offset = "0xB2BD50", VA = "0xB2BD50")]
		public WorldUIAnchor(int topLeftX, int topLeftY, int width, int height)
		{
		}

		// Token: 0x06006479 RID: 25721 RVA: 0x0002DFF0 File Offset: 0x0002C1F0
		[Token(Token = "0x6006479")]
		[Address(RVA = "0xB2BF64", Offset = "0xB2BF64", VA = "0xB2BF64")]
		public bool InRange(Vector2 target, float tileRangeX, float tileRangeY)
		{
			return default(bool);
		}

		// Token: 0x0400A1F8 RID: 41464
		[Token(Token = "0x400A1F8")]
		[FieldOffset(Offset = "0x8")]
		public WorldUIAnchor.AnchorType type;

		// Token: 0x0400A1F9 RID: 41465
		[Token(Token = "0x400A1F9")]
		[FieldOffset(Offset = "0xC")]
		public Entity entity;

		// Token: 0x0400A1FA RID: 41466
		[Token(Token = "0x400A1FA")]
		[FieldOffset(Offset = "0x10")]
		public Vector2 pos;

		// Token: 0x0400A1FB RID: 41467
		[Token(Token = "0x400A1FB")]
		[FieldOffset(Offset = "0x18")]
		public Vector2 size;

		// Token: 0x02000D3E RID: 3390
		[Token(Token = "0x2000D3E")]
		public enum AnchorType
		{
			// Token: 0x0400A1FD RID: 41469
			[Token(Token = "0x400A1FD")]
			Entity,
			// Token: 0x0400A1FE RID: 41470
			[Token(Token = "0x400A1FE")]
			Tile,
			// Token: 0x0400A1FF RID: 41471
			[Token(Token = "0x400A1FF")]
			Pos,
			// Token: 0x0400A200 RID: 41472
			[Token(Token = "0x400A200")]
			None
		}
	}
}
