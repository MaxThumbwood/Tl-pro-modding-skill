using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Terraria.GameContent
{
	// Token: 0x020009DC RID: 2524
	[Token(Token = "0x20009DC")]
	public class TownNPCProfiles
	{
		// Token: 0x06005265 RID: 21093 RVA: 0x00026640 File Offset: 0x00024840
		[Token(Token = "0x6005265")]
		[Address(RVA = "0x7DC6D0", Offset = "0x7DC6D0", VA = "0x7DC6D0")]
		public bool GetProfile(int npcId, out ITownNPCProfile profile)
		{
			return default(bool);
		}

		// Token: 0x06005266 RID: 21094 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005266")]
		[Address(RVA = "0x7DC744", Offset = "0x7DC744", VA = "0x7DC744")]
		public static ITownNPCProfile LegacyWithSimpleShimmer(string subPath, int headIdNormal, int headIdShimmered, bool uniquePartyTexture = true, bool uniquePartyTextureShimmered = true)
		{
			return null;
		}

		// Token: 0x06005267 RID: 21095 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005267")]
		[Address(RVA = "0x7DCC8C", Offset = "0x7DCC8C", VA = "0x7DCC8C")]
		public static ITownNPCProfile TransformableWithSimpleShimmer(string subPath, int headIdNormal, int headIdShimmered, bool uniqueCreditTexture = true, bool uniqueCreditTextureShimmered = true)
		{
			return null;
		}

		// Token: 0x06005268 RID: 21096 RVA: 0x00026658 File Offset: 0x00024858
		[Token(Token = "0x6005268")]
		[Address(RVA = "0x7DD204", Offset = "0x7DD204", VA = "0x7DD204")]
		public static int GetHeadIndexSafe(NPC npc)
		{
			return 0;
		}

		// Token: 0x06005269 RID: 21097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005269")]
		[Address(RVA = "0x7DD3D8", Offset = "0x7DD3D8", VA = "0x7DD3D8")]
		public TownNPCProfiles()
		{
		}

		// Token: 0x040096C4 RID: 38596
		[Token(Token = "0x40096C4")]
		private const string DefaultNPCFileFolderPath = "Images/TownNPCs/";

		// Token: 0x040096C5 RID: 38597
		[Token(Token = "0x40096C5")]
		private const string ShimmeredNPCFileFolderPath = "Images/TownNPCs/Shimmered/";

		// Token: 0x040096C6 RID: 38598
		[Token(Token = "0x40096C6")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int[] CatHeadIDs;

		// Token: 0x040096C7 RID: 38599
		[Token(Token = "0x40096C7")]
		[FieldOffset(Offset = "0x4")]
		private static readonly int[] DogHeadIDs;

		// Token: 0x040096C8 RID: 38600
		[Token(Token = "0x40096C8")]
		[FieldOffset(Offset = "0x8")]
		private static readonly int[] BunnyHeadIDs;

		// Token: 0x040096C9 RID: 38601
		[Token(Token = "0x40096C9")]
		[FieldOffset(Offset = "0xC")]
		private static readonly int[] SlimeHeadIDs;

		// Token: 0x040096CA RID: 38602
		[Token(Token = "0x40096CA")]
		[FieldOffset(Offset = "0x8")]
		private Dictionary<int, ITownNPCProfile> _townNPCProfiles;

		// Token: 0x040096CB RID: 38603
		[Token(Token = "0x40096CB")]
		[FieldOffset(Offset = "0x10")]
		public static TownNPCProfiles Instance;
	}
}
