using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

namespace Terraria.GameContent.Golf
{
	// Token: 0x02000CD0 RID: 3280
	[Token(Token = "0x2000CD0")]
	public class GolfBallTrackRecord
	{
		// Token: 0x06006162 RID: 24930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006162")]
		[Address(RVA = "0xAB258C", Offset = "0xAB258C", VA = "0xAB258C")]
		public GolfBallTrackRecord()
		{
		}

		// Token: 0x06006163 RID: 24931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006163")]
		[Address(RVA = "0xAB2624", Offset = "0xAB2624", VA = "0xAB2624")]
		public void RecordHit(Vector2 position)
		{
		}

		// Token: 0x06006164 RID: 24932 RVA: 0x0002CFB8 File Offset: 0x0002B1B8
		[Token(Token = "0x6006164")]
		[Address(RVA = "0xAB26E8", Offset = "0xAB26E8", VA = "0xAB26E8")]
		public int GetAccumulatedScore()
		{
			return 0;
		}

		// Token: 0x06006165 RID: 24933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006165")]
		[Address(RVA = "0xAB2758", Offset = "0xAB2758", VA = "0xAB2758")]
		private void GetTrackInfo(out double totalDistancePassed, out int hitsMade)
		{
		}

		// Token: 0x0400A014 RID: 40980
		[Token(Token = "0x400A014")]
		[FieldOffset(Offset = "0x8")]
		private List<Vector2> _hitLocations;
	}
}
