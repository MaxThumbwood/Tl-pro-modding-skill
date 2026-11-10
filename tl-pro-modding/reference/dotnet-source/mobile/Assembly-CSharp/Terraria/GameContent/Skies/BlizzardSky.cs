using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Graphics.Effects;
using Terraria.Utilities;

namespace Terraria.GameContent.Skies
{
	// Token: 0x02000C7F RID: 3199
	[Token(Token = "0x2000C7F")]
	public class BlizzardSky : CustomSky
	{
		// Token: 0x06005EC1 RID: 24257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EC1")]
		[Address(RVA = "0x9CB5C4", Offset = "0x9CB5C4", VA = "0x9CB5C4", Slot = "4")]
		public override void OnLoad()
		{
		}

		// Token: 0x06005EC2 RID: 24258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EC2")]
		[Address(RVA = "0x9CB5C8", Offset = "0x9CB5C8", VA = "0x9CB5C8", Slot = "8")]
		public override void Update(GameTime gameTime)
		{
		}

		// Token: 0x06005EC3 RID: 24259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EC3")]
		[Address(RVA = "0x9CB6DC", Offset = "0x9CB6DC", VA = "0x9CB6DC", Slot = "9")]
		public override void Draw(SpriteBatch spriteBatch, float minDepth, float maxDepth)
		{
		}

		// Token: 0x06005EC4 RID: 24260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EC4")]
		[Address(RVA = "0x9CB988", Offset = "0x9CB988", VA = "0x9CB988", Slot = "6")]
		public override void Activate(Vector2 position, object[] args)
		{
		}

		// Token: 0x06005EC5 RID: 24261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EC5")]
		[Address(RVA = "0x9CB994", Offset = "0x9CB994", VA = "0x9CB994", Slot = "7")]
		public override void Deactivate(object[] args)
		{
		}

		// Token: 0x06005EC6 RID: 24262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EC6")]
		[Address(RVA = "0x9CB9A0", Offset = "0x9CB9A0", VA = "0x9CB9A0", Slot = "11")]
		public override void Reset()
		{
		}

		// Token: 0x06005EC7 RID: 24263 RVA: 0x0002BDE8 File Offset: 0x00029FE8
		[Token(Token = "0x6005EC7")]
		[Address(RVA = "0x9CB9B0", Offset = "0x9CB9B0", VA = "0x9CB9B0", Slot = "10")]
		public override bool IsActive()
		{
			return default(bool);
		}

		// Token: 0x06005EC8 RID: 24264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EC8")]
		[Address(RVA = "0x9CB9B8", Offset = "0x9CB9B8", VA = "0x9CB9B8")]
		public BlizzardSky()
		{
		}

		// Token: 0x04009E2A RID: 40490
		[Token(Token = "0x4009E2A")]
		[FieldOffset(Offset = "0x14")]
		private UnifiedRandom _random;

		// Token: 0x04009E2B RID: 40491
		[Token(Token = "0x4009E2B")]
		[FieldOffset(Offset = "0x18")]
		private bool _isActive;

		// Token: 0x04009E2C RID: 40492
		[Token(Token = "0x4009E2C")]
		[FieldOffset(Offset = "0x19")]
		private bool _isLeaving;

		// Token: 0x04009E2D RID: 40493
		[Token(Token = "0x4009E2D")]
		[FieldOffset(Offset = "0x1C")]
		private float _opacity;
	}
}
