using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

namespace Terraria.Cinematics
{
	// Token: 0x02000915 RID: 2325
	[Token(Token = "0x2000915")]
	public class Film
	{
		// Token: 0x1700096A RID: 2410
		// (get) Token: 0x06004E0D RID: 19981 RVA: 0x00024720 File Offset: 0x00022920
		[Token(Token = "0x1700096A")]
		public int Frame
		{
			[Token(Token = "0x6004E0D")]
			[Address(RVA = "0x72E94C", Offset = "0x72E94C", VA = "0x72E94C")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700096B RID: 2411
		// (get) Token: 0x06004E0E RID: 19982 RVA: 0x00024738 File Offset: 0x00022938
		[Token(Token = "0x1700096B")]
		public int FrameCount
		{
			[Token(Token = "0x6004E0E")]
			[Address(RVA = "0x72E954", Offset = "0x72E954", VA = "0x72E954")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700096C RID: 2412
		// (get) Token: 0x06004E0F RID: 19983 RVA: 0x00024750 File Offset: 0x00022950
		[Token(Token = "0x1700096C")]
		public int AppendPoint
		{
			[Token(Token = "0x6004E0F")]
			[Address(RVA = "0x72E95C", Offset = "0x72E95C", VA = "0x72E95C")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700096D RID: 2413
		// (get) Token: 0x06004E10 RID: 19984 RVA: 0x00024768 File Offset: 0x00022968
		[Token(Token = "0x1700096D")]
		public bool IsActive
		{
			[Token(Token = "0x6004E10")]
			[Address(RVA = "0x72E964", Offset = "0x72E964", VA = "0x72E964")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06004E11 RID: 19985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E11")]
		[Address(RVA = "0x729F80", Offset = "0x729F80", VA = "0x729F80")]
		public void AddSequence(int start, int duration, FrameEvent frameEvent)
		{
		}

		// Token: 0x06004E12 RID: 19986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E12")]
		[Address(RVA = "0x729F60", Offset = "0x729F60", VA = "0x729F60")]
		public void AppendSequence(int duration, FrameEvent frameEvent)
		{
		}

		// Token: 0x06004E13 RID: 19987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E13")]
		[Address(RVA = "0x729EFC", Offset = "0x729EFC", VA = "0x729EFC")]
		public void AddSequences(int start, int duration, FrameEvent[] frameEvents)
		{
		}

		// Token: 0x06004E14 RID: 19988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E14")]
		[Address(RVA = "0x729BC4", Offset = "0x729BC4", VA = "0x729BC4")]
		public void AppendSequences(int duration, FrameEvent[] frameEvents)
		{
		}

		// Token: 0x06004E15 RID: 19989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E15")]
		[Address(RVA = "0x72D7F0", Offset = "0x72D7F0", VA = "0x72D7F0")]
		public void AppendEmptySequence(int duration)
		{
		}

		// Token: 0x06004E16 RID: 19990 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E16")]
		[Address(RVA = "0x729EF0", Offset = "0x729EF0", VA = "0x729EF0")]
		public void AppendKeyFrame(FrameEvent frameEvent)
		{
		}

		// Token: 0x06004E17 RID: 19991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E17")]
		[Address(RVA = "0x729A14", Offset = "0x729A14", VA = "0x729A14")]
		public void AppendKeyFrames(FrameEvent[] frameEvents)
		{
		}

		// Token: 0x06004E18 RID: 19992 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E18")]
		[Address(RVA = "0x729D98", Offset = "0x729D98", VA = "0x729D98")]
		public void AddKeyFrame(int frame, FrameEvent frameEvent)
		{
		}

		// Token: 0x06004E19 RID: 19993 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E19")]
		[Address(RVA = "0x72E998", Offset = "0x72E998", VA = "0x72E998")]
		public void AddKeyFrames(int frame, FrameEvent[] frameEvents)
		{
		}

		// Token: 0x06004E1A RID: 19994 RVA: 0x00024780 File Offset: 0x00022980
		[Token(Token = "0x6004E1A")]
		[Address(RVA = "0x72808C", Offset = "0x72808C", VA = "0x72808C")]
		public bool OnUpdate(GameTime gameTime)
		{
			return default(bool);
		}

		// Token: 0x06004E1B RID: 19995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E1B")]
		[Address(RVA = "0x72CA8C", Offset = "0x72CA8C", VA = "0x72CA8C", Slot = "4")]
		public virtual void OnBegin()
		{
		}

		// Token: 0x06004E1C RID: 19996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E1C")]
		[Address(RVA = "0x72CDCC", Offset = "0x72CDCC", VA = "0x72CDCC", Slot = "5")]
		public virtual void OnEnd()
		{
		}

		// Token: 0x06004E1D RID: 19997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E1D")]
		[Address(RVA = "0x72E9EC", Offset = "0x72E9EC", VA = "0x72E9EC")]
		private static void EmptyFrameEvent(FrameEventData evt)
		{
		}

		// Token: 0x06004E1E RID: 19998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E1E")]
		[Address(RVA = "0x7298A0", Offset = "0x7298A0", VA = "0x7298A0")]
		public Film()
		{
		}

		// Token: 0x040092E3 RID: 37603
		[Token(Token = "0x40092E3")]
		[FieldOffset(Offset = "0x8")]
		private int _frame;

		// Token: 0x040092E4 RID: 37604
		[Token(Token = "0x40092E4")]
		[FieldOffset(Offset = "0xC")]
		private int _frameCount;

		// Token: 0x040092E5 RID: 37605
		[Token(Token = "0x40092E5")]
		[FieldOffset(Offset = "0x10")]
		private int _nextSequenceAppendTime;

		// Token: 0x040092E6 RID: 37606
		[Token(Token = "0x40092E6")]
		[FieldOffset(Offset = "0x14")]
		private bool _isActive;

		// Token: 0x040092E7 RID: 37607
		[Token(Token = "0x40092E7")]
		[FieldOffset(Offset = "0x18")]
		private List<Film.Sequence> _sequences;

		// Token: 0x02000916 RID: 2326
		[Token(Token = "0x2000916")]
		private class Sequence
		{
			// Token: 0x1700096E RID: 2414
			// (get) Token: 0x06004E1F RID: 19999 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700096E")]
			public FrameEvent Event
			{
				[Token(Token = "0x6004E1F")]
				[Address(RVA = "0x72E9F0", Offset = "0x72E9F0", VA = "0x72E9F0")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700096F RID: 2415
			// (get) Token: 0x06004E20 RID: 20000 RVA: 0x00024798 File Offset: 0x00022998
			[Token(Token = "0x1700096F")]
			public int Duration
			{
				[Token(Token = "0x6004E20")]
				[Address(RVA = "0x72E9F8", Offset = "0x72E9F8", VA = "0x72E9F8")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000970 RID: 2416
			// (get) Token: 0x06004E21 RID: 20001 RVA: 0x000247B0 File Offset: 0x000229B0
			[Token(Token = "0x17000970")]
			public int Start
			{
				[Token(Token = "0x6004E21")]
				[Address(RVA = "0x72EA00", Offset = "0x72EA00", VA = "0x72EA00")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06004E22 RID: 20002 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004E22")]
			[Address(RVA = "0x72E96C", Offset = "0x72E96C", VA = "0x72E96C")]
			public Sequence(FrameEvent frameEvent, int start, int duration)
			{
			}

			// Token: 0x040092E8 RID: 37608
			[Token(Token = "0x40092E8")]
			[FieldOffset(Offset = "0x8")]
			private FrameEvent _frameEvent;

			// Token: 0x040092E9 RID: 37609
			[Token(Token = "0x40092E9")]
			[FieldOffset(Offset = "0xC")]
			private int _duration;

			// Token: 0x040092EA RID: 37610
			[Token(Token = "0x40092EA")]
			[FieldOffset(Offset = "0x10")]
			private int _start;
		}
	}
}
