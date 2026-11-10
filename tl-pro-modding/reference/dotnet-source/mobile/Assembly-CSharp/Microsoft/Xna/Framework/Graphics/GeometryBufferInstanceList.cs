using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

namespace Microsoft.Xna.Framework.Graphics
{
	// Token: 0x020003EA RID: 1002
	[Token(Token = "0x20003EA")]
	public class GeometryBufferInstanceList
	{
		// Token: 0x06001B38 RID: 6968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B38")]
		[Address(RVA = "0xE55FBC", Offset = "0xE55FBC", VA = "0xE55FBC")]
		public GeometryBufferInstanceList(int vertexCount, [Optional] string rootName, int forcedLayer = -1)
		{
		}

		// Token: 0x06001B39 RID: 6969 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B39")]
		[Address(RVA = "0xE5379C", Offset = "0xE5379C", VA = "0xE5379C")]
		public GeometryBufferInstance GetBatchInstance(int bufferOffest)
		{
			return null;
		}

		// Token: 0x06001B3A RID: 6970 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B3A")]
		public GeometryBufferInstance GetInstance<T>(T[] vertices, short[] indices, int vertexCount, int indexCount, int bufferOffest, VertexAttributeDescriptor[] vertexDesc) where T : struct
		{
			return null;
		}

		// Token: 0x06001B3B RID: 6971 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B3B")]
		[Address(RVA = "0xE53EC4", Offset = "0xE53EC4", VA = "0xE53EC4")]
		public GeometryBufferInstance GetInstance(SpriteBatcher.VertexData[] vertices, short[] indices, int vertexCount, int indexCount, int bufferOffest)
		{
			return null;
		}

		// Token: 0x06001B3C RID: 6972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B3C")]
		[Address(RVA = "0xE56094", Offset = "0xE56094", VA = "0xE56094")]
		private void SetupParent()
		{
		}

		// Token: 0x06001B3D RID: 6973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B3D")]
		[Address(RVA = "0xE53330", Offset = "0xE53330", VA = "0xE53330")]
		public void SetOffset(Vector2 offset)
		{
		}

		// Token: 0x06001B3E RID: 6974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B3E")]
		[Address(RVA = "0xE53230", Offset = "0xE53230", VA = "0xE53230")]
		public void FinaliseInstances()
		{
		}

		// Token: 0x06001B3F RID: 6975 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B3F")]
		[Address(RVA = "0xE51418", Offset = "0xE51418", VA = "0xE51418")]
		public void ClearInstances()
		{
		}

		// Token: 0x04002F2F RID: 12079
		[Token(Token = "0x4002F2F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static GameObject _root;

		// Token: 0x04002F30 RID: 12080
		[Token(Token = "0x4002F30")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private readonly string _rootName;

		// Token: 0x04002F31 RID: 12081
		[Token(Token = "0x4002F31")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private GameObject _parent;

		// Token: 0x04002F32 RID: 12082
		[Token(Token = "0x4002F32")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Transform _parentTransform;

		// Token: 0x04002F33 RID: 12083
		[Token(Token = "0x4002F33")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private List<GeometryBufferInstance> _freeInstances;

		// Token: 0x04002F34 RID: 12084
		[Token(Token = "0x4002F34")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private List<GeometryBufferInstance> _usedInstances;

		// Token: 0x04002F35 RID: 12085
		[Token(Token = "0x4002F35")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private int _resetOffset;

		// Token: 0x04002F36 RID: 12086
		[Token(Token = "0x4002F36")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int _vertexCount;

		// Token: 0x04002F37 RID: 12087
		[Token(Token = "0x4002F37")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private int _forcedLayer;

		// Token: 0x04002F38 RID: 12088
		[Token(Token = "0x4002F38")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static VertexAttributeDescriptor[] vertexDescription;

		// Token: 0x04002F39 RID: 12089
		[Token(Token = "0x4002F39")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static SubMeshDescriptor[] subMeshes;

		// Token: 0x04002F3A RID: 12090
		[Token(Token = "0x4002F3A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool _finalPending;
	}
}
