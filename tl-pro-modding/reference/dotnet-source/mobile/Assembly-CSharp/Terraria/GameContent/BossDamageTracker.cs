using System;
using Il2CppDummyDll;
using Terraria.Localization;

namespace Terraria.GameContent
{
	// Token: 0x02000946 RID: 2374
	[Token(Token = "0x2000946")]
	public class BossDamageTracker : NPCDamageTracker
	{
		// Token: 0x06004F4D RID: 20301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F4D")]
		[Address(RVA = "0x749324", Offset = "0x749324", VA = "0x749324")]
		public BossDamageTracker(int type, NPCDamageTracker.CustomDefinition definition)
		{
		}

		// Token: 0x17000980 RID: 2432
		// (get) Token: 0x06004F4E RID: 20302 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000980")]
		public override LocalizedText Name
		{
			[Token(Token = "0x6004F4E")]
			[Address(RVA = "0x74BA90", Offset = "0x74BA90", VA = "0x74BA90", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000981 RID: 2433
		// (get) Token: 0x06004F4F RID: 20303 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000981")]
		public override LocalizedText KillTimeMessage
		{
			[Token(Token = "0x6004F4F")]
			[Address(RVA = "0x74BB14", Offset = "0x74BB14", VA = "0x74BB14", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x06004F50 RID: 20304 RVA: 0x00024E88 File Offset: 0x00023088
		[Token(Token = "0x6004F50")]
		[Address(RVA = "0x74BBC4", Offset = "0x74BBC4", VA = "0x74BBC4", Slot = "6")]
		protected override bool IncludeDamageFor(NPC npc)
		{
			return default(bool);
		}

		// Token: 0x06004F51 RID: 20305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F51")]
		[Address(RVA = "0x74BCB4", Offset = "0x74BCB4", VA = "0x74BCB4", Slot = "7")]
		protected override void CheckActive()
		{
		}

		// Token: 0x06004F52 RID: 20306 RVA: 0x00024EA0 File Offset: 0x000230A0
		[Token(Token = "0x6004F52")]
		[Address(RVA = "0x74BD24", Offset = "0x74BD24", VA = "0x74BD24")]
		private bool IsActive()
		{
			return default(bool);
		}

		// Token: 0x06004F53 RID: 20307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F53")]
		[Address(RVA = "0x74BF88", Offset = "0x74BF88", VA = "0x74BF88", Slot = "8")]
		protected override void OnBossKilled(NPC npc)
		{
		}

		// Token: 0x0400937A RID: 37754
		[Token(Token = "0x400937A")]
		[FieldOffset(Offset = "0x1C")]
		private readonly int _type;

		// Token: 0x0400937B RID: 37755
		[Token(Token = "0x400937B")]
		[FieldOffset(Offset = "0x20")]
		private readonly NPCDamageTracker.CustomDefinition _overrides;

		// Token: 0x0400937C RID: 37756
		[Token(Token = "0x400937C")]
		[FieldOffset(Offset = "0x24")]
		private bool _killed;
	}
}
