using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Terraria.GameContent.Drawing;
using Terraria.Graphics;

namespace Microsoft.Xna.Framework.Graphics
{
	// Token: 0x020003D4 RID: 980
	[Token(Token = "0x20003D4")]
	public class SpriteBatch_NatureLit : GraphicsResource
	{
		// Token: 0x06001AA1 RID: 6817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AA1")]
		[Address(RVA = "0xE43BA8", Offset = "0xE43BA8", VA = "0xE43BA8")]
		public SpriteBatch_NatureLit(GraphicsDevice graphicsDevice)
		{
		}

		// Token: 0x06001AA2 RID: 6818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AA2")]
		[Address(RVA = "0xE43D20", Offset = "0xE43D20", VA = "0xE43D20")]
		public void Begin(SpriteSortMode sortMode, bool defferedBatch)
		{
		}

		// Token: 0x06001AA3 RID: 6819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AA3")]
		[Address(RVA = "0xE43F7C", Offset = "0xE43F7C", VA = "0xE43F7C")]
		public void Begin(SpriteSortMode sortMode = SpriteSortMode.Deferred, [Optional] BlendState blendState, [Optional] SamplerState samplerState, [Optional] DepthStencilState depthStencilState, [Optional] RasterizerState rasterizerState, [Optional] Effect effect, [Optional] Matrix? transformMatrix, bool defferedBatch = true)
		{
		}

		// Token: 0x06001AA4 RID: 6820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AA4")]
		[Address(RVA = "0xE441A0", Offset = "0xE441A0", VA = "0xE441A0")]
		public void End()
		{
		}

		// Token: 0x06001AA5 RID: 6821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AA5")]
		[Address(RVA = "0xE44330", Offset = "0xE44330", VA = "0xE44330")]
		public void Flush()
		{
		}

		// Token: 0x06001AA6 RID: 6822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AA6")]
		[Address(RVA = "0xE43F1C", Offset = "0xE43F1C", VA = "0xE43F1C")]
		private void Setup()
		{
		}

		// Token: 0x06001AA7 RID: 6823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AA7")]
		[Address(RVA = "0xE44354", Offset = "0xE44354", VA = "0xE44354")]
		private void CheckValid(Texture2D texture)
		{
		}

		// Token: 0x06001AA8 RID: 6824 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AA8")]
		[Address(RVA = "0xE44408", Offset = "0xE44408", VA = "0xE44408")]
		public SpriteBatchItem_NatureLit InsertNewBatchItem(Texture2D texture)
		{
			return null;
		}

		// Token: 0x06001AA9 RID: 6825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AA9")]
		[Address(RVA = "0xE446E8", Offset = "0xE446E8", VA = "0xE446E8")]
		public void Draw(Texture2D texture, ref Vector2 position, ref Rectangle srcRect, ref Color color, float rotation, ref Vector2 origin, float scale, SpriteEffects effects = SpriteEffects.None, SideFlags seams = SideFlags.None)
		{
		}

		// Token: 0x06001AAA RID: 6826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AAA")]
		[Address(RVA = "0xE448E0", Offset = "0xE448E0", VA = "0xE448E0")]
		public static void ForceDrawScale(float scale, Vector2 origin, Vector2 position)
		{
		}

		// Token: 0x06001AAB RID: 6827 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AAB")]
		[Address(RVA = "0xE449B0", Offset = "0xE449B0", VA = "0xE449B0")]
		public static void ClearDrawScale()
		{
		}

		// Token: 0x06001AAC RID: 6828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AAC")]
		[Address(RVA = "0xE44A18", Offset = "0xE44A18", VA = "0xE44A18")]
		public static void TransformPosition(ref Vector2 position, ref Vector2 scale)
		{
		}

		// Token: 0x06001AAD RID: 6829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AAD")]
		[Address(RVA = "0xE44B6C", Offset = "0xE44B6C", VA = "0xE44B6C")]
		public void Draw(Texture2D texture, ref Vector2 position, ref Rectangle srcRect, ref VertexColors color)
		{
		}

