using System;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x0200001F RID: 31
[Token(Token = "0x200001F")]
public class CursorInputLayer
{
	// Token: 0x06000089 RID: 137 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000089")]
	[Address(RVA = "0x499AF4", Offset = "0x499AF4", VA = "0x499AF4")]
	public CursorInputLayer()
	{
	}

	// Token: 0x0600008A RID: 138 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600008A")]
	[Address(RVA = "0x499CB4", Offset = "0x499CB4", VA = "0x499CB4", Slot = "1")]
	protected override void Finalize()
	{
	}

	// Token: 0x0600008B RID: 139 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600008B")]
	[Address(RVA = "0x499E40", Offset = "0x499E40", VA = "0x499E40")]
	public void UpdateCursor(Cursor cursor)
	{
	}

	// Token: 0x0600008C RID: 140 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600008C")]
	[Address(RVA = "0x499E5C", Offset = "0x499E5C", VA = "0x499E5C")]
	public void Postupdate(List<Cursor> cursors)
	{
	}

	// Token: 0x17000032 RID: 50
	// (get) Token: 0x0600008D RID: 141 RVA: 0x000024C0 File Offset: 0x000006C0
	// (set) Token: 0x0600008E RID: 142 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000032")]
	public int Priority
	{
		[Token(Token = "0x600008D")]
		[Address(RVA = "0x499E78", Offset = "0x499E78", VA = "0x499E78")]
		get
		{
			return 0;
		}
		[Token(Token = "0x600008E")]
		[Address(RVA = "0x499E80", Offset = "0x499E80", VA = "0x499E80")]
		set
		{
		}
	}

	// Token: 0x0600008F RID: 143 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600008F")]
	[Address(RVA = "0x499EF4", Offset = "0x499EF4", VA = "0x499EF4")]
	public static void Resort()
	{
	}

	// Token: 0x17000033 RID: 51
	// (get) Token: 0x06000090 RID: 144 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000033")]
	public static List<CursorInputLayer> Layers
	{
		[Token(Token = "0x6000090")]
		[Address(RVA = "0x499C4C", Offset = "0x499C4C", VA = "0x499C4C")]
		get
		{
			return null;
		}
	}

	// Token: 0x040002C1 RID: 705
	[Token(Token = "0x40002C1")]
	[FieldOffset(Offset = "0x8")]
	public CursorInputLayer.CursorUpdater UpdateCallback;

	// Token: 0x040002C2 RID: 706
	[Token(Token = "0x40002C2")]
	[FieldOffset(Offset = "0xC")]
	public CursorInputLayer.CursorPostUpdate PostUpdateCallback;

	// Token: 0x040002C3 RID: 707
	[Token(Token = "0x40002C3")]
	[FieldOffset(Offset = "0x10")]
	private int _priority;

	// Token: 0x040002C4 RID: 708
	[Token(Token = "0x40002C4")]
	[FieldOffset(Offset = "0x0")]
	public static bool Dirty;

	// Token: 0x02000020 RID: 32
	// (Invoke) Token: 0x06000093 RID: 147
	[Token(Token = "0x2000020")]
	public delegate void CursorUpdater(Cursor cursor);

	// Token: 0x02000021 RID: 33
	// (Invoke) Token: 0x06000097 RID: 151
	[Token(Token = "0x2000021")]
	public delegate void CursorPostUpdate(List<Cursor> cursors);

	// Token: 0x02000022 RID: 34
	[Token(Token = "0x2000022")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x0600009B RID: 155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600009B")]
		[Address(RVA = "0x49A4D0", Offset = "0x49A4D0", VA = "0x49A4D0")]
		public <>c()
		{
		}

		// Token: 0x0600009C RID: 156 RVA: 0x000024D8 File Offset: 0x000006D8
		[Token(Token = "0x600009C")]
		[Address(RVA = "0x49A4D8", Offset = "0x49A4D8", VA = "0x49A4D8")]
		internal int <Resort>b__9_0(CursorInputLayer layer1, CursorInputLayer layer2)
		{
			return 0;
		}

		// Token: 0x040002C5 RID: 709
		[Token(Token = "0x40002C5")]
		[FieldOffset(Offset = "0x0")]
		public static readonly CursorInputLayer.<>c <>9;

		// Token: 0x040002C6 RID: 710
		[Token(Token = "0x40002C6")]
		[FieldOffset(Offset = "0x4")]
		public static Comparison<CursorInputLayer> <>9__9_0;
	}
}
