using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.GameContent.Generation.Dungeon;

namespace Terraria.WorldBuilding
{
	// Token: 0x02000549 RID: 1353
	[Token(Token = "0x2000549")]
	public static class Actions
	{
		// Token: 0x060039F5 RID: 14837 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60039F5")]
		[Address(RVA = "0x1DFBB64", Offset = "0x1DFBB64", VA = "0x1DFBB64")]
		public static GenAction Chain(GenAction[] actions)
		{
			return null;
		}

		// Token: 0x060039F6 RID: 14838 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60039F6")]
		[Address(RVA = "0x1DFBBDC", Offset = "0x1DFBBDC", VA = "0x1DFBBDC")]
		public static GenAction Continue(GenAction action)
		{
			return null;
		}

		// Token: 0x0200054A RID: 1354
		[Token(Token = "0x200054A")]
		public class ContinueWrapper : GenAction
		{
			// Token: 0x060039F7 RID: 14839 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60039F7")]
			[Address(RVA = "0x1DFBC58", Offset = "0x1DFBC58", VA = "0x1DFBC58")]
			public ContinueWrapper(GenAction action)
			{
			}

			// Token: 0x060039F8 RID: 14840 RVA: 0x0001D220 File Offset: 0x0001B420
			[Token(Token = "0x60039F8")]
			[Address(RVA = "0x1DFBC80", Offset = "0x1DFBC80", VA = "0x1DFBC80", Slot = "4")]
			public override bool Apply(Point origin, int x, int y, object[] args)
			{
				return default(bool);
			}

			// Token: 0x040045D0 RID: 17872
			[Token(Token = "0x40045D0")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private GenAction _action;
		}

		// Token: 0x0200054B RID: 1355
		[Token(Token = "0x200054B")]
		public class Count : GenAction
		{
			// Token: 0x060039F9 RID: 14841 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60039F9")]
			[Address(RVA = "0x1DFBD38", Offset = "0x1DFBD38", VA = "0x1DFBD38")]
			public Count(Ref<int> count)
			{
			}

			// Token: 0x060039FA RID: 14842 RVA: 0x0001D238 File Offset: 0x0001B438
			[Token(Token = "0x60039FA")]
			[Address(RVA = "0x1DFBD60", Offset = "0x1DFBD60", VA = "0x1DFBD60", Slot = "4")]
			public override bool Apply(Point origin, int x, int y, object[] args)
			{
				return default(bool);
			}

			// Token: 0x040045D1 RID: 17873
			[Token(Token = "0x40045D1")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private Ref<int> _count;
		}

		// Token: 0x0200054C RID: 1356
		[Token(Token = "0x200054C")]
		public class Scanner : GenAction
		{
			// Token: 0x060039FB RID: 14843 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60039FB")]
			[Address(RVA = "0x1DFBE04", Offset = "0x1DFBE04", VA = "0x1DFBE04")]
			public Scanner(Ref<int> count)
			{
			}

			// Token: 0x060039FC RID: 14844 RVA: 0x0001D250 File Offset: 0x0001B450
			[Token(Token = "0x60039FC")]
			[Address(RVA = "0x1DFBE2C", Offset = "0x1DFBE2C", VA = "0x1DFBE2C", Slot = "4")]
			public override bool Apply(Point origin, int x, int y, object[] args)
			{
				return default(bool);
			}

			// Token: 0x040045D2 RID: 17874
			[Token(Token = "0x40045D2")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private Ref<int> _count;
		}

		// Token: 0x0200054D RID: 1357
		[Token(Token = "0x200054D")]
		public class TileScanner : GenAction
		{
			// Token: 0x060039FD RID: 14845 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60039FD")]
			[Address(RVA = "0x1DFBED0", Offset = "0x1DFBED0", VA = "0x1DFBED0")]
			public TileScanner(ushort[] tiles)
			{
			}

			// Token: 0x060039FE RID: 14846 RVA: 0x0001D268 File Offset: 0x0001B468
			[Token(Token = "0x60039FE")]
			[Address(RVA = "0x1DFC008", Offset = "0x1DFC008", VA = "0x1DFC008", Slot = "4")]
			public override bool Apply(Point origin, int x, int y, object[] args)
			{
				return default(bool);
			}

