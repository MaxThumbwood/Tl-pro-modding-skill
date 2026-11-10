using System;
using Il2CppDummyDll;

namespace Terraria.GameContent.Creative
{
	// Token: 0x02000CF1 RID: 3313
	[Token(Token = "0x2000CF1")]
	public static class SortingSteps
	{
		// Token: 0x02000CF2 RID: 3314
		[Token(Token = "0x2000CF2")]
		public abstract class ACreativeItemSortStep : FileAPI, GUIControllerItem, GUIControllerItem
		{
			// Token: 0x0600621F RID: 25119
			[Token(Token = "0x600621F")]
			public abstract string GetDisplayNameKey();

			// Token: 0x06006220 RID: 25120
			[Token(Token = "0x6006220")]
			public abstract int Compare(Item x, Item y);

			// Token: 0x06006221 RID: 25121 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006221")]
			[Address(RVA = "0xAE4A58", Offset = "0xAE4A58", VA = "0xAE4A58")]
			protected ACreativeItemSortStep()
			{
			}
		}

		// Token: 0x02000CF3 RID: 3315
		[Token(Token = "0x2000CF3")]
		public abstract class AStepByFittingFilter : SortingSteps.ACreativeItemSortStep
		{
			// Token: 0x06006222 RID: 25122 RVA: 0x0002D390 File Offset: 0x0002B590
			[Token(Token = "0x6006222")]
			[Address(RVA = "0xAE4A60", Offset = "0xAE4A60", VA = "0xAE4A60", Slot = "7")]
			public override int Compare(Item x, Item y)
			{
				return 0;
			}

			// Token: 0x06006223 RID: 25123
			[Token(Token = "0x6006223")]
			public abstract bool FitsFilter(Item item);

			// Token: 0x06006224 RID: 25124 RVA: 0x0002D3A8 File Offset: 0x0002B5A8
			[Token(Token = "0x6006224")]
			[Address(RVA = "0xAE4B1C", Offset = "0xAE4B1C", VA = "0xAE4B1C", Slot = "9")]
			public virtual int CompareWhenBothFit(Item x, Item y)
			{
				return 0;
			}

			// Token: 0x06006225 RID: 25125 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006225")]
			[Address(RVA = "0xAE4B74", Offset = "0xAE4B74", VA = "0xAE4B74")]
			protected AStepByFittingFilter()
			{
			}
		}

		// Token: 0x02000CF4 RID: 3316
		[Token(Token = "0x2000CF4")]
		public class Blocks : SortingSteps.AStepByFittingFilter
		{
			// Token: 0x06006226 RID: 25126 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006226")]
			[Address(RVA = "0xAE4B7C", Offset = "0xAE4B7C", VA = "0xAE4B7C", Slot = "6")]
			public override string GetDisplayNameKey()
			{
				return null;
			}

			// Token: 0x06006227 RID: 25127 RVA: 0x0002D3C0 File Offset: 0x0002B5C0
			[Token(Token = "0x6006227")]
			[Address(RVA = "0xAE4BC4", Offset = "0xAE4BC4", VA = "0xAE4BC4", Slot = "8")]
			public override bool FitsFilter(Item item)
			{
				return default(bool);
			}

			// Token: 0x06006228 RID: 25128 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006228")]
			[Address(RVA = "0xAE4C6C", Offset = "0xAE4C6C", VA = "0xAE4C6C")]
			public Blocks()
			{
			}
		}

		// Token: 0x02000CF5 RID: 3317
		[Token(Token = "0x2000CF5")]
		public class Walls : SortingSteps.AStepByFittingFilter
		{
			// Token: 0x06006229 RID: 25129 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006229")]
			[Address(RVA = "0xAE4C74", Offset = "0xAE4C74", VA = "0xAE4C74", Slot = "6")]
			public override string GetDisplayNameKey()
			{
				return null;
			}

			// Token: 0x0600622A RID: 25130 RVA: 0x0002D3D8 File Offset: 0x0002B5D8
			[Token(Token = "0x600622A")]
			[Address(RVA = "0xAE4CBC", Offset = "0xAE4CBC", VA = "0xAE4CBC", Slot = "8")]
			public override bool FitsFilter(Item item)
			{
				return default(bool);
			}

