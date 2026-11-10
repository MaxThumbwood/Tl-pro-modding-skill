using System;
using Il2CppDummyDll;

namespace Microsoft.Xna.Framework.Input
{
	// Token: 0x020003B4 RID: 948
	[Token(Token = "0x20003B4")]
	public struct GamePadTriggers
	{
		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x06001948 RID: 6472 RVA: 0x0000C1B0 File Offset: 0x0000A3B0
		// (set) Token: 0x06001949 RID: 6473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170002A0")]
		public float Left
		{
			[Token(Token = "0x6001948")]
			[Address(RVA = "0xE260A0", Offset = "0xE260A0", VA = "0xE260A0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6001949")]
			[Address(RVA = "0xE260A8", Offset = "0xE260A8", VA = "0xE260A8")]
			private set
			{
			}
		}

		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x0600194A RID: 6474 RVA: 0x0000C1C8 File Offset: 0x0000A3C8
		// (set) Token: 0x0600194B RID: 6475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170002A1")]
		public float Right
		{
			[Token(Token = "0x600194A")]
			[Address(RVA = "0xE260B0", Offset = "0xE260B0", VA = "0xE260B0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600194B")]
			[Address(RVA = "0xE260B8", Offset = "0xE260B8", VA = "0xE260B8")]
			private set
			{
			}
		}

		// Token: 0x0600194C RID: 6476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600194C")]
		[Address(RVA = "0xE24424", Offset = "0xE24424", VA = "0xE24424")]
		public GamePadTriggers(float leftTrigger, float rightTrigger)
		{
		}

		// Token: 0x0600194D RID: 6477 RVA: 0x0000C1E0 File Offset: 0x0000A3E0
		[Token(Token = "0x600194D")]
		[Address(RVA = "0xE24930", Offset = "0xE24930", VA = "0xE24930")]
		public static bool operator ==(GamePadTriggers left, GamePadTriggers right)
		{
			return default(bool);
		}

		// Token: 0x0600194E RID: 6478 RVA: 0x0000C1F8 File Offset: 0x0000A3F8
		[Token(Token = "0x600194E")]
		[Address(RVA = "0xE260C0", Offset = "0xE260C0", VA = "0xE260C0")]
		public static bool operator !=(GamePadTriggers left, GamePadTriggers right)
		{
			return default(bool);
		}

		// Token: 0x0600194F RID: 6479 RVA: 0x0000C210 File Offset: 0x0000A410
		[Token(Token = "0x600194F")]
		[Address(RVA = "0xE260F4", Offset = "0xE260F4", VA = "0xE260F4", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06001950 RID: 6480 RVA: 0x0000C228 File Offset: 0x0000A428
		[Token(Token = "0x6001950")]
		[Address(RVA = "0xE24EFC", Offset = "0xE24EFC", VA = "0xE24EFC", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001951 RID: 6481 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001951")]
		[Address(RVA = "0xE2575C", Offset = "0xE2575C", VA = "0xE2575C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x04002BB2 RID: 11186
		[Token(Token = "0x4002BB2")]
		[FieldOffset(Offset = "0x0")]
		private float <Left>k__BackingField;

		// Token: 0x04002BB3 RID: 11187
		[Token(Token = "0x4002BB3")]
		[FieldOffset(Offset = "0x4")]
		private float <Right>k__BackingField;
	}
}
