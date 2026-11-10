using System;
using System.Collections.Generic;
using System.IO;
using Il2CppDummyDll;

namespace ReLogic.Content.Sources
{
	// Token: 0x02000E19 RID: 3609
	[Token(Token = "0x2000E19")]
	public class XnaDirectContentSource : FileAPI
	{
		// Token: 0x17000B54 RID: 2900
		// (get) Token: 0x06006985 RID: 27013 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006986 RID: 27014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B54")]
		public IContentValidator ContentValidator
		{
			[Token(Token = "0x6006985")]
			[Address(RVA = "0xB87E4C", Offset = "0xB87E4C", VA = "0xB87E4C", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6006986")]
			[Address(RVA = "0xB87E54", Offset = "0xB87E54", VA = "0xB87E54", Slot = "5")]
			set
			{
			}
		}

		// Token: 0x06006987 RID: 27015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006987")]
		[Address(RVA = "0xB87E5C", Offset = "0xB87E5C", VA = "0xB87E5C")]
		public XnaDirectContentSource(string rootDirectory)
		{
		}

		// Token: 0x06006988 RID: 27016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006988")]
		[Address(RVA = "0xB87FE8", Offset = "0xB87FE8", VA = "0xB87FE8")]
		private void BuildFileMap()
		{
		}

		// Token: 0x06006989 RID: 27017 RVA: 0x0002FB98 File Offset: 0x0002DD98
		[Token(Token = "0x6006989")]
		[Address(RVA = "0xB88110", Offset = "0xB88110", VA = "0xB88110", Slot = "6")]
		public bool HasAsset(string assetName)
		{
			return default(bool);
		}

		// Token: 0x0600698A RID: 27018 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600698A")]
		[Address(RVA = "0xB88284", Offset = "0xB88284", VA = "0xB88284", Slot = "7")]
		public string GetExtension(string assetName)
		{
			return null;
		}

		// Token: 0x0600698B RID: 27019 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600698B")]
		[Address(RVA = "0xB882CC", Offset = "0xB882CC", VA = "0xB882CC", Slot = "8")]
		public Stream OpenStream(string assetName)
		{
			return null;
		}

		// Token: 0x0600698C RID: 27020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600698C")]
		[Address(RVA = "0xB8841C", Offset = "0xB8841C", VA = "0xB8841C", Slot = "9")]
		public void RejectAsset(string assetName, IRejectionReason reason)
		{
		}

		// Token: 0x0600698D RID: 27021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600698D")]
		[Address(RVA = "0xB8849C", Offset = "0xB8849C", VA = "0xB8849C", Slot = "10")]
		public void ClearRejections()
		{
		}

		// Token: 0x0600698E RID: 27022 RVA: 0x0002FBB0 File Offset: 0x0002DDB0
		[Token(Token = "0x600698E")]
		[Address(RVA = "0xB8850C", Offset = "0xB8850C", VA = "0xB8850C", Slot = "11")]
		public bool TryGetRejections(List<string> rejectionReasons)
		{
			return default(bool);
		}

		// Token: 0x0400A700 RID: 42752
		[Token(Token = "0x400A700")]
		[FieldOffset(Offset = "0x8")]
		private readonly string _rootDirectory;

		// Token: 0x0400A701 RID: 42753
		[Token(Token = "0x400A701")]
		[FieldOffset(Offset = "0xC")]
		private readonly HashSet<string> _files;

		// Token: 0x0400A702 RID: 42754
		[Token(Token = "0x400A702")]
		[FieldOffset(Offset = "0x10")]
		private IContentValidator <ContentValidator>k__BackingField;

		// Token: 0x0400A703 RID: 42755
		[Token(Token = "0x400A703")]
		[FieldOffset(Offset = "0x14")]
		private readonly RejectedAssetCollection _rejections;
	}
}
