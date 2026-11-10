using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

namespace Terraria.UI
{
	// Token: 0x0200088B RID: 2187
	[Token(Token = "0x200088B")]
	public class SnapPoint
	{
		// Token: 0x1700090F RID: 2319
		// (get) Token: 0x06004A5D RID: 19037 RVA: 0x000237F0 File Offset: 0x000219F0
		// (set) Token: 0x06004A5E RID: 19038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700090F")]
		public int Id
		{
			[Token(Token = "0x6004A5D")]
			[Address(RVA = "0x61C74C", Offset = "0x61C74C", VA = "0x61C74C")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6004A5E")]
			[Address(RVA = "0x61C754", Offset = "0x61C754", VA = "0x61C754")]
			private set
			{
			}
		}

		// Token: 0x17000910 RID: 2320
		// (get) Token: 0x06004A5F RID: 19039 RVA: 0x00023808 File Offset: 0x00021A08
		// (set) Token: 0x06004A60 RID: 19040 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000910")]
		public Vector2 Position
		{
			[Token(Token = "0x6004A5F")]
			[Address(RVA = "0x61C75C", Offset = "0x61C75C", VA = "0x61C75C")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6004A60")]
			[Address(RVA = "0x61C770", Offset = "0x61C770", VA = "0x61C770")]
			private set
			{
			}
		}

		// Token: 0x06004A61 RID: 19041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A61")]
		[Address(RVA = "0x61C77C", Offset = "0x61C77C", VA = "0x61C77C")]
		public SnapPoint(string name, int id, Vector2 anchor, Vector2 offset)
		{
		}

		// Token: 0x06004A62 RID: 19042 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A62")]
		[Address(RVA = "0x61C7C0", Offset = "0x61C7C0", VA = "0x61C7C0")]
		public void Calculate(UIElement element)
		{
		}

		// Token: 0x06004A63 RID: 19043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A63")]
		[Address(RVA = "0x61C8FC", Offset = "0x61C8FC", VA = "0x61C8FC")]
		public void ThisIsAHackThatChangesTheSnapPointsInfo(Vector2 anchor, Vector2 offset, int id)
		{
		}

		// Token: 0x04008FC4 RID: 36804
		[Token(Token = "0x4008FC4")]
		[FieldOffset(Offset = "0x8")]
		public string Name;

		// Token: 0x04008FC5 RID: 36805
		[Token(Token = "0x4008FC5")]
		[FieldOffset(Offset = "0xC")]
		private int <Id>k__BackingField;

		// Token: 0x04008FC6 RID: 36806
		[Token(Token = "0x4008FC6")]
		[FieldOffset(Offset = "0x10")]
		private Vector2 <Position>k__BackingField;

		// Token: 0x04008FC7 RID: 36807
		[Token(Token = "0x4008FC7")]
		[FieldOffset(Offset = "0x18")]
		private Vector2 _anchor;

		// Token: 0x04008FC8 RID: 36808
		[Token(Token = "0x4008FC8")]
		[FieldOffset(Offset = "0x20")]
		private Vector2 _offset;
	}
}
