using System;
using Il2CppDummyDll;

namespace Terraria.DataStructures
{
	// Token: 0x020007B9 RID: 1977
	[Token(Token = "0x20007B9")]
	public class RejectionMenuInfo
	{
		// Token: 0x0600445B RID: 17499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600445B")]
		[Address(RVA = "0x559218", Offset = "0x559218", VA = "0x559218")]
		public void DefaultExitAction()
		{
		}

		// Token: 0x0600445C RID: 17500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600445C")]
		[Address(RVA = "0x5592B4", Offset = "0x5592B4", VA = "0x5592B4")]
		public RejectionMenuInfo()
		{
		}

		// Token: 0x04008BE2 RID: 35810
		[Token(Token = "0x4008BE2")]
		[FieldOffset(Offset = "0x8")]
		public ReturnFromRejectionMenuAction ExitAction;

		// Token: 0x04008BE3 RID: 35811
		[Token(Token = "0x4008BE3")]
		[FieldOffset(Offset = "0xC")]
		public string TextToShow;
	}
}
