using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

namespace ReLogic.OS.Linux
{
	// Token: 0x02000DF5 RID: 3573
	[Token(Token = "0x2000DF5")]
	internal class WindowService : FileAPI
	{
		// Token: 0x060068B6 RID: 26806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068B6")]
		[Address(RVA = "0xB82BB8", Offset = "0xB82BB8", VA = "0xB82BB8", Slot = "4")]
		public void SetUnicodeTitle(GameWindow window, string title)
		{
		}

		// Token: 0x060068B7 RID: 26807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068B7")]
		[Address(RVA = "0xB82BE4", Offset = "0xB82BE4", VA = "0xB82BE4", Slot = "5")]
		public void StartFlashingIcon(GameWindow window)
		{
		}

		// Token: 0x060068B8 RID: 26808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068B8")]
		[Address(RVA = "0xB82BE8", Offset = "0xB82BE8", VA = "0xB82BE8", Slot = "6")]
		public void StopFlashingIcon(GameWindow window)
		{
		}

		// Token: 0x060068B9 RID: 26809 RVA: 0x0002F8E0 File Offset: 0x0002DAE0
		[Token(Token = "0x60068B9")]
		[Address(RVA = "0xB82BEC", Offset = "0xB82BEC", VA = "0xB82BEC", Slot = "7")]
		public float GetScaling()
		{
			return 0f;
		}

		// Token: 0x060068BA RID: 26810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068BA")]
		[Address(RVA = "0xB82BF4", Offset = "0xB82BF4", VA = "0xB82BF4", Slot = "8")]
		public void SetQuickEditEnabled(bool enabled)
		{
		}

		// Token: 0x060068BB RID: 26811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068BB")]
		[Address(RVA = "0xB82BF8", Offset = "0xB82BF8", VA = "0xB82BF8")]
		public WindowService()
		{
		}
	}
}
