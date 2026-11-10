using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Terraria.IO
{
	// Token: 0x0200066A RID: 1642
	[Token(Token = "0x200066A")]
	public class FavoritesFile
	{
		// Token: 0x06003F7C RID: 16252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F7C")]
		[Address(RVA = "0x1E8519C", Offset = "0x1E8519C", VA = "0x1E8519C")]
		public FavoritesFile(string path, bool isCloud)
		{
		}

		// Token: 0x06003F7D RID: 16253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F7D")]
		[Address(RVA = "0x1E85244", Offset = "0x1E85244", VA = "0x1E85244")]
		public void SaveFavorite(FileData fileData)
		{
		}

		// Token: 0x06003F7E RID: 16254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F7E")]
		[Address(RVA = "0x1E85670", Offset = "0x1E85670", VA = "0x1E85670")]
		public void ClearEntry(FileData fileData)
		{
		}

		// Token: 0x06003F7F RID: 16255 RVA: 0x0001F3B0 File Offset: 0x0001D5B0
		[Token(Token = "0x6003F7F")]
		[Address(RVA = "0x1E857E4", Offset = "0x1E857E4", VA = "0x1E857E4")]
		public bool IsFavorite(FileData fileData)
		{
			return default(bool);
		}

		// Token: 0x06003F80 RID: 16256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F80")]
		[Address(RVA = "0x1E854D8", Offset = "0x1E854D8", VA = "0x1E854D8")]
		public void Save()
		{
		}

		// Token: 0x06003F81 RID: 16257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F81")]
		[Address(RVA = "0x1E85984", Offset = "0x1E85984", VA = "0x1E85984")]
		public void Load()
		{
		}

		// Token: 0x04004966 RID: 18790
		[Token(Token = "0x4004966")]
		[FieldOffset(Offset = "0x8")]
		public readonly string Path;

		// Token: 0x04004967 RID: 18791
		[Token(Token = "0x4004967")]
		[FieldOffset(Offset = "0xC")]
		public readonly bool IsCloudSave;

		// Token: 0x04004968 RID: 18792
		[Token(Token = "0x4004968")]
		[FieldOffset(Offset = "0x10")]
		private Dictionary<string, Dictionary<string, bool>> _data;
	}
}
