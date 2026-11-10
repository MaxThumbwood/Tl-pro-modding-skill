using System;
using Il2CppDummyDll;

namespace Terraria.Graphics.CameraModifiers
{
	// Token: 0x020008F2 RID: 2290
	[Token(Token = "0x20008F2")]
	public interface ICameraModifier
	{
		// Token: 0x17000944 RID: 2372
		// (get) Token: 0x06004D01 RID: 19713
		[Token(Token = "0x17000944")]
		string UniqueIdentity
		{
			[Token(Token = "0x6004D01")]
			get;
		}

		// Token: 0x06004D02 RID: 19714
		[Token(Token = "0x6004D02")]
		void Update(ref CameraInfo cameraPosition);

		// Token: 0x17000945 RID: 2373
		// (get) Token: 0x06004D03 RID: 19715
		[Token(Token = "0x17000945")]
		bool IsAScreenShake
		{
			[Token(Token = "0x6004D03")]
			get;
		}

		// Token: 0x17000946 RID: 2374
		// (get) Token: 0x06004D04 RID: 19716
		[Token(Token = "0x17000946")]
		bool Finished
		{
			[Token(Token = "0x6004D04")]
			get;
		}
	}
}
