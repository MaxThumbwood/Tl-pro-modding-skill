using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.GameContent.UI.Elements;
using Terraria.UI;

namespace Terraria.GameContent.Creative
{
	// Token: 0x02000CD6 RID: 3286
	[Token(Token = "0x2000CD6")]
	public class CreativePowersHelper
	{
		// Token: 0x06006194 RID: 24980 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006194")]
		[Address(RVA = "0xAB6B98", Offset = "0xAB6B98", VA = "0xAB6B98")]
		private static Asset<Texture2D> GetPowerIconAsset(string path)
		{
			return null;
		}

		// Token: 0x06006195 RID: 24981 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006195")]
		[Address(RVA = "0xAB6CB0", Offset = "0xAB6CB0", VA = "0xAB6CB0")]
		public static UIImageFramed GetIconImage(Point iconLocation)
		{
			return null;
		}

		// Token: 0x06006196 RID: 24982 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006196")]
		[Address(RVA = "0xAB6E88", Offset = "0xAB6E88", VA = "0xAB6E88")]
		public static GroupOptionButton<bool> CreateToggleButton(CreativePowerUIElementRequestInfo info)
		{
			return null;
		}

		// Token: 0x06006197 RID: 24983 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006197")]
		[Address(RVA = "0xAB715C", Offset = "0xAB715C", VA = "0xAB715C")]
		public static GroupOptionButton<bool> CreateSimpleButton(CreativePowerUIElementRequestInfo info)
		{
			return null;
		}

		// Token: 0x06006198 RID: 24984 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006198")]
		public static GroupOptionButton<T> CreateCategoryButton<T>(CreativePowerUIElementRequestInfo info, T option, T currentOption) where T : IConvertible, IEquatable<T>
		{
			return null;
		}

		// Token: 0x06006199 RID: 24985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006199")]
		[Address(RVA = "0xAB73CC", Offset = "0xAB73CC", VA = "0xAB73CC")]
		public static void AddPermissionTextIfNeeded(ICreativePower power, ref string originalText)
		{
		}

		// Token: 0x0600619A RID: 24986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600619A")]
		[Address(RVA = "0xAB7660", Offset = "0xAB7660", VA = "0xAB7660")]
		public static void AddDescriptionIfNeeded(ref string originalText, string descriptionKey)
		{
		}

		// Token: 0x0600619B RID: 24987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600619B")]
		[Address(RVA = "0xAB7730", Offset = "0xAB7730", VA = "0xAB7730")]
		public static void AddUnlockTextIfNeeded(ref string originalText, bool needed, string descriptionKey)
		{
		}

		// Token: 0x0600619C RID: 24988 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600619C")]
		[Address(RVA = "0xAB77E8", Offset = "0xAB77E8", VA = "0xAB77E8")]
		public static UIVerticalSlider CreateSlider(Func<float> GetSliderValueMethod, Action<float> SetValueKeyboardMethod, Action SetValueGamepadMethod)
		{
			return null;
		}

		// Token: 0x0600619D RID: 24989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600619D")]
		[Address(RVA = "0xAB79E8", Offset = "0xAB79E8", VA = "0xAB79E8")]
		public static void UpdateUseMouseInterface(UIElement affectedElement)
		{
		}

		// Token: 0x0600619E RID: 24990 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600619E")]
		[Address(RVA = "0xAB7A7C", Offset = "0xAB7A7C", VA = "0xAB7A7C")]
		public static void UpdateUnlockStateByPower(ICreativePower power, UIElement button, Color colorWhenSelected)
		{
		}

		// Token: 0x0600619F RID: 24991 RVA: 0x0002D0A8 File Offset: 0x0002B2A8
		[Token(Token = "0x600619F")]
		[Address(RVA = "0xAB7508", Offset = "0xAB7508", VA = "0xAB7508")]
		public static bool IsAvailableForPlayer(ICreativePower power, int playerIndex)
		{
			return default(bool);
		}

		// Token: 0x060061A0 RID: 24992 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061A0")]
		[Address(RVA = "0xAB7C00", Offset = "0xAB7C00", VA = "0xAB7C00")]
		private static void UpdateUnlockStateByPowerInternal(ICreativePower power, Color colorWhenSelected, IGroupOptionButton asButton)
		{
		}

		// Token: 0x060061A1 RID: 24993 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061A1")]
		[Address(RVA = "0xAB805C", Offset = "0xAB805C", VA = "0xAB805C")]
		public CreativePowersHelper()
		{
		}

		// Token: 0x0400A029 RID: 41001
		[Token(Token = "0x400A029")]
		public const int TextureIconColumns = 21;

		// Token: 0x0400A02A RID: 41002
		[Token(Token = "0x400A02A")]
		public const int TextureIconRows = 1;

		// Token: 0x0400A02B RID: 41003
		[Token(Token = "0x400A02B")]
		[FieldOffset(Offset = "0x0")]
		public static Color CommonSelectedColor;

		// Token: 0x02000CD7 RID: 3287
		[Token(Token = "0x2000CD7")]
		public class CreativePowerIconLocations
		{
			// Token: 0x060061A3 RID: 24995 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60061A3")]
			[Address(RVA = "0xAB80E0", Offset = "0xAB80E0", VA = "0xAB80E0")]
			public CreativePowerIconLocations()
			{
			}

			// Token: 0x0400A02C RID: 41004
			[Token(Token = "0x400A02C")]
			[FieldOffset(Offset = "0x0")]
			public static readonly Point Unassigned;

