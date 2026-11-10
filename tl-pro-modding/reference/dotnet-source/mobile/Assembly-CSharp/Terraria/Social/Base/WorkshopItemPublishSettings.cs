using System;
using Il2CppDummyDll;

namespace Terraria.Social.Base
{
	// Token: 0x0200063F RID: 1599
	[Token(Token = "0x200063F")]
	public class WorkshopItemPublishSettings
	{
		// Token: 0x06003E11 RID: 15889 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E11")]
		[Address(RVA = "0x1E693A4", Offset = "0x1E693A4", VA = "0x1E693A4")]
		public string[] GetUsedTagsInternalNames()
		{
			return null;
		}

		// Token: 0x06003E12 RID: 15890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E12")]
		[Address(RVA = "0x1E694F4", Offset = "0x1E694F4", VA = "0x1E694F4")]
		public WorkshopItemPublishSettings()
		{
		}

		// Token: 0x0400488C RID: 18572
		[Token(Token = "0x400488C")]
		[FieldOffset(Offset = "0x8")]
		public WorkshopTagOption[] UsedTags;

		// Token: 0x0400488D RID: 18573
		[Token(Token = "0x400488D")]
		[FieldOffset(Offset = "0xC")]
		public WorkshopItemPublicSettingId Publicity;

		// Token: 0x0400488E RID: 18574
		[Token(Token = "0x400488E")]
		[FieldOffset(Offset = "0x10")]
		public string PreviewImagePath;

		// Token: 0x02000640 RID: 1600
		[Token(Token = "0x2000640")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06003E14 RID: 15892 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003E14")]
			[Address(RVA = "0x1E695CC", Offset = "0x1E695CC", VA = "0x1E695CC")]
			public <>c()
			{
			}

			// Token: 0x06003E15 RID: 15893 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003E15")]
			[Address(RVA = "0x1E695D4", Offset = "0x1E695D4", VA = "0x1E695D4")]
			internal string <GetUsedTagsInternalNames>b__3_0(WorkshopTagOption x)
			{
				return null;
			}

			// Token: 0x0400488F RID: 18575
			[Token(Token = "0x400488F")]
			[FieldOffset(Offset = "0x0")]
			public static readonly WorkshopItemPublishSettings.<>c <>9;

			// Token: 0x04004890 RID: 18576
			[Token(Token = "0x4004890")]
			[FieldOffset(Offset = "0x4")]
			public static Func<WorkshopTagOption, string> <>9__3_0;
		}
	}
}
