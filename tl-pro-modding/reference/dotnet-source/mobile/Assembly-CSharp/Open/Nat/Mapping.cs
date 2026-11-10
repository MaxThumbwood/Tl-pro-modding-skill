using System;
using System.Net;
using Il2CppDummyDll;

namespace Open.Nat
{
	// Token: 0x02000E37 RID: 3639
	[Token(Token = "0x2000E37")]
	public class Mapping
	{
		// Token: 0x17000B6B RID: 2923
		// (get) Token: 0x06006A22 RID: 27170 RVA: 0x00030048 File Offset: 0x0002E248
		// (set) Token: 0x06006A23 RID: 27171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B6B")]
		internal MappingLifetime LifetimeType
		{
			[Token(Token = "0x6006A22")]
			[Address(RVA = "0xB94F80", Offset = "0xB94F80", VA = "0xB94F80")]
			get
			{
				return MappingLifetime.Permanent;
			}
			[Token(Token = "0x6006A23")]
			[Address(RVA = "0xB94F88", Offset = "0xB94F88", VA = "0xB94F88")]
			set
			{
			}
		}

		// Token: 0x17000B6C RID: 2924
		// (get) Token: 0x06006A24 RID: 27172 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006A25 RID: 27173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B6C")]
		public string Description
		{
			[Token(Token = "0x6006A24")]
			[Address(RVA = "0xB94F90", Offset = "0xB94F90", VA = "0xB94F90")]
			get
			{
				return null;
			}
			[Token(Token = "0x6006A25")]
			[Address(RVA = "0xB94F98", Offset = "0xB94F98", VA = "0xB94F98")]
			internal set
			{
			}
		}

		// Token: 0x17000B6D RID: 2925
		// (get) Token: 0x06006A26 RID: 27174 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006A27 RID: 27175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B6D")]
		public IPAddress PrivateIP
		{
			[Token(Token = "0x6006A26")]
			[Address(RVA = "0xB94FA0", Offset = "0xB94FA0", VA = "0xB94FA0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6006A27")]
			[Address(RVA = "0xB94FA8", Offset = "0xB94FA8", VA = "0xB94FA8")]
			internal set
			{
			}
		}

		// Token: 0x17000B6E RID: 2926
		// (get) Token: 0x06006A28 RID: 27176 RVA: 0x00030060 File Offset: 0x0002E260
		// (set) Token: 0x06006A29 RID: 27177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B6E")]
		public Protocol Protocol
		{
			[Token(Token = "0x6006A28")]
			[Address(RVA = "0xB94FB0", Offset = "0xB94FB0", VA = "0xB94FB0")]
			get
			{
				return Protocol.Tcp;
			}
			[Token(Token = "0x6006A29")]
			[Address(RVA = "0xB94FB8", Offset = "0xB94FB8", VA = "0xB94FB8")]
			internal set
			{
			}
		}

		// Token: 0x17000B6F RID: 2927
		// (get) Token: 0x06006A2A RID: 27178 RVA: 0x00030078 File Offset: 0x0002E278
		// (set) Token: 0x06006A2B RID: 27179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B6F")]
		public int PrivatePort
		{
			[Token(Token = "0x6006A2A")]
			[Address(RVA = "0xB94FC0", Offset = "0xB94FC0", VA = "0xB94FC0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6006A2B")]
			[Address(RVA = "0xB94FC8", Offset = "0xB94FC8", VA = "0xB94FC8")]
			internal set
			{
			}
		}

		// Token: 0x17000B70 RID: 2928
		// (get) Token: 0x06006A2C RID: 27180 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006A2D RID: 27181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B70")]
		public IPAddress PublicIP
		{
			[Token(Token = "0x6006A2C")]
			[Address(RVA = "0xB94FD0", Offset = "0xB94FD0", VA = "0xB94FD0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6006A2D")]
			[Address(RVA = "0xB94FD8", Offset = "0xB94FD8", VA = "0xB94FD8")]
			internal set
			{
			}
		}

		// Token: 0x17000B71 RID: 2929
		// (get) Token: 0x06006A2E RID: 27182 RVA: 0x00030090 File Offset: 0x0002E290
		// (set) Token: 0x06006A2F RID: 27183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B71")]
		public int PublicPort
		{
			[Token(Token = "0x6006A2E")]
			[Address(RVA = "0xB94FE0", Offset = "0xB94FE0", VA = "0xB94FE0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6006A2F")]
			[Address(RVA = "0xB94FE8", Offset = "0xB94FE8", VA = "0xB94FE8")]
			internal set
			{
			}
		}

		// Token: 0x17000B72 RID: 2930
		// (get) Token: 0x06006A30 RID: 27184 RVA: 0x000300A8 File Offset: 0x0002E2A8
		// (set) Token: 0x06006A31 RID: 27185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B72")]
		public int Lifetime
		{
			[Token(Token = "0x6006A30")]
			[Address(RVA = "0xB94FF0", Offset = "0xB94FF0", VA = "0xB94FF0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6006A31")]
			[Address(RVA = "0xB94FF8", Offset = "0xB94FF8", VA = "0xB94FF8")]
			internal set
			{
			}
		}

