using System;
using Il2CppDummyDll;

namespace Microsoft.Xna.Framework.Graphics
{
	// Token: 0x020003FC RID: 1020
	[Token(Token = "0x20003FC")]
	internal class PresentationEventArgs : EventArgs
	{
		// Token: 0x17000346 RID: 838
		// (get) Token: 0x06001C06 RID: 7174 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001C07 RID: 7175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000346")]
		public PresentationParameters PresentationParameters
		{
			[Token(Token = "0x6001C06")]
			[Address(RVA = "0xE847D4", Offset = "0xE847D4", VA = "0xE847D4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001C07")]
			[Address(RVA = "0xE847DC", Offset = "0xE847DC", VA = "0xE847DC")]
			private set
			{
			}
		}

		// Token: 0x06001C08 RID: 7176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C08")]
		[Address(RVA = "0xE847E4", Offset = "0xE847E4", VA = "0xE847E4")]
		public PresentationEventArgs(PresentationParameters presentationParameters)
		{
		}

		// Token: 0x04002FBE RID: 12222
		[Token(Token = "0x4002FBE")]
		[FieldOffset(Offset = "0x8")]
		private PresentationParameters <PresentationParameters>k__BackingField;
	}
}
