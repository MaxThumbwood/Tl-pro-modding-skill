using System;
using System.Runtime.InteropServices;
using Controller;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.UI.Chat;

// Token: 0x0200010A RID: 266
[Token(Token = "0x200010A")]
public class ControlsButtonTagHandler : FileAPI
{
	// Token: 0x060006F9 RID: 1785 RVA: 0x00004B60 File Offset: 0x00002D60
	[Token(Token = "0x60006F9")]
	[Address(RVA = "0xF2DDE8", Offset = "0xF2DDE8", VA = "0xF2DDE8")]
	public static bool MeasureInline(ref SpriteFont.CharacterSource text, int offset, ref int endOffset, ref Vector2 size)
	{
		return default(bool);
	}

	// Token: 0x060006FA RID: 1786 RVA: 0x00004B78 File Offset: 0x00002D78
	[Token(Token = "0x60006FA")]
	[Address(RVA = "0xF2E40C", Offset = "0xF2E40C", VA = "0xF2E40C")]
	private static int DrawButtonControl(SpriteBatch spriteBatch, Vector2 position, Color color, float scale, ControllerActionButton action, bool mesaureOnly = false)
	{
		return 0;
	}

	// Token: 0x060006FB RID: 1787 RVA: 0x00004B90 File Offset: 0x00002D90
	[Token(Token = "0x60006FB")]
	[Address(RVA = "0xF2E7E4", Offset = "0xF2E7E4", VA = "0xF2E7E4")]
	private static int DrawAxisControl(SpriteBatch spriteBatch, Vector2 position, Color color, float scale, ControllerActionVector action, bool mesasure = false, float threshold = 0f)
	{
		return 0;
	}

	// Token: 0x060006FC RID: 1788 RVA: 0x00004BA8 File Offset: 0x00002DA8
	[Token(Token = "0x60006FC")]
	[Address(RVA = "0xF2EA3C", Offset = "0xF2EA3C", VA = "0xF2EA3C")]
	public static bool PrintInlineMapping(SpriteBatch spriteBatch, Vector2 position, Color color, float scale, ref SpriteFont.CharacterSource text, int offset, ref int endOffset, ref Vector2 size)
	{
		return default(bool);
	}

	// Token: 0x060006FD RID: 1789 RVA: 0x00004BC0 File Offset: 0x00002DC0
	[Token(Token = "0x60006FD")]
	[Address(RVA = "0xF2F984", Offset = "0xF2F984", VA = "0xF2F984")]
	public static bool MeasureInlineMapping(ref SpriteFont.CharacterSource text, int offset, ref int endOffset, ref Vector2 size)
	{
		return default(bool);
	}

	// Token: 0x060006FE RID: 1790 RVA: 0x00004BD8 File Offset: 0x00002DD8
	[Token(Token = "0x60006FE")]
	[Address(RVA = "0xF30848", Offset = "0xF30848", VA = "0xF30848")]
	public static bool PrintInline(SpriteBatch spriteBatch, Vector2 position, Color color, float scale, ref SpriteFont.CharacterSource text, int offset, ref int endOffset, ref Vector2 size)
	{
		return default(bool);
	}

	// Token: 0x060006FF RID: 1791 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006FF")]
	[Address(RVA = "0xF3101C", Offset = "0xF3101C", VA = "0xF3101C", Slot = "4")]
	public TextSnippet Parse(string text, [Optional] Color baseColor, [Optional] string options)
	{
		return null;
	}

	// Token: 0x06000700 RID: 1792 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000700")]
	[Address(RVA = "0xF310E0", Offset = "0xF310E0", VA = "0xF310E0")]
	public ControlsButtonTagHandler()
	{
	}

