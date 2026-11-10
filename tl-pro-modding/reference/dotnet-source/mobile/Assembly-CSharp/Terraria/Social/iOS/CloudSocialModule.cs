using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using Il2CppDummyDll;
using Terraria.Social.Base;

namespace Terraria.Social.iOS
{
	// Token: 0x0200061A RID: 1562
	[Token(Token = "0x200061A")]
	public class CloudSocialModule : CloudSocialModule
	{
		// Token: 0x06003D46 RID: 15686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D46")]
		[Address(RVA = "0x1E635C8", Offset = "0x1E635C8", VA = "0x1E635C8", Slot = "6")]
		public override void Initialize()
		{
		}

		// Token: 0x06003D47 RID: 15687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D47")]
		[Address(RVA = "0x1E63734", Offset = "0x1E63734", VA = "0x1E63734", Slot = "7")]
		public override void Shutdown()
		{
		}

		// Token: 0x06003D48 RID: 15688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D48")]
		[Address(RVA = "0x1E63738", Offset = "0x1E63738", VA = "0x1E63738")]
		public void SyncFiles(string path)
		{
		}

		// Token: 0x06003D49 RID: 15689 RVA: 0x0001E8E8 File Offset: 0x0001CAE8
		[Token(Token = "0x6003D49")]
		[Address(RVA = "0x1E63748", Offset = "0x1E63748", VA = "0x1E63748")]
		public bool HasFinishedSync()
		{
			return default(bool);
		}

		// Token: 0x06003D4A RID: 15690 RVA: 0x0001E900 File Offset: 0x0001CB00
		[Token(Token = "0x6003D4A")]
		[Address(RVA = "0x1E635D4", Offset = "0x1E635D4", VA = "0x1E635D4")]
		public bool IsRequired()
		{
			return default(bool);
		}

		// Token: 0x06003D4B RID: 15691 RVA: 0x0001E918 File Offset: 0x0001CB18
		[Token(Token = "0x6003D4B")]
		[Address(RVA = "0x1E639C0", Offset = "0x1E639C0", VA = "0x1E639C0")]
		public bool IsAvailable()
		{
			return default(bool);
		}

		// Token: 0x06003D4C RID: 15692 RVA: 0x0001E930 File Offset: 0x0001CB30
		[Token(Token = "0x6003D4C")]
		[Address(RVA = "0x1E639C8", Offset = "0x1E639C8", VA = "0x1E639C8")]
		public bool IsConnected()
		{
			return default(bool);
		}

		// Token: 0x06003D4D RID: 15693 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D4D")]
		[Address(RVA = "0x1E639D0", Offset = "0x1E639D0", VA = "0x1E639D0", Slot = "8")]
		public override IEnumerable<string> GetFiles()
		{
			return null;
		}

		// Token: 0x06003D4E RID: 15694 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D4E")]
		[Address(RVA = "0x1E63864", Offset = "0x1E63864", VA = "0x1E63864")]
		public static string GetParentFolderPath(string path, bool includeExtension = true)
		{
			return null;
		}

		// Token: 0x06003D4F RID: 15695 RVA: 0x0001E948 File Offset: 0x0001CB48
		[Token(Token = "0x6003D4F")]
		[Address(RVA = "0x1E63B9C", Offset = "0x1E63B9C", VA = "0x1E63B9C", Slot = "9")]
		public override bool Write(string path, byte[] data, int length)
		{
			return default(bool);
		}

		// Token: 0x06003D50 RID: 15696 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D50")]
		[Address(RVA = "0x1E63CDC", Offset = "0x1E63CDC", VA = "0x1E63CDC", Slot = "11")]
		public override Stream OpenRead(string file)
		{
			return null;
		}

		// Token: 0x06003D51 RID: 15697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D51")]
		[Address(RVA = "0x1E63CE4", Offset = "0x1E63CE4", VA = "0x1E63CE4", Slot = "10")]
		public override void Read(string path, byte[] buffer, int length)
		{
		}

		// Token: 0x06003D52 RID: 15698 RVA: 0x0001E960 File Offset: 0x0001CB60
		[Token(Token = "0x6003D52")]
		[Address(RVA = "0x1E63D4C", Offset = "0x1E63D4C", VA = "0x1E63D4C", Slot = "12")]
		public override bool HasFile(string path)
		{
			return default(bool);
		}

		// Token: 0x06003D53 RID: 15699 RVA: 0x0001E978 File Offset: 0x0001CB78
		[Token(Token = "0x6003D53")]
		[Address(RVA = "0x1E63DD4", Offset = "0x1E63DD4", VA = "0x1E63DD4", Slot = "13")]
		public override int GetFileSize(string path)
		{
			return 0;
		}

		// Token: 0x06003D54 RID: 15700 RVA: 0x0001E990 File Offset: 0x0001CB90
		[Token(Token = "0x6003D54")]
		[Address(RVA = "0x1E63E0C", Offset = "0x1E63E0C", VA = "0x1E63E0C", Slot = "14")]
		public override bool Delete(string path)
		{
			return default(bool);
		}

		// Token: 0x06003D55 RID: 15701 RVA: 0x0001E9A8 File Offset: 0x0001CBA8
		[Token(Token = "0x6003D55")]
		[Address(RVA = "0x1E63E2C", Offset = "0x1E63E2C", VA = "0x1E63E2C", Slot = "15")]
		public override bool Forget(string path)
		{
			return default(bool);
		}

		// Token: 0x06003D56 RID: 15702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D56")]
		[Address(RVA = "0x1E63E34", Offset = "0x1E63E34", VA = "0x1E63E34")]
		public CloudSocialModule()
		{
		}

		// Token: 0x0400482A RID: 18474
		[Token(Token = "0x400482A")]
		[FieldOffset(Offset = "0xC")]
		private string editorRemoteCache;

		// Token: 0x0400482B RID: 18475
		[Token(Token = "0x400482B")]
		[FieldOffset(Offset = "0x10")]
		private string cacheFolder;

		// Token: 0x0400482C RID: 18476
		[Token(Token = "0x400482C")]
		[FieldOffset(Offset = "0x0")]
		private static Regex FileNameRegex;

		// Token: 0x0400482D RID: 18477
		[Token(Token = "0x400482D")]
		[FieldOffset(Offset = "0x14")]
		private string SyncPath;

		// Token: 0x0400482E RID: 18478
		[Token(Token = "0x400482E")]
		[FieldOffset(Offset = "0x18")]
		private DateTime SyncStarted;
	}
}
