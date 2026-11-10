using System;
using Il2CppDummyDll;

namespace Terraria.UI
{
	// Token: 0x0200083F RID: 2111
	[Token(Token = "0x200083F")]
	public class GameInterfaceLayer
	{
		// Token: 0x060048FD RID: 18685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048FD")]
		[Address(RVA = "0x5F6868", Offset = "0x5F6868", VA = "0x5F6868")]
		public GameInterfaceLayer(string name, InterfaceScaleType scaleType)
		{
		}

		// Token: 0x060048FE RID: 18686 RVA: 0x00022C50 File Offset: 0x00020E50
		[Token(Token = "0x60048FE")]
		[Address(RVA = "0x5F688C", Offset = "0x5F688C", VA = "0x5F688C")]
		public bool Draw()
		{
			return default(bool);
		}

		// Token: 0x060048FF RID: 18687 RVA: 0x00022C68 File Offset: 0x00020E68
		[Token(Token = "0x60048FF")]
		[Address(RVA = "0x5F6E04", Offset = "0x5F6E04", VA = "0x5F6E04", Slot = "4")]
		protected virtual bool DrawSelf()
		{
			return default(bool);
		}

		// Token: 0x04008F17 RID: 36631
		[Token(Token = "0x4008F17")]
		[FieldOffset(Offset = "0x8")]
		public readonly string Name;

		// Token: 0x04008F18 RID: 36632
		[Token(Token = "0x4008F18")]
		[FieldOffset(Offset = "0xC")]
		public InterfaceScaleType ScaleType;
	}
}
