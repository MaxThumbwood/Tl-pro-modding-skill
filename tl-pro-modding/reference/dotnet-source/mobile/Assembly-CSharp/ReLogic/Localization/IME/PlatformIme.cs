using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace ReLogic.Localization.IME
{
	// Token: 0x02000DFA RID: 3578
	[Token(Token = "0x2000DFA")]
	public abstract class PlatformIme : FileAPI, GUIControllerItem
	{
		// Token: 0x17000B31 RID: 2865
		// (get) Token: 0x060068DA RID: 26842
		[Token(Token = "0x17000B31")]
		public abstract string CompositionString
		{
			[Token(Token = "0x60068DA")]
			get;
		}

		// Token: 0x17000B32 RID: 2866
		// (get) Token: 0x060068DB RID: 26843
		[Token(Token = "0x17000B32")]
		public abstract bool IsCandidateListVisible
		{
			[Token(Token = "0x60068DB")]
			get;
		}

		// Token: 0x17000B33 RID: 2867
		// (get) Token: 0x060068DC RID: 26844
		[Token(Token = "0x17000B33")]
		public abstract uint SelectedCandidate
		{
			[Token(Token = "0x60068DC")]
			get;
		}

		// Token: 0x17000B34 RID: 2868
		// (get) Token: 0x060068DD RID: 26845
		[Token(Token = "0x17000B34")]
		public abstract uint CandidateCount
		{
			[Token(Token = "0x60068DD")]
			get;
		}

		// Token: 0x17000B35 RID: 2869
		// (get) Token: 0x060068DE RID: 26846 RVA: 0x0002F940 File Offset: 0x0002DB40
		// (set) Token: 0x060068DF RID: 26847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B35")]
		public bool IsEnabled
		{
			[Token(Token = "0x60068DE")]
			[Address(RVA = "0xB83310", Offset = "0xB83310", VA = "0xB83310", Slot = "8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60068DF")]
			[Address(RVA = "0xB83318", Offset = "0xB83318", VA = "0xB83318")]
			private set
			{
			}
		}

		// Token: 0x060068E0 RID: 26848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068E0")]
		[Address(RVA = "0xB82EF0", Offset = "0xB82EF0", VA = "0xB82EF0")]
		protected PlatformIme()
		{
		}

		// Token: 0x060068E1 RID: 26849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068E1")]
		[Address(RVA = "0xB83320", Offset = "0xB83320", VA = "0xB83320", Slot = "12")]
		public void AddKeyListener(Action<char> listener)
		{
		}

		// Token: 0x060068E2 RID: 26850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068E2")]
		[Address(RVA = "0xB833DC", Offset = "0xB833DC", VA = "0xB833DC", Slot = "13")]
		public void RemoveKeyListener(Action<char> listener)
		{
		}

		// Token: 0x060068E3 RID: 26851 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068E3")]
		[Address(RVA = "0xB82FA0", Offset = "0xB82FA0", VA = "0xB82FA0")]
		protected void OnKeyPress(char character)
		{
		}

		// Token: 0x060068E4 RID: 26852
		[Token(Token = "0x60068E4")]
		public abstract string GetCandidate(uint index);

		// Token: 0x060068E5 RID: 26853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068E5")]
		[Address(RVA = "0xB83448", Offset = "0xB83448", VA = "0xB83448", Slot = "10")]
		public void Enable()
		{
		}

		// Token: 0x060068E6 RID: 26854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068E6")]
		[Address(RVA = "0xB83248", Offset = "0xB83248", VA = "0xB83248", Slot = "11")]
		public void Disable()
		{
		}

		// Token: 0x060068E7 RID: 26855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068E7")]
		[Address(RVA = "0xB8347C", Offset = "0xB8347C", VA = "0xB8347C", Slot = "20")]
		protected virtual void OnEnable()
		{
		}

		// Token: 0x060068E8 RID: 26856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068E8")]
		[Address(RVA = "0xB83480", Offset = "0xB83480", VA = "0xB83480", Slot = "21")]
		protected virtual void OnDisable()
		{
		}

		// Token: 0x060068E9 RID: 26857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068E9")]
		[Address(RVA = "0xB83484", Offset = "0xB83484", VA = "0xB83484", Slot = "22")]
		protected virtual void Dispose(bool disposing)
		{
		}

		// Token: 0x060068EA RID: 26858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068EA")]
		[Address(RVA = "0xB83498", Offset = "0xB83498", VA = "0xB83498", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x060068EB RID: 26859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068EB")]
		[Address(RVA = "0xB83538", Offset = "0xB83538", VA = "0xB83538", Slot = "14")]
		public void Dispose()
		{
		}

		// Token: 0x0400A515 RID: 42261
		[Token(Token = "0x400A515")]
		[FieldOffset(Offset = "0x8")]
		private bool <IsEnabled>k__BackingField;

		// Token: 0x0400A516 RID: 42262
		[Token(Token = "0x400A516")]
		[FieldOffset(Offset = "0xC")]
		private readonly List<Action<char>> _keyPressCallbacks;

		// Token: 0x0400A517 RID: 42263
		[Token(Token = "0x400A517")]
		[FieldOffset(Offset = "0x10")]
		private bool _disposedValue;
	}
}
