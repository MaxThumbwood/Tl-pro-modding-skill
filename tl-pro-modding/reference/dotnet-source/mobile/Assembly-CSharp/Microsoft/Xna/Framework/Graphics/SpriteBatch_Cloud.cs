using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Terraria.Graphics;

namespace Microsoft.Xna.Framework.Graphics
{
	// Token: 0x020003D3 RID: 979
	[Token(Token = "0x20003D3")]
	public class SpriteBatch_Cloud : GraphicsResource
	{
		// Token: 0x06001A7B RID: 6779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A7B")]
		[Address(RVA = "0xE3E3B0", Offset = "0xE3E3B0", VA = "0xE3E3B0")]
		public SpriteBatch_Cloud(GraphicsDevice graphicsDevice)
		{
		}

		// Token: 0x06001A7C RID: 6780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A7C")]
		[Address(RVA = "0xE3E908", Offset = "0xE3E908", VA = "0xE3E908")]
		public void Begin(SpriteSortMode sortMode, bool defferedBatch)
		{
		}

		// Token: 0x06001A7D RID: 6781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A7D")]
		[Address(RVA = "0xE3EB64", Offset = "0xE3EB64", VA = "0xE3EB64")]
		public void Begin(SpriteSortMode sortMode = SpriteSortMode.Deferred, [Optional] BlendState blendState, [Optional] SamplerState samplerState, [Optional] DepthStencilState depthStencilState, [Optional] RasterizerState rasterizerState, [Optional] Effect effect, [Optional] Matrix? transformMatrix, bool defferedBatch = true)
		{
		}

		// Token: 0x06001A7E RID: 6782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A7E")]
		[Address(RVA = "0xE3ED88", Offset = "0xE3ED88", VA = "0xE3ED88")]
		public void End()
		{
		}

		// Token: 0x06001A7F RID: 6783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A7F")]
		[Address(RVA = "0xE3EF18", Offset = "0xE3EF18", VA = "0xE3EF18")]
		public void Flush()
		{
		}

		// Token: 0x06001A80 RID: 6784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A80")]
		[Address(RVA = "0xE3EB04", Offset = "0xE3EB04", VA = "0xE3EB04")]
		private void Setup()
		{
		}

		// Token: 0x06001A81 RID: 6785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A81")]
		[Address(RVA = "0xE3EF3C", Offset = "0xE3EF3C", VA = "0xE3EF3C")]
		private void CheckValid(Texture2D texture)
		{
		}

		// Token: 0x06001A82 RID: 6786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A82")]
		[Address(RVA = "0xE3EFF0", Offset = "0xE3EFF0", VA = "0xE3EFF0")]
		public void Draw(Texture2D texture, [Optional] Vector2? position, [Optional] Rectangle? destinationRectangle, [Optional] Rectangle? sourceRectangle, [Optional] Vector2? origin, float rotation = 0f, [Optional] Vector2? scale, [Optional] Color? color, SpriteEffects effects = SpriteEffects.None, float layerDepth = 0f)
		{
		}

		// Token: 0x06001A83 RID: 6787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A83")]
		[Address(RVA = "0xE3FEE4", Offset = "0xE3FEE4", VA = "0xE3FEE4")]
		public void Draw(Texture2D texture, Vector2? position, Rectangle? destinationRectangle, Rectangle? sourceRectangle, Vector2? origin, float rotation, Vector2? scale, ref VertexColors color, SpriteEffects effects = SpriteEffects.None, float layerDepth = 0f)
		{
		}

		// Token: 0x06001A84 RID: 6788 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A84")]
		[Address(RVA = "0xE40CF8", Offset = "0xE40CF8", VA = "0xE40CF8")]
		public SpriteBatchItem_Cloud InsertNewBatchItem(Texture2D texture)
		{
			return null;
		}

		// Token: 0x06001A85 RID: 6789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A85")]
		[Address(RVA = "0xE40FD8", Offset = "0xE40FD8", VA = "0xE40FD8")]
		public void Draw(Texture2D texture, ref Vector2 position, ref Rectangle srcRect, ref Color color, float rotation, Vector2 origin, float scale, SpriteEffects effects = SpriteEffects.None)
		{
		}