		// Token: 0x17000B73 RID: 2931
		// (get) Token: 0x06006A32 RID: 27186 RVA: 0x000300C0 File Offset: 0x0002E2C0
		// (set) Token: 0x06006A33 RID: 27187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B73")]
		public DateTime Expiration
		{
			[Token(Token = "0x6006A32")]
			[Address(RVA = "0xB95118", Offset = "0xB95118", VA = "0xB95118")]
			get
			{
				return default(DateTime);
			}
			[Token(Token = "0x6006A33")]
			[Address(RVA = "0xB95128", Offset = "0xB95128", VA = "0xB95128")]
			internal set
			{
			}
		}

		// Token: 0x06006A34 RID: 27188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A34")]
		[Address(RVA = "0xB95244", Offset = "0xB95244", VA = "0xB95244")]
		internal Mapping(Protocol protocol, IPAddress privateIP, int privatePort, int publicPort)
		{
		}

		// Token: 0x06006A35 RID: 27189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A35")]
		[Address(RVA = "0xB952CC", Offset = "0xB952CC", VA = "0xB952CC")]
		public Mapping(Protocol protocol, IPAddress privateIP, int privatePort, int publicPort, int lifetime, string description)
		{
		}

		// Token: 0x06006A36 RID: 27190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A36")]
		[Address(RVA = "0xB95624", Offset = "0xB95624", VA = "0xB95624")]
		public Mapping(Protocol protocol, int privatePort, int publicPort)
		{
		}

		// Token: 0x06006A37 RID: 27191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A37")]
		[Address(RVA = "0xB956DC", Offset = "0xB956DC", VA = "0xB956DC")]
		public Mapping(Protocol protocol, int privatePort, int publicPort, string description)
		{
		}

		// Token: 0x06006A38 RID: 27192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A38")]
		[Address(RVA = "0xB95778", Offset = "0xB95778", VA = "0xB95778")]
		public Mapping(Protocol protocol, int privatePort, int publicPort, int lifetime, string description)
		{
		}

		// Token: 0x06006A39 RID: 27193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A39")]
		[Address(RVA = "0xB95814", Offset = "0xB95814", VA = "0xB95814")]
		internal Mapping(Mapping mapping)
		{
		}

		// Token: 0x06006A3A RID: 27194 RVA: 0x000300D8 File Offset: 0x0002E2D8
		[Token(Token = "0x6006A3A")]
		[Address(RVA = "0xB958EC", Offset = "0xB958EC", VA = "0xB958EC")]
		public bool IsExpired()
		{
			return default(bool);
		}

		// Token: 0x06006A3B RID: 27195 RVA: 0x000300F0 File Offset: 0x0002E2F0
		[Token(Token = "0x6006A3B")]
		[Address(RVA = "0xB95998", Offset = "0xB95998", VA = "0xB95998")]
		internal bool ShoundRenew()
		{
			return default(bool);
		}

		// Token: 0x06006A3C RID: 27196 RVA: 0x00030108 File Offset: 0x0002E308
		[Token(Token = "0x6006A3C")]
		[Address(RVA = "0xB95A50", Offset = "0xB95A50", VA = "0xB95A50", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06006A3D RID: 27197 RVA: 0x00030120 File Offset: 0x0002E320
		[Token(Token = "0x6006A3D")]
		[Address(RVA = "0xB95B24", Offset = "0xB95B24", VA = "0xB95B24", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06006A3E RID: 27198 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A3E")]
		[Address(RVA = "0xB95B70", Offset = "0xB95B70", VA = "0xB95B70", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0400A7A7 RID: 42919
		[Token(Token = "0x400A7A7")]
		[FieldOffset(Offset = "0x8")]
		private DateTime _expiration;

		// Token: 0x0400A7A8 RID: 42920
		[Token(Token = "0x400A7A8")]
		[FieldOffset(Offset = "0x10")]
		private int _lifetime;

		// Token: 0x0400A7A9 RID: 42921
		[Token(Token = "0x400A7A9")]
		[FieldOffset(Offset = "0x14")]
		private MappingLifetime <LifetimeType>k__BackingField;

		// Token: 0x0400A7AA RID: 42922
		[Token(Token = "0x400A7AA")]
		[FieldOffset(Offset = "0x18")]
		private string <Description>k__BackingField;

		// Token: 0x0400A7AB RID: 42923
		[Token(Token = "0x400A7AB")]
		[FieldOffset(Offset = "0x1C")]
		private IPAddress <PrivateIP>k__BackingField;

		// Token: 0x0400A7AC RID: 42924
		[Token(Token = "0x400A7AC")]
		[FieldOffset(Offset = "0x20")]
		private Protocol <Protocol>k__BackingField;

		// Token: 0x0400A7AD RID: 42925
		[Token(Token = "0x400A7AD")]
		[FieldOffset(Offset = "0x24")]
		private int <PrivatePort>k__BackingField;

		// Token: 0x0400A7AE RID: 42926
		[Token(Token = "0x400A7AE")]
		[FieldOffset(Offset = "0x28")]
		private IPAddress <PublicIP>k__BackingField;

		// Token: 0x0400A7AF RID: 42927
		[Token(Token = "0x400A7AF")]
		[FieldOffset(Offset = "0x2C")]
		private int <PublicPort>k__BackingField;
	}
}
