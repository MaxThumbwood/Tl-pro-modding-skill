using System;
using Il2CppDummyDll;

namespace Microsoft.Xna.Framework.Graphics
{
	// Token: 0x020003DE RID: 990
	[Token(Token = "0x20003DE")]
	public class EffectTechnique
	{
		// Token: 0x170002F7 RID: 759
		// (get) Token: 0x06001AF9 RID: 6905 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001AFA RID: 6906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170002F7")]
		public EffectPassCollection Passes
		{
			[Token(Token = "0x6001AF9")]
			[Address(RVA = "0xE47228", Offset = "0xE47228", VA = "0xE47228")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001AFA")]
			[Address(RVA = "0xE47230", Offset = "0xE47230", VA = "0xE47230")]
			private set
			{
			}
		}

		// Token: 0x170002F8 RID: 760
		// (get) Token: 0x06001AFB RID: 6907 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001AFC RID: 6908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170002F8")]
		public string Name
		{
			[Token(Token = "0x6001AFB")]
			[Address(RVA = "0xE47238", Offset = "0xE47238", VA = "0xE47238")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001AFC")]
			[Address(RVA = "0xE47240", Offset = "0xE47240", VA = "0xE47240")]
			private set
			{
			}
		}

		// Token: 0x06001AFD RID: 6909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AFD")]
		[Address(RVA = "0xE47248", Offset = "0xE47248", VA = "0xE47248")]
		internal EffectTechnique(Effect effect, EffectTechnique cloneSource)
		{
		}

		// Token: 0x06001AFE RID: 6910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AFE")]
		[Address(RVA = "0xE472AC", Offset = "0xE472AC", VA = "0xE472AC")]
		internal EffectTechnique(Effect effect, string name, EffectPassCollection passes)
		{
		}

		// Token: 0x04002E38 RID: 11832
		[Token(Token = "0x4002E38")]
		[FieldOffset(Offset = "0x8")]
		private EffectPassCollection <Passes>k__BackingField;

		// Token: 0x04002E39 RID: 11833
		[Token(Token = "0x4002E39")]
		[FieldOffset(Offset = "0xC")]
		private string <Name>k__BackingField;
	}
}
