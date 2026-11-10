using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ReLogic.Content;
using Terraria.IO;

namespace Terraria.DataStructures
{
	// Token: 0x020007BA RID: 1978
	[Token(Token = "0x20007BA")]
	public abstract class SelectionHolder<TCycleType> where TCycleType : class, IConfigKeyHolder
	{
		// Token: 0x17000837 RID: 2103
		// (get) Token: 0x0600445D RID: 17501 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600445E RID: 17502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000837")]
		public string ActiveSelectionKeyName
		{
			[Token(Token = "0x600445D")]
			get
			{
				return null;
			}
			[Token(Token = "0x600445E")]
			private set
			{
			}
		}

		// Token: 0x0600445F RID: 17503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600445F")]
		public void BindTo(Preferences preferences)
		{
		}

		// Token: 0x06004460 RID: 17504
		[Token(Token = "0x6004460")]
		protected abstract void Configuration_Save(Preferences obj);

		// Token: 0x06004461 RID: 17505
		[Token(Token = "0x6004461")]
		protected abstract void Configuration_OnLoad(Preferences obj);

		// Token: 0x06004462 RID: 17506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004462")]
		protected void Wrapped_Configuration_OnLoad(Preferences obj)
		{
		}

		// Token: 0x06004463 RID: 17507
		[Token(Token = "0x6004463")]
		protected abstract void PopulateOptionsAndLoadContent(AssetRequestMode mode);

		// Token: 0x06004464 RID: 17508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004464")]
		public void LoadContent(AssetRequestMode mode)
		{
		}

		// Token: 0x06004465 RID: 17509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004465")]
		public void CycleSelection()
		{
		}

		// Token: 0x06004466 RID: 17510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004466")]
		public void SetActiveMinimapFromLoadedConfigKey()
		{
		}

		// Token: 0x06004467 RID: 17511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004467")]
		private void SetActiveFrame(string frameName)
		{
		}

		// Token: 0x06004468 RID: 17512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004468")]
		private void SetActiveFrame(TCycleType frame)
		{
		}

		// Token: 0x06004469 RID: 17513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004469")]
		protected SelectionHolder()
		{
		}

		// Token: 0x04008BE4 RID: 35812
		[Token(Token = "0x4008BE4")]
		[FieldOffset(Offset = "0x0")]
		protected Dictionary<string, TCycleType> Options;

		// Token: 0x04008BE5 RID: 35813
		[Token(Token = "0x4008BE5")]
		[FieldOffset(Offset = "0x0")]
		protected TCycleType ActiveSelection;

		// Token: 0x04008BE6 RID: 35814
		[Token(Token = "0x4008BE6")]
		[FieldOffset(Offset = "0x0")]
		protected string ActiveSelectionConfigKey;

		// Token: 0x04008BE7 RID: 35815
		[Token(Token = "0x4008BE7")]
		[FieldOffset(Offset = "0x0")]
		protected bool LoadedContent;

		// Token: 0x04008BE8 RID: 35816
		[Token(Token = "0x4008BE8")]
		[FieldOffset(Offset = "0x0")]
		private string <ActiveSelectionKeyName>k__BackingField;

		// Token: 0x020007BB RID: 1979
		[Token(Token = "0x20007BB")]
		private sealed class <>c__DisplayClass14_0
		{
			// Token: 0x0600446A RID: 17514 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600446A")]
			public <>c__DisplayClass14_0()
			{
			}

			// Token: 0x0600446B RID: 17515 RVA: 0x00020C28 File Offset: 0x0001EE28
			[Token(Token = "0x600446B")]
			internal bool <CycleSelection>b__0(TCycleType frame)
			{
				return default(bool);
			}

			// Token: 0x04008BE9 RID: 35817
			[Token(Token = "0x4008BE9")]
			[FieldOffset(Offset = "0x0")]
			public SelectionHolder<TCycleType> <>4__this;

			// Token: 0x04008BEA RID: 35818
			[Token(Token = "0x4008BEA")]
			[FieldOffset(Offset = "0x0")]
			public TCycleType lastFrame;
		}

		// Token: 0x020007BC RID: 1980
		[Token(Token = "0x20007BC")]
		private sealed class <>c__DisplayClass16_0
		{
			// Token: 0x0600446C RID: 17516 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600446C")]
			public <>c__DisplayClass16_0()
			{
			}

			// Token: 0x0600446D RID: 17517 RVA: 0x00020C40 File Offset: 0x0001EE40
			[Token(Token = "0x600446D")]
			internal bool <SetActiveFrame>b__0(KeyValuePair<string, TCycleType> pair)
			{
				return default(bool);
			}

			// Token: 0x04008BEB RID: 35819
			[Token(Token = "0x4008BEB")]
			[FieldOffset(Offset = "0x0")]
			public string frameName;
		}
	}
}
