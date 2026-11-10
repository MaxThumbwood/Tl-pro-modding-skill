using System;
using System.IO;
using Il2CppDummyDll;

namespace Terraria
{
	// Token: 0x0200047D RID: 1149
	[Token(Token = "0x200047D")]
	public class MessageBuffer
	{
		// Token: 0x14000029 RID: 41
		// (add) Token: 0x060025C5 RID: 9669 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x060025C6 RID: 9670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000029")]
		public static event TileChangeReceivedEvent OnTileChangeReceived
		{
			[Token(Token = "0x60025C5")]
			[Address(RVA = "0x120DDB4", Offset = "0x120DDB4", VA = "0x120DDB4")]
			add
			{
			}
			[Token(Token = "0x60025C6")]
			[Address(RVA = "0x120DEB8", Offset = "0x120DEB8", VA = "0x120DEB8")]
			remove
			{
			}
		}

		// Token: 0x060025C7 RID: 9671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025C7")]
		[Address(RVA = "0x120DFBC", Offset = "0x120DFBC", VA = "0x120DFBC")]
		public void Reset(bool setupActive = false)
		{
		}

		// Token: 0x060025C8 RID: 9672 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025C8")]
		[Address(RVA = "0x120DFCC", Offset = "0x120DFCC", VA = "0x120DFCC")]
		private float[] ReUseTemporaryProjectileAI()
		{
			return null;
		}

		// Token: 0x060025C9 RID: 9673 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025C9")]
		[Address(RVA = "0x120E02C", Offset = "0x120E02C", VA = "0x120E02C")]
		private float[] ReUseTemporaryNPCAI()
		{
			return null;
		}

		// Token: 0x060025CA RID: 9674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025CA")]
		[Address(RVA = "0x11E0360", Offset = "0x11E0360", VA = "0x11E0360")]
		public void ProcessData(byte[] messageData, int length, out int messageType)
		{
		}

		// Token: 0x060025CB RID: 9675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025CB")]
		[Address(RVA = "0x120E08C", Offset = "0x120E08C", VA = "0x120E08C")]
		private static void ReadAccessoryVisibility(BinaryReader reader, bool[] hideVisibleAccessory)
		{
		}

		// Token: 0x060025CC RID: 9676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025CC")]
		[Address(RVA = "0x120E108", Offset = "0x120E108", VA = "0x120E108")]
		private static void TrySendingItemArray(int plr, Item[] array, int slotStartIndex)
		{
		}

		// Token: 0x060025CD RID: 9677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025CD")]
		[Address(RVA = "0x120E328", Offset = "0x120E328", VA = "0x120E328")]
		public MessageBuffer()
		{
		}

		// Token: 0x040036B1 RID: 14001
		[Token(Token = "0x40036B1")]
		[FieldOffset(Offset = "0x0")]
		private static byte[] processData;

		// Token: 0x040036B2 RID: 14002
		[Token(Token = "0x40036B2")]
		[FieldOffset(Offset = "0x4")]
		private static MemoryStream readerStream;

		// Token: 0x040036B3 RID: 14003
		[Token(Token = "0x40036B3")]
		[FieldOffset(Offset = "0x8")]
		private static BinaryReader reader;

		// Token: 0x040036B4 RID: 14004
		[Token(Token = "0x40036B4")]
		[FieldOffset(Offset = "0x8")]
		public bool broadcast;

		// Token: 0x040036B5 RID: 14005
		[Token(Token = "0x40036B5")]
		[FieldOffset(Offset = "0xC")]
		public int whoAmI;

		// Token: 0x040036B6 RID: 14006
		[Token(Token = "0x40036B6")]
		[FieldOffset(Offset = "0x10")]
		public int spamCount;

		// Token: 0x040036B7 RID: 14007
		[Token(Token = "0x40036B7")]
		[FieldOffset(Offset = "0x14")]
		public int maxSpam;

		// Token: 0x040036B9 RID: 14009
		[Token(Token = "0x40036B9")]
		[FieldOffset(Offset = "0x18")]
		private float[] _temporaryProjectileAI;

		// Token: 0x040036BA RID: 14010
		[Token(Token = "0x40036BA")]
		[FieldOffset(Offset = "0x1C")]
		private float[] _temporaryNPCAI;
	}
}
