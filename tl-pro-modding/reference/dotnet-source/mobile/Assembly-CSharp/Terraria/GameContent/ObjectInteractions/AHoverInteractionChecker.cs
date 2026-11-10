using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

namespace Terraria.GameContent.ObjectInteractions
{
	// Token: 0x02000A2D RID: 2605
	[Token(Token = "0x2000A2D")]
	public abstract class AHoverInteractionChecker
	{
		// Token: 0x06005403 RID: 21507 RVA: 0x00027078 File Offset: 0x00025278
		[Token(Token = "0x6005403")]
		[Address(RVA = "0x80E414", Offset = "0x80E414", VA = "0x80E414")]
		internal AHoverInteractionChecker.HoverStatus AttemptInteraction(Player player, Rectangle Hitbox)
		{
			return AHoverInteractionChecker.HoverStatus.NotSelectable;
		}

		// Token: 0x06005404 RID: 21508
		[Token(Token = "0x6005404")]
		internal abstract bool? AttemptOverridingHoverStatus(Player player, Rectangle rectangle);

		// Token: 0x06005405 RID: 21509
		[Token(Token = "0x6005405")]
		internal abstract void DoHoverEffect(Player player, Rectangle hitbox);

		// Token: 0x06005406 RID: 21510
		[Token(Token = "0x6005406")]
		internal abstract bool ShouldBlockInteraction(Player player, Rectangle hitbox);

		// Token: 0x06005407 RID: 21511
		[Token(Token = "0x6005407")]
		internal abstract void PerformInteraction(Player player, Rectangle hitbox);

		// Token: 0x06005408 RID: 21512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005408")]
		[Address(RVA = "0x80E9DC", Offset = "0x80E9DC", VA = "0x80E9DC")]
		protected AHoverInteractionChecker()
		{
		}

		// Token: 0x02000A2E RID: 2606
		[Token(Token = "0x2000A2E")]
		internal enum HoverStatus
		{
			// Token: 0x040097B6 RID: 38838
			[Token(Token = "0x40097B6")]
			NotSelectable,
			// Token: 0x040097B7 RID: 38839
			[Token(Token = "0x40097B7")]
			SelectableButNotSelected,
			// Token: 0x040097B8 RID: 38840
			[Token(Token = "0x40097B8")]
			Selected
		}
	}
}
