using System;
using System.Collections.Generic;
using System.IO;
using Il2CppDummyDll;

namespace Terraria.Net
{
	// Token: 0x020007EE RID: 2030
	[Token(Token = "0x20007EE")]
	public class NetManager
	{
		// Token: 0x060045E0 RID: 17888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045E0")]
		[Address(RVA = "0x587E7C", Offset = "0x587E7C", VA = "0x587E7C")]
		private NetManager()
		{
		}

		// Token: 0x060045E1 RID: 17889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045E1")]
		public void Register<T>() where T : NetModule, new()
		{
		}

		// Token: 0x060045E2 RID: 17890 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045E2")]
		public NetModule GetModule<T>() where T : NetModule
		{
			return null;
		}

		// Token: 0x060045E3 RID: 17891 RVA: 0x00021378 File Offset: 0x0001F578
		[Token(Token = "0x60045E3")]
		public ushort GetId<T>() where T : NetModule
		{
			return 0;
		}

		// Token: 0x060045E4 RID: 17892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045E4")]
		[Address(RVA = "0x587F14", Offset = "0x587F14", VA = "0x587F14")]
		public void Read(BinaryReader reader, int userId, int readLength)
		{
		}

		// Token: 0x060045E5 RID: 17893 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045E5")]
		[Address(RVA = "0x5880E8", Offset = "0x5880E8", VA = "0x5880E8")]
		public void Broadcast(NetPacket packet, int ignoreClient = -1)
		{
		}

		// Token: 0x060045E6 RID: 17894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045E6")]
		[Address(RVA = "0x5885F8", Offset = "0x5885F8", VA = "0x5885F8")]
		public void Broadcast(NetPacket packet, NetManager.BroadcastCondition conditionToBroadcast, int ignoreClient = -1)
		{
		}

		// Token: 0x060045E7 RID: 17895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045E7")]
		[Address(RVA = "0x5887AC", Offset = "0x5887AC", VA = "0x5887AC")]
		public void SendToSelf(NetPacket packet)
		{
		}

		// Token: 0x060045E8 RID: 17896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045E8")]
		[Address(RVA = "0x588A6C", Offset = "0x588A6C", VA = "0x588A6C")]
		public void BroadcastOrLoopback(NetPacket packet)
		{
		}

		// Token: 0x060045E9 RID: 17897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045E9")]
		[Address(RVA = "0x588B5C", Offset = "0x588B5C", VA = "0x588B5C")]
		public void SendToServerOrLoopback(NetPacket packet)
		{
		}

		// Token: 0x060045EA RID: 17898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045EA")]
		[Address(RVA = "0x588C54", Offset = "0x588C54", VA = "0x588C54")]
		public void SendToServerAndSelf(NetPacket packet)
		{
		}

		// Token: 0x060045EB RID: 17899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045EB")]
		[Address(RVA = "0x588D2C", Offset = "0x588D2C", VA = "0x588D2C")]
		public void SendToServerOrBroadcast(NetPacket packet)
		{
		}

		// Token: 0x060045EC RID: 17900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045EC")]
		[Address(RVA = "0x588C38", Offset = "0x588C38", VA = "0x588C38")]
		public void SendToServer(NetPacket packet)
		{
		}

		// Token: 0x060045ED RID: 17901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045ED")]
		[Address(RVA = "0x588270", Offset = "0x588270", VA = "0x588270")]
		public void SendToClient(NetPacket packet, int clientId)
		{
		}

		// Token: 0x060045EE RID: 17902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045EE")]
		[Address(RVA = "0x589094", Offset = "0x589094", VA = "0x589094")]
		public void SendToClientOrLoopback(NetPacket packet, int playerId)
		{
		}

		// Token: 0x060045EF RID: 17903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045EF")]
		[Address(RVA = "0x5889D0", Offset = "0x5889D0", VA = "0x5889D0")]
		public static void SendCallback(object state)
		{
		}

		// Token: 0x04008D11 RID: 36113
		[Token(Token = "0x4008D11")]
		[FieldOffset(Offset = "0x0")]
		public static NetManager Instance;

		// Token: 0x04008D12 RID: 36114
		[Token(Token = "0x4008D12")]
		[FieldOffset(Offset = "0x8")]
		private Dictionary<ushort, NetModule> _modules;

		// Token: 0x04008D13 RID: 36115
		[Token(Token = "0x4008D13")]
		[FieldOffset(Offset = "0xC")]
		private ushort _moduleCount;

		// Token: 0x04008D14 RID: 36116
		[Token(Token = "0x4008D14")]
		[FieldOffset(Offset = "0x4")]
		public static bool LoopbackClientSends;

		// Token: 0x020007EF RID: 2031
		[Token(Token = "0x20007EF")]
		private class PacketTypeStorage<T> where T : NetModule
		{
			// Token: 0x060045F1 RID: 17905 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60045F1")]
			public PacketTypeStorage()
			{
			}

			// Token: 0x04008D15 RID: 36117
			[Token(Token = "0x4008D15")]
			[FieldOffset(Offset = "0x0")]
			public static ushort Id;

			// Token: 0x04008D16 RID: 36118
			[Token(Token = "0x4008D16")]
			[FieldOffset(Offset = "0x0")]
			public static T Module;
		}

		// Token: 0x020007F0 RID: 2032
		// (Invoke) Token: 0x060045F3 RID: 17907
		[Token(Token = "0x20007F0")]
		public delegate bool BroadcastCondition(int clientIndex);
	}
}
