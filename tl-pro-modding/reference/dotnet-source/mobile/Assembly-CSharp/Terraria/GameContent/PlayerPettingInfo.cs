using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

namespace Terraria.GameContent
{
	// Token: 0x020009B7 RID: 2487
	[Token(Token = "0x20009B7")]
	public struct PlayerPettingInfo
	{
		// Token: 0x06005166 RID: 20838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005166")]
		[Address(RVA = "0x77A530", Offset = "0x77A530", VA = "0x77A530")]
		public PlayerPettingInfo(NPC npc, Vector2 offsetFromPet, bool isPetSmall)
		{
		}

		// Token: 0x06005167 RID: 20839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005167")]
		[Address(RVA = "0x77A5A8", Offset = "0x77A5A8", VA = "0x77A5A8")]
		public PlayerPettingInfo(Projectile proj, Vector2 offsetFromPet, bool isPetSmall)
		{
		}

		// Token: 0x06005168 RID: 20840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005168")]
		[Address(RVA = "0x77A618", Offset = "0x77A618", VA = "0x77A618")]
		public PlayerPettingInfo(int mountId, bool isPetSmall)
		{
		}

		// Token: 0x06005169 RID: 20841 RVA: 0x00025D40 File Offset: 0x00023F40
		[Token(Token = "0x6005169")]
		[Address(RVA = "0x77A6FC", Offset = "0x77A6FC", VA = "0x77A6FC")]
		public bool TryGetTarget(out Entity target)
		{
			return default(bool);
		}

		// Token: 0x040094D0 RID: 38096
		[Token(Token = "0x40094D0")]
		[FieldOffset(Offset = "0x0")]
		public bool isPetting;

		// Token: 0x040094D1 RID: 38097
		[Token(Token = "0x40094D1")]
		[FieldOffset(Offset = "0x4")]
		public int npc;

		// Token: 0x040094D2 RID: 38098
		[Token(Token = "0x40094D2")]
		[FieldOffset(Offset = "0x8")]
		public int proj;

		// Token: 0x040094D3 RID: 38099
		[Token(Token = "0x40094D3")]
		[FieldOffset(Offset = "0xC")]
		public int type;

		// Token: 0x040094D4 RID: 38100
		[Token(Token = "0x40094D4")]
		[FieldOffset(Offset = "0x10")]
		public bool mount;

		// Token: 0x040094D5 RID: 38101
		[Token(Token = "0x40094D5")]
		[FieldOffset(Offset = "0x14")]
		public Vector2 offsetFromPet;

		// Token: 0x040094D6 RID: 38102
		[Token(Token = "0x40094D6")]
		[FieldOffset(Offset = "0x1C")]
		public bool isPetSmall;
	}
}
