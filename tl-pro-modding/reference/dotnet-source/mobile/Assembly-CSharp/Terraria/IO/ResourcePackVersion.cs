using System;
using Il2CppDummyDll;

namespace Terraria.IO
{
	// Token: 0x02000674 RID: 1652
	[Token(Token = "0x2000674")]
	public struct ResourcePackVersion : FileAPI, GUIControllerItem
	{
		// Token: 0x17000800 RID: 2048
		// (get) Token: 0x06003FD3 RID: 16339 RVA: 0x0001F500 File Offset: 0x0001D700
		// (set) Token: 0x06003FD4 RID: 16340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000800")]
		public int Major
		{
			[Token(Token = "0x6003FD3")]
			[Address(RVA = "0x1E8A948", Offset = "0x1E8A948", VA = "0x1E8A948")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6003FD4")]
			[Address(RVA = "0x1E8A950", Offset = "0x1E8A950", VA = "0x1E8A950")]
			private set
			{
			}
		}

		// Token: 0x17000801 RID: 2049
		// (get) Token: 0x06003FD5 RID: 16341 RVA: 0x0001F518 File Offset: 0x0001D718
		// (set) Token: 0x06003FD6 RID: 16342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000801")]
		public int Minor
		{
			[Token(Token = "0x6003FD5")]
			[Address(RVA = "0x1E8A958", Offset = "0x1E8A958", VA = "0x1E8A958")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6003FD6")]
			[Address(RVA = "0x1E8A960", Offset = "0x1E8A960", VA = "0x1E8A960")]
			private set
			{
			}
		}

		// Token: 0x06003FD7 RID: 16343 RVA: 0x0001F530 File Offset: 0x0001D730
		[Token(Token = "0x6003FD7")]
		[Address(RVA = "0x1E8A968", Offset = "0x1E8A968", VA = "0x1E8A968", Slot = "4")]
		public int CompareTo(object obj)
		{
			return 0;
		}

		// Token: 0x06003FD8 RID: 16344 RVA: 0x0001F548 File Offset: 0x0001D748
		[Token(Token = "0x6003FD8")]
		[Address(RVA = "0x1E8AA9C", Offset = "0x1E8AA9C", VA = "0x1E8AA9C", Slot = "5")]
		public int CompareTo(ResourcePackVersion other)
		{
			return 0;
		}

		// Token: 0x06003FD9 RID: 16345 RVA: 0x0001F560 File Offset: 0x0001D760
		[Token(Token = "0x6003FD9")]
		[Address(RVA = "0x1E8AAF0", Offset = "0x1E8AAF0", VA = "0x1E8AAF0")]
		public static bool operator ==(ResourcePackVersion lhs, ResourcePackVersion rhs)
		{
			return default(bool);
		}

		// Token: 0x06003FDA RID: 16346 RVA: 0x0001F578 File Offset: 0x0001D778
		[Token(Token = "0x6003FDA")]
		[Address(RVA = "0x1E8AB40", Offset = "0x1E8AB40", VA = "0x1E8AB40")]
		public static bool operator !=(ResourcePackVersion lhs, ResourcePackVersion rhs)
		{
			return default(bool);
		}

		// Token: 0x06003FDB RID: 16347 RVA: 0x0001F590 File Offset: 0x0001D790
		[Token(Token = "0x6003FDB")]
		[Address(RVA = "0x1E8AB90", Offset = "0x1E8AB90", VA = "0x1E8AB90")]
		public static bool operator <(ResourcePackVersion lhs, ResourcePackVersion rhs)
		{
			return default(bool);
		}

		// Token: 0x06003FDC RID: 16348 RVA: 0x0001F5A8 File Offset: 0x0001D7A8
		[Token(Token = "0x6003FDC")]
		[Address(RVA = "0x1E8ABDC", Offset = "0x1E8ABDC", VA = "0x1E8ABDC")]
		public static bool operator >(ResourcePackVersion lhs, ResourcePackVersion rhs)
		{
			return default(bool);
		}

		// Token: 0x06003FDD RID: 16349 RVA: 0x0001F5C0 File Offset: 0x0001D7C0
		[Token(Token = "0x6003FDD")]
		[Address(RVA = "0x1E8AC34", Offset = "0x1E8AC34", VA = "0x1E8AC34", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06003FDE RID: 16350 RVA: 0x0001F5D8 File Offset: 0x0001D7D8
		[Token(Token = "0x6003FDE")]
		[Address(RVA = "0x1E8ACF4", Offset = "0x1E8ACF4", VA = "0x1E8ACF4", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06003FDF RID: 16351 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FDF")]
		[Address(RVA = "0x1E8AD24", Offset = "0x1E8AD24", VA = "0x1E8AD24")]
		public string GetFormattedVersion()
		{
			return null;
		}

		// Token: 0x0400499A RID: 18842
		[Token(Token = "0x400499A")]
		[FieldOffset(Offset = "0x0")]
		private int <Major>k__BackingField;

		// Token: 0x0400499B RID: 18843
		[Token(Token = "0x400499B")]
		[FieldOffset(Offset = "0x4")]
		private int <Minor>k__BackingField;
	}
}
