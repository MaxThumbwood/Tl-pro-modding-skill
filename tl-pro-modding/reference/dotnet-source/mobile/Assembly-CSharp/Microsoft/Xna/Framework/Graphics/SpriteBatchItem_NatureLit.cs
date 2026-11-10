using System;
using Il2CppDummyDll;
using Terraria.GameContent.Drawing;
using Terraria.Graphics;
using UnityEngine;

namespace Microsoft.Xna.Framework.Graphics
{
	// Token: 0x020003D2 RID: 978
	[Token(Token = "0x20003D2")]
	public class SpriteBatchItem_NatureLit
	{
		// Token: 0x06001A6E RID: 6766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A6E")]
		[Address(RVA = "0xE3ABF0", Offset = "0xE3ABF0", VA = "0xE3ABF0")]
		public static void PushExpandedClippingRegion()
		{
		}

		// Token: 0x06001A6F RID: 6767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A6F")]
		[Address(RVA = "0xE3AC90", Offset = "0xE3AC90", VA = "0xE3AC90")]
		public static void PopExpandedClippingRegion()
		{
		}

		// Token: 0x06001A70 RID: 6768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A70")]
		[Address(RVA = "0xE3AD30", Offset = "0xE3AD30", VA = "0xE3AD30")]
		public static void EnableClipping(Rectangle inner, Rectangle outer, SpriteBatch batcher, bool vertical)
		{
		}

		// Token: 0x06001A71 RID: 6769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A71")]
		[Address(RVA = "0xE3AFCC", Offset = "0xE3AFCC", VA = "0xE3AFCC")]
		public static void PushClippedImageRegion(Rectangle region, SpriteBatch batcher, bool enableGeometryScale, Vector2 geometryScaleCentre, float geometryScale)
		{
		}

		// Token: 0x06001A72 RID: 6770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A72")]
		[Address(RVA = "0xE3B438", Offset = "0xE3B438", VA = "0xE3B438")]
		public static void PopClippedImageRegion()
		{
		}

		// Token: 0x06001A73 RID: 6771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A73")]
		[Address(RVA = "0xE3B6D0", Offset = "0xE3B6D0", VA = "0xE3B6D0")]
		public static void DisabledClipping()
		{
		}

		// Token: 0x06001A74 RID: 6772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A74")]
		[Address(RVA = "0xE3B738", Offset = "0xE3B738", VA = "0xE3B738")]
		public static void SetGeometryOffset(SpriteBatch_NatureLit batcher, bool enabled, Vector2 offset)
		{
		}

		// Token: 0x06001A75 RID: 6773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A75")]
		[Address(RVA = "0xE35944", Offset = "0xE35944", VA = "0xE35944")]
		public SpriteBatchItem_NatureLit()
		{
		}

		// Token: 0x06001A76 RID: 6774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A76")]
		[Address(RVA = "0xE3B864", Offset = "0xE3B864", VA = "0xE3B864")]
		public void Set(float x, float y, float dx, float dy, float w, float h, float sin, float cos, ref Color color, ref Vector2 texCoordTL, ref Vector2 texCoordBR, SideFlags seams = SideFlags.None)
		{
		}

		// Token: 0x06001A77 RID: 6775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A77")]
		[Address(RVA = "0xE3C3EC", Offset = "0xE3C3EC", VA = "0xE3C3EC")]
		public void Set(float x, float y, float dx, float dy, float w, float h, float sin, float cos, ref VertexColors colors, ref Vector2 texCoordTL, ref Vector2 texCoordBR)
		{
		}

		// Token: 0x06001A78 RID: 6776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A78")]
		[Address(RVA = "0xE3CDE4", Offset = "0xE3CDE4", VA = "0xE3CDE4")]
		public void Set(float x, float y, float w, float h, ref Color color, ref Vector2 texCoordTL, ref Vector2 texCoordBR, SideFlags seams = SideFlags.None)
		{
		}

		// Token: 0x06001A79 RID: 6777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A79")]
		[Address(RVA = "0xE3D900", Offset = "0xE3D900", VA = "0xE3D900")]
		public void Set(float x, float y, float w, float h, ref VertexColors color, ref Vector2 texCoordTL, ref Vector2 texCoordBR)
		{
		}

		// Token: 0x04002DCA RID: 11722
		[Token(Token = "0x4002DCA")]
		private const float uvFixupOffset = 0.031f;

		// Token: 0x04002DCB RID: 11723
		[Token(Token = "0x4002DCB")]
		[FieldOffset(Offset = "0x0")]
		private static bool clippingPushedEnabledBackup;

