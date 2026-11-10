using System;
using Il2CppDummyDll;
using Terraria.Graphics;
using UnityEngine;

namespace Microsoft.Xna.Framework.Graphics
{
	// Token: 0x020003D1 RID: 977
	[Token(Token = "0x20003D1")]
	public class SpriteBatchItem_Cloud
	{
		// Token: 0x06001A61 RID: 6753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A61")]
		[Address(RVA = "0xE37164", Offset = "0xE37164", VA = "0xE37164")]
		public static void PushExpandedClippingRegion()
		{
		}

		// Token: 0x06001A62 RID: 6754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A62")]
		[Address(RVA = "0xE37204", Offset = "0xE37204", VA = "0xE37204")]
		public static void PopExpandedClippingRegion()
		{
		}

		// Token: 0x06001A63 RID: 6755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A63")]
		[Address(RVA = "0xE372A4", Offset = "0xE372A4", VA = "0xE372A4")]
		public static void EnableClipping(Rectangle inner, Rectangle outer, SpriteBatch batcher, bool vertical)
		{
		}

		// Token: 0x06001A64 RID: 6756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A64")]
		[Address(RVA = "0xE37540", Offset = "0xE37540", VA = "0xE37540")]
		public static void PushClippedImageRegion(Rectangle region, SpriteBatch batcher, bool enableGeometryScale, Vector2 geometryScaleCentre, float geometryScale)
		{
		}

		// Token: 0x06001A65 RID: 6757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A65")]
		[Address(RVA = "0xE379AC", Offset = "0xE379AC", VA = "0xE379AC")]
		public static void PopClippedImageRegion()
		{
		}

		// Token: 0x06001A66 RID: 6758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A66")]
		[Address(RVA = "0xE37C44", Offset = "0xE37C44", VA = "0xE37C44")]
		public static void DisabledClipping()
		{
		}

		// Token: 0x06001A67 RID: 6759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A67")]
		[Address(RVA = "0xE37CAC", Offset = "0xE37CAC", VA = "0xE37CAC")]
		public static void SetGeometryScale(SpriteBatch batcher, bool enable, Vector2 centre, Vector2 scale, Vector2 offset)
		{
		}

		// Token: 0x06001A68 RID: 6760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A68")]
		[Address(RVA = "0xE37DE8", Offset = "0xE37DE8", VA = "0xE37DE8")]
		public SpriteBatchItem_Cloud()
		{
		}

		// Token: 0x06001A69 RID: 6761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A69")]
		[Address(RVA = "0xE37E08", Offset = "0xE37E08", VA = "0xE37E08")]
		public void Set(float x, float y, float dx, float dy, float w, float h, float sin, float cos, ref Color color, ref Vector2 texCoordTL, ref Vector2 texCoordBR)
		{
		}

		// Token: 0x06001A6A RID: 6762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A6A")]
		[Address(RVA = "0xE38A18", Offset = "0xE38A18", VA = "0xE38A18")]
		public void Set(float x, float y, float dx, float dy, float w, float h, float sin, float cos, ref VertexColors colors, ref Vector2 texCoordTL, ref Vector2 texCoordBR)
		{
		}

		// Token: 0x06001A6B RID: 6763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A6B")]
		[Address(RVA = "0xE394C0", Offset = "0xE394C0", VA = "0xE394C0")]
		public void Set(float x, float y, float w, float h, ref Color color, ref Vector2 texCoordTL, ref Vector2 texCoordBR)
		{
		}

		// Token: 0x06001A6C RID: 6764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A6C")]
		[Address(RVA = "0xE3A080", Offset = "0xE3A080", VA = "0xE3A080")]
		public void Set(float x, float y, float w, float h, ref VertexColors color, ref Vector2 texCoordTL, ref Vector2 texCoordBR)
		{
		}

		// Token: 0x04002DB0 RID: 11696
		[Token(Token = "0x4002DB0")]
		private const float uvFixupOffset = 0.031f;

		// Token: 0x04002DB1 RID: 11697
		[Token(Token = "0x4002DB1")]
		[FieldOffset(Offset = "0x0")]
		private static bool clippingPushedEnabledBackup;

		// Token: 0x04002DB2 RID: 11698
		[Token(Token = "0x4002DB2")]
		[FieldOffset(Offset = "0x1")]
		private static bool clippingVerticalBackup;

		// Token: 0x04002DB3 RID: 11699
		[Token(Token = "0x4002DB3")]
		[FieldOffset(Offset = "0x2")]
		private static bool clippingHorzontalBackup;

