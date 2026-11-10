using System;
using Il2CppDummyDll;

namespace MonoGame.OpenGL
{
	// Token: 0x02000388 RID: 904
	[Token(Token = "0x2000388")]
	internal interface IGraphicsContext
	{
		// Token: 0x1700021F RID: 543
		// (get) Token: 0x0600164B RID: 5707
		// (set) Token: 0x0600164C RID: 5708
		[Token(Token = "0x1700021F")]
		int SwapInterval
		{
			[Token(Token = "0x600164B")]
			get;
			[Token(Token = "0x600164C")]
			set;
		}

		// Token: 0x17000220 RID: 544
		// (get) Token: 0x0600164D RID: 5709
		[Token(Token = "0x17000220")]
		bool IsDisposed
		{
			[Token(Token = "0x600164D")]
			get;
		}

		// Token: 0x0600164E RID: 5710
		[Token(Token = "0x600164E")]
		void MakeCurrent(IWindowInfo info);

		// Token: 0x0600164F RID: 5711
		[Token(Token = "0x600164F")]
		void SwapBuffers();

		// Token: 0x17000221 RID: 545
		// (get) Token: 0x06001650 RID: 5712
		[Token(Token = "0x17000221")]
		bool IsCurrent
		{
			[Token(Token = "0x6001650")]
			get;
		}
	}
}
