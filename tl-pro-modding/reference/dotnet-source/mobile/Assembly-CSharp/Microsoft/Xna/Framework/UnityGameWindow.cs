using System;
using Il2CppDummyDll;

namespace Microsoft.Xna.Framework
{
	// Token: 0x020003A4 RID: 932
	[Token(Token = "0x20003A4")]
	internal class UnityGameWindow : GameWindow
	{
		// Token: 0x1700025F RID: 607
		// (get) Token: 0x06001884 RID: 6276 RVA: 0x0000B8F8 File Offset: 0x00009AF8
		// (set) Token: 0x06001885 RID: 6277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700025F")]
		public override bool AllowUserResizing
		{
			[Token(Token = "0x6001884")]
			[Address(RVA = "0xE2073C", Offset = "0xE2073C", VA = "0xE2073C", Slot = "4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001885")]
			[Address(RVA = "0xE20744", Offset = "0xE20744", VA = "0xE20744", Slot = "5")]
			set
			{
			}
		}

		// Token: 0x06001886 RID: 6278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001886")]
		[Address(RVA = "0xE20748", Offset = "0xE20748", VA = "0xE20748", Slot = "9")]
		public override void BeginScreenDeviceChange(bool willBeFullScreen)
		{
		}

		// Token: 0x17000260 RID: 608
		// (get) Token: 0x06001887 RID: 6279 RVA: 0x0000B910 File Offset: 0x00009B10
		[Token(Token = "0x17000260")]
		public override Rectangle ClientBounds
		{
			[Token(Token = "0x6001887")]
			[Address(RVA = "0xE2074C", Offset = "0xE2074C", VA = "0xE2074C", Slot = "6")]
			get
			{
				return default(Rectangle);
			}
		}

		// Token: 0x06001888 RID: 6280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001888")]
		[Address(RVA = "0xE20798", Offset = "0xE20798", VA = "0xE20798", Slot = "10")]
		public override void EndScreenDeviceChange(string screenDeviceName, int clientWidth, int clientHeight)
		{
		}

		// Token: 0x17000261 RID: 609
		// (get) Token: 0x06001889 RID: 6281 RVA: 0x0000B928 File Offset: 0x00009B28
		[Token(Token = "0x17000261")]
		public override IntPtr Handle
		{
			[Token(Token = "0x6001889")]
			[Address(RVA = "0xE207E4", Offset = "0xE207E4", VA = "0xE207E4", Slot = "7")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000262 RID: 610
		// (get) Token: 0x0600188A RID: 6282 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000262")]
		public override string ScreenDeviceName
		{
			[Token(Token = "0x600188A")]
			[Address(RVA = "0xE20830", Offset = "0xE20830", VA = "0xE20830", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600188B RID: 6283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600188B")]
		[Address(RVA = "0xE2087C", Offset = "0xE2087C", VA = "0xE2087C", Slot = "11")]
		protected override void SetTitle(string title)
		{
		}

		// Token: 0x0600188C RID: 6284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600188C")]
		[Address(RVA = "0xE1FCB4", Offset = "0xE1FCB4", VA = "0xE1FCB4")]
		public UnityGameWindow()
		{
		}
	}
}
