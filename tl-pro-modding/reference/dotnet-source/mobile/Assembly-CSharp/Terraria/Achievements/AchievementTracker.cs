using System;
using Il2CppDummyDll;

namespace Terraria.Achievements
{
	// Token: 0x020007E8 RID: 2024
	[Token(Token = "0x20007E8")]
	public abstract class AchievementTracker<T> : FileAPI
	{
		// Token: 0x1700085B RID: 2139
		// (get) Token: 0x060045C5 RID: 17861 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700085B")]
		public T Value
		{
			[Token(Token = "0x60045C5")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700085C RID: 2140
		// (get) Token: 0x060045C6 RID: 17862 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700085C")]
		public T MaxValue
		{
			[Token(Token = "0x60045C6")]
			get
			{
				return null;
			}
		}

		// Token: 0x060045C7 RID: 17863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045C7")]
		protected AchievementTracker(TrackerType type)
		{
		}

		// Token: 0x060045C8 RID: 17864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045C8")]
		private void Terraria.Achievements.IAchievementTracker.ReportAs(string name)
		{
		}

		// Token: 0x060045C9 RID: 17865 RVA: 0x00021360 File Offset: 0x0001F560
		[Token(Token = "0x60045C9")]
		private TrackerType Terraria.Achievements.IAchievementTracker.GetTrackerType()
		{
			return TrackerType.Float;
		}

		// Token: 0x060045CA RID: 17866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045CA")]
		private void Terraria.Achievements.IAchievementTracker.Clear()
		{
		}

		// Token: 0x060045CB RID: 17867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045CB")]
		public void SetValue(T newValue, bool reportUpdate = true)
		{
		}

		// Token: 0x060045CC RID: 17868
		[Token(Token = "0x60045CC")]
		public abstract void ReportUpdate();

		// Token: 0x060045CD RID: 17869
		[Token(Token = "0x60045CD")]
		protected abstract void Load();

		// Token: 0x060045CE RID: 17870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045CE")]
		private void Terraria.Achievements.IAchievementTracker.Load()
		{
		}

		// Token: 0x060045CF RID: 17871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045CF")]
		protected void OnComplete()
		{
		}

		// Token: 0x04008D09 RID: 36105
		[Token(Token = "0x4008D09")]
		[FieldOffset(Offset = "0x0")]
		protected T _value;

		// Token: 0x04008D0A RID: 36106
		[Token(Token = "0x4008D0A")]
		[FieldOffset(Offset = "0x0")]
		protected T _maxValue;

		// Token: 0x04008D0B RID: 36107
		[Token(Token = "0x4008D0B")]
		[FieldOffset(Offset = "0x0")]
		protected string _name;

		// Token: 0x04008D0C RID: 36108
		[Token(Token = "0x4008D0C")]
		[FieldOffset(Offset = "0x0")]
		private TrackerType _type;
	}
}
