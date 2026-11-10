using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Terraria.GameInput
{
	// Token: 0x02000823 RID: 2083
	[Token(Token = "0x2000823")]
	public class KeyConfiguration
	{
		// Token: 0x170008B0 RID: 2224
		// (get) Token: 0x06004790 RID: 18320 RVA: 0x00021F48 File Offset: 0x00020148
		[Token(Token = "0x170008B0")]
		public bool DoGrappleAndInteractShareTheSameKey
		{
			[Token(Token = "0x6004790")]
			[Address(RVA = "0x5E23B8", Offset = "0x5E23B8", VA = "0x5E23B8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06004791 RID: 18321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004791")]
		[Address(RVA = "0x5E254C", Offset = "0x5E254C", VA = "0x5E254C")]
		public void SetupKeys()
		{
		}

		// Token: 0x06004792 RID: 18322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004792")]
		[Address(RVA = "0x5E2664", Offset = "0x5E2664", VA = "0x5E2664")]
		public void Processkey(TriggersSet set, string newKey)
		{
		}

		// Token: 0x06004793 RID: 18323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004793")]
		[Address(RVA = "0x5E2BB0", Offset = "0x5E2BB0", VA = "0x5E2BB0")]
		public void CopyKeyState(TriggersSet oldSet, TriggersSet newSet, string newKey)
		{
		}

		// Token: 0x06004794 RID: 18324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004794")]
		[Address(RVA = "0x5E2E58", Offset = "0x5E2E58", VA = "0x5E2E58")]
		public void ReadPreferences(Dictionary<TriggerNames, List<string>> dict)
		{
		}

		// Token: 0x06004795 RID: 18325 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004795")]
		[Address(RVA = "0x5E330C", Offset = "0x5E330C", VA = "0x5E330C")]
		public Dictionary<TriggerNames, List<string>> WritePreferences()
		{
			return null;
		}

		// Token: 0x06004796 RID: 18326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004796")]
		[Address(RVA = "0x5E3958", Offset = "0x5E3958", VA = "0x5E3958")]
		public KeyConfiguration()
		{
		}

		// Token: 0x04008E05 RID: 36357
		[Token(Token = "0x4008E05")]
		[FieldOffset(Offset = "0x8")]
		public Dictionary<TriggerNames, List<string>> KeyStatus;
	}
}
