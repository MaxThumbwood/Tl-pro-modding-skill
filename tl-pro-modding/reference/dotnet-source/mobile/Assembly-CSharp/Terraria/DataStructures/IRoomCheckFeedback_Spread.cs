using System;
using Il2CppDummyDll;

namespace Terraria.DataStructures
{
	// Token: 0x02000769 RID: 1897
	[Token(Token = "0x2000769")]
	public interface IRoomCheckFeedback_Spread
	{
		// Token: 0x17000821 RID: 2081
		// (get) Token: 0x060042F1 RID: 17137
		[Token(Token = "0x17000821")]
		bool StopOnFail
		{
			[Token(Token = "0x60042F1")]
			get;
		}

		// Token: 0x17000822 RID: 2082
		// (get) Token: 0x060042F2 RID: 17138
		[Token(Token = "0x17000822")]
		bool DisplayText
		{
			[Token(Token = "0x60042F2")]
			get;
		}

		// Token: 0x060042F3 RID: 17139
		[Token(Token = "0x60042F3")]
		void BeginSpread(int x, int y);

		// Token: 0x060042F4 RID: 17140
		[Token(Token = "0x60042F4")]
		void StartedInASolidTile(int x, int y);

		// Token: 0x060042F5 RID: 17141
		[Token(Token = "0x60042F5")]
		void TooCloseToWorldEdge(int x, int y, int iteration);

		// Token: 0x060042F6 RID: 17142
		[Token(Token = "0x60042F6")]
		void AnyBlockScannedHere(int x, int y, int iteration);

		// Token: 0x060042F7 RID: 17143
		[Token(Token = "0x60042F7")]
		void RoomTooBig(int x, int y, int iteration);

		// Token: 0x060042F8 RID: 17144
		[Token(Token = "0x60042F8")]
		void BlockingWall(int x, int y, int iteration);

		// Token: 0x060042F9 RID: 17145
		[Token(Token = "0x60042F9")]
		void BlockingOpenGate(int x, int y, int iteration);

		// Token: 0x060042FA RID: 17146
		[Token(Token = "0x60042FA")]
		void Stinkbug(int x, int y, int iteration);

		// Token: 0x060042FB RID: 17147
		[Token(Token = "0x60042FB")]
		void EchoStinkbug(int x, int y, int iteration);

		// Token: 0x060042FC RID: 17148
		[Token(Token = "0x60042FC")]
		void MissingAWall(int x, int y, int iteration);

		// Token: 0x060042FD RID: 17149
		[Token(Token = "0x60042FD")]
		void UnsafeWall(int x, int y, int iteration);

		// Token: 0x060042FE RID: 17150
		[Token(Token = "0x60042FE")]
		void EndSpread();
	}
}
