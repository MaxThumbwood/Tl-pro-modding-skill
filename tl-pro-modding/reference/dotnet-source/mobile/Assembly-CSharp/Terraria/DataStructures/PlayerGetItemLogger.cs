using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Terraria.DataStructures
{
	// Token: 0x0200078E RID: 1934
	[Token(Token = "0x200078E")]
	public class PlayerGetItemLogger
	{
		// Token: 0x06004402 RID: 17410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004402")]
		[Address(RVA = "0x557730", Offset = "0x557730", VA = "0x557730")]
		public void Clear()
		{
		}

		// Token: 0x06004403 RID: 17411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004403")]
		[Address(RVA = "0x5577B0", Offset = "0x5577B0", VA = "0x5577B0")]
		public void Add(Item[] array, int slot, int itemSlotContext, int stack)
		{
		}

		// Token: 0x06004404 RID: 17412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004404")]
		[Address(RVA = "0x5578A8", Offset = "0x5578A8", VA = "0x5578A8")]
		public void Start()
		{
		}

		// Token: 0x06004405 RID: 17413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004405")]
		[Address(RVA = "0x55792C", Offset = "0x55792C", VA = "0x55792C")]
		public void Stop()
		{
		}

		// Token: 0x06004406 RID: 17414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004406")]
		[Address(RVA = "0x557938", Offset = "0x557938", VA = "0x557938")]
		public PlayerGetItemLogger()
		{
		}

		// Token: 0x04008B97 RID: 35735
		[Token(Token = "0x4008B97")]
		[FieldOffset(Offset = "0x8")]
		public List<PlayerGetItemLogger.GetItemLoggerEntry> Entries;

		// Token: 0x04008B98 RID: 35736
		[Token(Token = "0x4008B98")]
		[FieldOffset(Offset = "0xC")]
		private bool _enabled;

		// Token: 0x0200078F RID: 1935
		[Token(Token = "0x200078F")]
		public struct GetItemLoggerEntry
		{
			// Token: 0x04008B99 RID: 35737
			[Token(Token = "0x4008B99")]
			[FieldOffset(Offset = "0x0")]
			public Item[] TargetArray;

			// Token: 0x04008B9A RID: 35738
			[Token(Token = "0x4008B9A")]
			[FieldOffset(Offset = "0x4")]
			public int TargetSlot;

			// Token: 0x04008B9B RID: 35739
			[Token(Token = "0x4008B9B")]
			[FieldOffset(Offset = "0x8")]
			public int TargetItemSlotContext;

			// Token: 0x04008B9C RID: 35740
			[Token(Token = "0x4008B9C")]
			[FieldOffset(Offset = "0xC")]
			public int Stack;
		}
	}
}
