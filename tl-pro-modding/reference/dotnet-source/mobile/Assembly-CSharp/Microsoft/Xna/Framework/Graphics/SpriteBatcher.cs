using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

namespace Microsoft.Xna.Framework.Graphics
{
	// Token: 0x02000407 RID: 1031
	[Token(Token = "0x2000407")]
	public class SpriteBatcher
	{
		// Token: 0x06001C84 RID: 7300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C84")]
		[Address(RVA = "0xE859A0", Offset = "0xE859A0", VA = "0xE859A0")]
		public SpriteBatcher(GraphicsDevice device)
		{
		}

		// Token: 0x06001C85 RID: 7301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C85")]
		[Address(RVA = "0xE85DC4", Offset = "0xE85DC4", VA = "0xE85DC4")]
		private void InitialiseIndexBuffer()
		{
		}

		// Token: 0x06001C86 RID: 7302 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C86")]
		[Address(RVA = "0xE85E40", Offset = "0xE85E40", VA = "0xE85E40")]
		public SpriteBatchItem CreateBatchItem()
		{
			return null;
		}

		// Token: 0x06001C87 RID: 7303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C87")]
		[Address(RVA = "0xE85F58", Offset = "0xE85F58", VA = "0xE85F58")]
		public void CreateBatchItemList(out SpriteBatchItemList item)
		{
		}

		// Token: 0x06001C88 RID: 7304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C88")]
		[Address(RVA = "0xE86100", Offset = "0xE86100", VA = "0xE86100")]
		public void DrawImmediateBatch(Effect effect)
		{
		}

