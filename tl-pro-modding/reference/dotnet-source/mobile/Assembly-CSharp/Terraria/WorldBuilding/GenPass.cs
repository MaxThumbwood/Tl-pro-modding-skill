using System;
using Il2CppDummyDll;
using Terraria.IO;

namespace Terraria.WorldBuilding
{
	// Token: 0x02000599 RID: 1433
	[Token(Token = "0x2000599")]
	public abstract class GenPass : GenBase
	{
		// Token: 0x17000760 RID: 1888
		// (get) Token: 0x06003AAD RID: 15021 RVA: 0x0001D940 File Offset: 0x0001BB40
		// (set) Token: 0x06003AAE RID: 15022 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000760")]
		public bool Enabled
		{
			[Token(Token = "0x6003AAD")]
			[Address(RVA = "0x1E064E8", Offset = "0x1E064E8", VA = "0x1E064E8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003AAE")]
			[Address(RVA = "0x1E064F0", Offset = "0x1E064F0", VA = "0x1E064F0")]
			private set
			{
			}
		}

		// Token: 0x06003AAF RID: 15023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AAF")]
		[Address(RVA = "0x1E064F8", Offset = "0x1E064F8", VA = "0x1E064F8")]
		public void Disable()
		{
		}

		// Token: 0x06003AB0 RID: 15024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AB0")]
		[Address(RVA = "0x1E06504", Offset = "0x1E06504", VA = "0x1E06504")]
		internal void Enable()
		{
		}

		// Token: 0x06003AB1 RID: 15025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AB1")]
		[Address(RVA = "0x1E06510", Offset = "0x1E06510", VA = "0x1E06510")]
		public GenPass(string name, double loadWeight)
		{
		}

		// Token: 0x06003AB2 RID: 15026
		[Token(Token = "0x6003AB2")]
		protected abstract void ApplyPass(GenerationProgress progress, GameConfiguration configuration);

		// Token: 0x06003AB3 RID: 15027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AB3")]
		[Address(RVA = "0x1E06544", Offset = "0x1E06544", VA = "0x1E06544")]
		public void Apply(GenerationProgress progress, GameConfiguration configuration)
		{
		}

		// Token: 0x04004635 RID: 17973
		[Token(Token = "0x4004635")]
		[FieldOffset(Offset = "0x8")]
		private bool <Enabled>k__BackingField;

		// Token: 0x04004636 RID: 17974
		[Token(Token = "0x4004636")]
		[FieldOffset(Offset = "0xC")]
		public string Name;

		// Token: 0x04004637 RID: 17975
		[Token(Token = "0x4004637")]
		[FieldOffset(Offset = "0x10")]
		public double Weight;
	}
}
