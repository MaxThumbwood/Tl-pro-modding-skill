using System;
using System.Collections.Generic;
using System.Text;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace Terraria.GameInput
{
	// Token: 0x0200081F RID: 2079
	[Token(Token = "0x200081F")]
	public class PlayerInput
	{
		// Token: 0x17000887 RID: 2183
		// (get) Token: 0x0600471F RID: 18207 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06004720 RID: 18208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000887")]
		public static TriggersPack Triggers
		{
			[Token(Token = "0x600471F")]
			[Address(RVA = "0x5ADDB4", Offset = "0x5ADDB4", VA = "0x5ADDB4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004720")]
			[Address(RVA = "0x5ADE1C", Offset = "0x5ADE1C", VA = "0x5ADE1C")]
			set
			{
			}
		}

		// Token: 0x17000888 RID: 2184
		// (get) Token: 0x06004721 RID: 18209 RVA: 0x00021AF8 File Offset: 0x0001FCF8
		// (set) Token: 0x06004722 RID: 18210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000888")]
		public static MouseState MouseInfo
		{
			[Token(Token = "0x6004721")]
			[Address(RVA = "0x5ADE88", Offset = "0x5ADE88", VA = "0x5ADE88")]
			get
			{
				return default(MouseState);
			}
			[Token(Token = "0x6004722")]
			[Address(RVA = "0x5ADF10", Offset = "0x5ADF10", VA = "0x5ADF10")]
			set
			{
			}
		}

		// Token: 0x17000889 RID: 2185
		// (get) Token: 0x06004723 RID: 18211 RVA: 0x00021B10 File Offset: 0x0001FD10
		// (set) Token: 0x06004724 RID: 18212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000889")]
		public static MouseState MouseInfoOld
		{
			[Token(Token = "0x6004723")]
			[Address(RVA = "0x5ADFBC", Offset = "0x5ADFBC", VA = "0x5ADFBC")]
			get
			{
				return default(MouseState);
			}
			[Token(Token = "0x6004724")]
			[Address(RVA = "0x5AE04C", Offset = "0x5AE04C", VA = "0x5AE04C")]
			set
			{
			}
		}

		// Token: 0x1700088A RID: 2186
		// (get) Token: 0x06004725 RID: 18213 RVA: 0x00021B28 File Offset: 0x0001FD28
		// (set) Token: 0x06004726 RID: 18214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700088A")]
		public static int MouseX
		{
			[Token(Token = "0x6004725")]
			[Address(RVA = "0x5AC550", Offset = "0x5AC550", VA = "0x5AC550")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6004726")]
			[Address(RVA = "0x5AC2DC", Offset = "0x5AC2DC", VA = "0x5AC2DC")]
			set
			{
			}
		}

		// Token: 0x1700088B RID: 2187
		// (get) Token: 0x06004727 RID: 18215 RVA: 0x00021B40 File Offset: 0x0001FD40
		// (set) Token: 0x06004728 RID: 18216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700088B")]
		public static int MouseY
		{
			[Token(Token = "0x6004727")]
			[Address(RVA = "0x5AC5B8", Offset = "0x5AC5B8", VA = "0x5AC5B8")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6004728")]
			[Address(RVA = "0x5AC348", Offset = "0x5AC348", VA = "0x5AC348")]
			set
			{
			}
		}

		// Token: 0x1700088C RID: 2188
		// (get) Token: 0x06004729 RID: 18217 RVA: 0x00021B58 File Offset: 0x0001FD58
		// (set) Token: 0x0600472A RID: 18218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700088C")]
		public static bool LockGamepadTileUseButton
		{
			[Token(Token = "0x6004729")]
			[Address(RVA = "0x5AE0F8", Offset = "0x5AE0F8", VA = "0x5AE0F8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600472A")]
			[Address(RVA = "0x5AE160", Offset = "0x5AE160", VA = "0x5AE160")]
			set
			{
			}
		}

		// Token: 0x1700088D RID: 2189
		// (get) Token: 0x0600472B RID: 18219 RVA: 0x00021B70 File Offset: 0x0001FD70
		// (set) Token: 0x0600472C RID: 18220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700088D")]
		public static int PreUIX
		{
			[Token(Token = "0x600472B")]
			[Address(RVA = "0x5AE1CC", Offset = "0x5AE1CC", VA = "0x5AE1CC")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600472C")]
			[Address(RVA = "0x5AE234", Offset = "0x5AE234", VA = "0x5AE234")]
			set
			{
			}
		}

		// Token: 0x1700088E RID: 2190
		// (get) Token: 0x0600472D RID: 18221 RVA: 0x00021B88 File Offset: 0x0001FD88
		// (set) Token: 0x0600472E RID: 18222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700088E")]
		public static int PreUIY
		{
			[Token(Token = "0x600472D")]
			[Address(RVA = "0x5AE2A0", Offset = "0x5AE2A0", VA = "0x5AE2A0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600472E")]
			[Address(RVA = "0x5AE308", Offset = "0x5AE308", VA = "0x5AE308")]
			set
			{
			}
		}

		// Token: 0x1700088F RID: 2191
		// (get) Token: 0x0600472F RID: 18223 RVA: 0x00021BA0 File Offset: 0x0001FDA0
		// (set) Token: 0x06004730 RID: 18224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700088F")]
		public static int PreLockOnX
		{
			[Token(Token = "0x600472F")]
			[Address(RVA = "0x5AE374", Offset = "0x5AE374", VA = "0x5AE374")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6004730")]
			[Address(RVA = "0x5AE3DC", Offset = "0x5AE3DC", VA = "0x5AE3DC")]
			set
			{
			}
		}

		// Token: 0x17000890 RID: 2192
		// (get) Token: 0x06004731 RID: 18225 RVA: 0x00021BB8 File Offset: 0x0001FDB8
		// (set) Token: 0x06004732 RID: 18226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000890")]
		public static int PreLockOnY
		{
			[Token(Token = "0x6004731")]
			[Address(RVA = "0x5AE448", Offset = "0x5AE448", VA = "0x5AE448")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6004732")]
			[Address(RVA = "0x5AE4B0", Offset = "0x5AE4B0", VA = "0x5AE4B0")]
			set
			{
			}
		}

		// Token: 0x17000891 RID: 2193
		// (get) Token: 0x06004733 RID: 18227 RVA: 0x00021BD0 File Offset: 0x0001FDD0
		// (set) Token: 0x06004734 RID: 18228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000891")]
		public static int ScrollWheelValue
		{
			[Token(Token = "0x6004733")]
			[Address(RVA = "0x5AE51C", Offset = "0x5AE51C", VA = "0x5AE51C")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6004734")]
			[Address(RVA = "0x5AE584", Offset = "0x5AE584", VA = "0x5AE584")]
			set
			{
			}
		}

		// Token: 0x17000892 RID: 2194
		// (get) Token: 0x06004735 RID: 18229 RVA: 0x00021BE8 File Offset: 0x0001FDE8
		// (set) Token: 0x06004736 RID: 18230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000892")]
		public static int ScrollWheelValueOld
		{
			[Token(Token = "0x6004735")]
			[Address(RVA = "0x5AE5F0", Offset = "0x5AE5F0", VA = "0x5AE5F0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6004736")]
			[Address(RVA = "0x5AE658", Offset = "0x5AE658", VA = "0x5AE658")]
			set
			{
			}
		}

		// Token: 0x17000893 RID: 2195
		// (get) Token: 0x06004737 RID: 18231 RVA: 0x00021C00 File Offset: 0x0001FE00
		// (set) Token: 0x06004738 RID: 18232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000893")]
		public static int ScrollWheelDelta
		{
			[Token(Token = "0x6004737")]
			[Address(RVA = "0x5AE6C4", Offset = "0x5AE6C4", VA = "0x5AE6C4")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6004738")]
			[Address(RVA = "0x5AE72C", Offset = "0x5AE72C", VA = "0x5AE72C")]
			set
			{
			}
		}

		// Token: 0x14000046 RID: 70
		// (add) Token: 0x06004739 RID: 18233 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x0600473A RID: 18234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000046")]
		public static event Action OnBindingChange
		{
			[Token(Token = "0x6004739")]
			[Address(RVA = "0x5AE798", Offset = "0x5AE798", VA = "0x5AE798")]
			add
			{
			}
			[Token(Token = "0x600473A")]
			[Address(RVA = "0x5AE89C", Offset = "0x5AE89C", VA = "0x5AE89C")]
			remove
			{
			}
		}

		// Token: 0x14000047 RID: 71
		// (add) Token: 0x0600473B RID: 18235 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x0600473C RID: 18236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000047")]
		public static event Action OnActionableInput
		{
			[Token(Token = "0x600473B")]
			[Address(RVA = "0x5AE9A0", Offset = "0x5AE9A0", VA = "0x5AE9A0")]
			add
			{
			}
			[Token(Token = "0x600473C")]
			[Address(RVA = "0x5AEAA4", Offset = "0x5AEAA4", VA = "0x5AEAA4")]
			remove
			{
			}
		}

		// Token: 0x0600473D RID: 18237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600473D")]
		[Address(RVA = "0x5AEBA8", Offset = "0x5AEBA8", VA = "0x5AEBA8")]
		public static void ListenFor(string triggerName, InputMode inputmode)
		{
		}

		// Token: 0x17000894 RID: 2196
		// (get) Token: 0x0600473E RID: 18238 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000894")]
		public static string ListeningTrigger
		{
			[Token(Token = "0x600473E")]
			[Address(RVA = "0x5AEC18", Offset = "0x5AEC18", VA = "0x5AEC18")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000895 RID: 2197
		// (get) Token: 0x0600473F RID: 18239 RVA: 0x00021C18 File Offset: 0x0001FE18
		[Token(Token = "0x17000895")]
		public static bool CurrentlyRebinding
		{
			[Token(Token = "0x600473F")]
			[Address(RVA = "0x5AEC7C", Offset = "0x5AEC7C", VA = "0x5AEC7C")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000896 RID: 2198
		// (get) Token: 0x06004740 RID: 18240 RVA: 0x00021C30 File Offset: 0x0001FE30
		[Token(Token = "0x17000896")]
		public static bool InvisibleGamepadInMenus
		{
			[Token(Token = "0x6004740")]
			[Address(RVA = "0x5AECE8", Offset = "0x5AECE8", VA = "0x5AECE8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000897 RID: 2199
		// (get) Token: 0x06004741 RID: 18241 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000897")]
		public static PlayerInputProfile CurrentProfile
		{
			[Token(Token = "0x6004741")]
			[Address(RVA = "0x5AF070", Offset = "0x5AF070", VA = "0x5AF070")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000898 RID: 2200
		// (get) Token: 0x06004742 RID: 18242 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000898")]
		public static KeyConfiguration ProfileGamepadUI
		{
			[Token(Token = "0x6004742")]
			[Address(RVA = "0x5AF0D4", Offset = "0x5AF0D4", VA = "0x5AF0D4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000899 RID: 2201
		// (get) Token: 0x06004743 RID: 18243 RVA: 0x00021C48 File Offset: 0x0001FE48
		// (set) Token: 0x06004744 RID: 18244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000899")]
		public static InputMode CurrentInputMode
		{
			[Token(Token = "0x6004743")]
			[Address(RVA = "0x5AF1C4", Offset = "0x5AF1C4", VA = "0x5AF1C4")]
			get
			{
				return InputMode.Keyboard;
			}
			[Token(Token = "0x6004744")]
			[Address(RVA = "0x5AF228", Offset = "0x5AF228", VA = "0x5AF228")]
			set
			{
			}
		}

		// Token: 0x1700089A RID: 2202
		// (get) Token: 0x06004745 RID: 18245 RVA: 0x00021C60 File Offset: 0x0001FE60
		[Token(Token = "0x1700089A")]
		public static bool UsingGamepad
		{
			[Token(Token = "0x6004745")]
			[Address(RVA = "0x5AF30C", Offset = "0x5AF30C", VA = "0x5AF30C")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700089B RID: 2203
		// (get) Token: 0x06004746 RID: 18246 RVA: 0x00021C78 File Offset: 0x0001FE78
		[Token(Token = "0x1700089B")]
		public static bool UsingGamepadUI
		{
			[Token(Token = "0x6004746")]
			[Address(RVA = "0x5AF424", Offset = "0x5AF424", VA = "0x5AF424")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700089C RID: 2204
		// (get) Token: 0x06004747 RID: 18247 RVA: 0x00021C90 File Offset: 0x0001FE90
		[Token(Token = "0x1700089C")]
		public static bool IgnoreMouseInterface
		{
			[Token(Token = "0x6004747")]
			[Address(RVA = "0x5AF4D8", Offset = "0x5AF4D8", VA = "0x5AF4D8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700089D RID: 2205
		// (get) Token: 0x06004748 RID: 18248 RVA: 0x00021CA8 File Offset: 0x0001FEA8
		[Token(Token = "0x1700089D")]
		public static bool SteamDeckIsUsed
		{
			[Token(Token = "0x6004748")]
			[Address(RVA = "0x5AF594", Offset = "0x5AF594", VA = "0x5AF594")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06004749 RID: 18249 RVA: 0x00021CC0 File Offset: 0x0001FEC0
		[Token(Token = "0x6004749")]
		[Address(RVA = "0x5AF5F8", Offset = "0x5AF5F8", VA = "0x5AF5F8")]
		private static bool InvalidateKeyboardSwap()
		{
			return default(bool);
		}

		// Token: 0x0600474A RID: 18250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600474A")]
		[Address(RVA = "0x5AF894", Offset = "0x5AF894", VA = "0x5AF894")]
		public static void ResetInputsOnActiveStateChange()
		{
		}

		// Token: 0x0600474B RID: 18251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600474B")]
		[Address(RVA = "0x5AFE1C", Offset = "0x5AFE1C", VA = "0x5AFE1C")]
		public static void TryEnteringFastUseModeForInventorySlot(int inventorySlot)
		{
		}

		// Token: 0x0600474C RID: 18252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600474C")]
		[Address(RVA = "0x5AFECC", Offset = "0x5AFECC", VA = "0x5AFECC")]
		public static void TryEnteringFastUseModeForMouseItem()
		{
		}

		// Token: 0x1700089E RID: 2206
		// (get) Token: 0x0600474D RID: 18253 RVA: 0x00021CD8 File Offset: 0x0001FED8
		[Token(Token = "0x1700089E")]
		public static bool ShouldFastUseItem
		{
			[Token(Token = "0x600474D")]
			[Address(RVA = "0x5AFF74", Offset = "0x5AFF74", VA = "0x5AFF74")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600474E RID: 18254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600474E")]
		[Address(RVA = "0x5AFFE0", Offset = "0x5AFFE0", VA = "0x5AFFE0")]
		public static void TryEndingFastUse()
		{
		}

		// Token: 0x1700089F RID: 2207
		// (get) Token: 0x0600474F RID: 18255 RVA: 0x00021CF0 File Offset: 0x0001FEF0
		[Token(Token = "0x1700089F")]
		public static bool InBuildingMode
		{
			[Token(Token = "0x600474F")]
			[Address(RVA = "0x5B004C", Offset = "0x5B004C", VA = "0x5B004C")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170008A0 RID: 2208
		// (get) Token: 0x06004750 RID: 18256 RVA: 0x00021D08 File Offset: 0x0001FF08
		[Token(Token = "0x170008A0")]
		public static int RealScreenWidth
		{
			[Token(Token = "0x6004750")]
			[Address(RVA = "0x5B00B0", Offset = "0x5B00B0", VA = "0x5B00B0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170008A1 RID: 2209
		// (get) Token: 0x06004751 RID: 18257 RVA: 0x00021D20 File Offset: 0x0001FF20
		[Token(Token = "0x170008A1")]
		public static int RealScreenHeight
		{
			[Token(Token = "0x6004751")]
			[Address(RVA = "0x5B0114", Offset = "0x5B0114", VA = "0x5B0114")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170008A2 RID: 2210
		// (get) Token: 0x06004752 RID: 18258 RVA: 0x00021D38 File Offset: 0x0001FF38
		[Token(Token = "0x170008A2")]
		public static int UIScreenWidth
		{
			[Token(Token = "0x6004752")]
			[Address(RVA = "0x5B0178", Offset = "0x5B0178", VA = "0x5B0178")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170008A3 RID: 2211
		// (get) Token: 0x06004753 RID: 18259 RVA: 0x00021D50 File Offset: 0x0001FF50
		[Token(Token = "0x170008A3")]
		public static int UIScreenHeight
		{
			[Token(Token = "0x6004753")]
			[Address(RVA = "0x5B028C", Offset = "0x5B028C", VA = "0x5B028C")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06004754 RID: 18260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004754")]
		[Address(RVA = "0x5B03A0", Offset = "0x5B03A0", VA = "0x5B03A0")]
		public static void SetSelectedProfile(string name)
		{
		}

		// Token: 0x06004755 RID: 18261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004755")]
		[Address(RVA = "0x5B04B0", Offset = "0x5B04B0", VA = "0x5B04B0")]
		public static void Initialize()
		{
		}

		// Token: 0x170008A4 RID: 2212
		// (get) Token: 0x06004756 RID: 18262 RVA: 0x00021D68 File Offset: 0x0001FF68
		[Token(Token = "0x170008A4")]
		public static bool CursorIsBusy
		{
			[Token(Token = "0x6004756")]
			[Address(RVA = "0x5AEFCC", Offset = "0x5AEFCC", VA = "0x5AEFCC")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06004757 RID: 18263 RVA: 0x00021D80 File Offset: 0x0001FF80
		[Token(Token = "0x6004757")]
		[Address(RVA = "0x5B0C94", Offset = "0x5B0C94", VA = "0x5B0C94")]
		public static bool IsGamepadButtonLockedFromUse(string keyName)
		{
			return default(bool);
		}

		// Token: 0x06004758 RID: 18264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004758")]
		[Address(RVA = "0x5B0D34", Offset = "0x5B0D34", VA = "0x5B0D34")]
		public static void UpdateInput()
		{
		}

		// Token: 0x06004759 RID: 18265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004759")]
		[Address(RVA = "0x5B35C4", Offset = "0x5B35C4", VA = "0x5B35C4")]
		public static void UpdateMainMouse()
		{
		}

		// Token: 0x0600475A RID: 18266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600475A")]
		[Address(RVA = "0x5B3740", Offset = "0x5B3740", VA = "0x5B3740")]
		public static void CacheZoomableValues()
		{
		}

		// Token: 0x0600475B RID: 18267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600475B")]
		[Address(RVA = "0x5B3930", Offset = "0x5B3930", VA = "0x5B3930")]
		public static void CacheMousePositionForZoom()
		{
		}

		// Token: 0x0600475C RID: 18268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600475C")]
		[Address(RVA = "0x5B37A0", Offset = "0x5B37A0", VA = "0x5B37A0")]
		private static void CacheOriginalInput()
		{
		}

		// Token: 0x0600475D RID: 18269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600475D")]
		[Address(RVA = "0x5B387C", Offset = "0x5B387C", VA = "0x5B387C")]
		public static void CacheOriginalScreenDimensions()
		{
		}

		// Token: 0x170008A5 RID: 2213
		// (get) Token: 0x0600475E RID: 18270 RVA: 0x00021D98 File Offset: 0x0001FF98
		[Token(Token = "0x170008A5")]
		public static Vector2 OriginalScreenSize
		{
			[Token(Token = "0x600475E")]
			[Address(RVA = "0x5B39FC", Offset = "0x5B39FC", VA = "0x5B39FC")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x170008A6 RID: 2214
		// (get) Token: 0x0600475F RID: 18271 RVA: 0x00021DB0 File Offset: 0x0001FFB0
		// (set) Token: 0x06004760 RID: 18272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170008A6")]
		public static Vector2 HousingWorldPosition
		{
			[Token(Token = "0x600475F")]
			[Address(RVA = "0x5B3A90", Offset = "0x5B3A90", VA = "0x5B3A90")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6004760")]
			[Address(RVA = "0x5B3BC4", Offset = "0x5B3BC4", VA = "0x5B3BC4")]
			set
			{
			}
		}

		// Token: 0x170008A7 RID: 2215
		// (get) Token: 0x06004761 RID: 18273 RVA: 0x00021DC8 File Offset: 0x0001FFC8
		[Token(Token = "0x170008A7")]
		public static Vector2 HousingScreenPosition
		{
			[Token(Token = "0x6004761")]
			[Address(RVA = "0x5B3CF0", Offset = "0x5B3CF0", VA = "0x5B3CF0")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x06004762 RID: 18274 RVA: 0x00021DE0 File Offset: 0x0001FFE0
		[Token(Token = "0x6004762")]
		[Address(RVA = "0x5B3144", Offset = "0x5B3144", VA = "0x5B3144")]
		private static bool GamePadInput()
		{
			return default(bool);
		}

		// Token: 0x06004763 RID: 18275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004763")]
		[Address(RVA = "0x5B1860", Offset = "0x5B1860", VA = "0x5B1860")]
		private static void MouseInput()
		{
		}

		// Token: 0x06004764 RID: 18276 RVA: 0x00021DF8 File Offset: 0x0001FFF8
		[Token(Token = "0x6004764")]
		[Address(RVA = "0x5B2554", Offset = "0x5B2554", VA = "0x5B2554")]
		private static bool KeyboardInput()
		{
			return default(bool);
		}

		// Token: 0x06004765 RID: 18277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004765")]
		[Address(RVA = "0x5B3DB4", Offset = "0x5B3DB4", VA = "0x5B3DB4")]
		private static void DebugKeys(List<Keys> keys)
		{
		}

		// Token: 0x06004766 RID: 18278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004766")]
		[Address(RVA = "0x5B3DB8", Offset = "0x5B3DB8", VA = "0x5B3DB8")]
		private static void FixDerpedRebinds()
		{
		}

		// Token: 0x06004767 RID: 18279 RVA: 0x00021E10 File Offset: 0x00020010
		[Token(Token = "0x6004767")]
		[Address(RVA = "0x5B3DBC", Offset = "0x5B3DBC", VA = "0x5B3DBC")]
		private static bool CheckRebindingProcessGamepad(string newKey)
		{
			return default(bool);
		}

		// Token: 0x06004768 RID: 18280 RVA: 0x00021E28 File Offset: 0x00020028
		[Token(Token = "0x6004768")]
		[Address(RVA = "0x5B3DAC", Offset = "0x5B3DAC", VA = "0x5B3DAC")]
		private static bool CheckRebindingProcessKeyboard(string newKey)
		{
			return default(bool);
		}

		// Token: 0x06004769 RID: 18281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004769")]
		[Address(RVA = "0x5B314C", Offset = "0x5B314C", VA = "0x5B314C")]
		private static void PostInput()
		{
		}

		// Token: 0x0600476A RID: 18282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600476A")]
		[Address(RVA = "0x5B3DC4", Offset = "0x5B3DC4", VA = "0x5B3DC4")]
		private static void HandleDpadSnap()
		{
		}

		// Token: 0x0600476B RID: 18283 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600476B")]
		[Address(RVA = "0x5B4C68", Offset = "0x5B4C68", VA = "0x5B4C68")]
		public static string BuildCommand(string CommandText, List<string>[] Bindings)
		{
			return null;
		}

		// Token: 0x0600476C RID: 18284 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600476C")]
		[Address(RVA = "0x5B4E40", Offset = "0x5B4E40", VA = "0x5B4E40")]
		private static string GenerateGlyphList(List<string> list)
		{
			return null;
		}

		// Token: 0x0600476D RID: 18285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600476D")]
		[Address(RVA = "0x5B4FC0", Offset = "0x5B4FC0", VA = "0x5B4FC0")]
		public static void NavigatorCachePosition()
		{
		}

		// Token: 0x0600476E RID: 18286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600476E")]
		[Address(RVA = "0x5B4FC4", Offset = "0x5B4FC4", VA = "0x5B4FC4")]
		public static void NavigatorUnCachePosition()
		{
		}

		// Token: 0x0600476F RID: 18287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600476F")]
		[Address(RVA = "0x5AC140", Offset = "0x5AC140", VA = "0x5AC140")]
		public static void LockOnCachePosition()
		{
		}

		// Token: 0x06004770 RID: 18288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004770")]
		[Address(RVA = "0x5AC3B4", Offset = "0x5AC3B4", VA = "0x5AC3B4")]
		public static void LockOnUnCachePosition()
		{
		}

		// Token: 0x06004771 RID: 18289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004771")]
		[Address(RVA = "0x5B4FC8", Offset = "0x5B4FC8", VA = "0x5B4FC8")]
		public static void PrettyPrintProfiles(ref string text)
		{
		}

		// Token: 0x06004772 RID: 18290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004772")]
		[Address(RVA = "0x5B5468", Offset = "0x5B5468", VA = "0x5B5468")]
		public static void PrettyPrintProfilesOld(ref string text)
		{
		}

		// Token: 0x06004773 RID: 18291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004773")]
		[Address(RVA = "0x5B5674", Offset = "0x5B5674", VA = "0x5B5674")]
		public static void Reset(KeyConfiguration c, PresetProfiles style, InputMode mode)
		{
		}

		// Token: 0x06004774 RID: 18292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004774")]
		[Address(RVA = "0x5BEEBC", Offset = "0x5BEEBC", VA = "0x5BEEBC")]
		public static void SetZoom_UI()
		{
		}

		// Token: 0x06004775 RID: 18293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004775")]
		[Address(RVA = "0x5BEEC0", Offset = "0x5BEEC0", VA = "0x5BEEC0")]
		public static void SetZoom_World()
		{
		}

		// Token: 0x06004776 RID: 18294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004776")]
		[Address(RVA = "0x5BEEC4", Offset = "0x5BEEC4", VA = "0x5BEEC4")]
		public static void SetZoom_Unscaled()
		{
		}

		// Token: 0x06004777 RID: 18295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004777")]
		[Address(RVA = "0x5BEEC8", Offset = "0x5BEEC8", VA = "0x5BEEC8")]
		public static void SetZoom_Test()
		{
		}

		// Token: 0x06004778 RID: 18296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004778")]
		[Address(RVA = "0x5BEECC", Offset = "0x5BEECC", VA = "0x5BEECC")]
		public static void SetZoom_MouseInWorld()
		{
		}

		// Token: 0x06004779 RID: 18297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004779")]
		[Address(RVA = "0x5BEED0", Offset = "0x5BEED0", VA = "0x5BEED0")]
		private static void SetZoom_Scaled(float scale)
		{
		}

		// Token: 0x0600477A RID: 18298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600477A")]
		[Address(RVA = "0x5BEED4", Offset = "0x5BEED4", VA = "0x5BEED4")]
		public PlayerInput()
		{
		}

		// Token: 0x04008DD5 RID: 36309
		[Token(Token = "0x4008DD5")]
		[FieldOffset(Offset = "0x0")]
		public static Vector2 RawMouseScale;

		// Token: 0x04008DD6 RID: 36310
		[Token(Token = "0x4008DD6")]
		[FieldOffset(Offset = "0x8")]
		public static bool GrappleAndInteractAreShared;

		// Token: 0x04008DD7 RID: 36311
		[Token(Token = "0x4008DD7")]
		[FieldOffset(Offset = "0xC")]
		public static SmartSelectGamepadPointer smartSelectPointer;

		// Token: 0x04008DD8 RID: 36312
		[Token(Token = "0x4008DD8")]
		[FieldOffset(Offset = "0x10")]
		private static StringBuilder _invalidatorCheck;

		// Token: 0x04008DD9 RID: 36313
		[Token(Token = "0x4008DD9")]
		[FieldOffset(Offset = "0x14")]
		private static StringBuilder ff;

		// Token: 0x04008DDA RID: 36314
		[Token(Token = "0x4008DDA")]
		[FieldOffset(Offset = "0x18")]
		private static bool _lastActivityState;

		// Token: 0x04008DDB RID: 36315
		[Token(Token = "0x4008DDB")]
		[FieldOffset(Offset = "0x1C")]
		public static int ScrollWheelDeltaForUI;

		// Token: 0x04008DDC RID: 36316
		[Token(Token = "0x4008DDC")]
		[FieldOffset(Offset = "0x20")]
		public static bool GamepadAllowScrolling;

		// Token: 0x04008DDD RID: 36317
		[Token(Token = "0x4008DDD")]
		[FieldOffset(Offset = "0x24")]
		public static int GamepadScrollValue;

		// Token: 0x04008DDE RID: 36318
		[Token(Token = "0x4008DDE")]
		[FieldOffset(Offset = "0x28")]
		public static Vector2 GamepadThumbstickLeft;

		// Token: 0x04008DDF RID: 36319
		[Token(Token = "0x4008DDF")]
		[FieldOffset(Offset = "0x30")]
		public static Vector2 GamepadThumbstickRight;

		// Token: 0x04008DE0 RID: 36320
		[Token(Token = "0x4008DE0")]
		[FieldOffset(Offset = "0x38")]
		private static PlayerInput.FastUseItemMemory _fastUseMemory;

		// Token: 0x04008DE3 RID: 36323
		[Token(Token = "0x4008DE3")]
		[FieldOffset(Offset = "0x50")]
		private static string _listeningTrigger;

		// Token: 0x04008DE4 RID: 36324
		[Token(Token = "0x4008DE4")]
		[FieldOffset(Offset = "0x54")]
		private static InputMode _listeningInputMode;

		// Token: 0x04008DE5 RID: 36325
		[Token(Token = "0x4008DE5")]
		[FieldOffset(Offset = "0x58")]
		private static bool _canReleaseRebindingLock;

		// Token: 0x04008DE6 RID: 36326
		[Token(Token = "0x4008DE6")]
		[FieldOffset(Offset = "0x5C")]
		private static int _memoOfLastPoint;

		// Token: 0x04008DE7 RID: 36327
		[Token(Token = "0x4008DE7")]
		[FieldOffset(Offset = "0x60")]
		public static int NavigatorRebindingLock;

		// Token: 0x04008DE8 RID: 36328
		[Token(Token = "0x4008DE8")]
		[FieldOffset(Offset = "0x64")]
		public static string BlockedKey;

		// Token: 0x04008DE9 RID: 36329
		[Token(Token = "0x4008DE9")]
		[FieldOffset(Offset = "0x68")]
		public static Dictionary<string, PlayerInputProfile> Profiles;

		// Token: 0x04008DEA RID: 36330
		[Token(Token = "0x4008DEA")]
		[FieldOffset(Offset = "0x6C")]
		public static Dictionary<string, PlayerInputProfile> OriginalProfiles;

		// Token: 0x04008DEB RID: 36331
		[Token(Token = "0x4008DEB")]
		[FieldOffset(Offset = "0x70")]
		private static string _selectedProfile;

		// Token: 0x04008DEC RID: 36332
		[Token(Token = "0x4008DEC")]
		[FieldOffset(Offset = "0x74")]
		private static PlayerInputProfile _currentProfile;

		// Token: 0x04008DED RID: 36333
		[Token(Token = "0x4008DED")]
		[FieldOffset(Offset = "0x78")]
		private static InputMode _inputMode;

		// Token: 0x04008DEE RID: 36334
		[Token(Token = "0x4008DEE")]
		[FieldOffset(Offset = "0x7C")]
		private static Buttons[] ButtonsGamepad;

		// Token: 0x04008DEF RID: 36335
		[Token(Token = "0x4008DEF")]
		[FieldOffset(Offset = "0x80")]
		public static bool UseSteamDeckIfPossible;

		// Token: 0x04008DF0 RID: 36336
		[Token(Token = "0x4008DF0")]
		[FieldOffset(Offset = "0x84")]
		public static List<string> MouseKeys;

		// Token: 0x04008DF1 RID: 36337
		[Token(Token = "0x4008DF1")]
		[FieldOffset(Offset = "0x88")]
		private static bool _InBuildingMode;

		// Token: 0x04008DF2 RID: 36338
		[Token(Token = "0x4008DF2")]
		[FieldOffset(Offset = "0x8C")]
		private static int _UIPointForBuildingMode;

		// Token: 0x04008DF3 RID: 36339
		[Token(Token = "0x4008DF3")]
		[FieldOffset(Offset = "0x90")]
		public static bool WritingText;

		// Token: 0x04008DF4 RID: 36340
		[Token(Token = "0x4008DF4")]
		[FieldOffset(Offset = "0x94")]
		private static int _originalMouseX;

		// Token: 0x04008DF5 RID: 36341
		[Token(Token = "0x4008DF5")]
		[FieldOffset(Offset = "0x98")]
		private static int _originalMouseY;

		// Token: 0x04008DF6 RID: 36342
		[Token(Token = "0x4008DF6")]
		[FieldOffset(Offset = "0x9C")]
		private static int _originalLastMouseX;

		// Token: 0x04008DF7 RID: 36343
		[Token(Token = "0x4008DF7")]
		[FieldOffset(Offset = "0xA0")]
		private static int _originalLastMouseY;

		// Token: 0x04008DF8 RID: 36344
		[Token(Token = "0x4008DF8")]
		[FieldOffset(Offset = "0xA4")]
		private static int _originalScreenWidth;

		// Token: 0x04008DF9 RID: 36345
		[Token(Token = "0x4008DF9")]
		[FieldOffset(Offset = "0xA8")]
		private static int _originalScreenHeight;

		// Token: 0x04008DFA RID: 36346
		[Token(Token = "0x4008DFA")]
		[FieldOffset(Offset = "0xAC")]
		private static List<string> _buttonsLocked;

		// Token: 0x04008DFB RID: 36347
		[Token(Token = "0x4008DFB")]
		[FieldOffset(Offset = "0xB0")]
		public static Vector2 HousingMouseOffset;

		// Token: 0x04008DFC RID: 36348
		[Token(Token = "0x4008DFC")]
		[FieldOffset(Offset = "0xB8")]
		private static int[] DpadSnapCooldown;

		// Token: 0x02000820 RID: 2080
		[Token(Token = "0x2000820")]
		public class MiscSettingsTEMP
		{
			// Token: 0x0600477C RID: 18300 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600477C")]
			[Address(RVA = "0x5E1570", Offset = "0x5E1570", VA = "0x5E1570")]
			public MiscSettingsTEMP()
			{
			}

			// Token: 0x04008DFD RID: 36349
			[Token(Token = "0x4008DFD")]
			[FieldOffset(Offset = "0x0")]
			public static bool HotbarRadialShouldBeUsed;
		}

		// Token: 0x02000821 RID: 2081
		[Token(Token = "0x2000821")]
		public static class SettingsForUI
		{
			// Token: 0x170008A8 RID: 2216
			// (get) Token: 0x0600477E RID: 18302 RVA: 0x00021E40 File Offset: 0x00020040
			// (set) Token: 0x0600477F RID: 18303 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170008A8")]
			public static CursorMode CurrentCursorMode
			{
				[Token(Token = "0x600477E")]
				[Address(RVA = "0x5E15CC", Offset = "0x5E15CC", VA = "0x5E15CC")]
				get
				{
					return CursorMode.Mouse;
				}
				[Token(Token = "0x600477F")]
				[Address(RVA = "0x5E161C", Offset = "0x5E161C", VA = "0x5E161C")]
				private set
				{
				}
			}

			// Token: 0x06004780 RID: 18304 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004780")]
			[Address(RVA = "0x5E1670", Offset = "0x5E1670", VA = "0x5E1670")]
			public static void SetCursorMode(CursorMode cursorMode)
			{
			}

			// Token: 0x170008A9 RID: 2217
			// (get) Token: 0x06004781 RID: 18305 RVA: 0x00021E58 File Offset: 0x00020058
			[Token(Token = "0x170008A9")]
			public static bool ShowGamepadHints
			{
				[Token(Token = "0x6004781")]
				[Address(RVA = "0x5E1738", Offset = "0x5E1738", VA = "0x5E1738")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170008AA RID: 2218
			// (get) Token: 0x06004782 RID: 18306 RVA: 0x00021E70 File Offset: 0x00020070
			[Token(Token = "0x170008AA")]
			public static bool AllowSecondaryGamepadAim
			{
				[Token(Token = "0x6004782")]
				[Address(RVA = "0x5E1814", Offset = "0x5E1814", VA = "0x5E1814")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170008AB RID: 2219
			// (get) Token: 0x06004783 RID: 18307 RVA: 0x00021E88 File Offset: 0x00020088
			[Token(Token = "0x170008AB")]
			public static bool PushEquipmentAreaUp
			{
				[Token(Token = "0x6004783")]
				[Address(RVA = "0x5E1918", Offset = "0x5E1918", VA = "0x5E1918")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170008AC RID: 2220
			// (get) Token: 0x06004784 RID: 18308 RVA: 0x00021EA0 File Offset: 0x000200A0
			[Token(Token = "0x170008AC")]
			public static bool ShowGamepadCursor
			{
				[Token(Token = "0x6004784")]
				[Address(RVA = "0x5E1A60", Offset = "0x5E1A60", VA = "0x5E1A60")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170008AD RID: 2221
			// (get) Token: 0x06004785 RID: 18309 RVA: 0x00021EB8 File Offset: 0x000200B8
			[Token(Token = "0x170008AD")]
			public static bool HighlightThingsForMouse
			{
				[Token(Token = "0x6004785")]
				[Address(RVA = "0x5E1B80", Offset = "0x5E1B80", VA = "0x5E1B80")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170008AE RID: 2222
			// (get) Token: 0x06004786 RID: 18310 RVA: 0x00021ED0 File Offset: 0x000200D0
			// (set) Token: 0x06004787 RID: 18311 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170008AE")]
			public static int FramesSinceLastTimeInMouseMode
			{
				[Token(Token = "0x6004786")]
				[Address(RVA = "0x5E1C40", Offset = "0x5E1C40", VA = "0x5E1C40")]
				get
				{
					return 0;
				}
				[Token(Token = "0x6004787")]
				[Address(RVA = "0x5E1C90", Offset = "0x5E1C90", VA = "0x5E1C90")]
				private set
				{
				}
			}

			// Token: 0x170008AF RID: 2223
			// (get) Token: 0x06004788 RID: 18312 RVA: 0x00021EE8 File Offset: 0x000200E8
			[Token(Token = "0x170008AF")]
			public static bool PreventHighlightsForGamepad
			{
				[Token(Token = "0x6004788")]
				[Address(RVA = "0x5E1CE4", Offset = "0x5E1CE4", VA = "0x5E1CE4")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06004789 RID: 18313 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004789")]
			[Address(RVA = "0x5E1D3C", Offset = "0x5E1D3C", VA = "0x5E1D3C")]
			public static void UpdateCounters()
			{
			}

			// Token: 0x0600478A RID: 18314 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600478A")]
			[Address(RVA = "0x5E1E00", Offset = "0x5E1E00", VA = "0x5E1E00")]
			public static void TryRevertingToMouseMode()
			{
			}

			// Token: 0x04008DFE RID: 36350
			[Token(Token = "0x4008DFE")]
			[FieldOffset(Offset = "0x0")]
			private static CursorMode <CurrentCursorMode>k__BackingField;

			// Token: 0x04008DFF RID: 36351
			[Token(Token = "0x4008DFF")]
			[FieldOffset(Offset = "0x4")]
			private static int <FramesSinceLastTimeInMouseMode>k__BackingField;
		}

		// Token: 0x02000822 RID: 2082
		[Token(Token = "0x2000822")]
		private struct FastUseItemMemory
		{
			// Token: 0x0600478B RID: 18315 RVA: 0x00021F00 File Offset: 0x00020100
			[Token(Token = "0x600478B")]
			[Address(RVA = "0x5E1F9C", Offset = "0x5E1F9C", VA = "0x5E1F9C")]
			public bool TryStartForItemSlot(Player player, int itemSlot)
			{
				return default(bool);
			}

			// Token: 0x0600478C RID: 18316 RVA: 0x00021F18 File Offset: 0x00020118
			[Token(Token = "0x600478C")]
			[Address(RVA = "0x5E20B8", Offset = "0x5E20B8", VA = "0x5E20B8")]
			public bool TryStartForMouse(Player player)
			{
				return default(bool);
			}

			// Token: 0x0600478D RID: 18317 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600478D")]
			[Address(RVA = "0x5E20AC", Offset = "0x5E20AC", VA = "0x5E20AC")]
			public void Clear()
			{
			}

			// Token: 0x0600478E RID: 18318 RVA: 0x00021F30 File Offset: 0x00020130
			[Token(Token = "0x600478E")]
			[Address(RVA = "0x5E2178", Offset = "0x5E2178", VA = "0x5E2178")]
			public bool CanFastUse()
			{
				return default(bool);
			}

			// Token: 0x0600478F RID: 18319 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600478F")]
			[Address(RVA = "0x5E2258", Offset = "0x5E2258", VA = "0x5E2258")]
			public void EndFastUse()
			{
			}

			// Token: 0x04008E00 RID: 36352
			[Token(Token = "0x4008E00")]
			[FieldOffset(Offset = "0x0")]
			private int _slot;

			// Token: 0x04008E01 RID: 36353
			[Token(Token = "0x4008E01")]
			[FieldOffset(Offset = "0x4")]
			private int _itemType;

			// Token: 0x04008E02 RID: 36354
			[Token(Token = "0x4008E02")]
			[FieldOffset(Offset = "0x8")]
			private bool _shouldFastUse;

			// Token: 0x04008E03 RID: 36355
			[Token(Token = "0x4008E03")]
			[FieldOffset(Offset = "0x9")]
			private bool _isMouseItem;

			// Token: 0x04008E04 RID: 36356
			[Token(Token = "0x4008E04")]
			[FieldOffset(Offset = "0xC")]
			private Player _player;
		}
	}
}
