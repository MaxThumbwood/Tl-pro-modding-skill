using System;
using Il2CppDummyDll;

namespace Terraria.Social.Base
{
	// Token: 0x02000634 RID: 1588
	[Token(Token = "0x2000634")]
	public abstract class OverlaySocialModule : FileAPI
	{
		// Token: 0x06003DD6 RID: 15830
		[Token(Token = "0x6003DD6")]
		public abstract void Initialize();

		// Token: 0x06003DD7 RID: 15831
		[Token(Token = "0x6003DD7")]
		public abstract void Shutdown();

		// Token: 0x06003DD8 RID: 15832
		[Token(Token = "0x6003DD8")]
		public abstract bool IsGamepadTextInputActive();

		// Token: 0x06003DD9 RID: 15833
		[Token(Token = "0x6003DD9")]
		public abstract bool ShowGamepadTextInput(string description, uint maxLength, bool multiLine = false, string existingText = "", bool password = false);

		// Token: 0x06003DDA RID: 15834
		[Token(Token = "0x6003DDA")]
		public abstract string GetGamepadText();

		// Token: 0x06003DDB RID: 15835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DDB")]
		[Address(RVA = "0x1E68020", Offset = "0x1E68020", VA = "0x1E68020")]
		protected OverlaySocialModule()
		{
		}
	}
}
