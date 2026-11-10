using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.DataStructures;

namespace Terraria
{
	// Token: 0x02000501 RID: 1281
	[Token(Token = "0x2000501")]
	public struct Tile
	{
		// Token: 0x060032B0 RID: 12976 RVA: 0x00018828 File Offset: 0x00016A28
		[Token(Token = "0x60032B0")]
		[Address(RVA = "0x1A0E79C", Offset = "0x1A0E79C", VA = "0x1A0E79C")]
		public static bool operator ==(Tile a, Tile b)
		{
			return default(bool);
		}

		// Token: 0x060032B1 RID: 12977 RVA: 0x00018840 File Offset: 0x00016A40
		[Token(Token = "0x60032B1")]
		[Address(RVA = "0x1A0E7AC", Offset = "0x1A0E7AC", VA = "0x1A0E7AC")]
		public static bool operator !=(Tile a, Tile b)
		{
			return default(bool);
		}

		// Token: 0x060032B2 RID: 12978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032B2")]
		[Address(RVA = "0x1A0E7B8", Offset = "0x1A0E7B8", VA = "0x1A0E7B8")]
		[MethodImpl(256)]
		public Tile(int tileOffset)
		{
		}

		// Token: 0x170006E2 RID: 1762
		// (get) Token: 0x060032B3 RID: 12979 RVA: 0x00018858 File Offset: 0x00016A58
		[Token(Token = "0x170006E2")]
		public bool IsLoaded
		{
			[Token(Token = "0x60032B3")]
			[Address(RVA = "0x1A0E7C0", Offset = "0x1A0E7C0", VA = "0x1A0E7C0")]
			[MethodImpl(256)]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060032B4 RID: 12980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032B4")]
		[Address(RVA = "0x1A0E870", Offset = "0x1A0E870", VA = "0x1A0E870")]
		[MethodImpl(256)]
		public void ReregisterTile()
		{
		}

		// Token: 0x170006E3 RID: 1763
		// (get) Token: 0x060032B5 RID: 12981 RVA: 0x00018870 File Offset: 0x00016A70
		// (set) Token: 0x060032B6 RID: 12982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006E3")]
		public ushort type
		{
			[Token(Token = "0x60032B5")]
			[Address(RVA = "0x1A0E984", Offset = "0x1A0E984", VA = "0x1A0E984")]
			[MethodImpl(256)]
			get
			{
				return 0;
			}
			[Token(Token = "0x60032B6")]
			[Address(RVA = "0x1A0E9B8", Offset = "0x1A0E9B8", VA = "0x1A0E9B8")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x060032B7 RID: 12983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032B7")]
		[Address(RVA = "0x1A0EA98", Offset = "0x1A0EA98", VA = "0x1A0EA98")]
		public void SetType(ushort type)
		{
		}

		// Token: 0x170006E4 RID: 1764
		// (get) Token: 0x060032B8 RID: 12984 RVA: 0x00018888 File Offset: 0x00016A88
		// (set) Token: 0x060032B9 RID: 12985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006E4")]
		public ushort wall
		{
			[Token(Token = "0x60032B8")]
			[Address(RVA = "0x1A0EB08", Offset = "0x1A0EB08", VA = "0x1A0EB08")]
			[MethodImpl(256)]
			get
			{
				return 0;
			}
			[Token(Token = "0x60032B9")]
			[Address(RVA = "0x1A0EB30", Offset = "0x1A0EB30", VA = "0x1A0EB30")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x060032BA RID: 12986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032BA")]
		[Address(RVA = "0x1A0EB58", Offset = "0x1A0EB58", VA = "0x1A0EB58")]
		[MethodImpl(256)]
		public void SetWall(ushort wall)
		{
		}

		// Token: 0x170006E5 RID: 1765
		// (get) Token: 0x060032BB RID: 12987 RVA: 0x000188A0 File Offset: 0x00016AA0
		// (set) Token: 0x060032BC RID: 12988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006E5")]
		public byte liquid
		{
			[Token(Token = "0x60032BB")]
			[Address(RVA = "0x1A0EB80", Offset = "0x1A0EB80", VA = "0x1A0EB80")]
			[MethodImpl(256)]
			get
			{
				return 0;
			}
			[Token(Token = "0x60032BC")]
			[Address(RVA = "0x1A0EBA4", Offset = "0x1A0EBA4", VA = "0x1A0EBA4")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x060032BD RID: 12989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032BD")]
		[Address(RVA = "0x1A0EBC8", Offset = "0x1A0EBC8", VA = "0x1A0EBC8")]
		[MethodImpl(256)]
		public void SetLiquid(byte liquid)
		{
		}

		// Token: 0x170006E6 RID: 1766
		// (get) Token: 0x060032BE RID: 12990 RVA: 0x000188B8 File Offset: 0x00016AB8
		// (set) Token: 0x060032BF RID: 12991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006E6")]
		public short sTileHeader
		{
			[Token(Token = "0x60032BE")]
			[Address(RVA = "0x1A0EBEC", Offset = "0x1A0EBEC", VA = "0x1A0EBEC")]
			[MethodImpl(256)]
			get
			{
				return 0;
			}
			[Token(Token = "0x60032BF")]
			[Address(RVA = "0x1A0EC30", Offset = "0x1A0EC30", VA = "0x1A0EC30")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x060032C0 RID: 12992 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032C0")]
		[Address(RVA = "0x1A0ED10", Offset = "0x1A0ED10", VA = "0x1A0ED10")]
		[MethodImpl(256)]
		public void SetSTileHeader(short value)
		{
		}

		// Token: 0x170006E7 RID: 1767
		// (get) Token: 0x060032C1 RID: 12993 RVA: 0x000188D0 File Offset: 0x00016AD0
		// (set) Token: 0x060032C2 RID: 12994 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006E7")]
		public byte bTileHeader
		{
			[Token(Token = "0x60032C1")]
			[Address(RVA = "0x1A0ED18", Offset = "0x1A0ED18", VA = "0x1A0ED18")]
			[MethodImpl(256)]
			get
			{
				return 0;
			}
			[Token(Token = "0x60032C2")]
			[Address(RVA = "0x1A0ED48", Offset = "0x1A0ED48", VA = "0x1A0ED48")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x060032C3 RID: 12995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032C3")]
		[Address(RVA = "0x1A0EDF4", Offset = "0x1A0EDF4", VA = "0x1A0EDF4")]
		[MethodImpl(256)]
		public void SetBTileHeader(byte value)
		{
		}

		// Token: 0x170006E8 RID: 1768
		// (get) Token: 0x060032C4 RID: 12996 RVA: 0x000188E8 File Offset: 0x00016AE8
		// (set) Token: 0x060032C5 RID: 12997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006E8")]
		public byte bTileHeader2
		{
			[Token(Token = "0x60032C4")]
			[Address(RVA = "0x1A0EDFC", Offset = "0x1A0EDFC", VA = "0x1A0EDFC")]
			[MethodImpl(256)]
			get
			{
				return 0;
			}
			[Token(Token = "0x60032C5")]
			[Address(RVA = "0x1A0EE2C", Offset = "0x1A0EE2C", VA = "0x1A0EE2C")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x060032C6 RID: 12998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032C6")]
		[Address(RVA = "0x1A0EED8", Offset = "0x1A0EED8", VA = "0x1A0EED8")]
		[MethodImpl(256)]
		public void SetBTileHeader2(byte value)
		{
		}

		// Token: 0x170006E9 RID: 1769
		// (get) Token: 0x060032C7 RID: 12999 RVA: 0x00018900 File Offset: 0x00016B00
		// (set) Token: 0x060032C8 RID: 13000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006E9")]
		public byte bTileHeader3
		{
			[Token(Token = "0x60032C7")]
			[Address(RVA = "0x1A0EEE0", Offset = "0x1A0EEE0", VA = "0x1A0EEE0")]
			[MethodImpl(256)]
			get
			{
				return 0;
			}
			[Token(Token = "0x60032C8")]
			[Address(RVA = "0x1A0EF10", Offset = "0x1A0EF10", VA = "0x1A0EF10")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x060032C9 RID: 13001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032C9")]
		[Address(RVA = "0x1A0EFBC", Offset = "0x1A0EFBC", VA = "0x1A0EFBC")]
		[MethodImpl(256)]
		public void SetBTileHeader3(byte value)
		{
		}

		// Token: 0x170006EA RID: 1770
		// (get) Token: 0x060032CA RID: 13002 RVA: 0x00018918 File Offset: 0x00016B18
		// (set) Token: 0x060032CB RID: 13003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006EA")]
		public short frameX
		{
			[Token(Token = "0x60032CA")]
			[Address(RVA = "0x1A0EFC4", Offset = "0x1A0EFC4", VA = "0x1A0EFC4")]
			[MethodImpl(256)]
			get
			{
				return 0;
			}
			[Token(Token = "0x60032CB")]
			[Address(RVA = "0x1A0EFF8", Offset = "0x1A0EFF8", VA = "0x1A0EFF8")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x060032CC RID: 13004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032CC")]
		[Address(RVA = "0x1A0F0AC", Offset = "0x1A0F0AC", VA = "0x1A0F0AC")]
		[MethodImpl(256)]
		public void SetFrameX(short value)
		{
		}

		// Token: 0x060032CD RID: 13005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032CD")]
		[Address(RVA = "0x1A0F0B4", Offset = "0x1A0F0B4", VA = "0x1A0F0B4")]
		[MethodImpl(256)]
		public void SetFrameXY(short xValue, short yValue)
		{
		}

		// Token: 0x060032CE RID: 13006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032CE")]
		[Address(RVA = "0x1A0F178", Offset = "0x1A0F178", VA = "0x1A0F178")]
		[MethodImpl(256)]
		public void OffsetFrameX(short value)
		{
		}

		// Token: 0x170006EB RID: 1771
		// (get) Token: 0x060032CF RID: 13007 RVA: 0x00018930 File Offset: 0x00016B30
		// (set) Token: 0x060032D0 RID: 13008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006EB")]
		public short frameY
		{
			[Token(Token = "0x60032CF")]
			[Address(RVA = "0x1A0F210", Offset = "0x1A0F210", VA = "0x1A0F210")]
			[MethodImpl(256)]
			get
			{
				return 0;
			}
			[Token(Token = "0x60032D0")]
			[Address(RVA = "0x1A0F244", Offset = "0x1A0F244", VA = "0x1A0F244")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x060032D1 RID: 13009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032D1")]
		[Address(RVA = "0x1A0F2F8", Offset = "0x1A0F2F8", VA = "0x1A0F2F8")]
		[MethodImpl(256)]
		public void SetFrameY(short value)
		{
		}

		// Token: 0x060032D2 RID: 13010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032D2")]
		[Address(RVA = "0x1A0F300", Offset = "0x1A0F300", VA = "0x1A0F300")]
		[MethodImpl(256)]
		public void OffsetFrameY(short value)
		{
		}

		// Token: 0x060032D3 RID: 13011 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032D3")]
		[Address(RVA = "0x1A0F398", Offset = "0x1A0F398", VA = "0x1A0F398")]
		[MethodImpl(256)]
		public void BitWiseOrFrameY(short value)
		{
		}

		// Token: 0x170006EC RID: 1772
		// (get) Token: 0x060032D4 RID: 13012 RVA: 0x00018948 File Offset: 0x00016B48
		[Token(Token = "0x170006EC")]
		public ushort TileSeachUID
		{
			[Token(Token = "0x60032D4")]
			[Address(RVA = "0x1A0F430", Offset = "0x1A0F430", VA = "0x1A0F430")]
			[MethodImpl(256)]
			get
			{
				return 0;
			}
		}

		// Token: 0x060032D5 RID: 13013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032D5")]
		[Address(RVA = "0x1A0F45C", Offset = "0x1A0F45C", VA = "0x1A0F45C")]
		[MethodImpl(256)]
		public void SetTileSeachUID(ushort value)
		{
		}

		// Token: 0x060032D6 RID: 13014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032D6")]
		[Address(RVA = "0x1A0F490", Offset = "0x1A0F490", VA = "0x1A0F490")]
		public static void StartNewSearch()
		{
		}

		// Token: 0x060032D7 RID: 13015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032D7")]
		[Address(RVA = "0x1A0F554", Offset = "0x1A0F554", VA = "0x1A0F554")]
		[MethodImpl(256)]
		public void ClearEverything()
		{
		}

		// Token: 0x060032D8 RID: 13016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032D8")]
		[Address(RVA = "0x1A0F67C", Offset = "0x1A0F67C", VA = "0x1A0F67C")]
		[MethodImpl(256)]
		public void SetEverything(ushort tileType, short tileSHeader, short frameX, short frameY, byte tileBHeader, byte tileBHeader2, byte tileBHeader3, byte wall, byte liquid)
		{
		}

		// Token: 0x060032D9 RID: 13017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032D9")]
		[Address(RVA = "0x1A0F7A4", Offset = "0x1A0F7A4", VA = "0x1A0F7A4")]
		[MethodImpl(256)]
		public void ClearTile()
		{
		}

		// Token: 0x060032DA RID: 13018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032DA")]
		[Address(RVA = "0x1A0F7E0", Offset = "0x1A0F7E0", VA = "0x1A0F7E0")]
		[MethodImpl(256)]
		public void ClearSlope()
		{
		}

		// Token: 0x060032DB RID: 13019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032DB")]
		[Address(RVA = "0x1A0F814", Offset = "0x1A0F814", VA = "0x1A0F814")]
		public void CopyFrom(Tile from)
		{
		}

		// Token: 0x170006ED RID: 1773
		// (get) Token: 0x060032DC RID: 13020 RVA: 0x00018960 File Offset: 0x00016B60
		[Token(Token = "0x170006ED")]
		public int collisionType
		{
			[Token(Token = "0x60032DC")]
			[Address(RVA = "0x1A0F93C", Offset = "0x1A0F93C", VA = "0x1A0F93C")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060032DD RID: 13021 RVA: 0x00018978 File Offset: 0x00016B78
		[Token(Token = "0x60032DD")]
		[Address(RVA = "0x1A0FD48", Offset = "0x1A0FD48", VA = "0x1A0FD48")]
		public bool isTheSameAs(Tile compTile)
		{
			return default(bool);
		}

		// Token: 0x060032DE RID: 13022 RVA: 0x00018990 File Offset: 0x00016B90
		[Token(Token = "0x60032DE")]
		[Address(RVA = "0x1A109A8", Offset = "0x1A109A8", VA = "0x1A109A8")]
		[MethodImpl(256)]
		public int wallFrameX()
		{
			return 0;
		}

		// Token: 0x060032DF RID: 13023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032DF")]
		[Address(RVA = "0x1A109E4", Offset = "0x1A109E4", VA = "0x1A109E4")]
		[MethodImpl(256)]
		public void wallFrameX(int wallFrameX)
		{
		}

		// Token: 0x060032E0 RID: 13024 RVA: 0x000189A8 File Offset: 0x00016BA8
		[Token(Token = "0x60032E0")]
		[Address(RVA = "0x1A10A30", Offset = "0x1A10A30", VA = "0x1A10A30")]
		[MethodImpl(256)]
		public int wallFrameY()
		{
			return 0;
		}

		// Token: 0x060032E1 RID: 13025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032E1")]
		[Address(RVA = "0x1A10A6C", Offset = "0x1A10A6C", VA = "0x1A10A6C")]
		[MethodImpl(256)]
		public void wallFrameY(int wallFrameY)
		{
		}

		// Token: 0x060032E2 RID: 13026 RVA: 0x000189C0 File Offset: 0x00016BC0
		[Token(Token = "0x60032E2")]
		[Address(RVA = "0x1A10AB8", Offset = "0x1A10AB8", VA = "0x1A10AB8")]
		[MethodImpl(256)]
		public bool invisibleBlock()
		{
			return default(bool);
		}

		// Token: 0x060032E3 RID: 13027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032E3")]
		[Address(RVA = "0x1A10AEC", Offset = "0x1A10AEC", VA = "0x1A10AEC")]
		[MethodImpl(256)]
		public void invisibleBlock(bool invisibleBlock)
		{
		}

		// Token: 0x060032E4 RID: 13028 RVA: 0x000189D8 File Offset: 0x00016BD8
		[Token(Token = "0x60032E4")]
		[Address(RVA = "0x1A10B28", Offset = "0x1A10B28", VA = "0x1A10B28")]
		[MethodImpl(256)]
		public bool invisibleWall()
		{
			return default(bool);
		}

		// Token: 0x060032E5 RID: 13029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032E5")]
		[Address(RVA = "0x1A10B5C", Offset = "0x1A10B5C", VA = "0x1A10B5C")]
		[MethodImpl(256)]
		public void invisibleWall(bool invisibleWall)
		{
		}

		// Token: 0x060032E6 RID: 13030 RVA: 0x000189F0 File Offset: 0x00016BF0
		[Token(Token = "0x60032E6")]
		[Address(RVA = "0x1A10B98", Offset = "0x1A10B98", VA = "0x1A10B98")]
		[MethodImpl(256)]
		public bool fullbrightBlock()
		{
			return default(bool);
		}

		// Token: 0x060032E7 RID: 13031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032E7")]
		[Address(RVA = "0x1A10BCC", Offset = "0x1A10BCC", VA = "0x1A10BCC")]
		[MethodImpl(256)]
		public void fullbrightBlock(bool fullbrightBlock)
		{
		}

		// Token: 0x060032E8 RID: 13032 RVA: 0x00018A08 File Offset: 0x00016C08
		[Token(Token = "0x60032E8")]
		[Address(RVA = "0x1A10C08", Offset = "0x1A10C08", VA = "0x1A10C08")]
		[MethodImpl(256)]
		public bool fullbrightWall()
		{
			return default(bool);
		}

		// Token: 0x060032E9 RID: 13033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032E9")]
		[Address(RVA = "0x1A10C48", Offset = "0x1A10C48", VA = "0x1A10C48")]
		[MethodImpl(256)]
		public void fullbrightWall(bool fullbrightWall)
		{
		}

		// Token: 0x060032EA RID: 13034 RVA: 0x00018A20 File Offset: 0x00016C20
		[Token(Token = "0x60032EA")]
		[Address(RVA = "0x1A10C84", Offset = "0x1A10C84", VA = "0x1A10C84")]
		[MethodImpl(256)]
		public byte frameNumber()
		{
			return 0;
		}

		// Token: 0x060032EB RID: 13035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032EB")]
		[Address(RVA = "0x1A10CB8", Offset = "0x1A10CB8", VA = "0x1A10CB8")]
		[MethodImpl(256)]
		public void frameNumber(byte frameNumber)
		{
		}

		// Token: 0x060032EC RID: 13036 RVA: 0x00018A38 File Offset: 0x00016C38
		[Token(Token = "0x60032EC")]
		[Address(RVA = "0x1A10CF0", Offset = "0x1A10CF0", VA = "0x1A10CF0")]
		[MethodImpl(256)]
		public byte wallFrameNumber()
		{
			return 0;
		}

		// Token: 0x060032ED RID: 13037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032ED")]
		[Address(RVA = "0x1A10D24", Offset = "0x1A10D24", VA = "0x1A10D24")]
		[MethodImpl(256)]
		public void wallFrameNumber(byte wallFrameNumber)
		{
		}

		// Token: 0x060032EE RID: 13038 RVA: 0x00018A50 File Offset: 0x00016C50
		[Token(Token = "0x60032EE")]
		[Address(RVA = "0x1A10D5C", Offset = "0x1A10D5C", VA = "0x1A10D5C")]
		public bool topSlope()
		{
			return default(bool);
		}

		// Token: 0x060032EF RID: 13039 RVA: 0x00018A68 File Offset: 0x00016C68
		[Token(Token = "0x60032EF")]
		[Address(RVA = "0x1A10E44", Offset = "0x1A10E44", VA = "0x1A10E44")]
		public bool bottomSlope()
		{
			return default(bool);
		}

		// Token: 0x060032F0 RID: 13040 RVA: 0x00018A80 File Offset: 0x00016C80
		[Token(Token = "0x60032F0")]
		[Address(RVA = "0x1A10F2C", Offset = "0x1A10F2C", VA = "0x1A10F2C")]
		public bool leftSlope()
		{
			return default(bool);
		}

		// Token: 0x060032F1 RID: 13041 RVA: 0x00018A98 File Offset: 0x00016C98
		[Token(Token = "0x60032F1")]
		[Address(RVA = "0x1A11010", Offset = "0x1A11010", VA = "0x1A11010")]
		public bool rightSlope()
		{
			return default(bool);
		}

		// Token: 0x060032F2 RID: 13042 RVA: 0x00018AB0 File Offset: 0x00016CB0
		[Token(Token = "0x60032F2")]
		[Address(RVA = "0x1A110F8", Offset = "0x1A110F8", VA = "0x1A110F8")]
		[MethodImpl(256)]
		public byte slope()
		{
			return 0;
		}

		// Token: 0x060032F3 RID: 13043 RVA: 0x00018AC8 File Offset: 0x00016CC8
		[Token(Token = "0x60032F3")]
		[Address(RVA = "0x1A11130", Offset = "0x1A11130", VA = "0x1A11130")]
		[MethodImpl(256)]
		public bool HasSameSlope(Tile tile)
		{
			return default(bool);
		}

		// Token: 0x060032F4 RID: 13044 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032F4")]
		[Address(RVA = "0x1A11180", Offset = "0x1A11180", VA = "0x1A11180")]
		[MethodImpl(256)]
		public void slope(byte slope)
		{
		}

		// Token: 0x060032F5 RID: 13045 RVA: 0x00018AE0 File Offset: 0x00016CE0
		[Token(Token = "0x60032F5")]
		[Address(RVA = "0x1A111C4", Offset = "0x1A111C4", VA = "0x1A111C4")]
		public int blockType()
		{
			return 0;
		}

		// Token: 0x060032F6 RID: 13046 RVA: 0x00018AF8 File Offset: 0x00016CF8
		[Token(Token = "0x60032F6")]
		[Address(RVA = "0x1A11210", Offset = "0x1A11210", VA = "0x1A11210")]
		[MethodImpl(256)]
		public byte color()
		{
			return 0;
		}

		// Token: 0x060032F7 RID: 13047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032F7")]
		[Address(RVA = "0x1A11248", Offset = "0x1A11248", VA = "0x1A11248")]
		[MethodImpl(256)]
		public void color(byte color)
		{
		}

		// Token: 0x060032F8 RID: 13048 RVA: 0x00018B10 File Offset: 0x00016D10
		[Token(Token = "0x60032F8")]
		[Address(RVA = "0x1A11284", Offset = "0x1A11284", VA = "0x1A11284")]
		[MethodImpl(256)]
		public byte wallColor()
		{
			return 0;
		}

		// Token: 0x060032F9 RID: 13049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032F9")]
		[Address(RVA = "0x1A112B8", Offset = "0x1A112B8", VA = "0x1A112B8")]
		[MethodImpl(256)]
		public void wallColor(byte wallColor)
		{
		}

		// Token: 0x060032FA RID: 13050 RVA: 0x00018B28 File Offset: 0x00016D28
		[Token(Token = "0x60032FA")]
		[Address(RVA = "0x1A112EC", Offset = "0x1A112EC", VA = "0x1A112EC")]
		[MethodImpl(256)]
		public bool lava()
		{
			return default(bool);
		}

		// Token: 0x060032FB RID: 13051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032FB")]
		[Address(RVA = "0x1A1132C", Offset = "0x1A1132C", VA = "0x1A1132C")]
		[MethodImpl(256)]
		public void lava(bool lava)
		{
		}

		// Token: 0x060032FC RID: 13052 RVA: 0x00018B40 File Offset: 0x00016D40
		[Token(Token = "0x60032FC")]
		[Address(RVA = "0x1A11378", Offset = "0x1A11378", VA = "0x1A11378")]
		[MethodImpl(256)]
		public bool honey()
		{
			return default(bool);
		}

		// Token: 0x060032FD RID: 13053 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032FD")]
		[Address(RVA = "0x1A113B8", Offset = "0x1A113B8", VA = "0x1A113B8")]
		[MethodImpl(256)]
		public void honey(bool honey)
		{
		}

		// Token: 0x060032FE RID: 13054 RVA: 0x00018B58 File Offset: 0x00016D58
		[Token(Token = "0x60032FE")]
		[Address(RVA = "0x1A11404", Offset = "0x1A11404", VA = "0x1A11404")]
		[MethodImpl(256)]
		public bool shimmer()
		{
			return default(bool);
		}

		// Token: 0x060032FF RID: 13055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032FF")]
		[Address(RVA = "0x1A11444", Offset = "0x1A11444", VA = "0x1A11444")]
		[MethodImpl(256)]
		public void shimmer(bool shimmer)
		{
		}

		// Token: 0x06003300 RID: 13056 RVA: 0x00018B70 File Offset: 0x00016D70
		[Token(Token = "0x6003300")]
		[Address(RVA = "0x1A1148C", Offset = "0x1A1148C", VA = "0x1A1148C")]
		public bool water()
		{
			return default(bool);
		}

		// Token: 0x06003301 RID: 13057 RVA: 0x00018B88 File Offset: 0x00016D88
		[Token(Token = "0x6003301")]
		[Address(RVA = "0x1A11564", Offset = "0x1A11564", VA = "0x1A11564")]
		public bool anyWater()
		{
			return default(bool);
		}

		// Token: 0x06003302 RID: 13058 RVA: 0x00018BA0 File Offset: 0x00016DA0
		[Token(Token = "0x6003302")]
		[Address(RVA = "0x1A11650", Offset = "0x1A11650", VA = "0x1A11650")]
		public bool anyLava()
		{
			return default(bool);
		}

		// Token: 0x06003303 RID: 13059 RVA: 0x00018BB8 File Offset: 0x00016DB8
		[Token(Token = "0x6003303")]
		[Address(RVA = "0x1A117A8", Offset = "0x1A117A8", VA = "0x1A117A8")]
		public bool anyHoney()
		{
			return default(bool);
		}

		// Token: 0x06003304 RID: 13060 RVA: 0x00018BD0 File Offset: 0x00016DD0
		[Token(Token = "0x6003304")]
		[Address(RVA = "0x1A11900", Offset = "0x1A11900", VA = "0x1A11900")]
		public bool anyShimmer()
		{
			return default(bool);
		}

		// Token: 0x06003305 RID: 13061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003305")]
		[Address(RVA = "0x1A11A58", Offset = "0x1A11A58", VA = "0x1A11A58")]
		public void ClearTileAndPaint()
		{
		}

		// Token: 0x06003306 RID: 13062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003306")]
		[Address(RVA = "0x1A11D20", Offset = "0x1A11D20", VA = "0x1A11D20")]
		public void liquidType(int liquidType)
		{
		}

		// Token: 0x06003307 RID: 13063 RVA: 0x00018BE8 File Offset: 0x00016DE8
		[Token(Token = "0x6003307")]
		[Address(RVA = "0x1A11D64", Offset = "0x1A11D64", VA = "0x1A11D64")]
		[MethodImpl(256)]
		public byte liquidType()
		{
			return 0;
		}

		// Token: 0x06003308 RID: 13064 RVA: 0x00018C00 File Offset: 0x00016E00
		[Token(Token = "0x6003308")]
		[Address(RVA = "0x1A11D98", Offset = "0x1A11D98", VA = "0x1A11D98")]
		public bool checkingLiquid()
		{
			return default(bool);
		}

		// Token: 0x06003309 RID: 13065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003309")]
		[Address(RVA = "0x1A11DFC", Offset = "0x1A11DFC", VA = "0x1A11DFC")]
		public void checkingLiquid(bool checkingLiquid)
		{
		}

		// Token: 0x0600330A RID: 13066 RVA: 0x00018C18 File Offset: 0x00016E18
		[Token(Token = "0x600330A")]
		[Address(RVA = "0x1A11E70", Offset = "0x1A11E70", VA = "0x1A11E70")]
		public bool skipLiquid()
		{
			return default(bool);
		}

		// Token: 0x0600330B RID: 13067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600330B")]
		[Address(RVA = "0x1A11EC4", Offset = "0x1A11EC4", VA = "0x1A11EC4")]
		public void skipLiquid(bool skipLiquid)
		{
		}

		// Token: 0x0600330C RID: 13068 RVA: 0x00018C30 File Offset: 0x00016E30
		[Token(Token = "0x600330C")]
		[Address(RVA = "0x1A11F38", Offset = "0x1A11F38", VA = "0x1A11F38")]
		public bool TileFramed()
		{
			return default(bool);
		}

		// Token: 0x0600330D RID: 13069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600330D")]
		[Address(RVA = "0x1A11F8C", Offset = "0x1A11F8C", VA = "0x1A11F8C")]
		public void TileFramed(bool framed)
		{
		}

		// Token: 0x0600330E RID: 13070 RVA: 0x00018C48 File Offset: 0x00016E48
		[Token(Token = "0x600330E")]
		[Address(RVA = "0x1A12030", Offset = "0x1A12030", VA = "0x1A12030")]
		[MethodImpl(256)]
		public bool wire()
		{
			return default(bool);
		}

		// Token: 0x0600330F RID: 13071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600330F")]
		[Address(RVA = "0x1A12068", Offset = "0x1A12068", VA = "0x1A12068")]
		[MethodImpl(256)]
		public void wire(bool wire)
		{
		}

		// Token: 0x06003310 RID: 13072 RVA: 0x00018C60 File Offset: 0x00016E60
		[Token(Token = "0x6003310")]
		[Address(RVA = "0x1A120A8", Offset = "0x1A120A8", VA = "0x1A120A8")]
		[MethodImpl(256)]
		public bool wire2()
		{
			return default(bool);
		}

		// Token: 0x06003311 RID: 13073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003311")]
		[Address(RVA = "0x1A120E0", Offset = "0x1A120E0", VA = "0x1A120E0")]
		[MethodImpl(256)]
		public void wire2(bool wire2)
		{
		}

		// Token: 0x06003312 RID: 13074 RVA: 0x00018C78 File Offset: 0x00016E78
		[Token(Token = "0x6003312")]
		[Address(RVA = "0x1A12124", Offset = "0x1A12124", VA = "0x1A12124")]
		[MethodImpl(256)]
		public bool wire3()
		{
			return default(bool);
		}

		// Token: 0x06003313 RID: 13075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003313")]
		[Address(RVA = "0x1A1215C", Offset = "0x1A1215C", VA = "0x1A1215C")]
		[MethodImpl(256)]
		public void wire3(bool wire3)
		{
		}

		// Token: 0x06003314 RID: 13076 RVA: 0x00018C90 File Offset: 0x00016E90
		[Token(Token = "0x6003314")]
		[Address(RVA = "0x1A121A0", Offset = "0x1A121A0", VA = "0x1A121A0")]
		[MethodImpl(256)]
		public bool wire4()
		{
			return default(bool);
		}

		// Token: 0x06003315 RID: 13077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003315")]
		[Address(RVA = "0x1A121E0", Offset = "0x1A121E0", VA = "0x1A121E0")]
		[MethodImpl(256)]
		public void wire4(bool wire4)
		{
		}

		// Token: 0x06003316 RID: 13078 RVA: 0x00018CA8 File Offset: 0x00016EA8
		[Token(Token = "0x6003316")]
		[Address(RVA = "0x1A1222C", Offset = "0x1A1222C", VA = "0x1A1222C")]
		[MethodImpl(256)]
		public bool halfBrick()
		{
			return default(bool);
		}

		// Token: 0x06003317 RID: 13079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003317")]
		[Address(RVA = "0x1A12264", Offset = "0x1A12264", VA = "0x1A12264")]
		[MethodImpl(256)]
		public void halfBrick(bool halfBrick)
		{
		}

		// Token: 0x06003318 RID: 13080 RVA: 0x00018CC0 File Offset: 0x00016EC0
		[Token(Token = "0x6003318")]
		[Address(RVA = "0x1A122A8", Offset = "0x1A122A8", VA = "0x1A122A8")]
		[MethodImpl(256)]
		public bool actuator()
		{
			return default(bool);
		}

		// Token: 0x06003319 RID: 13081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003319")]
		[Address(RVA = "0x1A122E0", Offset = "0x1A122E0", VA = "0x1A122E0")]
		[MethodImpl(256)]
		public void actuator(bool actuator)
		{
		}

		// Token: 0x0600331A RID: 13082 RVA: 0x00018CD8 File Offset: 0x00016ED8
		[Token(Token = "0x600331A")]
		[Address(RVA = "0x1A12324", Offset = "0x1A12324", VA = "0x1A12324")]
		public bool nactive()
		{
			return default(bool);
		}

		// Token: 0x0600331B RID: 13083 RVA: 0x00018CF0 File Offset: 0x00016EF0
		[Token(Token = "0x600331B")]
		[Address(RVA = "0x1A12370", Offset = "0x1A12370", VA = "0x1A12370")]
		[MethodImpl(256)]
		public bool inActive()
		{
			return default(bool);
		}

		// Token: 0x0600331C RID: 13084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600331C")]
		[Address(RVA = "0x1A123A8", Offset = "0x1A123A8", VA = "0x1A123A8")]
		[MethodImpl(256)]
		public void inActive(bool inActive)
		{
		}

		// Token: 0x0600331D RID: 13085 RVA: 0x00018D08 File Offset: 0x00016F08
		[Token(Token = "0x600331D")]
		[Address(RVA = "0x1A123EC", Offset = "0x1A123EC", VA = "0x1A123EC")]
		[MethodImpl(256)]
		public bool active()
		{
			return default(bool);
		}

		// Token: 0x0600331E RID: 13086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600331E")]
		[Address(RVA = "0x1A1242C", Offset = "0x1A1242C", VA = "0x1A1242C")]
		[MethodImpl(256)]
		public void active(bool active)
		{
		}

		// Token: 0x0600331F RID: 13087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600331F")]
		[Address(RVA = "0x1A12494", Offset = "0x1A12494", VA = "0x1A12494")]
		public void ResetToType(ushort type)
		{
		}

		// Token: 0x06003320 RID: 13088 RVA: 0x00018D20 File Offset: 0x00016F20
		[Token(Token = "0x6003320")]
		[Address(RVA = "0x1A127A8", Offset = "0x1A127A8", VA = "0x1A127A8")]
		public Color actColor(Color oldColor)
		{
			return default(Color);
		}

		// Token: 0x06003321 RID: 13089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003321")]
		[Address(RVA = "0x1A12920", Offset = "0x1A12920", VA = "0x1A12920")]
		public void actColor(ref Vector3 oldColor)
		{
		}

		// Token: 0x06003322 RID: 13090 RVA: 0x00018D38 File Offset: 0x00016F38
		[Token(Token = "0x6003322")]
		[Address(RVA = "0x1A12A78", Offset = "0x1A12A78", VA = "0x1A12A78")]
		[MethodImpl(256)]
		public bool anyWire()
		{
			return default(bool);
		}

		// Token: 0x06003323 RID: 13091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003323")]
		[Address(RVA = "0x1A12AB8", Offset = "0x1A12AB8", VA = "0x1A12AB8")]
		public void Clear(TileDataType types)
		{
		}

		// Token: 0x06003324 RID: 13092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003324")]
		[Address(RVA = "0x1A13610", Offset = "0x1A13610", VA = "0x1A13610")]
		public static void SmoothSlope(int x, int y, bool applyToNeighbors = true, bool sync = false)
		{
		}

		// Token: 0x06003325 RID: 13093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003325")]
		[Address(RVA = "0x1A13F20", Offset = "0x1A13F20", VA = "0x1A13F20")]
		public void CopyPaintAndCoating(Tile other)
		{
		}

		// Token: 0x06003326 RID: 13094 RVA: 0x00018D50 File Offset: 0x00016F50
		[Token(Token = "0x6003326")]
		[Address(RVA = "0x1A14214", Offset = "0x1A14214", VA = "0x1A14214")]
		public TileColorCache BlockColorAndCoating()
		{
			return default(TileColorCache);
		}

		// Token: 0x06003327 RID: 13095 RVA: 0x00018D68 File Offset: 0x00016F68
		[Token(Token = "0x6003327")]
		[Address(RVA = "0x1A143B0", Offset = "0x1A143B0", VA = "0x1A143B0")]
		public TileColorCache WallColorAndCoating()
		{
			return default(TileColorCache);
		}

		// Token: 0x06003328 RID: 13096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003328")]
		[Address(RVA = "0x1A14548", Offset = "0x1A14548", VA = "0x1A14548")]
		public void UseBlockColors(TileColorCache cache)
		{
		}

		// Token: 0x06003329 RID: 13097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003329")]
		[Address(RVA = "0x1A1473C", Offset = "0x1A1473C", VA = "0x1A1473C")]
		public void UseWallColors(TileColorCache cache)
		{
		}

		// Token: 0x0600332A RID: 13098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600332A")]
		[Address(RVA = "0x1A11B4C", Offset = "0x1A11B4C", VA = "0x1A11B4C")]
		public void ClearBlockPaintAndCoating()
		{
		}

		// Token: 0x0600332B RID: 13099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600332B")]
		[Address(RVA = "0x1A13440", Offset = "0x1A13440", VA = "0x1A13440")]
		public void ClearWallPaintAndCoating()
		{
		}

		// Token: 0x0600332C RID: 13100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600332C")]
		[Address(RVA = "0x1A14928", Offset = "0x1A14928", VA = "0x1A14928")]
		internal void ClearMetadata()
		{
		}

		// Token: 0x040042FC RID: 17148
		[Token(Token = "0x40042FC")]
		[FieldOffset(Offset = "0x0")]
		public static Tile s_Null;

		// Token: 0x040042FD RID: 17149
		[Token(Token = "0x40042FD")]
		[FieldOffset(Offset = "0x0")]
		private int _tileOffset;

		// Token: 0x040042FE RID: 17150
		[Token(Token = "0x40042FE")]
		[FieldOffset(Offset = "0x4")]
		public static ushort CurrentSearchUID;

		// Token: 0x040042FF RID: 17151
		[Token(Token = "0x40042FF")]
		[FieldOffset(Offset = "0x6")]
		public static ushort MaxSearchUID;

		// Token: 0x04004300 RID: 17152
		[Token(Token = "0x4004300")]
		public const int Type_Solid = 0;

		// Token: 0x04004301 RID: 17153
		[Token(Token = "0x4004301")]
		public const int Type_Halfbrick = 1;

		// Token: 0x04004302 RID: 17154
		[Token(Token = "0x4004302")]
		public const int Type_SlopeDownRight = 2;

		// Token: 0x04004303 RID: 17155
		[Token(Token = "0x4004303")]
		public const int Type_SlopeDownLeft = 3;

		// Token: 0x04004304 RID: 17156
		[Token(Token = "0x4004304")]
		public const int Type_SlopeUpRight = 4;

		// Token: 0x04004305 RID: 17157
		[Token(Token = "0x4004305")]
		public const int Type_SlopeUpLeft = 5;

		// Token: 0x04004306 RID: 17158
		[Token(Token = "0x4004306")]
		public const int Liquid_Water = 0;

		// Token: 0x04004307 RID: 17159
		[Token(Token = "0x4004307")]
		public const int Liquid_Lava = 1;

		// Token: 0x04004308 RID: 17160
		[Token(Token = "0x4004308")]
		public const int Liquid_Honey = 2;

		// Token: 0x04004309 RID: 17161
		[Token(Token = "0x4004309")]
		public const int Liquid_Shimmer = 3;
	}
}
