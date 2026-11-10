using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Graphics;
using Terraria.Graphics;

namespace Terraria.GameContent.Golf
{
	// Token: 0x02000CCE RID: 3278
	[Token(Token = "0x2000CCE")]
	public class FancyGolfPredictionLine
	{
		// Token: 0x06006159 RID: 24921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006159")]
		[Address(RVA = "0xAADD48", Offset = "0xAADD48", VA = "0xAADD48")]
		public FancyGolfPredictionLine(int iterations)
		{
		}

		// Token: 0x0600615A RID: 24922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600615A")]
		[Address(RVA = "0xAADF6C", Offset = "0xAADF6C", VA = "0xAADF6C")]
		public void Update(Entity golfBall, Vector2 impactVelocity, float roughLandResistance)
		{
		}

		// Token: 0x0600615B RID: 24923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600615B")]
		[Address(RVA = "0xAAE36C", Offset = "0xAAE36C", VA = "0xAAE36C")]
		public void Draw(Camera camera, SpriteBatch spriteBatch, float chargeProgress)
		{
		}

		// Token: 0x0600615C RID: 24924 RVA: 0x0002CF58 File Offset: 0x0002B158
		[Token(Token = "0x600615C")]
		[Address(RVA = "0xAB22D4", Offset = "0xAB22D4", VA = "0xAB22D4")]
		private Color GetColor(float travelledLength)
		{
			return default(Color);
		}

		// Token: 0x0600615D RID: 24925 RVA: 0x0002CF70 File Offset: 0x0002B170
		[Token(Token = "0x600615D")]
		[Address(RVA = "0xAB2004", Offset = "0xAB2004", VA = "0xAB2004")]
		private Color GetColor2(float index)
		{
			return default(Color);
		}

		// Token: 0x0600615E RID: 24926 RVA: 0x0002CF88 File Offset: 0x0002B188
		[Token(Token = "0x600615E")]
		[Address(RVA = "0xAB21B8", Offset = "0xAB21B8", VA = "0xAB21B8")]
		private float GetScale(float travelledLength)
		{
			return 0f;
		}

		// Token: 0x0600615F RID: 24927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600615F")]
		[Address(RVA = "0xAB1C2C", Offset = "0xAB1C2C", VA = "0xAB1C2C")]
		private void GetSectionLength(int startIndex, out float length, out float rotation)
		{
		}

		// Token: 0x06006160 RID: 24928 RVA: 0x0002CFA0 File Offset: 0x0002B1A0
		[Token(Token = "0x6006160")]
		[Address(RVA = "0xAB1E3C", Offset = "0xAB1E3C", VA = "0xAB1E3C")]
		private Vector2 GetPosition(float indexProgress)
		{
			return default(Vector2);
		}

		// Token: 0x0400A00E RID: 40974
		[Token(Token = "0x400A00E")]
		[FieldOffset(Offset = "0x8")]
		private readonly List<Vector2> _positions;

		// Token: 0x0400A00F RID: 40975
		[Token(Token = "0x400A00F")]
		[FieldOffset(Offset = "0xC")]
		private readonly Entity _entity;

		// Token: 0x0400A010 RID: 40976
		[Token(Token = "0x400A010")]
		[FieldOffset(Offset = "0x10")]
		private readonly int _iterations;

		// Token: 0x0400A011 RID: 40977
		[Token(Token = "0x400A011")]
		[FieldOffset(Offset = "0x14")]
		private readonly Color[] _colors;

		// Token: 0x0400A012 RID: 40978
		[Token(Token = "0x400A012")]
		[FieldOffset(Offset = "0x18")]
		private readonly BasicDebugDrawer _drawer;

		// Token: 0x0400A013 RID: 40979
		[Token(Token = "0x400A013")]
		[FieldOffset(Offset = "0x1C")]
		private float _time;

		// Token: 0x02000CCF RID: 3279
		[Token(Token = "0x2000CCF")]
		private class PredictionEntity : Entity
		{
			// Token: 0x06006161 RID: 24929 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006161")]
			[Address(RVA = "0xAB1C24", Offset = "0xAB1C24", VA = "0xAB1C24")]
			public PredictionEntity()
			{
			}
		}
	}
}
