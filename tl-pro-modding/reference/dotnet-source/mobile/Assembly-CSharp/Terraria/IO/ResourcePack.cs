using System;
using System.IO;
using Il2CppDummyDll;
using Ionic.Zip;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content.Sources;

namespace Terraria.IO
{
	// Token: 0x02000673 RID: 1651
	[Token(Token = "0x2000673")]
	public class ResourcePack
	{
		// Token: 0x170007F9 RID: 2041
		// (get) Token: 0x06003FC0 RID: 16320 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007F9")]
		public Texture2D Icon
		{
			[Token(Token = "0x6003FC0")]
			[Address(RVA = "0x1E899B0", Offset = "0x1E899B0", VA = "0x1E899B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170007FA RID: 2042
		// (get) Token: 0x06003FC1 RID: 16321 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06003FC2 RID: 16322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007FA")]
		public string Name
		{
			[Token(Token = "0x6003FC1")]
			[Address(RVA = "0x1E89D3C", Offset = "0x1E89D3C", VA = "0x1E89D3C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6003FC2")]
			[Address(RVA = "0x1E89D44", Offset = "0x1E89D44", VA = "0x1E89D44")]
			private set
			{
			}
		}

		// Token: 0x170007FB RID: 2043
		// (get) Token: 0x06003FC3 RID: 16323 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06003FC4 RID: 16324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007FB")]
		public string Description
		{
			[Token(Token = "0x6003FC3")]
			[Address(RVA = "0x1E89D4C", Offset = "0x1E89D4C", VA = "0x1E89D4C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6003FC4")]
			[Address(RVA = "0x1E89D54", Offset = "0x1E89D54", VA = "0x1E89D54")]
			private set
			{
			}
		}

		// Token: 0x170007FC RID: 2044
		// (get) Token: 0x06003FC5 RID: 16325 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06003FC6 RID: 16326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007FC")]
		public string Author
		{
			[Token(Token = "0x6003FC5")]
			[Address(RVA = "0x1E89D5C", Offset = "0x1E89D5C", VA = "0x1E89D5C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6003FC6")]
			[Address(RVA = "0x1E89D64", Offset = "0x1E89D64", VA = "0x1E89D64")]
			private set
			{
			}
		}

		// Token: 0x170007FD RID: 2045
		// (get) Token: 0x06003FC7 RID: 16327 RVA: 0x0001F4A0 File Offset: 0x0001D6A0
		// (set) Token: 0x06003FC8 RID: 16328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007FD")]
		public ResourcePackVersion Version
		{
			[Token(Token = "0x6003FC7")]
			[Address(RVA = "0x1E89D6C", Offset = "0x1E89D6C", VA = "0x1E89D6C")]
			get
			{
				return default(ResourcePackVersion);
			}
			[Token(Token = "0x6003FC8")]
			[Address(RVA = "0x1E89D80", Offset = "0x1E89D80", VA = "0x1E89D80")]
			private set
			{
			}
		}

		// Token: 0x170007FE RID: 2046
		// (get) Token: 0x06003FC9 RID: 16329 RVA: 0x0001F4B8 File Offset: 0x0001D6B8
		// (set) Token: 0x06003FCA RID: 16330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007FE")]
		public bool IsEnabled
		{
			[Token(Token = "0x6003FC9")]
			[Address(RVA = "0x1E89D8C", Offset = "0x1E89D8C", VA = "0x1E89D8C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003FCA")]
			[Address(RVA = "0x1E89D94", Offset = "0x1E89D94", VA = "0x1E89D94")]
			set
			{
			}
		}

		// Token: 0x170007FF RID: 2047
		// (get) Token: 0x06003FCB RID: 16331 RVA: 0x0001F4D0 File Offset: 0x0001D6D0
		// (set) Token: 0x06003FCC RID: 16332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007FF")]
		public int SortingOrder
		{
			[Token(Token = "0x6003FCB")]
			[Address(RVA = "0x1E89D9C", Offset = "0x1E89D9C", VA = "0x1E89D9C")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6003FCC")]
			[Address(RVA = "0x1E89DA4", Offset = "0x1E89DA4", VA = "0x1E89DA4")]
			set
			{
			}
		}

		// Token: 0x06003FCD RID: 16333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FCD")]
		[Address(RVA = "0x1E89DAC", Offset = "0x1E89DAC", VA = "0x1E89DAC")]
		public ResourcePack(IServiceProvider services, string path)
		{
		}

		// Token: 0x06003FCE RID: 16334 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FCE")]
		[Address(RVA = "0x1E8A548", Offset = "0x1E8A548", VA = "0x1E8A548")]
		public IContentSource GetContentSource()
		{
			return null;
		}

		// Token: 0x06003FCF RID: 16335 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FCF")]
		[Address(RVA = "0x1E899D4", Offset = "0x1E899D4", VA = "0x1E899D4")]
		private Texture2D CreateIcon()
		{
			return null;
		}

		// Token: 0x06003FD0 RID: 16336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FD0")]
		[Address(RVA = "0x1E89F28", Offset = "0x1E89F28", VA = "0x1E89F28")]
		private void LoadManifest()
		{
		}

		// Token: 0x06003FD1 RID: 16337 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FD1")]
		[Address(RVA = "0x1E8A7F8", Offset = "0x1E8A7F8", VA = "0x1E8A7F8")]
		private Stream OpenStream(string fileName)
		{
			return null;
		}

		// Token: 0x06003FD2 RID: 16338 RVA: 0x0001F4E8 File Offset: 0x0001D6E8
		[Token(Token = "0x6003FD2")]
		[Address(RVA = "0x1E8A74C", Offset = "0x1E8A74C", VA = "0x1E8A74C")]
		private bool HasFile(string fileName)
		{
			return default(bool);
		}

		// Token: 0x0400498B RID: 18827
		[Token(Token = "0x400498B")]
		[FieldOffset(Offset = "0x8")]
		public readonly string FullPath;

		// Token: 0x0400498C RID: 18828
		[Token(Token = "0x400498C")]
		[FieldOffset(Offset = "0xC")]
		public readonly string FileName;

		// Token: 0x0400498D RID: 18829
		[Token(Token = "0x400498D")]
		[FieldOffset(Offset = "0x10")]
		private string <Name>k__BackingField;

		// Token: 0x0400498E RID: 18830
		[Token(Token = "0x400498E")]
		[FieldOffset(Offset = "0x14")]
		private string <Description>k__BackingField;

		// Token: 0x0400498F RID: 18831
		[Token(Token = "0x400498F")]
		[FieldOffset(Offset = "0x18")]
		private string <Author>k__BackingField;

		// Token: 0x04004990 RID: 18832
		[Token(Token = "0x4004990")]
		[FieldOffset(Offset = "0x1C")]
		private ResourcePackVersion <Version>k__BackingField;

		// Token: 0x04004991 RID: 18833
		[Token(Token = "0x4004991")]
		[FieldOffset(Offset = "0x24")]
		private bool <IsEnabled>k__BackingField;

		// Token: 0x04004992 RID: 18834
		[Token(Token = "0x4004992")]
		[FieldOffset(Offset = "0x28")]
		private int <SortingOrder>k__BackingField;

		// Token: 0x04004993 RID: 18835
		[Token(Token = "0x4004993")]
		[FieldOffset(Offset = "0x2C")]
		private readonly IServiceProvider _services;

		// Token: 0x04004994 RID: 18836
		[Token(Token = "0x4004994")]
		[FieldOffset(Offset = "0x30")]
		private readonly bool _isCompressed;

		// Token: 0x04004995 RID: 18837
		[Token(Token = "0x4004995")]
		[FieldOffset(Offset = "0x34")]
		private readonly ZipFile _zipFile;

		// Token: 0x04004996 RID: 18838
		[Token(Token = "0x4004996")]
		[FieldOffset(Offset = "0x38")]
		private Texture2D _icon;

		// Token: 0x04004997 RID: 18839
		[Token(Token = "0x4004997")]
		[FieldOffset(Offset = "0x3C")]
		private IContentSource _contentSource;

		// Token: 0x04004998 RID: 18840
		[Token(Token = "0x4004998")]
		private const string ICON_FILE_NAME = "icon.png";

		// Token: 0x04004999 RID: 18841
		[Token(Token = "0x4004999")]
		private const string PACK_FILE_NAME = "pack.json";
	}
}
