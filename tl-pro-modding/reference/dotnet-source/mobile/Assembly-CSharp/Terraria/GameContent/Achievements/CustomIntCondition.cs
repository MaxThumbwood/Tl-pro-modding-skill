using System;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;
using Terraria.Achievements;

namespace Terraria.GameContent.Achievements
{
	// Token: 0x02000C5E RID: 3166
	[Token(Token = "0x2000C5E")]
	public class CustomIntCondition : AchievementCondition
	{
		// Token: 0x17000A6E RID: 2670
		// (get) Token: 0x06005E0A RID: 24074 RVA: 0x0002BBA8 File Offset: 0x00029DA8
		// (set) Token: 0x06005E0B RID: 24075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A6E")]
		public int Value
		{
			[Token(Token = "0x6005E0A")]
			[Address(RVA = "0x9B7D38", Offset = "0x9B7D38", VA = "0x9B7D38")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6005E0B")]
			[Address(RVA = "0x9B7D40", Offset = "0x9B7D40", VA = "0x9B7D40")]
			set
			{
			}
		}

		// Token: 0x06005E0C RID: 24076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E0C")]
		[Address(RVA = "0x9B7EC8", Offset = "0x9B7EC8", VA = "0x9B7EC8")]
		private CustomIntCondition(string name, int maxValue)
		{
		}

		// Token: 0x06005E0D RID: 24077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E0D")]
		[Address(RVA = "0x9B7EEC", Offset = "0x9B7EEC", VA = "0x9B7EEC", Slot = "6")]
		public override void Clear()
		{
		}

		// Token: 0x06005E0E RID: 24078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E0E")]
		[Address(RVA = "0x9B7EFC", Offset = "0x9B7EFC", VA = "0x9B7EFC", Slot = "4")]
		public override void Load(JObject state)
		{
		}

		// Token: 0x06005E0F RID: 24079 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005E0F")]
		[Address(RVA = "0x9B8088", Offset = "0x9B8088", VA = "0x9B8088", Slot = "8")]
		protected override IAchievementTracker CreateAchievementTracker()
		{
			return null;
		}

		// Token: 0x06005E10 RID: 24080 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005E10")]
		[Address(RVA = "0x9B8100", Offset = "0x9B8100", VA = "0x9B8100")]
		public static AchievementCondition Create(string name, int maxValue)
		{
			return null;
		}

		// Token: 0x06005E11 RID: 24081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E11")]
		[Address(RVA = "0x9B8184", Offset = "0x9B8184", VA = "0x9B8184", Slot = "7")]
		public override void Complete()
		{
		}

		// Token: 0x04009DC6 RID: 40390
		[Token(Token = "0x4009DC6")]
		[FieldOffset(Offset = "0x18")]
		private int _value;

		// Token: 0x04009DC7 RID: 40391
		[Token(Token = "0x4009DC7")]
		[FieldOffset(Offset = "0x1C")]
		private int _maxValue;
	}
}
