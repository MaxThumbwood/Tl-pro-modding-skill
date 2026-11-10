using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

namespace Terraria.WorldBuilding
{
	// Token: 0x020005B6 RID: 1462
	[Token(Token = "0x20005B6")]
	public class SimpleStructure : GenStructure
	{
		// Token: 0x17000774 RID: 1908
		// (get) Token: 0x06003B1D RID: 15133 RVA: 0x0001DC70 File Offset: 0x0001BE70
		[Token(Token = "0x17000774")]
		public int Width
		{
			[Token(Token = "0x6003B1D")]
			[Address(RVA = "0x1E0A884", Offset = "0x1E0A884", VA = "0x1E0A884")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000775 RID: 1909
		// (get) Token: 0x06003B1E RID: 15134 RVA: 0x0001DC88 File Offset: 0x0001BE88
		[Token(Token = "0x17000775")]
		public int Height
		{
			[Token(Token = "0x6003B1E")]
			[Address(RVA = "0x1E0A88C", Offset = "0x1E0A88C", VA = "0x1E0A88C")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06003B1F RID: 15135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B1F")]
		[Address(RVA = "0x1E0A894", Offset = "0x1E0A894", VA = "0x1E0A894")]
		public SimpleStructure(string[] data)
		{
		}

		// Token: 0x06003B20 RID: 15136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B20")]
		[Address(RVA = "0x1E0AA30", Offset = "0x1E0AA30", VA = "0x1E0AA30")]
		public SimpleStructure(string data)
		{
		}

		// Token: 0x06003B21 RID: 15137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B21")]
		[Address(RVA = "0x1E0A8B8", Offset = "0x1E0A8B8", VA = "0x1E0A8B8")]
		private void ReadData(string[] lines)
		{
		}

		// Token: 0x06003B22 RID: 15138 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B22")]
		[Address(RVA = "0x1E0AA74", Offset = "0x1E0AA74", VA = "0x1E0AA74")]
		public SimpleStructure SetActions(GenAction[] actions)
		{
			return null;
		}

		// Token: 0x06003B23 RID: 15139 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B23")]
		[Address(RVA = "0x1E0AA7C", Offset = "0x1E0AA7C", VA = "0x1E0AA7C")]
		public SimpleStructure Mirror(bool horizontalMirror, bool verticalMirror)
		{
			return null;
		}

		// Token: 0x06003B24 RID: 15140 RVA: 0x0001DCA0 File Offset: 0x0001BEA0
		[Token(Token = "0x6003B24")]
		[Address(RVA = "0x1E0AA88", Offset = "0x1E0AA88", VA = "0x1E0AA88", Slot = "5")]
		public override bool Place(Point origin, StructureMap structures, GenerationProgress progress)
		{
			return default(bool);
		}

		// Token: 0x040046F2 RID: 18162
		[Token(Token = "0x40046F2")]
		[FieldOffset(Offset = "0x8")]
		private int[,] _data;

		// Token: 0x040046F3 RID: 18163
		[Token(Token = "0x40046F3")]
		[FieldOffset(Offset = "0xC")]
		private int _width;

		// Token: 0x040046F4 RID: 18164
		[Token(Token = "0x40046F4")]
		[FieldOffset(Offset = "0x10")]
		private int _height;

		// Token: 0x040046F5 RID: 18165
		[Token(Token = "0x40046F5")]
		[FieldOffset(Offset = "0x14")]
		private GenAction[] _actions;

		// Token: 0x040046F6 RID: 18166
		[Token(Token = "0x40046F6")]
		[FieldOffset(Offset = "0x18")]
		private bool _xMirror;

		// Token: 0x040046F7 RID: 18167
		[Token(Token = "0x40046F7")]
		[FieldOffset(Offset = "0x19")]
		private bool _yMirror;
	}
}
