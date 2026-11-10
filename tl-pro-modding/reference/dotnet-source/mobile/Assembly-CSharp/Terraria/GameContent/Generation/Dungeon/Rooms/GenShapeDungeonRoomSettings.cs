using System;
using Il2CppDummyDll;
using Terraria.WorldBuilding;

namespace Terraria.GameContent.Generation.Dungeon.Rooms
{
	// Token: 0x02000B3F RID: 2879
	[Token(Token = "0x2000B3F")]
	public class GenShapeDungeonRoomSettings : DungeonRoomSettings
	{
		// Token: 0x0600593B RID: 22843 RVA: 0x00029B50 File Offset: 0x00027D50
		[Token(Token = "0x600593B")]
		[Address(RVA = "0x89ABB4", Offset = "0x89ABB4", VA = "0x89ABB4", Slot = "4")]
		public override int GetBoundingRadius()
		{
			return 0;
		}

		// Token: 0x0600593C RID: 22844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600593C")]
		[Address(RVA = "0x89ABBC", Offset = "0x89ABBC", VA = "0x89ABBC")]
		public GenShapeDungeonRoomSettings()
		{
		}

		// Token: 0x04009AE6 RID: 39654
		[Token(Token = "0x4009AE6")]
		[FieldOffset(Offset = "0x44")]
		public GenShapeType ShapeType;

		// Token: 0x04009AE7 RID: 39655
		[Token(Token = "0x4009AE7")]
		[FieldOffset(Offset = "0x48")]
		public GenShape InnerShape;

		// Token: 0x04009AE8 RID: 39656
		[Token(Token = "0x4009AE8")]
		[FieldOffset(Offset = "0x4C")]
		public GenShape OuterShape;

		// Token: 0x04009AE9 RID: 39657
		[Token(Token = "0x4009AE9")]
		[FieldOffset(Offset = "0x50")]
		public int BoundingRadius;
	}
}
