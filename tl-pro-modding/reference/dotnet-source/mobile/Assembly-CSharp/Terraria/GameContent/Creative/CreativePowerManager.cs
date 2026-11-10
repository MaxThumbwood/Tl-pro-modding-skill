using System;
using System.Collections.Generic;
using System.IO;
using Il2CppDummyDll;

namespace Terraria.GameContent.Creative
{
	// Token: 0x02000CD2 RID: 3282
	[Token(Token = "0x2000CD2")]
	public class CreativePowerManager
	{
		// Token: 0x17000A92 RID: 2706
		// (get) Token: 0x06006177 RID: 24951 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A92")]
		public static CreativePowerManager Instance
		{
			[Token(Token = "0x6006177")]
			[Address(RVA = "0xAA3F74", Offset = "0xAA3F74", VA = "0xAA3F74")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A93 RID: 2707
		// (get) Token: 0x06006178 RID: 24952 RVA: 0x0002D048 File Offset: 0x0002B248
		// (set) Token: 0x06006179 RID: 24953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A93")]
		private static bool _initialized
		{
			[Token(Token = "0x6006178")]
			[Address(RVA = "0xAB3044", Offset = "0xAB3044", VA = "0xAB3044")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6006179")]
			[Address(RVA = "0xAB30AC", Offset = "0xAB30AC", VA = "0xAB30AC")]
			set
			{
			}
		}

		// Token: 0x0600617A RID: 24954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600617A")]
		[Address(RVA = "0xAB3118", Offset = "0xAB3118", VA = "0xAB3118")]
		public CreativePowerManager()
		{
		}

		// Token: 0x0600617B RID: 24955 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600617B")]
		public void Register<T>(string nameInServerConfig) where T : ICreativePower, new()
		{
		}

		// Token: 0x0600617C RID: 24956 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600617C")]
		public T GetPower<T>() where T : class, ICreativePower
		{
			return null;
		}

		// Token: 0x0600617D RID: 24957 RVA: 0x0002D060 File Offset: 0x0002B260
		[Token(Token = "0x600617D")]
		public ushort GetPowerId<T>() where T : ICreativePower
		{
			return 0;
		}

		// Token: 0x0600617E RID: 24958 RVA: 0x0002D078 File Offset: 0x0002B278
		[Token(Token = "0x600617E")]
		[Address(RVA = "0xAA3FDC", Offset = "0xAA3FDC", VA = "0xAA3FDC")]
		public bool TryGetPower(ushort id, out ICreativePower power)
		{
			return default(bool);
		}

		// Token: 0x0600617F RID: 24959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600617F")]
		[Address(RVA = "0xAB3210", Offset = "0xAB3210", VA = "0xAB3210")]
		public static void TryListingPermissionsFrom(string line)
		{
		}

		// Token: 0x06006180 RID: 24960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006180")]
		[Address(RVA = "0xAB35A8", Offset = "0xAB35A8", VA = "0xAB35A8")]
		public static void Initialize()
		{
		}

		// Token: 0x06006181 RID: 24961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006181")]
		[Address(RVA = "0xAB3F38", Offset = "0xAB3F38", VA = "0xAB3F38")]
		public void Reset()
		{
		}

		// Token: 0x06006182 RID: 24962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006182")]
		[Address(RVA = "0xAB4334", Offset = "0xAB4334", VA = "0xAB4334")]
		public void SaveToWorld(BinaryWriter writer)
		{
		}

		// Token: 0x06006183 RID: 24963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006183")]
		[Address(RVA = "0xAB4610", Offset = "0xAB4610", VA = "0xAB4610")]
		public void LoadFromWorld(BinaryReader reader, int versionGameWasLastSavedOn)
		{
		}

		// Token: 0x06006184 RID: 24964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006184")]
		[Address(RVA = "0xAB478C", Offset = "0xAB478C", VA = "0xAB478C")]
		public void ValidateWorld(BinaryReader reader, int versionGameWasLastSavedOn)
		{
		}

		// Token: 0x06006185 RID: 24965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006185")]
		[Address(RVA = "0xAB4908", Offset = "0xAB4908", VA = "0xAB4908")]
		public static void SyncSplitScreenPlayer(int playerIndex)
		{
		}

		// Token: 0x06006186 RID: 24966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006186")]
		[Address(RVA = "0xAB49F8", Offset = "0xAB49F8", VA = "0xAB49F8")]
		private void SyncSplitScreenPlayerInternal(int playerIndex)
		{
		}

		// Token: 0x06006187 RID: 24967 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006187")]
		[Address(RVA = "0xAB4FFC", Offset = "0xAB4FFC", VA = "0xAB4FFC")]
		public void SyncThingsToJoiningPlayer(int playerIndex)
		{
		}

		// Token: 0x06006188 RID: 24968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006188")]
		[Address(RVA = "0xAB54D0", Offset = "0xAB54D0", VA = "0xAB54D0")]
		public void SaveToPlayer(Player player, BinaryWriter writer)
		{
		}

		// Token: 0x06006189 RID: 24969 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006189")]
		[Address(RVA = "0xAB57B4", Offset = "0xAB57B4", VA = "0xAB57B4")]
		public void LoadToPlayer(Player player, BinaryReader reader, int versionGameWasLastSavedOn)
		{
		}

		// Token: 0x0600618A RID: 24970 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600618A")]
		[Address(RVA = "0xAB5BA4", Offset = "0xAB5BA4", VA = "0xAB5BA4")]
		public void ApplyLoadedDataToPlayer(Player player)
		{
		}

		// Token: 0x0600618B RID: 24971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600618B")]
		[Address(RVA = "0xAB5960", Offset = "0xAB5960", VA = "0xAB5960")]
		public void ResetPowersForPlayer(Player player)
		{
		}

		// Token: 0x0600618C RID: 24972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600618C")]
		[Address(RVA = "0xAB5DE8", Offset = "0xAB5DE8", VA = "0xAB5DE8")]
		public void ResetDataForNewPlayer(Player player)
		{
		}

		// Token: 0x0400A020 RID: 40992
		[Token(Token = "0x400A020")]
		[FieldOffset(Offset = "0x8")]
		private Dictionary<ushort, ICreativePower> _powersById;

		// Token: 0x0400A021 RID: 40993
		[Token(Token = "0x400A021")]
		[FieldOffset(Offset = "0xC")]
		private Dictionary<string, ICreativePower> _powersByName;

		// Token: 0x0400A022 RID: 40994
		[Token(Token = "0x400A022")]
		[FieldOffset(Offset = "0x10")]
		private ushort _powersCount;

		// Token: 0x0400A023 RID: 40995
		[Token(Token = "0x400A023")]
		private const string _powerPermissionsLineHeader = "journeypermission_";

		// Token: 0x02000CD3 RID: 3283
		[Token(Token = "0x2000CD3")]
		private class PowerTypeStorage<T> where T : ICreativePower
		{
			// Token: 0x0600618D RID: 24973 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600618D")]
			public PowerTypeStorage()
			{
			}

			// Token: 0x0400A024 RID: 40996
			[Token(Token = "0x400A024")]
			[FieldOffset(Offset = "0x0")]
			public static ushort Id;

			// Token: 0x0400A025 RID: 40997
			[Token(Token = "0x400A025")]
			[FieldOffset(Offset = "0x0")]
			public static string Name;
		}
	}
}
