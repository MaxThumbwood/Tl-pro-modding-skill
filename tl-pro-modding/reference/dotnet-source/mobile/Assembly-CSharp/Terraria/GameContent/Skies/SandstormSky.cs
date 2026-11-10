using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Graphics.Effects;
using Terraria.Utilities;

namespace Terraria.GameContent.Skies
{
	// Token: 0x02000C8C RID: 3212
	[Token(Token = "0x2000C8C")]
	public class SandstormSky : CustomSky
	{
		// Token: 0x06005F16 RID: 24342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F16")]
		[Address(RVA = "0xA88618", Offset = "0xA88618", VA = "0xA88618", Slot = "4")]
		public override void OnLoad()
		{
		}

		// Token: 0x06005F17 RID: 24343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F17")]
		[Address(RVA = "0xA8861C", Offset = "0xA8861C", VA = "0xA8861C", Slot = "8")]
		public override void Update(GameTime gameTime)
		{
		}

		// Token: 0x06005F18 RID: 24344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F18")]
		[Address(RVA = "0xA88730", Offset = "0xA88730", VA = "0xA88730", Slot = "9")]
		public override void Draw(SpriteBatch spriteBatch, float minDepth, float maxDepth)
		{
		}

		// Token: 0x06005F19 RID: 24345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F19")]
		[Address(RVA = "0xA88A28", Offset = "0xA88A28", VA = "0xA88A28", Slot = "6")]
		public override void Activate(Vector2 position, object[] args)
		{
		}

		// Token: 0x06005F1A RID: 24346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F1A")]
		[Address(RVA = "0xA88A34", Offset = "0xA88A34", VA = "0xA88A34", Slot = "7")]
		public override void Deactivate(object[] args)
		{
		}

		// Token: 0x06005F1B RID: 24347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F1B")]
		[Address(RVA = "0xA88A40", Offset = "0xA88A40", VA = "0xA88A40", Slot = "11")]
		public override void Reset()
		{
		}

		// Token: 0x06005F1C RID: 24348 RVA: 0x0002BFE0 File Offset: 0x0002A1E0
		[Token(Token = "0x6005F1C")]
		[Address(RVA = "0xA88A50", Offset = "0xA88A50", VA = "0xA88A50", Slot = "10")]
		public override bool IsActive()
		{
			return default(bool);
		}

		// Token: 0x06005F1D RID: 24349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F1D")]
		[Address(RVA = "0xA88A58", Offset = "0xA88A58", VA = "0xA88A58")]
		public SandstormSky()
		{
		}

		// Token: 0x04009E74 RID: 40564
		[Token(Token = "0x4009E74")]
		[FieldOffset(Offset = "0x14")]
		private UnifiedRandom _random;

		// Token: 0x04009E75 RID: 40565
		[Token(Token = "0x4009E75")]
		[FieldOffset(Offset = "0x18")]
		private bool _isActive;

		// Token: 0x04009E76 RID: 40566
		[Token(Token = "0x4009E76")]
		[FieldOffset(Offset = "0x19")]
		private bool _isLeaving;

		// Token: 0x04009E77 RID: 40567
		[Token(Token = "0x4009E77")]
		[FieldOffset(Offset = "0x1C")]
		private float _opacity;
	}
}