		// Token: 0x06001AAE RID: 6830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AAE")]
		[Address(RVA = "0xE4489C", Offset = "0xE4489C", VA = "0xE4489C")]
		internal void FlushIfNeeded()
		{
		}

		// Token: 0x04002E01 RID: 11777
		[Token(Token = "0x4002E01")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool BatchDeffered;

		// Token: 0x04002E02 RID: 11778
		[Token(Token = "0x4002E02")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool BatchDefferedHeadInsert;

		// Token: 0x04002E03 RID: 11779
		[Token(Token = "0x4002E03")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private readonly SpriteBatcher_NatureLit _batcher;

		// Token: 0x04002E04 RID: 11780
		[Token(Token = "0x4002E04")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private SpriteSortMode _sortMode;

		// Token: 0x04002E05 RID: 11781
		[Token(Token = "0x4002E05")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private BlendState _blendState;

		// Token: 0x04002E06 RID: 11782
		[Token(Token = "0x4002E06")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private DepthStencilState _depthStencilState;

		// Token: 0x04002E07 RID: 11783
		[Token(Token = "0x4002E07")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private RasterizerState _rasterizerState;

		// Token: 0x04002E08 RID: 11784
		[Token(Token = "0x4002E08")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Effect _effect;

		// Token: 0x04002E09 RID: 11785
		[Token(Token = "0x4002E09")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public bool _beginCalled;

		// Token: 0x04002E0A RID: 11786
		[Token(Token = "0x4002E0A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int _batchOffset;

		// Token: 0x04002E0B RID: 11787
		[Token(Token = "0x4002E0B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private SpriteBatchItem_NatureLit _lastBatchItem;

		// Token: 0x04002E0C RID: 11788
		[Token(Token = "0x4002E0C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private SpriteBatchItemList_NatureLit _firstBatchList;

		// Token: 0x04002E0D RID: 11789
		[Token(Token = "0x4002E0D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private SpriteBatchItemList_NatureLit _lastBatchList;

		// Token: 0x04002E0E RID: 11790
		[Token(Token = "0x4002E0E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Effect _spriteEffect;

		// Token: 0x04002E0F RID: 11791
		[Token(Token = "0x4002E0F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private readonly EffectPass _spritePass;

		// Token: 0x04002E10 RID: 11792
		[Token(Token = "0x4002E10")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Matrix _renderMatrix;

		// Token: 0x04002E11 RID: 11793
		[Token(Token = "0x4002E11")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private bool _hasMatrix;

		// Token: 0x04002E12 RID: 11794
		[Token(Token = "0x4002E12")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private Viewport _lastViewport;

		// Token: 0x04002E13 RID: 11795
		[Token(Token = "0x4002E13")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private Matrix _projection;

		// Token: 0x04002E14 RID: 11796
		[Token(Token = "0x4002E14")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private Rectangle _tempRect;

		// Token: 0x04002E15 RID: 11797
		[Token(Token = "0x4002E15")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		private Vector2 _texCoordTL;

		// Token: 0x04002E16 RID: 11798
		[Token(Token = "0x4002E16")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		private Vector2 _texCoordBR;

		// Token: 0x04002E17 RID: 11799
		[Token(Token = "0x4002E17")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal static bool NeedsHalfPixelOffset;

		// Token: 0x04002E18 RID: 11800
		[Token(Token = "0x4002E18")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static string LastBeginCall;

		// Token: 0x04002E19 RID: 11801
		[Token(Token = "0x4002E19")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		public EffectPass OverloadedEffectPass;

		// Token: 0x04002E1A RID: 11802
		[Token(Token = "0x4002E1A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static bool forceDrawScale;

		// Token: 0x04002E1B RID: 11803
		[Token(Token = "0x4002E1B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public static Vector2 forcedDrawScale;

		// Token: 0x04002E1C RID: 11804
		[Token(Token = "0x4002E1C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public static Vector2 forcedDrawOrigin;

		// Token: 0x04002E1D RID: 11805
		[Token(Token = "0x4002E1D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public static Vector2 forcedDrawPosition;
	}
}
