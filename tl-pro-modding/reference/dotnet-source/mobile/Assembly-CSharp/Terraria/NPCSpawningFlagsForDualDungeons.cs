using System;
using Il2CppDummyDll;

namespace Terraria
{
	// Token: 0x020004E8 RID: 1256
	[Token(Token = "0x20004E8")]
	public struct NPCSpawningFlagsForDualDungeons
	{
		// Token: 0x06003164 RID: 12644 RVA: 0x00017E80 File Offset: 0x00016080
		[Token(Token = "0x6003164")]
		[Address(RVA = "0x19F9AEC", Offset = "0x19F9AEC", VA = "0x19F9AEC")]
		public bool CanScan(int x, int y)
		{
			return default(bool);
		}

		// Token: 0x06003165 RID: 12645 RVA: 0x00017E98 File Offset: 0x00016098
		[Token(Token = "0x6003165")]
		[Address(RVA = "0x19F9CE0", Offset = "0x19F9CE0", VA = "0x19F9CE0")]
		public bool ScanZonesFor(int x, int y)
		{
			return default(bool);
		}

		// Token: 0x040041FD RID: 16893
		[Token(Token = "0x40041FD")]
		[FieldOffset(Offset = "0x0")]
		public bool ZoneDungeon;

		// Token: 0x040041FE RID: 16894
		[Token(Token = "0x40041FE")]
		[FieldOffset(Offset = "0x1")]
		public bool ZoneSnow;

		// Token: 0x040041FF RID: 16895
		[Token(Token = "0x40041FF")]
		[FieldOffset(Offset = "0x2")]
		public bool ZoneGlowshroom;

		// Token: 0x04004200 RID: 16896
		[Token(Token = "0x4004200")]
		[FieldOffset(Offset = "0x3")]
		public bool ZoneCorrupt;

		// Token: 0x04004201 RID: 16897
		[Token(Token = "0x4004201")]
		[FieldOffset(Offset = "0x4")]
		public bool ZoneCrimson;

		// Token: 0x04004202 RID: 16898
		[Token(Token = "0x4004202")]
		[FieldOffset(Offset = "0x5")]
		public bool ZoneJungle;

		// Token: 0x04004203 RID: 16899
		[Token(Token = "0x4004203")]
		[FieldOffset(Offset = "0x6")]
		public bool ZoneHallow;

		// Token: 0x04004204 RID: 16900
		[Token(Token = "0x4004204")]
		[FieldOffset(Offset = "0x7")]
		public bool ZoneLihzhardTemple;

		// Token: 0x04004205 RID: 16901
		[Token(Token = "0x4004205")]
		[FieldOffset(Offset = "0x8")]
		public bool ZoneUndergroundDesert;
	}
}
