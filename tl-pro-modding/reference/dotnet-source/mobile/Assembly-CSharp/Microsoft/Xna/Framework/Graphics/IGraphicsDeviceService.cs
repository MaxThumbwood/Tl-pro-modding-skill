using System;
using Il2CppDummyDll;

namespace Microsoft.Xna.Framework.Graphics
{
	// Token: 0x020003F9 RID: 1017
	[Token(Token = "0x20003F9")]
	public interface IGraphicsDeviceService
	{
		// Token: 0x17000344 RID: 836
		// (get) Token: 0x06001BF9 RID: 7161
		[Token(Token = "0x17000344")]
		GraphicsDevice GraphicsDevice
		{
			[Token(Token = "0x6001BF9")]
			get;
		}

		// Token: 0x1400001A RID: 26
		// (add) Token: 0x06001BFA RID: 7162
		// (remove) Token: 0x06001BFB RID: 7163
		[Token(Token = "0x1400001A")]
		event EventHandler<EventArgs> DeviceCreated;

		// Token: 0x1400001B RID: 27
		// (add) Token: 0x06001BFC RID: 7164
		// (remove) Token: 0x06001BFD RID: 7165
		[Token(Token = "0x1400001B")]
		event EventHandler<EventArgs> DeviceDisposing;

		// Token: 0x1400001C RID: 28
		// (add) Token: 0x06001BFE RID: 7166
		// (remove) Token: 0x06001BFF RID: 7167
		[Token(Token = "0x1400001C")]
		event EventHandler<EventArgs> DeviceReset;

		// Token: 0x1400001D RID: 29
		// (add) Token: 0x06001C00 RID: 7168
		// (remove) Token: 0x06001C01 RID: 7169
		[Token(Token = "0x1400001D")]
		event EventHandler<EventArgs> DeviceResetting;
	}
}
