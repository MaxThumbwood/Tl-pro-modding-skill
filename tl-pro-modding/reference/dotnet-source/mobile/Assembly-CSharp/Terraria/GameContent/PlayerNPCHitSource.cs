using System;
using Il2CppDummyDll;

namespace Terraria.GameContent
{
	// Token: 0x020009C2 RID: 2498
	[Token(Token = "0x20009C2")]
	public struct PlayerNPCHitSource : FileAPI
	{
		// Token: 0x06005192 RID: 20882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005192")]
		[Address(RVA = "0x77FA10", Offset = "0x77FA10", VA = "0x77FA10")]
		public PlayerNPCHitSource(int itemType, int projType, string other)
		{
		}

		// Token: 0x170009A7 RID: 2471
		// (get) Token: 0x06005193 RID: 20883 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009A7")]
		public string Name
		{
			[Token(Token = "0x6005193")]
			[Address(RVA = "0x77FA18", Offset = "0x77FA18", VA = "0x77FA18")]
			get
			{
				return null;
			}
		}

		// Token: 0x06005194 RID: 20884 RVA: 0x00025E78 File Offset: 0x00024078
		[Token(Token = "0x6005194")]
		[Address(RVA = "0x77FB9C", Offset = "0x77FB9C", VA = "0x77FB9C")]
		public static PlayerNPCHitSource FromItem(int itemType)
		{
			return default(PlayerNPCHitSource);
		}

		// Token: 0x06005195 RID: 20885 RVA: 0x00025E90 File Offset: 0x00024090
		[Token(Token = "0x6005195")]
		[Address(RVA = "0x77FBAC", Offset = "0x77FBAC", VA = "0x77FBAC")]
		public static PlayerNPCHitSource FromProjectile(int projType)
		{
			return default(PlayerNPCHitSource);
		}

		// Token: 0x06005196 RID: 20886 RVA: 0x00025EA8 File Offset: 0x000240A8
		[Token(Token = "0x6005196")]
		[Address(RVA = "0x77FBBC", Offset = "0x77FBBC", VA = "0x77FBBC")]
		public static PlayerNPCHitSource FromOther(string s)
		{
			return default(PlayerNPCHitSource);
		}

		// Token: 0x06005197 RID: 20887 RVA: 0x00025EC0 File Offset: 0x000240C0
		[Token(Token = "0x6005197")]
		[Address(RVA = "0x77FBD0", Offset = "0x77FBD0", VA = "0x77FBD0", Slot = "4")]
		public bool Equals(PlayerNPCHitSource other)
		{
			return default(bool);
		}

		// Token: 0x06005198 RID: 20888 RVA: 0x00025ED8 File Offset: 0x000240D8
		[Token(Token = "0x6005198")]
		[Address(RVA = "0x77FBFC", Offset = "0x77FBFC", VA = "0x77FBFC", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06005199 RID: 20889 RVA: 0x00025EF0 File Offset: 0x000240F0
		[Token(Token = "0x6005199")]
		[Address(RVA = "0x77FC48", Offset = "0x77FC48", VA = "0x77FC48", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x0600519A RID: 20890 RVA: 0x00025F08 File Offset: 0x00024108
		[Token(Token = "0x600519A")]
		[Address(RVA = "0x77FCEC", Offset = "0x77FCEC", VA = "0x77FCEC")]
		public static bool operator ==(PlayerNPCHitSource left, PlayerNPCHitSource right)
		{
			return default(bool);
		}

		// Token: 0x0600519B RID: 20891 RVA: 0x00025F20 File Offset: 0x00024120
		[Token(Token = "0x600519B")]
		[Address(RVA = "0x77FD14", Offset = "0x77FD14", VA = "0x77FD14")]
		public static bool operator !=(PlayerNPCHitSource left, PlayerNPCHitSource right)
		{
			return default(bool);
		}

		// Token: 0x040094FE RID: 38142
		[Token(Token = "0x40094FE")]
		[FieldOffset(Offset = "0x0")]
		public readonly int ItemType;

		// Token: 0x040094FF RID: 38143
		[Token(Token = "0x40094FF")]
		[FieldOffset(Offset = "0x4")]
		public readonly int ProjType;

		// Token: 0x04009500 RID: 38144
		[Token(Token = "0x4009500")]
		[FieldOffset(Offset = "0x8")]
		public readonly string Other;
	}
}
