using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.Graphics.Capture
{
	// Token: 0x020008EF RID: 2287
	[Token(Token = "0x20008EF")]
	public class CaptureManager : FileAPI
	{
		// Token: 0x17000941 RID: 2369
		// (get) Token: 0x06004CED RID: 19693 RVA: 0x00024258 File Offset: 0x00022458
		[Token(Token = "0x17000941")]
		public bool IsCapturing
		{
			[Token(Token = "0x6004CED")]
			[Address(RVA = "0x71B91C", Offset = "0x71B91C", VA = "0x71B91C")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06004CEE RID: 19694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CEE")]
		[Address(RVA = "0x71B924", Offset = "0x71B924", VA = "0x71B924")]
		public CaptureManager()
		{
		}

		// Token: 0x17000942 RID: 2370
		// (get) Token: 0x06004CEF RID: 19695 RVA: 0x00024270 File Offset: 0x00022470
		// (set) Token: 0x06004CF0 RID: 19696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000942")]
		public bool Active
		{
			[Token(Token = "0x6004CEF")]
			[Address(RVA = "0x71B9A0", Offset = "0x71B9A0", VA = "0x71B9A0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004CF0")]
			[Address(RVA = "0x71B9C4", Offset = "0x71B9C4", VA = "0x71B9C4")]
			set
			{
			}
		}

		// Token: 0x17000943 RID: 2371
		// (get) Token: 0x06004CF1 RID: 19697 RVA: 0x00024288 File Offset: 0x00022488
		[Token(Token = "0x17000943")]
		public bool UsingMap
		{
			[Token(Token = "0x6004CF1")]
			[Address(RVA = "0x71BA74", Offset = "0x71BA74", VA = "0x71BA74")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06004CF2 RID: 19698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CF2")]
		[Address(RVA = "0x71BABC", Offset = "0x71BABC", VA = "0x71BABC")]
		public void Scrolling()
		{
		}

		// Token: 0x06004CF3 RID: 19699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CF3")]
		[Address(RVA = "0x71BADC", Offset = "0x71BADC", VA = "0x71BADC")]
		public void Update(CaptureInterface.SelectionContext context)
		{
		}

		// Token: 0x06004CF4 RID: 19700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CF4")]
		[Address(RVA = "0x71BB04", Offset = "0x71BB04", VA = "0x71BB04")]
		public void Draw(SpriteBatch sb)
		{
		}

		// Token: 0x06004CF5 RID: 19701 RVA: 0x000242A0 File Offset: 0x000224A0
		[Token(Token = "0x6004CF5")]
		[Address(RVA = "0x714FAC", Offset = "0x714FAC", VA = "0x714FAC")]
		public float GetProgress()
		{
			return 0f;
		}

		// Token: 0x06004CF6 RID: 19702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CF6")]
		[Address(RVA = "0x71BB2C", Offset = "0x71BB2C", VA = "0x71BB2C")]
		public void Capture()
		{
		}

		// Token: 0x06004CF7 RID: 19703 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CF7")]
		[Address(RVA = "0x714FA8", Offset = "0x714FA8", VA = "0x714FA8")]
		public void Capture(CaptureSettings settings)
		{
		}

		// Token: 0x06004CF8 RID: 19704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CF8")]
		[Address(RVA = "0x71BBFC", Offset = "0x71BBFC", VA = "0x71BBFC")]
		public void DrawTick()
		{
		}

		// Token: 0x06004CF9 RID: 19705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CF9")]
		[Address(RVA = "0x71BC00", Offset = "0x71BC00", VA = "0x71BC00", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x040091EB RID: 37355
		[Token(Token = "0x40091EB")]
		[FieldOffset(Offset = "0x0")]
		public static CaptureManager Instance;

		// Token: 0x040091EC RID: 37356
		[Token(Token = "0x40091EC")]
		[FieldOffset(Offset = "0x8")]
		private CaptureInterface _interface;
	}
}
