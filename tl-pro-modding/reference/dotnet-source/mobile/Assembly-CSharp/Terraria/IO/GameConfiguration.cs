using System;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;

namespace Terraria.IO
{
	// Token: 0x0200066E RID: 1646
	[Token(Token = "0x200066E")]
	public class GameConfiguration
	{
		// Token: 0x06003F94 RID: 16276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F94")]
		[Address(RVA = "0x1E866A0", Offset = "0x1E866A0", VA = "0x1E866A0")]
		public GameConfiguration(JObject configurationRoot)
		{
		}

		// Token: 0x06003F95 RID: 16277 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F95")]
		public T Get<T>(string entry)
		{
			return null;
		}

		// Token: 0x04004979 RID: 18809
		[Token(Token = "0x4004979")]
		[FieldOffset(Offset = "0x8")]
		private readonly JObject _root;
	}
}
