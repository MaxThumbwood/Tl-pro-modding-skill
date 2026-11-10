using System;
using Il2CppDummyDll;

namespace Terraria.GameContent.Metadata
{
	// Token: 0x02000A40 RID: 2624
	[Token(Token = "0x2000A40")]
	public class TileMaterial
	{
		// Token: 0x170009D0 RID: 2512
		// (get) Token: 0x0600544A RID: 21578 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600544B RID: 21579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009D0")]
		public TileGolfPhysics GolfPhysics
		{
			[Token(Token = "0x600544A")]
			[Address(RVA = "0x8130F0", Offset = "0x8130F0", VA = "0x8130F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600544B")]
			[Address(RVA = "0x8130F8", Offset = "0x8130F8", VA = "0x8130F8")]
			private set
			{
			}
		}

		// Token: 0x0600544C RID: 21580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600544C")]
		[Address(RVA = "0x813100", Offset = "0x813100", VA = "0x813100")]
		public TileMaterial()
		{
		}

		// Token: 0x040097DD RID: 38877
		[Token(Token = "0x40097DD")]
		[FieldOffset(Offset = "0x8")]
		private TileGolfPhysics <GolfPhysics>k__BackingField;
	}
}
