using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent.UI.BigProgressBar
{
	// Token: 0x02000DBD RID: 3517
	[Token(Token = "0x2000DBD")]
	public abstract class LunarPillarBigProgessBar : FileAPI
	{
		// Token: 0x0600676F RID: 26479 RVA: 0x0002E9F8 File Offset: 0x0002CBF8
		[Token(Token = "0x600676F")]
		[Address(RVA = "0xB74D68", Offset = "0xB74D68", VA = "0xB74D68", Slot = "4")]
		public bool ValidateAndCollectNecessaryInfo(ref BigProgressBarInfo info)
		{
			return default(bool);
		}

		// Token: 0x06006770 RID: 26480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006770")]
		[Address(RVA = "0xB74F94", Offset = "0xB74F94", VA = "0xB74F94", Slot = "5")]
		public void Draw(ref BigProgressBarInfo info, SpriteBatch spriteBatch)
		{
		}

		// Token: 0x06006771 RID: 26481
		[Token(Token = "0x6006771")]
		internal abstract float GetCurrentShieldValue();

		// Token: 0x06006772 RID: 26482
		[Token(Token = "0x6006772")]
		internal abstract float GetMaxShieldValue();

		// Token: 0x06006773 RID: 26483
		[Token(Token = "0x6006773")]
		internal abstract bool IsPlayerInCombatArea();

		// Token: 0x06006774 RID: 26484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006774")]
		[Address(RVA = "0xB75130", Offset = "0xB75130", VA = "0xB75130")]
		protected LunarPillarBigProgessBar()
		{
		}

		// Token: 0x0400A45E RID: 42078
		[Token(Token = "0x400A45E")]
		[FieldOffset(Offset = "0x8")]
		private BigProgressBarCache _cache;

		// Token: 0x0400A45F RID: 42079
		[Token(Token = "0x400A45F")]
		[FieldOffset(Offset = "0x18")]
		private int _headIndex;
	}
}
