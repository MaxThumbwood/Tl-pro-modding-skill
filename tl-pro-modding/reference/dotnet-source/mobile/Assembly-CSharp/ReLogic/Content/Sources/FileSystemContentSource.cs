using System;
using System.Collections.Generic;
using System.IO;
using Il2CppDummyDll;

namespace ReLogic.Content.Sources
{
	// Token: 0x02000E16 RID: 3606
	[Token(Token = "0x2000E16")]
	public class FileSystemContentSource : FileAPI
	{
		// Token: 0x17000B50 RID: 2896
		// (get) Token: 0x06006967 RID: 26983 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006968 RID: 26984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B50")]
		public IContentValidator ContentValidator
		{
			[Token(Token = "0x6006967")]
			[Address(RVA = "0xB86CC8", Offset = "0xB86CC8", VA = "0xB86CC8", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6006968")]
			[Address(RVA = "0xB86CD0", Offset = "0xB86CD0", VA = "0xB86CD0", Slot = "5")]
			set
			{
			}
		}

		// Token: 0x17000B51 RID: 2897
		// (get) Token: 0x06006969 RID: 26985 RVA: 0x0002FB20 File Offset: 0x0002DD20
		[Token(Token = "0x17000B51")]
		public int FileCount
		{
			[Token(Token = "0x6006969")]
			[Address(RVA = "0xB86CD8", Offset = "0xB86CD8", VA = "0xB86CD8")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600696A RID: 26986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600696A")]
		[Address(RVA = "0xB86D3C", Offset = "0xB86D3C", VA = "0xB86D3C")]
		public FileSystemContentSource(string basePath)
		{
		}

		// Token: 0x0600696B RID: 26987 RVA: 0x0002FB38 File Offset: 0x0002DD38
		[Token(Token = "0x600696B")]
		[Address(RVA = "0xB871E8", Offset = "0xB871E8", VA = "0xB871E8", Slot = "6")]
		public bool HasAsset(string assetName)
		{
			return default(bool);
		}

		// Token: 0x0600696C RID: 26988 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600696C")]
		[Address(RVA = "0xB872D0", Offset = "0xB872D0", VA = "0xB872D0", Slot = "7")]
		public string GetExtension(string assetName)
		{
			return null;
		}

		// Token: 0x0600696D RID: 26989 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600696D")]
		[Address(RVA = "0xB873F0", Offset = "0xB873F0", VA = "0xB873F0", Slot = "8")]
		public Stream OpenStream(string assetName)
		{
			return null;
		}

		// Token: 0x0600696E RID: 26990 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600696E")]
		[Address(RVA = "0xB86FF4", Offset = "0xB86FF4", VA = "0xB86FF4")]
		private void BuildNameToAbsolutePathDictionary()
		{
		}

		// Token: 0x0600696F RID: 26991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600696F")]
		[Address(RVA = "0xB87550", Offset = "0xB87550", VA = "0xB87550", Slot = "9")]
		public void RejectAsset(string assetName, IRejectionReason reason)
		{
		}

		// Token: 0x06006970 RID: 26992 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006970")]
		[Address(RVA = "0xB875D0", Offset = "0xB875D0", VA = "0xB875D0", Slot = "10")]
		public void ClearRejections()
		{
		}

		// Token: 0x06006971 RID: 26993 RVA: 0x0002FB50 File Offset: 0x0002DD50
		[Token(Token = "0x6006971")]
		[Address(RVA = "0xB87640", Offset = "0xB87640", VA = "0xB87640", Slot = "11")]
		public bool TryGetRejections(List<string> rejectionReasons)
		{
			return default(bool);
		}

		// Token: 0x0400A6F8 RID: 42744
		[Token(Token = "0x400A6F8")]
		[FieldOffset(Offset = "0x8")]
		private IContentValidator <ContentValidator>k__BackingField;

		// Token: 0x0400A6F9 RID: 42745
		[Token(Token = "0x400A6F9")]
		[FieldOffset(Offset = "0xC")]
		private readonly string _basePath;

		// Token: 0x0400A6FA RID: 42746
		[Token(Token = "0x400A6FA")]
		[FieldOffset(Offset = "0x10")]
		private readonly Dictionary<string, string> _nameToAbsolutePath;

		// Token: 0x0400A6FB RID: 42747
		[Token(Token = "0x400A6FB")]
		[FieldOffset(Offset = "0x14")]
		private readonly RejectedAssetCollection _rejections;
	}
}
