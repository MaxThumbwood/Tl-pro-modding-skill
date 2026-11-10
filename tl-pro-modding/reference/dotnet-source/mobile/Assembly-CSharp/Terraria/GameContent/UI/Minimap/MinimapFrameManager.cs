using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.DataStructures;
using Terraria.IO;

namespace Terraria.GameContent.UI.Minimap
{
	// Token: 0x02000D57 RID: 3415
	[Token(Token = "0x2000D57")]
	public class MinimapFrameManager : SelectionHolder<MinimapFrame>
	{
		// Token: 0x06006544 RID: 25924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006544")]
		[Address(RVA = "0xB44EE0", Offset = "0xB44EE0", VA = "0xB44EE0", Slot = "5")]
		protected override void Configuration_OnLoad(Preferences obj)
		{
		}

		// Token: 0x06006545 RID: 25925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006545")]
		[Address(RVA = "0xB44FC0", Offset = "0xB44FC0", VA = "0xB44FC0", Slot = "4")]
		protected override void Configuration_Save(Preferences obj)
		{
		}

		// Token: 0x06006546 RID: 25926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006546")]
		[Address(RVA = "0xB45030", Offset = "0xB45030", VA = "0xB45030", Slot = "6")]
		protected override void PopulateOptionsAndLoadContent(AssetRequestMode mode)
		{
		}

		// Token: 0x06006547 RID: 25927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006547")]
		[Address(RVA = "0xB45890", Offset = "0xB45890", VA = "0xB45890")]
		private void CreateAndAdd(string name, Vector2 frameOffset, Vector2 resetPosition, Vector2 zoomInPosition, Vector2 zoomOutPosition, AssetRequestMode mode)
		{
		}

		// Token: 0x06006548 RID: 25928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006548")]
		[Address(RVA = "0xB45C88", Offset = "0xB45C88", VA = "0xB45C88")]
		public void DrawTo(SpriteBatch spriteBatch, Vector2 position)
		{
		}

		// Token: 0x06006549 RID: 25929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006549")]
		[Address(RVA = "0xB45CEC", Offset = "0xB45CEC", VA = "0xB45CEC")]
		public void DrawForeground(SpriteBatch spriteBatch)
		{
		}

		// Token: 0x0600654A RID: 25930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600654A")]
		[Address(RVA = "0xB45D14", Offset = "0xB45D14", VA = "0xB45D14")]
		public MinimapFrameManager()
		{
		}
	}
}
