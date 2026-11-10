using System;
using Il2CppDummyDll;

namespace Terraria.UI
{
	// Token: 0x02000886 RID: 2182
	[Token(Token = "0x2000886")]
	public class LegacyGameInterfaceLayer : GameInterfaceLayer
	{
		// Token: 0x06004A3C RID: 19004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A3C")]
		[Address(RVA = "0x61B670", Offset = "0x61B670", VA = "0x61B670")]
		public LegacyGameInterfaceLayer(string name, GameInterfaceDrawMethod drawMethod, InterfaceScaleType scaleType = InterfaceScaleType.Game)
		{
		}

		// Token: 0x06004A3D RID: 19005 RVA: 0x000237D8 File Offset: 0x000219D8
		[Token(Token = "0x6004A3D")]
		[Address(RVA = "0x61B690", Offset = "0x61B690", VA = "0x61B690", Slot = "4")]
		protected override bool DrawSelf()
		{
			return default(bool);
		}

		// Token: 0x04008FB6 RID: 36790
		[Token(Token = "0x4008FB6")]
		[FieldOffset(Offset = "0x10")]
		private GameInterfaceDrawMethod _drawMethod;
	}
}