		// Token: 0x06001A86 RID: 6790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A86")]
		[Address(RVA = "0xE411FC", Offset = "0xE411FC", VA = "0xE411FC")]
		public void Draw(Texture2D texture, ref Vector2 position, ref Rectangle srcRect, ref Color color, float rotation, Vector2 origin, Vector2 scale, SpriteEffects effects = SpriteEffects.None)
		{
		}

		// Token: 0x06001A87 RID: 6791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A87")]
		[Address(RVA = "0xE413E0", Offset = "0xE413E0", VA = "0xE413E0")]
		public void Draw(Texture2D texture, ref Vector2 position, ref Rectangle srcRect, ref Color color, float rotation, Vector2 origin, float scale)
		{
		}

		// Token: 0x06001A88 RID: 6792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A88")]
		[Address(RVA = "0xE41598", Offset = "0xE41598", VA = "0xE41598")]
		public void Draw(Texture2D texture, ref Vector2 position, ref Color color, float rotation, Vector2 origin, float scale)
		{
		}

		// Token: 0x06001A89 RID: 6793 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A89")]
		[Address(RVA = "0xE3F4F4", Offset = "0xE3F4F4", VA = "0xE3F4F4")]
		public void Draw(Texture2D texture, Vector2 position, Rectangle? sourceRectangle, Color color, float rotation, Vector2 origin, Vector2 scale, SpriteEffects effects, float layerDepth)
		{
		}

		// Token: 0x06001A8A RID: 6794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A8A")]
		[Address(RVA = "0xE418A0", Offset = "0xE418A0", VA = "0xE418A0")]
		public void Draw(Texture2D texture, Vector2 position, ref Rectangle srcRect, Color color, float rotation, Vector2 origin, Vector2 scale, SpriteEffects effects, float layerDepth)
		{
		}

		// Token: 0x06001A8B RID: 6795 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A8B")]
		[Address(RVA = "0xE40300", Offset = "0xE40300", VA = "0xE40300")]
		public void Draw(Texture2D texture, Vector2 position, Rectangle? sourceRectangle, ref VertexColors color, float rotation, Vector2 origin, Vector2 scale, SpriteEffects effects, float layerDepth)
		{
		}

		// Token: 0x06001A8C RID: 6796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A8C")]
		[Address(RVA = "0xE41B38", Offset = "0xE41B38", VA = "0xE41B38")]
		public void Draw(Texture2D texture, Vector2 position, ref Rectangle srcRect, ref VertexColors color, float rotation, Vector2 origin, Vector2 scale, SpriteEffects effects, float layerDepth)
		{
		}

		// Token: 0x06001A8D RID: 6797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A8D")]
		[Address(RVA = "0xE41DF0", Offset = "0xE41DF0", VA = "0xE41DF0")]
		public void Draw(Texture2D texture, Vector2 position, ref Rectangle srcRect, ref VertexColors color, float rotation, Vector2 origin, float scale, SpriteEffects effects, float layerDepth)
		{
		}

		// Token: 0x06001A8E RID: 6798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A8E")]
		[Address(RVA = "0xE42084", Offset = "0xE42084", VA = "0xE42084")]
		public static void ForceDrawScale(float scale, Vector2 origin, Vector2 position)
		{
		}

		// Token: 0x06001A8F RID: 6799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A8F")]
		[Address(RVA = "0xE42154", Offset = "0xE42154", VA = "0xE42154")]
		public static void ClearDrawScale()
		{
		}

		// Token: 0x06001A90 RID: 6800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A90")]
		[Address(RVA = "0xE421BC", Offset = "0xE421BC", VA = "0xE421BC")]
		public static void TransformPosition(ref Vector2 position, ref Vector2 scale)
		{
		}

		// Token: 0x06001A91 RID: 6801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A91")]
		[Address(RVA = "0xE42310", Offset = "0xE42310", VA = "0xE42310")]
		public void Draw(Texture2D texture, Vector2 position, Rectangle? sourceRectangle, Color color, float rotation, Vector2 origin, float scale, SpriteEffects effects, float layerDepth = 0f)
		{
		}

