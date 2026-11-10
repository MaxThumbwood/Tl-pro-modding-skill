using System;
using Il2CppDummyDll;

namespace Terraria.GameContent.Generation.Dungeon.Rooms
{
	// Token: 0x02000B43 RID: 2883
	[Token(Token = "0x2000B43")]
	public class LivingTreeDungeonRoomSettings : DungeonRoomSettings
	{
		// Token: 0x06005954 RID: 22868 RVA: 0x00029CA0 File Offset: 0x00027EA0
		[Token(Token = "0x6005954")]
		[Address(RVA = "0x89EC08", Offset = "0x89EC08", VA = "0x89EC08", Slot = "4")]
		public override int GetBoundingRadius()
		{
			return 0;
		}

		// Token: 0x06005955 RID: 22869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005955")]
		[Address(RVA = "0x89EC10", Offset = "0x89EC10", VA = "0x89EC10")]
		public LivingTreeDungeonRoomSettings()
		{
		}

		// Token: 0x04009AF4 RID: 39668
		[Token(Token = "0x4009AF4")]
		[FieldOffset(Offset = "0x44")]
		public int InnerWidth;

		// Token: 0x04009AF5 RID: 39669
		[Token(Token = "0x4009AF5")]
		[FieldOffset(Offset = "0x48")]
		public int InnerHeight;

		// Token: 0x04009AF6 RID: 39670
		[Token(Token = "0x4009AF6")]
		[FieldOffset(Offset = "0x4C")]
		public int Depth;

		// Token: 0x04009AF7 RID: 39671
		[Token(Token = "0x4009AF7")]
		[FieldOffset(Offset = "0x50")]
		public int BoundingRadius;
	}
}
