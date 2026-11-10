using System;
using Il2CppDummyDll;

namespace Terraria.GameInput
{
	// Token: 0x0200082A RID: 2090
	[Token(Token = "0x200082A")]
	public class TriggersPack
	{
		// Token: 0x060047A9 RID: 18345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60047A9")]
		[Address(RVA = "0x5E58F8", Offset = "0x5E58F8", VA = "0x5E58F8")]
		public void Initialize()
		{
		}

		// Token: 0x060047AA RID: 18346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60047AA")]
		[Address(RVA = "0x5E5AB8", Offset = "0x5E5AB8", VA = "0x5E5AB8")]
		public void Reset()
		{
		}

		// Token: 0x060047AB RID: 18347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60047AB")]
		[Address(RVA = "0x5E5C50", Offset = "0x5E5C50", VA = "0x5E5C50")]
		public void Update()
		{
		}

		// Token: 0x060047AC RID: 18348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60047AC")]
		[Address(RVA = "0x5E5C84", Offset = "0x5E5C84", VA = "0x5E5C84")]
		public void CompareDiffs(TriggersSet Bearer, TriggersSet oldset, TriggersSet newset)
		{
		}

		// Token: 0x060047AD RID: 18349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60047AD")]
		[Address(RVA = "0x5E5D8C", Offset = "0x5E5D8C", VA = "0x5E5D8C")]
		public TriggersPack()
		{
		}

		// Token: 0x04008E67 RID: 36455
		[Token(Token = "0x4008E67")]
		[FieldOffset(Offset = "0x8")]
		public TriggersSet Current;

		// Token: 0x04008E68 RID: 36456
		[Token(Token = "0x4008E68")]
		[FieldOffset(Offset = "0xC")]
		public TriggersSet Old;

		// Token: 0x04008E69 RID: 36457
		[Token(Token = "0x4008E69")]
		[FieldOffset(Offset = "0x10")]
		public TriggersSet JustPressed;

		// Token: 0x04008E6A RID: 36458
		[Token(Token = "0x4008E6A")]
		[FieldOffset(Offset = "0x14")]
		public TriggersSet JustReleased;
	}
}
