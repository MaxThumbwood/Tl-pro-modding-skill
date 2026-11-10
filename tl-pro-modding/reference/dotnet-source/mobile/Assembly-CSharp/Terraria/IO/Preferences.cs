using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace Terraria.IO
{
	// Token: 0x02000671 RID: 1649
	[Token(Token = "0x2000671")]
	public class Preferences
	{
		// Token: 0x1400003D RID: 61
		// (add) Token: 0x06003FAC RID: 16300 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06003FAD RID: 16301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400003D")]
		public event Action<Preferences> OnSave
		{
			[Token(Token = "0x6003FAC")]
			[Address(RVA = "0x1E87F78", Offset = "0x1E87F78", VA = "0x1E87F78")]
			add
			{
			}
			[Token(Token = "0x6003FAD")]
			[Address(RVA = "0x1E88040", Offset = "0x1E88040", VA = "0x1E88040")]
			remove
			{
			}
		}

		// Token: 0x1400003E RID: 62
		// (add) Token: 0x06003FAE RID: 16302 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06003FAF RID: 16303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400003E")]
		public event Action<Preferences> OnLoad
		{
			[Token(Token = "0x6003FAE")]
			[Address(RVA = "0x1E88108", Offset = "0x1E88108", VA = "0x1E88108")]
			add
			{
			}
			[Token(Token = "0x6003FAF")]
			[Address(RVA = "0x1E881D0", Offset = "0x1E881D0", VA = "0x1E881D0")]
			remove
			{
			}
		}

		// Token: 0x1400003F RID: 63
		// (add) Token: 0x06003FB0 RID: 16304 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06003FB1 RID: 16305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400003F")]
		public event Preferences.TextProcessAction OnProcessText
		{
			[Token(Token = "0x6003FB0")]
			[Address(RVA = "0x1E88298", Offset = "0x1E88298", VA = "0x1E88298")]
			add
			{
			}
			[Token(Token = "0x6003FB1")]
			[Address(RVA = "0x1E88348", Offset = "0x1E88348", VA = "0x1E88348")]
			remove
			{
			}
		}

		// Token: 0x06003FB2 RID: 16306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FB2")]
		[Address(RVA = "0x1E883F8", Offset = "0x1E883F8", VA = "0x1E883F8")]
		public Preferences(string path, bool parseAllTypes = false, bool useBson = false)
		{
		}

		// Token: 0x06003FB3 RID: 16307 RVA: 0x0001F458 File Offset: 0x0001D658
		[Token(Token = "0x6003FB3")]
		[Address(RVA = "0x1E885A4", Offset = "0x1E885A4", VA = "0x1E885A4")]
		public bool Load()
		{
			return default(bool);
		}

		// Token: 0x06003FB4 RID: 16308 RVA: 0x0001F470 File Offset: 0x0001D670
		[Token(Token = "0x6003FB4")]
		[Address(RVA = "0x1E88CCC", Offset = "0x1E88CCC", VA = "0x1E88CCC")]
		public bool Save(bool canCreateFile = true)
		{
			return default(bool);
		}

		// Token: 0x06003FB5 RID: 16309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FB5")]
		[Address(RVA = "0x1E894A0", Offset = "0x1E894A0", VA = "0x1E894A0")]
		public void Clear()
		{
		}

		// Token: 0x06003FB6 RID: 16310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FB6")]
		[Address(RVA = "0x1E89504", Offset = "0x1E89504", VA = "0x1E89504")]
		public void Put(string name, object value)
		{
		}

		// Token: 0x06003FB7 RID: 16311 RVA: 0x0001F488 File Offset: 0x0001D688
		[Token(Token = "0x6003FB7")]
		[Address(RVA = "0x1E89648", Offset = "0x1E89648", VA = "0x1E89648")]
		public bool Contains(string name)
		{
			return default(bool);
		}

		// Token: 0x06003FB8 RID: 16312 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FB8")]
		public T Get<T>(string name, T defaultValue)
		{
			return null;
		}

		// Token: 0x06003FB9 RID: 16313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FB9")]
		public void Get<T>(string name, ref T currentValue)
		{
		}

		// Token: 0x06003FBA RID: 16314 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FBA")]
		[Address(RVA = "0x1E89778", Offset = "0x1E89778", VA = "0x1E89778")]
		public List<string> GetAllKeys()
		{
			return null;
		}

		// Token: 0x06003FBB RID: 16315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FBB")]
		[Address(RVA = "0x1E89800", Offset = "0x1E89800", VA = "0x1E89800")]
		public void Clear(string name)
		{
		}

		// Token: 0x04004982 RID: 18818
		[Token(Token = "0x4004982")]
		[FieldOffset(Offset = "0x8")]
		private Dictionary<string, object> _data;

		// Token: 0x04004983 RID: 18819
		[Token(Token = "0x4004983")]
		[FieldOffset(Offset = "0xC")]
		private readonly string _path;

		// Token: 0x04004984 RID: 18820
		[Token(Token = "0x4004984")]
		[FieldOffset(Offset = "0x10")]
		private readonly JsonSerializerSettings _serializerSettings;

		// Token: 0x04004985 RID: 18821
		[Token(Token = "0x4004985")]
		[FieldOffset(Offset = "0x14")]
		public readonly bool UseBson;

		// Token: 0x04004986 RID: 18822
		[Token(Token = "0x4004986")]
		[FieldOffset(Offset = "0x18")]
		private readonly object _lock;

		// Token: 0x04004987 RID: 18823
		[Token(Token = "0x4004987")]
		[FieldOffset(Offset = "0x1C")]
		public bool AutoSave;

		// Token: 0x02000672 RID: 1650
		// (Invoke) Token: 0x06003FBD RID: 16317
		[Token(Token = "0x2000672")]
		public delegate void TextProcessAction(ref string text);
	}
}
