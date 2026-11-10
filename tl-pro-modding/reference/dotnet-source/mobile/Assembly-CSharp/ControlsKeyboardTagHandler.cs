using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.UI.Chat;

// Token: 0x0200010D RID: 269
[Token(Token = "0x200010D")]
public class ControlsKeyboardTagHandler : FileAPI
{
	// Token: 0x06000706 RID: 1798 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000706")]
	[Address(RVA = "0xF31238", Offset = "0xF31238", VA = "0xF31238")]
	private static void DrawKeyboardBinding(SpriteBatch spriteBatch, SpriteFont spriteFont, Vector2 position, Color color, float scale, string bindingText, bool measure = false)
	{
	}

	// Token: 0x06000707 RID: 1799 RVA: 0x00004C38 File Offset: 0x00002E38
	[Token(Token = "0x6000707")]
	[Address(RVA = "0xF31554", Offset = "0xF31554", VA = "0xF31554")]
	public static bool PrintInlineMapping(SpriteBatch spriteBatch, SpriteFont spriteFont, Vector2 position, Color color, float scale, ref SpriteFont.CharacterSource text, int offset, ref int endOffset, ref Vector2 size)
	{
		return default(bool);
	}

	// Token: 0x06000708 RID: 1800 RVA: 0x00004C50 File Offset: 0x00002E50
	[Token(Token = "0x6000708")]
	[Address(RVA = "0xF324F4", Offset = "0xF324F4", VA = "0xF324F4")]
	public static bool MeasureInlineMapping(SpriteFont spriteFont, ref SpriteFont.CharacterSource text, int offset, ref int endOffset, ref Vector2 tagSize)
	{
		return default(bool);
	}

	// Token: 0x06000709 RID: 1801 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000709")]
	[Address(RVA = "0xF333F0", Offset = "0xF333F0", VA = "0xF333F0", Slot = "4")]
	public TextSnippet Parse(string text, [Optional] Color baseColor, [Optional] string options)
	{
		return null;
	}

	// Token: 0x0600070A RID: 1802 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600070A")]
	[Address(RVA = "0xF334B4", Offset = "0xF334B4", VA = "0xF334B4")]
	public ControlsKeyboardTagHandler()
	{
	}

	// Token: 0x0200010E RID: 270
	[Token(Token = "0x200010E")]
	public class ControlsKeyboardSnippet : TextSnippet
	{
		// Token: 0x0600070B RID: 1803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600070B")]
		[Address(RVA = "0xF334BC", Offset = "0xF334BC", VA = "0xF334BC")]
		public ControlsKeyboardSnippet(GUIControllerInputButton.LinkedControlType control)
		{
		}

		// Token: 0x0600070C RID: 1804 RVA: 0x00004C68 File Offset: 0x00002E68
		[Token(Token = "0x600070C")]
		[Address(RVA = "0xF312B8", Offset = "0xF312B8", VA = "0xF312B8")]
		public static bool Draw(string binding, bool justCheckingString, out Vector2 size, SpriteBatch spriteBatch, SpriteFont spriteFont, [Optional] Vector2 position, [Optional] Color color, float scale = 1f)
		{
			return default(bool);
		}

		// Token: 0x0600070D RID: 1805 RVA: 0x00004C80 File Offset: 0x00002E80
		[Token(Token = "0x600070D")]
		[Address(RVA = "0xF33568", Offset = "0xF33568", VA = "0xF33568", Slot = "10")]
		public override float GetStringLength(SpriteFont font)
		{
			return 0f;
		}

		// Token: 0x040007B5 RID: 1973
		[Token(Token = "0x40007B5")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private readonly GUIControllerInputButton.LinkedControlType _control;

		// Token: 0x040007B6 RID: 1974
		[Token(Token = "0x40007B6")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly string _binding;
	}

	// Token: 0x0200010F RID: 271
	[Token(Token = "0x200010F")]
	public enum MappingType
	{
		// Token: 0x040007B8 RID: 1976
		[Token(Token = "0x40007B8")]
		MoveUp,
		// Token: 0x040007B9 RID: 1977
		[Token(Token = "0x40007B9")]
		MoveDown,
		// Token: 0x040007BA RID: 1978
		[Token(Token = "0x40007BA")]
		MoveLeft,
		// Token: 0x040007BB RID: 1979
		[Token(Token = "0x40007BB")]
		MoveRight,
		// Token: 0x040007BC RID: 1980
		[Token(Token = "0x40007BC")]
		Aim,
		// Token: 0x040007BD RID: 1981
		[Token(Token = "0x40007BD")]
		Fire,
		// Token: 0x040007BE RID: 1982
		[Token(Token = "0x40007BE")]
		Jump,
		// Token: 0x040007BF RID: 1983
		[Token(Token = "0x40007BF")]
		Interact,
		// Token: 0x040007C0 RID: 1984
		[Token(Token = "0x40007C0")]
		InventoryToggle,
		// Token: 0x040007C1 RID: 1985
		[Token(Token = "0x40007C1")]
		CycleLeftPage,
		// Token: 0x040007C2 RID: 1986
		[Token(Token = "0x40007C2")]
		CycleRightPage,
		// Token: 0x040007C3 RID: 1987
		[Token(Token = "0x40007C3")]
		CyclePreviousHotbarItem,
		// Token: 0x040007C4 RID: 1988
		[Token(Token = "0x40007C4")]
		CycleNextHotbarItem,
		// Token: 0x040007C5 RID: 1989
		[Token(Token = "0x40007C5")]
		SwitchToWorld,
		// Token: 0x040007C6 RID: 1990
		[Token(Token = "0x40007C6")]
		CraftItem,
		// Token: 0x040007C7 RID: 1991
		[Token(Token = "0x40007C7")]
		PickupItem,
		// Token: 0x040007C8 RID: 1992
		[Token(Token = "0x40007C8")]
		EquipItem,
		// Token: 0x040007C9 RID: 1993
		[Token(Token = "0x40007C9")]
		Settings,
		// Token: 0x040007CA RID: 1994
		[Token(Token = "0x40007CA")]
		NavigateInventory,
		// Token: 0x040007CB RID: 1995
		[Token(Token = "0x40007CB")]
		Teleport,
		// Token: 0x040007CC RID: 1996
		[Token(Token = "0x40007CC")]
		ZoomIn,
		// Token: 0x040007CD RID: 1997
		[Token(Token = "0x40007CD")]
		ZoomOut,
		// Token: 0x040007CE RID: 1998
		[Token(Token = "0x40007CE")]
		NavigateHotbar,
		// Token: 0x040007CF RID: 1999
		[Token(Token = "0x40007CF")]
		Grapple,
		// Token: 0x040007D0 RID: 2000
		[Token(Token = "0x40007D0")]
		Mount,
		// Token: 0x040007D1 RID: 2001
		[Token(Token = "0x40007D1")]
		Heal,
		// Token: 0x040007D2 RID: 2002
		[Token(Token = "0x40007D2")]
		Mana,
		// Token: 0x040007D3 RID: 2003
		[Token(Token = "0x40007D3")]
		Buff,
		// Token: 0x040007D4 RID: 2004
		[Token(Token = "0x40007D4")]
		Share,
		// Token: 0x040007D5 RID: 2005
		[Token(Token = "0x40007D5")]
		Count
	}
}
