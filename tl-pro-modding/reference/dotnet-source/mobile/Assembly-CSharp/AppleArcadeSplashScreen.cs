using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Video;

// Token: 0x02000365 RID: 869
[Token(Token = "0x2000365")]
public class AppleArcadeSplashScreen : MonoBehaviour
{
	// Token: 0x06001569 RID: 5481 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001569")]
	[Address(RVA = "0xDF79E8", Offset = "0xDF79E8", VA = "0xDF79E8")]
	public IEnumerator PlayAppleArcadeIntro()
	{
		return null;
	}

	// Token: 0x0600156A RID: 5482 RVA: 0x000096C0 File Offset: 0x000078C0
	[Token(Token = "0x600156A")]
	[Address(RVA = "0xDF7AA0", Offset = "0xDF7AA0", VA = "0xDF7AA0")]
	private bool NearlyEqual(float a, float b, float tolerance = 0.001f)
	{
		return default(bool);
	}

	// Token: 0x0600156B RID: 5483 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600156B")]
	[Address(RVA = "0xDF7AC8", Offset = "0xDF7AC8", VA = "0xDF7AC8")]
	private AppleArcadeSplashScreen.VideoPerDimension GetBestFitSplashScreenVideo()
	{
		return null;
	}

	// Token: 0x0600156C RID: 5484 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600156C")]
	[Address(RVA = "0xDF7C58", Offset = "0xDF7C58", VA = "0xDF7C58")]
	public AppleArcadeSplashScreen()
	{
	}

	// Token: 0x040029C3 RID: 10691
	[Token(Token = "0x40029C3")]
	[FieldOffset(Offset = "0xC")]
	private VideoPlayer videoPlayer;

	// Token: 0x040029C4 RID: 10692
	[Token(Token = "0x40029C4")]
	[FieldOffset(Offset = "0x10")]
	private AppleArcadeSplashScreen.VideoPerDimension[] videos;

	// Token: 0x02000366 RID: 870
	[Token(Token = "0x2000366")]
	[Serializable]
	public class VideoPerDimension
	{
		// Token: 0x0600156D RID: 5485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600156D")]
		[Address(RVA = "0xDF7C60", Offset = "0xDF7C60", VA = "0xDF7C60")]
		public VideoPerDimension()
		{
		}

		// Token: 0x040029C5 RID: 10693
		[Token(Token = "0x40029C5")]
		[FieldOffset(Offset = "0x8")]
		public Vector2 dimensions;

		// Token: 0x040029C6 RID: 10694
		[Token(Token = "0x40029C6")]
		[FieldOffset(Offset = "0x10")]
		public string videoId;
	}

	// Token: 0x02000367 RID: 871
	[Token(Token = "0x2000367")]
	private sealed class <PlayAppleArcadeIntro>d__3 : FileAPI, GUIControllerItem, GUIControllerItem
	{
		// Token: 0x0600156E RID: 5486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600156E")]
		[Address(RVA = "0xDF7A84", Offset = "0xDF7A84", VA = "0xDF7A84")]
		public <PlayAppleArcadeIntro>d__3(int <>1__state)
		{
		}

		// Token: 0x0600156F RID: 5487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600156F")]
		[Address(RVA = "0xDF7C68", Offset = "0xDF7C68", VA = "0xDF7C68", Slot = "5")]
		private void System.IDisposable.Dispose()
		{
		}

		// Token: 0x06001570 RID: 5488 RVA: 0x000096D8 File Offset: 0x000078D8
		[Token(Token = "0x6001570")]
		[Address(RVA = "0xDF7C6C", Offset = "0xDF7C6C", VA = "0xDF7C6C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x06001571 RID: 5489 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001E8")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6001571")]
			[Address(RVA = "0xDF809C", Offset = "0xDF809C", VA = "0xDF809C", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001572 RID: 5490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001572")]
		[Address(RVA = "0xDF80A4", Offset = "0xDF80A4", VA = "0xDF80A4", Slot = "8")]
		private void System.Collections.IEnumerator.Reset()
		{
		}

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x06001573 RID: 5491 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001E9")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6001573")]
			[Address(RVA = "0xDF80F0", Offset = "0xDF80F0", VA = "0xDF80F0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x040029C7 RID: 10695
		[Token(Token = "0x40029C7")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x040029C8 RID: 10696
		[Token(Token = "0x40029C8")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x040029C9 RID: 10697
		[Token(Token = "0x40029C9")]
		[FieldOffset(Offset = "0x10")]
		public AppleArcadeSplashScreen <>4__this;
	}

	// Token: 0x02000368 RID: 872
	[Token(Token = "0x2000368")]
	private sealed class <>c__DisplayClass5_0
	{
		// Token: 0x06001574 RID: 5492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001574")]
		[Address(RVA = "0xDF7C50", Offset = "0xDF7C50", VA = "0xDF7C50")]
		public <>c__DisplayClass5_0()
		{
		}

		// Token: 0x06001575 RID: 5493 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001575")]
		[Address(RVA = "0xDF80F8", Offset = "0xDF80F8", VA = "0xDF80F8")]
		internal AppleArcadeSplashScreen.VideoPerDimension <GetBestFitSplashScreenVideo>b__0(AppleArcadeSplashScreen.VideoPerDimension v1, AppleArcadeSplashScreen.VideoPerDimension v2)
		{
			return null;
		}

		// Token: 0x040029CA RID: 10698
		[Token(Token = "0x40029CA")]
		[FieldOffset(Offset = "0x8")]
		public AppleArcadeSplashScreen <>4__this;

		// Token: 0x040029CB RID: 10699
		[Token(Token = "0x40029CB")]
		[FieldOffset(Offset = "0xC")]
		public Vector2 screen;

		// Token: 0x040029CC RID: 10700
		[Token(Token = "0x40029CC")]
		[FieldOffset(Offset = "0x14")]
		public float aspectScreen;
	}
}
