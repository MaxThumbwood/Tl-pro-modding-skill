using System;
using System.IO;
using Il2CppDummyDll;

namespace Terraria.DataStructures
{
	// Token: 0x0200074C RID: 1868
	[Token(Token = "0x200074C")]
	public struct BinaryWriterHelper
	{
		// Token: 0x06004295 RID: 17045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004295")]
		[Address(RVA = "0x4F735C", Offset = "0x4F735C", VA = "0x4F735C")]
		public void ReservePointToFillLengthLaterByFilling6Bytes(BinaryWriter writer)
		{
		}

		// Token: 0x06004296 RID: 17046 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004296")]
		[Address(RVA = "0x4F73E4", Offset = "0x4F73E4", VA = "0x4F73E4")]
		public void FillReservedPoint(BinaryWriter writer, ushort dataId)
		{
		}

		// Token: 0x06004297 RID: 17047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004297")]
		[Address(RVA = "0x4F7510", Offset = "0x4F7510", VA = "0x4F7510")]
		public void FillOnlyIfThereIsLengthOrRevertToSavedPosition(BinaryWriter writer, ushort dataId, out bool wroteSomething)
		{
		}

		// Token: 0x04008A17 RID: 35351
		[Token(Token = "0x4008A17")]
		[FieldOffset(Offset = "0x0")]
		private long _placeInWriter;
	}
}
