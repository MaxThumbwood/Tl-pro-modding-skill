using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.UI.Chat;

// Token: 0x02000110 RID: 272
[Token(Token = "0x2000110")]
public class ControlsTouchAxisHandler : FileAPI
{
	// Token: 0x0600070E RID: 1806 RVA: 0x00004C98 File Offset: 0x00002E98
	[Token(Token = "0x600070E")]
	[Address(RVA = "0xF3360C", Offset = "0xF3360C", VA = "0xF3360C")]
	public static bool MeasureInline(ref SpriteFont.CharacterSource text, int offset, ref int endOffset, ref Vector2 size)
	{
		return default(bool);
	}

	// Token: 0x0600070F RID: 1807 RVA: 0x00004CB0 File Offset: 0x00002EB0
	[Token(Token = "0x600070F")]
	[Address(RVA = "0xF33CD4", Offset = "0xF33CD4", VA = "0xF33CD4")]
	public static bool PrintInline(SpriteBatch spriteBatch, Vector2 position, Color color, float scale, ref SpriteFont.CharacterSource text, int offset, ref int endOffset, ref Vector2 size)
	{
		return default(bool);
	}

	// Token: 0x06000710 RID: 1808 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000710")]
	[Address(RVA = "0xF345E0", Offset = "0xF345E0", VA = "0xF345E0", Slot = "4")]
	public TextSnippet Parse(string text, [Optional] Color baseColour, [Optional] string options)
	{
		return null;
	}

	// Token: 0x06000711 RID: 1809 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000711")]
	[Address(RVA = "0xF345E8", Offset = "0xF345E8", VA = "0xF345E8")]
	public ControlsTouchAxisHandler()
	{
	}
}
