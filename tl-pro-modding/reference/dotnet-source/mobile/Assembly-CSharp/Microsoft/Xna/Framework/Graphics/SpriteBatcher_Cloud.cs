using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

namespace Microsoft.Xna.Framework.Graphics
{
	// Token: 0x020003CB RID: 971
	[Token(Token = "0x20003CB")]
	public class SpriteBatcher_Cloud
	{
		// Token: 0x06001A49 RID: 6729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A49")]
		[Address(RVA = "0xE339D0", Offset = "0xE339D0", VA = "0xE339D0")]
		public SpriteBatcher_Cloud(GraphicsDevice device)
		{
		}

		// Token: 0x06001A4A RID: 6730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A4A")]
		[Address(RVA = "0xE33D9C", Offset = "0xE33D9C", VA = "0xE33D9C")]
		private void InitialiseIndexBuffer()
		{
		}

		// Token: 0x06001A4B RID: 6731 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A4B")]
		[Address(RVA = "0xE33E18", Offset = "0xE33E18", VA = "0xE33E18")]
		public SpriteBatchItem_Cloud CreateBatchItem()
		{
			return null;
		}

		// Token: 0x06001A4C RID: 6732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A4C")]
		[Address(RVA = "0xE33EFC", Offset = "0xE33EFC", VA = "0xE33EFC")]
		public void CreateBatchItemList(out SpriteBatchItemList_Cloud item)
		{
		}

		// Token: 0x06001A4D RID: 6733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A4D")]
		[Address(RVA = "0xE340A4", Offset = "0xE340A4", VA = "0xE340A4")]
		public void DrawImmediateBatch(Effect effect)
		{
		}

		// Token: 0x170002E0 RID: 736
		// (get) Token: 0x06001A4E RID: 6734 RVA: 0x0000CC60 File Offset: 0x0000AE60
		[Token(Token = "0x170002E0")]
		private int WorldCameraHeight
		{
			[Token(Token = "0x6001A4E")]
			[Address(RVA = "0xE34674", Offset = "0xE34674", VA = "0xE34674")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06001A4F RID: 6735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A4F")]
		[Address(RVA = "0xE34B20", Offset = "0xE34B20", VA = "0xE34B20")]
		public void FlushBatches()
		{
		}

		// Token: 0x06001A50 RID: 6736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A50")]
		[Address(RVA = "0xE34D9C", Offset = "0xE34D9C", VA = "0xE34D9C")]
		public void DrawBatch(SpriteSortMode sortMode, Effect effect, bool deffered, [Optional] SpriteBatchItem_Cloud overrideFirstItem)
		{
		}

		// Token: 0x06001A51 RID: 6737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A51")]
		[Address(RVA = "0xE34840", Offset = "0xE34840", VA = "0xE34840")]
		private void AddSubMesh(Effect effect, Texture2D texture, EffectPass overloadEffectPass)
		{
		}

		// Token: 0x06001A52 RID: 6738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A52")]
		[Address(RVA = "0xE346FC", Offset = "0xE346FC", VA = "0xE346FC")]
		private void RenderVertexArrayWithSubMeshes(int vertexCount, int indexCount, Vector3 position, Vector3 scale)
		{
		}

		// Token: 0x04002D6E RID: 11630
		[Token(Token = "0x4002D6E")]
		private const int InitialBatchSize = 256;

		// Token: 0x04002D6F RID: 11631
		[Token(Token = "0x4002D6F")]
		private const int MaxBatchSize = 5461;

		// Token: 0x04002D70 RID: 11632
		[Token(Token = "0x4002D70")]
		private const int InitialVertexArraySize = 256;

		// Token: 0x04002D71 RID: 11633
		[Token(Token = "0x4002D71")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public SpriteBatchItem_Cloud[] _batchItemList;

		// Token: 0x04002D72 RID: 11634
		[Token(Token = "0x4002D72")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int _batchItemCount;

		// Token: 0x04002D73 RID: 11635
		[Token(Token = "0x4002D73")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int _lastBatchListId;

		// Token: 0x04002D74 RID: 11636
		[Token(Token = "0x4002D74")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public SpriteBatchItemList_Cloud _lastBatchList;

		// Token: 0x04002D75 RID: 11637
		[Token(Token = "0x4002D75")]
		public const int BatchListPoolCount = 64;

		// Token: 0x04002D76 RID: 11638
		[Token(Token = "0x4002D76")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public SpriteBatchItemList_Cloud[] _activeBatchListsPool;

		// Token: 0x04002D77 RID: 11639
		[Token(Token = "0x4002D77")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private SpriteBatchItemList_Cloud[] _batchItemListList;

		// Token: 0x04002D78 RID: 11640
		[Token(Token = "0x4002D78")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int _batchItemListCount;

		// Token: 0x04002D79 RID: 11641
		[Token(Token = "0x4002D79")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private readonly GraphicsDevice _device;

		// Token: 0x04002D7A RID: 11642
		[Token(Token = "0x4002D7A")]
		private const int maxQuadCount = 8192;

		// Token: 0x04002D7B RID: 11643
		[Token(Token = "0x4002D7B")]
		private const int maxVerts = 32768;

		// Token: 0x04002D7C RID: 11644
		[Token(Token = "0x4002D7C")]
		private const int maxIndices = 49152;

		// Token: 0x04002D7D RID: 11645
		[Token(Token = "0x4002D7D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int _vertexOffset;

		// Token: 0x04002D7E RID: 11646
		[Token(Token = "0x4002D7E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private int _indexOffset;

		// Token: 0x04002D7F RID: 11647
		[Token(Token = "0x4002D7F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int _materialOffset;

		// Token: 0x04002D80 RID: 11648
		[Token(Token = "0x4002D80")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private SpriteBatcher_Cloud.VertexData[] vertexData;

		// Token: 0x04002D81 RID: 11649
		[Token(Token = "0x4002D81")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private short[] indexData;

		// Token: 0x04002D82 RID: 11650
		[Token(Token = "0x4002D82")]
		private const int MaxSubMeshes = 1024;

		// Token: 0x04002D83 RID: 11651
		[Token(Token = "0x4002D83")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private SubMeshDescriptor[] _submeshList;

		// Token: 0x04002D84 RID: 11652
		[Token(Token = "0x4002D84")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int _submeshCount;

		// Token: 0x04002D85 RID: 11653
		[Token(Token = "0x4002D85")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Material[] _submeshListMaterials;

		// Token: 0x04002D86 RID: 11654
		[Token(Token = "0x4002D86")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static VertexAttributeDescriptor[] vertexDescription;

		// Token: 0x020003CC RID: 972
		[Token(Token = "0x20003CC")]
		public struct VertexData
		{
			// Token: 0x04002D87 RID: 11655
			[Token(Token = "0x4002D87")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector4 Position;

			// Token: 0x04002D88 RID: 11656
			[Token(Token = "0x4002D88")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Color32 Color;

			// Token: 0x04002D89 RID: 11657
			[Token(Token = "0x4002D89")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Vector2 TextureCoordinate;

			// Token: 0x04002D8A RID: 11658
			[Token(Token = "0x4002D8A")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector4 TextureRegion;
		}
	}
}
