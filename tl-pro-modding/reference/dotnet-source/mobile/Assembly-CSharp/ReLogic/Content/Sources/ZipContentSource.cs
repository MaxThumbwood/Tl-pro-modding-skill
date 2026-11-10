using System;
using System.Collections.Generic;
using System.IO;
using Il2CppDummyDll;
using Ionic.Zip;

namespace ReLogic.Content.Sources
{
	// Token: 0x02000E1A RID: 3610
	[Token(Token = "0x2000E1A")]
	public class ZipContentSource : FileAPI, GUIControllerItem
	{
		// Token: 0x17000B55 RID: 2901
		// (get) Token: 0x0600698F RID: 27023 RVA: 0x0002FBC8 File Offset: 0x0002DDC8
		[Token(Token = "0x17000B55")]
		public int EntryCount
		{
			[Token(Token = "0x600698F")]
			[Address(RVA = "0xB88534", Offset = "0xB88534", VA = "0xB88534")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000B56 RID: 2902
		// (get) Token: 0x06006990 RID: 27024 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006991 RID: 27025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B56")]
		public IContentValidator ContentValidator
		{
			[Token(Token = "0x6006990")]
			[Address(RVA = "0xB88598", Offset = "0xB88598", VA = "0xB88598", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6006991")]
			[Address(RVA = "0xB885A0", Offset = "0xB885A0", VA = "0xB885A0", Slot = "5")]
			set
			{
			}
		}

		// Token: 0x06006992 RID: 27026 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006992")]
		[Address(RVA = "0xB885A8", Offset = "0xB885A8", VA = "0xB885A8")]
		public ZipContentSource(string path)
		{
		}

		// Token: 0x06006993 RID: 27027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006993")]
		[Address(RVA = "0xB88604", Offset = "0xB88604", VA = "0xB88604")]
		public ZipContentSource(string path, string contentDir)
		{
		}

		// Token: 0x06006994 RID: 27028 RVA: 0x0002FBE0 File Offset: 0x0002DDE0
		[Token(Token = "0x6006994")]
		[Address(RVA = "0xB88FD8", Offset = "0xB88FD8", VA = "0xB88FD8", Slot = "6")]
		public bool HasAsset(string assetName)
		{
			return default(bool);
		}

		// Token: 0x06006995 RID: 27029 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006995")]
		[Address(RVA = "0xB890D4", Offset = "0xB890D4", VA = "0xB890D4", Slot = "7")]
		public string GetExtension(string assetName)
		{
			return null;
		}

		// Token: 0x06006996 RID: 27030 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006996")]
		[Address(RVA = "0xB89204", Offset = "0xB89204", VA = "0xB89204", Slot = "8")]
		public Stream OpenStream(string assetName)
		{
			return null;
		}

		// Token: 0x06006997 RID: 27031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006997")]
		[Address(RVA = "0xB88A20", Offset = "0xB88A20", VA = "0xB88A20")]
		private void BuildExtensionFreeEntryList()
		{
		}

		// Token: 0x06006998 RID: 27032 RVA: 0x0002FBF8 File Offset: 0x0002DDF8
		[Token(Token = "0x6006998")]
		[Address(RVA = "0xB88840", Offset = "0xB88840", VA = "0xB88840")]
		private static bool ZipPathContainsInvalidCharacters(string path)
		{
			return default(bool);
		}

		// Token: 0x06006999 RID: 27033 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006999")]
		[Address(RVA = "0xB888EC", Offset = "0xB888EC", VA = "0xB888EC")]
		private static string CleanZipPath(string path)
		{
			return null;
		}

		// Token: 0x0600699A RID: 27034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600699A")]
		[Address(RVA = "0xB89364", Offset = "0xB89364", VA = "0xB89364", Slot = "13")]
		protected virtual void Dispose(bool disposing)
		{
		}

		// Token: 0x0600699B RID: 27035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600699B")]
		[Address(RVA = "0xB89404", Offset = "0xB89404", VA = "0xB89404", Slot = "12")]
		public void Dispose()
		{
		}

		// Token: 0x0600699C RID: 27036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600699C")]
		[Address(RVA = "0xB89418", Offset = "0xB89418", VA = "0xB89418", Slot = "9")]
		public void RejectAsset(string assetName, IRejectionReason reason)
		{
		}

		// Token: 0x0600699D RID: 27037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600699D")]
		[Address(RVA = "0xB89498", Offset = "0xB89498", VA = "0xB89498", Slot = "10")]
		public void ClearRejections()
		{
		}

		// Token: 0x0600699E RID: 27038 RVA: 0x0002FC10 File Offset: 0x0002DE10
		[Token(Token = "0x600699E")]
		[Address(RVA = "0xB89508", Offset = "0xB89508", VA = "0xB89508", Slot = "11")]
		public bool TryGetRejections(List<string> rejectionReasons)
		{
			return default(bool);
		}

		// Token: 0x0600699F RID: 27039 RVA: 0x0002FC28 File Offset: 0x0002DE28
		[Token(Token = "0x600699F")]
		[Address(RVA = "0xB89530", Offset = "0xB89530", VA = "0xB89530")]
		private bool <BuildExtensionFreeEntryList>b__14_0(ZipEntry entry)
		{
			return default(bool);
		}

		// Token: 0x0400A704 RID: 42756
		[Token(Token = "0x400A704")]
		[FieldOffset(Offset = "0x8")]
		private IContentValidator <ContentValidator>k__BackingField;

		// Token: 0x0400A705 RID: 42757
		[Token(Token = "0x400A705")]
		[FieldOffset(Offset = "0xC")]
		private readonly ZipFile _zipFile;

		// Token: 0x0400A706 RID: 42758
		[Token(Token = "0x400A706")]
		[FieldOffset(Offset = "0x10")]
		private readonly Dictionary<string, ZipEntry> _entries;

		// Token: 0x0400A707 RID: 42759
		[Token(Token = "0x400A707")]
		[FieldOffset(Offset = "0x14")]
		private readonly string _basePath;

		// Token: 0x0400A708 RID: 42760
		[Token(Token = "0x400A708")]
		[FieldOffset(Offset = "0x18")]
		private bool _isDisposed;

		// Token: 0x0400A709 RID: 42761
		[Token(Token = "0x400A709")]
		[FieldOffset(Offset = "0x1C")]
		private readonly RejectedAssetCollection _rejections;
	}
}
