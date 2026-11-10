using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Terraria.Social.Base
{
	// Token: 0x0200062E RID: 1582
	[Token(Token = "0x200062E")]
	public abstract class AWorkshopTagsCollection
	{
		// Token: 0x06003DAA RID: 15786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DAA")]
		[Address(RVA = "0x1E633B8", Offset = "0x1E633B8", VA = "0x1E633B8")]
		protected void AddWorldTag(string tagNameKey, string tagInternalName)
		{
		}

		// Token: 0x06003DAB RID: 15787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DAB")]
		[Address(RVA = "0x1E634C0", Offset = "0x1E634C0", VA = "0x1E634C0")]
		protected void AddResourcePackTag(string tagNameKey, string tagInternalName)
		{
		}

		// Token: 0x06003DAC RID: 15788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DAC")]
		[Address(RVA = "0x1E632F8", Offset = "0x1E632F8", VA = "0x1E632F8")]
		protected AWorkshopTagsCollection()
		{
		}

		// Token: 0x0400486E RID: 18542
		[Token(Token = "0x400486E")]
		[FieldOffset(Offset = "0x8")]
		public readonly List<WorkshopTagOption> WorldTags;

		// Token: 0x0400486F RID: 18543
		[Token(Token = "0x400486F")]
		[FieldOffset(Offset = "0xC")]
		public readonly List<WorkshopTagOption> ResourcePackTags;
	}
}
