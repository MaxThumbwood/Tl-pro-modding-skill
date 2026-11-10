using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent.UI.BigProgressBar
{
	// Token: 0x02000DBA RID: 3514
	[Token(Token = "0x2000DBA")]
	public class NeverValidProgressBar : FileAPI
	{
		// Token: 0x06006767 RID: 26471 RVA: 0x0002E9C8 File Offset: 0x0002CBC8
		[Token(Token = "0x6006767")]
		[Address(RVA = "0xB74A24", Offset = "0xB74A24", VA = "0xB74A24", Slot = "4")]
		public bool ValidateAndCollectNecessaryInfo(ref BigProgressBarInfo info)
		{
			return default(bool);
		}

		// Token: 0x06006768 RID: 26472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006768")]
		[Address(RVA = "0xB74A2C", Offset = "0xB74A2C", VA = "0xB74A2C", Slot = "5")]
		public void Draw(ref BigProgressBarInfo info, SpriteBatch spriteBatch)
		{
		}

		// Token: 0x06006769 RID: 26473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006769")]
		[Address(RVA = "0xB70744", Offset = "0xB70744", VA = "0xB70744")]
		public NeverValidProgressBar()
		{
		}
	}
}
