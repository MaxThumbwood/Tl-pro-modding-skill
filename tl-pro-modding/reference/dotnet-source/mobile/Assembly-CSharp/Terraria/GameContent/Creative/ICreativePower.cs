using System;
using System.Collections.Generic;
using System.IO;
using Il2CppDummyDll;
using Terraria.UI;

namespace Terraria.GameContent.Creative
{
	// Token: 0x02000CFC RID: 3324
	[Token(Token = "0x2000CFC")]
	public interface ICreativePower
	{
		// Token: 0x17000A98 RID: 2712
		// (get) Token: 0x06006238 RID: 25144
		// (set) Token: 0x06006239 RID: 25145
		[Token(Token = "0x17000A98")]
		ushort PowerId
		{
			[Token(Token = "0x6006238")]
			get;
			[Token(Token = "0x6006239")]
			set;
		}

		// Token: 0x17000A99 RID: 2713
		// (get) Token: 0x0600623A RID: 25146
		// (set) Token: 0x0600623B RID: 25147
		[Token(Token = "0x17000A99")]
		string ServerConfigName
		{
			[Token(Token = "0x600623A")]
			get;
			[Token(Token = "0x600623B")]
			set;
		}

		// Token: 0x17000A9A RID: 2714
		// (get) Token: 0x0600623C RID: 25148
		// (set) Token: 0x0600623D RID: 25149
		[Token(Token = "0x17000A9A")]
		PowerPermissionLevel CurrentPermissionLevel
		{
			[Token(Token = "0x600623C")]
			get;
			[Token(Token = "0x600623D")]
			set;
		}

		// Token: 0x17000A9B RID: 2715
		// (get) Token: 0x0600623E RID: 25150
		// (set) Token: 0x0600623F RID: 25151
		[Token(Token = "0x17000A9B")]
		PowerPermissionLevel DefaultPermissionLevel
		{
			[Token(Token = "0x600623E")]
			get;
			[Token(Token = "0x600623F")]
			set;
		}

		// Token: 0x06006240 RID: 25152
		[Token(Token = "0x6006240")]
		void DeserializeNetMessage(BinaryReader reader, int userId);

		// Token: 0x06006241 RID: 25153
		[Token(Token = "0x6006241")]
		void ProvidePowerButtons(CreativePowerUIElementRequestInfo info, List<UIElement> elements);

		// Token: 0x06006242 RID: 25154
		[Token(Token = "0x6006242")]
		bool GetIsUnlocked();
	}
}
