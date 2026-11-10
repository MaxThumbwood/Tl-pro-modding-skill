using System;
using Il2CppDummyDll;

namespace Microsoft.Xna.Framework
{
	// Token: 0x020003A2 RID: 930
	[Token(Token = "0x20003A2")]
	public abstract class GameWindow
	{
		// Token: 0x17000257 RID: 599
		// (get) Token: 0x06001868 RID: 6248 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001869 RID: 6249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000257")]
		public string Title
		{
			[Token(Token = "0x6001868")]
			[Address(RVA = "0xE201A4", Offset = "0xE201A4", VA = "0xE201A4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001869")]
			[Address(RVA = "0xE201AC", Offset = "0xE201AC", VA = "0xE201AC")]
			set
			{
			}
		}

		// Token: 0x17000258 RID: 600
		// (get) Token: 0x0600186A RID: 6250
		// (set) Token: 0x0600186B RID: 6251
		[Token(Token = "0x17000258")]
		public abstract bool AllowUserResizing
		{
			[Token(Token = "0x600186A")]
			get;
			[Token(Token = "0x600186B")]
			set;
		}

		// Token: 0x17000259 RID: 601
		// (get) Token: 0x0600186C RID: 6252
		[Token(Token = "0x17000259")]
		public abstract Rectangle ClientBounds
		{
			[Token(Token = "0x600186C")]
			get;
		}

		// Token: 0x1700025A RID: 602
		// (get) Token: 0x0600186D RID: 6253
		[Token(Token = "0x1700025A")]
		public abstract IntPtr Handle
		{
			[Token(Token = "0x600186D")]
			get;
		}

		// Token: 0x1700025B RID: 603
		// (get) Token: 0x0600186E RID: 6254
		[Token(Token = "0x1700025B")]
		public abstract string ScreenDeviceName
		{
			[Token(Token = "0x600186E")]
			get;
		}

		// Token: 0x14000008 RID: 8
		// (add) Token: 0x0600186F RID: 6255 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06001870 RID: 6256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000008")]
		public event EventHandler ClientSizeChanged
		{
			[Token(Token = "0x600186F")]
			[Address(RVA = "0xE201EC", Offset = "0xE201EC", VA = "0xE201EC")]
			add
			{
			}
			[Token(Token = "0x6001870")]
			[Address(RVA = "0xE2029C", Offset = "0xE2029C", VA = "0xE2029C")]
			remove
			{
			}
		}

		// Token: 0x14000009 RID: 9
		// (add) Token: 0x06001871 RID: 6257 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06001872 RID: 6258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000009")]
		public event EventHandler ScreenDeviceNameChanged
		{
			[Token(Token = "0x6001871")]
			[Address(RVA = "0xE2034C", Offset = "0xE2034C", VA = "0xE2034C")]
			add
			{
			}
			[Token(Token = "0x6001872")]
			[Address(RVA = "0xE203FC", Offset = "0xE203FC", VA = "0xE203FC")]
			remove
			{
			}
		}

		// Token: 0x06001873 RID: 6259
		[Token(Token = "0x6001873")]
		public abstract void BeginScreenDeviceChange(bool willBeFullScreen);

		// Token: 0x06001874 RID: 6260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001874")]
		[Address(RVA = "0xE204AC", Offset = "0xE204AC", VA = "0xE204AC")]
		public void EndScreenDeviceChange(string screenDeviceName)
		{
		}

		// Token: 0x06001875 RID: 6261
		[Token(Token = "0x6001875")]
		public abstract void EndScreenDeviceChange(string screenDeviceName, int clientWidth, int clientHeight);

		// Token: 0x06001876 RID: 6262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001876")]
		[Address(RVA = "0xE204F8", Offset = "0xE204F8", VA = "0xE204F8")]
		protected void OnActivated()
		{
		}

		// Token: 0x06001877 RID: 6263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001877")]
		[Address(RVA = "0xE204FC", Offset = "0xE204FC", VA = "0xE204FC")]
		protected void OnClientSizeChanged()
		{
		}

		// Token: 0x06001878 RID: 6264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001878")]
		[Address(RVA = "0xE20588", Offset = "0xE20588", VA = "0xE20588")]
		protected void OnDeactivated()
		{
		}

		// Token: 0x06001879 RID: 6265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001879")]
		[Address(RVA = "0xE2058C", Offset = "0xE2058C", VA = "0xE2058C")]
		protected void OnPaint()
		{
		}

		// Token: 0x0600187A RID: 6266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600187A")]
		[Address(RVA = "0xE205D8", Offset = "0xE205D8", VA = "0xE205D8")]
		protected void OnScreenDeviceNameChanged()
		{
		}

		// Token: 0x0600187B RID: 6267
		[Token(Token = "0x600187B")]
		protected abstract void SetTitle(string title);

		// Token: 0x1700025C RID: 604
		// (get) Token: 0x0600187C RID: 6268 RVA: 0x0000B8C8 File Offset: 0x00009AC8
		// (set) Token: 0x0600187D RID: 6269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700025C")]
		public DisplayOrientation CurrentOrientation
		{
			[Token(Token = "0x600187C")]
			[Address(RVA = "0xE20664", Offset = "0xE20664", VA = "0xE20664")]
			get
			{
				return DisplayOrientation.Default;
			}
			[Token(Token = "0x600187D")]
			[Address(RVA = "0xE2066C", Offset = "0xE2066C", VA = "0xE2066C")]
			set
			{
			}
		}

		// Token: 0x0600187E RID: 6270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600187E")]
		[Address(RVA = "0xE20674", Offset = "0xE20674", VA = "0xE20674")]
		protected GameWindow()
		{
		}

		// Token: 0x04002B52 RID: 11090
		[Token(Token = "0x4002B52")]
		[FieldOffset(Offset = "0x8")]
		private string title;

		// Token: 0x04002B55 RID: 11093
		[Token(Token = "0x4002B55")]
		[FieldOffset(Offset = "0x14")]
		private DisplayOrientation <CurrentOrientation>k__BackingField;
	}
}
