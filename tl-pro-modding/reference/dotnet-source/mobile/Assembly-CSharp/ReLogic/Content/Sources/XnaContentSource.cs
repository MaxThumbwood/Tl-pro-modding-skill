using System;
using System.Collections.Generic;
using System.IO;
using Il2CppDummyDll;

namespace ReLogic.Content.Sources
{
	// Token: 0x02000E18 RID: 3608
	[Token(Token = "0x2000E18")]
	public class XnaContentSource : FileAPI
	{
		// Token: 0x17000B53 RID: 2899
		// (get) Token: 0x0600697A RID: 27002 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600697B RID: 27003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B53")]
		public IContentValidator ContentValidator
		{
			[Token(Token = "0x600697A")]
			[Address(RVA = "0xB87668", Offset = "0xB87668", VA = "0xB87668", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600697B")]
			[Address(RVA = "0xB87670", Offset = "0xB87670", VA = "0xB87670", Slot = "5")]
			set
			{
			}
		}

		// Token: 0x0600697C RID: 27004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600697C")]
		[Address(RVA = "0xB87678", Offset = "0xB87678", VA = "0xB87678")]
		public XnaContentSource(string rootDirectory)
		{
		}

		// Token: 0x0600697D RID: 27005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600697D")]
		[Address(RVA = "0xB87804", Offset = "0xB87804", VA = "0xB87804")]
		private void BuildFileMap()
		{
		}

		// Token: 0x0600697E RID: 27006 RVA: 0x0002FB68 File Offset: 0x0002DD68
		[Token(Token = "0x600697E")]
		[Address(RVA = "0xB8792C", Offset = "0xB8792C", VA = "0xB8792C", Slot = "6")]
		public bool HasAsset(string assetName)
		{
			return default(bool);
		}

		// Token: 0x0600697F RID: 27007 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600697F")]
		[Address(RVA = "0xB87AA0", Offset = "0xB87AA0", VA = "0xB87AA0", Slot = "7")]
		public string GetExtension(string assetName)
		{
			return null;
		}

		// Token: 0x06006980 RID: 27008 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006980")]
		[Address(RVA = "0xB87AE8", Offset = "0xB87AE8", VA = "0xB87AE8", Slot = "8")]
		public Stream OpenStream(string assetName)
		{
			return null;
		}

		// Token: 0x06006981 RID: 27009 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006981")]
		[Address(RVA = "0xB87C38", Offset = "0xB87C38", VA = "0xB87C38")]
		public static string GetTitleLocationPath()
		{
			return null;
		}

		// Token: 0x06006982 RID: 27010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006982")]
		[Address(RVA = "0xB87D34", Offset = "0xB87D34", VA = "0xB87D34", Slot = "9")]
		public void RejectAsset(string assetName, IRejectionReason reason)
		{
		}

		// Token: 0x06006983 RID: 27011 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006983")]
		[Address(RVA = "0xB87DB4", Offset = "0xB87DB4", VA = "0xB87DB4", Slot = "10")]
		public void ClearRejections()
		{
		}

		// Token: 0x06006984 RID: 27012 RVA: 0x0002FB80 File Offset: 0x0002DD80
		[Token(Token = "0x6006984")]
		[Address(RVA = "0xB87E24", Offset = "0xB87E24", VA = "0xB87E24", Slot = "11")]
		public bool TryGetRejections(List<string> rejectionReasons)
		{
			return default(bool);
		}

		// Token: 0x0400A6FC RID: 42748
		[Token(Token = "0x400A6FC")]
		[FieldOffset(Offset = "0x8")]
		private readonly string _rootDirectory;

		// Token: 0x0400A6FD RID: 42749
		[Token(Token = "0x400A6FD")]
		[FieldOffset(Offset = "0xC")]
		private readonly HashSet<string> _files;

		// Token: 0x0400A6FE RID: 42750
		[Token(Token = "0x400A6FE")]
		[FieldOffset(Offset = "0x10")]
		private IContentValidator <ContentValidator>k__BackingField;

		// Token: 0x0400A6FF RID: 42751
		[Token(Token = "0x400A6FF")]
		[FieldOffset(Offset = "0x14")]
		private readonly RejectedAssetCollection _rejections;
	}
}
