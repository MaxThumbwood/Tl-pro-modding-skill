using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200003E RID: 62
[Token(Token = "0x200003E")]
public static class AndroidImmersive
{
	// Token: 0x0600015C RID: 348 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600015C")]
	[Address(RVA = "0x49E78C", Offset = "0x49E78C", VA = "0x49E78C")]
	public static void Activate()
	{
	}

	// Token: 0x0600015D RID: 349 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600015D")]
	[Address(RVA = "0x4A46E4", Offset = "0x4A46E4", VA = "0x4A46E4")]
	public static void Deactivate(bool blockReactivation)
	{
	}

	// Token: 0x0600015E RID: 350 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600015E")]
	[Address(RVA = "0x4A4A34", Offset = "0x4A4A34", VA = "0x4A4A34")]
	private static void RunActivate()
	{
	}

	// Token: 0x0600015F RID: 351 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600015F")]
	[Address(RVA = "0x4A4DF0", Offset = "0x4A4DF0", VA = "0x4A4DF0")]
	private static void RunDeactivate()
	{
	}

	// Token: 0x06000160 RID: 352 RVA: 0x00002A30 File Offset: 0x00000C30
	[Token(Token = "0x6000160")]
	[Address(RVA = "0x4A4404", Offset = "0x4A4404", VA = "0x4A4404")]
	private static int GetSDKLevel()
	{
		return 0;
	}

	// Token: 0x04000346 RID: 838
	[Token(Token = "0x4000346")]
	[FieldOffset(Offset = "0x0")]
	private static AndroidJavaObject _viewInstance;

	// Token: 0x04000347 RID: 839
	[Token(Token = "0x4000347")]
	[FieldOffset(Offset = "0x4")]
	private static AndroidJavaObject _viewInstanceBackup;

	// Token: 0x04000348 RID: 840
	[Token(Token = "0x4000348")]
	[FieldOffset(Offset = "0x8")]
	private static bool _blockReactivation;

	// Token: 0x04000349 RID: 841
	[Token(Token = "0x4000349")]
	private const int SYSTEM_UI_FLAG_HIDE_NAVIGATION = 2;

	// Token: 0x0400034A RID: 842
	[Token(Token = "0x400034A")]
	private const int SYSTEM_UI_FLAG_FULLSCREEN = 4;

	// Token: 0x0400034B RID: 843
	[Token(Token = "0x400034B")]
	private const int SYSTEM_UI_FLAG_LAYOUT_STABLE = 256;

	// Token: 0x0400034C RID: 844
	[Token(Token = "0x400034C")]
	private const int SYSTEM_UI_FLAG_LAYOUT_HIDE_NAVIGATION = 512;

	// Token: 0x0400034D RID: 845
	[Token(Token = "0x400034D")]
	private const int SYSTEM_UI_FLAG_LAYOUT_FULLSCREEN = 1024;

	// Token: 0x0400034E RID: 846
	[Token(Token = "0x400034E")]
	private const int SYSTEM_UI_FLAG_IMMERSIVE = 2048;

	// Token: 0x0400034F RID: 847
	[Token(Token = "0x400034F")]
	private const int SYSTEM_UI_FLAG_IMMERSIVE_STICKY = 4096;

	// Token: 0x0200003F RID: 63
	// (Invoke) Token: 0x06000162 RID: 354
	[Token(Token = "0x200003F")]
	private delegate void RunPtr();

	// Token: 0x02000040 RID: 64
	[Token(Token = "0x2000040")]
	private class Listener : AndroidJavaProxy
	{
		// Token: 0x06000165 RID: 357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000165")]
		[Address(RVA = "0x4A4D68", Offset = "0x4A4D68", VA = "0x4A4D68")]
		public Listener()
		{
		}

		// Token: 0x06000166 RID: 358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000166")]
		[Address(RVA = "0x4A4FC4", Offset = "0x4A4FC4", VA = "0x4A4FC4")]
		private void onSystemUiVisibilityChange(int visibility)
		{
		}
	}
}
