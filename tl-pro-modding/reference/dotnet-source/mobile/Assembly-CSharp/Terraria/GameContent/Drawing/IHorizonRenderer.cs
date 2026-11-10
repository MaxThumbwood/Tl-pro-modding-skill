using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent.Drawing
{
	// Token: 0x02000CA0 RID: 3232
	[Token(Token = "0x2000CA0")]
	public interface IHorizonRenderer
	{
		// Token: 0x06005FF0 RID: 24560
		[Token(Token = "0x6005FF0")]
		void DrawHorizon();

		// Token: 0x06005FF1 RID: 24561
		[Token(Token = "0x6005FF1")]
		void ModifyHorizonLight(ref Color color);

		// Token: 0x06005FF2 RID: 24562
		[Token(Token = "0x6005FF2")]
		void DrawSun(Vector2 sunPosition);

		// Token: 0x06005FF3 RID: 24563
		[Token(Token = "0x6005FF3")]
		void CloudsStart();

		// Token: 0x06005FF4 RID: 24564
		[Token(Token = "0x6005FF4")]
		void DrawCloud(float globalCloudAlpha, Cloud theCloud, int cloudPass, float cY);

		// Token: 0x06005FF5 RID: 24565
		[Token(Token = "0x6005FF5")]
		void CloudsEnd();

		// Token: 0x06005FF6 RID: 24566
		[Token(Token = "0x6005FF6")]
		void DrawSurfaceLayer(int layerIndex);

		// Token: 0x06005FF7 RID: 24567
		[Token(Token = "0x6005FF7")]
		void DrawLensFlare();
	}
}
