using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Terraria.Utilities
{
	// Token: 0x020005E2 RID: 1506
	[Token(Token = "0x20005E2")]
	public class WeightedRandom<T>
	{
		// Token: 0x06003C1F RID: 15391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C1F")]
		public WeightedRandom()
		{
		}

		// Token: 0x06003C20 RID: 15392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C20")]
		public WeightedRandom(int seed)
		{
		}

		// Token: 0x06003C21 RID: 15393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C21")]
		public WeightedRandom(UnifiedRandom random)
		{
		}

		// Token: 0x06003C22 RID: 15394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C22")]
		public WeightedRandom(Tuple<T, double>[] theElements)
		{
		}

		// Token: 0x06003C23 RID: 15395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C23")]
		public WeightedRandom(int seed, Tuple<T, double>[] theElements)
		{
		}

		// Token: 0x06003C24 RID: 15396 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C24")]
		public WeightedRandom(UnifiedRandom random, Tuple<T, double>[] theElements)
		{
		}

		// Token: 0x06003C25 RID: 15397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C25")]
		public void Add(T element, double weight = 1.0)
		{
		}

		// Token: 0x06003C26 RID: 15398 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C26")]
		public T Get()
		{
			return null;
		}

		// Token: 0x06003C27 RID: 15399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C27")]
		public void CalculateTotalWeight()
		{
		}

		// Token: 0x06003C28 RID: 15400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C28")]
		public void Clear()
		{
		}

		// Token: 0x06003C29 RID: 15401 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C29")]
		public static implicit operator T(WeightedRandom<T> weightedRandom)
		{
			return null;
		}

		// Token: 0x04004784 RID: 18308
		[Token(Token = "0x4004784")]
		[FieldOffset(Offset = "0x0")]
		public readonly List<Tuple<T, double>> elements;

		// Token: 0x04004785 RID: 18309
		[Token(Token = "0x4004785")]
		[FieldOffset(Offset = "0x0")]
		public readonly UnifiedRandom random;

		// Token: 0x04004786 RID: 18310
		[Token(Token = "0x4004786")]
		[FieldOffset(Offset = "0x0")]
		public bool needsRefresh;

		// Token: 0x04004787 RID: 18311
		[Token(Token = "0x4004787")]
		[FieldOffset(Offset = "0x0")]
		private double _totalWeight;
	}
}
