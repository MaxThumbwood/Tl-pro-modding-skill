using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.UI
{
	// Token: 0x02000889 RID: 2185
	[Token(Token = "0x2000889")]
	public class NetDiagnosticsUI : FileAPI
	{
		// Token: 0x06004A4F RID: 19023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A4F")]
		[Address(RVA = "0x61B6EC", Offset = "0x61B6EC", VA = "0x61B6EC", Slot = "4")]
		public void Reset()
		{
		}

		// Token: 0x06004A50 RID: 19024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A50")]
		[Address(RVA = "0x61B814", Offset = "0x61B814", VA = "0x61B814", Slot = "6")]
		public void CountReadMessage(int messageId, int messageLength)
		{
		}

		// Token: 0x06004A51 RID: 19025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A51")]
		[Address(RVA = "0x61B888", Offset = "0x61B888", VA = "0x61B888", Slot = "7")]
		public void CountSentMessage(int messageId, int messageLength)
		{
		}

		// Token: 0x06004A52 RID: 19026 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A52")]
		[Address(RVA = "0x61B8FC", Offset = "0x61B8FC", VA = "0x61B8FC", Slot = "8")]
		public void CountReadModuleMessage(int moduleMessageId, int messageLength)
		{
		}

		// Token: 0x06004A53 RID: 19027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A53")]
		[Address(RVA = "0x61BA00", Offset = "0x61BA00", VA = "0x61BA00", Slot = "9")]
		public void CountSentModuleMessage(int moduleMessageId, int messageLength)
		{
		}

		// Token: 0x06004A54 RID: 19028 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A54")]
		[Address(RVA = "0x61BB04", Offset = "0x61BB04", VA = "0x61BB04", Slot = "10")]
		public void RotateSendRecvCounters()
		{
		}

		// Token: 0x06004A55 RID: 19029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A55")]
		[Address(RVA = "0x61BB50", Offset = "0x61BB50", VA = "0x61BB50", Slot = "11")]
		public void GetLastSentRecvBytes(out int sent, out int recv)
		{
		}

		// Token: 0x06004A56 RID: 19030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A56")]
		[Address(RVA = "0x61BB7C", Offset = "0x61BB7C", VA = "0x61BB7C", Slot = "5")]
		public void Draw(SpriteBatch spriteBatch)
		{
		}

		// Token: 0x06004A57 RID: 19031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A57")]
		[Address(RVA = "0x61C12C", Offset = "0x61C12C", VA = "0x61C12C")]
		private void DrawCounter(SpriteBatch spriteBatch, ref NetDiagnosticsUI.CounterForMessage counter, string title, Vector2 position)
		{
		}

		// Token: 0x06004A58 RID: 19032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A58")]
		[Address(RVA = "0x61C4E8", Offset = "0x61C4E8", VA = "0x61C4E8")]
		private void DrawText(SpriteBatch spriteBatch, string text, Vector2 pos, Color color)
		{
		}

		// Token: 0x06004A59 RID: 19033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A59")]
		[Address(RVA = "0x61C640", Offset = "0x61C640", VA = "0x61C640")]
		public NetDiagnosticsUI()
		{
		}

		// Token: 0x04008FB7 RID: 36791
		[Token(Token = "0x4008FB7")]
		[FieldOffset(Offset = "0x8")]
		private NetDiagnosticsUI.CounterForMessage[] _counterByMessageId;

		// Token: 0x04008FB8 RID: 36792
		[Token(Token = "0x4008FB8")]
		[FieldOffset(Offset = "0xC")]
		private Dictionary<int, NetDiagnosticsUI.CounterForMessage> _counterByModuleId;

		// Token: 0x04008FB9 RID: 36793
		[Token(Token = "0x4008FB9")]
		[FieldOffset(Offset = "0x10")]
		private int bytesRecv;

		// Token: 0x04008FBA RID: 36794
		[Token(Token = "0x4008FBA")]
		[FieldOffset(Offset = "0x14")]
		private int bytesRecvLast;

		// Token: 0x04008FBB RID: 36795
		[Token(Token = "0x4008FBB")]
		[FieldOffset(Offset = "0x18")]
		private int bytesSent;

		// Token: 0x04008FBC RID: 36796
		[Token(Token = "0x4008FBC")]
		[FieldOffset(Offset = "0x1C")]
		private int bytesSentLast;

		// Token: 0x04008FBD RID: 36797
		[Token(Token = "0x4008FBD")]
		[FieldOffset(Offset = "0x20")]
		private int _highestFoundReadBytes;

		// Token: 0x04008FBE RID: 36798
		[Token(Token = "0x4008FBE")]
		[FieldOffset(Offset = "0x24")]
		private int _highestFoundReadCount;

		// Token: 0x0200088A RID: 2186
		[Token(Token = "0x200088A")]
		private struct CounterForMessage
		{
			// Token: 0x06004A5A RID: 19034 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004A5A")]
			[Address(RVA = "0x61B808", Offset = "0x61B808", VA = "0x61B808")]
			public void Reset()
			{
			}

			// Token: 0x06004A5B RID: 19035 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004A5B")]
			[Address(RVA = "0x61B86C", Offset = "0x61B86C", VA = "0x61B86C")]
			public void CountReadMessage(int messageLength)
			{
			}

			// Token: 0x06004A5C RID: 19036 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004A5C")]
			[Address(RVA = "0x61B8E0", Offset = "0x61B8E0", VA = "0x61B8E0")]
			public void CountSentMessage(int messageLength)
			{
			}

			// Token: 0x04008FBF RID: 36799
			[Token(Token = "0x4008FBF")]
			[FieldOffset(Offset = "0x0")]
			public int timesReceived;

			// Token: 0x04008FC0 RID: 36800
			[Token(Token = "0x4008FC0")]
			[FieldOffset(Offset = "0x4")]
			public int timesSent;

			// Token: 0x04008FC1 RID: 36801
			[Token(Token = "0x4008FC1")]
			[FieldOffset(Offset = "0x8")]
			public int bytesReceived;

			// Token: 0x04008FC2 RID: 36802
			[Token(Token = "0x4008FC2")]
			[FieldOffset(Offset = "0xC")]
			public int bytesSent;

			// Token: 0x04008FC3 RID: 36803
			[Token(Token = "0x4008FC3")]
			[FieldOffset(Offset = "0x10")]
			public bool exemptFromBadScoreTest;
		}
	}
}
