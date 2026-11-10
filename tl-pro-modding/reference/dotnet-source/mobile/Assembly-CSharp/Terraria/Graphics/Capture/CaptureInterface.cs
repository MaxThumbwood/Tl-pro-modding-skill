using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.Graphics.Capture
{
	// Token: 0x020008E8 RID: 2280
	[Token(Token = "0x20008E8")]
	public class CaptureInterface
	{
		// Token: 0x17000940 RID: 2368
		// (get) Token: 0x06004CB3 RID: 19635 RVA: 0x00024138 File Offset: 0x00022338
		[Token(Token = "0x17000940")]
		private static Matrix SelectionZoomMatrix
		{
			[Token(Token = "0x6004CB3")]
			[Address(RVA = "0x70FF7C", Offset = "0x70FF7C", VA = "0x70FF7C")]
			get
			{
				return default(Matrix);
			}
		}

		// Token: 0x06004CB4 RID: 19636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CB4")]
		[Address(RVA = "0x710144", Offset = "0x710144", VA = "0x710144")]
		private static void SetZoom_Context()
		{
		}

		// Token: 0x06004CB5 RID: 19637 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004CB5")]
		[Address(RVA = "0x71021C", Offset = "0x71021C", VA = "0x71021C")]
		private static Dictionary<int, CaptureInterface.CaptureInterfaceMode> FillModes()
		{
			return null;
		}

		// Token: 0x06004CB6 RID: 19638 RVA: 0x00024150 File Offset: 0x00022350
		[Token(Token = "0x6004CB6")]
		[Address(RVA = "0x710420", Offset = "0x710420", VA = "0x710420")]
		public static Rectangle GetArea()
		{
			return default(Rectangle);
		}

		// Token: 0x06004CB7 RID: 19639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CB7")]
		[Address(RVA = "0x710548", Offset = "0x710548", VA = "0x710548")]
		public void Update(CaptureInterface.SelectionContext context)
		{
		}

		// Token: 0x06004CB8 RID: 19640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CB8")]
		[Address(RVA = "0x7114F4", Offset = "0x7114F4", VA = "0x7114F4")]
		public void Draw(SpriteBatch sb)
		{
		}

		// Token: 0x06004CB9 RID: 19641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CB9")]
		[Address(RVA = "0x710B34", Offset = "0x710B34", VA = "0x710B34")]
		public void ToggleCamera(bool On = true)
		{
		}

		// Token: 0x06004CBA RID: 19642 RVA: 0x00024168 File Offset: 0x00022368
		[Token(Token = "0x6004CBA")]
		[Address(RVA = "0x710E78", Offset = "0x710E78", VA = "0x710E78")]
		private bool UpdateButtons(Vector2 mouse)
		{
			return default(bool);
		}

		// Token: 0x06004CBB RID: 19643 RVA: 0x00024180 File Offset: 0x00022380
		[Token(Token = "0x6004CBB")]
		[Address(RVA = "0x7143CC", Offset = "0x7143CC", VA = "0x7143CC")]
		public static Rectangle FullScreenArea()
		{
			return default(Rectangle);
		}

		// Token: 0x06004CBC RID: 19644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CBC")]
		[Address(RVA = "0x713A74", Offset = "0x713A74", VA = "0x713A74")]
		public static void QuickScreenshot()
		{
		}

		// Token: 0x06004CBD RID: 19645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CBD")]
		[Address(RVA = "0x7121D8", Offset = "0x7121D8", VA = "0x7121D8")]
		private void DrawButtons(SpriteBatch sb)
		{
		}

		// Token: 0x06004CBE RID: 19646 RVA: 0x00024198 File Offset: 0x00022398
		[Token(Token = "0x6004CBE")]
		[Address(RVA = "0x7148D4", Offset = "0x7148D4", VA = "0x7148D4")]
		private static bool GetMapCoords(int PinX, int PinY, int Goal, out Point result)
		{
			return default(bool);
		}

		// Token: 0x06004CBF RID: 19647 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CBF")]
		[Address(RVA = "0x714914", Offset = "0x714914", VA = "0x714914")]
		private static void ConstraintPoints()
		{
		}

		// Token: 0x06004CC0 RID: 19648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CC0")]
		[Address(RVA = "0x7149F0", Offset = "0x7149F0", VA = "0x7149F0")]
		private static void PointWorldClamp(ref Point point, int fluff)
		{
		}

		// Token: 0x06004CC1 RID: 19649 RVA: 0x000241B0 File Offset: 0x000223B0
		[Token(Token = "0x6004CC1")]
		[Address(RVA = "0x714AFC", Offset = "0x714AFC", VA = "0x714AFC")]
		public bool UsingMap()
		{
			return default(bool);
		}

		// Token: 0x06004CC2 RID: 19650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CC2")]
		[Address(RVA = "0x7142F8", Offset = "0x7142F8", VA = "0x7142F8")]
		public static void ResetFocus()
		{
		}

		// Token: 0x06004CC3 RID: 19651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CC3")]
		[Address(RVA = "0x714BEC", Offset = "0x714BEC", VA = "0x714BEC")]
		public void Scrolling()
		{
		}

		// Token: 0x06004CC4 RID: 19652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CC4")]
		[Address(RVA = "0x714CF8", Offset = "0x714CF8", VA = "0x714CF8")]
		public void UpdateCameraCountdown()
		{
		}

		// Token: 0x06004CC5 RID: 19653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CC5")]
		[Address(RVA = "0x7131A0", Offset = "0x7131A0", VA = "0x7131A0")]
		private void DrawCameraLock(SpriteBatch sb)
		{
		}

		// Token: 0x06004CC6 RID: 19654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CC6")]
		[Address(RVA = "0x7141DC", Offset = "0x7141DC", VA = "0x7141DC")]
		public static void StartCamera(CaptureSettings settings)
		{
		}

		// Token: 0x06004CC7 RID: 19655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CC7")]
		[Address(RVA = "0x714FB4", Offset = "0x714FB4", VA = "0x714FB4")]
		public static void EndCamera()
		{
		}

		// Token: 0x06004CC8 RID: 19656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CC8")]
		[Address(RVA = "0x71501C", Offset = "0x71501C", VA = "0x71501C")]
		public CaptureInterface()
		{
		}

		// Token: 0x040091C9 RID: 37321
		[Token(Token = "0x40091C9")]
		[FieldOffset(Offset = "0x0")]
		private static CaptureInterface.SelectionContext _selectionContext;

		// Token: 0x040091CA RID: 37322
		[Token(Token = "0x40091CA")]
		[FieldOffset(Offset = "0x4")]
		private static Dictionary<int, CaptureInterface.CaptureInterfaceMode> Modes;

		// Token: 0x040091CB RID: 37323
		[Token(Token = "0x40091CB")]
		[FieldOffset(Offset = "0x8")]
		public bool Active;

		// Token: 0x040091CC RID: 37324
		[Token(Token = "0x40091CC")]
		[FieldOffset(Offset = "0x8")]
		public static bool JustActivated;

		// Token: 0x040091CD RID: 37325
		[Token(Token = "0x40091CD")]
		[FieldOffset(Offset = "0x9")]
		private bool KeyToggleActiveHeld;

		// Token: 0x040091CE RID: 37326
		[Token(Token = "0x40091CE")]
		[FieldOffset(Offset = "0xC")]
		public int SelectedMode;

		// Token: 0x040091CF RID: 37327
		[Token(Token = "0x40091CF")]
		[FieldOffset(Offset = "0x10")]
		public int HoveredMode;

		// Token: 0x040091D0 RID: 37328
		[Token(Token = "0x40091D0")]
		[FieldOffset(Offset = "0x9")]
		public static bool EdgeAPinned;

		// Token: 0x040091D1 RID: 37329
		[Token(Token = "0x40091D1")]
		[FieldOffset(Offset = "0xA")]
		public static bool EdgeBPinned;

		// Token: 0x040091D2 RID: 37330
		[Token(Token = "0x40091D2")]
		[FieldOffset(Offset = "0xC")]
		public static Point EdgeA;

		// Token: 0x040091D3 RID: 37331
		[Token(Token = "0x40091D3")]
		[FieldOffset(Offset = "0x14")]
		public static Point EdgeB;

		// Token: 0x040091D4 RID: 37332
		[Token(Token = "0x40091D4")]
		[FieldOffset(Offset = "0x1C")]
		public static bool CameraLock;

		// Token: 0x040091D5 RID: 37333
		[Token(Token = "0x40091D5")]
		[FieldOffset(Offset = "0x20")]
		private static float CameraFrame;

		// Token: 0x040091D6 RID: 37334
		[Token(Token = "0x40091D6")]
		[FieldOffset(Offset = "0x24")]
		private static float CameraWaiting;

		// Token: 0x040091D7 RID: 37335
		[Token(Token = "0x40091D7")]
		private const float CameraMaxFrame = 5f;

		// Token: 0x040091D8 RID: 37336
		[Token(Token = "0x40091D8")]
		private const float CameraMaxWait = 60f;

		// Token: 0x040091D9 RID: 37337
		[Token(Token = "0x40091D9")]
		[FieldOffset(Offset = "0x28")]
		private static CaptureSettings CameraSettings;

		// Token: 0x020008E9 RID: 2281
		[Token(Token = "0x20008E9")]
		public static class Settings
		{
			// Token: 0x040091DA RID: 37338
			[Token(Token = "0x40091DA")]
			[FieldOffset(Offset = "0x0")]
			public static bool PackImage;

			// Token: 0x040091DB RID: 37339
			[Token(Token = "0x40091DB")]
			[FieldOffset(Offset = "0x1")]
			public static bool IncludeEntities;

			// Token: 0x040091DC RID: 37340
			[Token(Token = "0x40091DC")]
			[FieldOffset(Offset = "0x2")]
			public static bool TransparentBackground;

			// Token: 0x040091DD RID: 37341
			[Token(Token = "0x40091DD")]
			[FieldOffset(Offset = "0x4")]
			public static int BiomeChoiceIndex;

			// Token: 0x040091DE RID: 37342
			[Token(Token = "0x40091DE")]
			[FieldOffset(Offset = "0x8")]
			public static int ScreenAnchor;

			// Token: 0x040091DF RID: 37343
			[Token(Token = "0x40091DF")]
			[FieldOffset(Offset = "0xC")]
			public static Color MarkedAreaColor;
		}

		// Token: 0x020008EA RID: 2282
		[Token(Token = "0x20008EA")]
		private abstract class CaptureInterfaceMode
		{
			// Token: 0x06004CCB RID: 19659
			[Token(Token = "0x6004CCB")]
			public abstract void Update();

			// Token: 0x06004CCC RID: 19660
			[Token(Token = "0x6004CCC")]
			public abstract void Draw(SpriteBatch sb);

			// Token: 0x06004CCD RID: 19661
			[Token(Token = "0x6004CCD")]
			public abstract void ToggleActive(bool tickedOn);

			// Token: 0x06004CCE RID: 19662
			[Token(Token = "0x6004CCE")]
			public abstract bool UsingMap();

			// Token: 0x06004CCF RID: 19663 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004CCF")]
			[Address(RVA = "0x715158", Offset = "0x715158", VA = "0x715158")]
			protected void StartDrawingSelection(SpriteBatch sb)
			{
			}

			// Token: 0x06004CD0 RID: 19664 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004CD0")]
			[Address(RVA = "0x71543C", Offset = "0x71543C", VA = "0x71543C")]
			protected void EndDrawingSelection(SpriteBatch sb)
			{
			}

			// Token: 0x06004CD1 RID: 19665 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004CD1")]
			[Address(RVA = "0x71579C", Offset = "0x71579C", VA = "0x71579C")]
			protected CaptureInterfaceMode()
			{
			}

			// Token: 0x040091E0 RID: 37344
			[Token(Token = "0x40091E0")]
			[FieldOffset(Offset = "0x8")]
			public bool Selected;
		}

		// Token: 0x020008EB RID: 2283
		[Token(Token = "0x20008EB")]
		public enum SelectionContext
		{
			// Token: 0x040091E2 RID: 37346
			[Token(Token = "0x40091E2")]
			World,
			// Token: 0x040091E3 RID: 37347
			[Token(Token = "0x40091E3")]
			Map
		}

		// Token: 0x020008EC RID: 2284
		[Token(Token = "0x20008EC")]
		private class ModeEdgeSelection : CaptureInterface.CaptureInterfaceMode
		{
			// Token: 0x06004CD2 RID: 19666 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004CD2")]
			[Address(RVA = "0x7157A4", Offset = "0x7157A4", VA = "0x7157A4", Slot = "4")]
			public override void Update()
			{
			}

			// Token: 0x06004CD3 RID: 19667 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004CD3")]
			[Address(RVA = "0x715B4C", Offset = "0x715B4C", VA = "0x715B4C", Slot = "5")]
			public override void Draw(SpriteBatch sb)
			{
			}

			// Token: 0x06004CD4 RID: 19668 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004CD4")]
			[Address(RVA = "0x717F08", Offset = "0x717F08", VA = "0x717F08", Slot = "6")]
			public override void ToggleActive(bool tickedOn)
			{
			}

			// Token: 0x06004CD5 RID: 19669 RVA: 0x000241C8 File Offset: 0x000223C8
			[Token(Token = "0x6004CD5")]
			[Address(RVA = "0x717F0C", Offset = "0x717F0C", VA = "0x717F0C", Slot = "7")]
			public override bool UsingMap()
			{
				return default(bool);
			}

			// Token: 0x06004CD6 RID: 19670 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004CD6")]
			[Address(RVA = "0x7158C8", Offset = "0x7158C8", VA = "0x7158C8")]
			private void EdgePlacement(Vector2 mouse)
			{
			}

			// Token: 0x06004CD7 RID: 19671 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004CD7")]
			[Address(RVA = "0x715B80", Offset = "0x715B80", VA = "0x715B80")]
			private void DrawMarkedArea(SpriteBatch sb)
			{
			}

			// Token: 0x06004CD8 RID: 19672 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004CD8")]
			[Address(RVA = "0x716514", Offset = "0x716514", VA = "0x716514")]
			private void DrawCursors(SpriteBatch sb)
			{
			}

			// Token: 0x06004CD9 RID: 19673 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004CD9")]
			[Address(RVA = "0x7103F4", Offset = "0x7103F4", VA = "0x7103F4")]
			public ModeEdgeSelection()
			{
			}
		}

		// Token: 0x020008ED RID: 2285
		[Token(Token = "0x20008ED")]
		private class ModeDragBounds : CaptureInterface.CaptureInterfaceMode
		{
			// Token: 0x06004CDA RID: 19674 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004CDA")]
			[Address(RVA = "0x717F14", Offset = "0x717F14", VA = "0x717F14", Slot = "4")]
			public override void Update()
			{
			}

			// Token: 0x06004CDB RID: 19675 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004CDB")]
			[Address(RVA = "0x718C58", Offset = "0x718C58", VA = "0x718C58", Slot = "5")]
			public override void Draw(SpriteBatch sb)
			{
			}

			// Token: 0x06004CDC RID: 19676 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004CDC")]
			[Address(RVA = "0x7194E8", Offset = "0x7194E8", VA = "0x7194E8", Slot = "6")]
			public override void ToggleActive(bool tickedOn)
			{
			}

			// Token: 0x06004CDD RID: 19677 RVA: 0x000241E0 File Offset: 0x000223E0
			[Token(Token = "0x6004CDD")]
			[Address(RVA = "0x7194F8", Offset = "0x7194F8", VA = "0x7194F8", Slot = "7")]
			public override bool UsingMap()
			{
				return default(bool);
			}

			// Token: 0x06004CDE RID: 19678 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004CDE")]
			[Address(RVA = "0x718068", Offset = "0x718068", VA = "0x718068")]
			private void DragBounds(Vector2 mouse)
			{
			}

			// Token: 0x06004CDF RID: 19679 RVA: 0x000241F8 File Offset: 0x000223F8
			[Token(Token = "0x6004CDF")]
			[Address(RVA = "0x71950C", Offset = "0x71950C", VA = "0x71950C")]
			private Rectangle GetBound(Rectangle drawbox, int boundIndex)
			{
				return default(Rectangle);
			}

			// Token: 0x06004CE0 RID: 19680 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004CE0")]
			[Address(RVA = "0x718C90", Offset = "0x718C90", VA = "0x718C90")]
			public void DrawMarkedArea(SpriteBatch sb)
			{
			}

			// Token: 0x06004CE1 RID: 19681 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004CE1")]
			[Address(RVA = "0x719684", Offset = "0x719684", VA = "0x719684")]
			private void DrawBound(SpriteBatch sb, Rectangle r, int mode)
			{
			}

			// Token: 0x06004CE2 RID: 19682 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004CE2")]
			[Address(RVA = "0x7103FC", Offset = "0x7103FC", VA = "0x7103FC")]
			public ModeDragBounds()
			{
			}

			// Token: 0x040091E4 RID: 37348
			[Token(Token = "0x40091E4")]
			[FieldOffset(Offset = "0xC")]
			public int currentAim;

			// Token: 0x040091E5 RID: 37349
			[Token(Token = "0x40091E5")]
			[FieldOffset(Offset = "0x10")]
			private bool dragging;

			// Token: 0x040091E6 RID: 37350
			[Token(Token = "0x40091E6")]
			[FieldOffset(Offset = "0x14")]
			private int caughtEdge;

			// Token: 0x040091E7 RID: 37351
			[Token(Token = "0x40091E7")]
			[FieldOffset(Offset = "0x18")]
			private bool inMap;
		}

		// Token: 0x020008EE RID: 2286
		[Token(Token = "0x20008EE")]
		private class ModeChangeSettings : CaptureInterface.CaptureInterfaceMode
		{
			// Token: 0x06004CE3 RID: 19683 RVA: 0x00024210 File Offset: 0x00022410
			[Token(Token = "0x6004CE3")]
			[Address(RVA = "0x719BB8", Offset = "0x719BB8", VA = "0x719BB8")]
			private Rectangle GetRect()
			{
				return default(Rectangle);
			}

			// Token: 0x06004CE4 RID: 19684 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004CE4")]
			[Address(RVA = "0x719CB8", Offset = "0x719CB8", VA = "0x719CB8")]
			private void ButtonDraw(int button, ref string key, ref string value)
			{
			}

			// Token: 0x06004CE5 RID: 19685 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004CE5")]
			[Address(RVA = "0x71A02C", Offset = "0x71A02C", VA = "0x71A02C")]
			private void PressButton(int button)
			{
			}

			// Token: 0x06004CE6 RID: 19686 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004CE6")]
			[Address(RVA = "0x71A1B0", Offset = "0x71A1B0", VA = "0x71A1B0")]
			private void DrawWaterChoices(SpriteBatch spritebatch, Point start, Point mouse)
			{
			}

			// Token: 0x06004CE7 RID: 19687 RVA: 0x00024228 File Offset: 0x00022428
			[Token(Token = "0x6004CE7")]
			[Address(RVA = "0x71AB34", Offset = "0x71AB34", VA = "0x71AB34")]
			private int UnnecessaryBiomeSelectionTypeConversion(int index)
			{
				return 0;
			}

			// Token: 0x06004CE8 RID: 19688 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004CE8")]
			[Address(RVA = "0x71AB54", Offset = "0x71AB54", VA = "0x71AB54", Slot = "4")]
			public override void Update()
			{
			}

			// Token: 0x06004CE9 RID: 19689 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004CE9")]
			[Address(RVA = "0x71AF70", Offset = "0x71AF70", VA = "0x71AF70", Slot = "5")]
			public override void Draw(SpriteBatch sb)
			{
			}

			// Token: 0x06004CEA RID: 19690 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004CEA")]
			[Address(RVA = "0x71B904", Offset = "0x71B904", VA = "0x71B904", Slot = "6")]
			public override void ToggleActive(bool tickedOn)
			{
			}

			// Token: 0x06004CEB RID: 19691 RVA: 0x00024240 File Offset: 0x00022440
			[Token(Token = "0x6004CEB")]
			[Address(RVA = "0x71B914", Offset = "0x71B914", VA = "0x71B914", Slot = "7")]
			public override bool UsingMap()
			{
				return default(bool);
			}

			// Token: 0x06004CEC RID: 19692 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004CEC")]
			[Address(RVA = "0x710410", Offset = "0x710410", VA = "0x710410")]
			public ModeChangeSettings()
			{
			}

			// Token: 0x040091E8 RID: 37352
			[Token(Token = "0x40091E8")]
			private const int ButtonsCount = 7;

			// Token: 0x040091E9 RID: 37353
			[Token(Token = "0x40091E9")]
			[FieldOffset(Offset = "0xC")]
			private int hoveredButton;

			// Token: 0x040091EA RID: 37354
			[Token(Token = "0x40091EA")]
			[FieldOffset(Offset = "0x10")]
			private bool inUI;
		}
	}
}
