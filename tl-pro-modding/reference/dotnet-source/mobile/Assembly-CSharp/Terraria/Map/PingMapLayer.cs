using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using ReLogic.Utilities;

namespace Terraria.Map
{
	// Token: 0x02000815 RID: 2069
	[Token(Token = "0x2000815")]
	public class PingMapLayer : FileAPI
	{
		// Token: 0x060046BE RID: 18110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046BE")]
		[Address(RVA = "0x5A17F0", Offset = "0x5A17F0", VA = "0x5A17F0", Slot = "4")]
		public void Draw(ref MapOverlayDrawContext context, ref string text)
		{
		}

		// Token: 0x060046BF RID: 18111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046BF")]
		[Address(RVA = "0x5A1E1C", Offset = "0x5A1E1C", VA = "0x5A1E1C")]
		public void Add(Vector2 position)
		{
		}

		// Token: 0x060046C0 RID: 18112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046C0")]
		[Address(RVA = "0x5A1FFC", Offset = "0x5A1FFC", VA = "0x5A1FFC")]
		public void Clear()
		{
		}

		// Token: 0x060046C1 RID: 18113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046C1")]
		[Address(RVA = "0x5A2060", Offset = "0x5A2060", VA = "0x5A2060")]
		public PingMapLayer()
		{
		}

		// Token: 0x04008DA6 RID: 36262
		[Token(Token = "0x4008DA6")]
		private const double PING_DURATION_IN_SECONDS = 15.0;

		// Token: 0x04008DA7 RID: 36263
		[Token(Token = "0x4008DA7")]
		private const double PING_FRAME_RATE = 10.0;

		// Token: 0x04008DA8 RID: 36264
		[Token(Token = "0x4008DA8")]
		[FieldOffset(Offset = "0x8")]
		private readonly SlotVector<PingMapLayer.Ping> _pings;

		// Token: 0x02000816 RID: 2070
		[Token(Token = "0x2000816")]
		private struct Ping
		{
			// Token: 0x060046C2 RID: 18114 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60046C2")]
			[Address(RVA = "0x5A1F74", Offset = "0x5A1F74", VA = "0x5A1F74")]
			public Ping(Vector2 position)
			{
			}

			// Token: 0x04008DA9 RID: 36265
			[Token(Token = "0x4008DA9")]
			[FieldOffset(Offset = "0x0")]
			public readonly Vector2 Position;

			// Token: 0x04008DAA RID: 36266
			[Token(Token = "0x4008DAA")]
			[FieldOffset(Offset = "0x8")]
			public readonly DateTime Time;
		}
	}
}
