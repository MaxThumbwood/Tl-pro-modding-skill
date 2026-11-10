using System;
using System.IO;
using Il2CppDummyDll;
using Terraria.GameContent.Ambience;
using Terraria.Net;

namespace Terraria.GameContent.NetModules
{
	// Token: 0x02000CB9 RID: 3257
	[Token(Token = "0x2000CB9")]
	public class NetAmbienceModule : NetModule
	{
		// Token: 0x060060FC RID: 24828 RVA: 0x0002CB08 File Offset: 0x0002AD08
		[Token(Token = "0x60060FC")]
		[Address(RVA = "0xAA2ACC", Offset = "0xAA2ACC", VA = "0xAA2ACC")]
		public static NetPacket SerializeSkyEntitySpawn(Player player, SkyEntityType type)
		{
			return default(NetPacket);
		}

		// Token: 0x060060FD RID: 24829 RVA: 0x0002CB20 File Offset: 0x0002AD20
		[Token(Token = "0x60060FD")]
		[Address(RVA = "0xAA2C68", Offset = "0xAA2C68", VA = "0xAA2C68", Slot = "4")]
		public override bool Deserialize(BinaryReader reader, int userId)
		{
			return default(bool);
		}

		// Token: 0x060060FE RID: 24830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060FE")]
		[Address(RVA = "0xAA2E64", Offset = "0xAA2E64", VA = "0xAA2E64")]
		public NetAmbienceModule()
		{
		}

		// Token: 0x02000CBA RID: 3258
		[Token(Token = "0x2000CBA")]
		private sealed class <>c__DisplayClass1_0
		{
			// Token: 0x060060FF RID: 24831 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60060FF")]
			[Address(RVA = "0xAA2E5C", Offset = "0xAA2E5C", VA = "0xAA2E5C")]
			public <>c__DisplayClass1_0()
			{
			}

			// Token: 0x06006100 RID: 24832 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006100")]
			[Address(RVA = "0xAA2E6C", Offset = "0xAA2E6C", VA = "0xAA2E6C")]
			internal void <Deserialize>b__0()
			{
			}

			// Token: 0x04009FB8 RID: 40888
			[Token(Token = "0x4009FB8")]
			[FieldOffset(Offset = "0x8")]
			public byte playerId;

			// Token: 0x04009FB9 RID: 40889
			[Token(Token = "0x4009FB9")]
			[FieldOffset(Offset = "0x9")]
			public SkyEntityType type;

			// Token: 0x04009FBA RID: 40890
			[Token(Token = "0x4009FBA")]
			[FieldOffset(Offset = "0xC")]
			public int seed;
		}
	}
}
