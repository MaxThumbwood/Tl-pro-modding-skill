using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

namespace Terraria
{
	// Token: 0x020004F1 RID: 1265
	[Token(Token = "0x20004F1")]
	public class Rain
	{
		// Token: 0x06003185 RID: 12677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003185")]
		[Address(RVA = "0x19FC8E0", Offset = "0x19FC8E0", VA = "0x19FC8E0")]
		public static void ClearRain()
		{
		}

		// Token: 0x06003186 RID: 12678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003186")]
		[Address(RVA = "0x19FC9A0", Offset = "0x19FC9A0", VA = "0x19FC9A0")]
		public static void MakeRain()
		{
		}

		// Token: 0x06003187 RID: 12679 RVA: 0x00017EC8 File Offset: 0x000160C8
		[Token(Token = "0x6003187")]
		[Address(RVA = "0x19FD1CC", Offset = "0x19FD1CC", VA = "0x19FD1CC")]
		public static Vector2 GetRainFallVelocity()
		{
			return default(Vector2);
		}

		// Token: 0x06003188 RID: 12680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003188")]
		[Address(RVA = "0x19FD8B8", Offset = "0x19FD8B8", VA = "0x19FD8B8")]
		public void Update()
		{
		}

		// Token: 0x06003189 RID: 12681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003189")]
		[Address(RVA = "0x19FDB80", Offset = "0x19FDB80", VA = "0x19FDB80")]
		public void Collided()
		{
		}

		// Token: 0x0600318A RID: 12682 RVA: 0x00017EE0 File Offset: 0x000160E0
		[Token(Token = "0x600318A")]
		[Address(RVA = "0x19FDFD4", Offset = "0x19FDFD4", VA = "0x19FDFD4")]
		public static int NewRainForced(Vector2 Position, Vector2 Velocity)
		{
			return 0;
		}

		// Token: 0x0600318B RID: 12683 RVA: 0x00017EF8 File Offset: 0x000160F8
		[Token(Token = "0x600318B")]
		[Address(RVA = "0x19FD268", Offset = "0x19FD268", VA = "0x19FD268")]
		private static int NewRain(Vector2 Position, Vector2 Velocity)
		{
			return 0;
		}

		// Token: 0x0600318C RID: 12684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600318C")]
		[Address(RVA = "0x19FE3C0", Offset = "0x19FE3C0", VA = "0x19FE3C0")]
		public Rain()
		{
		}

		// Token: 0x0400423B RID: 16955
		[Token(Token = "0x400423B")]
		[FieldOffset(Offset = "0x8")]
		public Vector2 position;

		// Token: 0x0400423C RID: 16956
		[Token(Token = "0x400423C")]
		[FieldOffset(Offset = "0x10")]
		public Vector2 velocity;

		// Token: 0x0400423D RID: 16957
		[Token(Token = "0x400423D")]
		[FieldOffset(Offset = "0x18")]
		public float scale;

		// Token: 0x0400423E RID: 16958
		[Token(Token = "0x400423E")]
		[FieldOffset(Offset = "0x1C")]
		public float rotation;

		// Token: 0x0400423F RID: 16959
		[Token(Token = "0x400423F")]
		[FieldOffset(Offset = "0x20")]
		public int alpha;

		// Token: 0x04004240 RID: 16960
		[Token(Token = "0x4004240")]
		[FieldOffset(Offset = "0x24")]
		public bool active;

		// Token: 0x04004241 RID: 16961
		[Token(Token = "0x4004241")]
		[FieldOffset(Offset = "0x25")]
		public byte type;
	}
}
