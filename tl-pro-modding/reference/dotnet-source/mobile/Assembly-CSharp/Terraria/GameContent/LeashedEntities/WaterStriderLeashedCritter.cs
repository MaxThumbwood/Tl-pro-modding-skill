using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

namespace Terraria.GameContent.LeashedEntities
{
	// Token: 0x02000A5D RID: 2653
	[Token(Token = "0x2000A5D")]
	internal class WaterStriderLeashedCritter : JumperLeashedCritter
	{
		// Token: 0x060054DF RID: 21727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054DF")]
		[Address(RVA = "0x81F5D0", Offset = "0x81F5D0", VA = "0x81F5D0")]
		public WaterStriderLeashedCritter()
		{
		}

		// Token: 0x060054E0 RID: 21728 RVA: 0x00027450 File Offset: 0x00025650
		[Token(Token = "0x60054E0")]
		[Address(RVA = "0x81F68C", Offset = "0x81F68C", VA = "0x81F68C", Slot = "14")]
		public override Vector2 GetDrawOffset()
		{
			return default(Vector2);
		}

		// Token: 0x04009838 RID: 38968
		[Token(Token = "0x4009838")]
		[FieldOffset(Offset = "0x0")]
		public new static WaterStriderLeashedCritter Prototype;
	}
}
