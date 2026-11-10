using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Terraria.Net
{
	// Token: 0x020007F2 RID: 2034
	[Token(Token = "0x20007F2")]
	public class NetGroupInfo
	{
		// Token: 0x060045FD RID: 17917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045FD")]
		[Address(RVA = "0x58A438", Offset = "0x58A438", VA = "0x58A438")]
		public NetGroupInfo()
		{
		}

		// Token: 0x060045FE RID: 17918 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045FE")]
		[Address(RVA = "0x58A754", Offset = "0x58A754", VA = "0x58A754")]
		public string ComposeInfo()
		{
			return null;
		}

		// Token: 0x060045FF RID: 17919 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045FF")]
		[Address(RVA = "0x58ACD4", Offset = "0x58ACD4", VA = "0x58ACD4")]
		public Dictionary<NetGroupInfo.InfoProviderId, string> DecomposeInfo(string info)
		{
			return null;
		}

		// Token: 0x06004600 RID: 17920 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004600")]
		[Address(RVA = "0x58AC6C", Offset = "0x58AC6C", VA = "0x58AC6C")]
		private string ConvertToSafeInfo(string text)
		{
			return null;
		}

		// Token: 0x06004601 RID: 17921 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004601")]
		[Address(RVA = "0x58AED0", Offset = "0x58AED0", VA = "0x58AED0")]
		private string ConvertFromSafeInfo(string text)
		{
			return null;
		}

		// Token: 0x04008D22 RID: 36130
		[Token(Token = "0x4008D22")]
		[FieldOffset(Offset = "0x8")]
		private readonly string[] _separatorBetweenInfos;

		// Token: 0x04008D23 RID: 36131
		[Token(Token = "0x4008D23")]
		[FieldOffset(Offset = "0xC")]
		private readonly string[] _separatorBetweenIdAndInfo;

		// Token: 0x04008D24 RID: 36132
		[Token(Token = "0x4008D24")]
		[FieldOffset(Offset = "0x10")]
		private List<NetGroupInfo.INetGroupInfoProvider> _infoProviders;

		// Token: 0x020007F3 RID: 2035
		[Token(Token = "0x20007F3")]
		public enum InfoProviderId
		{
			// Token: 0x04008D26 RID: 36134
			[Token(Token = "0x4008D26")]
			IPAddress,
			// Token: 0x04008D27 RID: 36135
			[Token(Token = "0x4008D27")]
			Steam
		}

		// Token: 0x020007F4 RID: 2036
		[Token(Token = "0x20007F4")]
		private interface INetGroupInfoProvider
		{
			// Token: 0x1700085D RID: 2141
			// (get) Token: 0x06004602 RID: 17922
			[Token(Token = "0x1700085D")]
			NetGroupInfo.InfoProviderId Id
			{
				[Token(Token = "0x6004602")]
				get;
			}

			// Token: 0x1700085E RID: 2142
			// (get) Token: 0x06004603 RID: 17923
			[Token(Token = "0x1700085E")]
			bool HasValidInfo
			{
				[Token(Token = "0x6004603")]
				get;
			}

			// Token: 0x06004604 RID: 17924
			[Token(Token = "0x6004604")]
			string ProvideInfoNeededToJoin();
		}

		// Token: 0x020007F5 RID: 2037
		[Token(Token = "0x20007F5")]
		private class IPAddressInfoProvider : FileAPI
		{
			// Token: 0x1700085F RID: 2143
			// (get) Token: 0x06004605 RID: 17925 RVA: 0x00021390 File Offset: 0x0001F590
			[Token(Token = "0x1700085F")]
			public NetGroupInfo.InfoProviderId Id
			{
				[Token(Token = "0x6004605")]
				[Address(RVA = "0x58AF38", Offset = "0x58AF38", VA = "0x58AF38", Slot = "4")]
				get
				{
					return NetGroupInfo.InfoProviderId.IPAddress;
				}
			}

			// Token: 0x17000860 RID: 2144
			// (get) Token: 0x06004606 RID: 17926 RVA: 0x000213A8 File Offset: 0x0001F5A8
			[Token(Token = "0x17000860")]
			public bool HasValidInfo
			{
				[Token(Token = "0x6004606")]
				[Address(RVA = "0x58AF40", Offset = "0x58AF40", VA = "0x58AF40", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06004607 RID: 17927 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004607")]
			[Address(RVA = "0x58AF48", Offset = "0x58AF48", VA = "0x58AF48", Slot = "6")]
			public string ProvideInfoNeededToJoin()
			{
				return null;
			}

			// Token: 0x06004608 RID: 17928 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004608")]
			[Address(RVA = "0x58A744", Offset = "0x58A744", VA = "0x58A744")]
			public IPAddressInfoProvider()
			{
			}
		}

		// Token: 0x020007F6 RID: 2038
		[Token(Token = "0x20007F6")]
		private class SteamLobbyInfoProvider : FileAPI
		{
			// Token: 0x17000861 RID: 2145
			// (get) Token: 0x06004609 RID: 17929 RVA: 0x000213C0 File Offset: 0x0001F5C0
			[Token(Token = "0x17000861")]
			public NetGroupInfo.InfoProviderId Id
			{
				[Token(Token = "0x6004609")]
				[Address(RVA = "0x58AF90", Offset = "0x58AF90", VA = "0x58AF90", Slot = "4")]
				get
				{
					return NetGroupInfo.InfoProviderId.IPAddress;
				}
			}

			// Token: 0x17000862 RID: 2146
			// (get) Token: 0x0600460A RID: 17930 RVA: 0x000213D8 File Offset: 0x0001F5D8
			[Token(Token = "0x17000862")]
			public bool HasValidInfo
			{
				[Token(Token = "0x600460A")]
				[Address(RVA = "0x58AF98", Offset = "0x58AF98", VA = "0x58AF98", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0600460B RID: 17931 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600460B")]
			[Address(RVA = "0x58B004", Offset = "0x58B004", VA = "0x58B004", Slot = "6")]
			public string ProvideInfoNeededToJoin()
			{
				return null;
			}

			// Token: 0x0600460C RID: 17932 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600460C")]
			[Address(RVA = "0x58A74C", Offset = "0x58A74C", VA = "0x58A74C")]
			public SteamLobbyInfoProvider()
			{
			}
		}
	}
}
