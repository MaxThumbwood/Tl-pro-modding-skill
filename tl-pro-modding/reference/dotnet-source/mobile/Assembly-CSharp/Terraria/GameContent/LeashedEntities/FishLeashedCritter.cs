using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

namespace Terraria.GameContent.LeashedEntities
{
	// Token: 0x02000A5A RID: 2650
	[Token(Token = "0x2000A5A")]
	public class FishLeashedCritter : FlyerLeashedCritter
	{
		// Token: 0x060054CB RID: 21707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054CB")]
		[Address(RVA = "0x81D054", Offset = "0x81D054", VA = "0x81D054")]
		public FishLeashedCritter()
		{
		}

		// Token: 0x060054CC RID: 21708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054CC")]
		[Address(RVA = "0x81D0FC", Offset = "0x81D0FC", VA = "0x81D0FC", Slot = "13")]
		protected override void CopyToDummy()
		{
		}

		// Token: 0x060054CD RID: 21709 RVA: 0x000273D8 File Offset: 0x000255D8
		[Token(Token = "0x60054CD")]
		[Address(RVA = "0x81D210", Offset = "0x81D210", VA = "0x81D210", Slot = "14")]
		public override Vector2 GetDrawOffset()
		{
			return default(Vector2);
		}

		// Token: 0x0400982A RID: 38954
		[Token(Token = "0x400982A")]
		[FieldOffset(Offset = "0x0")]
		public new static FishLeashedCritter Prototype;
	}
}
