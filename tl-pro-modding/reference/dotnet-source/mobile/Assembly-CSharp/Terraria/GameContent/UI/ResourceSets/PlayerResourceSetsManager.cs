using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ReLogic.Content;
using Terraria.IO;

namespace Terraria.GameContent.UI.ResourceSets
{
	// Token: 0x02000D4F RID: 3407
	[Token(Token = "0x2000D4F")]
	public class PlayerResourceSetsManager
	{
		// Token: 0x17000AD8 RID: 2776
		// (get) Token: 0x06006511 RID: 25873 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006512 RID: 25874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AD8")]
		public string ActiveSetKeyName
		{
			[Token(Token = "0x6006511")]
			[Address(RVA = "0xB4284C", Offset = "0xB4284C", VA = "0xB4284C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6006512")]
			[Address(RVA = "0xB42854", Offset = "0xB42854", VA = "0xB42854")]
			private set
			{
			}
		}

		// Token: 0x06006513 RID: 25875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006513")]
		[Address(RVA = "0xB4285C", Offset = "0xB4285C", VA = "0xB4285C")]
		public void BindTo(Preferences preferences)
		{
		}

		// Token: 0x06006514 RID: 25876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006514")]
		[Address(RVA = "0xB42970", Offset = "0xB42970", VA = "0xB42970")]
		private void Configuration_OnLoad(Preferences obj)
		{
		}

		// Token: 0x06006515 RID: 25877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006515")]
		[Address(RVA = "0xB42A3C", Offset = "0xB42A3C", VA = "0xB42A3C")]
		private void Configuration_OnSave(Preferences obj)
		{
		}

		// Token: 0x06006516 RID: 25878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006516")]
		[Address(RVA = "0xB42AAC", Offset = "0xB42AAC", VA = "0xB42AAC")]
		public void LoadContent(AssetRequestMode mode)
		{
		}

		// Token: 0x06006517 RID: 25879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006517")]
		[Address(RVA = "0xB42A34", Offset = "0xB42A34", VA = "0xB42A34")]
		public void SetActiveFromLoadedConfigKey()
		{
		}

		// Token: 0x06006518 RID: 25880 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006518")]
		[Address(RVA = "0xB42E60", Offset = "0xB42E60", VA = "0xB42E60")]
		private void SetActive(string name)
		{
		}

		// Token: 0x06006519 RID: 25881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006519")]
		[Address(RVA = "0xB43014", Offset = "0xB43014", VA = "0xB43014")]
		private void SetActiveFrame(IPlayerResourcesDisplaySet set)
		{
		}

		// Token: 0x0600651A RID: 25882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600651A")]
		[Address(RVA = "0xB43144", Offset = "0xB43144", VA = "0xB43144")]
		public void TryToHoverOverResources()
		{
		}

		// Token: 0x0600651B RID: 25883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600651B")]
		[Address(RVA = "0xB431FC", Offset = "0xB431FC", VA = "0xB431FC")]
		public void Draw()
		{
		}

		// Token: 0x0600651C RID: 25884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600651C")]
		[Address(RVA = "0xB432B4", Offset = "0xB432B4", VA = "0xB432B4")]
		public void CycleResourceSet()
		{
		}

		// Token: 0x0600651D RID: 25885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600651D")]
		[Address(RVA = "0xB4347C", Offset = "0xB4347C", VA = "0xB4347C")]
		public PlayerResourceSetsManager()
		{
		}

		// Token: 0x0400A27E RID: 41598
		[Token(Token = "0x400A27E")]
		[FieldOffset(Offset = "0x8")]
		private Dictionary<string, IPlayerResourcesDisplaySet> _sets;

		// Token: 0x0400A27F RID: 41599
		[Token(Token = "0x400A27F")]
		[FieldOffset(Offset = "0xC")]
		private IPlayerResourcesDisplaySet _activeSet;

		// Token: 0x0400A280 RID: 41600
		[Token(Token = "0x400A280")]
		[FieldOffset(Offset = "0x10")]
		private string _activeSetConfigKey;

		// Token: 0x0400A281 RID: 41601
		[Token(Token = "0x400A281")]
		[FieldOffset(Offset = "0x14")]
		private bool _loadedContent;

		// Token: 0x0400A282 RID: 41602
		[Token(Token = "0x400A282")]
		[FieldOffset(Offset = "0x18")]
		private string <ActiveSetKeyName>k__BackingField;

		// Token: 0x02000D50 RID: 3408
		[Token(Token = "0x2000D50")]
		private sealed class <>c__DisplayClass13_0
		{
			// Token: 0x0600651E RID: 25886 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600651E")]
			[Address(RVA = "0xB4300C", Offset = "0xB4300C", VA = "0xB4300C")]
			public <>c__DisplayClass13_0()
			{
			}

			// Token: 0x0600651F RID: 25887 RVA: 0x0002E0E0 File Offset: 0x0002C2E0
			[Token(Token = "0x600651F")]
			[Address(RVA = "0xB43514", Offset = "0xB43514", VA = "0xB43514")]
			internal bool <SetActive>b__0(KeyValuePair<string, IPlayerResourcesDisplaySet> pair)
			{
				return default(bool);
			}

			// Token: 0x0400A283 RID: 41603
			[Token(Token = "0x400A283")]
			[FieldOffset(Offset = "0x8")]
			public string name;
		}

		// Token: 0x02000D51 RID: 3409
		[Token(Token = "0x2000D51")]
		private sealed class <>c__DisplayClass17_0
		{
			// Token: 0x06006520 RID: 25888 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006520")]
			[Address(RVA = "0xB43474", Offset = "0xB43474", VA = "0xB43474")]
			public <>c__DisplayClass17_0()
			{
			}

			// Token: 0x06006521 RID: 25889 RVA: 0x0002E0F8 File Offset: 0x0002C2F8
			[Token(Token = "0x6006521")]
			[Address(RVA = "0xB43564", Offset = "0xB43564", VA = "0xB43564")]
			internal bool <CycleResourceSet>b__0(IPlayerResourcesDisplaySet frame)
			{
				return default(bool);
			}

			// Token: 0x0400A284 RID: 41604
			[Token(Token = "0x400A284")]
			[FieldOffset(Offset = "0x8")]
			public PlayerResourceSetsManager <>4__this;

			// Token: 0x0400A285 RID: 41605
			[Token(Token = "0x400A285")]
			[FieldOffset(Offset = "0xC")]
			public IPlayerResourcesDisplaySet lastFrame;
		}
	}
}
