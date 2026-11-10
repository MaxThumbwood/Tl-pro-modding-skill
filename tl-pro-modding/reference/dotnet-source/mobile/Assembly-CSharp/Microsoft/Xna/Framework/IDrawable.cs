using System;
using Il2CppDummyDll;

namespace Microsoft.Xna.Framework
{
	// Token: 0x020003A8 RID: 936
	[Token(Token = "0x20003A8")]
	public interface IDrawable
	{
		// Token: 0x17000268 RID: 616
		// (get) Token: 0x060018AC RID: 6316
		[Token(Token = "0x17000268")]
		int DrawOrder
		{
			[Token(Token = "0x60018AC")]
			get;
		}

		// Token: 0x17000269 RID: 617
		// (get) Token: 0x060018AD RID: 6317
		[Token(Token = "0x17000269")]
		bool Visible
		{
			[Token(Token = "0x60018AD")]
			get;
		}

		// Token: 0x1400000E RID: 14
		// (add) Token: 0x060018AE RID: 6318
		// (remove) Token: 0x060018AF RID: 6319
		[Token(Token = "0x1400000E")]
		event EventHandler<EventArgs> DrawOrderChanged;

		// Token: 0x1400000F RID: 15
		// (add) Token: 0x060018B0 RID: 6320
		// (remove) Token: 0x060018B1 RID: 6321
		[Token(Token = "0x1400000F")]
		event EventHandler<EventArgs> VisibleChanged;

		// Token: 0x060018B2 RID: 6322
		[Token(Token = "0x60018B2")]
		void Draw(GameTime gameTime);
	}
}
