using System;
using Il2CppDummyDll;
using ReLogic.Utilities;

namespace Terraria.GameContent.Generation.Dungeon.Rooms
{
	// Token: 0x02000B3C RID: 2876
	[Token(Token = "0x2000B3C")]
	public abstract class StepBasedDungeonRoomSettings : DungeonRoomSettings
	{
		// Token: 0x06005920 RID: 22816 RVA: 0x000299D0 File Offset: 0x00027BD0
		[Token(Token = "0x6005920")]
		[Address(RVA = "0x8986B0", Offset = "0x8986B0", VA = "0x8986B0", Slot = "4")]
		public override int GetBoundingRadius()
		{
			return 0;
		}

		// Token: 0x06005921 RID: 22817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005921")]
		[Address(RVA = "0x898710", Offset = "0x898710", VA = "0x898710")]
		protected StepBasedDungeonRoomSettings()
		{
		}

		// Token: 0x04009AD5 RID: 39637
		[Token(Token = "0x4009AD5")]
		[FieldOffset(Offset = "0x44")]
		public int OverrideStrength;

		// Token: 0x04009AD6 RID: 39638
		[Token(Token = "0x4009AD6")]
		[FieldOffset(Offset = "0x48")]
		public int OverrideSteps;

		// Token: 0x04009AD7 RID: 39639
		[Token(Token = "0x4009AD7")]
		[FieldOffset(Offset = "0x50")]
		public Vector2D OverrideStartPosition;

		// Token: 0x04009AD8 RID: 39640
		[Token(Token = "0x4009AD8")]
		[FieldOffset(Offset = "0x60")]
		public Vector2D OverrideEndPosition;

		// Token: 0x04009AD9 RID: 39641
		[Token(Token = "0x4009AD9")]
		[FieldOffset(Offset = "0x70")]
		public Vector2D OverrideVelocity;

		// Token: 0x04009ADA RID: 39642
		[Token(Token = "0x4009ADA")]
		[FieldOffset(Offset = "0x80")]
		public double OverrideInteriorToExteriorRatio;
	}
}
