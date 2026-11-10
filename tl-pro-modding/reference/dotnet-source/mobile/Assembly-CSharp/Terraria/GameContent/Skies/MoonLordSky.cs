using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Graphics.Effects;
using Terraria.Utilities;

namespace Terraria.GameContent.Skies
{
	// Token: 0x02000C89 RID: 3209
	[Token(Token = "0x2000C89")]
	public class MoonLordSky : CustomSky
	{
		// Token: 0x06005F00 RID: 24320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F00")]
		[Address(RVA = "0xA86420", Offset = "0xA86420", VA = "0xA86420")]
		public MoonLordSky(bool forPlayer)
		{
		}

		// Token: 0x06005F01 RID: 24321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F01")]
		[Address(RVA = "0xA864A4", Offset = "0xA864A4", VA = "0xA864A4", Slot = "4")]
		public override void OnLoad()
		{
		}

		// Token: 0x06005F02 RID: 24322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F02")]
		[Address(RVA = "0xA864A8", Offset = "0xA864A8", VA = "0xA864A8", Slot = "8")]
		public override void Update(GameTime gameTime)
		{
		}

		// Token: 0x06005F03 RID: 24323 RVA: 0x0002BF20 File Offset: 0x0002A120
		[Token(Token = "0x6005F03")]
		[Address(RVA = "0xA86574", Offset = "0xA86574", VA = "0xA86574")]
		private float GetIntensity()
		{
			return 0f;
		}

		// Token: 0x06005F04 RID: 24324 RVA: 0x0002BF38 File Offset: 0x0002A138
		[Token(Token = "0x6005F04")]
		[Address(RVA = "0xA86680", Offset = "0xA86680", VA = "0xA86680", Slot = "12")]
		public override Color OnTileColor(Color inColor)
		{
			return default(Color);
		}

		// Token: 0x06005F05 RID: 24325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F05")]
		[Address(RVA = "0xA867CC", Offset = "0xA867CC", VA = "0xA867CC", Slot = "9")]
		public override void Draw(SpriteBatch spriteBatch, float minDepth, float maxDepth)
		{
		}

		// Token: 0x06005F06 RID: 24326 RVA: 0x0002BF50 File Offset: 0x0002A150
		[Token(Token = "0x6005F06")]
		[Address(RVA = "0xA86950", Offset = "0xA86950", VA = "0xA86950", Slot = "13")]
		public override float GetCloudAlpha()
		{
			return 0f;
		}

		// Token: 0x06005F07 RID: 24327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F07")]
		[Address(RVA = "0xA86964", Offset = "0xA86964", VA = "0xA86964", Slot = "6")]
		public override void Activate(Vector2 position, object[] args)
		{
		}

		// Token: 0x06005F08 RID: 24328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F08")]
		[Address(RVA = "0xA8698C", Offset = "0xA8698C", VA = "0xA8698C", Slot = "7")]
		public override void Deactivate(object[] args)
		{
		}

		// Token: 0x06005F09 RID: 24329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F09")]
		[Address(RVA = "0xA869A4", Offset = "0xA869A4", VA = "0xA869A4", Slot = "11")]
		public override void Reset()
		{
		}

		// Token: 0x06005F0A RID: 24330 RVA: 0x0002BF68 File Offset: 0x0002A168
		[Token(Token = "0x6005F0A")]
		[Address(RVA = "0xA869B4", Offset = "0xA869B4", VA = "0xA869B4", Slot = "10")]
		public override bool IsActive()
		{
			return default(bool);
		}

		// Token: 0x04009E66 RID: 40550
		[Token(Token = "0x4009E66")]
		[FieldOffset(Offset = "0x14")]
		private UnifiedRandom _random;

		// Token: 0x04009E67 RID: 40551
		[Token(Token = "0x4009E67")]
		[FieldOffset(Offset = "0x18")]
		private bool _isActive;

		// Token: 0x04009E68 RID: 40552
		[Token(Token = "0x4009E68")]
		[FieldOffset(Offset = "0x19")]
		private bool _forPlayer;

		// Token: 0x04009E69 RID: 40553
		[Token(Token = "0x4009E69")]
		[FieldOffset(Offset = "0x1C")]
		private float _fadeOpacity;
	}
}
