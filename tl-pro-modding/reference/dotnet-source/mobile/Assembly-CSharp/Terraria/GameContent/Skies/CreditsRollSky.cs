using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.GameContent.Animations;
using Terraria.GameContent.Skies.CreditsRoll;
using Terraria.Graphics.Effects;

namespace Terraria.GameContent.Skies
{
	// Token: 0x02000C80 RID: 3200
	[Token(Token = "0x2000C80")]
	public class CreditsRollSky : CustomSky
	{
		// Token: 0x17000A72 RID: 2674
		// (get) Token: 0x06005EC9 RID: 24265 RVA: 0x0002BE00 File Offset: 0x0002A000
		[Token(Token = "0x17000A72")]
		public int AmountOfTimeNeededForFullPlay
		{
			[Token(Token = "0x6005EC9")]
			[Address(RVA = "0x9CBA34", Offset = "0x9CBA34", VA = "0x9CBA34")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06005ECA RID: 24266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005ECA")]
		[Address(RVA = "0x9CBA3C", Offset = "0x9CBA3C", VA = "0x9CBA3C")]
		public CreditsRollSky()
		{
		}

		// Token: 0x06005ECB RID: 24267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005ECB")]
		[Address(RVA = "0x9CBCBC", Offset = "0x9CBCBC", VA = "0x9CBCBC", Slot = "8")]
		public override void Update(GameTime gameTime)
		{
		}

		// Token: 0x06005ECC RID: 24268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005ECC")]
		[Address(RVA = "0x9CBF2C", Offset = "0x9CBF2C", VA = "0x9CBF2C", Slot = "9")]
		public override void Draw(SpriteBatch spriteBatch, float minDepth, float maxDepth)
		{
		}

		// Token: 0x06005ECD RID: 24269 RVA: 0x0002BE18 File Offset: 0x0002A018
		[Token(Token = "0x6005ECD")]
		[Address(RVA = "0x9CC26C", Offset = "0x9CC26C", VA = "0x9CC26C", Slot = "10")]
		public override bool IsActive()
		{
			return default(bool);
		}

		// Token: 0x06005ECE RID: 24270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005ECE")]
		[Address(RVA = "0x9CC274", Offset = "0x9CC274", VA = "0x9CC274", Slot = "11")]
		public override void Reset()
		{
		}

		// Token: 0x06005ECF RID: 24271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005ECF")]
		[Address(RVA = "0x9CC290", Offset = "0x9CC290", VA = "0x9CC290", Slot = "6")]
		public override void Activate(Vector2 position, object[] args)
		{
		}

		// Token: 0x06005ED0 RID: 24272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005ED0")]
		[Address(RVA = "0x9CBB48", Offset = "0x9CBB48", VA = "0x9CBB48")]
		private void EnsureSegmentsAreMade()
		{
		}

		// Token: 0x06005ED1 RID: 24273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005ED1")]
		[Address(RVA = "0x9CC2C4", Offset = "0x9CC2C4", VA = "0x9CC2C4", Slot = "7")]
		public override void Deactivate(object[] args)
		{
		}

		// Token: 0x04009E2E RID: 40494
		[Token(Token = "0x4009E2E")]
		[FieldOffset(Offset = "0x14")]
		private int _endTime;

		// Token: 0x04009E2F RID: 40495
		[Token(Token = "0x4009E2F")]
		[FieldOffset(Offset = "0x18")]
		private int _currentTime;

		// Token: 0x04009E30 RID: 40496
		[Token(Token = "0x4009E30")]
		[FieldOffset(Offset = "0x1C")]
		private CreditsRollComposer _composer;

		// Token: 0x04009E31 RID: 40497
		[Token(Token = "0x4009E31")]
		[FieldOffset(Offset = "0x20")]
		private List<IAnimationSegment> _segmentsInGame;

		// Token: 0x04009E32 RID: 40498
		[Token(Token = "0x4009E32")]
		[FieldOffset(Offset = "0x24")]
		private List<IAnimationSegment> _segmentsInMainMenu;

		// Token: 0x04009E33 RID: 40499
		[Token(Token = "0x4009E33")]
		[FieldOffset(Offset = "0x28")]
		private bool _isActive;

		// Token: 0x04009E34 RID: 40500
		[Token(Token = "0x4009E34")]
		[FieldOffset(Offset = "0x29")]
		private bool _wantsToBeSeen;

		// Token: 0x04009E35 RID: 40501
		[Token(Token = "0x4009E35")]
		[FieldOffset(Offset = "0x2C")]
		private float _opacity;
	}
}
