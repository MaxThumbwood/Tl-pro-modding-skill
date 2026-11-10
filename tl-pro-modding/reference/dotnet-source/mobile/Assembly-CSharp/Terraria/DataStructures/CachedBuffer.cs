using System;
using System.IO;
using Il2CppDummyDll;

namespace Terraria.DataStructures
{
	// Token: 0x0200074E RID: 1870
	[Token(Token = "0x200074E")]
	public class CachedBuffer
	{
		// Token: 0x1700081D RID: 2077
		// (get) Token: 0x0600429D RID: 17053 RVA: 0x00020418 File Offset: 0x0001E618
		[Token(Token = "0x1700081D")]
		public int Length
		{
			[Token(Token = "0x600429D")]
			[Address(RVA = "0x4F81DC", Offset = "0x4F81DC", VA = "0x4F81DC")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700081E RID: 2078
		// (get) Token: 0x0600429E RID: 17054 RVA: 0x00020430 File Offset: 0x0001E630
		[Token(Token = "0x1700081E")]
		public bool IsActive
		{
			[Token(Token = "0x600429E")]
			[Address(RVA = "0x4F86D4", Offset = "0x4F86D4", VA = "0x4F86D4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600429F RID: 17055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600429F")]
		[Address(RVA = "0x4F7D08", Offset = "0x4F7D08", VA = "0x4F7D08")]
		public CachedBuffer(byte[] data)
		{
		}

		// Token: 0x060042A0 RID: 17056 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042A0")]
		[Address(RVA = "0x4F7E2C", Offset = "0x4F7E2C", VA = "0x4F7E2C")]
		internal CachedBuffer Activate()
		{
			return null;
		}

		// Token: 0x060042A1 RID: 17057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042A1")]
		[Address(RVA = "0x4F86DC", Offset = "0x4F86DC", VA = "0x4F86DC")]
		public void Recycle()
		{
		}

		// Token: 0x04008A21 RID: 35361
		[Token(Token = "0x4008A21")]
		[FieldOffset(Offset = "0x8")]
		public readonly byte[] Data;

		// Token: 0x04008A22 RID: 35362
		[Token(Token = "0x4008A22")]
		[FieldOffset(Offset = "0xC")]
		public readonly BinaryWriter Writer;

		// Token: 0x04008A23 RID: 35363
		[Token(Token = "0x4008A23")]
		[FieldOffset(Offset = "0x10")]
		public readonly BinaryReader Reader;

		// Token: 0x04008A24 RID: 35364
		[Token(Token = "0x4008A24")]
		[FieldOffset(Offset = "0x14")]
		private readonly MemoryStream _memoryStream;

		// Token: 0x04008A25 RID: 35365
		[Token(Token = "0x4008A25")]
		[FieldOffset(Offset = "0x18")]
		private bool _isActive;
	}
}
