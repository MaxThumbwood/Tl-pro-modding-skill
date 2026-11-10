using System;
using Il2CppDummyDll;

namespace Microsoft.Xna.Framework
{
	// Token: 0x020003AA RID: 938
	[Token(Token = "0x20003AA")]
	public interface IUpdateable
	{
		// Token: 0x060018B4 RID: 6324
		[Token(Token = "0x60018B4")]
		void Update(GameTime gameTime);

		// Token: 0x14000010 RID: 16
		// (add) Token: 0x060018B5 RID: 6325
		// (remove) Token: 0x060018B6 RID: 6326
		[Token(Token = "0x14000010")]
		event EventHandler<EventArgs> EnabledChanged;

		// Token: 0x14000011 RID: 17
		// (add) Token: 0x060018B7 RID: 6327
		// (remove) Token: 0x060018B8 RID: 6328
		[Token(Token = "0x14000011")]
		event EventHandler<EventArgs> UpdateOrderChanged;

		// Token: 0x1700026A RID: 618
		// (get) Token: 0x060018B9 RID: 6329
		[Token(Token = "0x1700026A")]
		bool Enabled
		{
			[Token(Token = "0x60018B9")]
			get;
		}

		// Token: 0x1700026B RID: 619
		// (get) Token: 0x060018BA RID: 6330
		[Token(Token = "0x1700026B")]
		int UpdateOrder
		{
			[Token(Token = "0x60018BA")]
			get;
		}
	}
}
