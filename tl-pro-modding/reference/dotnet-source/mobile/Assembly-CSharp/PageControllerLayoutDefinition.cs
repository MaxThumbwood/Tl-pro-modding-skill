using System;
using Il2CppDummyDll;

// Token: 0x0200024F RID: 591
[Token(Token = "0x200024F")]
public class PageControllerLayoutDefinition<T> : LayoutDefinition where T : PageControllerLayoutDefinition<T>
{
	// Token: 0x17000176 RID: 374
	// (get) Token: 0x06000E51 RID: 3665 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000176")]
	public static T Instance
	{
		[Token(Token = "0x6000E51")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000177 RID: 375
	// (get) Token: 0x06000E52 RID: 3666 RVA: 0x00007950 File Offset: 0x00005B50
	[Token(Token = "0x17000177")]
	public bool RightPageController
	{
		[Token(Token = "0x6000E52")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000E53 RID: 3667 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E53")]
	protected void Awake()
	{
	}

	// Token: 0x06000E54 RID: 3668 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E54")]
	public PageControllerLayoutDefinition()
	{
	}

	// Token: 0x04001B08 RID: 6920
	[Token(Token = "0x4001B08")]
	[FieldOffset(Offset = "0x0")]
	public static T InstanceNormal;

	// Token: 0x04001B09 RID: 6921
	[Token(Token = "0x4001B09")]
	[FieldOffset(Offset = "0x0")]
	public static T InstanceConsoleLeft;

	// Token: 0x04001B0A RID: 6922
	[Token(Token = "0x4001B0A")]
	[FieldOffset(Offset = "0x0")]
	public static T InstanceConsoleRight;

	// Token: 0x04001B0B RID: 6923
	[Token(Token = "0x4001B0B")]
	[FieldOffset(Offset = "0x0")]
	private bool _rightPageController;
}
