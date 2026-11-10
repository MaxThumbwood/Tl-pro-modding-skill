using System;
using Il2CppDummyDll;

namespace Terraria.DataStructures
{
	// Token: 0x02000795 RID: 1941
	[Token(Token = "0x2000795")]
	public struct PortableStoolUsage
	{
		// Token: 0x06004421 RID: 17441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004421")]
		[Address(RVA = "0x5587F0", Offset = "0x5587F0", VA = "0x5587F0")]
		public void Reset()
		{
		}

		// Token: 0x06004422 RID: 17442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004422")]
		[Address(RVA = "0x558808", Offset = "0x558808", VA = "0x558808")]
		public void SetStats(int heightBoost, int visualYOffset, int mapYOffset)
		{
		}

		// Token: 0x06004423 RID: 17443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004423")]
		[Address(RVA = "0x558818", Offset = "0x558818", VA = "0x558818")]
		public void OverrideInUse(bool inUse)
		{
		}

		// Token: 0x04008BC0 RID: 35776
		[Token(Token = "0x4008BC0")]
		[FieldOffset(Offset = "0x0")]
		public bool HasAStool;

		// Token: 0x04008BC1 RID: 35777
		[Token(Token = "0x4008BC1")]
		[FieldOffset(Offset = "0x1")]
		public bool IsInUse;

		// Token: 0x04008BC2 RID: 35778
		[Token(Token = "0x4008BC2")]
		[FieldOffset(Offset = "0x4")]
		public int HeightBoost;

		// Token: 0x04008BC3 RID: 35779
		[Token(Token = "0x4008BC3")]
		[FieldOffset(Offset = "0x8")]
		public int VisualYOffset;

		// Token: 0x04008BC4 RID: 35780
		[Token(Token = "0x4008BC4")]
		[FieldOffset(Offset = "0xC")]
		public int MapYOffset;
	}
}
