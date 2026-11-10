using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

namespace Microsoft.Xna.Framework.Graphics
{
	// Token: 0x020003CD RID: 973
	[Token(Token = "0x20003CD")]
	public class SpriteBatcher_NatureLit
	{
		// Token: 0x06001A54 RID: 6740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A54")]
		[Address(RVA = "0xE35580", Offset = "0xE35580", VA = "0xE35580")]
		public SpriteBatcher_NatureLit(GraphicsDevice device)
		{
		}

		// Token: 0x06001A55 RID: 6741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A55")]
		[Address(RVA = "0xE3596C", Offset = "0xE3596C", VA = "0xE3596C")]
		private void InitialiseIndexBuffer()
		{
		}

		// Token: 0x06001A56 RID: 6742 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A56")]
		[Address(RVA = "0xE359E8", Offset = "0xE359E8", VA = "0xE359E8")]
		public SpriteBatchItem_NatureLit CreateBatchItem()
		{
			return null;
		}

		// Token: 0x06001A57 RID: 6743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A57")]
		[Address(RVA = "0xE35AD8", Offset = "0xE35AD8", VA = "0xE35AD8")]
		public void CreateBatchItemList(out SpriteBatchItemList_NatureLit item)
		{
		}

		// Token: 0x06001A58 RID: 6744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A58")]
		[Address(RVA = "0xE35C80", Offset = "0xE35C80", VA = "0xE35C80")]
		public void DrawImmediateBatch(Effect effect)
		{
		}

		// Token: 0x170002E1 RID: 737
		// (get) Token: 0x06001A59 RID: 6745 RVA: 0x0000CC78 File Offset: 0x0000AE78
		[Token(Token = "0x170002E1")]
		private int WorldCameraHeight
		{
			[Token(Token = "0x6001A59")]
			[Address(RVA = "0xE36250", Offset = "0xE36250", VA = "0xE36250")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06001A5A RID: 6746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A5A")]
		[Address(RVA = "0xE366FC", Offset = "0xE366FC", VA = "0xE366FC")]
		public void FlushBatches()
		{
		}

		// Token: 0x06001A5B RID: 6747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A5B")]
		[Address(RVA = "0xE36978", Offset = "0xE36978", VA = "0xE36978")]
		public void DrawBatch(SpriteSortMode sortMode, Effect effect, bool deffered, [Optional] SpriteBatchItem_NatureLit overrideFirstItem)
		{
		}

		// Token: 0x06001A5C RID: 6748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A5C")]
		[Address(RVA = "0xE3641C", Offset = "0xE3641C", VA = "0xE3641C")]
		private void AddSubMesh(Effect effect, Texture2D texture, EffectPass overloadEffectPass)
		{
		}

		// Token: 0x06001A5D RID: 6749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A5D")]
		[Address(RVA = "0xE362D8", Offset = "0xE362D8", VA = "0xE362D8")]
		private void RenderVertexArrayWithSubMeshes(int vertexCount, int indexCount, Vector3 position, Vector3 scale)
		{
		}

		// Token: 0x04002D8B RID: 11659
		[Token(Token = "0x4002D8B")]
		private const int InitialBatchSize = 256;

		// Token: 0x04002D8C RID: 11660
		[Token(Token = "0x4002D8C")]
		private const int MaxBatchSize = 5461;

		// Token: 0x04002D8D RID: 11661
		[Token(Token = "0x4002D8D")]
		private const int InitialVertexArraySize = 256;

		// Token: 0x04002D8E RID: 11662
		[Token(Token = "0x4002D8E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public SpriteBatchItem_NatureLit[] _batchItemList;

		// Token: 0x04002D8F RID: 11663
		[Token(Token = "0x4002D8F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int _batchItemCount;

		// Token: 0x04002D90 RID: 11664
		[Token(Token = "0x4002D90")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int _lastBatchListId;

		// Token: 0x04002D91 RID: 11665
		[Token(Token = "0x4002D91")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public SpriteBatchItemList_NatureLit _lastBatchList;

		// Token: 0x04002D92 RID: 11666
		[Token(Token = "0x4002D92")]
		public const int BatchListPoolCount = 64;

		// Token: 0x04002D93 RID: 11667
		[Token(Token = "0x4002D93")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public SpriteBatchItemList_NatureLit[] _activeBatchListsPool;

		// Token: 0x04002D94 RID: 11668
		[Token(Token = "0x4002D94")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private SpriteBatchItemList_NatureLit[] _batchItemListList;

		// Token: 0x04002D95 RID: 11669
		[Token(Token = "0x4002D95")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int _batchItemListCount;

		// Token: 0x04002D96 RID: 11670
		[Token(Token = "0x4002D96")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private readonly GraphicsDevice _device;

		// Token: 0x04002D97 RID: 11671
		[Token(Token = "0x4002D97")]
		private const int maxQuadCount = 8192;

		// Token: 0x04002D98 RID: 11672
		[Token(Token = "0x4002D98")]
		private const int maxVerts = 32768;

		// Token: 0x04002D99 RID: 11673
		[Token(Token = "0x4002D99")]
		private const int maxIndices = 49152;

		// Token: 0x04002D9A RID: 11674
		[Token(Token = "0x4002D9A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int _vertexOffset;

		// Token: 0x04002D9B RID: 11675
		[Token(Token = "0x4002D9B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private int _indexOffset;

		// Token: 0x04002D9C RID: 11676
		[Token(Token = "0x4002D9C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int _materialOffset;

		// Token: 0x04002D9D RID: 11677
		[Token(Token = "0x4002D9D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private SpriteBatcher_NatureLit.VertexData[] vertexData;

		// Token: 0x04002D9E RID: 11678
		[Token(Token = "0x4002D9E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private short[] indexData;

		// Token: 0x04002D9F RID: 11679
		[Token(Token = "0x4002D9F")]
		private const int MaxSubMeshes = 1024;

		// Token: 0x04002DA0 RID: 11680
		[Token(Token = "0x4002DA0")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private SubMeshDescriptor[] _submeshList;

		// Token: 0x04002DA1 RID: 11681
		[Token(Token = "0x4002DA1")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int _submeshCount;

		// Token: 0x04002DA2 RID: 11682
		[Token(Token = "0x4002DA2")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Material[] _submeshListMaterials;

		// Token: 0x04002DA3 RID: 11683
		[Token(Token = "0x4002DA3")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static VertexAttributeDescriptor[] vertexDescription;

		// Token: 0x020003CE RID: 974
		[Token(Token = "0x20003CE")]
		public struct VertexData
		{
			// Token: 0x04002DA4 RID: 11684
			[Token(Token = "0x4002DA4")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector4 Position;

			// Token: 0x04002DA5 RID: 11685
			[Token(Token = "0x4002DA5")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Color32 Color;

			// Token: 0x04002DA6 RID: 11686
			[Token(Token = "0x4002DA6")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Vector2 TextureCoordinate;

			// Token: 0x04002DA7 RID: 11687
			[Token(Token = "0x4002DA7")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector4 TextureRegion;
		}
	}
}
