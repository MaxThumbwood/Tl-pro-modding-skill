using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.Localization;
using Terraria.UI;

namespace Terraria.WorldBuilding
{
	// Token: 0x0200053B RID: 1339
	[Token(Token = "0x200053B")]
	public abstract class AWorldGenerationOption
	{
		// Token: 0x1400002F RID: 47
		// (add) Token: 0x060039B0 RID: 14768 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x060039B1 RID: 14769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400002F")]
		protected static event Action<AWorldGenerationOption> OnOptionStateChanged
		{
			[Token(Token = "0x60039B0")]
			[Address(RVA = "0x1DF8D68", Offset = "0x1DF8D68", VA = "0x1DF8D68")]
			add
			{
			}
			[Token(Token = "0x60039B1")]
			[Address(RVA = "0x1DF8E44", Offset = "0x1DF8E44", VA = "0x1DF8E44")]
			remove
			{
			}
		}

		// Token: 0x1700073A RID: 1850
		// (get) Token: 0x060039B2 RID: 14770 RVA: 0x0001D190 File Offset: 0x0001B390
		// (set) Token: 0x060039B3 RID: 14771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700073A")]
		public bool Enabled
		{
			[Token(Token = "0x60039B2")]
			[Address(RVA = "0x1DF8F20", Offset = "0x1DF8F20", VA = "0x1DF8F20")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60039B3")]
			[Address(RVA = "0x1DF82C4", Offset = "0x1DF82C4", VA = "0x1DF82C4")]
			set
			{
			}
		}

		// Token: 0x1700073B RID: 1851
		// (get) Token: 0x060039B4 RID: 14772
		[Token(Token = "0x1700073B")]
		protected abstract string KeyName
		{
			[Token(Token = "0x60039B4")]
			get;
		}

		// Token: 0x1700073C RID: 1852
		// (get) Token: 0x060039B5 RID: 14773
		[Token(Token = "0x1700073C")]
		public abstract string ServerConfigName
		{
			[Token(Token = "0x60039B5")]
			get;
		}

		// Token: 0x1700073D RID: 1853
		// (get) Token: 0x060039B6 RID: 14774 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060039B7 RID: 14775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700073D")]
		public string[] SpecialSeedNames
		{
			[Token(Token = "0x60039B6")]
			[Address(RVA = "0x1DF8F28", Offset = "0x1DF8F28", VA = "0x1DF8F28")]
			get
			{
				return null;
			}
			[Token(Token = "0x60039B7")]
			[Address(RVA = "0x1DF8F30", Offset = "0x1DF8F30", VA = "0x1DF8F30")]
			protected set
			{
			}
		}

		// Token: 0x1700073E RID: 1854
		// (get) Token: 0x060039B8 RID: 14776 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060039B9 RID: 14777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700073E")]
		public int[] SpecialSeedValues
		{
			[Token(Token = "0x60039B8")]
			[Address(RVA = "0x1DF8F38", Offset = "0x1DF8F38", VA = "0x1DF8F38")]
			get
			{
				return null;
			}
			[Token(Token = "0x60039B9")]
			[Address(RVA = "0x1DF8F40", Offset = "0x1DF8F40", VA = "0x1DF8F40")]
			protected set
			{
			}
		}

		// Token: 0x1700073F RID: 1855
		// (get) Token: 0x060039BA RID: 14778 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060039BB RID: 14779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700073F")]
		public LocalizedText Description
		{
			[Token(Token = "0x60039BA")]
			[Address(RVA = "0x1DF8F48", Offset = "0x1DF8F48", VA = "0x1DF8F48")]
			get
			{
				return null;
			}
			[Token(Token = "0x60039BB")]
			[Address(RVA = "0x1DF8F50", Offset = "0x1DF8F50", VA = "0x1DF8F50")]
			private set
			{
			}
		}

		// Token: 0x17000740 RID: 1856
		// (get) Token: 0x060039BC RID: 14780 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060039BD RID: 14781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000740")]
		public LocalizedText Title
		{
			[Token(Token = "0x60039BC")]
			[Address(RVA = "0x1DF8F58", Offset = "0x1DF8F58", VA = "0x1DF8F58")]
			get
			{
				return null;
			}
			[Token(Token = "0x60039BD")]
			[Address(RVA = "0x1DF8F60", Offset = "0x1DF8F60", VA = "0x1DF8F60")]
			private set
			{
			}
		}

		// Token: 0x17000741 RID: 1857
		// (get) Token: 0x060039BE RID: 14782 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060039BF RID: 14783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000741")]
		public Asset<Texture2D> Texture
		{
			[Token(Token = "0x60039BE")]
			[Address(RVA = "0x1DF8F68", Offset = "0x1DF8F68", VA = "0x1DF8F68")]
			get
			{
				return null;
			}
			[Token(Token = "0x60039BF")]
			[Address(RVA = "0x1DF8F70", Offset = "0x1DF8F70", VA = "0x1DF8F70")]
			private set
			{
			}
		}

		// Token: 0x060039C0 RID: 14784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039C0")]
		[Address(RVA = "0x1DF8F78", Offset = "0x1DF8F78", VA = "0x1DF8F78", Slot = "6")]
		protected virtual void OnEnabledStateChanged()
		{
		}

		// Token: 0x060039C1 RID: 14785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039C1")]
		[Address(RVA = "0x1DF8F7C", Offset = "0x1DF8F7C", VA = "0x1DF8F7C")]
		public void Load()
		{
		}

		// Token: 0x060039C2 RID: 14786 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60039C2")]
		[Address(RVA = "0x1DF91E8", Offset = "0x1DF91E8", VA = "0x1DF91E8", Slot = "7")]
		public virtual UIElement ProvideUIElement()
		{
			return null;
		}

		// Token: 0x060039C3 RID: 14787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039C3")]
		[Address(RVA = "0x1DF92C4", Offset = "0x1DF92C4", VA = "0x1DF92C4")]
		protected AWorldGenerationOption()
		{
		}

		// Token: 0x040045BC RID: 17852
		[Token(Token = "0x40045BC")]
		[FieldOffset(Offset = "0x8")]
		public bool DisableStateChangeNotification;

		// Token: 0x040045BE RID: 17854
		[Token(Token = "0x40045BE")]
		[FieldOffset(Offset = "0x9")]
		private bool _enabled;

		// Token: 0x040045BF RID: 17855
		[Token(Token = "0x40045BF")]
		[FieldOffset(Offset = "0xA")]
		public bool AutoGenEnabled;

		// Token: 0x040045C0 RID: 17856
		[Token(Token = "0x40045C0")]
		[FieldOffset(Offset = "0xC")]
		private string[] <SpecialSeedNames>k__BackingField;

		// Token: 0x040045C1 RID: 17857
		[Token(Token = "0x40045C1")]
		[FieldOffset(Offset = "0x10")]
		private int[] <SpecialSeedValues>k__BackingField;

		// Token: 0x040045C2 RID: 17858
		[Token(Token = "0x40045C2")]
		[FieldOffset(Offset = "0x14")]
		private LocalizedText <Description>k__BackingField;

		// Token: 0x040045C3 RID: 17859
		[Token(Token = "0x40045C3")]
		[FieldOffset(Offset = "0x18")]
		private LocalizedText <Title>k__BackingField;

		// Token: 0x040045C4 RID: 17860
		[Token(Token = "0x40045C4")]
		[FieldOffset(Offset = "0x1C")]
		private Asset<Texture2D> <Texture>k__BackingField;
	}
}
