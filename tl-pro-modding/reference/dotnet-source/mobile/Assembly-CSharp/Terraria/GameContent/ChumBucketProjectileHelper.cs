using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

namespace Terraria.GameContent
{
	// Token: 0x02000949 RID: 2377
	[Token(Token = "0x2000949")]
	public class ChumBucketProjectileHelper
	{
		// Token: 0x06004F61 RID: 20321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F61")]
		[Address(RVA = "0x74CA7C", Offset = "0x74CA7C", VA = "0x74CA7C")]
		public void OnPreUpdateAllProjectiles()
		{
		}

		// Token: 0x06004F62 RID: 20322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F62")]
		[Address(RVA = "0x74CB44", Offset = "0x74CB44", VA = "0x74CB44")]
		public void AddChumLocation(Vector2 spot)
		{
		}

		// Token: 0x06004F63 RID: 20323 RVA: 0x00024F30 File Offset: 0x00023130
		[Token(Token = "0x6004F63")]
		[Address(RVA = "0x74CC70", Offset = "0x74CC70", VA = "0x74CC70")]
		public int GetChumsInLocation(Point tileCoords)
		{
			return 0;
		}

		// Token: 0x06004F64 RID: 20324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F64")]
		[Address(RVA = "0x74CD00", Offset = "0x74CD00", VA = "0x74CD00")]
		public ChumBucketProjectileHelper()
		{
		}

		// Token: 0x04009384 RID: 37764
		[Token(Token = "0x4009384")]
		[FieldOffset(Offset = "0x8")]
		private Dictionary<Point, int> _chumCountsPendingForThisFrame;

		// Token: 0x04009385 RID: 37765
		[Token(Token = "0x4009385")]
		[FieldOffset(Offset = "0xC")]
		private Dictionary<Point, int> _chumCountsFromLastFrame;
	}
}
