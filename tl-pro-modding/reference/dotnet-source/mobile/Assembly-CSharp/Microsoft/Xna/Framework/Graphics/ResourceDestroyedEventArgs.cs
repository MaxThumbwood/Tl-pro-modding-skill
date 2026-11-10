using System;
using Il2CppDummyDll;

namespace Microsoft.Xna.Framework.Graphics
{
	// Token: 0x02000403 RID: 1027
	[Token(Token = "0x2000403")]
	public sealed class ResourceDestroyedEventArgs : EventArgs
	{
		// Token: 0x1700035B RID: 859
		// (get) Token: 0x06001C3C RID: 7228 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001C3D RID: 7229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700035B")]
		public string Name
		{
			[Token(Token = "0x6001C3C")]
			[Address(RVA = "0xE85020", Offset = "0xE85020", VA = "0xE85020")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001C3D")]
			[Address(RVA = "0xE85028", Offset = "0xE85028", VA = "0xE85028")]
			internal set
			{
			}
		}

		// Token: 0x1700035C RID: 860
		// (get) Token: 0x06001C3E RID: 7230 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001C3F RID: 7231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700035C")]
		public object Tag
		{
			[Token(Token = "0x6001C3E")]
			[Address(RVA = "0xE85030", Offset = "0xE85030", VA = "0xE85030")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001C3F")]
			[Address(RVA = "0xE85038", Offset = "0xE85038", VA = "0xE85038")]
			internal set
			{
			}
		}

		// Token: 0x06001C40 RID: 7232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C40")]
		[Address(RVA = "0xE85040", Offset = "0xE85040", VA = "0xE85040")]
		public ResourceDestroyedEventArgs()
		{
		}

		// Token: 0x04002FDC RID: 12252
		[Token(Token = "0x4002FDC")]
		[FieldOffset(Offset = "0x8")]
		private string <Name>k__BackingField;

		// Token: 0x04002FDD RID: 12253
		[Token(Token = "0x4002FDD")]
		[FieldOffset(Offset = "0xC")]
		private object <Tag>k__BackingField;
	}
}
