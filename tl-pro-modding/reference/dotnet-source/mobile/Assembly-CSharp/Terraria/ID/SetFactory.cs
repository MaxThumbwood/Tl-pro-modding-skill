using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Terraria.ID
{
	// Token: 0x02000711 RID: 1809
	[Token(Token = "0x2000711")]
	public class SetFactory
	{
		// Token: 0x060041DA RID: 16858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60041DA")]
		[Address(RVA = "0x1F7610C", Offset = "0x1F7610C", VA = "0x1F7610C")]
		public SetFactory(int size)
		{
		}

		// Token: 0x060041DB RID: 16859 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041DB")]
		[Address(RVA = "0x1F87508", Offset = "0x1F87508", VA = "0x1F87508")]
		protected bool[] GetBoolBuffer()
		{
			return null;
		}

		// Token: 0x060041DC RID: 16860 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041DC")]
		[Address(RVA = "0x1F87690", Offset = "0x1F87690", VA = "0x1F87690")]
		protected int[] GetIntBuffer()
		{
			return null;
		}

		// Token: 0x060041DD RID: 16861 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041DD")]
		[Address(RVA = "0x1F87818", Offset = "0x1F87818", VA = "0x1F87818")]
		protected ushort[] GetUshortBuffer()
		{
			return null;
		}

		// Token: 0x060041DE RID: 16862 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041DE")]
		[Address(RVA = "0x1F879A0", Offset = "0x1F879A0", VA = "0x1F879A0")]
		protected float[] GetFloatBuffer()
		{
			return null;
		}

		// Token: 0x060041DF RID: 16863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60041DF")]
		public void Recycle<T>(T[] buffer)
		{
		}

		// Token: 0x060041E0 RID: 16864 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041E0")]
		[Address(RVA = "0x1F76370", Offset = "0x1F76370", VA = "0x1F76370")]
		public bool[] CreateBoolSet(int[] types)
		{
			return null;
		}

		// Token: 0x060041E1 RID: 16865 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041E1")]
		[Address(RVA = "0x1F872E4", Offset = "0x1F872E4", VA = "0x1F872E4")]
		public bool[] CreateBoolSet(bool defaultState, int[] types)
		{
			return null;
		}

		// Token: 0x060041E2 RID: 16866 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041E2")]
		[Address(RVA = "0x1F87B28", Offset = "0x1F87B28", VA = "0x1F87B28")]
		public int[] CreateIntSet(int[] types)
		{
			return null;
		}

		// Token: 0x060041E3 RID: 16867 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041E3")]
		[Address(RVA = "0x1F76400", Offset = "0x1F76400", VA = "0x1F76400")]
		public int[] CreateIntSet(int defaultState, int[] inputs)
		{
			return null;
		}

		// Token: 0x060041E4 RID: 16868 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041E4")]
		[Address(RVA = "0x1F87B34", Offset = "0x1F87B34", VA = "0x1F87B34")]
		public ushort[] CreateUshortSet(ushort defaultState, ushort[] inputs)
		{
			return null;
		}

		// Token: 0x060041E5 RID: 16869 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041E5")]
		[Address(RVA = "0x1F87374", Offset = "0x1F87374", VA = "0x1F87374")]
		public float[] CreateFloatSet(float defaultState, float[] inputs)
		{
			return null;
		}

		// Token: 0x060041E6 RID: 16870 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041E6")]
		public T[] CreateCustomSet<T>(T defaultState, object[] inputs)
		{
			return null;
		}

		// Token: 0x04008175 RID: 33141
		[Token(Token = "0x4008175")]
		[FieldOffset(Offset = "0x8")]
		protected int _size;

		// Token: 0x04008176 RID: 33142
		[Token(Token = "0x4008176")]
		[FieldOffset(Offset = "0xC")]
		private readonly Queue<int[]> _intBufferCache;

		// Token: 0x04008177 RID: 33143
		[Token(Token = "0x4008177")]
		[FieldOffset(Offset = "0x10")]
		private readonly Queue<ushort[]> _ushortBufferCache;

		// Token: 0x04008178 RID: 33144
		[Token(Token = "0x4008178")]
		[FieldOffset(Offset = "0x14")]
		private readonly Queue<bool[]> _boolBufferCache;

		// Token: 0x04008179 RID: 33145
		[Token(Token = "0x4008179")]
		[FieldOffset(Offset = "0x18")]
		private readonly Queue<float[]> _floatBufferCache;

		// Token: 0x0400817A RID: 33146
		[Token(Token = "0x400817A")]
		[FieldOffset(Offset = "0x1C")]
		private object _queueLock;
	}
}