			// Token: 0x0600622B RID: 25131 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600622B")]
			[Address(RVA = "0xAE4CE0", Offset = "0xAE4CE0", VA = "0xAE4CE0")]
			public Walls()
			{
			}
		}

		// Token: 0x02000CF6 RID: 3318
		[Token(Token = "0x2000CF6")]
		public class PlaceableObjects : SortingSteps.AStepByFittingFilter
		{
			// Token: 0x0600622C RID: 25132 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600622C")]
			[Address(RVA = "0xAE4CE8", Offset = "0xAE4CE8", VA = "0xAE4CE8", Slot = "6")]
			public override string GetDisplayNameKey()
			{
				return null;
			}

			// Token: 0x0600622D RID: 25133 RVA: 0x0002D3F0 File Offset: 0x0002B5F0
			[Token(Token = "0x600622D")]
			[Address(RVA = "0xAE4D30", Offset = "0xAE4D30", VA = "0xAE4D30", Slot = "8")]
			public override bool FitsFilter(Item item)
			{
				return default(bool);
			}

			// Token: 0x0600622E RID: 25134 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600622E")]
			[Address(RVA = "0xAE4DD8", Offset = "0xAE4DD8", VA = "0xAE4DD8")]
			public PlaceableObjects()
			{
			}
		}

		// Token: 0x02000CF7 RID: 3319
		[Token(Token = "0x2000CF7")]
		public class ByUnlockStatus : SortingSteps.ACreativeItemSortStep
		{
			// Token: 0x0600622F RID: 25135 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600622F")]
			[Address(RVA = "0xAE4DE0", Offset = "0xAE4DE0", VA = "0xAE4DE0", Slot = "6")]
			public override string GetDisplayNameKey()
			{
				return null;
			}

			// Token: 0x06006230 RID: 25136 RVA: 0x0002D408 File Offset: 0x0002B608
			[Token(Token = "0x6006230")]
			[Address(RVA = "0xAE4E28", Offset = "0xAE4E28", VA = "0xAE4E28", Slot = "7")]
			public override int Compare(Item x, Item y)
			{
				return 0;
			}

			// Token: 0x06006231 RID: 25137 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006231")]
			[Address(RVA = "0xAE5040", Offset = "0xAE5040", VA = "0xAE5040")]
			public ByUnlockStatus()
			{
			}
		}

		// Token: 0x02000CF8 RID: 3320
		[Token(Token = "0x2000CF8")]
		public class ByCreativeSortingId : SortingSteps.ACreativeItemSortStep
		{
			// Token: 0x06006232 RID: 25138 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006232")]
			[Address(RVA = "0xAE5048", Offset = "0xAE5048", VA = "0xAE5048", Slot = "6")]
			public override string GetDisplayNameKey()
			{
				return null;
			}

			// Token: 0x06006233 RID: 25139 RVA: 0x0002D420 File Offset: 0x0002B620
			[Token(Token = "0x6006233")]
			[Address(RVA = "0xAE5090", Offset = "0xAE5090", VA = "0xAE5090", Slot = "7")]
			public override int Compare(Item x, Item y)
			{
				return 0;
			}

			// Token: 0x06006234 RID: 25140 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006234")]
			[Address(RVA = "0xAE522C", Offset = "0xAE522C", VA = "0xAE522C")]
			public ByCreativeSortingId()
			{
			}
		}

		// Token: 0x02000CF9 RID: 3321
		[Token(Token = "0x2000CF9")]
		public class Alphabetical : SortingSteps.ACreativeItemSortStep
		{
			// Token: 0x06006235 RID: 25141 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006235")]
			[Address(RVA = "0xAE5234", Offset = "0xAE5234", VA = "0xAE5234", Slot = "6")]
			public override string GetDisplayNameKey()
			{
				return null;
			}

			// Token: 0x06006236 RID: 25142 RVA: 0x0002D438 File Offset: 0x0002B638
			[Token(Token = "0x6006236")]
			[Address(RVA = "0xAE527C", Offset = "0xAE527C", VA = "0xAE527C", Slot = "7")]
			public override int Compare(Item x, Item y)
			{
				return 0;
			}

			// Token: 0x06006237 RID: 25143 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006237")]
			[Address(RVA = "0xAE52E0", Offset = "0xAE52E0", VA = "0xAE52E0")]
			public Alphabetical()
			{
			}
		}
	}
}
