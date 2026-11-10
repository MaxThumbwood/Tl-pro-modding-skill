using System;
using Il2CppDummyDll;

namespace Terraria.GameContent.Animations
{
	// Token: 0x02000C46 RID: 3142
	[Token(Token = "0x2000C46")]
	public interface IAnimationSegment
	{
		// Token: 0x17000A68 RID: 2664
		// (get) Token: 0x06005D8D RID: 23949
		[Token(Token = "0x17000A68")]
		float DedicatedTimeNeeded
		{
			[Token(Token = "0x6005D8D")]
			get;
		}

		// Token: 0x06005D8E RID: 23950
		[Token(Token = "0x6005D8E")]
		void Draw(ref GameAnimationSegment info);
	}
}
