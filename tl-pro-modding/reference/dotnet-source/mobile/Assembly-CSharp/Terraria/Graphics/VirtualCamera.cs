using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

namespace Terraria.Graphics
{
	// Token: 0x020008BC RID: 2236
	[Token(Token = "0x20008BC")]
	public struct VirtualCamera
	{
		// Token: 0x06004BA2 RID: 19362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BA2")]
		[Address(RVA = "0x6E23DC", Offset = "0x6E23DC", VA = "0x6E23DC")]
		public VirtualCamera(Player player)
		{
		}

		// Token: 0x1700092C RID: 2348
		// (get) Token: 0x06004BA3 RID: 19363 RVA: 0x00023EB0 File Offset: 0x000220B0
		[Token(Token = "0x1700092C")]
		public Vector2 Position
		{
			[Token(Token = "0x6004BA3")]
			[Address(RVA = "0x6E23E4", Offset = "0x6E23E4", VA = "0x6E23E4")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x1700092D RID: 2349
		// (get) Token: 0x06004BA4 RID: 19364 RVA: 0x00023EC8 File Offset: 0x000220C8
		[Token(Token = "0x1700092D")]
		public Vector2 Size
		{
			[Token(Token = "0x6004BA4")]
			[Address(RVA = "0x6E2580", Offset = "0x6E2580", VA = "0x6E2580")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x1700092E RID: 2350
		// (get) Token: 0x06004BA5 RID: 19365 RVA: 0x00023EE0 File Offset: 0x000220E0
		[Token(Token = "0x1700092E")]
		public Vector2 Center
		{
			[Token(Token = "0x6004BA5")]
			[Address(RVA = "0x6E2544", Offset = "0x6E2544", VA = "0x6E2544")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x0400909D RID: 37021
		[Token(Token = "0x400909D")]
		[FieldOffset(Offset = "0x0")]
		public readonly Player Player;
	}
}
