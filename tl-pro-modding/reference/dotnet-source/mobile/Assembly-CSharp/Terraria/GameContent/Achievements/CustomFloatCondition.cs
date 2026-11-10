using System;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;
using Terraria.Achievements;

namespace Terraria.GameContent.Achievements
{
	// Token: 0x02000C5D RID: 3165
	[Token(Token = "0x2000C5D")]
	public class CustomFloatCondition : AchievementCondition
	{
		// Token: 0x17000A6D RID: 2669
		// (get) Token: 0x06005E02 RID: 24066 RVA: 0x0002BB90 File Offset: 0x00029D90
		// (set) Token: 0x06005E03 RID: 24067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A6D")]
		public float Value
		{
			[Token(Token = "0x6005E02")]
			[Address(RVA = "0x9B77B0", Offset = "0x9B77B0", VA = "0x9B77B0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6005E03")]
			[Address(RVA = "0x9B77B8", Offset = "0x9B77B8", VA = "0x9B77B8")]
			set
			{
			}
		}

		// Token: 0x06005E04 RID: 24068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E04")]
		[Address(RVA = "0x9B7954", Offset = "0x9B7954", VA = "0x9B7954")]
		private CustomFloatCondition(string name, float maxValue)
		{
		}

		// Token: 0x06005E05 RID: 24069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E05")]
		[Address(RVA = "0x9B7978", Offset = "0x9B7978", VA = "0x9B7978", Slot = "6")]
		public override void Clear()
		{
		}

		// Token: 0x06005E06 RID: 24070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E06")]
		[Address(RVA = "0x9B7988", Offset = "0x9B7988", VA = "0x9B7988", Slot = "4")]
		public override void Load(JObject state)
		{
		}

		// Token: 0x06005E07 RID: 24071 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005E07")]
		[Address(RVA = "0x9B7B14", Offset = "0x9B7B14", VA = "0x9B7B14", Slot = "8")]
		protected override IAchievementTracker CreateAchievementTracker()
		{
			return null;
		}

		// Token: 0x06005E08 RID: 24072 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005E08")]
		[Address(RVA = "0x9B7B94", Offset = "0x9B7B94", VA = "0x9B7B94")]
		public static AchievementCondition Create(string name, float maxValue)
		{
			return null;
		}

		// Token: 0x06005E09 RID: 24073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E09")]
		[Address(RVA = "0x9B7C24", Offset = "0x9B7C24", VA = "0x9B7C24", Slot = "7")]
		public override void Complete()
		{
		}

		// Token: 0x04009DC4 RID: 40388
		[Token(Token = "0x4009DC4")]
		[FieldOffset(Offset = "0x18")]
		private float _value;

		// Token: 0x04009DC5 RID: 40389
		[Token(Token = "0x4009DC5")]
		[FieldOffset(Offset = "0x1C")]
		private float _maxValue;
	}
}