	// Token: 0x04000796 RID: 1942
	[Token(Token = "0x4000796")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static float ButtonControlSize;

	// Token: 0x04000797 RID: 1943
	[Token(Token = "0x4000797")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public static bool RightSideAdjustment;

	// Token: 0x04000798 RID: 1944
	[Token(Token = "0x4000798")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static float ScaleModifier;

	// Token: 0x0200010B RID: 267
	[Token(Token = "0x200010B")]
	private class ControlsButtonSnippet : TextSnippet
	{
		// Token: 0x06000702 RID: 1794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000702")]
		[Address(RVA = "0xF31150", Offset = "0xF31150", VA = "0xF31150")]
		public ControlsButtonSnippet(GUIControllerInputButton.LinkedControlType control)
		{
		}

		// Token: 0x06000703 RID: 1795 RVA: 0x00004BF0 File Offset: 0x00002DF0
		[Token(Token = "0x6000703")]
		[Address(RVA = "0xF2E65C", Offset = "0xF2E65C", VA = "0xF2E65C")]
		public static bool Draw(GUIControllerInputButton.LinkedControlType control, bool justCheckingString, out Vector2 size, SpriteBatch spriteBatch, [Optional] Vector2 position, [Optional] Color color, float scale = 1f)
		{
			return default(bool);
		}

		// Token: 0x06000704 RID: 1796 RVA: 0x00004C08 File Offset: 0x00002E08
		[Token(Token = "0x6000704")]
		[Address(RVA = "0xF311F0", Offset = "0xF311F0", VA = "0xF311F0", Slot = "8")]
		public override bool UniqueDraw(bool justCheckingString, out Vector2 size, SpriteBatch spriteBatch, [Optional] Vector2 position, [Optional] Color color, float scale = 1f)
		{
			return default(bool);
		}

		// Token: 0x06000705 RID: 1797 RVA: 0x00004C20 File Offset: 0x00002E20
		[Token(Token = "0x6000705")]
		[Address(RVA = "0xF3122C", Offset = "0xF3122C", VA = "0xF3122C", Slot = "10")]
		public override float GetStringLength(SpriteFont font)
		{
			return 0f;
		}

		// Token: 0x04000799 RID: 1945
		[Token(Token = "0x4000799")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private GUIControllerInputButton.LinkedControlType _control;
	}

	// Token: 0x0200010C RID: 268
	[Token(Token = "0x200010C")]
	public enum MappingType
	{
		// Token: 0x0400079B RID: 1947
		[Token(Token = "0x400079B")]
		Movement,
		// Token: 0x0400079C RID: 1948
		[Token(Token = "0x400079C")]
		Aim,
		// Token: 0x0400079D RID: 1949
		[Token(Token = "0x400079D")]
		Fire,
		// Token: 0x0400079E RID: 1950
		[Token(Token = "0x400079E")]
		Jump,
		// Token: 0x0400079F RID: 1951
		[Token(Token = "0x400079F")]
		Interact,
		// Token: 0x040007A0 RID: 1952
		[Token(Token = "0x40007A0")]
		OpenInventory,
		// Token: 0x040007A1 RID: 1953
		[Token(Token = "0x40007A1")]
		CloseInventory,
		// Token: 0x040007A2 RID: 1954
		[Token(Token = "0x40007A2")]
		CycleLeftPage,
		// Token: 0x040007A3 RID: 1955
		[Token(Token = "0x40007A3")]
		CycleRightPage,
		// Token: 0x040007A4 RID: 1956
		[Token(Token = "0x40007A4")]
		CyclePreviousHotbarItem,
		// Token: 0x040007A5 RID: 1957
		[Token(Token = "0x40007A5")]
		CycleNextHotbarItem,
		// Token: 0x040007A6 RID: 1958
		[Token(Token = "0x40007A6")]
		SwitchToWorld,
		// Token: 0x040007A7 RID: 1959
		[Token(Token = "0x40007A7")]
		CraftItem,
		// Token: 0x040007A8 RID: 1960
		[Token(Token = "0x40007A8")]
		PickupItem,
		// Token: 0x040007A9 RID: 1961
		[Token(Token = "0x40007A9")]
		EquipItem,
		// Token: 0x040007AA RID: 1962
		[Token(Token = "0x40007AA")]
		Settings,
		// Token: 0x040007AB RID: 1963
		[Token(Token = "0x40007AB")]
		NavigateInventory,
		// Token: 0x040007AC RID: 1964
		[Token(Token = "0x40007AC")]
		MoveLeft,
		// Token: 0x040007AD RID: 1965
		[Token(Token = "0x40007AD")]
		MoveRight,
		// Token: 0x040007AE RID: 1966
		[Token(Token = "0x40007AE")]
		Grapple,
		// Token: 0x040007AF RID: 1967
		[Token(Token = "0x40007AF")]
		Mount,
		// Token: 0x040007B0 RID: 1968
		[Token(Token = "0x40007B0")]
		Heal,
		// Token: 0x040007B1 RID: 1969
		[Token(Token = "0x40007B1")]
		Mana,
		// Token: 0x040007B2 RID: 1970
		[Token(Token = "0x40007B2")]
		Buff,
		// Token: 0x040007B3 RID: 1971
		[Token(Token = "0x40007B3")]
		Share,
		// Token: 0x040007B4 RID: 1972
		[Token(Token = "0x40007B4")]
		Count
	}
}
