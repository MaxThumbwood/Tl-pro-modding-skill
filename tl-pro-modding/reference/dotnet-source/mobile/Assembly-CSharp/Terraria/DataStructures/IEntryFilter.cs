using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.UI;

namespace Terraria.DataStructures
{
	// Token: 0x02000759 RID: 1881
	[Token(Token = "0x2000759")]
	public interface IEntryFilter<T>
	{
		// Token: 0x060042CD RID: 17101
		[Token(Token = "0x60042CD")]
		bool FitsFilter(T entry);

		// Token: 0x060042CE RID: 17102
		[Token(Token = "0x60042CE")]
		string GetDisplayNameKey();

		// Token: 0x060042CF RID: 17103
		[Token(Token = "0x60042CF")]
		UIElement GetImage();

		// Token: 0x060042D0 RID: 17104
		[Token(Token = "0x60042D0")]
		void GetDisplay(out Texture2D texture, out Rectangle frame);
	}
}
