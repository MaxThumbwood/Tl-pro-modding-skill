using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.DataStructures;

namespace Terraria.Physics
{
	// Token: 0x0200064B RID: 1611
	[Token(Token = "0x200064B")]
	public static class CollisionVisualizer
	{
		// Token: 0x06003E5A RID: 15962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E5A")]
		[Address(RVA = "0x1E6D364", Offset = "0x1E6D364", VA = "0x1E6D364")]
		public static void VisualizeElipticalLine(Vector2 attacker, Vector2 target, float allowedDistance, float squishX, float squishY, bool needsCanHitCheck)
		{
		}

		// Token: 0x06003E5B RID: 15963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E5B")]
		[Address(RVA = "0x1E6D66C", Offset = "0x1E6D66C", VA = "0x1E6D66C")]
		public static void VisualizeRects(Rectangle attacker, Rectangle target, bool needsCanHitCheck)
		{
		}

		// Token: 0x06003E5C RID: 15964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E5C")]
		[Address(RVA = "0x1E6D82C", Offset = "0x1E6D82C", VA = "0x1E6D82C")]
		public static void VisualizeConeFast(Vector2 attacker, Rectangle targetRect, float correctedAngle, float maximumAngle, float allowedDistance, bool needsCanHitCheck)
		{
		}

		// Token: 0x06003E5D RID: 15965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E5D")]
		[Address(RVA = "0x1E6DB10", Offset = "0x1E6DB10", VA = "0x1E6DB10")]
		public static void VisualizeConeSlow(Vector2 attacker, Rectangle targetRect, float correctedAngle, float maximumAngle, float allowedDistance, bool needsCanHitCheck)
		{
		}

		// Token: 0x06003E5E RID: 15966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E5E")]
		[Address(RVA = "0x1E6DDF4", Offset = "0x1E6DDF4", VA = "0x1E6DDF4")]
		public static void VisualizeAABBvLine(Rectangle targetRect, Vector2 lineStart, Vector2 lineEnd, float lineWidth)
		{
		}

		// Token: 0x06003E5F RID: 15967 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E5F")]
		[Address(RVA = "0x1E6DF14", Offset = "0x1E6DF14", VA = "0x1E6DF14")]
		public static void VisualizeAABBvMultiPoint(Rectangle targetRectangle, MultiPointHitbox lightning)
		{
		}

		// Token: 0x040048B6 RID: 18614
		[Token(Token = "0x40048B6")]
		[FieldOffset(Offset = "0x0")]
		public static bool enabled;

		// Token: 0x040048B7 RID: 18615
		[Token(Token = "0x40048B7")]
		[FieldOffset(Offset = "0x1")]
		public static Color colorSelf;

		// Token: 0x040048B8 RID: 18616
		[Token(Token = "0x40048B8")]
		[FieldOffset(Offset = "0x5")]
		public static Color colorTarget;
	}
}
