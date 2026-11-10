using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Terraria.DataStructures
{
	// Token: 0x0200075C RID: 1884
	[Token(Token = "0x200075C")]
	public class EntryFilterer<T, U> where T : new() where U : IEntryFilter<T>
	{
		// Token: 0x060042D3 RID: 17107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042D3")]
		public EntryFilterer()
		{
		}

		// Token: 0x060042D4 RID: 17108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042D4")]
		public void AddFilters(List<U> filters)
		{
		}

		// Token: 0x060042D5 RID: 17109 RVA: 0x00020508 File Offset: 0x0001E708
		[Token(Token = "0x60042D5")]
		public bool FitsFilter(T entry)
		{
			return default(bool);
		}

		// Token: 0x060042D6 RID: 17110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042D6")]
		public void ToggleFilter(int filterIndex)
		{
		}

		// Token: 0x060042D7 RID: 17111 RVA: 0x00020520 File Offset: 0x0001E720
		[Token(Token = "0x60042D7")]
		public bool IsFilterActive(int filterIndex)
		{
			return default(bool);
		}

		// Token: 0x060042D8 RID: 17112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042D8")]
		public void SetSearchFilterObject<Z>(Z searchFilter) where Z : ISearchFilter<T>, U
		{
		}

		// Token: 0x060042D9 RID: 17113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042D9")]
		public void SetSearchFilter(string searchFilter)
		{
		}

		// Token: 0x060042DA RID: 17114 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042DA")]
		public string GetDisplayName()
		{
			return null;
		}

		// Token: 0x04008A53 RID: 35411
		[Token(Token = "0x4008A53")]
		[FieldOffset(Offset = "0x0")]
		public List<U> AvailableFilters;

		// Token: 0x04008A54 RID: 35412
		[Token(Token = "0x4008A54")]
		[FieldOffset(Offset = "0x0")]
		public List<U> ActiveFilters;

		// Token: 0x04008A55 RID: 35413
		[Token(Token = "0x4008A55")]
		[FieldOffset(Offset = "0x0")]
		public List<U> AlwaysActiveFilters;

		// Token: 0x04008A56 RID: 35414
		[Token(Token = "0x4008A56")]
		[FieldOffset(Offset = "0x0")]
		private ISearchFilter<T> _searchFilter;

		// Token: 0x04008A57 RID: 35415
		[Token(Token = "0x4008A57")]
		[FieldOffset(Offset = "0x0")]
		private ISearchFilter<T> _searchFilterFromConstructor;
	}
}
