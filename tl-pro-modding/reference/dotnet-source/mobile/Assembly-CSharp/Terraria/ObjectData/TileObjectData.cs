using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using Terraria.Enums;
using Terraria.Modules;

namespace Terraria.ObjectData
{
	// Token: 0x0200064E RID: 1614
	[Token(Token = "0x200064E")]
	public class TileObjectData
	{
		// Token: 0x06003E63 RID: 15971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E63")]
		[Address(RVA = "0x1E6E0D4", Offset = "0x1E6E0D4", VA = "0x1E6E0D4")]
		public TileObjectData([Optional] TileObjectData copyFrom)
		{
		}

		// Token: 0x06003E64 RID: 15972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E64")]
		[Address(RVA = "0x1E6E174", Offset = "0x1E6E174", VA = "0x1E6E174")]
		public void CopyFrom(TileObjectData copy)
		{
		}

		// Token: 0x06003E65 RID: 15973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E65")]
		[Address(RVA = "0x1E6E1D0", Offset = "0x1E6E1D0", VA = "0x1E6E1D0")]
		public void FullCopyFrom(ushort tileType)
		{
		}

		// Token: 0x06003E66 RID: 15974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E66")]
		[Address(RVA = "0x1E6E480", Offset = "0x1E6E480", VA = "0x1E6E480")]
		public void FullCopyFrom(TileObjectData copy)
		{
		}

		// Token: 0x06003E67 RID: 15975 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E67")]
		[Address(RVA = "0x1E6E560", Offset = "0x1E6E560", VA = "0x1E6E560")]
		private void SetupBaseObject()
		{
		}

		// Token: 0x06003E68 RID: 15976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E68")]
		[Address(RVA = "0x1E7298C", Offset = "0x1E7298C", VA = "0x1E7298C")]
		private void Calculate()
		{
		}

		// Token: 0x06003E69 RID: 15977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E69")]
		[Address(RVA = "0x1E72C40", Offset = "0x1E72C40", VA = "0x1E72C40")]
		private void WriteCheck()
		{
		}

		// Token: 0x06003E6A RID: 15978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E6A")]
		[Address(RVA = "0x1E72CF0", Offset = "0x1E72CF0", VA = "0x1E72CF0")]
		private void LockWrites()
		{
		}

