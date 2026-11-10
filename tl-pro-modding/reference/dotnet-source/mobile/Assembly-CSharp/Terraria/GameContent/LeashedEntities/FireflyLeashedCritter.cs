using System;
using Il2CppDummyDll;

namespace Terraria.GameContent.LeashedEntities
{
	// Token: 0x02000A54 RID: 2644
	[Token(Token = "0x2000A54")]
	public class FireflyLeashedCritter : FlyLeashedCritter
	{
		// Token: 0x060054B4 RID: 21684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054B4")]
		[Address(RVA = "0x81B864", Offset = "0x81B864", VA = "0x81B864", Slot = "13")]
		protected override void CopyToDummy()
		{
		}

		// Token: 0x060054B5 RID: 21685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054B5")]
		[Address(RVA = "0x81B99C", Offset = "0x81B99C", VA = "0x81B99C", Slot = "12")]
		protected override void VisualEffects()
		{
		}

		// Token: 0x060054B6 RID: 21686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054B6")]
		[Address(RVA = "0x81BB20", Offset = "0x81BB20", VA = "0x81BB20")]
		private void AddLight()
		{
		}

		// Token: 0x060054B7 RID: 21687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054B7")]
		[Address(RVA = "0x81B9D8", Offset = "0x81B9D8", VA = "0x81B9D8")]
		private void UpdateTimer()
		{
		}

		// Token: 0x060054B8 RID: 21688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054B8")]
		[Address(RVA = "0x81BD00", Offset = "0x81BD00", VA = "0x81BD00")]
		public FireflyLeashedCritter()
		{
		}

		// Token: 0x04009820 RID: 38944
		[Token(Token = "0x4009820")]
		[FieldOffset(Offset = "0x0")]
		public new static FireflyLeashedCritter Prototype;

		// Token: 0x04009821 RID: 38945
		[Token(Token = "0x4009821")]
		[FieldOffset(Offset = "0xA5")]
		private bool lightOn;

		// Token: 0x04009822 RID: 38946
		[Token(Token = "0x4009822")]
		[FieldOffset(Offset = "0xA8")]
		private int timer;
	}
}
