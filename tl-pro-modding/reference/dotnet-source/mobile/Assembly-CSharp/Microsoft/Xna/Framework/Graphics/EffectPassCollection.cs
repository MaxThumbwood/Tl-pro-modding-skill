using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Microsoft.Xna.Framework.Graphics
{
	// Token: 0x020003DC RID: 988
	[Token(Token = "0x20003DC")]
	public class EffectPassCollection : FileAPI, GUIControllerItem
	{
		// Token: 0x06001AEB RID: 6891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AEB")]
		[Address(RVA = "0xE46DD8", Offset = "0xE46DD8", VA = "0xE46DD8")]
		internal EffectPassCollection(EffectPass[] passes)
		{
		}

		// Token: 0x06001AEC RID: 6892 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AEC")]
		[Address(RVA = "0xE46DF4", Offset = "0xE46DF4", VA = "0xE46DF4")]
		internal EffectPassCollection Clone(Effect effect)
		{
			return null;
		}

		// Token: 0x170002F2 RID: 754
		// (get) Token: 0x06001AED RID: 6893 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002F2")]
		public EffectPass Item
		{
			[Token(Token = "0x6001AED")]
			[Address(RVA = "0xE3E8F8", Offset = "0xE3E8F8", VA = "0xE3E8F8")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x06001AEE RID: 6894 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002F3")]
		public EffectPass Item
		{
			[Token(Token = "0x6001AEE")]
			[Address(RVA = "0xE46F78", Offset = "0xE46F78", VA = "0xE46F78")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002F4 RID: 756
		// (get) Token: 0x06001AEF RID: 6895 RVA: 0x0000CE10 File Offset: 0x0000B010
		[Token(Token = "0x170002F4")]
		public int Count
		{
			[Token(Token = "0x6001AEF")]
			[Address(RVA = "0xE46FEC", Offset = "0xE46FEC", VA = "0xE46FEC")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06001AF0 RID: 6896 RVA: 0x0000CE28 File Offset: 0x0000B028
		[Token(Token = "0x6001AF0")]
		[Address(RVA = "0xE47010", Offset = "0xE47010", VA = "0xE47010")]
		public EffectPassCollection.Enumerator GetEnumerator()
		{
			return default(EffectPassCollection.Enumerator);
		}

		// Token: 0x06001AF1 RID: 6897 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AF1")]
		[Address(RVA = "0xE47034", Offset = "0xE47034", VA = "0xE47034", Slot = "4")]
		private IEnumerator<EffectPass> System.Collections.Generic.IEnumerable<Microsoft.Xna.Framework.Graphics.EffectPass>.GetEnumerator()
		{
			return null;
		}

		// Token: 0x06001AF2 RID: 6898 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AF2")]
		[Address(RVA = "0xE470EC", Offset = "0xE470EC", VA = "0xE470EC", Slot = "5")]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}

		// Token: 0x04002E34 RID: 11828
		[Token(Token = "0x4002E34")]
		[FieldOffset(Offset = "0x8")]
		private readonly EffectPass[] _passes;

		// Token: 0x020003DD RID: 989
		[Token(Token = "0x20003DD")]
		public struct Enumerator : FileAPI, GUIControllerItem, GUIControllerItem
		{
			// Token: 0x06001AF3 RID: 6899 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001AF3")]
			[Address(RVA = "0xE47024", Offset = "0xE47024", VA = "0xE47024")]
			internal Enumerator(EffectPass[] array)
			{
			}

			// Token: 0x06001AF4 RID: 6900 RVA: 0x0000CE40 File Offset: 0x0000B040
			[Token(Token = "0x6001AF4")]
			[Address(RVA = "0xE47110", Offset = "0xE47110", VA = "0xE47110", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x170002F5 RID: 757
			// (get) Token: 0x06001AF5 RID: 6901 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170002F5")]
			public EffectPass Current
			{
				[Token(Token = "0x6001AF5")]
				[Address(RVA = "0xE47194", Offset = "0xE47194", VA = "0xE47194", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002F6 RID: 758
			// (get) Token: 0x06001AF6 RID: 6902 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170002F6")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6001AF6")]
				[Address(RVA = "0xE4719C", Offset = "0xE4719C", VA = "0xE4719C", Slot = "7")]
				get
				{
					return null;
				}
			}

			// Token: 0x06001AF7 RID: 6903 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001AF7")]
			[Address(RVA = "0xE47214", Offset = "0xE47214", VA = "0xE47214", Slot = "8")]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			// Token: 0x06001AF8 RID: 6904 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001AF8")]
			[Address(RVA = "0xE47224", Offset = "0xE47224", VA = "0xE47224", Slot = "5")]
			public void Dispose()
			{
			}

			// Token: 0x04002E35 RID: 11829
			[Token(Token = "0x4002E35")]
			[FieldOffset(Offset = "0x0")]
			private readonly EffectPass[] _array;

			// Token: 0x04002E36 RID: 11830
			[Token(Token = "0x4002E36")]
			[FieldOffset(Offset = "0x4")]
			private int _index;

			// Token: 0x04002E37 RID: 11831
			[Token(Token = "0x4002E37")]
			[FieldOffset(Offset = "0x8")]
			private EffectPass _current;
		}
	}
}
