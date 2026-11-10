using System;
using System.IO;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

namespace Terraria.GameContent.Drawing
{
	// Token: 0x02000CAE RID: 3246
	[Token(Token = "0x2000CAE")]
	public struct ParticleOrchestraSettings
	{
		// Token: 0x0600604F RID: 24655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600604F")]
		[Address(RVA = "0xA9C340", Offset = "0xA9C340", VA = "0xA9C340")]
		public void Serialize(BinaryWriter writer)
		{
		}

		// Token: 0x06006050 RID: 24656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006050")]
		[Address(RVA = "0xA9C41C", Offset = "0xA9C41C", VA = "0xA9C41C")]
		public void DeserializeFrom(BinaryReader reader)
		{
		}

		// Token: 0x04009F4D RID: 40781
		[Token(Token = "0x4009F4D")]
		[FieldOffset(Offset = "0x0")]
		public Vector2 PositionInWorld;

		// Token: 0x04009F4E RID: 40782
		[Token(Token = "0x4009F4E")]
		[FieldOffset(Offset = "0x8")]
		public Vector2 MovementVector;

		// Token: 0x04009F4F RID: 40783
		[Token(Token = "0x4009F4F")]
		[FieldOffset(Offset = "0x10")]
		public int UniqueInfoPiece;

		// Token: 0x04009F50 RID: 40784
		[Token(Token = "0x4009F50")]
		[FieldOffset(Offset = "0x14")]
		public byte IndexOfPlayerWhoInvokedThis;
	}
}
