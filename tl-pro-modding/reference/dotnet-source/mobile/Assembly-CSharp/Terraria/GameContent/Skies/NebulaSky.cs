using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.Graphics.Effects;
using Terraria.Utilities;

namespace Terraria.GameContent.Skies
{
	// Token: 0x02000C8A RID: 3210
	[Token(Token = "0x2000C8A")]
	public class NebulaSky : CustomSky
	{
		// Token: 0x06005F0B RID: 24331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F0B")]
		[Address(RVA = "0xA869E8", Offset = "0xA869E8", VA = "0xA869E8", Slot = "4")]
		public override void OnLoad()
		{
		}

		// Token: 0x06005F0C RID: 24332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F0C")]
		[Address(RVA = "0xA86E6C", Offset = "0xA86E6C", VA = "0xA86E6C", Slot = "8")]
		public override void Update(GameTime gameTime)
		{
		}

		// Token: 0x06005F0D RID: 24333 RVA: 0x0002BF80 File Offset: 0x0002A180
		[Token(Token = "0x6005F0D")]
		[Address(RVA = "0xA86F2C", Offset = "0xA86F2C", VA = "0xA86F2C", Slot = "12")]
		public override Color OnTileColor(Color inColor)
		{
			return default(Color);
		}

		// Token: 0x06005F0E RID: 24334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F0E")]
		[Address(RVA = "0xA87098", Offset = "0xA87098", VA = "0xA87098", Slot = "9")]
		public override void Draw(SpriteBatch spriteBatch, float minDepth, float maxDepth)
		{
		}

		// Token: 0x06005F0F RID: 24335 RVA: 0x0002BF98 File Offset: 0x0002A198
		[Token(Token = "0x6005F0F")]
		[Address(RVA = "0xA8821C", Offset = "0xA8821C", VA = "0xA8821C", Slot = "13")]
		public override float GetCloudAlpha()
		{
			return 0f;
		}

		// Token: 0x06005F10 RID: 24336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F10")]
		[Address(RVA = "0xA88244", Offset = "0xA88244", VA = "0xA88244", Slot = "6")]
		public override void Activate(Vector2 position, object[] args)
		{
		}

		// Token: 0x06005F11 RID: 24337 RVA: 0x0002BFB0 File Offset: 0x0002A1B0
		[Token(Token = "0x6005F11")]
		[Address(RVA = "0xA88514", Offset = "0xA88514", VA = "0xA88514")]
		private int SortMethod(NebulaSky.LightPillar pillar1, NebulaSky.LightPillar pillar2)
		{
			return 0;
		}

		// Token: 0x06005F12 RID: 24338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F12")]
		[Address(RVA = "0xA88550", Offset = "0xA88550", VA = "0xA88550", Slot = "7")]
		public override void Deactivate(object[] args)
		{
		}

		// Token: 0x06005F13 RID: 24339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F13")]
		[Address(RVA = "0xA8855C", Offset = "0xA8855C", VA = "0xA8855C", Slot = "11")]
		public override void Reset()
		{
		}

		// Token: 0x06005F14 RID: 24340 RVA: 0x0002BFC8 File Offset: 0x0002A1C8
		[Token(Token = "0x6005F14")]
		[Address(RVA = "0xA88568", Offset = "0xA88568", VA = "0xA88568", Slot = "10")]
		public override bool IsActive()
		{
			return default(bool);
		}

		// Token: 0x06005F15 RID: 24341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F15")]
		[Address(RVA = "0xA8859C", Offset = "0xA8859C", VA = "0xA8859C")]
		public NebulaSky()
		{
		}

		// Token: 0x04009E6A RID: 40554
		[Token(Token = "0x4009E6A")]
		[FieldOffset(Offset = "0x14")]
		private NebulaSky.LightPillar[] _pillars;

		// Token: 0x04009E6B RID: 40555
		[Token(Token = "0x4009E6B")]
		[FieldOffset(Offset = "0x18")]
		private UnifiedRandom _random;

		// Token: 0x04009E6C RID: 40556
		[Token(Token = "0x4009E6C")]
		[FieldOffset(Offset = "0x1C")]
		private Asset<Texture2D> _planetTexture;

		// Token: 0x04009E6D RID: 40557
		[Token(Token = "0x4009E6D")]
		[FieldOffset(Offset = "0x20")]
		private Asset<Texture2D> _bgTexture;

		// Token: 0x04009E6E RID: 40558
		[Token(Token = "0x4009E6E")]
		[FieldOffset(Offset = "0x24")]
		private Asset<Texture2D> _beamTexture;

		// Token: 0x04009E6F RID: 40559
		[Token(Token = "0x4009E6F")]
		[FieldOffset(Offset = "0x28")]
		private Asset<Texture2D>[] _rockTextures;

		// Token: 0x04009E70 RID: 40560
		[Token(Token = "0x4009E70")]
		[FieldOffset(Offset = "0x2C")]
		private bool _isActive;

		// Token: 0x04009E71 RID: 40561
		[Token(Token = "0x4009E71")]
		[FieldOffset(Offset = "0x30")]
		private float _fadeOpacity;

		// Token: 0x02000C8B RID: 3211
		[Token(Token = "0x2000C8B")]
		private struct LightPillar
		{
			// Token: 0x04009E72 RID: 40562
			[Token(Token = "0x4009E72")]
			[FieldOffset(Offset = "0x0")]
			public Vector2 Position;

			// Token: 0x04009E73 RID: 40563
			[Token(Token = "0x4009E73")]
			[FieldOffset(Offset = "0x8")]
			public float Depth;
		}
	}
}