			// Token: 0x060039FF RID: 14847 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60039FF")]
			[Address(RVA = "0x1DFC3AC", Offset = "0x1DFC3AC", VA = "0x1DFC3AC")]
			public Actions.TileScanner Output(Dictionary<ushort, int> resultsOutput)
			{
				return null;
			}

			// Token: 0x06003A00 RID: 14848 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003A00")]
			[Address(RVA = "0x1DFC4CC", Offset = "0x1DFC4CC", VA = "0x1DFC4CC")]
			public Dictionary<ushort, int> GetResults()
			{
				return null;
			}

			// Token: 0x06003A01 RID: 14849 RVA: 0x0001D280 File Offset: 0x0001B480
			[Token(Token = "0x6003A01")]
			[Address(RVA = "0x1DFC4D4", Offset = "0x1DFC4D4", VA = "0x1DFC4D4")]
			public int GetCount(ushort tileId)
			{
				return 0;
			}

			// Token: 0x040045D3 RID: 17875
			[Token(Token = "0x40045D3")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private ushort[] _tileIds;

			// Token: 0x040045D4 RID: 17876
			[Token(Token = "0x40045D4")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private Dictionary<ushort, int> _tileCounts;
		}

		// Token: 0x0200054E RID: 1358
		[Token(Token = "0x200054E")]
		public class Blank : GenAction
		{
			// Token: 0x06003A02 RID: 14850 RVA: 0x0001D298 File Offset: 0x0001B498
			[Token(Token = "0x6003A02")]
			[Address(RVA = "0x1DFC58C", Offset = "0x1DFC58C", VA = "0x1DFC58C", Slot = "4")]
			public override bool Apply(Point origin, int x, int y, object[] args)
			{
				return default(bool);
			}

			// Token: 0x06003A03 RID: 14851 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003A03")]
			[Address(RVA = "0x1DFC604", Offset = "0x1DFC604", VA = "0x1DFC604")]
			public Blank()
			{
			}
		}

		// Token: 0x0200054F RID: 1359
		[Token(Token = "0x200054F")]
		public class Custom : GenAction
		{
			// Token: 0x06003A04 RID: 14852 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003A04")]
			[Address(RVA = "0x1DFC614", Offset = "0x1DFC614", VA = "0x1DFC614")]
			public Custom(GenBase.CustomPerUnitAction perUnit)
			{
			}

			// Token: 0x06003A05 RID: 14853 RVA: 0x0001D2B0 File Offset: 0x0001B4B0
			[Token(Token = "0x6003A05")]
			[Address(RVA = "0x1DFC63C", Offset = "0x1DFC63C", VA = "0x1DFC63C", Slot = "4")]
			public override bool Apply(Point origin, int x, int y, object[] args)
			{
				return default(bool);
			}

			// Token: 0x040045D5 RID: 17877
			[Token(Token = "0x40045D5")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private GenBase.CustomPerUnitAction _perUnit;
		}

		// Token: 0x02000550 RID: 1360
		[Token(Token = "0x2000550")]
		public class ClearMetadata : GenAction
		{
			// Token: 0x06003A06 RID: 14854 RVA: 0x0001D2C8 File Offset: 0x0001B4C8
			[Token(Token = "0x6003A06")]
			[Address(RVA = "0x1DFC6EC", Offset = "0x1DFC6EC", VA = "0x1DFC6EC", Slot = "4")]
			public override bool Apply(Point origin, int x, int y, object[] args)
			{
				return default(bool);
			}

			// Token: 0x06003A07 RID: 14855 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003A07")]
			[Address(RVA = "0x1DFC84C", Offset = "0x1DFC84C", VA = "0x1DFC84C")]
			public ClearMetadata()
			{
			}
		}

		// Token: 0x02000551 RID: 1361
		[Token(Token = "0x2000551")]
		public class Clear : GenAction
		{
			// Token: 0x06003A08 RID: 14856 RVA: 0x0001D2E0 File Offset: 0x0001B4E0
			[Token(Token = "0x6003A08")]
			[Address(RVA = "0x1DFC85C", Offset = "0x1DFC85C", VA = "0x1DFC85C", Slot = "4")]
			public override bool Apply(Point origin, int x, int y, object[] args)
			{
				return default(bool);
			}

			// Token: 0x06003A09 RID: 14857 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003A09")]
			[Address(RVA = "0x1DFCA14", Offset = "0x1DFCA14", VA = "0x1DFCA14")]
			public Clear()
			{
			}
		}

		// Token: 0x02000552 RID: 1362
		[Token(Token = "0x2000552")]
		public class ClearTile : GenAction
		{
			// Token: 0x06003A0A RID: 14858 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003A0A")]
			[Address(RVA = "0x1DFCA24", Offset = "0x1DFCA24", VA = "0x1DFCA24")]
			public ClearTile(bool frameNeighbors = false)
			{
			}

			// Token: 0x06003A0B RID: 14859 RVA: 0x0001D2F8 File Offset: 0x0001B4F8
			[Token(Token = "0x6003A0B")]
			[Address(RVA = "0x1DFCA4C", Offset = "0x1DFCA4C", VA = "0x1DFCA4C", Slot = "4")]
			public override bool Apply(Point origin, int x, int y, object[] args)
			{
				return default(bool);
			}

			// Token: 0x040045D6 RID: 17878
			[Token(Token = "0x40045D6")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x11")]
			private bool _frameNeighbors;
		}

		// Token: 0x02000553 RID: 1363
		[Token(Token = "0x2000553")]
		public class ClearWall : GenAction
		{
			// Token: 0x06003A0C RID: 14860 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003A0C")]
			[Address(RVA = "0x1DFCCC0", Offset = "0x1DFCCC0", VA = "0x1DFCCC0")]
			public ClearWall(bool frameNeighbors = false)
			{
			}

			// Token: 0x06003A0D RID: 14861 RVA: 0x0001D310 File Offset: 0x0001B510
			[Token(Token = "0x6003A0D")]
			[Address(RVA = "0x1DFCCE8", Offset = "0x1DFCCE8", VA = "0x1DFCCE8", Slot = "4")]
			public override bool Apply(Point origin, int x, int y, object[] args)
			{
				return default(bool);
			}

			// Token: 0x040045D7 RID: 17879
			[Token(Token = "0x40045D7")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x11")]
			private bool _frameNeighbors;
		}

		// Token: 0x02000554 RID: 1364
		[Token(Token = "0x2000554")]
		public class HalfBlock : GenAction
		{
			// Token: 0x06003A0E RID: 14862 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003A0E")]
			[Address(RVA = "0x1DFCF28", Offset = "0x1DFCF28", VA = "0x1DFCF28")]
			public HalfBlock(bool value = true)
			{
			}

			// Token: 0x06003A0F RID: 14863 RVA: 0x0001D328 File Offset: 0x0001B528
			[Token(Token = "0x6003A0F")]
			[Address(RVA = "0x1DFCF50", Offset = "0x1DFCF50", VA = "0x1DFCF50", Slot = "4")]
			public override bool Apply(Point origin, int x, int y, object[] args)
			{
				return default(bool);
			}

			// Token: 0x040045D8 RID: 17880
			[Token(Token = "0x40045D8")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x11")]
			private bool _value;
		}

		// Token: 0x02000555 RID: 1365
		[Token(Token = "0x2000555")]
		public class SetTile : GenAction
		{
			// Token: 0x06003A10 RID: 14864 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003A10")]
			[Address(RVA = "0x1DFD128", Offset = "0x1DFD128", VA = "0x1DFD128")]
			public SetTile(ushort type, bool setSelfFrames = false, bool setNeighborFrames = true, bool clearTile = true)
			{
			}

			// Token: 0x06003A11 RID: 14865 RVA: 0x0001D340 File Offset: 0x0001B540
			[Token(Token = "0x6003A11")]
			[Address(RVA = "0x1DFD168", Offset = "0x1DFD168", VA = "0x1DFD168", Slot = "4")]
			public override bool Apply(Point origin, int x, int y, object[] args)
			{
				return default(bool);
			}

			// Token: 0x040045D9 RID: 17881
			[Token(Token = "0x40045D9")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x12")]
			private ushort _type;

			// Token: 0x040045DA RID: 17882
			[Token(Token = "0x40045DA")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private bool _doFraming;

			// Token: 0x040045DB RID: 17883
			[Token(Token = "0x40045DB")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x15")]
			private bool _doNeighborFraming;

			// Token: 0x040045DC RID: 17884
			[Token(Token = "0x40045DC")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x16")]
			private bool _clearTile;
		}

		// Token: 0x02000556 RID: 1366
		[Token(Token = "0x2000556")]
		public class SetWall : GenAction
		{
			// Token: 0x06003A12 RID: 14866 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003A12")]
			[Address(RVA = "0x1DFD514", Offset = "0x1DFD514", VA = "0x1DFD514")]
			public SetWall(ushort type, bool setSelfFrames = false, bool setNeighborFrames = true, bool clearTile = true)
			{
			}

			// Token: 0x06003A13 RID: 14867 RVA: 0x0001D358 File Offset: 0x0001B558
			[Token(Token = "0x6003A13")]
			[Address(RVA = "0x1DFD554", Offset = "0x1DFD554", VA = "0x1DFD554", Slot = "4")]
			public override bool Apply(Point origin, int x, int y, object[] args)
			{
				return default(bool);
			}

			// Token: 0x040045DD RID: 17885
			[Token(Token = "0x40045DD")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x12")]
			private ushort _type;

			// Token: 0x040045DE RID: 17886
			[Token(Token = "0x40045DE")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private bool _doFraming;

			// Token: 0x040045DF RID: 17887
			[Token(Token = "0x40045DF")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x15")]
			private bool _doNeighborFraming;

			// Token: 0x040045E0 RID: 17888
			[Token(Token = "0x40045E0")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x16")]
			private bool _clearTile;
		}

		// Token: 0x02000557 RID: 1367
		[Token(Token = "0x2000557")]
		public class SetTileKeepWall : GenAction
		{
			// Token: 0x06003A14 RID: 14868 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003A14")]
			[Address(RVA = "0x1DFD7E0", Offset = "0x1DFD7E0", VA = "0x1DFD7E0")]
			public SetTileKeepWall(ushort type, bool setSelfFrames = false, bool setNeighborFrames = true)
			{
			}

			// Token: 0x06003A15 RID: 14869 RVA: 0x0001D370 File Offset: 0x0001B570
			[Token(Token = "0x6003A15")]
			[Address(RVA = "0x1DFD818", Offset = "0x1DFD818", VA = "0x1DFD818", Slot = "4")]
			public override bool Apply(Point origin, int x, int y, object[] args)
			{
				return default(bool);
			}

			// Token: 0x040045E1 RID: 17889
			[Token(Token = "0x40045E1")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x12")]
			private ushort _type;

			// Token: 0x040045E2 RID: 17890
			[Token(Token = "0x40045E2")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private bool _doFraming;

			// Token: 0x040045E3 RID: 17891
			[Token(Token = "0x40045E3")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x15")]
			private bool _doNeighborFraming;
		}

		// Token: 0x02000558 RID: 1368
		[Token(Token = "0x2000558")]
		public class UpdateBounds : GenAction
		{
			// Token: 0x06003A16 RID: 14870 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003A16")]
			[Address(RVA = "0x1DFDD2C", Offset = "0x1DFDD2C", VA = "0x1DFDD2C")]
			public UpdateBounds(DungeonBounds bounds)
			{
			}

			// Token: 0x06003A17 RID: 14871 RVA: 0x0001D388 File Offset: 0x0001B588
			[Token(Token = "0x6003A17")]
			[Address(RVA = "0x1DFDD54", Offset = "0x1DFDD54", VA = "0x1DFDD54", Slot = "4")]
			public override bool Apply(Point origin, int x, int y, object[] args)
			{
				return default(bool);
			}

			// Token: 0x040045E4 RID: 17892
			[Token(Token = "0x40045E4")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private DungeonBounds _bounds;
		}

		// Token: 0x02000559 RID: 1369
		[Token(Token = "0x2000559")]
		public class DebugDraw : GenAction
		{
			// Token: 0x06003A18 RID: 14872 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003A18")]
			[Address(RVA = "0x1DFDDF0", Offset = "0x1DFDDF0", VA = "0x1DFDDF0")]
			public DebugDraw(SpriteBatch spriteBatch, [Optional] Color color)
			{
			}

			// Token: 0x06003A19 RID: 14873 RVA: 0x0001D3A0 File Offset: 0x0001B5A0
			[Token(Token = "0x6003A19")]
			[Address(RVA = "0x1DFDE20", Offset = "0x1DFDE20", VA = "0x1DFDE20", Slot = "4")]
			public override bool Apply(Point origin, int x, int y, object[] args)
			{
				return default(bool);
			}

			// Token: 0x040045E5 RID: 17893
			[Token(Token = "0x40045E5")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x11")]
			private Color _color;

			// Token: 0x040045E6 RID: 17894
			[Token(Token = "0x40045E6")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private SpriteBatch _spriteBatch;
		}

		// Token: 0x0200055A RID: 1370
		[Token(Token = "0x200055A")]
		public class SetSlope : GenAction
		{
			// Token: 0x06003A1A RID: 14874 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003A1A")]
			[Address(RVA = "0x1DFDFF8", Offset = "0x1DFDFF8", VA = "0x1DFDFF8")]
			public SetSlope(int slope)
			{
			}

			// Token: 0x06003A1B RID: 14875 RVA: 0x0001D3B8 File Offset: 0x0001B5B8
			[Token(Token = "0x6003A1B")]
			[Address(RVA = "0x1DFE020", Offset = "0x1DFE020", VA = "0x1DFE020", Slot = "4")]
			public override bool Apply(Point origin, int x, int y, object[] args)
			{
				return default(bool);
			}

			// Token: 0x040045E7 RID: 17895
			[Token(Token = "0x40045E7")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private int _slope;
		}

		// Token: 0x0200055B RID: 1371
		[Token(Token = "0x200055B")]
		public class SetHalfTile : GenAction
		{
			// Token: 0x06003A1C RID: 14876 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003A1C")]
			[Address(RVA = "0x1DFE110", Offset = "0x1DFE110", VA = "0x1DFE110")]
			public SetHalfTile(bool halfTile)
			{
			}

			// Token: 0x06003A1D RID: 14877 RVA: 0x0001D3D0 File Offset: 0x0001B5D0
			[Token(Token = "0x6003A1D")]
			[Address(RVA = "0x1DFE138", Offset = "0x1DFE138", VA = "0x1DFE138", Slot = "4")]
			public override bool Apply(Point origin, int x, int y, object[] args)
			{
				return default(bool);
			}

			// Token: 0x040045E8 RID: 17896
			[Token(Token = "0x40045E8")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x11")]
			private bool _halfTile;
		}

		// Token: 0x0200055C RID: 1372
		[Token(Token = "0x200055C")]
		public class SetTilePaint : GenAction
		{
			// Token: 0x06003A1E RID: 14878 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003A1E")]
			[Address(RVA = "0x1DFE310", Offset = "0x1DFE310", VA = "0x1DFE310")]
			public SetTilePaint(byte? paintID)
			{
			}

			// Token: 0x06003A1F RID: 14879 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003A1F")]
			[Address(RVA = "0x1DFE3B0", Offset = "0x1DFE3B0", VA = "0x1DFE3B0")]
			public SetTilePaint(byte paintID)
			{
			}

			// Token: 0x06003A20 RID: 14880 RVA: 0x0001D3E8 File Offset: 0x0001B5E8
			[Token(Token = "0x6003A20")]
			[Address(RVA = "0x1DFE3D8", Offset = "0x1DFE3D8", VA = "0x1DFE3D8", Slot = "4")]
			public override bool Apply(Point origin, int x, int y, object[] args)
			{
				return default(bool);
			}

			// Token: 0x040045E9 RID: 17897
			[Token(Token = "0x40045E9")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x11")]
			private byte paintID;
		}

		// Token: 0x0200055D RID: 1373
		[Token(Token = "0x200055D")]
		public class ClearTilePaint : GenAction
		{
			// Token: 0x06003A21 RID: 14881 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003A21")]
			[Address(RVA = "0x1DFE5B4", Offset = "0x1DFE5B4", VA = "0x1DFE5B4")]
			public ClearTilePaint()
			{
			}

			// Token: 0x06003A22 RID: 14882 RVA: 0x0001D400 File Offset: 0x0001B600
			[Token(Token = "0x6003A22")]
			[Address(RVA = "0x1DFE5C4", Offset = "0x1DFE5C4", VA = "0x1DFE5C4", Slot = "4")]
			public override bool Apply(Point origin, int x, int y, object[] args)
			{
				return default(bool);
			}
		}

		// Token: 0x0200055E RID: 1374
		[Token(Token = "0x200055E")]
		public class SetWallPaint : GenAction
		{
			// Token: 0x06003A23 RID: 14883 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003A23")]
			[Address(RVA = "0x1DFE788", Offset = "0x1DFE788", VA = "0x1DFE788")]
			public SetWallPaint(byte? paintID)
			{
			}

			// Token: 0x06003A24 RID: 14884 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003A24")]
			[Address(RVA = "0x1DFE828", Offset = "0x1DFE828", VA = "0x1DFE828")]
			public SetWallPaint(byte paintID)
			{
			}

			// Token: 0x06003A25 RID: 14885 RVA: 0x0001D418 File Offset: 0x0001B618
			[Token(Token = "0x6003A25")]
			[Address(RVA = "0x1DFE850", Offset = "0x1DFE850", VA = "0x1DFE850", Slot = "4")]
			public override bool Apply(Point origin, int x, int y, object[] args)
			{
				return default(bool);
			}

			// Token: 0x040045EA RID: 17898
			[Token(Token = "0x40045EA")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x11")]
			private byte paintID;
		}

		// Token: 0x0200055F RID: 1375
		[Token(Token = "0x200055F")]
		public class ClearWallPaint : GenAction
		{
			// Token: 0x06003A26 RID: 14886 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003A26")]
			[Address(RVA = "0x1DFEA24", Offset = "0x1DFEA24", VA = "0x1DFEA24")]
			public ClearWallPaint()
			{
			}

			// Token: 0x06003A27 RID: 14887 RVA: 0x0001D430 File Offset: 0x0001B630
			[Token(Token = "0x6003A27")]
			[Address(RVA = "0x1DFEA34", Offset = "0x1DFEA34", VA = "0x1DFEA34", Slot = "4")]
			public override bool Apply(Point origin, int x, int y, object[] args)
			{
				return default(bool);
			}
		}

		// Token: 0x02000560 RID: 1376
		[Token(Token = "0x2000560")]
		public class SetTileAndWallPaint : GenAction
		{
			// Token: 0x06003A28 RID: 14888 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003A28")]
			[Address(RVA = "0x1DFEBF4", Offset = "0x1DFEBF4", VA = "0x1DFEBF4")]
			public SetTileAndWallPaint(byte paintID)
			{
			}

			// Token: 0x06003A29 RID: 14889 RVA: 0x0001D448 File Offset: 0x0001B648
			[Token(Token = "0x6003A29")]
			[Address(RVA = "0x1DFEC1C", Offset = "0x1DFEC1C", VA = "0x1DFEC1C", Slot = "4")]
			public override bool Apply(Point origin, int x, int y, object[] args)
			{
				return default(bool);
			}

			// Token: 0x040045EB RID: 17899
			[Token(Token = "0x40045EB")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x11")]
			private byte paintID;
		}

		// Token: 0x02000561 RID: 1377
		[Token(Token = "0x2000561")]
		public class ClearTileAndWallPaint : GenAction
		{
			// Token: 0x06003A2A RID: 14890 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003A2A")]
			[Address(RVA = "0x1DFF114", Offset = "0x1DFF114", VA = "0x1DFF114")]
			public ClearTileAndWallPaint()
			{
			}

			// Token: 0x06003A2B RID: 14891 RVA: 0x0001D460 File Offset: 0x0001B660
			[Token(Token = "0x6003A2B")]
			[Address(RVA = "0x1DFF124", Offset = "0x1DFF124", VA = "0x1DFF124", Slot = "4")]
			public override bool Apply(Point origin, int x, int y, object[] args)
			{
				return default(bool);
			}
		}

		// Token: 0x02000562 RID: 1378
		[Token(Token = "0x2000562")]
		public class SetTileAndWallRainbowPaint : GenAction
		{
			// Token: 0x06003A2C RID: 14892 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003A2C")]
			[Address(RVA = "0x1DFF3C8", Offset = "0x1DFF3C8", VA = "0x1DFF3C8")]
			public SetTileAndWallRainbowPaint()
			{
			}

			// Token: 0x06003A2D RID: 14893 RVA: 0x0001D478 File Offset: 0x0001B678
			[Token(Token = "0x6003A2D")]
			[Address(RVA = "0x1DFF3D8", Offset = "0x1DFF3D8", VA = "0x1DFF3D8", Slot = "4")]
			public override bool Apply(Point origin, int x, int y, object[] args)
			{
				return default(bool);
			}
		}

		// Token: 0x02000563 RID: 1379
		[Token(Token = "0x2000563")]
		public class PlaceTile : GenAction
		{
			// Token: 0x06003A2E RID: 14894 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003A2E")]
			[Address(RVA = "0x1DFF8DC", Offset = "0x1DFF8DC", VA = "0x1DFF8DC")]
			public PlaceTile(ushort type, int style = 0)
			{
			}

			// Token: 0x06003A2F RID: 14895 RVA: 0x0001D490 File Offset: 0x0001B690
			[Token(Token = "0x6003A2F")]
			[Address(RVA = "0x1DFF90C", Offset = "0x1DFF90C", VA = "0x1DFF90C", Slot = "4")]
			public override bool Apply(Point origin, int x, int y, object[] args)
			{
				return default(bool);
			}

			// Token: 0x040045EC RID: 17900
			[Token(Token = "0x40045EC")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x12")]
			private ushort _type;

			// Token: 0x040045ED RID: 17901
			[Token(Token = "0x40045ED")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private int _style;
		}

		// Token: 0x02000564 RID: 1380
		[Token(Token = "0x2000564")]
		public class RemoveWall : GenAction
		{
			// Token: 0x06003A30 RID: 14896 RVA: 0x0001D4A8 File Offset: 0x0001B6A8
			[Token(Token = "0x6003A30")]
			[Address(RVA = "0x1DFFA00", Offset = "0x1DFFA00", VA = "0x1DFFA00", Slot = "4")]
			public override bool Apply(Point origin, int x, int y, object[] args)
			{
				return default(bool);
			}

			// Token: 0x06003A31 RID: 14897 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003A31")]
			[Address(RVA = "0x1DFFBB0", Offset = "0x1DFFBB0", VA = "0x1DFFBB0")]
			public RemoveWall()
			{
			}
		}

		// Token: 0x02000565 RID: 1381
		[Token(Token = "0x2000565")]
		public class PlaceWall : GenAction
		{
			// Token: 0x06003A32 RID: 14898 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003A32")]
			[Address(RVA = "0x1DFFBC0", Offset = "0x1DFFBC0", VA = "0x1DFFBC0")]
			public PlaceWall(ushort type, bool neighbors = true)
			{
			}

			// Token: 0x06003A33 RID: 14899 RVA: 0x0001D4C0 File Offset: 0x0001B6C0
			[Token(Token = "0x6003A33")]
			[Address(RVA = "0x1DFFBF0", Offset = "0x1DFFBF0", VA = "0x1DFFBF0", Slot = "4")]
			public override bool Apply(Point origin, int x, int y, object[] args)
			{
				return default(bool);
			}

			// Token: 0x040045EE RID: 17902
			[Token(Token = "0x40045EE")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x12")]
			private ushort _type;

			// Token: 0x040045EF RID: 17903
			[Token(Token = "0x40045EF")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private bool _neighbors;
		}

		// Token: 0x02000566 RID: 1382
		[Token(Token = "0x2000566")]
		public class SetLiquid : GenAction
		{
			// Token: 0x06003A34 RID: 14900 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003A34")]
			[Address(RVA = "0x1DFFE54", Offset = "0x1DFFE54", VA = "0x1DFFE54")]
			public SetLiquid(int type = 0, byte value = 255)
			{
			}

			// Token: 0x06003A35 RID: 14901 RVA: 0x0001D4D8 File Offset: 0x0001B6D8
			[Token(Token = "0x6003A35")]
			[Address(RVA = "0x1DFFE84", Offset = "0x1DFFE84", VA = "0x1DFFE84", Slot = "4")]
			public override bool Apply(Point origin, int x, int y, object[] args)
			{
				return default(bool);
			}

			// Token: 0x040045F0 RID: 17904
			[Token(Token = "0x40045F0")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private int _type;

			// Token: 0x040045F1 RID: 17905
			[Token(Token = "0x40045F1")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private byte _value;
		}

		// Token: 0x02000567 RID: 1383
		[Token(Token = "0x2000567")]
		public class SwapSolidTile : GenAction
		{
			// Token: 0x06003A36 RID: 14902 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003A36")]
			[Address(RVA = "0x1E00054", Offset = "0x1E00054", VA = "0x1E00054")]
			public SwapSolidTile(ushort type)
			{
			}

			// Token: 0x06003A37 RID: 14903 RVA: 0x0001D4F0 File Offset: 0x0001B6F0
			[Token(Token = "0x6003A37")]
			[Address(RVA = "0x1E0007C", Offset = "0x1E0007C", VA = "0x1E0007C", Slot = "4")]
			public override bool Apply(Point origin, int x, int y, object[] args)
			{
				return default(bool);
			}

			// Token: 0x040045F2 RID: 17906
			[Token(Token = "0x40045F2")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x12")]
			private ushort _type;
		}

		// Token: 0x02000568 RID: 1384
		[Token(Token = "0x2000568")]
		public class SetFrames : GenAction
		{
			// Token: 0x06003A38 RID: 14904 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003A38")]
			[Address(RVA = "0x1E0023C", Offset = "0x1E0023C", VA = "0x1E0023C")]
			public SetFrames(bool frameNeighbors = false)
			{
			}

			// Token: 0x06003A39 RID: 14905 RVA: 0x0001D508 File Offset: 0x0001B708
			[Token(Token = "0x6003A39")]
			[Address(RVA = "0x1E00264", Offset = "0x1E00264", VA = "0x1E00264", Slot = "4")]
			public override bool Apply(Point origin, int x, int y, object[] args)
			{
				return default(bool);
			}

			// Token: 0x040045F3 RID: 17907
			[Token(Token = "0x40045F3")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x11")]
			private bool _frameNeighbors;
		}

		// Token: 0x02000569 RID: 1385
		[Token(Token = "0x2000569")]
		public class Smooth : GenAction
		{
			// Token: 0x06003A3A RID: 14906 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003A3A")]
			[Address(RVA = "0x1E002EC", Offset = "0x1E002EC", VA = "0x1E002EC")]
			public Smooth(bool applyToNeighbors = false)
			{
			}

			// Token: 0x06003A3B RID: 14907 RVA: 0x0001D520 File Offset: 0x0001B720
			[Token(Token = "0x6003A3B")]
			[Address(RVA = "0x1E00314", Offset = "0x1E00314", VA = "0x1E00314", Slot = "4")]
			public override bool Apply(Point origin, int x, int y, object[] args)
			{
				return default(bool);
			}

			// Token: 0x040045F4 RID: 17908
			[Token(Token = "0x40045F4")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x11")]
			private bool _applyToNeighbors;
		}
	}
}
