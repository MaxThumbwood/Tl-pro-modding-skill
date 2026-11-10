using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Terraria.Achievements
{
	// Token: 0x020007E6 RID: 2022
	[Token(Token = "0x20007E6")]
	public class AchievementManager
	{
		// Token: 0x14000045 RID: 69
		// (add) Token: 0x060045B0 RID: 17840 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x060045B1 RID: 17841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000045")]
		public event Achievement.AchievementCompleted OnAchievementCompleted
		{
			[Token(Token = "0x60045B0")]
			[Address(RVA = "0x5852E0", Offset = "0x5852E0", VA = "0x5852E0")]
			add
			{
			}
			[Token(Token = "0x60045B1")]
			[Address(RVA = "0x585390", Offset = "0x585390", VA = "0x585390")]
			remove
			{
			}
		}

		// Token: 0x060045B2 RID: 17842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045B2")]
		[Address(RVA = "0x585440", Offset = "0x585440", VA = "0x585440")]
		public AchievementManager(LocalUser user)
		{
		}

		// Token: 0x060045B3 RID: 17843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045B3")]
		[Address(RVA = "0x585754", Offset = "0x585754", VA = "0x585754")]
		public void Save()
		{
		}

		// Token: 0x060045B4 RID: 17844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045B4")]
		[Address(RVA = "0x585780", Offset = "0x585780", VA = "0x585780")]
		private void Save(string path, bool cloud)
		{
		}

		// Token: 0x060045B5 RID: 17845 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045B5")]
		[Address(RVA = "0x586070", Offset = "0x586070", VA = "0x586070")]
		public List<Achievement> CreateAchievementsList()
		{
			return null;
		}

		// Token: 0x060045B6 RID: 17846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045B6")]
		[Address(RVA = "0x5860F8", Offset = "0x5860F8", VA = "0x5860F8")]
		public void Load()
		{
		}

		// Token: 0x060045B7 RID: 17847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045B7")]
		[Address(RVA = "0x586124", Offset = "0x586124", VA = "0x586124")]
		private void Load(string path, bool cloud)
		{
		}

		// Token: 0x060045B8 RID: 17848 RVA: 0x00021330 File Offset: 0x0001F530
		[Token(Token = "0x60045B8")]
		[Address(RVA = "0x587058", Offset = "0x587058", VA = "0x587058")]
		public bool Clear(string achievementName)
		{
			return default(bool);
		}

		// Token: 0x060045B9 RID: 17849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045B9")]
		[Address(RVA = "0x587154", Offset = "0x587154", VA = "0x587154")]
		public void ClearAll()
		{
		}

		// Token: 0x060045BA RID: 17850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045BA")]
		[Address(RVA = "0x587360", Offset = "0x587360", VA = "0x587360")]
		public void Shutdown()
		{
		}

		// Token: 0x060045BB RID: 17851 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045BB")]
		[Address(RVA = "0x587514", Offset = "0x587514", VA = "0x587514")]
		private void AchievementCompleted(Achievement achievement)
		{
		}

		// Token: 0x060045BC RID: 17852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045BC")]
		[Address(RVA = "0x587568", Offset = "0x587568", VA = "0x587568")]
		public void Register(Achievement achievement)
		{
		}

		// Token: 0x060045BD RID: 17853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045BD")]
		[Address(RVA = "0x5876DC", Offset = "0x5876DC", VA = "0x5876DC")]
		public void RegisterIconIndex(string achievementName, int iconIndex)
		{
		}

		// Token: 0x060045BE RID: 17854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045BE")]
		[Address(RVA = "0x587750", Offset = "0x587750", VA = "0x587750")]
		public void RegisterAchievementCategory(string achievementName, AchievementCategory category)
		{
		}

		// Token: 0x060045BF RID: 17855 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045BF")]
		[Address(RVA = "0x5877DC", Offset = "0x5877DC", VA = "0x5877DC")]
		public Achievement GetAchievement(string achievementName)
		{
			return null;
		}

		// Token: 0x060045C0 RID: 17856 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045C0")]
		public T GetCondition<T>(string achievementName, string conditionName) where T : AchievementCondition
		{
			return null;
		}

		// Token: 0x060045C1 RID: 17857 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045C1")]
		[Address(RVA = "0x587868", Offset = "0x587868", VA = "0x587868")]
		public AchievementCondition GetCondition(string achievementName, string conditionName)
		{
			return null;
		}

		// Token: 0x060045C2 RID: 17858 RVA: 0x00021348 File Offset: 0x0001F548
		[Token(Token = "0x60045C2")]
		[Address(RVA = "0x58797C", Offset = "0x58797C", VA = "0x58797C")]
		public int GetIconIndex(string achievementName)
		{
			return 0;
		}

		// Token: 0x04008CFF RID: 36095
		[Token(Token = "0x4008CFF")]
		[FieldOffset(Offset = "0x8")]
		private string _savePath;

		// Token: 0x04008D00 RID: 36096
		[Token(Token = "0x4008D00")]
		[FieldOffset(Offset = "0xC")]
		private bool _isCloudSave;

		// Token: 0x04008D01 RID: 36097
		[Token(Token = "0x4008D01")]
		[FieldOffset(Offset = "0x10")]
		private LocalUser User;

		// Token: 0x04008D03 RID: 36099
		[Token(Token = "0x4008D03")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<string, Achievement> _achievements;

		// Token: 0x04008D04 RID: 36100
		[Token(Token = "0x4008D04")]
		[FieldOffset(Offset = "0x1C")]
		private readonly JsonSerializerSettings _serializerSettings;

		// Token: 0x04008D05 RID: 36101
		[Token(Token = "0x4008D05")]
		[FieldOffset(Offset = "0x20")]
		private byte[] _cryptoKey;

		// Token: 0x04008D06 RID: 36102
		[Token(Token = "0x4008D06")]
		[FieldOffset(Offset = "0x24")]
		private Dictionary<string, int> _achievementIconIndexes;

		// Token: 0x04008D07 RID: 36103
		[Token(Token = "0x4008D07")]
		[FieldOffset(Offset = "0x0")]
		private static object _ioLock;

		// Token: 0x020007E7 RID: 2023
		[Token(Token = "0x20007E7")]
		private class StoredAchievement
		{
			// Token: 0x060045C4 RID: 17860 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60045C4")]
			[Address(RVA = "0x587A98", Offset = "0x587A98", VA = "0x587A98")]
			public StoredAchievement()
			{
			}

			// Token: 0x04008D08 RID: 36104
			[Token(Token = "0x4008D08")]
			[FieldOffset(Offset = "0x8")]
			public Dictionary<string, JObject> Conditions;
		}
	}
}
