using System;
using Il2CppDummyDll;

namespace Terraria.WorldBuilding
{
	// Token: 0x0200053C RID: 1340
	[Token(Token = "0x200053C")]
	public class WorldSeedOption_Normal : AWorldGenerationOption
	{
		// Token: 0x17000742 RID: 1858
		// (get) Token: 0x060039C4 RID: 14788 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000742")]
		protected override string KeyName
		{
			[Token(Token = "0x60039C4")]
			[Address(RVA = "0x1DF92CC", Offset = "0x1DF92CC", VA = "0x1DF92CC", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000743 RID: 1859
		// (get) Token: 0x060039C5 RID: 14789 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000743")]
		public override string ServerConfigName
		{
			[Token(Token = "0x60039C5")]
			[Address(RVA = "0x1DF9314", Offset = "0x1DF9314", VA = "0x1DF9314", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x060039C6 RID: 14790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039C6")]
		[Address(RVA = "0x1DF931C", Offset = "0x1DF931C", VA = "0x1DF931C")]
		public WorldSeedOption_Normal()
		{
		}

		// Token: 0x060039C7 RID: 14791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039C7")]
		[Address(RVA = "0x1DF9418", Offset = "0x1DF9418", VA = "0x1DF9418")]
		private void UpdateDependentState(AWorldGenerationOption changed)
		{
		}

		// Token: 0x060039C8 RID: 14792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039C8")]
		[Address(RVA = "0x1DF95F4", Offset = "0x1DF95F4", VA = "0x1DF95F4", Slot = "6")]
		protected override void OnEnabledStateChanged()
		{
		}

		// Token: 0x060039C9 RID: 14793 RVA: 0x0001D1A8 File Offset: 0x0001B3A8
		[Token(Token = "0x60039C9")]
		[Address(RVA = "0x1DF9A7C", Offset = "0x1DF9A7C", VA = "0x1DF9A7C")]
		private bool <UpdateDependentState>b__5_0(AWorldGenerationOption x)
		{
			return default(bool);
		}
	}
}
