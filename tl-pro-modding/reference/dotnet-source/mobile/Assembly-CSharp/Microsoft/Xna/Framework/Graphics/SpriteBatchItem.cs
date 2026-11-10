using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Terraria.Graphics;
using UnityEngine;

namespace Microsoft.Xna.Framework.Graphics
{
	// Token: 0x0200040A RID: 1034
	[Token(Token = "0x200040A")]
	public class SpriteBatchItem
	{
		// Token: 0x06001C96 RID: 7318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C96")]
		[Address(RVA = "0xE877E8", Offset = "0xE877E8", VA = "0xE877E8")]
		public static void PushExpandedClippingRegion()
		{
		}

		// Token: 0x06001C97 RID: 7319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C97")]
		[Address(RVA = "0xE87888", Offset = "0xE87888", VA = "0xE87888")]
		public static void PopExpandedClippingRegion()
		{
		}

		// Token: 0x06001C98 RID: 7320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C98")]
		[Address(RVA = "0xE87928", Offset = "0xE87928", VA = "0xE87928")]
		public static void EnableFullClipping(Rectangle inner, Rectangle outer, SpriteBatch batcher)
		{
		}

		// Token: 0x06001C99 RID: 7321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C99")]
		[Address(RVA = "0xE87BBC", Offset = "0xE87BBC", VA = "0xE87BBC")]
		public static void EnableClipping(Rectangle inner, Rectangle outer, SpriteBatch batcher, bool vertical)
		{
		}

		// Token: 0x06001C9A RID: 7322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C9A")]
		[Address(RVA = "0xE87E58", Offset = "0xE87E58", VA = "0xE87E58")]
		public static void PushClippedImageRegion(Rectangle region, SpriteBatch batcher, bool enableGeometryScale, Vector2 geometryScaleCentre, float geometryScale)
		{
		}

		// Token: 0x06001C9B RID: 7323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C9B")]
		[Address(RVA = "0xE882C4", Offset = "0xE882C4", VA = "0xE882C4")]
		public static void PopClippedImageRegion()
		{
		}

		// Token: 0x06001C9C RID: 7324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C9C")]
		[Address(RVA = "0xE8855C", Offset = "0xE8855C", VA = "0xE8855C")]
		public static void DisabledClipping()
		{
		}

		// Token: 0x06001C9D RID: 7325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C9D")]
		[Address(RVA = "0xE885C4", Offset = "0xE885C4", VA = "0xE885C4")]
		public static void SetGeometryScale(SpriteBatch batcher, bool enable, Vector2 centre, Vector2 scale, Vector2 offset)
		{
		}

		// Token: 0x06001C9E RID: 7326 RVA: 0x0000D5F0 File Offset: 0x0000B7F0
		[Token(Token = "0x6001C9E")]
		[Address(RVA = "0xE88700", Offset = "0xE88700", VA = "0xE88700")]
		public static Vector2 Scale(Vector2 position)
		{
			return default(Vector2);
		}

		// Token: 0x06001C9F RID: 7327 RVA: 0x0000D608 File Offset: 0x0000B808
		[Token(Token = "0x6001C9F")]
		[Address(RVA = "0xE887E0", Offset = "0xE887E0", VA = "0xE887E0")]
		public static Vector2 InvScale(Vector2 position)
		{
			return default(Vector2);
		}

		// Token: 0x06001CA0 RID: 7328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CA0")]
		[Address(RVA = "0xE85D84", Offset = "0xE85D84", VA = "0xE85D84")]
		public SpriteBatchItem()
		{
		}

		// Token: 0x06001CA1 RID: 7329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CA1")]
		[Address(RVA = "0xE888C0", Offset = "0xE888C0", VA = "0xE888C0")]
		public void Set(float x, float y, float dx, float dy, float w, float h, float sin, float cos, ref Color color, ref Vector2 texCoordTL, ref Vector2 texCoordBR)
		{
		}

		// Token: 0x06001CA2 RID: 7330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CA2")]
		[Address(RVA = "0xE89364", Offset = "0xE89364", VA = "0xE89364")]
		public void Set(float x, float y, float dx, float dy, float w, float h, float sin, float cos, ref VertexColors colors, ref Vector2 texCoordTL, ref Vector2 texCoordBR)
		{
		}

		// Token: 0x06001CA3 RID: 7331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CA3")]
		[Address(RVA = "0xE89D3C", Offset = "0xE89D3C", VA = "0xE89D3C")]
		[MethodImpl(256)]
		public void Set_Fast(float x, float y, float w, float h, ref Color color, ref Vector2 texCoordTL, ref Vector2 texCoordBR)
		{
		}

		// Token: 0x06001CA4 RID: 7332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CA4")]
		[Address(RVA = "0xE8A83C", Offset = "0xE8A83C", VA = "0xE8A83C")]
		public void Set(float x, float y, float w, float h, ref Color color, ref Vector2 texCoordTL, ref Vector2 texCoordBR)
		{
		}

		// Token: 0x06001CA5 RID: 7333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CA5")]
		[Address(RVA = "0xE8B3E8", Offset = "0xE8B3E8", VA = "0xE8B3E8")]
		public void Set_Fast(float x, float y, float w, float h, ref VertexColors color, ref Vector2 texCoordTL, ref Vector2 texCoordBR)
		{
		}

