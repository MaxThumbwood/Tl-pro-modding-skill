using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.Graphics.Effects
{
	// Token: 0x02000903 RID: 2307
	[Token(Token = "0x2000903")]
	public abstract class CustomSky : GameEffect
	{
		// Token: 0x06004D84 RID: 19844
		[Token(Token = "0x6004D84")]
		public abstract void Update(GameTime gameTime);

		// Token: 0x06004D85 RID: 19845
		[Token(Token = "0x6004D85")]
		public abstract void Draw(SpriteBatch spriteBatch, float minDepth, float maxDepth);

		// Token: 0x06004D86 RID: 19846
		[Token(Token = "0x6004D86")]
		public abstract bool IsActive();

		// Token: 0x06004D87 RID: 19847
		[Token(Token = "0x6004D87")]
		public abstract void Reset();

		// Token: 0x06004D88 RID: 19848 RVA: 0x00024510 File Offset: 0x00022710
		[Token(Token = "0x6004D88")]
		[Address(RVA = "0x723C44", Offset = "0x723C44", VA = "0x723C44", Slot = "12")]
		public virtual Color OnTileColor(Color inColor)
		{
			return default(Color);
		}

		// Token: 0x06004D89 RID: 19849 RVA: 0x00024528 File Offset: 0x00022728
		[Token(Token = "0x6004D89")]
		[Address(RVA = "0x723C4C", Offset = "0x723C4C", VA = "0x723C4C", Slot = "13")]
		public virtual float GetCloudAlpha()
		{
			return 0f;
		}

		// Token: 0x06004D8A RID: 19850 RVA: 0x00024540 File Offset: 0x00022740
		[Token(Token = "0x6004D8A")]
		[Address(RVA = "0x723C54", Offset = "0x723C54", VA = "0x723C54", Slot = "5")]
		public override bool IsVisible()
		{
			return default(bool);
		}

		// Token: 0x06004D8B RID: 19851 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D8B")]
		[Address(RVA = "0x723C5C", Offset = "0x723C5C", VA = "0x723C5C")]
		protected CustomSky()
		{
		}
	}
}
