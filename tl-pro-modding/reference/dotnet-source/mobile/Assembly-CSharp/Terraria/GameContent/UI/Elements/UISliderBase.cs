using System;
using Il2CppDummyDll;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements
{
	// Token: 0x02000D76 RID: 3446
	[Token(Token = "0x2000D76")]
	public class UISliderBase : UIElement
	{
		// Token: 0x060065FC RID: 26108 RVA: 0x0002E3C8 File Offset: 0x0002C5C8
		[Token(Token = "0x60065FC")]
		[Address(RVA = "0xB581DC", Offset = "0xB581DC", VA = "0xB581DC")]
		internal int GetUsageLevel()
		{
			return 0;
		}

		// Token: 0x060065FD RID: 26109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065FD")]
		[Address(RVA = "0xB5824C", Offset = "0xB5824C", VA = "0xB5824C")]
		public static void EscapeElements()
		{
		}

		// Token: 0x060065FE RID: 26110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065FE")]
		[Address(RVA = "0xB582AC", Offset = "0xB582AC", VA = "0xB582AC")]
		public UISliderBase()
		{
		}

		// Token: 0x0400A33D RID: 41789
		[Token(Token = "0x400A33D")]
		internal const int UsageLevel_NotSelected = 0;

		// Token: 0x0400A33E RID: 41790
		[Token(Token = "0x400A33E")]
		internal const int UsageLevel_SelectedAndLocked = 1;

		// Token: 0x0400A33F RID: 41791
		[Token(Token = "0x400A33F")]
		internal const int UsageLevel_OtherElementIsLocked = 2;

		// Token: 0x0400A340 RID: 41792
		[Token(Token = "0x400A340")]
		[FieldOffset(Offset = "0x0")]
		public static UIElement CurrentLockedSlider;

		// Token: 0x0400A341 RID: 41793
		[Token(Token = "0x400A341")]
		[FieldOffset(Offset = "0x4")]
		public static UIElement CurrentAimedSlider;
	}
}