			// Token: 0x0400A02D RID: 41005
			[Token(Token = "0x400A02D")]
			[FieldOffset(Offset = "0x8")]
			public static readonly Point Deprecated;

			// Token: 0x0400A02E RID: 41006
			[Token(Token = "0x400A02E")]
			[FieldOffset(Offset = "0x10")]
			public static readonly Point ItemDuplication;

			// Token: 0x0400A02F RID: 41007
			[Token(Token = "0x400A02F")]
			[FieldOffset(Offset = "0x18")]
			public static readonly Point ItemResearch;

			// Token: 0x0400A030 RID: 41008
			[Token(Token = "0x400A030")]
			[FieldOffset(Offset = "0x20")]
			public static readonly Point TimeCategory;

			// Token: 0x0400A031 RID: 41009
			[Token(Token = "0x400A031")]
			[FieldOffset(Offset = "0x28")]
			public static readonly Point WeatherCategory;

			// Token: 0x0400A032 RID: 41010
			[Token(Token = "0x400A032")]
			[FieldOffset(Offset = "0x30")]
			public static readonly Point EnemyStrengthSlider;

			// Token: 0x0400A033 RID: 41011
			[Token(Token = "0x400A033")]
			[FieldOffset(Offset = "0x38")]
			public static readonly Point GameEvents;

			// Token: 0x0400A034 RID: 41012
			[Token(Token = "0x400A034")]
			[FieldOffset(Offset = "0x40")]
			public static readonly Point Godmode;

			// Token: 0x0400A035 RID: 41013
			[Token(Token = "0x400A035")]
			[FieldOffset(Offset = "0x48")]
			public static readonly Point BlockPlacementRange;

			// Token: 0x0400A036 RID: 41014
			[Token(Token = "0x400A036")]
			[FieldOffset(Offset = "0x50")]
			public static readonly Point StopBiomeSpread;

			// Token: 0x0400A037 RID: 41015
			[Token(Token = "0x400A037")]
			[FieldOffset(Offset = "0x58")]
			public static readonly Point EnemySpawnRate;

			// Token: 0x0400A038 RID: 41016
			[Token(Token = "0x400A038")]
			[FieldOffset(Offset = "0x60")]
			public static readonly Point FreezeTime;

			// Token: 0x0400A039 RID: 41017
			[Token(Token = "0x400A039")]
			[FieldOffset(Offset = "0x68")]
			public static readonly Point TimeDawn;

			// Token: 0x0400A03A RID: 41018
			[Token(Token = "0x400A03A")]
			[FieldOffset(Offset = "0x70")]
			public static readonly Point TimeNoon;

			// Token: 0x0400A03B RID: 41019
			[Token(Token = "0x400A03B")]
			[FieldOffset(Offset = "0x78")]
			public static readonly Point TimeDusk;

			// Token: 0x0400A03C RID: 41020
			[Token(Token = "0x400A03C")]
			[FieldOffset(Offset = "0x80")]
			public static readonly Point TimeMidnight;

			// Token: 0x0400A03D RID: 41021
			[Token(Token = "0x400A03D")]
			[FieldOffset(Offset = "0x88")]
			public static readonly Point WindDirection;

			// Token: 0x0400A03E RID: 41022
			[Token(Token = "0x400A03E")]
			[FieldOffset(Offset = "0x90")]
			public static readonly Point WindFreeze;

			// Token: 0x0400A03F RID: 41023
			[Token(Token = "0x400A03F")]
			[FieldOffset(Offset = "0x98")]
			public static readonly Point RainStrength;

			// Token: 0x0400A040 RID: 41024
			[Token(Token = "0x400A040")]
			[FieldOffset(Offset = "0xA0")]
			public static readonly Point RainFreeze;

			// Token: 0x0400A041 RID: 41025
			[Token(Token = "0x400A041")]
			[FieldOffset(Offset = "0xA8")]
			public static readonly Point ModifyTime;

			// Token: 0x0400A042 RID: 41026
			[Token(Token = "0x400A042")]
			[FieldOffset(Offset = "0xB0")]
			public static readonly Point PersonalCategory;
		}

		// Token: 0x02000CD8 RID: 3288
		[Token(Token = "0x2000CD8")]
		private sealed class <>c__DisplayClass14_0
		{
			// Token: 0x060061A5 RID: 24997 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60061A5")]
			[Address(RVA = "0xAB7BF8", Offset = "0xAB7BF8", VA = "0xAB7BF8")]
			public <>c__DisplayClass14_0()
			{
			}

			// Token: 0x060061A6 RID: 24998 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60061A6")]
			[Address(RVA = "0xAB85DC", Offset = "0xAB85DC", VA = "0xAB85DC")]
			internal void <UpdateUnlockStateByPower>b__0(UIElement element)
			{
			}

			// Token: 0x0400A043 RID: 41027
			[Token(Token = "0x400A043")]
			[FieldOffset(Offset = "0x8")]
			public ICreativePower power;

			// Token: 0x0400A044 RID: 41028
			[Token(Token = "0x400A044")]
			[FieldOffset(Offset = "0xC")]
			public Color colorWhenSelected;

			// Token: 0x0400A045 RID: 41029
			[Token(Token = "0x400A045")]
			[FieldOffset(Offset = "0x10")]
			public IGroupOptionButton asButton;
		}
	}
}
