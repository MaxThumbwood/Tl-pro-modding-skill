using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Microsoft.Xna.Framework.Graphics
{
	// Token: 0x020003D6 RID: 982
	[Token(Token = "0x20003D6")]
	public class DisplayModeCollection : FileAPI, GUIControllerItem
	{
		// Token: 0x170002E7 RID: 743
		// (get) Token: 0x06001ABC RID: 6844 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002E7")]
		public IEnumerable<DisplayMode> Item
		{
			[Token(Token = "0x6001ABC")]
			[Address(RVA = "0xE45468", Offset = "0xE45468", VA = "0xE45468")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001ABD RID: 6845 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001ABD")]
		[Address(RVA = "0xE456EC", Offset = "0xE456EC", VA = "0xE456EC", Slot = "4")]
		public IEnumerator<DisplayMode> GetEnumerator()
		{
			return null;
		}

		// Token: 0x06001ABE RID: 6846 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001ABE")]
		[Address(RVA = "0xE45790", Offset = "0xE45790", VA = "0xE45790", Slot = "5")]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}

		// Token: 0x06001ABF RID: 6847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001ABF")]
		[Address(RVA = "0xE45834", Offset = "0xE45834", VA = "0xE45834")]
		internal DisplayModeCollection(List<DisplayMode> modes)
		{
		}

		// Token: 0x04002E21 RID: 11809
		[Token(Token = "0x4002E21")]
		[FieldOffset(Offset = "0x8")]
		private readonly List<DisplayMode> _modes;

		// Token: 0x020003D7 RID: 983
		[Token(Token = "0x20003D7")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06001AC1 RID: 6849 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001AC1")]
			[Address(RVA = "0xE459FC", Offset = "0xE459FC", VA = "0xE459FC")]
			public <>c()
			{
			}

			// Token: 0x06001AC2 RID: 6850 RVA: 0x0000CD68 File Offset: 0x0000AF68
			[Token(Token = "0x6001AC2")]
			[Address(RVA = "0xE45A04", Offset = "0xE45A04", VA = "0xE45A04")]
			internal int <.ctor>b__5_0(DisplayMode a, DisplayMode b)
			{
				return 0;
			}

			// Token: 0x04002E22 RID: 11810
			[Token(Token = "0x4002E22")]
			[FieldOffset(Offset = "0x0")]
			public static readonly DisplayModeCollection.<>c <>9;

			// Token: 0x04002E23 RID: 11811
			[Token(Token = "0x4002E23")]
			[FieldOffset(Offset = "0x4")]
			public static Comparison<DisplayMode> <>9__5_0;
		}
	}
}
