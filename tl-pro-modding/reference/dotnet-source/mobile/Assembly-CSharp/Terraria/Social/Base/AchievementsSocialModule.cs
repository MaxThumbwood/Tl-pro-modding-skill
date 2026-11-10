using System;
using Il2CppDummyDll;

namespace Terraria.Social.Base
{
	// Token: 0x0200062D RID: 1581
	[Token(Token = "0x200062D")]
	public abstract class AchievementsSocialModule : FileAPI
	{
		// Token: 0x06003DA0 RID: 15776
		[Token(Token = "0x6003DA0")]
		public abstract void Initialize();

		// Token: 0x06003DA1 RID: 15777
		[Token(Token = "0x6003DA1")]
		public abstract void Shutdown();

		// Token: 0x06003DA2 RID: 15778
		[Token(Token = "0x6003DA2")]
		public abstract byte[] GetEncryptionKey();

		// Token: 0x06003DA3 RID: 15779
		[Token(Token = "0x6003DA3")]
		public abstract string GetSavePath();

		// Token: 0x06003DA4 RID: 15780
		[Token(Token = "0x6003DA4")]
		public abstract void UpdateIntStat(string name, int value);

		// Token: 0x06003DA5 RID: 15781
		[Token(Token = "0x6003DA5")]
		public abstract void UpdateFloatStat(string name, float value);

		// Token: 0x06003DA6 RID: 15782
		[Token(Token = "0x6003DA6")]
		public abstract void CompleteAchievement(string name);

		// Token: 0x06003DA7 RID: 15783
		[Token(Token = "0x6003DA7")]
		public abstract bool IsAchievementCompleted(string name);

		// Token: 0x06003DA8 RID: 15784
		[Token(Token = "0x6003DA8")]
		public abstract void StoreStats();

		// Token: 0x06003DA9 RID: 15785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DA9")]
		[Address(RVA = "0x1E67D60", Offset = "0x1E67D60", VA = "0x1E67D60")]
		protected AchievementsSocialModule()
		{
		}
	}
}
