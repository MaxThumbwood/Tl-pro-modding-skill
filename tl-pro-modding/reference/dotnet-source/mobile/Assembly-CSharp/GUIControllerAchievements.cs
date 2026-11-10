using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

// Token: 0x02000092 RID: 146
[Token(Token = "0x2000092")]
public class GUIControllerAchievements : FileAPI
{
	// Token: 0x060003C4 RID: 964 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003C4")]
	[Address(RVA = "0xC4E85C", Offset = "0xC4E85C", VA = "0xC4E85C", Slot = "4")]
	public void Activate()
	{
	}

	// Token: 0x060003C5 RID: 965 RVA: 0x00003018 File Offset: 0x00001218
	[Token(Token = "0x60003C5")]
	[Address(RVA = "0xC4E958", Offset = "0xC4E958", VA = "0xC4E958", Slot = "7")]
	public int GetNavigationOutDirs()
	{
		return 0;
	}

	// Token: 0x060003C6 RID: 966 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003C6")]
	[Address(RVA = "0xC4E960", Offset = "0xC4E960", VA = "0xC4E960")]
	private void UpdateScroll()
	{
	}

	// Token: 0x060003C7 RID: 967 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003C7")]
	[Address(RVA = "0xC4EC70", Offset = "0xC4EC70", VA = "0xC4EC70", Slot = "5")]
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		return null;
	}

	// Token: 0x060003C8 RID: 968 RVA: 0x00003030 File Offset: 0x00001230
	[Token(Token = "0x60003C8")]
	[Address(RVA = "0xC4F108", Offset = "0xC4F108", VA = "0xC4F108", Slot = "6")]
	public Rectangle GetSelectedItemRegion()
	{
		return default(Rectangle);
	}

	// Token: 0x060003C9 RID: 969 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003C9")]
	[Address(RVA = "0xC4F524", Offset = "0xC4F524", VA = "0xC4F524")]
	public GUIControllerAchievements()
	{
	}

	// Token: 0x040005C4 RID: 1476
	[Token(Token = "0x40005C4")]
	[FieldOffset(Offset = "0x8")]
	public GUIControllerAchievements.Controls selectedControl;

	// Token: 0x02000093 RID: 147
	[Token(Token = "0x2000093")]
	public enum Controls
	{
		// Token: 0x040005C6 RID: 1478
		[Token(Token = "0x40005C6")]
		FilterSlayer,
		// Token: 0x040005C7 RID: 1479
		[Token(Token = "0x40005C7")]
		FilterCollector,
		// Token: 0x040005C8 RID: 1480
		[Token(Token = "0x40005C8")]
		FilterExplorer,
		// Token: 0x040005C9 RID: 1481
		[Token(Token = "0x40005C9")]
		FilterChallenger,
		// Token: 0x040005CA RID: 1482
		[Token(Token = "0x40005CA")]
		Element,
		// Token: 0x040005CB RID: 1483
		[Token(Token = "0x40005CB")]
		Back
	}
}
