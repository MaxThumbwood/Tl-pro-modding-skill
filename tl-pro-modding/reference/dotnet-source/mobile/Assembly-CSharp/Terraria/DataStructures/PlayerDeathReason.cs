using System;
using System.IO;
using Il2CppDummyDll;
using Terraria.Localization;

namespace Terraria.DataStructures
{
	// Token: 0x02000783 RID: 1923
	[Token(Token = "0x2000783")]
	public class PlayerDeathReason
	{
		// Token: 0x1700082D RID: 2093
		// (get) Token: 0x0600436B RID: 17259 RVA: 0x00020760 File Offset: 0x0001E960
		[Token(Token = "0x1700082D")]
		public int? SourceOtherIndex
		{
			[Token(Token = "0x600436B")]
			[Address(RVA = "0x4FFC4C", Offset = "0x4FFC4C", VA = "0x4FFC4C")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700082E RID: 2094
		// (get) Token: 0x0600436C RID: 17260 RVA: 0x00020778 File Offset: 0x0001E978
		[Token(Token = "0x1700082E")]
		public int? SourceProjectileType
		{
			[Token(Token = "0x600436C")]
			[Address(RVA = "0x4FFCBC", Offset = "0x4FFCBC", VA = "0x4FFCBC")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700082F RID: 2095
		// (get) Token: 0x0600436D RID: 17261 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700082F")]
		public string CustomReason
		{
			[Token(Token = "0x600436D")]
			[Address(RVA = "0x4FFD40", Offset = "0x4FFD40", VA = "0x4FFD40")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600436E RID: 17262 RVA: 0x00020790 File Offset: 0x0001E990
		[Token(Token = "0x600436E")]
		[Address(RVA = "0x4FFD48", Offset = "0x4FFD48", VA = "0x4FFD48")]
		public bool TryGetCausingEntity(out Entity entity)
		{
			return default(bool);
		}

		// Token: 0x0600436F RID: 17263 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600436F")]
		[Address(RVA = "0x4FFF78", Offset = "0x4FFF78", VA = "0x4FFF78")]
		public static PlayerDeathReason LegacyDefault()
		{
			return null;
		}

		// Token: 0x06004370 RID: 17264 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004370")]
		[Address(RVA = "0x500054", Offset = "0x500054", VA = "0x500054")]
		public static PlayerDeathReason ByNPC(int index)
		{
			return null;
		}

		// Token: 0x06004371 RID: 17265 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004371")]
		[Address(RVA = "0x500114", Offset = "0x500114", VA = "0x500114")]
		public static PlayerDeathReason ByCustomReason(string reasonInEnglish)
		{
			return null;
		}

		// Token: 0x06004372 RID: 17266 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004372")]
		[Address(RVA = "0x5001D4", Offset = "0x5001D4", VA = "0x5001D4")]
		public static PlayerDeathReason ByPlayer(int index)
		{
			return null;
		}

		// Token: 0x06004373 RID: 17267 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004373")]
		[Address(RVA = "0x5003EC", Offset = "0x5003EC", VA = "0x5003EC")]
		public static PlayerDeathReason ByOther(int type)
		{
			return null;
		}

		// Token: 0x06004374 RID: 17268 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004374")]
		[Address(RVA = "0x5004AC", Offset = "0x5004AC", VA = "0x5004AC")]
		public static PlayerDeathReason ByProjectile(int playerIndex, int projectileIndex)
		{
			return null;
		}

		// Token: 0x06004375 RID: 17269 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004375")]
		[Address(RVA = "0x500724", Offset = "0x500724", VA = "0x500724")]
		public NetworkText GetDeathText(string deadPlayerName)
		{
			return null;
		}

		// Token: 0x06004376 RID: 17270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004376")]
		[Address(RVA = "0x500818", Offset = "0x500818", VA = "0x500818")]
		public void WriteSelfTo(BinaryWriter writer)
		{
		}

		// Token: 0x06004377 RID: 17271 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004377")]
		[Address(RVA = "0x500AD0", Offset = "0x500AD0", VA = "0x500AD0")]
		public static PlayerDeathReason FromReader(BinaryReader reader)
		{
			return null;
		}

		// Token: 0x06004378 RID: 17272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004378")]
		[Address(RVA = "0x500038", Offset = "0x500038", VA = "0x500038")]
		public PlayerDeathReason()
		{
		}

		// Token: 0x04008AB7 RID: 35511
		[Token(Token = "0x4008AB7")]
		[FieldOffset(Offset = "0x8")]
		private int _sourcePlayerIndex;

		// Token: 0x04008AB8 RID: 35512
		[Token(Token = "0x4008AB8")]
		[FieldOffset(Offset = "0xC")]
		private int _sourceNPCIndex;

		// Token: 0x04008AB9 RID: 35513
		[Token(Token = "0x4008AB9")]
		[FieldOffset(Offset = "0x10")]
		private int _sourceProjectileLocalIndex;

		// Token: 0x04008ABA RID: 35514
		[Token(Token = "0x4008ABA")]
		[FieldOffset(Offset = "0x14")]
		private int _sourceOtherIndex;

		// Token: 0x04008ABB RID: 35515
		[Token(Token = "0x4008ABB")]
		[FieldOffset(Offset = "0x18")]
		private int _sourceProjectileType;

		// Token: 0x04008ABC RID: 35516
		[Token(Token = "0x4008ABC")]
		[FieldOffset(Offset = "0x1C")]
		private int _sourceItemType;

		// Token: 0x04008ABD RID: 35517
		[Token(Token = "0x4008ABD")]
		[FieldOffset(Offset = "0x20")]
		private int _sourceItemPrefix;

		// Token: 0x04008ABE RID: 35518
		[Token(Token = "0x4008ABE")]
		[FieldOffset(Offset = "0x24")]
		private string _sourceCustomReason;
	}
}
