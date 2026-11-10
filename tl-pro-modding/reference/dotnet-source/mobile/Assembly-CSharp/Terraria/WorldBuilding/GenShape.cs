using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

namespace Terraria.WorldBuilding
{
	// Token: 0x020005A6 RID: 1446
	[Token(Token = "0x20005A6")]
	public abstract class GenShape : GenBase
	{
		// Token: 0x06003AD8 RID: 15064
		[Token(Token = "0x6003AD8")]
		public abstract bool Perform(Point origin, GenAction action);

		// Token: 0x06003AD9 RID: 15065 RVA: 0x0001DA60 File Offset: 0x0001BC60
		[Token(Token = "0x6003AD9")]
		[Address(RVA = "0x1E05944", Offset = "0x1E05944", VA = "0x1E05944")]
		protected bool UnitApply(GenAction action, Point origin, int x, int y, object[] args)
		{
			return default(bool);
		}

		// Token: 0x06003ADA RID: 15066 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003ADA")]
		[Address(RVA = "0x1E078B4", Offset = "0x1E078B4", VA = "0x1E078B4")]
		public GenShape Output(ShapeData outputData)
		{
			return null;
		}

		// Token: 0x06003ADB RID: 15067 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003ADB")]
		[Address(RVA = "0x1E078BC", Offset = "0x1E078BC", VA = "0x1E078BC")]
		public GenShape QuitOnFail(bool value = true)
		{
			return null;
		}

		// Token: 0x06003ADC RID: 15068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003ADC")]
		[Address(RVA = "0x1E05698", Offset = "0x1E05698", VA = "0x1E05698")]
		protected GenShape()
		{
		}

		// Token: 0x0400464A RID: 17994
		[Token(Token = "0x400464A")]
		[FieldOffset(Offset = "0x8")]
		private ShapeData _outputData;

		// Token: 0x0400464B RID: 17995
		[Token(Token = "0x400464B")]
		[FieldOffset(Offset = "0xC")]
		protected bool _quitOnFail;
	}
}
