using System;
using System.IO;
using Il2CppDummyDll;
using Terraria.DataStructures;

namespace Terraria.Net
{
	// Token: 0x020007F8 RID: 2040
	[Token(Token = "0x20007F8")]
	public struct NetPacket
	{
		// Token: 0x17000863 RID: 2147
		// (get) Token: 0x06004610 RID: 17936 RVA: 0x00021408 File Offset: 0x0001F608
		// (set) Token: 0x06004611 RID: 17937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000863")]
		public int Length
		{
			[Token(Token = "0x6004610")]
			[Address(RVA = "0x58B078", Offset = "0x58B078", VA = "0x58B078")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6004611")]
			[Address(RVA = "0x58B080", Offset = "0x58B080", VA = "0x58B080")]
			private set
			{
			}
		}

		// Token: 0x17000864 RID: 2148
		// (get) Token: 0x06004612 RID: 17938 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000864")]
		public BinaryWriter Writer
		{
			[Token(Token = "0x6004612")]
			[Address(RVA = "0x58B088", Offset = "0x58B088", VA = "0x58B088")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000865 RID: 2149
		// (get) Token: 0x06004613 RID: 17939 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000865")]
		public BinaryReader Reader
		{
			[Token(Token = "0x6004613")]
			[Address(RVA = "0x5889AC", Offset = "0x5889AC", VA = "0x5889AC")]
			get
			{
				return null;
			}
		}

		// Token: 0x06004614 RID: 17940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004614")]
		[Address(RVA = "0x58B0AC", Offset = "0x58B0AC", VA = "0x58B0AC")]
		public NetPacket(ushort id, int size)
		{
		}

		// Token: 0x06004615 RID: 17941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004615")]
		[Address(RVA = "0x588E28", Offset = "0x588E28", VA = "0x588E28")]
		public void Recycle()
		{
		}

		// Token: 0x06004616 RID: 17942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004616")]
		[Address(RVA = "0x588E4C", Offset = "0x588E4C", VA = "0x588E4C")]
		public void ShrinkToFit()
		{
		}

		// Token: 0x04008D28 RID: 36136
		[Token(Token = "0x4008D28")]
		public const int HEADER_SIZE = 5;

		// Token: 0x04008D29 RID: 36137
		[Token(Token = "0x4008D29")]
		[FieldOffset(Offset = "0x0")]
		public readonly ushort Id;

		// Token: 0x04008D2A RID: 36138
		[Token(Token = "0x4008D2A")]
		[FieldOffset(Offset = "0x4")]
		private int <Length>k__BackingField;

		// Token: 0x04008D2B RID: 36139
		[Token(Token = "0x4008D2B")]
		[FieldOffset(Offset = "0x8")]
		public readonly CachedBuffer Buffer;
	}
}
