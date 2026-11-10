using System;
using System.Reflection;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Terraria.Utilities
{
	// Token: 0x020005CD RID: 1485
	[Token(Token = "0x20005CD")]
	public class EasyDeserializationJsonContractResolver : DefaultContractResolver
	{
		// Token: 0x06003BA6 RID: 15270 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BA6")]
		[Address(RVA = "0x1E1334C", Offset = "0x1E1334C", VA = "0x1E1334C", Slot = "17")]
		protected override JsonContract CreateContract(Type objectType)
		{
			return null;
		}

		// Token: 0x06003BA7 RID: 15271 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BA7")]
		[Address(RVA = "0x1E135C0", Offset = "0x1E135C0", VA = "0x1E135C0", Slot = "20")]
		protected override JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization)
		{
			return null;
		}

		// Token: 0x06003BA8 RID: 15272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BA8")]
		[Address(RVA = "0x1E135F4", Offset = "0x1E135F4", VA = "0x1E135F4")]
		public EasyDeserializationJsonContractResolver()
		{
		}
	}
}
