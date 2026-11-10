using System;
using Il2CppDummyDll;

namespace Terraria.GameContent.Animations
{
	// Token: 0x02000C23 RID: 3107
	[Token(Token = "0x2000C23")]
	public interface IAnimationSegmentAction<T>
	{
		// Token: 0x06005D05 RID: 23813
		[Token(Token = "0x6005D05")]
		void BindTo(T obj);

		// Token: 0x17000A50 RID: 2640
		// (get) Token: 0x06005D06 RID: 23814
		[Token(Token = "0x17000A50")]
		int ExpectedLengthOfActionInFrames
		{
			[Token(Token = "0x6005D06")]
			get;
		}

		// Token: 0x06005D07 RID: 23815
		[Token(Token = "0x6005D07")]
		void ApplyTo(T obj, float localTimeForObj);

		// Token: 0x06005D08 RID: 23816
		[Token(Token = "0x6005D08")]
		void SetDelay(float delay);
	}
}
