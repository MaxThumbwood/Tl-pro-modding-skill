using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace ReLogic.Content
{
	// Token: 0x02000E06 RID: 3590
	[Token(Token = "0x2000E06")]
	public class RejectedAssetCollection
	{
		// Token: 0x0600691D RID: 26909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600691D")]
		[Address(RVA = "0xB84788", Offset = "0xB84788", VA = "0xB84788")]
		public void Reject(string assetPath, IRejectionReason reason)
		{
		}

		// Token: 0x0600691E RID: 26910 RVA: 0x0002FA00 File Offset: 0x0002DC00
		[Token(Token = "0x600691E")]
		[Address(RVA = "0xB847FC", Offset = "0xB847FC", VA = "0xB847FC")]
		public bool IsRejected(string assetPath)
		{
			return default(bool);
		}

		// Token: 0x0600691F RID: 26911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600691F")]
		[Address(RVA = "0xB84868", Offset = "0xB84868", VA = "0xB84868")]
		public void Clear()
		{
		}

		// Token: 0x06006920 RID: 26912 RVA: 0x0002FA18 File Offset: 0x0002DC18
		[Token(Token = "0x6006920")]
		[Address(RVA = "0xB848CC", Offset = "0xB848CC", VA = "0xB848CC")]
		public bool TryGetRejections(List<string> rejectionReasons)
		{
			return default(bool);
		}

		// Token: 0x06006921 RID: 26913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006921")]
		[Address(RVA = "0xB84C00", Offset = "0xB84C00", VA = "0xB84C00")]
		public RejectedAssetCollection()
		{
		}

		// Token: 0x0400A6DB RID: 42715
		[Token(Token = "0x400A6DB")]
		[FieldOffset(Offset = "0x8")]
		private Dictionary<string, IRejectionReason> _rejectedAssetsAndReasons;
	}
}
