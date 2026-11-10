using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Terraria.Achievements;

namespace Terraria.GameContent.Achievements
{
	// Token: 0x02000C63 RID: 3171
	[Token(Token = "0x2000C63")]
	public class TileDestroyedCondition : AchievementCondition
	{
		// Token: 0x06005E36 RID: 24118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E36")]
		[Address(RVA = "0x9BB1BC", Offset = "0x9BB1BC", VA = "0x9BB1BC")]
		private TileDestroyedCondition(LocalUser user, ushort[] tileIds)
		{
		}

		// Token: 0x06005E37 RID: 24119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E37")]
		[Address(RVA = "0x9BB614", Offset = "0x9BB614", VA = "0x9BB614", Slot = "5")]
		public override void Shutdown()
		{
		}

		// Token: 0x06005E38 RID: 24120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E38")]
		[Address(RVA = "0x9BB284", Offset = "0x9BB284", VA = "0x9BB284")]
		private static void ListenForDestruction(TileDestroyedCondition condition)
		{
		}

		// Token: 0x06005E39 RID: 24121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E39")]
		[Address(RVA = "0x9BB744", Offset = "0x9BB744", VA = "0x9BB744")]
		private static void TileDestroyedListener(Player player, ushort tileId)
		{
		}

		// Token: 0x06005E3A RID: 24122 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005E3A")]
		[Address(RVA = "0x9BB9BC", Offset = "0x9BB9BC", VA = "0x9BB9BC")]
		public static AchievementCondition Create(LocalUser user, ushort[] tileIds)
		{
			return null;
		}

		// Token: 0x04009DDB RID: 40411
		[Token(Token = "0x4009DDB")]
		public const string Identifier = "TILE_DESTROYED";

		// Token: 0x04009DDC RID: 40412
		[Token(Token = "0x4009DDC")]
		[FieldOffset(Offset = "0x0")]
		private static Dictionary<ushort, List<TileDestroyedCondition>> _listeners;

		// Token: 0x04009DDD RID: 40413
		[Token(Token = "0x4009DDD")]
		[FieldOffset(Offset = "0x4")]
		private static bool _isListenerHooked;

		// Token: 0x04009DDE RID: 40414
		[Token(Token = "0x4009DDE")]
		[FieldOffset(Offset = "0x18")]
		private readonly LocalUser _user;

		// Token: 0x04009DDF RID: 40415
		[Token(Token = "0x4009DDF")]
		[FieldOffset(Offset = "0x1C")]
		private ushort[] _tileIds;
	}
}