		// Token: 0x04002DCC RID: 11724
		[Token(Token = "0x4002DCC")]
		[FieldOffset(Offset = "0x1")]
		private static bool clippingVerticalBackup;

		// Token: 0x04002DCD RID: 11725
		[Token(Token = "0x4002DCD")]
		[FieldOffset(Offset = "0x2")]
		private static bool clippingHorzontalBackup;

		// Token: 0x04002DCE RID: 11726
		[Token(Token = "0x4002DCE")]
		[FieldOffset(Offset = "0x4")]
		private static Rectangle clippingPushedInnerBackup;

		// Token: 0x04002DCF RID: 11727
		[Token(Token = "0x4002DCF")]
		[FieldOffset(Offset = "0x14")]
		private static Rectangle clippingPushedOuterBackup;

		// Token: 0x04002DD0 RID: 11728
		[Token(Token = "0x4002DD0")]
		[FieldOffset(Offset = "0x24")]
		public static bool clippingEnabled;

		// Token: 0x04002DD1 RID: 11729
		[Token(Token = "0x4002DD1")]
		[FieldOffset(Offset = "0x25")]
		public static bool geometryOffsetEnabled;

		// Token: 0x04002DD2 RID: 11730
		[Token(Token = "0x4002DD2")]
		[FieldOffset(Offset = "0x26")]
		private static bool clippingVertical;

		// Token: 0x04002DD3 RID: 11731
		[Token(Token = "0x4002DD3")]
		[FieldOffset(Offset = "0x27")]
		private static bool clippingHorzontal;

		// Token: 0x04002DD4 RID: 11732
		[Token(Token = "0x4002DD4")]
		[FieldOffset(Offset = "0x28")]
		private static Rectangle clippingInner;

		// Token: 0x04002DD5 RID: 11733
		[Token(Token = "0x4002DD5")]
		[FieldOffset(Offset = "0x38")]
		public static Rectangle clippingOuter;

		// Token: 0x04002DD6 RID: 11734
		[Token(Token = "0x4002DD6")]
		[FieldOffset(Offset = "0x48")]
		private static SpriteBatch clippingBatch;

		// Token: 0x04002DD7 RID: 11735
		[Token(Token = "0x4002DD7")]
		[FieldOffset(Offset = "0x4C")]
		private static Clipper clipperObject;

		// Token: 0x04002DD8 RID: 11736
		[Token(Token = "0x4002DD8")]
		[FieldOffset(Offset = "0x8")]
		public int BatchKey;

		// Token: 0x04002DD9 RID: 11737
		[Token(Token = "0x4002DD9")]
		[FieldOffset(Offset = "0xC")]
		public Texture2D Texture;

		// Token: 0x04002DDA RID: 11738
		[Token(Token = "0x4002DDA")]
		[FieldOffset(Offset = "0x10")]
		public EffectPass OverloadedEffectPass;

		// Token: 0x04002DDB RID: 11739
		[Token(Token = "0x4002DDB")]
		[FieldOffset(Offset = "0x14")]
		public SpriteBatchItem_NatureLit NextBatchItem;

		// Token: 0x04002DDC RID: 11740
		[Token(Token = "0x4002DDC")]
		[FieldOffset(Offset = "0x18")]
		public SpriteBatcher_NatureLit.VertexData vertexTL;

		// Token: 0x04002DDD RID: 11741
		[Token(Token = "0x4002DDD")]
		[FieldOffset(Offset = "0x44")]
		public SpriteBatcher_NatureLit.VertexData vertexTR;

		// Token: 0x04002DDE RID: 11742
		[Token(Token = "0x4002DDE")]
		[FieldOffset(Offset = "0x70")]
		public SpriteBatcher_NatureLit.VertexData vertexBL;

		// Token: 0x04002DDF RID: 11743
		[Token(Token = "0x4002DDF")]
		[FieldOffset(Offset = "0x9C")]
		public SpriteBatcher_NatureLit.VertexData vertexBR;

		// Token: 0x04002DE0 RID: 11744
		[Token(Token = "0x4002DE0")]
		[FieldOffset(Offset = "0x50")]
		public static float ColourScale;

		// Token: 0x04002DE1 RID: 11745
		[Token(Token = "0x4002DE1")]
		[FieldOffset(Offset = "0x54")]
		public static bool EnableMaterialTrimming;

		// Token: 0x04002DE2 RID: 11746
		[Token(Token = "0x4002DE2")]
		[FieldOffset(Offset = "0x58")]
		public static Vector2 MaterialTrimmingMin;

		// Token: 0x04002DE3 RID: 11747
		[Token(Token = "0x4002DE3")]
		[FieldOffset(Offset = "0x60")]
		public static Vector2 MaterialTrimmingMax;
	}
}