		// Token: 0x1700035E RID: 862
		// (get) Token: 0x06001C89 RID: 7305 RVA: 0x0000D578 File Offset: 0x0000B778
		[Token(Token = "0x1700035E")]
		private int WorldCameraHeight
		{
			[Token(Token = "0x6001C89")]
			[Address(RVA = "0xE867A8", Offset = "0xE867A8", VA = "0xE867A8")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06001C8A RID: 7306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C8A")]
		[Address(RVA = "0xE86BC8", Offset = "0xE86BC8", VA = "0xE86BC8")]
		public void FlushBatches()
		{
		}

		// Token: 0x06001C8B RID: 7307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C8B")]
		[Address(RVA = "0xE86EA8", Offset = "0xE86EA8", VA = "0xE86EA8")]
		public void DrawBatch(SpriteSortMode sortMode, Effect effect, bool deffered, [Optional] SpriteBatchItem overrideFirstItem)
		{
		}

		// Token: 0x06001C8C RID: 7308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C8C")]
		[Address(RVA = "0xE868F4", Offset = "0xE868F4", VA = "0xE868F4")]
		private void AddSubMesh(Effect effect, Texture2D texture, EffectPass overloadEffectPass)
		{
		}

		// Token: 0x06001C8D RID: 7309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C8D")]
		[Address(RVA = "0xE86830", Offset = "0xE86830", VA = "0xE86830")]
		private void RenderVertexArrayWithSubMeshes(int vertexCount, int indexCount, Vector3 position, Vector3 scale)
		{
		}

		// Token: 0x0400300D RID: 12301
		[Token(Token = "0x400300D")]
		private const int InitialBatchSize = 256;

		// Token: 0x0400300E RID: 12302
		[Token(Token = "0x400300E")]
		private const int MaxBatchSize = 5461;

		// Token: 0x0400300F RID: 12303
		[Token(Token = "0x400300F")]
		private const int InitialVertexArraySize = 256;

		// Token: 0x04003010 RID: 12304
		[Token(Token = "0x4003010")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public SpriteBatchItem[] _batchItemList;

		// Token: 0x04003011 RID: 12305
		[Token(Token = "0x4003011")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int _batchItemCount;

		// Token: 0x04003012 RID: 12306
		[Token(Token = "0x4003012")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int _lastBatchListId;

		// Token: 0x04003013 RID: 12307
		[Token(Token = "0x4003013")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public SpriteBatchItemList _lastBatchList;

		// Token: 0x04003014 RID: 12308
		[Token(Token = "0x4003014")]
		public const int BatchListPoolCount = 64;

		// Token: 0x04003015 RID: 12309
		[Token(Token = "0x4003015")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public SpriteBatchItemList[] _activeBatchListsPool;

		// Token: 0x04003016 RID: 12310
		[Token(Token = "0x4003016")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private SpriteBatchItemList[] _batchItemListList;

		// Token: 0x04003017 RID: 12311
		[Token(Token = "0x4003017")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int _batchItemListCount;

		// Token: 0x04003018 RID: 12312
		[Token(Token = "0x4003018")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private readonly GraphicsDevice _device;

		// Token: 0x04003019 RID: 12313
		[Token(Token = "0x4003019")]
		private const int maxQuadCount = 8192;

		// Token: 0x0400301A RID: 12314
		[Token(Token = "0x400301A")]
		private const int maxVerts = 32768;

		// Token: 0x0400301B RID: 12315
		[Token(Token = "0x400301B")]
		private const int maxIndices = 49152;

		// Token: 0x0400301C RID: 12316
		[Token(Token = "0x400301C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int _vertexOffset;

		// Token: 0x0400301D RID: 12317
		[Token(Token = "0x400301D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private int _indexOffset;

		// Token: 0x0400301E RID: 12318
		[Token(Token = "0x400301E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int _materialOffset;

		// Token: 0x0400301F RID: 12319
		[Token(Token = "0x400301F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private SpriteBatcher.VertexData[] vertexData;

		// Token: 0x04003020 RID: 12320
		[Token(Token = "0x4003020")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private short[] indexData;

		// Token: 0x04003021 RID: 12321
		[Token(Token = "0x4003021")]
		private const int MaxSubMeshes = 1024;

		// Token: 0x04003022 RID: 12322
		[Token(Token = "0x4003022")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private SubMeshDescriptor[] _submeshList;

		// Token: 0x04003023 RID: 12323
		[Token(Token = "0x4003023")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int _submeshCount;

		// Token: 0x04003024 RID: 12324
		[Token(Token = "0x4003024")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Material[] _submeshListMaterials;

		// Token: 0x04003025 RID: 12325
		[Token(Token = "0x4003025")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static VertexAttributeDescriptor[] vertexDescription;

		// Token: 0x02000408 RID: 1032
		[Token(Token = "0x2000408")]
		public struct FP16Vector2
		{
			// Token: 0x06001C8F RID: 7311 RVA: 0x0000D590 File Offset: 0x0000B790
			[Token(Token = "0x6001C8F")]
			[Address(RVA = "0xE87660", Offset = "0xE87660", VA = "0xE87660")]
			public static implicit operator Vector2(SpriteBatcher.FP16Vector2 v)
			{
				return default(Vector2);
			}

			// Token: 0x06001C90 RID: 7312 RVA: 0x0000D5A8 File Offset: 0x0000B7A8
			[Token(Token = "0x6001C90")]
			[Address(RVA = "0xE87668", Offset = "0xE87668", VA = "0xE87668")]
			public static implicit operator SpriteBatcher.FP16Vector2(Vector2 v)
			{
				return default(SpriteBatcher.FP16Vector2);
			}

			// Token: 0x06001C91 RID: 7313 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001C91")]
			[Address(RVA = "0xE87670", Offset = "0xE87670", VA = "0xE87670")]
			public FP16Vector2(float xVal, float yVal)
			{
			}

			// Token: 0x1700035F RID: 863
			// (get) Token: 0x06001C93 RID: 7315 RVA: 0x0000D5C0 File Offset: 0x0000B7C0
			// (set) Token: 0x06001C92 RID: 7314 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700035F")]
			public float x
			{
				[Token(Token = "0x6001C93")]
				[Address(RVA = "0xE87728", Offset = "0xE87728", VA = "0xE87728")]
				get
				{
					return 0f;
				}
				[Token(Token = "0x6001C92")]
				[Address(RVA = "0xE87678", Offset = "0xE87678", VA = "0xE87678")]
				set
				{
				}
			}

			// Token: 0x17000360 RID: 864
			// (get) Token: 0x06001C95 RID: 7317 RVA: 0x0000D5D8 File Offset: 0x0000B7D8
			// (set) Token: 0x06001C94 RID: 7316 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000360")]
			public float y
			{
				[Token(Token = "0x6001C95")]
				[Address(RVA = "0xE877E0", Offset = "0xE877E0", VA = "0xE877E0")]
				get
				{
					return 0f;
				}
				[Token(Token = "0x6001C94")]
				[Address(RVA = "0xE87730", Offset = "0xE87730", VA = "0xE87730")]
				set
				{
				}
			}

			// Token: 0x04003026 RID: 12326
			[Token(Token = "0x4003026")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float _x;

			// Token: 0x04003027 RID: 12327
			[Token(Token = "0x4003027")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public float _y;
		}

		// Token: 0x02000409 RID: 1033
		[Token(Token = "0x2000409")]
		public struct VertexData
		{
			// Token: 0x04003028 RID: 12328
			[Token(Token = "0x4003028")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector2 Position;

			// Token: 0x04003029 RID: 12329
			[Token(Token = "0x4003029")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Color32 Color;

			// Token: 0x0400302A RID: 12330
			[Token(Token = "0x400302A")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector2 TextureCoordinate;
		}
	}
}
