using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

namespace Terraria.Cinematics
{
	// Token: 0x02000910 RID: 2320
	[Token(Token = "0x2000910")]
	public class CinematicManager
	{
		// Token: 0x06004DD0 RID: 19920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DD0")]
		[Address(RVA = "0x727EC4", Offset = "0x727EC4", VA = "0x727EC4")]
		public void Update(GameTime gameTime)
		{
		}

		// Token: 0x06004DD1 RID: 19921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DD1")]
		[Address(RVA = "0x7282C0", Offset = "0x7282C0", VA = "0x7282C0")]
		public void PlayFilm(Film film)
		{
		}

		// Token: 0x06004DD2 RID: 19922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DD2")]
		[Address(RVA = "0x72837C", Offset = "0x72837C", VA = "0x72837C")]
		public void StopAll()
		{
		}

		// Token: 0x06004DD3 RID: 19923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DD3")]
		[Address(RVA = "0x728380", Offset = "0x728380", VA = "0x728380")]
		public CinematicManager()
		{
		}

		// Token: 0x040092D4 RID: 37588
		[Token(Token = "0x40092D4")]
		[FieldOffset(Offset = "0x0")]
		public static CinematicManager Instance;

		// Token: 0x040092D5 RID: 37589
		[Token(Token = "0x40092D5")]
		[FieldOffset(Offset = "0x8")]
		private List<Film> _films;
	}
}
