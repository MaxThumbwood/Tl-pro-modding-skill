using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Terraria.GameContent.UI.Elements;
using Terraria.UI;

namespace Terraria.WorldBuilding
{
	// Token: 0x02000544 RID: 1348
	[Token(Token = "0x2000544")]
	public class WorldSeedOption_Everything : AWorldGenerationOption
	{
		// Token: 0x17000752 RID: 1874
		// (get) Token: 0x060039DF RID: 14815 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000752")]
		protected override string KeyName
		{
			[Token(Token = "0x60039DF")]
			[Address(RVA = "0x1DFA674", Offset = "0x1DFA674", VA = "0x1DFA674", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000753 RID: 1875
		// (get) Token: 0x060039E0 RID: 14816 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000753")]
		public override string ServerConfigName
		{
			[Token(Token = "0x60039E0")]
			[Address(RVA = "0x1DFA6BC", Offset = "0x1DFA6BC", VA = "0x1DFA6BC", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000754 RID: 1876
		// (get) Token: 0x060039E1 RID: 14817 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000754")]
		public List<AWorldGenerationOption> Dependencies
		{
			[Token(Token = "0x60039E1")]
			[Address(RVA = "0x1DFA704", Offset = "0x1DFA704", VA = "0x1DFA704")]
			get
			{
				return null;
			}
		}

		// Token: 0x060039E2 RID: 14818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039E2")]
		[Address(RVA = "0x1DFAC60", Offset = "0x1DFAC60", VA = "0x1DFAC60")]
		public WorldSeedOption_Everything()
		{
		}

		// Token: 0x060039E3 RID: 14819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039E3")]
		[Address(RVA = "0x1DFADBC", Offset = "0x1DFADBC", VA = "0x1DFADBC")]
		private void UpdateDependentState(AWorldGenerationOption changed)
		{
		}

		// Token: 0x060039E4 RID: 14820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039E4")]
		[Address(RVA = "0x1DFB00C", Offset = "0x1DFB00C", VA = "0x1DFB00C", Slot = "6")]
		protected override void OnEnabledStateChanged()
		{
		}

		// Token: 0x060039E5 RID: 14821 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60039E5")]
		[Address(RVA = "0x1DFB354", Offset = "0x1DFB354", VA = "0x1DFB354", Slot = "7")]
		public override UIElement ProvideUIElement()
		{
			return null;
		}

		// Token: 0x040045C5 RID: 17861
		[Token(Token = "0x40045C5")]
		[FieldOffset(Offset = "0x20")]
		protected List<AWorldGenerationOption> _dependencies;

		// Token: 0x02000545 RID: 1349
		[Token(Token = "0x2000545")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060039E7 RID: 14823 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60039E7")]
			[Address(RVA = "0x1DFB658", Offset = "0x1DFB658", VA = "0x1DFB658")]
			public <>c()
			{
			}

			// Token: 0x060039E8 RID: 14824 RVA: 0x0001D1C0 File Offset: 0x0001B3C0
			[Token(Token = "0x60039E8")]
			[Address(RVA = "0x1DFB660", Offset = "0x1DFB660", VA = "0x1DFB660")]
			internal bool <UpdateDependentState>b__8_0(AWorldGenerationOption d)
			{
				return default(bool);
			}

			// Token: 0x060039E9 RID: 14825 RVA: 0x0001D1D8 File Offset: 0x0001B3D8
			[Token(Token = "0x60039E9")]
			[Address(RVA = "0x1DFB684", Offset = "0x1DFB684", VA = "0x1DFB684")]
			internal bool <OnEnabledStateChanged>b__9_0(AWorldGenerationOption d)
			{
				return default(bool);
			}

			// Token: 0x040045C6 RID: 17862
			[Token(Token = "0x40045C6")]
			[FieldOffset(Offset = "0x0")]
			public static readonly WorldSeedOption_Everything.<>c <>9;

			// Token: 0x040045C7 RID: 17863
			[Token(Token = "0x40045C7")]
			[FieldOffset(Offset = "0x4")]
			public static Func<AWorldGenerationOption, bool> <>9__8_0;

			// Token: 0x040045C8 RID: 17864
			[Token(Token = "0x40045C8")]
			[FieldOffset(Offset = "0x8")]
			public static Func<AWorldGenerationOption, bool> <>9__9_0;
		}

		// Token: 0x02000546 RID: 1350
		[Token(Token = "0x2000546")]
		private sealed class <>c__DisplayClass10_0
		{
			// Token: 0x060039EA RID: 14826 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60039EA")]
			[Address(RVA = "0x1DFB5DC", Offset = "0x1DFB5DC", VA = "0x1DFB5DC")]
			public <>c__DisplayClass10_0()
			{
			}

			// Token: 0x060039EB RID: 14827 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60039EB")]
			[Address(RVA = "0x1DFB6A8", Offset = "0x1DFB6A8", VA = "0x1DFB6A8")]
			internal void <ProvideUIElement>b__0(UIElement _)
			{
			}

			// Token: 0x040045C9 RID: 17865
			[Token(Token = "0x40045C9")]
			[FieldOffset(Offset = "0x8")]
			public int glitchFrame;

			// Token: 0x040045CA RID: 17866
			[Token(Token = "0x40045CA")]
			[FieldOffset(Offset = "0xC")]
			public int glitchFrameCounter;

			// Token: 0x040045CB RID: 17867
			[Token(Token = "0x40045CB")]
			[FieldOffset(Offset = "0x10")]
			public int glitchVariation;

			// Token: 0x040045CC RID: 17868
			[Token(Token = "0x40045CC")]
			[FieldOffset(Offset = "0x14")]
			public UIImageFramed image;
		}
	}
}
