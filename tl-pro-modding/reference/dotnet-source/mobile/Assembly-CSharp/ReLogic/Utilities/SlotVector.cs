using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace ReLogic.Utilities
{
	// Token: 0x02000DD5 RID: 3541
	[Token(Token = "0x2000DD5")]
	public sealed class SlotVector<T> : FileAPI, GUIControllerItem
	{
		// Token: 0x17000B11 RID: 2833
		// (get) Token: 0x060067EC RID: 26604 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060067ED RID: 26605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B11")]
		public T Item
		{
			[Token(Token = "0x60067EC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60067ED")]
			set
			{
			}
		}

		// Token: 0x17000B12 RID: 2834
		// (get) Token: 0x060067EE RID: 26606 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060067EF RID: 26607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B12")]
		public T Item
		{
			[Token(Token = "0x60067EE")]
			get
			{
				return null;
			}
			[Token(Token = "0x60067EF")]
			set
			{
			}
		}

		// Token: 0x17000B13 RID: 2835
		// (get) Token: 0x060067F0 RID: 26608 RVA: 0x0002F190 File Offset: 0x0002D390
		// (set) Token: 0x060067F1 RID: 26609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B13")]
		public int Count
		{
			[Token(Token = "0x60067F0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60067F1")]
			private set
			{
			}
		}

		// Token: 0x17000B14 RID: 2836
		// (get) Token: 0x060067F2 RID: 26610 RVA: 0x0002F1A8 File Offset: 0x0002D3A8
		[Token(Token = "0x17000B14")]
		public int Capacity
		{
			[Token(Token = "0x60067F2")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060067F3 RID: 26611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60067F3")]
		public SlotVector(int capacity)
		{
		}

		// Token: 0x060067F4 RID: 26612 RVA: 0x0002F1C0 File Offset: 0x0002D3C0
		[Token(Token = "0x60067F4")]
		public SlotId Add(T value)
		{
			return default(SlotId);
		}

		// Token: 0x060067F5 RID: 26613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60067F5")]
		public void Clear()
		{
		}

		// Token: 0x060067F6 RID: 26614 RVA: 0x0002F1D8 File Offset: 0x0002D3D8
		[Token(Token = "0x60067F6")]
		public bool Remove(SlotId id)
		{
			return default(bool);
		}

		// Token: 0x060067F7 RID: 26615 RVA: 0x0002F1F0 File Offset: 0x0002D3F0
		[Token(Token = "0x60067F7")]
		public bool Has(SlotId id)
		{
			return default(bool);
		}

		// Token: 0x060067F8 RID: 26616 RVA: 0x0002F208 File Offset: 0x0002D408
		[Token(Token = "0x60067F8")]
		public bool Has(int index)
		{
			return default(bool);
		}

		// Token: 0x060067F9 RID: 26617 RVA: 0x0002F220 File Offset: 0x0002D420
		[Token(Token = "0x60067F9")]
		public SlotVector<T>.ItemPair GetPair(int index)
		{
			return default(SlotVector<T>.ItemPair);
		}

		// Token: 0x060067FA RID: 26618 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067FA")]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}

		// Token: 0x060067FB RID: 26619 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067FB")]
		private IEnumerator<SlotVector<T>.ItemPair> System.Collections.Generic.IEnumerable<ReLogic.Utilities.SlotVector<T>.ItemPair>.GetEnumerator()
		{
			return null;
		}

		// Token: 0x0400A4BF RID: 42175
		[Token(Token = "0x400A4BF")]
		private const uint MAX_INDEX = 65535U;

		// Token: 0x0400A4C0 RID: 42176
		[Token(Token = "0x400A4C0")]
		[FieldOffset(Offset = "0x0")]
		private readonly SlotVector<T>.ItemPair[] _array;

		// Token: 0x0400A4C1 RID: 42177
		[Token(Token = "0x400A4C1")]
		[FieldOffset(Offset = "0x0")]
		private uint _freeHead;

		// Token: 0x0400A4C2 RID: 42178
		[Token(Token = "0x400A4C2")]
		[FieldOffset(Offset = "0x0")]
		private uint _usedSpaceLength;

		// Token: 0x0400A4C3 RID: 42179
		[Token(Token = "0x400A4C3")]
		[FieldOffset(Offset = "0x0")]
		private int <Count>k__BackingField;

		// Token: 0x02000DD6 RID: 3542
		[Token(Token = "0x2000DD6")]
		public sealed class Enumerator : FileAPI, GUIControllerItem, GUIControllerItem
		{
			// Token: 0x060067FC RID: 26620 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60067FC")]
			public Enumerator(SlotVector<T> slotVector)
			{
			}

			// Token: 0x17000B15 RID: 2837
			// (get) Token: 0x060067FD RID: 26621 RVA: 0x0002F238 File Offset: 0x0002D438
			[Token(Token = "0x17000B15")]
			private SlotVector<T>.ItemPair System.Collections.Generic.IEnumerator<ReLogic.Utilities.SlotVector<T>.ItemPair>.Current
			{
				[Token(Token = "0x60067FD")]
				get
				{
					return default(SlotVector<T>.ItemPair);
				}
			}

			// Token: 0x17000B16 RID: 2838
			// (get) Token: 0x060067FE RID: 26622 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000B16")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60067FE")]
				get
				{
					return null;
				}
			}

			// Token: 0x060067FF RID: 26623 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60067FF")]
			public void Reset()
			{
			}

			// Token: 0x06006800 RID: 26624 RVA: 0x0002F250 File Offset: 0x0002D450
			[Token(Token = "0x6006800")]
			public bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x06006801 RID: 26625 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006801")]
			public void Dispose()
			{
			}

			// Token: 0x0400A4C4 RID: 42180
			[Token(Token = "0x400A4C4")]
			[FieldOffset(Offset = "0x0")]
			private SlotVector<T> _slotVector;

			// Token: 0x0400A4C5 RID: 42181
			[Token(Token = "0x400A4C5")]
			[FieldOffset(Offset = "0x0")]
			private int _index;
		}

		// Token: 0x02000DD7 RID: 3543
		[Token(Token = "0x2000DD7")]
		public struct ItemPair
		{
			// Token: 0x06006802 RID: 26626 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006802")]
			public ItemPair(T value, SlotId id)
			{
			}

			// Token: 0x0400A4C6 RID: 42182
			[Token(Token = "0x400A4C6")]
			[FieldOffset(Offset = "0x0")]
			public readonly T Value;

			// Token: 0x0400A4C7 RID: 42183
			[Token(Token = "0x400A4C7")]
			[FieldOffset(Offset = "0x0")]
			public readonly SlotId Id;
		}
	}
}
