using System;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;

namespace Terraria.Achievements
{
	// Token: 0x020007E4 RID: 2020
	[Token(Token = "0x20007E4")]
	public abstract class AchievementCondition
	{
		// Token: 0x14000044 RID: 68
		// (add) Token: 0x060045A2 RID: 17826 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x060045A3 RID: 17827 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000044")]
		public event AchievementCondition.AchievementUpdate OnComplete
		{
			[Token(Token = "0x60045A2")]
			[Address(RVA = "0x5840DC", Offset = "0x5840DC", VA = "0x5840DC")]
			add
			{
			}
			[Token(Token = "0x60045A3")]
			[Address(RVA = "0x5850D4", Offset = "0x5850D4", VA = "0x5850D4")]
			remove
			{
			}
		}

		// Token: 0x1700085A RID: 2138
		// (get) Token: 0x060045A4 RID: 17828 RVA: 0x00021318 File Offset: 0x0001F518
		[Token(Token = "0x1700085A")]
		public bool IsCompleted
		{
			[Token(Token = "0x60045A4")]
			[Address(RVA = "0x585184", Offset = "0x585184", VA = "0x585184")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060045A5 RID: 17829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045A5")]
		[Address(RVA = "0x58518C", Offset = "0x58518C", VA = "0x58518C")]
		protected AchievementCondition(string name)
		{
		}

		// Token: 0x060045A6 RID: 17830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045A6")]
		[Address(RVA = "0x5851A8", Offset = "0x5851A8", VA = "0x5851A8", Slot = "4")]
		public virtual void Load(JObject state)
		{
		}

		// Token: 0x060045A7 RID: 17831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045A7")]
		[Address(RVA = "0x585254", Offset = "0x585254", VA = "0x585254", Slot = "5")]
		public virtual void Shutdown()
		{
		}

		// Token: 0x060045A8 RID: 17832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045A8")]
		[Address(RVA = "0x585258", Offset = "0x585258", VA = "0x585258", Slot = "6")]
		public virtual void Clear()
		{
		}

		// Token: 0x060045A9 RID: 17833 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045A9")]
		[Address(RVA = "0x585264", Offset = "0x585264", VA = "0x585264", Slot = "7")]
		public virtual void Complete()
		{
		}

		// Token: 0x060045AA RID: 17834 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045AA")]
		[Address(RVA = "0x58529C", Offset = "0x58529C", VA = "0x58529C", Slot = "8")]
		protected virtual IAchievementTracker CreateAchievementTracker()
		{
			return null;
		}

		// Token: 0x060045AB RID: 17835 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045AB")]
		[Address(RVA = "0x584E24", Offset = "0x584E24", VA = "0x584E24")]
		public IAchievementTracker GetAchievementTracker()
		{
			return null;
		}

		// Token: 0x04008CFB RID: 36091
		[Token(Token = "0x4008CFB")]
		[FieldOffset(Offset = "0x8")]
		public readonly string Name;

		// Token: 0x04008CFD RID: 36093
		[Token(Token = "0x4008CFD")]
		[FieldOffset(Offset = "0x10")]
		protected IAchievementTracker _tracker;

		// Token: 0x04008CFE RID: 36094
		[Token(Token = "0x4008CFE")]
		[FieldOffset(Offset = "0x14")]
		private bool _isCompleted;

		// Token: 0x020007E5 RID: 2021
		// (Invoke) Token: 0x060045AD RID: 17837
		[Token(Token = "0x20007E5")]
		public delegate void AchievementUpdate(AchievementCondition condition);
	}
}
