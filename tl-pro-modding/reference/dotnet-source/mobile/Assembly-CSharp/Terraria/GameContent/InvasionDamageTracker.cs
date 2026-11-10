using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Terraria.Localization;

namespace Terraria.GameContent
{
	// Token: 0x02000947 RID: 2375
	[Token(Token = "0x2000947")]
	public class InvasionDamageTracker : NPCDamageTracker
	{
		// Token: 0x06004F54 RID: 20308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F54")]
		[Address(RVA = "0x74BF94", Offset = "0x74BF94", VA = "0x74BF94")]
		public InvasionDamageTracker(int invasionGroup, [Optional] LocalizedText name)
		{
		}

		// Token: 0x17000982 RID: 2434
		// (get) Token: 0x06004F55 RID: 20309 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000982")]
		public override LocalizedText Name
		{
			[Token(Token = "0x6004F55")]
			[Address(RVA = "0x74C158", Offset = "0x74C158", VA = "0x74C158", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000983 RID: 2435
		// (get) Token: 0x06004F56 RID: 20310 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000983")]
		public override LocalizedText KillTimeMessage
		{
			[Token(Token = "0x6004F56")]
			[Address(RVA = "0x74C160", Offset = "0x74C160", VA = "0x74C160", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x06004F57 RID: 20311 RVA: 0x00024EB8 File Offset: 0x000230B8
		[Token(Token = "0x6004F57")]
		[Address(RVA = "0x74C168", Offset = "0x74C168", VA = "0x74C168", Slot = "6")]
		protected override bool IncludeDamageFor(NPC npc)
		{
			return default(bool);
		}

		// Token: 0x06004F58 RID: 20312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F58")]
		[Address(RVA = "0x74C1F4", Offset = "0x74C1F4", VA = "0x74C1F4", Slot = "7")]
		protected override void CheckActive()
		{
		}

		// Token: 0x06004F59 RID: 20313 RVA: 0x00024ED0 File Offset: 0x000230D0
		[Token(Token = "0x6004F59")]
		[Address(RVA = "0x74C31C", Offset = "0x74C31C", VA = "0x74C31C")]
		private bool IsActive()
		{
			return default(bool);
		}

		// Token: 0x0400937D RID: 37757
		[Token(Token = "0x400937D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Dictionary<int, string> VanillaInvasionNameKeys;

		// Token: 0x0400937E RID: 37758
		[Token(Token = "0x400937E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private readonly int _invasionGroup;

		// Token: 0x0400937F RID: 37759
		[Token(Token = "0x400937F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly LocalizedText _name;
	}
}
