using System;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;
using Terraria.IO;

namespace Terraria.WorldBuilding
{
	// Token: 0x020005BB RID: 1467
	[Token(Token = "0x20005BB")]
	public class WorldGenConfiguration : GameConfiguration
	{
		// Token: 0x06003B3B RID: 15163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B3B")]
		[Address(RVA = "0x1E0E5F8", Offset = "0x1E0E5F8", VA = "0x1E0E5F8")]
		public WorldGenConfiguration(JObject configurationRoot)
		{
		}

		// Token: 0x06003B3C RID: 15164 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B3C")]
		public T CreateBiome<T>() where T : MicroBiome, new()
		{
			return null;
		}

		// Token: 0x06003B3D RID: 15165 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B3D")]
		public T CreateBiome<T>(string name) where T : MicroBiome, new()
		{
			return null;
		}

		// Token: 0x06003B3E RID: 15166 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B3E")]
		[Address(RVA = "0x1E0E7A8", Offset = "0x1E0E7A8", VA = "0x1E0E7A8")]
		public GameConfiguration GetPassConfiguration(string name)
		{
			return null;
		}

		// Token: 0x06003B3F RID: 15167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B3F")]
		[Address(RVA = "0x1E0E924", Offset = "0x1E0E924", VA = "0x1E0E924")]
		private static void LoadOnMainThread(object nullObject)
		{
		}

		// Token: 0x06003B40 RID: 15168 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B40")]
		[Address(RVA = "0x1E0E9D4", Offset = "0x1E0E9D4", VA = "0x1E0E9D4")]
		public static WorldGenConfiguration FromEmbeddedPath(string path)
		{
			return null;
		}

		// Token: 0x04004704 RID: 18180
		[Token(Token = "0x4004704")]
		[FieldOffset(Offset = "0xC")]
		private readonly JObject _biomeRoot;

		// Token: 0x04004705 RID: 18181
		[Token(Token = "0x4004705")]
		[FieldOffset(Offset = "0x10")]
		private readonly JObject _passRoot;

		// Token: 0x04004706 RID: 18182
		[Token(Token = "0x4004706")]
		[FieldOffset(Offset = "0x0")]
		private static string resource;
	}
}
