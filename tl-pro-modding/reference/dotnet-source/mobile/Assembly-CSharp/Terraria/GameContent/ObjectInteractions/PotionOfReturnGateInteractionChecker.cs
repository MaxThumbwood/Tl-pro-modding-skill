using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

namespace Terraria.GameContent.ObjectInteractions
{
	// Token: 0x02000A3E RID: 2622
	[Token(Token = "0x2000A3E")]
	public class PotionOfReturnGateInteractionChecker : AHoverInteractionChecker
	{
		// Token: 0x0600543A RID: 21562 RVA: 0x000271B0 File Offset: 0x000253B0
		[Token(Token = "0x600543A")]
		[Address(RVA = "0x812F04", Offset = "0x812F04", VA = "0x812F04", Slot = "4")]
		internal override bool? AttemptOverridingHoverStatus(Player player, Rectangle rectangle)
		{
			return null;
		}

		// Token: 0x0600543B RID: 21563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600543B")]
		[Address(RVA = "0x812FB0", Offset = "0x812FB0", VA = "0x812FB0", Slot = "5")]
		internal override void DoHoverEffect(Player player, Rectangle hitbox)
		{
		}

		// Token: 0x0600543C RID: 21564 RVA: 0x000271C8 File Offset: 0x000253C8
		[Token(Token = "0x600543C")]
		[Address(RVA = "0x813004", Offset = "0x813004", VA = "0x813004", Slot = "6")]
		internal override bool ShouldBlockInteraction(Player player, Rectangle hitbox)
		{
			return default(bool);
		}

		// Token: 0x0600543D RID: 21565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600543D")]
		[Address(RVA = "0x81306C", Offset = "0x81306C", VA = "0x81306C", Slot = "7")]
		internal override void PerformInteraction(Player player, Rectangle hitbox)
		{
		}

		// Token: 0x0600543E RID: 21566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600543E")]
		[Address(RVA = "0x813090", Offset = "0x813090", VA = "0x813090")]
		public PotionOfReturnGateInteractionChecker()
		{
		}
	}
}
