using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

namespace ReLogic.OS.OSX
{
	// Token: 0x02000DF2 RID: 3570
	[Token(Token = "0x2000DF2")]
	internal class WindowService : FileAPI
	{
		// Token: 0x060068AA RID: 26794 RVA: 0x0002F8C8 File Offset: 0x0002DAC8
		[Token(Token = "0x60068AA")]
		[Address(RVA = "0xB81EE0", Offset = "0xB81EE0", VA = "0xB81EE0", Slot = "7")]
		public float GetScaling()
		{
			return 0f;
		}

		// Token: 0x060068AB RID: 26795 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068AB")]
		[Address(RVA = "0xB81EE8", Offset = "0xB81EE8", VA = "0xB81EE8", Slot = "8")]
		public void SetQuickEditEnabled(bool enabled)
		{
		}

		// Token: 0x060068AC RID: 26796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068AC")]
		[Address(RVA = "0xB81EEC", Offset = "0xB81EEC", VA = "0xB81EEC", Slot = "4")]
		public void SetUnicodeTitle(GameWindow window, string title)
		{
		}

		// Token: 0x060068AD RID: 26797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068AD")]
		[Address(RVA = "0xB81F18", Offset = "0xB81F18", VA = "0xB81F18", Slot = "5")]
		public void StartFlashingIcon(GameWindow window)
		{
		}

		// Token: 0x060068AE RID: 26798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068AE")]
		[Address(RVA = "0xB81F1C", Offset = "0xB81F1C", VA = "0xB81F1C", Slot = "6")]
		public void StopFlashingIcon(GameWindow window)
		{
		}

		// Token: 0x060068AF RID: 26799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068AF")]
		[Address(RVA = "0xB81F20", Offset = "0xB81F20", VA = "0xB81F20")]
		public WindowService()
		{
		}
	}
}
