using System;
using Il2CppDummyDll;
using Terraria.DataStructures;
using Terraria.Utilities;

namespace Terraria.GameContent.FishDropRules
{
	// Token: 0x02000AFB RID: 2811
	[Token(Token = "0x2000AFB")]
	public class FishingContext
	{
		// Token: 0x060057FD RID: 22525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057FD")]
		[Address(RVA = "0x85C10C", Offset = "0x85C10C", VA = "0x85C10C")]
		public FishingContext()
		{
		}

		// Token: 0x04009958 RID: 39256
		[Token(Token = "0x4009958")]
		[FieldOffset(Offset = "0x8")]
		public UnifiedRandom Random;

		// Token: 0x04009959 RID: 39257
		[Token(Token = "0x4009959")]
		[FieldOffset(Offset = "0xC")]
		public FishingAttempt Fisher;

		// Token: 0x0400995A RID: 39258
		[Token(Token = "0x400995A")]
		[FieldOffset(Offset = "0x68")]
		public Player Player;

		// Token: 0x0400995B RID: 39259
		[Token(Token = "0x400995B")]
		[FieldOffset(Offset = "0x6C")]
		public bool RolledCorruption;

		// Token: 0x0400995C RID: 39260
		[Token(Token = "0x400995C")]
		[FieldOffset(Offset = "0x6D")]
		public bool RolledCrimson;

		// Token: 0x0400995D RID: 39261
		[Token(Token = "0x400995D")]
		[FieldOffset(Offset = "0x6E")]
		public bool RolledJungle;

		// Token: 0x0400995E RID: 39262
		[Token(Token = "0x400995E")]
		[FieldOffset(Offset = "0x6F")]
		public bool RolledSnow;

		// Token: 0x0400995F RID: 39263
		[Token(Token = "0x400995F")]
		[FieldOffset(Offset = "0x70")]
		public bool RolledDesert;

		// Token: 0x04009960 RID: 39264
		[Token(Token = "0x4009960")]
		[FieldOffset(Offset = "0x71")]
		public bool RolledInfectedDesert;

		// Token: 0x04009961 RID: 39265
		[Token(Token = "0x4009961")]
		[FieldOffset(Offset = "0x72")]
		public bool RolledRemixOcean;
	}
}
