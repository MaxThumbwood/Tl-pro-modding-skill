using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace Terraria.WorldBuilding
{
	// Token: 0x020005C2 RID: 1474
	[Token(Token = "0x20005C2")]
	public class WorldManifest
	{
		// Token: 0x17000782 RID: 1922
		// (get) Token: 0x06003B64 RID: 15204 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06003B65 RID: 15205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000782")]
		public string Version
		{
			[Token(Token = "0x6003B64")]
			[Address(RVA = "0x1E103F8", Offset = "0x1E103F8", VA = "0x1E103F8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6003B65")]
			[Address(RVA = "0x1E10400", Offset = "0x1E10400", VA = "0x1E10400")]
			set
			{
			}
		}

		// Token: 0x17000783 RID: 1923
		// (get) Token: 0x06003B66 RID: 15206 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06003B67 RID: 15207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000783")]
		public string GitSHA
		{
			[Token(Token = "0x6003B66")]
			[Address(RVA = "0x1E10408", Offset = "0x1E10408", VA = "0x1E10408")]
			get
			{
				return null;
			}
			[Token(Token = "0x6003B67")]
			[Address(RVA = "0x1E10410", Offset = "0x1E10410", VA = "0x1E10410")]
			set
			{
			}
		}

		// Token: 0x17000784 RID: 1924
		// (get) Token: 0x06003B68 RID: 15208 RVA: 0x0001DEB0 File Offset: 0x0001C0B0
		[Token(Token = "0x17000784")]
		public uint? FinalHash
		{
			[Token(Token = "0x6003B68")]
			[Address(RVA = "0x1E10418", Offset = "0x1E10418", VA = "0x1E10418")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003B69 RID: 15209 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B69")]
		[Address(RVA = "0x1E104F0", Offset = "0x1E104F0", VA = "0x1E104F0")]
		public static WorldManifest Deserialize(string json)
		{
			return null;
		}

		// Token: 0x06003B6A RID: 15210 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B6A")]
		[Address(RVA = "0x1E107A4", Offset = "0x1E107A4", VA = "0x1E107A4")]
		public string Serialize()
		{
			return null;
		}

		// Token: 0x06003B6B RID: 15211 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B6B")]
		[Address(RVA = "0x1E10850", Offset = "0x1E10850", VA = "0x1E10850")]
		public WorldManifest Clone()
		{
			return null;
		}

		// Token: 0x06003B6C RID: 15212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B6C")]
		[Address(RVA = "0x1E1070C", Offset = "0x1E1070C", VA = "0x1E1070C")]
		public WorldManifest()
		{
		}

		// Token: 0x0400472A RID: 18218
		[Token(Token = "0x400472A")]
		[FieldOffset(Offset = "0x8")]
		private string <Version>k__BackingField;

		// Token: 0x0400472B RID: 18219
		[Token(Token = "0x400472B")]
		[FieldOffset(Offset = "0xC")]
		private string <GitSHA>k__BackingField;

		// Token: 0x0400472C RID: 18220
		[Token(Token = "0x400472C")]
		[FieldOffset(Offset = "0x10")]
		public List<GenPassResult> GenPassResults;

		// Token: 0x0400472D RID: 18221
		[Token(Token = "0x400472D")]
		[FieldOffset(Offset = "0x0")]
		public static readonly JsonSerializerSettings SerializerSettings;
	}
}