		// Token: 0x04002DB4 RID: 11700
		[Token(Token = "0x4002DB4")]
		[FieldOffset(Offset = "0x4")]
		private static Rectangle clippingPushedInnerBackup;

		// Token: 0x04002DB5 RID: 11701
		[Token(Token = "0x4002DB5")]
		[FieldOffset(Offset = "0x14")]
		private static Rectangle clippingPushedOuterBackup;

		// Token: 0x04002DB6 RID: 11702
		[Token(Token = "0x4002DB6")]
		[FieldOffset(Offset = "0x24")]
		public static bool clippingEnabled;

		// Token: 0x04002DB7 RID: 11703
		[Token(Token = "0x4002DB7")]
		[FieldOffset(Offset = "0x25")]
		public static bool geometryScaleEnabled;

		// Token: 0x04002DB8 RID: 11704
		[Token(Token = "0x4002DB8")]
		[FieldOffset(Offset = "0x26")]
		private static bool clippingVertical;

		// Token: 0x04002DB9 RID: 11705
		[Token(Token = "0x4002DB9")]
		[FieldOffset(Offset = "0x27")]
		private static bool clippingHorzontal;

		// Token: 0x04002DBA RID: 11706
		[Token(Token = "0x4002DBA")]
		[FieldOffset(Offset = "0x28")]
		private static Rectangle clippingInner;

		// Token: 0x04002DBB RID: 11707
		[Token(Token = "0x4002DBB")]
		[FieldOffset(Offset = "0x38")]
		public static Rectangle clippingOuter;

		// Token: 0x04002DBC RID: 11708
		[Token(Token = "0x4002DBC")]
		[FieldOffset(Offset = "0x48")]
		private static SpriteBatch clippingBatch;

		// Token: 0x04002DBD RID: 11709
		[Token(Token = "0x4002DBD")]
		[FieldOffset(Offset = "0x4C")]
		private static Clipper clipperObject;

		// Token: 0x04002DBE RID: 11710
		[Token(Token = "0x4002DBE")]
		[FieldOffset(Offset = "0x8")]
		public int BatchKey;

		// Token: 0x04002DBF RID: 11711
		[Token(Token = "0x4002DBF")]
		[FieldOffset(Offset = "0xC")]
		public Texture2D Texture;

		// Token: 0x04002DC0 RID: 11712
		[Token(Token = "0x4002DC0")]
		[FieldOffset(Offset = "0x10")]
		public EffectPass OverloadedEffectPass;

		// Token: 0x04002DC1 RID: 11713
		[Token(Token = "0x4002DC1")]
		[FieldOffset(Offset = "0x14")]
		public SpriteBatchItem_Cloud NextBatchItem;

		// Token: 0x04002DC2 RID: 11714
		[Token(Token = "0x4002DC2")]
		[FieldOffset(Offset = "0x18")]
		public SpriteBatcher_Cloud.VertexData vertexTL;

		// Token: 0x04002DC3 RID: 11715
		[Token(Token = "0x4002DC3")]
		[FieldOffset(Offset = "0x44")]
		public SpriteBatcher_Cloud.VertexData vertexTR;

		// Token: 0x04002DC4 RID: 11716
		[Token(Token = "0x4002DC4")]
		[FieldOffset(Offset = "0x70")]
		public SpriteBatcher_Cloud.VertexData vertexBL;

		// Token: 0x04002DC5 RID: 11717
		[Token(Token = "0x4002DC5")]
		[FieldOffset(Offset = "0x9C")]
		public SpriteBatcher_Cloud.VertexData vertexBR;

		// Token: 0x04002DC6 RID: 11718
		[Token(Token = "0x4002DC6")]
		[FieldOffset(Offset = "0x50")]
		public static float ColourScale;

		// Token: 0x04002DC7 RID: 11719
		[Token(Token = "0x4002DC7")]
		[FieldOffset(Offset = "0x54")]
		public static bool EnableMaterialTrimming;

		// Token: 0x04002DC8 RID: 11720
		[Token(Token = "0x4002DC8")]
		[FieldOffset(Offset = "0x58")]
		public static Vector2 MaterialTrimmingMin;

		// Token: 0x04002DC9 RID: 11721
		[Token(Token = "0x4002DC9")]
		[FieldOffset(Offset = "0x60")]
		public static Vector2 MaterialTrimmingMax;
	}
}
