using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.UI
{
	// Token: 0x02000887 RID: 2183
	[Token(Token = "0x2000887")]
	public interface INetDiagnosticsUI
	{
		// Token: 0x06004A3E RID: 19006
		[Token(Token = "0x6004A3E")]
		void Reset();

		// Token: 0x06004A3F RID: 19007
		[Token(Token = "0x6004A3F")]
		void Draw(SpriteBatch spriteBatch);

		// Token: 0x06004A40 RID: 19008
		[Token(Token = "0x6004A40")]
		void CountReadMessage(int messageId, int messageLength);

		// Token: 0x06004A41 RID: 19009
		[Token(Token = "0x6004A41")]
		void CountSentMessage(int messageId, int messageLength);

		// Token: 0x06004A42 RID: 19010
		[Token(Token = "0x6004A42")]
		void CountReadModuleMessage(int moduleMessageId, int messageLength);

		// Token: 0x06004A43 RID: 19011
		[Token(Token = "0x6004A43")]
		void CountSentModuleMessage(int moduleMessageId, int messageLength);

		// Token: 0x06004A44 RID: 19012
		[Token(Token = "0x6004A44")]
		void RotateSendRecvCounters();

		// Token: 0x06004A45 RID: 19013
		[Token(Token = "0x6004A45")]
		void GetLastSentRecvBytes(out int sent, out int recv);
	}
}
