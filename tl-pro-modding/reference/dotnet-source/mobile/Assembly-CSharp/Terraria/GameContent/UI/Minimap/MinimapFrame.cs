using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;

namespace Terraria.GameContent.UI.Minimap
{
	// Token: 0x02000D55 RID: 3413
	[Token(Token = "0x2000D55")]
	public class MinimapFrame : FileAPI
	{
		// Token: 0x17000AD9 RID: 2777
		// (get) Token: 0x06006528 RID: 25896 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006529 RID: 25897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AD9")]
		public string ConfigKey
		{
			[Token(Token = "0x6006528")]
			[Address(RVA = "0xB4375C", Offset = "0xB4375C", VA = "0xB4375C", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x6006529")]
			[Address(RVA = "0xB43764", Offset = "0xB43764", VA = "0xB43764")]
			set
			{
			}
		}

		// Token: 0x17000ADA RID: 2778
		// (get) Token: 0x0600652A RID: 25898 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600652B RID: 25899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000ADA")]
		public string NameKey
		{
			[Token(Token = "0x600652A")]
			[Address(RVA = "0xB4376C", Offset = "0xB4376C", VA = "0xB4376C", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600652B")]
			[Address(RVA = "0xB43774", Offset = "0xB43774", VA = "0xB43774")]
			set
			{
			}
		}

		// Token: 0x17000ADB RID: 2779
		// (get) Token: 0x0600652C RID: 25900 RVA: 0x0002E110 File Offset: 0x0002C310
		// (set) Token: 0x0600652D RID: 25901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000ADB")]
		public Vector2 MinimapPosition
		{
			[Token(Token = "0x600652C")]
			[Address(RVA = "0xB4377C", Offset = "0xB4377C", VA = "0xB4377C")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x600652D")]
			[Address(RVA = "0xB43790", Offset = "0xB43790", VA = "0xB43790")]
			set
			{
			}
		}

		// Token: 0x17000ADC RID: 2780
		// (get) Token: 0x0600652E RID: 25902 RVA: 0x0002E128 File Offset: 0x0002C328
		// (set) Token: 0x0600652F RID: 25903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000ADC")]
		private Vector2 FramePosition
		{
			[Token(Token = "0x600652E")]
			[Address(RVA = "0xB4379C", Offset = "0xB4379C", VA = "0xB4379C")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x600652F")]
			[Address(RVA = "0xB43840", Offset = "0xB43840", VA = "0xB43840")]
			set
			{
			}
		}

		// Token: 0x06006530 RID: 25904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006530")]
		[Address(RVA = "0xB438E4", Offset = "0xB438E4", VA = "0xB438E4")]
		public MinimapFrame(Asset<Texture2D> frameTexture, Vector2 frameOffset)
		{
		}

		// Token: 0x06006531 RID: 25905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006531")]
		[Address(RVA = "0xB43910", Offset = "0xB43910", VA = "0xB43910")]
		public void SetResetButton(Asset<Texture2D> hoverTexture, Vector2 position)
		{
		}

		// Token: 0x06006532 RID: 25906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006532")]
		[Address(RVA = "0xB43A30", Offset = "0xB43A30", VA = "0xB43A30")]
		private void ResetZoom()
		{
		}

		// Token: 0x06006533 RID: 25907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006533")]
		[Address(RVA = "0xB43A98", Offset = "0xB43A98", VA = "0xB43A98")]
		public void SetZoomInButton(Asset<Texture2D> hoverTexture, Vector2 position)
		{
		}

		// Token: 0x06006534 RID: 25908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006534")]
		[Address(RVA = "0xB43B84", Offset = "0xB43B84", VA = "0xB43B84")]
		private void ZoomInButton()
		{
		}

		// Token: 0x06006535 RID: 25909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006535")]
		[Address(RVA = "0xB43C00", Offset = "0xB43C00", VA = "0xB43C00")]
		public void SetZoomOutButton(Asset<Texture2D> hoverTexture, Vector2 position)
		{
		}

		// Token: 0x06006536 RID: 25910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006536")]
		[Address(RVA = "0xB43CEC", Offset = "0xB43CEC", VA = "0xB43CEC")]
		private void ZoomOutButton()
		{
		}

		// Token: 0x06006537 RID: 25911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006537")]
		[Address(RVA = "0xB43D68", Offset = "0xB43D68", VA = "0xB43D68")]
		public void Update()
		{
		}

		// Token: 0x06006538 RID: 25912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006538")]
		[Address(RVA = "0xB443BC", Offset = "0xB443BC", VA = "0xB443BC")]
		public void DrawBackground(SpriteBatch spriteBatch)
		{
		}

		// Token: 0x06006539 RID: 25913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006539")]
		[Address(RVA = "0xB44560", Offset = "0xB44560", VA = "0xB44560")]
		public void DrawForeground(SpriteBatch spriteBatch)
		{
		}

		// Token: 0x0600653A RID: 25914 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600653A")]
		[Address(RVA = "0xB4404C", Offset = "0xB4404C", VA = "0xB4404C")]
		private MinimapFrame.Button GetButtonUnderMouse()
		{
			return null;
		}

		// Token: 0x0600653B RID: 25915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600653B")]
		[Address(RVA = "0xB44048", Offset = "0xB44048", VA = "0xB44048")]
		private void ValidateState()
		{
		}

		// Token: 0x0600653C RID: 25916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600653C")]
		[Address(RVA = "0xB44CD0", Offset = "0xB44CD0", VA = "0xB44CD0")]
		private void <SetResetButton>b__24_0()
		{
		}

		// Token: 0x0600653D RID: 25917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600653D")]
		[Address(RVA = "0xB44D38", Offset = "0xB44D38", VA = "0xB44D38")]
		private void <SetZoomInButton>b__26_0()
		{
		}

		// Token: 0x0600653E RID: 25918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600653E")]
		[Address(RVA = "0xB44DB4", Offset = "0xB44DB4", VA = "0xB44DB4")]
		private void <SetZoomOutButton>b__28_0()
		{
		}

		// Token: 0x0400A295 RID: 41621
		[Token(Token = "0x400A295")]
		private const float DEFAULT_ZOOM = 1.05f;

		// Token: 0x0400A296 RID: 41622
		[Token(Token = "0x400A296")]
		private const float ZOOM_OUT_MULTIPLIER = 0.975f;

		// Token: 0x0400A297 RID: 41623
		[Token(Token = "0x400A297")]
		private const float ZOOM_IN_MULTIPLIER = 1.025f;

		// Token: 0x0400A298 RID: 41624
		[Token(Token = "0x400A298")]
		[FieldOffset(Offset = "0x8")]
		private string <ConfigKey>k__BackingField;

		// Token: 0x0400A299 RID: 41625
		[Token(Token = "0x400A299")]
		[FieldOffset(Offset = "0xC")]
		private string <NameKey>k__BackingField;

		// Token: 0x0400A29A RID: 41626
		[Token(Token = "0x400A29A")]
		[FieldOffset(Offset = "0x10")]
		private Vector2 <MinimapPosition>k__BackingField;

		// Token: 0x0400A29B RID: 41627
		[Token(Token = "0x400A29B")]
		[FieldOffset(Offset = "0x18")]
		private readonly Asset<Texture2D> _frameTexture;

		// Token: 0x0400A29C RID: 41628
		[Token(Token = "0x400A29C")]
		[FieldOffset(Offset = "0x1C")]
		private readonly Vector2 _frameOffset;

		// Token: 0x0400A29D RID: 41629
		[Token(Token = "0x400A29D")]
		[FieldOffset(Offset = "0x24")]
		private MinimapFrame.Button _resetButton;

		// Token: 0x0400A29E RID: 41630
		[Token(Token = "0x400A29E")]
		[FieldOffset(Offset = "0x28")]
		private MinimapFrame.Button _zoomInButton;

		// Token: 0x0400A29F RID: 41631
		[Token(Token = "0x400A29F")]
		[FieldOffset(Offset = "0x2C")]
		private MinimapFrame.Button _zoomOutButton;

		// Token: 0x02000D56 RID: 3414
		[Token(Token = "0x2000D56")]
		private class Button
		{
			// Token: 0x17000ADD RID: 2781
			// (get) Token: 0x0600653F RID: 25919 RVA: 0x0002E140 File Offset: 0x0002C340
			[Token(Token = "0x17000ADD")]
			private Vector2 Size
			{
				[Token(Token = "0x600653F")]
				[Address(RVA = "0xB44E30", Offset = "0xB44E30", VA = "0xB44E30")]
				get
				{
					return default(Vector2);
				}
			}

			// Token: 0x06006540 RID: 25920 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006540")]
			[Address(RVA = "0xB439FC", Offset = "0xB439FC", VA = "0xB439FC")]
			public Button(Asset<Texture2D> hoverTexture, Vector2 position, Action mouseDownCallback)
			{
			}

			// Token: 0x06006541 RID: 25921 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006541")]
			[Address(RVA = "0xB44394", Offset = "0xB44394", VA = "0xB44394")]
			public void Click()
			{
			}

			// Token: 0x06006542 RID: 25922 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006542")]
			[Address(RVA = "0xB448A0", Offset = "0xB448A0", VA = "0xB448A0")]
			public void Draw(SpriteBatch spriteBatch, Vector2 parentPosition)
			{
			}

			// Token: 0x06006543 RID: 25923 RVA: 0x0002E158 File Offset: 0x0002C358
			[Token(Token = "0x6006543")]
			[Address(RVA = "0xB449C8", Offset = "0xB449C8", VA = "0xB449C8")]
			public bool IsTouchingPoint(Vector2 testPoint, Vector2 parentPosition)
			{
				return default(bool);
			}

			// Token: 0x0400A2A0 RID: 41632
			[Token(Token = "0x400A2A0")]
			[FieldOffset(Offset = "0x8")]
			public bool IsHighlighted;

			// Token: 0x0400A2A1 RID: 41633
			[Token(Token = "0x400A2A1")]
			[FieldOffset(Offset = "0xC")]
			private readonly Vector2 _position;

			// Token: 0x0400A2A2 RID: 41634
			[Token(Token = "0x400A2A2")]
			[FieldOffset(Offset = "0x14")]
			private readonly Asset<Texture2D> _hoverTexture;

			// Token: 0x0400A2A3 RID: 41635
			[Token(Token = "0x400A2A3")]
			[FieldOffset(Offset = "0x18")]
			private readonly Action _onMouseDown;
		}
	}
}
