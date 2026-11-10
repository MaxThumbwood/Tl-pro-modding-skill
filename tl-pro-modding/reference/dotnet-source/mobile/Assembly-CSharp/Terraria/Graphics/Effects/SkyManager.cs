using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.Graphics.Effects
{
	// Token: 0x0200090F RID: 2319
	[Token(Token = "0x200090F")]
	public class SkyManager : EffectManager<CustomSky>
	{
		// Token: 0x06004DC0 RID: 19904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DC0")]
		[Address(RVA = "0x7269F4", Offset = "0x7269F4", VA = "0x7269F4")]
		public static void EnsureActiveForAllLocalUsers(string id)
		{
		}

		// Token: 0x06004DC1 RID: 19905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DC1")]
		[Address(RVA = "0x726D24", Offset = "0x726D24", VA = "0x726D24")]
		public static void ActivateForAllUsers(string id)
		{
		}

		// Token: 0x06004DC2 RID: 19906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DC2")]
		[Address(RVA = "0x726F74", Offset = "0x726F74", VA = "0x726F74")]
		public static void DeactivateForAllUsers(string id)
		{
		}

		// Token: 0x06004DC3 RID: 19907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DC3")]
		[Address(RVA = "0x7271B8", Offset = "0x7271B8", VA = "0x7271B8")]
		public void Reset()
		{
		}

		// Token: 0x06004DC4 RID: 19908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DC4")]
		[Address(RVA = "0x7273C8", Offset = "0x7273C8", VA = "0x7273C8")]
		public void Update(GameTime gameTime)
		{
		}

		// Token: 0x06004DC5 RID: 19909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DC5")]
		[Address(RVA = "0x72756C", Offset = "0x72756C", VA = "0x72756C")]
		public void Draw(SpriteBatch spriteBatch)
		{
		}

		// Token: 0x06004DC6 RID: 19910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DC6")]
		[Address(RVA = "0x7278EC", Offset = "0x7278EC", VA = "0x7278EC")]
		public void DrawToDepth(SpriteBatch spriteBatch, float minDepth)
		{
		}

		// Token: 0x06004DC7 RID: 19911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DC7")]
		[Address(RVA = "0x72758C", Offset = "0x72758C", VA = "0x72758C")]
		public void DrawDepthRange(SpriteBatch spriteBatch, float minDepth, float maxDepth)
		{
		}

		// Token: 0x06004DC8 RID: 19912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DC8")]
		[Address(RVA = "0x727928", Offset = "0x727928", VA = "0x727928")]
		public void DrawRemainingDepth(SpriteBatch spriteBatch)
		{
		}

		// Token: 0x06004DC9 RID: 19913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DC9")]
		[Address(RVA = "0x727950", Offset = "0x727950", VA = "0x727950")]
		public void ResetDepthTracker()
		{
		}

		// Token: 0x06004DCA RID: 19914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DCA")]
		[Address(RVA = "0x727960", Offset = "0x727960", VA = "0x727960")]
		public void SetStartingDepth(float depth)
		{
		}

		// Token: 0x06004DCB RID: 19915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DCB")]
		[Address(RVA = "0x727968", Offset = "0x727968", VA = "0x727968", Slot = "4")]
		public override void OnActivate(CustomSky effect, Vector2 position)
		{
		}

		// Token: 0x06004DCC RID: 19916 RVA: 0x00024648 File Offset: 0x00022848
		[Token(Token = "0x6004DCC")]
		[Address(RVA = "0x727A10", Offset = "0x727A10", VA = "0x727A10")]
		public Color ProcessTileColor(Color color)
		{
			return default(Color);
		}

		// Token: 0x06004DCD RID: 19917 RVA: 0x00024660 File Offset: 0x00022860
		[Token(Token = "0x6004DCD")]
		[Address(RVA = "0x727BD0", Offset = "0x727BD0", VA = "0x727BD0")]
		public float ProcessCloudAlpha()
		{
			return 0f;
		}

		// Token: 0x06004DCE RID: 19918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DCE")]
		[Address(RVA = "0x727DA0", Offset = "0x727DA0", VA = "0x727DA0")]
		public SkyManager()
		{
		}

		// Token: 0x040092D1 RID: 37585
		[Token(Token = "0x40092D1")]
		[FieldOffset(Offset = "0x0")]
		public static SkyManager Instance;

		// Token: 0x040092D2 RID: 37586
		[Token(Token = "0x40092D2")]
		[FieldOffset(Offset = "0x10")]
		private float _lastDepth;

		// Token: 0x040092D3 RID: 37587
		[Token(Token = "0x40092D3")]
		[FieldOffset(Offset = "0x14")]
		private LinkedList<CustomSky> _activeSkies;
	}
}