		// Token: 0x06001CA6 RID: 7334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CA6")]
		[Address(RVA = "0xE8BD14", Offset = "0xE8BD14", VA = "0xE8BD14")]
		public void Set(float x, float y, float w, float h, ref VertexColors color, ref Vector2 texCoordTL, ref Vector2 texCoordBR)
		{
		}

		// Token: 0x0400302B RID: 12331
		[Token(Token = "0x400302B")]
		private const float uvFixupOffset = 0.031f;

		// Token: 0x0400302C RID: 12332
		[Token(Token = "0x400302C")]
		[FieldOffset(Offset = "0x0")]
		private static bool clippingPushedEnabledBackup;

		// Token: 0x0400302D RID: 12333
		[Token(Token = "0x400302D")]
		[FieldOffset(Offset = "0x1")]
		private static bool clippingVerticalBackup;

		// Token: 0x0400302E RID: 12334
		[Token(Token = "0x400302E")]
		[FieldOffset(Offset = "0x2")]
		private static bool clippingHorzontalBackup;

		// Token: 0x0400302F RID: 12335
		[Token(Token = "0x400302F")]
		[FieldOffset(Offset = "0x4")]
		private static Rectangle clippingPushedInnerBackup;

		// Token: 0x04003030 RID: 12336
		[Token(Token = "0x4003030")]
		[FieldOffset(Offset = "0x14")]
		private static Rectangle clippingPushedOuterBackup;

		// Token: 0x04003031 RID: 12337
		[Token(Token = "0x4003031")]
		[FieldOffset(Offset = "0x24")]
		public static bool clippingEnabled;

		// Token: 0x04003032 RID: 12338
		[Token(Token = "0x4003032")]
		[FieldOffset(Offset = "0x25")]
		public static bool geometryScaleEnabled;

		// Token: 0x04003033 RID: 12339
		[Token(Token = "0x4003033")]
		[FieldOffset(Offset = "0x26")]
		private static bool clippingVertical;

		// Token: 0x04003034 RID: 12340
		[Token(Token = "0x4003034")]
		[FieldOffset(Offset = "0x27")]
		private static bool clippingHorzontal;

		// Token: 0x04003035 RID: 12341
		[Token(Token = "0x4003035")]
		[FieldOffset(Offset = "0x28")]
		private static Rectangle clippingInner;

		// Token: 0x04003036 RID: 12342
		[Token(Token = "0x4003036")]
		[FieldOffset(Offset = "0x38")]
		public static Rectangle clippingOuter;

		// Token: 0x04003037 RID: 12343
		[Token(Token = "0x4003037")]
		[FieldOffset(Offset = "0x48")]
		private static SpriteBatch clippingBatch;

		// Token: 0x04003038 RID: 12344
		[Token(Token = "0x4003038")]
		[FieldOffset(Offset = "0x4C")]
		public static Clipper clipperObject;

		// Token: 0x04003039 RID: 12345
		[Token(Token = "0x4003039")]
		[FieldOffset(Offset = "0x8")]
		public int BatchKey;

		// Token: 0x0400303A RID: 12346
		[Token(Token = "0x400303A")]
		[FieldOffset(Offset = "0xC")]
		public Texture2D Texture;

		// Token: 0x0400303B RID: 12347
		[Token(Token = "0x400303B")]
		[FieldOffset(Offset = "0x10")]
		public EffectPass OverloadedEffectPass;

		// Token: 0x0400303C RID: 12348
		[Token(Token = "0x400303C")]
		[FieldOffset(Offset = "0x14")]
		public SpriteBatchItem NextBatchItem;

		// Token: 0x0400303D RID: 12349
		[Token(Token = "0x400303D")]
		[FieldOffset(Offset = "0x18")]
		public SpriteBatcher.VertexData vertexTL;

		// Token: 0x0400303E RID: 12350
		[Token(Token = "0x400303E")]
		[FieldOffset(Offset = "0x2C")]
		public SpriteBatcher.VertexData vertexTR;

		// Token: 0x0400303F RID: 12351
		[Token(Token = "0x400303F")]
		[FieldOffset(Offset = "0x40")]
		public SpriteBatcher.VertexData vertexBL;

		// Token: 0x04003040 RID: 12352
		[Token(Token = "0x4003040")]
		[FieldOffset(Offset = "0x54")]
		public SpriteBatcher.VertexData vertexBR;

		// Token: 0x04003041 RID: 12353
		[Token(Token = "0x4003041")]
		[FieldOffset(Offset = "0x50")]
		public static float ColourScale;

		// Token: 0x04003042 RID: 12354
		[Token(Token = "0x4003042")]
		[FieldOffset(Offset = "0x54")]
		public static bool EnableMaterialTrimming;

		// Token: 0x04003043 RID: 12355
		[Token(Token = "0x4003043")]
		[FieldOffset(Offset = "0x58")]
		public static Vector2 MaterialTrimmingMin;

		// Token: 0x04003044 RID: 12356
		[Token(Token = "0x4003044")]
		[FieldOffset(Offset = "0x60")]
		public static Vector2 MaterialTrimmingMax;
	}
}
