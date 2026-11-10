using System;
using Il2CppDummyDll;

namespace Terraria.GameContent.Generation.Dungeon.Rooms
{
	// Token: 0x02000B45 RID: 2885
	[Token(Token = "0x2000B45")]
	public class RegularDungeonRoomSettings : DungeonRoomSettings
	{
		// Token: 0x06005960 RID: 22880 RVA: 0x00029D18 File Offset: 0x00027F18
		[Token(Token = "0x6005960")]
		[Address(RVA = "0x8A102C", Offset = "0x8A102C", VA = "0x8A102C", Slot = "4")]
		public override int GetBoundingRadius()
		{
			return 0;
		}

		// Token: 0x06005961 RID: 22881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005961")]
		[Address(RVA = "0x8A1058", Offset = "0x8A1058", VA = "0x8A1058")]
		public RegularDungeonRoomSettings()
		{
		}

		// Token: 0x04009AFC RID: 39676
		[Token(Token = "0x4009AFC")]
		[FieldOffset(Offset = "0x44")]
		public int OverrideInnerBoundsSize;

		// Token: 0x04009AFD RID: 39677
		[Token(Token = "0x4009AFD")]
		[FieldOffset(Offset = "0x48")]
		public int OverrideOuterBoundsSize;
	}
}
