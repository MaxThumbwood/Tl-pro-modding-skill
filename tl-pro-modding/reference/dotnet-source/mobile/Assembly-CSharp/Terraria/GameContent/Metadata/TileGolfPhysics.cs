using System;
using Il2CppDummyDll;

namespace Terraria.GameContent.Metadata
{
	// Token: 0x02000A3F RID: 2623
	[Token(Token = "0x2000A3F")]
	public class TileGolfPhysics
	{
		// Token: 0x170009CB RID: 2507
		// (get) Token: 0x0600543F RID: 21567 RVA: 0x000271E0 File Offset: 0x000253E0
		// (set) Token: 0x06005440 RID: 21568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009CB")]
		public float DirectImpactDampening
		{
			[Token(Token = "0x600543F")]
			[Address(RVA = "0x813098", Offset = "0x813098", VA = "0x813098")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6005440")]
			[Address(RVA = "0x8130A0", Offset = "0x8130A0", VA = "0x8130A0")]
			private set
			{
			}
		}

		// Token: 0x170009CC RID: 2508
		// (get) Token: 0x06005441 RID: 21569 RVA: 0x000271F8 File Offset: 0x000253F8
		// (set) Token: 0x06005442 RID: 21570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009CC")]
		public float SideImpactDampening
		{
			[Token(Token = "0x6005441")]
			[Address(RVA = "0x8130A8", Offset = "0x8130A8", VA = "0x8130A8")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6005442")]
			[Address(RVA = "0x8130B0", Offset = "0x8130B0", VA = "0x8130B0")]
			private set
			{
			}
		}

		// Token: 0x170009CD RID: 2509
		// (get) Token: 0x06005443 RID: 21571 RVA: 0x00027210 File Offset: 0x00025410
		// (set) Token: 0x06005444 RID: 21572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009CD")]
		public float ClubImpactDampening
		{
			[Token(Token = "0x6005443")]
			[Address(RVA = "0x8130B8", Offset = "0x8130B8", VA = "0x8130B8")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6005444")]
			[Address(RVA = "0x8130C0", Offset = "0x8130C0", VA = "0x8130C0")]
			private set
			{
			}
		}

		// Token: 0x170009CE RID: 2510
		// (get) Token: 0x06005445 RID: 21573 RVA: 0x00027228 File Offset: 0x00025428
		// (set) Token: 0x06005446 RID: 21574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009CE")]
		public float PassThroughDampening
		{
			[Token(Token = "0x6005445")]
			[Address(RVA = "0x8130C8", Offset = "0x8130C8", VA = "0x8130C8")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6005446")]
			[Address(RVA = "0x8130D0", Offset = "0x8130D0", VA = "0x8130D0")]
			private set
			{
			}
		}

		// Token: 0x170009CF RID: 2511
		// (get) Token: 0x06005447 RID: 21575 RVA: 0x00027240 File Offset: 0x00025440
		// (set) Token: 0x06005448 RID: 21576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009CF")]
		public float ImpactDampeningResistanceEfficiency
		{
			[Token(Token = "0x6005447")]
			[Address(RVA = "0x8130D8", Offset = "0x8130D8", VA = "0x8130D8")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6005448")]
			[Address(RVA = "0x8130E0", Offset = "0x8130E0", VA = "0x8130E0")]
			private set
			{
			}
		}

		// Token: 0x06005449 RID: 21577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005449")]
		[Address(RVA = "0x8130E8", Offset = "0x8130E8", VA = "0x8130E8")]
		public TileGolfPhysics()
		{
		}

		// Token: 0x040097D8 RID: 38872
		[Token(Token = "0x40097D8")]
		[FieldOffset(Offset = "0x8")]
		private float <DirectImpactDampening>k__BackingField;

		// Token: 0x040097D9 RID: 38873
		[Token(Token = "0x40097D9")]
		[FieldOffset(Offset = "0xC")]
		private float <SideImpactDampening>k__BackingField;

		// Token: 0x040097DA RID: 38874
		[Token(Token = "0x40097DA")]
		[FieldOffset(Offset = "0x10")]
		private float <ClubImpactDampening>k__BackingField;

		// Token: 0x040097DB RID: 38875
		[Token(Token = "0x40097DB")]
		[FieldOffset(Offset = "0x14")]
		private float <PassThroughDampening>k__BackingField;

		// Token: 0x040097DC RID: 38876
		[Token(Token = "0x40097DC")]
		[FieldOffset(Offset = "0x18")]
		private float <ImpactDampeningResistanceEfficiency>k__BackingField;
	}
}
