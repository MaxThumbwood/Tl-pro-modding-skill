using System;
using Il2CppDummyDll;

namespace Terraria.IO
{
	// Token: 0x0200066B RID: 1643
	[Token(Token = "0x200066B")]
	public abstract class FileData
	{
		// Token: 0x170007F4 RID: 2036
		// (get) Token: 0x06003F82 RID: 16258 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007F4")]
		public string Path
		{
			[Token(Token = "0x6003F82")]
			[Address(RVA = "0x1E85CF0", Offset = "0x1E85CF0", VA = "0x1E85CF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170007F5 RID: 2037
		// (get) Token: 0x06003F83 RID: 16259 RVA: 0x0001F3C8 File Offset: 0x0001D5C8
		[Token(Token = "0x170007F5")]
		public bool IsCloudSave
		{
			[Token(Token = "0x6003F83")]
			[Address(RVA = "0x1E85CF8", Offset = "0x1E85CF8", VA = "0x1E85CF8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170007F6 RID: 2038
		// (get) Token: 0x06003F84 RID: 16260 RVA: 0x0001F3E0 File Offset: 0x0001D5E0
		[Token(Token = "0x170007F6")]
		public bool IsFavorite
		{
			[Token(Token = "0x6003F84")]
			[Address(RVA = "0x1E85D00", Offset = "0x1E85D00", VA = "0x1E85D00")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06003F85 RID: 16261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F85")]
		[Address(RVA = "0x1E85D08", Offset = "0x1E85D08", VA = "0x1E85D08")]
		protected FileData(string type)
		{
		}

		// Token: 0x06003F86 RID: 16262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F86")]
		[Address(RVA = "0x1E85D24", Offset = "0x1E85D24", VA = "0x1E85D24")]
		protected FileData(string type, string path, bool isCloud)
		{
		}

		// Token: 0x06003F87 RID: 16263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F87")]
		[Address(RVA = "0x1E85DF4", Offset = "0x1E85DF4", VA = "0x1E85DF4")]
		public void UpdatePath(string newPath)
		{
		}

		// Token: 0x06003F88 RID: 16264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F88")]
		[Address(RVA = "0x1E85DFC", Offset = "0x1E85DFC", VA = "0x1E85DFC")]
		public void ToggleFavorite()
		{
		}

		// Token: 0x06003F89 RID: 16265 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F89")]
		[Address(RVA = "0x1E85464", Offset = "0x1E85464", VA = "0x1E85464")]
		public string GetFileName(bool includeExtension = true)
		{
			return null;
		}

		// Token: 0x06003F8A RID: 16266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F8A")]
		[Address(RVA = "0x1E85EB4", Offset = "0x1E85EB4", VA = "0x1E85EB4")]
		public void SetFavorite(bool favorite, bool saveChanges = true)
		{
		}

		// Token: 0x06003F8B RID: 16267
		[Token(Token = "0x6003F8B")]
		public abstract void SetAsActive();

		// Token: 0x06003F8C RID: 16268
		[Token(Token = "0x6003F8C")]
		public abstract void MoveToCloud();

		// Token: 0x06003F8D RID: 16269
		[Token(Token = "0x6003F8D")]
		public abstract void MoveToLocal();

		// Token: 0x04004969 RID: 18793
		[Token(Token = "0x4004969")]
		[FieldOffset(Offset = "0x8")]
		protected string _path;

		// Token: 0x0400496A RID: 18794
		[Token(Token = "0x400496A")]
		[FieldOffset(Offset = "0xC")]
		protected bool _isCloudSave;

		// Token: 0x0400496B RID: 18795
		[Token(Token = "0x400496B")]
		[FieldOffset(Offset = "0x10")]
		public FileMetadata Metadata;

		// Token: 0x0400496C RID: 18796
		[Token(Token = "0x400496C")]
		[FieldOffset(Offset = "0x14")]
		public string Name;

		// Token: 0x0400496D RID: 18797
		[Token(Token = "0x400496D")]
		[FieldOffset(Offset = "0x18")]
		public readonly string Type;

		// Token: 0x0400496E RID: 18798
		[Token(Token = "0x400496E")]
		[FieldOffset(Offset = "0x1C")]
		protected bool _isFavorite;
	}
}