		// Token: 0x06001A92 RID: 6802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A92")]
		[Address(RVA = "0xE42424", Offset = "0xE42424", VA = "0xE42424")]
		public void Draw(Texture2D texture, ref Vector2 position, ref Rectangle srcRect, ref Color color)
		{
		}

		// Token: 0x06001A93 RID: 6803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A93")]
		[Address(RVA = "0xE42550", Offset = "0xE42550", VA = "0xE42550")]
		public void Draw(Texture2D texture, ref Vector2 position, ref Rectangle srcRect, ref VertexColors color)
		{
		}

		// Token: 0x06001A94 RID: 6804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A94")]
		[Address(RVA = "0xE4267C", Offset = "0xE4267C", VA = "0xE4267C")]
		public void Draw(Texture2D texture, ref Vector2 position, ref Rectangle srcRect, ref Color color, SpriteEffects effects)
		{
		}

		// Token: 0x06001A95 RID: 6805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A95")]
		[Address(RVA = "0xE427CC", Offset = "0xE427CC", VA = "0xE427CC")]
		public void Draw(Texture2D texture, ref Vector2 position, ref Rectangle srcRect, ref VertexColors color, SpriteEffects effects)
		{
		}

		// Token: 0x06001A96 RID: 6806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A96")]
		[Address(RVA = "0xE4291C", Offset = "0xE4291C", VA = "0xE4291C")]
		public void Draw(Texture2D texture, Vector2 position, ref Rectangle srcRect, Color color, float rotation, Vector2 origin, float scale, SpriteEffects effects, float layerDepth = 0f)
		{
		}

		// Token: 0x06001A97 RID: 6807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A97")]
		[Address(RVA = "0xE42BA8", Offset = "0xE42BA8", VA = "0xE42BA8")]
		public void Draw(Texture2D texture, Vector2 position, Rectangle? sourceRectangle, ref VertexColors color, float rotation, Vector2 origin, float scale, SpriteEffects effects, float layerDepth = 0f)
		{
		}

		// Token: 0x06001A98 RID: 6808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A98")]
		[Address(RVA = "0xE3F99C", Offset = "0xE3F99C", VA = "0xE3F99C")]
		public void Draw(Texture2D texture, Rectangle destinationRectangle, Rectangle? sourceRectangle, Color color, float rotation, Vector2 origin, SpriteEffects effects, float layerDepth)
		{
		}

		// Token: 0x06001A99 RID: 6809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A99")]
		[Address(RVA = "0xE40788", Offset = "0xE40788", VA = "0xE40788")]
		public void Draw(Texture2D texture, Rectangle destinationRectangle, Rectangle? sourceRectangle, ref VertexColors color, float rotation, Vector2 origin, SpriteEffects effects, float layerDepth)
		{
		}

		// Token: 0x06001A9A RID: 6810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A9A")]
		[Address(RVA = "0xE411B8", Offset = "0xE411B8", VA = "0xE411B8")]
		internal void FlushIfNeeded()
		{
		}

		// Token: 0x06001A9B RID: 6811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A9B")]
		[Address(RVA = "0xE42CBC", Offset = "0xE42CBC", VA = "0xE42CBC")]
		public void Draw(Texture2D texture, Vector2 position, Rectangle? sourceRectangle, Color color)
		{
		}

		// Token: 0x06001A9C RID: 6812 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A9C")]
		[Address(RVA = "0xE43044", Offset = "0xE43044", VA = "0xE43044")]
		public void Draw(Texture2D texture, Vector2 position, Rectangle? sourceRectangle, ref VertexColors color)
		{
		}

		// Token: 0x06001A9D RID: 6813 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A9D")]
		[Address(RVA = "0xE433C4", Offset = "0xE433C4", VA = "0xE433C4")]
		public void Draw(Texture2D texture, Rectangle destinationRectangle, Rectangle? sourceRectangle, Color color)
		{
		}

		// Token: 0x06001A9E RID: 6814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A9E")]
		[Address(RVA = "0xE436CC", Offset = "0xE436CC", VA = "0xE436CC")]
		public void Draw(Texture2D texture, Vector2 position, Color color)
		{
		}