		// Token: 0x170007BA RID: 1978
		// (get) Token: 0x06003E6B RID: 15979 RVA: 0x0001EC90 File Offset: 0x0001CE90
		// (set) Token: 0x06003E6C RID: 15980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007BA")]
		private bool LinkedAlternates
		{
			[Token(Token = "0x6003E6B")]
			[Address(RVA = "0x1E72D44", Offset = "0x1E72D44", VA = "0x1E72D44")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003E6C")]
			[Address(RVA = "0x1E72D4C", Offset = "0x1E72D4C", VA = "0x1E72D4C")]
			set
			{
			}
		}

		// Token: 0x170007BB RID: 1979
		// (get) Token: 0x06003E6D RID: 15981 RVA: 0x0001ECA8 File Offset: 0x0001CEA8
		// (set) Token: 0x06003E6E RID: 15982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007BB")]
		public bool UsesCustomCanPlace
		{
			[Token(Token = "0x6003E6D")]
			[Address(RVA = "0x1E72DF4", Offset = "0x1E72DF4", VA = "0x1E72DF4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003E6E")]
			[Address(RVA = "0x1E72DFC", Offset = "0x1E72DFC", VA = "0x1E72DFC")]
			set
			{
			}
		}

		// Token: 0x170007BC RID: 1980
		// (get) Token: 0x06003E6F RID: 15983 RVA: 0x0001ECC0 File Offset: 0x0001CEC0
		// (set) Token: 0x06003E70 RID: 15984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007BC")]
		public bool UsesGlobalLiquidChecks
		{
			[Token(Token = "0x6003E6F")]
			[Address(RVA = "0x1E72E14", Offset = "0x1E72E14", VA = "0x1E72E14")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003E70")]
			[Address(RVA = "0x1E72E1C", Offset = "0x1E72E1C", VA = "0x1E72E1C")]
			set
			{
			}
		}

		// Token: 0x06003E71 RID: 15985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E71")]
		[Address(RVA = "0x1E72E34", Offset = "0x1E72E34", VA = "0x1E72E34")]
		public void ApplyNaturalObjectRules()
		{
		}

		// Token: 0x170007BD RID: 1981
		// (get) Token: 0x06003E72 RID: 15986 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06003E73 RID: 15987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007BD")]
		private List<TileObjectData> Alternates
		{
			[Token(Token = "0x6003E72")]
			[Address(RVA = "0x1E72E58", Offset = "0x1E72E58", VA = "0x1E72E58")]
			get
			{
				return null;
			}
			[Token(Token = "0x6003E73")]
			[Address(RVA = "0x1E6ED0C", Offset = "0x1E6ED0C", VA = "0x1E6ED0C")]
			set
			{
			}
		}

		// Token: 0x170007BE RID: 1982
		// (get) Token: 0x06003E74 RID: 15988 RVA: 0x0001ECD8 File Offset: 0x0001CED8
		// (set) Token: 0x06003E75 RID: 15989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007BE")]
		public AnchorData AnchorTop
		{
			[Token(Token = "0x6003E74")]
			[Address(RVA = "0x1E72EC4", Offset = "0x1E72EC4", VA = "0x1E72EC4")]
			get
			{
				return default(AnchorData);
			}
			[Token(Token = "0x6003E75")]
			[Address(RVA = "0x1E6EDC0", Offset = "0x1E6EDC0", VA = "0x1E6EDC0")]
			set
			{
			}
		}

		// Token: 0x170007BF RID: 1983
		// (get) Token: 0x06003E76 RID: 15990 RVA: 0x0001ECF0 File Offset: 0x0001CEF0
		// (set) Token: 0x06003E77 RID: 15991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007BF")]
		public AnchorData AnchorBottom
		{
			[Token(Token = "0x6003E76")]
			[Address(RVA = "0x1E72F64", Offset = "0x1E72F64", VA = "0x1E72F64")]
			get
			{
				return default(AnchorData);
			}
			[Token(Token = "0x6003E77")]
			[Address(RVA = "0x1E6EFC8", Offset = "0x1E6EFC8", VA = "0x1E6EFC8")]
			set
			{
			}
		}

		// Token: 0x170007C0 RID: 1984
		// (get) Token: 0x06003E78 RID: 15992 RVA: 0x0001ED08 File Offset: 0x0001CF08
		// (set) Token: 0x06003E79 RID: 15993 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007C0")]
		public AnchorData AnchorLeft
		{
			[Token(Token = "0x6003E78")]
			[Address(RVA = "0x1E73004", Offset = "0x1E73004", VA = "0x1E73004")]
			get
			{
				return default(AnchorData);
			}
			[Token(Token = "0x6003E79")]
			[Address(RVA = "0x1E6F1D0", Offset = "0x1E6F1D0", VA = "0x1E6F1D0")]
			set
			{
			}
		}

		// Token: 0x170007C1 RID: 1985
		// (get) Token: 0x06003E7A RID: 15994 RVA: 0x0001ED20 File Offset: 0x0001CF20
		// (set) Token: 0x06003E7B RID: 15995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007C1")]
		public AnchorData AnchorRight
		{
			[Token(Token = "0x6003E7A")]
			[Address(RVA = "0x1E730A4", Offset = "0x1E730A4", VA = "0x1E730A4")]
			get
			{
				return default(AnchorData);
			}
			[Token(Token = "0x6003E7B")]
			[Address(RVA = "0x1E6F3D8", Offset = "0x1E6F3D8", VA = "0x1E6F3D8")]
			set
			{
			}
		}

		// Token: 0x170007C2 RID: 1986
		// (get) Token: 0x06003E7C RID: 15996 RVA: 0x0001ED38 File Offset: 0x0001CF38
		// (set) Token: 0x06003E7D RID: 15997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007C2")]
		public bool AnchorWall
		{
			[Token(Token = "0x6003E7C")]
			[Address(RVA = "0x1E73144", Offset = "0x1E73144", VA = "0x1E73144")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003E7D")]
			[Address(RVA = "0x1E6F5E0", Offset = "0x1E6F5E0", VA = "0x1E6F5E0")]
			set
			{
			}
		}

		// Token: 0x170007C3 RID: 1987
		// (get) Token: 0x06003E7E RID: 15998 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06003E7F RID: 15999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007C3")]
		public int[] AnchorValidTiles
		{
			[Token(Token = "0x6003E7E")]
			[Address(RVA = "0x1E731B0", Offset = "0x1E731B0", VA = "0x1E731B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6003E7F")]
			[Address(RVA = "0x1E6F76C", Offset = "0x1E6F76C", VA = "0x1E6F76C")]
			set
			{
			}
		}

		// Token: 0x170007C4 RID: 1988
		// (get) Token: 0x06003E80 RID: 16000 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06003E81 RID: 16001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007C4")]
		public int[] AnchorInvalidTiles
		{
			[Token(Token = "0x6003E80")]
			[Address(RVA = "0x1E7321C", Offset = "0x1E7321C", VA = "0x1E7321C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6003E81")]
			[Address(RVA = "0x1E6F9A8", Offset = "0x1E6F9A8", VA = "0x1E6F9A8")]
			set
			{
			}
		}

		// Token: 0x170007C5 RID: 1989
		// (get) Token: 0x06003E82 RID: 16002 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06003E83 RID: 16003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007C5")]
		public int[] AnchorAlternateTiles
		{
			[Token(Token = "0x6003E82")]
			[Address(RVA = "0x1E73288", Offset = "0x1E73288", VA = "0x1E73288")]
			get
			{
				return null;
			}
			[Token(Token = "0x6003E83")]
			[Address(RVA = "0x1E6FBE4", Offset = "0x1E6FBE4", VA = "0x1E6FBE4")]
			set
			{
			}
		}

		// Token: 0x170007C6 RID: 1990
		// (get) Token: 0x06003E84 RID: 16004 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06003E85 RID: 16005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007C6")]
		public int[] AnchorValidWalls
		{
			[Token(Token = "0x6003E84")]
			[Address(RVA = "0x1E732F4", Offset = "0x1E732F4", VA = "0x1E732F4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6003E85")]
			[Address(RVA = "0x1E6FE20", Offset = "0x1E6FE20", VA = "0x1E6FE20")]
			set
			{
			}
		}

		// Token: 0x170007C7 RID: 1991
		// (get) Token: 0x06003E86 RID: 16006 RVA: 0x0001ED50 File Offset: 0x0001CF50
		// (set) Token: 0x06003E87 RID: 16007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007C7")]
		public bool WaterDeath
		{
			[Token(Token = "0x6003E86")]
			[Address(RVA = "0x1E73360", Offset = "0x1E73360", VA = "0x1E73360")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003E87")]
			[Address(RVA = "0x1E70004", Offset = "0x1E70004", VA = "0x1E70004")]
			set
			{
			}
		}

		// Token: 0x170007C8 RID: 1992
		// (get) Token: 0x06003E88 RID: 16008 RVA: 0x0001ED68 File Offset: 0x0001CF68
		// (set) Token: 0x06003E89 RID: 16009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007C8")]
		public bool LavaDeath
		{
			[Token(Token = "0x6003E88")]
			[Address(RVA = "0x1E733CC", Offset = "0x1E733CC", VA = "0x1E733CC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003E89")]
			[Address(RVA = "0x1E70190", Offset = "0x1E70190", VA = "0x1E70190")]
			set
			{
			}
		}

		// Token: 0x170007C9 RID: 1993
		// (get) Token: 0x06003E8A RID: 16010 RVA: 0x0001ED80 File Offset: 0x0001CF80
		// (set) Token: 0x06003E8B RID: 16011 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007C9")]
		public LiquidPlacement WaterPlacement
		{
			[Token(Token = "0x6003E8A")]
			[Address(RVA = "0x1E73438", Offset = "0x1E73438", VA = "0x1E73438")]
			get
			{
				return LiquidPlacement.Allowed;
			}
			[Token(Token = "0x6003E8B")]
			[Address(RVA = "0x1E7031C", Offset = "0x1E7031C", VA = "0x1E7031C")]
			set
			{
			}
		}

		// Token: 0x170007CA RID: 1994
		// (get) Token: 0x06003E8C RID: 16012 RVA: 0x0001ED98 File Offset: 0x0001CF98
		// (set) Token: 0x06003E8D RID: 16013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007CA")]
		public LiquidPlacement LavaPlacement
		{
			[Token(Token = "0x6003E8C")]
			[Address(RVA = "0x1E734A4", Offset = "0x1E734A4", VA = "0x1E734A4")]
			get
			{
				return LiquidPlacement.Allowed;
			}
			[Token(Token = "0x6003E8D")]
			[Address(RVA = "0x1E704A8", Offset = "0x1E704A8", VA = "0x1E704A8")]
			set
			{
			}
		}

		// Token: 0x170007CB RID: 1995
		// (get) Token: 0x06003E8E RID: 16014 RVA: 0x0001EDB0 File Offset: 0x0001CFB0
		// (set) Token: 0x06003E8F RID: 16015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007CB")]
		public PlacementHook HookCheckIfCanPlace
		{
			[Token(Token = "0x6003E8E")]
			[Address(RVA = "0x1E73510", Offset = "0x1E73510", VA = "0x1E73510")]
			get
			{
				return default(PlacementHook);
			}
			[Token(Token = "0x6003E8F")]
			[Address(RVA = "0x1E70634", Offset = "0x1E70634", VA = "0x1E70634")]
			set
			{
			}
		}

		// Token: 0x170007CC RID: 1996
		// (get) Token: 0x06003E90 RID: 16016 RVA: 0x0001EDC8 File Offset: 0x0001CFC8
		// (set) Token: 0x06003E91 RID: 16017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007CC")]
		public PlacementHook HookPostPlaceEveryone
		{
			[Token(Token = "0x6003E90")]
			[Address(RVA = "0x1E735AC", Offset = "0x1E735AC", VA = "0x1E735AC")]
			get
			{
				return default(PlacementHook);
			}
			[Token(Token = "0x6003E91")]
			[Address(RVA = "0x1E706F8", Offset = "0x1E706F8", VA = "0x1E706F8")]
			set
			{
			}
		}

		// Token: 0x170007CD RID: 1997
		// (get) Token: 0x06003E92 RID: 16018 RVA: 0x0001EDE0 File Offset: 0x0001CFE0
		// (set) Token: 0x06003E93 RID: 16019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007CD")]
		public PlacementHook HookPostPlaceMyPlayer
		{
			[Token(Token = "0x6003E92")]
			[Address(RVA = "0x1E73648", Offset = "0x1E73648", VA = "0x1E73648")]
			get
			{
				return default(PlacementHook);
			}
			[Token(Token = "0x6003E93")]
			[Address(RVA = "0x1E707BC", Offset = "0x1E707BC", VA = "0x1E707BC")]
			set
			{
			}
		}

		// Token: 0x170007CE RID: 1998
		// (get) Token: 0x06003E94 RID: 16020 RVA: 0x0001EDF8 File Offset: 0x0001CFF8
		// (set) Token: 0x06003E95 RID: 16021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007CE")]
		public PlacementHook HookPlaceOverride
		{
			[Token(Token = "0x6003E94")]
			[Address(RVA = "0x1E736E4", Offset = "0x1E736E4", VA = "0x1E736E4")]
			get
			{
				return default(PlacementHook);
			}
			[Token(Token = "0x6003E95")]
			[Address(RVA = "0x1E70880", Offset = "0x1E70880", VA = "0x1E70880")]
			set
			{
			}
		}

		// Token: 0x170007CF RID: 1999
		// (get) Token: 0x06003E96 RID: 16022 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06003E97 RID: 16023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007CF")]
		public GetStyleMethod GetStyleOverride
		{
			[Token(Token = "0x6003E96")]
			[Address(RVA = "0x1E73780", Offset = "0x1E73780", VA = "0x1E73780")]
			get
			{
				return null;
			}
			[Token(Token = "0x6003E97")]
			[Address(RVA = "0x1E70944", Offset = "0x1E70944", VA = "0x1E70944")]
			set
			{
			}
		}

		// Token: 0x170007D0 RID: 2000
		// (get) Token: 0x06003E98 RID: 16024 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06003E99 RID: 16025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007D0")]
		private List<TileObjectData> SubTiles
		{
			[Token(Token = "0x6003E98")]
			[Address(RVA = "0x1E737EC", Offset = "0x1E737EC", VA = "0x1E737EC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6003E99")]
			[Address(RVA = "0x1E709FC", Offset = "0x1E709FC", VA = "0x1E709FC")]
			set
			{
			}
		}

		// Token: 0x170007D1 RID: 2001
		// (get) Token: 0x06003E9A RID: 16026 RVA: 0x0001EE10 File Offset: 0x0001D010
		// (set) Token: 0x06003E9B RID: 16027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007D1")]
		public int DrawYOffset
		{
			[Token(Token = "0x6003E9A")]
			[Address(RVA = "0x1E73858", Offset = "0x1E73858", VA = "0x1E73858")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6003E9B")]
			[Address(RVA = "0x1E71D2C", Offset = "0x1E71D2C", VA = "0x1E71D2C")]
			set
			{
			}
		}

		// Token: 0x170007D2 RID: 2002
		// (get) Token: 0x06003E9C RID: 16028 RVA: 0x0001EE28 File Offset: 0x0001D028
		// (set) Token: 0x06003E9D RID: 16029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007D2")]
		public int DrawXOffset
		{
			[Token(Token = "0x6003E9C")]
			[Address(RVA = "0x1E7386C", Offset = "0x1E7386C", VA = "0x1E7386C")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6003E9D")]
			[Address(RVA = "0x1E73880", Offset = "0x1E73880", VA = "0x1E73880")]
			set
			{
			}
		}

		// Token: 0x170007D3 RID: 2003
		// (get) Token: 0x06003E9E RID: 16030 RVA: 0x0001EE40 File Offset: 0x0001D040
		// (set) Token: 0x06003E9F RID: 16031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007D3")]
		public bool DrawFlipHorizontal
		{
			[Token(Token = "0x6003E9E")]
			[Address(RVA = "0x1E73A0C", Offset = "0x1E73A0C", VA = "0x1E73A0C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003E9F")]
			[Address(RVA = "0x1E71EB8", Offset = "0x1E71EB8", VA = "0x1E71EB8")]
			set
			{
			}
		}

		// Token: 0x170007D4 RID: 2004
		// (get) Token: 0x06003EA0 RID: 16032 RVA: 0x0001EE58 File Offset: 0x0001D058
		// (set) Token: 0x06003EA1 RID: 16033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007D4")]
		public bool DrawFlipVertical
		{
			[Token(Token = "0x6003EA0")]
			[Address(RVA = "0x1E73A20", Offset = "0x1E73A20", VA = "0x1E73A20")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003EA1")]
			[Address(RVA = "0x1E72044", Offset = "0x1E72044", VA = "0x1E72044")]
			set
			{
			}
		}

		// Token: 0x170007D5 RID: 2005
		// (get) Token: 0x06003EA2 RID: 16034 RVA: 0x0001EE70 File Offset: 0x0001D070
		// (set) Token: 0x06003EA3 RID: 16035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007D5")]
		public int DrawStepDown
		{
			[Token(Token = "0x6003EA2")]
			[Address(RVA = "0x1E73A34", Offset = "0x1E73A34", VA = "0x1E73A34")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6003EA3")]
			[Address(RVA = "0x1E721D0", Offset = "0x1E721D0", VA = "0x1E721D0")]
			set
			{
			}
		}

		// Token: 0x170007D6 RID: 2006
		// (get) Token: 0x06003EA4 RID: 16036 RVA: 0x0001EE88 File Offset: 0x0001D088
		// (set) Token: 0x06003EA5 RID: 16037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007D6")]
		public bool StyleHorizontal
		{
			[Token(Token = "0x6003EA4")]
			[Address(RVA = "0x1E73A48", Offset = "0x1E73A48", VA = "0x1E73A48")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003EA5")]
			[Address(RVA = "0x1E724E8", Offset = "0x1E724E8", VA = "0x1E724E8")]
			set
			{
			}
		}

		// Token: 0x170007D7 RID: 2007
		// (get) Token: 0x06003EA6 RID: 16038 RVA: 0x0001EEA0 File Offset: 0x0001D0A0
		// (set) Token: 0x06003EA7 RID: 16039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007D7")]
		public int Style
		{
			[Token(Token = "0x6003EA6")]
			[Address(RVA = "0x1E73A5C", Offset = "0x1E73A5C", VA = "0x1E73A5C")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6003EA7")]
			[Address(RVA = "0x1E7235C", Offset = "0x1E7235C", VA = "0x1E7235C")]
			set
			{
			}
		}

		// Token: 0x170007D8 RID: 2008
		// (get) Token: 0x06003EA8 RID: 16040 RVA: 0x0001EEB8 File Offset: 0x0001D0B8
		// (set) Token: 0x06003EA9 RID: 16041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007D8")]
		public int StyleWrapLimit
		{
			[Token(Token = "0x6003EA8")]
			[Address(RVA = "0x1E73AC8", Offset = "0x1E73AC8", VA = "0x1E73AC8")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6003EA9")]
			[Address(RVA = "0x1E72674", Offset = "0x1E72674", VA = "0x1E72674")]
			set
			{
			}
		}

		// Token: 0x170007D9 RID: 2009
		// (get) Token: 0x06003EAA RID: 16042 RVA: 0x0001EED0 File Offset: 0x0001D0D0
		// (set) Token: 0x06003EAB RID: 16043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007D9")]
		public int? StyleWrapLimitVisualOverride
		{
			[Token(Token = "0x6003EAA")]
			[Address(RVA = "0x1E73B34", Offset = "0x1E73B34", VA = "0x1E73B34")]
			get
			{
				return null;
			}
			[Token(Token = "0x6003EAB")]
			[Address(RVA = "0x1E73BD8", Offset = "0x1E73BD8", VA = "0x1E73BD8")]
			set
			{
			}
		}

		// Token: 0x170007DA RID: 2010
		// (get) Token: 0x06003EAC RID: 16044 RVA: 0x0001EEE8 File Offset: 0x0001D0E8
		// (set) Token: 0x06003EAD RID: 16045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007DA")]
		public int? styleLineSkipVisualOverride
		{
			[Token(Token = "0x6003EAC")]
			[Address(RVA = "0x1E73DB0", Offset = "0x1E73DB0", VA = "0x1E73DB0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6003EAD")]
			[Address(RVA = "0x1E73E54", Offset = "0x1E73E54", VA = "0x1E73E54")]
			set
			{
			}
		}

		// Token: 0x170007DB RID: 2011
		// (get) Token: 0x06003EAE RID: 16046 RVA: 0x0001EF00 File Offset: 0x0001D100
		// (set) Token: 0x06003EAF RID: 16047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007DB")]
		public int StyleLineSkip
		{
			[Token(Token = "0x6003EAE")]
			[Address(RVA = "0x1E7402C", Offset = "0x1E7402C", VA = "0x1E7402C")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6003EAF")]
			[Address(RVA = "0x1E74098", Offset = "0x1E74098", VA = "0x1E74098")]
			set
			{
			}
		}

		// Token: 0x170007DC RID: 2012
		// (get) Token: 0x06003EB0 RID: 16048 RVA: 0x0001EF18 File Offset: 0x0001D118
		// (set) Token: 0x06003EB1 RID: 16049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007DC")]
		public int StyleMultiplier
		{
			[Token(Token = "0x6003EB0")]
			[Address(RVA = "0x1E74224", Offset = "0x1E74224", VA = "0x1E74224")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6003EB1")]
			[Address(RVA = "0x1E72800", Offset = "0x1E72800", VA = "0x1E72800")]
			set
			{
			}
		}

		// Token: 0x170007DD RID: 2013
		// (get) Token: 0x06003EB2 RID: 16050 RVA: 0x0001EF30 File Offset: 0x0001D130
		// (set) Token: 0x06003EB3 RID: 16051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007DD")]
		public int Width
		{
			[Token(Token = "0x6003EB2")]
			[Address(RVA = "0x1E72BD4", Offset = "0x1E72BD4", VA = "0x1E72BD4")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6003EB3")]
			[Address(RVA = "0x1E70AB0", Offset = "0x1E70AB0", VA = "0x1E70AB0")]
			set
			{
			}
		}

		// Token: 0x170007DE RID: 2014
		// (get) Token: 0x06003EB4 RID: 16052 RVA: 0x0001EF48 File Offset: 0x0001D148
		// (set) Token: 0x06003EB5 RID: 16053 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007DE")]
		public int Height
		{
			[Token(Token = "0x6003EB4")]
			[Address(RVA = "0x1E74290", Offset = "0x1E74290", VA = "0x1E74290")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6003EB5")]
			[Address(RVA = "0x1E70CDC", Offset = "0x1E70CDC", VA = "0x1E70CDC")]
			set
			{
			}
		}

		// Token: 0x170007DF RID: 2015
		// (get) Token: 0x06003EB6 RID: 16054 RVA: 0x0001EF60 File Offset: 0x0001D160
		// (set) Token: 0x06003EB7 RID: 16055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007DF")]
		public Point16 Origin
		{
			[Token(Token = "0x6003EB6")]
			[Address(RVA = "0x1E742FC", Offset = "0x1E742FC", VA = "0x1E742FC")]
			get
			{
				return default(Point16);
			}
			[Token(Token = "0x6003EB7")]
			[Address(RVA = "0x1E70F08", Offset = "0x1E70F08", VA = "0x1E70F08")]
			set
			{
			}
		}

		// Token: 0x170007E0 RID: 2016
		// (get) Token: 0x06003EB8 RID: 16056 RVA: 0x0001EF78 File Offset: 0x0001D178
		// (set) Token: 0x06003EB9 RID: 16057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007E0")]
		public TileObjectDirection Direction
		{
			[Token(Token = "0x6003EB8")]
			[Address(RVA = "0x1E74368", Offset = "0x1E74368", VA = "0x1E74368")]
			get
			{
				return TileObjectDirection.None;
			}
			[Token(Token = "0x6003EB9")]
			[Address(RVA = "0x1E710D4", Offset = "0x1E710D4", VA = "0x1E710D4")]
			set
			{
			}
		}

		// Token: 0x170007E1 RID: 2017
		// (get) Token: 0x06003EBA RID: 16058 RVA: 0x0001EF90 File Offset: 0x0001D190
		// (set) Token: 0x06003EBB RID: 16059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007E1")]
		public int RandomStyleRange
		{
			[Token(Token = "0x6003EBA")]
			[Address(RVA = "0x1E743D4", Offset = "0x1E743D4", VA = "0x1E743D4")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6003EBB")]
			[Address(RVA = "0x1E71260", Offset = "0x1E71260", VA = "0x1E71260")]
			set
			{
			}
		}

		// Token: 0x170007E2 RID: 2018
		// (get) Token: 0x06003EBC RID: 16060 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06003EBD RID: 16061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007E2")]
		public int[] SpecificRandomStyles
		{
			[Token(Token = "0x6003EBC")]
			[Address(RVA = "0x1E74440", Offset = "0x1E74440", VA = "0x1E74440")]
			get
			{
				return null;
			}
			[Token(Token = "0x6003EBD")]
			[Address(RVA = "0x1E744AC", Offset = "0x1E744AC", VA = "0x1E744AC")]
			set
			{
			}
		}

		// Token: 0x170007E3 RID: 2019
		// (get) Token: 0x06003EBE RID: 16062 RVA: 0x0001EFA8 File Offset: 0x0001D1A8
		// (set) Token: 0x06003EBF RID: 16063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007E3")]
		public bool FlattenAnchors
		{
			[Token(Token = "0x6003EBE")]
			[Address(RVA = "0x1E74638", Offset = "0x1E74638", VA = "0x1E74638")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003EBF")]
			[Address(RVA = "0x1E713EC", Offset = "0x1E713EC", VA = "0x1E713EC")]
			set
			{
			}
		}

		// Token: 0x170007E4 RID: 2020
		// (get) Token: 0x06003EC0 RID: 16064 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06003EC1 RID: 16065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007E4")]
		public int[] CoordinateHeights
		{
			[Token(Token = "0x6003EC0")]
			[Address(RVA = "0x1E746A4", Offset = "0x1E746A4", VA = "0x1E746A4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6003EC1")]
			[Address(RVA = "0x1E71578", Offset = "0x1E71578", VA = "0x1E71578")]
			set
			{
			}
		}

		// Token: 0x170007E5 RID: 2021
		// (get) Token: 0x06003EC2 RID: 16066 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06003EC3 RID: 16067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007E5")]
		public Rectangle[,] DrawFrameOffsets
		{
			[Token(Token = "0x6003EC2")]
			[Address(RVA = "0x1E74710", Offset = "0x1E74710", VA = "0x1E74710")]
			get
			{
				return null;
			}
			[Token(Token = "0x6003EC3")]
			[Address(RVA = "0x1E7477C", Offset = "0x1E7477C", VA = "0x1E7477C")]
			set
			{
			}
		}

		// Token: 0x170007E6 RID: 2022
		// (get) Token: 0x06003EC4 RID: 16068 RVA: 0x0001EFC0 File Offset: 0x0001D1C0
		// (set) Token: 0x06003EC5 RID: 16069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007E6")]
		public int CoordinateWidth
		{
			[Token(Token = "0x6003EC4")]
			[Address(RVA = "0x1E749E4", Offset = "0x1E749E4", VA = "0x1E749E4")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6003EC5")]
			[Address(RVA = "0x1E717E0", Offset = "0x1E717E0", VA = "0x1E717E0")]
			set
			{
			}
		}

		// Token: 0x170007E7 RID: 2023
		// (get) Token: 0x06003EC6 RID: 16070 RVA: 0x0001EFD8 File Offset: 0x0001D1D8
		// (set) Token: 0x06003EC7 RID: 16071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007E7")]
		public int CoordinatePadding
		{
			[Token(Token = "0x6003EC6")]
			[Address(RVA = "0x1E74A50", Offset = "0x1E74A50", VA = "0x1E74A50")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6003EC7")]
			[Address(RVA = "0x1E7198C", Offset = "0x1E7198C", VA = "0x1E7198C")]
			set
			{
			}
		}

		// Token: 0x170007E8 RID: 2024
		// (get) Token: 0x06003EC8 RID: 16072 RVA: 0x0001EFF0 File Offset: 0x0001D1F0
		// (set) Token: 0x06003EC9 RID: 16073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007E8")]
		public Point16 CoordinatePaddingFix
		{
			[Token(Token = "0x6003EC8")]
			[Address(RVA = "0x1E74ABC", Offset = "0x1E74ABC", VA = "0x1E74ABC")]
			get
			{
				return default(Point16);
			}
			[Token(Token = "0x6003EC9")]
			[Address(RVA = "0x1E71B38", Offset = "0x1E71B38", VA = "0x1E71B38")]
			set
			{
			}
		}

		// Token: 0x170007E9 RID: 2025
		// (get) Token: 0x06003ECA RID: 16074 RVA: 0x0001F008 File Offset: 0x0001D208
		[Token(Token = "0x170007E9")]
		public int CoordinateFullWidth
		{
			[Token(Token = "0x6003ECA")]
			[Address(RVA = "0x1E74B28", Offset = "0x1E74B28", VA = "0x1E74B28")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170007EA RID: 2026
		// (get) Token: 0x06003ECB RID: 16075 RVA: 0x0001F020 File Offset: 0x0001D220
		[Token(Token = "0x170007EA")]
		public int CoordinateFullHeight
		{
			[Token(Token = "0x6003ECB")]
			[Address(RVA = "0x1E74BB8", Offset = "0x1E74BB8", VA = "0x1E74BB8")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170007EB RID: 2027
		// (get) Token: 0x06003ECC RID: 16076 RVA: 0x0001F038 File Offset: 0x0001D238
		// (set) Token: 0x06003ECD RID: 16077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007EB")]
		public int DrawStyleOffset
		{
			[Token(Token = "0x6003ECC")]
			[Address(RVA = "0x1E74C48", Offset = "0x1E74C48", VA = "0x1E74C48")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6003ECD")]
			[Address(RVA = "0x1E74CB4", Offset = "0x1E74CB4", VA = "0x1E74CB4")]
			set
			{
			}
		}

		// Token: 0x06003ECE RID: 16078 RVA: 0x0001F050 File Offset: 0x0001D250
		[Token(Token = "0x6003ECE")]
		[Address(RVA = "0x1E74E60", Offset = "0x1E74E60", VA = "0x1E74E60")]
		public bool LiquidPlace(Tile checkTile)
		{
			return default(bool);
		}

		// Token: 0x170007EC RID: 2028
		// (get) Token: 0x06003ECF RID: 16079 RVA: 0x0001F068 File Offset: 0x0001D268
		[Token(Token = "0x170007EC")]
		public int AlternatesCount
		{
			[Token(Token = "0x6003ECF")]
			[Address(RVA = "0x1E75374", Offset = "0x1E75374", VA = "0x1E75374")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06003ED0 RID: 16080 RVA: 0x0001F080 File Offset: 0x0001D280
		[Token(Token = "0x6003ED0")]
		[Address(RVA = "0x1E75428", Offset = "0x1E75428", VA = "0x1E75428")]
		public bool isValidTileAnchor(int type)
		{
			return default(bool);
		}

		// Token: 0x06003ED1 RID: 16081 RVA: 0x0001F098 File Offset: 0x0001D298
		[Token(Token = "0x6003ED1")]
		[Address(RVA = "0x1E754B4", Offset = "0x1E754B4", VA = "0x1E754B4")]
		public bool isValidWallAnchor(int type)
		{
			return default(bool);
		}

		// Token: 0x06003ED2 RID: 16082 RVA: 0x0001F0B0 File Offset: 0x0001D2B0
		[Token(Token = "0x6003ED2")]
		[Address(RVA = "0x1E75510", Offset = "0x1E75510", VA = "0x1E75510")]
		public bool isValidAlternateAnchor(int type)
		{
			return default(bool);
		}

		// Token: 0x06003ED3 RID: 16083 RVA: 0x0001F0C8 File Offset: 0x0001D2C8
		[Token(Token = "0x6003ED3")]
		[Address(RVA = "0x1E75564", Offset = "0x1E75564", VA = "0x1E75564")]
		public int CalculatePlacementStyle(int style, int alternate, int random)
		{
			return 0;
		}

		// Token: 0x06003ED4 RID: 16084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003ED4")]
		[Address(RVA = "0x1E75640", Offset = "0x1E75640", VA = "0x1E75640")]
		private static void addBaseTile(out TileObjectData baseTile)
		{
		}

		// Token: 0x06003ED5 RID: 16085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003ED5")]
		[Address(RVA = "0x1E75794", Offset = "0x1E75794", VA = "0x1E75794")]
		private static void addTile(int tileType)
		{
		}

		// Token: 0x06003ED6 RID: 16086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003ED6")]
		[Address(RVA = "0x1E75908", Offset = "0x1E75908", VA = "0x1E75908")]
		private static void addSubTile(int[] styles)
		{
		}

		// Token: 0x06003ED7 RID: 16087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003ED7")]
		[Address(RVA = "0x1E75D58", Offset = "0x1E75D58", VA = "0x1E75D58")]
		private static void addSubTileRange(int startStyle, int styleCount)
		{
		}

		// Token: 0x06003ED8 RID: 16088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003ED8")]
		[Address(RVA = "0x1E7619C", Offset = "0x1E7619C", VA = "0x1E7619C")]
		private static void addSubTile(int style)
		{
		}

		// Token: 0x06003ED9 RID: 16089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003ED9")]
		[Address(RVA = "0x1E765AC", Offset = "0x1E765AC", VA = "0x1E765AC")]
		private static void addAlternate(int baseStyle)
		{
		}

		// Token: 0x06003EDA RID: 16090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EDA")]
		[Address(RVA = "0x1E17BA4", Offset = "0x1E17BA4", VA = "0x1E17BA4")]
		public static void Initialize()
		{
		}

		// Token: 0x06003EDB RID: 16091 RVA: 0x0001F0E0 File Offset: 0x0001D2E0
		[Token(Token = "0x6003EDB")]
		[Address(RVA = "0x1E76950", Offset = "0x1E76950", VA = "0x1E76950")]
		public static bool CustomPlace(int type, int style)
		{
			return default(bool);
		}

		// Token: 0x06003EDC RID: 16092 RVA: 0x0001F0F8 File Offset: 0x0001D2F8
		[Token(Token = "0x6003EDC")]
		[Address(RVA = "0x1E76ACC", Offset = "0x1E76ACC", VA = "0x1E76ACC")]
		public static bool CheckLiquidPlacement(int type, int style, Tile checkTile)
		{
			return default(bool);
		}

		// Token: 0x06003EDD RID: 16093 RVA: 0x0001F110 File Offset: 0x0001D310
		[Token(Token = "0x6003EDD")]
		[Address(RVA = "0x1E76B04", Offset = "0x1E76B04", VA = "0x1E76B04")]
		public static bool LiquidPlace(int type, Tile checkTile)
		{
			return default(bool);
		}

		// Token: 0x06003EDE RID: 16094 RVA: 0x0001F128 File Offset: 0x0001D328
		[Token(Token = "0x6003EDE")]
		[Address(RVA = "0x1E76CD0", Offset = "0x1E76CD0", VA = "0x1E76CD0")]
		public static bool CheckWaterDeath(int type, int style)
		{
			return default(bool);
		}

		// Token: 0x06003EDF RID: 16095 RVA: 0x0001F140 File Offset: 0x0001D340
		[Token(Token = "0x6003EDF")]
		[Address(RVA = "0x1E76DE4", Offset = "0x1E76DE4", VA = "0x1E76DE4")]
		public static bool CheckWaterDeath(int x, int y, ref TileData.TileDataPointers tileData)
		{
			return default(bool);
		}

		// Token: 0x06003EE0 RID: 16096 RVA: 0x0001F158 File Offset: 0x0001D358
		[Token(Token = "0x6003EE0")]
		[Address(RVA = "0x1E77768", Offset = "0x1E77768", VA = "0x1E77768")]
		public static bool CheckWaterDeath(Tile checkTile)
		{
			return default(bool);
		}

		// Token: 0x06003EE1 RID: 16097 RVA: 0x0001F170 File Offset: 0x0001D370
		[Token(Token = "0x6003EE1")]
		[Address(RVA = "0x1E783F8", Offset = "0x1E783F8", VA = "0x1E783F8")]
		public static bool CheckLavaDeath(int type, int style)
		{
			return default(bool);
		}

		// Token: 0x06003EE2 RID: 16098 RVA: 0x0001F188 File Offset: 0x0001D388
		[Token(Token = "0x6003EE2")]
		[Address(RVA = "0x1E7850C", Offset = "0x1E7850C", VA = "0x1E7850C")]
		public static bool CheckLavaDeath(int x, int y, ref TileData.TileDataPointers tileData)
		{
			return default(bool);
		}

		// Token: 0x06003EE3 RID: 16099 RVA: 0x0001F1A0 File Offset: 0x0001D3A0
		[Token(Token = "0x6003EE3")]
		[Address(RVA = "0x1E78654", Offset = "0x1E78654", VA = "0x1E78654")]
		public static bool CheckLavaDeath(Tile checkTile)
		{
			return default(bool);
		}

		// Token: 0x06003EE4 RID: 16100 RVA: 0x0001F1B8 File Offset: 0x0001D3B8
		[Token(Token = "0x6003EE4")]
		[Address(RVA = "0x1E78888", Offset = "0x1E78888", VA = "0x1E78888")]
		public static int PlatformFrameWidth()
		{
			return 0;
		}

		// Token: 0x06003EE5 RID: 16101 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EE5")]
		[Address(RVA = "0x1E6E1F8", Offset = "0x1E6E1F8", VA = "0x1E6E1F8")]
		public static TileObjectData GetTileData(int type, int style, int alternate = 0)
		{
			return null;
		}

		// Token: 0x06003EE6 RID: 16102 RVA: 0x0001F1D0 File Offset: 0x0001D3D0
		[Token(Token = "0x6003EE6")]
		[Address(RVA = "0x1E78998", Offset = "0x1E78998", VA = "0x1E78998")]
		public static bool TryGetTileBounds(int x, int y, out Rectangle bounds)
		{
			return default(bool);
		}

		// Token: 0x06003EE7 RID: 16103 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EE7")]
		[Address(RVA = "0x1E76F28", Offset = "0x1E76F28", VA = "0x1E76F28")]
		public static TileObjectData GetTileData(int x, int y, ref TileData.TileDataPointers tileData)
		{
			return null;
		}

		// Token: 0x06003EE8 RID: 16104 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EE8")]
		[Address(RVA = "0x1E7799C", Offset = "0x1E7799C", VA = "0x1E7799C")]
		public static TileObjectData GetTileData(Tile getTile)
		{
			return null;
		}

		// Token: 0x06003EE9 RID: 16105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EE9")]
		[Address(RVA = "0x1E79038", Offset = "0x1E79038", VA = "0x1E79038")]
		public static void SyncObjectPlacement(int tileX, int tileY, int type, int style, int dir)
		{
		}

		// Token: 0x06003EEA RID: 16106 RVA: 0x0001F1E8 File Offset: 0x0001D3E8
		[Token(Token = "0x6003EEA")]
		[Address(RVA = "0x1E7910C", Offset = "0x1E7910C", VA = "0x1E7910C")]
		public static bool CallPostPlacementPlayerHook(int tileX, int tileY, int type, int style, int dir, int alternate, TileObject data)
		{
			return default(bool);
		}

		// Token: 0x06003EEB RID: 16107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EEB")]
		[Address(RVA = "0x1E7929C", Offset = "0x1E7929C", VA = "0x1E7929C")]
		public static void OriginToTopLeft(int type, int style, ref Point16 baseCoords)
		{
		}

		// Token: 0x06003EEC RID: 16108 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EEC")]
		[Address(RVA = "0x1E793B4", Offset = "0x1E793B4", VA = "0x1E793B4")]
		public static TileObjectData GetStyle_Detritus(Tile tile, TileObjectData current)
		{
			return null;
		}

		// Token: 0x06003EED RID: 16109 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EED")]
		[Address(RVA = "0x1E79534", Offset = "0x1E79534", VA = "0x1E79534")]
		public static TileObjectData GetStyle_SmallPiles(Tile tile, TileObjectData current)
		{
			return null;
		}

		// Token: 0x06003EEE RID: 16110 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EEE")]
		[Address(RVA = "0x1E796B4", Offset = "0x1E796B4", VA = "0x1E796B4")]
		public static TileObjectData GetStyle_Stalactite(Tile tile, TileObjectData current)
		{
			return null;
		}

		// Token: 0x040048BB RID: 18619
		[Token(Token = "0x40048BB")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private TileObjectData _parent;

		// Token: 0x040048BC RID: 18620
		[Token(Token = "0x40048BC")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private bool _linkedAlternates;

		// Token: 0x040048BD RID: 18621
		[Token(Token = "0x40048BD")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xD")]
		private bool _usesCustomCanPlace;

		// Token: 0x040048BE RID: 18622
		[Token(Token = "0x40048BE")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xE")]
		private bool _useGlobalLiquidChecks;

		// Token: 0x040048BF RID: 18623
		[Token(Token = "0x40048BF")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private TileObjectAlternatesModule _alternates;

		// Token: 0x040048C0 RID: 18624
		[Token(Token = "0x40048C0")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private AnchorDataModule _anchor;

		// Token: 0x040048C1 RID: 18625
		[Token(Token = "0x40048C1")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private AnchorTypesModule _anchorTiles;

		// Token: 0x040048C2 RID: 18626
		[Token(Token = "0x40048C2")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private LiquidDeathModule _liquidDeath;

		// Token: 0x040048C3 RID: 18627
		[Token(Token = "0x40048C3")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private LiquidPlacementModule _liquidPlacement;

		// Token: 0x040048C4 RID: 18628
		[Token(Token = "0x40048C4")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private TilePlacementHooksModule _placementHooks;

		// Token: 0x040048C5 RID: 18629
		[Token(Token = "0x40048C5")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TileObjectSubTilesModule _subTiles;

		// Token: 0x040048C6 RID: 18630
		[Token(Token = "0x40048C6")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private TileObjectDrawModule _tileObjectDraw;

		// Token: 0x040048C7 RID: 18631
		[Token(Token = "0x40048C7")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TileObjectStyleModule _tileObjectStyle;

		// Token: 0x040048C8 RID: 18632
		[Token(Token = "0x40048C8")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private TileObjectBaseModule _tileObjectBase;

		// Token: 0x040048C9 RID: 18633
		[Token(Token = "0x40048C9")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private TileObjectCoordinatesModule _tileObjectCoords;

		// Token: 0x040048CA RID: 18634
		[Token(Token = "0x40048CA")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private bool _hasOwnAlternates;

		// Token: 0x040048CB RID: 18635
		[Token(Token = "0x40048CB")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
		private bool _hasOwnAnchor;

		// Token: 0x040048CC RID: 18636
		[Token(Token = "0x40048CC")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x3E")]
		private bool _hasOwnAnchorTiles;

		// Token: 0x040048CD RID: 18637
		[Token(Token = "0x40048CD")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x3F")]
		private bool _hasOwnLiquidDeath;

		// Token: 0x040048CE RID: 18638
		[Token(Token = "0x40048CE")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool _hasOwnLiquidPlacement;

		// Token: 0x040048CF RID: 18639
		[Token(Token = "0x40048CF")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x41")]
		private bool _hasOwnPlacementHooks;

		// Token: 0x040048D0 RID: 18640
		[Token(Token = "0x40048D0")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x42")]
		private bool _hasOwnSubTiles;

		// Token: 0x040048D1 RID: 18641
		[Token(Token = "0x40048D1")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x43")]
		private bool _hasOwnTileObjectBase;

		// Token: 0x040048D2 RID: 18642
		[Token(Token = "0x40048D2")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private bool _hasOwnTileObjectDraw;

		// Token: 0x040048D3 RID: 18643
		[Token(Token = "0x40048D3")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x45")]
		private bool _hasOwnTileObjectStyle;

		// Token: 0x040048D4 RID: 18644
		[Token(Token = "0x40048D4")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x46")]
		private bool _hasOwnTileObjectCoords;

		// Token: 0x040048D5 RID: 18645
		[Token(Token = "0x40048D5")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static List<TileObjectData> _data;

		// Token: 0x040048D6 RID: 18646
		[Token(Token = "0x40048D6")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static TileObjectData _baseObject;

		// Token: 0x040048D7 RID: 18647
		[Token(Token = "0x40048D7")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static bool readOnlyData;

		// Token: 0x040048D8 RID: 18648
		[Token(Token = "0x40048D8")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private static TileObjectData newTile;

		// Token: 0x040048D9 RID: 18649
		[Token(Token = "0x40048D9")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static TileObjectData newSubTile;

		// Token: 0x040048DA RID: 18650
		[Token(Token = "0x40048DA")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private static TileObjectData newAlternate;

		// Token: 0x040048DB RID: 18651
		[Token(Token = "0x40048DB")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static TileObjectData StyleSwitch;

		// Token: 0x040048DC RID: 18652
		[Token(Token = "0x40048DC")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private static TileObjectData StyleTorch;

		// Token: 0x040048DD RID: 18653
		[Token(Token = "0x40048DD")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static TileObjectData Style4x2;

		// Token: 0x040048DE RID: 18654
		[Token(Token = "0x40048DE")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private static TileObjectData Style2x2;

		// Token: 0x040048DF RID: 18655
		[Token(Token = "0x40048DF")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static TileObjectData Style1x2;

		// Token: 0x040048E0 RID: 18656
		[Token(Token = "0x40048E0")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private static TileObjectData Style1x1;

		// Token: 0x040048E1 RID: 18657
		[Token(Token = "0x40048E1")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static TileObjectData StyleAlch;

		// Token: 0x040048E2 RID: 18658
		[Token(Token = "0x40048E2")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private static TileObjectData StyleDye;

		// Token: 0x040048E3 RID: 18659
		[Token(Token = "0x40048E3")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static TileObjectData Style2x1;

		// Token: 0x040048E4 RID: 18660
		[Token(Token = "0x40048E4")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private static TileObjectData Style6x3;

		// Token: 0x040048E5 RID: 18661
		[Token(Token = "0x40048E5")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static TileObjectData StyleSmallCage;

		// Token: 0x040048E6 RID: 18662
		[Token(Token = "0x40048E6")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private static TileObjectData StyleOnTable1x1;

		// Token: 0x040048E7 RID: 18663
		[Token(Token = "0x40048E7")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static TileObjectData Style1x2Top;

		// Token: 0x040048E8 RID: 18664
		[Token(Token = "0x40048E8")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private static TileObjectData Style1xX;

		// Token: 0x040048E9 RID: 18665
		[Token(Token = "0x40048E9")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static TileObjectData Style2xX;

		// Token: 0x040048EA RID: 18666
		[Token(Token = "0x40048EA")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private static TileObjectData Style3x2;

		// Token: 0x040048EB RID: 18667
		[Token(Token = "0x40048EB")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static TileObjectData Style3x3;

		// Token: 0x040048EC RID: 18668
		[Token(Token = "0x40048EC")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private static TileObjectData Style3x4;

		// Token: 0x040048ED RID: 18669
		[Token(Token = "0x40048ED")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static TileObjectData Style4x4;

		// Token: 0x040048EE RID: 18670
		[Token(Token = "0x40048EE")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private static TileObjectData Style5x4;

		// Token: 0x040048EF RID: 18671
		[Token(Token = "0x40048EF")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static TileObjectData Style3x3Wall;

		// Token: 0x040048F0 RID: 18672
		[Token(Token = "0x40048F0")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private static TileObjectData Style1x1Drip;

		// Token: 0x040048F1 RID: 18673
		[Token(Token = "0x40048F1")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static TileObjectData Style1x1Plant_Height22;

		// Token: 0x040048F2 RID: 18674
		[Token(Token = "0x40048F2")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private static TileObjectData Style1x1Plant_Height34;
	}
}
