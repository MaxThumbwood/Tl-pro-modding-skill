using System;
using Il2CppDummyDll;

namespace Terraria.Map
{
	// Token: 0x02000813 RID: 2067
	[Token(Token = "0x2000813")]
	public struct MapTile
	{
		// Token: 0x17000871 RID: 2161
		// (get) Token: 0x060046AE RID: 18094 RVA: 0x000217F8 File Offset: 0x0001F9F8
		// (set) Token: 0x060046AF RID: 18095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000871")]
		public bool IsChanged
		{
			[Token(Token = "0x60046AE")]
			[Address(RVA = "0x5A112C", Offset = "0x5A112C", VA = "0x5A112C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60046AF")]
			[Address(RVA = "0x5A1140", Offset = "0x5A1140", VA = "0x5A1140")]
			set
			{
			}
		}

		// Token: 0x17000872 RID: 2162
		// (get) Token: 0x060046B0 RID: 18096 RVA: 0x00021810 File Offset: 0x0001FA10
		// (set) Token: 0x060046B1 RID: 18097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000872")]
		public bool UpdateQueued
		{
			[Token(Token = "0x60046B0")]
			[Address(RVA = "0x5A1158", Offset = "0x5A1158", VA = "0x5A1158")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60046B1")]
			[Address(RVA = "0x5A1164", Offset = "0x5A1164", VA = "0x5A1164")]
			set
			{
			}
		}

		// Token: 0x17000873 RID: 2163
		// (get) Token: 0x060046B2 RID: 18098 RVA: 0x00021828 File Offset: 0x0001FA28
		// (set) Token: 0x060046B3 RID: 18099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000873")]
		public byte Color
		{
			[Token(Token = "0x60046B2")]
			[Address(RVA = "0x5A117C", Offset = "0x5A117C", VA = "0x5A117C")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60046B3")]
			[Address(RVA = "0x5A1188", Offset = "0x5A1188", VA = "0x5A1188")]
			set
			{
			}
		}

		// Token: 0x060046B4 RID: 18100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046B4")]
		[Address(RVA = "0x5A11A0", Offset = "0x5A11A0", VA = "0x5A11A0")]
		private MapTile(ushort type, byte light, byte extraData)
		{
		}

		// Token: 0x060046B5 RID: 18101 RVA: 0x00021840 File Offset: 0x0001FA40
		[Token(Token = "0x60046B5")]
		[Address(RVA = "0x5A11B0", Offset = "0x5A11B0", VA = "0x5A11B0")]
		public bool Equals(ref MapTile other)
		{
			return default(bool);
		}

		// Token: 0x060046B6 RID: 18102 RVA: 0x00021858 File Offset: 0x0001FA58
		[Token(Token = "0x60046B6")]
		[Address(RVA = "0x5A11F4", Offset = "0x5A11F4", VA = "0x5A11F4")]
		public bool EqualsWithoutLight(ref MapTile other)
		{
			return default(bool);
		}

		// Token: 0x060046B7 RID: 18103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046B7")]
		[Address(RVA = "0x5A1228", Offset = "0x5A1228", VA = "0x5A1228")]
		public void Clear()
		{
		}

		// Token: 0x060046B8 RID: 18104 RVA: 0x00021870 File Offset: 0x0001FA70
		[Token(Token = "0x60046B8")]
		[Address(RVA = "0x5A1234", Offset = "0x5A1234", VA = "0x5A1234")]
		public MapTile WithLight(byte light)
		{
			return default(MapTile);
		}

		// Token: 0x060046B9 RID: 18105 RVA: 0x00021888 File Offset: 0x0001FA88
		[Token(Token = "0x60046B9")]
		[Address(RVA = "0x5A124C", Offset = "0x5A124C", VA = "0x5A124C")]
		public static MapTile Create(ushort type, byte light, byte color)
		{
			return default(MapTile);
		}

		// Token: 0x04008D9E RID: 36254
		[Token(Token = "0x4008D9E")]
		[FieldOffset(Offset = "0x0")]
		public ushort Type;

		// Token: 0x04008D9F RID: 36255
		[Token(Token = "0x4008D9F")]
		[FieldOffset(Offset = "0x2")]
		public byte Light;

		// Token: 0x04008DA0 RID: 36256
		[Token(Token = "0x4008DA0")]
		[FieldOffset(Offset = "0x3")]
		public byte _extraData;
	}
}