		// Token: 0x06001A9F RID: 6815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A9F")]
		[Address(RVA = "0xE438B8", Offset = "0xE438B8", VA = "0xE438B8")]
		public void Draw(Texture2D texture, Rectangle destinationRectangle, Color color)
		{
		}

		// Token: 0x04002DE4 RID: 11748
		[Token(Token = "0x4002DE4")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool BatchDeffered;

		// Token: 0x04002DE5 RID: 11749
		[Token(Token = "0x4002DE5")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool BatchDefferedHeadInsert;

		// Token: 0x04002DE6 RID: 11750
		[Token(Token = "0x4002DE6")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private readonly SpriteBatcher_Cloud _batcher;

		// Token: 0x04002DE7 RID: 11751
		[Token(Token = "0x4002DE7")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private SpriteSortMode _sortMode;

		// Token: 0x04002DE8 RID: 11752
		[Token(Token = "0x4002DE8")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private BlendState _blendState;

		// Token: 0x04002DE9 RID: 11753
		[Token(Token = "0x4002DE9")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private DepthStencilState _depthStencilState;

		// Token: 0x04002DEA RID: 11754
		[Token(Token = "0x4002DEA")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private RasterizerState _rasterizerState;

		// Token: 0x04002DEB RID: 11755
		[Token(Token = "0x4002DEB")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Effect _effect;

		// Token: 0x04002DEC RID: 11756
		[Token(Token = "0x4002DEC")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public bool _beginCalled;

		// Token: 0x04002DED RID: 11757
		[Token(Token = "0x4002DED")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int _batchOffset;

		// Token: 0x04002DEE RID: 11758
		[Token(Token = "0x4002DEE")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private SpriteBatchItem_Cloud _lastBatchItem;

		// Token: 0x04002DEF RID: 11759
		[Token(Token = "0x4002DEF")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private SpriteBatchItemList_Cloud _firstBatchList;

		// Token: 0x04002DF0 RID: 11760
		[Token(Token = "0x4002DF0")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private SpriteBatchItemList_Cloud _lastBatchList;

		// Token: 0x04002DF1 RID: 11761
		[Token(Token = "0x4002DF1")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Effect _spriteEffect;

		// Token: 0x04002DF2 RID: 11762
		[Token(Token = "0x4002DF2")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private readonly EffectPass _spritePass;

		// Token: 0x04002DF3 RID: 11763
		[Token(Token = "0x4002DF3")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Matrix _renderMatrix;

		// Token: 0x04002DF4 RID: 11764
		[Token(Token = "0x4002DF4")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private bool _hasMatrix;

		// Token: 0x04002DF5 RID: 11765
		[Token(Token = "0x4002DF5")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private Viewport _lastViewport;

		// Token: 0x04002DF6 RID: 11766
		[Token(Token = "0x4002DF6")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private Matrix _projection;

		// Token: 0x04002DF7 RID: 11767
		[Token(Token = "0x4002DF7")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private Rectangle _tempRect;

		// Token: 0x04002DF8 RID: 11768
		[Token(Token = "0x4002DF8")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		private Vector2 _texCoordTL;

		// Token: 0x04002DF9 RID: 11769
		[Token(Token = "0x4002DF9")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		private Vector2 _texCoordBR;

		// Token: 0x04002DFA RID: 11770
		[Token(Token = "0x4002DFA")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal static bool NeedsHalfPixelOffset;

		// Token: 0x04002DFB RID: 11771
		[Token(Token = "0x4002DFB")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static string LastBeginCall;

		// Token: 0x04002DFC RID: 11772
		[Token(Token = "0x4002DFC")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		public EffectPass OverloadedEffectPass;

		// Token: 0x04002DFD RID: 11773
		[Token(Token = "0x4002DFD")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static bool forceDrawScale;

		// Token: 0x04002DFE RID: 11774
		[Token(Token = "0x4002DFE")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public static Vector2 forcedDrawScale;

		// Token: 0x04002DFF RID: 11775
		[Token(Token = "0x4002DFF")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public static Vector2 forcedDrawOrigin;

		// Token: 0x04002E00 RID: 11776
		[Token(Token = "0x4002E00")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public static Vector2 forcedDrawPosition;
	}
}
